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
    public partial class ReaderTypeM : Form
    {
        public ReaderTypeM()
        {
            InitializeComponent();
        }

        private void RType_Load(object sender, EventArgs e)
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

        private void ObjOpen()
        {
            txtTypeIo.Enabled = true;
            TypeName.Enabled = true;
            txtDays.Enabled = true;
            txtNum.Enabled = true;
            txtTypeIo.Focus();
        }

        private void Reset()
        {
            txtTypeIo.Text = "";
            TypeName.Text = "";
            txtNum.Text = "";
            txtDays.Text = "";
            txtSelect.Text = "";
        }

        private void Cancel()
        {
            txtTypeIo.Visible = true;
            TypeName.Visible = true;
            txtNum.Visible = true;
            txtDays.Visible = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDel.Visible = true;
            btnUpdate.Enabled = true;
            btnAddConfirm.Visible = false;
            btnUpdateConfirm.Visible = false;
            btnCancel.Visible = false;
            cmbSelect.Enabled = true;
            btnAdd.Enabled = true;
            btnSelect.Enabled = true;
            btnDel.Enabled = true;
            cmbSelect.SelectedIndex = 0;
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
                    MessageBox.Show("操作成功", "提示");
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
                dgvRType.DataSource = ds.Tables[0];
                string[] headers = { "类型编号", "类型名称", "借书数量", "借书期限" };
                int[] widths = { 400, 400, 400, 400 };

                for (int i = 0; i < headers.Length; i++)
                {
                    dgvRType.Columns[i].HeaderText = headers[i];
                    dgvRType.Columns[i].Width = widths[i];
                }
            }
        }

        private void RefreshData()
        {
            ObjClose();
            string sqlStr = "SELECT * FROM ReaderType order by left(ReaderTypeID,1) ASC";
            DataBindings(sqlStr);
        }
        private void ObjClose()
        {
            txtSelect.Enabled = true;
            txtTypeIo.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = true;
            btnUpdate.Enabled = false;
            btnUpdateConfirm.Visible = false;
            btnDel.Enabled = false;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            btnReset.Enabled = true;
            btnAdd.Enabled = false;
            btnSelect.Enabled = false;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            txtTypeIo.Enabled = true;
        }

        private void DeleteReaderType()
        {
            string readerTypeID = txtTypeIo.Text;

            // 检查是否存在该类型用户
            string checkReaderSql = "SELECT COUNT(*) FROM Reader WHERE ReaderTypeID = @ReaderTypeID";
            using (SqlCommand checkReaderCommand = new SqlCommand(checkReaderSql, CDataBase.conn))
            {
                checkReaderCommand.Parameters.AddWithValue("@ReaderTypeID", readerTypeID);

                if (CDataBase.conn.State != ConnectionState.Open)
                {
                    CDataBase.conn.Open();
                }

                int readerCount = Convert.ToInt32(checkReaderCommand.ExecuteScalar());

                if (readerCount > 0)
                {
                    MessageBox.Show("无法删除该记录，因为读者中存在该类型的用户！","提示");
                    return;
                }
            }

            // 删除ReaderType表中相应记录
            string deleteSql = "DELETE FROM ReaderType WHERE ReaderTypeID = @ReaderTypeID";
            using (SqlCommand deleteCommand = new SqlCommand(deleteSql, CDataBase.conn))
            {
                deleteCommand.Parameters.AddWithValue("@ReaderTypeID", readerTypeID);

                // 在执行 SQL 前检查连接状态
                if (CDataBase.conn.State != ConnectionState.Open)
                {
                    CDataBase.conn.Open();
                }

                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("删除成功！", "提示");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtTypeIo.Text.Trim() == "")
            {
                MessageBox.Show("请选择要删除的读者类型！", "提示");
                return;
            }

            DialogResult dr = MessageBox.Show("是否删除选中的读者类型信息？", "确认", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                DeleteReaderType();
                RefreshData();
                Cancel();
                Reset();
            }
        }

        private void dgvRType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtTypeIo.Text = dgvRType.Rows[e.RowIndex].Cells[0].Value.ToString();
                TypeName.Text = dgvRType.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNum.Text = dgvRType.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDays.Text = dgvRType.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (txtTypeIo.Text.Trim() == "")
            {
                MessageBox.Show("类型编号不能为空!", "提示");
                txtTypeIo.Focus();
                return;
            }
            if (TypeName.Text.Trim() == "")
            {
                MessageBox.Show("类型名称不能为空!", "提示");
                TypeName.Focus();
                return;
            }
            if (txtNum.Text.Trim() == "")
            {
                MessageBox.Show("借书数量不能为空!", "提示");
                txtTypeIo.Focus();
                return;
            }
            if (TypeName.Text.Trim() == "")
            {
                MessageBox.Show("借书期限不能为空", "提示");
                TypeName.Focus();
                return;
            }
            string sql = "update ReaderType set ReaderTypeID='" + txtTypeIo.Text + "', ReaderTypeName='" + TypeName.Text + "', ReaderTypeQuantity='" + txtNum.Text + "', ReaderTypeDays='" + txtDays.Text + "' WHERE ReaderTypeID='" + txtTypeIo.Text + "'";
            if (CDataBase.UpdateDB(sql))
            {
                MessageBox.Show("信息修改成功!", "提示");
                btnCancel_Click(sender, e);
                RefreshData();
            }
            else
            {
                MessageBox.Show("信息修改失败！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjClose();
            Reset();
            Cancel();
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            // 检查ReaderTypeID是否已存在
            int count = 0;
            string checkSql = "SELECT count(*) FROM ReaderType WHERE ReaderTypeID = '" + txtTypeIo.Text + "'";
            SqlCommand checkCmd = new SqlCommand(checkSql, CDataBase.conn);
            try
            {
                CDataBase.conn.Open();
                count = (int)checkCmd.ExecuteScalar();
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

            if ((count > 0))
            {
                MessageBox.Show("类型编号已存在，添加失败", "提示");
                btnCancel_Click(sender, e);
                return;
            }


            // 定义一个字典，存储控件名和提示信息
            Dictionary<string, string> errorDict = new Dictionary<string, string>
            {
                { "txtTypeIo", "类型编号不能为空" },
                { "TypeName", "类型名称不能为空" },
                { "txtNum", "借书数量不能为空" },
                { "txtDays", "借书期限不能为空" }
            };

            // 遍历字典，检查每个控件是否为空
            foreach (KeyValuePair<string, string> entry in errorDict)
            {
                string controlName = entry.Key;
                string errorMessage = entry.Value;
                Control control = Controls.Find(controlName, true).FirstOrDefault();

                if (control == null || string.IsNullOrWhiteSpace(control.Text))
                {
                    MessageBox.Show(errorMessage, "提示");
                    control?.Focus();
                    return;
                }
            }

            //s数据更新
            string sql = "INSERT INTO ReaderType(ReaderTypeID,ReaderTypeName,ReaderTypeQuantity,ReaderTypeDays) VALUES('" + txtTypeIo.Text + "','" + TypeName.Text + "','" + txtNum.Text + "','" + txtDays.Text + "')";
            DataUpdate(sql);
            RefreshData();
            Cancel();
            Reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "SELECT * FROM ReaderType WHERE ReaderTypeID='" + txtTypeIo.Text + "'";
            CDataBase.conn.ConnectionString = CDataBase.connstr;
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sql);
            if (txtTypeIo.Text.Trim() == "")
            {
                MessageBox.Show("请选中你要修改的类型信息", "提示");
                return;
            }
            if (ds == null)
            {
                MessageBox.Show("该类型信息未录入，请重新输入", "提示");
                Reset();
                return;
            }
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnDel.Visible = false;
            btnCancel.Visible = true;
            txtTypeIo.Enabled = false;
            cmbSelect.Enabled = false;
            txtSelect.Enabled = false;
            btnSelect.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> selectOptions = new Dictionary<int, string>()
            {
                {1, "ReaderTypeID"},
                {2, "ReaderTypeName"},
                {3, "ReaderTypeQuantity"},
                {4, "ReaderTypeDays"}
            };

            try
            {

                if (txtSelect.Text.Trim() == "")
                {
                    MessageBox.Show("请输入需要查询的“" + cmbSelect.SelectedItem.ToString().Trim() + "”", "提示");
                    return;
                }
                int i = cmbSelect.SelectedIndex;
                if (!selectOptions.ContainsKey(i))
                {
                    MessageBox.Show("无效的查询选项", "提示");
                    return;
                }
                string column = selectOptions[i];
                string sql = string.Format("SELECT * FROM ReaderType WHERE {0} = '{1}'", column, txtSelect.Text);

                SqlCommand comm = new SqlCommand(sql, CDataBase.conn);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("没有符合条件的读者类型记录", "提示");
                    return;
                }
                else
                {
                    dgvRType.DataSource = dt;
                    dgvRType.AutoGenerateColumns = false;

                    dgvRType.DataSource = ds.Tables[0];
                    string[] headers = { "类型编号", "类型名称", "借书数量", "借书期限" };
                    int[] widths = { 200, 200, 200, 200 };

                    for (int t = 0; t < headers.Length; t++)
                    {
                        dgvRType.Columns[t].HeaderText = headers[t];
                        dgvRType.Columns[t].Width = widths[t];
                    }
                    dgvRType.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void btnRetren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.Text == "查询条件")
            {
                txtSelect.Text = "";
                txtSelect.Enabled = false;
                btnSelect.Enabled = false;
            }
            else
            {
                txtSelect.Text = "";
                txtSelect.Enabled = true;
                btnSelect.Enabled = true;
            }
        }

        private void RType_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }

        private void dgvRType_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 如果点击的是列标题
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // 禁用整个 DataGridView 的列标题排序
                foreach (DataGridViewColumn col in dgvRType.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                // 禁用列标题选择
                dgvRType.ClearSelection();
            }
        }

        private void dgvRType_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
