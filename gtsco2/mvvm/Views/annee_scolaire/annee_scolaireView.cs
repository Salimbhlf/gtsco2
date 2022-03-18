using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.annee_scolaireView{
    public partial class annee_scolaireView : XtraUserControl {
        public annee_scolaireView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.annee_scolaireViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                annee_scolaireViewBindingSource, x => x.Entity, x => x.Update());
				#region Absences Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(AbsencesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.annee_scolaireAbsencesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Absence,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(AbsencesGridView, "RowClick")
						 .EventToCommand(
						     x => x.annee_scolaireAbsencesDetails.Edit(null), x => x.annee_scolaireAbsencesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			AbsencesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    AbsencesPopUpMenu.ShowPopup(AbsencesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the annee_scolaireAbsencesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(AbsencesGridControl, g => g.DataSource, x => x.annee_scolaireAbsencesDetails.Entities);
				
														fluentAPI.BindCommand(bbiAbsencesNew, x => x.annee_scolaireAbsencesDetails.New());
																													fluentAPI.BindCommand(bbiAbsencesEdit,x => x.annee_scolaireAbsencesDetails.Edit(null), x=>x.annee_scolaireAbsencesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiAbsencesDelete,x => x.annee_scolaireAbsencesDetails.Delete(null), x=>x.annee_scolaireAbsencesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiAbsencesRefresh, x => x.annee_scolaireAbsencesDetails.Refresh());
																	#endregion
						#region Evaluations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EvaluationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.annee_scolaireEvaluationsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Evaluation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EvaluationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.annee_scolaireEvaluationsDetails.Edit(null), x => x.annee_scolaireEvaluationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EvaluationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EvaluationsPopUpMenu.ShowPopup(EvaluationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the annee_scolaireEvaluationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EvaluationsGridControl, g => g.DataSource, x => x.annee_scolaireEvaluationsDetails.Entities);
				
														fluentAPI.BindCommand(bbiEvaluationsNew, x => x.annee_scolaireEvaluationsDetails.New());
																													fluentAPI.BindCommand(bbiEvaluationsEdit,x => x.annee_scolaireEvaluationsDetails.Edit(null), x=>x.annee_scolaireEvaluationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEvaluationsDelete,x => x.annee_scolaireEvaluationsDetails.Delete(null), x=>x.annee_scolaireEvaluationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEvaluationsRefresh, x => x.annee_scolaireEvaluationsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
