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
    public partial class BookTypeM : Form
    {
        public BookTypeM()
        {

            InitializeComponent();
        }

        private void BookType_Load(object sender, EventArgs e)
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

        private void btnRetren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ObjClose()
        {
            txtSelect.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjClose();
            Reset();
            Cancel();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtTypeIo.Text = dgvBookType.Rows[e.RowIndex].Cells[0].Value.ToString();
                TypeName.Text = dgvBookType.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void BookType_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }

        private void UpdateModeUI()//窗体更新
        {
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            txtTypeIo.Enabled = false;
            btnSelect.Enabled = false;
        }
        private void Cancel()
        {
            txtTypeIo.Visible = true;
            TypeName.Visible = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDel.Visible = true;
            btnUpdate.Enabled = true;
            btnAddConfirm.Visible = false;
            btnUpdateConfirm.Visible = false;
            cmbSelect.Enabled = true;
            btnAdd.Enabled = true;
            btnSelect.Enabled = true;
            cmbSelect.SelectedIndex = 0;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            txtTypeIo.Focus();
            txtTypeIo.Enabled = true;
            TypeName.Enabled = true;
            btnAdd.Visible = false;
            btnAddConfirm.Visible = true;
            btnUpdate.Enabled = false;
            btnUpdateConfirm.Visible = false;
            btnDel.Enabled = false;
            btnDel.Visible = true;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            btnReset.Enabled = true;
            btnAdd.Enabled = false;
            btnSelect.Enabled = false;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            txtTypeIo.Enabled = true;
        }

        private void ObjOpen()
        {
            btnDel.Enabled = false;
            btnDel.Visible = true;
            txtTypeIo.Enabled = true;
            TypeName.Enabled = true;
            btnAdd.Enabled=false;
            btnAdd.Visible = true;
        }
        private void Reset()
        {
            txtTypeIo.Enabled = true;
            txtTypeIo.Text = "";
            TypeName.Text = "";
        }

        private void RefreshData()
        {
            StateChange();
            Reset();
            string sqlStr = "select * from BookType order by left(BookTypeID,1) ASC";
            DataBindings(sqlStr);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql = "";

            // 弹出确认对话框
            DialogResult dr = MessageBox.Show("是否删除选中的图书类别信息？", "确认", MessageBoxButtons.OKCancel);

            // 检查是否选择了图书类别
            if (txtTypeIo.Text.Trim() == "")
            {
                MessageBox.Show("请先选择图书类别", "提示");
            }
            else
            {
                if (dr == DialogResult.OK)
                {
                    // 开启数据库连接
                    if (CDataBase.conn.State == ConnectionState.Closed)
                    {
                        CDataBase.conn.Open();
                    }

                    // 开始事务
                    SqlTransaction transaction = CDataBase.conn.BeginTransaction();

                    try
                    {
                        // 先查询 Book 表中是否存在该类别
                        string query = "select BookTypeID from Book WHERE BookTypeID='" + txtTypeIo.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(query, CDataBase.conn);
                        cmd.Transaction = transaction;
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // 如果该类别已经在图书中被使用，提示用户删除失败
                            MessageBox.Show("删除失败，该类别已在图书中被使用！", "提示");
                            Reset();
                        }
                        else
                        {
                            // 如果该类别没有在图书中被使用，执行删除操作
                            sql = "delete from booktype WHERE BookTypeID='" + txtTypeIo.Text.Trim() + "'";
                            cmd = new SqlCommand(sql, CDataBase.conn);
                            cmd.Transaction = transaction;
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            RefreshData();
                            Cancel();
                            Reset();
                        }
                    }
                    catch (Exception ex)
                    {
                        // 发生异常时回滚事务
                        transaction.Rollback();
                        MessageBox.Show("删除失败，错误信息：" + ex.Message, "提示");
                    }
                    finally
                    {
                        // 关闭数据库连接
                        CDataBase.conn.Close();
                    }
                }
            }
        }

        private void DataBindings(string sqlStr)
        {
            if (CDataBase.conn.State == ConnectionState.Open)
            {
                CDataBase.conn.Close();
            }
            SqlCommand com = new SqlCommand(sqlStr, CDataBase.conn);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            CDataBase.conn.Open();
            sda.Fill(ds);
            CDataBase.conn.Close();
            if (ds != null)
            {
                dgvBookType.DataSource = ds.Tables[0];

                // 定义列标题和列宽的数组
                string[] columnHeaders = { "类别编号", "名称" };
                int[] columnWidths = { 585, 585 };

                // 循环设置DataGridView控件中的每一列的标题和宽度
                for (int i = 0; i < columnHeaders.Length; i++)
                {
                    dgvBookType.Columns[i].HeaderText = columnHeaders[i];
                    dgvBookType.Columns[i].Width = columnWidths[i];
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                // 如果查询输入框为空，则提醒用户输入
                if (string.IsNullOrEmpty(txtSelect.Text))
                {
                    string selected = cmbSelect.SelectedItem.ToString().Trim();
                    MessageBox.Show($"请输入需要查询的“{selected}”", "提示");
                    return;
                }
                // 根据下拉框选择的值设置查询列名
                string columnName = "";
                switch (cmbSelect.SelectedIndex)
                {
                    case 1:
                        columnName = "booktypeid";
                        break;
                    case 2:
                        columnName = "booktypename";
                        break;
                    default:
                        MessageBox.Show("请选择查询条件", "提示");
                        return;
                }

                // 设置查询SQL语句并执行查询
                string sql = $"SELECT * FROM booktype WHERE {columnName} = @SearchText";
                SqlCommand comm = new SqlCommand(sql, CDataBase.conn);
                comm.Parameters.AddWithValue("@SearchText", txtSelect.Text);

                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                // 从查询结果中获取数据表
                DataTable dt = ds.Tables[0];

                // 如果没有查询到结果，则提醒用户并返回
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("没有符合条件的图书记录", "提示");
                    return;
                }
                else
                {
                    // 将查询结果绑定到DataGridView控件上
                    dgvBookType.DataSource = dt;

                    // 定义列标题和列宽的数组
                    string[] columnHeaders = { "类别编号", "名称" };
                    int[] columnWidths = { 585, 585 };

                    // 循环设置DataGridView控件中的每一列的标题和宽度
                    for (int i = 0; i < columnHeaders.Length; i++)
                    {
                        dgvBookType.Columns[i].HeaderText = columnHeaders[i];
                        dgvBookType.Columns[i].Width = columnWidths[i];
                    }
                }
            }
            catch (Exception ex)
            {
                // 如果查询出错，则关闭数据库连接并弹出错误信息
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "select * from BookType where BookTypeID=@BookTypeID";
            CDataBase.conn.ConnectionString = CDataBase.connstr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, CDataBase.conn);
            cmd.Parameters.AddWithValue("@BookTypeID", txtTypeIo.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd); // 创建SqlDataAdapter对象
            da.Fill(ds); // 将数据填充到DataSet中

            if (txtTypeIo.Text.Trim() == "")
            {
                MessageBox.Show("请选中你要修改的类别信息", "提示");
                return;
            }
            if (ds.Tables[0].Rows.Count == 0) // 判断DataSet是否为空
            {
                MessageBox.Show("该类别信息未录入，请重新输入", "提示");
                Reset();
                return;
            }
            ObjOpen();
            UpdateModeUI();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            StateChange();
            if (cmbSelect.Text.Trim() == "类别编号")
            {
                sql = "select * from booktype WHERE BookTypeID='" + txtTypeIo.Text.Trim() + "'";
            }
            else if (cmbSelect.Text.Trim() == "类别名称")
            {
                sql = "select * from booktype WHERE BookTypeName='" + txtTypeIo.Text.Trim() + "'";
            }
            else
            {
                return;
            }
            DataSet ds = CDataBase.GetDataFromDB(sql);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtTypeIo.Text = ds.Tables[0].Rows[0]["BookTypeID"].ToString().Trim();
                TypeName.Text = ds.Tables[0].Rows[0]["BookTypeName"].ToString().Trim();
            }
            else
            {
                txtTypeIo.Text = "";
                TypeName.Text = "";
            }
        }

        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            // 检查输入的类别编号是否为空
            if (txtTypeIo.Text.Trim() == "")
            {
                MessageBox.Show("类别编号不能为空", "提示");
                txtTypeIo.Focus();
                return;
            }
            // 检查输入的名称是否为空
            if (TypeName.Text.Trim() == "")
            {
                MessageBox.Show("名称不能为空", "提示");
                TypeName.Focus();
                return;
            }

            // 检查类别编号是否已存在
            string checkSql = "select count(*) from BookType WHERE BookTypeID = '" + txtTypeIo.Text + "'";
            SqlCommand checkCmd = new SqlCommand(checkSql, CDataBase.conn);
            int count = 0;
            try
            {
                CDataBase.conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(checkCmd);
                sda.Fill(ds);
                count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库错误：" + ex.Message, "错误");
                return;
            }
            finally
            {
                CDataBase.conn.Close();
            }

            // 如果类别编号已存在，提示用户并返回
            if (count > 0)
            {
                MessageBox.Show("类别编号已存在，请重新输入", "提示");
                txtTypeIo.Focus();
                return;
            }

            // 执行修改操作
            string sql = "UPDATE BookType SET BookTypeName='" + TypeName.Text + "' WHERE BookTypeID='" + txtTypeIo.Text + "'";
            if (CDataBase.UpdateDB(sql))
            {
                MessageBox.Show("信息修改成功", "提示");
                btnCancel_Click(sender, e);
                RefreshData();
            }
            else
            {
                MessageBox.Show("信息修改失败", "提示");
            }
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            // 检查类别编号是否已存在
            string checkSql = "SELECT COUNT(*) FROM booktype WHERE booktypeid = @BookTypeID";
            SqlCommand checkCmd = new SqlCommand(checkSql, CDataBase.conn);
            checkCmd.Parameters.AddWithValue("@BookTypeID", txtTypeIo.Text.Trim());

            try
            {
                CDataBase.conn.Open();
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("类别编号已存在，添加失败", "提示");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库错误：" + ex.Message, "错误");
                return;
            }
            finally
            {
                CDataBase.conn.Close();
            }

            // 检查图书类别名称是否已存在
            checkSql = "SELECT COUNT(*) FROM booktype WHERE booktypename = @BookTypeName";
            checkCmd = new SqlCommand(checkSql, CDataBase.conn);
            checkCmd.Parameters.AddWithValue("@BookTypeName", TypeName.Text.Trim());

            try
            {
                CDataBase.conn.Open();
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("该图书类别已存在，请勿重复添加", "提示");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库错误：" + ex.Message, "错误");
                return;
            }
            finally
            {
                CDataBase.conn.Close();
            }

            // 检查输入是否合法
            if (txtTypeIo.Text.Trim() == "")
            {
                MessageBox.Show("类别编号不能为空", "提示");
                txtTypeIo.Focus();
                return;
            }
            if (TypeName.Text.Trim() == "")
            {
                MessageBox.Show("名称不能为空", "提示");
                TypeName.Focus();
                return;
            }

            // 执行插入操作
            string insertSql = "INSERT INTO booktype (booktypeid, booktypename) VALUES (@BookTypeID, @BookTypeName)";
            SqlCommand insertCmd = new SqlCommand(insertSql, CDataBase.conn);
            insertCmd.Parameters.AddWithValue("@BookTypeID", txtTypeIo.Text.Trim());
            insertCmd.Parameters.AddWithValue("@BookTypeName", TypeName.Text.Trim());

            try
            {
                CDataBase.conn.Open();
                int result = insertCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    // 提示添加成功，刷新数据，重置输入框
                    MessageBox.Show("添加成功", "提示");
                    RefreshData();
                    Cancel();
                    Reset();
                }
                else
                {
                    MessageBox.Show("添加失败", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库错误：" + ex.Message, "错误");
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }


    }
}
