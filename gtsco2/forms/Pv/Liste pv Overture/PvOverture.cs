using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using gtsco2.classe;
using System.Linq;

namespace gtsco2.forms.Pv.Liste_pv_Overture
{
    public partial class PvOverture : DevExpress.XtraReports.UI.XtraReport
    {
        public PvOverture()
        {
            InitializeComponent();
        }
        public void databinding()
        {
            xrTableCell19numro.ExpressionBindings.Add(new ExpressionBinding("Text", "code"));
            xrTableCell18nom.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "nom"));
            xrTableCell17datelieuNas.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "dataniss"));
            xrTableCell16Niveu.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "niveu"));
            xrTableCell15Prenompare.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "prenompere"));
            xrTableCell13Emp.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "emp"));
            xrTableCell14NOmMre.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "nommare"));
            xrTableCell12Adress.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "aderss"));






        }
        public static void print(int promo)
        {
            PvOverture frm = new PvOverture();
            frm.DataSource = frm.load(promo);
            frm.databinding();
            frm.ShowRibbonPreview();
        }
        public object load(int promo)
        {
            var qur = from stg in shared.bd.Stagiairs
                      where stg.ID_Promo == promo
                      select new
                      {
                          code = stg.Num_STG,
                          nom = stg.Nom_ar + " " + stg.Prenom_ar,
                          dataniss = stg.Date_de_Naissance+" "+    stg.Commune.Commune_name_ar  ,     
                          
                        
                          niveu = stg.Nivo_SCO_ar,
                          nommare = stg.Nom_Mère_STG_ar + " " + stg.Prenom_Mère_STG_ar,
                          prnompere = stg.Prenom_Père_STG_ar,
                          emp = stg.Employeur.Nom_Emp_ar + " " + stg.Employeur.Code_Postal.Commune.Commune_name_ar,
                          aderss = stg.Adresse + " " + stg.Code_Postal1.Commune.Commune_name_ar


                      };
            return qur.ToList();
        }
    }
}
