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
    public partial class ReaderIdentityM : Form
    {
        public ReaderIdentityM()
        {
            InitializeComponent();
        }

        private void RSManage_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ObjClose()
        {
            txtName.Enabled = false;
            txtPsw.Enabled = false;
            txtPhone.Enabled = false;
            txtGen.Enabled = false;
            txtNownum.Enabled = false;
            txtEmail.Enabled = false;
            txtId.Enabled = false;
            txtRdt.Enabled = false;
        }
        private void RefreshData()
        {
            ObjClose();
            string sqlStr = "select * from reader";
            DataBindings(sqlStr);
        }
        private void DataBindings(string sql)
        {
            SqlCommand com = new SqlCommand(sql, CDataBase.conn);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            CDataBase.conn.Open();
            sda.Fill(ds);
            CDataBase.conn.Close();
            if (ds != null)
            {
                dgvReader.DataSource = ds.Tables[0];
                dgvReader.Columns[0].HeaderText = "借书证号";
                dgvReader.Columns[0].Width = 120;
                dgvReader.Columns[1].HeaderText = "姓名";
                dgvReader.Columns[1].Width = 100;
                dgvReader.Columns[2].HeaderText = "性别";
                dgvReader.Columns[2].Width = 90;
                dgvReader.Columns[3].HeaderText = "身份编号";
                dgvReader.Columns[3].Width = 130;
                dgvReader.Columns[4].HeaderText = "工作人员编号";
                dgvReader.Columns[4].Width = 130;
                dgvReader.Columns[5].HeaderText = "单位";
                dgvReader.Columns[5].Width = 120;
                dgvReader.Columns[6].HeaderText = "借书数量";
                dgvReader.Columns[6].Width = 100;
                dgvReader.Columns[7].HeaderText = "电话";
                dgvReader.Columns[7].Width = 120;
                dgvReader.Columns[8].HeaderText = "邮箱";
                dgvReader.Columns[8].Width = 140;
                dgvReader.Columns[9].HeaderText = "密码";
                dgvReader.Columns[9].Width = 90;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = true;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = false;
            btnDel.Visible = false;
            btnCancel.Visible = true;
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("请选中你要修改的读者信息", "提示");
                return;
            }
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnDel.Visible = false;
            btnCancel.Visible = true;
        }
        private void ObjOpen()
        {
            txtId.Visible = true;
            lblId.Visible = true;
            txtName.Enabled = true;
            txtPsw.Enabled = true;
            txtId.Enabled = true;
            txtPhone.Enabled = true;
            txtGen.Enabled = true;
            txtNownum.Enabled = true;
            txtEmail.Enabled = true;
            txtRdt.Enabled = true;
        }

        private void Reset()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPsw.Text = "";
            txtPhone.Text = "";
            txtGen.Text = "";
            txtNownum.Text = "";
            txtEmail.Text = "";
            txtRdt.Text = "";
            txtId.Focus();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Reset();
            ObjOpen();
            btnAdd.Visible = false;
            btnAddConfirm.Visible = true;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = false;
            btnDel.Visible = false;
            btnCancel.Visible = true;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("请选中你要修改的读者信息", "提示");
                return;
            }
            ObjOpen();
            txtId.Enabled = false;
            btnAdd.Visible = false;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnDel.Visible = false;
            btnCancel.Visible = true;
        }
        private void Cancel()
        {
            lblId.Visible = true;
            txtId.Visible = true;
            txtId.Enabled = false;
            btnAdd.Visible = true;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = true;
            btnDel.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("借书证号不能为空", "提示");
                txtId.Focus();
                return;
            }
            else
            {
                if (txtNownum.Text.Trim() != "0")
                {
                    MessageBox.Show("有书籍未还，不能删除", "提示");
                    return;
                }
                string sqlStr = "select * from reader where readerid='" + txtId.Text + "'";
                if (CDataBase.GetDataFromDB(sqlStr) == null)
                {
                    MessageBox.Show("借书证号不存在", "提示");
                    txtId.Focus();
                    return;
                }
            }
            DialogResult dr = MessageBox.Show("是否删除选中的读者信息?", "确认", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                sql = "delete from reader where readerid='" + txtId.Text.Trim() + "'";
                DataUpdate(sql);
                RefreshData();
                Cancel();
                Reset();
            }
        }

        private void btnRetren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空", "提示");
                txtName.Focus();
                return;
            }
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
            if (txtGen.Text.Trim() == "")
            {
                MessageBox.Show("职业不能为空", "提示");
                txtGen.Focus();
                return;
            }
            sql = "insert into Reader(ReaderID,ReaderName,ReaderPwd,ReaderEmail,ReaderGender,ReaderTel,ReaderBookQuantity,ReaderDept) values('" + txtId.Text + "','" + txtName.Text + "','" + txtPsw.Text + "','" + txtEmail.Text + "','" + txtGen.Text + "','" + txtPhone.Text + "','" + txtNownum.Text + "','" + txtRdt.Text + "')";
            DataUpdate(sql);
            RefreshData();
            Cancel();
            Reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjClose();
            Reset();
            Cancel();
        }

        private void RSManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }

        private void dgvReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&& e.ColumnIndex>=0)
            {
                txtId.Text = dgvReader.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvReader.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = dgvReader.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtPsw.Text = dgvReader.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtGen.Text = dgvReader.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNownum.Text = dgvReader.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEmail.Text = dgvReader.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtRdt.Text = dgvReader.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空", "提示");
                txtName.Focus();
                return;
            }
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
            if (txtGen.Text.Trim() == "")
            {
                MessageBox.Show("职业不能为空", "提示");
                txtGen.Focus();
                return;
            }
            sql = "update reader set ReaderName='" + txtName.Text + "',ReaderPwd='" + txtPsw.Text + "',ReaderEmail='" + txtEmail.Text + "',ReaderGender='" + txtGen.Text + "',ReaderTel='" + txtPhone.Text + "',ReaderBookQuantity='" + txtNownum.Text + "',ReaderDept='" + txtRdt.Text + "' where ReaderID='" + txtId.Text + "'";
            DataUpdate(sql);
            RefreshData();
            Cancel();
            Reset();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
