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
    public partial class frmManageJob : Form
    {

        SqlConnection sqlCon = new SqlConnection();
        
        Job objJob = new Job();

        public frmManageJob()
        {
            InitializeComponent();
        }

        private void frmManageJob_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            try
            {
                if (IsNewJob)
                {
                    objJob = GetJobDetails(GetJobId());
                    GetComponentOperationQuantity(objJob.JobId);
                }
                else
                {
                    objJob = GetJobDetails(JobId);
                    GetComponentOperationQuantity(objJob.JobId);
                }
                this.Text = this.Text + " - " + objJob.JobName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: frmManageJob_Load: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private bool mIsNewJob;

        public bool IsNewJob
        {
            get { return mIsNewJob; }
            set { mIsNewJob = value; }
        }

        private Int64 mJobId;

        public Int64 JobId
        {
            get { return mJobId; }
            set { mJobId = value; }
        }

        public Job GetJobDetails(Int64 JobId)
        {
            Job objJob = new Job();

            string strCmd = "SELECT JobId, JobCode, JobName, JobStartDate, JobEndDate FROM dbo.[JobMaster] WHERE JobId = " + JobId;

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

        public void GetComponentOperationQuantity(Int64 JobId)
        {

            DataTable dt = new DataTable("ComponentOperationQuantity");

            string strCmd = "SELECT OperationName as [Operation Name], [Incoming Qty] AS [Quantity], [Inhouse Qty] AS [Inhouse Qty] FROM [ICS].[dbo].[GetOperationQuantity] (" + JobId + ") ORDER BY SequenceNumber";

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                if (sqlDR.HasRows)
                {
                    dt.Clear();
                    dt.Load(sqlDR);
                    dgvComponentOperationQuantity.DataSource = dt;
                    dgvComponentOperationQuantity.Refresh();

                    dgvComponentOperationQuantity.Columns[0].Width = 200;
                    dgvComponentOperationQuantity.Columns[1].Width = 110;
                    dgvComponentOperationQuantity.Columns[2].Width = 110;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: GetComponentOperationQuantity " + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        public Int64 GetJobId()
        {
            string strCmd = "SELECT Max(JobId) as JobId FROM dbo.[JobMaster]";

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                if (sqlDR.HasRows)
                {
                    sqlDR.Read();
                    return sqlDR.GetInt64(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: GetJobId " + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
            return 0;
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnRawMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnCompleteJob_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmManageJob_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnRawMaterial_Click(object sender, EventArgs e)
        {

            frmRawMaterial frmRM = new frmRawMaterial();

            frmRM.JobId = objJob.JobId;

            frmRM.JobCode = objJob.JobCode;

            frmRM.ShowDialog();
        }

        private void btnVoucherOutward_Click(object sender, EventArgs e)
        {
            frmVoucher frmVchOutward = new frmVoucher();

            frmVchOutward.JobId = objJob.JobId;
            frmVchOutward.JobCode = objJob.JobCode;

            frmVchOutward.ShowDialog(this);
        }

        private void btnVoucherInward_Click(object sender, EventArgs e)
        {
            frmVoucherInward frmVchIn = new frmVoucherInward();

            frmVchIn.JobId = objJob.JobId;
            frmVchIn.JobCode = objJob.JobCode;

            frmVchIn.ShowDialog(this);
        }

        private void btnVoucherOutward_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnVoucherInward_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnCompleteJob_Click(object sender, EventArgs e)
        {

        }

        private void dgvComponentOperationQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        
        
    }
}
