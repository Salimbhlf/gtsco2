using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace gtsco2.forms.GTabsences.PVabsences.Formlaire_saisie_absence.etat_absence
{
    public partial class reportabsonce : DevExpress.XtraReports.UI.XtraReport
    {
        public reportabsonce()
        {
            InitializeComponent();
        }
        void binddata(string SEC, string SEM, DateTime DATEED, DateTime DATEEF ,string promo,string sp)
        {
            pSection.Value = SEC;
            pSemestre.Value = SEM;
            pDated.Value = DATEED;
            pDateF.Value = DATEEF;
            pPromo.Value = promo;
            pSpecialite.Value = sp;


            //affecte des valuer sur le table de raport
            xrnam.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Nom_et_Prenom"));

            xrseance.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Nombre_dabsences_par_séance"));
            xrabsoncenj.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Absences_non_justfer"));
            xrabsjourJ.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Absences_justef"));
           XROPS.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "OBS"));
        }
        public static void print(object ds,string SEC,string SEM, DateTime DATEED , DateTime DATEEF , string promo ,string sp)
        {
            reportabsonce rpt = new reportabsonce();
            rpt.DataSource = ds;
           
            rpt.binddata(SEC,SEM,DATEED,DATEEF,promo , sp);
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
                p.Visible = false;


                rpt.ShowRibbonPreview();
           


        }

    }
}
