using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.Pageprancipel
{
    public partial class FrmPrancipal : DevExpress.XtraEditors.XtraForm
    {
        public FrmPrancipal()
        {
            InitializeComponent();
            //opfrm(new forms.navigation.Form1());
              
        }
        

        public void opfrm(Form fs)
        {
            bool isopens = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == fs.Text)
                {
                    isopens = true;
                    f.Focus();
                }
            }
            if (isopens == false)
            {

                fs.MdiParent = FrmPrancipal.ActiveForm;
                fs.Show();
            }
        }

        private void barButtonItemstgiaire_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.StagiairCollectionView.StagiairCollectionView());
        }

        private void barButtonItemAddnote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new forms.form());
        }

        private void barButtonItem1PvNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new forms.PVfinal.FrmPVfinal());
        }

        private void barButtonItemAddABS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new forms.GTabsences.addabsences());
        }

        private void barButtonItemPvAbs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new forms.GTabsences.PVabsences.PVabsences());
        }

        private void barButtonItemModeF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.Mode_formationCollectionView.Mode_formationCollectionView());
        }

        private void barButtonItem1Bronch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.BranchCollectionView.BranchCollectionView());
        }

        private void barButtonItem5Specailite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.SpecialiteCollectionView.SpecialiteCollectionView());
        }

        private void barButtonItem6Option_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.OptionCollectionView.OptionCollectionView());
        }

      

        private void barButtonItem1Semestre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.SemestreCollectionView.SemestreCollectionView());
        }

        private void barButtonItem5Anne_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.annee_scolaireCollectionView.annee_scolaireCollectionView());
        }

        private void barButtonItem1Soiver_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.Suiver_stagiaireCollectionView.Suiver_stagiaireCollectionView());
        }

        private void barButtonItem1Employeur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.EmployeurCollectionView.EmployeurCollectionView());
        }

        private void barButtonItemMaitre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.Maitre_ApprentissageCollectionView.Maitre_ApprentissageCollectionView());
        }

       

        private void barButtonItem1Evaluation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.EvaluationCollectionView.EvaluationCollectionView());
        }

        private void barButtonItem1ABS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.AbsenceCollectionView.AbsenceCollectionView());
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new navigation.Form1());
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1Module_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.ModuleCollectionView.ModuleCollectionView());
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.EnseignantCollectionView.EnseignantCollectionView());
        }

        private void barButtonItem8Titeur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.tuteurCollectionView.tuteurCollectionView());
        }

        private void barButtonItem9Etablissement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.EtablissementCollectionView.EtablissementCollectionView());
        }

        private void barButtonItem8ContractAvnCHongment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.Contract_avenant_changementCollectionView.Contract_avenant_changementCollectionView());
        }

        private void barButtonItem9AvenantProrgation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.Avenant_contrat_prorogationCollectionView.Avenant_contrat_prorogationCollectionView());
        }

        private void barButtonItem8ProceVerbale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.Proce_verbal_delibationCollectionView.Proce_verbal_delibationCollectionView());
        }

        private void barButtonItem9ParticpePV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.PARTICIPECollectionView.PARTICIPECollectionView());
        }

        private void barButtonItem8Promo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.PromoCollectionView.PromoCollectionView()); 
        }

        private void barButtonItem8Section_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.SectionCollectionView.SectionCollectionView());
        }

        private void barButtonItem8_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.DecisionCollectionView.DecisionCollectionView());
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CnxDataBase.FrmCnxDataBase frm =new CnxDataBase.FrmCnxDataBase();
            frm.ShowDialog();

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.Views.TransfererCollectionView.TransfererCollectionView());
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opfrm(new mvvm.user.Views.UserCollectionView.UserCollectionView());
        }
    }
}
