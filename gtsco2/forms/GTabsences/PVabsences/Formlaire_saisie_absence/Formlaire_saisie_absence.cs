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

        public void load(string anne, string sp, string promo , string section, string module, List<forms.eva> data)
        {
            pAnnee.Value = anne;
            pModule.Value = module;
            pPromo.Value = promo;
            pSECTION.Value = section;
            pSpecialite.Value = sp;
            objectDataSource1.DataSource = data;

        }
             

    }
}
