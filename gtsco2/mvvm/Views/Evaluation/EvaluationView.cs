using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.EvaluationView{
    public partial class EvaluationView : XtraUserControl {
        public EvaluationView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.EvaluationViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                evaluationViewBindingSource, x => x.Entity, x => x.Update());
							// Binding for annee_scolaire LookUp editor
			fluentAPI.SetBinding(annee_scolaireLookUpEdit.Properties, p => p.DataSource, x => x.LookUpannee_scolaire.Entities);
						// Binding for Enseignant1 LookUp editor
			fluentAPI.SetBinding(Enseignant1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpEnseignants.Entities);
						// Binding for Module LookUp editor
			fluentAPI.SetBinding(ModuleLookUpEdit.Properties, p => p.DataSource, x => x.LookUpModules.Entities);
						// Binding for Semestre LookUp editor
			fluentAPI.SetBinding(SemestreLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSemestres.Entities);
						// Binding for Stagiair LookUp editor
			fluentAPI.SetBinding(StagiairLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStagiairs.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
