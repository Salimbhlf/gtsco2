using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using gtsco2.classe;
using System.Linq;

namespace gtsco2.forms.Pv.Page_de_garde_PV_d_ouverture
{
    public partial class Page_de_garde_PV_d_ouverture : DevExpress.XtraReports.UI.XtraReport
    {
        public Page_de_garde_PV_d_ouverture()
        {
            InitializeComponent();
        }

        public static  void print (int promo)
        {
            Page_de_garde_PV_d_ouverture rpt = new Page_de_garde_PV_d_ouverture();
            rpt.load(promo);
            rpt.ShowRibbonPreview();
        }

        public void load(int promo)
        {
            var qur = from pro in shared.bd.Promoes
                      where pro.ID_Promo == promo
                      select new
                      {
                          sp = (pro.Option.Specialite1.Designation_SP_AR + "/ خيار: " + pro.Option.Designation_Option_ar),
                          code_sp = pro.Option.Specialite1.Branch.Code_Branche + pro.Option.Specialite1.Code_SP,
                          bronch = pro.Option.Specialite1.Branch.Designation_Branche_ar,
                          niveu = pro.Option.Specialite1.Niveau_qualification,
                          dateDube = pro.DATE_D_Formation,
                          dateFin = pro.Date_F_Formation,
                          nbrstg = (shared.bd.Stagiairs.Where(x => x.ID_Promo == promo)).Count(),
                          nbrStgFille = (shared.bd.Stagiairs.Where(x => x.ID_Promo == promo && x.Sexe == "Femme")).Count(),
                          nberStgHond = (shared.bd.Stagiairs.Where(x => x.ID_Promo == promo && x.Handicape == true)).Count(),
                          mode = pro.Mode_formation.Désignation_Mode_Formation_ar,
                      };

            foreach (var row in qur.ToList()) {
                xrLabel10Sp.Text = row.sp;
                xrLabel31branch.Text = row.bronch;
                xrLabel10niveu.Text = "........" + row.niveu + ".......";
                xrLabel24codesp.Text = row.code_sp        ;
                try { 
                xrLabel25dateDube.Text = row.dateDube.Value.ToString("dd/MM/yyyy");
                xrLabel28Datefin.Text = row.dateFin.Value.ToString("dd/MM/yyyy");
                }
                catch { }
                xrLabel6mode.Text = "( " + row.mode + " )";
                if(row.nbrstg!=0)
                xrLabel26Nstg.Text = "........" + row.nbrstg + ".......";

                if (row.nbrStgFille != 0)
                    xrLabel27NstgFille.Text = "........" + row.nbrStgFille + ".......";

                if (row.nberStgHond != 0)
                    xrLabel30NstgHond.Text = "........" + row.nberStgHond + ".......";

            }
        }
    }
}
