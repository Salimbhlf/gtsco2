using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
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
        public void bandingdata()
        {
            xrTabletoutal_preve.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture_prive"));
            xrTableprive_fill.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture_prive_fill"));
            xrTablepublic_t.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture_public"));
            xrTablpublic_fill.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture_public_fill"));
            xrTablepublic_epa.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture_public_epa"));
            xrTablepublic_epa_fill.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture_public_epa_fill"));
           
            xrTable_toutal_g.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture2"));
            xrTabletoutal_g_fill.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "secture2_fill"));

            xrTableCellsp.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "speclite"));
            xrTableCellniveua.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "naive"));
            xrTableCellcodesp.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "codespeclite"));
            xrTableCellsection.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "codesection"));
            xrTableCelldatadube.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "datedube"));
            xrTableCell22.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "semestre"));





        }

        public static void printsutation_effictife()
        {
            Sutatuin_Effictife rpt = new Sutatuin_Effictife();
            object dt = rpt.load();
            rpt.DataSource = dt;



            rpt.TOUTAL(dt as DataTable) ;
            rpt.bandingdata();

            rpt.ShowRibbonPreview();

        }

        public void TOUTAL(DataTable AB)
        { int secture_prive = 0;
            int secture_prive_fill = 0;
            int secture_public = 0;
            int secture_public_fill = 0;
            int secture_public_Epa = 0;
            int secture_public_epa_fill = 0;
            int secture2 = 0;
            int secture2_fill = 0;
            foreach (DataRow ROW in AB.Rows )
                    {
                secture_prive += int.Parse(ROW["secture_prive"].ToString());
                secture_prive_fill += int.Parse(ROW["secture_prive_fill"].ToString());
                secture_public += int.Parse(ROW["secture_public"].ToString());
                secture_public_fill += int.Parse(ROW["secture_public_fill"].ToString());
                secture_public_Epa += int.Parse(ROW["secture_public_Epa"].ToString());
                secture_public_epa_fill += int.Parse(ROW["secture_public_epa_fill"].ToString());

                secture2 += int.Parse(ROW["secture2"].ToString());
                secture2_fill += int.Parse(ROW["secture2_fill"].ToString());
            }
            xrTableCell27.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture_prive.ToString()));
            xrTableCell28.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture_prive_fill.ToString()));
            xrTableCell29.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture_public.ToString())); 
            xrTableCell30.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture_public_fill.ToString()));
            xrTableCell31.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture_public_Epa.ToString()));
            xrTableCell32.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture_public_epa_fill.ToString()));
            xrTableCell33.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture2.ToString()));
            xrTableCell34.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", secture2_fill.ToString()));



        }
        public  object load()
        {
            var qure = from sp in shared.bd.Specialites select new { codesp = sp.Code_SP , id = sp.ID_Specialité  ,naive = sp.Niveau_qualification};

            DataTable tb1 = new DataTable();

            tb1.Columns.Add("codespeclite");
            tb1.Columns.Add("speclite");
            tb1.Columns.Add("codesection");
            tb1.Columns.Add("semestre");
            
            tb1.Columns.Add("datedube");
            tb1.Columns.Add("secture_prive");
            tb1.Columns.Add("secture_prive_fill");
            tb1.Columns.Add("secture_public");
            tb1.Columns.Add("secture_public_fill");
            tb1.Columns.Add("secture_public_Epa");
            tb1.Columns.Add("secture_public_epa_fill");
            tb1.Columns.Add("naive");
            
            tb1.Columns.Add("secture2");
            tb1.Columns.Add("secture2_fill");

            foreach (var row in qure.ToList())
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
                                secture2_fill= (shared.bd.Stagiairs.Where(x =>  x.Section == section.SectionID && x.Sexe=="Femme").Count()),
                                sp =op.Designation_Option





                            };


                foreach (var row1 in qures.ToList())
                {
                    DataRow datarow = tb1.NewRow();
                    datarow["codespeclite"] = row.codesp;
                    datarow["codespeclite"] = row1.sp;
                    datarow["codesection"] = row1.codesection;
                    datarow["semestre"] = row1.semestre;
                    try { 
                    datarow["datedube"] = row1.date_dube.Value.ToString("MM/dd/yyyy");
                    }
                    catch { }
                    datarow["secture_prive"] = row1.secture_prive;
                    datarow["naive"] = row.naive;
                    datarow["secture_prive_fill"] = row1.secture_prive_fill;

                    datarow["secture_public"] = row1.secture_public;
                    datarow["secture_public_fill"] = row1.secture_public_fill;

                    datarow["secture_public_Epa"] = row1.secture_public_Epa;

                    datarow["secture_public_epa_fill"] = row1.secture_public_epa_fill;
                    datarow["secture2"] = row1.secture2;
                    datarow["secture2_fill"] = row1.secture2_fill;

                    tb1.Rows.Add(datarow);
                       




                }

                






            }

            return tb1;
        }



    }
}
