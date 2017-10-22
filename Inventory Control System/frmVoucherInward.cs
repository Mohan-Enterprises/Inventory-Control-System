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
    public partial class frmVoucherInward : Form
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

        public frmVoucherInward()
        {
            InitializeComponent();
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {

            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            lblTotalQty.Text = "0";

            //if (JobId > 0)
            //    SetJobData(GetJobDetails(JobId));
            //else
            //{
            //    OpenFindJobDialog();
            //    dtTranDate.Focus();
            //}

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
            /*
            lblReferenceNumber.Text = objJob.ReferenceNumber;
            lblComponentCode.Text = objJob.ComponentCode;
            lblComponentName.Text = objJob.ComponentName;
            lblMaterial.Text = objJob.MaterialName;
            lblJobCode.Text = objJob.JobCode;
            lblJobName.Text = objJob.JobName;
            lblJobStartDate.Text = objJob.JobStartDate.ToString("dd-MMM-yyyy");
            lblJobEndDate.Text = objJob.JobEndDate.ToString("dd-MMM-yyyy");
             */
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

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dtTranDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void OpenVendorDataSummary()
        {
            //Item itmVendor = (Item)cmbVendor.SelectedItem;

            //if (itmVendor != null)
            //{
            //    frmVendorDataSummary frmVDS = new frmVendorDataSummary();

            //    frmVDS.GetDataSummary(itmVendor.Value);

            //    frmVDS.Text = itmVendor.Name + " Data Summmary";

            //    frmVDS.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Please select a vendor!", "Vendor Data Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public void GetVendorDetails(string vendorCode, string vendorName)
        {
            txtVendor.Text = vendorCode;
            txtVendorName.Text = vendorName;
        }

        public void GetComponentDetails(string componentCode, string componentName)
        {
            txtComponentCode.Text = componentCode;
            lblComponentName.Text = componentName;
        }

        private void frmVoucher_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;

            dtTranDate.Focus();

            if (txtVendorName.Text.Trim() != string.Empty)
            {
                txtComponentCode.Enabled = true;
            }
            else
            {
                txtComponentCode.Enabled = false;
                txtVoucherNumber.Enabled = false;
                txtQuantity.Enabled = false;
            }

            if (txtComponentCode.Text.Trim() != string.Empty)
            {
                txtVoucherNumber.Enabled = true;
                txtQuantity.Enabled = true;
            }
            else
            {
                txtVoucherNumber.Enabled = false;
                txtQuantity.Enabled = false;
            }
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

            string strType = "I"; //for inward vouchers

            SqlCommand sqlCmd = new SqlCommand();

            string strCommand = string.Empty;

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

                sqlCmd.Connection = sqlCon;


                foreach (DataGridViewRow dgr in dgvCompActualPendingQty.Rows)
                {
                    string strVoucherNumber = (string)dgr.Cells[0].Value;
                    string strReferenceNumber = (string)dgr.Cells[2].Value;
                    string strJobCode = (string)dgr.Cells[3].Value;
                    string strOperationCode = (string)dgr.Cells[4].Value;
                    decimal dQuantity = Convert.ToDecimal(dgr.Cells[5].Value);

                    if (txtRejectedQuantity.Text == string.Empty)
                        txtRejectedQuantity.Text = "0";
                    decimal dRejectedQty = Convert.ToDecimal(txtRejectedQuantity.Text);

                    if (txtBilledQuantity.Text == string.Empty)
                        txtBilledQuantity.Text = "0";
                    decimal dBilledQty = Convert.ToDecimal(txtBilledQuantity.Text);

                    strCommand = "Insert into [Transaction] (TranDate, ChalaanNumberInternal, ChalaanNumberExternal, VendorCode, ComponentCode, Quantity, [Type], RejectedQuantity, BilledQuantity, ReferenceNumber, OperationCode, JobCode)" +
                    "Values('" + dtTranDate.Text + "','" + strVoucherNumber + "','" + txtVoucherNumber.Text + "','" + txtVendor.Text + "','" + txtComponentCode.Text + "'," + dQuantity + ",'" + strType + "'," + dRejectedQty + "," + dBilledQty + ",'" + strReferenceNumber + "','" + strOperationCode + "','" + strJobCode + "')";

                    sqlCmd.CommandText = strCommand;

                    sqlCmd.ExecuteNonQuery();
                }

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
            txtVoucherNumber.Text = "";
        }

        private bool ValidateData()
        {

            try
            {

                if (txtVoucherNumber.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please provide Voucher number!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVoucherNumber.Focus();
                    return false;
                }

                if (txtQuantity.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Quantity left blank. Please enter the quantity.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                    return false;
                }

                decimal dTotalQty = 0;
                decimal dVoucherTotalQty = 0;
                decimal dRejectedQty = 0;

                if (txtQuantity.Text == string.Empty)
                    txtQuantity.Text = "0";

                dVoucherTotalQty = Convert.ToDecimal(txtQuantity.Text);

                if (txtRejectedQuantity.Text == string.Empty)
                    txtRejectedQuantity.Text = "0";

                dRejectedQty = Convert.ToDecimal(txtRejectedQuantity.Text);

                dTotalQty = Convert.ToDecimal(lblTotalQty.Text);

                dVoucherTotalQty = dVoucherTotalQty + dRejectedQty;

                if (dVoucherTotalQty != dTotalQty)
                {
                    MessageBox.Show("Voucher & Rejected Quantity should match the quantity entered against vouchers!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //if(lblTotalQty.Text

                //if (IsChalaanNumberDuplicate())
                //{
                //    MessageBox.Show("Duplicate Voucher number. Please enter an unused Voucher number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtVoucherNumber.Focus();
                //    return false;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: ValidateData" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {

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

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyCode.ToString() == "Return")
            {
                if (txtVendorName.Focused)
                {
                    frmVendorList frmVL = new frmVendorList();
                    frmVL.SourceForm = "VoucherInward";
                    frmVL.ShowDialog(this);
                }
                else if (txtComponentCode.Focused)
                {
                    frmComponentList frmCL = new frmComponentList();
                    frmCL.SourceForm = "VoucherInward";
                    frmCL.ShowDialog(this);
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }

                if (txtQuantity.Focused)
                {
                    frmVouchersOutstandingList frmVOL = new frmVouchersOutstandingList();

                    frmVOL.VendorCode = txtVendor.Text;
                    frmVOL.ComponentCode = txtComponentCode.Text;

                    frmVOL.ShowDialog(this);
                }
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

        public void RefreshLineItemsGrid(DataTable dt)
        {
            dgvCompActualPendingQty.DataSource = dt;
            dgvCompActualPendingQty.Refresh();

            if (dgvCompActualPendingQty.Columns.Count > 0)
            {
                dgvCompActualPendingQty.Columns[0].Width = 70;
                dgvCompActualPendingQty.Columns[1].Width = 90;
                dgvCompActualPendingQty.Columns[2].Width = 100;
                dgvCompActualPendingQty.Columns[3].Width = 110;
                dgvCompActualPendingQty.Columns[4].Width = 114;
                dgvCompActualPendingQty.Columns[5].Width = 120;
            }

            decimal dTotalQty = 0;

            foreach (DataRow dr in dt.Rows)
            {
                dTotalQty = Convert.ToDecimal(dr[5]) + dTotalQty;
                //MessageBox.Show(dr[2].ToString());
            }

            lblTotalQty.Text = dTotalQty.ToString();
        }

        private void txtVendor_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            RefreshLineItemsGrid(dt);

            dt = null;

            VendorCode = txtVendor.Text;
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvCompActualPendingQty_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmVoucherInward_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtComponentCode_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            RefreshLineItemsGrid(dt);

            dt = null;
        }

        private void txtComponentCode_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtVendorName_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void chkBilledQuantity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbRejectionReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRejectedQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbRejectionReason_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtBilledQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void chkBilledQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Transaction frmSearchTransaction = new Search_Transaction();

            frmSearchTransaction.ShowDialog();
        }

        private void btnDataSummary_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnUnassigned_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        
    }
}
