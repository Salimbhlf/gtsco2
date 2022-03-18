using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.Suiver_stagiaireView{
    public partial class Suiver_stagiaireView : XtraUserControl {
        public Suiver_stagiaireView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.Suiver_stagiaireViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                suiver_stagiaireViewBindingSource, x => x.Entity, x => x.Update());
							// Binding for Enseignant1 LookUp editor
			fluentAPI.SetBinding(Enseignant1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpEnseignants.Entities);
						// Binding for Semestre1 LookUp editor
			fluentAPI.SetBinding(Semestre1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpSemestres.Entities);
						// Binding for Stagiair LookUp editor
			fluentAPI.SetBinding(StagiairLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStagiairs.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
