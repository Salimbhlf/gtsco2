using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace gtsco2.forms.GTabsences.PVabsences.Formlaire_saisie_absence
{
    public partial class Formlaire_saisie_absence : DevExpress.XtraReports.UI.XtraReport
    {
        public Formlaire_saisie_absence()
        {
            InitializeComponent();
          
        }
        void binding(DateTime dated, DateTime datef, string sem, string section, string promo,string jour1,string jour2)
        {
            pSemestre.Value = sem;
            pSECTION.Value = section;
            pPromo.Value = promo;
            pDated.Value = dated;
            pDatef.Value = datef;

            xrTableCell11.Text = jour1;
            xrTableCell12.Text = jour2;
            xrTableCell13.Text = jour1;
            xrTableCell16.Text = jour2;
            xrTableCell17.Text = jour1;
            xrTableCell15.Text = jour2;
            xrTableCell14.Text = jour1; 
            xrTableCell18.Text = jour2;


            xrTableCell46.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Nom_et_Prenom"));
        }

        public static void  load(DateTime dated, DateTime datef, string sem, string section, string promo, string jour1, string jour2, object data)
        {
            Formlaire_saisie_absence rpt = new Formlaire_saisie_absence();
            rpt.DataSource = data;
            rpt.binding(dated, datef, sem, section, promo, jour1, jour2);
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
                p.Visible = false;


            rpt.ShowRibbonPreview();



        }
             

    }
}
