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

namespace TSJYSystem
{
    public partial class MainReader : Form
    {
        public MainReader()
        {
            InitializeComponent();
            if(CPublic.userInfo[0] == "工作人员")
            {
                btnRecord.Visible = false;
                lblBorrow.Visible = false;
                txtBorrow.Visible=false;
                btnBorrow.Visible = false;
            }
            else
            {
                btnRecord.Visible = true;
                lblBorrow.Visible = true;
                txtBorrow.Visible = true;
            }
        }

        private void MainR_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbSelect.SelectedIndex = 0;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Text = "欢迎登录--" + CPublic.userInfo[3];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.SelectedIndex == 0)
            {
                txtSelect.Text = "";
                txtSelect.Enabled = false;
            }
            else
            {
                txtSelect.Text = "";
                txtSelect.Enabled = true;
                txtSelect.Focus();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                if (txtSelect.Text.Trim() == "" && cmbSelect.SelectedIndex!=0)
                {
                    MessageBox.Show("请输入需要查询的“" + cmbSelect.SelectedItem.ToString().Trim() + "”", "提示");
                    return;
                }
                int i = cmbSelect.SelectedIndex;
                switch (i)
                {
                    case 0:
                        sql = "select * from book";
                        break;
                    case 1:
                        sql = "select * from book WHERE BookID like'%" + txtSelect.Text + "%'";
                        break;
                    case 2:
                        sql = "select * from book WHERE BookTypeID like'%" + txtSelect.Text + "%'";
                        break;
                    case 3:
                        sql = "select * from book WHERE PressID like'%" + txtSelect.Text + "%'";
                        break;
                    case 4:
                        sql = "select * from book WHERE WorkerID like'%" + txtSelect.Text + "%'";
                        break;
                    case 5:
                        sql = "select * from book WHERE BookName like'%" + txtSelect.Text + "%'";
                        break;
                    case 6:             
                        sql = "select * from book WHERE BookAuthor like'%" + txtSelect.Text + "%'";
                        break;
                    case 7:
                        sql = "select * from book WHERE BookPrice like'%" + txtSelect.Text + "%'";
                        break;
                    case 8:
                        sql = "select * from book WHERE BookPressDate like'%" + txtSelect.Text + "%'";
                        break;
                    case 9:
                        sql = "select * from book WHERE BookISBN like'%" + txtSelect.Text + "%'";
                        break;
                    case 10:
                        sql = "select * from book WHERE BookPosition like'%" + txtSelect.Text + "%'";
                        break;
                    case 11:
                        sql = "select * from book WHERE BookNum like'%" + txtSelect.Text + "%'";
                        break;
                }
                DataSet ds = CDataBase.GetDataFromDB(sql);
                if(ds==null)
                {
                    MessageBox.Show("没有符合条件的图书记录", "提示");
                    return;
                }
                else
                {
                    DataBindingBook(sql);
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void DataBindingBook(string sql)
        {
            DataSet ds = CDataBase.GetDataFromDB(sql);

            dgvBook.DataSource = ds.Tables[0];

            string[] headers = { "书籍编号", "类别编号", "出版社", "工号", "书名", "作者", "价格", "借书时间", "书号", "馆藏位置", "图书数量" };
            int columnWidth = 100;

            for (int i = 0; i < dgvBook.Columns.Count; i++)
            {
                dgvBook.Columns[i].HeaderText = headers[i];
                dgvBook.Columns[i].Width = columnWidth;
            }
        }

        private void DataBindingReturnInfo(string sql)
        {
            DataSet ds = CDataBase.GetDataFromDB(sql);

            dgvRecord.DataSource = ds.Tables[0];

            string[] headers = { "图书编号", "读者证号", "借书时间", "归还时间", "应还时间", "状态" };
            int columnWidth = 190;

            for (int i = 0; i < headers.Length; i++)
            {
                dgvRecord.Columns[i].HeaderText = headers[i];
                dgvRecord.Columns[i].Width = columnWidth;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnCancel.Visible = true;
            btnConfirm.Visible = true;
            txtPsw.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtGen.Enabled = true;
            txtRdept.Enabled = true;
            txtName.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPsw.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                txtPsw.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("联系方式不能为空", "提示");
                txtPhone.Focus();
                return;
            }
            string sql = "";
            sql = "UPDATE reader SET ReaderPwd='" + txtPsw.Text + "',ReaderTel='" + txtPhone.Text + "',ReaderGender='" + txtGen.Text + "',ReaderDept='" + txtRdept.Text + "',ReaderName='" + txtName.Text + "',ReaderEmail='" + txtEmail.Text + "' WHERE readerid='" + txtId.Text + "'";

            if (CDataBase.UpdateDB(sql))
            {
                MessageBox.Show("信息修改成功", "提示");
                btnCancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("信息修改失败","提示");
            }
            
            btnCancel.Text = "返回首页";
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            txtPsw.Enabled = false;
            txtPhone.Enabled = false;
            txtGen.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtRdept.Enabled = false;

            DataSet ds = CDataBase.GetDataFromDB("select * from reader WHERE readerid='" + CPublic.userInfo[1] + "'");
            txtPsw.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString().Trim();
            txtPhone.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString().Trim();

            btnCancel.Visible = false;
            if (btnCancel.Text == "返回首页")
            {
                this.Close();
            }

        }

        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            gbxBookInfo.Visible = true;
            gbxMyInfo.Visible = false;
            gbxRecord.Visible = false;
 
            cmbSelect.SelectedIndex = 0;
            RefreshDataBook();
        }

        private void RefreshDataBook()
        {
            string sql = "select * from book";
            DataBindingBook(sql);
        }

        private void RefreshReturnInfo()
        {
            string sql = "select * from BorrowReturn WHERE readerid='" + CPublic.userInfo[1] + "'";
            DataBindingReturnInfo(sql);
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            gbxBookInfo.Visible = false;
            gbxMyInfo.Visible = true;
            gbxRecord.Visible = false;
            btnUpdate.Visible = true;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            
            string query = "select ReaderBookQuantity from Reader WHERE ReaderID='" + CPublic.userInfo[1] + "'";//在借书数
            SqlCommand cmd = new SqlCommand(query, CDataBase.conn);
            if (CDataBase.conn.State == ConnectionState.Closed)
            {
                CDataBase.conn.Open();
            }
            object result = cmd.ExecuteScalar();
            CDataBase.conn.Close();

            if (result != null)
            {
                txtBookQuantity.Text = result.ToString();
            }

            DataSet ds = CDataBase.GetDataFromDB("select * from Reader WHERE readerID='" + CPublic.userInfo[1] + "'");

            string[] columnNames = { "ReaderID", "ReaderName", "ReaderTel", "ReaderPwd", "ReaderDept", "ReaderEmail", "ReaderGender" };
            TextBox[] textBoxes = { txtId, txtName, txtPhone, txtPsw, txtRdept, txtEmail, txtGen };

            for (int i = 0; i < columnNames.Length; i++)
            {
                textBoxes[i].Text = ds.Tables[0].Rows[0][columnNames[i]].ToString().Trim();
            }

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // 显示借阅记录页面
            gbxBookInfo.Visible = false;
            gbxMyInfo.Visible = false;
            gbxRecord.Visible = true;

            // 查询读者借阅数量
            int readerBookQuantity = 0;
            string selectReaderSql = "SELECT ReaderBookQuantity FROM Reader WHERE ReaderID = @ReaderID";
            Dictionary<string, object> selectReaderParams = new Dictionary<string, object>
            {
                { "@ReaderID", CPublic.userInfo[1] }
            };
            DataSet readerDs = CDataBase.GetDataFromDB(selectReaderSql, selectReaderParams);
            if (readerDs != null && readerDs.Tables[0].Rows.Count > 0)
            {
                readerBookQuantity = Convert.ToInt32(readerDs.Tables[0].Rows[0]["ReaderBookQuantity"]);
            }

            // 如果读者有借书，更新逾期记录
            if (readerBookQuantity > 0)
            {
                UpdateOverdueRecords();
            }
            else
            {
                MessageBox.Show("您当前没有借阅任何图书！");
            }

            // 查询读者借阅记录
            string selectRecordSql = "SELECT * FROM BorrowReturn WHERE ReaderID = @ReaderID";
            Dictionary<string, object> selectRecordParams = new Dictionary<string, object>
            {
                { "@ReaderID", CPublic.userInfo[1] }
            };
            DataSet recordDs = CDataBase.GetDataFromDB(selectRecordSql, selectRecordParams);

            // 如果查询结果不为空，设置借阅记录表格
            if (recordDs != null)
            {
                dgvRecord.DataSource = recordDs.Tables[0];
                string[] headers = { "图书编号", "读者证号", "借书时间", "归还时间", "应还时间", "状态" };
                int columnWidth = 190;
                for (int i = 0; i < dgvRecord.Columns.Count; i++)
                {
                    dgvRecord.Columns[i].HeaderText = headers[i];
                    dgvRecord.Columns[i].Width = columnWidth;
                }
            }

            // 刷新归还信息
            RefreshReturnInfo();
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(CPublic.userInfo[0] == "工作人员")
            {
                this.Close();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //查询读者信息
            string sqlStrReader = "select * from reader WHERE ReaderID='" + CPublic.userInfo[1] + "'";
            DataSet readerData = CDataBase.GetDataFromDB(sqlStrReader);
            lblRType.Text = readerData.Tables[0].Rows[0].ItemArray[3].ToString().Trim();
            string sqlStrReaderType = "select * from ReaderType WHERE ReaderTypeID='" + lblRType.Text + "'";
            DataSet readerTypeData = CDataBase.GetDataFromDB(sqlStrReaderType);
          
            int maxnum = Convert.ToInt32(readerTypeData.Tables[0].Rows[0].ItemArray[2].ToString().Trim());
            int nownum = Convert.ToInt32(readerData.Tables[0].Rows[0].ItemArray[6].ToString().Trim());

            //检查是否已借阅过该书籍
            string BookID = txtBorrow.Text.Trim();
            string sqlStrCheckBorrowed = "SELECT * FROM BorrowReturn WHERE ReaderID='" + CPublic.userInfo[1] + "' AND BookID='" + txtBorrow.Text + "' AND (State='未归还' OR State='逾期未还')";
            if (CDataBase.GetDataFromDB(sqlStrCheckBorrowed) != null)
            {
                MessageBox.Show("您已经借阅过该书籍，不能重复借阅!", "提示");
                txtBorrow.Focus();
                return;
            }

            //检查是否达到最大借书数量
            if (maxnum.CompareTo(nownum) <= 0)
            {
                MessageBox.Show("已达到最大借书数量，请先归还书籍!", "提示");
                txtBorrow.Focus();
                return;
            }

            // 检查输入的书籍编号是否存在
            string sqlStrCheckBook = $"SELECT * FROM book WHERE  BookID='" + txtBorrow.Text + "'";
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

            //借阅时间获取
            string btime = DateTime.Now.ToString("yyyy-MM-dd");
            string mtime;
            int readerTypeDays;
            CPublic.userInfo[0] = lblRType.Text.Trim();
            if (readerTypeData.Tables[0].Rows.Count > 0)
            {
                readerTypeDays = Convert.ToInt32(readerTypeData.Tables[0].Rows[0]["ReaderTypeDays"]);
                mtime = DateTime.Now.AddDays(readerTypeDays).ToString("yyyy-MM-dd");
            }
            else
            {
                mtime = DateTime.Now.AddMonths(5).ToString("yyyy-MM-dd");
            }
            CPublic.userInfo[0] = lblRType.Text.Trim();
            string sqlReaderTypeID = "select * from ReaderType WHERE ReaderTypeID='" + CPublic.userInfo[0] + "'";
            DataSet dataSet1 = CDataBase.GetDataFromDB(sqlReaderTypeID);
            string strReaderTypeDays = dataSet1.Tables[0].Rows[0]["ReaderTypeDays"].ToString();
            int days = Convert.ToInt32(strReaderTypeDays);


            //更新借阅信息
            DateTime borrowDate = DateTime.Now;
            DateTime expireDate = borrowDate.AddDays(days);
            string sqlStrUpdateBook = "UPDATE Book SET BookNum=BookNum-1 WHERE BookID='" + txtBorrow.Text + "'";
            string sqlStrUpdateReader = "UPDATE Reader SET ReaderBookQuantity=ReaderBookQuantity+1 WHERE ReaderID='" + CPublic.userInfo[1] + "'";
            string sqlStrInsertBorrowReturn = "INSERT INTO BorrowReturn(ReaderID,BookID,BorrowDate,Exprire,state) VALUES('" + CPublic.userInfo[1] + "','" + txtBorrow.Text + "','" + borrowDate.ToString("yyyy-MM-dd") + "','" + expireDate.ToString("yyyy-MM-dd") + "','未归还')";

            try
            {
                //执行SQL语句
                CDataBase.UpdateDB(sqlStrUpdateBook);
                CDataBase.UpdateDB(sqlStrUpdateReader);
                CDataBase.UpdateDB(sqlStrInsertBorrowReturn);

                MessageBox.Show("借书成功！", "提示");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"借书失败：{ex.Message}", "错误提示");
            }

            RefreshDataBook();
        }

        private void UpdateOverdueRecords() // 逾期未还更新
        {
            // 查询所有借还记录
            string selectSql = "SELECT * FROM BorrowReturn";
            DataSet ds = CDataBase.GetDataFromDB(selectSql, null);

            // 遍历每一条记录
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // 获取图书编号、读者编号、还书日期、到期日期
                string bookID = row["BookID"].ToString().Trim();
                string readerID = row["ReaderID"].ToString().Trim();
                DateTime returnDate = DateTime.Now;
                DateTime expireDate = Convert.ToDateTime(row["Exprire"].ToString());

                // 如果还书日期超过到期日期，且状态不是逾期归还，而是未归还
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
                        // 更新借还记录状态为逾期未还
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


        private void btnReturn_Click(object sender, EventArgs e)
        {
            // 判断是否选中借书记录
            if (dgvRecord.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中需要还书的借书记录！", "提示");
                return;
            }

            // 获取选中借书记录的图书编号
            string BookID = dgvRecord.SelectedRows[0].Cells[0].Value.ToString().Trim();

            // 查询选中借书记录是否存在
            string selectSql = "SELECT * FROM BorrowReturn WHERE ReaderID = @ReaderID AND BookID = @BookID";
            Dictionary<string, object> selectParams = new Dictionary<string, object>
            {
                {  "@ReaderID", CPublic.userInfo[1]},
                { "@BookID", BookID }
            };
            DataSet ds = CDataBase.GetDataFromDB(selectSql, selectParams);

            // 判断选中借书记录是否存在
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("选中的借书记录不存在，请刷新借阅信息", "提示");
                return;
            }

            // 获取借书记录的读者编号和状态
            string readerID = ds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
            string state = ds.Tables[0].Rows[0].ItemArray[5].ToString().Trim();

            // 判断借书记录的状态是否为已归还或逾期归还
            if (state == "已归还" || state == "逾期归还")
            {
                MessageBox.Show("已归还，请选中未归还的借书记录！", "提示");
                return;
            }

            // 获取当前时间和应还时间
            DateTime returnDate = DateTime.Now;
            DateTime expireDate = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[4].ToString().Trim());

            // 判断是否逾期还书
            if (DateTime.Compare(returnDate, expireDate) > 0)
            {
                // 逾期还书，进行罚款操作
                MessageBox.Show("逾期还书，请在还书后缴纳罚款！", "提示");

                // 更新借书记录状态为逾期归还
                string updateSql = "UPDATE BorrowReturn SET State = @State, ReturnDate = @ReturnDate WHERE ReaderID = @ReaderID AND BookID = @BookID AND (State = '逾期未还' OR State = '未归还')";
                Dictionary<string, object> updateParams = new Dictionary<string, object>
                {
                    { "@State", "逾期归还" },
                    { "@ReturnDate", returnDate },
                    { "@ReaderID", CPublic.userInfo[1] },
                    { "@BookID", BookID }
                };
                CDataBase.UpdateDB(updateSql, updateParams);
            }
            else
            {
                // 更新借书记录状态为已归还
                MessageBox.Show("还书成功！", "提示");

                // 更新图书库存数量
                string updateBookSql = "UPDATE Book SET BookNum = BookNum + 1 WHERE BookID = @BookID";
                Dictionary<string, object> updateBookParams = new Dictionary<string, object>
                {
                    {  "@BookID", BookID }
                };
                // 更新借阅次数
                string updateReaderSql = "UPDATE Reader SET ReaderBookQuantity = ReaderBookQuantity - 1 WHERE ReaderID = @ReaderID";
                Dictionary<string, object> updateReaderParams = new Dictionary<string, object>
                {
                    {"@ReaderID", readerID }
                };
                CDataBase.UpdateDB(updateReaderSql, updateReaderParams);

                // 更新借书记录状态为已归还
                string updateBorrowReturnSql = "UPDATE BorrowReturn SET State = '已归还', ReturnDate = @ReturnDate WHERE ReaderID = @ReaderID AND BookID = @BookID AND State = '未归还'";
                Dictionary<string, object> updateBorrowReturnParams = new Dictionary<string, object>
                {
                    { "@ReturnDate", returnDate },
                    { "@ReaderID", CPublic.userInfo[1] },
                    { "@BookID", BookID }
                };
                CDataBase.UpdateDB(updateBorrowReturnSql, updateBorrowReturnParams);
            }
            RefreshReturnInfo();
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtReturn.Text = dgvRecord.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtBorrow.Text = dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void MainR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }
    }
        }
