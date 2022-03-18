using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.Code_PostalView{
    public partial class Code_PostalView : XtraUserControl {
        public Code_PostalView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.Code_PostalViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                code_PostalViewBindingSource, x => x.Entity, x => x.Update());
				#region Stagiairs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StagiairsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Code_PostalStagiairsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Stagiair,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(StagiairsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Code_PostalStagiairsDetails.Edit(null), x => x.Code_PostalStagiairsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			StagiairsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    StagiairsPopUpMenu.ShowPopup(StagiairsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Code_PostalStagiairsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(StagiairsGridControl, g => g.DataSource, x => x.Code_PostalStagiairsDetails.Entities);
				
														fluentAPI.BindCommand(bbiStagiairsNew, x => x.Code_PostalStagiairsDetails.New());
																													fluentAPI.BindCommand(bbiStagiairsEdit,x => x.Code_PostalStagiairsDetails.Edit(null), x=>x.Code_PostalStagiairsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStagiairsDelete,x => x.Code_PostalStagiairsDetails.Delete(null), x=>x.Code_PostalStagiairsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStagiairsRefresh, x => x.Code_PostalStagiairsDetails.Refresh());
																	#endregion
						#region Employeurs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EmployeursGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Code_PostalEmployeursDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Employeur,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EmployeursGridView, "RowClick")
						 .EventToCommand(
						     x => x.Code_PostalEmployeursDetails.Edit(null), x => x.Code_PostalEmployeursDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EmployeursGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EmployeursPopUpMenu.ShowPopup(EmployeursGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Code_PostalEmployeursDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EmployeursGridControl, g => g.DataSource, x => x.Code_PostalEmployeursDetails.Entities);
				
														fluentAPI.BindCommand(bbiEmployeursNew, x => x.Code_PostalEmployeursDetails.New());
																													fluentAPI.BindCommand(bbiEmployeursEdit,x => x.Code_PostalEmployeursDetails.Edit(null), x=>x.Code_PostalEmployeursDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEmployeursDelete,x => x.Code_PostalEmployeursDetails.Delete(null), x=>x.Code_PostalEmployeursDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEmployeursRefresh, x => x.Code_PostalEmployeursDetails.Refresh());
																	#endregion
						#region Etablissements Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EtablissementsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Code_PostalEtablissementsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Etablissement,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EtablissementsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Code_PostalEtablissementsDetails.Edit(null), x => x.Code_PostalEtablissementsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EtablissementsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EtablissementsPopUpMenu.ShowPopup(EtablissementsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Code_PostalEtablissementsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EtablissementsGridControl, g => g.DataSource, x => x.Code_PostalEtablissementsDetails.Entities);
				
														fluentAPI.BindCommand(bbiEtablissementsNew, x => x.Code_PostalEtablissementsDetails.New());
																													fluentAPI.BindCommand(bbiEtablissementsEdit,x => x.Code_PostalEtablissementsDetails.Edit(null), x=>x.Code_PostalEtablissementsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEtablissementsDelete,x => x.Code_PostalEtablissementsDetails.Delete(null), x=>x.Code_PostalEtablissementsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEtablissementsRefresh, x => x.Code_PostalEtablissementsDetails.Refresh());
																	#endregion
									// Binding for Commune LookUp editor
			fluentAPI.SetBinding(CommuneLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCommunes.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
