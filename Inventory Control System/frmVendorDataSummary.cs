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
    public partial class frmVendorDataSummary : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        public frmVendorDataSummary()
        {
            InitializeComponent();

            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();
        }

        private class Item
        {
            public string Name;
            public string Value;

            public Item(string name, string value)
            {
                Name = name;
                Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public void GetDataSummary(string value)
        {
            //VendorDataSummary vds = new VendorDataSummary();

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "select VendorCode, LastDateOutgoing, LastDateIncoming, Running_Balance - RejectedQuantity as RunningBalance from dbo.vw_VendorDataSummary where vendorCode = '" + value + "'";
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                if (sqlDR.HasRows)
                {
                    sqlDR.Read();

                    lblVendorStock.Text = "Quantity with Vendor: " + sqlDR.GetDecimal(3).ToString();

                    lblDateSent.Text = "Last Date Sent: " + sqlDR.GetDateTime(1).ToString("dd-MMM-yyyy");

                    if (!sqlDR.IsDBNull(2))
                        lblDateReceived.Text = "Last Date Received: " + sqlDR.GetDateTime(2).ToString("dd-MMM-yyyy");
                    else
                        lblDateReceived.Text = "Last Date Received: Not available";

                    sqlDR.Close();
                    sqlDR = null;
                    sqlCmd = null;

                    GetActualPendingQty(value);
                }
                else
                {
                    lblVendorStock.Text = "Quantity with Vendor: Not available";
                    lblDateSent.Text = "Last Date Sent: Not available";
                    lblDateReceived.Text = "Last Date Received: Not available";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Method name: GetDataSummary " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDR != null)
                {
                    if (!sqlDR.IsClosed)
                        sqlDR.Close();
                    sqlDR = null;
                    sqlCmd = null;
                }
                //vds = null;
            }
        }

        private void frmVendorDataSummary_Load(object sender, EventArgs e)
        {

        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyCode.ToString() == "Return")
            {

            }

        }

        private void frmVendorDataSummary_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void GetActualPendingQty(string vendorCode)
        {
            DataTable dtQuantity = new DataTable("ActualPendingQty");

            string strCmd = string.Empty;

            strCmd = "SELECT ComponentCode as [Component Code], ComponentName as [Component Name], ActualQuantity as [Sent Quantity], (ActualQuantity - PendingQty) as [Received Quantity], PendingQty as [Balance Quantity] FROM [dbo].[GetActualPendingQty]('" + vendorCode + "')";

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandText = strCmd;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            bool IsDataAvailable = false;

            try
            {

                if (sqlDR.HasRows)
                {
                    //sqlDR.Read();
                    dtQuantity.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtQuantity);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: GetActualPendingQty" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        private void RefreshDataGrid(bool bIsDataAvailable, DataTable dt)
        {
            if (bIsDataAvailable)
            {
                dgvCompActualPendingQty.DataSource = dt;
                dgvCompActualPendingQty.Refresh();

                dgvCompActualPendingQty.Columns[0].Width = 100;
                dgvCompActualPendingQty.Columns[1].Width = 200;
                dgvCompActualPendingQty.Columns[2].Width = 118;
                dgvCompActualPendingQty.Columns[3].Width = 118;
            }
            else
            {
                dgvCompActualPendingQty.DataSource = "";
                dgvCompActualPendingQty.Refresh();
            }
        }

        private void dgvCompActualPendingQty_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }
    }
}
