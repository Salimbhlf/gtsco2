using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.forms.GTSecetion.rpor_sction
{
    public partial class listsection : DevExpress.XtraReports.UI.XtraReport
    {
        public listsection()
        {
            InitializeComponent();
        }
        public static void print(int sec)
        {
            listsection rpt = new listsection();
            rpt.DataSource = rpt.load(sec);
            rpt.databinding();
            rpt.ShowRibbonPreview();

        }

        void databinding()
        {
            xrTableCell7code.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "code"));
            xrTableCell8nom.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "nom"));
            xrTableCell9Prenom.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "prenom"));
        }

        public object load(int sec)
        {
            var qur = from stg in shared.bd.Stagiairs
                      where stg.Section == sec
                      select new
                      {
                          code = stg.Num_STG,
                          nom = stg.Nom,
                          prenom = stg.Prenom,


                      };

            return qur.ToList();




        }
    } 
   
}
