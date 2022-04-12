using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.forms.Page_de_garde
{
    public partial class autirisationDeatude : DevExpress.XtraReports.UI.XtraReport
    {
        public autirisationDeatude()
        {
            
            InitializeComponent();
            
        }
        public static void print(string Nstg, string jour1, string jour2)
        {
            autirisationDeatude rpt = new autirisationDeatude();
            rpt.load(Nstg, jour1, jour2);
            rpt.ShowRibbonPreview();
        }

        public void load(string Nstg , string jour1 , string jour2)

        {
            try
            {
                var qur = from stg in shared.bd.Stagiairs
                          from emp in shared.bd.Employeurs.Where(x => x.ID_Emp == stg.ID_Emp)
                          where stg.Num_STG == Nstg
                          select new
                          {
                              nom = stg.Nom + "  " + stg.Prenom,
                              nomEmp = emp.Nom_Emp,

                          };

                foreach (var row in qur.ToList())
                {
                    xrLabel6nom.Text = row.nom;
                    xrLabel3stg.Text = row.nom;
                    xrLabel5enp.Text = row.nomEmp;
                    xrLabelemp.Text = row.nomEmp;

                }
                xrLabel1J1.Text = jour1;
                xrLabel8J1.Text = jour1;
                xrLabel2J2.Text = jour2;
                xrLabel7J2.Text = jour2;
            }
            catch
            {

            }
        }
    }
}
