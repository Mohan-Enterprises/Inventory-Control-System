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
    public partial class frmFindJob : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        DataTable dtGridTransactions = new DataTable("GridJobs");

        public string SourceForm = string.Empty;

        public frmFindJob()
        {
            InitializeComponent();
        }

        private void frmFindJob_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }

            if (e.KeyCode.ToString() == "Return")
            {
                GetJob();
            }
        }

        private void GetJob()
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                if (SourceForm == "Job")
                {
                    frmJob frm1 = new frmJob();
                    frm1.JobId = (Int64)dgvJobs.SelectedRows[0].Cells[0].Value;
                    frm1.IsNewJob = false;
                    frm1.ShowDialog();
                }
                if (SourceForm == "Voucher")
                {
                    frmVoucher frm1 = new frmVoucher();
                    frm1.JobId = (Int64)dgvJobs.SelectedRows[0].Cells[0].Value;
                    frm1.ShowDialog();
                    this.Close();
                }
                if (SourceForm == "VoucherInhouse")
                {
                    frmVoucherInhouse frm1 = new frmVoucherInhouse();
                    frm1.JobId = (Int64)dgvJobs.SelectedRows[0].Cells[0].Value;
                    frm1.ShowDialog();
                    this.Close();
                }
            }
            else
                MessageBox.Show("No job selected!", "Job", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmFindJob_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearchCriteria = PrepareSearchCriteria();

            SearchJobs(strSearchCriteria);

            dgvJobs.Focus();
        }

        private void SearchJobs(string strSearchCriteria)
        {

            string strCmd = string.Empty;

            //if (strSearchCriteria != string.Empty)
            //{
            //    //strCmd = "select * from dbo.[transaction] where " + strSearchCriteria;
            //    strCmd = "SELECT [TransactionId], convert(varchar, [TranDate], 103) as [TranDate], [ChalaanNumberInternal], [ChalaanNumberExternal], [Component name], [Vendor Name], [Quantity], [RejectedQuantity], [Type] FROM [ICS].[dbo].[vw_Transactions] where " + strSearchCriteria;
            //}
            //else
            //{
            //    strCmd = "SELECT [TransactionId],convert(varchar, [TranDate], 103) as [TranDate], [ChalaanNumberInternal], [ChalaanNumberExternal], [Component name], [Vendor Name], [Quantity], [RejectedQuantity], [Type] FROM [ICS].[dbo].[vw_Transactions] ";
            //}

            strCmd = "SELECT      a.JobId AS [Job Id] " +
                               ", a.JobCode AS [Job Code] " +
                               ", a.JobName AS [Job Name] " +
                               //", CONVERT(VARCHAR, a.JobStartDate, 103) AS [Job Start Date] " +
                               //", b.ComponentCode AS [Component Code] " +
                               //", b.Name AS [Component Name] " +
                               //", c.MaterialCode AS [Material Code] " +
                               //", d.MaterialName AS [Material Name] " +
                               //", v.VendorCode AS [Vendor Code] " +
                               //", v.Name AS [Vendor Name] " +
                       " FROM dbo.JobMaster a LEFT OUTER JOIN dbo.ComponentMaster b" +
                       " ON a.ComponentCode = b.ComponentCode" +
                       " LEFT OUTER JOIN dbo.MaterialTransactions c" +
                       " ON a.JobCode = c.JobCode" +
                       " LEFT OUTER JOIN dbo.MaterialMaster d" +
                       " ON c.MaterialCode = d.MaterialCode" +
                       " LEFT OUTER JOIN (SELECT DISTINCT VendorCode, JobCode FROM dbo.[Transaction]) e" +
                       " on e.JobCode = a.JobCode" +
                       " LEFT OUTER JOIN dbo.VendorMaster v" +
                       " ON e.VendorCode = v.VendorCode " +
                       strSearchCriteria;
            
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
                    dtGridTransactions.Clear();
                    dtGridTransactions.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtGridTransactions);

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

        private string PrepareSearchCriteria()
        {
            string strSearchSQL = string.Empty;
            string strSearchCriteria = string.Empty;
            string strSearchText = txtSearchCriteria.Text;

            strSearchText = strSearchText.Replace("'", "''");

            try
            {
                strSearchCriteria = " WHERE a.JobCode LIKE '%" + strSearchText + "%' OR a.JobCode LIKE '%" + strSearchText + "%' " +
                        " OR a.JobName LIKE '%" + strSearchText + "%'" +
                        " OR d.MaterialName LIKE '%" + strSearchText + "%' OR v.Name LIKE '%" + strSearchText + "%' " +
                        " OR b.Name LIKE '%" + strSearchText + "%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PrepareSearchCriteria " + Environment.NewLine + ex.Message);
            }
            finally
            {

            }

            return strSearchCriteria;
        }

        private void RefreshDataGrid(bool bIsDataAvailable, DataTable dt)
        {

            dgvJobs.DataSource = "";
            dgvJobs.Refresh();

            //foreach (DataColumn dtCol in dt.Columns)
            //{
            //    if (dtCol.ColumnName != "Job Id" && dtCol.ColumnName != "Job Code" && dtCol.ColumnName != "Job Name")
            //    {
            //        dtGridTransactions.Columns.Remove(dtCol);
            //    }
            //}

            if (bIsDataAvailable)
            {
                dgvJobs.DataSource = dtGridTransactions;
                dgvJobs.Refresh();

                dgvJobs.Columns[0].Width = 100;
                dgvJobs.Columns[1].Width = 100;
                dgvJobs.Columns[2].Width = 126;
            }

        }

        private void dgvJobs_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbSearchBy_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtSearchCriteria_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvJobs_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Int64 JobId = Convert.ToInt32(dgvJobs.Rows[e.RowIndex].Cells[0].Value);

            GetJobDetails(JobId);
        }

        public void GetJobDetails(Int64 JobId)
        {

            //DataRow dr = dtGridTransactions.Rows.Find(JobId);

            //if (dr != null)
            //{
            //    MessageBox.Show(dr[0].ToString());
            //}

        }

        private void txtSearchCriteria_TextChanged(object sender, EventArgs e)
        {
            string strSearchCriteria = PrepareSearchCriteria();

            SearchJobs(strSearchCriteria);

            //dgvJobs.Focus();
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
