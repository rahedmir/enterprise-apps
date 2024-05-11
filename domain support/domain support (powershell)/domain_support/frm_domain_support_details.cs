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
    public partial class frm_domain_support_details : Form
    {
        public frm_domain_support_details()
        {
            InitializeComponent();
        }

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

        private void frm_domain_support_details_Load(object sender, EventArgs e)
        {
            try
            {
                if (checkService("sc query SecureConnector | find \"RUNNING\"") != "")
                {
                    txtSecureConnector.Text = "SecureConnector is running";
                    txtSecureConnector.ForeColor = Color.Green;
                }
                else
                {
                    txtSecureConnector.Text = "SecureConnector is not running";
                    txtSecureConnector.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query SepMasterService | find \"RUNNING\"") != "")
                {
                    txtSepMasterService.Text = "SepMasterService is running";
                    txtSepMasterService.ForeColor = Color.Green;
                }
                else
                {
                    txtSepMasterService.Text = "SepMasterService is not running";
                    txtSepMasterService.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query SepScanService | find \"RUNNING\"") != "")
                {
                    txtSepScanService.Text = "SepScanService is running";
                    txtSepScanService.ForeColor = Color.Green;
                }
                else
                {
                    txtSepScanService.Text = "SepScanService is not running";
                    txtSepScanService.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query sepWscSvc | find \"RUNNING\"") != "")
                {
                    txtSepWscSvc.Text = "sepWscSvc is running";
                    txtSepWscSvc.ForeColor = Color.Green;
                }
                else
                {
                    txtSepWscSvc.Text = "sepWscSvc is not running";
                    txtSepWscSvc.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query \"LANDesk Targeted Multicast\" | find \"RUNNING\"") != "")
                {
                    txtLANDeskTargetedMulticast.Text = "LANDesk Targeted Multicast is running";
                    txtLANDeskTargetedMulticast.ForeColor = Color.Green;
                }
                else
                {
                    txtLANDeskTargetedMulticast.Text = "LANDesk Targeted Multicast is not running";
                    txtLANDeskTargetedMulticast.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query CBA8 | find \"RUNNING\"") != "")
                {
                    txtCBA8.Text = "CBA8 is running";
                    txtCBA8.ForeColor = Color.Green;
                }
                else
                {
                    txtCBA8.Text = "CBA8 is not running";
                    txtCBA8.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query Softmon | find \"RUNNING\"") != "")
                {
                    txtSoftmon.Text = "Softmon is running";
                    txtSoftmon.ForeColor = Color.Green;
                }
                else
                {
                    txtSoftmon.Text = "Softmon is not running";
                    txtSoftmon.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query RCSERVICE | find \"RUNNING\"") != "")
                {
                    txtRCSERVICE.Text = "RCSERVICE is running";
                    txtRCSERVICE.ForeColor = Color.Green;
                }
                else
                {
                    txtRCSERVICE.Text = "RCSERVICE is not running";
                    txtRCSERVICE.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query EDPA | find \"RUNNING\"") != "")
                {
                    txtEDP.Text = "EDPA is running";
                    txtEDP.ForeColor = Color.Green;
                }
                else
                {
                    txtEDP.Text = "EDPA is not running";
                    txtEDP.ForeColor = Color.Red;
                }

                /*------------------------------*/

                if (checkService("sc query cyserver | find \"RUNNING\"") != "")
                {
                    txtCyserver.Text = "cyserver is running";
                    txtCyserver.ForeColor = Color.Green;
                }
                else
                {
                    txtCyserver.Text = "cyserver is not running";
                    txtCyserver.ForeColor = Color.Red;
                }
            }
            catch { }
        }

    }
}
