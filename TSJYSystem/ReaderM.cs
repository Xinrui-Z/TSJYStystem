using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSJYSystem
{
    public partial class ReaderM : Form
    {
        public ReaderM()
        {
            InitializeComponent();
        }

        private void ReaderManage_Load(object sender, EventArgs e)
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
            string sqlStr = "select * FROM Reader order by ReaderID ASC";
            DataBindings(sqlStr);
        }

        private void DataBindings(string sql)
        {
            SqlCommand com = new SqlCommand(sql,CDataBase.conn);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            CDataBase.conn.Open();
            sda.Fill(ds);
            CDataBase.conn.Close();
            if (ds != null)
            {
                dgvReader.DataSource = ds.Tables[0];
                string[] headers = { "读者证号", "姓名", "性别", "类别编号", "工作人员编号", "单位", "现借书数", "电话", "邮箱", "密码" };
                int[] widths = { 117, 117, 90, 117, 117, 117, 110, 117, 117, 110 };

                for (int i = 0; i < headers.Length; i++)
                {
                    dgvReader.Columns[i].HeaderText = headers[i];
                    dgvReader.Columns[i].Width = widths[i];
                }
            }
        }

        private void ObjClose()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtPsw.Enabled = false;
            txtSelect.Enabled = false;
            txtWorkerID.Enabled = false;
            txtClassID.Enabled = false;
            txtNownum.Enabled = false;
            txtWorkerID.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            if(txtId.Enabled)
            {
                txtId.Text = "";
                txtName.Text = "";
                txtPsw.Text = "";
                txtWorkerID.Text = "";
                txtClassID.Text = "";
                txtNownum.Text = "";
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                txtPsw.Text = "";
                txtClassID.Text = "";
                txtNownum.Text = "";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            ObjOpen();
            txtId.Visible = true;
            btnAdd.Visible = false;
            btnAddConfirm.Visible = true;
            btnUpdate.Enabled = false;
            btnUpdateConfirm.Visible = false;
            btnDel.Visible = false;
            btnCancel.Visible = true;
            txtId.Enabled = true;
            cmbSelect.SelectedIndex = 0;
            cmbSelect.Enabled = false;
            txtWorkerID.Text = CPublic.userInfo[1];
            txtWorkerID.Enabled = false;
        }

        private void ObjOpen()
        {
            txtName.Enabled = true;
            txtPsw.Enabled = true;
            txtSelect.Enabled = true;
            txtWorkerID.Enabled = true;
            txtClassID.Enabled = true;
            txtNownum.Enabled = true;
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            string checkBkType = "SELECT COUNT(*) FROM ReaderType WHERE ReaderTypeID = @ReaderTypeID";
            string addReaderSql = "INSERT INTO Reader(ReaderName, Readerid, ReaderPwd, WorkerID, ReaderTypeID, ReaderBookQuantity) VALUES(@ReaderName, @Readerid, @ReaderPwd, @WorkerID, @ReaderTypeID, @ReaderBookQuantity)";

            Dictionary<string, string> fieldNames = new Dictionary<string, string>()
            {
                {"txtId", "读者证号"},
                {"txtName", "姓名"},
                {"txtPsw", "密码"},
                {"txtClassID", "类别编号"},
            };

            foreach (KeyValuePair<string, string> fieldName in fieldNames)
            {
                if (Controls[fieldName.Key].Text.Trim() == "")
                {
                    MessageBox.Show(fieldName.Value + "不能为空", "提示");
                    Controls[fieldName.Key].Focus();
                    return;
                }
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(CDataBase.connstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(checkBkType, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReaderTypeID", txtClassID.Text);
                        int cout = Convert.ToInt32(cmd.ExecuteScalar());

                        //如果ReaderType表中不存在该ReaderTypeID，则向ReaderType表中添该加类型
                        if (cout == 0)
                        {
                            using (SqlCommand addTypeCmd = new SqlCommand(checkBkType, conn))
                            {
                                addTypeCmd.Parameters.AddWithValue("@ReaderTypeID", txtClassID.Text);
                                addTypeCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(addReaderSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReaderName", txtName.Text);
                        cmd.Parameters.AddWithValue("@Readerid", txtId.Text);
                        cmd.Parameters.AddWithValue("@ReaderPwd", txtPsw.Text);
                        cmd.Parameters.AddWithValue("@WorkerID", txtWorkerID.Text);
                        cmd.Parameters.AddWithValue("@ReaderTypeID", txtClassID.Text);
                        cmd.Parameters.AddWithValue("@ReaderBookQuantity", txtNownum.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("操作成功", "提示");
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


        private void DataUpdate(string sql)
        {
            try
             {
                 SqlCommand com = new SqlCommand(sql, CDataBase.conn);
                 CDataBase.conn.Open();
                 int i = com.ExecuteNonQuery();
                 if (i > 0)
                 {
                     MessageBox.Show("操作成功","提示");
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

        private void Cancel()
        {
            lblId.Visible = true;
            txtId.Visible = true;
            btnAdd.Visible = true;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = true;
            btnDel.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnCancel.Visible = false;
            cmbSelect.Enabled = true;
            cmbSelect.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("请选中你要修改的读者信息", "提示");
                return;
            }
            
            ObjOpen();
            lblId.Visible = true;
            btnAdd.Visible = false;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnDel.Visible = false;
            btnCancel.Visible = true;
            cmbSelect.SelectedIndex = 0;
            cmbSelect.Enabled = false;
            txtWorkerID.Text = CPublic.userInfo[1];
            txtWorkerID.Enabled = false;
            txtId.Enabled = false;
        }

        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            // 定义条件和提示信息的字典
            Dictionary<Func<bool>, string> conditions = new Dictionary<Func<bool>, string>()
            {
                { () => txtName.Text.Trim() == "", "姓名不能为空" },
                { () => CDataBase.GetDataFromDB($"select * FROM Reader WHERE ReaderID='{txtId.Text.Trim()}'") == null, "此编号不存在" },
                { () => txtPsw.Text.Trim() == "", "密码不能为空" },
                { () => txtClassID.Text.Trim() == "", "读者类别编号不能为空" }
            };

            // 遍历字典，检查条件是否满足
            foreach (var condition in conditions)
            {
                if (condition.Key())
                {
                    MessageBox.Show(condition.Value, "提示");
                    return;
                }
            }

            // 更新数据
            string sql = $"update Reader set ReaderName='{txtName.Text.Trim()}', ReaderPwd='{txtPsw.Text.Trim()}', " +
                         $"WorkerID='{CPublic.userInfo[1]}', ReaderTypeID='{txtClassID.Text.Trim()}', " +
                         $"ReaderBookQuantity='{txtNownum.Text.Trim()}' WHERE ReaderID='{txtId.Text.Trim()}'";
            DataUpdate(sql);

            RefreshData();
            Cancel();
            Reset();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("读者证号不能为空", "提示");
                txtId.Focus();
                return;
            }
            if (txtNownum.Text.Trim() != "0")
            {
                MessageBox.Show("有书籍未还，不能删除!", "提示");
                return;
            }

            string sqlStr = "select * FROM Reader WHERE ReaderID=@ID";
            var parameters = new Dictionary<string, object>() { { "@ID", txtId.Text } };
            var result = CDataBase.GetDataFromDB(sqlStr, parameters);
            if (result == null)
            {
                MessageBox.Show("读者证号不存在", "提示");
                txtId.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("是否删除选中的读者信息?", "确认", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string sql = "DELETE FROM Reader WHERE ReaderID='" + txtId.Text.Trim() + "'";
                DataUpdate(sql);
                RefreshData();
                Cancel();
                Reset();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ObjClose();
            Reset();
            Cancel();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (txtSelect.Text.Trim() == "" && cmbSelect.SelectedIndex != 0)
                {
                    MessageBox.Show("请输入需要查询的" + cmbSelect.SelectedItem.ToString().Trim() + "", "提示");
                    return;
                }
                int i = cmbSelect.SelectedIndex;
                string[] headers = { "读者证号", "姓名", "性别", "类别编号", "工作人员编号", "单位", "现借书数", "电话", "邮箱", "密码" };
                int widths = 110;
                string[] searchTypes = { "", "ReaderID", "ReaderName", "ReaderGender", "ReaderTypeID", "WorkerID", "ReaderDept", "ReaderBookQuantity", "ReaderTel", "ReaderEmail", "ReaderPwd" };
                if (i == 0)
                {
                    sql = "select * FROM Reader ";
                }
                else
                {
                    string searchType = searchTypes[i];
                    sql = string.Format("select * FROM Reader WHERE {0} like '%{1}%' ", searchType, txtSelect.Text);
                }
                SqlCommand comm = new SqlCommand(sql, CDataBase.conn);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("查询无果", "提示");
                    return;
                }
                else
                {
                    dgvReader.DataSource = dt;
                    for (int j = 0; j < headers.Length; j++)
                    {
                        dgvReader.Columns[j].HeaderText = headers[j];
                        dgvReader.Columns[j].Width = widths;
                    }
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            ObjOpen();
            RefreshData();
            Reset();
        }

        private void btnRetren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtId.Text = dgvReader.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvReader.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtWorkerID.Text = dgvReader.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPsw.Text = dgvReader.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtNownum.Text = dgvReader.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtClassID.Text = dgvReader.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void RIM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }

    }
}
