using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using gtsco2.classe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.GTSecetion
{
    public partial class GTsectionfrm : DevExpress.XtraEditors.XtraForm
    {
        public GTsectionfrm()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            List<basededonne.Mode_formation> list = shared.bd.Mode_formation.ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("disc");

            foreach (basededonne.Mode_formation ro in list)
            {
                dt.Rows.Add(ro.Code_Mode_Formation, ro.Désignation_Mode_Formation);
            }
            modecomboBox117.DataSource = dt;
            modecomboBox117.DisplayMember = dt.Columns[1].ColumnName;
            modecomboBox117.ValueMember = dt.Columns[0].ColumnName;
           

            modecombobox17.DataSource = dt;
            modecombobox17.DisplayMember = dt.Columns[1].ColumnName;
            modecombobox17.ValueMember = dt.Columns[0].ColumnName;


            var qur = from sp in shared.bd.Options select new { id = sp.ID_Option, nom = sp.Code_Option };

            spcomboBox1.DataSource = qur.ToList();
            spcomboBox1.DisplayMember = "nom";
            spcomboBox1.ValueMember = "id";

            spcomboBox113.DataSource = qur.ToList();
            spcomboBox113.DisplayMember = "nom";
            spcomboBox113.ValueMember = "id";

            var qur1 = from pr in shared.bd.Promoes
                       join po in shared.bd.Options on pr.ID_Option equals po.ID_Option
                       join mo in shared.bd.Mode_formation on pr.Mode_de_formation equals mo.ID_Mode_Formation
                       select new { id = pr.ID_Promo, nom = (mo.Code_Mode_Formation + po.Code_Option + pr.Code_Promo) };

            promocomboBox11.DataSource = qur1.ToList();
            promocomboBox11.DisplayMember = "nom";
            promocomboBox11.ValueMember = "id";

            promocomboBox114.DataSource = qur1.ToList();
            promocomboBox114.DisplayMember = "nom";
            promocomboBox114.ValueMember = "id";



            var qur3 = from sec in shared.bd.Sections
                       join po in shared.bd.Options on sec.ID_Option equals po.ID_Option
                       join mo in shared.bd.Mode_formation on sec.ID_Mode_Formation equals mo.ID_Mode_Formation
                       join pro in shared.bd.Promoes on sec.ID_Promo equals pro.ID_Promo
                       select new { id = sec.SectionID, nom = (mo.Code_Mode_Formation + po.Code_Option + pro.Code_Promo + " " + sec.Code_Section) };

            seccomboBox.DataSource = qur3.ToList();
            seccomboBox.DisplayMember = "nom";
            seccomboBox.ValueMember = "id";


            seccomboBox15.DataSource = qur3.ToList();
            seccomboBox15.DisplayMember = "nom";
            seccomboBox15.ValueMember = "id";

           

        }


        public  DataTable refrach( int promo , int section,bool sec , bool pro)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Numro_STG");
            dt.Columns.Add("Nom et prenom");
            dt.Columns.Add("Date de Naissance");
            try
            {
                

                if (pro == false && sec == true)
                {
                    
                    var qurz = from stg in shared.bd.Stagiairs
                               where stg.ID_Promo == promo && stg.Section == section
                               select new
                               {
                                   Numro_STG = stg.Num_STG,
                                   Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                   Date_de_Naissance = stg.Date_de_Naissance
                               };
                    
                    foreach ( var row in qurz.ToList())
                    {
                        dt.Rows.Add(row.Numro_STG, row.Nom_et_Prenom, row.Date_de_Naissance);
                    }
                    
                    return dt;
                    
                }
                else if (pro == false && sec == false)
                {
                   var qurf = (from stg in shared.bd.Stagiairs
                            where stg.ID_Promo == promo
                            select new
                            {
                                Numro_STG = stg.Num_STG,
                                Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                Date_de_Naissance = stg.Date_de_Naissance
                            } ).ToList();
                    foreach (var row in qurf.ToList())
                    {
                        dt.Rows.Add(row.Numro_STG, row.Nom_et_Prenom, row.Date_de_Naissance);
                    }

                    return dt;
                }
                else if (pro == true)
                {
                    var qure = from stg in shared.bd.Stagiairs
                              where stg.ID_Promo == promo && stg.Section == null
                              select new
                              {
                                  Numro_STG = stg.Num_STG,
                                  Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                  Date_de_Naissance = stg.Date_de_Naissance
                              };
                    foreach (var row in qure.ToList())
                    {
                        dt.Rows.Add(row.Numro_STG, row.Nom_et_Prenom, row.Date_de_Naissance);
                    }

                    return dt;
                }
                
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
            var qur = (from stg in shared.bd.Stagiairs

                           select new
                           {

                           }) ;
           

            return dt;

           


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      

        public void lefttoright()
        {
            try
            {
                if (gridView1.GetSelectedRows().Count() > 0)
                {


                    DataTable dt = gridControl2.DataSource as DataTable;
                    if (gridView1.OptionsSelection.MultiSelectMode == GridMultiSelectMode.CheckBoxRowSelect)
                    {
                        List<int> ab = new List<int>();
                        foreach (int i in gridView1.GetSelectedRows())
                        {
                            //Recuperation de l'index de la ligne selectionnée
                            int IndexLigne = gridView1.GetRowHandle(i);

                            //ou même récupérer la ligne pour en faire ce que tu veux
                            DataRow rows = gridView1.GetDataRow(IndexLigne);
                            if (dt != null)
                            {
                                dt.Rows.Add(rows[0], rows[1], rows[2]);
                                ab.Add(IndexLigne);

                            }
                            else { MessageBox.Show("Veuillez sélectionner la section dans laquelle vous voulez affectés les stagiaires (s)! puis affichez le teableau de droite ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        for (int i = ab.Count() - 1; i >= 0; i--)
                        {
                            //Recuperation de l'index de la ligne selectionnée
                            int IndexLigne = gridView1.GetRowHandle(ab[i]);

                            //ou même récupérer la ligne pour en faire ce que tu veux
                            DataRow rows = gridView1.GetDataRow(IndexLigne);
                            if (dt != null)
                            {
                                gridView1.DeleteRow(IndexLigne);

                            }
                            else { MessageBox.Show("Veuillez sélectionner la section dans laquelle vous voulez affectés les stagiaires (s)! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }

                        }
                        NUBEREF.Text = gridView1.DataRowCount.ToString();
                        NUBEREF2.Text = gridView2.DataRowCount.ToString();
                    }
                    else
                    {

                        //MessageBox.Show("Veuillez sélectionner la même promos sur les 2 tableaux");
                        //MessageBox.Show("selection des section  de la meme promo sur le diex tablo");

                    }
                }
                else {
                    MessageBox.Show("Veuillez selectionner les informations que vous souhaitez afficher ensuite affichez le tableau de droite puis cocher la case correspondante au stagiaire que vous voulez transferer", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

            }

            catch(NullReferenceException)
            {
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


          



        }
        public void righttolet()
        {
            try
            {
                if (gridView2.GetSelectedRows().Count() > 0)
                {

                    DataTable dt = gridControl1.DataSource as DataTable;
                    if (gridView2.OptionsSelection.MultiSelectMode == GridMultiSelectMode.CheckBoxRowSelect)
                    {
                        List<int> ab = new List<int>();
                        foreach (int i in gridView2.GetSelectedRows())
                        {
                            //Recuperation de l'index de la ligne selectionnée
                            int IndexLigne = gridView2.GetRowHandle(i);

                            //ou même récupérer la ligne pour en faire ce que tu veux
                            DataRow rows = gridView2.GetDataRow(IndexLigne);
                            if (dt != null)
                            {
                                dt.Rows.Add(rows[0], rows[1], rows[2]);
                                ab.Add(IndexLigne);

                            }
                            else { 
                                
                                MessageBox.Show("Veuillez sélectionner la section dans laquelle vous voulez affectés les stagiaires (s)! puis affichez le teableau de gauche ", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                            //MessageBox.Show("selection la section donne que vous voule effactue le stg ");
                        }
                        for (int i = ab.Count() - 1; i >= 0; i--)
                        {
                            //Recuperation de l'index de la ligne selectionnée
                            int IndexLigne = gridView2.GetRowHandle(ab[i]);

                          
                            if (dt != null)
                            {
                                gridView2.DeleteRow(IndexLigne);

                            }
                            else {

                                MessageBox.Show("Veuillez sélectionner la section dans laquelle vous voulez affectés les stagiaires (s)! ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                break;

                                //MessageBox.Show("selection la section donne que vous voule effactue le stg ");
                                //break;
                            }

                        }
                        NUBEREF.Text = gridView1.DataRowCount.ToString();
                        NUBEREF2.Text = gridView2.DataRowCount.ToString();
                    }
                    else
                    {

                        MessageBox.Show("Veuillez sélectionner la même promos sur les 2 tableaux");
                        //MessageBox.Show("selection des section  de la meme promo sur le diex tablo");

                    }
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner les informations que vous souhaitez afficher ensuite affichez le tableau de gauche puis cocher la case correspondante au stagiaire que vous voulez transferer");
                }
            }
            catch (NullReferenceException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void save1()
        {
            try {
                int promo = int.Parse(promocomboBox11.SelectedValue.ToString());
                int sec = int.Parse(seccomboBox.SelectedValue.ToString());
                bool sec1 = Sec1checkEdit1.Checked;
                bool pro1 = pro1checkEdit1.Checked;
                DataTable tbsv = gridControl1.DataSource as DataTable;
                if (tbsv != null)
                {
                    if (pro1 == false && sec1 == true)
                    {
                        if (pro1 == false && sec1 == true)
                        {
                            DialogResult r = MessageBox.Show("Etes-vous sure de vouloir enregistrer ce (s) stagiaire (s) sur la section:  " + seccomboBox.Text + " de la promo: " + promocomboBox11.Text + "", "", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                            if (r == DialogResult.Yes)
                            {

                                foreach (DataRow row in tbsv.Rows)
                                {

                                    string ab = row[0].ToString();

                                    var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                    stg.Section = int.Parse(seccomboBox.SelectedValue.ToString());
                                    shared.bd.Stagiairs.AddOrUpdate(stg);

                                }
                                shared.bd.SaveChanges();
                            }
                        }
                        else if (pro1 == true && sec1 == false)
                        {


                            DialogResult r = MessageBox.Show("Attention vous etes sur le point d'enregistrer ce (s) stagiaire (s) sur la promos  " + promocomboBox11.Text + "  mais sans section  ", "", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                            //DialogResult r = MessageBox.Show("attinstion vous ete sur de que vous voulez que la list des stgaire tu le svagred juste avic la promo  " + promocomboBox11.Text + "  et un section anonim ", "", MessageBoxButtons.YesNo);
                            if (r == DialogResult.Yes)
                            {

                                foreach (DataRow row in tbsv.Rows)
                                {

                                    string ab = row[0].ToString();

                                    var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                    stg.Section = null;
                                    shared.bd.Stagiairs.AddOrUpdate(stg);

                                }
                                shared.bd.SaveChanges();
                            }
                        }
                        MessageBox.Show("Données enregistrées avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Veuillez cocher la case 'Afficher uniquement les stagiaire sans section' enregistrer  les stagiaires sans section ou la case section pour le enregistrer donne la section sélectioner  ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        //MessageBox.Show("stp coche la case de la section et decoche la cse de affiche juster le stg son section pour enrgistre les stg avic la section sinon fi le conntrare pour garede les satgire son section");
                    }
                }
                else { MessageBox.Show("Aucun changement à enregistrer","",MessageBoxButtons.OK,MessageBoxIcon.Error); }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void save2()
        {
            try
            {
                int promo = int.Parse(promocomboBox114.SelectedValue.ToString());
            int sec = int.Parse(seccomboBox15.SelectedValue.ToString());
            bool sec1 = Sec2checkEdit2.Checked;
            bool pro1 = pro2checkEdit3.Checked;
            DataTable tbsv = gridControl2.DataSource as DataTable;
                if (tbsv != null)
                {
                    if (pro1 == true || sec1 == false)
                    {
                        if (pro1 == false && sec1 == true)
                        {
                            DialogResult r = MessageBox.Show("Etes-vous sure de vouloir enregistrer ces stagiaires sur la section: " + seccomboBox15.Text + " de la promo: " + promocomboBox114.Text + "", "", MessageBoxButtons.YesNo);
                            if (r == DialogResult.Yes)
                            {

                                foreach (DataRow row in tbsv.Rows)
                                {

                                    string ab = row[0].ToString();

                                    var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                    stg.Section = int.Parse(seccomboBox15.SelectedValue.ToString());
                                    shared.bd.Stagiairs.AddOrUpdate(stg);

                                }
                                shared.bd.SaveChanges();
                            }
                        }
                        else if (pro1 == true && sec1 == false)
                        {
                            DialogResult r = MessageBox.Show("Attention vous etes sur le point d'enregistrer ce (s) stagiaire (s) sur la promos" + promocomboBox114.Text + "et un section anonim ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (r == DialogResult.Yes)
                            {

                                foreach (DataRow row in tbsv.Rows)
                                {

                                    string ab = row[0].ToString();

                                    var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                    stg.Section = null;
                                    shared.bd.Stagiairs.AddOrUpdate(stg);

                                }
                                shared.bd.SaveChanges();

                            }
                        }MessageBox.Show("Données enregistrées avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Veuillez cocher la case 'Afficher uniquement les stagiaire sans section' si vous voulez afficher et transferer uniquement les stagiaires sans section", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                else { MessageBox.Show("Aucun changement à enregistrer","",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }
      

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            lefttoright();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            righttolet();
        }

        

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            save1();
        }

        private void simpleButton71_Click(object sender, EventArgs e)
        {
            save2();
        }
        // sarge les donne de gridview 1 a partire de la fonction REFRACH
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int promo = int.Parse(promocomboBox11.SelectedValue.ToString());
                int sec = int.Parse(seccomboBox.SelectedValue.ToString());
                bool sec1 = Sec1checkEdit1.Checked;
                bool pro1 = pro1checkEdit1.Checked;
                gridControl1.DataSource = refrach(promo, sec, sec1, pro1);
                gridView1.OptionsBehavior.ReadOnly = true;
                NUBEREF.Text = gridView1.RowCount.ToString();
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }

        }
        // sarge les donnes de gridview 2 a partire de la fonction REFRACH
        private void simpleButton72_Click(object sender, EventArgs e)
        {
            try
            {
                int promo = int.Parse(promocomboBox114.SelectedValue.ToString());
                int sec = int.Parse(seccomboBox15.SelectedValue.ToString());
                bool sec2 = Sec2checkEdit2.Checked;
                bool pro2 = pro2checkEdit3.Checked;
                gridControl2.DataSource = refrach(promo, sec, sec2, pro2);
                gridView2.OptionsBehavior.ReadOnly = true;
                NUBEREF2.Text = gridView2.RowCount.ToString();
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
        }

        private void seccomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GTsectionfrm_Load(object sender, EventArgs e)
        {

        }

        private void Sec1checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (Sec1checkEdit1.Checked == true)
            {
                pro1checkEdit1.Checked = false;
            }
        }

        private void pro1checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(pro1checkEdit1.Checked == true)
            {
                Sec1checkEdit1.Checked = false;
            }
        }

        private void pro2checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (pro2checkEdit3.Checked == true)
            {
                Sec2checkEdit2.Checked = false;
            }
        }

        private void Sec2checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (Sec2checkEdit2.Checked ==true)
            {
                pro2checkEdit3.Checked = false;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            gridView1.ShowRibbonPrintPreview(); 
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            gridView2.ShowRibbonPrintPreview ();
        }

        private void promocomboBox11_SelectedValueChanged(object sender, EventArgs e)
        {try
            {
                if (promocomboBox11.Text != null)
                {
                    int promo = int.Parse(promocomboBox11.SelectedValue.ToString());


                    var qur3 = from sec in shared.bd.Sections
                               join po in shared.bd.Options on sec.ID_Option equals po.ID_Option
                               join mo in shared.bd.Mode_formation on sec.ID_Mode_Formation equals mo.ID_Mode_Formation
                               join pro in shared.bd.Promoes on sec.ID_Promo equals pro.ID_Promo
                               where sec.ID_Promo == promo
                               select new { id = sec.SectionID, nom = (mo.Code_Mode_Formation + po.Code_Option + pro.Code_Promo + " " + sec.Code_Section) };

                    seccomboBox.DataSource = qur3.ToList();
                    seccomboBox.DisplayMember = "nom";
                    seccomboBox.ValueMember = "id";
                }
                else
                {
                    seccomboBox.DataSource = null;
                    seccomboBox.Items.Clear();
                }
            }
            catch
            {
                seccomboBox.DataSource = null;
                seccomboBox.Items.Clear();
            }

        }

        private void promocomboBox114_SelectedIndexChanged(object sender, EventArgs e)
        {try { seccomboBox15.DataSource = null;
                seccomboBox15.Items.Clear();
                if (promocomboBox114.SelectedValue.ToString() != null) { 
                    int promo = int.Parse(promocomboBox114.SelectedValue.ToString());

                
                var qur3 = from sec in shared.bd.Sections
                       join po in shared.bd.Options on sec.ID_Option equals po.ID_Option
                       join mo in shared.bd.Mode_formation on sec.ID_Mode_Formation equals mo.ID_Mode_Formation
                       join pro in shared.bd.Promoes on sec.ID_Promo equals pro.ID_Promo
                       where sec.ID_Promo == promo
                       select new { id = sec.SectionID, nom = (mo.Code_Mode_Formation + po.Code_Option + pro.Code_Promo + " " + sec.Code_Section) };

            seccomboBox15.DataSource = qur3.ToList();
            seccomboBox15.DisplayMember = "nom";
            seccomboBox15.ValueMember = "id";}
        }
            catch
            {
               seccomboBox15.DataSource = null;
                seccomboBox15.Items.Clear();
            }
        }

        private void modecombobox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int mode = int.Parse(modecomboBox117.SelectedValue.ToString());
                int sp = int.Parse(spcomboBox1.SelectedValue.ToString());
                promocomboBox11.DataSource = null;
                promocomboBox11.Items.Clear();
                var qur1 = from pr in shared.bd.Promoes
                           join po in shared.bd.Options on pr.ID_Option equals po.ID_Option
                           join mo in shared.bd.Mode_formation on pr.Mode_de_formation equals mo.ID_Mode_Formation
                           where pr.Mode_de_formation == mode && pr.ID_Option == sp
                           select new { id = pr.ID_Promo, nom = (mo.Code_Mode_Formation + po.Code_Option + pr.Code_Promo) };
                
                promocomboBox11.DataSource = qur1.ToList();
                promocomboBox11.DisplayMember = "nom";
                promocomboBox11.ValueMember = "id";
            }
            catch {
                promocomboBox11.DataSource = null;
                promocomboBox11.Items.Clear(); }
        }

        private void spcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            int mode = int.Parse(modecomboBox117.SelectedValue.ToString());
            int sp = int.Parse(spcomboBox1.SelectedValue.ToString());
                promocomboBox11.DataSource = null;
                promocomboBox11.Items.Clear();
                var qur1 = from pr in shared.bd.Promoes
                       join po in shared.bd.Options on pr.ID_Option equals po.ID_Option
                       join mo in shared.bd.Mode_formation on pr.Mode_de_formation equals mo.ID_Mode_Formation
                       where pr.Mode_de_formation == mode && pr.ID_Option == sp
                       select new { id = pr.ID_Promo, nom = (mo.Code_Mode_Formation + po.Code_Option + pr.Code_Promo) };

            promocomboBox11.DataSource = qur1.ToList();
            promocomboBox11.DisplayMember = "nom";
            promocomboBox11.ValueMember = "id";
            }
            catch {
                promocomboBox11.DataSource = null;
                promocomboBox11.Items.Clear();
            }
        }
    }
}
