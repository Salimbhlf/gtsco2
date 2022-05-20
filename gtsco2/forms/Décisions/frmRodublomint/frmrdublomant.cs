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

namespace gtsco2.forms.Décisions.frmRodublomint
{
    public partial class frmrdublomant : DevExpress.XtraEditors.XtraForm
    {
        public frmrdublomant()
        {
            InitializeComponent();
        }

        public void STG(int cle)
        {

            var qur = from dis in shared.bd.Decisions
                      join stg in shared.bd.Stagiairs on dis.Num_STG equals stg.Num_STG
                      join sem in shared.bd.Semestres on dis.ID_Semestre equals sem.ID_Semestre
                      join promo in shared.bd.Promoes on dis.ID_Promo equals promo.ID_Promo
                      join ops in shared.bd.Options on promo.ID_Option equals ops.ID_Option
                      join sp in shared.bd.Specialites on ops.Specialite equals sp.ID_Specialité
                      join pv in shared.bd.Proce_verbal_delibation on dis.ID_PV_Délibiration equals pv.ID_PV_Délibiration
                      where dis.ID_Decision == cle
                      select new
                      {
                          nom = (stg.Nom_ar + " " + stg.Prenom_ar),
                          sps = sp.Designation_SP_AR  + ops.Designation_Option_ar,
                          smstr = sem.Designation_Semestre_ar,
                          datepv = pv.Date_PV_Délibiration,
                          numcont = stg.Num_Validation_Contrat_STG,
                          datevalidation = stg.Date_Validation_Contrat_STG

                      };
            foreach (var row in qur.ToList())
            {

                memoEdit1.Text = ("-نـظرا للمحضـر المـــؤرخ يـوم " + row.datevalidation.Value.ToString("dd/MM/yyyy")
                    + " تحت رقـــم " + row.numcont + " والمتضمـن فتــح فــرع تـقنـي ســامي فــي اختصــاص ألمعلوماتية خيار قاعدة المعطيات  " + row.sps);

                memoEdit2.Text = ("- وتبـعـــا لقـــرار محضــر اجتمــاع مجلــس الأساتــذة المنعقد يوم" + row.datepv.Value.ToString("dd/MM/yyyy"));

                memoEdit3.Text = ("المـادة الأولـى : يعـيـــد المتمهن  " + row.nom + "(" + " السداسي " + row.smstr + ")");
               memoEdit4.Text = row.sps;
            }



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            print();
        }

        public void print()
        {
            forms.Décisions.Redoublement.load(memoEdit1.Text, memoEdit2.Text, memoEdit3.Text, memoEdit4.Text);
        }
    }
}
