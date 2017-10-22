using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory_Control_System
{
    public partial class Form1 : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        Transaction objTrans = new Transaction();

        private string strOperation = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblComponentCode.Text = string.Empty;

            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            PopulateVendorDropdown();

            cmbVendor.SelectedIndex = 0;

            PopulateComponentDropdown();

            cmbComponent.SelectedIndex = 0;

            PopulateRejectionReasons();

            PrepareOpenChalaanList();

        }

        private void PrepareOpenChalaanList()
        {
            lstvwOpenChalaans.Columns.Add(new ColumnHeader());
            lstvwOpenChalaans.Columns[0].Text = "Ch Num";
            lstvwOpenChalaans.Columns[0].Width = 50;

            lstvwOpenChalaans.Columns.Add(new ColumnHeader());
            lstvwOpenChalaans.Columns[1].Text = "Component Name";
            lstvwOpenChalaans.Columns[1].Width = 120;

            lstvwOpenChalaans.Columns.Add(new ColumnHeader());
            lstvwOpenChalaans.Columns[2].Text = "Tran Date";
            lstvwOpenChalaans.Columns[2].Width = 120;

            lstvwOpenChalaans.Columns.Add(new ColumnHeader());
            lstvwOpenChalaans.Columns[3].Text = "Tran Year";
            lstvwOpenChalaans.Columns[3].Width = 70;
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



        private void PopulateRejectionReasons()
        {

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select RejectionCode, ReasonofRejection from dbo.RejectionMaster";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {

                cmbRejectionReason.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    cmbRejectionReason.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PopulateRejectionReasons" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        private void PopulateVendorDropdown()
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select VendorCode, Name + ' (' + [TYPE] + ')' from dbo.VendorMaster";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {

                cmbVendor.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    cmbVendor.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
                }

                //cmbVendor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PopulateVendorDropdown" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        private void PopulateComponentDropdown()
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select ComponentCode, Name from dbo.ComponentMaster";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                string strComponentName = string.Empty;

                cmbComponent.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    strComponentName = sqlDR.GetString(1);
                    cmbComponent.Items.Add(new Item(strComponentName, sqlDR.GetString(0)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PopulateComponentDropdown" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
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
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
                //vds = null;
            }
        }

        /*
        public void RefreshDataGrid(string value)
        {
            DataTable dtTransactions = new DataTable("VendorTransactions");

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select * from dbo.vw_Transactions where vendorCode = '" + value + "'";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {

                if (sqlDR.HasRows)
                {
                    //dtTransactions.Load(sqlDR);

                    //dgvTransactions.DataSource = dtTransactions;

                    //dgvTransactions.Refresh();
                }
                else
                {
                    //dgvTransactions.DataSource = "";
                    //dgvTransactions.Refresh();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlCmd = null;
                sqlDR.Close();
            }
        }
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //vendor dropdown
            //ClearFields();

            ComboBox cmb1 = (ComboBox)sender;
            Item itm = (Item)cmb1.SelectedItem;
            GetDataSummary(itm.Value);
            //GetOpenChalaansByVendor(itm.Value);
            //GetOpenChalaansByVendor2(itm.Value, false);
            GetOpenChalaansByVendorComponent(itm.Value);
            GetActualPendingQty();
            //RefreshDataGrid(itm.Value);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {

            cmbVendor.Text = "";
            cmbComponent.Text = "";
            cmbType.Text = "";
            txtChalaanNumberInternal.Text = "";
            txtChalaanNumberExternal.Text = "";
            txtQuantity.Text = "";
            txtRejectedQuantity.Text = "";
            txtBilledQuantity.Text = "";

            if (strOperation != "Reset")
            {
                //data summary section
                lblVendorStock.Text = "Quantity with Vendor: ";
                lblDateReceived.Text = "Last Date Received: ";
                lblDateSent.Text = "Last Date Sent: ";
            }

            cmbRejectionReason.Text = "";

            if (lblVendorStock.Text == "Quantity with Vendor: ")
            {
                lblVendorStock.Text = "Quantity with Vendor: Not available";
            }

            if (lblDateReceived.Text == "Last Date Received: ")
            {
                lblDateReceived.Text = "Last Date Received: Not available";
            }

            if (lblDateSent.Text == "Last Date Sent: ")
            {
                lblDateSent.Text = "Last Date Sent: Not available";
            }

        }

        private void EnableDisable(string pOperation)
        {
            strOperation = pOperation;

            if (pOperation == "Add")
            {
                btnSave.Enabled = true;
                cmbVendor.Enabled = true;
                cmbComponent.Enabled = true;
                cmbType.Enabled = true;
                txtQuantity.Enabled = true;
                txtChalaanNumberExternal.Enabled = true;
                txtChalaanNumberInternal.Enabled = true;
                txtRejectedQuantity.Enabled = (cmbType.Text == "Incoming");
                chkBilledQuantity.Checked = true;
                chkBilledQuantity.Enabled = true;
                txtBilledQuantity.Enabled = !chkBilledQuantity.Checked;
                cmbRejectionReason.Enabled = txtRejectedQuantity.Enabled;
            }
            else if (pOperation == "Save")
            {
                btnSave.Enabled = false;
                cmbVendor.Enabled = false;
                cmbComponent.Enabled = false;
                cmbType.Enabled = false;
                txtQuantity.Enabled = false;
                txtChalaanNumberExternal.Enabled = false;
                txtChalaanNumberInternal.Enabled = false;
                txtRejectedQuantity.Enabled = false;
                chkBilledQuantity.Enabled = false;
                txtBilledQuantity.Enabled = !chkBilledQuantity.Checked;
                cmbRejectionReason.Enabled = false;
            }
            else if (pOperation == "Reset")
            {
                btnSave.Enabled = true;
                cmbVendor.Enabled = true;
                cmbComponent.Enabled = true;
                cmbType.Enabled = true;
                txtQuantity.Enabled = true;
                txtChalaanNumberExternal.Enabled = false;
                txtChalaanNumberInternal.Enabled = true;
                txtRejectedQuantity.Enabled = false;
                chkBilledQuantity.Checked = true;
                chkBilledQuantity.Enabled = false;
                txtBilledQuantity.Enabled = !chkBilledQuantity.Checked;
                cmbRejectionReason.Enabled = false;
                //lstvwOpenChalaans.Items.Clear();
                cmbVendor.SelectedValue = "";
            }

        }

        private bool ValidateData()
        {

            Item itmVendor;
            Item itmComponent;
            Item itmOperation;

            if (cmbVendor.SelectedItem != null)
                itmVendor = (Item)cmbVendor.SelectedItem;
            else
                itmVendor = (Item)cmbVendor.Items[0];

            if (cmbComponent.SelectedItem != null)
                itmComponent = (Item)cmbComponent.SelectedItem;
            else
                itmComponent = (Item)cmbComponent.Items[0];

            if (cmbOperation.SelectedItem != null)
                itmOperation = (Item)cmbOperation.SelectedItem;
            else
                itmOperation = (Item)cmbOperation.Items[0];

            try
            {

                if (txtReferenceNumber.Text == string.Empty)
                {
                    MessageBox.Show("Reference number cannot be left blank!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReferenceNumber.Focus();
                    return false;
                }

                if (!IsReferenceNumberValid())
                {
                    MessageBox.Show("Invalid Reference number!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReferenceNumber.Focus();
                    return false;
                }

                if (itmVendor.Value == string.Empty)
                {
                    MessageBox.Show("Please select a vendor!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbVendor.Focus();
                    return false;
                }

                if (itmComponent.Value == string.Empty)
                {
                    MessageBox.Show("Please select a component!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbComponent.Focus();
                    return false;
                }

                if (itmOperation.Value == string.Empty)
                {
                    MessageBox.Show("Please select an operation!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbOperation.Focus();
                    return false;
                }

                if (cmbType.Text == string.Empty)
                {
                    MessageBox.Show("Please select Transaction Type [Internal or External]!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbType.Focus();
                    return false;
                }

                if (cmbType.Text == "Incoming")
                {
                    if (txtChalaanNumberInternal.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please provide Chalaan number (Internal or External)!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChalaanNumberInternal.Focus();
                        return false;
                    }
                }

                if (cmbType.Text == "Outgoing")
                {
                    if (txtChalaanNumberExternal.Text.Trim() != string.Empty)
                    {
                        MessageBox.Show("External chalaan number is not required for Outgoing transactions! Please clear the external chalaan number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChalaanNumberExternal.Focus();
                        return false;
                    }
                    if (txtChalaanNumberInternal.Text == string.Empty)
                    {
                        MessageBox.Show("Please provide Chalaan number (Internal)!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChalaanNumberInternal.Focus();
                        return false;
                    }
                }

                if (IsChalaanNumberDuplicate())
                {
                    MessageBox.Show("Duplicate Chalaan number. Please enter an unused Chalaan number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChalaanNumberInternal.Focus();
                    return false;
                }

                if (txtQuantity.Text == string.Empty)
                {
                    MessageBox.Show("Quantity cannot be left blank!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                    return false;
                }

                if (txtQuantity.Text != string.Empty)
                {
                    if (Convert.ToDecimal(txtQuantity.Text) < 0)
                    {
                        MessageBox.Show("Quantity cannot be less than zero!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQuantity.Focus();
                        return false;
                    }
                }

                if (txtRejectedQuantity.Text != string.Empty)
                {
                    if (Convert.ToDecimal(txtRejectedQuantity.Text) < 0)
                    {
                        MessageBox.Show("Rejected Quantity cannot be less than zero!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRejectedQuantity.Focus();
                        return false;
                    }
                }

                if (!objTrans.IsValidIncomingChalaan && cmbType.Text == "Incoming")
                {
                    MessageBox.Show("Chalaan number not found. Either select outgoing as type or enter a valid Internal Chalaan number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChalaanNumberInternal.Focus();
                    return false;
                }

                //validate Incoming Qty should not exceed Outgoing Qty
                if (!IsQuantityValid())
                {
                    MessageBox.Show("Incoming Qty cannot be greater than Outgoing Qty for a Chalaan!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: ValidateData" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsReferenceNumberValid()
        {
            string strCmd = "SELECT ReferenceNumber FROM dbo.[MaterialTransactions] WHERE ReferenceNumber = '" + txtReferenceNumber.Text + "'";

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                return sqlDR.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: IsReferenceNumberValid" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
            return false;
        }

        private bool IsValidIncomingChalaan()
        {



            return false;
        }

        private bool IsChalaanNumberDuplicate()
        {
            if (SearchByInternalChalaan() && cmbType.Text == "Outgoing")
                return true;

            return false;
        }

        private bool SearchByInternalChalaan()
        {

            string strCmd = "select * from dbo.[Transaction] where ChalaanNumberInternal = '" + txtChalaanNumberInternal.Text + "' and year(trandate) = " + dtTranDate.Value.Year;

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                return sqlDR.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: SearchByInternalChalaan" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
            return false;
        }

        private void GetTransaction(string chalaanNumber, string year)
        {
            string strCmd = "select VendorCode, ComponentCode, TotalIncomingQuantity, TotalOutgoingQty, ChalaanNumberInternal, TranDate, OperationCode from GetIncomingOutgoingQtyByChalaan('" + chalaanNumber + "'," + year + ")";

            string strVendorCode = string.Empty;

            string strComponentCode = string.Empty;

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            decimal IncomingQty = 0;

            try
            {

                if (sqlDR.HasRows)
                {
                    sqlDR.Read();

                    objTrans.VendorCode = sqlDR.GetString(0);

                    objTrans.TransactionDate = sqlDR.GetDateTime(5);

                    objTrans.ComponentCode = sqlDR.GetString(1);

                    objTrans.ChalaanNumberInternal = sqlDR.GetString(4);

                    objTrans.IncomingQuantity = sqlDR.GetDecimal(2);

                    objTrans.TotalQuantity = sqlDR.GetDecimal(3);

                    objTrans.Quantity = objTrans.TotalQuantity;

                    objTrans.RejectedQuantity = sqlDR.GetDecimal(2);

                    if (!sqlDR.IsDBNull(6))
                        objTrans.OperationCode = sqlDR.GetString(6);

                    objTrans.IsValidIncomingChalaan = true;

                    if (sqlDR != null)
                    {
                        sqlDR.Close();
                        sqlDR = null;
                        sqlCmd = null;
                    }


                }
                else
                {
                    objTrans.ChalaanNumberInternal = string.Empty;
                    objTrans.IsValidIncomingChalaan = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Method: GetTransaction" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objTrans = null;
            }
            finally
            {
                if (sqlDR != null)
                {
                    sqlDR.Close();
                    sqlDR = null;
                    sqlCmd = null;
                }
            }
        }

        private bool IsQuantityValid()
        {

            try
            {
                if (FindChalaan(txtChalaanNumberInternal.Text, dtTranDate.Value.Year.ToString()))
                {
                    decimal dIncomingQuantity = objTrans.IncomingQuantity;

                    if (txtQuantity.Text != string.Empty)
                    {
                        dIncomingQuantity = dIncomingQuantity + Convert.ToDecimal(txtQuantity.Text);
                        if (txtRejectedQuantity.Text != string.Empty)
                            dIncomingQuantity = dIncomingQuantity + Convert.ToDecimal(txtRejectedQuantity.Text);
                    }

                    if (dIncomingQuantity > objTrans.TotalQuantity)
                        return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: IsQuantityValid" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
            return true;

        }

        private void SelectComboItem(ComboBox cmb, string selectedItem)
        {
            int i = 0;

            foreach (Item itm in cmb.Items)
            {
                if (itm.Value == selectedItem)
                {
                    cmb.SelectedIndex = i;
                }
                i++;
            }
        }

        private void SaveData()
        {
            string strType = string.Empty;

            SqlCommand sqlCmd = new SqlCommand();

            try
            {

                if (!ValidateData())
                {
                    return;
                }

                string strMessage = "Are you sure you would like to save it?";

                DialogResult dResult = MessageBox.Show(strMessage, "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dResult == DialogResult.No)
                    return;

                //EnableDisable("Save");

                Item itmVendor = (Item)cmbVendor.SelectedItem;

                Item itmComponent = (Item)cmbComponent.SelectedItem;

                Item itmRejectionCode;

                if (cmbRejectionReason.SelectedItem != null)
                    itmRejectionCode = (Item)cmbRejectionReason.SelectedItem;
                else
                    itmRejectionCode = (Item)cmbRejectionReason.Items[0];

                Item itmOperation = (Item)cmbOperation.SelectedItem;

                if (cmbType.Text == "Outgoing")
                    strType = "O";
                else
                    strType = "I";

                if (string.IsNullOrEmpty(txtRejectedQuantity.Text))
                    txtRejectedQuantity.Text = "0";

                if (string.IsNullOrEmpty(txtBilledQuantity.Text))
                    txtBilledQuantity.Text = "0";

                string strCommand = "Insert into [Transaction] (TranDate, ChalaanNumberInternal, ChalaanNumberExternal, VendorCode, ComponentCode, Quantity, RejectedQuantity, [Type], BilledQuantity, RejectionCode, ReferenceNumber, OperationCode)" +
                    "Values('" + dtTranDate.Text + "','" + txtChalaanNumberInternal.Text + "','" + txtChalaanNumberExternal.Text + "','" + itmVendor.Value + "','" + itmComponent.Value + "'," + txtQuantity.Text + "," + txtRejectedQuantity.Text + ",'" + strType + "'," + txtBilledQuantity.Text + ",'" + itmRejectionCode.Value + "', '" + txtReferenceNumber.Text + "','" + itmOperation.Value + "')";

                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = strCommand;

                sqlCmd.ExecuteNonQuery();

                Item itm = (Item)cmbVendor.SelectedItem;
                //RefreshDataGrid(itm.Value);

                GetOpenChalaansByVendorComponent(itm.Value);

                ClearFields();
                //EnableDisable("Add");
                dtTranDate.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: btnSaveClick: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCmd = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private bool FindChalaan(string chalaanNumber, string year)
        {

            GetTransaction(chalaanNumber, year);

            if (objTrans.ChalaanNumberInternal != string.Empty && objTrans.ChalaanNumberInternal != null)
                return true;
            else
                return false;
        }

        private void EnableDisableIfChalaanFound(bool bFound)
        {
            cmbComponent.Enabled = !bFound;
            cmbType.Enabled = !bFound;
            cmbVendor.Enabled = !bFound;

            if (!bFound)
            {
                txtQuantity.Text = "";
                //lstOpenChalaan.Items.Clear();
            }
        }

        private void PopulateData()
        {

            cmbType.SelectedIndex = 1;

            txtChalaanNumberInternal.Text = objTrans.ChalaanNumberInternal;

            //MessageBox.Show(objTrans.TransactionDate.ToString());
            lblTransactionsDateOriginal.Text = objTrans.TransactionDate.ToString("dd-MMM-yyyy");

            dtTranDate.Text = DateTime.Today.ToString("dd-MMM-yyyy"); //incoming transaction should show current date

            SelectComboItem(cmbComponent, objTrans.ComponentCode);

            SelectComboItem(cmbVendor, objTrans.VendorCode);

            SelectComboItem(cmbOperation, objTrans.OperationCode);

            txtQuantity.Text = (objTrans.TotalQuantity - objTrans.IncomingQuantity).ToString();

        }

        private void txtChalaanNumberInternal_Leave(object sender, EventArgs e)
        {
            //ValidateIncomingQty();
            if (FindChalaan(txtChalaanNumberInternal.Text, dtTranDate.Value.Year.ToString()))
            {
                PopulateData();
                //disable component & type dropdown
                EnableDisableIfChalaanFound(true);
            }
            else
            {
                EnableDisableIfChalaanFound(false);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (chkBilledQuantity.Checked)
                txtBilledQuantity.Text = txtQuantity.Text;
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            //if (FindChalaan(txtChalaanNumberInternal.Text, dtTranDate.Value.Year.ToString()))
            //{
            //    PopulateData();
            //    //disable component & type dropdown
            //    EnableDisableIfChalaanFound(true);
            //}
            //else
            //{
            //    EnableDisableIfChalaanFound(false);
            //}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text == "Incoming")
            {
                txtRejectedQuantity.Enabled = true;
                cmbRejectionReason.Enabled = true;
                lblBilledQuantity.Visible = true;
                chkBilledQuantity.Visible = true;
                txtBilledQuantity.Visible = true;
                txtChalaanNumberExternal.Enabled = true;
            }
            else
            {
                txtRejectedQuantity.Enabled = false;
                cmbRejectionReason.Enabled = false;
                lblBilledQuantity.Visible = false;
                chkBilledQuantity.Visible = false;
                txtBilledQuantity.Visible = false;
                txtChalaanNumberExternal.Enabled = false;
            }
        }

        private void dtTranDate_ValueChanged(object sender, EventArgs e)
        {
            ////string strTranDate = dtTranDate.Text.ToString();

            ////////MessageBox.Show(strTranDate);

            //if (FindChalaan(txtChalaanNumberInternal.Text, dtTranDate.Value.Year.ToString()))
            //{
            //    PopulateData();
            //    //disable component & type dropdown
            //    EnableDisableIfChalaanFound(true);
            //}
            //else
            //{
            //    EnableDisableIfChalaanFound(false);
            //}
            ////dtTranDate.Text = strTranDate;
        }

        private void chkBilledQuantity_CheckedChanged(object sender, EventArgs e)
        {
            lblBilledQuantity.Enabled = !chkBilledQuantity.Checked;
            txtBilledQuantity.Enabled = !chkBilledQuantity.Checked;

            if (!chkBilledQuantity.Checked)
                txtBilledQuantity.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtChalaanNumberInternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void transactionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search_Transaction frmSearchTransaction = new Search_Transaction();

            frmSearchTransaction.ShowDialog();
        }

        public void GetDataByChalaan(string chalaanNumber, string year)
        {

            //VendorDataSummary vds = new VendorDataSummary();

            DateTime TranDate;
            string strComponentCode = string.Empty;
            decimal dQuantity;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "select TranDate, ComponentCode, ChalaanNumberInternal, Quantity, TotalIncomingQuantity, RemainingQuantity, VendorCode from [GetDataByChalaanNumberInternal]('" + chalaanNumber + "','" + year + "')";

            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                if (sqlDR.HasRows)
                {
                    sqlDR.Read();

                    TranDate = sqlDR.GetDateTime(0);
                    strComponentCode = sqlDR.GetString(1);
                    dQuantity = sqlDR.GetDecimal(5);

                    sqlDR.Close();
                    sqlDR = null;
                    sqlCmd = null;

                    dtTranDate.Text = TranDate.ToShortDateString();

                    SelectComboItem(cmbComponent, strComponentCode);

                    txtQuantity.Text = dQuantity.ToString();

                    //if (!sqlDR.IsDBNull(2))
                    //    lblDateReceived.Text = "Last Date Received: " + sqlDR.GetDateTime(2).ToShortDateString();
                    //else
                    //    lblDateReceived.Text = "Last Date Received: Not available";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Method name: GetDataByChalaan " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //if (sqldr != null)
                //{
                //    sqlDR.Close();
                //    sqlDR = null;
                //}
                //sqlCmd = null;
                //vds = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTransaction();
        }

        private void SearchTransaction()
        {
            Search_Transaction frmSearchTransaction = new Search_Transaction();

            frmSearchTransaction.ShowDialog();
        }

        private void lstOpenChalaan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetDataByChalaan(sender
        }

        private void GetOpenChalaansByVendor(string vendorCode)
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "select VendorCode, ChalaanNumber, TranDateYear, OutgoingQuantity, IncomingQuantity from OpenChalaansByVendor('" + vendorCode + "')";
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                //lstOpenChalaan.Items.Clear();

                //while (sqlDR.Read())
                //{
                //lstOpenChalaan.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetInt32(2).ToString()));

                //}
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

        private void GetOpenChalaansByVendor2(string vendorCode, bool byComponent)
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "select VendorCode, ChalaanNumber, TranDateYear, TranDate, OutgoingQuantity, IncomingQuantity from OpenChalaansByVendor('" + vendorCode + "')  ORDER BY CAST(ChalaanNumber as int) asc";
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                //lstOpenChalaan.Items.Clear();

                lstvwOpenChalaans.Items.Clear();

                while (sqlDR.Read())
                {
                    lstvwOpenChalaans.Items.Add(new ListViewItem(new string[] { sqlDR.GetString(1), sqlDR.GetInt32(2).ToString(), sqlDR.GetDateTime(3).ToString("dd-MMM-yyyy") }));
                }
                
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

        private void GetOpenChalaansByVendorComponent(string vendorCode)
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "select VendorCode, ChalaanNumber, TranDateYear, TranDate, OutgoingQuantity, IncomingQuantity, [Name] as ComponentName from OpenChalaansByVendorComponent('" + vendorCode + "')";
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                //lstOpenChalaan.Items.Clear();

                lstvwOpenChalaans.Items.Clear();

                while (sqlDR.Read())
                {
                    lstvwOpenChalaans.Items.Add(new ListViewItem(new string[] { sqlDR.GetString(1), sqlDR.GetString(6), sqlDR.GetDateTime(3).ToString("dd-MMM-yyyy"), sqlDR.GetInt32(2).ToString() }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method name: GetOpenChalaansByVendorComponent " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
                //vds = null;
            }
        }

        private void lstvwOpenChalaans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lst = (ListView)sender;

            if (lst.SelectedItems.Count > 0)
            {

                if (FindChalaan(lst.SelectedItems[0].SubItems[0].Text, lst.SelectedItems[0].SubItems[3].Text))
                {
                    PopulateData();
                    strOperation = "Incoming";
                    //disable component & type dropdown
                    EnableDisableIfChalaanFound(true);
                }
                else
                {
                    EnableDisableIfChalaanFound(false);
                }                //MessageBox.Show(lst.SelectedItems[0].SubItems[0].Text);
                //MessageBox.Show(lst.SelectedItems[0].SubItems[1].Text);
            }

            //string selectedChalaanNumber = lst.SelectedItems[0].Text;
            ////string selectedTranDateYear = lst.SelectedItems[1]

            //if (FindChalaan(itm.Name, itm.Value))
            //{
            //    PopulateData();
            //    //disable component & type dropdown
            //    EnableDisableIfChalaanFound(true);
            //}
            //else
            //{
            //    EnableDisableIfChalaanFound(false);
            //}

        }

        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox lst = (ComboBox)sender;

            Item itm = (Item)lst.SelectedItem;

            lblComponentCode.Text = itm.Value;

            PopulateOperationDropdown();

        }

        private void PopulateOperationDropdown()
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            Item itmComponent = (Item)cmbComponent.SelectedItem;

            sqlCmd.CommandText = "SELECT	dbo.OperationMaster.OperationId AS OperationId " +
                                 ", dbo.OperationMaster.OperationCode AS OperationCode " +
                                 ", dbo.OperationMaster.ComponentCode " +
                                 ", dbo.OperationMaster.OperationName " +
                                 ", dbo.OperationMaster.OperationTimePerUnit " +
                                 ", dbo.ComponentMaster.Name AS ComponentName " +
                                 " FROM    dbo.OperationMaster INNER JOIN  dbo.ComponentMaster ON dbo.OperationMaster.ComponentCode = dbo.ComponentMaster.ComponentCode " +
                                 " WHERE dbo.OperationMaster.ComponentCode = '" + itmComponent.Value + "'";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                cmbOperation.Items.Clear();

                string strOperationName = string.Empty;

                cmbOperation.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    strOperationName = sqlDR.GetString(3);
                    cmbOperation.Items.Add(new Item(strOperationName, sqlDR.GetString(1)));
                }

                cmbOperation.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PopulateOperationDropdown" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        private void GetActualPendingQty()
        {
            DataTable dtQuantity = new DataTable("ActualPendingQty");

            string strCmd = string.Empty;

            Item itmVendor = (Item)cmbVendor.SelectedItem;

            strCmd = "SELECT ComponentCode as [Component Code], ComponentName as [Component Name], ActualQuantity as [Sent Quantity], (ActualQuantity - PendingQty) as [Received Quantity], PendingQty as [Quantity Balance] FROM [dbo].[GetActualPendingQty]('" + itmVendor.Value + "')";

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
            }
            else
            {
                dgvCompActualPendingQty.DataSource = "";
                dgvCompActualPendingQty.Refresh();
            }
        }

        private void btnTimesheet_Click(object sender, EventArgs e)
        {
            Timesheet frmTimesheet = new Timesheet();

            frmTimesheet.ShowDialog();
        }

        private void txtReferenceNumber_TextChanged(object sender, EventArgs e)
        {
            GetMaterialInfo();

        }

        private void GetMaterialInfo()
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT a.MaterialCode, b.MaterialName FROM dbo.MaterialTransactions a INNER JOIN dbo.MaterialMaster b ON a.MaterialCode = b.MaterialCode WHERE ReferenceNumber = '" + txtReferenceNumber.Text + "'";
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                lblMaterial.Text = string.Empty;

                while (sqlDR.Read())
                {
                    lblMaterial.Text = sqlDR.GetString(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method name: GetMaterialInfo " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
                //vds = null;
            }
        }

        private void btnSearchReferenceNumber_Click(object sender, EventArgs e)
        {
            frmSearchMaterial frmSearchMaterial1 = new frmSearchMaterial();

            frmSearchMaterial1.ShowDialog(this);
        }

        public void GetReferenceNumber(string ReferenceNumber)
        {
            txtReferenceNumber.Text = ReferenceNumber;
        }

        private void txtReferenceNumber_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string strMessage = "Are you sure you would like to exit?";

            DialogResult dResult = MessageBox.Show(strMessage, "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.No)
                e.Cancel = true;


        }

        private void dtTranDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearchReferenceNumber_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbVendor_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtChalaanNumberInternal_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void chkBilledQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtBilledQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbComponent_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtChalaanNumberExternal_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtRejectedQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbRejectionReason_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnTimesheet_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void lstvwOpenChalaans_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvCompActualPendingQty_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void KeyAction(KeyEventArgs e)
        {


            if (e.KeyCode.ToString() == "Escape")
            {
                if (strOperation != "Incoming")
                {
                    this.Close();
                }
                else
                {
                    EnableDisable("Reset");
                    ClearFields();
                    strOperation = string.Empty;
                }
            }

            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }

            if (e.KeyCode.ToString() == "F4")
            {
                if (lblActualPendingQty.Visible)
                {
                    lblActualPendingQty.Visible = false;
                    dgvCompActualPendingQty.Visible = false;
                    this.Height = 420;
                }
                else
                {
                    lblActualPendingQty.Visible = true;
                    dgvCompActualPendingQty.Visible = true;
                    this.Height = 569;
                }
            }

            if (e.KeyCode.ToString() == "F2")
            {
                SaveData();
            }

            if (e.KeyCode.ToString() == "F3")
            {
                SearchTransaction();
            }
        }

        private void dgvCompActualPendingQty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCompActualPendingQty_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dgvCompActualPendingQty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Search_Transaction objSearchTran = new Search_Transaction();

            objSearchTran.IsSearch = true;

            //vendor code
            Item itmVendorCode = (Item)cmbVendor.SelectedItem;
            string strVendorCode = itmVendorCode.Value;

            //component code
            string strComponentCode = dgvCompActualPendingQty.Rows[dgvCompActualPendingQty.SelectedRows[0].Index].Cells[0].Value.ToString();

            objSearchTran.VendorCode = strVendorCode;

            objSearchTran.ComponentCode = strComponentCode;

            objSearchTran.ShowDialog();
        }

        private void cmbOperation_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void lstvwOpenChalaans_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

    }
}
