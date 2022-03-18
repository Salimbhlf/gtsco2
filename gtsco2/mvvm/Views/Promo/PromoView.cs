using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.PromoView{
    public partial class PromoView : XtraUserControl {
        public PromoView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.PromoViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                promoViewBindingSource, x => x.Entity, x => x.Update());
				#region Decisions Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(DecisionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PromoDecisionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Decision,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(DecisionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PromoDecisionsDetails.Edit(null), x => x.PromoDecisionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			DecisionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    DecisionsPopUpMenu.ShowPopup(DecisionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PromoDecisionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(DecisionsGridControl, g => g.DataSource, x => x.PromoDecisionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiDecisionsNew, x => x.PromoDecisionsDetails.New());
																													fluentAPI.BindCommand(bbiDecisionsEdit,x => x.PromoDecisionsDetails.Edit(null), x=>x.PromoDecisionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiDecisionsDelete,x => x.PromoDecisionsDetails.Delete(null), x=>x.PromoDecisionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiDecisionsRefresh, x => x.PromoDecisionsDetails.Refresh());
																	#endregion
						#region Sections Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SectionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PromoSectionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SectionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PromoSectionsDetails.Edit(null), x => x.PromoSectionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SectionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SectionsPopUpMenu.ShowPopup(SectionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PromoSectionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SectionsGridControl, g => g.DataSource, x => x.PromoSectionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiSectionsNew, x => x.PromoSectionsDetails.New());
																													fluentAPI.BindCommand(bbiSectionsEdit,x => x.PromoSectionsDetails.Edit(null), x=>x.PromoSectionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSectionsDelete,x => x.PromoSectionsDetails.Delete(null), x=>x.PromoSectionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSectionsRefresh, x => x.PromoSectionsDetails.Refresh());
																	#endregion
						#region Stagiairs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StagiairsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PromoStagiairsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Stagiair,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(StagiairsGridView, "RowClick")
						 .EventToCommand(
						     x => x.PromoStagiairsDetails.Edit(null), x => x.PromoStagiairsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			StagiairsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    StagiairsPopUpMenu.ShowPopup(StagiairsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PromoStagiairsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(StagiairsGridControl, g => g.DataSource, x => x.PromoStagiairsDetails.Entities);
				
														fluentAPI.BindCommand(bbiStagiairsNew, x => x.PromoStagiairsDetails.New());
																													fluentAPI.BindCommand(bbiStagiairsEdit,x => x.PromoStagiairsDetails.Edit(null), x=>x.PromoStagiairsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStagiairsDelete,x => x.PromoStagiairsDetails.Delete(null), x=>x.PromoStagiairsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStagiairsRefresh, x => x.PromoStagiairsDetails.Refresh());
																	#endregion
									// Binding for Mode_formation LookUp editor
			fluentAPI.SetBinding(Mode_formationLookUpEdit.Properties, p => p.DataSource, x => x.LookUpMode_formation.Entities);
						// Binding for Option LookUp editor
			fluentAPI.SetBinding(OptionLookUpEdit.Properties, p => p.DataSource, x => x.LookUpOptions.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
