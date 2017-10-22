namespace Inventory_Control_System
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.btnSearchReferenceNumber = new System.Windows.Forms.Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTransactionsDateOriginal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblComponentCode = new System.Windows.Forms.Label();
            this.cmbRejectionReason = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBilledQuantity = new System.Windows.Forms.Label();
            this.txtBilledQuantity = new System.Windows.Forms.TextBox();
            this.chkBilledQuantity = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRejectedQuantity = new System.Windows.Forms.TextBox();
            this.txtChalaanNumberExternal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChalaanNumberInternal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtTranDate = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.lblDateSent = new System.Windows.Forms.Label();
            this.lblVendorStock = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOpenChalaans = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstvwOpenChalaans = new System.Windows.Forms.ListView();
            this.btnTimesheet = new System.Windows.Forms.Button();
            this.lblActualPendingQty = new System.Windows.Forms.Label();
            this.dgvCompActualPendingQty = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbOperation);
            this.groupBox1.Controls.Add(this.cmbVendor);
            this.groupBox1.Controls.Add(this.btnSearchReferenceNumber);
            this.groupBox1.Controls.Add(this.lblMaterial);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtReferenceNumber);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblTransactionsDateOriginal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblComponentCode);
            this.groupBox1.Controls.Add(this.cmbRejectionReason);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBilledQuantity);
            this.groupBox1.Controls.Add(this.txtBilledQuantity);
            this.groupBox1.Controls.Add(this.chkBilledQuantity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRejectedQuantity);
            this.groupBox1.Controls.Add(this.txtChalaanNumberExternal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtChalaanNumberInternal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtTranDate);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbComponent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction/Voucher details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(390, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Operation Name:";
            // 
            // cmbOperation
            // 
            this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(501, 147);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(168, 24);
            this.cmbOperation.TabIndex = 5;
            this.cmbOperation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOperation_KeyDown);
            // 
            // cmbVendor
            // 
            this.cmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(173, 120);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(158, 24);
            this.cmbVendor.TabIndex = 3;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbVendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVendor_KeyDown);
            // 
            // btnSearchReferenceNumber
            // 
            this.btnSearchReferenceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReferenceNumber.Location = new System.Drawing.Point(336, 88);
            this.btnSearchReferenceNumber.Name = "btnSearchReferenceNumber";
            this.btnSearchReferenceNumber.Size = new System.Drawing.Size(26, 23);
            this.btnSearchReferenceNumber.TabIndex = 2;
            this.btnSearchReferenceNumber.Text = "::";
            this.btnSearchReferenceNumber.UseVisualStyleBackColor = true;
            this.btnSearchReferenceNumber.Click += new System.EventHandler(this.btnSearchReferenceNumber_Click);
            this.btnSearchReferenceNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearchReferenceNumber_KeyDown);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(502, 69);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(77, 15);
            this.lblMaterial.TabIndex = 26;
            this.lblMaterial.Text = "Material type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(436, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Material:";
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenceNumber.Location = new System.Drawing.Point(173, 88);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(158, 23);
            this.txtReferenceNumber.TabIndex = 2;
            this.txtReferenceNumber.TextChanged += new System.EventHandler(this.txtReferenceNumber_TextChanged);
            this.txtReferenceNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReferenceNumber_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Reference number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Original Transaction Date:";
            // 
            // lblTransactionsDateOriginal
            // 
            this.lblTransactionsDateOriginal.AutoSize = true;
            this.lblTransactionsDateOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsDateOriginal.Location = new System.Drawing.Point(176, 69);
            this.lblTransactionsDateOriginal.Name = "lblTransactionsDateOriginal";
            this.lblTransactionsDateOriginal.Size = new System.Drawing.Size(0, 15);
            this.lblTransactionsDateOriginal.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(390, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Component Code:";
            // 
            // lblComponentCode
            // 
            this.lblComponentCode.AutoSize = true;
            this.lblComponentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentCode.Location = new System.Drawing.Point(502, 93);
            this.lblComponentCode.Name = "lblComponentCode";
            this.lblComponentCode.Size = new System.Drawing.Size(101, 15);
            this.lblComponentCode.TabIndex = 19;
            this.lblComponentCode.Text = "Component code";
            // 
            // cmbRejectionReason
            // 
            this.cmbRejectionReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRejectionReason.Enabled = false;
            this.cmbRejectionReason.FormattingEnabled = true;
            this.cmbRejectionReason.Location = new System.Drawing.Point(501, 249);
            this.cmbRejectionReason.Name = "cmbRejectionReason";
            this.cmbRejectionReason.Size = new System.Drawing.Size(168, 23);
            this.cmbRejectionReason.TabIndex = 8;
            this.cmbRejectionReason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRejectionReason_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Reason of Rejection:";
            // 
            // lblBilledQuantity
            // 
            this.lblBilledQuantity.AutoSize = true;
            this.lblBilledQuantity.Enabled = false;
            this.lblBilledQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilledQuantity.Location = new System.Drawing.Point(86, 271);
            this.lblBilledQuantity.Name = "lblBilledQuantity";
            this.lblBilledQuantity.Size = new System.Drawing.Size(85, 15);
            this.lblBilledQuantity.TabIndex = 17;
            this.lblBilledQuantity.Text = "Billed Quantity";
            // 
            // txtBilledQuantity
            // 
            this.txtBilledQuantity.Enabled = false;
            this.txtBilledQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilledQuantity.Location = new System.Drawing.Point(173, 266);
            this.txtBilledQuantity.Name = "txtBilledQuantity";
            this.txtBilledQuantity.Size = new System.Drawing.Size(158, 23);
            this.txtBilledQuantity.TabIndex = 10;
            this.txtBilledQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBilledQuantity_KeyDown);
            // 
            // chkBilledQuantity
            // 
            this.chkBilledQuantity.AutoSize = true;
            this.chkBilledQuantity.Checked = true;
            this.chkBilledQuantity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBilledQuantity.Enabled = false;
            this.chkBilledQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBilledQuantity.Location = new System.Drawing.Point(173, 235);
            this.chkBilledQuantity.Name = "chkBilledQuantity";
            this.chkBilledQuantity.Size = new System.Drawing.Size(143, 19);
            this.chkBilledQuantity.TabIndex = 9;
            this.chkBilledQuantity.Text = "Billed same as Actual";
            this.chkBilledQuantity.UseVisualStyleBackColor = true;
            this.chkBilledQuantity.CheckedChanged += new System.EventHandler(this.chkBilledQuantity_CheckedChanged);
            this.chkBilledQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkBilledQuantity_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Rejected Quantity";
            // 
            // txtRejectedQuantity
            // 
            this.txtRejectedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRejectedQuantity.Location = new System.Drawing.Point(501, 212);
            this.txtRejectedQuantity.Name = "txtRejectedQuantity";
            this.txtRejectedQuantity.Size = new System.Drawing.Size(168, 23);
            this.txtRejectedQuantity.TabIndex = 8;
            this.txtRejectedQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRejectedQuantity_KeyDown);
            // 
            // txtChalaanNumberExternal
            // 
            this.txtChalaanNumberExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChalaanNumberExternal.Location = new System.Drawing.Point(501, 180);
            this.txtChalaanNumberExternal.Name = "txtChalaanNumberExternal";
            this.txtChalaanNumberExternal.Size = new System.Drawing.Size(168, 23);
            this.txtChalaanNumberExternal.TabIndex = 6;
            this.txtChalaanNumberExternal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChalaanNumberExternal_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chalaan Number (Vendor):";
            // 
            // txtChalaanNumberInternal
            // 
            this.txtChalaanNumberInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChalaanNumberInternal.Location = new System.Drawing.Point(173, 179);
            this.txtChalaanNumberInternal.Name = "txtChalaanNumberInternal";
            this.txtChalaanNumberInternal.Size = new System.Drawing.Size(158, 23);
            this.txtChalaanNumberInternal.TabIndex = 5;
            this.txtChalaanNumberInternal.TextChanged += new System.EventHandler(this.txtChalaanNumberInternal_TextChanged);
            this.txtChalaanNumberInternal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChalaanNumberInternal_KeyDown);
            this.txtChalaanNumberInternal.Leave += new System.EventHandler(this.txtChalaanNumberInternal_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chalaan Number (Internal):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Transaction date";
            // 
            // dtTranDate
            // 
            this.dtTranDate.CustomFormat = "dd-MMM-yyyy";
            this.dtTranDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTranDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTranDate.Location = new System.Drawing.Point(173, 37);
            this.dtTranDate.Name = "dtTranDate";
            this.dtTranDate.Size = new System.Drawing.Size(158, 23);
            this.dtTranDate.TabIndex = 0;
            this.dtTranDate.ValueChanged += new System.EventHandler(this.dtTranDate_ValueChanged);
            this.dtTranDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtTranDate_KeyDown);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Outgoing",
            "Incoming"});
            this.cmbType.Location = new System.Drawing.Point(505, 38);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(168, 24);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbType_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type (Out/In)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Component Name:";
            // 
            // cmbComponent
            // 
            this.cmbComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(501, 117);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(168, 24);
            this.cmbComponent.TabIndex = 4;
            this.cmbComponent.SelectedIndexChanged += new System.EventHandler(this.cmbComponent_SelectedIndexChanged);
            this.cmbComponent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbComponent_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendor / Contractor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actual Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(173, 209);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(158, 23);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDateReceived);
            this.groupBox2.Controls.Add(this.lblDateSent);
            this.groupBox2.Controls.Add(this.lblVendorStock);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(728, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 151);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Summary";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceived.Location = new System.Drawing.Point(17, 89);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(116, 15);
            this.lblDateReceived.TabIndex = 6;
            this.lblDateReceived.Text = "Last Date Received:";
            // 
            // lblDateSent
            // 
            this.lblDateSent.AutoSize = true;
            this.lblDateSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSent.Location = new System.Drawing.Point(17, 58);
            this.lblDateSent.Name = "lblDateSent";
            this.lblDateSent.Size = new System.Drawing.Size(90, 15);
            this.lblDateSent.TabIndex = 5;
            this.lblDateSent.Text = "Last Date Sent:";
            // 
            // lblVendorStock
            // 
            this.lblVendorStock.AutoSize = true;
            this.lblVendorStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorStock.ForeColor = System.Drawing.Color.Black;
            this.lblVendorStock.Location = new System.Drawing.Point(17, 28);
            this.lblVendorStock.Name = "lblVendorStock";
            this.lblVendorStock.Size = new System.Drawing.Size(124, 15);
            this.lblVendorStock.TabIndex = 4;
            this.lblVendorStock.Text = "Quantity with Vendor: ";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(163, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save (F2)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(279, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close (ESC)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // lblOpenChalaans
            // 
            this.lblOpenChalaans.AutoSize = true;
            this.lblOpenChalaans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpenChalaans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenChalaans.Location = new System.Drawing.Point(725, 185);
            this.lblOpenChalaans.Name = "lblOpenChalaans";
            this.lblOpenChalaans.Size = new System.Drawing.Size(130, 15);
            this.lblOpenChalaans.TabIndex = 15;
            this.lblOpenChalaans.Text = "List of Open Chalaans:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(384, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Searc&h (F3)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // lstvwOpenChalaans
            // 
            this.lstvwOpenChalaans.Location = new System.Drawing.Point(728, 203);
            this.lstvwOpenChalaans.Name = "lstvwOpenChalaans";
            this.lstvwOpenChalaans.Size = new System.Drawing.Size(255, 129);
            this.lstvwOpenChalaans.TabIndex = 17;
            this.lstvwOpenChalaans.UseCompatibleStateImageBehavior = false;
            this.lstvwOpenChalaans.View = System.Windows.Forms.View.Details;
            this.lstvwOpenChalaans.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstvwOpenChalaans_ColumnClick);
            this.lstvwOpenChalaans.SelectedIndexChanged += new System.EventHandler(this.lstvwOpenChalaans_SelectedIndexChanged);
            this.lstvwOpenChalaans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstvwOpenChalaans_KeyDown);
            // 
            // btnTimesheet
            // 
            this.btnTimesheet.Enabled = false;
            this.btnTimesheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimesheet.Location = new System.Drawing.Point(492, 339);
            this.btnTimesheet.Name = "btnTimesheet";
            this.btnTimesheet.Size = new System.Drawing.Size(85, 30);
            this.btnTimesheet.TabIndex = 18;
            this.btnTimesheet.Text = "&Timesheet";
            this.btnTimesheet.UseVisualStyleBackColor = true;
            this.btnTimesheet.Click += new System.EventHandler(this.btnTimesheet_Click);
            this.btnTimesheet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTimesheet_KeyDown);
            // 
            // lblActualPendingQty
            // 
            this.lblActualPendingQty.AutoSize = true;
            this.lblActualPendingQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualPendingQty.Location = new System.Drawing.Point(28, 379);
            this.lblActualPendingQty.Name = "lblActualPendingQty";
            this.lblActualPendingQty.Size = new System.Drawing.Size(194, 15);
            this.lblActualPendingQty.TabIndex = 20;
            this.lblActualPendingQty.Text = "Actual/Pending Qty by Component:";
            // 
            // dgvCompActualPendingQty
            // 
            this.dgvCompActualPendingQty.AllowUserToAddRows = false;
            this.dgvCompActualPendingQty.AllowUserToDeleteRows = false;
            this.dgvCompActualPendingQty.AllowUserToOrderColumns = true;
            this.dgvCompActualPendingQty.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvCompActualPendingQty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompActualPendingQty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompActualPendingQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompActualPendingQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompActualPendingQty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompActualPendingQty.Location = new System.Drawing.Point(31, 399);
            this.dgvCompActualPendingQty.MultiSelect = false;
            this.dgvCompActualPendingQty.Name = "dgvCompActualPendingQty";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompActualPendingQty.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCompActualPendingQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompActualPendingQty.Size = new System.Drawing.Size(688, 129);
            this.dgvCompActualPendingQty.TabIndex = 19;
            this.dgvCompActualPendingQty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompActualPendingQty_CellContentClick);
            this.dgvCompActualPendingQty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompActualPendingQty_CellDoubleClick);
            this.dgvCompActualPendingQty.SelectionChanged += new System.EventHandler(this.dgvCompActualPendingQty_SelectionChanged);
            this.dgvCompActualPendingQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCompActualPendingQty_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 541);
            this.ControlBox = false;
            this.Controls.Add(this.lblActualPendingQty);
            this.Controls.Add(this.dgvCompActualPendingQty);
            this.Controls.Add(this.btnTimesheet);
            this.Controls.Add(this.lstvwOpenChalaans);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblOpenChalaans);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Voucher Outward/Inward";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVendorStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtTranDate;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.Label lblDateSent;
        private System.Windows.Forms.TextBox txtChalaanNumberExternal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChalaanNumberInternal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRejectedQuantity;
        private System.Windows.Forms.TextBox txtBilledQuantity;
        private System.Windows.Forms.CheckBox chkBilledQuantity;
        private System.Windows.Forms.Label lblBilledQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRejectionReason;
        private System.Windows.Forms.Label lblOpenChalaans;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstvwOpenChalaans;
        private System.Windows.Forms.Label lblComponentCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTimesheet;
        private System.Windows.Forms.Label lblTransactionsDateOriginal;
        private System.Windows.Forms.Label lblActualPendingQty;
        private System.Windows.Forms.DataGridView dgvCompActualPendingQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnSearchReferenceNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbOperation;
    }
}

