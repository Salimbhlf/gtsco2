using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.SectionView{
    public partial class SectionView : XtraUserControl {
        public SectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.SectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                sectionViewBindingSource, x => x.Entity, x => x.Update());
				#region Stagiairs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StagiairsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SectionStagiairsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Stagiair,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(StagiairsGridView, "RowClick")
						 .EventToCommand(
						     x => x.SectionStagiairsDetails.Edit(null), x => x.SectionStagiairsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			StagiairsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    StagiairsPopUpMenu.ShowPopup(StagiairsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SectionStagiairsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(StagiairsGridControl, g => g.DataSource, x => x.SectionStagiairsDetails.Entities);
				
														fluentAPI.BindCommand(bbiStagiairsNew, x => x.SectionStagiairsDetails.New());
																													fluentAPI.BindCommand(bbiStagiairsEdit,x => x.SectionStagiairsDetails.Edit(null), x=>x.SectionStagiairsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStagiairsDelete,x => x.SectionStagiairsDetails.Delete(null), x=>x.SectionStagiairsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStagiairsRefresh, x => x.SectionStagiairsDetails.Refresh());
																	#endregion
									// Binding for Mode_formation LookUp editor
			fluentAPI.SetBinding(Mode_formationLookUpEdit.Properties, p => p.DataSource, x => x.LookUpMode_formation.Entities);
						// Binding for Option LookUp editor
			fluentAPI.SetBinding(OptionLookUpEdit.Properties, p => p.DataSource, x => x.LookUpOptions.Entities);
						// Binding for Promo LookUp editor
			fluentAPI.SetBinding(PromoLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPromoes.Entities);
						// Binding for Semestre LookUp editor
			fluentAPI.SetBinding(SemestreLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSemestres.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
