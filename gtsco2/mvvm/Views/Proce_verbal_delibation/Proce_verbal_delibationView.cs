using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.Proce_verbal_delibationView{
    public partial class Proce_verbal_delibationView : XtraUserControl {
        public Proce_verbal_delibationView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                proce_verbal_delibationViewBindingSource, x => x.Entity, x => x.Update());
				#region Decisions Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(DecisionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Proce_verbal_delibationDecisionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Decision,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(DecisionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Proce_verbal_delibationDecisionsDetails.Edit(null), x => x.Proce_verbal_delibationDecisionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			DecisionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    DecisionsPopUpMenu.ShowPopup(DecisionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Proce_verbal_delibationDecisionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(DecisionsGridControl, g => g.DataSource, x => x.Proce_verbal_delibationDecisionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiDecisionsNew, x => x.Proce_verbal_delibationDecisionsDetails.New());
																													fluentAPI.BindCommand(bbiDecisionsEdit,x => x.Proce_verbal_delibationDecisionsDetails.Edit(null), x=>x.Proce_verbal_delibationDecisionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiDecisionsDelete,x => x.Proce_verbal_delibationDecisionsDetails.Delete(null), x=>x.Proce_verbal_delibationDecisionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiDecisionsRefresh, x => x.Proce_verbal_delibationDecisionsDetails.Refresh());
																	#endregion
						#region PARTICIPEs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PARTICIPEsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Proce_verbal_delibationPARTICIPEsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.PARTICIPE,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PARTICIPEsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Proce_verbal_delibationPARTICIPEsDetails.Edit(null), x => x.Proce_verbal_delibationPARTICIPEsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PARTICIPEsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PARTICIPEsPopUpMenu.ShowPopup(PARTICIPEsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Proce_verbal_delibationPARTICIPEsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PARTICIPEsGridControl, g => g.DataSource, x => x.Proce_verbal_delibationPARTICIPEsDetails.Entities);
				
														fluentAPI.BindCommand(bbiPARTICIPEsNew, x => x.Proce_verbal_delibationPARTICIPEsDetails.New());
																													fluentAPI.BindCommand(bbiPARTICIPEsEdit,x => x.Proce_verbal_delibationPARTICIPEsDetails.Edit(null), x=>x.Proce_verbal_delibationPARTICIPEsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPARTICIPEsDelete,x => x.Proce_verbal_delibationPARTICIPEsDetails.Delete(null), x=>x.Proce_verbal_delibationPARTICIPEsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPARTICIPEsRefresh, x => x.Proce_verbal_delibationPARTICIPEsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
