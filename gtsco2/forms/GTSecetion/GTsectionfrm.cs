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


            var qur = from sp in shared.bd.Opations select new { id = sp.ID_Option, nom = sp.Code_Option };

            spcomboBox1.DataSource = qur.ToList();
            spcomboBox1.DisplayMember = "nom";
            spcomboBox1.ValueMember = "id";

            spcomboBox113.DataSource = qur.ToList();
            spcomboBox113.DisplayMember = "nom";
            spcomboBox113.ValueMember = "id";

            var qur1 = from pr in shared.bd.Promoes
                       join po in shared.bd.Opations on pr.ID_Option equals po.ID_Option
                       join mo in shared.bd.Mode_formation on pr.Mode_de_formation equals mo.ID_Mode_Formation
                       select new { id = pr.ID_Promo, nom = (mo.Code_Mode_Formation + po.Code_Option + pr.Code_Promo) };

            promocomboBox11.DataSource = qur1.ToList();
            promocomboBox11.DisplayMember = "nom";
            promocomboBox11.ValueMember = "id";

            promocomboBox114.DataSource = qur1.ToList();
            promocomboBox114.DisplayMember = "nom";
            promocomboBox114.ValueMember = "id";



            var qur3 = from sec in shared.bd.Sections
                       join po in shared.bd.Opations on sec.ID_Option equals po.ID_Option
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
            {if (promocomboBox11.SelectedValue.ToString() == promocomboBox114.SelectedValue.ToString())
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
                            else { MessageBox.Show("selection la section donne que vous voule effactue le stg ");
                                break;
                            }
                        }
                       for (int i =ab.Count()-1;i>=0;i--)
                        {
                            //Recuperation de l'index de la ligne selectionnée
                            int IndexLigne = gridView1.GetRowHandle(ab[i]);

                            //ou même récupérer la ligne pour en faire ce que tu veux
                            DataRow rows = gridView1.GetDataRow(IndexLigne);
                            if (dt != null)
                            {
                                gridView1.DeleteRow(IndexLigne);

                            }
                            else { MessageBox.Show("selection la section donne que vous voule effactue le stg ");
                                break;
                            }

                        }
                        NUBEREF.Text= gridView1.DataRowCount.ToString() ;
                        NUBEREF2.Text = gridView2.DataRowCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("selection des section  de la meme promo sur le diex tablo");

                    }
                }
            }catch(NullReferenceException)
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
                if (promocomboBox11.SelectedValue.ToString() == promocomboBox114.SelectedValue.ToString())
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
                            else { MessageBox.Show("selection la section donne que vous voule effactue le stg "); }
                        }
                        for (int i = ab.Count() - 1; i >= 0; i--)
                        {
                            //Recuperation de l'index de la ligne selectionnée
                            int IndexLigne = gridView2.GetRowHandle(ab[i]);

                          
                            if (dt != null)
                            {
                                gridView2.DeleteRow(IndexLigne);

                            }
                            else { MessageBox.Show("selection la section donne que vous voule effactue le stg ");
                                break;
                            }

                        }
                        NUBEREF.Text = gridView1.DataRowCount.ToString();
                        NUBEREF2.Text = gridView2.DataRowCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("selection des section  de la meme promo sur le diex tablo");

                    }
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
                        DialogResult r = MessageBox.Show("vous voules suvagred les stagiairs sur la section:  " + seccomboBox.Text + " de la promo: " + promocomboBox11.Text + "", "", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {

                            foreach (DataRow row in tbsv.Rows)
                            {

                                string ab = row[0].ToString();

                                var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                stg.Section = int.Parse(seccomboBox.SelectedValue.ToString());
                                shared.bd.Stagiairs.AddOrUpdate(stg);
                                
                            }shared.bd.SaveChanges();
                        }
                    }
                    else if (pro1 == true && sec1 == false)
                    {
                        DialogResult r = MessageBox.Show("attinstion vous ete sur de que vous voulez que la list des stgaire tu le svagred juste avic la promo  " + promocomboBox11.Text + "  et un section anonim ", "", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {

                            foreach (DataRow row in tbsv.Rows)
                            {

                                string ab = row[0].ToString();

                                var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                stg.Section = null;
                                shared.bd.Stagiairs.AddOrUpdate(stg);
                                
                            }shared.bd.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("stp coche la case de la section et decoche la cse de affiche juster le stg son section pour enrgistre les stg avic la section sinon fi le conntrare pour garede les satgire son section");
                    }
                }
                else { MessageBox.Show("vous nave effcutau aucone aupiration pour le sevgarede"); }
                MessageBox.Show("bien enrgistre");
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
                    if (pro1 == false && sec1 == true)
                    {
                        DialogResult r = MessageBox.Show("vous voules suvagred les stagiairs sur la section: " + seccomboBox15.Text + " de la promo: " + promocomboBox114.Text + "", "", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {

                            foreach (DataRow row in tbsv.Rows)
                            {

                                string ab = row[0].ToString();

                                var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                stg.Section = int.Parse(seccomboBox15.SelectedValue.ToString());
                                shared.bd.Stagiairs.AddOrUpdate(stg);
                                
                            }shared.bd.SaveChanges();
                        }
                    }
                    else if (pro1 == true && sec1 == false)
                    {
                        DialogResult r = MessageBox.Show("attinstion vous ete sur de que vous voulez que la list des stgaire tu le svagred juste avic la promo" + promocomboBox114.Text + "et un section anonim ", "", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {

                            foreach (DataRow row in tbsv.Rows)
                            {

                                string ab = row[0].ToString();

                                var stg = shared.bd.Stagiairs.First(a => a.Num_STG == ab);
                                stg.Section = null;
                                shared.bd.Stagiairs.AddOrUpdate(stg);
                               
                            } shared.bd.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("stp coche la case de la section et decoche la cse de affiche juster le stg son section pour enrgistre les stg avic la section sinon fi le conntrare pour garede les satgire son section");
                    }
                }
                else { MessageBox.Show("vous nave effcutau aucone aupiration pour le sevgarede"); }
                MessageBox.Show("bien enrgistre");
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
    }
}
