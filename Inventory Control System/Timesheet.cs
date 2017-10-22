using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public partial class Timesheet : Form
    {
        public Timesheet()
        {
            InitializeComponent();


        }

        private void DrawDayLabels()
        {

            string[] strDays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Label lblDay = new Label();

            for (int i = 0; i < 7; i++)
            {

                lblDay.Text = strDays[i];

                //lblDay.Width = 50 + i;
                lblDay.Left = 40 + i;
                //lblDay.Top = 40;

                this.Controls.Add(lblDay);
            }

        }

        private void Timesheet_Load(object sender, EventArgs e)
        {
            DrawDayLabels();
        }
    }
}
