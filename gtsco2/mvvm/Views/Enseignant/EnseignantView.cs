using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.EnseignantView{
    public partial class EnseignantView : XtraUserControl {
        public EnseignantView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.EnseignantViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                enseignantViewBindingSource, x => x.Entity, x => x.Update());
				#region Evaluations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EvaluationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EnseignantEvaluationsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Evaluation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EvaluationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.EnseignantEvaluationsDetails.Edit(null), x => x.EnseignantEvaluationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EvaluationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EvaluationsPopUpMenu.ShowPopup(EvaluationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EnseignantEvaluationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EvaluationsGridControl, g => g.DataSource, x => x.EnseignantEvaluationsDetails.Entities);
				
														fluentAPI.BindCommand(bbiEvaluationsNew, x => x.EnseignantEvaluationsDetails.New());
																													fluentAPI.BindCommand(bbiEvaluationsEdit,x => x.EnseignantEvaluationsDetails.Edit(null), x=>x.EnseignantEvaluationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEvaluationsDelete,x => x.EnseignantEvaluationsDetails.Delete(null), x=>x.EnseignantEvaluationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEvaluationsRefresh, x => x.EnseignantEvaluationsDetails.Refresh());
																	#endregion
						#region PARTICIPEs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PARTICIPEsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EnseignantPARTICIPEsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.PARTICIPE,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PARTICIPEsGridView, "RowClick")
						 .EventToCommand(
						     x => x.EnseignantPARTICIPEsDetails.Edit(null), x => x.EnseignantPARTICIPEsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PARTICIPEsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PARTICIPEsPopUpMenu.ShowPopup(PARTICIPEsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EnseignantPARTICIPEsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PARTICIPEsGridControl, g => g.DataSource, x => x.EnseignantPARTICIPEsDetails.Entities);
				
														fluentAPI.BindCommand(bbiPARTICIPEsNew, x => x.EnseignantPARTICIPEsDetails.New());
																													fluentAPI.BindCommand(bbiPARTICIPEsEdit,x => x.EnseignantPARTICIPEsDetails.Edit(null), x=>x.EnseignantPARTICIPEsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPARTICIPEsDelete,x => x.EnseignantPARTICIPEsDetails.Delete(null), x=>x.EnseignantPARTICIPEsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPARTICIPEsRefresh, x => x.EnseignantPARTICIPEsDetails.Refresh());
																	#endregion
						#region Suiver_stagiaire Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Suiver_stagiaireGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EnseignantSuiver_stagiaireDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Suiver_stagiaire,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Suiver_stagiaireGridView, "RowClick")
						 .EventToCommand(
						     x => x.EnseignantSuiver_stagiaireDetails.Edit(null), x => x.EnseignantSuiver_stagiaireDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Suiver_stagiaireGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Suiver_stagiairePopUpMenu.ShowPopup(Suiver_stagiaireGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EnseignantSuiver_stagiaireDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Suiver_stagiaireGridControl, g => g.DataSource, x => x.EnseignantSuiver_stagiaireDetails.Entities);
				
														fluentAPI.BindCommand(bbiSuiver_stagiaireNew, x => x.EnseignantSuiver_stagiaireDetails.New());
																													fluentAPI.BindCommand(bbiSuiver_stagiaireEdit,x => x.EnseignantSuiver_stagiaireDetails.Edit(null), x=>x.EnseignantSuiver_stagiaireDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSuiver_stagiaireDelete,x => x.EnseignantSuiver_stagiaireDetails.Delete(null), x=>x.EnseignantSuiver_stagiaireDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSuiver_stagiaireRefresh, x => x.EnseignantSuiver_stagiaireDetails.Refresh());
																	#endregion
									// Binding for Mode_formation1 LookUp editor
			fluentAPI.SetBinding(Mode_formation1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpMode_formation.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
