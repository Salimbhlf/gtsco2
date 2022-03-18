using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.WillayaView{
    public partial class WillayaView : XtraUserControl {
        public WillayaView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.WillayaViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                willayaViewBindingSource, x => x.Entity, x => x.Update());
				#region Communes Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CommunesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.WillayaCommunesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Commune,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(CommunesGridView, "RowClick")
						 .EventToCommand(
						     x => x.WillayaCommunesDetails.Edit(null), x => x.WillayaCommunesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			CommunesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CommunesPopUpMenu.ShowPopup(CommunesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the WillayaCommunesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CommunesGridControl, g => g.DataSource, x => x.WillayaCommunesDetails.Entities);
				
														fluentAPI.BindCommand(bbiCommunesNew, x => x.WillayaCommunesDetails.New());
																													fluentAPI.BindCommand(bbiCommunesEdit,x => x.WillayaCommunesDetails.Edit(null), x=>x.WillayaCommunesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCommunesDelete,x => x.WillayaCommunesDetails.Delete(null), x=>x.WillayaCommunesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCommunesRefresh, x => x.WillayaCommunesDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
