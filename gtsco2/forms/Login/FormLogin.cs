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


namespace gtsco2.forms.Login
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }







        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            textEdit2.Focus();

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            textEdit2.Focus();


        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            textEdit1.Focus();
        }



        private void panel3_Click(object sender, EventArgs e)
        {
            textEdit1.Focus();

        }





        private void textEdit2_Enter(object sender, EventArgs e)
        {
            textEdit2.BackColor = Color.White;
            textEdit1.BackColor = System.Drawing.SystemColors.Control;
            panel5.BackColor = Color.White;
            panel3.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit2.BackColor = Color.White;
            pictureEdit1.BackColor = System.Drawing.SystemColors.Control;
            textEdit2.SelectAll();

        }



        private void textEdit1_Enter(object sender, EventArgs e)
        {
            textEdit1.BackColor = Color.White;
            textEdit2.BackColor = System.Drawing.SystemColors.Control;
            panel3.BackColor = Color.White;
            panel5.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit1.BackColor = Color.White;
            pictureEdit2.BackColor = System.Drawing.SystemColors.Control;

            textEdit1.SelectAll();
        }





        private void pictureEdit2_MouseHover(object sender, EventArgs e)
        {
            textEdit2.BackColor = Color.White;

            panel5.BackColor = Color.White;

            pictureEdit2.BackColor = Color.White;


        }



        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            textEdit2.BackColor = Color.White;

            panel5.BackColor = Color.White;

            pictureEdit2.BackColor = Color.White;


        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            if (textEdit2.ContainsFocus == false)
            {
                textEdit2.BackColor = System.Drawing.SystemColors.Control;

                panel5.BackColor = System.Drawing.SystemColors.Control;

                pictureEdit2.BackColor = System.Drawing.SystemColors.Control;

            }
        }

        private void textEdit2_MouseLeave(object sender, EventArgs e)
        {
            if (textEdit2.ContainsFocus == false)
            {
                textEdit2.BackColor = System.Drawing.SystemColors.Control;

                panel5.BackColor = System.Drawing.SystemColors.Control;

                pictureEdit2.BackColor = System.Drawing.SystemColors.Control;

            }
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            textEdit1.BackColor = Color.White;

            panel3.BackColor = Color.White;

            pictureEdit1.BackColor = Color.White;



        }



        private void textEdit1_MouseEnter(object sender, EventArgs e)
        {
            textEdit1.BackColor = Color.White;

            panel3.BackColor = Color.White;

            pictureEdit1.BackColor = Color.White;



        }

        private void textEdit1_MouseLeave(object sender, EventArgs e)
        {
            if (textEdit1.ContainsFocus == false)
            {
                textEdit1.BackColor = System.Drawing.SystemColors.Control; ;

                panel3.BackColor = System.Drawing.SystemColors.Control; ;

                pictureEdit1.BackColor = System.Drawing.SystemColors.Control; ;


            }
        }



        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            if (textEdit1.ContainsFocus == false)
            {
                textEdit1.BackColor = System.Drawing.SystemColors.Control; ;

                panel3.BackColor = System.Drawing.SystemColors.Control; ;

                pictureEdit1.BackColor = System.Drawing.SystemColors.Control;
            }

        }

        private void textEdit2_MouseEnter(object sender, EventArgs e)
        {
            textEdit2.BackColor = Color.White;

            panel5.BackColor = Color.White;

            pictureEdit2.BackColor = Color.White;



        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
                textEdit2.Properties.UseSystemPasswordChar = false;
            else
                textEdit2.Properties.UseSystemPasswordChar = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void Login()
        {
            if (textEdit1.Text == "" || textEdit2.Text == "")
            {
                if (textEdit1.Text == "")
                {
                    textEdit1.Focus();
                }
                else
                {

                    textEdit2.Focus();

                }

            }
            else if (shared.bd.Users.Where(a => a.Nomeutlisature == textEdit1.Text && a.MotedePasse == textEdit2.Text).Count() >0)
            {
                try
                {
                    Properties.Settings.Default.iduser = shared.bd.Users.First(a => a.Nomeutlisature == textEdit1.Text && a.MotedePasse == textEdit2.Text).ID_user.ToString();
                    Properties.Settings.Default.Save();
                }
                catch { }
                forms.Pageprancipel.FrmPrancipal p = new Pageprancipel.FrmPrancipal();
                p.Show();
                this.Close();

            }
            else
            {
                if (shared.bd.Users.Local.Any(a => a.Nomeutlisature == textEdit1.Text) == false)
                {

                    textEdit1.Focus();
                    textEdit1.SelectAll();
                    separatorControl1.BackColor = Color.Red;

                }
                else
                {
                    textEdit2.Focus();
                    textEdit2.SelectAll();
                    separatorControl2.BackColor = Color.Red;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            separatorControl1.BackColor = Color.FromArgb(041, 128, 185);
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            separatorControl2.BackColor = Color.FromArgb(041, 128, 185);
        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {
            forms.CnxDataBase.FrmCnxDataBase fr = new CnxDataBase.FrmCnxDataBase();
            fr.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
