using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gtsco2.forms.coupe_de_la_base_de_donne
{
    public partial class FrmfrmcoupeBD : DevExpress.XtraEditors.XtraForm
    {
        public FrmfrmcoupeBD()
        {
            InitializeComponent();
            load();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            fillediloge();


        }

        private void FrmCnxDataBase_Load(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            saveData();
          

        }

        public void load()
        {
            try
            {
                CnxDataBase.AppSetting satting = new CnxDataBase.AppSetting();
                textEditconxtionstring.Text = satting.GetConnectionString("gtsco");
                textEdit3conniction2.Text = satting.GetConnectionString("gtsco");
            }
            catch { }
        }

        public void fillediloge() {

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textEditfilediloge.Text = dlg.SelectedPath;
                simpleButton2save.Enabled = true;

            }

        }



        public void fillediloge2()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER Database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textEditPs1Url.Text = dlg.FileName;
                simpleButtonsave.Enabled = true;

            }

        }

        public void restore()
        {
            //try { 
            //string con = textEdit3conniction2.Text;
            //SqlConnection conx = new SqlConnection(con);
            //    //SqlConnection conxtion = new SqlConnection("data source=(local);initial catalog=master;integrated security=true;user id =; password =;");
            //string data = conx.Database.ToString();
            //conx.Open();
            //try
            //{
            //    //    string str1 = string.Format("ALTER DATABASE [" + data + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;") ;

            //    //SqlCommand sql = new SqlCommand(str1, conx);
            //    //sql.ExecuteNonQuery();

            //    string str2 = "USE MASTER; RESTORE DATABASE [{0}] FROM DISK ='" + textEditPs1Url.Text + "'";
            //    //    SqlCommand cmd1 = new SqlCommand(str2, conx);

            //    //cmd1.ExecuteNonQuery();
            //      int path =  classe.shared.bd.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(str2, data));

            //    //string str3 = string.Format("ALTER DATABASE[" + data + "] SET MULTI_USER");
            //    //SqlCommand cmd2 = new SqlCommand(str3, conx);
            //    //cmd2.ExecuteNonQuery();

            //    MessageBox.Show("la base de donne et bien resture ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        simpleButton2save.Enabled = false;







            //            conx.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //    conx.Close();
            //}catch(Exception ex ){  MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);  }








            try
            {
               var db = new basededonne.gtsco();
                string con = textEditPs1Url.Text;
                string dbname = db.Database.Connection.Database;
                string sqlCommand = @"Use master;Restore DATABASE [{0}] From  DISK = '" + con.ToString() + "'";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname));
                MessageBox.Show("Base de données réstaurée avec succés", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }




        }

        public void saveData()
        {
            //try
            //{

            //    string con = textEditconxtionstring.Text;
            //    SqlConnection conx = new SqlConnection(con);
            //    string data = conx.Database.ToString();

            //    if (textEditfilediloge.Text == string.Empty)
            //    {
            //        MessageBox.Show("Plasse select backup file localistion ");

            //    }
            //    else
            //    {conx.Open();
            //        string cmd = ("BACKUP DATABASE [" + data + "] TO  DISK ='" + textEditfilediloge.Text + "\\" + "Database" + "-" + DateTime.Now.ToString(" yyyy-MM-dd-hh-mm-ss") + ".bak' WITH NOFORMAT , NOINIT, NAME = N'GTSCO25', SKIP,NOREWIND,NOUNLOAD,STATS =10");

            //        SqlCommand commend = new SqlCommand(cmd, conx);
            //        commend.ExecuteNonQuery();
            //        MessageBox.Show("database backup done successfuly","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //        conx.Close();
            //        conx.Dispose();
            //        simpleButton2save.Enabled = false;

            //    }
            //}
            //catch(Exception ex ) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            try { 
            string con = textEditfilediloge.Text;

            var db = new basededonne. gtsco ();

            string dbname = db.Database.Connection.Database;
            string dbBackUp = "DMMback" + DateTime.Now.ToString("yyyyMMddHHmm");
            var fullpath = con.ToString() + dbBackUp + ".bak";
            string sqlCommand = @"BACKUP DATABASE [{0}] TO  DISK = '" + fullpath + "' WITH NOFORMAT, NOINIT,  NAME = N'DBMDD', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackUp));
                MessageBox.Show("Base de données copié avec succés", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void simpleButton11openfill_Click(object sender, EventArgs e)
        {
            try { fillediloge2();} catch { }
            
        }

        private void simpleButtonsave_Click(object sender, EventArgs e)
        {
            restore();
        }

        private void textEditfilediloge_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
