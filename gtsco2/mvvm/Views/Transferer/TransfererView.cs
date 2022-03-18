using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.TransfererView{
    public partial class TransfererView : XtraUserControl {
        public TransfererView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.TransfererViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                transfererViewBindingSource, x => x.Entity, x => x.Update());
							// Binding for Etablissement LookUp editor
			fluentAPI.SetBinding(EtablissementLookUpEdit.Properties, p => p.DataSource, x => x.LookUpEtablissements.Entities);
						// Binding for Stagiair LookUp editor
			fluentAPI.SetBinding(StagiairLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStagiairs.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
