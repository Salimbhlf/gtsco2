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

        

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            form ev = new form();
            ev.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
           
                Cursor = Cursors.WaitCursor; // change cursor to hourglass type
               
                Cursor = Cursors.Arrow; // change cursor to normal type
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            GTabsences.PVabsences.PVabsences ab = new GTabsences.PVabsences.PVabsences();
            ab.ShowDialog();
            
        }

      

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            form ev = new form();
            ev.refrech();
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
            Pageprancipel.FrmPrancipal fr = new Pageprancipel.FrmPrancipal();
            fr.ShowDialog();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            navigation.Form1 fr = new navigation.Form1();
            fr.ShowDialog();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            forms.SplashSacrine.Form1 sa = new SplashSacrine.Form1();
            sa.Show();
            
           
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            Login.FormLogin frm = new Login.FormLogin();
            frm.Show();
        }

        private void addevabtn_Click(object sender, EventArgs e)
        {
            form ev = new form();
            ev.ShowDialog();

        }

        private void evabtn_Click(object sender, EventArgs e)
        {
            
            PVfinal.FrmPVfinal fr = new PVfinal.FrmPVfinal();
            fr.refrech();
            fr.ShowDialog();
        }
    }
}
