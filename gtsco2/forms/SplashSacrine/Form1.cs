using gtsco2.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.SplashSacrine
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2022-" + DateTime.Now.Year.ToString();
            timer1.Start();

        }

        public void load()
        {
            try
            {
               
                shared.bd.Stagiairs.Load();
               
                labelStatus.Text = "Stagiairs load ......";
                shared.bd.Etablissements.Load();
                labelStatus.Text = "Etablissements load ......";
                shared.bd.Employeurs.Load();
                labelStatus.Text = "Employeurs load ......";
                shared.bd.Evaluations.Load();
                labelStatus.Text = "Evaluations load ......";
                shared.bd.Absences.Load();
                labelStatus.Text = "Absences load ......";
                shared.bd.Code_Postal.Load();
                labelStatus.Text = "Code_Postals load ......";
                shared.bd.annee_scolaire.Load();
                labelStatus.Text = "annee_scolaire load ......";
                shared.bd.Willayas.Load();
                labelStatus.Text = "Willayas load ......";
                shared.bd.Mode_formation.Load();
                labelStatus.Text = "Mode_formation load ......";
                shared.bd.Specialites.Load();
                labelStatus.Text = "Specialites load ......";
                shared.bd.Avenant_contrat_prorogation.Load();
                labelStatus.Text = "Avenant_contrat_prorogation load ......";
                shared.bd.Contract_avenant_changement.Load();
                labelStatus.Text = "Contract_avenant_changement load ......";
                shared.bd.Decisions.Load();
                labelStatus.Text = "DEciseiont load ......";
                shared.bd.Users.Load();
                labelStatus.Text = "Users load ......";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                forms.CnxDataBase.FrmCnxDataBase d = new CnxDataBase.FrmCnxDataBase();
                d.ShowDialog();
            }



        }
        public void test()
        {
            try
            {
                if (shared.bd.Users.Count() == 0)
                {
                    MessageBox.Show("bienveun", " meesage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mvvm.user.Views.User.adduser d = new mvvm.user.Views.User.adduser();
                    


                    d.Show();
                }
                else
                {
                    forms.Login.FormLogin fr = new Login.FormLogin();
                    fr.ShowDialog();
                    


                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); this.Close(); }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 4)
            {
                load();
                test();
                Close();
            }
        }
    }
}
