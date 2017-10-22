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
    public partial class frmRawMaterial : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        Job objJob = new Job();

        RawMaterialTransaction objRM = new RawMaterialTransaction();

        DataTable dtRM = new DataTable("RawMaterial");

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

        private bool InEditMode = false;

        public frmRawMaterial()
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

        private void frmRawMaterial_Load(object sender, EventArgs e)
        {

            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            PopulateMaterialDropdown();

            objJob = GetJobDetails(JobId);

            this.Text = "Raw Material - " + objJob.JobName;

            objRM = GetRawMaterial();

            if (objRM != null)
            {
                if (objRM.TransactionId > 0)
                {
                    InEditMode = true;

                    dtTranDate.Text = objRM.TranDate.ToShortDateString();

                    txtReferenceNumber.Text = objRM.ReferenceNumber;

                    SelectComboItem(cmbMaterial, objRM.MaterialCode);

                    txtQtyReceived.Text = objRM.QuantityReceived.ToString();

                    lblUOM.Text = objRM.UOM;

                    txtProdUnits.Text = objRM.ProdUnits.ToString();
                }
            }

        }

        private RawMaterialTransaction GetRawMaterial()
        {
            RawMaterialTransaction objRM = new RawMaterialTransaction();

            string strCmd = "SELECT TransactionId, b.MaterialCode, ReferenceNumber, TranDate, QuantityReceived, JobCode, UOM, ProdUnits FROM dbo.[MaterialTransactions] a INNER JOIN dbo.MaterialMaster b ON a.MaterialCode = b.MaterialCode WHERE JobCode = '" + JobCode + "'";

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                if (sqlDR.HasRows)
                {

                    sqlDR.Read();

                    objRM.TransactionId = sqlDR.GetInt64(0);
                    objRM.MaterialCode = sqlDR.GetString(1);
                    objRM.ReferenceNumber = sqlDR.GetString(2);
                    objRM.TranDate = sqlDR.GetDateTime(3);
                    objRM.QuantityReceived = sqlDR.GetDecimal(4);
                    if (!sqlDR.IsDBNull(5))
                        objRM.JobCode = sqlDR.GetString(5);
                    if (!sqlDR.IsDBNull(6))
                        objRM.UOM = sqlDR.GetString(6);
                    if (!sqlDR.IsDBNull(7))
                        objRM.ProdUnits = sqlDR.GetDecimal(7);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: GetRawMaterial " + Environment.NewLine + ex.Message);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
            return objRM;
        }

        private void PopulateMaterialDropdown()
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select a.MaterialCode, a.MaterialName, a.UOM from dbo.MaterialMaster a";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {

                dtRM.Clear();
                dtRM.Load(sqlDR);

                cmbMaterial.Items.Add(new Item("--None--", ""));

                foreach (DataRow dr in dtRM.Rows)
                {
                    cmbMaterial.Items.Add(new Item(dr[1].ToString(), dr[0].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: PopulateMaterialDropdown" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox lst = (ComboBox)sender;

            Item itm = (Item)lst.SelectedItem;

            lblMaterialCode.Text = itm.Value;

            lblUOM.Text = GetUOM(itm.Value);
        }

        private string GetUOM(string MaterialCode)
        {

            DataRow[] dr;

            dr = dtRM.Select("MaterialCode = '" + MaterialCode + "'");

            return dr[0][2].ToString();

            //return dr[2].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCmd = new SqlCommand();

            if (!IsValidated())
                return;

            //string strMessage = "Are you sure you would like to save it?";

            //DialogResult dResult = MessageBox.Show(strMessage, "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (dResult == DialogResult.No)
            //    return;

            Item itmMaterial = (Item)cmbMaterial.SelectedItem;

            string strCommand = string.Empty;

            if (string.IsNullOrEmpty(txtQtyReceived.Text))
                txtQtyReceived.Text = "0";

            if (!InEditMode)
            {
                strCommand = "Insert into [MaterialTransactions] (TranDate, MaterialCode, ReferenceNumber, QuantityReceived, ProdUnits, JobCode)" +
                    "Values('" + dtTranDate.Text + "','" + itmMaterial.Value + "','" + txtReferenceNumber.Text + "'," + txtQtyReceived.Text + "," + txtProdUnits.Text +  ",'" + objJob.JobCode + "')";
            }
            else
            {
                strCommand = "UPDATE [MaterialTransactions] " +
                        " SET TranDate = '" + dtTranDate.Text + "'" +
                        " , MaterialCode = '" + itmMaterial.Value + "'" +
                        " , ReferenceNumber = '" + txtReferenceNumber.Text + "'" +
                        " , QuantityReceived = '" + txtQtyReceived.Text + "'" +
                        " , ProdUnits = '" + txtProdUnits.Text + "'" +
                        " WHERE JobCode = '" + JobCode + "'";
            }

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandText = strCommand;

            sqlCmd.ExecuteNonQuery();

            this.Close();

        }

        private bool IsValidated()
        {
            Item itmMaterial;

            if (cmbMaterial.SelectedItem != null)
                itmMaterial = (Item)cmbMaterial.SelectedItem;
            else
                itmMaterial = (Item)cmbMaterial.Items[0];

            try
            {
                if (itmMaterial.Value == string.Empty)
                {
                    MessageBox.Show("Please select a Material!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbMaterial.Focus();
                    return false;
                }

                if (txtReferenceNumber.Text == string.Empty)
                {
                    MessageBox.Show("Reference number cannot be left blank!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReferenceNumber.Focus();
                    return false;
                }

                if (txtQtyReceived.Text == string.Empty)
                {
                    MessageBox.Show("Quantity received cannot be left blank!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQtyReceived.Focus();
                    return false;
                }

                if (!IsReferenceNumberValid() && txtReferenceNumber.Text != objRM.ReferenceNumber)
                {
                    MessageBox.Show("Invalid reference number! This reference number has been used in this year. Please enter a different Reference number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReferenceNumber.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: IsValidated" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsReferenceNumberValid()
        {

            string strCmd = "SELECT ReferenceNumber FROM dbo.[MaterialTransactions] WHERE ReferenceNumber = '" + txtReferenceNumber.Text + "' AND YEAR(TranDate) = " + dtTranDate.Value.Year;

            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCon);

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                return !sqlDR.HasRows;
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
            return true;
        }

        private void ClearFields()
        {
            cmbMaterial.Text = "";
            txtReferenceNumber.Text = "";
            txtQtyReceived.Text = "";
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

        private void frmRawMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dtTranDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtReferenceNumber_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void cmbMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void txtQtyReceived_KeyDown(object sender, KeyEventArgs e)
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

        private void txtProdUnits_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }
    }
}
