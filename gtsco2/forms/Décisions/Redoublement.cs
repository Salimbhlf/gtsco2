using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using gtsco2.classe;
using System.Linq;

namespace gtsco2.forms.Décisions
{
    public partial class Redoublement : DevExpress.XtraReports.UI.XtraReport
    {
        public Redoublement()
        {
            InitializeComponent();
        }

        public static void load(string v1 , string v2 , string v3 , string v4)
        
        {
            
            gtsco2.forms.Décisions.Redoublement frm = new Décisions.Redoublement();
            

            frm.STG(v1,v2,v3,v4);
            frm.ShowPreviewDialog();
            
        }
        public void STG(string v1, string v2, string v3, string v4)
        {

            //var qur = from dis in shared.bd.Decisions
            //          join stg in shared.bd.Stagiairs on dis.Num_STG equals stg.Num_STG
            //          join sem in shared.bd.Semestres on dis.ID_Semestre equals sem.ID_Semestre
            //          join promo in shared.bd.Promoes on dis.ID_Promo equals promo.ID_Promo
            //          join ops in shared.bd.Options on promo.ID_Option equals ops.ID_Option
            //          join sp in shared.bd.Specialites on ops.Specialite equals sp.ID_Specialité
            //          join pv in shared.bd.Proce_verbal_delibation on dis.ID_PV_Délibiration equals pv.ID_PV_Délibiration
            //          where dis.ID_Decision == cle
            //          select new
            //          {
            //              nom = (stg.Nom_ar + " " + stg.Prenom_ar),
            //              sps = sp.Designation_SP_AR + " اختصاص " + ops.Designation_Option_ar,
            //              smstr = sem.Designation_Semestre_ar,
            //              datepv = pv.Date_PV_Délibiration,
            //              numcont = stg.Num_Validation_Contrat_STG,
            //              datevalidation = stg.Date_Validation_Contrat_STG

            //          };
            //foreach (var row in qur.ToList())
            //{

            //    labe1.Text = ("-نـظرا للمحضـر المـــؤرخ يـوم " + row.datevalidation.Value.ToString("dd/MM/yyyy")
            //        + " تحت رقـــم " + row.numcont + " والمتضمـن فتــح فــرع تـقنـي ســامي فــي اختصــاص ألمعلوماتية خيار قاعدة المعطيات  ");

            //    xrLabel2.Text = ("- وتبـعـــا لقـــرار محضــر اجتمــاع مجلــس الأساتــذة المنعقد يوم" + row.datepv.Value.ToString("dd/MM/yyyy"));

            //    label03.Text = ("المـادة الأولـى : يعـيـــد المتمهن  " + row.nom + "(" + " السداسي "+row.smstr + ")");
            //    labelsp04.Text = row.sps;
            //}
            labe1.Text = v1;
            xrLabel2.Text = v2;
            label03.Text = v3;
            labelsp04.Text = v4;



        }

    }
}
