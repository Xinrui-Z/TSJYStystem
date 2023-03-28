namespace TSJYSystem
{
    partial class MainReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReader));
            this.btnBookInfo = new System.Windows.Forms.Button();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbxBookInfo = new System.Windows.Forms.GroupBox();
            this.txtBorrow = new System.Windows.Forms.TextBox();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.gbxMyInfo = new System.Windows.Forms.GroupBox();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRdept = new System.Windows.Forms.TextBox();
            this.lblRDept = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.lblPsw = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbxRecord = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.lblRType = new System.Windows.Forms.Label();
            this.gbxBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.gbxMyInfo.SuspendLayout();
            this.gbxRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBookInfo.Location = new System.Drawing.Point(15, 11);
            this.btnBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Size = new System.Drawing.Size(117, 39);
            this.btnBookInfo.TabIndex = 0;
            this.btnBookInfo.Text = "图书信息";
            this.btnBookInfo.UseVisualStyleBackColor = true;
            this.btnBookInfo.Click += new System.EventHandler(this.btnBookInfo_Click);
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMyInfo.Location = new System.Drawing.Point(169, 11);
            this.btnMyInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(117, 39);
            this.btnMyInfo.TabIndex = 1;
            this.btnMyInfo.Text = "个人信息";
            this.btnMyInfo.UseVisualStyleBackColor = true;
            this.btnMyInfo.Click += new System.EventHandler(this.btnMyInfo_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord.Location = new System.Drawing.Point(324, 11);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(117, 39);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "借书记录";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(1050, 11);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(117, 39);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbxBookInfo
            // 
            this.gbxBookInfo.Controls.Add(this.txtBorrow);
            this.gbxBookInfo.Controls.Add(this.lblBorrow);
            this.gbxBookInfo.Controls.Add(this.btnBorrow);
            this.gbxBookInfo.Controls.Add(this.dgvBook);
            this.gbxBookInfo.Controls.Add(this.btnSelect);
            this.gbxBookInfo.Controls.Add(this.txtSelect);
            this.gbxBookInfo.Controls.Add(this.lblSelect);
            this.gbxBookInfo.Controls.Add(this.cmbSelect);
            this.gbxBookInfo.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.gbxBookInfo.Location = new System.Drawing.Point(9, 74);
            this.gbxBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBookInfo.Name = "gbxBookInfo";
            this.gbxBookInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBookInfo.Size = new System.Drawing.Size(1160, 768);
            this.gbxBookInfo.TabIndex = 4;
            this.gbxBookInfo.TabStop = false;
            this.gbxBookInfo.Text = "图书信息";
            // 
            // txtBorrow
            // 
            this.txtBorrow.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtBorrow.Location = new System.Drawing.Point(708, 36);
            this.txtBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.txtBorrow.Name = "txtBorrow";
            this.txtBorrow.Size = new System.Drawing.Size(144, 31);
            this.txtBorrow.TabIndex = 32;
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBorrow.Location = new System.Drawing.Point(648, 42);
            this.lblBorrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(56, 21);
            this.lblBorrow.TabIndex = 31;
            this.lblBorrow.Text = "借阅";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBorrow.Location = new System.Drawing.Point(870, 30);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(110, 39);
            this.btnBorrow.TabIndex = 33;
            this.btnBorrow.Text = "借阅";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(4, 75);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowTemplate.Height = 27;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.ShowCellToolTips = false;
            this.dgvBook.ShowEditingIcon = false;
            this.dgvBook.Size = new System.Drawing.Size(1152, 701);
            this.dgvBook.TabIndex = 29;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(375, 30);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 39);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSelect.Location = new System.Drawing.Point(214, 36);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(144, 31);
            this.txtSelect.TabIndex = 27;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(4, 42);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(56, 21);
            this.lblSelect.TabIndex = 26;
            this.lblSelect.Text = "查询";
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "查询条件",
            "图书编号",
            "类别编号",
            "借书编号",
            "管理员编号",
            "书名",
            "作者",
            "价格",
            "借书时间",
            "书号",
            "位置",
            "图书数量"});
            this.cmbSelect.Location = new System.Drawing.Point(66, 38);
            this.cmbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(141, 29);
            this.cmbSelect.TabIndex = 25;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // gbxMyInfo
            // 
            this.gbxMyInfo.Controls.Add(this.txtBookQuantity);
            this.gbxMyInfo.Controls.Add(this.lblBookQuantity);
            this.gbxMyInfo.Controls.Add(this.btnCancel);
            this.gbxMyInfo.Controls.Add(this.txtRdept);
            this.gbxMyInfo.Controls.Add(this.lblRDept);
            this.gbxMyInfo.Controls.Add(this.txtEmail);
            this.gbxMyInfo.Controls.Add(this.lblEmail);
            this.gbxMyInfo.Controls.Add(this.txtGen);
            this.gbxMyInfo.Controls.Add(this.lblGen);
            this.gbxMyInfo.Controls.Add(this.btnUpdate);
            this.gbxMyInfo.Controls.Add(this.btnConfirm);
            this.gbxMyInfo.Controls.Add(this.txtPhone);
            this.gbxMyInfo.Controls.Add(this.lblPhone);
            this.gbxMyInfo.Controls.Add(this.txtPsw);
            this.gbxMyInfo.Controls.Add(this.lblPsw);
            this.gbxMyInfo.Controls.Add(this.txtName);
            this.gbxMyInfo.Controls.Add(this.lblName);
            this.gbxMyInfo.Controls.Add(this.txtId);
            this.gbxMyInfo.Controls.Add(this.lblId);
            this.gbxMyInfo.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.gbxMyInfo.Location = new System.Drawing.Point(11, 73);
            this.gbxMyInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxMyInfo.Name = "gbxMyInfo";
            this.gbxMyInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxMyInfo.Size = new System.Drawing.Size(1162, 772);
            this.gbxMyInfo.TabIndex = 30;
            this.gbxMyInfo.TabStop = false;
            this.gbxMyInfo.Text = "个人信息";
            this.gbxMyInfo.Visible = false;
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Enabled = false;
            this.txtBookQuantity.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookQuantity.Location = new System.Drawing.Point(349, 446);
            this.txtBookQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(150, 32);
            this.txtBookQuantity.TabIndex = 34;
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookQuantity.Location = new System.Drawing.Point(221, 446);
            this.lblBookQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(128, 27);
            this.lblBookQuantity.TabIndex = 33;
            this.lblBookQuantity.Text = "在借书数";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(699, 555);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 39);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRdept
            // 
            this.txtRdept.Enabled = false;
            this.txtRdept.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtRdept.Location = new System.Drawing.Point(725, 268);
            this.txtRdept.Margin = new System.Windows.Forms.Padding(2);
            this.txtRdept.Name = "txtRdept";
            this.txtRdept.Size = new System.Drawing.Size(150, 31);
            this.txtRdept.TabIndex = 32;
            // 
            // lblRDept
            // 
            this.lblRDept.AutoSize = true;
            this.lblRDept.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblRDept.Location = new System.Drawing.Point(621, 269);
            this.lblRDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRDept.Name = "lblRDept";
            this.lblRDept.Size = new System.Drawing.Size(100, 27);
            this.lblRDept.TabIndex = 31;
            this.lblRDept.Text = "单  位";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(725, 358);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 32);
            this.txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(625, 358);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 31);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email";
            // 
            // txtGen
            // 
            this.txtGen.Enabled = false;
            this.txtGen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGen.Location = new System.Drawing.Point(349, 268);
            this.txtGen.Margin = new System.Windows.Forms.Padding(2);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(150, 32);
            this.txtGen.TabIndex = 28;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGen.Location = new System.Drawing.Point(221, 268);
            this.lblGen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(130, 27);
            this.lblGen.TabIndex = 27;
            this.lblGen.Text = "性    别";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(507, 555);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 39);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(327, 555);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 39);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(349, 358);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 32);
            this.txtPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.Location = new System.Drawing.Point(221, 358);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(130, 27);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "电    话";
            // 
            // txtPsw
            // 
            this.txtPsw.Enabled = false;
            this.txtPsw.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsw.Location = new System.Drawing.Point(725, 446);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(2);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(150, 32);
            this.txtPsw.TabIndex = 17;
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPsw.Location = new System.Drawing.Point(621, 447);
            this.lblPsw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(100, 27);
            this.lblPsw.TabIndex = 16;
            this.lblPsw.Text = "密  码";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(725, 176);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(621, 177);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 27);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "姓  名";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(349, 176);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 32);
            this.txtId.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.Location = new System.Drawing.Point(221, 178);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(128, 27);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "读者证号";
            // 
            // gbxRecord
            // 
            this.gbxRecord.Controls.Add(this.btnReturn);
            this.gbxRecord.Controls.Add(this.txtReturn);
            this.gbxRecord.Controls.Add(this.lblReturn);
            this.gbxRecord.Controls.Add(this.dgvRecord);
            this.gbxRecord.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.gbxRecord.Location = new System.Drawing.Point(15, 70);
            this.gbxRecord.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRecord.Name = "gbxRecord";
            this.gbxRecord.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRecord.Size = new System.Drawing.Size(1160, 776);
            this.gbxRecord.TabIndex = 27;
            this.gbxRecord.TabStop = false;
            this.gbxRecord.Text = "借书记录";
            this.gbxRecord.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(309, 24);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 39);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "还书";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtReturn
            // 
            this.txtReturn.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtReturn.Location = new System.Drawing.Point(112, 29);
            this.txtReturn.Margin = new System.Windows.Forms.Padding(2);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(159, 31);
            this.txtReturn.TabIndex = 2;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblReturn.Location = new System.Drawing.Point(4, 36);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(102, 21);
            this.lblReturn.TabIndex = 1;
            this.lblReturn.Text = "图书编号";
            // 
            // dgvRecord
            // 
            this.dgvRecord.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Location = new System.Drawing.Point(8, 69);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowTemplate.Height = 27;
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.Size = new System.Drawing.Size(1144, 703);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellContentClick);
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Location = new System.Drawing.Point(275, 32);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(0, 12);
            this.lblRType.TabIndex = 34;
            // 
            // MainReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbxRecord);
            this.Controls.Add(this.gbxMyInfo);
            this.Controls.Add(this.gbxBookInfo);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnMyInfo);
            this.Controls.Add(this.btnBookInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainR_FormClosed);
            this.Load += new System.EventHandler(this.MainR_Load);
            this.gbxBookInfo.ResumeLayout(false);
            this.gbxBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.gbxMyInfo.ResumeLayout(false);
            this.gbxMyInfo.PerformLayout();
            this.gbxRecord.ResumeLayout(false);
            this.gbxRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookInfo;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox gbxBookInfo;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.GroupBox gbxMyInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gbxRecord;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtBorrow;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.TextBox txtRdept;
        private System.Windows.Forms.Label lblRDept;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.Label lblBookQuantity;
    }
}