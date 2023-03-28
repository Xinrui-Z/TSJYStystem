using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TSJYSystem
{
    public partial class ReturnM : Form
    {
        public ReturnM()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                this.cmbSelect.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshData()
        {
            // 更新逾期未还信息
            UpdateOverdueRecords();

            string sqlStr = "SELECT * FROM BorrowReturn ORDER BY BookID ASC";
            DataBinding(sqlStr);
        }

        private void UpdateOverdueRecords()
        {
            try
            {
                string selectSql = "SELECT * FROM BorrowReturn";
                DataSet ds = CDataBase.GetDataFromDB(selectSql, null);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string bookID = row["BookID"].ToString().Trim();
                    string readerID = row["ReaderID"].ToString().Trim();
                    DateTime returnDate = DateTime.Now;
                    DateTime expireDate = Convert.ToDateTime(row["Exprire"].ToString());

                    if (returnDate > expireDate && row["State"].ToString().Trim() != "逾期归还" && row["State"].ToString().Trim() == "未归还")
                    {
                        // 检查读者是否借书
                        string selectReaderSql = "SELECT ReaderBookQuantity FROM Reader WHERE ReaderID = @ReaderID";
                        Dictionary<string, object> selectReaderParams = new Dictionary<string, object>
                        {
                            { "@ReaderID", readerID }
                        };

                        DataSet readerDs = CDataBase.GetDataFromDB(selectReaderSql, selectReaderParams);
                        int readerBookQuantity = Convert.ToInt32(readerDs.Tables[0].Rows[0]["ReaderBookQuantity"]);

                        if (readerBookQuantity > 0)
                        {
                            string updateSql = "UPDATE BorrowReturn SET State='逾期未还' WHERE BookID=@BookID AND ReaderID=@ReaderID AND State='未归还'";
                            Dictionary<string, object> updateParams = new Dictionary<string, object>
                            {
                                { "@BookID", bookID },
                                { "@ReaderID", readerID }
                            };
                            CDataBase.UpdateDB(updateSql, updateParams);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示");
            }
        }

        private void DataBinding(string sqlStr)
        {
            DataSet ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgvReturn.DataSource = ds.Tables[0];
                string[,] columns = {
                {"图书编号", "192"},
                {"读者证号", "192"},
                {"借书时间", "192"},
                {"还书时间", "192"},
                {"应还时间", "192"},
                {"状态", "192"}
            };

                for (int i = 0; i < columns.GetLength(0); i++)
                {
                    dgvReturn.Columns[i].HeaderText = columns[i, 0];
                    dgvReturn.Columns[i].Width = int.Parse(columns[i, 1]);
                }
            }
        }

        private void StateChange()
        {
            if (cmbSelect.Text == "查询条件")
            {
                txtSelect.Text = "";
                txtSelect.Enabled = false;
                btnSelect.Enabled = true;
            }
            else
            {
                txtSelect.Text = "";
                txtSelect.Enabled = true;
                btnSelect.Enabled = true;
            }
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateChange();
            if (cmbSelect.Text == "借书时间" || cmbSelect.Text == "归还时间" || cmbSelect.Text == "应还时间")
            {
                lblTime.Visible = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Dictionary<int, string[]> columns = new Dictionary<int, string[]>
            {
                {1, new string[]{"BookID", "图书编号", "192"}},
                {2, new string[]{"ReaderID", "读者证号", "192"}},
                {3, new string[]{"CONVERT(varchar(100), BorrowDate, 23)", "借书时间", "192"}},
                {4, new string[]{"CONVERT(varchar(100), ReturnDate, 23)", "还书时间", "192"}},
                {5, new string[]{"CONVERT(varchar(100), Exprire, 23)", "应还时间", "192"}},
                {6, new string[]{"State", "状态", "192"}}
            };

            if (cmbSelect.SelectedIndex < 1 || cmbSelect.SelectedIndex > columns.Count)
            {
                MessageBox.Show("请选择查询条件", "提示");
                return;
            }

            string columnName = columns[cmbSelect.SelectedIndex][0];
            string headerText;
            int width;

            try
            {
                headerText = columns[cmbSelect.SelectedIndex][1];
                width = int.Parse(columns[cmbSelect.SelectedIndex][2]);
            }
            catch (Exception)
            {
                headerText = "";
                width = 0;
            }

            string sql = "SELECT * FROM BorrowReturn WHERE " + columnName + " LIKE @txtSelect";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, CDataBase.conn);
                cmd.Parameters.AddWithValue("@txtSelect", "%" + txtSelect.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("查询无果", "提示");
                    return;
                }
                else
                {
                    dgvReturn.DataSource = ds.Tables[0];

                    dgvReturn.Columns[0].HeaderText = headerText;
                    dgvReturn.Columns[0].Width = width;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReturn.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请选中需要还书的借书记录！", "提示");
                    return;
                }

                string BookID = dgvReturn.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string ReaderID = dgvReturn.SelectedRows[0].Cells[1].Value.ToString().Trim();

                string selectSql = "SELECT * FROM BorrowReturn WHERE ReaderID = @ReaderID AND BookID = @BookID";
                Dictionary<string, object> selectParams = new Dictionary<string, object>
                {
                    {  "@ReaderID", ReaderID},
                    { "@BookID", BookID }
                };

                DataSet ds = CDataBase.GetDataFromDB(selectSql, selectParams);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("选中的借书记录不存在，请刷新借阅信息", "提示");
                    return;
                }

                string readerID = ds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                string state = ds.Tables[0].Rows[0].ItemArray[5].ToString().Trim();

                if (state == "已归还" || state == "逾期归还")
                {
                    MessageBox.Show("已归还，请选中未归还的借书记录！", "提示");
                    return;
                }

                DateTime returnDate = DateTime.Now;
                DateTime expireDate = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[4].ToString().Trim());

                if (DateTime.Compare(returnDate, expireDate) > 0)
                {
                    // 逾期还书，进行罚款操作
                    MessageBox.Show("逾期还书，请通知读者缴纳罚款！", "提示");

                    string updateSql = "UPDATE BorrowReturn SET State = @State, ReturnDate = @ReturnDate WHERE ReaderID = @ReaderID AND BookID = @BookID AND (State = '逾期未还' OR State = '未归还')";
                    Dictionary<string, object> updateParams = new Dictionary<string, object>
                {
                    { "@State", "逾期归还" },
                    { "@ReturnDate", returnDate },
                    { "@ReaderID", ReaderID },
                    { "@BookID", BookID }
                };

                    CDataBase.UpdateDB(updateSql, updateParams);
                }
                else
                {
                    MessageBox.Show("还书成功！", "提示");

                    // 更新图书信息
                    string updateBookSql = "UPDATE Book SET BookNum = BookNum + 1 WHERE BookID = @BookID";
                    Dictionary<string, object> updateBookParams = new Dictionary<string, object>
                {
                    {  "@BookID", BookID }
                };

                    CDataBase.UpdateDB(updateBookSql, updateBookParams);

                    // 更新读者借阅次数
                    string updateReaderSql = "UPDATE Reader SET ReaderBookQuantity = ReaderBookQuantity - 1 WHERE ReaderID = @ReaderID";
                    Dictionary<string, object> updateReaderParams = new Dictionary<string, object>
                {
                    {"@ReaderID", readerID  }
                };
                    CDataBase.UpdateDB(updateReaderSql, updateReaderParams);

                    // 更新借书记录状态
                    string updateBorrowReturnSql = "UPDATE BorrowReturn SET State = '已归还', ReturnDate = @ReturnDate WHERE ReaderID = @ReaderID AND BookID = @BookID AND State = '未归还'";
                    Dictionary<string, object> updateBorrowReturnParams = new Dictionary<string, object>
                {
                    { "@ReturnDate", returnDate },
                    { "@ReaderID", ReaderID },
                    { "@BookID", BookID }
                };

                    CDataBase.UpdateDB(updateBorrowReturnSql, updateBorrowReturnParams);
                }

                RefreshData();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"还书出现异常：{ex.Message}", "提示");
            }

        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&& e.ColumnIndex>=0)
            {
                txtReturn.Text = dgvReturn.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblReaderID.Text = dgvReturn.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
