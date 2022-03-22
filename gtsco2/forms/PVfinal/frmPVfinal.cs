using DevExpress.XtraGrid;
using gtsco2.classe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace gtsco2.forms.PVfinal
{
    public partial class FrmPVfinal : DevExpress.XtraEditors.XtraForm
    {
        public FrmPVfinal()
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



                var qur5 = from ann in shared.bd.annee_scolaire
                           select new { id = ann.ID_Année_SCO, nom = (ann.Designation + ann.Session_Année_SCO) };
                anneecomboBox141.DataSource = qur5.ToList();
                anneecomboBox141.DisplayMember = "nom";
                anneecomboBox141.ValueMember = "id";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            refrech();
        }

        private void spcomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
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

        public void refrech()
        {
            try
            {
                if (radio1.Checked == true) { cncnex1(); }
                else if (radio2.Checked == true)
                {
                    cntexm2();
                }
                else if (radio3.Checked == true)
                {
                    cntcntexmorrtp3();
                }
                else if (radio4.Checked == true) { cntcntrtp4(); }
                else if (radio5.Checked == true) { contexmourtp5(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }
        public DataTable conff;
        
        public void loadmoye()
        {
            try { 
            idsec = int.Parse(seccomboBox.SelectedValue.ToString());
            }
            catch { MessageBox.Show("auccune section selicatione"); }
            try { 
            idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());
            }
            catch { MessageBox.Show("auccune semmestre selicatione"); }
            try { 
            idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());
            }
            catch { MessageBox.Show("auccune annnee selicatione"); }
            var qure = from eva in shared.bd.Evaluations
                       join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                       join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                       join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                       where eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec
                       select new
                       {
                           Numro_STG = eva.Num_STG,

                           Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                           mynav = eva.Moyenne_Module_AvRt,
                           mynap = eva.Moyenne_Module_ApRt,
                          coefficient_Module= modul.coefficient_Module,
                           notelm = modul.Note_Elim_Module,
                           module = ("Matiére: " + modul.Designation_Module + " Note Elim: " + modul.Note_Elim_Module + " Coeff: " + modul.coefficient_Module)

                       };
            //declarationde la table
            DataTable dt = new DataTable();
            dt.Clear();
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            int tcon = 0;
            conff = new DataTable();
            conff.Columns.Add("nommodule");
            conff.Columns.Add("coeff");
            conff.Columns.Add("notelm");

            //cration des colouns de datatable
            foreach (var qr in qure.ToList())
            {
                if (dt.Columns.Count <= 0)
                {
                    dt.Columns.Add("Numro_STG");
                    dt.Columns.Add("Nom_Et_Prnom");
                    dt.Columns.Add(qr.module, typeof(double));
                    
                    conff.Rows.Add(qr.module, qr.coefficient_Module, qr.notelm);
                    tcon += int.Parse(qr.coefficient_Module.ToString());
                }
                else
                {
                    int x = 0;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dc.ColumnName == qr.module)
                        {
                            x += 2;

                        }

                    }
                    if (x == 0)
                    {
                        dt.Columns.Add(qr.module,typeof(double));
                        tcon += int.Parse(qr.coefficient_Module.ToString());
                        conff.Rows.Add(qr.module, qr.coefficient_Module,qr.notelm);
                    }
                }
            }
            //cration des colonne des module 
            // et l'ajouter des line
            foreach (var qres in qure)
            {
                var r = dt.Rows.Count;
                foreach (DataRow dro in dt.Rows)
                {
                    if (dro[0].ToString() == qres.Numro_STG.ToString())
                    {
                        if (chikdeavenrtp.Checked == true)
                        {
                            dro[qres.module] = qres.mynav;
                            r += 1;
                        }
                        else
                        {
                            dro[qres.module] = Math.Max((double)qres.mynav, (double)qres.mynap);
                            r += 1;
                        }

                    }
                }
                if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                {
                    DataRow dro;
                    dro = dt.NewRow();

                    dro[0] = qres.Numro_STG;
                    dro[1] = qres.Nom_Et_Prenom;

                    if (chikdeavenrtp.Checked == true)
                    {
                        dro[qres.module] = qres.mynav;
                       
                    }
                    else
                    {
                        dro[qres.module] = Math.Max((double)qres.mynav, (double)qres.mynap);
                        
                    }

                    dt.Rows.Add(dro);
                }

            }
            dt.Columns.Add("MG");
            dt.Columns.Add("OPS");
            //calucle de la moynne ginarale et affictation des ops

            foreach(DataRow rowstg in dt.Rows)
            {
                double moyne = 0;
                int cooff = 0;
                bool rat = false;
                foreach (DataRow coof in conff.Rows)
                {
                    moyne += (double)((double)(rowstg[coof[0].ToString()])* int.Parse(coof[1].ToString()));
                    cooff += int.Parse(coof[1].ToString());
                    if (int.Parse(coof[2].ToString())> (double)(rowstg[coof[0].ToString()]))
                    {
                        rat = true;
                    }

                }
                rowstg["MG"] = (moyne / cooff);
                if ( rat==true ||float.Parse(rowstg["MG"].ToString())<10)
                {
                    if (chikdeavenrtp.Checked == true)
                    {
                        rowstg["OPS"] = "Ret";
                    }
                }
                else
                {
                    rowstg["OPS"] = "Admis";
                }
            }

            gridControl1.DataSource = dt;




        }



        



        public void cncnex1()
        {
            try { 

            idsec = int.Parse(seccomboBox.SelectedValue.ToString());
            idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());

            idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());

            var qure = from eva in shared.bd.Evaluations
                       join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                       join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                       join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                       where eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                       select new
                       {
                           Numro_STG = eva.Num_STG,

                           Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                           myn = ((eva.Control_1 + eva.Control_2 + eva.Exam) / 4),
                           modul.coefficient_Module,
                           module = ("Matiére: "+modul.Designation_Module + " Note Elim: " + modul.Note_Elim_Module + " Coeff: " + modul.coefficient_Module)

                       };
            DataTable dt = new DataTable();
            dt.Clear();
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            int tcon = 0;
            foreach (var qr in qure.ToList())
            {
                if (dt.Columns.Count <= 0)
                {
                    dt.Columns.Add("Numro_STG");
                    dt.Columns.Add("Nom_Et_Prnom");
                    dt.Columns.Add(qr.module);
                    tcon += int.Parse(qr.coefficient_Module.ToString());
                }
                else
                {
                    int x = 0;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dc.ColumnName == qr.module)
                        {
                            x += 2;

                        }

                    }
                    if (x == 0)
                    {
                        dt.Columns.Add(qr.module);
                        tcon += int.Parse(qr.coefficient_Module.ToString());
                    }
                }
            }
            foreach (var qres in qure)
            {
                var r = dt.Rows.Count;
                foreach (DataRow dro in dt.Rows)
                {
                    if (dro[0].ToString() == qres.Numro_STG.ToString())
                    {

                        dro[qres.module] = qres.myn;
                        r += 1;


                    }
                    else
                    {



                    }


                }
                if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                {
                    DataRow dro;
                    dro = dt.NewRow();

                    dro[0] = qres.Numro_STG;
                    dro[1] = qres.Nom_Et_Prenom;
                    dro[qres.module.ToString()] = qres.myn;
                    dt.Rows.Add(dro);
                }

            }
            dt.Columns.Add("MG");
            int i = 1;
            if (dt.Rows != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var a = row[0].ToString();
                    i += 1;
                    int mcof = 0;
                    float tmyn = 0;
                    float mg = 0;


                    var qur = from eva in shared.bd.Evaluations
                              join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                              join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                              join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                              where eva.Num_STG == a && eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                              select new
                              {
                                  Numro_STG = eva.Num_STG,

                                  Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                                  myn = (((eva.Control_1 + eva.Control_2 + eva.Exam) / 4) * modul.coefficient_Module),
                                  modul.coefficient_Module,
                                  module = (modul.Designation_Module + " (" + modul.Note_Elim_Module + ")")

                              };
                    foreach (var quree in qur.ToList())
                    {
                        
                        if (quree.myn.ToString() != "")
                        {
                            mcof += int.Parse(quree.coefficient_Module.ToString());
                            tmyn += float.Parse(quree.myn.ToString());
                        }

                    }
                    mg = tmyn / mcof;
                    row["MG"] = mg;

                }

            }

            gridControl1.DataSource = null;
            gridControl1.DataSource = dt;
                gridView1.OptionsBehavior.ReadOnly = true;
                NUBEREF.Text = dt.Rows.Count.ToString();
        }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}


        // con1 + exm /3
        public void cntexm2()
        {
            try { 
            idsec = int.Parse(seccomboBox.SelectedValue.ToString());
            idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());

            idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());

                var qure = from eva in shared.bd.Evaluations
                           join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                           join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                           join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                           where eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                           select new
                           {
                               Numro_STG = eva.Num_STG,

                               Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                               myn = ((eva.Control_1 + eva.Exam) / 3),
                               modul.coefficient_Module,
                               module = ("Matiére: " + modul.Designation_Module + " Note Elim: " + modul.Note_Elim_Module + " Coeff: " + modul.coefficient_Module) 

                       };
            DataTable dt = new DataTable();
            dt.Clear();
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            int tcon = 0;
            foreach (var qr in qure.ToList())
            {
                if (dt.Columns.Count <= 0)
                {
                    dt.Columns.Add("Numro_STG");
                    dt.Columns.Add("Nom_Et_Prnom");
                    dt.Columns.Add(qr.module);
                    tcon += int.Parse(qr.coefficient_Module.ToString());
                }
                else
                {
                    int x = 0;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dc.ColumnName == qr.module)
                        {
                            x += 2;

                        }

                    }
                    if (x == 0)
                    {
                        dt.Columns.Add(qr.module);
                        tcon += int.Parse(qr.coefficient_Module.ToString());
                    }
                }
            }
            foreach (var qres in qure)
            {
                var r = dt.Rows.Count;
                foreach (DataRow dro in dt.Rows)
                {
                    if (dro[0].ToString() == qres.Numro_STG.ToString())
                    {

                        dro[qres.module] = qres.myn;
                        r += 1;


                    }
                    else
                    {



                    }


                }
                if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                {
                    DataRow dro;
                    dro = dt.NewRow();

                    dro[0] = qres.Numro_STG;
                    dro[1] = qres.Nom_Et_Prenom;
                    dro[qres.module.ToString()] = qres.myn;
                    dt.Rows.Add(dro);
                }

            }
            dt.Columns.Add("MG");
            int i = 1;
            if (dt.Rows != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var a = row[0].ToString();
                    i += 1;
                    int mcof = 0;
                    float tmyn = 0;
                    float mg = 0;


                    var qur = from eva in shared.bd.Evaluations
                              join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                              join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                              join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                              where eva.Num_STG == a && eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                              select new
                              {
                                  Numro_STG = eva.Num_STG,

                                  Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                                  myn = (((eva.Control_1 + eva.Exam) / 3) * modul.coefficient_Module),
                                  modul.coefficient_Module,
                                  module = ("Matiére: " + modul.Designation_Module + " Note Elim: " + modul.Note_Elim_Module + " Coeff: " + modul.coefficient_Module)

                              };
                    foreach (var quree in qur.ToList())
                    {
                       
                        if (quree.myn.ToString() != "")
                        {
                            mcof += int.Parse(quree.coefficient_Module.ToString());
                            tmyn += float.Parse(quree.myn.ToString());
                        }

                    }
                    mg = tmyn / mcof;
                    row["MG"] = mg;

                }
            
        }

            gridControl1.DataSource = null;
            gridControl1.DataSource = dt;
            NUBEREF.Text = dt.Rows.Count.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // cont1 + cont2 +(exm or rtp)/4
        public void cntcntexmorrtp3()
        {
            try
            {
                idsec = int.Parse(seccomboBox.SelectedValue.ToString());
                idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());

                idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());

                var qure = from eva in shared.bd.Evaluations
                           join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                           join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                           join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                           where eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                           select new
                           {
                               Numro_STG = eva.Num_STG,

                               Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                               cnt1 = eva.Control_1,
                               cont2= eva.Control_2,
                               exm = eva.Exam,
                               rat = eva.Rattrapage,
                               conff = modul.coefficient_Module,
                               
                               module = ("Matiére: " + modul.Designation_Module + " Note Elim: " + modul.Note_Elim_Module + " Coeff: " + modul.coefficient_Module)

                           };
                DataTable dt = new DataTable();
                dt.Clear();
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                int tcon = 0;

                foreach (var qr in qure.ToList())
                {
                    if (dt.Columns.Count <= 0)
                    {
                        dt.Columns.Add("Numro_STG");
                        dt.Columns.Add("Nom_Et_Prnom");
                        dt.Columns.Add(qr.module);
                        tcon += int.Parse(qr.conff.ToString());
                    }
                    else
                    {
                        int x = 0;
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dc.ColumnName == qr.module)
                            {
                                x += 2;

                            }

                        }
                        if (x == 0)
                        {
                            dt.Columns.Add(qr.module);
                            tcon += int.Parse(qr.conff.ToString());
                        }
                    }
                }
                foreach (var qres in qure)
                {
                    var r = dt.Rows.Count;
                    foreach (DataRow dro in dt.Rows)
                    {
                        if (dro[0].ToString() == qres.Numro_STG.ToString())
                        {
                            float rat = 0;
                            if (qres.rat.ToString() != "")
                            {
                                rat = float.Parse(qres.rat.ToString());
                            }
                            dro[qres.module] = ((qres.cnt1 + qres.cont2+float.Parse(maxa(rat.ToString(), qres.exm.ToString()))) / 4);
                            r += 1;


                        }
                        else
                        {



                        }


                    }
                    if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                    {
                        DataRow dro;
                        dro = dt.NewRow();

                        dro[0] = qres.Numro_STG;
                        dro[1] = qres.Nom_Et_Prenom;
                        float rat = 0;
                        if (qres.rat.ToString() != "")
                        {
                            rat = float.Parse(qres.rat.ToString());
                        }
                        dro[qres.module] = ((qres.cnt1 + qres.cont2 + float.Parse(maxa(rat.ToString(), qres.exm.ToString()))) / 4);

                        dt.Rows.Add(dro);
                    }

                }
                dt.Columns.Add("MG");
                int i = 1;
                if (dt.Rows != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var a = row[0].ToString();
                        i += 1;
                        int mcof = 0;
                        float tmyn = 0;
                        float mg = 0;


                        var qur = from eva in shared.bd.Evaluations
                                  join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                                  join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                                  join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                                  where eva.Num_STG == a && eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                                  select new
                                  {
                                      Numro_STG = eva.Num_STG,

                                      Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                                      cnt1 = eva.Control_1,
                                      cnt2 =eva.Control_2,
                                      exm = eva.Exam,
                                      rat = eva.Rattrapage,
                                      conff =modul.coefficient_Module,
                                 };
                        foreach (var quree in qur.ToList())
                        {

                            if (quree.cnt1.ToString() != "" || quree.exm.ToString() != ""||quree.cnt2.ToString()!="")
                            {
                                float cont = float.Parse(quree.cnt1.ToString());
                                float cont2 = float.Parse(quree.cnt2.ToString());
                                float exm = float.Parse(quree.exm.ToString());
                                float rat = 0;
                                if (quree.rat.ToString() != "")
                                {
                                    rat = float.Parse(quree.rat.ToString());
                                }

                                float max = float.Parse(maxa(exm.ToString(), rat.ToString()));

                                mcof += int.Parse(quree.conff.ToString());
                                tmyn += (((cont + max+cont2) / 4) * float.Parse(quree.conff.ToString()));
                            }
                            

                        }
                        mg = tmyn / mcof;
                        row["MG"] = mg;

                    }

                }

                gridControl1.DataSource = null;
                gridControl1.DataSource = dt;
                gridView1.OptionsBehavior.ReadOnly = true;
                NUBEREF.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public  string maxa(string a,string b)
        { float z = float.Parse(a);
            float n = float.Parse(b);
            if (z >= n)
            {
                return (z.ToString());

            }
            else
            {
                return (n.ToString());
            }
        }

         //cnt1+cnt2+rtp/4

        public void cntcntrtp4()
        {
            try
            {
                idsec = int.Parse(seccomboBox.SelectedValue.ToString());
                idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());

                idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());

                var qure = from eva in shared.bd.Evaluations
                           join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                           join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                           join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                           where eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                           select new
                           {
                               Numro_STG = eva.Num_STG,

                               Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                               myn = ((eva.Control_1 + eva.Control_2 + eva.Rattrapage) / 4),
                               modul.coefficient_Module,
                               module = ("Matiére: " + modul.Designation_Module + " Note Elim: " + modul.Note_Elim_Module + " Coeff: " + modul.coefficient_Module)

                           };
                DataTable dt = new DataTable();
                dt.Clear();
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                int tcon = 0;
                foreach (var qr in qure.ToList())
                {
                    if (dt.Columns.Count <= 0)
                    {
                        dt.Columns.Add("Numro_STG");
                        dt.Columns.Add("Nom_Et_Prnom");
                        dt.Columns.Add(qr.module);
                        tcon += int.Parse(qr.coefficient_Module.ToString());
                    }
                    else
                    {
                        int x = 0;
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dc.ColumnName == qr.module)
                            {
                                x += 2;

                            }

                        }
                        if (x == 0)
                        {
                            dt.Columns.Add(qr.module);
                            tcon += int.Parse(qr.coefficient_Module.ToString());
                        }
                    }
                }
                foreach (var qres in qure)
                {
                    var r = dt.Rows.Count;
                    foreach (DataRow dro in dt.Rows)
                    {
                        if (dro[0].ToString() == qres.Numro_STG.ToString())
                        {

                            dro[qres.module] = qres.myn;
                            r += 1;


                        }
                        else
                        {



                        }


                    }
                    if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                    {
                        DataRow dro;
                        dro = dt.NewRow();

                        dro[0] = qres.Numro_STG;
                        dro[1] = qres.Nom_Et_Prenom;
                        dro[qres.module.ToString()] = qres.myn;
                        dt.Rows.Add(dro);
                    }

                }
                dt.Columns.Add("MG");
                int i = 1;
                if (dt.Rows != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var a = row[0].ToString();
                        i += 1;
                        int mcof = 0;
                        float tmyn = 0;
                        float mg = 0;


                        var qur = from eva in shared.bd.Evaluations
                                  join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                                  join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                                  join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                                  where eva.Num_STG == a && eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                                  select new
                                  {
                                      Numro_STG = eva.Num_STG,

                                      Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                                      myn = (((eva.Control_1 + eva.Control_2 + eva.Rattrapage) / 4) * modul.coefficient_Module),
                                      modul.coefficient_Module,
                                      module = (modul.Designation_Module + " (" + modul.Note_Elim_Module + ")")

                                  };
                        foreach (var quree in qur.ToList())
                        {
                          
                            if (quree.myn.ToString() != "")
                            {
                                mcof += int.Parse(quree.coefficient_Module.ToString());
                                tmyn += float.Parse(quree.myn.ToString());
                            }

                        }
                        mg = tmyn / mcof;
                        row["MG"] = mg;

                    }

                }

                gridControl1.DataSource = null;
                gridControl1.DataSource = dt;
                gridView1.OptionsBehavior.ReadOnly = true;
                NUBEREF.Text = dt.Rows.Count.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // con1+rtp ou exm / 3

        public void contexmourtp5()

        {
            try
            {
                idsec = int.Parse(seccomboBox.SelectedValue.ToString());
                idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());

                idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());

                var qure = from eva in shared.bd.Evaluations
                           join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                           join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                           join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                           where eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                           select new
                           {
                               Numro_STG = eva.Num_STG,

                               Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                              
                              cnt1 = eva.Control_1,
                              exm = eva.Exam,
                              rat = eva.Rattrapage,


                               modul.coefficient_Module,
                               module = ("Matiére: " + modul.Designation_Module + " Note Elim: " + modul.Note_Elim_Module + " Coeff: " + modul.coefficient_Module)

                           };
                DataTable dt = new DataTable();
                dt.Clear();
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                int tcon = 0;
                foreach (var qr in qure.ToList())
                {
                    if (dt.Columns.Count <= 0)
                    {
                        dt.Columns.Add("Numro_STG");
                        dt.Columns.Add("Nom_Et_Prnom");
                        dt.Columns.Add(qr.module);
                        tcon += int.Parse(qr.coefficient_Module.ToString());
                    }
                    else
                    {
                        int x = 0;
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dc.ColumnName == qr.module)
                            {
                                x += 2;

                            }

                        }
                        if (x == 0)
                        {
                            dt.Columns.Add(qr.module);
                            tcon += int.Parse(qr.coefficient_Module.ToString());
                        }
                    }
                }
                foreach (var qres in qure)
                {
                    var r = dt.Rows.Count;
                    foreach (DataRow dro in dt.Rows)
                    {
                        if (dro[0].ToString() == qres.Numro_STG.ToString())
                        {
                            float rat = 0;
                            if (qres.rat.ToString() != "")
                            {
                                rat = float.Parse(qres.rat.ToString());
                            }

                            dro[qres.module] = ((qres.cnt1 + float.Parse(maxa(rat.ToString(),qres.exm.ToString())))/3);
                            r += 1;


                        }
                        else
                        {



                        }


                    }
                    if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                    {
                        DataRow dro;
                        dro = dt.NewRow();

                        dro[0] = qres.Numro_STG;
                        dro[1] = qres.Nom_Et_Prenom;
                        float rat = 0;
                        if(qres.rat.ToString()!= "")
                        {
                            rat = float.Parse(qres.rat.ToString());
                        }
                        dro[qres.module.ToString()] = ((qres.cnt1 + float.Parse(maxa(rat.ToString(), qres.exm.ToString()))) / 3);
                        dt.Rows.Add(dro);
                    }

                }

                dt.Columns.Add("MG");
                dt.Columns.Add("OBS");
                int i = 1;
                if (dt.Rows != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var a = row[0].ToString();
                        i += 1;
                        int mcof = 0;
                        float tmyn = 0;
                        float mg = 0;
                        float tmynE = 0;
                        int confs = 0;


                        var qur = from eva in shared.bd.Evaluations
                                  join stg in shared.bd.Stagiairs on eva.Num_STG equals stg.Num_STG
                                  join modul in shared.bd.Modules on eva.ID_Module equals modul.ID_Module
                                  join anne in shared.bd.annee_scolaire on eva.ID_Année_SCO equals anne.ID_Année_SCO
                                  where eva.Num_STG == a && eva.ID_Semestre == idsem && eva.ID_Année_SCO == idannee && stg.Section == idsec

                                  select new
                                  {
                                      Numro_STG = eva.Num_STG,

                                      Nom_Et_Prenom = (stg.Nom + " " + stg.Prenom),
                                      cnt1 = eva.Control_1,
                                      exm = eva.Exam,
                                      rat = eva.Rattrapage,
                                      conff=modul.coefficient_Module
                                    

                                  }; 
                        string OB = "f";
                        foreach (var quree in qur.ToList())
                        {
                            OB = "n";
                            if (quree.cnt1.ToString() != "" && quree.exm.ToString() != "")
                            {
                                float cont = float.Parse(quree.cnt1.ToString());
                                float exm = float.Parse(quree.exm.ToString());
                                float rat = 0;
                                if (quree.rat.ToString() != "")
                                {
                                    rat = float.Parse(quree.rat.ToString());
                                }

                                float max = float.Parse(maxa(exm.ToString(), rat.ToString()));

                                confs = int.Parse(quree.conff.ToString());
                                mcof += confs;   
                                tmynE = (((cont + max) / 3)*float.Parse(quree.conff.ToString()));
                                tmyn += tmynE;
                                if (tmynE < confs)
                                {
                                    OB = "r";
                                }
                                
                            }


                        }
                       
                       mg = tmyn / mcof;
                        row["MG"] = mg;
                        if(OB=="r"|| mg < 10)
                        {
                            row["OBS"] = "RAT";
                        }
                        else { row["OBS"] = "ADM"; }

                    }

                }

                gridControl1.DataSource = null;
                gridControl1.DataSource = dt;
                gridView1.OptionsBehavior.ReadOnly = true;
                NUBEREF.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }



        private void avenrtp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            loadmoye();
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



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {

        }
        //chonge la color de cell solen le ceoffiation 
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                foreach (DataRow row in conff.Rows)
                {
                    if ((e.Column).ToString() == row[0].ToString())
                    {
                        var conn = float.Parse(row[2].ToString());
                        var valeu = float.Parse(e.CellValue.ToString());
                        if (valeu < conn)
                        {
                            e.Appearance.BackColor = Color.FromArgb(0xD2, 0xFD, 0x91);
                            e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                        }
                    }
                }
            }
            catch { }
            //if (e.Column == gridView1.Columns[3])
            //{
            //    var age = float.Parse(e.CellValue.ToString());
            //    if (age > 10)
            //        e.Appearance.BackColor = Color.Red;
            //    else
            //        e.Appearance.BackColor = Color.FromArgb(0xD2, 0xFD, 0x91);
            //}
        }
    }
}

