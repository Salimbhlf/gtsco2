using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.Mode_formationView{
    public partial class Mode_formationView : XtraUserControl {
        public Mode_formationView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.Mode_formationViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                mode_formationViewBindingSource, x => x.Entity, x => x.Update());
				#region Enseignants Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EnseignantsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Mode_formationEnseignantsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Enseignant,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EnseignantsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Mode_formationEnseignantsDetails.Edit(null), x => x.Mode_formationEnseignantsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EnseignantsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EnseignantsPopUpMenu.ShowPopup(EnseignantsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Mode_formationEnseignantsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EnseignantsGridControl, g => g.DataSource, x => x.Mode_formationEnseignantsDetails.Entities);
				
														fluentAPI.BindCommand(bbiEnseignantsNew, x => x.Mode_formationEnseignantsDetails.New());
																													fluentAPI.BindCommand(bbiEnseignantsEdit,x => x.Mode_formationEnseignantsDetails.Edit(null), x=>x.Mode_formationEnseignantsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEnseignantsDelete,x => x.Mode_formationEnseignantsDetails.Delete(null), x=>x.Mode_formationEnseignantsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEnseignantsRefresh, x => x.Mode_formationEnseignantsDetails.Refresh());
																	#endregion
						#region Promoes Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PromoesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Mode_formationPromoesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Promo,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PromoesGridView, "RowClick")
						 .EventToCommand(
						     x => x.Mode_formationPromoesDetails.Edit(null), x => x.Mode_formationPromoesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PromoesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PromoesPopUpMenu.ShowPopup(PromoesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Mode_formationPromoesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PromoesGridControl, g => g.DataSource, x => x.Mode_formationPromoesDetails.Entities);
				
														fluentAPI.BindCommand(bbiPromoesNew, x => x.Mode_formationPromoesDetails.New());
																													fluentAPI.BindCommand(bbiPromoesEdit,x => x.Mode_formationPromoesDetails.Edit(null), x=>x.Mode_formationPromoesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPromoesDelete,x => x.Mode_formationPromoesDetails.Delete(null), x=>x.Mode_formationPromoesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPromoesRefresh, x => x.Mode_formationPromoesDetails.Refresh());
																	#endregion
						#region Sections Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SectionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Mode_formationSectionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SectionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Mode_formationSectionsDetails.Edit(null), x => x.Mode_formationSectionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SectionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SectionsPopUpMenu.ShowPopup(SectionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Mode_formationSectionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SectionsGridControl, g => g.DataSource, x => x.Mode_formationSectionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiSectionsNew, x => x.Mode_formationSectionsDetails.New());
																													fluentAPI.BindCommand(bbiSectionsEdit,x => x.Mode_formationSectionsDetails.Edit(null), x=>x.Mode_formationSectionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSectionsDelete,x => x.Mode_formationSectionsDetails.Delete(null), x=>x.Mode_formationSectionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSectionsRefresh, x => x.Mode_formationSectionsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
