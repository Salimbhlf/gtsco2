using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using gtsco2.classe;
using System.Linq;

namespace gtsco2.forms.Formulaire.certficat
{
    public partial class ReportCertficat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportCertficat()
        {
            InitializeComponent();
        }

        private void xrTableCell83_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        public static void  printCertficat(string Num_stgg)
        {
            ReportCertficat rpt = new ReportCertficat();

            rpt.load(Num_stgg);
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
                p.Visible = false;




            rpt.ShowRibbonPreview();
            
        }

        public void load(string Num_stg)
        {
            var qure = from stg in shared.bd.Stagiairs
                       from sec in shared.bd.Sections.Where( x=> x.SectionID == stg.Section).DefaultIfEmpty()
                       from sem in shared.bd.Semestres.Where(x => x.ID_Semestre == sec.Semestre_en_coure).DefaultIfEmpty()
                       join promo in shared.bd.Promoes on stg.ID_Promo equals promo.ID_Promo
                       from anne in shared.bd.annee_scolaire.Where(x => x.ID_Année_SCO == sec.Annee_secolir_en_coure).DefaultIfEmpty()

                       join mod in shared.bd.Mode_formation on promo.Mode_de_formation equals mod.ID_Mode_Formation
                       join ops in shared.bd.Options on promo.ID_Option equals ops.ID_Option
                       join sp in shared.bd.Specialites on ops.Specialite equals sp.ID_Specialité
                       from comun in shared.bd.Communes.Where(x => x.Commune_id == stg.Lieu_Naissance).DefaultIfEmpty()
                       where stg.Num_STG == Num_stg
                       select new
                       {
                           Numro = stg.Num_STG,
                           nom = stg.Nom_ar,
                           prenom = stg.Prenom_ar,
                           date_niss = stg.Date_de_Naissance,
                           lieu_niss = comun.Commune_name_ar,
                           sp = (sp.Designation_SP_AR + "  تخصص " + ops.Designation_Option_ar),
                           date_dF = promo.DATE_D_Formation,
                           date_finF = promo.Date_F_Formation,
                           semestre = sem.Designation_Semestre_ar,
                           date_dube_sem = anne.DATE_D_Année_SCO,
                           date_fin_sem = anne.Date_F_Année_SCO,
                           annee_scolaire = anne.Designation,
                           MofeFormation = mod.Désignation_Mode_Formation_ar
                       };


            foreach(var row in qure.ToList())
            {
                Numrostg.Value = row.Numro;
                nom.Value = row.nom;
                prenom.Value = row.prenom;
                dateniss.Value = row.date_niss;
                lieuniss.Value = row.lieu_niss;
                specalite.Value = row.sp;
                dateDfromation.Value = row.date_dF;
                dateFformation.Value = row.date_finF;
                sememstr.Value = row.semestre;
                dateDubeSem.Value = row.date_dube_sem;
                DateFInsem.Value = row.date_fin_sem;
                Anneescoliar.Value = row.annee_scolaire;
                modef.Value = row.MofeFormation;

            }



        }
    }
}
