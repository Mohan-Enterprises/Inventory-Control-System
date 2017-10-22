namespace Inventory_Control_System
{
    partial class frmVoucherInward
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnassigned = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDataSummary = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRejectionReason = new System.Windows.Forms.ComboBox();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRejectedQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBilledQuantity = new System.Windows.Forms.TextBox();
            this.chkBilledQuantity = new System.Windows.Forms.CheckBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.lblComponentName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComponentCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.dgvCompActualPendingQty = new System.Windows.Forms.DataGridView();
            this.txtVoucherNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtTranDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUnassigned);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDataSummary);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(653, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 340);
            this.panel1.TabIndex = 6;
            // 
            // btnUnassigned
            // 
            this.btnUnassigned.BackColor = System.Drawing.Color.Silver;
            this.btnUnassigned.Enabled = false;
            this.btnUnassigned.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnassigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnassigned.Location = new System.Drawing.Point(3, 269);
            this.btnUnassigned.Name = "btnUnassigned";
            this.btnUnassigned.Size = new System.Drawing.Size(180, 60);
            this.btnUnassigned.TabIndex = 12;
            this.btnUnassigned.UseVisualStyleBackColor = false;
            this.btnUnassigned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUnassigned_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Open Vouchers (F5)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // btnDataSummary
            // 
            this.btnDataSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDataSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataSummary.Location = new System.Drawing.Point(3, 136);
            this.btnDataSummary.Name = "btnDataSummary";
            this.btnDataSummary.Size = new System.Drawing.Size(180, 60);
            this.btnDataSummary.TabIndex = 10;
            this.btnDataSummary.Text = "&Data Summary (F4)";
            this.btnDataSummary.UseVisualStyleBackColor = false;
            this.btnDataSummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDataSummary_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(3, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 60);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Searc&h (F3)";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 60);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save (F2)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRejectionReason);
            this.groupBox1.Controls.Add(this.txtVendor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRejectedQuantity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBilledQuantity);
            this.groupBox1.Controls.Add(this.chkBilledQuantity);
            this.groupBox1.Controls.Add(this.txtVendorName);
            this.groupBox1.Controls.Add(this.lblComponentName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtComponentCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalQty);
            this.groupBox1.Controls.Add(this.dgvCompActualPendingQty);
            this.groupBox1.Controls.Add(this.txtVoucherNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtTranDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 344);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction / Voucher Details";
            // 
            // cmbRejectionReason
            // 
            this.cmbRejectionReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRejectionReason.Enabled = false;
            this.cmbRejectionReason.FormattingEnabled = true;
            this.cmbRejectionReason.Location = new System.Drawing.Point(492, 93);
            this.cmbRejectionReason.Name = "cmbRejectionReason";
            this.cmbRejectionReason.Size = new System.Drawing.Size(137, 23);
            this.cmbRejectionReason.TabIndex = 7;
            this.cmbRejectionReason.SelectedIndexChanged += new System.EventHandler(this.cmbRejectionReason_SelectedIndexChanged);
            this.cmbRejectionReason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRejectionReason_KeyDown);
            // 
            // txtVendor
            // 
            this.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendor.Location = new System.Drawing.Point(168, 324);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.ReadOnly = true;
            this.txtVendor.Size = new System.Drawing.Size(99, 23);
            this.txtVendor.TabIndex = 1;
            this.txtVendor.Visible = false;
            this.txtVendor.TextChanged += new System.EventHandler(this.txtVendor_TextChanged);
            this.txtVendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Vendor Code:";
            this.label3.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "Rejected Quantity";
            // 
            // txtRejectedQuantity
            // 
            this.txtRejectedQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRejectedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRejectedQuantity.Location = new System.Drawing.Point(390, 92);
            this.txtRejectedQuantity.Name = "txtRejectedQuantity";
            this.txtRejectedQuantity.Size = new System.Drawing.Size(76, 23);
            this.txtRejectedQuantity.TabIndex = 6;
            this.txtRejectedQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRejectedQuantity_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Reason of Rejection:";
            // 
            // txtBilledQuantity
            // 
            this.txtBilledQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBilledQuantity.Enabled = false;
            this.txtBilledQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilledQuantity.Location = new System.Drawing.Point(247, 92);
            this.txtBilledQuantity.Name = "txtBilledQuantity";
            this.txtBilledQuantity.Size = new System.Drawing.Size(133, 23);
            this.txtBilledQuantity.TabIndex = 5;
            this.txtBilledQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBilledQuantity_KeyDown);
            // 
            // chkBilledQuantity
            // 
            this.chkBilledQuantity.AutoSize = true;
            this.chkBilledQuantity.Checked = true;
            this.chkBilledQuantity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBilledQuantity.Enabled = false;
            this.chkBilledQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBilledQuantity.Location = new System.Drawing.Point(247, 74);
            this.chkBilledQuantity.Name = "chkBilledQuantity";
            this.chkBilledQuantity.Size = new System.Drawing.Size(143, 19);
            this.chkBilledQuantity.TabIndex = 38;
            this.chkBilledQuantity.Text = "Billed same as Actual";
            this.chkBilledQuantity.UseVisualStyleBackColor = true;
            this.chkBilledQuantity.CheckedChanged += new System.EventHandler(this.chkBilledQuantity_CheckedChanged);
            this.chkBilledQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkBilledQuantity_KeyDown);
            // 
            // txtVendorName
            // 
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.Location = new System.Drawing.Point(132, 41);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.ReadOnly = true;
            this.txtVendorName.Size = new System.Drawing.Size(159, 23);
            this.txtVendorName.TabIndex = 1;
            this.txtVendorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendorName_KeyDown);
            // 
            // lblComponentName
            // 
            this.lblComponentName.AutoSize = true;
            this.lblComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentName.Location = new System.Drawing.Point(435, 40);
            this.lblComponentName.Name = "lblComponentName";
            this.lblComponentName.Size = new System.Drawing.Size(108, 15);
            this.lblComponentName.TabIndex = 35;
            this.lblComponentName.Text = "Component Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Component Name:";
            // 
            // txtComponentCode
            // 
            this.txtComponentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponentCode.Enabled = false;
            this.txtComponentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponentCode.Location = new System.Drawing.Point(315, 40);
            this.txtComponentCode.Name = "txtComponentCode";
            this.txtComponentCode.ReadOnly = true;
            this.txtComponentCode.Size = new System.Drawing.Size(103, 23);
            this.txtComponentCode.TabIndex = 2;
            this.txtComponentCode.TextChanged += new System.EventHandler(this.txtComponentCode_TextChanged);
            this.txtComponentCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComponentCode_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Component Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vendor Name:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(130, 92);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(99, 23);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total Quantity:";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(578, 299);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(14, 13);
            this.lblTotalQty.TabIndex = 22;
            this.lblTotalQty.Text = "0";
            // 
            // dgvCompActualPendingQty
            // 
            this.dgvCompActualPendingQty.AllowUserToAddRows = false;
            this.dgvCompActualPendingQty.AllowUserToDeleteRows = false;
            this.dgvCompActualPendingQty.AllowUserToOrderColumns = true;
            this.dgvCompActualPendingQty.AllowUserToResizeColumns = false;
            this.dgvCompActualPendingQty.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvCompActualPendingQty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompActualPendingQty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCompActualPendingQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompActualPendingQty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompActualPendingQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompActualPendingQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompActualPendingQty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompActualPendingQty.Location = new System.Drawing.Point(16, 122);
            this.dgvCompActualPendingQty.MultiSelect = false;
            this.dgvCompActualPendingQty.Name = "dgvCompActualPendingQty";
            this.dgvCompActualPendingQty.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompActualPendingQty.RowHeadersVisible = false;
            this.dgvCompActualPendingQty.RowHeadersWidth = 70;
            this.dgvCompActualPendingQty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompActualPendingQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompActualPendingQty.ShowEditingIcon = false;
            this.dgvCompActualPendingQty.Size = new System.Drawing.Size(605, 160);
            this.dgvCompActualPendingQty.TabIndex = 5;
            this.dgvCompActualPendingQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCompActualPendingQty_KeyDown);
            // 
            // txtVoucherNumber
            // 
            this.txtVoucherNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucherNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNumber.Location = new System.Drawing.Point(16, 93);
            this.txtVoucherNumber.Name = "txtVoucherNumber";
            this.txtVoucherNumber.Size = new System.Drawing.Size(99, 23);
            this.txtVoucherNumber.TabIndex = 3;
            this.txtVoucherNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNumber_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Voucher Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date:";
            // 
            // dtTranDate
            // 
            this.dtTranDate.CustomFormat = "dd-MMM-yyyy";
            this.dtTranDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTranDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTranDate.Location = new System.Drawing.Point(12, 41);
            this.dtTranDate.Name = "dtTranDate";
            this.dtTranDate.Size = new System.Drawing.Size(99, 23);
            this.dtTranDate.TabIndex = 0;
            this.dtTranDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtTranDate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Voucher Inward";
            // 
            // frmVoucherInward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(848, 407);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVoucherInward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Voucher - Outward";
            this.Activated += new System.EventHandler(this.frmVoucher_Activated);
            this.Deactivate += new System.EventHandler(this.frmVoucher_Deactivate);
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherInward_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVoucherNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtTranDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDataSummary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnassigned;
        private System.Windows.Forms.DataGridView dgvCompActualPendingQty;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComponentCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblComponentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.CheckBox chkBilledQuantity;
        private System.Windows.Forms.ComboBox cmbRejectionReason;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBilledQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRejectedQuantity;
    }
}