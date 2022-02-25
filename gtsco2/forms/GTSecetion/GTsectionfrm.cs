using gtsco2.classe;
using System;
using System.Collections.Generic;
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


        public  object refrach( int promo , int section,bool sec , bool pro)
        {object qure;
            try
            {
                

                if (pro == false && sec == true)
                {
                    qure = (from stg in shared.bd.Stagiairs
                            where stg.ID_Promo == promo && stg.Section == section
                            select new
                            {
                                Numro_STG = stg.Num_STG,
                                Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                Date_de_Naissance = stg.Date_de_Naissance
                            }).ToList();
                    return qure;
                }
                else if (pro == false && sec == false)
                {
                    qure = (from stg in shared.bd.Stagiairs
                            where stg.ID_Promo == promo
                            select new
                            {
                                Numro_STG = stg.Num_STG,
                                Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                Date_de_Naissance = stg.Date_de_Naissance
                            }).ToList();
                    return qure;
                }
                else if (pro == true)
                {
                    qure = (from stg in shared.bd.Stagiairs
                            where stg.ID_Promo == promo && stg.Section == null
                            select new
                            {
                                Numro_STG = stg.Num_STG,
                                Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                                Date_de_Naissance = stg.Date_de_Naissance
                            }).ToList();
                    return qure;
                }
                
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
                          return qure = (from stg in shared.bd.Stagiairs
                               
                               select new
                               {

                               }).ToList();



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
        // sarge les donne de gridview 1 a partire de la fonction REFRACH
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try { 
            int promo = int.Parse(promocomboBox11.SelectedValue.ToString());
            int sec = int.Parse(seccomboBox.SelectedValue.ToString());
            bool sec1 = Sec1checkEdit1.Checked;
            bool pro1 = pro1checkEdit1.Checked;
            gridControl1.DataSource= refrach(promo, sec,sec1,pro1);
                gridView1.OptionsBehavior.ReadOnly = true;
                NUBEREF.Text= gridView1.RowCount.ToString();
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
        }


        public void lefttoright()
        {
            DataTable dt = gridControl2.DataSource as DataTable;
            DataTable dr = gridView1.GetFocusedRow() as DataTable;
            //foreach(DataRow dataR in dr.Rows) { 
            //dt.Rows.Add(dataR);}
            gridControl2.DataSource = dr;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }
        // sarge les donnes de gridview 2 a partire de la fonction REFRACH
        private void BTN2simpleButton6_Click(object sender, EventArgs e)
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
            catch(Exception EX) { MessageBox.Show(EX.Message); }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            lefttoright();
        }
    }
}
