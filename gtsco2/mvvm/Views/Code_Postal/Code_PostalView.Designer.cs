namespace gtsco2.mvvm.Views.Code_PostalView {
    partial class Code_PostalView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
						this.StagiairsGridControl = new DevExpress.XtraGrid.GridControl();
			this.StagiairsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.StagiairsBarManager = new DevExpress.XtraBars.BarManager();
			this.StagiairsBar = new DevExpress.XtraBars.Bar();
			this.StagiairsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.StagiairsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiStagiairsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStagiairsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStagiairsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStagiairsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.StagiairsBarManager)).BeginInit();
						this.EmployeursGridControl = new DevExpress.XtraGrid.GridControl();
			this.EmployeursGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.EmployeursBarManager = new DevExpress.XtraBars.BarManager();
			this.EmployeursBar = new DevExpress.XtraBars.Bar();
			this.EmployeursXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.EmployeursPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiEmployeursNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEmployeursEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEmployeursDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEmployeursRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.EmployeursBarManager)).BeginInit();
						this.EtablissementsGridControl = new DevExpress.XtraGrid.GridControl();
			this.EtablissementsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.EtablissementsBarManager = new DevExpress.XtraBars.BarManager();
			this.EtablissementsBar = new DevExpress.XtraBars.Bar();
			this.EtablissementsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.EtablissementsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiEtablissementsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEtablissementsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEtablissementsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEtablissementsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.EtablissementsBarManager)).BeginInit();
									this.CommuneLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.CommuneBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
			this.SuspendLayout();
			// 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
			this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.bbiCustomize});
            this.mainRibbonControl.Name = "mainRibbonControl";
			this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
						DevExpress.XtraBars.BarButtonItem bbiSave = new DevExpress.XtraBars.BarButtonItem();
			bbiSave.Caption = "Save";
			bbiSave.Name = "bbiSave";
			bbiSave.ImageUri.Uri = "Save";
			this.mainRibbonControl.Items.Add(bbiSave);
						DevExpress.XtraBars.BarButtonItem bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveAndClose.Caption = "Save And Close";
			bbiSaveAndClose.Name = "bbiSaveAndClose";
			bbiSaveAndClose.ImageUri.Uri = "SaveAndClose";
			this.mainRibbonControl.Items.Add(bbiSaveAndClose);
						DevExpress.XtraBars.BarButtonItem bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveAndNew.Caption = "Save And New";
			bbiSaveAndNew.Name = "bbiSaveAndNew";
			bbiSaveAndNew.ImageUri.Uri = "SaveAndNew";
			this.mainRibbonControl.Items.Add(bbiSaveAndNew);
						DevExpress.XtraBars.BarButtonItem bbiReset = new DevExpress.XtraBars.BarButtonItem();
			bbiReset.Caption = "Reset Changes";
			bbiReset.Name = "bbiReset";
			bbiReset.ImageUri.Uri = "Reset";
			this.mainRibbonControl.Items.Add(bbiReset);
						DevExpress.XtraBars.BarButtonItem bbiDelete = new DevExpress.XtraBars.BarButtonItem();
			bbiDelete.Caption = "Delete";
			bbiDelete.Name = "bbiDelete";
			bbiDelete.ImageUri.Uri = "Delete";
			this.mainRibbonControl.Items.Add(bbiDelete);
						DevExpress.XtraBars.BarButtonItem bbiClose = new DevExpress.XtraBars.BarButtonItem();
			bbiClose.Caption = "Close";
			bbiClose.Name = "bbiClose";
			bbiClose.ImageUri.Uri = "Close";
			this.mainRibbonControl.Items.Add(bbiClose);
						DevExpress.XtraBars.BarButtonItem bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveLayout.Caption = "Save Layout";
			bbiSaveLayout.Name = "bbiSaveLayout";
			bbiSaveLayout.ImageUri.Uri = "Save";
			this.mainRibbonControl.Items.Add(bbiSaveLayout);
						DevExpress.XtraBars.BarButtonItem bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
			bbiResetLayout.Caption = "Reset Layout";
			bbiResetLayout.Name = "bbiResetLayout";
			bbiResetLayout.ImageUri.Uri = "Reset";
			this.mainRibbonControl.Items.Add(bbiResetLayout);
			            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroupLayout});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
			this.mainRibbonPage.MergeOrder = 0;
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSave);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSaveAndClose);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSaveAndNew);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiReset);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiDelete);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiClose);
			            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Code_Postal Tasks";
			// 
            // ribbonPageGroupLayout
            //
			this.ribbonPageGroupLayout.AllowTextClipping = false; 
			this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
						this.ribbonPageGroupLayout.ItemLinks.Add(bbiSaveLayout);
						this.ribbonPageGroupLayout.ItemLinks.Add(bbiResetLayout);
			            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Layout";
			// 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.ImageUri.Uri = "Customization";
            this.bbiCustomize.Name = "bbiCustomize";
			// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.code_PostalViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.code_PostalViewBindingSource.DataSource = typeof(gtsco2.basededonne.Code_Postal);
			this.dataLayoutControl1.DataSource = code_PostalViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//StagiairsGridControl
			//
			this.StagiairsGridControl.MainView = this.StagiairsGridView;
			this.StagiairsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StagiairsGridControl.MenuManager = this.mainRibbonControl;
            this.StagiairsGridControl.Name = "StagiairsGridControl";
            this.StagiairsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StagiairsGridView});
			//
			//StagiairsGridView
			//
            this.StagiairsGridView.GridControl = this.StagiairsGridControl;
            this.StagiairsGridView.Name = "StagiairsGridView";
            this.StagiairsGridView.OptionsBehavior.Editable = false;
            this.StagiairsGridView.OptionsBehavior.ReadOnly = true;
			//
			//StagiairsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters StagiairsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters AbsencesStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            AbsencesStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Absences";
		    AbsencesStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(AbsencesStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Avenant_contrat_prorogation";
		    Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_Postal1StagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_Postal1StagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Code_Postal1";
		    Code_Postal1StagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Code_Postal1StagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommuneStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommuneStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Commune";
		    CommuneStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(CommuneStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Contract_avenant_changementStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Contract_avenant_changementStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Contract_avenant_changement";
		    Contract_avenant_changementStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Contract_avenant_changementStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DecisionsStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DecisionsStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Decisions";
		    DecisionsStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(DecisionsStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeurStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeurStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Employeur";
		    EmployeurStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(EmployeurStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EtablissementStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EtablissementStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Etablissement";
		    EtablissementStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(EtablissementStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EvaluationsStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EvaluationsStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Evaluations";
		    EvaluationsStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(EvaluationsStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Maitre_Apprentissage";
		    Maitre_ApprentissageStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Promo";
		    PromoStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(PromoStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Section1StagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Section1StagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Section1";
		    Section1StagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Section1StagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters tuteurStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            tuteurStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "tuteur";
		    tuteurStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(tuteurStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Suiver_stagiaireStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Suiver_stagiaireStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Suiver_stagiaire";
		    Suiver_stagiaireStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Suiver_stagiaireStagiairsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TransferersStagiairsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TransferersStagiairsChildPopulateColumnParameters_NotVisible.FieldName = "Transferers";
		    TransferersStagiairsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(TransferersStagiairsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsStagiairsChildPopulateColumnParameters.FieldName = "StagiairsStagiairs";
            StagiairsStagiairsChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeursStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeursStagiairsChildPopulateColumnParameters.FieldName = "EmployeursStagiairs";
            EmployeursStagiairsChildPopulateColumnParameters.Path = "Employeurs.Type_Emp";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(EmployeursStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommuneStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommuneStagiairsChildPopulateColumnParameters.FieldName = "CommuneStagiairs";
            CommuneStagiairsChildPopulateColumnParameters.Path = "Commune.Commune_name";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(CommuneStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EtablissementsStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EtablissementsStagiairsChildPopulateColumnParameters.FieldName = "EtablissementsStagiairs";
            EtablissementsStagiairsChildPopulateColumnParameters.Path = "Etablissements.Nom_ETAB";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(EtablissementsStagiairsChildPopulateColumnParameters);
			 
		    this.StagiairsGridView.PopulateColumns(typeof(gtsco2.basededonne.Stagiair),StagiairsPopulateColumnsParameters);
			//
			//StagiairsBindingSource
			//
			System.Windows.Forms.BindingSource StagiairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			StagiairsBindingSource.DataSource = typeof(gtsco2.basededonne.Stagiair);
            this.StagiairsGridControl.DataSource = StagiairsBindingSource;
			//
			//StagiairsXtraUserControl
			//
            this.StagiairsXtraUserControl.Controls.Add(StagiairsGridControl);
			this.StagiairsXtraUserControl.Name = "StagiairsXtraUserControl";
			this.StagiairsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//StagiairsNew
			//
			this.bbiStagiairsNew.Caption = "New";
			this.bbiStagiairsNew.Name = "bbiStagiairsNew";
			this.bbiStagiairsNew.ImageUri.Uri = "New";
			this.bbiStagiairsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StagiairsBarManager.Items.Add(this.bbiStagiairsNew);
			this.StagiairsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsNew));
			this.StagiairsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsNew));
						//
			//StagiairsEdit
			//
			this.bbiStagiairsEdit.Caption = "Edit";
			this.bbiStagiairsEdit.Name = "bbiStagiairsEdit";
			this.bbiStagiairsEdit.ImageUri.Uri = "Edit";
			this.bbiStagiairsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StagiairsBarManager.Items.Add(this.bbiStagiairsEdit);
			this.StagiairsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsEdit));
			this.StagiairsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsEdit));
						//
			//StagiairsDelete
			//
			this.bbiStagiairsDelete.Caption = "Delete";
			this.bbiStagiairsDelete.Name = "bbiStagiairsDelete";
			this.bbiStagiairsDelete.ImageUri.Uri = "Delete";
			this.bbiStagiairsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StagiairsBarManager.Items.Add(this.bbiStagiairsDelete);
			this.StagiairsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsDelete));
			this.StagiairsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsDelete));
						//
			//StagiairsRefresh
			//
			this.bbiStagiairsRefresh.Caption = "Refresh";
			this.bbiStagiairsRefresh.Name = "bbiStagiairsRefresh";
			this.bbiStagiairsRefresh.ImageUri.Uri = "Refresh";
			this.bbiStagiairsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.StagiairsBarManager.Items.Add(this.bbiStagiairsRefresh);
			this.StagiairsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsRefresh));
			this.StagiairsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStagiairsRefresh));
						//
			//StagiairsBar
			//
			this.StagiairsBar.BarName = "Stagiairs";
            this.StagiairsBar.DockCol = 0;
            this.StagiairsBar.DockRow = 0;
            this.StagiairsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.StagiairsBar.OptionsBar.AllowQuickCustomization = false;
            this.StagiairsBar.OptionsBar.DrawDragBorder = false;
            this.StagiairsBar.Text = "Stagiairs";
			//
			//StagiairsBarManager
			//
			this.StagiairsBarManager.AllowCustomization = false;
            this.StagiairsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.StagiairsBar});
            this.StagiairsBarManager.Form = StagiairsXtraUserControl;
            this.StagiairsBarManager.MainMenu = this.StagiairsBar;
			// 
            // StagiairsPopUpMenu
            // 
            this.StagiairsPopUpMenu.Manager = this.StagiairsBarManager;
            this.StagiairsPopUpMenu.Name = "StagiairsPopUpMenu";
			//
			//StagiairsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters StagiairsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            StagiairsRetriveFieldParameters.FieldName = "Stagiairs";
            StagiairsRetriveFieldParameters.ControlForField = StagiairsXtraUserControl;
			StagiairsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(StagiairsRetriveFieldParameters);
						//
			//EmployeursGridControl
			//
			this.EmployeursGridControl.MainView = this.EmployeursGridView;
			this.EmployeursGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeursGridControl.MenuManager = this.mainRibbonControl;
            this.EmployeursGridControl.Name = "EmployeursGridControl";
            this.EmployeursGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EmployeursGridView});
			//
			//EmployeursGridView
			//
            this.EmployeursGridView.GridControl = this.EmployeursGridControl;
            this.EmployeursGridView.Name = "EmployeursGridView";
            this.EmployeursGridView.OptionsBehavior.Editable = false;
            this.EmployeursGridView.OptionsBehavior.ReadOnly = true;
			//
			//EmployeursPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters EmployeursPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Avenant_contrat_prorogationEmployeursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Avenant_contrat_prorogationEmployeursChildPopulateColumnParameters_NotVisible.FieldName = "Avenant_contrat_prorogation";
		    Avenant_contrat_prorogationEmployeursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(Avenant_contrat_prorogationEmployeursChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalEmployeursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalEmployeursChildPopulateColumnParameters_NotVisible.FieldName = "Code_Postal";
		    Code_PostalEmployeursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalEmployeursChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Contract_avenant_changementEmployeursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Contract_avenant_changementEmployeursChildPopulateColumnParameters_NotVisible.FieldName = "Contract_avenant_changement";
		    Contract_avenant_changementEmployeursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(Contract_avenant_changementEmployeursChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageEmployeursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageEmployeursChildPopulateColumnParameters_NotVisible.FieldName = "Maitre_Apprentissage";
		    Maitre_ApprentissageEmployeursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageEmployeursChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsEmployeursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsEmployeursChildPopulateColumnParameters_NotVisible.FieldName = "Stagiairs";
		    StagiairsEmployeursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsEmployeursChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsEmployeursChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsEmployeursChildPopulateColumnParameters.FieldName = "StagiairsEmployeurs";
            StagiairsEmployeursChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsEmployeursChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeursEmployeursChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeursEmployeursChildPopulateColumnParameters.FieldName = "EmployeursEmployeurs";
            EmployeursEmployeursChildPopulateColumnParameters.Path = "Employeurs.Type_Emp";
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(EmployeursEmployeursChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommuneEmployeursChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommuneEmployeursChildPopulateColumnParameters.FieldName = "CommuneEmployeurs";
            CommuneEmployeursChildPopulateColumnParameters.Path = "Commune.Commune_name";
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(CommuneEmployeursChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EtablissementsEmployeursChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EtablissementsEmployeursChildPopulateColumnParameters.FieldName = "EtablissementsEmployeurs";
            EtablissementsEmployeursChildPopulateColumnParameters.Path = "Etablissements.Nom_ETAB";
			EmployeursPopulateColumnsParameters.CustomColumnParameters.Add(EtablissementsEmployeursChildPopulateColumnParameters);
			 
		    this.EmployeursGridView.PopulateColumns(typeof(gtsco2.basededonne.Employeur),EmployeursPopulateColumnsParameters);
			//
			//EmployeursBindingSource
			//
			System.Windows.Forms.BindingSource EmployeursBindingSource = new System.Windows.Forms.BindingSource(this.components);
			EmployeursBindingSource.DataSource = typeof(gtsco2.basededonne.Employeur);
            this.EmployeursGridControl.DataSource = EmployeursBindingSource;
			//
			//EmployeursXtraUserControl
			//
            this.EmployeursXtraUserControl.Controls.Add(EmployeursGridControl);
			this.EmployeursXtraUserControl.Name = "EmployeursXtraUserControl";
			this.EmployeursXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//EmployeursNew
			//
			this.bbiEmployeursNew.Caption = "New";
			this.bbiEmployeursNew.Name = "bbiEmployeursNew";
			this.bbiEmployeursNew.ImageUri.Uri = "New";
			this.bbiEmployeursNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EmployeursBarManager.Items.Add(this.bbiEmployeursNew);
			this.EmployeursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursNew));
			this.EmployeursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursNew));
						//
			//EmployeursEdit
			//
			this.bbiEmployeursEdit.Caption = "Edit";
			this.bbiEmployeursEdit.Name = "bbiEmployeursEdit";
			this.bbiEmployeursEdit.ImageUri.Uri = "Edit";
			this.bbiEmployeursEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EmployeursBarManager.Items.Add(this.bbiEmployeursEdit);
			this.EmployeursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursEdit));
			this.EmployeursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursEdit));
						//
			//EmployeursDelete
			//
			this.bbiEmployeursDelete.Caption = "Delete";
			this.bbiEmployeursDelete.Name = "bbiEmployeursDelete";
			this.bbiEmployeursDelete.ImageUri.Uri = "Delete";
			this.bbiEmployeursDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EmployeursBarManager.Items.Add(this.bbiEmployeursDelete);
			this.EmployeursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursDelete));
			this.EmployeursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursDelete));
						//
			//EmployeursRefresh
			//
			this.bbiEmployeursRefresh.Caption = "Refresh";
			this.bbiEmployeursRefresh.Name = "bbiEmployeursRefresh";
			this.bbiEmployeursRefresh.ImageUri.Uri = "Refresh";
			this.bbiEmployeursRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EmployeursBarManager.Items.Add(this.bbiEmployeursRefresh);
			this.EmployeursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursRefresh));
			this.EmployeursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEmployeursRefresh));
						//
			//EmployeursBar
			//
			this.EmployeursBar.BarName = "Employeurs";
            this.EmployeursBar.DockCol = 0;
            this.EmployeursBar.DockRow = 0;
            this.EmployeursBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.EmployeursBar.OptionsBar.AllowQuickCustomization = false;
            this.EmployeursBar.OptionsBar.DrawDragBorder = false;
            this.EmployeursBar.Text = "Employeurs";
			//
			//EmployeursBarManager
			//
			this.EmployeursBarManager.AllowCustomization = false;
            this.EmployeursBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.EmployeursBar});
            this.EmployeursBarManager.Form = EmployeursXtraUserControl;
            this.EmployeursBarManager.MainMenu = this.EmployeursBar;
			// 
            // EmployeursPopUpMenu
            // 
            this.EmployeursPopUpMenu.Manager = this.EmployeursBarManager;
            this.EmployeursPopUpMenu.Name = "EmployeursPopUpMenu";
			//
			//EmployeursRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters EmployeursRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            EmployeursRetriveFieldParameters.FieldName = "Employeurs";
            EmployeursRetriveFieldParameters.ControlForField = EmployeursXtraUserControl;
			EmployeursRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(EmployeursRetriveFieldParameters);
						//
			//EtablissementsGridControl
			//
			this.EtablissementsGridControl.MainView = this.EtablissementsGridView;
			this.EtablissementsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EtablissementsGridControl.MenuManager = this.mainRibbonControl;
            this.EtablissementsGridControl.Name = "EtablissementsGridControl";
            this.EtablissementsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EtablissementsGridView});
			//
			//EtablissementsGridView
			//
            this.EtablissementsGridView.GridControl = this.EtablissementsGridControl;
            this.EtablissementsGridView.Name = "EtablissementsGridView";
            this.EtablissementsGridView.OptionsBehavior.Editable = false;
            this.EtablissementsGridView.OptionsBehavior.ReadOnly = true;
			//
			//EtablissementsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters EtablissementsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalEtablissementsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalEtablissementsChildPopulateColumnParameters_NotVisible.FieldName = "Code_Postal";
		    Code_PostalEtablissementsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EtablissementsPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalEtablissementsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsEtablissementsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsEtablissementsChildPopulateColumnParameters_NotVisible.FieldName = "Stagiairs";
		    StagiairsEtablissementsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EtablissementsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsEtablissementsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TransferersEtablissementsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TransferersEtablissementsChildPopulateColumnParameters_NotVisible.FieldName = "Transferers";
		    TransferersEtablissementsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EtablissementsPopulateColumnsParameters.CustomColumnParameters.Add(TransferersEtablissementsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsEtablissementsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsEtablissementsChildPopulateColumnParameters.FieldName = "StagiairsEtablissements";
            StagiairsEtablissementsChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			EtablissementsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsEtablissementsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeursEtablissementsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeursEtablissementsChildPopulateColumnParameters.FieldName = "EmployeursEtablissements";
            EmployeursEtablissementsChildPopulateColumnParameters.Path = "Employeurs.Type_Emp";
			EtablissementsPopulateColumnsParameters.CustomColumnParameters.Add(EmployeursEtablissementsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommuneEtablissementsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommuneEtablissementsChildPopulateColumnParameters.FieldName = "CommuneEtablissements";
            CommuneEtablissementsChildPopulateColumnParameters.Path = "Commune.Commune_name";
			EtablissementsPopulateColumnsParameters.CustomColumnParameters.Add(CommuneEtablissementsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EtablissementsEtablissementsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EtablissementsEtablissementsChildPopulateColumnParameters.FieldName = "EtablissementsEtablissements";
            EtablissementsEtablissementsChildPopulateColumnParameters.Path = "Etablissements.Nom_ETAB";
			EtablissementsPopulateColumnsParameters.CustomColumnParameters.Add(EtablissementsEtablissementsChildPopulateColumnParameters);
			 
		    this.EtablissementsGridView.PopulateColumns(typeof(gtsco2.basededonne.Etablissement),EtablissementsPopulateColumnsParameters);
			//
			//EtablissementsBindingSource
			//
			System.Windows.Forms.BindingSource EtablissementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			EtablissementsBindingSource.DataSource = typeof(gtsco2.basededonne.Etablissement);
            this.EtablissementsGridControl.DataSource = EtablissementsBindingSource;
			//
			//EtablissementsXtraUserControl
			//
            this.EtablissementsXtraUserControl.Controls.Add(EtablissementsGridControl);
			this.EtablissementsXtraUserControl.Name = "EtablissementsXtraUserControl";
			this.EtablissementsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//EtablissementsNew
			//
			this.bbiEtablissementsNew.Caption = "New";
			this.bbiEtablissementsNew.Name = "bbiEtablissementsNew";
			this.bbiEtablissementsNew.ImageUri.Uri = "New";
			this.bbiEtablissementsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EtablissementsBarManager.Items.Add(this.bbiEtablissementsNew);
			this.EtablissementsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsNew));
			this.EtablissementsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsNew));
						//
			//EtablissementsEdit
			//
			this.bbiEtablissementsEdit.Caption = "Edit";
			this.bbiEtablissementsEdit.Name = "bbiEtablissementsEdit";
			this.bbiEtablissementsEdit.ImageUri.Uri = "Edit";
			this.bbiEtablissementsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EtablissementsBarManager.Items.Add(this.bbiEtablissementsEdit);
			this.EtablissementsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsEdit));
			this.EtablissementsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsEdit));
						//
			//EtablissementsDelete
			//
			this.bbiEtablissementsDelete.Caption = "Delete";
			this.bbiEtablissementsDelete.Name = "bbiEtablissementsDelete";
			this.bbiEtablissementsDelete.ImageUri.Uri = "Delete";
			this.bbiEtablissementsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EtablissementsBarManager.Items.Add(this.bbiEtablissementsDelete);
			this.EtablissementsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsDelete));
			this.EtablissementsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsDelete));
						//
			//EtablissementsRefresh
			//
			this.bbiEtablissementsRefresh.Caption = "Refresh";
			this.bbiEtablissementsRefresh.Name = "bbiEtablissementsRefresh";
			this.bbiEtablissementsRefresh.ImageUri.Uri = "Refresh";
			this.bbiEtablissementsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EtablissementsBarManager.Items.Add(this.bbiEtablissementsRefresh);
			this.EtablissementsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsRefresh));
			this.EtablissementsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEtablissementsRefresh));
						//
			//EtablissementsBar
			//
			this.EtablissementsBar.BarName = "Etablissements";
            this.EtablissementsBar.DockCol = 0;
            this.EtablissementsBar.DockRow = 0;
            this.EtablissementsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.EtablissementsBar.OptionsBar.AllowQuickCustomization = false;
            this.EtablissementsBar.OptionsBar.DrawDragBorder = false;
            this.EtablissementsBar.Text = "Etablissements";
			//
			//EtablissementsBarManager
			//
			this.EtablissementsBarManager.AllowCustomization = false;
            this.EtablissementsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.EtablissementsBar});
            this.EtablissementsBarManager.Form = EtablissementsXtraUserControl;
            this.EtablissementsBarManager.MainMenu = this.EtablissementsBar;
			// 
            // EtablissementsPopUpMenu
            // 
            this.EtablissementsPopUpMenu.Manager = this.EtablissementsBarManager;
            this.EtablissementsPopUpMenu.Name = "EtablissementsPopUpMenu";
			//
			//EtablissementsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters EtablissementsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            EtablissementsRetriveFieldParameters.FieldName = "Etablissements";
            EtablissementsRetriveFieldParameters.ControlForField = EtablissementsXtraUserControl;
			EtablissementsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(EtablissementsRetriveFieldParameters);
									//
			//CommuneLookUpEdit
			//
			this.CommuneBindingSource.DataSource = typeof(gtsco2.basededonne.Commune);
			this.CommuneLookUpEdit.Properties.ValueMember = "Commune_id"; 
			this.CommuneLookUpEdit.Properties.DisplayMember = "Commune_name";
			this.CommuneLookUpEdit.Properties.DataSource = this.CommuneBindingSource;
			this.CommuneLookUpEdit.Name = "CommuneLookUpEdit";
			this.CommuneLookUpEdit.DataBindings.Add("EditValue", code_PostalViewBindingSource, "Commune_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CommuneLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CommuneLookUpEditRetrieveFieldParameters.FieldName = "Commune_id";
            CommuneLookUpEditRetrieveFieldParameters.ControlForField = this.CommuneLookUpEdit;
			parameters.CustomListParameters.Add(CommuneLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CommuneLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    CommuneLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Commune";
		    CommuneLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(CommuneLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Code_PostalViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//Code_PostalView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "Code_PostalView";
						((System.ComponentModel.ISupportInitialize)(this.StagiairsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.EmployeursBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.EtablissementsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
		private DevExpress.XtraBars.BarButtonItem bbiCustomize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLayout;
		private System.Windows.Forms.BindingSource code_PostalViewBindingSource;
				private DevExpress.XtraGrid.GridControl StagiairsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView StagiairsGridView;
		private DevExpress.XtraBars.BarManager StagiairsBarManager;
		private DevExpress.XtraBars.Bar StagiairsBar;
		private DevExpress.XtraEditors.XtraUserControl StagiairsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu StagiairsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiStagiairsNew;
				private DevExpress.XtraBars.BarButtonItem bbiStagiairsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiStagiairsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiStagiairsRefresh;
						private DevExpress.XtraGrid.GridControl EmployeursGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView EmployeursGridView;
		private DevExpress.XtraBars.BarManager EmployeursBarManager;
		private DevExpress.XtraBars.Bar EmployeursBar;
		private DevExpress.XtraEditors.XtraUserControl EmployeursXtraUserControl;
		private DevExpress.XtraBars.PopupMenu EmployeursPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiEmployeursNew;
				private DevExpress.XtraBars.BarButtonItem bbiEmployeursEdit;
				private DevExpress.XtraBars.BarButtonItem bbiEmployeursDelete;
				private DevExpress.XtraBars.BarButtonItem bbiEmployeursRefresh;
						private DevExpress.XtraGrid.GridControl EtablissementsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView EtablissementsGridView;
		private DevExpress.XtraBars.BarManager EtablissementsBarManager;
		private DevExpress.XtraBars.Bar EtablissementsBar;
		private DevExpress.XtraEditors.XtraUserControl EtablissementsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu EtablissementsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiEtablissementsNew;
				private DevExpress.XtraBars.BarButtonItem bbiEtablissementsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiEtablissementsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiEtablissementsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit CommuneLookUpEdit;
		private System.Windows.Forms.BindingSource CommuneBindingSource;
		 
	}
}
