using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace gtsco2.forms.GSTnote.reportnote
{
    public partial class Report1note : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1note()
        {
            InitializeComponent();
          
        }

        public void load(string anne, string sp, string promo , string section, string module, List<forms.eva> data, string ens)
        {
            pEnseignant.Value = ens;
            pAnnee.Value = anne;
            pModule.Value = module;
            pPromo.Value = promo;
            pSECTION.Value = section;
            pSpecialite.Value = sp;
            objectDataSource1.DataSource = data;

        }
             

    }
}
