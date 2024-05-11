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
    public partial class frm_domain_support_about : Form
    {

        public frm_domain_support_about()
        {
            InitializeComponent();
        }

        private void lblAuthorMir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://rahedmir.com");
            }
            catch{}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
