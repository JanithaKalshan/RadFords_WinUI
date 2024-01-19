namespace RadFordsWinUI.WinForms
{
    partial class StaffManagementCRUD
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtIRDTaxNumber = new System.Windows.Forms.TextBox();
            this.txtOfficeExtension = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblIRDNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOfficeExtension = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvStaffMember = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStaffType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMiddleInitails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHomePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOfficeExtention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIRDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvManagerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.cmbPageNo = new System.Windows.Forms.ComboBox();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.cmbPageSize = new System.Windows.Forms.ComboBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMember)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblId);
            this.groupBox.Controls.Add(this.cmbStaffType);
            this.groupBox.Controls.Add(this.lblStaffType);
            this.groupBox.Controls.Add(this.cmbManager);
            this.groupBox.Controls.Add(this.cmbStatus);
            this.groupBox.Controls.Add(this.txtIRDTaxNumber);
            this.groupBox.Controls.Add(this.txtOfficeExtension);
            this.groupBox.Controls.Add(this.txtCellPhone);
            this.groupBox.Controls.Add(this.txtHomePhone);
            this.groupBox.Controls.Add(this.txtLastName);
            this.groupBox.Controls.Add(this.txtMiddleName);
            this.groupBox.Controls.Add(this.txtFirstName);
            this.groupBox.Controls.Add(this.cmbTitle);
            this.groupBox.Controls.Add(this.lblManager);
            this.groupBox.Controls.Add(this.lblIRDNumber);
            this.groupBox.Controls.Add(this.lblStatus);
            this.groupBox.Controls.Add(this.lblOfficeExtension);
            this.groupBox.Controls.Add(this.lblCellPhone);
            this.groupBox.Controls.Add(this.lblHomePhone);
            this.groupBox.Controls.Add(this.lblLastName);
            this.groupBox.Controls.Add(this.lblTitle);
            this.groupBox.Controls.Add(this.lblMiddleName);
            this.groupBox.Controls.Add(this.lblFirstName);
            this.groupBox.Location = new System.Drawing.Point(13, 17);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Size = new System.Drawing.Size(462, 500);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 466);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 20;
            this.lblId.Visible = false;
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(172, 19);
            this.cmbStaffType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(138, 28);
            this.cmbStaffType.TabIndex = 0;
            this.cmbStaffType.SelectedIndexChanged += new System.EventHandler(this.cmbStaffType_SelectedIndexChange);
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Location = new System.Drawing.Point(11, 27);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(75, 20);
            this.lblStaffType.TabIndex = 18;
            this.lblStaffType.Text = "Staff Type";
            // 
            // cmbManager
            // 
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Location = new System.Drawing.Point(172, 425);
            this.cmbManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(255, 28);
            this.cmbManager.TabIndex = 10;
            this.cmbManager.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(172, 387);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(138, 28);
            this.cmbStatus.TabIndex = 9;
            // 
            // txtIRDTaxNumber
            // 
            this.txtIRDTaxNumber.Location = new System.Drawing.Point(172, 341);
            this.txtIRDTaxNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIRDTaxNumber.Name = "txtIRDTaxNumber";
            this.txtIRDTaxNumber.Size = new System.Drawing.Size(155, 27);
            this.txtIRDTaxNumber.TabIndex = 8;
            // 
            // txtOfficeExtension
            // 
            this.txtOfficeExtension.Location = new System.Drawing.Point(172, 297);
            this.txtOfficeExtension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOfficeExtension.MaxLength = 5;
            this.txtOfficeExtension.Name = "txtOfficeExtension";
            this.txtOfficeExtension.Size = new System.Drawing.Size(155, 27);
            this.txtOfficeExtension.TabIndex = 7;
            this.txtOfficeExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOfficeExtension_KeyPress);
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(172, 259);
            this.txtCellPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCellPhone.MaxLength = 10;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(255, 27);
            this.txtCellPhone.TabIndex = 6;
            this.txtCellPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellPhone_KeyPress);
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(172, 220);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomePhone.MaxLength = 10;
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(255, 27);
            this.txtHomePhone.TabIndex = 5;
            this.txtHomePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHomePhone_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(172, 140);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(255, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(172, 185);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(255, 27);
            this.txtMiddleName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(172, 96);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(255, 27);
            this.txtFirstName.TabIndex = 2;
            // 
            // cmbTitle
            // 
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(172, 57);
            this.cmbTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(159, 28);
            this.cmbTitle.TabIndex = 1;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(8, 436);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(68, 20);
            this.lblManager.TabIndex = 7;
            this.lblManager.Text = "Manager";
            this.lblManager.Visible = false;
            // 
            // lblIRDNumber
            // 
            this.lblIRDNumber.AutoSize = true;
            this.lblIRDNumber.Location = new System.Drawing.Point(8, 352);
            this.lblIRDNumber.Name = "lblIRDNumber";
            this.lblIRDNumber.Size = new System.Drawing.Size(127, 20);
            this.lblIRDNumber.TabIndex = 1;
            this.lblIRDNumber.Text = "IRD(TAX) Number";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 397);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblOfficeExtension
            // 
            this.lblOfficeExtension.AutoSize = true;
            this.lblOfficeExtension.Location = new System.Drawing.Point(8, 308);
            this.lblOfficeExtension.Name = "lblOfficeExtension";
            this.lblOfficeExtension.Size = new System.Drawing.Size(116, 20);
            this.lblOfficeExtension.TabIndex = 6;
            this.lblOfficeExtension.Text = "Office Extension";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(7, 269);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(79, 20);
            this.lblCellPhone.TabIndex = 5;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(6, 231);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(91, 20);
            this.lblHomePhone.TabIndex = 4;
            this.lblHomePhone.Text = "HomePhone";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 147);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(6, 192);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(103, 20);
            this.lblMiddleName.TabIndex = 1;
            this.lblMiddleName.Text = "Middle Initials";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 107);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(13, 525);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(462, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 24);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 24);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvStaffMember
            // 
            this.dgvStaffMember.AllowUserToAddRows = false;
            this.dgvStaffMember.AllowUserToDeleteRows = false;
            this.dgvStaffMember.AllowUserToOrderColumns = true;
            this.dgvStaffMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvStaffType,
            this.dgvTitle,
            this.dgvFirstName,
            this.dgvLastName,
            this.dgvMiddleInitails,
            this.dgvHomePhone,
            this.dgvCellPhone,
            this.dgvOfficeExtention,
            this.dgvIRDNumber,
            this.dgvStatus,
            this.dgvManagerId});
            this.dgvStaffMember.Location = new System.Drawing.Point(503, 99);
            this.dgvStaffMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStaffMember.Name = "dgvStaffMember";
            this.dgvStaffMember.ReadOnly = true;
            this.dgvStaffMember.RowHeadersWidth = 51;
            this.dgvStaffMember.RowTemplate.Height = 25;
            this.dgvStaffMember.Size = new System.Drawing.Size(929, 498);
            this.dgvStaffMember.TabIndex = 2;
            this.dgvStaffMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffMember_CellDoubleClick);
            // 
            // dgvId
            // 
            this.dgvId.DataPropertyName = "StaffMemberId";
            this.dgvId.HeaderText = "Id";
            this.dgvId.MinimumWidth = 6;
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 125;
            // 
            // dgvStaffType
            // 
            this.dgvStaffType.DataPropertyName = "StaffType";
            this.dgvStaffType.HeaderText = "StaffType";
            this.dgvStaffType.MinimumWidth = 6;
            this.dgvStaffType.Name = "dgvStaffType";
            this.dgvStaffType.ReadOnly = true;
            this.dgvStaffType.Width = 125;
            // 
            // dgvTitle
            // 
            this.dgvTitle.DataPropertyName = "Title";
            this.dgvTitle.HeaderText = "Title";
            this.dgvTitle.MinimumWidth = 6;
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.ReadOnly = true;
            this.dgvTitle.Width = 125;
            // 
            // dgvFirstName
            // 
            this.dgvFirstName.DataPropertyName = "FirstName";
            this.dgvFirstName.HeaderText = "FirstName";
            this.dgvFirstName.MinimumWidth = 6;
            this.dgvFirstName.Name = "dgvFirstName";
            this.dgvFirstName.ReadOnly = true;
            this.dgvFirstName.Width = 125;
            // 
            // dgvLastName
            // 
            this.dgvLastName.DataPropertyName = "LastName";
            this.dgvLastName.HeaderText = "LastName";
            this.dgvLastName.MinimumWidth = 6;
            this.dgvLastName.Name = "dgvLastName";
            this.dgvLastName.ReadOnly = true;
            this.dgvLastName.Width = 125;
            // 
            // dgvMiddleInitails
            // 
            this.dgvMiddleInitails.DataPropertyName = "MiddleInitial";
            this.dgvMiddleInitails.HeaderText = "MiddleInitials";
            this.dgvMiddleInitails.MinimumWidth = 6;
            this.dgvMiddleInitails.Name = "dgvMiddleInitails";
            this.dgvMiddleInitails.ReadOnly = true;
            this.dgvMiddleInitails.Width = 125;
            // 
            // dgvHomePhone
            // 
            this.dgvHomePhone.DataPropertyName = "HomePhone";
            this.dgvHomePhone.HeaderText = "HomePhone";
            this.dgvHomePhone.MinimumWidth = 6;
            this.dgvHomePhone.Name = "dgvHomePhone";
            this.dgvHomePhone.ReadOnly = true;
            this.dgvHomePhone.Width = 125;
            // 
            // dgvCellPhone
            // 
            this.dgvCellPhone.DataPropertyName = "CellPhone";
            this.dgvCellPhone.HeaderText = "CellPhone";
            this.dgvCellPhone.MinimumWidth = 6;
            this.dgvCellPhone.Name = "dgvCellPhone";
            this.dgvCellPhone.ReadOnly = true;
            this.dgvCellPhone.Width = 125;
            // 
            // dgvOfficeExtention
            // 
            this.dgvOfficeExtention.DataPropertyName = "OfficeExtension";
            this.dgvOfficeExtention.HeaderText = "OfficeExtention";
            this.dgvOfficeExtention.MinimumWidth = 6;
            this.dgvOfficeExtention.Name = "dgvOfficeExtention";
            this.dgvOfficeExtention.ReadOnly = true;
            this.dgvOfficeExtention.Width = 125;
            // 
            // dgvIRDNumber
            // 
            this.dgvIRDNumber.DataPropertyName = "IRDNumber";
            this.dgvIRDNumber.HeaderText = "IRD(TAX)Number";
            this.dgvIRDNumber.MinimumWidth = 6;
            this.dgvIRDNumber.Name = "dgvIRDNumber";
            this.dgvIRDNumber.ReadOnly = true;
            this.dgvIRDNumber.Width = 125;
            // 
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "Status";
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Width = 125;
            // 
            // dgvManagerId
            // 
            this.dgvManagerId.DataPropertyName = "ManagerId";
            this.dgvManagerId.HeaderText = "ManagerId";
            this.dgvManagerId.MinimumWidth = 6;
            this.dgvManagerId.Name = "dgvManagerId";
            this.dgvManagerId.ReadOnly = true;
            this.dgvManagerId.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFilterStatus);
            this.groupBox2.Controls.Add(this.lblFilterStatus);
            this.groupBox2.Location = new System.Drawing.Point(1109, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Grid";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Location = new System.Drawing.Point(157, 32);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(151, 28);
            this.cmbFilterStatus.TabIndex = 0;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(98, 35);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(49, 20);
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnCsv);
            this.groupBox3.Controls.Add(this.cmbPageNo);
            this.groupBox3.Controls.Add(this.lblPageNo);
            this.groupBox3.Controls.Add(this.cmbPageSize);
            this.groupBox3.Controls.Add(this.lblPageSize);
            this.groupBox3.Location = new System.Drawing.Point(503, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(459, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 28);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(359, 19);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(94, 29);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "Export CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // cmbPageNo
            // 
            this.cmbPageNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageNo.FormattingEnabled = true;
            this.cmbPageNo.Location = new System.Drawing.Point(213, 20);
            this.cmbPageNo.Name = "cmbPageNo";
            this.cmbPageNo.Size = new System.Drawing.Size(71, 28);
            this.cmbPageNo.TabIndex = 1;
            this.cmbPageNo.SelectedIndexChanged += new System.EventHandler(this.cmbPageNo_SelectedIndexChanged);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Location = new System.Drawing.Point(142, 23);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(65, 20);
            this.lblPageNo.TabIndex = 2;
            this.lblPageNo.Text = "Page No";
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.Items.AddRange(new object[] {
            "1",
            "10",
            "50",
            "100"});
            this.cmbPageSize.Location = new System.Drawing.Point(84, 20);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(52, 28);
            this.cmbPageSize.TabIndex = 0;
            this.cmbPageSize.SelectedIndexChanged += new System.EventHandler(this.cmbPageSize_SelectedIndexChanged);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Location = new System.Drawing.Point(6, 23);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(72, 20);
            this.lblPageSize.TabIndex = 0;
            this.lblPageSize.Text = "Page Size";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // StaffManagementCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 628);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvStaffMember);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StaffManagementCRUD";
            this.Text = "StaffManagementCRUD";
            this.Load += new System.EventHandler(this.StaffManagementCRUD_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMember)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private Label lblLastName;
        private Label lblTitle;
        private Label lblMiddleName;
        private Label lblFirstName;
        private Label lblHomePhone;
        private Label lblCellPhone;
        private ComboBox cmbTitle;
        private Label lblManager;
        private Label lblIRDNumber;
        private Label lblStatus;
        private Label lblOfficeExtension;
        private TextBox txtLastName;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private ComboBox cmbManager;
        private ComboBox cmbStatus;
        private TextBox txtIRDTaxNumber;
        private TextBox txtOfficeExtension;
        private TextBox txtCellPhone;
        private TextBox txtHomePhone;
        private ComboBox cmbStaffType;
        private Label lblStaffType;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnSave;
        private DataGridView dgvStaffMember;
        private Label lblId;
        private Button btnDelete;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvStaffType;
        private DataGridViewTextBoxColumn dgvTitle;
        private DataGridViewTextBoxColumn dgvFirstName;
        private DataGridViewTextBoxColumn dgvLastName;
        private DataGridViewTextBoxColumn dgvMiddleInitails;
        private DataGridViewTextBoxColumn dgvHomePhone;
        private DataGridViewTextBoxColumn dgvCellPhone;
        private DataGridViewTextBoxColumn dgvOfficeExtention;
        private DataGridViewTextBoxColumn dgvIRDNumber;
        private DataGridViewTextBoxColumn dgvStatus;
        private DataGridViewTextBoxColumn dgvManagerId;
        private GroupBox groupBox2;
        private ComboBox cmbFilterStatus;
        private Label lblFilterStatus;
        private GroupBox groupBox3;
        private ComboBox cmbPageSize;
        private Label lblPageSize;
        private ComboBox cmbPageNo;
        private Label lblPageNo;
        private Button btnCsv;
        private System.Drawing.Printing.PrintDocument printDocument;
        private Button btnPrint;
    }
}