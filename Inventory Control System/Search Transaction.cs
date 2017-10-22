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
    public partial class Search_Transaction : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        int iTransactionId = 0;

        public bool IsSearch = false;

        private string strOperation = string.Empty;

        public Search_Transaction()
        {
            InitializeComponent();
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

        private void PopulateVendorDropdown()
        {
            DataTable dtComponent = new DataTable("Vendor");

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select VendorCode, Name + ' (' + [TYPE] + ')' from dbo.VendorMaster";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                cmbVendorSearch.Items.Add(new Item("--None--", ""));
                cmbVendor.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    cmbVendorSearch.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
                    cmbVendor.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
                }

                cmbVendorSearch.SelectedIndex = 0;
                cmbVendor.SelectedIndex = 0;

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

        private void PopulateComponentDropdown()
        {
            DataTable dtComponent = new DataTable("Component");

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select ComponentCode, Name from dbo.ComponentMaster";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {

                cmbComponentSearch.Items.Add(new Item("--None--", ""));
                cmbComponent.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    cmbComponentSearch.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
                    cmbComponent.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
                }

                cmbComponentSearch.SelectedIndex = 0;
                cmbComponent.SelectedIndex = 0;

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

        private string PrepareSearchCriteria()
        {

            string strSearchSQL = string.Empty;
            string strSearchCriteria = string.Empty;

            SearchObject objSearch = new SearchObject();

            try
            {
                objSearch.IncludeDate = chkIncludeDate.Checked;

                objSearch.YearOnly = chkYear.Checked;

                objSearch.TransactionMonth = dtTranDateSearch.Value.Month.ToString();

                objSearch.TransactionYear = dtTranDateSearch.Value.Year.ToString();

                objSearch.ChalaanNumberInternal = txtChalaanNumberInternalSearch.Text;

                Item itm = (Item)cmbVendorSearch.SelectedItem;
                objSearch.VendorCode = itm.Value;

                Item itmComponent = (Item)cmbComponentSearch.SelectedItem;
                objSearch.ComponentCode = itmComponent.Value;

                objSearch.RejectedLots = chkRejectedLots.Checked;

                objSearch.TransactionType = cmbType.Text;

                return objSearch.PrepareSearchCriteria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PrepareSearchCriteria " + Environment.NewLine + ex.Message);
            }
            finally
            {
                objSearch = null;
            }
            return strSearchCriteria;
        }

        private bool HasIncomingTransactions()
        {

            string strCmd = "SELECT TransactionId, TranDate, ChalaanNumberInternal FROM dbo.[Transaction] WHERE TransactionId = " + iTransactionId;

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                return sqlDR.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: HasIncomingTransactions" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
            return false;
        }

        private bool ValidateData()
        {
            Item itmVendor = (Item)cmbVendor.SelectedItem;

            Item itmComponent = (Item)cmbComponent.SelectedItem;

            if (cmbVendor.Text == string.Empty)
            {
                MessageBox.Show("Please select a vendor!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbVendor.Focus();
                return false;
            }

            if (cmbComponent.Text == string.Empty)
            {
                MessageBox.Show("Please select a component!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbComponent.Focus();
                return false;
            }

            if (!IsReferenceNumberValid())
            {
                MessageBox.Show("Invalid Reference number!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReferenceNumber.Focus();
                return false;
            }

            if (cmbType.Text == "Incoming")
            {
                if (txtChalaanNumberInternal.Text == string.Empty || txtChalaanNumberInternal.Text == string.Empty)
                {
                    MessageBox.Show("Please provide Chalaan number (Internal pr External)!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChalaanNumberInternal.Focus();
                    return false;
                }
            }

            if (cmbType.Text == "Outgoing")
            {
                //if (txtChalaanNumberExternal.Text.Trim() != string.Empty)
                //{
                //    MessageBox.Show("External chalaan number is not required for Outgoing transactions! Please clear the external chalaan number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtChalaanNumberExternal.Focus();
                //    return false;
                //}
                if (txtChalaanNumberInternal.Text == string.Empty)
                {
                    MessageBox.Show("Please provide Chalaan number (Internal)!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChalaanNumberInternal.Focus();
                    return false;
                }
            }

            //if (IsChalaanNumberDuplicate())
            //{
            //    MessageBox.Show("Duplicate Chalaan number. Please enter an unused Chalaan number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtChalaanNumberInternal.Focus();
            //    return false;
            //}

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


            //validate Incoming Qty should not exceed Outgoing Qty
            //if (!ValidateIncomingQty())
            //    return false;

            return true;
        }

        private void SearchTransactions(string strSearchCriteria)
        {
            DataTable dtTransactions = new DataTable("VendorTransactions");

            string strCmd = string.Empty;

            if (strSearchCriteria != string.Empty)
            {
                //strCmd = "select * from dbo.[transaction] where " + strSearchCriteria;
                strCmd = "SELECT [TransactionId], convert(varchar, [TranDate], 103) as [TranDate], [ChalaanNumberInternal], [ChalaanNumberExternal], [Component name], [Vendor Name], [Quantity], [RejectedQuantity], [Type] FROM [ICS].[dbo].[vw_Transactions] where " + strSearchCriteria;
            }
            else
            {
                strCmd = "SELECT [TransactionId],convert(varchar, [TranDate], 103) as [TranDate], [ChalaanNumberInternal], [ChalaanNumberExternal], [Component name], [Vendor Name], [Quantity], [RejectedQuantity], [Type] FROM [ICS].[dbo].[vw_Transactions] ";
            }

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
                    dtTransactions.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtTransactions);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: SearchTransactions" + Environment.NewLine + ex.Message);
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
                dgvTransactions.DataSource = dt;
                dgvTransactions.Refresh();
            }
            else
            {
                dgvTransactions.DataSource = "";
                dgvTransactions.Refresh();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            try
            {
                string strSearchCriteria = PrepareSearchCriteria();

                SearchTransactions(strSearchCriteria);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: btnFindClick" + Environment.NewLine + ex.Message);
            }
            finally
            {

            }
        }

        private void ClearFields()
        {
            dtTranDate.Value = DateTime.Today;
            cmbVendor.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtReferenceNumber.Text = string.Empty;
            txtChalaanNumberInternal.Text = string.Empty;
            txtChalaanNumberExternal.Text = string.Empty;
            cmbOperation.Text = string.Empty;
            cmbComponent.Text = string.Empty;
            txtRejectedQuantity.Text = string.Empty;
            txtBilledQuantity.Text = string.Empty;
            lblTransactionType.Text = "Transaction Type: " + string.Empty;
            iTransactionId = 0;
        }

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
                    dtTransactions.Load(sqlDR);

                    dgvTransactions.DataSource = dtTransactions;

                    dgvTransactions.Refresh();
                }
                else
                {
                    dgvTransactions.DataSource = "";
                    dgvTransactions.Refresh();
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

        private void Search_Transaction_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            PopulateVendorDropdown();

            PopulateComponentDropdown();

            cmbType.SelectedIndex = 0;

            if (IsSearch)
            {
                SelectDropdownItem(cmbVendorSearch, VendorCode);
                SelectDropdownItem(cmbComponentSearch, ComponentCode);

                string strSearchCriteria = PrepareSearchCriteria();

                SearchTransactions(strSearchCriteria);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetTransactionData(int pTransactionId)
        {
            DataTable dtComponent = new DataTable("Vendor");

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "SELECT VendorCode, ComponentCode, TranDate, ChalaanNumberInternal, ChalaanNumberExternal, Quantity, RejectedQuantity, [Type], ReferenceNumber, OperationCode FROM dbo.vw_transactions WHERE TransactionId = " + pTransactionId;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            string strVendorCode = string.Empty;
            string strComponentCode = string.Empty;
            string strOperationCode = string.Empty;
            DateTime dtTransactionDate;
            string strChalaanNumberInternal = string.Empty;
            string strChalaanNumberExternal = string.Empty;
            decimal dQuantity = 0;
            decimal dRejectedQuantity = 0;
            string strTransactionType = string.Empty;
            string strReferenceNumber = string.Empty;

            try
            {
                if (sqlDR.HasRows)
                {
                    sqlDR.Read();

                    strVendorCode = sqlDR.GetString(0);
                    strComponentCode = sqlDR.GetString(1);
                    if (!sqlDR.IsDBNull(9))
                        strOperationCode = sqlDR.GetString(9);
                    dtTransactionDate = sqlDR.GetDateTime(2);
                    strChalaanNumberInternal = sqlDR.GetString(3);
                    if (!sqlDR.IsDBNull(4))
                        strChalaanNumberExternal = sqlDR.GetString(4);
                    dQuantity = sqlDR.GetDecimal(5);
                    dRejectedQuantity = sqlDR.GetDecimal(6);
                    strTransactionType = sqlDR.GetString(7);
                    if (!sqlDR.IsDBNull(8))
                        strReferenceNumber = sqlDR.GetString(8);

                    if (!sqlDR.IsClosed)
                        sqlDR.Close();

                    SelectDropdownItem(cmbVendor, strVendorCode);

                    SelectDropdownItem(cmbComponent, strComponentCode);

                    SelectDropdownItem(cmbOperation, strOperationCode);

                    dtTranDate.Text = dtTransactionDate.ToShortDateString();

                    txtChalaanNumberInternal.Text = strChalaanNumberInternal;

                    txtChalaanNumberExternal.Text = strChalaanNumberExternal;

                    txtQuantity.Text = dQuantity.ToString();

                    txtRejectedQuantity.Text = dRejectedQuantity.ToString();

                    lblTransactionType.Text = "Transaction Type: " + strTransactionType;

                    txtReferenceNumber.Text = strReferenceNumber;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: GetTransactionData" + Environment.NewLine + ex.Message);
            }
            finally
            {
                if (!sqlDR.IsClosed)
                {
                    sqlDR.Close();
                    sqlDR = null;
                    sqlCmd = null;
                }
            }
        }

        private void SelectDropdownItem(ComboBox cmb, string strValue)
        {
            int i = 0;

            //MessageBox.Show("SelectDropdownList " + strValue);

            foreach (Item itm in cmb.Items)
            {

                if (itm.Value == strValue)
                {
                    cmb.SelectedIndex = i;
                }
                i++;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (iTransactionId <= 0)
            {
                MessageBox.Show("No transaction selected for editing.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EnableDisable("Edit");
        }

        private void EnableDisable(string pOperation)
        {
            strOperation = pOperation;

            if (pOperation == "Edit")
            {
                btnEdit.Enabled = !(pOperation == "Edit");
                btnSave.Enabled = (pOperation == "Edit");
                btnDelete.Enabled = !(pOperation == "Edit");

                dtTranDate.Enabled = (pOperation == "Edit");
                txtChalaanNumberInternal.Enabled = (pOperation == "Edit");
                cmbVendor.Enabled = (pOperation == "Edit");
                cmbComponent.Enabled = (pOperation == "Edit");
                cmbOperation.Enabled = (pOperation == "Edit");
                txtQuantity.Enabled = (pOperation == "Edit");
                txtRejectedQuantity.Enabled = (pOperation == "Edit" && lblTransactionType.Text == "Transaction Type: Incoming");
                txtChalaanNumberExternal.Enabled = (pOperation == "Edit" && lblTransactionType.Text == "Transaction Type: Incoming");
                txtReferenceNumber.Enabled = (pOperation == "Edit" && lblTransactionType.Text == "Transaction Type: Outgoing");
            }

            if (pOperation == "Save")
            {
                btnEdit.Enabled = (pOperation == "Save");
                btnSave.Enabled = !(pOperation == "Save");
                btnDelete.Enabled = (pOperation == "Save");
            }

            if (pOperation == "Reset")
            {
                btnEdit.Enabled = (pOperation == "Reset");
                btnSave.Enabled = !(pOperation == "Reset");
                btnDelete.Enabled = (pOperation == "Reset");

                dtTranDate.Enabled = false;
                txtChalaanNumberInternal.Enabled = false;
                cmbVendor.Enabled = false;
                cmbComponent.Enabled = false;
                cmbOperation.Enabled = false;
                txtQuantity.Enabled = false;
                txtRejectedQuantity.Enabled = false;
                txtChalaanNumberExternal.Enabled = false;
                txtReferenceNumber.Enabled = false;
            }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strType = string.Empty;

            SqlCommand sqlCmd = new SqlCommand();

            try
            {

                if (!ValidateData())
                    return;

                EnableDisable("Save");

                Item itmVendor = (Item)cmbVendor.SelectedItem;

                Item itmComponent = (Item)cmbComponent.SelectedItem;

                Item itmOperationCode = (Item)cmbOperation.SelectedItem;

                if (cmbType.Text == "Outgoing")
                    strType = "O";
                else
                    strType = "I";

                if (string.IsNullOrEmpty(txtRejectedQuantity.Text))
                    txtRejectedQuantity.Text = "0";

                if (string.IsNullOrEmpty(txtBilledQuantity.Text))
                    txtBilledQuantity.Text = "0";

                string strCommand = "UPDATE dbo.[Transaction] SET TranDate = '" + dtTranDate.Text +
                    "', ChalaanNumberInternal = '" + txtChalaanNumberInternal.Text +
                    "', ReferenceNumber = '" + txtReferenceNumber.Text +
                    "', OperationCode = '" + itmOperationCode.Value +
                    "', ChalaanNumberExternal = '" + txtChalaanNumberExternal.Text + "' , VendorCode = '" +
                    itmVendor.Value + "', ComponentCode = '" + itmComponent.Value + "' , Quantity = " +
                    txtQuantity.Text + ", RejectedQuantity = " + txtRejectedQuantity.Text +
                        ", BilledQuantity = " + txtBilledQuantity.Text + " WHERE TransactionId = " + iTransactionId + ";";

                strCommand = strCommand + "UPDATE dbo.[Transaction] SET ReferenceNumber = '" + txtReferenceNumber.Text +
                  "' WHERE ChalaanNumberInternal = '" + txtChalaanNumberInternal.Text + "'";

                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = strCommand;

                sqlCmd.ExecuteNonQuery();

                Item itm = (Item)cmbVendor.SelectedItem;
                //RefreshDataGrid(itm.Value);

                MessageBox.Show("Transaction saved successfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: btnSaveClick: " + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlCmd = null;
            }
        }

        private void dgvTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvTransactions_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int TransactionId = Convert.ToInt32(dgvTransactions.Rows[e.RowIndex].Cells[0].Value);

            GetTransactionData(TransactionId);

            iTransactionId = TransactionId;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (iTransactionId <= 0)
            {
                MessageBox.Show("No transaction selected for deletion.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (HasIncomingTransactions() && lblTransactionType.Text == "Transaction Type: Outgoing")
            {
                MessageBox.Show("This transaction has incoming transactions. It cannot be deleted without deleting the incoming transactions.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string strMessage = "Are you sure you would like to delete this transaction?";

            DialogResult dResult = MessageBox.Show(strMessage, "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.No)
                return;

            string strCommand = "DELETE dbo.[Transaction] WHERE TransactionId = " + iTransactionId;

            SqlCommand sqlCmd = new SqlCommand();

            try
            {

                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = strCommand;

                sqlCmd.ExecuteNonQuery();

                string strSearchCriteria = PrepareSearchCriteria();

                SearchTransactions(strSearchCriteria);

                MessageBox.Show("Transaction deleted successfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: btnDeleteClick: " + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlCmd = null;
            }
        }

        private void Search_Transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            string strMessage = "Are you sure you would like to exit?";

            DialogResult dResult = MessageBox.Show(strMessage, "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.No)
                e.Cancel = true;
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                if (strOperation != "Edit")
                {
                    this.Close();
                }
                else
                {
                    EnableDisable("Reset");
                }
            }

            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void dtTranDateSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void chkIncludeDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void chkYear_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbVendorSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtChalaanNumberInternalSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbComponentSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnFind_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dtTranDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtChalaanNumberInternal_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbVendor_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbComponent_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtRejectedQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnEdit_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
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

        private void txtBilledQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private string mVendorCode;

        public string VendorCode
        {
            get { return mVendorCode; }
            set { mVendorCode = value; }
        }

        private string mComponentCode;

        public string ComponentCode
        {
            get { return mComponentCode; }
            set { mComponentCode = value; }
        }

        private void txtChalaanNumberExternal_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
