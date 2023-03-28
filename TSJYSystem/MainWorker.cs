using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSJYSystem
{
    public partial class MainWorker : Form
    {
        public MainWorker()
        {
            InitializeComponent();
        }
        private void MainA_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                lblUser.Text = "你好" + CPublic.userInfo[3] + ",欢迎进入本系统";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenBookManagementForm(object sender, EventArgs e)
        {
            BookM book = new BookM();
            book.Show(this);
            this.Hide();
        }

        private void OpenReaderManagementForm(object sender, EventArgs e)
        {
            ReaderM rim = new ReaderM();
            rim.Show(this);
            this.Hide();
        }

        private void OpenBorrowForm(object sender, EventArgs e)
        {
            BorrowM record = new BorrowM();
            record.Show(this);
            this.Hide();
        }

        private void OpenReturnForm(object sender, EventArgs e)
        {
            ReturnM record = new ReturnM();
            record.Show(this);
            this.Hide();
        }

        private void OpenSystemManageForm(object sender, EventArgs e)
        {
            SystemM change = new SystemM();
            change.Show(this);
            this.Hide();
        }

        private void OpenReaderTypeManagementForm(object sender, EventArgs e)
        {
            ReaderTypeM retype = new ReaderTypeM();
            retype.Show(this);
            this.Hide();
        }

        private void OpenBookTypeManagementForm(object sender, EventArgs e)
        {
            BookTypeM booktype = new BookTypeM();
            booktype.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PressM press = new PressM();
            press.Show(this);
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
