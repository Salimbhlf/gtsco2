using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.OptionView{
    public partial class OptionView : XtraUserControl {
        public OptionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.OptionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                optionViewBindingSource, x => x.Entity, x => x.Update());
				#region Promoes Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PromoesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.OptionPromoesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Promo,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PromoesGridView, "RowClick")
						 .EventToCommand(
						     x => x.OptionPromoesDetails.Edit(null), x => x.OptionPromoesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PromoesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PromoesPopUpMenu.ShowPopup(PromoesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the OptionPromoesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PromoesGridControl, g => g.DataSource, x => x.OptionPromoesDetails.Entities);
				
														fluentAPI.BindCommand(bbiPromoesNew, x => x.OptionPromoesDetails.New());
																													fluentAPI.BindCommand(bbiPromoesEdit,x => x.OptionPromoesDetails.Edit(null), x=>x.OptionPromoesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPromoesDelete,x => x.OptionPromoesDetails.Delete(null), x=>x.OptionPromoesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPromoesRefresh, x => x.OptionPromoesDetails.Refresh());
																	#endregion
						#region Sections Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SectionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.OptionSectionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SectionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.OptionSectionsDetails.Edit(null), x => x.OptionSectionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SectionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SectionsPopUpMenu.ShowPopup(SectionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the OptionSectionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SectionsGridControl, g => g.DataSource, x => x.OptionSectionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiSectionsNew, x => x.OptionSectionsDetails.New());
																													fluentAPI.BindCommand(bbiSectionsEdit,x => x.OptionSectionsDetails.Edit(null), x=>x.OptionSectionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSectionsDelete,x => x.OptionSectionsDetails.Delete(null), x=>x.OptionSectionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSectionsRefresh, x => x.OptionSectionsDetails.Refresh());
																	#endregion
						#region Modules Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ModulesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.OptionModulesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Module,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ModulesGridView, "RowClick")
						 .EventToCommand(
						     x => x.OptionModulesDetails.Edit(null), x => x.OptionModulesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ModulesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ModulesPopUpMenu.ShowPopup(ModulesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the OptionModulesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ModulesGridControl, g => g.DataSource, x => x.OptionModulesDetails.Entities);
				
														fluentAPI.BindCommand(bbiModulesNew, x => x.OptionModulesDetails.New());
																													fluentAPI.BindCommand(bbiModulesEdit,x => x.OptionModulesDetails.Edit(null), x=>x.OptionModulesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiModulesDelete,x => x.OptionModulesDetails.Delete(null), x=>x.OptionModulesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiModulesRefresh, x => x.OptionModulesDetails.Refresh());
																	#endregion
									// Binding for Specialite1 LookUp editor
			fluentAPI.SetBinding(Specialite1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpSpecialites.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
