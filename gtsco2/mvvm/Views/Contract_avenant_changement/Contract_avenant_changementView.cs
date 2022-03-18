using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.Contract_avenant_changementView{
    public partial class Contract_avenant_changementView : XtraUserControl {
        public Contract_avenant_changementView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.Contract_avenant_changementViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                contract_avenant_changementViewBindingSource, x => x.Entity, x => x.Update());
							// Binding for Employeur LookUp editor
			fluentAPI.SetBinding(EmployeurLookUpEdit.Properties, p => p.DataSource, x => x.LookUpEmployeurs.Entities);
						// Binding for Stagiair LookUp editor
			fluentAPI.SetBinding(StagiairLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStagiairs.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
