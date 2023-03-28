namespace TSJYSystem
{
    partial class BorrowM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowM));
            this.lblSelect = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtBtime = new System.Windows.Forms.TextBox();
            this.lblBtime = new System.Windows.Forms.Label();
            this.lblRtime = new System.Windows.Forms.Label();
            this.txtRtime = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnBConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRname = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.txtEtime = new System.Windows.Forms.TextBox();
            this.lblEtime = new System.Windows.Forms.Label();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblBname = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(13, 161);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(103, 21);
            this.lblSelect.TabIndex = 18;
            this.lblSelect.Text = "查  询：";
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "查询条件",
            "图书编号",
            "读者证号",
            "借书时间",
            "归还时间",
            "应还时间",
            "状态"});
            this.cmbSelect.Location = new System.Drawing.Point(120, 158);
            this.cmbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(120, 27);
            this.cmbSelect.TabIndex = 19;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // txtSelect
            // 
            this.txtSelect.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.txtSelect.Location = new System.Drawing.Point(249, 157);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(136, 26);
            this.txtSelect.TabIndex = 20;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(409, 154);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 32);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAll.Location = new System.Drawing.Point(753, 154);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(121, 32);
            this.btnAll.TabIndex = 22;
            this.btnAll.Text = "所有信息";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRe.Location = new System.Drawing.Point(882, 154);
            this.btnRe.Margin = new System.Windows.Forms.Padding(2);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(81, 32);
            this.btnRe.TabIndex = 23;
            this.btnRe.Text = "返回";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 15.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrow.Location = new System.Drawing.Point(5, 205);
            this.dgvBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowTemplate.Height = 27;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(1170, 645);
            this.dgvBorrow.TabIndex = 24;
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(11, 39);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(102, 21);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "借书证号";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("楷体", 14F);
            this.txtId.Location = new System.Drawing.Point(120, 33);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 29);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNo.Location = new System.Drawing.Point(296, 39);
            this.lblNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(102, 21);
            this.lblNo.TabIndex = 4;
            this.lblNo.Text = "图书编号";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("楷体", 14F);
            this.txtNo.Location = new System.Drawing.Point(409, 33);
            this.txtNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(120, 29);
            this.txtNo.TabIndex = 5;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // txtBtime
            // 
            this.txtBtime.Font = new System.Drawing.Font("楷体", 14F);
            this.txtBtime.Location = new System.Drawing.Point(736, 36);
            this.txtBtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBtime.Name = "txtBtime";
            this.txtBtime.Size = new System.Drawing.Size(120, 29);
            this.txtBtime.TabIndex = 6;
            // 
            // lblBtime
            // 
            this.lblBtime.AutoSize = true;
            this.lblBtime.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBtime.Location = new System.Drawing.Point(628, 40);
            this.lblBtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtime.Name = "lblBtime";
            this.lblBtime.Size = new System.Drawing.Size(102, 21);
            this.lblBtime.TabIndex = 7;
            this.lblBtime.Text = "借书时间";
            // 
            // lblRtime
            // 
            this.lblRtime.AutoSize = true;
            this.lblRtime.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRtime.Location = new System.Drawing.Point(13, 97);
            this.lblRtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRtime.Name = "lblRtime";
            this.lblRtime.Size = new System.Drawing.Size(102, 21);
            this.lblRtime.TabIndex = 8;
            this.lblRtime.Text = "归还时间";
            // 
            // txtRtime
            // 
            this.txtRtime.Font = new System.Drawing.Font("楷体", 14F);
            this.txtRtime.Location = new System.Drawing.Point(120, 91);
            this.txtRtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtRtime.Name = "txtRtime";
            this.txtRtime.Size = new System.Drawing.Size(120, 29);
            this.txtRtime.TabIndex = 9;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblState.Location = new System.Drawing.Point(628, 97);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(104, 21);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "状    态";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("楷体", 14F);
            this.txtState.Location = new System.Drawing.Point(736, 93);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(120, 29);
            this.txtState.TabIndex = 11;
            // 
            // btnBConfirm
            // 
            this.btnBConfirm.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBConfirm.Location = new System.Drawing.Point(632, 154);
            this.btnBConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnBConfirm.Name = "btnBConfirm";
            this.btnBConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnBConfirm.TabIndex = 14;
            this.btnBConfirm.Text = "确认";
            this.btnBConfirm.UseVisualStyleBackColor = true;
            this.btnBConfirm.Click += new System.EventHandler(this.btnBConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(882, 90);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(882, 33);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 32);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRname
            // 
            this.lblRname.AutoSize = true;
            this.lblRname.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRname.Location = new System.Drawing.Point(118, 70);
            this.lblRname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRname.Name = "lblRname";
            this.lblRname.Size = new System.Drawing.Size(0, 12);
            this.lblRname.TabIndex = 27;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBorrow.Location = new System.Drawing.Point(632, 155);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(100, 30);
            this.btnBorrow.TabIndex = 12;
            this.btnBorrow.Text = "借书";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // txtEtime
            // 
            this.txtEtime.Font = new System.Drawing.Font("楷体", 14F);
            this.txtEtime.Location = new System.Drawing.Point(409, 91);
            this.txtEtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtEtime.Name = "txtEtime";
            this.txtEtime.Size = new System.Drawing.Size(120, 29);
            this.txtEtime.TabIndex = 26;
            // 
            // lblEtime
            // 
            this.lblEtime.AutoSize = true;
            this.lblEtime.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEtime.Location = new System.Drawing.Point(296, 97);
            this.lblEtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtime.Name = "lblEtime";
            this.lblEtime.Size = new System.Drawing.Size(102, 21);
            this.lblEtime.TabIndex = 25;
            this.lblEtime.Text = "应还时间";
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRType.Location = new System.Drawing.Point(212, 70);
            this.lblRType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(0, 12);
            this.lblRType.TabIndex = 29;
            // 
            // lblBname
            // 
            this.lblBname.AutoSize = true;
            this.lblBname.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBname.Location = new System.Drawing.Point(407, 70);
            this.lblBname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBname.Name = "lblBname";
            this.lblBname.Size = new System.Drawing.Size(0, 12);
            this.lblBname.TabIndex = 30;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(247, 188);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(114, 12);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "示例：2023-03-26";
            this.lblTime.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1019, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 44);
            this.label1.TabIndex = 47;
            this.label1.Text = "借书时，请先点击“借书\"按钮！";
            // 
            // BorrowM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBname);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblRname);
            this.Controls.Add(this.txtEtime);
            this.Controls.Add(this.lblEtime);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBConfirm);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtRtime);
            this.Controls.Add(this.lblRtime);
            this.Controls.Add(this.lblBtime);
            this.Controls.Add(this.txtBtime);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借阅信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Borrow_FormClosed);
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtBtime;
        private System.Windows.Forms.Label lblBtime;
        private System.Windows.Forms.Label lblRtime;
        private System.Windows.Forms.TextBox txtRtime;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnBConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRname;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtEtime;
        private System.Windows.Forms.Label lblEtime;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblBname;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
    }
}