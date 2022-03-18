using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.BranchView{
    public partial class BranchView : XtraUserControl {
        public BranchView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.BranchViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                branchViewBindingSource, x => x.Entity, x => x.Update());
				#region Specialites Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SpecialitesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BranchSpecialitesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Specialite,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SpecialitesGridView, "RowClick")
						 .EventToCommand(
						     x => x.BranchSpecialitesDetails.Edit(null), x => x.BranchSpecialitesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SpecialitesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SpecialitesPopUpMenu.ShowPopup(SpecialitesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the BranchSpecialitesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SpecialitesGridControl, g => g.DataSource, x => x.BranchSpecialitesDetails.Entities);
				
														fluentAPI.BindCommand(bbiSpecialitesNew, x => x.BranchSpecialitesDetails.New());
																													fluentAPI.BindCommand(bbiSpecialitesEdit,x => x.BranchSpecialitesDetails.Edit(null), x=>x.BranchSpecialitesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSpecialitesDelete,x => x.BranchSpecialitesDetails.Delete(null), x=>x.BranchSpecialitesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSpecialitesRefresh, x => x.BranchSpecialitesDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
