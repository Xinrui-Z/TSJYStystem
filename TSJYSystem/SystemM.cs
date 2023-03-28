using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TSJYSystem
{
    public partial class SystemM : Form
    {
        string path = Application.StartupPath + "\\" + "DbSet.ini";
        public SystemM()
        {
            InitializeComponent();
        }

        private void Chaneg_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                cmbRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            try
            {
                // 检查输入的用户名、原密码和新密码是否为空
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("用户名不能为空", "错误");
                    txtId.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPwd.Text))
                {
                    MessageBox.Show("原密码不能为空", "错误");
                    txtPwd.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPwdNew.Text))
                {
                    MessageBox.Show("新密码不能为空", "错误");
                    txtPwdNew.Focus();
                    return;
                }

                // 获取用户角色，确定要查询的表名和字段名
                string role = cmbRole.Text.Trim();
                string tableName = role == "工作人员" ? "Worker" : "Reader";
                string idFieldName = $"{tableName}ID";
                string nameFieldName = $"{tableName}Name";
                string pwdFieldName = $"{tableName}Pwd";

                // 查询用户信息
                string sqlStr = $"SELECT {nameFieldName}, {pwdFieldName} FROM {tableName} WHERE {idFieldName} = '{txtId.Text.Trim()}'";
                DataSet ds = CDataBase.GetDataFromDB(sqlStr);

                // 判断查询结果是否为空
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("账号错误，请重新输入", "错误");
                    ClearTextFields();
                    txtId.Focus();
                    return;
                }

                // 判断原密码是否正确
                string pwd = ds.Tables[0].Rows[0][pwdFieldName].ToString().Trim();
                if (pwd != txtPwd.Text.Trim())
                {
                    MessageBox.Show("密码错误，请重新输入", "错误");
                    ClearTextFields();
                    txtPwd.Focus();
                    return;
                }

                // 判断新密码和确认密码是否一致
                string newPwd = txtPwdNew.Text.Trim();
                string confirmPwd = txtPwdNewConfirm.Text.Trim();
                if (newPwd != confirmPwd)
                {
                    MessageBox.Show("两次输入密码不一致", "错误");
                    txtPwdNewConfirm.Focus();
                    return;
                }

                // 判断新密码是否与原密码相同
                if (newPwd == pwd)
                {
                    MessageBox.Show("修改失败，原密码与新密码相同", "错误");
                    ClearTextFields();
                    txtPwd.Focus();
                    return;
                }

                // 更新用户密码
                string updateSql = $"UPDATE {tableName} SET {pwdFieldName} = '{newPwd}' WHERE {idFieldName} = '{txtId.Text.Trim()}'";
                if (CDataBase.UpdateDB(updateSql))
                {
                    MessageBox.Show("信息修改成功", "提示");
                    ClearTextFields();
                }
                else
                {
                    MessageBox.Show("密码修改失败，请稍后重试", "错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"密码修改失败！{ex.Message}", "错误");
            }
        }

        private void ClearTextFields()
        {
            txtId.Clear();
            txtPwd.Clear();
            txtPwdNew.Clear();
            txtPwdNewConfirm.Clear();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPwd.Text = "";
            txtPwdNew.Text = "";
            txtPwdNewConfirm.Text = "";
            txtId.Focus();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }
    }

   }

