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
    public partial class frmVoucherMenu : Form
    {
        public frmVoucherMenu()
        {
            InitializeComponent();
        }

        private void frmVoucherMenu_Load(object sender, EventArgs e)
        {
            //panel1.Left = 1165;
            //panel1.Height = 650;
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyCode.ToString() == "Return")
            {

            }
        }

        private void btnVoucherVendor_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnTransactionRawMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmVoucherMenu_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnVoucherVendor_Click(object sender, EventArgs e)
        {
            frmVoucher frmVcher = new frmVoucher();

            frmVcher.ShowDialog();
        }

        private void frmVoucherMenu_Activated(object sender, EventArgs e)
        {
            //this.Opacity = 1;
            this.Enabled = true;
        }

        private void frmVoucherMenu_Deactivate(object sender, EventArgs e)
        {
            //this.Opacity = .6;
            this.Enabled = false;
        }

        private void btnVoucherInward_Click(object sender, EventArgs e)
        {
            frmVoucherInward frmVI = new frmVoucherInward();

            frmVI.ShowDialog();
        }

        private void btnVoucherInhouse_Click(object sender, EventArgs e)
        {
            frmVoucherInhouse frmVI = new frmVoucherInhouse();

            frmVI.ShowDialog(this);
        }

        
    }
}
