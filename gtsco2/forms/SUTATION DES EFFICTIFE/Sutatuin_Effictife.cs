using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.forms.SUTATION_DES_EFFICTIFE
{
    public partial class Sutatuin_Effictife : DevExpress.XtraReports.UI.XtraReport
    {
        public Sutatuin_Effictife()
        {
            InitializeComponent();
        }



        public void load()
        {
            var qure = from sp in shared.bd.Specialites select new { codesp = sp.Code_SP , id = sp.ID_Specialité };



            foreach(var row in qure.ToList())
            {
                var qures = from section in shared.bd.Sections
                            from op in shared.bd.Options.Where(x => x.ID_Option == section.ID_Option).DefaultIfEmpty()
                            where op.Specialite == row.id
                            select new
                            {
                                codesection = section.Promo.Mode_formation.Code_Mode_Formation+section.Option.Code_Option+section.Promo.Code_Promo +section.Code_Section,
                                semestre = section.Semestre.Designation_Semestre,
                                date_dube = section.Promo.DATE_D_Formation,
                                secture_prive = (shared.bd.Stagiairs.Where(x=> x.Employeur.Type_Emp=="Privé"&&x.Section ==section.SectionID).Count()),
                                secture_prive_fill = (shared.bd.Stagiairs.Where(x => x.Employeur.Type_Emp == "Privé" && x.Section == section.SectionID&&x.Sexe=="Femme").Count()),
                                secture_public =      (shared.bd.Stagiairs.Where(x => (x.Employeur.Type_Emp == "Public" || x.Employeur.Type_Emp == "E.P.A" )&& x.Section == section.SectionID).Count()),
                                secture_public_fill = (shared.bd.Stagiairs.Where(x => (x.Employeur.Type_Emp == "Public" || x.Employeur.Type_Emp == "E.P.A" )&&x.Section == section.SectionID&&x.Sexe=="Femme").Count()),
                                secture_public_Epa = (shared.bd.Stagiairs.Where(x => x.Employeur.Type_Emp == "E.P.A" && x.Section == section.SectionID).Count()),
                                secture_public_epa_fill= (shared.bd.Stagiairs.Where(x => x.Employeur.Type_Emp == "E.P.A" && x.Section == section.SectionID&&x.Sexe =="Femme").Count()),
                                secture2 = (shared.bd.Stagiairs.Where(x =>  x.Section == section.SectionID).Count()),
                                secture2_fill= (shared.bd.Stagiairs.Where(x =>  x.Section == section.SectionID && x.Sexe=="Femme").Count())





                            };
                

            }

         
        }



    }
}
