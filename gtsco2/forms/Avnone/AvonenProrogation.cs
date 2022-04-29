using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using gtsco2.classe;
using System.Windows;

namespace gtsco2.forms.Avnone
{
    public partial class AvonenProrogation : DevExpress.XtraReports.UI.XtraReport
    {
        public AvonenProrogation()
        {
            InitializeComponent();
        }

        public static void printProro(string numstg, int empid)
        {
            AvonenProrogation rpt = new AvonenProrogation();
            rpt.load(numstg, empid);
            rpt.ShowRibbonPreview();
        }
        public void load(string numstg, int empid)
        {
            var qure = from proro in shared.bd.Avenant_contrat_prorogation
                       join stg in shared.bd.Stagiairs on proro.Num_stg equals stg.Num_STG
                       join emp in shared.bd.Employeurs on proro.ID_emp equals emp.ID_Emp
                       from commlie in shared.bd.Communes.Where(x => x.Commune_id == stg.Lieu_Naissance).DefaultIfEmpty()
                       from post in shared.bd.Code_Postal.Where(x => x.ID_Code_Postal == stg.Code_postal).DefaultIfEmpty()
                       from titure in shared.bd.tuteurs.Where(x => x.id_tuteur == stg.id_tuteur).DefaultIfEmpty()
                       from promo in shared.bd.Promoes.Where(x => x.ID_Promo == stg.ID_Promo).DefaultIfEmpty()
                       where proro.Num_stg == numstg && proro.ID_emp == empid

                       select new
                       {
                           nom = stg.Nom,
                           nomAr = stg.Nom_ar,
                           prenom = stg.Prenom,
                           prnomAr = stg.Prenom_ar,
                           stg.Date_de_Naissance,
                           lieuniss = commlie.Commune_name + "-" + commlie.Willaya.Wilaya_name__fr_,
                           lieunassAr = commlie.Commune_name_ar + "-" + commlie.Willaya.Wilaya_name__ar,
                           Sexe = stg.Sexe,
                           Adrasse_ar = stg.Adresse_ar,
                           adersse = stg.Adresse,
                           codePostStg = post.Code_Postal1,
                           communSTg = post.Commune.Commune_name,
                           communStgAr = post.Commune.Commune_name_ar,
                           NumTlfStg = stg.Telephone,
                           EmilStg = stg.E_Maile,
                           Niveu = stg.Nivo_SCO,
                           NiveuAr = stg.Nivo_SCO,

                           //tuture
                           NomTT = titure.nom,
                           preNomTT = titure.prenom,
                           TlfTT = titure.telephone,
                           AdrassTT = titure.adresse,
                           

                           // emploire

                           NomEmp = emp.Nom_Emp,
                           emp.Statut_Emp,
                           emp.Adresse_Emp,
                           emp.Mail_Emp,
                           emp.Fax_Emp,
                           emp.Tel_Emp,
                           codepostEmp = emp.Code_Postal.Code_Postal1,
                           communEmp = emp.Code_Postal.Commune.Commune_name,
                           emp.Type_Emp,


                           // formation
                           promo.DATE_D_Formation,
                           promo.Date_F_Formation,
                           promo.Diplome,
                           promo.Diplome_ar,
                           sp = promo.Option.Specialite1.Designation_SP + " Option " + promo.Option.Designation_Option,
                           proro.Duree,

                           proro.date_dbt_proro,
                           proro.date_fin_proro,
                           proro.date_validation_cont_proro,
                           proro.Num_validation_cont_proro,

                           code_sp = promo.Option.Specialite1.Branch.Code_Branche +promo.Option.Specialite1.Code_SP
                           


                       };

            foreach (var row in qure.ToList())
            {try
                {
                    try
                    {
                        xrLabelNomStg.Text = row.nom;
                        xrLabelPrenomSTg.Text = row.prenom;
                        xrLabelADrssStg.Text = row.adersse;
                        try
                        {
                            xrLabelDATEnStg.Text = row.Date_de_Naissance.Value.ToString("dd/MM/yyyy");
                        }
                        catch { }
                        xrLabelLeusNStg.Text = row.lieuniss;
                        if (row.Sexe == "Femme")
                            xrLabelFm.Text = "X";
                        else
                            xrLabelMal.Text = "X";

                        xrLabelCodepostStg.Text = row.codePostStg;
                        xrLabelCommunSTG.Text = row.communSTg;
                        xrLabelTlfStg.Text = row.NumTlfStg;
                        xrLabelEmailSTg.Text = row.EmilStg;
                        xrLabelNiveuSTg.Text = row.Niveu;

                    }
                    catch { }
                    try
                    {
                        ////tuture
                        xrLabelNomTuture.Text = row.NomTT;
                        xrLabelPrenomTutur.Text = row.preNomTT;
                        xrLabelAdressTutur.Text = row.AdrassTT;
                        xrLabelTlfTutuer.Text = row.TlfTT;
                        xrLabelEmaileTuteur.Text = "";
                        xrLabelCodepostTuteur.Text = "";
                        xrLabelComuneTuteur.Text = "";
                    }
                    catch { }

                    // emploire
                    try
                    {
                        xrLabelNomEMp.Text = row.NomEmp;
                        xrLabelSTatuEmp.Text = row.Statut_Emp;
                        xrLabelAdressEMp.Text = row.Adresse_Emp;
                        xrLabelEmailEmp.Text = row.Mail_Emp;
                        xrLabelFAxEmp.Text = row.Fax_Emp;
                        xrLabelTLfEmp.Text = row.Tel_Emp;
                        xrLabelCommunEmp.Text = row.communEmp;
                        xrLabelCodePEMp.Text = row.codepostEmp;
                        if (row.Type_Emp == "Public")
                        {
                            xrLabelPU.Text = "X";
                            xrLabelPR.Text = "";
                        }
                        else
                        {
                            xrLabelPU.Text = "";
                            xrLabelPR.Text = "X";
                        }
                    }
                    catch { }
                    //foemation 
                    try
                    {
                        xrLabelDureeProro.Text = row.Duree + " mois";

                        xrLabelDEplome.Text = row.Diplome;
                        xrLabelSpecialiter.Text = row.sp;
                        xrLabelNumCon.Text = row.Num_validation_cont_proro;
                    }
                    catch { }
                    try
                    {
                        xrLabelDateDub.Text = row.DATE_D_Formation.Value.ToString("dd/MM/yyyy");
                        xrLabelDateFin.Text = row.Date_F_Formation.Value.ToString("dd/MM/yyyy");
                        xrLabelDVCont.Text = row.date_validation_cont_proro.Value.ToString("dd/MM/yyyy");
                    }
                    catch { }
                    xrLabelCodeFo.Text = row.code_sp;




                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                

                     

            }








        }
    }
}
