namespace Inventory_Control_System
{
    partial class frmManageJob
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRawMaterial = new System.Windows.Forms.Button();
            this.btnVoucherOutward = new System.Windows.Forms.Button();
            this.btnCompleteJob = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoucherInward = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvComponentOperationQuantity = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentOperationQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRawMaterial
            // 
            this.btnRawMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRawMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRawMaterial.Location = new System.Drawing.Point(3, 5);
            this.btnRawMaterial.Name = "btnRawMaterial";
            this.btnRawMaterial.Size = new System.Drawing.Size(180, 60);
            this.btnRawMaterial.TabIndex = 0;
            this.btnRawMaterial.Text = "&Raw Material (R)";
            this.btnRawMaterial.UseVisualStyleBackColor = false;
            this.btnRawMaterial.Click += new System.EventHandler(this.btnRawMaterial_Click);
            this.btnRawMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRawMaterial_KeyDown);
            // 
            // btnVoucherOutward
            // 
            this.btnVoucherOutward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVoucherOutward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucherOutward.Location = new System.Drawing.Point(3, 71);
            this.btnVoucherOutward.Name = "btnVoucherOutward";
            this.btnVoucherOutward.Size = new System.Drawing.Size(180, 60);
            this.btnVoucherOutward.TabIndex = 1;
            this.btnVoucherOutward.Text = "Voucher &Outward (O)";
            this.btnVoucherOutward.UseVisualStyleBackColor = false;
            this.btnVoucherOutward.Click += new System.EventHandler(this.btnVoucherOutward_Click);
            this.btnVoucherOutward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnVoucherOutward_KeyDown);
            // 
            // btnCompleteJob
            // 
            this.btnCompleteJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCompleteJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteJob.Location = new System.Drawing.Point(3, 200);
            this.btnCompleteJob.Name = "btnCompleteJob";
            this.btnCompleteJob.Size = new System.Drawing.Size(180, 60);
            this.btnCompleteJob.TabIndex = 2;
            this.btnCompleteJob.Text = "&Complete Job (C)";
            this.btnCompleteJob.UseVisualStyleBackColor = false;
            this.btnCompleteJob.Click += new System.EventHandler(this.btnCompleteJob_Click);
            this.btnCompleteJob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCompleteJob_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVoucherInward);
            this.panel1.Controls.Add(this.btnRawMaterial);
            this.panel1.Controls.Add(this.btnVoucherOutward);
            this.panel1.Controls.Add(this.btnCompleteJob);
            this.panel1.Location = new System.Drawing.Point(447, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 270);
            this.panel1.TabIndex = 6;
            // 
            // btnVoucherInward
            // 
            this.btnVoucherInward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVoucherInward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucherInward.Location = new System.Drawing.Point(3, 134);
            this.btnVoucherInward.Name = "btnVoucherInward";
            this.btnVoucherInward.Size = new System.Drawing.Size(180, 60);
            this.btnVoucherInward.TabIndex = 3;
            this.btnVoucherInward.Text = "Voucher &Inward (I)";
            this.btnVoucherInward.UseVisualStyleBackColor = false;
            this.btnVoucherInward.Click += new System.EventHandler(this.btnVoucherInward_Click);
            this.btnVoucherInward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnVoucherInward_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvComponentOperationQuantity);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 270);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Operation Inventory";
            // 
            // dgvComponentOperationQuantity
            // 
            this.dgvComponentOperationQuantity.AllowUserToAddRows = false;
            this.dgvComponentOperationQuantity.AllowUserToDeleteRows = false;
            this.dgvComponentOperationQuantity.AllowUserToOrderColumns = true;
            this.dgvComponentOperationQuantity.AllowUserToResizeColumns = false;
            this.dgvComponentOperationQuantity.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvComponentOperationQuantity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvComponentOperationQuantity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvComponentOperationQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComponentOperationQuantity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComponentOperationQuantity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvComponentOperationQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComponentOperationQuantity.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvComponentOperationQuantity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComponentOperationQuantity.Location = new System.Drawing.Point(9, 20);
            this.dgvComponentOperationQuantity.MultiSelect = false;
            this.dgvComponentOperationQuantity.Name = "dgvComponentOperationQuantity";
            this.dgvComponentOperationQuantity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComponentOperationQuantity.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvComponentOperationQuantity.RowHeadersVisible = false;
            this.dgvComponentOperationQuantity.RowHeadersWidth = 70;
            this.dgvComponentOperationQuantity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComponentOperationQuantity.ShowEditingIcon = false;
            this.dgvComponentOperationQuantity.Size = new System.Drawing.Size(424, 127);
            this.dgvComponentOperationQuantity.TabIndex = 21;
            this.dgvComponentOperationQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvComponentOperationQuantity_KeyDown);
            // 
            // frmManageJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(640, 279);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageJob";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job Manager";
            this.Load += new System.EventHandler(this.frmManageJob_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManageJob_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentOperationQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRawMaterial;
        private System.Windows.Forms.Button btnVoucherOutward;
        private System.Windows.Forms.Button btnCompleteJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoucherInward;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvComponentOperationQuantity;
        private System.Windows.Forms.Label label1;
    }
}