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
    public partial class frmJob : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        public bool IsNewJob = true;

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


        public frmJob()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            SaveJob();

            OpenJobMgr(IsNewJob);
        }

        private void OpenJobMgr(bool IsNewJob)
        {
            frmManageJob frmMngJob = new frmManageJob();

            frmMngJob.IsNewJob = IsNewJob;
            
            frmMngJob.JobId = JobId;

            frmMngJob.ShowDialog();
        }

        private Int32 GetJobId()
        {


            return 0;
        }

        private void SaveJob()
        {
            SqlCommand sqlCmd = new SqlCommand();

            try
            {

                Item itmComponent = (Item)cmbComponent.SelectedItem;

                string strCommand = string.Empty;

                if (IsNewJob)
                {
                    strCommand = "INSERT INTO dbo.[JobMaster] (JobCode, JobName, JobStartDate, JobEndDate, ComponentCode)" +
                            "VALUES('" + txtJobCode.Text + "','" + txtJobName.Text + "','" + dtJobStartDate.Text + "','" + dtJobEndDate.Text + "','" + itmComponent.Value + "')";
                }
                else
                {

                    strCommand = "UPDATE dbo.[JobMaster] SET JobCode = '" + txtJobCode.Text + "' , JobName = '" + txtJobName.Text + "', JobStartDate = '" + dtJobStartDate.Text + "', JobEndDate = '" + dtJobEndDate.Text + "', ComponentCode = '" + itmComponent.Value + "' WHERE JobId = " + JobId;
                }

                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = strCommand;

                sqlCmd.ExecuteNonQuery();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: SaveJob: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCmd = null;
            }
        }

        private void ClearFields()
        {
            txtJobCode.Text = string.Empty;
            txtJobName.Text = string.Empty;

            txtJobCode.Focus();
        }

        private bool IsValid()
        {
            if (txtJobCode.Text != JobCode)
            {
                if (!IsJobCodeValid())
                {
                    MessageBox.Show("Invalid Job code!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtJobCode.Focus();
                    return false;
                }
            }

            if (txtJobCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Job code cannot be left blank!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJobCode.Focus();
                return false;
            }

            if (txtJobName.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Job name cannot be left blank!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJobName.Focus();
                return false;
            }

            Item itmComponent = (Item)cmbComponent.SelectedItem;

            if (cmbComponent.Text == string.Empty)
            {
                MessageBox.Show("Please select a component!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbComponent.Focus();
                return false;
            }

            DateTime mdtJobStartDate = DateTime.MinValue;
            DateTime mdtJobEndDate = DateTime.MinValue;

            if (mdtJobEndDate.Date > mdtJobStartDate.Date)
            {
                MessageBox.Show("Job end date cannot be greater than Job end date!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtJobStartDate.Focus();
                return false;
            }

            return true;
        }

        private bool IsJobCodeValid()
        {

            string strCmd = "SELECT JobCode FROM dbo.[JobMaster] WHERE JobCode = '" + txtJobCode.Text + "'";

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                return !sqlDR.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: IsJobCodeValid" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
            return true;
        }

        private void frmJob_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            PopulateComponentDropdown();

            if (!IsNewJob)
                SetData(GetJobDetails(JobId));

            SetControls();

        }

        private void SetControls()
        {
            if (IsNewJob)
                btnJobManager.Visible = false;
        }

        private void SetData(Job objJob)
        {
            JobCode = objJob.JobCode;
            txtJobCode.Text = objJob.JobCode;
            txtJobName.Text = objJob.JobName;
            SelectComboItem(cmbComponent, objJob.ComponentCode);
            dtJobStartDate.Text = objJob.JobStartDate.ToShortDateString();
            dtJobEndDate.Text = objJob.JobEndDate.ToShortDateString();
            lblComponentCode.Text = objJob.ComponentCode;
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

        public Job GetJobDetails(Int64 JobId)
        {
            Job objJob = new Job();

            string strCmd = "SELECT JobId, JobCode, JobName, JobStartDate, JobEndDate, ComponentCode FROM dbo.[JobMaster] WHERE JobId = " + JobId;

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
                    objJob.ComponentCode = sqlDR.GetString(5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: IsJobCodeValid " + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }

            return objJob;
        }

        private void frmJob_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
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

        private void txtJobCode_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtJobName_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dtJobStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dtJobEndDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
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

        private void PopulateComponentDropdown()
        {

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select ComponentCode, Name from dbo.ComponentMaster";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {

                cmbComponent.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    cmbComponent.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
                }

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

        private void btnJobManager_Click(object sender, EventArgs e)
        {
            OpenJobMgr(false);
        }

        private void cmbComponent_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itmComponent = (Item)cmbComponent.SelectedItem;

            lblComponentCode.Text = itmComponent.Value;
        }
    }
}
