using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_Control_System
{
    public class VendorDataSummary
    {

        public VendorDataSummary()
        {

        }

        private string mVendorCode;

        public string VendorCode
        {
            get { return mVendorCode; }
            set { VendorCode = value; }
        }

        private DateTime mLastDateOutgoing;

        public DateTime LastDateOutgoing
        {
            get { return mLastDateOutgoing; }
            set { LastDateOutgoing = value; }
        }

        private DateTime mLastDateIncoming;

        public DateTime LastDateIncoming
        {
            get { return mLastDateOutgoing; }
            set { LastDateIncoming = value; }
        }

        private decimal mQtyWithVendor;

        public decimal QtyWithVendor
        {
            get { return mQtyWithVendor; }
            set { QtyWithVendor = value; }
        }
    }
}
