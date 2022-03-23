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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            textEdit2.Focus();
            textEdit2.BackColor = Color.White;
            textEdit1.BackColor = System.Drawing.SystemColors.Control;
            panel5.BackColor = Color.White;
            panel3.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit2.BackColor = Color.White;
            pictureEdit1.BackColor = System.Drawing.SystemColors.Control;
            separatorControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            separatorControl1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            textEdit2.Focus();
            textEdit2.BackColor = Color.White;
            textEdit1.BackColor = System.Drawing.SystemColors.Control;
            panel5.BackColor = Color.White;
            panel3.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit2.BackColor = Color.White;
            pictureEdit1.BackColor = System.Drawing.SystemColors.Control;
            separatorControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            separatorControl1.BackColor = System.Drawing.SystemColors.Control;

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
            
            textEdit1.BackColor = Color.White;
            textEdit2.BackColor = System.Drawing.SystemColors.Control;
            panel3.BackColor = Color.White;
            panel5.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit1.BackColor = Color.White;
            pictureEdit2.BackColor = System.Drawing.SystemColors.Control;
            separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            separatorControl2.BackColor = System.Drawing.SystemColors.Control;
        }

        private void textEdit1_Validated(object sender, EventArgs e)
        {
            textEdit1.BackColor = Color.White;
            textEdit2.BackColor = System.Drawing.SystemColors.Control;
            panel3.BackColor = Color.White;
            panel5.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit1.BackColor = Color.White;
            pictureEdit2.BackColor = System.Drawing.SystemColors.Control;
            separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            separatorControl2.BackColor = System.Drawing.SystemColors.Control;
        }

        private void textEdit1_Validating(object sender, CancelEventArgs e)
        {

            textEdit1.BackColor = Color.White;
            textEdit2.BackColor = System.Drawing.SystemColors.Control;
            panel3.BackColor = Color.White;
            panel5.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit1.BackColor = Color.White;
            pictureEdit2.BackColor = System.Drawing.SystemColors.Control;
            separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            separatorControl2.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
