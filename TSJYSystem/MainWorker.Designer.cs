namespace TSJYSystem
{
    partial class MainWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWorker));
            this.lblSystemName = new System.Windows.Forms.Label();
            this.BookM = new System.Windows.Forms.Button();
            this.ReaderM = new System.Windows.Forms.Button();
            this.BookBorrowM = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SystemM = new System.Windows.Forms.Button();
            this.BookReturnM = new System.Windows.Forms.Button();
            this.BookTypeM = new System.Windows.Forms.Button();
            this.ReaderTypeM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("华文行楷", 40F);
            this.lblSystemName.Location = new System.Drawing.Point(360, 50);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(457, 57);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "图书借阅管理系统";
            // 
            // BookM
            // 
            this.BookM.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookM.Location = new System.Drawing.Point(492, 201);
            this.BookM.Margin = new System.Windows.Forms.Padding(2);
            this.BookM.Name = "BookM";
            this.BookM.Size = new System.Drawing.Size(200, 75);
            this.BookM.TabIndex = 1;
            this.BookM.Text = "图书管理";
            this.BookM.UseVisualStyleBackColor = true;
            this.BookM.Click += new System.EventHandler(this.OpenBookManagementForm);
            // 
            // ReaderM
            // 
            this.ReaderM.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReaderM.Location = new System.Drawing.Point(216, 367);
            this.ReaderM.Margin = new System.Windows.Forms.Padding(2);
            this.ReaderM.Name = "ReaderM";
            this.ReaderM.Size = new System.Drawing.Size(200, 75);
            this.ReaderM.TabIndex = 2;
            this.ReaderM.Text = "读者管理";
            this.ReaderM.UseVisualStyleBackColor = true;
            this.ReaderM.Click += new System.EventHandler(this.OpenReaderManagementForm);
            // 
            // BookBorrowM
            // 
            this.BookBorrowM.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookBorrowM.Location = new System.Drawing.Point(492, 367);
            this.BookBorrowM.Margin = new System.Windows.Forms.Padding(2);
            this.BookBorrowM.Name = "BookBorrowM";
            this.BookBorrowM.Size = new System.Drawing.Size(200, 75);
            this.BookBorrowM.TabIndex = 3;
            this.BookBorrowM.Text = "图书借阅";
            this.BookBorrowM.UseVisualStyleBackColor = true;
            this.BookBorrowM.Click += new System.EventHandler(this.OpenBorrowForm);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(764, 552);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 75);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // SystemM
            // 
            this.SystemM.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SystemM.Location = new System.Drawing.Point(492, 552);
            this.SystemM.Margin = new System.Windows.Forms.Padding(2);
            this.SystemM.Name = "SystemM";
            this.SystemM.Size = new System.Drawing.Size(200, 75);
            this.SystemM.TabIndex = 5;
            this.SystemM.Text = "系统管理";
            this.SystemM.UseVisualStyleBackColor = true;
            this.SystemM.Click += new System.EventHandler(this.OpenSystemManageForm);
            // 
            // BookReturnM
            // 
            this.BookReturnM.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookReturnM.Location = new System.Drawing.Point(764, 367);
            this.BookReturnM.Margin = new System.Windows.Forms.Padding(2);
            this.BookReturnM.Name = "BookReturnM";
            this.BookReturnM.Size = new System.Drawing.Size(200, 75);
            this.BookReturnM.TabIndex = 6;
            this.BookReturnM.Text = "图书归还";
            this.BookReturnM.UseVisualStyleBackColor = true;
            this.BookReturnM.Click += new System.EventHandler(this.OpenReturnForm);
            // 
            // BookTypeM
            // 
            this.BookTypeM.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookTypeM.Location = new System.Drawing.Point(217, 201);
            this.BookTypeM.Margin = new System.Windows.Forms.Padding(2);
            this.BookTypeM.Name = "BookTypeM";
            this.BookTypeM.Size = new System.Drawing.Size(200, 75);
            this.BookTypeM.TabIndex = 8;
            this.BookTypeM.Text = "图书类别管理";
            this.BookTypeM.UseVisualStyleBackColor = true;
            this.BookTypeM.Click += new System.EventHandler(this.OpenBookTypeManagementForm);
            // 
            // ReaderTypeM
            // 
            this.ReaderTypeM.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReaderTypeM.Location = new System.Drawing.Point(764, 201);
            this.ReaderTypeM.Margin = new System.Windows.Forms.Padding(2);
            this.ReaderTypeM.Name = "ReaderTypeM";
            this.ReaderTypeM.Size = new System.Drawing.Size(200, 75);
            this.ReaderTypeM.TabIndex = 9;
            this.ReaderTypeM.Text = "读者类型管理";
            this.ReaderTypeM.UseVisualStyleBackColor = true;
            this.ReaderTypeM.Click += new System.EventHandler(this.OpenReaderTypeManagementForm);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(216, 552);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 75);
            this.button1.TabIndex = 10;
            this.button1.Text = "出版社管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.Location = new System.Drawing.Point(11, 816);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // MainWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.BookM);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.ReaderM);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.SystemM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReaderTypeM);
            this.Controls.Add(this.BookReturnM);
            this.Controls.Add(this.BookBorrowM);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.BookTypeM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.MainA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button BookM;
        private System.Windows.Forms.Button ReaderM;
        private System.Windows.Forms.Button BookBorrowM;
        private System.Windows.Forms.Button btnQuit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SystemM;
        private System.Windows.Forms.Button BookReturnM;
        private System.Windows.Forms.Button btnReaderMa;
        private System.Windows.Forms.Button BookTypeM;
        private System.Windows.Forms.Button ReaderTypeM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUser;
    }
}