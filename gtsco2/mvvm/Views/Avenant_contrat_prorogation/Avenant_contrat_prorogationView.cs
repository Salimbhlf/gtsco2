using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.Avenant_contrat_prorogationView{
    public partial class Avenant_contrat_prorogationView : XtraUserControl {
        public Avenant_contrat_prorogationView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.Avenant_contrat_prorogationViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                avenant_contrat_prorogationViewBindingSource, x => x.Entity, x => x.Update());
							// Binding for Employeur LookUp editor
			fluentAPI.SetBinding(EmployeurLookUpEdit.Properties, p => p.DataSource, x => x.LookUpEmployeurs.Entities);
						// Binding for Stagiair LookUp editor
			fluentAPI.SetBinding(StagiairLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStagiairs.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
