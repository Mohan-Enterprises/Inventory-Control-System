using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_Control_System
{
    public class RawMaterialTransaction
    {
        private Int64 mTransactionId;

        public Int64 TransactionId
        {
            get { return mTransactionId; }
            set { mTransactionId = value; }
        }

        private string mMaterialCode;

        public string MaterialCode
        {
            get { return mMaterialCode; }
            set { mMaterialCode = value; }
        }

        private string mReferenceNumber;

        public string ReferenceNumber
        {
            get { return mReferenceNumber; }
            set { mReferenceNumber = value; }
        }

        private DateTime mTranDate;

        public DateTime TranDate
        {
            get { return mTranDate; }
            set { mTranDate = value; }
        }

        private decimal mQuantityReceived;

        public decimal QuantityReceived
        {
            get { return mQuantityReceived; }
            set { mQuantityReceived = value; }
        }

        private string mJobCode;

        public string JobCode
        {
            get { return mJobCode; }
            set { mJobCode = value; }
        }

        private string mUOM;

        public string UOM
        {
            get { return mUOM; }
            set { mUOM = value; }
        }

        private decimal mProdUnits;

        public decimal ProdUnits
        {
            get { return mProdUnits; }
            set { mProdUnits = value; }
        }

        
    }
}
