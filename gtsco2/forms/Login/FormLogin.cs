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

       
    }
}
