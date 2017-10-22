namespace Inventory_Control_System
{
    partial class frmVoucherMenu
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
            this.btnVoucherVendor = new System.Windows.Forms.Button();
            this.btnVoucherInward = new System.Windows.Forms.Button();
            this.btnVoucherInhouse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoucherVendor
            // 
            this.btnVoucherVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVoucherVendor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoucherVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucherVendor.Location = new System.Drawing.Point(3, 5);
            this.btnVoucherVendor.Name = "btnVoucherVendor";
            this.btnVoucherVendor.Size = new System.Drawing.Size(180, 60);
            this.btnVoucherVendor.TabIndex = 0;
            this.btnVoucherVendor.Text = "&Outward Voucher (O)";
            this.btnVoucherVendor.UseVisualStyleBackColor = false;
            this.btnVoucherVendor.Click += new System.EventHandler(this.btnVoucherVendor_Click);
            this.btnVoucherVendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnVoucherVendor_KeyDown);
            // 
            // btnVoucherInward
            // 
            this.btnVoucherInward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVoucherInward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoucherInward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucherInward.Location = new System.Drawing.Point(3, 70);
            this.btnVoucherInward.Name = "btnVoucherInward";
            this.btnVoucherInward.Size = new System.Drawing.Size(180, 60);
            this.btnVoucherInward.TabIndex = 1;
            this.btnVoucherInward.Text = "&Inward Voucher (I)";
            this.btnVoucherInward.UseVisualStyleBackColor = false;
            this.btnVoucherInward.Click += new System.EventHandler(this.btnVoucherInward_Click);
            this.btnVoucherInward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // btnVoucherInhouse
            // 
            this.btnVoucherInhouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVoucherInhouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoucherInhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucherInhouse.Location = new System.Drawing.Point(3, 136);
            this.btnVoucherInhouse.Name = "btnVoucherInhouse";
            this.btnVoucherInhouse.Size = new System.Drawing.Size(180, 60);
            this.btnVoucherInhouse.TabIndex = 2;
            this.btnVoucherInhouse.Text = "Inhouse &Voucher (V)";
            this.btnVoucherInhouse.UseVisualStyleBackColor = false;
            this.btnVoucherInhouse.Click += new System.EventHandler(this.btnVoucherInhouse_Click);
            this.btnVoucherInhouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTransactionRawMaterial_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVoucherVendor);
            this.panel1.Controls.Add(this.btnVoucherInhouse);
            this.panel1.Controls.Add(this.btnVoucherInward);
            this.panel1.Location = new System.Drawing.Point(372, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 203);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inventory Control System - Vouchers";
            // 
            // frmVoucherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVoucherMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Voucher Menu";
            this.Activated += new System.EventHandler(this.frmVoucherMenu_Activated);
            this.Deactivate += new System.EventHandler(this.frmVoucherMenu_Deactivate);
            this.Load += new System.EventHandler(this.frmVoucherMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherMenu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoucherVendor;
        private System.Windows.Forms.Button btnVoucherInward;
        private System.Windows.Forms.Button btnVoucherInhouse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}