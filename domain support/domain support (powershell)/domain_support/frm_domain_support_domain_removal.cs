using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace domain_support
{
    public partial class frm_domain_support_domain_removal : Form
    {
        public frm_domain_support_domain_removal()
        {
            InitializeComponent();
        }

        static bool IsLANConnected()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    if (adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        return true; 
                    }
                }
            }

            return false; 
        }

        /*---------------------------------------------------------------------------*/

        public static int DomainJoinCheck(string args)
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

        public static string DomainRemove(string args)
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

            return error;
        }

        /*---------------------------------------------------------------------------*/

        public static void DomainOperation(string IDD, string PASSWORDD)
        {
            string id;
            string password;

            id = IDD;
            password = PASSWORDD;

            string[] allDomainString = new string[]{
                        $"$username = '{id}'",
                        $"$password = ConvertTo-SecureString '{password}' -AsPlainText -Force",
                        $"$credential = New-Object System.Management.Automation.PSCredential($username, $password)",
                        $"Remove-Computer -UnjoinDomainCredential $credential -WorkgroupName 'WORKGROUP' -Force",};

            string oneDomainString = string.Join(";", allDomainString);

            string stringReturn = DomainRemove(oneDomainString);

            if (stringReturn != "")
            {
                MessageBox.Show("Error! Unsuccessful Domain Remove, Domain UID/PW/LAN issue.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult confirm = MessageBox.Show("Domain Removed Successfully. Click OK to Reboot.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (confirm == DialogResult.OK)
                {
                    var cmd = new System.Diagnostics.ProcessStartInfo("shutdown.exe", "-r -t 0");
                    cmd.CreateNoWindow = true;
                    cmd.UseShellExecute = false;
                    cmd.ErrorDialog = false;
                    System.Diagnostics.Process.Start(cmd);
                }
            }
        }

        /*---------------------------------------------------------------------------*/

        RegistryKey key = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\Tcpip\\Parameters", true);
        string hostName = System.Environment.MachineName;

        /*---------------------------------------------------------------------------*/

        private void frm_domain_support_domain_removal_Load(object sender, EventArgs e)
        {

            object valueData = key.GetValue("Domain");

            if (valueData != null)
            {
                txtAssetCode.Text = hostName + "." + valueData.ToString();
            }
            else
            {
                txtAssetCode.Text = hostName;
            }

            bool LANConnection = IsLANConnected();

            if(LANConnection == true)
            {
                if (valueData.ToString() == "ABC.com")
                {
                    txtID.Text = "ABC.com\\";

                    txtID.Enabled = true;
                    txtPassword.Enabled = true;
                }
                else if (valueData.ToString() == "EFG.corp")
                {
                    txtID.Text = "EFG.corp\\";

                    txtID.Enabled = true;
                    txtPassword.Enabled = true;
                }
                else if (valueData.ToString() == "PQR.corp")
                {
                    txtID.Text = "PQR.corp\\";

                    txtID.Enabled = true;
                    txtPassword.Enabled = true;
                }
                else if (valueData.ToString() == "XYZ.com")
                {
                    txtID.Text = "XYZ.com\\";

                    txtID.Enabled = true;
                    txtPassword.Enabled = true;
                }
                else
                {
                    txtID.Text = "";
                    txtPassword.Text = "";

                    txtID.Enabled = false;
                    txtPassword.Enabled = false;
                }

                txtPassword.Text = "";
            }
            else
            {
                txtID.Text = "Administrator";
                txtPassword.Text = "qwertyuiop";

                txtID.Enabled = false;
                txtPassword.Enabled = false;
            }

            txtPassword.PasswordChar = '*';

        }

        /*---------------------------------------------------------------------------*/

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
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
                    bool LanConnection = IsLANConnected();

                    if (LanConnection == true)
                    {
                        if (txtID.Text == "" || txtPassword.Text == "")
                        {
                            MessageBox.Show("Please enter Domain UID, Password.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            object valueData = key.GetValue("Domain");

                            if (valueData.ToString() == "ABC.com")
                            {
                                txtID.Enabled = true;
                                txtPassword.Enabled = true;

                            }
                            else if (valueData.ToString() == "EFG.corp")
                            {
                                txtID.Enabled = true;
                                txtPassword.Enabled = true;

                            }
                            else if (valueData.ToString() == "PQR.corp")
                            {
                                txtID.Enabled = true;
                                txtPassword.Enabled = true;

                            }
                            else if (valueData.ToString() == "XYZ.com")
                            {
                                txtID.Enabled = true;
                                txtPassword.Enabled = true;

                            }
                            else
                            {
                                MessageBox.Show("Invalid Domain operation.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            DomainOperation(txtID.Text, txtPassword.Text);
                        }
                    }
                    else
                    {
                        txtID.Text = "Administrator";
                        txtPassword.Text = "qwertyuiop";

                        txtID.Enabled = false;
                        txtPassword.Enabled = false;

                        DomainOperation(txtID.Text, txtPassword.Text);
                    }
                }
                else if (checkValue == 1)
                {
                    MessageBox.Show("Domain Remove not allowed. Asset is not on domain.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unidentified Error!", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error! Operation (Powershell.exe) blocked by Local / Domain Controller Policy.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------*/

        private void ImgPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

    }
}
