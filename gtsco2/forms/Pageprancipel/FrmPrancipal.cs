﻿using System;
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
    }
}
