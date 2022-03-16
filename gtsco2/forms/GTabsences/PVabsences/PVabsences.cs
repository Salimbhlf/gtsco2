using gtsco2.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.GTabsences.PVabsences
{
    public partial class PVabsences : DevExpress.XtraEditors.XtraForm
    {
        public PVabsences()
        {
            InitializeComponent();
            load();
        }
        // load data combobox
        public void load()
        {

            try
            {

                List<basededonne.Mode_formation> list = shared.bd.Mode_formation.ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("disc");

                foreach (basededonne.Mode_formation ro in list)
                {
                    dt.Rows.Add(ro.Code_Mode_Formation, ro.Désignation_Mode_Formation);
                }
                modecombobox.DataSource = dt;
                modecombobox.DisplayMember = dt.Columns[1].ColumnName;
                modecombobox.ValueMember = dt.Columns[0].ColumnName;


                var qur = from sp in shared.bd.Options select new { id = sp.ID_Option, nom = sp.Code_Option };

                spcomboBox1.DataSource = qur.ToList();
                spcomboBox1.DisplayMember = "nom";
                spcomboBox1.ValueMember = "id";

                var qur1 = from pr in shared.bd.Promoes
                           join po in shared.bd.Options on pr.ID_Option equals po.ID_Option
                           join mo in shared.bd.Mode_formation on pr.Mode_de_formation equals mo.ID_Mode_Formation
                           select new { id = pr.ID_Promo, nom = (mo.Code_Mode_Formation + po.Code_Option + pr.Code_Promo) };

                promocomboBox11.DataSource = qur1.ToList();
                promocomboBox11.DisplayMember = "nom";
                promocomboBox11.ValueMember = "id";

                var qur2 = from sec in shared.bd.Semestres select new { id = sec.ID_Semestre, nom = sec.Designation_Semestre };


                smstcomboBox13.DataSource = qur2.ToList();
                smstcomboBox13.DisplayMember = "nom";
                smstcomboBox13.ValueMember = "id";

                var qur3 = from sec in shared.bd.Sections
                           join po in shared.bd.Options on sec.ID_Option equals po.ID_Option
                           join mo in shared.bd.Mode_formation on sec.ID_Mode_Formation equals mo.ID_Mode_Formation
                           join pro in shared.bd.Promoes on sec.ID_Promo equals pro.ID_Promo
                           select new { id = sec.SectionID, nom = (mo.Code_Mode_Formation + po.Code_Option + pro.Code_Promo + " " + sec.Code_Section) };

                seccomboBox.DataSource = qur3.ToList();
                seccomboBox.DisplayMember = "nom";
                seccomboBox.ValueMember = "id";

                var qur4 = from mod in shared.bd.Modules
                           select new { id = mod.ID_Module, nom = mod.Designation_Module };



                var qur5 = from ann in shared.bd.annee_scolaire
                           select new { id = ann.ID_Année_SCO, nom = (ann.Designation + ann.Session_Année_SCO) };
                anneecomboBox141.DataSource = qur5.ToList();
                anneecomboBox141.DisplayMember = "nom";
                anneecomboBox141.ValueMember = "id";



            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }




        private void simpleButton2_Click(object sender, EventArgs e)
        {
            refrech();
        }

        private void spcomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try {
                int sp = int.Parse(spcomboBox1.SelectedValue.ToString());
                promocomboBox11.DataSource = null;
                promocomboBox11.Items.Clear();

                var qur1 = from pr in shared.bd.Promoes
                           join po in shared.bd.Options on pr.ID_Option equals po.ID_Option
                           join mo in shared.bd.Mode_formation on pr.Mode_de_formation equals mo.ID_Mode_Formation
                           where pr.ID_Option == sp
                           select new { id = pr.ID_Promo, nom = (mo.Code_Mode_Formation + po.Code_Option + pr.Code_Promo) };

                promocomboBox11.DataSource = qur1.ToList();
                promocomboBox11.DisplayMember = "nom";
                promocomboBox11.ValueMember = "id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void promocomboBox11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int sp = int.Parse(promocomboBox11.SelectedValue.ToString());
                seccomboBox.DataSource = null;
                seccomboBox.Items.Clear();

                var qur3 = from sec in shared.bd.Sections
                           join po in shared.bd.Options on sec.ID_Option equals po.ID_Option
                           join mo in shared.bd.Mode_formation on sec.ID_Mode_Formation equals mo.ID_Mode_Formation
                           join pro in shared.bd.Promoes on sec.ID_Promo equals pro.ID_Promo
                           where sec.ID_Promo == sp
                           select new { id = sec.SectionID, nom = (mo.Code_Mode_Formation + po.Code_Option + pro.Code_Promo + " " + sec.Code_Section) };

                seccomboBox.DataSource = qur3.ToList();
                seccomboBox.DisplayMember = "nom";
                seccomboBox.ValueMember = "id";







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
        }
        int idsec;
        int idsem;
        int idannee;
        DateTime datee;


        string a;
        public void refrech()
        {
            try
            {

                datee = dateEditdébut.DateTime;

                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                if (datee > new DateTime(1000, 01, 01) )
                {
                    using (DataTable dt = new DataTable())
                    {

                        dt.Columns.Add("Numro_STG");

                        dt.Columns.Add("Nom_et_Prenom");
                        dt.Columns.Add("Nombre_dabsences_par_séance");
                        dt.Columns.Add("Absences_non_justfer");
                        dt.Columns.Add("Absences_justef");
                        dt.Columns.Add("OBS");


                        idsec = int.Parse(seccomboBox.SelectedValue.ToString());
                        idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());

                        idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());

                        var qure = from abs in shared.bd.Absences
                                   join stg in shared.bd.Stagiairs on abs.Num_STG equals stg.Num_STG
                                   where stg.Section == idsec && abs.ID_Année_SCO == idannee && abs.ID_Semestre == idsec

                                   select new
                                   {
                                       Numro_STG = stg.Num_STG,
                                       Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),

                                       number_Justfer = (shared.bd.Absences.Where(b => b.Num_STG == stg.Num_STG && b.Seance_1_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == true).Count()) +
                                      (shared.bd.Absences.Where(b => b.Num_STG == abs.Num_STG && b.Seance_2_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == true).Count()) +
                                      (shared.bd.Absences.Where(b => b.Num_STG == stg.Num_STG && b.Seance_3_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == true).Count()) +
                                      (shared.bd.Absences.Where(b => b.Num_STG == stg.Num_STG && b.Seance_4_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == true).Count()),


                                       number_a = (shared.bd.Absences.Where(b => b.Num_STG == stg.Num_STG && b.Seance_1_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == false).Count()) +
                                      (shared.bd.Absences.Where(b => b.Num_STG == abs.Num_STG && b.Seance_2_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == false).Count()) +
                                      (shared.bd.Absences.Where(b => b.Num_STG == stg.Num_STG && b.Seance_3_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == false).Count()) +
                                      (shared.bd.Absences.Where(b => b.Num_STG == stg.Num_STG && b.Seance_4_ABS == true && b.Date_ABS >= dateEditdébut.DateTime && b.Date_ABS <= dateEditfin.DateTime && b.Absence_Justifer == false).Count()),





                                   };


                        foreach (basededonne.Stagiair stg in shared.bd.Stagiairs)
                        {

                            if (stg.Section == idsec)
                            {
                                a = "r";
                                foreach (var row in qure.ToList())
                                {
                                    if (row.Numro_STG == stg.Num_STG)
                                    {
                                        string absseance = (row.number_Justfer + row.number_a).ToString();
                                        string avrt = "/";
                                        string NBJ = "";
                                        int st = row.number_a / 4;
                                        double vt = ((double.Parse((row.number_a).ToString("#0.00")) / 4) - st) * 4;

                                        if (vt == 0) { NBJ = (st + "J "); }
                                        else
                                        {
                                            NBJ = (st + "J " + vt + "/4");
                                        }

                                        string jt;
                                        int jn = row.number_Justfer / 4;
                                        double jv = ((double.Parse((row.number_Justfer).ToString("#0.00")) / 4) - jn) * 4;

                                        if (jv == 0) { jt = (jn + "J "); }
                                        else
                                        {
                                            jt = (jn + "J " + jv + "/4");
                                        }
                                        avrt = Avert(st);

                                        dt.Rows.Add(row.Numro_STG, row.Nom_et_Prenom,absseance, NBJ, jt, avrt);
                                        a = "ez";
                                        a = "g";
                                        break;

                                    }
                                    else
                                    {
                                        a = "f";
                                    }
                                }

                            }
                        }
                        gridControl1.DataSource = dt;

                        if (a == "g")
                        {
                            gridView1.OptionsBehavior.ReadOnly = true;
                            NUBEREF.Text = dt.Rows.Count.ToString();
                        }
                        else
                        {
                            edit();
                            NUBEREF.Text = dt.Rows.Count.ToString();
                        }

                    }
                }


                else { MessageBox.Show("Veuillez mentionnez pèriode de comptabilisation des absences"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        // GINARTURE DES AVERITISMOS
    
         private string Avert(int nubrabs)
        {
            try
            { string r;
                int av1 = int.Parse(av1textEdit1.Text);
                int av2 = int.Parse(av2textEdit11.Text);
                int balm = int.Parse(blmtextEdit12.Text);
                int exl = int.Parse(exctextEdit13.Text);
                if (nubrabs >= av1 && nubrabs < av2)
                {  r= ("Avertissement 1");
                    return r;
                    
                }
                else if (nubrabs >= av2 && nubrabs < balm)
                {
                    return ("Avertissement 2").ToString();
                }
                else if (nubrabs >= balm && nubrabs <= exl)
                {
                    return "Blâme avant exclusion  ";
                }
                else if (nubrabs >exl)
                {
                    return "Exclusion définitive";
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "/";

        }

        

        public void edit()
        {
            try
            {
                if (gridView1.Columns.Count > 0)
                {


                    gridView1.OptionsBehavior.ReadOnly = false;
                    gridView1.Columns[0].OptionsColumn.ReadOnly = true;
                    gridView1.Columns[1].OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     

        

      

       

       



        private void simpleButton4_Click(object sender, EventArgs e)
        {
            refrech();
        }

        private void closeButton7_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Fermer la fenêtre? ", "Fermeture de la fenêtre", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                
                Close();

            }
            else
            {
                

            }
        }


        public void printPvABS()
        {

            string idsec = seccomboBox.Text;
            string idsem = smstcomboBox13.Text;
            string promo = promocomboBox11.Text;
            string sp = spcomboBox1.Text;
           string idannee = anneecomboBox141.Text;
            DateTime dateeD = dateEditdébut.DateTime;
            DateTime dateeF = dateEditfin.DateTime;
            object dt = gridControl1.DataSource;
            Formlaire_saisie_absence.etat_absence.reportabsonce.print(dt,idsec,idsem,dateeD,dateeF,promo ,sp);


        }


        private void seccomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void promocomboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            printPvABS();
            
        }
        public void printForm_SaiseAbsonce()
        {
            string pro = promocomboBox11.Text;
            string sec = seccomboBox.Text;
            string semestre = smstcomboBox13.Text;

            formilaredesabsonce.frmforimolierdesabsonce frm = new formilaredesabsonce.frmforimolierdesabsonce();

            frm.print(gridControl1.DataSource, sec, semestre, pro);
            
            frm.ShowDialog();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            printForm_SaiseAbsonce();
        }
    }
}
