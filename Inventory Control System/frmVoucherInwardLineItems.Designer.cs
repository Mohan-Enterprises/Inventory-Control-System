namespace Inventory_Control_System
{
    partial class frmVoucherInwardLineItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompActualPendingQty = new System.Windows.Forms.DataGridView();
            this.lblVoucherNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoucherNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompActualPendingQty
            // 
            this.dgvCompActualPendingQty.AllowUserToAddRows = false;
            this.dgvCompActualPendingQty.AllowUserToDeleteRows = false;
            this.dgvCompActualPendingQty.AllowUserToOrderColumns = true;
            this.dgvCompActualPendingQty.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvCompActualPendingQty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCompActualPendingQty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCompActualPendingQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompActualPendingQty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompActualPendingQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompActualPendingQty.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCompActualPendingQty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompActualPendingQty.Location = new System.Drawing.Point(12, 44);
            this.dgvCompActualPendingQty.MultiSelect = false;
            this.dgvCompActualPendingQty.Name = "dgvCompActualPendingQty";
            this.dgvCompActualPendingQty.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompActualPendingQty.RowHeadersVisible = false;
            this.dgvCompActualPendingQty.RowHeadersWidth = 70;
            this.dgvCompActualPendingQty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompActualPendingQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompActualPendingQty.ShowEditingIcon = false;
            this.dgvCompActualPendingQty.Size = new System.Drawing.Size(382, 89);
            this.dgvCompActualPendingQty.TabIndex = 22;
            this.dgvCompActualPendingQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCompActualPendingQty_KeyDown);
            // 
            // lblVoucherNumber
            // 
            this.lblVoucherNumber.AutoSize = true;
            this.lblVoucherNumber.Location = new System.Drawing.Point(13, 13);
            this.lblVoucherNumber.Name = "lblVoucherNumber";
            this.lblVoucherNumber.Size = new System.Drawing.Size(90, 13);
            this.lblVoucherNumber.TabIndex = 23;
            this.lblVoucherNumber.Text = "Voucher Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantity:";
            // 
            // txtVoucherNumber
            // 
            this.txtVoucherNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucherNumber.Location = new System.Drawing.Point(108, 11);
            this.txtVoucherNumber.Name = "txtVoucherNumber";
            this.txtVoucherNumber.Size = new System.Drawing.Size(100, 20);
            this.txtVoucherNumber.TabIndex = 25;
            this.txtVoucherNumber.TextChanged += new System.EventHandler(this.txtVoucherNumber_TextChanged);
            this.txtVoucherNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNumber_KeyDown);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(294, 11);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // frmVoucherInwardLineItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(406, 147);
            this.ControlBox = false;
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtVoucherNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVoucherNumber);
            this.Controls.Add(this.dgvCompActualPendingQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVoucherInwardLineItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Voucher Inward Line Items";
            this.Load += new System.EventHandler(this.frmVoucherInwardLineItems_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherInwardLineItems_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompActualPendingQty;
        private System.Windows.Forms.Label lblVoucherNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoucherNumber;
        private System.Windows.Forms.TextBox txtQuantity;

    }
}