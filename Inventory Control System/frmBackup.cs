using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace Inventory_Control_System
{
    public partial class frmUtilities : Form
    {
        public frmUtilities()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            string serverName = ConfigurationManager.AppSettings["SQLServer"].ToString();
            string backup_location = ConfigurationManager.AppSettings["backup_location"].ToString();

            //string procCmd = "sqlcmd";
            //string procArguments = @" -S " + serverName +  @""" BACKUP DATABASE ICS TO DISK = " + backup_location + @"ics.bak""";

            string procErrors = string.Empty;
            string procOutput = string.Empty;

            //ProcessStartInfo info = new ProcessStartInfo(procCmd, procArguments);
            ProcessStartInfo info = new ProcessStartInfo("sqlcmd", " -S " + @serverName +"  -i " + @backup_location + "backup.sql");

            info.UseShellExecute = false;

            //info.Arguments = procArguments;

            info.CreateNoWindow = true;

            info.WindowStyle = ProcessWindowStyle.Hidden;

            info.RedirectStandardOutput = true;

            info.RedirectStandardError = true;

            Process proc = new Process();

            proc.StartInfo = info;

            proc.Start();

            MessageBox.Show("Backup taken successfully.", "ICS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            proc = null;

            this.Close();

        }

        private void frmUtilities_Load(object sender, EventArgs e)
        {

        }

        private void KeyAction(KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();

            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnBackup_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

        private void frmUtilities_KeyDown(object sender, KeyEventArgs e)
        {
            KeyAction(e);
        }

    }
}
