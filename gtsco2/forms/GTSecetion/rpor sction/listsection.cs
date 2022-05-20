using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.forms.GTSecetion.rpor_sction
{
    public partial class listsection : DevExpress.XtraReports.UI.XtraReport
    {
        public listsection()
        {
            InitializeComponent();
        }
        public static void print(int sec, string section , string promo)
        {
            listsection rpt = new listsection();
            rpt.DataSource = rpt.load(sec);
            rpt.databinding(section,promo);
            rpt.ShowRibbonPreview();

        }

        void databinding(string section , string promo )
        {
            xrLabepromo.Text = promo;
            xrLabel10Secttion.Text = section;
            xrlabelsemstre.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "semastre"));
            xrLabel6fille.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "nbrfille"));
            xrLabel1gr.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "nbrhomme"));
            xrLabel2sp.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sp"));
            xrTableCell7code.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "code"));
            xrTableCell8nom.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "nom"));
            xrTableCell9Prenom.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "prenom"));
        }

        public object load(int sec)
        {
            var qur = from stg in shared.bd.Stagiairs
                      where stg.Section == sec
                      select new
                      {
                          code = stg.Num_STG,
                          nom = stg.Nom,
                          prenom = stg.Prenom,
                          semastre = stg.Section1.Semestre.Designation_Semestre,
                          sp = stg.Promo.Option.Specialite1.Designation_SP+" "+stg.Promo.Option.Designation_Option,
                          nbrfille = (shared.bd.Stagiairs.Where(x=> x.Section == sec && x.Sexe == "Femme").Count()),
                          nbrhomme =(shared.bd.Stagiairs.Where(x => x.Section == sec && x.Sexe == "Homme").Count()),
                          


                          


                      };

            return qur.ToList();




        }
    } 
   
}
