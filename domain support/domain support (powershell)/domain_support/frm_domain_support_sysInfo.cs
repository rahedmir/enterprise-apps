using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domain_support
{
    public partial class frm_domain_support_sysInfo : Form
    {

        public frm_domain_support_sysInfo()
        {
            InitializeComponent();
        }


        public static string SystemInfo()
        {
            var adminInfo = "/c systeminfo";
            var processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            processInfo.Arguments = adminInfo;
            processInfo.CreateNoWindow = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.UseShellExecute = false;

            var cmd = System.Diagnostics.Process.Start(processInfo);
            var output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();

            return output;
        }

        private void frm_domain_support_sysInfo_Load(object sender, EventArgs e)
        {
            try
            {
                txtSystemInfo.Text = SystemInfo();
            }
            catch
            { }
        }
    }
}
