using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.CnxDataBase
{
    public partial class FrmCnxDataBase : Form
    {
        public FrmCnxDataBase()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string conniction = string.Format("data source={0};initial catalog=GTSCO19;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework", textEditSercver.Text);
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["gtsco"].ConnectionString = conniction;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var strl = config.ConnectionStrings.ConnectionStrings["gtsco"].ConnectionString;
            MessageBox.Show("chien de connection " + strl);
            Application.Restart();
           
        }
    }
}
