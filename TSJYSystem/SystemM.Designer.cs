
namespace TSJYSystem
{
    partial class SystemM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemM));
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelOld = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.txtPwdNew = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRe = new System.Windows.Forms.Button();
            this.txtPwdNewConfirm = new System.Windows.Forms.TextBox();
            this.labelOk = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.comRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold);
            this.labelUserName.Location = new System.Drawing.Point(384, 200);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(114, 33);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "用户名";
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold);
            this.labelOld.Location = new System.Drawing.Point(384, 279);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(114, 33);
            this.labelOld.TabIndex = 2;
            this.labelOld.Text = "原密码";
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold);
            this.labelNew.Location = new System.Drawing.Point(384, 371);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(114, 33);
            this.labelNew.TabIndex = 3;
            this.labelNew.Text = "新密码";
            // 
            // txtPwdNew
            // 
            this.txtPwdNew.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.txtPwdNew.Location = new System.Drawing.Point(549, 371);
            this.txtPwdNew.Name = "txtPwdNew";
            this.txtPwdNew.PasswordChar = '*';
            this.txtPwdNew.Size = new System.Drawing.Size(148, 35);
            this.txtPwdNew.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.txtPwd.Location = new System.Drawing.Point(549, 287);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(148, 35);
            this.txtPwd.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.txtId.Location = new System.Drawing.Point(549, 202);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 35);
            this.txtId.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRe);
            this.groupBox1.Controls.Add(this.txtPwdNewConfirm);
            this.groupBox1.Controls.Add(this.labelOk);
            this.groupBox1.Controls.Add(this.btReset);
            this.groupBox1.Controls.Add(this.btChange);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtPwdNew);
            this.groupBox1.Controls.Add(this.labelNew);
            this.groupBox1.Controls.Add(this.labelOld);
            this.groupBox1.Controls.Add(this.comRole);
            this.groupBox1.Controls.Add(this.labelUserName);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 837);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.btnRe.Location = new System.Drawing.Point(652, 580);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(123, 39);
            this.btnRe.TabIndex = 12;
            this.btnRe.Text = "返回";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // txtPwdNewConfirm
            // 
            this.txtPwdNewConfirm.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.txtPwdNewConfirm.Location = new System.Drawing.Point(549, 457);
            this.txtPwdNewConfirm.Name = "txtPwdNewConfirm";
            this.txtPwdNewConfirm.PasswordChar = '*';
            this.txtPwdNewConfirm.Size = new System.Drawing.Size(148, 35);
            this.txtPwdNewConfirm.TabIndex = 11;
            // 
            // labelOk
            // 
            this.labelOk.AutoSize = true;
            this.labelOk.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold);
            this.labelOk.Location = new System.Drawing.Point(384, 457);
            this.labelOk.Name = "labelOk";
            this.labelOk.Size = new System.Drawing.Size(115, 33);
            this.labelOk.TabIndex = 10;
            this.labelOk.Text = "确  认";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.btReset.Location = new System.Drawing.Point(492, 580);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(123, 39);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "重置";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btChange
            // 
            this.btChange.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.btChange.Location = new System.Drawing.Point(332, 580);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(123, 39);
            this.btChange.TabIndex = 8;
            this.btChange.Text = "修改";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // comRole
            // 
            this.comRole.AutoSize = true;
            this.comRole.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold);
            this.comRole.Location = new System.Drawing.Point(384, 115);
            this.comRole.Name = "comRole";
            this.comRole.Size = new System.Drawing.Size(115, 33);
            this.comRole.TabIndex = 0;
            this.comRole.Text = "角  色";
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 24;
            this.cmbRole.Items.AddRange(new object[] {
            "请选择",
            "读者",
            "工作人员"});
            this.cmbRole.Location = new System.Drawing.Point(549, 120);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(150, 32);
            this.cmbRole.TabIndex = 4;
            // 
            // SystemM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SystemM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Change_FormClosed);
            this.Load += new System.EventHandler(this.Chaneg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelOld;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.TextBox txtPwdNew;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox txtPwdNewConfirm;
        private System.Windows.Forms.Label labelOk;
        private System.Windows.Forms.Label comRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnRe;
    }
}