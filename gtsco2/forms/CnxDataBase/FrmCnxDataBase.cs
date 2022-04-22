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
using System.Data.SqlClient;

namespace gtsco2.forms.CnxDataBase
{
    public partial class FrmCnxDataBase : DevExpress.XtraEditors.XtraForm
    {
        public FrmCnxDataBase()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string conniction = string.Format("data source={0};initial catalog=GTSCO19;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework", textEditSercver.Text);
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings["gtsco"].ConnectionString = conniction;
            //config.Save();
            //ConfigurationManager.RefreshSection("connectionString");
            //var strl = config.ConnectionStrings.ConnectionStrings["gtsco"].ConnectionString;
            //MessageBox.Show("chien de connection " + strl);
            //Application.Restart();
            string secr;
            if(comboBoxEditATH.Text== "Authentification Windows")
            { secr = "true"; }else { secr = "false"; }

            string Connection = string.Format("data source={0};initial catalog={4};integrated security={1};user id ={2}; password ={3};MultipleActiveResultSets=True;App=EntityFramework", comboBoxEdit1.Text,secr,textEdit3Nometu.Text,textEditPs.Text,textEdit3dATEBASE.Text) ;
            try { Sqlhelper helper = new Sqlhelper(Connection);
                if (helper.IsConnection)
                    MessageBox.Show("test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex ) { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                
        }

        private void FrmCnxDataBase_Load(object sender, EventArgs e)
        {
            AppSetting satting = new AppSetting();


            SqlConnection sa = new SqlConnection(satting.GetConnectionString("gtsco"));
            comboBoxEdit1.Text = sa.DataSource;
            textEdit3dATEBASE.Text = sa.Database;
            
            comboBoxEdit1.Properties.Items.Add(sa.DataSource);
            comboBoxEdit1.Properties.Items.Add("(local)");
            comboBoxEdit1.Properties.Items.Add(Environment.MachineName);
            comboBoxEditATH.SelectedIndex = 0;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string secr;
            if (comboBoxEditATH.Text == "Authentification Windows")
            { secr = "true"; }
            else { secr = "false"; }

            string Connection = string.Format("data source={0};initial catalog={4};integrated security={1};user id ={2}; password ={3};MultipleActiveResultSets=True;App=EntityFramework", comboBoxEdit1.Text, secr, textEdit3Nometu.Text, textEditPs.Text,textEdit3dATEBASE.Text);
            try                            
            {
               
                
                    AppSetting satting = new AppSetting();
                satting.SeveConnectionString("gtsco", Connection);

                

                    MessageBox.Show("La connection a eter bien enrgistre ."+satting.GetConnectionString("gtsco"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
