using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.navigation
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        public void overirform(Form frm)
        {
            forms.Pageprancipel.FrmPrancipal fr = new forms.Pageprancipel.FrmPrancipal();
            bool rz = false;
            foreach (Form f in Application.OpenForms)
            {

                if (fr.Text == f.Text)
                {
                    fr.opfrm(frm);
                    rz = true;
                    break;
                }


            }
            if (rz == false)
            {
                fr.Show();
                this.Close();
                forms.navigation.Form1 nf = new forms.navigation.Form1();
                nf.MdiParent = forms.Pageprancipel.FrmPrancipal.ActiveForm;
                nf.Show();
                fr.opfrm(frm);

            }
        }

        private void tileItem11_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            overirform(new mvvm.Views.StagiairCollectionView.StagiairCollectionView());
            //fr.ShowDialog();
        }
    }
}