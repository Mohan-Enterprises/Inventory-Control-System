namespace Inventory_Control_System
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnContractorVendorTransaction = new System.Windows.Forms.Button();
            this.btnSearchTransaction = new System.Windows.Forms.Button();
            this.btnManageJob = new System.Windows.Forms.Button();
            this.btnUtilities = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportsMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContractorVendorTransaction
            // 
            this.btnContractorVendorTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContractorVendorTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractorVendorTransaction.Location = new System.Drawing.Point(3, 70);
            this.btnContractorVendorTransaction.Name = "btnContractorVendorTransaction";
            this.btnContractorVendorTransaction.Size = new System.Drawing.Size(180, 60);
            this.btnContractorVendorTransaction.TabIndex = 2;
            this.btnContractorVendorTransaction.Text = "Create &Voucher (V)";
            this.btnContractorVendorTransaction.UseVisualStyleBackColor = false;
            this.btnContractorVendorTransaction.Click += new System.EventHandler(this.btnContractorVendorTransaction_Click);
            this.btnContractorVendorTransaction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnContractorVendorTransaction_KeyDown);
            // 
            // btnSearchTransaction
            // 
            this.btnSearchTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearchTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTransaction.Location = new System.Drawing.Point(3, 136);
            this.btnSearchTransaction.Name = "btnSearchTransaction";
            this.btnSearchTransaction.Size = new System.Drawing.Size(180, 60);
            this.btnSearchTransaction.TabIndex = 3;
            this.btnSearchTransaction.Text = "&Search Vouchers (S)";
            this.btnSearchTransaction.UseVisualStyleBackColor = false;
            this.btnSearchTransaction.Click += new System.EventHandler(this.btnSearchTransaction_Click);
            this.btnSearchTransaction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearchTransaction_KeyDown);
            // 
            // btnManageJob
            // 
            this.btnManageJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageJob.ForeColor = System.Drawing.Color.Black;
            this.btnManageJob.Location = new System.Drawing.Point(3, 5);
            this.btnManageJob.Name = "btnManageJob";
            this.btnManageJob.Size = new System.Drawing.Size(180, 60);
            this.btnManageJob.TabIndex = 0;
            this.btnManageJob.Text = "&Manage Job (M)";
            this.btnManageJob.UseVisualStyleBackColor = false;
            this.btnManageJob.Click += new System.EventHandler(this.btnManageJob_Click);
            this.btnManageJob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnManageJob_KeyDown);
            // 
            // btnUtilities
            // 
            this.btnUtilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilities.Location = new System.Drawing.Point(3, 269);
            this.btnUtilities.Name = "btnUtilities";
            this.btnUtilities.Size = new System.Drawing.Size(180, 60);
            this.btnUtilities.TabIndex = 5;
            this.btnUtilities.Text = "&Utilities (U)";
            this.btnUtilities.UseVisualStyleBackColor = false;
            this.btnUtilities.Click += new System.EventHandler(this.btnUtilities_Click);
            this.btnUtilities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUtilities_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReportsMenu);
            this.panel1.Controls.Add(this.btnManageJob);
            this.panel1.Controls.Add(this.btnUtilities);
            this.panel1.Controls.Add(this.btnSearchTransaction);
            this.panel1.Controls.Add(this.btnContractorVendorTransaction);
            this.panel1.Location = new System.Drawing.Point(442, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 337);
            this.panel1.TabIndex = 5;
            // 
            // btnReportsMenu
            // 
            this.btnReportsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReportsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportsMenu.Location = new System.Drawing.Point(4, 202);
            this.btnReportsMenu.Name = "btnReportsMenu";
            this.btnReportsMenu.Size = new System.Drawing.Size(180, 60);
            this.btnReportsMenu.TabIndex = 4;
            this.btnReportsMenu.Text = "&Reports (R)";
            this.btnReportsMenu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory Control System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Control_System.Properties.Resources.ERP_Software_Solution;
            this.pictureBox1.Location = new System.Drawing.Point(10, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(639, 385);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control System";
            this.Activated += new System.EventHandler(this.frmMainMenu_Activated);
            this.Deactivate += new System.EventHandler(this.frmMainMenu_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.Enter += new System.EventHandler(this.frmMainMenu_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainMenu_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContractorVendorTransaction;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.Button btnManageJob;
        private System.Windows.Forms.Button btnUtilities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReportsMenu;
    }
}