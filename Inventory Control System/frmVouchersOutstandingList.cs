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
    public partial class frmVouchersOutstandingList : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        DataTable dtOpenVouchers = new DataTable("OpenVouchers");
        DataTable dtVoucherLineItems = new DataTable("VoucherLineItems");

        DataRow drVoucherLineItem;

        public string VendorCode = string.Empty;

        public string ComponentCode = string.Empty;

        public frmVouchersOutstandingList()
        {
            InitializeComponent();
        }

        private void frmVouchersOutstandingList_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            GetOpenChalaansByVendor2(VendorCode, ComponentCode);

            GetVendorDetails();

            dtVoucherLineItems.Columns.Add("Voucher Number");
            dtVoucherLineItems.Columns.Add("Component Code");
            dtVoucherLineItems.Columns.Add("Reference Number");
            dtVoucherLineItems.Columns.Add("Job Code");
            dtVoucherLineItems.Columns.Add("Operation Code");
            dtVoucherLineItems.Columns.Add("Quantity");
        }

        private void GetVendorDetails()
        {
            Vendor objVendor = new Vendor();

            try
            {
                objVendor = objVendor.GetVendorDetails(VendorCode);

                lblFormTitle.Text = "Against Outstanding Voucher(s) - " + objVendor.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetVendorDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objVendor = null;
            }
        }

        private void KeyAction(KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Escape")
                {
                    this.Close();
                }


                if (e.KeyData == Keys.Return)
                {

                    if (!ValidateQty())
                        return;

                    string strMessage = "Add Voucher?";

                    DialogResult dResult = MessageBox.Show(strMessage, "Add Voucher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dResult == DialogResult.No)
                        return;

                    string strVoucherNumber = string.Empty;
                    string strTranDate = string.Empty;
                    string strComponentCode = string.Empty;

                    if (dgvCompActualPendingQty.SelectedRows.Count > 0)
                    {
                        strVoucherNumber = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[0].Value;
                        strTranDate = dgvCompActualPendingQty.SelectedRows[0].Cells[1].Value.ToString();
                        strComponentCode = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[2].Value;

                    }

                    AddVoucherLineItem();

                    //GetOpenChalaansByVendor2(VendorCode, strComponentCode);

                    //dgvCompActualPendingQty.Rows.RemoveAt(dgvCompActualPendingQty.SelectedRows[0].Index);

                    //if (dtOpenVouchers.Rows.Count > 0)
                    //    dtOpenVouchers.Rows[dgvCompActualPendingQty.SelectedRows[0].Index].Delete();

                    foreach (DataRow dr in dtOpenVouchers.Rows)
                    {

                        if (dr[0].ToString() == strVoucherNumber && dr[1].ToString() == strTranDate)
                        {
                            dr[5] = (decimal)dr[5] - Convert.ToDecimal(txtQuantity.Text);

                            if ((decimal)dr[5] <= 0)
                                dr.Delete();
                        }
                    }

                    dtOpenVouchers.AcceptChanges();

                    RefreshDataGrid(true, dtOpenVouchers);

                    frmVoucherInward frmVI = (frmVoucherInward)this.Owner;

                    frmVI.RefreshLineItemsGrid(dtVoucherLineItems);

                    if (dgvCompActualPendingQty.Rows.Count > 0)
                    {
                        dgvCompActualPendingQty.Rows[0].Selected = true;
                    }
                    else
                        this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("KeyAction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private bool ValidateQty()
        {
            decimal dQuantity = 0;

            if (dgvCompActualPendingQty.SelectedRows.Count > 0)
            {
                dQuantity = (decimal)dgvCompActualPendingQty.SelectedRows[0].Cells[5].Value;
            }
            else
                return false;

            if (txtQuantity.Text != string.Empty)
            {
                if (Convert.ToDecimal(txtQuantity.Text) > dQuantity)
                {
                    MessageBox.Show("Quantity cannot be greater than Balance Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Select a voucher from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddVoucherLineItem()
        {

            try
            {
                bool IsUpdate = false;
                string strComponentCode = string.Empty;
                string strReferenceNumber = string.Empty;
                string strOperationCode = string.Empty;
                string strJobCode = string.Empty;

                strComponentCode = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[2].Value;
                if (!Convert.IsDBNull(dgvCompActualPendingQty.SelectedRows[0].Cells[6].Value))
                    strReferenceNumber = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[6].Value;
                if (!Convert.IsDBNull(dgvCompActualPendingQty.SelectedRows[0].Cells[7].Value))
                    strJobCode = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[7].Value;
                if (!Convert.IsDBNull(dgvCompActualPendingQty.SelectedRows[0].Cells[8].Value))
                    strOperationCode = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[8].Value;

                decimal dQuantity = 0;

                foreach (DataRow dr in dtVoucherLineItems.Rows)
                {
                    if (dr[0].ToString() == txtVoucherNumber.Text && dr[1].ToString() == strComponentCode)
                    {
                        dQuantity = Convert.ToDecimal(txtQuantity.Text);
                        drVoucherLineItem["Voucher Number"] = txtVoucherNumber.Text;
                        //MessageBox.Show((dr["Quantity"]).ToString());
                        dQuantity = dQuantity + Convert.ToDecimal(drVoucherLineItem["Quantity"]);
                        drVoucherLineItem["Quantity"] = dQuantity;
                        //MessageBox.Show(dQuantity.ToString());
                        drVoucherLineItem["Component Code"] = strComponentCode;
                        drVoucherLineItem["Reference Number"] = strReferenceNumber;
                        drVoucherLineItem["Job Code"] = strJobCode;
                        drVoucherLineItem["Operation Code"] = strOperationCode;
                        IsUpdate = true;
                    }
                }

                if (!IsUpdate)
                {
                    drVoucherLineItem = dtVoucherLineItems.NewRow();
                    drVoucherLineItem["Voucher Number"] = txtVoucherNumber.Text;
                    drVoucherLineItem["Quantity"] = txtQuantity.Text;
                    drVoucherLineItem["Component Code"] = strComponentCode;
                    drVoucherLineItem["Reference Number"] = strReferenceNumber;
                    drVoucherLineItem["Job Code"] = strJobCode;
                    drVoucherLineItem["Operation Code"] = strOperationCode;
                    dtVoucherLineItems.Rows.Add(drVoucherLineItem);
                }

                dtVoucherLineItems.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddVoucher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //drVoucherLineItem = null;
            }
        }

        private void GetOpenChalaansByVendor2(string vendorCode, string componentCode)
        {
            SqlCommand sqlCmd = new SqlCommand();

            string strSearchCriteria = string.Empty;

            if (componentCode != string.Empty)
                strSearchCriteria = " WHERE ComponentCode = '" + componentCode + "' ORDER BY CAST(ChalaanNumber AS INT) ASC";
            else
                strSearchCriteria = "ORDER BY CAST(ChalaanNumber AS INT) ASC";

            sqlCmd.CommandText = "SELECT ChalaanNumber AS [Voucher Number], TranDate as [Date], ComponentCode as [Component Code], OutgoingQuantity as [Qty Sent], IncomingQuantity as [Qty Received], BalanceQty as [Balance Qty], ReferenceNumber as [Reference Number], JobCode as [Job Code], OperationCode as [Operation Code] FROM OpenChalaansByVendor('" + vendorCode + "')" + strSearchCriteria;
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            bool IsDataAvailable = false;

            try
            {
                if (sqlDR.HasRows)
                {
                    dtOpenVouchers.Clear();
                    dtOpenVouchers.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtOpenVouchers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method name: GetOpenChalaansByVendor " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
                //vds = null;
            }
        }

        private void RefreshDataGrid(bool bIsDataAvailable, DataTable dt)
        {
            dgvCompActualPendingQty.DataSource = "";
            dgvCompActualPendingQty.Refresh();

            if (bIsDataAvailable)
            {
                dgvCompActualPendingQty.DataSource = dtOpenVouchers;
                dgvCompActualPendingQty.Refresh();
            }
        }

        private void dgvCompActualPendingQty_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvCompActualPendingQty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVouchersOutstandingList_KeyDown(object sender, KeyEventArgs e)
        {
            //KeyAction(e);
        }

        private void frmVouchersOutstandingList_Activated(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        private void frmVouchersOutstandingList_Deactivate(object sender, EventArgs e)
        {
            this.Enabled = false;
        }

        private void dgvCompActualPendingQty_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompActualPendingQty.SelectedRows.Count > 0)
            {
                txtVoucherNumber.Text = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[0].Value;
                txtQuantity.Text = Convert.ToDecimal(dgvCompActualPendingQty.SelectedRows[0].Cells[5].Value).ToString();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtVoucherNumber_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvCompActualPendingQty_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCompActualPendingQty.SelectedRows.Count > 0)
            {
                txtVoucherNumber.Text = (string)dgvCompActualPendingQty.SelectedRows[0].Cells[0].Value;
                txtQuantity.Text = Convert.ToDecimal(dgvCompActualPendingQty.SelectedRows[0].Cells[5].Value).ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
