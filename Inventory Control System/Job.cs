using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_Control_System
{
    public class Job
    {
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

        private string mJobName;

        public string JobName
        {
            get { return mJobName; }
            set { mJobName = value; }
        }

        private DateTime mJobStartDate;

        public DateTime JobStartDate
        {
            get { return mJobStartDate; }
            set { mJobStartDate = value; }
        }

        private DateTime mJobEndDate;

        public DateTime JobEndDate
        {
            get { return mJobEndDate; }
            set { mJobEndDate = value; }
        }

        private string mComponentCode;

        public string ComponentCode
        {
            get { return mComponentCode; }
            set { mComponentCode = value; }
        }

        private string mMaterialCode;

        public string MaterialCode
        {
            get { return mMaterialCode; }
            set { mMaterialCode = value; }
        }

        private string mMaterialName;

        public string MaterialName
        {
            get { return mMaterialName; }
            set { mMaterialName = value; }
        }

        private string mComponentName;

        public string ComponentName
        {
            get { return mComponentName; }
            set { mComponentName = value; }
        }

        private string mReferenceNumber;

        public string ReferenceNumber
        {
            get { return mReferenceNumber; }
            set { mReferenceNumber = value; }
        }


    }
}
