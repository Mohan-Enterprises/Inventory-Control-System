namespace Inventory_Control_System
{
    partial class frmVouchersOutstandingList
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
            this.dgvCompActualPendingQty = new System.Windows.Forms.DataGridView();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtVoucherNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVoucherNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).BeginInit();
            this.SuspendLayout();
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
            this.dgvCompActualPendingQty.Location = new System.Drawing.Point(12, 75);
            this.dgvCompActualPendingQty.MultiSelect = false;
            this.dgvCompActualPendingQty.Name = "dgvCompActualPendingQty";
            this.dgvCompActualPendingQty.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompActualPendingQty.RowHeadersVisible = false;
            this.dgvCompActualPendingQty.RowHeadersWidth = 70;
            this.dgvCompActualPendingQty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompActualPendingQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompActualPendingQty.ShowEditingIcon = false;
            this.dgvCompActualPendingQty.Size = new System.Drawing.Size(766, 204);
            this.dgvCompActualPendingQty.TabIndex = 22;
            this.dgvCompActualPendingQty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompActualPendingQty_CellContentClick);
            this.dgvCompActualPendingQty.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompActualPendingQty_CellEnter);
            this.dgvCompActualPendingQty.SelectionChanged += new System.EventHandler(this.dgvCompActualPendingQty_SelectionChanged);
            this.dgvCompActualPendingQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCompActualPendingQty_KeyDown);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(74, 18);
            this.lblFormTitle.TabIndex = 39;
            this.lblFormTitle.Text = "Vouchers";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(295, 49);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 44;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // txtVoucherNumber
            // 
            this.txtVoucherNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucherNumber.Location = new System.Drawing.Point(109, 49);
            this.txtVoucherNumber.Name = "txtVoucherNumber";
            this.txtVoucherNumber.ReadOnly = true;
            this.txtVoucherNumber.Size = new System.Drawing.Size(100, 20);
            this.txtVoucherNumber.TabIndex = 43;
            this.txtVoucherNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNumber_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Quantity:";
            // 
            // lblVoucherNumber
            // 
            this.lblVoucherNumber.AutoSize = true;
            this.lblVoucherNumber.Location = new System.Drawing.Point(14, 51);
            this.lblVoucherNumber.Name = "lblVoucherNumber";
            this.lblVoucherNumber.Size = new System.Drawing.Size(90, 13);
            this.lblVoucherNumber.TabIndex = 41;
            this.lblVoucherNumber.Text = "Voucher Number:";
            // 
            // frmVouchersOutstandingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(790, 291);
            this.ControlBox = false;
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtVoucherNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVoucherNumber);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.dgvCompActualPendingQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVouchersOutstandingList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Outstanding Vouchers List";
            this.Activated += new System.EventHandler(this.frmVouchersOutstandingList_Activated);
            this.Deactivate += new System.EventHandler(this.frmVouchersOutstandingList_Deactivate);
            this.Load += new System.EventHandler(this.frmVouchersOutstandingList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVouchersOutstandingList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompActualPendingQty;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtVoucherNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVoucherNumber;
    }
}