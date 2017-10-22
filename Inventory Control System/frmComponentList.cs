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
    public partial class frmComponentList : Form
    {
        
        SqlConnection sqlCon = new SqlConnection();

        DataTable dtComponents = new DataTable("Components");

        public string SourceForm = string.Empty;

        public frmComponentList()
        {
            InitializeComponent();
        }

        private void frmComponentList_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            PopulateComponentList();
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }

            if (e.KeyCode.ToString() == "Return")
            {
                GetComponent();

                SendKeys.Send("{TAB}");
            }

            if (e.KeyData == Keys.Down)
            {
                dgvComponentList.Focus();
            }
        }

        private void GetComponent()
        {
            if (SourceForm == "VoucherInward")
            {
                //frmVoucherInward frm1 = new frmVoucherInward();
                frmVoucherInward frm1 = (frmVoucherInward)this.Owner;
                string strComponentCode = (string)dgvComponentList.SelectedRows[0].Cells[0].Value;
                string strComponentName = (string)dgvComponentList.SelectedRows[0].Cells[1].Value;
                frm1.GetComponentDetails(strComponentCode, strComponentName);

                this.Close();
            }
        }


        private void PopulateComponentList()
        {
            string strCmd = string.Empty;

            strCmd = "SELECT ComponentCode AS [Component Code], Name AS [Component Name] from dbo.ComponentMaster";

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
                    dtComponents.Clear();
                    dtComponents.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtComponents);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PopulateComponentList" + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        private void SearchComponents()
        {

            string strCmd = string.Empty;

            string strSearchCriteria = " WHERE ComponentCode LIKE '%" + txtComponentNameSearchBox.Text + "%' OR [Name] LIKE '%" + txtComponentNameSearchBox.Text + "%'";

            strCmd = "SELECT ComponentCode AS [Component Code], Name AS [Component Name] from dbo.ComponentMaster " + strSearchCriteria;

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
                    dtComponents.Clear();
                    dtComponents.Load(sqlDR);
                    IsDataAvailable = true;
                }

                RefreshDataGrid(IsDataAvailable, dtComponents);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: SearchComponents" + Environment.NewLine + ex.Message);
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
            dgvComponentList.DataSource = "";
            dgvComponentList.Refresh();

            if (bIsDataAvailable)
            {
                dgvComponentList.DataSource = dtComponents;
                dgvComponentList.Refresh();

                //set data grid view column width
                dgvComponentList.Columns[0].Width = 140;
                dgvComponentList.Columns[1].Width = 191;
            }
        }

        private void txtComponentNameSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dgvComponentList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void rectangleShape1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmComponentList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtComponentNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchComponents();
        }
    }
}
