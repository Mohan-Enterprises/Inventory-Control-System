using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory_Control_System
{
    public class Vendor
    {
        SqlConnection sqlCon = new SqlConnection();

        private string mVendorCode = string.Empty;

        public string VendorCode
        {
            get
            {
                return mVendorCode;
            }
            set
            {
                mVendorCode = value;
            }
        }

        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        private string mAddress;

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }
        private string mState;

        public string State
        {
            get { return mState; }
            set { mState = value; }
        }
        private string mZipCode;

        public string ZipCode
        {
            get { return mZipCode; }
            set { mZipCode = value; }
        }
        private string mPhone;

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }
        private string mEmail;

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        private string mType;

        public string Type
        {
            get { return mType; }
            set { mType = value; }
        }

        public Vendor GetVendorDetails(string vendorCode)
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

            sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT [VendorCode], [Name], [Address], [State], [ZipCode], [Phone],[Email],[Type] FROM vw_VendorMaster WHERE VendorCode = '" + vendorCode + "'";
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDR = sqlCmd.ExecuteReader();

            try
            {
                if (sqlDR.HasRows)
                {
                    sqlDR.Read();

                    VendorCode = sqlDR.GetString(0);
                    if (!sqlDR.IsDBNull(1))
                        Name = sqlDR.GetString(1);
                    if (!sqlDR.IsDBNull(2))
                        Address = sqlDR.GetString(2);
                    if (!sqlDR.IsDBNull(3))
                        State = sqlDR.GetString(3);
                    if (!sqlDR.IsDBNull(4))
                        ZipCode = sqlDR.GetString(4);
                    if (!sqlDR.IsDBNull(5))
                        Phone = sqlDR.GetString(5);
                    if (!sqlDR.IsDBNull(6))
                        Email = sqlDR.GetString(6);
                    if (!sqlDR.IsDBNull(7))
                        Type = sqlDR.GetString(7);

                    if (Type == "V")
                        Type = "Vendor";
                    else if (Type == "C")
                        Type = "Contractor";

                    return this;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlDR.Close();
                sqlDR = null;
                sqlCmd = null;
            }
            return this;
        }
    }
}
