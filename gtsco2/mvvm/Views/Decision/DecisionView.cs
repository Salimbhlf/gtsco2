using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.DecisionView{
    public partial class DecisionView : XtraForm {
        public DecisionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.DecisionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                decisionViewBindingSource, x => x.Entity, x => x.Update());
							// Binding for Proce_verbal_delibation LookUp editor
			fluentAPI.SetBinding(Proce_verbal_delibationLookUpEdit.Properties, p => p.DataSource, x => x.LookUpProce_verbal_delibation.Entities);
						// Binding for Promo LookUp editor
			fluentAPI.SetBinding(PromoLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPromoes.Entities);
						// Binding for Semestre LookUp editor
			fluentAPI.SetBinding(SemestreLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSemestres.Entities);
						// Binding for Stagiair LookUp editor
			fluentAPI.SetBinding(StagiairLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStagiairs.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			int idds = int.Parse(ID_DecisionTextEdit.Text.ToString());
			//forms.Décisions.Redoublement.load(idds);
			forms.Décisions.frmRodublomint.frmrdublomant fr = new forms.Décisions.frmRodublomint.frmrdublomant();
			fr.STG(idds);
			fr.Show();
        }
    }
}
