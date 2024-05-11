using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using System.Diagnostics;

namespace domain_support
{
    public partial class frm_domain_support_asset_custom : Form
    {
        public frm_domain_support_asset_custom()
        {
            InitializeComponent();
        }

        public static int DomainJoinCheck (string args)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "powershell";
            processInfo.Arguments = $"-Command \"{args}\"";

            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            return int.Parse(output);
        }

        /*---------------------------------------------------------------------------*/

        static void SetHostName(string args)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
                processInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe";
                processInfo.Verb = "runas";
                processInfo.Arguments = "/C wmic computersystem where name=\"%COMPUTERNAME%\" call rename name=" + args;
                processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                System.Diagnostics.Process.Start(processInfo);

               DialogResult confirm = MessageBox.Show("Hostname changed successfully. Click OK to Reboot.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (confirm == DialogResult.OK)
                {
                    var cmd = new System.Diagnostics.ProcessStartInfo("shutdown.exe", "-r -t 0");
                    cmd.CreateNoWindow = true;
                    cmd.UseShellExecute = false;
                    cmd.ErrorDialog = false;
                    System.Diagnostics.Process.Start(cmd);
                }
                
            }
            catch
            {
                MessageBox.Show("Unidentified Error!, not able to change Hostname.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------*/

        private void frm_domain_support_asset_custom_Load(object sender, EventArgs e)
        {
            txtCustom.Text = "";
        }

        /*---------------------------------------------------------------------------*/

        private void btnRename_Click(object sender, EventArgs e)
        {
            string[] allString = new string[]{
                       $"$val",
                       $"$computerSystem = Get-WmiObject Win32_ComputerSystem",
                       "if ($computerSystem.PartOfDomain -eq $true) {$val = 0} else {$val = 1}",
                       "return $val",};

            string oneString = string.Join(";", allString);

            int checkValue = DomainJoinCheck(oneString);

            if (checkValue == 0)
            {
                MessageBox.Show("Domain Joined already, asset rename not allowed. De-domain the asset first.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (checkValue == 1)
            {
                string HostName = txtCustom.Text;

                if (txtCustom.Text == "")
                {
                    MessageBox.Show("Please enter Hostname.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (HostName.Length == 14)
                    {
                        SetHostName(HostName.ToUpper());
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Hostname.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Unidentified Error!", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
