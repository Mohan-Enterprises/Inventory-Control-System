using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_Control_System
{
    public class SearchObject
    {

        private string mComponentCode;

        public string ComponentCode
        {
            get { return mComponentCode; }
            set { mComponentCode = value; }
        }

        private string mVendorCode;

        public string VendorCode
        {
            get { return mVendorCode; }
            set { mVendorCode = value; }
        }

        private string mChalaanNumberInternal;

        public string ChalaanNumberInternal
        {
            get { return mChalaanNumberInternal; }
            set { mChalaanNumberInternal = value; }
        }


        private string mChalaanNumberExternal;

        public string ChalaanNumberExternal
        {
            get { return mChalaanNumberExternal; }
            set { mChalaanNumberExternal = value; }
        }

        private bool mIncludeDate;

        public bool IncludeDate
        {
            get { return mIncludeDate; }
            set { mIncludeDate = value; }
        }

        private bool mYearOnly;

        public bool YearOnly
        {
            get { return mYearOnly; }
            set { mYearOnly = value; }
        }

        private string mTransactionMonth;

        public string TransactionMonth
        {
            get { return mTransactionMonth; }
            set { mTransactionMonth = value; }
        }

        private string mTransactionYear;

        public string TransactionYear
        {
            get { return mTransactionYear; }
            set { mTransactionYear = value; }
        }

        private bool mRejectedLots;

        public bool RejectedLots
        {
            get { return mRejectedLots; }
            set { mRejectedLots = value; }
        }

        private string mTransactionType;

        public string TransactionType
        {
            get { return mTransactionType; }
            set { mTransactionType = value; }
        }

        public string PrepareSearchCriteria()
        {
            string strSearchSQL = string.Empty;
            string strSearchCriteria = string.Empty;

            string strMonth = string.Empty;
            string strYear = string.Empty;

            //if date should be included in Search criteria
            if (mIncludeDate)
            {
                //get month/year
                if (mYearOnly)
                {
                    strYear = TransactionYear;
                    if (strSearchCriteria != string.Empty)
                        strSearchCriteria = " and year(TranDate) = " + TransactionYear;
                    else
                        strSearchCriteria = " year(TranDate) = " + TransactionYear;
                }
                else
                {
                    strMonth = TransactionMonth;
                    strYear = TransactionYear;

                    strSearchCriteria = " year(TranDate) = " + TransactionYear + " and month(TranDate) = " + TransactionMonth;
                }
            }

            //get chalaan number
            if (ChalaanNumberInternal != string.Empty)
            {
                ChalaanNumberInternal = ChalaanNumberInternal.Replace("'", "''");

                if (strSearchCriteria != string.Empty)
                    strSearchCriteria = strSearchCriteria + " and ChalaanNumberInternal = '" + ChalaanNumberInternal + "'";
                else
                    strSearchCriteria = " ChalaanNumberInternal = '" + ChalaanNumberInternal + "'";
            }

            //get vendorcode
            if (VendorCode != "--None--" && VendorCode != string.Empty)
            {
                if (strSearchCriteria != string.Empty)
                    strSearchCriteria = strSearchCriteria + " and VendorCode = '" + VendorCode + "'";
                else
                    strSearchCriteria = " VendorCode = '" + VendorCode + "'";
            }

            //get componentcode
            if (ComponentCode != "--None--" && ComponentCode != string.Empty)
            {
                if (strSearchCriteria != string.Empty)
                    strSearchCriteria = strSearchCriteria + " and ComponentCode = '" + ComponentCode + "'";
                else
                    strSearchCriteria = " ComponentCode = '" + ComponentCode + "'";
            }

            //rejected lots
            if (RejectedLots)
            {
                if (strSearchCriteria != string.Empty)
                    strSearchCriteria = strSearchCriteria + " and RejectedQuantity is not null and RejectedQuantity > 0 ";
                else
                    strSearchCriteria = " RejectedQuantity is not null and RejectedQuantity > 0 ";
            }

            //Incoming/Outgoing
            if (TransactionType != "--None--")
            {
                if (TransactionType != "Both")
                {
                    if (strSearchCriteria != string.Empty)
                        strSearchCriteria = strSearchCriteria + " and [Type] = '" + TransactionType + "'";
                    else
                        strSearchCriteria = " [Type] = '" + TransactionType + "'";
                }
            }

            return strSearchCriteria;
        }
    }
}
