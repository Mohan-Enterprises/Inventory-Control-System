using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnContractorVendorTransaction_Click(object sender, EventArgs e)
        {
            frmVoucherMenu frmVouchers = new frmVoucherMenu();

            frmVouchers.ShowDialog();

        }

        private void btnTransactionRawMaterial_Click(object sender, EventArgs e)
        {
            frmRawMaterial frmRarMaterial1 = new frmRawMaterial();

            frmRarMaterial1.ShowDialog();
        }

        private void btnSearchTransaction_Click(object sender, EventArgs e)
        {
            Search_Transaction frmSearchTransaction = new Search_Transaction();

            frmSearchTransaction.ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //lineShape1.X2 = this.Width - 20;
            //panel1.Left = 1165;
            //panel1.Height = 650;
            //pictureBox1.Height = 650;
            //pictureBox1.Width = 1100;
            //MessageBox.Show(pictureBox1.Top.ToString());
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyCode.ToString() == "Return")
            {
                
            }

            //if (e.KeyCode.ToString() == "F1")
            //{
            //    Form1 frmVendorContractorTransaction = new Form1();

            //    frmVendorContractorTransaction.ShowDialog();
            //}


            //if (e.KeyCode.ToString() == "F2")
            //{
            //    frmRawMaterial frmRarMaterial1 = new frmRawMaterial();

            //    frmRarMaterial1.ShowDialog();
            //}


            //if (e.KeyCode.ToString() == "F3")
            //{
            //    Search_Transaction frmSearchTransaction = new Search_Transaction();

            //    frmSearchTransaction.ShowDialog();
            //}
        }

        private void btnContractorVendorTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnTransactionRawMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearchTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmMainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string strMessage = "Are you sure you would like to exit?";

            DialogResult dResult = MessageBox.Show(strMessage, "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.No)
                e.Cancel = true;
        }

        private void btnManageJob_Click(object sender, EventArgs e)
        {
            frmManageJobMenu frmMenu = new frmManageJobMenu();

            frmMenu.ShowDialog();
        }

        private void btnManageJob_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnUtilities_Click(object sender, EventArgs e)
        {
            frmUtilities frm = new frmUtilities();

            frm.ShowDialog();
        }

        private void btnUtilities_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmMainMenu_Enter(object sender, EventArgs e)
        {
        
        }

        private void frmMainMenu_Activated(object sender, EventArgs e)
        {
            //this.Opacity = 1;
        }

        private void frmMainMenu_Deactivate(object sender, EventArgs e)
        {
            //this.Opacity = .50;
        }

        private void btnVendorList_Click(object sender, EventArgs e)
        {
            frmVendorList frm1 = new frmVendorList();

            frm1.ShowDialog();
        }       
    }
}
