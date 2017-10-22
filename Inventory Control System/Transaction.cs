using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_Control_System
{
    public class Transaction
    {
        private Int32 mTransactionId;

        public Int32 TransactionId
        {
            get { return mTransactionId; }
            set { mTransactionId = value; }
        }

        private string mTransactionCode;

        public string TransactionCode
        {
            get { return mTransactionCode; }
            set { mTransactionCode = value; }
        }

        private DateTime mTransactionDate;

        public DateTime TransactionDate
        {
            get { return mTransactionDate; }
            set { mTransactionDate = value; }
        }
        private string mChalaanNumberInternal;

        public string ChalaanNumberInternal
        {
            get { return mChalaanNumberInternal; }
            set { mChalaanNumberInternal = value; }
        }
        private string mVendorCode;

        public string VendorCode
        {
            get { return mVendorCode; }
            set { mVendorCode = value; }
        }
        private string mComponentCode;

        public string ComponentCode
        {
            get { return mComponentCode; }
            set { mComponentCode = value; }
        }
        private decimal mQuantity;

        public decimal Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }

        private decimal mIncomingQuantity;

        public decimal IncomingQuantity
        {
            get { return mIncomingQuantity; }
            set { mIncomingQuantity = value; }
        }

        private decimal mTotalQuantity;

        public decimal TotalQuantity
        {
            get { return mTotalQuantity; }
            set { mTotalQuantity = value; }
        }


        private decimal mRejectedQuantity;

        public decimal RejectedQuantity
        {
            get { return mRejectedQuantity; }
            set { mRejectedQuantity = value; }
        }
        private string mChalaanNumberExternal;

        public string ChalaanNumberExternal
        {
            get { return mChalaanNumberExternal; }
            set { mChalaanNumberExternal = value; }
        }
        private string mType;

        public string Type
        {
            get { return mType; }
            set { mType = value; }
        }

        private bool mIsValidIncomingChalaan;

        public bool IsValidIncomingChalaan
        {
            get { return mIsValidIncomingChalaan; }
            set { mIsValidIncomingChalaan = value; }
        }

        private string mOperationCode;

        public string OperationCode
        {
            get { return mOperationCode; }
            set { mOperationCode = value; }
        }

    }
}
