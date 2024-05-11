using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using System.Management;
using System.Linq;
using System.DirectoryServices.AccountManagement;
using System.Runtime.InteropServices;

namespace domain_support
{

    public partial class frm_domain_support : Form
    {
        public frm_domain_support()
        {
            InitializeComponent();
        }

        //Child Forms

        frm_domain_support_asset_laptop frm_laptop = new frm_domain_support_asset_laptop();
        frm_domain_support_asset_desktop frm_desktop = new frm_domain_support_asset_desktop();
        frm_domain_support_asset_custom frm_custom = new frm_domain_support_asset_custom();
        frm_domain_support_join_info frm_info = new frm_domain_support_join_info();
        frm_domain_support_removal_info frm_removal_info = new frm_domain_support_removal_info();
        frm_domain_support_security_services frm_security = new frm_domain_support_security_services();
        frm_domain_support_serial_num frm_serial = new frm_domain_support_serial_num();
        frm_domain_support_loading frm_loading = new frm_domain_support_loading();
        frm_domain_support_sysInfo frm_sysInfo = new frm_domain_support_sysInfo(); 
        frm_domain_support_about frm_about = new frm_domain_support_about();

        /*---------------------------------------------------------------------------*/


        //Global Variables

        public static int flag = 0;
        public static int flag_2 = 0;

        public static int time = 4;
        

        public static string str_Xi_Caps = "net accounts /minpwlen:0 & net user Xi password@123";
        public static string str_Xi_Small = "net accounts /minpwlen:0 & net user xi password@123";
        public static string str_Administrator_Caps = "wmic useraccount where name='Administrator' call rename name='Xi' & net accounts /minpwlen:0 & net user Xi password@123";
        public static string str_Administrator_Small = "wmic useraccount where name='administrator' call rename name='Xi' & net accounts /minpwlen:0 & net user Xi password@123";
        public static string str_A1_Caps = "wmic useraccount where name='Administrator' call rename name='Xi' & net accounts /minpwlen:0 & net user Xi /active:yes & net user Xi password@123";
        public static string str_A1_Small = "wmic useraccount where name='administrator' call rename name='Xi' & net accounts /minpwlen:0 & net user Xi /active:yes & net user Xi password@123";
        public static string str_Xi_If_Caps = "net accounts /minpwlen:0 & net user Xi /active:yes & net user Xi password@123";
        public static string str_Xi_If_Small = "net accounts /minpwlen:0 & net user xi /active:yes & net user xi password@123";

        /*---------------------------------------------------------------------------*/


        //Error Messages

        static void errorMsg()
        {
            MessageBox.Show("Error! Please run as Admin or Xi.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void changeAdminMsg()
        {
            MessageBox.Show("Administrator account name already changed, use lusrmgr.msc", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static void errorMissingAdminMsg()
        {
            MessageBox.Show("Can't find Admin / Xi account, use lusrmgr.msc", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static void errorMixedNameMsg()
        {
            MessageBox.Show("Mixed or All CAPS character found in account name, use lusrmgr.msc", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static void errorDeleteA1()
        {
            MessageBox.Show("Can't delete A1 account while it is logged in.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void errorStartService()
        {
            MessageBox.Show("Unable to start the service.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void errorUnidentifiedMsg()
        {
            MessageBox.Show("Unidentified Error!", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void errorLockedMsg()
        {
            MessageBox.Show("Operation blocked by Landesk / Symantec policy, Unlock the asset first.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*---------------------------------------------------------------------------*/


        //Functions

        static bool isAdmin()
        {
           WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
           WindowsPrincipal adminUSer = new WindowsPrincipal(currentUser);
           return adminUSer.IsInRole(WindowsBuiltInRole.Administrator);
        }

        /*---------------------------------------------------------------------------*/

        static void addRegKey()
        {   
           try
            {
                if (isAdmin())
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Lsa", true);
                    key.SetValue("NetJoinLegacyAccountReuse", 1, RegistryValueKind.DWord);
                    key.SetValue("LmCompatibilityLevel", 5, RegistryValueKind.DWord);
                    key.Close();
                    MessageBox.Show("Key added successfully & LMA set to NTLMv2." + Environment.NewLine + "Proceed to redomain...", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
                
            }

            catch
            {
                errorUnidentifiedMsg();
            }
        }



        static void removeRegKey()
        {
            try
            {
               if (isAdmin())
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Lsa", true);
                    key.DeleteValue("NetJoinLegacyAccountReuse");
                    key.DeleteValue("LmCompatibilityLevel");
                    key.Close();
                    MessageBox.Show("Key removed successfully & LMA set to Nill.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
            } 
            
            catch
            {
                MessageBox.Show("Key already removed or doesn't exist.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*---------------------------------------------------------------------------*/

        static void checkUser(string args)
        {
            System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
            processInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe";
            processInfo.Verb = "runas";
            processInfo.Arguments = "/C " + args;
            processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process.Start(processInfo);
            MessageBox.Show("Admin / Xi account set up successfully.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*---------------------------------------------------------------------------*/

        static bool checkAdminExists(string admin)
        {
            var adminName = new NTAccount(admin);

            try
            {
                var sid = (SecurityIdentifier)adminName.Translate(typeof(SecurityIdentifier));
                return true;
            }
            catch (IdentityNotMappedException)
            {
                return false;
            }
        }

        /*---------------------------------------------------------------------------*/

        static void setAdmin()
        {
            string checkEnvironment = Environment.UserName;

            try
            {
                if (isAdmin())
                {
                    if (checkEnvironment == "Xi" || checkEnvironment == "xi")
                    {

                        if (checkAdminExists("Xi"))
                        {
                            flag = Convert.ToInt32(checkService("net user | find \"Xi\" /c"));
                            flag_2 = Convert.ToInt32(checkService("net user | find \"xi\" /c"));

                            if (flag == 1)
                            {
                                checkUser(str_Xi_Caps);
                                flag = 0;
                                return;
                            }
                            else if (flag_2 == 1)
                            {
                                checkUser(str_Xi_Small);
                                flag_2 = 0;
                                return;
                            }
                            else
                            {
                                errorMixedNameMsg();
                            }

                        }
                        else
                        {
                            changeAdminMsg();
                        }

                    }

                    else if (checkEnvironment == "Administrator" || checkEnvironment == "administrator")
                    {

                        if (checkAdminExists("Administrator"))
                        {
                            flag = Convert.ToInt32(checkService("net user | find \"Administrator\" /c"));
                            flag_2 = Convert.ToInt32(checkService("net user | find \"administrator\" /c"));

                            if (flag == 1)
                            {
                                checkUser(str_Administrator_Caps);
                                flag = 0;
                                return;
                            }
                            else if (flag_2 == 1)
                            {
                                checkUser(str_Administrator_Small);
                                flag_2 = 0;
                                return;
                            }
                            else
                            {
                                errorMixedNameMsg();
                            }

                        }
                        else
                        {
                            changeAdminMsg();
                        }

                    }

                    else if (checkEnvironment == "A1" || checkEnvironment == "a1")
                    {

                        if (checkAdminExists("A1"))
                        {
                            if (checkAdminExists("Administrator"))
                            {
                                flag = Convert.ToInt32(checkService("net user | find \"Administrator\" /c"));
                                flag_2 = Convert.ToInt32(checkService("net user | find \"administrator\" /c"));

                                if (flag == 1)
                                {
                                    checkUser(str_A1_Caps);
                                    flag = 0;
                                    return;
                                }
                                else if (flag_2 == 1)
                                {
                                    checkUser(str_A1_Small);
                                    flag_2 = 0;
                                    return;
                                }
                                else
                                {
                                    errorMixedNameMsg();
                                }

                            }

                            else if (checkAdminExists("Xi"))
                            {
                                flag = Convert.ToInt32(checkService("net user | find \"Xi\" /c"));
                                flag_2 = Convert.ToInt32(checkService("net user | find \"xi\" /c"));

                                if (flag == 1)
                                {
                                    checkUser(str_Xi_If_Caps);
                                    flag = 0;
                                    return;
                                }
                                else if (flag_2 == 1)
                                {
                                    checkUser(str_Xi_If_Small);
                                    flag_2 = 0;
                                    return;
                                }
                                else
                                {
                                    errorMixedNameMsg();
                                }
                            }

                            else
                            {
                                errorMissingAdminMsg();
                            }
                        }
                        else
                        {
                            changeAdminMsg();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error! Set Admin operation only supports Administrator, Xi or A1 account." + Environment.NewLine + "Your current login account : " + checkEnvironment, "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    errorMsg();
                }
            }
            catch
            {
                errorUnidentifiedMsg();
            }
        }

        /*---------------------------------------------------------------------------*/

        static void findA1()
        {

            if (checkAdminExists("A1"))
            {
                flag = Convert.ToInt32(checkService("net user | find \"A1\" /c"));
                flag_2 = Convert.ToInt32(checkService("net user | find \"a1\" /c"));

                if (flag == 1)
                {
                    StartServices("net user A1 /delete");
                    MessageBox.Show("A1 account deleted successfully.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    flag = 0;
                    return;
                }
                else if (flag_2 == 1)
                {
                    StartServices("net user a1 /delete");
                    MessageBox.Show("a1 account deleted successfully.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    flag_2 = 0;
                    return;
                }                           
            }
            else
            {
                MessageBox.Show("A1 account already removed or doesn't exist.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /*---------------------------------------------------------------------------*/

        static void deleteA1()
        {
            string checkEnvironment_2 = Environment.UserName;

            try
            {
                if (isAdmin())
                {
                    if (checkEnvironment_2 == "Xi" || checkEnvironment_2 == "xi")
                    {
                        findA1();
                    }
                   
                    else if (checkEnvironment_2 == "Administrator" || checkEnvironment_2 == "administrator")
                    {
                        findA1();
                    }
              
                    else if (checkEnvironment_2 == "A1" || checkEnvironment_2 == "a1")
                    {
                        errorDeleteA1();
                    }
             
                    else
                    {
                        MessageBox.Show("Error! Delete A1 operation only supported by Administrator, or Xi account." + Environment.NewLine + "Your current login account : " + checkEnvironment_2, "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorMsg();
                }
            }
            catch
            {
                errorUnidentifiedMsg();
            }
        }

        /*---------------------------------------------------------------------------*/

        static void restart()
        {
            var cmd = new System.Diagnostics.ProcessStartInfo("shutdown.exe", "-r -t 0");
            cmd.CreateNoWindow = true;
            cmd.UseShellExecute = false;
            cmd.ErrorDialog = false;
            System.Diagnostics.Process.Start(cmd);
        }

        /*---------------------------------------------------------------------------*/

        static string checkService(string args)
        {
            var adminInfo = "/C" + args;
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

        /*---------------------------------------------------------------------------*/

        static void StartServices(string args)
        {
            System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
            processInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe";
            processInfo.Verb = "runas";
            processInfo.Arguments = "/C " + args;
            processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process.Start(processInfo);
        }

        /*---------------------------------------------------------------------------*/

        static void StartServicesWindow(string args)
        {
            System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
            processInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe";
            processInfo.Verb = "runas";
            processInfo.Arguments = "/C " + args;

            System.Diagnostics.Process.Start(processInfo);
        }

        /*---------------------------------------------------------------------------*/

        static void WiredAutoConfigService(ToolStripMenuItem WiredAutoConfig)
        {
            if (checkService("sc query dot3svc | find \"RUNNING\"") != "")
            {
                WiredAutoConfig.Checked = true;
            }
            else
            {
                WiredAutoConfig.Checked = false;
            }

        }

       static void WLANAutoConfigService(ToolStripMenuItem WLANAutoConfig)
        {
            if (checkService("sc query WlanSvc | find \"RUNNING\"") != "")
            {
                WLANAutoConfig.Checked = true;
            }
            else
            {
                WLANAutoConfig.Checked = false;
            }
        }

        static void WindowsUpdateService(ToolStripMenuItem WindowsUpdate)
        {
            if (checkService("sc query wuauserv | find \"RUNNING\"") != "")
            {
                WindowsUpdate.Checked = true;
            }
            else
            {
                WindowsUpdate.Checked = false;
            }
        }

        static void BitLockerDriveService(ToolStripMenuItem BitLockerDrive)
        {
            if (checkService("sc query BDESVC | find \"RUNNING\"") != "")
            {
                BitLockerDrive.Checked = true;
            }
            else
            {
                BitLockerDrive.Checked = false;
            }
        }

        static void EncryptingFileService(ToolStripMenuItem EncryptingFile)
        {
            if (checkService("sc query EFS | find \"RUNNING\"") != "")
            {
                EncryptingFile.Checked = true;
            }
            else
            {
                EncryptingFile.Checked = false;
            }
        }

        /*---------------------------------------------------------------------------*/


        //Form Buttons


        private void btnAddKey_Click(object sender, EventArgs e)
        {
            addRegKey();
        }

        private void btnDomainJoinKey_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                frm_info.ShowDialog();
            }
            else
            {
                errorMsg();
            }
        }

        /*---------------------------------------------------------------------------*/


        //File Menu


        private void addKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRegKey();
        }

        private void removeKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeRegKey();
        }

        /*---------------------------------------------------------------------------*/



        //Domain Menu


        private void laptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                frm_laptop.ShowDialog();
            }
            else
            {
                errorMsg();
            }
        }

        private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                frm_desktop.ShowDialog();
            }
            else
            {
                errorMsg();
            }
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                frm_custom.ShowDialog();
            }
            else
            {
                errorMsg();
            }
        }

        /*---------------------------------------------------------------------------*/

        private void domainJoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                frm_info.ShowDialog();
            }
            else
            {
                errorMsg();
            }
        }

        private void removeDomainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                frm_removal_info.ShowDialog();
            }
            else
            {
                errorMsg();
            }
        }

        /*---------------------------------------------------------------------------*/


        //Admin Menu


        private void setAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setAdmin();
        }


        private void deleteA1AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteA1();
        }


        private void fixPasswordLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServices("net accounts /minpwlen:0");
                    MessageBox.Show("Password length set to default.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
            }
            catch
            {
                errorUnidentifiedMsg();
            }
        }

        private void safeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to Restart the system in Safe Mode...", "Domain Support", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (confirm == DialogResult.Yes)
                {
                    StartServices("bcdedit /set {default} safeboot minimal");
                    restart();
                }
                else if (confirm == DialogResult.No) { }
            }
            catch { }
        }

        private void safeModeWithNetworkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to Restart the system in Safe Mode with Networking...", "Domain Support", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (confirm == DialogResult.Yes)
                {
                    StartServices("bcdedit /set {default} safeboot network");
                    restart();
                }
                else if (confirm == DialogResult.No) { }
            }
            catch { }
        }

        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to Restart the system in Normal Mode...", "Domain Support", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (confirm == DialogResult.Yes)
                {
                    StartServices("bcdedit /deletevalue {default} safeboot");
                    restart();
                }
                else if (confirm == DialogResult.No) { }
            }
            catch { }
        }

        /*---------------------------------------------------------------------------*/



        //Services Menu


        private void servicesMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WiredAutoConfigService(WiredAutoConfigToolStripMenuItem);
            WLANAutoConfigService(WLANAutoConfigToolStripMenuItem);
            WindowsUpdateService(WindowsUpdateToolStripMenuItem);
            BitLockerDriveService(BitLockerDriveEncryptionToolStripMenuItem);
            EncryptingFileService(EncryptingFileSystemToolStripMenuItem);
        }

        /*---------------------------------------------------------------------------*/

        private void WiredAutoConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServices("sc.exe config dot3svc start= auto & net start dot3svc");
                    MessageBox.Show("Wired AutoConfig service is successfully enabled.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
            }

            catch
            {
                errorStartService();
            }
        }

        private void WLANAutoConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServices("sc.exe config WlanSvc start= auto & net start WlanSvc");
                    MessageBox.Show("WLAN AutoConfig service is successfully enabled.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
            }

            catch
            {
                errorStartService();
            }
        }

        private void WindowsUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServices("sc.exe config wuauserv start= demand & net start wuauserv");
                    MessageBox.Show("Windows Update service is successfully enabled.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
            }

            catch
            {
                errorStartService();
            }
        }

        private void BitLockerDriveEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServices("sc.exe config BDESVC start= demand & net start BDESVC");
                    MessageBox.Show("BitLocker Drive Encryption service is successfully enabled.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
            }

            catch
            {
                errorStartService();
            }
        }

        private void EncryptingFileSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServices("sc.exe config EFS start= demand & net start EFS");
                    MessageBox.Show("Encrypting File System (EFS) service is successfully enabled.", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorMsg();
                }
            }

            catch
            {
                errorStartService();
            }
        }

        private void securityServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_security.ShowDialog();
        }

        /*---------------------------------------------------------------------------*/


        //Tools Menu


        private void assetSerialNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_serial.ShowDialog();
        }

        /*---------------------------------------------------------------------------*/

        private void iExplorer11SetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP008.com/IE_Setup.exe");
            }
            catch {
                errorLockedMsg();
            }
        }

        /*---------------------------------------------------------------------------*/

        private void localUsersAndGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("lusrmgr.msc");
            }
            catch { }
        }

        private void localGroupPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("gpedit.msc");
            }
            catch { }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("services.msc");
            }
            catch { }
        }

        private void registryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("regedit");
            }
            catch { }
        }

        /*---------------------------------------------------------------------------*/

        private void CMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("start cmd");
            }
            catch { }
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("taskmgr");
            }
            catch { }
        }

        /*---------------------------------------------------------------------------*/

        private void allControlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("control");
            }
            catch { }
        }

        private void programsAndFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("appwiz.cpl");
            }
            catch { }
        }

        private void networkConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("ncpa.cpl");
            }
            catch { }
        }

        /*---------------------------------------------------------------------------*/

        private void deviceManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("devmgmt.msc");
            }
            catch { }
        }

        private void diskManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("diskmgmt.msc");
            }
            catch { }
        }

        private void trustedPlatformModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices("tpm.msc");
            }
            catch { }
        }

        /*---------------------------------------------------------------------------*/

        private void HYP002MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP002.com/SEPUpdateX64.exe");
            }
            catch {
                errorLockedMsg();
            }

        }

        private void HYP003MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP003.com/SEPUpdateX64.exe");
            }
            catch {
                errorLockedMsg();
            }
        }

        private void HYP005MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP005.com/SEPUpdateX64.exe");
            }
            catch {
                errorLockedMsg();
            }
        }

        private void HYP007MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP007.com/SEPUpdateX64.exe");
            }
            catch {
                errorLockedMsg();
            }
        }

        /*---------------------------------------------------------------------------*/

        private void RU3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServicesWindow("MsiExec.exe /F {0FDBD397-EAAB-4D67-A28F-939691EE3D84}");
                }
                else
                {
                    errorMsg();
                }
            }  catch { }

        }

        private void RU6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServicesWindow("MsiExec.exe /F {4B0D0931-861B-4D42-8314-191DCB5702B9}");
                }
                else
                {
                    errorMsg();
                }
            }
            catch { }
        }

        private void RU8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin())
                {
                    StartServicesWindow("MsiExec.exe /F {AB2C803C-5D82-4D6A-AC6A-5A7357D8B2F9}");
                }
                else
                {
                    errorMsg();
                }
            }
            catch { }
        }

        /*---------------------------------------------------------------------------*/

        private void HYP002ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP002.com");
            }
            catch {
                errorLockedMsg();
            }
        }

        private void HYP003ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP003.com");
            }
            catch {
                errorLockedMsg();
            }
        }

        private void HYP005ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP005.com");
            }
            catch {
                errorLockedMsg();
            }
        }

        private void HYP008ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://HYP008.com");
            }
            catch {
                errorLockedMsg();
            }
        }

         


        //Help Menu


        private void systemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            frm_loading.ShowDialog();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about.ShowDialog();
        }

        /*---------------------------------------------------------------------------*/


        //Form Loading Events

        private void frm_domain_support_Load(object sender, EventArgs e)
        {
            timer.Enabled = false;

            WiredAutoConfigService(WiredAutoConfigToolStripMenuItem);
            WLANAutoConfigService(WLANAutoConfigToolStripMenuItem);
            WindowsUpdateService(WindowsUpdateToolStripMenuItem);
            BitLockerDriveService(BitLockerDriveEncryptionToolStripMenuItem);
            EncryptingFileService(EncryptingFileSystemToolStripMenuItem);

            toolStripStatusLoginID.Text = Environment.UserName;    
        }

        /*---------------------------------------------------------------------------*/


        //Timer Events

        private void timer_Tick(object sender, EventArgs e)
        {
            time = time - 1;

            try
            {
                if (time == 0)
                {
                    timer.Enabled = false;
                    time = 4;

                    frm_loading.Close();
                    frm_sysInfo.ShowDialog();
                    return;
                }
            }
            catch { }
               
        }

        /*---------------------------------------------------------------------------*/



        //Notification Events

        private void frm_domain_support_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                notifyIcon.Visible = true;
                e.Cancel = true;
                Hide();
            }
            catch
            {
                errorUnidentifiedMsg();
            }
        }


        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Show();
            }
            catch { }
        }


        private void openDomainSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Show();
            }
            catch { }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(-1);
            }
            catch { }
        }

        
    }
}
