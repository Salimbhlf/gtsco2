using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.forms.Page_de_garde
{
    public partial class Pvinstalation : DevExpress.XtraReports.UI.XtraReport
    {
        public Pvinstalation()
        {
            InitializeComponent();
        }
        public static void print(string stg)
        {
            Pvinstalation rpt = new Pvinstalation();
            rpt.load(stg);
            rpt.ShowRibbonPreview();
        }
        public void load(string nstg)
        {
            try
            {
                var qur = from stg in shared.bd.Stagiairs
                          from emp in shared.bd.Employeurs.Where(x => x.ID_Emp == stg.ID_Emp)
                          where stg.Num_STG == nstg
                          select new
                          {
                              nom = stg.Nom_ar + "    " + stg.Prenom_ar,
                              nomEmp = emp.Nom_Emp_ar,
                              numro = stg.Num_Validation_Contrat_STG,

                          };


                foreach (var row in qur.ToList())
                {
                    xrLabel2nom.Text = row.nom;
                    xrLabel1enp.Text = row.nomEmp;
                    xrLabel4nom.Text = row.nom;
                    num.Text = row.numro.ToString();
                }


            }
            catch { }

        }
    }
}
