using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace gtsco2.forms
{
    public partial class form : DevExpress.XtraEditors.XtraForm
    {
        public form()
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
                    var qure = from mod in shared.bd.Mode_formation select new { id = mod.ID_Mode_Formation, nom = mod.Désignation_Mode_Formation };

                   

                    modecombobox.DataSource = qure.ToList();
                    modecombobox.DisplayMember = "nom";
                    modecombobox.ValueMember = "id";
                }
                catch { }


                try
                {
                    var  qur = from op in shared.bd.Options
                                   join sp in shared.bd.Specialites on op.Specialite equals sp.ID_Specialité

                                   select new { id = op.ID_Option, nom = (sp.Designation_SP + " option: " + op.Designation_Option) };

                    spcomboBox1.DataSource = qur.ToList();
                    spcomboBox1.DisplayMember = "nom";
                    spcomboBox1.ValueMember = "id";
                }
                catch { }

                try
                {
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
                }
                catch { }

                try
                {
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
                    var qur4 = from mod in shared.bd.Modules
                               select new { id = mod.ID_Module, nom = mod.Designation_Module };

                    modulcomboBox14.DataSource = qur4.ToList();
                    modulcomboBox14.DisplayMember = "nom";
                    modulcomboBox14.ValueMember = "id";
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

                try
                {
                    var qur6 = from ens in shared.bd.Enseignants
                               select new { id = ens.id_Enseignant, nom = (ens.Nom + " " + ens.prenom) };
                    comboBox1Enseignant.DataSource = qur6.ToList();
                    comboBox1Enseignant.DisplayMember = "nom";
                    comboBox1Enseignant.ValueMember = "id";
                }
                catch { }


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
            {int sp = int.Parse(spcomboBox1.SelectedValue.ToString());
                try
                {
                    
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
                catch { }
                try
                {
                    modulcomboBox14.DataSource = null;
                    modulcomboBox14.Items.Clear();
                

                var qur4 = from mod in shared.bd.Modules
                           where mod.ID_Option == sp
                           select new { id = mod.ID_Module, nom = mod.Designation_Module };

                modulcomboBox14.DataSource = qur4.ToList();
                modulcomboBox14.DisplayMember = "nom";
                modulcomboBox14.ValueMember = "id";
                }
                catch { }
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
        int idmod;



        public void refrech()
        {
            try
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                using (DataTable dt = new DataTable())
                {
                    dt.Columns.Add("Numro_STG");

                    dt.Columns.Add("Nom_et_Prenom");
                    dt.Columns.Add("Control1",typeof(double));
                    dt.Columns.Add("Control2",typeof(double));
                    dt.Columns.Add("Exam",typeof(double));
                    dt.Columns.Add("Rattrapage",typeof(double));
                    if(seccomboBox.SelectedValue.ToString()!=null)
                        idsec = int.Parse(seccomboBox.SelectedValue.ToString());


                    if (smstcomboBox13.SelectedValue.ToString() != null)
                        idsem = int.Parse(smstcomboBox13.SelectedValue.ToString()); 
                if (modecombobox.SelectedValue.ToString() != null)
                    idmod = int.Parse(modulcomboBox14.SelectedValue.ToString()); 
                     if (anneecomboBox141.SelectedValue.ToString() != null)
                idannee = int.Parse(anneecomboBox141.SelectedValue.ToString()); 
                    
                    var reqe = (from evalue in shared.bd.Evaluations
                                join stg in shared.bd.Stagiairs on evalue.Num_STG equals stg.Num_STG
                                where stg.Section == idsec && evalue.ID_Module == idmod && evalue.ID_Semestre == idsem && evalue.ID_Année_SCO == idannee

                                select new { Numro_STG = stg.Num_STG, Nom_et_Prenom = (stg.Nom + " " + stg.Prenom), Control1 = evalue.Control_1, Control2 = evalue.Control_2, Exam = evalue.Exam, Rattrapage = evalue.Rattrapage, evalue.Enseignant }).ToList();
                    string a = "r";
                    foreach (basededonne.Stagiair stg in shared.bd.Stagiairs)
                    {

                        if (stg.Section == idsec)
                        {

                            foreach (var rege in reqe.ToList())
                            {
                                if (rege.Numro_STG == stg.Num_STG)
                                {
                                  
                                    dt.Rows.Add(rege.Numro_STG, rege.Nom_et_Prenom, rege.Control1, rege.Control2, rege.Exam, rege.Rattrapage);
                                    try
                                    {
                                        comboBox1Enseignant.SelectedValue = rege.Enseignant;
                                    }
                                    catch { }
                                    a = "g";
                                    break;
                                }
                                else
                                {
                                    a = "f";
                                }
                            }
                            if (a == "f" || reqe.Count == 0)
                            {
                                dt.Rows.Add(stg.Num_STG, (stg.Nom + " " + stg.Prenom));
                            }
                        }
                    }
                    NUBEREF.Text = dt.Rows.Count.ToString();
                    gridControl1.DataSource = dt;
                    visablrtp();
                    if (a == "g")
                    {
                        gridView1.OptionsBehavior.ReadOnly = true;
                    }
                    else
                    {
                        edit();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void visablrtp()
        {
            try

            {
                if (gridView1.Columns.Count > 0)
                {
                    if (avenrtp.Checked == true)
                    {
                        if(gridView1.Columns.Count > 6)
                        {
                            gridView1.Columns["moyenne_apres_r"].Visible = false;
                        }

                        gridView1.Columns["Rattrapage"].Visible = false;

                    }
                    else {
                        if (gridView1.Columns.Count > 6)
                        {
                            gridView1.Columns["moyenne_apres_r"].Visible = true;
                        }
                        gridView1.Columns["Rattrapage"].Visible = true; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        public void add()
        {

            string s = "s";

            try
            {



                DataTable dt = gridControl1.DataSource as DataTable;

                {
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {

                            basededonne.Evaluation ev = new basededonne.Evaluation();



                            ev.ID_Année_SCO = idannee;
                            ev.ID_Module = idmod;
                            ev.Num_STG = row["Numro_STG"].ToString();
                            ev.ID_Semestre = idsem;
                            if (comboBox1Enseignant.SelectedValue != null)
                            {
                                ev.Enseignant = int.Parse(comboBox1Enseignant.SelectedValue.ToString());
                            }
                            

                            if (row["Control1"].ToString() != "" )
                            {
                                ev.Control_1 = float.Parse(row["Control1"].ToString());
                            }
                            if (row["Control2"].ToString() != "")
                            {
                                ev.Control_2 = float.Parse(row["Control2"].ToString());
                            }
                            if (row["Exam"].ToString() != "")
                            {
                                ev.Exam = float.Parse(row["Exam"].ToString());
                            }
                            
                                if (row["Rattrapage"].ToString() != "")
                                {
                                    ev.Rattrapage = float.Parse(row["Rattrapage"].ToString());
                                }

                            //calcule de la moyenne de module

                            if (ev.Control_1 != null && ev.Control_2 != null && ev.Exam != null && ev.Rattrapage != null)
                            {

                                ev.Moyenne_Module_AvRt = (double)((ev.Control_2 + ev.Control_1 + ev.Exam) / 4);

                                if (radio1avin.Checked == true)
                                {
                                    ev.Moyenne_Module_ApRt = (double)((ev.Control_2 + ev.Control_1 + Math.Max((double)ev.Exam, ((double)ev.Rattrapage * 2))) / 4);
                                }
                                else { ev.Moyenne_Module_ApRt =  Math.Max((double)ev.Moyenne_Module_AvRt, (double)ev.Rattrapage ); }


                            }
                            else if (ev.Control_1 != null && ev.Control_2 == null && ev.Exam != null && ev.Rattrapage != null)
                            {
                                ev.Moyenne_Module_AvRt = (double)((ev.Control_1 + ev.Exam) / 3);

                                if (radio1avin.Checked == true)
                                {
                                    ev.Moyenne_Module_ApRt = (double)((ev.Control_1 + Math.Max((double)ev.Exam, ((double)ev.Rattrapage * 2))) / 3);
                                }
                                else {
                                    ev.Moyenne_Module_ApRt = Math.Max((double)ev.Moyenne_Module_AvRt, (double)ev.Rattrapage);
                                }
                            }
                            else if (ev.Control_1 != null && ev.Control_2 == null && ev.Exam != null && ev.Rattrapage == null)
                            {
                                ev.Moyenne_Module_AvRt = (double)((ev.Control_1 + ev.Exam) / 3);
                            }
                            else if (ev.Control_1 != null && ev.Control_2 != null && ev.Exam != null && ev.Rattrapage == null)
                            {
                                ev.Moyenne_Module_AvRt = (double)((ev.Control_2 + ev.Control_1 + ev.Exam) / 4);


                            }


                            try
                            {
                                
                                if (shared.bd.Evaluations.First(a => a.Num_STG == ev.Num_STG && a.ID_Année_SCO == ev.ID_Année_SCO && a.ID_Module == ev.ID_Module && a.ID_Semestre == ev.ID_Semestre) != null)

                                {
                                    
                                    //shared.bd.Entry(ev).State = System.Data.Entity.EntityState.Modified;
                                    shared.bd.Evaluations.AddOrUpdate(ev);
                                    s = "m";
                                    
                                }
                                else
                                {

                                }
                            }
                            catch
                            {
                                
                                shared.bd.Evaluations.Add(ev);
                                s = "b";
                                
                                
                            }
                           
                        }
                      
                        if (s == "b")
                        {
                            MessageBox.Show(" Données Enregistres avec succès ");//donnne enregistre
                            
                        }
                        else
                        {
                            MessageBox.Show("Données mise à jours avec succès");
                            
                        }
                    }
                    else { MessageBox.Show("Affichez d'abord le tableau pour ensuite ajouter des données"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        public void vprint( int btn)
        {
            try
            {

                List<eva> listeva = new List<eva>();
            listeva.Clear();

            DataTable dt = gridControl1.DataSource as DataTable;


            if (dt != null)
            {  
                foreach (DataRow row in dt.Rows)
                {
                    eva ev = new eva();

                    ev.Numro_STG = row["Numro_STG"].ToString();
                    ev.Nom_Prenom = row["Nom_et_Prenom"].ToString();
                    if (row["Control1"].ToString() != "")
                    {
                        ev.Control_1 = row["Control1"].ToString();
                    }
                    if (row["Control2"].ToString() != "")
                    {
                        ev.Control_2 = row["Control2"].ToString();
                    }
                    if (row["Exam"].ToString() != "")
                    {
                        ev.Exam = row["Exam"].ToString();
                    }
                    if (row["Rattrapage"].ToString() != "")
                    {
                        ev.Rattarpage = row["Rattrapage"].ToString();
                    }
                    if(dt.Columns.Count > 6)
                        {
                            if (row["moyenne_avr"].ToString() != "")
                            {
                                ev.MoyAvenR = row["moyenne_avr"].ToString();
                            }
                            if (row["moyenne_apres_r"].ToString() != "")
                            {
                                ev.MoyApresR = row["moyenne_apres_r"].ToString();
                            }
                        }

                    listeva.Add(ev);






                  




                }
                int spd = int.Parse(spcomboBox1.SelectedValue.ToString());
                var qure = (from op in shared.bd.Options
                            join sp in shared.bd.Specialites on op.Specialite equals sp.ID_Specialité
                            where op.ID_Option == spd
                            select new { spelite = (sp.Designation_SP + " option: " + op.Designation_Option) });
                string spe = "";
                foreach (var qur in qure.ToList())
                {
                    spe = qur.spelite;
                }



                    string ens = comboBox1Enseignant.Text;
                    string idane = anneecomboBox141.Text;
                string sec = seccomboBox.Text;
                string mod = modulcomboBox14.Text;
                string pro = promocomboBox11.Text;

                    if (btn == 1)
                    {
                        using (print.documintview frm = new print.documintview())
                        {
                            frm.printdata(idane, spe, pro, sec, mod, listeva, ens);
                            frm.ShowDialog();


                        }
                    }
                    else
                    {
                        GSTnote.reportNoteAvicMoy.Report1noteAvicMoy.load(idane, spe, pro, sec, mod, listeva, ens);
                    }

                        
                        


                        
                    
            }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

       

        // affichage des note avic lure moyenne
        public void AffichagheNoteAvicMoyenne()
        {
            try
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                using (DataTable dt = new DataTable())
                {
                    dt.Columns.Add("Numro_STG");

                    dt.Columns.Add("Nom_et_Prenom");
                    dt.Columns.Add("Control1", typeof(double));
                    dt.Columns.Add("Control2",typeof(double));
                    dt.Columns.Add("Exam", typeof(double));
                    dt.Columns.Add("moyenne_avr", typeof(double));
                    dt.Columns.Add("Rattrapage", typeof(double));
                    dt.Columns.Add("moyenne_apres_r", typeof(double));

                    idsec = int.Parse(seccomboBox.SelectedValue.ToString());
                    idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());
                    idmod = int.Parse(modulcomboBox14.SelectedValue.ToString());
                    idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());
                    var reqe = (from evalue in shared.bd.Evaluations
                                join stg in shared.bd.Stagiairs on evalue.Num_STG equals stg.Num_STG
                                where stg.Section == idsec && evalue.ID_Module == idmod && evalue.ID_Semestre == idsem && evalue.ID_Année_SCO == idannee

                                select new
                                {
                                    Numro_STG = stg.Num_STG,
                                    Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                    Control1 = evalue.Control_1,
                                    Control2 = evalue.Control_2,
                                    Exam = evalue.Exam,
                                    Rattrapage = evalue.Rattrapage,
                                     evalue.Moyenne_Module_AvRt,
                                     evalue.Moyenne_Module_ApRt
                                }).ToList();
                    string a = "r";


                    foreach (basededonne.Stagiair stg in shared.bd.Stagiairs)
                    {

                        if (stg.Section == idsec)
                        {

                            foreach (var rege in reqe.ToList())
                            {
                                if (rege.Numro_STG == stg.Num_STG)
                                {

                                    dt.Rows.Add(rege.Numro_STG, rege.Nom_et_Prenom, rege.Control1, rege.Control2, rege.Exam, rege.Moyenne_Module_AvRt, rege.Rattrapage, rege.Moyenne_Module_ApRt);
                                    a = "g";
                                    break;

                                }
                                else
                                {
                                    a = "f";
                                }
                            }
                            if (a == "f" || reqe.Count == 0)
                            {
                                dt.Rows.Add(stg.Num_STG, (stg.Nom + " " + stg.Prenom));
                            }
                        }
                    }
                    
                        NUBEREF.Text = dt.Rows.Count.ToString();
                        gridControl1.DataSource = dt;
                        visablrtp();
                        if (a == "g")
                        {
                            gridView1.OptionsBehavior.ReadOnly = true;
                        }
                        else
                        {
                            edit();

                        }

                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     

        public void save()
        {
            try
            {

                shared.bd.SaveChanges();
                //MessageBox.Show("Données enregistrées ");
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);

            }

        }

        public void delite()
        {
            try

            {
                DataTable dt = gridControl1.DataSource as DataTable;

                if (dt.Rows.Count > 0)
                {
                    DialogResult r = MessageBox.Show("Vous êtes sur le point de supprimer toutes les données ", "", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                basededonne.Evaluation ev = new basededonne.Evaluation();
                                ev.Num_STG = row["Numro_STG"].ToString();
                                ev.ID_Module = idmod;
                                ev.ID_Année_SCO = idannee;
                                ev.ID_Semestre = idsem;
                               
                                var en = shared.bd.Evaluations.First(a => a.Num_STG == ev.Num_STG && a.ID_Année_SCO == ev.ID_Année_SCO && a.ID_Module == ev.ID_Module && a.ID_Semestre == ev.ID_Semestre);
                                shared.bd.Evaluations.Remove(en);

                            }
                           
                            save();
                            refrech();
                            MessageBox.Show("Les données ont été supprimé avec succés");

                        }
                        catch (Exception) { MessageBox.Show(" Le tableau ne contient aucune donnée!"); }
                        refrech();
                    }
                }
                else { MessageBox.Show("Aucune donnée à supprimer"); }
            }
            catch { }

        }



        private void simpleButton6_Click(object sender, EventArgs e)
        {
            add();
            save();
        }

        private void avenrtp_CheckedChanged(object sender, EventArgs e)
        {
            visablrtp();
        }

        private void removeButton1_Click(object sender, EventArgs e)
        {
            delite();
        }

      
        private void closeButton7_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Sauvgardé et fermé la fenêtre? ", "Fermeture de la fenêtre", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                add();
                save();
                
                Close();
                
                
            }
            else
            {
                MessageBox.Show("Donnée non sauvgarder, la fenêtre va se fermé ");
                Close();
               
            }
        }



        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            edit();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            refrech();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //add();
            //save();
            ////refrech();

            vprint(1);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            AffichagheNoteAvicMoyenne();
        }

        private void modecombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

            
            int selcted = int.Parse(modecombobox.SelectedValue.ToString());

                comboBox1Enseignant.DataSource = null;
                comboBox1Enseignant.Items.Clear();
                var qur6 = from ens in shared.bd.Enseignants
                       where ens.Mode_Formation ==selcted
                       select new { id = ens.id_Enseignant, nom = (ens.Nom + " " + ens.prenom) };
            comboBox1Enseignant.DataSource = qur6.ToList();
            comboBox1Enseignant.DisplayMember = "nom";
            comboBox1Enseignant.ValueMember = "id";
            }catch
            {
               
            }

           
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            vprint(2);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class eva
    {

        public string Numro_STG { get; set; }

        public string Nom_Prenom { get; set; }

        public string Control_1 { get; set; }

        public string Control_2 { get; set; }

        public string Exam { get; set; }

        public string MoyAvenR { get; set; }

        public string MoyApresR { get; set; }

        public string Rattarpage { get; set; }
    }
}

