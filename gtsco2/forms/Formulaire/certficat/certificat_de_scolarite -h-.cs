using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using gtsco2.classe;
using System.Linq;

namespace gtsco2.forms.Formulaire.certficat
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void xrTableCell83_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        public void load(string Num_stg)
        {
            var qure = from stg in shared.bd.Stagiairs
                       join sec in shared.bd.Sections on stg.Section equals sec.SectionID
                       join sem in shared.bd.Semestres on sec.Semestre_en_coure equals sem.ID_Semestre
                       join promo in shared.bd.Promoes on stg.ID_Promo equals promo.ID_Promo
                       join anne in shared.bd.annee_scolaire on sec.Annee_secolir_en_coure equals anne.ID_Année_SCO

                       join mod in shared.bd.Mode_formation on promo.Mode_de_formation equals mod.ID_Mode_Formation
                       join ops in shared.bd.Options on promo.ID_Option equals ops.ID_Option
                       join sp in shared.bd.Specialites on ops.Specialite equals sp.ID_Specialité
                       join comun in shared.bd.Communes on stg.Lieu_Naissance equals comun.Commune_id
                       where stg.Num_STG == Num_stg
                       select new
                       {
                           Numro = stg.Num_STG,
                           nom = stg.Nom_ar,
                           prenom = stg.Prenom_ar,
                           date_niss = stg.Date_de_Naissance,
                           lieu_niss = comun.Commune_name_ar,
                           sp = (sp.Designation_SP_AR + "  option " + ops.Designation_Option_ar),
                           date_dF = promo.DATE_D_Formation,
                           date_finF = promo.Date_F_Formation,
                           semestre = sem.Designation_Semestre_ar,
                           data_dube_sem = anne.DATE_D_Année_SCO,
                           date_fin_sem =anne.Date_F_Année_SCO,
                           annnee_scolaire =anne.Designation
                       };



        }
    }
}
