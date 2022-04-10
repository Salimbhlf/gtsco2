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

namespace gtsco2.mvvm.user.Views.User
{
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
        }

        private void adduser_Load(object sender, EventArgs e)
        {

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();
        }
        public void save()
        {
            basededonne.User us = new basededonne.User();
            us.Nom = NomTextEdit.Text;
            us.Prenom = PrenomTextEdit.Text;
            us.Nomeutlisature = NomeutlisatureTextEdit.Text;
            us.MotedePasse = MotedePasseTextEdit.Text;
            us.Role = comboBoxEdit1.Text;
            shared.bd.Users.Add(us);
            shared.bd.SaveChanges();

            forms.Pageprancipel.FrmPrancipal fr = new forms.Pageprancipel.FrmPrancipal();
            fr.Show();
            this.Close();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
