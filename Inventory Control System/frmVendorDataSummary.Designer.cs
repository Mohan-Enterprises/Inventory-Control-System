namespace Inventory_Control_System
{
    partial class frmVendorDataSummary
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
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.lblDateSent = new System.Windows.Forms.Label();
            this.lblVendorStock = new System.Windows.Forms.Label();
            this.dgvCompActualPendingQty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceived.Location = new System.Drawing.Point(424, 34);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(117, 15);
            this.lblDateReceived.TabIndex = 6;
            this.lblDateReceived.Text = "Last Date Received:";
            // 
            // lblDateSent
            // 
            this.lblDateSent.AutoSize = true;
            this.lblDateSent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSent.Location = new System.Drawing.Point(237, 34);
            this.lblDateSent.Name = "lblDateSent";
            this.lblDateSent.Size = new System.Drawing.Size(91, 15);
            this.lblDateSent.TabIndex = 5;
            this.lblDateSent.Text = "Last Date Sent:";
            // 
            // lblVendorStock
            // 
            this.lblVendorStock.AutoSize = true;
            this.lblVendorStock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorStock.ForeColor = System.Drawing.Color.Black;
            this.lblVendorStock.Location = new System.Drawing.Point(23, 34);
            this.lblVendorStock.Name = "lblVendorStock";
            this.lblVendorStock.Size = new System.Drawing.Size(123, 15);
            this.lblVendorStock.TabIndex = 4;
            this.lblVendorStock.Text = "Quantity with Vendor: ";
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
            this.dgvCompActualPendingQty.Location = new System.Drawing.Point(26, 52);
            this.dgvCompActualPendingQty.MultiSelect = false;
            this.dgvCompActualPendingQty.Name = "dgvCompActualPendingQty";
            this.dgvCompActualPendingQty.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompActualPendingQty.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCompActualPendingQty.RowHeadersVisible = false;
            this.dgvCompActualPendingQty.RowHeadersWidth = 70;
            this.dgvCompActualPendingQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompActualPendingQty.ShowEditingIcon = false;
            this.dgvCompActualPendingQty.Size = new System.Drawing.Size(654, 160);
            this.dgvCompActualPendingQty.TabIndex = 20;
            this.dgvCompActualPendingQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCompActualPendingQty_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vendor Data Summary";
            // 
            // frmVendorDataSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(692, 224);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCompActualPendingQty);
            this.Controls.Add(this.lblDateReceived);
            this.Controls.Add(this.lblDateSent);
            this.Controls.Add(this.lblVendorStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendorDataSummary";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendor Data Summary";
            this.Load += new System.EventHandler(this.frmVendorDataSummary_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendorDataSummary_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompActualPendingQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.Label lblDateSent;
        private System.Windows.Forms.Label lblVendorStock;
        private System.Windows.Forms.DataGridView dgvCompActualPendingQty;
        private System.Windows.Forms.Label label1;
    }
}