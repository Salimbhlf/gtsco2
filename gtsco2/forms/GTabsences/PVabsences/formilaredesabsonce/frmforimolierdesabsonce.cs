using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.GTabsences.PVabsences.formilaredesabsonce
{
    public partial class frmforimolierdesabsonce : DevExpress.XtraEditors.XtraForm
    {
        public frmforimolierdesabsonce()
        {
            InitializeComponent();
        }
        object dt;
        string sec1;
        string semestre1;
        string promo1;
        public void print (object data , string sec ,string semestre , string promo )
        {
            dt = data;
            sec1 = sec;
            semestre1 = semestre;
            promo1 = promo;

        }

        public void printfomlir()
        {
            GTabsences.PVabsences.Formlaire_saisie_absence.Formlaire_saisie_absence.load(dateDEdit1.DateTime, dateFEdit2.DateTime,semestre1,sec1,promo1,comboBoxjour1.Text,comboBoxjour2.Text,dt );
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            printfomlir();
            this.Close();
        }
    }
}
