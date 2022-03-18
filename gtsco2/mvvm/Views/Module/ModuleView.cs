using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.ModuleView{
    public partial class ModuleView : XtraUserControl {
        public ModuleView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.ModuleViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                moduleViewBindingSource, x => x.Entity, x => x.Update());
				#region Evaluations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EvaluationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ModuleEvaluationsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Evaluation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EvaluationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ModuleEvaluationsDetails.Edit(null), x => x.ModuleEvaluationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EvaluationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EvaluationsPopUpMenu.ShowPopup(EvaluationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ModuleEvaluationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EvaluationsGridControl, g => g.DataSource, x => x.ModuleEvaluationsDetails.Entities);
				
														fluentAPI.BindCommand(bbiEvaluationsNew, x => x.ModuleEvaluationsDetails.New());
																													fluentAPI.BindCommand(bbiEvaluationsEdit,x => x.ModuleEvaluationsDetails.Edit(null), x=>x.ModuleEvaluationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEvaluationsDelete,x => x.ModuleEvaluationsDetails.Delete(null), x=>x.ModuleEvaluationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEvaluationsRefresh, x => x.ModuleEvaluationsDetails.Refresh());
																	#endregion
									// Binding for Option LookUp editor
			fluentAPI.SetBinding(OptionLookUpEdit.Properties, p => p.DataSource, x => x.LookUpOptions.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
