using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.Page_de_garde.forjour
{
    public partial class forjourETd : DevExpress.XtraEditors.XtraForm
    {
        public forjourETd()
        {
            InitializeComponent();
        }
        
        string sec1;
       
        public void print ( string stg )
        {
            
            sec1 = stg;
            
        }

        public void printfomlir()
        {
            string j1 = comboBoxjour1.Text;
            string j2 = comboBoxjour2.Text;

            Page_de_garde.autirisationDeatude.print(sec1, j1, j2);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            printfomlir();
            this.Close();
        }

        private void forjourETd_Load(object sender, EventArgs e)
        {

        }
    }
}
