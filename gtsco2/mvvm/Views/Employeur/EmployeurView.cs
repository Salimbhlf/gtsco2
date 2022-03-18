using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.EmployeurView{
    public partial class EmployeurView : XtraUserControl {
        public EmployeurView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.EmployeurViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                employeurViewBindingSource, x => x.Entity, x => x.Update());
				#region Stagiairs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StagiairsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EmployeurStagiairsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Stagiair,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(StagiairsGridView, "RowClick")
						 .EventToCommand(
						     x => x.EmployeurStagiairsDetails.Edit(null), x => x.EmployeurStagiairsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			StagiairsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    StagiairsPopUpMenu.ShowPopup(StagiairsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EmployeurStagiairsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(StagiairsGridControl, g => g.DataSource, x => x.EmployeurStagiairsDetails.Entities);
				
														fluentAPI.BindCommand(bbiStagiairsNew, x => x.EmployeurStagiairsDetails.New());
																													fluentAPI.BindCommand(bbiStagiairsEdit,x => x.EmployeurStagiairsDetails.Edit(null), x=>x.EmployeurStagiairsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStagiairsDelete,x => x.EmployeurStagiairsDetails.Delete(null), x=>x.EmployeurStagiairsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStagiairsRefresh, x => x.EmployeurStagiairsDetails.Refresh());
																	#endregion
						#region Avenant_contrat_prorogation Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Avenant_contrat_prorogationGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EmployeurAvenant_contrat_prorogationDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Avenant_contrat_prorogation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Avenant_contrat_prorogationGridView, "RowClick")
						 .EventToCommand(
						     x => x.EmployeurAvenant_contrat_prorogationDetails.Edit(null), x => x.EmployeurAvenant_contrat_prorogationDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Avenant_contrat_prorogationGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Avenant_contrat_prorogationPopUpMenu.ShowPopup(Avenant_contrat_prorogationGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EmployeurAvenant_contrat_prorogationDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Avenant_contrat_prorogationGridControl, g => g.DataSource, x => x.EmployeurAvenant_contrat_prorogationDetails.Entities);
				
														fluentAPI.BindCommand(bbiAvenant_contrat_prorogationNew, x => x.EmployeurAvenant_contrat_prorogationDetails.New());
																													fluentAPI.BindCommand(bbiAvenant_contrat_prorogationEdit,x => x.EmployeurAvenant_contrat_prorogationDetails.Edit(null), x=>x.EmployeurAvenant_contrat_prorogationDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiAvenant_contrat_prorogationDelete,x => x.EmployeurAvenant_contrat_prorogationDetails.Delete(null), x=>x.EmployeurAvenant_contrat_prorogationDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiAvenant_contrat_prorogationRefresh, x => x.EmployeurAvenant_contrat_prorogationDetails.Refresh());
																	#endregion
						#region Maitre_Apprentissage Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Maitre_ApprentissageGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EmployeurMaitre_ApprentissageDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Maitre_Apprentissage,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Maitre_ApprentissageGridView, "RowClick")
						 .EventToCommand(
						     x => x.EmployeurMaitre_ApprentissageDetails.Edit(null), x => x.EmployeurMaitre_ApprentissageDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Maitre_ApprentissageGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Maitre_ApprentissagePopUpMenu.ShowPopup(Maitre_ApprentissageGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EmployeurMaitre_ApprentissageDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Maitre_ApprentissageGridControl, g => g.DataSource, x => x.EmployeurMaitre_ApprentissageDetails.Entities);
				
														fluentAPI.BindCommand(bbiMaitre_ApprentissageNew, x => x.EmployeurMaitre_ApprentissageDetails.New());
																													fluentAPI.BindCommand(bbiMaitre_ApprentissageEdit,x => x.EmployeurMaitre_ApprentissageDetails.Edit(null), x=>x.EmployeurMaitre_ApprentissageDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiMaitre_ApprentissageDelete,x => x.EmployeurMaitre_ApprentissageDetails.Delete(null), x=>x.EmployeurMaitre_ApprentissageDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiMaitre_ApprentissageRefresh, x => x.EmployeurMaitre_ApprentissageDetails.Refresh());
																	#endregion
						#region Contract_avenant_changement Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Contract_avenant_changementGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EmployeurContract_avenant_changementDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Contract_avenant_changement,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Contract_avenant_changementGridView, "RowClick")
						 .EventToCommand(
						     x => x.EmployeurContract_avenant_changementDetails.Edit(null), x => x.EmployeurContract_avenant_changementDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Contract_avenant_changementGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Contract_avenant_changementPopUpMenu.ShowPopup(Contract_avenant_changementGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EmployeurContract_avenant_changementDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Contract_avenant_changementGridControl, g => g.DataSource, x => x.EmployeurContract_avenant_changementDetails.Entities);
				
														fluentAPI.BindCommand(bbiContract_avenant_changementNew, x => x.EmployeurContract_avenant_changementDetails.New());
																													fluentAPI.BindCommand(bbiContract_avenant_changementEdit,x => x.EmployeurContract_avenant_changementDetails.Edit(null), x=>x.EmployeurContract_avenant_changementDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiContract_avenant_changementDelete,x => x.EmployeurContract_avenant_changementDetails.Delete(null), x=>x.EmployeurContract_avenant_changementDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiContract_avenant_changementRefresh, x => x.EmployeurContract_avenant_changementDetails.Refresh());
																	#endregion
									// Binding for Code_Postal LookUp editor
			fluentAPI.SetBinding(Code_PostalLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCode_Postal.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
