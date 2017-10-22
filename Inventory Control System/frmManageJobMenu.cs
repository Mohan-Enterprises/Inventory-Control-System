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
    public partial class frmManageJobMenu : Form
    {
        public frmManageJobMenu()
        {
            InitializeComponent();
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            frmJob frm1 = new frmJob();

            frm1.ShowDialog();
        }

        private void frmManageJobMenu_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }

        private void btnCreateJob_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void btnFindJob_Click(object sender, EventArgs e)
        {
            frmFindJob frmFJ = new frmFindJob();
            
            frmFJ.SourceForm = "Job";

            frmFJ.ShowDialog();
        }

        private void btnFindJob_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmManageJobMenu_Load(object sender, EventArgs e)
        {
            //panel1.Left = 1165;
            //panel1.Height = 650;
            //panel1.Top = 70;
            //pictureBox1.Height = 650;
            //pictureBox1.Width = 1100;
            //pictureBox1.Left = 10;
            //pictureBox1.Top = 70;
        }
        
    }
}
