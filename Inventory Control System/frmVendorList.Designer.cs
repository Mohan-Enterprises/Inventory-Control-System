namespace Inventory_Control_System
{
    partial class frmVendorList
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
            this.txtVendorNameSearchBox = new System.Windows.Forms.TextBox();
            this.dgvVendorList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVendorNameSearchBox
            // 
            this.txtVendorNameSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVendorNameSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorNameSearchBox.Location = new System.Drawing.Point(7, 37);
            this.txtVendorNameSearchBox.Name = "txtVendorNameSearchBox";
            this.txtVendorNameSearchBox.Size = new System.Drawing.Size(351, 20);
            this.txtVendorNameSearchBox.TabIndex = 0;
            this.txtVendorNameSearchBox.TextChanged += new System.EventHandler(this.txtVendorNameSearchBox_TextChanged);
            this.txtVendorNameSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendorNameSearchBox_KeyDown);
            // 
            // dgvVendorList
            // 
            this.dgvVendorList.AllowUserToAddRows = false;
            this.dgvVendorList.AllowUserToDeleteRows = false;
            this.dgvVendorList.AllowUserToOrderColumns = true;
            this.dgvVendorList.AllowUserToResizeColumns = false;
            this.dgvVendorList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvVendorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendorList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVendorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVendorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVendorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendorList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendorList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVendorList.Location = new System.Drawing.Point(7, 60);
            this.dgvVendorList.MultiSelect = false;
            this.dgvVendorList.Name = "dgvVendorList";
            this.dgvVendorList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVendorList.RowHeadersVisible = false;
            this.dgvVendorList.RowHeadersWidth = 70;
            this.dgvVendorList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVendorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendorList.ShowEditingIcon = false;
            this.dgvVendorList.Size = new System.Drawing.Size(351, 200);
            this.dgvVendorList.TabIndex = 22;
            this.dgvVendorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendorList_CellContentClick);
            this.dgvVendorList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendorList_CellEnter);
            this.dgvVendorList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVendorList_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vendors";
            // 
            // frmVendorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(365, 268);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVendorList);
            this.Controls.Add(this.txtVendorNameSearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVoucherList";
            this.Load += new System.EventHandler(this.frmVoucherList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendorList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVendorNameSearchBox;
        private System.Windows.Forms.DataGridView dgvVendorList;
        private System.Windows.Forms.Label label1;
    }
}