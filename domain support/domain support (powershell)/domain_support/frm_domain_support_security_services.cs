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
    public partial class frm_domain_support_security_services : Form
    {
        public frm_domain_support_security_services()
        {
            InitializeComponent();
        }

        frm_domain_support_details frm_details = new frm_domain_support_details();

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

        static void errorUnidentifiedMsg()
        {
            MessageBox.Show("Unidentified Error!", "Domain Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*---------------------------------------------------------------------------*/

        static void ForeScoutService(Label lblForeScout)
        {
            if (checkService("sc query SecureConnector | find \"RUNNING\"") != "")
            {
                lblForeScout.Text = "Running";
                lblForeScout.ForeColor = Color.Green;
            }
            else
            {
                lblForeScout.Text = "Not Running";
                lblForeScout.ForeColor = Color.Red;
            }

        }

        /*----------------------------*/

       static void SymantecService(Label lblSymantec)
       {

           if (checkService("sc query SepMasterService | find \"RUNNING\"") != "" && checkService("sc query SepScanService | find \"RUNNING\"") != "" && checkService("sc query sepWscSvc | find \"RUNNING\"") != "")
           {
               lblSymantec.Text = "Running";
               lblSymantec.ForeColor = Color.Green;
           }
           else
           {
               lblSymantec.Text = "Not Running";
               lblSymantec.ForeColor = Color.Red;
           }
       }

        /*----------------------------*/

        static void IvantiService(Label lblIvanti)
       {
           if (checkService("sc query \"LANDesk Targeted Multicast\" | find \"RUNNING\"") != "" && checkService("sc query CBA8 | find \"RUNNING\"") != "" && checkService("sc query Softmon | find \"RUNNING\"") != "" && checkService("sc query RCSERVICE | find \"RUNNING\"") != "")
           {
               lblIvanti.Text = "Running";
               lblIvanti.ForeColor = Color.Green;
           }
           else
           {
               lblIvanti.Text = "Not Running";
               lblIvanti.ForeColor = Color.Red;
           }

       }

        /*----------------------------*/

        static void DLPService(Label lblDLP)
       {

         if (checkService("sc query EDPA | find \"RUNNING\"") != "")
           {
               lblDLP.Text = "Running";
               lblDLP.ForeColor = Color.Green;
           }
           else
           {
               lblDLP.Text = "Not Running";
               lblDLP.ForeColor = Color.Red;
           }
       }

        /*----------------------------*/

        static void CortexService(Label lblCortex)
       {
            if (checkService("sc query cyserver | find \"RUNNING\"") != "")
            {
                lblCortex.Text = "Running";
                lblCortex.ForeColor = Color.Green;
            }
            else
            {
                lblCortex.Text = "Not Running";
                lblCortex.ForeColor = Color.Red;
            }
        }

       /*---------------------------------------------------------------------------*/

        private void frm_domain_support_security_services_Load(object sender, EventArgs e)
        {
            try
            {
                ForeScoutService(lblForeScoutStatus);
                SymantecService(lblSymantecStatus);
                IvantiService(lblIvantiStatus);
                DLPService(lblDLPStatus);
                CortexService(lblCortexStatus);
            }
            catch
            {
                errorUnidentifiedMsg();
            }
        }


        private void btnCheckServices_Click(object sender, EventArgs e)
        {
            try
            {
                ForeScoutService(lblForeScoutStatus);
                SymantecService(lblSymantecStatus);
                IvantiService(lblIvantiStatus);
                DLPService(lblDLPStatus);
                CortexService(lblCortexStatus);
            }
            catch
            {
                errorUnidentifiedMsg();
            }
        }

        /*---------------------------------------------------------------------------*/

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frm_details.ShowDialog();
        }

    }
}
