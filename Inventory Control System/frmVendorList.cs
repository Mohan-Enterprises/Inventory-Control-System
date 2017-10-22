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
    public partial class frmVendorList : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        Job objJob = new Job();

        DataTable dtVendors = new DataTable("Vendors");

        public string SourceForm = string.Empty;

        public frmVendorList()
        {
            InitializeComponent();
        }

        private void frmVoucherList_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            PopulateVendorList();
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }

            if (e.KeyCode.ToString() == "Return")
            {
                GetVendor();
                SendKeys.Send("{TAB}");
            }

            if (e.KeyData == Keys.Down)
            {
                dgvVendorList.Focus();
            }
        }

        private void GetVendor()
        {
            if (SourceForm == "VoucherInward")
            {
                //frmVoucherInward frm1 = new frmVoucherInward();
                frmVoucherInward frm1 = (frmVoucherInward)this.Owner;
                string strVendorCode = (string)dgvVendorList.SelectedRows[0].Cells[0].Value;
                string strVendorName = (string)dgvVendorList.SelectedRows[0].Cells[1].Value;
                frm1.GetVendorDetails(strVendorCode, strVendorName);



                this.Close();
            }
        }

        private void PopulateVendorList()
        {
            string strCmd = string.Empty;

            strCmd = "SELECT VendorCode AS [Vendor Code], Name AS [Vendor Name] from dbo.VendorMaster";

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
                    dtVendors.Clear();
                    dtVendors.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtVendors);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PopulateVendorList" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        private void SearchVendors()
        {

            string strCmd = string.Empty;

            string strSearchCriteria = " WHERE VendorCode LIKE '%" + txtVendorNameSearchBox.Text + "%' OR [Name] LIKE '%" + txtVendorNameSearchBox.Text + "%'";

            strCmd = "SELECT VendorCode AS [Vendor Code], Name AS [Vendor Name] from dbo.VendorMaster " + strSearchCriteria;

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
                    dtVendors.Clear();
                    dtVendors.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtVendors);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: SearchVendors" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        //public string PrepareSearchCriteria()
        //{
        //    string strSearchSQL = string.Empty;
        //    string strSearchCriteria = string.Empty;

        //    string strMonth = string.Empty;
        //    string strYear = string.Empty;

        //    //get chalaan number
        //    if (ChalaanNumberInternal != string.Empty)
        //    {
        //        ChalaanNumberInternal = ChalaanNumberInternal.Replace("'", "''");

        //        if (strSearchCriteria != string.Empty)
        //            strSearchCriteria = strSearchCriteria + " and ChalaanNumberInternal = '" + ChalaanNumberInternal + "'";
        //        else
        //            strSearchCriteria = " ChalaanNumberInternal = '" + ChalaanNumberInternal + "'";
        //    }

        //    //Incoming/Outgoing
        //    if (TransactionType != "--None--")
        //    {
        //        if (TransactionType != "Both")
        //        {
        //            if (strSearchCriteria != string.Empty)
        //                strSearchCriteria = strSearchCriteria + " and [Type] = '" + TransactionType + "'";
        //            else
        //                strSearchCriteria = " [Type] = '" + TransactionType + "'";
        //        }
        //    }

        //    return strSearchCriteria;
        //}

        private void RefreshDataGrid(bool bIsDataAvailable, DataTable dt)
        {
            dgvVendorList.DataSource = "";
            dgvVendorList.Refresh();

            if (bIsDataAvailable)
            {
                dgvVendorList.DataSource = dtVendors;
                dgvVendorList.Refresh();

                //set data grid view column width
                dgvVendorList.Columns[0].Width = 100;
                dgvVendorList.Columns[1].Width = 250;
            }
        }

        private void txtVendorNameSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvVendorList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmVendorList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtVendorNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchVendors();
        }

        private void dgvVendorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVendorList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
