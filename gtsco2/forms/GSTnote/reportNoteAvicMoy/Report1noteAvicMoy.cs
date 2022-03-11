using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace gtsco2.forms.GSTnote.reportNoteAvicMoy
{
    public partial class Report1noteAvicMoy : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1noteAvicMoy()
        {
            InitializeComponent();
          
        }
        public void binding(string anne, string sp, string promo, string section, string module, List<forms.eva> data, string ens)
        {
            pEnseignant.Value = ens;
            pAnnee.Value = anne;
            pModule.Value = module;
            pPromo.Value = promo;
            pSECTION.Value = section;
            pSpecialite.Value = sp;
            objectDataSource1.DataSource = data;
        }
        public  static void load(string anne, string sp, string promo , string section, string module, List<forms.eva> data,string ens)
        {
            Report1noteAvicMoy rpt = new Report1noteAvicMoy();
            rpt.binding(anne, sp, promo, section, module, data, ens);
            rpt.DataSource = data;
            
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
                p.Visible = false;


            

            rpt.ShowRibbonPreview();


        }
             

    }
}
