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

namespace gtsco2.forms.SUTATION_DES_EFFICTIFE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ANNEE();
        }


        public void ANNEE()
        {
            var qur5 = (from ann in shared.bd.annee_scolaire
                        select new { id = ann.ID_Année_SCO, nom = (ann.Designation + " " + ann.Session_Année_SCO) }).ToList();

            comboBox1.DataSource = qur5.ToList();
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id";


            var qur2 = (from mode in shared.bd.Mode_formation
                        select new { ID = mode.ID_Mode_Formation, nom = mode.Désignation_Mode_Formation }).ToList();
            comboBox3.DataSource = qur2;
            comboBox3.DisplayMember = "nom";
            comboBox3.ValueMember = "ID";


           
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int annee =int.Parse(comboBox1.SelectedValue.ToString());
            string sm = comboBox2.Text;
          int mode = int.Parse(comboBox3.SelectedValue.ToString());
            SUTATION_DES_EFFICTIFE.Sutatuin_Effictife.printsutation_effictife(annee, sm,mode );
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
