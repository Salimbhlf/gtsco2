using DevExpress.XtraReports.UI;
using gtsco2.classe;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace gtsco2.forms.SUTATION_DES_EFFICTIFE
{
    public partial class Sutatuin_Effictife : DevExpress.XtraReports.UI.XtraReport
    {
        public Sutatuin_Effictife()
        {
            InitializeComponent();
        }



        public void load()
        {
            var qure = from sp in shared.bd.Specialites select new { codesp = sp.Code_SP , id = sp.ID_Specialité };



            foreach(var row in qure.ToList())
            {
                var qures = from section in shared.bd.Sections
                            from op in shared.bd.Options.Where(x => x.ID_Option == section.ID_Option).DefaultIfEmpty()
                            where op.Specialite == row.id
                            select new
                            {
                                

                            };
                

            }

         
        }



    }
}
