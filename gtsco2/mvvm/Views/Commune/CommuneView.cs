using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.CommuneView{
    public partial class CommuneView : XtraUserControl {
        public CommuneView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.CommuneViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                communeViewBindingSource, x => x.Entity, x => x.Update());
				#region Stagiairs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StagiairsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CommuneStagiairsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Stagiair,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(StagiairsGridView, "RowClick")
						 .EventToCommand(
						     x => x.CommuneStagiairsDetails.Edit(null), x => x.CommuneStagiairsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			StagiairsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    StagiairsPopUpMenu.ShowPopup(StagiairsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CommuneStagiairsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(StagiairsGridControl, g => g.DataSource, x => x.CommuneStagiairsDetails.Entities);
				
														fluentAPI.BindCommand(bbiStagiairsNew, x => x.CommuneStagiairsDetails.New());
																													fluentAPI.BindCommand(bbiStagiairsEdit,x => x.CommuneStagiairsDetails.Edit(null), x=>x.CommuneStagiairsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStagiairsDelete,x => x.CommuneStagiairsDetails.Delete(null), x=>x.CommuneStagiairsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStagiairsRefresh, x => x.CommuneStagiairsDetails.Refresh());
																	#endregion
						#region Code_Postal Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Code_PostalGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CommuneCode_PostalDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Code_Postal,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Code_PostalGridView, "RowClick")
						 .EventToCommand(
						     x => x.CommuneCode_PostalDetails.Edit(null), x => x.CommuneCode_PostalDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Code_PostalGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Code_PostalPopUpMenu.ShowPopup(Code_PostalGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CommuneCode_PostalDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Code_PostalGridControl, g => g.DataSource, x => x.CommuneCode_PostalDetails.Entities);
				
														fluentAPI.BindCommand(bbiCode_PostalNew, x => x.CommuneCode_PostalDetails.New());
																													fluentAPI.BindCommand(bbiCode_PostalEdit,x => x.CommuneCode_PostalDetails.Edit(null), x=>x.CommuneCode_PostalDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCode_PostalDelete,x => x.CommuneCode_PostalDetails.Delete(null), x=>x.CommuneCode_PostalDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCode_PostalRefresh, x => x.CommuneCode_PostalDetails.Refresh());
																	#endregion
						#region Maitre_Apprentissage Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Maitre_ApprentissageGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CommuneMaitre_ApprentissageDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Maitre_Apprentissage,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Maitre_ApprentissageGridView, "RowClick")
						 .EventToCommand(
						     x => x.CommuneMaitre_ApprentissageDetails.Edit(null), x => x.CommuneMaitre_ApprentissageDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Maitre_ApprentissageGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Maitre_ApprentissagePopUpMenu.ShowPopup(Maitre_ApprentissageGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CommuneMaitre_ApprentissageDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Maitre_ApprentissageGridControl, g => g.DataSource, x => x.CommuneMaitre_ApprentissageDetails.Entities);
				
														fluentAPI.BindCommand(bbiMaitre_ApprentissageNew, x => x.CommuneMaitre_ApprentissageDetails.New());
																													fluentAPI.BindCommand(bbiMaitre_ApprentissageEdit,x => x.CommuneMaitre_ApprentissageDetails.Edit(null), x=>x.CommuneMaitre_ApprentissageDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiMaitre_ApprentissageDelete,x => x.CommuneMaitre_ApprentissageDetails.Delete(null), x=>x.CommuneMaitre_ApprentissageDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiMaitre_ApprentissageRefresh, x => x.CommuneMaitre_ApprentissageDetails.Refresh());
																	#endregion
									// Binding for Willaya LookUp editor
			fluentAPI.SetBinding(WillayaLookUpEdit.Properties, p => p.DataSource, x => x.LookUpWillayas.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
