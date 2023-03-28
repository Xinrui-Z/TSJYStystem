using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSJYSystem
{
    public partial class BorrowM : Form
    {
        public BorrowM()
        {
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
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
            btnBConfirm.Visible = false;
            btnBorrow.Visible = true;
            string sqlStr = "SELECT * FROM BorrowReturn";
            DataBinding(sqlStr);
        }

        private void DataBinding(string sqlStr)
        {
            DataSet ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgvBorrow.DataSource = ds.Tables[0];
                dgvBorrow.Columns[0].HeaderText = "图书编号";
                dgvBorrow.Columns[0].Width = 195;
                dgvBorrow.Columns[1].HeaderText = "读者证号";
                dgvBorrow.Columns[1].Width = 195;
                dgvBorrow.Columns[2].HeaderText = "借书时间";
                dgvBorrow.Columns[2].Width = 195;
                dgvBorrow.Columns[3].HeaderText = "归还时间";
                dgvBorrow.Columns[3].Width = 195;
                dgvBorrow.Columns[4].HeaderText = "应还时间";
                dgvBorrow.Columns[4].Width = 195;
                dgvBorrow.Columns[5].HeaderText = "当前状态";
                dgvBorrow.Columns[5].Width = 185;

            }
        }

        private void ObjClose()
        {
            txtId.Enabled = false;
            txtNo.Enabled = false;
            txtBtime.Enabled = false;
            txtRtime.Enabled = false;
            txtState.Enabled = false;
            txtEtime.Enabled = false;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT r.ReaderName, r.ReaderTypeID, t.ReaderTypeDays FROM Reader r INNER JOIN ReaderType t ON r.ReaderTypeID = t.ReaderTypeID WHERE r.ReaderID=@ReaderID";
                using (SqlConnection conn = new SqlConnection(CDataBase.connstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReaderID", txtId.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet != null && dataSet.Tables[0].Rows.Count > 0)
                        {
                            string readerTypeId = dataSet.Tables[0].Rows[0]["ReaderTypeID"].ToString().Trim();
                            lblRname.Text = dataSet.Tables[0].Rows[0]["ReaderName"].ToString().Trim();
                            lblRType.Text = readerTypeId;

                            int borrowPeriod;
                            if (int.TryParse(dataSet.Tables[0].Rows[0]["ReaderTypeDays"].ToString(), out borrowPeriod))
                            {
                                txtEtime.Text = DateTime.Now.AddDays(borrowPeriod).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                txtEtime.Text = "";
                            }
                        }
                        else
                        {
                            lblRname.Text = "";
                            lblRType.Text = "";
                            txtEtime.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT BookName FROM Book WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(sql, CDataBase.conn);
            command.Parameters.AddWithValue("@BookID", txtNo.Text);
            DataSet dataSet = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    lblBname.Text = dataSet.Tables[0].Rows[0]["BookName"].ToString().Trim();
                }
                else
                {
                    lblBname.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtId.Text = "";
            txtNo.Text = "";
            txtRtime.Text = "";
            txtState.Text = "";
            txtEtime.Text = "";
            lblRType.Text = "";
            txtBtime.Text = DateTime.Now.ToString();
            txtBtime.Enabled = false;
            txtId.Focus();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Reset();
            ObjOpen();
            txtState.Text = "未借出";
            txtState.Enabled = false;
            btnBorrow.Visible = false;
            btnBConfirm.Visible = true;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            txtRtime.Enabled = false;
            txtEtime.Enabled = false;
            cmbSelect.SelectedIndex = 0;
            cmbSelect.Enabled = false;
            txtBtime.Text = DateTime.Now.ToString("yyyy-MM-dd");          
        }

        private void ObjOpen()
        {
            txtId.Enabled = true;
            txtNo.Enabled = true;
            txtBtime.Enabled = true;
            txtRtime.Enabled = true;
            txtState.Enabled = true;
            txtEtime.Enabled = true;
        }

        private DateTime GetExperiDate()
        {
            string sqlStr = "SELECT * FROM Reader WHERE ReaderID='" + txtId.Text + "'";
            DataSet dataSet = CDataBase.GetDataFromDB(sqlStr);
            lblRType.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString().Trim();
            string sqlReaderTypeID = "SELECT * FROM ReaderType WHERE ReaderTypeID='" + lblRType.Text + "'";
            DataSet dataSet1 = CDataBase.GetDataFromDB(sqlReaderTypeID);
            string strReaderTypeDays = dataSet1.Tables[0].Rows[0]["ReaderTypeDays"].ToString();
            int days = Convert.ToInt32(strReaderTypeDays);

            DateTime borrowDate = DateTime.Now;
            DateTime expireDate = borrowDate.AddDays(days);
            return expireDate;
        }

        private void btnBConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //读者证号检查
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("请输入读者证号！", "提示");
                    txtId.Focus();
                    return;
                }

                string sqlStrReader = "SELECT * FROM Reader WHERE ReaderID='" + txtId.Text + "'";
                DataSet dataSetID = CDataBase.GetDataFromDB(sqlStrReader);
                if (dataSetID.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("读者证号不存在！", "提示");
                    txtId.Focus();
                    return;
                }

                //获取读者类型
                string sqlStr = "SELECT * FROM Reader WHERE ReaderID='" + txtId.Text + "'";
                DataSet dataSet = CDataBase.GetDataFromDB(sqlStr);
                lblRType.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString().Trim();
                string sqlReaderType = "SELECT * FROM ReaderType WHERE ReaderTypeID='" + lblRType.Text + "'";
                DataSet Reader = CDataBase.GetDataFromDB(sqlReaderType);

                // 检查是否已借阅该书籍
                string sqlStrCheckBorrowed = "SELECT * FROM BorrowReturn WHERE ReaderID='" + txtId.Text + "' AND BookID='" + txtNo.Text + "' AND (State='未归还' OR State='逾期未还')";
                string max = Reader.Tables[0].Rows[0].ItemArray[2].ToString().Trim();
                string now = dataSet.Tables[0].Rows[0].ItemArray[6].ToString().Trim();
                int maxnum = Convert.ToInt32(max);
                int nownum = Convert.ToInt32(now);

                if (CDataBase.GetDataFromDB(sqlStrCheckBorrowed) != null)
                {
                    MessageBox.Show("该读者已经借阅过该书籍，不能重复借阅!", "提示");
                    txtNo.Focus();
                    return;
                }

                //检查是否达到最大借书数量
                if (maxnum.CompareTo(nownum) <= 0)
                {
                    MessageBox.Show("已达到最大借书数量，请先归还书籍!", "提示");
                    txtNo.Focus();
                    return;
                }

                // 检查输入的书籍编号是否存在
                string sqlStrCheckBook = $"SELECT * FROM book WHERE  BookID='" + txtNo.Text + "'";
                DataSet bookData = CDataBase.GetDataFromDB(sqlStrCheckBook);
                if (bookData.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("此书籍编号不存在！", "提示");
                    return;
                }

                // 检查书籍是否有可借阅数量
                int bookNum = Convert.ToInt32(bookData.Tables[0].Rows[0]["BookNum"]);
                if (bookNum <= 0)
                {
                    MessageBox.Show("此书籍可借阅数量为0，借书失败！", "提示");
                    return;
                }

                //获取借阅和应还时间
                string btime = DateTime.Now.ToString("yyyy-MM-dd");
                string mtime;
                int readerTypeDays;
                CPublic.userInfo[0] = lblRType.Text.Trim();
                if (Reader.Tables[0].Rows.Count > 0)
                {
                    readerTypeDays = Convert.ToInt32(Reader.Tables[0].Rows[0]["ReaderTypeDays"]);
                    mtime = DateTime.Now.AddDays(readerTypeDays).ToString("yyyy-MM-dd");
                }
                else
                {
                    mtime = DateTime.Now.AddMonths(5).ToString("yyyy-MM-dd");
                }
                CPublic.userInfo[0] = lblRType.Text.Trim();
                string sqlReaderTypeID = "SELECT * FROM ReaderType WHERE ReaderTypeID='" + lblRType.Text + "'";
                DataSet dataSet1 = CDataBase.GetDataFromDB(sqlReaderTypeID);
                string strReaderTypeDays = dataSet1.Tables[0].Rows[0]["ReaderTypeDays"].ToString();
                int days = Convert.ToInt32(strReaderTypeDays);

                //更新借阅信息
                DateTime borrowDate = DateTime.Now;
                DateTime expireDate = borrowDate.AddDays(days);

                string BookNumSql = "UPDATE Book SET BookNum=BookNum-1 WHERE BookID='" + txtNo.Text + "'";
                string BookQuantitySql = "UPDATE Reader SET ReaderBookQuantity=ReaderBookQuantity+1 WHERE ReaderID='" + txtId.Text + "'";

                string sqlstr = "INSERT INTO BorrowReturn(ReaderID,BookID,BorrowDate,Exprire,State) VALUES('" + txtId.Text + "','" + txtNo.Text + "','" + borrowDate.ToString("yyyy-MM-dd") + "','" + expireDate.ToString("yyyy-MM-dd") + "','未归还')";
                try
                {
                    //执行SQL语句
                    CDataBase.UpdateDB(BookNumSql);
                    CDataBase.UpdateDB(BookQuantitySql);
                    CDataBase.UpdateDB(sqlstr);
                    MessageBox.Show("借阅成功！", "提示");
                }
                catch(Exception ex)
                {

                }

                RefreshData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
        }

         private void Cancel()
        {
            btnBorrow.Visible = true;
            btnBConfirm.Visible = false;
            cmbSelect.Enabled = true;
            cmbSelect.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjClose();
            Reset();
            Cancel();
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
            if(cmbSelect.Text=="借书时间" || cmbSelect.Text == "归还时间" || cmbSelect.Text == "应还时间")
            {
                lblTime.Visible = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //字典定义
            Dictionary<int, string> columnNames = new Dictionary<int, string>()
            {
                { 1, "BookID" },
                { 2, "ReaderID" },
                { 3, "CONVERT(varchar(100), BorrowDate, 23)" },
                { 4, "CONVERT(varchar(100), ReturnDate, 23)" },
                { 5, "CONVERT(varchar(100), Exprire, 23)" },
                { 6, "State" }
            };

            if (cmbSelect.SelectedIndex == 0)
            {
                MessageBox.Show("请选择查询条件", "提示");
                return;
            }

            string columnName = columnNames[cmbSelect.SelectedIndex];
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

                dgvBorrow.DataSource = ds.Tables[0];

                string[] columnHeaders = { "图书编号", "读者证号", "借书时间", "归还时间", "应还时间", "状态" };
                int[] columnWidths = { 195, 195, 195, 195, 195, 195 };


                for (int i = 0; i < columnHeaders.Length; i++)
                {
                    dgvBorrow.Columns[i].HeaderText = columnHeaders[i];
                    dgvBorrow.Columns[i].Width = columnWidths[i];
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
            Reset();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtId.Text = dgvBorrow.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNo.Text = dgvBorrow.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBtime.Text = dgvBorrow.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEtime.Text = dgvBorrow.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtState.Text = dgvBorrow.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtRtime.Text = dgvBorrow.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void Borrow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }
    }
}
