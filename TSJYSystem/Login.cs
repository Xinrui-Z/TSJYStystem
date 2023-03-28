using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSJYSystem
{
    public partial class Login : Form
    {
        string path = Application.StartupPath + "\\" + "DbSet.ini";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                cmbRole.SelectedIndex = 0;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //合法性校验
                if (txtId.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空", "错误");
                    txtId.Focus();
                    return;
                }
                else if (txtPwd.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空", "错误");
                    txtPwd.Focus();
                    return;
                }

                // 验证身份
                this.Text = "正在验证身份...";
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                string sqlStr = "";
                string LoginID = "";
                string tableName = "";
                string passwordFieldName = "";
                string nameFieldName = "";
                if (cmbRole.SelectedIndex == 1)
                {
                    LoginID = "ReaderID";
                    tableName = "Reader";
                    passwordFieldName = "ReaderPwd";
                    nameFieldName = "ReaderName";
                }
                else if (cmbRole.SelectedIndex == 2)
                {
                    LoginID = "WorkerID";
                    tableName = "Worker";
                    passwordFieldName = "WorkerPwd";
                    nameFieldName = "WorkerName";
                }
                else
                {
                    MessageBox.Show("请选择您的角色！", "提示");
                    return;
                }
                sqlStr = string.Format("SELECT {0}, {1} FROM {2} WHERE {3} = '{4}'", nameFieldName, passwordFieldName, tableName, LoginID, txtId.Text.Trim());
                CDataBase.conn.ConnectionString = CDataBase.connstr;
                DataSet ds = new DataSet();
                ds = CDataBase.GetDataFromDB(sqlStr);
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("账号错误，请重新输入", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "登录";
                    txtId.Text = "";
                    txtPwd.Text = "";
                    txtId.Focus();
                }
                else if (ds.Tables[0].Rows[0][passwordFieldName].ToString().Trim() == txtPwd.Text.Trim())
                {
                    // 登录成功
                    CPublic.userInfo[0] = cmbRole.Text.Trim();
                    CPublic.userInfo[1] = txtId.Text.Trim();
                    CPublic.userInfo[2] = txtPwd.Text.Trim();
                    CPublic.userInfo[3] = ds.Tables[0].Rows[0][nameFieldName].ToString().Trim();
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "登录";
                    if (CPublic.userInfo[0] == "工作人员")
                    {
                        MainWorker mainA = new MainWorker();
                        mainA.Show(this);
                    }
                    else
                    {
                        MainReader mainR = new MainReader();
                        mainR.Show(this);
                    }
                    this.Hide();
                    txtId.Text = "";
                    txtPwd.Text = "";
                    CDataBase.conn.Close();
                }
                else
                {
                    MessageBox.Show("密码错误，请重新输入", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "登录";
                    txtPwd.Text = "";
                    txtPwd.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录异常");
                this.Cursor = System.Windows.Forms.Cursors.Arrow;
                txtId.Text = "";
                txtPwd.Text = "";
                txtId.Focus();
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPwd.Text = "";
            txtId.Focus();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        
    }
}
