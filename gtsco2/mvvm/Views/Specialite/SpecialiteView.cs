using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.SpecialiteView{
    public partial class SpecialiteView : XtraUserControl {
        public SpecialiteView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.SpecialiteViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                specialiteViewBindingSource, x => x.Entity, x => x.Update());
				#region Options Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(OptionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SpecialiteOptionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Option,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(OptionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.SpecialiteOptionsDetails.Edit(null), x => x.SpecialiteOptionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			OptionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    OptionsPopUpMenu.ShowPopup(OptionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SpecialiteOptionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(OptionsGridControl, g => g.DataSource, x => x.SpecialiteOptionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiOptionsNew, x => x.SpecialiteOptionsDetails.New());
																													fluentAPI.BindCommand(bbiOptionsEdit,x => x.SpecialiteOptionsDetails.Edit(null), x=>x.SpecialiteOptionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiOptionsDelete,x => x.SpecialiteOptionsDetails.Delete(null), x=>x.SpecialiteOptionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiOptionsRefresh, x => x.SpecialiteOptionsDetails.Refresh());
																	#endregion
									// Binding for Branch LookUp editor
			fluentAPI.SetBinding(BranchLookUpEdit.Properties, p => p.DataSource, x => x.LookUpBranches.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
