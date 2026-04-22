using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARRENTALBUSINESS
{
    public partial class MDIadmin : Form
    {
        public MDIadmin()
        {
            InitializeComponent();
        }

        private void bOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
			FrmBooking frmBooking = new FrmBooking();
            frmBooking.MdiParent = this;
            frmBooking.Show();

		}

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHomePage frmHomePage = new FrmHomePage();
            frmHomePage.MdiParent = this;
            frmHomePage.Show();
		}
    }
}
