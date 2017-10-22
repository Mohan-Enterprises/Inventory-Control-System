using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_Control_System
{
    public class RawMaterialMaster
    {

        private Int64 mMaterialId;

        public Int64 MaterialId
        {
            get { return mMaterialId; }
            set { mMaterialId = value; }
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

        private string mUOM;

        public string UOM
        {
            get { return mUOM; }
            set { mUOM = value; }
        }


    }
}
