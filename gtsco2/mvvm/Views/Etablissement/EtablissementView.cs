using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.EtablissementView{
    public partial class EtablissementView : XtraUserControl {
        public EtablissementView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.EtablissementViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                etablissementViewBindingSource, x => x.Entity, x => x.Update());
				#region Stagiairs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StagiairsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EtablissementStagiairsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Stagiair,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(StagiairsGridView, "RowClick")
						 .EventToCommand(
						     x => x.EtablissementStagiairsDetails.Edit(null), x => x.EtablissementStagiairsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			StagiairsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    StagiairsPopUpMenu.ShowPopup(StagiairsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EtablissementStagiairsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(StagiairsGridControl, g => g.DataSource, x => x.EtablissementStagiairsDetails.Entities);
				
														fluentAPI.BindCommand(bbiStagiairsNew, x => x.EtablissementStagiairsDetails.New());
																													fluentAPI.BindCommand(bbiStagiairsEdit,x => x.EtablissementStagiairsDetails.Edit(null), x=>x.EtablissementStagiairsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStagiairsDelete,x => x.EtablissementStagiairsDetails.Delete(null), x=>x.EtablissementStagiairsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStagiairsRefresh, x => x.EtablissementStagiairsDetails.Refresh());
																	#endregion
						#region Transferers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(TransferersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EtablissementTransferersDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Transferer,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(TransferersGridView, "RowClick")
						 .EventToCommand(
						     x => x.EtablissementTransferersDetails.Edit(null), x => x.EtablissementTransferersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			TransferersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    TransferersPopUpMenu.ShowPopup(TransferersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the EtablissementTransferersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(TransferersGridControl, g => g.DataSource, x => x.EtablissementTransferersDetails.Entities);
				
														fluentAPI.BindCommand(bbiTransferersNew, x => x.EtablissementTransferersDetails.New());
																													fluentAPI.BindCommand(bbiTransferersEdit,x => x.EtablissementTransferersDetails.Edit(null), x=>x.EtablissementTransferersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiTransferersDelete,x => x.EtablissementTransferersDetails.Delete(null), x=>x.EtablissementTransferersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiTransferersRefresh, x => x.EtablissementTransferersDetails.Refresh());
																	#endregion
									// Binding for Code_Postal LookUp editor
			fluentAPI.SetBinding(Code_PostalLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCode_Postal.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
