using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;


namespace gtsco2.forms.Formulaire_d_inscription
{
    public partial class Formulaire_d_inscription : DevExpress.XtraReports.UI.XtraReport
    {
        public Formulaire_d_inscription()
        {
            InitializeComponent();
            
        }


        public static void print (string stg)
        {
            Formulaire_d_inscription frm = new Formulaire_d_inscription();
            frm.load(stg);
            frm.ShowRibbonPreview();

        }
        public void load (string numstg){
            try
            {
                var qure =
                           from stg in shared.bd.Stagiairs
                           from proro in shared.bd.Contract_avenant_changement.Where(x => x.num_stg == stg.Num_STG).DefaultIfEmpty()
                           from emp in shared.bd.Employeurs.Where(x => x.ID_Emp == proro.id_emp).DefaultIfEmpty()
                           from commlie in shared.bd.Communes.Where(x => x.Commune_id == stg.Lieu_Naissance).DefaultIfEmpty()
                           from post in shared.bd.Code_Postal.Where(x => x.ID_Code_Postal == stg.Code_postal).DefaultIfEmpty()
                           from titure in shared.bd.tuteurs.Where(x => x.id_tuteur == stg.id_tuteur).DefaultIfEmpty()
                           from promo in shared.bd.Promoes.Where(x => x.ID_Promo == stg.ID_Promo).DefaultIfEmpty()
                           from EmpX in shared.bd.Employeurs.Where(x => x.ID_Emp == stg.ID_Emp).DefaultIfEmpty()
                           where stg.Num_STG == numstg

                           select new
                           {
                               numrostg = stg.Num_STG,
                               nom = stg.Nom,
                               nomAr = stg.Nom_ar,
                               prenom = stg.Prenom,
                               prnomAr = stg.Prenom_ar,
                               stg.Date_de_Naissance,
                               lieuniss = commlie.Commune_name + "-" + commlie.Willaya.Wilaya_name__fr_,
                               lieunassAr = commlie.Commune_name_ar + "-" + commlie.Willaya.Wilaya_name__ar,
                               Sexe = stg.Sexe,
                               Adrasse_ar = stg.Adresse_ar,
                               adersse = stg.Adresse + " " + stg.Code_Postal1.Commune.Commune_name + " " + stg.Code_Postal1.Commune.Willaya.Wilaya_name__fr_ + " " + stg.Code_Postal1.Code_Postal1,
                               codePostStg = post.Code_Postal1,
                               communSTg = post.Commune.Commune_name,
                               communStgAr = post.Commune.Commune_name_ar,
                               NumTlfStg = stg.Telephone,
                               EmilStg = stg.E_Maile,
                               Niveu = stg.Nivo_SCO,
                               NiveuAr = stg.Nivo_SCO,
                               numrovalidation = stg.Num_Validation_Contrat_STG,

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
                               sp = promo.Option.Specialite1.Designation_SP,
                               Option = promo.Option.Designation_Option,

                               proro.DATE_AV_VALID_CHANG,

                               proro.NUM_AV_VALID_CHANG,

                               proro.DATE_DBT_FORMA_CHANG,
                               proro.DATE_FIN_FORMA_ANCIEN_EMP,
                               proro.DATE_FIN_FORMA_CHANG,

                               NomEmpX = EmpX.Nom_Emp,
                               stat = EmpX.Type_Emp,
                               amderessEmpX = EmpX.Adresse_Emp + " " + EmpX.Code_Postal.Commune.Commune_name + " " + EmpX.Code_Postal.Code_Postal1,
                               emilXEmp = EmpX.Mail_Emp,
                               nomprenoMere = stg.Nom_Mère_STG + "  " + stg.Prenom_Mère_STG,
                               promo = promo.Mode_formation.Code_Mode_Formation + promo.Option.Code_Option + promo.Code_Promo,
                               branch = promo.Option.Specialite1.Branch.Code_Branche + promo.Option.Specialite1.Code_SP,
                               image = stg.photo,

                           };

                foreach (var row in qure.ToList())
                {
                    xrLabelNumroInscerption.Text = row.numrostg;
                    xrLabelNumrodevalidation.Text = row.numrovalidation.ToString();

                    xrLabelbronch.Text = row.branch;
                
                    xrLabelOP.Text = row.Option;
                    xrLabelEMP.Text = row.NomEmpX;
                    xrLabelEmailEmp.Text = row.emilXEmp;
                    xrLabelSECTur.Text = row.stat;
                    xrLabelAderssEmp.Text = row.Adresse_Emp;
                    try
                    {
                        xrPictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(row.image));
                    }
                    catch { }
                    xrLabelEmpN.Text = row.NomEmp;
                    xrLabelSecturRmpN.Text = row.Type_Emp;
                    xrLabelAdersseEmpN.Text = row.Adresse_Emp;
                    xrLabelmailEmpN.Text = row.emilXEmp;

                    xrLabelNomSTg.Text = row.nom;
                    xrLabelPrenoStg.Text = row.prenom;
                    try
                    {
                        xrLabelDatedebutformation.Text = row.DATE_D_Formation.Value.ToString("dd/MM/yyyy");
                        xrLabeldatefine.Text = row.Date_F_Formation.Value.ToString("dd/MM/yyyy");
                        xrlabelDateLieN.Text = row.Date_de_Naissance.Value.ToString("dd/MM/yyyy") + " A: " + row.lieuniss;

                    }
                    catch { }
                    xrLabelNiveu.Text = row.Niveu;
                    xrLabelNOmPREMere.Text = row.nomprenoMere;
                    xrLabelAderStg.Text = row.adersse;
                    xrLabelTelfSTg.Text = row.NumTlfStg;
                    xrLabelMailSTG.Text = row.EmilStg;
                    xrLabel1.Text = row.promo;



                }



            }
            catch { }

        }
    }
}
