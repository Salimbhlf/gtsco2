using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;

namespace gtsco2.mvvm.Views.gtscoView{
    public partial class gtscoView : XtraUserControl {
        public gtscoView() {
            InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            ribbonControl.Merge += ribbonControl_Merge;
            ribbonControl.UnMerge += ribbonControl_UnMerge;
        }

        private void ribbonControl_UnMerge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergeOwner.SelectedPage;
            ribbonControl.StatusBar.UnMergeStatusBar();
        }

        void ribbonControl_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
            ribbonControl.StatusBar.MergeStatusBar(e.MergedChild.StatusBar);
        }
        void InitializeNavigation() {
            // We want the DocumentManager's TabbedView to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView));
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<gtsco2.mvvm.ViewModels.gtscoViewModel>();
			            fluentAPI.BindCommand(accordionItemAbsenceCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			            fluentAPI.BindCommand(accordionItemannee_scolaireCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			            fluentAPI.BindCommand(accordionItemEvaluationCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			            fluentAPI.BindCommand(accordionItemEnseignantCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			            fluentAPI.BindCommand(accordionItemMode_formationCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			            fluentAPI.BindCommand(accordionItemPromoCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			            fluentAPI.BindCommand(accordionItemDecisionCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			            fluentAPI.BindCommand(accordionItemProce_verbal_delibationCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			            fluentAPI.BindCommand(accordionItemPARTICIPECollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			            fluentAPI.BindCommand(accordionItemSemestreCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			            fluentAPI.BindCommand(accordionItemSectionCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
			            fluentAPI.BindCommand(accordionItemOptionCollectionView, (x, m) => x.Show(m), x => x.Modules[11]);
			            fluentAPI.BindCommand(accordionItemModuleCollectionView, (x, m) => x.Show(m), x => x.Modules[12]);
			            fluentAPI.BindCommand(accordionItemSpecialiteCollectionView, (x, m) => x.Show(m), x => x.Modules[13]);
			            fluentAPI.BindCommand(accordionItemBranchCollectionView, (x, m) => x.Show(m), x => x.Modules[14]);
			            fluentAPI.BindCommand(accordionItemStagiairCollectionView, (x, m) => x.Show(m), x => x.Modules[15]);
			            fluentAPI.BindCommand(accordionItemAvenant_contrat_prorogationCollectionView, (x, m) => x.Show(m), x => x.Modules[16]);
			            fluentAPI.BindCommand(accordionItemEmployeurCollectionView, (x, m) => x.Show(m), x => x.Modules[17]);
			            fluentAPI.BindCommand(accordionItemCode_PostalCollectionView, (x, m) => x.Show(m), x => x.Modules[18]);
			            fluentAPI.BindCommand(accordionItemCommuneCollectionView, (x, m) => x.Show(m), x => x.Modules[19]);
			            fluentAPI.BindCommand(accordionItemMaitre_ApprentissageCollectionView, (x, m) => x.Show(m), x => x.Modules[20]);
			            fluentAPI.BindCommand(accordionItemWillayaCollectionView, (x, m) => x.Show(m), x => x.Modules[21]);
			            fluentAPI.BindCommand(accordionItemEtablissementCollectionView, (x, m) => x.Show(m), x => x.Modules[22]);
			            fluentAPI.BindCommand(accordionItemTransfererCollectionView, (x, m) => x.Show(m), x => x.Modules[23]);
			            fluentAPI.BindCommand(accordionItemContract_avenant_changementCollectionView, (x, m) => x.Show(m), x => x.Modules[24]);
			            fluentAPI.BindCommand(accordionItemSuiver_stagiaireCollectionView, (x, m) => x.Show(m), x => x.Modules[25]);
			            fluentAPI.BindCommand(accordionItemtuteurCollectionView, (x, m) => x.Show(m), x => x.Modules[26]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
        }
    }
}
