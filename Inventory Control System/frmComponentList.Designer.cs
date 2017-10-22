namespace Inventory_Control_System
{
    partial class frmComponentList
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dgvComponentList = new System.Windows.Forms.DataGridView();
            this.txtComponentNameSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 4);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(104, 18);
            this.lblFormTitle.TabIndex = 27;
            this.lblFormTitle.Text = "Components";
            // 
            // dgvComponentList
            // 
            this.dgvComponentList.AllowUserToAddRows = false;
            this.dgvComponentList.AllowUserToDeleteRows = false;
            this.dgvComponentList.AllowUserToOrderColumns = true;
            this.dgvComponentList.AllowUserToResizeColumns = false;
            this.dgvComponentList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvComponentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComponentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvComponentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComponentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComponentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComponentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComponentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComponentList.Location = new System.Drawing.Point(11, 58);
            this.dgvComponentList.MultiSelect = false;
            this.dgvComponentList.Name = "dgvComponentList";
            this.dgvComponentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComponentList.RowHeadersVisible = false;
            this.dgvComponentList.RowHeadersWidth = 70;
            this.dgvComponentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComponentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComponentList.ShowEditingIcon = false;
            this.dgvComponentList.Size = new System.Drawing.Size(351, 207);
            this.dgvComponentList.TabIndex = 26;
            this.dgvComponentList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvComponentList_KeyDown);
            // 
            // txtComponentNameSearchBox
            // 
            this.txtComponentNameSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComponentNameSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponentNameSearchBox.Location = new System.Drawing.Point(11, 35);
            this.txtComponentNameSearchBox.Name = "txtComponentNameSearchBox";
            this.txtComponentNameSearchBox.Size = new System.Drawing.Size(351, 20);
            this.txtComponentNameSearchBox.TabIndex = 25;
            this.txtComponentNameSearchBox.TextChanged += new System.EventHandler(this.txtComponentNameSearchBox_TextChanged);
            this.txtComponentNameSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComponentNameSearchBox_KeyDown);
            // 
            // frmComponentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(369, 268);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.dgvComponentList);
            this.Controls.Add(this.txtComponentNameSearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComponentList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Components";
            this.Load += new System.EventHandler(this.frmComponentList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmComponentList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dgvComponentList;
        private System.Windows.Forms.TextBox txtComponentNameSearchBox;
    }
}