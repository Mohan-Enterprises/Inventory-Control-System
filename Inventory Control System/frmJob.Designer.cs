namespace Inventory_Control_System
{
    partial class frmJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobCode = new System.Windows.Forms.TextBox();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.dtJobStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtJobEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblComponentCode = new System.Windows.Forms.Label();
            this.btnJobManager = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Job Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job End Date:";
            // 
            // txtJobCode
            // 
            this.txtJobCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobCode.Location = new System.Drawing.Point(108, 13);
            this.txtJobCode.Name = "txtJobCode";
            this.txtJobCode.Size = new System.Drawing.Size(135, 21);
            this.txtJobCode.TabIndex = 0;
            this.txtJobCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJobCode_KeyDown);
            // 
            // txtJobName
            // 
            this.txtJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobName.Location = new System.Drawing.Point(108, 51);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(135, 21);
            this.txtJobName.TabIndex = 1;
            this.txtJobName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJobName_KeyDown);
            // 
            // dtJobStartDate
            // 
            this.dtJobStartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtJobStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtJobStartDate.Location = new System.Drawing.Point(108, 90);
            this.dtJobStartDate.Name = "dtJobStartDate";
            this.dtJobStartDate.Size = new System.Drawing.Size(135, 20);
            this.dtJobStartDate.TabIndex = 3;
            this.dtJobStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtJobStartDate_KeyDown);
            // 
            // dtJobEndDate
            // 
            this.dtJobEndDate.CustomFormat = "dd-MMM-yyyy";
            this.dtJobEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtJobEndDate.Location = new System.Drawing.Point(399, 90);
            this.dtJobEndDate.Name = "dtJobEndDate";
            this.dtJobEndDate.Size = new System.Drawing.Size(135, 20);
            this.dtJobEndDate.TabIndex = 4;
            this.dtJobEndDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtJobEndDate_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 60);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save (S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Component:";
            // 
            // cmbComponent
            // 
            this.cmbComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(399, 51);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(135, 21);
            this.cmbComponent.TabIndex = 2;
            this.cmbComponent.SelectedIndexChanged += new System.EventHandler(this.cmbComponent_SelectedIndexChanged);
            this.cmbComponent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbComponent_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Component Code:";
            // 
            // lblComponentCode
            // 
            this.lblComponentCode.AutoSize = true;
            this.lblComponentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentCode.Location = new System.Drawing.Point(396, 17);
            this.lblComponentCode.Name = "lblComponentCode";
            this.lblComponentCode.Size = new System.Drawing.Size(101, 15);
            this.lblComponentCode.TabIndex = 21;
            this.lblComponentCode.Text = "Component code";
            // 
            // btnJobManager
            // 
            this.btnJobManager.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnJobManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobManager.Location = new System.Drawing.Point(3, 70);
            this.btnJobManager.Name = "btnJobManager";
            this.btnJobManager.Size = new System.Drawing.Size(180, 60);
            this.btnJobManager.TabIndex = 23;
            this.btnJobManager.Text = "Job &Manager (M)";
            this.btnJobManager.UseVisualStyleBackColor = true;
            this.btnJobManager.Click += new System.EventHandler(this.btnJobManager_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnJobManager);
            this.panel1.Location = new System.Drawing.Point(555, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 136);
            this.panel1.TabIndex = 24;
            // 
            // frmJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(748, 155);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblComponentCode);
            this.Controls.Add(this.cmbComponent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtJobEndDate);
            this.Controls.Add(this.dtJobStartDate);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.txtJobCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmJob";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job Master";
            this.Load += new System.EventHandler(this.frmJob_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJob_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJobCode;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.DateTimePicker dtJobStartDate;
        private System.Windows.Forms.DateTimePicker dtJobEndDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblComponentCode;
        private System.Windows.Forms.Button btnJobManager;
        private System.Windows.Forms.Panel panel1;
    }
}