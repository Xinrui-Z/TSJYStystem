
namespace TSJYSystem
{
    partial class BookTypeM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTypeM));
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateConfirm = new System.Windows.Forms.Button();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.btnAddConfirm = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBookType = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRetren = new System.Windows.Forms.Button();
            this.TypeName = new System.Windows.Forms.TextBox();
            this.TyName = new System.Windows.Forms.Label();
            this.txtTypeIo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(524, 14);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(81, 32);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(272, 70);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 32);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateConfirm
            // 
            this.btnUpdateConfirm.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateConfirm.Location = new System.Drawing.Point(272, 71);
            this.btnUpdateConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateConfirm.Name = "btnUpdateConfirm";
            this.btnUpdateConfirm.Size = new System.Drawing.Size(81, 32);
            this.btnUpdateConfirm.TabIndex = 32;
            this.btnUpdateConfirm.Text = "确认";
            this.btnUpdateConfirm.UseVisualStyleBackColor = true;
            this.btnUpdateConfirm.Visible = false;
            this.btnUpdateConfirm.Click += new System.EventHandler(this.btnUpdateConfirm_Click);
            // 
            // cmbSelect
            // 
            this.cmbSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "类别编号",
            "类别名称"});
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "查询条件",
            "类别编号",
            "类别名称"});
            this.cmbSelect.Location = new System.Drawing.Point(117, 124);
            this.cmbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(118, 27);
            this.cmbSelect.TabIndex = 34;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddConfirm.Location = new System.Drawing.Point(406, 14);
            this.btnAddConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(81, 32);
            this.btnAddConfirm.TabIndex = 31;
            this.btnAddConfirm.Text = "确认";
            this.btnAddConfirm.UseVisualStyleBackColor = true;
            this.btnAddConfirm.Visible = false;
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(9, 127);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(104, 21);
            this.lblSelect.TabIndex = 35;
            this.lblSelect.Text = "查    询";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(406, 71);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 32);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSelect.Location = new System.Drawing.Point(272, 125);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(116, 26);
            this.txtSelect.TabIndex = 36;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(406, 121);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 32);
            this.btnSelect.TabIndex = 37;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.Type.Location = new System.Drawing.Point(9, 23);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(102, 21);
            this.Type.TabIndex = 3;
            this.Type.Text = "类别编号";
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAll.Location = new System.Drawing.Point(524, 119);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(121, 32);
            this.btnAll.TabIndex = 38;
            this.btnAll.Text = "所有信息";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(406, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 32);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvBookType
            // 
            this.dgvBookType.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookType.EnableHeadersVisualStyles = false;
            this.dgvBookType.Location = new System.Drawing.Point(5, 161);
            this.dgvBookType.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBookType.Name = "dgvBookType";
            this.dgvBookType.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("楷体", 12.5F, System.Drawing.FontStyle.Bold);
            this.dgvBookType.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookType.RowTemplate.Height = 27;
            this.dgvBookType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookType.ShowCellToolTips = false;
            this.dgvBookType.ShowEditingIcon = false;
            this.dgvBookType.Size = new System.Drawing.Size(1171, 688);
            this.dgvBookType.TabIndex = 0;
            this.dgvBookType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(272, 14);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 32);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRetren
            // 
            this.btnRetren.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRetren.Location = new System.Drawing.Point(524, 69);
            this.btnRetren.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetren.Name = "btnRetren";
            this.btnRetren.Size = new System.Drawing.Size(81, 32);
            this.btnRetren.TabIndex = 41;
            this.btnRetren.Text = "返回首页";
            this.btnRetren.UseVisualStyleBackColor = true;
            this.btnRetren.Click += new System.EventHandler(this.btnRetren_Click);
            // 
            // TypeName
            // 
            this.TypeName.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.TypeName.Location = new System.Drawing.Point(117, 72);
            this.TypeName.Margin = new System.Windows.Forms.Padding(2);
            this.TypeName.Name = "TypeName";
            this.TypeName.Size = new System.Drawing.Size(118, 31);
            this.TypeName.TabIndex = 43;
            // 
            // TyName
            // 
            this.TyName.AutoSize = true;
            this.TyName.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.TyName.Location = new System.Drawing.Point(9, 77);
            this.TyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TyName.Name = "TyName";
            this.TyName.Size = new System.Drawing.Size(102, 21);
            this.TyName.TabIndex = 42;
            this.TyName.Text = "类别名称\r\n";
            // 
            // txtTypeIo
            // 
            this.txtTypeIo.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTypeIo.Location = new System.Drawing.Point(117, 19);
            this.txtTypeIo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeIo.Name = "txtTypeIo";
            this.txtTypeIo.Size = new System.Drawing.Size(118, 31);
            this.txtTypeIo.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(634, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "添加图书类别信息，请先点击“添加”按钮！";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTypeIo);
            this.groupBox1.Controls.Add(this.TyName);
            this.groupBox1.Controls.Add(this.TypeName);
            this.groupBox1.Controls.Add(this.btnRetren);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.dgvBookType);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtSelect);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblSelect);
            this.groupBox1.Controls.Add(this.btnAddConfirm);
            this.groupBox1.Controls.Add(this.cmbSelect);
            this.groupBox1.Controls.Add(this.btnUpdateConfirm);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 855);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // BookTypeM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookTypeM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书类别管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookType_FormClosed);
            this.Load += new System.EventHandler(this.BookType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateConfirm;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Button btnAddConfirm;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBookType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRetren;
        private System.Windows.Forms.TextBox TypeName;
        private System.Windows.Forms.Label TyName;
        private System.Windows.Forms.TextBox txtTypeIo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}