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
    public partial class frmVoucher : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        Job objJob = new Job();

        private Int64 mJobId;

        public Int64 JobId
        {
            get { return mJobId; }
            set { mJobId = value; }
        }

        private string mJobCode;

        public string JobCode
        {
            get { return mJobCode; }
            set { mJobCode = value; }
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

        public string strVoucherType = string.Empty;

        public frmVoucher()
        {
            InitializeComponent();
        }

        private void btnContractorVendorTransaction_Click(object sender, EventArgs e)
        {

        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {

            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            if (JobId > 0)
                SetJobData(GetJobDetails(JobId));
            else
            {
                OpenFindJobDialog();
                dtTranDate.Focus();
            }

            PopulateVendorDropdown();

            PopulateOperationDropdown();

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

        private void PopulateOperationDropdown()
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "SELECT	dbo.OperationMaster.OperationId AS OperationId " +
                                 ", dbo.OperationMaster.OperationCode AS OperationCode " +
                                 ", dbo.OperationMaster.ComponentCode " +
                                 ", dbo.OperationMaster.OperationName " +
                                 ", dbo.OperationMaster.OperationTimePerUnit " +
                                 ", dbo.ComponentMaster.Name AS ComponentName " +
                                 " FROM    dbo.OperationMaster INNER JOIN  dbo.ComponentMaster ON dbo.OperationMaster.ComponentCode = dbo.ComponentMaster.ComponentCode " +
                                 " WHERE dbo.OperationMaster.ComponentCode = '" + lblComponentCode.Text + "'";

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

        private void OpenFindJobDialog()
        {
            frmFindJob frmFJ = new frmFindJob();

            this.Opacity = .90;

            frmFJ.FormClosed += new FormClosedEventHandler(frmFJ_FormClosed);

            frmFJ.SourceForm = "Voucher";

            frmFJ.ShowDialog();
        }

        private void frmFJ_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (JobId <= 0)
                this.Close();
        }

        private void SetJobData(Job objJob)
        {
            lblReferenceNumber.Text = objJob.ReferenceNumber;
            lblComponentCode.Text = objJob.ComponentCode;
            lblComponentName.Text = objJob.ComponentName;
            lblMaterial.Text = objJob.MaterialName;
            lblJobCode.Text = objJob.JobCode;
            lblJobName.Text = objJob.JobName;
            lblJobStartDate.Text = objJob.JobStartDate.ToString("dd-MMM-yyyy");
            lblJobEndDate.Text = objJob.JobEndDate.ToString("dd-MMM-yyyy");

        }

        public Job GetJobDetails(Int64 JobId)
        {
            Job objJob = new Job();

            string strCmd = "SELECT JobId, JobCode, JobName, JobStartDate, JobEndDate, ReferenceNumber, ComponentCode, ComponentName, MaterialCode, MaterialName FROM [ICS].[dbo].[GetJobDetails] (" + JobId + ")";

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                if (sqlDR.HasRows)
                {
                    sqlDR.Read();
                    objJob.JobId = sqlDR.GetInt64(0);
                    objJob.JobCode = sqlDR.GetString(1);
                    objJob.JobName = sqlDR.GetString(2);
                    objJob.JobStartDate = sqlDR.GetDateTime(3);
                    objJob.JobEndDate = sqlDR.GetDateTime(4);
                    objJob.ReferenceNumber = sqlDR.GetString(5);
                    objJob.ComponentCode = sqlDR.GetString(6);
                    objJob.ComponentName = sqlDR.GetString(7);
                    objJob.MaterialCode = sqlDR.GetString(8);
                    objJob.MaterialName = sqlDR.GetString(9);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: GetJobDetails " + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }

            return objJob;
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }

            if (e.KeyCode.ToString() == "F2")
            {
                SaveData();
            }

            if (e.KeyCode.ToString() == "F3")
            {
                Search_Transaction frmSearch = new Search_Transaction();

                frmSearch.ShowDialog();
            }
            
            if (e.KeyCode.ToString() == "F4")
            {
                OpenVendorDataSummary();
            }
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnDataSummary_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dtTranDate_KeyDown(object sender, KeyEventArgs e)
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

        private void chkBilledQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtBilledQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbRejectionReason_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        

        private void cmbOperation_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        

        private void txtRejectedQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDataSummary_Click(object sender, EventArgs e)
        {
            OpenVendorDataSummary();
        }

        private void OpenVendorDataSummary()
        {
            Item itmVendor = (Item)cmbVendor.SelectedItem;

            if (itmVendor != null)
            {
                frmVendorDataSummary frmVDS = new frmVendorDataSummary();

                frmVDS.GetDataSummary(itmVendor.Value);

                frmVDS.Text = itmVendor.Name + " Data Summmary";

                frmVDS.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a vendor!", "Vendor Data Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVoucher_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
            dtTranDate.Focus();
        }

        private void frmVoucher_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = .60;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            string strType = "O"; //for outward vouchers

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

                Item itmOperation = (Item)cmbOperation.SelectedItem;

                string strCommand = "Insert into [Transaction] (TranDate, ChalaanNumberInternal, VendorCode, ComponentCode, Quantity, [Type], ReferenceNumber, OperationCode, JobCode)" +
                    "Values('" + dtTranDate.Text + "','" + txtVoucherNumber.Text + "','" + itmVendor.Value + "','" + lblComponentCode.Text + "'," + txtQuantity.Text + ",'" + strType + "','" + lblReferenceNumber.Text + "','" + itmOperation.Value + "','" + lblJobCode.Text + "')";

                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = strCommand;

                sqlCmd.ExecuteNonQuery();

                Item itm = (Item)cmbVendor.SelectedItem;
                
                ClearFields();

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

        private void ClearFields()
        {
            cmbVendor.Text = "";
            txtVoucherNumber.Text = "";
            txtQuantity.Text = "";
        }

        private bool ValidateData()
        {

            Item itmVendor;
            Item itmOperation;

            

            try
            {

                if (cmbVendor.SelectedItem != null)
                    itmVendor = (Item)cmbVendor.SelectedItem;
                else
                    itmVendor = (Item)cmbVendor.Items[0];

                if (cmbOperation.SelectedItem != null)
                    itmOperation = (Item)cmbOperation.SelectedItem;
                else
                    itmOperation = (Item)cmbOperation.Items[0];

                if (itmVendor.Value == string.Empty)
                {
                    MessageBox.Show("Please select a vendor!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbVendor.Focus();
                    return false;
                }

                if (itmOperation.Value == string.Empty)
                {
                    MessageBox.Show("Please select an operation!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbOperation.Focus();
                    return false;
                }

                if (txtVoucherNumber.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please provide Voucher number!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVoucherNumber.Focus();
                    return false;
                }

                if (IsChalaanNumberDuplicate())
                {
                    MessageBox.Show("Duplicate Voucher number. Please enter an unused Voucher number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVoucherNumber.Focus();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: ValidateData" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private bool IsChalaanNumberDuplicate()
        {
            if (SearchByInternalChalaan())
                return true;

            return false;
        }


        private bool SearchByInternalChalaan()
        {

            string strCmd = "select * from dbo.[Transaction] where ChalaanNumberInternal = '" + txtVoucherNumber.Text + "' and year(trandate) = " + dtTranDate.Value.Year;

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

        private void txtVoucherNumber_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Transaction frmSearchTransaction = new Search_Transaction();

            frmSearchTransaction.ShowDialog();
        }

    }
}
