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

namespace gtsco2.forms.GTabsences
{
    public partial class addabsences : DevExpress.XtraEditors.XtraForm
    {
        public addabsences()
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


                var qur = from sp in shared.bd.Opations select new { id = sp.ID_Option, nom = sp.Code_Option };

                spcomboBox1.DataSource = qur.ToList();
                spcomboBox1.DisplayMember = "nom";
                spcomboBox1.ValueMember = "id";

                var qur1 = from pr in shared.bd.Promoes
                           join po in shared.bd.Opations on pr.ID_Option equals po.ID_Option
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
                           join po in shared.bd.Opations on sec.ID_Option equals po.ID_Option
                           join mo in shared.bd.Mode_formation on sec.ID_Mode_Formation equals mo.ID_Mode_Formation
                           join pro in shared.bd.Promoes on sec.ID_Promo equals pro.ID_Promo
                           select new { id = sec.SectionID, nom = (mo.Code_Mode_Formation + po.Code_Option + pro.Code_Promo + " " + sec.Code_Section) };

                seccomboBox.DataSource = qur3.ToList();
                seccomboBox.DisplayMember = "nom";
                seccomboBox.ValueMember = "id";

                var qur4 = from mod in shared.bd.Modules
                           select new { id=mod.ID_Module, nom=mod.Designation_Module };

              

                var qur5 = from ann in shared.bd.annee_scolaire
                           select new { id = ann.ID_Année_SCO, nom = (ann.disination + ann.Session_Année_SCO) };
                anneecomboBox141.DataSource = qur5.ToList();
                anneecomboBox141.DisplayMember = "nom";
                anneecomboBox141.ValueMember = "id";

                 

            }catch (Exception ex)
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
                       join po in shared.bd.Opations on pr.ID_Option equals po.ID_Option
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
                           join po in shared.bd.Opations on sec.ID_Option equals po.ID_Option
                           join mo in shared.bd.Mode_formation on sec.ID_Mode_Formation equals mo.ID_Mode_Formation
                           join pro in shared.bd.Promoes on sec.ID_Promo equals pro.ID_Promo
                           where sec.ID_Promo == sp
                           select new { id = sec.SectionID, nom = (mo.Code_Mode_Formation + po.Code_Option + pro.Code_Promo + " " + sec.Code_Section) };

                seccomboBox.DataSource = qur3.ToList();
                seccomboBox.DisplayMember = "nom";
                seccomboBox.ValueMember = "id";



                



            }
            catch(Exception ex)
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

                datee = dateEdit1.DateTime;
                
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                if (datee > new DateTime(1000,01,01))
                {
                    using (DataTable dt = new DataTable())
                    {

                        dt.Columns.Add("Numro_STG");

                        dt.Columns.Add("Nom_et_Prenom");
                        dt.Columns.Add("Seance_1", typeof(bool));
                        dt.Columns.Add("Seance_2", typeof(bool));
                        dt.Columns.Add("Seance_3", typeof(bool));
                        dt.Columns.Add("Seance_4", typeof(bool));
                        dt.Columns.Add("Absonce_Justfer", typeof(bool));
                        dt.Columns.Add("Justfiction");


                        idsec = int.Parse(seccomboBox.SelectedValue.ToString());
                        idsem = int.Parse(smstcomboBox13.SelectedValue.ToString());
                        
                        idannee = int.Parse(anneecomboBox141.SelectedValue.ToString());

                        var qure = from abs in shared.bd.Absences
                                   join stg in shared.bd.Stagiairs on abs.Num_STG equals stg.Num_STG
                                   where stg.Section == idsec && abs.ID_Année_SCO == idannee && abs.ID_Semestre == idsec && abs.Date_ABS == dateEdit1.DateTime
                                   select new
                                   {
                                       Numro_STG = stg.Num_STG,
                                       Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                       Seance_1 = abs.Seance_1_ABS,
                                       Seance_2 = abs.Seance_2_ABS,
                                       Seance_3 = abs.Seance_3_ABS,
                                       Seance_4 = abs.Seance_4_ABS,
                                       Absonce_Justfer = abs.Absence_Justifer,
                                       Justfiction = abs.Justif_ABS


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




                                        dt.Rows.Add(row.Numro_STG, row.Nom_et_Prenom, row.Seance_1, row.Seance_2, row.Seance_3, row.Seance_4, row.Absonce_Justfer, row.Justfiction);
                                        
                                        a = "g";
                                        break;

                                    }
                                    else
                                    {
                                        a = "f";
                                    }
                                }
                                if (a == "f" || qure.ToList().Count == 0)
                                {
                                    dt.Rows.Add(stg.Num_STG, (stg.Nom + " " + stg.Prenom), false, false, false, false, false);

                                }
                            }
                        }
                        gridControl1.DataSource = dt;
                        NUBEREF.Text = dt.Rows.Count.ToString();
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
            

                else { MessageBox.Show("Veuillez selectioné une date d'absence"); }
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



            try
            {
                DataTable dt = gridControl1.DataSource as DataTable;

                int z = 1;
                if (dt!=null&& dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        basededonne.Absence ev = new basededonne.Absence();



                        ev.ID_Année_SCO = idannee;

                        ev.Num_STG = row["Numro_STG"].ToString();
                        ev.ID_Semestre = idsem;


                        if (row["Seance_1"].ToString() != null)
                        {
                            ev.Seance_1_ABS = bool.Parse(row["Seance_1"].ToString());
                        }
                        if (row["Seance_2"].ToString() != null)
                        {
                            ev.Seance_2_ABS = bool.Parse(row["Seance_2"].ToString());
                        }
                        if (row["Seance_3"].ToString() != null)
                        {
                            ev.Seance_3_ABS = bool.Parse(row["Seance_3"].ToString());
                        }
                        if (row["Seance_4"].ToString() != null)
                        {
                            ev.Seance_4_ABS = bool.Parse(row["Seance_4"].ToString());
                        }
                        if (row["Absonce_Justfer"].ToString() != null)
                        {
                            ev.Absence_Justifer = bool.Parse(row["Absonce_Justfer"].ToString());
                        }
                        if ((row["Justfiction"].ToString()) != "")
                        {
                            ev.Justif_ABS = row["Justfiction"].ToString();
                        }

                        ev.Date_ABS = datee;


                

                        //shared.bd.SaveChanges();

                        try
                        {
                            if (shared.bd.Absences.First(a => a.Num_STG == ev.Num_STG && a.ID_Année_SCO == ev.ID_Année_SCO && a.ID_Semestre == ev.ID_Semestre && a.Date_ABS == ev.Date_ABS) != null)
                            {
                                var eb = shared.bd.Absences.First(a => a.Num_STG == ev.Num_STG && a.ID_Année_SCO == ev.ID_Année_SCO && a.ID_Semestre == ev.ID_Semestre && a.Date_ABS == ev.Date_ABS);
                                ev.ID_Absence = eb.ID_Absence;

                                //shared.bd.Entry(ev).State = System.Data.Entity.EntityState.Modified;
                                shared.bd.Absences.AddOrUpdate(ev);
                                z = 2;

                            }
                            else
                            {

                            }

                        }
                        catch
                        {
                            z = 3;

                            shared.bd.Absences.Add(ev);

                            
                        }
                    }
                    if (z == 1)
                    {
                        MessageBox.Show(" Aucune valeur n'a été enregistrée!");
                        
                    }
                    else if (z == 2)
                    {
                        save();
                        MessageBox.Show("Modifications enregistrées avec succés!");
                       
                    }
                    else if (z == 3)
                    {    save();
                        MessageBox.Show("Mise à jour enregistrée avec succés!");
                       
                    }

                 
                }
                else { MessageBox.Show("Aucune information n'existe sur le tableau"); }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Affichez puis appliquez des modifications sur le tableau, pour ensuite enregistré vos informations");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        

        public void save()
        {
            try
            {
            
          
                shared.bd.SaveChanges();
            
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


                    DialogResult r = MessageBox.Show("Vous etes sur le point de supprimer toutes les données enregistrées à la date : " + datee, "", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)

                    {
                        try
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                basededonne.Absence ev = new basededonne.Absence();
                                ev.Num_STG = row["Numro_STG"].ToString();
                                ev.Date_ABS = datee ;
                                ev.ID_Année_SCO = idannee;
                                ev.ID_Semestre = idsem;
                               
                                var en = shared.bd.Absences.First(a => a.Num_STG == ev.Num_STG && a.ID_Année_SCO == ev.ID_Année_SCO && a.Date_ABS == ev.Date_ABS && a.ID_Semestre == ev.ID_Semestre);
                                shared.bd.Absences.Remove(en);

                            }
                            save();
                            refrech();
                            MessageBox.Show("Les données ont été supprimé avec succés");

                        }
                        catch (Exception ex) { MessageBox.Show(" Le tableau ne contient aucune donnée!"); }
                        refrech();
                    
                    }
                    
                }
                else { MessageBox.Show("Le tableau ne contient aucune donnée à supprimer!"); }


            }

            catch (NullReferenceException ) { MessageBox.Show("Veuillez affichez votre tableau pour supprimer son contenue! "); }

            catch  (Exception ex) { MessageBox.Show(ex.ToString());}

        }

       

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            add();
           
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
            add();            
            gridControl1.ShowPrintPreview();
        }





        private void simpleButton1_Click(object sender, EventArgs e)
        {
            refrech();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            edit();
        }

        private void closeButton7_Click_1(object sender, EventArgs e)
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
    }
}
