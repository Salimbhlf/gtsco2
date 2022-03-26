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
                }
                catch { }
                try
                {

                    var qur = from op in shared.bd.Options join sp in shared.bd.Specialites on op.Specialite equals sp.ID_Specialité select new { id = op.ID_Option, nom = sp.Designation_SP + " Option: " + op.Designation_Option };

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
                }
                catch { }
                try
                {

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

                }
                catch { }

                try
                {
                    var qur5 = (from ann in shared.bd.annee_scolaire
                                select new { id = ann.ID_Année_SCO, nom = (ann.Designation + ann.Session_Année_SCO) }).ToList();
                    DataTable table = new DataTable();
                    table.Columns.Add("nom");
                    table.Columns.Add("id");

                    for (int i = qur5.Count - 1; i >= 0; i--)
                        table.Rows.Add(qur5[i].nom, qur5[i].id);

                    anneecomboBox141.DataSource = table;
                    anneecomboBox141.DisplayMember = "nom";
                    anneecomboBox141.ValueMember = "id";

                }
                catch { }

            }
            catch (Exception ex)
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
                loadmoye();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }
        public DataTable conff;
        
        public void loadmoye()
        {
            if (seccomboBox.SelectedValue != null) { 
            idsec = int.Parse(seccomboBox.SelectedValue.ToString());
            }
            else {MessageBox.Show("auccune section selicatione"); }
          if(smstcomboBox13.SelectedValue!=null)
            idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());
            else { MessageBox.Show("auccune semmestre selicatione"); }
            if(anneecomboBox141.SelectedValue!=null) { 
            idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());
            }
            else { MessageBox.Show("auccune annnee selicatione"); }
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
                    try
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
                    catch { }
                }
                if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                {
                    DataRow dro;
                    dro = dt.NewRow();

                    dro[0] = qres.Numro_STG;
                    dro[1] = qres.Nom_Et_Prenom;

                    if (chikdeavenrtp.Checked == true)
                    {
                        if ( qres.mynav != null)
                        dro[qres.module] = qres.mynav;
                        else MessageBox.Show("pas de moy de d'exmaine");

                    }
                    else
                    {
                        if (qres.mynap != null)
                            dro[qres.module] = Math.Max((double)qres.mynav, (double)qres.mynap);
                        else MessageBox.Show("pas de moy de ratrpage");
                        
                    }

                    dt.Rows.Add(dro);
                }

            }
            dt.Columns.Add("MG",typeof(double));
            dt.Columns.Add("OPS");
            //calucle de la moynne ginarale et affictation des ops

            foreach(DataRow rowstg in dt.Rows)
            {
                double moyne = 0;
                int cooff = 0;
                bool rat = false;
                foreach (DataRow coof in conff.Rows)
                {
                    try
                    {
                        moyne += (double)((double)(rowstg[coof[0].ToString()]) * int.Parse(coof[1].ToString()));
                        cooff += int.Parse(coof[1].ToString());
                        if (int.Parse(coof[2].ToString()) > (double)(rowstg[coof[0].ToString()]))
                        {
                            rat = true;
                        }
                    }
                    catch { }
                }
                rowstg["MG"] = (moyne / cooff);
                if ( rat==true ||float.Parse(rowstg["MG"].ToString())<10)
                {
                    if (chikdeavenrtp.Checked == true)
                    {
                        rowstg["OPS"] = "Ratt";
                    }
                }
                else
                {
                    rowstg["OPS"] = "Admis";
                }
            }
            NUBEREF.Text = dt.Rows.Count.ToString();
            gridControl1.DataSource = dt;
            gridView1.OptionsBehavior.ReadOnly = true;




        }



        



      


       

        

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
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
                            //e.Appearance.BackColor = Color.FromArgb(0xD2, 0xFD, 0x91);
                            e.Appearance.BackColor = Color.Orange;

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

