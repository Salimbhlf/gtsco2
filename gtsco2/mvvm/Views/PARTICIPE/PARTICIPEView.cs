using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.PARTICIPEView{
    public partial class PARTICIPEView : XtraUserControl {
        public PARTICIPEView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.PARTICIPEViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                pARTICIPEViewBindingSource, x => x.Entity, x => x.Update());
							// Binding for Enseignant LookUp editor
			fluentAPI.SetBinding(EnseignantLookUpEdit.Properties, p => p.DataSource, x => x.LookUpEnseignants.Entities);
						// Binding for Proce_verbal_delibation LookUp editor
			fluentAPI.SetBinding(Proce_verbal_delibationLookUpEdit.Properties, p => p.DataSource, x => x.LookUpProce_verbal_delibation.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
