using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.forms.Décisions
{
    public partial class Transfert : DevExpress.XtraReports.UI.XtraReport
    {
        public Transfert()
        {
            InitializeComponent();
        }
        public static void printtrnsfer(string stgP, int idEmp)
        {
            Transfert rpt = new Transfert();
            rpt.load(stgP, idEmp);
            rpt.ShowRibbonPreview();
        }

        public void load(string stgP , int idEmp)
        {
          
            var qur = from trns in shared.bd.Transferers 
                      join stg in shared.bd.Stagiairs on trns.num_stg equals stg.Num_STG
                      join etp in shared.bd.Etablissements on  trns.ID_etb equals etp.ID_ETAB
                      from emp in shared.bd.Employeurs.Where(x=>x.ID_Emp ==stg.ID_Emp).DefaultIfEmpty()
                      where trns.num_stg == stgP where trns.ID_etb== idEmp

                      select new
                      
                      {
                          nom = (stg.Nom_ar + " " + stg.Prenom_ar),
                          trns.date_transfert,
                          nometp= etp.Nom_ETAB_ar
                          
                          ,stg.Date_Validation_Contrat_STG,
                          stg.Num_Validation_Contrat_STG,
                          emp.Nom_Emp_ar,
                          comEmp =emp.Code_Postal.Commune.Commune_name_ar,
                          numcont = stg.Num_Validation_Contrat_STG,
                          datevalidation = stg.Date_Validation_Contrat_STG

                      };

            try { 
            foreach (var row in qur.ToList()) {
                    xrLabel1.Text = ("- نـظرا لموافقة مدير " + row.nometp);
                label6.Text = ("المـادة الأولى :  يحول المتمهن  " + row.nom.ToString());
                try
                {
                    label8.Text = (" إبـتـداءا مـن   " + row.date_transfert.Value.ToString("dd/MM/yyyy"));
                    label17.Text = ("المـصــادق علـيـه في " + row.datevalidation.Value.ToString("dd/MM/yyyy"));
                }
                catch { }
                label18.Text = ("تحت رقم  " + row.Num_Validation_Contrat_STG);
                label19.Text = ("الذي يـربـط  المتمـهـن " + row.nom);
                label20.Text = ("بالمـسـتـخـدم " + row.Nom_Emp_ar);
                label21.Text = (row.comEmp);





                }
            }
            catch { }
        }
      

    }
}
