using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace domain_support
{
    public partial class frm_domain_support_domain_addition : Form
    {
        public frm_domain_support_domain_addition()
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

        public static string DomainJoin(string args)
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

        private void frm_domain_support_domain_addition_Load(object sender, EventArgs e)
        {
            comboDomainList.Text = "ABC.com";
            comboDomainList.TabStop = false;
            txtID.Text = "ABC\\";
            txtPassword.Text = "";
            txtAssetCode.Text = System.Environment.MachineName;

            txtPassword.PasswordChar = '*';
        }

        /*---------------------------------------------------------------------------*/

        private void btnJoin_Click(object sender, EventArgs e)
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

                if(checkValue == 0)
                {
                    MessageBox.Show("Domain already joined, Remove the domain first to redomain.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(checkValue == 1)
                {
                    bool LANConnection = IsLANConnected();

                    if (LANConnection == true)
                    {
                        if (txtID.Text == "" || txtPassword.Text == "")
                        {
                            MessageBox.Show("Please enter Domain UID, Password.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string assetCode = txtAssetCode.Text;

                            string stringCompare = assetCode.Substring(0, Math.Min(3, assetCode.Length));

                            if (stringCompare == "IBI")
                            {
                                string domain;
                                string id;
                                string password;

                                domain = comboDomainList.Text;
                                id = txtID.Text;
                                password = txtPassword.Text;

                                string[] allDomainString = new string[]{
                        $"$domain = '{domain}'",
                        $"$username = '{id}'",
                        $"$password = ConvertTo-SecureString '{password}' -AsPlainText -Force",
                        $"$credential = New-Object System.Management.Automation.PSCredential($username, $password)",
                        $"Add-Computer -DomainName $domain -Credential $credential",};

                                string oneDomainString = string.Join(";", allDomainString);

                                string stringReturn = DomainJoin(oneDomainString);

                                if (stringReturn != "")
                                {
                                    MessageBox.Show("Error! Unsuccessful Domain Join, Domain UID/PW/LAN issue or Host entry already on domain.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                else
                                {
                                    DialogResult confirm = MessageBox.Show("Domain Joined Successfully. Do you want to Reboot?", "Domain Support", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                    if (confirm == DialogResult.Yes)
                                    {
                                        var cmd = new System.Diagnostics.ProcessStartInfo("shutdown.exe", "-r -t 0");
                                        cmd.CreateNoWindow = true;
                                        cmd.UseShellExecute = false;
                                        cmd.ErrorDialog = false;
                                        System.Diagnostics.Process.Start(cmd);
                                    }
                                    else if (confirm == DialogResult.No) { }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Domain Join not allowed. Change the asset code first.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Domain join error! Lan not connected.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void comboDomainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDomainList.Text == "ABC.com")
            {
                txtID.Text = "ABC\\";
            }
            else if(comboDomainList.Text == "EFG.corp")
            {
                txtID.Text = "EFG\\";
            }
            else if (comboDomainList.Text == "PQR.corp")
            {
                txtID.Text = "PQR\\";
            }
            else if (comboDomainList.Text == "XYZ.com")
            {
                txtID.Text = "XYZ\\";
            }

        }

        /*---------------------------------------------------------------------------*/

        private void ImgPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
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

