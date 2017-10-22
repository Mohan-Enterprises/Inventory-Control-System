namespace Inventory_Control_System
{
    partial class frmSearchMaterial
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
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMaterialReferences = new System.Windows.Forms.ListView();
            this.dtTranDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDateSearch = new System.Windows.Forms.CheckBox();
            this.lblReferences = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(88, 23);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(161, 23);
            this.cmbMaterial.TabIndex = 0;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            this.cmbMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMaterial_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material:";
            // 
            // lstMaterialReferences
            // 
            this.lstMaterialReferences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMaterialReferences.CheckBoxes = true;
            this.lstMaterialReferences.FullRowSelect = true;
            this.lstMaterialReferences.Location = new System.Drawing.Point(30, 110);
            this.lstMaterialReferences.MultiSelect = false;
            this.lstMaterialReferences.Name = "lstMaterialReferences";
            this.lstMaterialReferences.Size = new System.Drawing.Size(459, 98);
            this.lstMaterialReferences.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstMaterialReferences.TabIndex = 3;
            this.lstMaterialReferences.UseCompatibleStateImageBehavior = false;
            this.lstMaterialReferences.View = System.Windows.Forms.View.Details;
            this.lstMaterialReferences.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstMaterialReferences_ItemChecked);
            this.lstMaterialReferences.SelectedIndexChanged += new System.EventHandler(this.lstMaterialReferences_SelectedIndexChanged);
            this.lstMaterialReferences.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMaterialReferences_KeyDown);
            // 
            // dtTranDate
            // 
            this.dtTranDate.CustomFormat = "MMM-yyyy";
            this.dtTranDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTranDate.Location = new System.Drawing.Point(371, 26);
            this.dtTranDate.Name = "dtTranDate";
            this.dtTranDate.Size = new System.Drawing.Size(118, 20);
            this.dtTranDate.TabIndex = 1;
            this.dtTranDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtTranDate_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transaction date:";
            // 
            // chkDateSearch
            // 
            this.chkDateSearch.AutoSize = true;
            this.chkDateSearch.Location = new System.Drawing.Point(278, 57);
            this.chkDateSearch.Name = "chkDateSearch";
            this.chkDateSearch.Size = new System.Drawing.Size(92, 17);
            this.chkDateSearch.TabIndex = 2;
            this.chkDateSearch.Text = "Date Search?";
            this.chkDateSearch.UseVisualStyleBackColor = true;
            this.chkDateSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkDateSearch_KeyDown);
            // 
            // lblReferences
            // 
            this.lblReferences.AutoSize = true;
            this.lblReferences.Location = new System.Drawing.Point(30, 91);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(96, 13);
            this.lblReferences.TabIndex = 6;
            this.lblReferences.Text = "List of References:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(214, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSearchMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 244);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblReferences);
            this.Controls.Add(this.chkDateSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTranDate);
            this.Controls.Add(this.lstMaterialReferences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchMaterial_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchMaterial_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearchMaterial_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMaterialReferences;
        private System.Windows.Forms.DateTimePicker dtTranDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDateSearch;
        private System.Windows.Forms.Label lblReferences;
        private System.Windows.Forms.Button btnOK;
    }
}