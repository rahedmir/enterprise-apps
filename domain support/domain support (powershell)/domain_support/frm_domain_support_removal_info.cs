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
    public partial class frm_domain_support_removal_info : Form
    {
        public frm_domain_support_removal_info()
        {
            InitializeComponent();
        }

        frm_domain_support_domain_removal frm_removal = new frm_domain_support_domain_removal();

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_removal.ShowDialog();
        }
    }
}
