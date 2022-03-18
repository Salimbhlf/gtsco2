using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.SemestreView{
    public partial class SemestreView : XtraUserControl {
        public SemestreView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.SemestreViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                semestreViewBindingSource, x => x.Entity, x => x.Update());
				#region Absences Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(AbsencesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SemestreAbsencesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Absence,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(AbsencesGridView, "RowClick")
						 .EventToCommand(
						     x => x.SemestreAbsencesDetails.Edit(null), x => x.SemestreAbsencesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			AbsencesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    AbsencesPopUpMenu.ShowPopup(AbsencesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SemestreAbsencesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(AbsencesGridControl, g => g.DataSource, x => x.SemestreAbsencesDetails.Entities);
				
														fluentAPI.BindCommand(bbiAbsencesNew, x => x.SemestreAbsencesDetails.New());
																													fluentAPI.BindCommand(bbiAbsencesEdit,x => x.SemestreAbsencesDetails.Edit(null), x=>x.SemestreAbsencesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiAbsencesDelete,x => x.SemestreAbsencesDetails.Delete(null), x=>x.SemestreAbsencesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiAbsencesRefresh, x => x.SemestreAbsencesDetails.Refresh());
																	#endregion
						#region Evaluations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EvaluationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SemestreEvaluationsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Evaluation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EvaluationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.SemestreEvaluationsDetails.Edit(null), x => x.SemestreEvaluationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EvaluationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EvaluationsPopUpMenu.ShowPopup(EvaluationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SemestreEvaluationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EvaluationsGridControl, g => g.DataSource, x => x.SemestreEvaluationsDetails.Entities);
				
														fluentAPI.BindCommand(bbiEvaluationsNew, x => x.SemestreEvaluationsDetails.New());
																													fluentAPI.BindCommand(bbiEvaluationsEdit,x => x.SemestreEvaluationsDetails.Edit(null), x=>x.SemestreEvaluationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEvaluationsDelete,x => x.SemestreEvaluationsDetails.Delete(null), x=>x.SemestreEvaluationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEvaluationsRefresh, x => x.SemestreEvaluationsDetails.Refresh());
																	#endregion
						#region Decisions Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(DecisionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SemestreDecisionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Decision,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(DecisionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.SemestreDecisionsDetails.Edit(null), x => x.SemestreDecisionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			DecisionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    DecisionsPopUpMenu.ShowPopup(DecisionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SemestreDecisionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(DecisionsGridControl, g => g.DataSource, x => x.SemestreDecisionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiDecisionsNew, x => x.SemestreDecisionsDetails.New());
																													fluentAPI.BindCommand(bbiDecisionsEdit,x => x.SemestreDecisionsDetails.Edit(null), x=>x.SemestreDecisionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiDecisionsDelete,x => x.SemestreDecisionsDetails.Delete(null), x=>x.SemestreDecisionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiDecisionsRefresh, x => x.SemestreDecisionsDetails.Refresh());
																	#endregion
						#region Sections Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SectionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SemestreSectionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SectionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.SemestreSectionsDetails.Edit(null), x => x.SemestreSectionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SectionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SectionsPopUpMenu.ShowPopup(SectionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SemestreSectionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SectionsGridControl, g => g.DataSource, x => x.SemestreSectionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiSectionsNew, x => x.SemestreSectionsDetails.New());
																													fluentAPI.BindCommand(bbiSectionsEdit,x => x.SemestreSectionsDetails.Edit(null), x=>x.SemestreSectionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSectionsDelete,x => x.SemestreSectionsDetails.Delete(null), x=>x.SemestreSectionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSectionsRefresh, x => x.SemestreSectionsDetails.Refresh());
																	#endregion
						#region Suiver_stagiaire Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Suiver_stagiaireGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SemestreSuiver_stagiaireDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Suiver_stagiaire,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Suiver_stagiaireGridView, "RowClick")
						 .EventToCommand(
						     x => x.SemestreSuiver_stagiaireDetails.Edit(null), x => x.SemestreSuiver_stagiaireDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Suiver_stagiaireGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Suiver_stagiairePopUpMenu.ShowPopup(Suiver_stagiaireGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SemestreSuiver_stagiaireDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Suiver_stagiaireGridControl, g => g.DataSource, x => x.SemestreSuiver_stagiaireDetails.Entities);
				
														fluentAPI.BindCommand(bbiSuiver_stagiaireNew, x => x.SemestreSuiver_stagiaireDetails.New());
																													fluentAPI.BindCommand(bbiSuiver_stagiaireEdit,x => x.SemestreSuiver_stagiaireDetails.Edit(null), x=>x.SemestreSuiver_stagiaireDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSuiver_stagiaireDelete,x => x.SemestreSuiver_stagiaireDetails.Delete(null), x=>x.SemestreSuiver_stagiaireDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSuiver_stagiaireRefresh, x => x.SemestreSuiver_stagiaireDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
