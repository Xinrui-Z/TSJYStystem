
namespace TSJYSystem
{
    partial class ReaderIdentityM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderIdentityM));
            this.lblName = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblNownum = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRdt = new System.Windows.Forms.TextBox();
            this.lblRdt = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdateConfirm = new System.Windows.Forms.Button();
            this.btnAddConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.btnRetren = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNownum = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(15, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPsw.Location = new System.Drawing.Point(633, 31);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(104, 21);
            this.lblPsw.TabIndex = 1;
            this.lblPsw.Text = "密    码";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblGen.Location = new System.Drawing.Point(14, 108);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(56, 21);
            this.lblGen.TabIndex = 2;
            this.lblGen.Text = "性别";
            // 
            // lblNownum
            // 
            this.lblNownum.AutoSize = true;
            this.lblNownum.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNownum.Location = new System.Drawing.Point(635, 108);
            this.lblNownum.Name = "lblNownum";
            this.lblNownum.Size = new System.Drawing.Size(102, 21);
            this.lblNownum.TabIndex = 3;
            this.lblNownum.Text = "现借书数";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(296, 108);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 21);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "联系电话";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(75, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 29);
            this.txtName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRdt);
            this.groupBox1.Controls.Add(this.lblRdt);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtGen);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdateConfirm);
            this.groupBox1.Controls.Add(this.btnAddConfirm);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.dgvReader);
            this.groupBox1.Controls.Add(this.btnRetren);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtNownum);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtPsw);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblGen);
            this.groupBox1.Controls.Add(this.lblNownum);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPsw);
            this.groupBox1.Location = new System.Drawing.Point(-2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 858);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(635, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "添加读者信息，请先点击“添加”按钮！";
            // 
            // txtRdt
            // 
            this.txtRdt.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRdt.Location = new System.Drawing.Point(1031, 104);
            this.txtRdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtRdt.Name = "txtRdt";
            this.txtRdt.Size = new System.Drawing.Size(118, 29);
            this.txtRdt.TabIndex = 52;
            this.txtRdt.TextChanged += new System.EventHandler(this.txtRdt_TextChanged);
            // 
            // lblRdt
            // 
            this.lblRdt.AutoSize = true;
            this.lblRdt.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRdt.Location = new System.Drawing.Point(977, 109);
            this.lblRdt.Name = "lblRdt";
            this.lblRdt.Size = new System.Drawing.Size(56, 21);
            this.lblRdt.TabIndex = 51;
            this.lblRdt.Text = "单位";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(1031, 27);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 29);
            this.txtEmail.TabIndex = 50;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(977, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 21);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "邮箱";
            // 
            // txtGen
            // 
            this.txtGen.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGen.Location = new System.Drawing.Point(75, 104);
            this.txtGen.Margin = new System.Windows.Forms.Padding(2);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(118, 29);
            this.txtGen.TabIndex = 48;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(215, 150);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(81, 32);
            this.btnDel.TabIndex = 44;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(115, 150);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 32);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(15, 150);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdateConfirm
            // 
            this.btnUpdateConfirm.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateConfirm.Location = new System.Drawing.Point(115, 150);
            this.btnUpdateConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateConfirm.Name = "btnUpdateConfirm";
            this.btnUpdateConfirm.Size = new System.Drawing.Size(81, 32);
            this.btnUpdateConfirm.TabIndex = 46;
            this.btnUpdateConfirm.Text = "确认";
            this.btnUpdateConfirm.UseVisualStyleBackColor = true;
            this.btnUpdateConfirm.Visible = false;
            this.btnUpdateConfirm.Click += new System.EventHandler(this.btnUpdateConfirm_Click);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddConfirm.Location = new System.Drawing.Point(15, 150);
            this.btnAddConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(81, 32);
            this.btnAddConfirm.TabIndex = 45;
            this.btnAddConfirm.Text = "确认";
            this.btnAddConfirm.UseVisualStyleBackColor = true;
            this.btnAddConfirm.Visible = false;
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(317, 150);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 32);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvReader
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.dgvReader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReader.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 15.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReader.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReader.Location = new System.Drawing.Point(9, 198);
            this.dgvReader.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReader.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReader.RowTemplate.Height = 27;
            this.dgvReader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReader.ShowCellToolTips = false;
            this.dgvReader.ShowEditingIcon = false;
            this.dgvReader.Size = new System.Drawing.Size(1170, 648);
            this.dgvReader.TabIndex = 41;
            this.dgvReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReader_CellContentClick);
            // 
            // btnRetren
            // 
            this.btnRetren.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRetren.Location = new System.Drawing.Point(527, 150);
            this.btnRetren.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetren.Name = "btnRetren";
            this.btnRetren.Size = new System.Drawing.Size(81, 32);
            this.btnRetren.TabIndex = 40;
            this.btnRetren.Text = "返回首页";
            this.btnRetren.UseVisualStyleBackColor = true;
            this.btnRetren.Click += new System.EventHandler(this.btnRetren_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(420, 150);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 32);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtId.Location = new System.Drawing.Point(400, 27);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(118, 29);
            this.txtId.TabIndex = 38;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(296, 31);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(102, 21);
            this.lblId.TabIndex = 37;
            this.lblId.Text = "借书证号";
            // 
            // txtNownum
            // 
            this.txtNownum.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNownum.Location = new System.Drawing.Point(738, 105);
            this.txtNownum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNownum.Name = "txtNownum";
            this.txtNownum.Size = new System.Drawing.Size(118, 29);
            this.txtNownum.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(400, 104);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 29);
            this.txtPhone.TabIndex = 11;
            // 
            // txtPsw
            // 
            this.txtPsw.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPsw.Location = new System.Drawing.Point(738, 29);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(2);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(118, 29);
            this.txtPsw.TabIndex = 7;
            // 
            // ReaderIdentityM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReaderIdentityM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者身份管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RSManage_FormClosed);
            this.Load += new System.EventHandler(this.RSManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblNownum;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNownum;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnRetren;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdateConfirm;
        private System.Windows.Forms.Button btnAddConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtRdt;
        private System.Windows.Forms.Label lblRdt;
        private System.Windows.Forms.Label label1;
    }
}