using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory_Control_System
{
    public partial class frmVoucherInwardLineItems : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        DataTable dtOpenVouchers = new DataTable("OpenVouchers");

        public frmVoucherInwardLineItems()
        {
            InitializeComponent();
        }

        private void frmVoucherInwardLineItems_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();
        }

        private void frmVoucherInwardLineItems_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyData == Keys.Return)
            {
                if (txtVoucherNumber.Focused)
                    SendKeys.Send("{TAB}");
                else if (txtQuantity.Focused)
                    if (txtQuantity.Text != string.Empty)
                        AddLineItem();
                    else
                        MessageBox.Show("Please enter Quantity to proceed.");
            }
        }

        private void AddLineItem()
        {
            MessageBox.Show("in AddLineItem() proc");
        }

        private void dgvCompActualPendingQty_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtVoucherNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVoucherNumber_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

    }
}
