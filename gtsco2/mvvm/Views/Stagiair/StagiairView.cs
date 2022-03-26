using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace gtsco2.mvvm.Views.StagiairView{
    public partial class StagiairView : XtraForm {
        public StagiairView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.StagiairViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                stagiairViewBindingSource, x => x.Entity, x => x.Update());
				#region Absences Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(AbsencesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StagiairAbsencesDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Absence,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(AbsencesGridView, "RowClick")
						 .EventToCommand(
						     x => x.StagiairAbsencesDetails.Edit(null), x => x.StagiairAbsencesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			AbsencesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    AbsencesPopUpMenu.ShowPopup(AbsencesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StagiairAbsencesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(AbsencesGridControl, g => g.DataSource, x => x.StagiairAbsencesDetails.Entities);
				
														fluentAPI.BindCommand(bbiAbsencesNew, x => x.StagiairAbsencesDetails.New());
																													fluentAPI.BindCommand(bbiAbsencesEdit,x => x.StagiairAbsencesDetails.Edit(null), x=>x.StagiairAbsencesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiAbsencesDelete,x => x.StagiairAbsencesDetails.Delete(null), x=>x.StagiairAbsencesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiAbsencesRefresh, x => x.StagiairAbsencesDetails.Refresh());
																	#endregion
						#region Evaluations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(EvaluationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StagiairEvaluationsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Evaluation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(EvaluationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.StagiairEvaluationsDetails.Edit(null), x => x.StagiairEvaluationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			EvaluationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    EvaluationsPopUpMenu.ShowPopup(EvaluationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StagiairEvaluationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(EvaluationsGridControl, g => g.DataSource, x => x.StagiairEvaluationsDetails.Entities);
				
														fluentAPI.BindCommand(bbiEvaluationsNew, x => x.StagiairEvaluationsDetails.New());
																													fluentAPI.BindCommand(bbiEvaluationsEdit,x => x.StagiairEvaluationsDetails.Edit(null), x=>x.StagiairEvaluationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiEvaluationsDelete,x => x.StagiairEvaluationsDetails.Delete(null), x=>x.StagiairEvaluationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiEvaluationsRefresh, x => x.StagiairEvaluationsDetails.Refresh());
																	#endregion
						#region Decisions Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(DecisionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StagiairDecisionsDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Decision,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(DecisionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.StagiairDecisionsDetails.Edit(null), x => x.StagiairDecisionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			DecisionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    DecisionsPopUpMenu.ShowPopup(DecisionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StagiairDecisionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(DecisionsGridControl, g => g.DataSource, x => x.StagiairDecisionsDetails.Entities);
				
														fluentAPI.BindCommand(bbiDecisionsNew, x => x.StagiairDecisionsDetails.New());
																													fluentAPI.BindCommand(bbiDecisionsEdit,x => x.StagiairDecisionsDetails.Edit(null), x=>x.StagiairDecisionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiDecisionsDelete,x => x.StagiairDecisionsDetails.Delete(null), x=>x.StagiairDecisionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiDecisionsRefresh, x => x.StagiairDecisionsDetails.Refresh());
																	#endregion
						#region Avenant_contrat_prorogation Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Avenant_contrat_prorogationGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StagiairAvenant_contrat_prorogationDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Avenant_contrat_prorogation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Avenant_contrat_prorogationGridView, "RowClick")
						 .EventToCommand(
						     x => x.StagiairAvenant_contrat_prorogationDetails.Edit(null), x => x.StagiairAvenant_contrat_prorogationDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Avenant_contrat_prorogationGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Avenant_contrat_prorogationPopUpMenu.ShowPopup(Avenant_contrat_prorogationGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StagiairAvenant_contrat_prorogationDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Avenant_contrat_prorogationGridControl, g => g.DataSource, x => x.StagiairAvenant_contrat_prorogationDetails.Entities);
				
														fluentAPI.BindCommand(bbiAvenant_contrat_prorogationNew, x => x.StagiairAvenant_contrat_prorogationDetails.New());
																													fluentAPI.BindCommand(bbiAvenant_contrat_prorogationEdit,x => x.StagiairAvenant_contrat_prorogationDetails.Edit(null), x=>x.StagiairAvenant_contrat_prorogationDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiAvenant_contrat_prorogationDelete,x => x.StagiairAvenant_contrat_prorogationDetails.Delete(null), x=>x.StagiairAvenant_contrat_prorogationDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiAvenant_contrat_prorogationRefresh, x => x.StagiairAvenant_contrat_prorogationDetails.Refresh());
																	#endregion
						#region Transferers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(TransferersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StagiairTransferersDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Transferer,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(TransferersGridView, "RowClick")
						 .EventToCommand(
						     x => x.StagiairTransferersDetails.Edit(null), x => x.StagiairTransferersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			TransferersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    TransferersPopUpMenu.ShowPopup(TransferersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StagiairTransferersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(TransferersGridControl, g => g.DataSource, x => x.StagiairTransferersDetails.Entities);
				
														fluentAPI.BindCommand(bbiTransferersNew, x => x.StagiairTransferersDetails.New());
																													fluentAPI.BindCommand(bbiTransferersEdit,x => x.StagiairTransferersDetails.Edit(null), x=>x.StagiairTransferersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiTransferersDelete,x => x.StagiairTransferersDetails.Delete(null), x=>x.StagiairTransferersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiTransferersRefresh, x => x.StagiairTransferersDetails.Refresh());
																	#endregion
						#region Contract_avenant_changement Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Contract_avenant_changementGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StagiairContract_avenant_changementDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Contract_avenant_changement,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Contract_avenant_changementGridView, "RowClick")
						 .EventToCommand(
						     x => x.StagiairContract_avenant_changementDetails.Edit(null), x => x.StagiairContract_avenant_changementDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Contract_avenant_changementGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Contract_avenant_changementPopUpMenu.ShowPopup(Contract_avenant_changementGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StagiairContract_avenant_changementDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Contract_avenant_changementGridControl, g => g.DataSource, x => x.StagiairContract_avenant_changementDetails.Entities);
				
														fluentAPI.BindCommand(bbiContract_avenant_changementNew, x => x.StagiairContract_avenant_changementDetails.New());
																													fluentAPI.BindCommand(bbiContract_avenant_changementEdit,x => x.StagiairContract_avenant_changementDetails.Edit(null), x=>x.StagiairContract_avenant_changementDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiContract_avenant_changementDelete,x => x.StagiairContract_avenant_changementDetails.Delete(null), x=>x.StagiairContract_avenant_changementDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiContract_avenant_changementRefresh, x => x.StagiairContract_avenant_changementDetails.Refresh());
																	#endregion
						#region Suiver_stagiaire Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Suiver_stagiaireGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StagiairSuiver_stagiaireDetails.SelectedEntity,
                    args => args.Row as gtsco2.basededonne.Suiver_stagiaire,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Suiver_stagiaireGridView, "RowClick")
						 .EventToCommand(
						     x => x.StagiairSuiver_stagiaireDetails.Edit(null), x => x.StagiairSuiver_stagiaireDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Suiver_stagiaireGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Suiver_stagiairePopUpMenu.ShowPopup(Suiver_stagiaireGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the StagiairSuiver_stagiaireDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Suiver_stagiaireGridControl, g => g.DataSource, x => x.StagiairSuiver_stagiaireDetails.Entities);
				
														fluentAPI.BindCommand(bbiSuiver_stagiaireNew, x => x.StagiairSuiver_stagiaireDetails.New());
																													fluentAPI.BindCommand(bbiSuiver_stagiaireEdit,x => x.StagiairSuiver_stagiaireDetails.Edit(null), x=>x.StagiairSuiver_stagiaireDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSuiver_stagiaireDelete,x => x.StagiairSuiver_stagiaireDetails.Delete(null), x=>x.StagiairSuiver_stagiaireDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSuiver_stagiaireRefresh, x => x.StagiairSuiver_stagiaireDetails.Refresh());
																	#endregion
									// Binding for Code_Postal1 LookUp editor
			fluentAPI.SetBinding(Code_Postal1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpCode_Postal.Entities);
						// Binding for Commune LookUp editor
			fluentAPI.SetBinding(CommuneLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCommunes.Entities);
						// Binding for Employeur LookUp editor
			fluentAPI.SetBinding(EmployeurLookUpEdit.Properties, p => p.DataSource, x => x.LookUpEmployeurs.Entities);
						// Binding for Etablissement LookUp editor
			fluentAPI.SetBinding(EtablissementLookUpEdit.Properties, p => p.DataSource, x => x.LookUpEtablissements.Entities);
						// Binding for Maitre_Apprentissage LookUp editor
			fluentAPI.SetBinding(Maitre_ApprentissageLookUpEdit.Properties, p => p.DataSource, x => x.LookUpMaitre_Apprentissage.Entities);
						// Binding for Promo LookUp editor
			fluentAPI.SetBinding(PromoLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPromoes.Entities);
						// Binding for Section1 LookUp editor
			fluentAPI.SetBinding(Section1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpSections.Entities);
						// Binding for tuteur LookUp editor
			fluentAPI.SetBinding(tuteurLookUpEdit.Properties, p => p.DataSource, x => x.LookUptuteurs.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			forms.Formulaire.certficat.ReportCertficat.printCertficat(Num_STGTextEdit.Text);
			
		}
    }
}
