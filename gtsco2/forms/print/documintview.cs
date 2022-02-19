using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtsco2.forms.print
{
    public partial class documintview : Form
    {
        public documintview()
        {
            InitializeComponent();
        }
        public void printdata(string anne, string sp, string promo, string section, string module, List<eva> data)
        {
            GSTnote.reportnote.Report1note report1 = new GSTnote.reportnote.Report1note();
           

            foreach (DevExpress.XtraReports.Parameters.Parameter p in report1.Parameters)
            {
                p.Visible = false;



            }
            report1.load(anne, sp, promo, section, module, data);
            report1.DataSource = data;
            this.documentViewer1.DocumentSource = report1;
            report1.CreateDocument();
            
            
        }
    }
}
