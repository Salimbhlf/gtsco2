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


        public void refrach( int promo , int section, string condicine)
        {

            var qure = (from stg in shared.bd.Stagiairs
                        where stg.ID_Promo == promo && stg.Section == section
                        select new
                        {
                            Numro_STG = stg.Num_STG,
                            Nom_et_Prenom = (stg.Nom + " " + stg.Prenom),
                            Date_de_Naissance = stg.Date_de_Naissance
                        }).ToList();
            gridControl1.DataSource = qure;


            
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int promo = int.Parse(promocomboBox11.SelectedValue.ToString());
            int sec = int.Parse(seccomboBox.SelectedValue.ToString());
            refrach(promo,sec);
        }
    }
}
