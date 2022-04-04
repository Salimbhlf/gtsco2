using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using gtsco2.classe;
using System.Data;


namespace gtsco2.forms.Bulletin_Semestriel
{
    public partial class Bulletin : DevExpress.XtraReports.UI.XtraReport
    {
        public Bulletin()
        {
            InitializeComponent();
        }

        public static void printBulletin (int idsem, int idannee, int idsec, string nustg)
        {
            Bulletin rpt = new Bulletin();
            object dt =rpt.load(idsem, idannee, idsec, nustg);
            rpt.DataSource = dt;
            
            rpt.banding();

            rpt.ShowPreviewDialog();

        }
        public void banding()
        {
            

            xrTableCellMatieres.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Module"));
            xrTableCellOpservation.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Obs"));
            xrTableCellCoefficient.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Coff"));
            xrTableCellNoterElim.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Noteelim"));
            xrTableCellMoy.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Moy"));
        }
        public object load( int idsem , int idannee ,int idsec, string nustg)
        {
            
            var qure = from eva in shared.bd.Evaluations
                       join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                       join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                       join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                       from com in shared.bd.Communes.Where(x=> x.Commune_id == stg.Lieu_Naissance).DefaultIfEmpty()
                       where eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec && stg.Num_STG == nustg
                       select new
                       {
                           Numro_STG = eva.Num_STG,

                           Nom= (stg.Nom ),
                           Prenom = stg.Prenom,
                           codeStg = stg.Num_STG,
                           datenissance = stg.Date_de_Naissance,
                           lieuNissance = com.Commune_name+" "+com.Willaya.Wilaya_name__fr_,
                           datedeube = stg.Promo.DATE_D_Formation,
                           datefin = stg.Promo.Date_F_Formation,

                           sp = stg.Section1.Option.Specialite1.Designation_SP+" Option "+stg.Section1.Option.Designation_Option,
                           section = stg.Section1.Mode_formation.Code_Mode_Formation+stg.Section1.Option.Code_Option+stg.Section1.Promo.Code_Promo+" "+stg.Section1.Code_Section,
                           modeformation = stg.Section1.Mode_formation.Désignation_Mode_Formation,

                           mynav = eva.Moyenne_Module_AvRt,
                           mynap = eva.Moyenne_Module_ApRt,
                           coefficient_Module = modul.coefficient_Module,
                         
                           module =  modul.Designation_Module ,
                           NoteElim= modul.Note_Elim_Module ,
                           

                       };


            DataTable tb1 = new DataTable();
            tb1.Columns.Add("Module");

            tb1.Columns.Add("Moy");
            tb1.Columns.Add("Coff");
            tb1.Columns.Add("Noteelim");
            tb1.Columns.Add("Obs");
            double TNote = 0;
            int coff = 0;
            foreach (var row in qure.ToList())
            {
                DataRow drow = tb1.NewRow();
                drow["Module"] = row.module;
                double der=0;
                int cofl = 0;
                if (row.mynap != null) { 
                    der = Math.Max((double)row.mynav, (double)row.mynap);
                    cofl = int.Parse(row.coefficient_Module.ToString());
                    coff += cofl;
                    drow["Moy"] = der.ToString(".##");
                    TNote += (der * cofl);
                        
                }
                 
                else
                {
                    if (row.mynav != null) { 
                         der = (double)row.mynav;
                        cofl = int.Parse(row.coefficient_Module.ToString());
                        coff += cofl;
                        drow["Moy"] = der.ToString(".##");
                        TNote += (der * cofl);


                    }
                    
                }

                drow["Coff"] = row.coefficient_Module;
                if (((int)der) <= 7)
                {
                    drow["Obs"] = "Trés insufisant"; 

                }
                else if(((float)der) >= 7  && ((float)der)<10)
                {
                    drow["Obs"] = "Insufisant";

                }else if (((float)der) >= 10 && ((float)der) < 12)
                {
                    drow["Obs"] = "Passable";

                }
                else if (((float)der) >= 12 && ((float)der) < 15)
                {
                    drow["Obs"] = "Assez bien";

                }else
                if (((float)der) >= 15 && ((float)der) < 20)
                {
                    drow["Obs"] = "Trés Bien";

                }

                drow["Noteelim"] = row.NoteElim;



                xrTableCell21Prenom.Text = row.Prenom;

                xrTableCell6Nom.Text = row.Nom;
                //xrTableCell5CodeStg.Text = row.Numro_STG;
                xrTableCell3Specialite.Text = row.sp;
                xrTableCell2Modefr.Text = row.modeformation;
                xrTableCell22LieuNass.Text = row.lieuNissance;
                try { 
                xrTableCell8DateNiss.Text = row.datenissance.Value.ToString("MM/dd/yyyy");
                xrTableCell23DateFin.Text = row.datefin.Value.ToString("MM/dd/yyyy");
                xrTableCell10DateDube.Text = row.datedeube.Value.ToString("MM/dd/yyyy");
                }
                catch { }
                xrTableCell4Section.Text = row.section;



                tb1.Rows.Add(drow);

            }
            xrTableCell12MoyGenrale.Text = (TNote / coff).ToString(".##");
            return tb1;
          
         

            
        }
    }
}
