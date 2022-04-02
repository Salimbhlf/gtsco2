using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.NewFolder1
{
    public partial class TEST : DevExpress.XtraReports.UI.XtraReport
    {
        public TEST()
        {
            InitializeComponent();
        }

        public void RPT ()
        {
            var qure = from trnsgf in classe.shared.bd.Transferers
                       join
stg in classe.shared.bd.Stagiairs on trnsgf.num_stg equals stg.Num_STG
                       join emp in classe.shared.bd.Employeurs on stg.ID_Emp equals emp.ID_Emp
                       join etb in classe.shared.bd.Etablissements on trnsgf.ID_etb equals etb.ID_ETAB
                       select new
                       {

                       };
        }
    }
    
}
