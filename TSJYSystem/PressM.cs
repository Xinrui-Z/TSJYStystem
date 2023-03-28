using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSJYSystem
{
    public partial class PressM : Form
    {
        public PressM()
        {
            InitializeComponent();
            txtName.Enabled = true;
            txtTel.Enabled = true;
            txtURL.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void PressM_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                this.cmbSelect.SelectedIndex = 0;
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ObjOpen()
        {
            txtID.Enabled = true;
            txtName.Enabled = true;
            txtTel.Enabled = true;
            txtURL.Enabled = true;
            txtID.Focus();
        }

        private void Reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtTel.Text = "";
            txtURL.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnCancel.Visible = true;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            txtID.Enabled = true;
            btnSelect.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("请先选中出版社信息！", "提示");
            }
            DialogResult dr = MessageBox.Show("是否删除选中出版社信息？", "确认", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                DeletePreeInfo();
                RefreshData();
                Cancel();
                Reset();
            }
        }

        private void DeletePreeInfo()
        {
            // 获取要删除的出版社ID
            string PressID = txtID.Text;

            // 检查是否存在属于该出版社的图书
            string checkBookPressSql = "SELECT COUNT(*) FROM Book WHERE PressID = @PresID";
            using(SqlCommand checkBookPressCommand = new SqlCommand(checkBookPressSql, CDataBase.conn))
            {
                checkBookPressCommand.Parameters.AddWithValue("@PresID", PressID);

                if (CDataBase.conn.State != ConnectionState.Open)
                {
                    CDataBase.conn.Open();
                }

                int BookCount = Convert.ToInt32(checkBookPressCommand.ExecuteScalar());

                if(BookCount>0)
                {
                    MessageBox.Show("无法删除该记录，因为存在属于该出版社的图书！", "提示");
                    return;
                }
            }

            // 删除Pree表中相应的记录
            string deleteSql = "DELETE FROM ReaderType WHERE PressID = @PressID";
            using (SqlCommand deleteCommand = new SqlCommand(deleteSql, CDataBase.conn))
            {
                deleteCommand.Parameters.AddWithValue("@PressID", PressID);

                // 在执行 SQL 前检查连接状态
                if (CDataBase.conn.State != ConnectionState.Open)
                {
                    CDataBase.conn.Open();
                }

                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("删除成功！", "提示");
            }
        }

        private void RefreshData()
        {
            string sqlStr = "SELECT * FROM Press order by cast(PressID as int) ASC;";
            btnSelect.Enabled = true;
            txtID.Enabled = true;
            DataBindings(sqlStr);
        }

        private void DataBindings(string sqlStr)
        {
            SqlCommand com = new SqlCommand(sqlStr, CDataBase.conn);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            CDataBase.conn.Open();
            sda.Fill(ds);
            CDataBase.conn.Close();
            if (ds != null)
            {
                dgvPress.DataSource = ds.Tables[0];
                string[] headers = { "出版社编号", "出版社名称", "出版社官网", "出版社电话" };
                int[] widths = { 292, 292, 292, 292 };

                for (int i = 0; i < headers.Length; i++)
                {
                    dgvPress.Columns[i].HeaderText = headers[i];
                    dgvPress.Columns[i].Width = widths[i];
                }
            }
        }

        private void DataUpdate(string sql)
        {
            try
            {
                SqlCommand com = new SqlCommand(sql, CDataBase.conn);
                CDataBase.conn.Open();
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("操作成功");
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


        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            string pressID = txtID.Text.Trim();
            string pressName = txtName.Text.Trim();
            string pressURL = txtURL.Text.Trim();
            string pressTel = txtTel.Text.Trim();

            // 合法性检查
            if (string.IsNullOrEmpty(pressID))
            {
                MessageBox.Show("出版社编号不能为空", "提示");
                txtID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pressName))
            {
                MessageBox.Show("出版社名称不能为空", "提示");
                txtName.Focus();
                return;
            }

            string sql = $"update Press set PressName='{pressName}', PressID='{pressID}', PressURL='{pressURL}', PressTel='{pressTel}' WHERE PressID='{pressID}'";

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            Cancel();
        }

        private void Cancel()
        {
            txtID.Visible = true;
            txtName.Visible = true;
            txtTel.Visible = true;
            txtURL.Visible = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDel.Visible = true;
            btnAddConfirm.Visible = false;
            btnUpdateConfirm.Visible = false;
            btnCancel.Enabled = false;
            cmbSelect.Enabled = true;
            txtSelect.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            cmbSelect.SelectedIndex = 0;
            Reset();

        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            // 检查PressID是否已存在
            int COUNT = 0;
            string checkSql = "SELECT COUNT(*) FROM Press WHERE PressID = '" + txtID.Text + "'";
            SqlCommand checkCmd = new SqlCommand(checkSql, CDataBase.conn);
            try
            {
                CDataBase.conn.Open();
                COUNT = (int)checkCmd.ExecuteScalar();
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
            if (COUNT > 0)
            {
                MessageBox.Show("出版社编号已存在，添加失败", "提示");
                btnCancel_Click(sender, e);
                return;
            }

            // 检查PressName是否已存在
            COUNT = 0;
            checkSql = "SELECT COUNT(*) FROM Press WHERE PressName = '" + txtName.Text + "'";
            checkCmd = new SqlCommand(checkSql, CDataBase.conn);
            try
            {
                CDataBase.conn.Open();
                COUNT = (int)checkCmd.ExecuteScalar();
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

            if (COUNT > 0)
            {
                MessageBox.Show("该出版社已存在，请勿重复添加", "提示");
                btnCancel_Click(sender, e);
                return;
            }

            //  更新Pree表
            string sql;
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("出版社编号不能为空", "提示");
                txtID.Focus();
                return;
            }

            sql = "INSERT INTO Press(PressID,PressName,PressURL,PressTel) VALUES('" + txtID.Text + "','" + txtName.Text + "','" + txtURL.Text + "','" + txtTel.Text + "')";
            DataUpdate(sql);
            RefreshData();
            Cancel();
            Reset();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                if (txtSelect.Text.Trim() == "")
                {
                    MessageBox.Show("请输入需要查询的信息", "提示");
                    return;
                }
                int i = cmbSelect.SelectedIndex;
                Dictionary<int, string> sqlDict = new Dictionary<int, string>()
                {
                    { 0, "SELECT * FROM Press" },
                    { 1, "SELECT * FROM Press WHERE Pressid='{0}'" },
                    { 2, "SELECT * FROM Press WHERE PressName like'%{0}%'" },
                    { 3, "SELECT * FROM Press WHERE PressURL='{0}'" },
                    { 4, "SELECT * FROM Press WHERE PressTel like'%{0}%'" }
                };
                sql = string.Format(sqlDict[i], txtSelect.Text);
                SqlCommand comm = new SqlCommand(sql, CDataBase.conn);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("没有符合条件的出版社记录", "提示");
                    return;
                }
                else
                {
                    dgvPress.DataSource = ds.Tables[0];
                    string[] headers = { "出版社编号", "出版社名称", "出版社官网", "出版社电话" };
                    int[] widths = { 292, 292, 292, 292 };

                    for (int s = 0; s < headers.Length; s++)
                    {
                        dgvPress.Columns[s].HeaderText = headers[s];
                        dgvPress.Columns[s].Width = widths[s];
                    }
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
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
            CPublic.userInfo[0] = cmbSelect.Text.Trim();
            string sql ;
            if (CPublic.userInfo[0] == "出版社编号")
            {
                sql = "SELECT * FROM Press WHERE pressid='" + txtID.Text + "'";
            }
            else if (CPublic.userInfo[0] == "出版社名称")
            {
                sql = "SELECT * FROM Press WHERE pressname='" + txtName.Text + "'";
            }
            else if (CPublic.userInfo[0] == "出版社官网")
            {
                sql = "SELECT * FROM Press WHERE pressURL='" + txtURL.Text + "'";
            }
            else
            {
                sql = "SELECT * FROM Press WHERE pressTel='" + txtTel.Text + "'";
            }
            DataSet ds = CDataBase.GetDataFromDB(sql);
            if (ds != null)
            {
                txtID.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim();
                txtName.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                txtTel.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString().Trim();
                txtURL.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();
            }
            else
            {
                Reset();
            }
        }


        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtID.Text = dgvPress.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvPress.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtURL.Text = dgvPress.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTel.Text = dgvPress.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("请选中你要修改的出版社信息", "提示");
                return;
            }
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnDel.Visible = false;
            btnSelect.Enabled = false;
            btnCancel.Visible = true;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            txtID.Enabled = false;
        }

        private void btnRetren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Press_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }
    }
}
