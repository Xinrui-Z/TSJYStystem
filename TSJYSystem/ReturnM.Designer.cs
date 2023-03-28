namespace TSJYSystem
{
    partial class ReturnM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnM));
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReturn
            // 
            this.dgvReturn.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturn.EnableHeadersVisualStyles = false;
            this.dgvReturn.Location = new System.Drawing.Point(9, 86);
            this.dgvReturn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.dgvReturn.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturn.RowTemplate.Height = 27;
            this.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturn.ShowCellToolTips = false;
            this.dgvReturn.ShowEditingIcon = false;
            this.dgvReturn.Size = new System.Drawing.Size(1164, 764);
            this.dgvReturn.TabIndex = 31;
            this.dgvReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRe.Location = new System.Drawing.Point(484, 33);
            this.btnRe.Margin = new System.Windows.Forms.Padding(2);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(81, 32);
            this.btnRe.TabIndex = 30;
            this.btnRe.Text = "返回";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAll.Location = new System.Drawing.Point(898, 33);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(130, 32);
            this.btnAll.TabIndex = 29;
            this.btnAll.Text = "所有信息";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(394, 33);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 32);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.txtSelect.Location = new System.Drawing.Point(231, 33);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(116, 26);
            this.txtSelect.TabIndex = 27;
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
            "还书时间",
            "应还时间",
            "状态"});
            this.cmbSelect.Location = new System.Drawing.Point(100, 35);
            this.cmbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(123, 27);
            this.cmbSelect.TabIndex = 26;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(11, 36);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(80, 21);
            this.lblSelect.TabIndex = 25;
            this.lblSelect.Text = "查  询";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(781, 33);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(81, 32);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "归还";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtReturn
            // 
            this.txtReturn.Font = new System.Drawing.Font("楷体", 14F);
            this.txtReturn.Location = new System.Drawing.Point(644, 35);
            this.txtReturn.Margin = new System.Windows.Forms.Padding(2);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(124, 29);
            this.txtReturn.TabIndex = 34;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblReturn.Location = new System.Drawing.Point(590, 38);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(56, 21);
            this.lblReturn.TabIndex = 33;
            this.lblReturn.Text = "归还";
            // 
            // lblReaderID
            // 
            this.lblReaderID.AutoSize = true;
            this.lblReaderID.Location = new System.Drawing.Point(648, 69);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(0, 12);
            this.lblReaderID.TabIndex = 35;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(229, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(114, 12);
            this.lblTime.TabIndex = 36;
            this.lblTime.Text = "示例：2023-03-26";
            this.lblTime.Visible = false;
            // 
            // ReturnM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblReaderID);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvReturn);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.lblSelect);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "归还信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Record_FormClosed);
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.Label lblTime;
    }
}