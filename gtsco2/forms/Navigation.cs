using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms
{
    public partial class Navigation : DevExpress.XtraEditors.XtraForm
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            form ev = new form();
            ev.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            GTabsences.PVabsences.PVabsences ab = new GTabsences.PVabsences.PVabsences();
            ab.ShowDialog();
            
        }

      

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            form ev = new form();
            ev.ShowDialog();

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            GTabsences.addabsences ab = new GTabsences.addabsences();
            ab.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
           using( GTSecetion.GTsectionfrm frm = new GTSecetion.GTsectionfrm())
            {
                
                frm.ShowDialog();

            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {

        }

        private void addevabtn_Click(object sender, EventArgs e)
        {
            form ev = new form();
            ev.ShowDialog();

        }

        private void evabtn_Click(object sender, EventArgs e)
        {
            PVfinal.FrmPVfinal fr = new PVfinal.FrmPVfinal();
            fr.ShowDialog();
        }
    }
}
