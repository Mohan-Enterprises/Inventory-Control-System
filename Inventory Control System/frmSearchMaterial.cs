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
    public partial class frmSearchMaterial : Form
    {

        SqlConnection sqlCon = new SqlConnection();

        public frmSearchMaterial()
        {
            InitializeComponent();
        }

        private void frmSearchMaterial_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            PopulateMaterialDropdown();

            lstMaterialReferences.CheckBoxes = true;

            lstMaterialReferences.Columns.Add(new ColumnHeader());
            lstMaterialReferences.Columns[0].Text = "Reference Number";
            lstMaterialReferences.Columns[0].Width = 120;

            lstMaterialReferences.Columns.Add(new ColumnHeader());
            lstMaterialReferences.Columns[1].Text = "Transaction Date";
            lstMaterialReferences.Columns[1].Width = 120;

            lstMaterialReferences.Columns.Add(new ColumnHeader());
            lstMaterialReferences.Columns[2].Text = "Material Code";
            lstMaterialReferences.Columns[2].Width = 50;

            lstMaterialReferences.Columns.Add(new ColumnHeader());
            lstMaterialReferences.Columns[3].Text = "Material Name";
            lstMaterialReferences.Columns[3].Width = 120;

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

        private void PopulateMaterialDropdown()
        {
            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "select MaterialCode, MaterialName from dbo.MaterialMaster";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                cmbMaterial.Items.Add(new Item("--None--", ""));

                while (sqlDR.Read())
                {
                    cmbMaterial.Items.Add(new Item(sqlDR.GetString(1), sqlDR.GetString(0)));
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

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetReferenceNumbers();
        }

        private void GetReferenceNumbers()
        {

            Item itmMaterial = (Item)cmbMaterial.SelectedItem;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "SELECT TransactionId, a.MaterialCode, b.MaterialName, ReferenceNumber, TranDate, QuantityReceived FROM dbo.MaterialTransactions a INNER JOIN dbo.MaterialMaster b ON a.MaterialCode = b.MaterialCode WHERE a.MaterialCode = '" + itmMaterial.Value + "'";

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                lstMaterialReferences.Items.Clear();

                while (sqlDR.Read())
                {
                    lstMaterialReferences.Items.Add(new ListViewItem(new string[] { sqlDR.GetString(3), sqlDR.GetDateTime(4).ToString("dd-MMM-yyyy"), sqlDR.GetString(1), sqlDR.GetString(2) }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Method: GetReferenceNumbers" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lstMaterialReferences.CheckedItems[0].Text);
            Form1 frmVoucher = (Form1)this.Owner;

            if (lstMaterialReferences.CheckedItems.Count > 0)
                frmVoucher.GetReferenceNumber(lstMaterialReferences.CheckedItems[0].Text);

        }

        private void lstMaterialReferences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearCheckedItems(ListViewItem lvi)
        {
            foreach (ListViewItem lstItem in lstMaterialReferences.Items)
            {
                if (lstItem.Text != lvi.Text)
                {
                    lstItem.Checked = false;
                }
            }
        }

        private void lstMaterialReferences_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ClearCheckedItems(e.Item);
        }

        private void frmSearchMaterial_KeyDown(object sender, KeyEventArgs e)
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

        private void frmSearchMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cmbMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void dtTranDate_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void chkDateSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void chkDateSearch_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void lstMaterialReferences_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }
    }
}
