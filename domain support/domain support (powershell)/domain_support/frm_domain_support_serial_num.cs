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
    public partial class frm_domain_support_serial_num : Form
    {
        public frm_domain_support_serial_num()
        {
            InitializeComponent();
        }


        public static string SerialNumber()
        {
            var adminInfo = "/c wmic bios get serialnumber";
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

        private void frm_domain_support_serial_num_Load(object sender, EventArgs e)
        {
            try
            {
                txtSerialNum.Text = SerialNumber();
            } catch { }
            
        }
    }
}
