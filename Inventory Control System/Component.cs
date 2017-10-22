using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_Control_System
{
    public class Component
    {
        private string mComponentCode;

        public string ComponentCode
        {
            get { return mComponentCode; }
            set { ComponentCode= value; }
        }

        private string mName;

        public string Name
        {
            get { return mName; }
            set { Name = value; }
        }

        private string mUOM;

        public string UOM
        {
            get { return mUOM; }
            set { UOM = value; }
        }
    }
}
