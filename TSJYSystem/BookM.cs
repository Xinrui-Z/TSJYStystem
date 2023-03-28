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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TSJYSystem
{
    public partial class BookM : Form
    {
        public BookM()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                this.cmbSelect.SelectedIndex = 0;
                ObjOpen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshData()
        {
         //   ObjClose();
            string sqlStr = "SELECT * FROM Book order by cast(BookID as int) ASC,left(BookTypeID,1) ASC";
            DataBindings(sqlStr);
        }

        private void DataBindings(string sqlStr)
        {
            if (CDataBase.conn.State != ConnectionState.Open)
            {
                CDataBase.conn.Open();
            }
            SqlCommand com = new SqlCommand(sqlStr, CDataBase.conn);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            CDataBase.conn.Close();
            if (ds != null)
            {
                dgvBook.DataSource = ds.Tables[0];
                string[] headers = { "图书编号", "类别编号", "出版社编号", "工作人员工号", "图书名称", "图书作者", "图书价格", "出版时间", "ISBN", "馆藏地", "在馆数量" };
                int[] widths = { 105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 105 };

                for (int i = 0; i < headers.Length; i++)
                {
                    dgvBook.Columns[i].HeaderText = headers[i];
                    dgvBook.Columns[i].Width = widths[i];
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtPrice.Text = "";
            txtNo.Text = "";
            txtAuthor.Text = "";
            txtPos.Text = "";
            txtNum.Text = "";
            txtPressDa.Text = "";
            txtISBN.Text = "";
            txtName.Text = "";
            txtNum.Text = "";
            txtSelect.Text = "";
            txtPressID.Text = "";
            txtTypeID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            ObjOpen();
            lblNo.Visible = true;
            txtNo.Visible = true;
            btnAdd.Visible = false;
            btnAddConfirm.Visible = true;
            btnUpdate.Enabled = false;
            btnUpdateConfirm.Visible = false;
            btnDel.Enabled = false;
            btnCancel.Visible = true;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            btnSelect.Enabled = false;
            txtNo.Enabled = true;
            txtTypeID.Enabled = true;
            txtPressID.Enabled = true;

        }

        private void ObjOpen()
        {
            txtNo.Enabled = true;
            txtAuthor.Enabled = true;
            txtPos.Enabled = true;
            txtPressDa.Enabled = true;
            txtNum.Enabled = true;
            txtISBN.Enabled = true;
            txtPrice.Enabled = true;
            txtName.Enabled = true;
            txtNum.Enabled = true;
            txtTypeID.Enabled=true;
            txtPressID.Enabled=true;
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            // 构建检查空值的字典
            Dictionary<TextBox, string> emptyCheckDict = new Dictionary<TextBox, string>()
            {
                { txtNo, "图书编号不能为空!" },
                { txtName, "图书名称不能为空!" },
                { txtAuthor, "图书作者不能为空!" },
                { txtPrice, "图书价格不能为空!" },
                { txtPos, "馆藏地不能为空!" },
                { txtPressDa, "出版时间不能为空!" },
                { txtNum, "在馆数量不能为空!" },
                { txtISBN, "ISBN不能为空!" },
                { txtTypeID, "类别编号不能为空!" },
                { txtPressID, "出版社编号不能为空!" }
            };

            // 遍历字典，检查空值
            foreach (var pair in emptyCheckDict)
            {
                if (string.IsNullOrWhiteSpace(pair.Key.Text))
                {
                    MessageBox.Show(pair.Value, "提示");
                    pair.Key.Focus();
                    return;
                }
            }

            string checkBkType = "SELECT COUNT(*) FROM BookType WHERE BookTypeID = @BookTypeID";
            string addBkType = "INSERT INTO BookType (BookTypeID) VALUES (@BookTypeID)";
            string addBk = "INSERT INTO Book (BookID, bookauthor, QorkerID, bookname, bookISBN, BookPosition, BookTypeID, BookPrice, BookNum, PressID, BookPressDate) VALUES (@BookID, @BookAuthor, @WorkerID, @BookName, @BookISBN, @BookPosition, @BookTypeID, @BookPrice, @BookNum, @PressID, @BookPressDate)";
            string checkBk = "SELECT COUNT(*) FROM Book WHERE BookName = @BookName AND BookAuthor = @BookAuthor";

            try
            {
                using (SqlConnection conn = new SqlConnection(CDataBase.connstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(checkBkType, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookTypeID", txtTypeID.Text);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // 如果BookType表中不存在该BookTypeID，则向BookType表中添加该类型
                        if (count == 0)
                        {
                            using (SqlCommand addTypeCmd = new SqlCommand(addBkType, conn))
                            {
                                addTypeCmd.Parameters.AddWithValue("@BookTypeID", txtTypeID.Text);
                                addTypeCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 检查 Book 是否存在，不存在则插入
                    using (SqlCommand cmd = new SqlCommand(checkBk, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookName", txtName.Text);
                        cmd.Parameters.AddWithValue("@BookAuthor", txtAuthor.Text);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 0)
                        {
                            using (SqlCommand addBkCmd = new SqlCommand(addBk, conn))
                            {
                                addBkCmd.Parameters.AddWithValue("@BookID", txtNo.Text);
                                addBkCmd.Parameters.AddWithValue("@BookAuthor", txtAuthor.Text);
                                addBkCmd.Parameters.AddWithValue("@WorkerID", CPublic.userInfo[1]);
                                addBkCmd.Parameters.AddWithValue("@BookName", txtName.Text);
                                addBkCmd.Parameters.AddWithValue("@BookISBN", txtISBN.Text);
                                addBkCmd.Parameters.AddWithValue("@BookPosition", txtPos.Text);
                                addBkCmd.Parameters.AddWithValue("@BookTypeID", txtTypeID.Text);
                                addBkCmd.Parameters.AddWithValue("@BookPrice", txtPrice.Text);
                                addBkCmd.Parameters.AddWithValue("@BookNum", txtNum.Text);
                                addBkCmd.Parameters.AddWithValue("@PressID", txtPressID.Text);
                                addBkCmd.Parameters.AddWithValue("@BookPressDate", txtPressDa.Text);
                                addBkCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("操作成功!", "提示");
                        }
                        else
                        {
                            MessageBox.Show("该图书信息已存在，请勿重复添加！", "提示");
                        }
                    }

                    RefreshData();
                    Cancel();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
            }
        }

        private void Cancel()
        {
            lblNo.Visible = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDel.Enabled = true;
            btnUpdate.Enabled = true;
            btnAddConfirm.Visible = false;
            btnUpdateConfirm.Visible = false;
            btnCancel.Visible = false;
            cmbSelect.Enabled = true;
            cmbSelect.SelectedIndex = 0;
        }

        private void DataUpdate(string sql, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand com = new SqlCommand(sql, CDataBase.conn);
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    com.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
                CDataBase.conn.Open();
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    return;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNo.Text.Trim() == "")
            {
                MessageBox.Show("请选中你要修改的图书信息!", "提示");
                return;
            }
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnDel.Visible = false;
            btnCancel.Visible = true;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            btnSelect.Enabled = false;
            txtNo.Enabled = false;
        }

        private void BkStaCheck()
        {
            // 获取要删除的图书 ID
            int BookID = Convert.ToInt32(txtNo.Text);

            // 检查是否存在未归还的借书记录
            string checkSql = "SELECT COUNT(*) FROM BorrowReturn WHERE BookID=@BookID and State='已借出'";
            if (CDataBase.conn.State != ConnectionState.Open)
            {
                CDataBase.conn.Open();
            }
            SqlCommand checkCommand = new SqlCommand(checkSql, CDataBase.conn);
            checkCommand.Parameters.AddWithValue("@BookID", BookID);
            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

            // 如果存在未归还的借书记录，提示用户无法删除该记录
            if (count > 0)
            {
                MessageBox.Show("无法删除该记录，因为存在未归还的借书记录!","提示");
            }
            // 否则，删除该记录
            else
            {
                // 删除BorrowReturn表中所有BookID为要删除的Book的ID的记录
                string deleteBorrowReturnSql = "DELETE FROM BorrowReturn WHERE BookID=@BookID";
                SqlCommand deleteBorrowReturnCommand = new SqlCommand(deleteBorrowReturnSql, CDataBase.conn);
                deleteBorrowReturnCommand.Parameters.AddWithValue("@BookID", BookID);
                deleteBorrowReturnCommand.ExecuteNonQuery();

                // 删除Book表中相应的记录
                string deleteBookSql = "DELETE FROM Book WHERE BookID=@BookID";
                SqlCommand deleteBookCommand = new SqlCommand(deleteBookSql, CDataBase.conn);
                deleteBookCommand.Parameters.AddWithValue("@BookID", BookID);
                deleteBookCommand.ExecuteNonQuery();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtNo.Text.Trim() =="")
            {
                MessageBox.Show("请选择要删除的书籍!", "提示");
            }
            else
            {
                DialogResult dr = MessageBox.Show("是否删除选中的书籍信息？", "确认", MessageBoxButtons.OKCancel);
                BkStaCheck();
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("删除成功!", "提示");
                    RefreshData();
                    Cancel();
                    Reset();
                }
            }
          }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            Cancel();
        }

        private void btnUpdateConfirm_Click_1(object sender, EventArgs e)
        {
            // 定义字典存储各个控件名称对应的错误提示信息
            Dictionary<string, string> errorMessage = new Dictionary<string, string>()
            {
                { "txtNo", "编号不能为空!" },
                { "txtName", "图书名称不能为空!" },
                { "txtAuthor", "图书作者不能为空!" },
                { "txtPrice", "图书价格不能为空!" },
                { "txtPos", "馆藏地不能为空!" },
                { "txtPressDa", "出版时间不能为空!" },
                { "txtNum", "在馆数量不能为空!" },
                { "txtISBN", "ISBN不能为空!" },
                { "txtTypeID", "类别编号不能为空!" },
                { "lblPreID", "出版社编号不能为空!" }
            };

            // 检查是否存在空值
            foreach (Control c in Controls)
            {
                if (c is TextBox && c.Text.Trim() == "")
                {
                    MessageBox.Show(errorMessage[c.Name], "提示");
                    c.Focus();
                    return;
                }
            }

            // 合法性检验
            string selectSql = "SELECT * FROM Book WHERE BookID=@BookID";
            Dictionary<string, object> selectParams = new Dictionary<string, object>();
            selectParams.Add("@BookID", txtNo.Text.Trim());
            if (CDataBase.GetDataFromDB(selectSql, selectParams) == null)
            {
                MessageBox.Show("此编号不存在!", "提示");
                txtNo.Focus();
                return;
            }

            // 更新图书信息
            string updateSql = "UPDATE Book SET BookAuthor=@author, BookName=@name, BookNum=@num, Workerid=@QorkerID, BookISBN=@ISBN, BookPosition=@Position, BookTypeID=@TypeID, BookPrice=@Price, PressID=@PressID, BookPressDate=@pressdate WHERE BookID=@BookID";
            Dictionary<string, object> updateParams = new Dictionary<string, object>();
            updateParams.Add("@author", txtAuthor.Text);
            updateParams.Add("@name", txtName.Text);
            updateParams.Add("@num", txtNum.Text);
            updateParams.Add("@QorkerID", CPublic.userInfo[1]);
            updateParams.Add("@ISBN", txtISBN.Text);
            updateParams.Add("@Position", txtPos.Text);
            updateParams.Add("@TypeID", txtTypeID.Text);
            updateParams.Add("@Price", txtPrice.Text);
            updateParams.Add("@PressID", txtPressID.Text);
            updateParams.Add("@pressdate", txtPressDa.Text);
            updateParams.Add("@BookID", txtNo.Text.Trim());

            // 更新数据
            MessageBox.Show("操作成功!", "提示");
         //   ObjClose();
            DataUpdate(updateSql, updateParams);
            RefreshData();
            Cancel();
            Reset();
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
            if (cmbSelect.Text == "出版时间")
            {
                lblTime.Visible = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string searchText = txtSelect.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show(string.Format("请输入需要查询的“{0}”", cmbSelect.Text.Trim()), "提示");
                return;
            }

            // 列名和列头名称的字典
            Dictionary<int, string> columnDict = new Dictionary<int, string>();
            columnDict.Add(1, "BookID");
            columnDict.Add(2, "BookTypeID");
            columnDict.Add(3, "PressID");
            columnDict.Add(4, "WorkerID");
            columnDict.Add(5, "BookName");
            columnDict.Add(6, "BookAuthor");
            columnDict.Add(7, "BookPrice");
            columnDict.Add(8, "BookPressDate");
            columnDict.Add(9, "BookISBN");
            columnDict.Add(10, "BookPosition");
            columnDict.Add(11, "BookNum");

            // SQL 查询字符串和查询参数名称的字典
            Dictionary<string, string> sqlDict = new Dictionary<string, string>();
            sqlDict.Add("Book", "SELECT * FROM Book WHERE [{0}] = @searchText");

            string columnName;
            if (!columnDict.TryGetValue(cmbSelect.SelectedIndex, out columnName))
            {
                MessageBox.Show("请选择查询条件", "提示");
                return;
            }

            string sql = string.Format(sqlDict["Book"], columnName);
            try
            {
                SqlCommand comm = new SqlCommand(sql, CDataBase.conn);
                comm.Parameters.AddWithValue("@searchText", searchText);

                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("没有符合条件的图书记录", "提示");
                    return;
                }

                // 设置列头名称
                Dictionary<string, string> headerDict = new Dictionary<string, string>();
                headerDict.Add("BookID", "图书编号");
                headerDict.Add("BookTypeID", "类别编号");
                headerDict.Add("PressID", "出版社编号");
                headerDict.Add("WorkerID", "工作人员工号");
                headerDict.Add("BookName", "图书名称");
                headerDict.Add("BookAuthor", "图书作者");
                headerDict.Add("BookPrice", "图书价格");
                headerDict.Add("BookPressDate", "出版时间");
                headerDict.Add("BookISBN", "ISBN");
                headerDict.Add("BookPosition", "馆藏地");
                headerDict.Add("BookNum", "在馆数量");

                foreach (DataColumn column in dt.Columns)
                {
                    string headerText;
                    if (headerDict.TryGetValue(column.ColumnName, out headerText))
                    {
                        dgvBook.Columns[column.ColumnName].HeaderText = headerText;
                    }
                }

                dgvBook.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ObjOpen();
            txtNo.Enabled = true;
            RefreshData();
        }

        private void btnRetren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtNo.Text = dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTypeID.Text = dgvBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAuthor.Text = dgvBook.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPrice.Text = dgvBook.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPressDa.Text = dgvBook.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtISBN.Text = dgvBook.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtPos.Text = dgvBook.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtNum.Text = dgvBook.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtPressID.Text = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Book WHERE BookID='" + txtNo.Text + "'";
            DataSet ds = CDataBase.GetDataFromDB(sql);
            if (ds != null)
            {
                txtNo.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim();
                txtTypeID.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                txtName.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString().Trim();
                txtAuthor.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString().Trim();
                txtPrice.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString().Trim();
                txtPressDa.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString().Trim();
                txtISBN.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString().Trim();
                txtPos.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString().Trim();
                txtNum.Text = ds.Tables[0].Rows[0].ItemArray[10].ToString().Trim();
                txtPressID.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();

            }
            else
            {
                txtAuthor.Text = "";
                txtPos.Text = "";
                txtPressDa.Text = "";
                txtNum.Text = "";
                txtPrice.Text = "";
                txtISBN.Text = "";
                txtName.Text = "";
                txtNum.Text = "";
                txtPressID.Text = "";
                txtTypeID.Text = "";
                lblPressName.Text = "";
            }
        }

        private void txtPressID_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM press WHERE PressID='" + txtPressID.Text + "'";
            DataSet dataSet = CDataBase.GetDataFromDB(sql);
            if (dataSet != null)
            {
                lblPressName.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                lblPressName.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
            }
        }
    }
}




