namespace gtsco2.mvvm.Views.EmployeurView {
    partial class EmployeurView {
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
						this.Avenant_contrat_prorogationGridControl = new DevExpress.XtraGrid.GridControl();
			this.Avenant_contrat_prorogationGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Avenant_contrat_prorogationBarManager = new DevExpress.XtraBars.BarManager();
			this.Avenant_contrat_prorogationBar = new DevExpress.XtraBars.Bar();
			this.Avenant_contrat_prorogationXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Avenant_contrat_prorogationPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiAvenant_contrat_prorogationNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiAvenant_contrat_prorogationEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiAvenant_contrat_prorogationDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiAvenant_contrat_prorogationRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Avenant_contrat_prorogationBarManager)).BeginInit();
						this.Maitre_ApprentissageGridControl = new DevExpress.XtraGrid.GridControl();
			this.Maitre_ApprentissageGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Maitre_ApprentissageBarManager = new DevExpress.XtraBars.BarManager();
			this.Maitre_ApprentissageBar = new DevExpress.XtraBars.Bar();
			this.Maitre_ApprentissageXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Maitre_ApprentissagePopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiMaitre_ApprentissageNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiMaitre_ApprentissageEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiMaitre_ApprentissageDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiMaitre_ApprentissageRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Maitre_ApprentissageBarManager)).BeginInit();
						this.Contract_avenant_changementGridControl = new DevExpress.XtraGrid.GridControl();
			this.Contract_avenant_changementGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Contract_avenant_changementBarManager = new DevExpress.XtraBars.BarManager();
			this.Contract_avenant_changementBar = new DevExpress.XtraBars.Bar();
			this.Contract_avenant_changementXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Contract_avenant_changementPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiContract_avenant_changementNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiContract_avenant_changementEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiContract_avenant_changementDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiContract_avenant_changementRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Contract_avenant_changementBarManager)).BeginInit();
									this.Code_PostalLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.Code_PostalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Employeur Tasks";
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
			this.employeurViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeurViewBindingSource.DataSource = typeof(gtsco2.basededonne.Employeur);
			this.dataLayoutControl1.DataSource = employeurViewBindingSource;
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters.FieldName = "Avenant_contrat_prorogationStagiairs";
            Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters.Path = "Avenant_contrat_prorogation.Num_stg";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Avenant_contrat_prorogationStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalStagiairsChildPopulateColumnParameters.FieldName = "Code_PostalStagiairs";
            Code_PostalStagiairsChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageStagiairsChildPopulateColumnParameters.FieldName = "Maitre_ApprentissageStagiairs";
            Maitre_ApprentissageStagiairsChildPopulateColumnParameters.Path = "Maitre_Apprentissage.Nom_Maitre_Apprentissage";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Contract_avenant_changementStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Contract_avenant_changementStagiairsChildPopulateColumnParameters.FieldName = "Contract_avenant_changementStagiairs";
            Contract_avenant_changementStagiairsChildPopulateColumnParameters.Path = "Contract_avenant_changement.num_stg";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Contract_avenant_changementStagiairsChildPopulateColumnParameters);
			 
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
			//Avenant_contrat_prorogationGridControl
			//
			this.Avenant_contrat_prorogationGridControl.MainView = this.Avenant_contrat_prorogationGridView;
			this.Avenant_contrat_prorogationGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avenant_contrat_prorogationGridControl.MenuManager = this.mainRibbonControl;
            this.Avenant_contrat_prorogationGridControl.Name = "Avenant_contrat_prorogationGridControl";
            this.Avenant_contrat_prorogationGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Avenant_contrat_prorogationGridView});
			//
			//Avenant_contrat_prorogationGridView
			//
            this.Avenant_contrat_prorogationGridView.GridControl = this.Avenant_contrat_prorogationGridControl;
            this.Avenant_contrat_prorogationGridView.Name = "Avenant_contrat_prorogationGridView";
            this.Avenant_contrat_prorogationGridView.OptionsBehavior.Editable = false;
            this.Avenant_contrat_prorogationGridView.OptionsBehavior.ReadOnly = true;
			//
			//Avenant_contrat_prorogationPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Avenant_contrat_prorogationPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeurAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeurAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible.FieldName = "Employeur";
		    EmployeurAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Avenant_contrat_prorogationPopulateColumnsParameters.CustomColumnParameters.Add(EmployeurAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible.FieldName = "Stagiair";
		    StagiairAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Avenant_contrat_prorogationPopulateColumnsParameters.CustomColumnParameters.Add(StagiairAvenant_contrat_prorogationChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsAvenant_contrat_prorogationChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsAvenant_contrat_prorogationChildPopulateColumnParameters.FieldName = "StagiairsAvenant_contrat_prorogation";
            StagiairsAvenant_contrat_prorogationChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			Avenant_contrat_prorogationPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsAvenant_contrat_prorogationChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Avenant_contrat_prorogationAvenant_contrat_prorogationChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Avenant_contrat_prorogationAvenant_contrat_prorogationChildPopulateColumnParameters.FieldName = "Avenant_contrat_prorogationAvenant_contrat_prorogation";
            Avenant_contrat_prorogationAvenant_contrat_prorogationChildPopulateColumnParameters.Path = "Avenant_contrat_prorogation.Num_stg";
			Avenant_contrat_prorogationPopulateColumnsParameters.CustomColumnParameters.Add(Avenant_contrat_prorogationAvenant_contrat_prorogationChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalAvenant_contrat_prorogationChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalAvenant_contrat_prorogationChildPopulateColumnParameters.FieldName = "Code_PostalAvenant_contrat_prorogation";
            Code_PostalAvenant_contrat_prorogationChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			Avenant_contrat_prorogationPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalAvenant_contrat_prorogationChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageAvenant_contrat_prorogationChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageAvenant_contrat_prorogationChildPopulateColumnParameters.FieldName = "Maitre_ApprentissageAvenant_contrat_prorogation";
            Maitre_ApprentissageAvenant_contrat_prorogationChildPopulateColumnParameters.Path = "Maitre_Apprentissage.Nom_Maitre_Apprentissage";
			Avenant_contrat_prorogationPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageAvenant_contrat_prorogationChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Contract_avenant_changementAvenant_contrat_prorogationChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Contract_avenant_changementAvenant_contrat_prorogationChildPopulateColumnParameters.FieldName = "Contract_avenant_changementAvenant_contrat_prorogation";
            Contract_avenant_changementAvenant_contrat_prorogationChildPopulateColumnParameters.Path = "Contract_avenant_changement.num_stg";
			Avenant_contrat_prorogationPopulateColumnsParameters.CustomColumnParameters.Add(Contract_avenant_changementAvenant_contrat_prorogationChildPopulateColumnParameters);
			 
		    this.Avenant_contrat_prorogationGridView.PopulateColumns(typeof(gtsco2.basededonne.Avenant_contrat_prorogation),Avenant_contrat_prorogationPopulateColumnsParameters);
			//
			//Avenant_contrat_prorogationBindingSource
			//
			System.Windows.Forms.BindingSource Avenant_contrat_prorogationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			Avenant_contrat_prorogationBindingSource.DataSource = typeof(gtsco2.basededonne.Avenant_contrat_prorogation);
            this.Avenant_contrat_prorogationGridControl.DataSource = Avenant_contrat_prorogationBindingSource;
			//
			//Avenant_contrat_prorogationXtraUserControl
			//
            this.Avenant_contrat_prorogationXtraUserControl.Controls.Add(Avenant_contrat_prorogationGridControl);
			this.Avenant_contrat_prorogationXtraUserControl.Name = "Avenant_contrat_prorogationXtraUserControl";
			this.Avenant_contrat_prorogationXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Avenant_contrat_prorogationNew
			//
			this.bbiAvenant_contrat_prorogationNew.Caption = "New";
			this.bbiAvenant_contrat_prorogationNew.Name = "bbiAvenant_contrat_prorogationNew";
			this.bbiAvenant_contrat_prorogationNew.ImageUri.Uri = "New";
			this.bbiAvenant_contrat_prorogationNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Avenant_contrat_prorogationBarManager.Items.Add(this.bbiAvenant_contrat_prorogationNew);
			this.Avenant_contrat_prorogationBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationNew));
			this.Avenant_contrat_prorogationPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationNew));
						//
			//Avenant_contrat_prorogationEdit
			//
			this.bbiAvenant_contrat_prorogationEdit.Caption = "Edit";
			this.bbiAvenant_contrat_prorogationEdit.Name = "bbiAvenant_contrat_prorogationEdit";
			this.bbiAvenant_contrat_prorogationEdit.ImageUri.Uri = "Edit";
			this.bbiAvenant_contrat_prorogationEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Avenant_contrat_prorogationBarManager.Items.Add(this.bbiAvenant_contrat_prorogationEdit);
			this.Avenant_contrat_prorogationBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationEdit));
			this.Avenant_contrat_prorogationPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationEdit));
						//
			//Avenant_contrat_prorogationDelete
			//
			this.bbiAvenant_contrat_prorogationDelete.Caption = "Delete";
			this.bbiAvenant_contrat_prorogationDelete.Name = "bbiAvenant_contrat_prorogationDelete";
			this.bbiAvenant_contrat_prorogationDelete.ImageUri.Uri = "Delete";
			this.bbiAvenant_contrat_prorogationDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Avenant_contrat_prorogationBarManager.Items.Add(this.bbiAvenant_contrat_prorogationDelete);
			this.Avenant_contrat_prorogationBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationDelete));
			this.Avenant_contrat_prorogationPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationDelete));
						//
			//Avenant_contrat_prorogationRefresh
			//
			this.bbiAvenant_contrat_prorogationRefresh.Caption = "Refresh";
			this.bbiAvenant_contrat_prorogationRefresh.Name = "bbiAvenant_contrat_prorogationRefresh";
			this.bbiAvenant_contrat_prorogationRefresh.ImageUri.Uri = "Refresh";
			this.bbiAvenant_contrat_prorogationRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Avenant_contrat_prorogationBarManager.Items.Add(this.bbiAvenant_contrat_prorogationRefresh);
			this.Avenant_contrat_prorogationBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationRefresh));
			this.Avenant_contrat_prorogationPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiAvenant_contrat_prorogationRefresh));
						//
			//Avenant_contrat_prorogationBar
			//
			this.Avenant_contrat_prorogationBar.BarName = "Avenant_contrat_prorogation";
            this.Avenant_contrat_prorogationBar.DockCol = 0;
            this.Avenant_contrat_prorogationBar.DockRow = 0;
            this.Avenant_contrat_prorogationBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Avenant_contrat_prorogationBar.OptionsBar.AllowQuickCustomization = false;
            this.Avenant_contrat_prorogationBar.OptionsBar.DrawDragBorder = false;
            this.Avenant_contrat_prorogationBar.Text = "Avenant_contrat_prorogation";
			//
			//Avenant_contrat_prorogationBarManager
			//
			this.Avenant_contrat_prorogationBarManager.AllowCustomization = false;
            this.Avenant_contrat_prorogationBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Avenant_contrat_prorogationBar});
            this.Avenant_contrat_prorogationBarManager.Form = Avenant_contrat_prorogationXtraUserControl;
            this.Avenant_contrat_prorogationBarManager.MainMenu = this.Avenant_contrat_prorogationBar;
			// 
            // Avenant_contrat_prorogationPopUpMenu
            // 
            this.Avenant_contrat_prorogationPopUpMenu.Manager = this.Avenant_contrat_prorogationBarManager;
            this.Avenant_contrat_prorogationPopUpMenu.Name = "Avenant_contrat_prorogationPopUpMenu";
			//
			//Avenant_contrat_prorogationRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Avenant_contrat_prorogationRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Avenant_contrat_prorogationRetriveFieldParameters.FieldName = "Avenant_contrat_prorogation";
            Avenant_contrat_prorogationRetriveFieldParameters.ControlForField = Avenant_contrat_prorogationXtraUserControl;
			Avenant_contrat_prorogationRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Avenant_contrat_prorogationRetriveFieldParameters);
						//
			//Maitre_ApprentissageGridControl
			//
			this.Maitre_ApprentissageGridControl.MainView = this.Maitre_ApprentissageGridView;
			this.Maitre_ApprentissageGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maitre_ApprentissageGridControl.MenuManager = this.mainRibbonControl;
            this.Maitre_ApprentissageGridControl.Name = "Maitre_ApprentissageGridControl";
            this.Maitre_ApprentissageGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Maitre_ApprentissageGridView});
			//
			//Maitre_ApprentissageGridView
			//
            this.Maitre_ApprentissageGridView.GridControl = this.Maitre_ApprentissageGridControl;
            this.Maitre_ApprentissageGridView.Name = "Maitre_ApprentissageGridView";
            this.Maitre_ApprentissageGridView.OptionsBehavior.Editable = false;
            this.Maitre_ApprentissageGridView.OptionsBehavior.ReadOnly = true;
			//
			//Maitre_ApprentissagePopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Maitre_ApprentissagePopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommuneMaitre_ApprentissageChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommuneMaitre_ApprentissageChildPopulateColumnParameters_NotVisible.FieldName = "Commune";
		    CommuneMaitre_ApprentissageChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(CommuneMaitre_ApprentissageChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeurMaitre_ApprentissageChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeurMaitre_ApprentissageChildPopulateColumnParameters_NotVisible.FieldName = "Employeur";
		    EmployeurMaitre_ApprentissageChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(EmployeurMaitre_ApprentissageChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsMaitre_ApprentissageChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsMaitre_ApprentissageChildPopulateColumnParameters_NotVisible.FieldName = "Stagiairs";
		    StagiairsMaitre_ApprentissageChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(StagiairsMaitre_ApprentissageChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "StagiairsMaitre_Apprentissage";
            StagiairsMaitre_ApprentissageChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(StagiairsMaitre_ApprentissageChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Avenant_contrat_prorogationMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Avenant_contrat_prorogationMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "Avenant_contrat_prorogationMaitre_Apprentissage";
            Avenant_contrat_prorogationMaitre_ApprentissageChildPopulateColumnParameters.Path = "Avenant_contrat_prorogation.Num_stg";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(Avenant_contrat_prorogationMaitre_ApprentissageChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "Code_PostalMaitre_Apprentissage";
            Code_PostalMaitre_ApprentissageChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalMaitre_ApprentissageChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "Maitre_ApprentissageMaitre_Apprentissage";
            Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters.Path = "Maitre_Apprentissage.Nom_Maitre_Apprentissage";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Contract_avenant_changementMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Contract_avenant_changementMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "Contract_avenant_changementMaitre_Apprentissage";
            Contract_avenant_changementMaitre_ApprentissageChildPopulateColumnParameters.Path = "Contract_avenant_changement.num_stg";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(Contract_avenant_changementMaitre_ApprentissageChildPopulateColumnParameters);
			 
		    this.Maitre_ApprentissageGridView.PopulateColumns(typeof(gtsco2.basededonne.Maitre_Apprentissage),Maitre_ApprentissagePopulateColumnsParameters);
			//
			//Maitre_ApprentissageBindingSource
			//
			System.Windows.Forms.BindingSource Maitre_ApprentissageBindingSource = new System.Windows.Forms.BindingSource(this.components);
			Maitre_ApprentissageBindingSource.DataSource = typeof(gtsco2.basededonne.Maitre_Apprentissage);
            this.Maitre_ApprentissageGridControl.DataSource = Maitre_ApprentissageBindingSource;
			//
			//Maitre_ApprentissageXtraUserControl
			//
            this.Maitre_ApprentissageXtraUserControl.Controls.Add(Maitre_ApprentissageGridControl);
			this.Maitre_ApprentissageXtraUserControl.Name = "Maitre_ApprentissageXtraUserControl";
			this.Maitre_ApprentissageXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Maitre_ApprentissageNew
			//
			this.bbiMaitre_ApprentissageNew.Caption = "New";
			this.bbiMaitre_ApprentissageNew.Name = "bbiMaitre_ApprentissageNew";
			this.bbiMaitre_ApprentissageNew.ImageUri.Uri = "New";
			this.bbiMaitre_ApprentissageNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Maitre_ApprentissageBarManager.Items.Add(this.bbiMaitre_ApprentissageNew);
			this.Maitre_ApprentissageBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageNew));
			this.Maitre_ApprentissagePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageNew));
						//
			//Maitre_ApprentissageEdit
			//
			this.bbiMaitre_ApprentissageEdit.Caption = "Edit";
			this.bbiMaitre_ApprentissageEdit.Name = "bbiMaitre_ApprentissageEdit";
			this.bbiMaitre_ApprentissageEdit.ImageUri.Uri = "Edit";
			this.bbiMaitre_ApprentissageEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Maitre_ApprentissageBarManager.Items.Add(this.bbiMaitre_ApprentissageEdit);
			this.Maitre_ApprentissageBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageEdit));
			this.Maitre_ApprentissagePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageEdit));
						//
			//Maitre_ApprentissageDelete
			//
			this.bbiMaitre_ApprentissageDelete.Caption = "Delete";
			this.bbiMaitre_ApprentissageDelete.Name = "bbiMaitre_ApprentissageDelete";
			this.bbiMaitre_ApprentissageDelete.ImageUri.Uri = "Delete";
			this.bbiMaitre_ApprentissageDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Maitre_ApprentissageBarManager.Items.Add(this.bbiMaitre_ApprentissageDelete);
			this.Maitre_ApprentissageBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageDelete));
			this.Maitre_ApprentissagePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageDelete));
						//
			//Maitre_ApprentissageRefresh
			//
			this.bbiMaitre_ApprentissageRefresh.Caption = "Refresh";
			this.bbiMaitre_ApprentissageRefresh.Name = "bbiMaitre_ApprentissageRefresh";
			this.bbiMaitre_ApprentissageRefresh.ImageUri.Uri = "Refresh";
			this.bbiMaitre_ApprentissageRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Maitre_ApprentissageBarManager.Items.Add(this.bbiMaitre_ApprentissageRefresh);
			this.Maitre_ApprentissageBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageRefresh));
			this.Maitre_ApprentissagePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaitre_ApprentissageRefresh));
						//
			//Maitre_ApprentissageBar
			//
			this.Maitre_ApprentissageBar.BarName = "Maitre_Apprentissage";
            this.Maitre_ApprentissageBar.DockCol = 0;
            this.Maitre_ApprentissageBar.DockRow = 0;
            this.Maitre_ApprentissageBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Maitre_ApprentissageBar.OptionsBar.AllowQuickCustomization = false;
            this.Maitre_ApprentissageBar.OptionsBar.DrawDragBorder = false;
            this.Maitre_ApprentissageBar.Text = "Maitre_Apprentissage";
			//
			//Maitre_ApprentissageBarManager
			//
			this.Maitre_ApprentissageBarManager.AllowCustomization = false;
            this.Maitre_ApprentissageBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Maitre_ApprentissageBar});
            this.Maitre_ApprentissageBarManager.Form = Maitre_ApprentissageXtraUserControl;
            this.Maitre_ApprentissageBarManager.MainMenu = this.Maitre_ApprentissageBar;
			// 
            // Maitre_ApprentissagePopUpMenu
            // 
            this.Maitre_ApprentissagePopUpMenu.Manager = this.Maitre_ApprentissageBarManager;
            this.Maitre_ApprentissagePopUpMenu.Name = "Maitre_ApprentissagePopUpMenu";
			//
			//Maitre_ApprentissageRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Maitre_ApprentissageRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Maitre_ApprentissageRetriveFieldParameters.FieldName = "Maitre_Apprentissage";
            Maitre_ApprentissageRetriveFieldParameters.ControlForField = Maitre_ApprentissageXtraUserControl;
			Maitre_ApprentissageRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Maitre_ApprentissageRetriveFieldParameters);
						//
			//Contract_avenant_changementGridControl
			//
			this.Contract_avenant_changementGridControl.MainView = this.Contract_avenant_changementGridView;
			this.Contract_avenant_changementGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contract_avenant_changementGridControl.MenuManager = this.mainRibbonControl;
            this.Contract_avenant_changementGridControl.Name = "Contract_avenant_changementGridControl";
            this.Contract_avenant_changementGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Contract_avenant_changementGridView});
			//
			//Contract_avenant_changementGridView
			//
            this.Contract_avenant_changementGridView.GridControl = this.Contract_avenant_changementGridControl;
            this.Contract_avenant_changementGridView.Name = "Contract_avenant_changementGridView";
            this.Contract_avenant_changementGridView.OptionsBehavior.Editable = false;
            this.Contract_avenant_changementGridView.OptionsBehavior.ReadOnly = true;
			//
			//Contract_avenant_changementPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Contract_avenant_changementPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeurContract_avenant_changementChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeurContract_avenant_changementChildPopulateColumnParameters_NotVisible.FieldName = "Employeur";
		    EmployeurContract_avenant_changementChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Contract_avenant_changementPopulateColumnsParameters.CustomColumnParameters.Add(EmployeurContract_avenant_changementChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairContract_avenant_changementChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairContract_avenant_changementChildPopulateColumnParameters_NotVisible.FieldName = "Stagiair";
		    StagiairContract_avenant_changementChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Contract_avenant_changementPopulateColumnsParameters.CustomColumnParameters.Add(StagiairContract_avenant_changementChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsContract_avenant_changementChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsContract_avenant_changementChildPopulateColumnParameters.FieldName = "StagiairsContract_avenant_changement";
            StagiairsContract_avenant_changementChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			Contract_avenant_changementPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsContract_avenant_changementChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Avenant_contrat_prorogationContract_avenant_changementChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Avenant_contrat_prorogationContract_avenant_changementChildPopulateColumnParameters.FieldName = "Avenant_contrat_prorogationContract_avenant_changement";
            Avenant_contrat_prorogationContract_avenant_changementChildPopulateColumnParameters.Path = "Avenant_contrat_prorogation.Num_stg";
			Contract_avenant_changementPopulateColumnsParameters.CustomColumnParameters.Add(Avenant_contrat_prorogationContract_avenant_changementChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalContract_avenant_changementChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalContract_avenant_changementChildPopulateColumnParameters.FieldName = "Code_PostalContract_avenant_changement";
            Code_PostalContract_avenant_changementChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			Contract_avenant_changementPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalContract_avenant_changementChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageContract_avenant_changementChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageContract_avenant_changementChildPopulateColumnParameters.FieldName = "Maitre_ApprentissageContract_avenant_changement";
            Maitre_ApprentissageContract_avenant_changementChildPopulateColumnParameters.Path = "Maitre_Apprentissage.Nom_Maitre_Apprentissage";
			Contract_avenant_changementPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageContract_avenant_changementChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Contract_avenant_changementContract_avenant_changementChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Contract_avenant_changementContract_avenant_changementChildPopulateColumnParameters.FieldName = "Contract_avenant_changementContract_avenant_changement";
            Contract_avenant_changementContract_avenant_changementChildPopulateColumnParameters.Path = "Contract_avenant_changement.num_stg";
			Contract_avenant_changementPopulateColumnsParameters.CustomColumnParameters.Add(Contract_avenant_changementContract_avenant_changementChildPopulateColumnParameters);
			 
		    this.Contract_avenant_changementGridView.PopulateColumns(typeof(gtsco2.basededonne.Contract_avenant_changement),Contract_avenant_changementPopulateColumnsParameters);
			//
			//Contract_avenant_changementBindingSource
			//
			System.Windows.Forms.BindingSource Contract_avenant_changementBindingSource = new System.Windows.Forms.BindingSource(this.components);
			Contract_avenant_changementBindingSource.DataSource = typeof(gtsco2.basededonne.Contract_avenant_changement);
            this.Contract_avenant_changementGridControl.DataSource = Contract_avenant_changementBindingSource;
			//
			//Contract_avenant_changementXtraUserControl
			//
            this.Contract_avenant_changementXtraUserControl.Controls.Add(Contract_avenant_changementGridControl);
			this.Contract_avenant_changementXtraUserControl.Name = "Contract_avenant_changementXtraUserControl";
			this.Contract_avenant_changementXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Contract_avenant_changementNew
			//
			this.bbiContract_avenant_changementNew.Caption = "New";
			this.bbiContract_avenant_changementNew.Name = "bbiContract_avenant_changementNew";
			this.bbiContract_avenant_changementNew.ImageUri.Uri = "New";
			this.bbiContract_avenant_changementNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Contract_avenant_changementBarManager.Items.Add(this.bbiContract_avenant_changementNew);
			this.Contract_avenant_changementBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementNew));
			this.Contract_avenant_changementPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementNew));
						//
			//Contract_avenant_changementEdit
			//
			this.bbiContract_avenant_changementEdit.Caption = "Edit";
			this.bbiContract_avenant_changementEdit.Name = "bbiContract_avenant_changementEdit";
			this.bbiContract_avenant_changementEdit.ImageUri.Uri = "Edit";
			this.bbiContract_avenant_changementEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Contract_avenant_changementBarManager.Items.Add(this.bbiContract_avenant_changementEdit);
			this.Contract_avenant_changementBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementEdit));
			this.Contract_avenant_changementPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementEdit));
						//
			//Contract_avenant_changementDelete
			//
			this.bbiContract_avenant_changementDelete.Caption = "Delete";
			this.bbiContract_avenant_changementDelete.Name = "bbiContract_avenant_changementDelete";
			this.bbiContract_avenant_changementDelete.ImageUri.Uri = "Delete";
			this.bbiContract_avenant_changementDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Contract_avenant_changementBarManager.Items.Add(this.bbiContract_avenant_changementDelete);
			this.Contract_avenant_changementBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementDelete));
			this.Contract_avenant_changementPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementDelete));
						//
			//Contract_avenant_changementRefresh
			//
			this.bbiContract_avenant_changementRefresh.Caption = "Refresh";
			this.bbiContract_avenant_changementRefresh.Name = "bbiContract_avenant_changementRefresh";
			this.bbiContract_avenant_changementRefresh.ImageUri.Uri = "Refresh";
			this.bbiContract_avenant_changementRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Contract_avenant_changementBarManager.Items.Add(this.bbiContract_avenant_changementRefresh);
			this.Contract_avenant_changementBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementRefresh));
			this.Contract_avenant_changementPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract_avenant_changementRefresh));
						//
			//Contract_avenant_changementBar
			//
			this.Contract_avenant_changementBar.BarName = "Contract_avenant_changement";
            this.Contract_avenant_changementBar.DockCol = 0;
            this.Contract_avenant_changementBar.DockRow = 0;
            this.Contract_avenant_changementBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Contract_avenant_changementBar.OptionsBar.AllowQuickCustomization = false;
            this.Contract_avenant_changementBar.OptionsBar.DrawDragBorder = false;
            this.Contract_avenant_changementBar.Text = "Contract_avenant_changement";
			//
			//Contract_avenant_changementBarManager
			//
			this.Contract_avenant_changementBarManager.AllowCustomization = false;
            this.Contract_avenant_changementBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Contract_avenant_changementBar});
            this.Contract_avenant_changementBarManager.Form = Contract_avenant_changementXtraUserControl;
            this.Contract_avenant_changementBarManager.MainMenu = this.Contract_avenant_changementBar;
			// 
            // Contract_avenant_changementPopUpMenu
            // 
            this.Contract_avenant_changementPopUpMenu.Manager = this.Contract_avenant_changementBarManager;
            this.Contract_avenant_changementPopUpMenu.Name = "Contract_avenant_changementPopUpMenu";
			//
			//Contract_avenant_changementRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Contract_avenant_changementRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Contract_avenant_changementRetriveFieldParameters.FieldName = "Contract_avenant_changement";
            Contract_avenant_changementRetriveFieldParameters.ControlForField = Contract_avenant_changementXtraUserControl;
			Contract_avenant_changementRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Contract_avenant_changementRetriveFieldParameters);
									//
			//Code_PostalLookUpEdit
			//
			this.Code_PostalBindingSource.DataSource = typeof(gtsco2.basededonne.Code_Postal);
			this.Code_PostalLookUpEdit.Properties.ValueMember = "ID_Code_Postal"; 
			this.Code_PostalLookUpEdit.Properties.DisplayMember = "post_Adresse_ar";
			this.Code_PostalLookUpEdit.Properties.DataSource = this.Code_PostalBindingSource;
			this.Code_PostalLookUpEdit.Name = "Code_PostalLookUpEdit";
			this.Code_PostalLookUpEdit.DataBindings.Add("EditValue", employeurViewBindingSource, "Code_Postal_Emp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Code_PostalLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Code_PostalLookUpEditRetrieveFieldParameters.FieldName = "Code_Postal_Emp";
            Code_PostalLookUpEditRetrieveFieldParameters.ControlForField = this.Code_PostalLookUpEdit;
			parameters.CustomListParameters.Add(Code_PostalLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Code_PostalLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    Code_PostalLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Code_Postal";
		    Code_PostalLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(Code_PostalLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//EmployeurView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "EmployeurView";
						((System.ComponentModel.ISupportInitialize)(this.StagiairsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.Avenant_contrat_prorogationBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.Maitre_ApprentissageBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.Contract_avenant_changementBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource employeurViewBindingSource;
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
						private DevExpress.XtraGrid.GridControl Avenant_contrat_prorogationGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Avenant_contrat_prorogationGridView;
		private DevExpress.XtraBars.BarManager Avenant_contrat_prorogationBarManager;
		private DevExpress.XtraBars.Bar Avenant_contrat_prorogationBar;
		private DevExpress.XtraEditors.XtraUserControl Avenant_contrat_prorogationXtraUserControl;
		private DevExpress.XtraBars.PopupMenu Avenant_contrat_prorogationPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiAvenant_contrat_prorogationNew;
				private DevExpress.XtraBars.BarButtonItem bbiAvenant_contrat_prorogationEdit;
				private DevExpress.XtraBars.BarButtonItem bbiAvenant_contrat_prorogationDelete;
				private DevExpress.XtraBars.BarButtonItem bbiAvenant_contrat_prorogationRefresh;
						private DevExpress.XtraGrid.GridControl Maitre_ApprentissageGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Maitre_ApprentissageGridView;
		private DevExpress.XtraBars.BarManager Maitre_ApprentissageBarManager;
		private DevExpress.XtraBars.Bar Maitre_ApprentissageBar;
		private DevExpress.XtraEditors.XtraUserControl Maitre_ApprentissageXtraUserControl;
		private DevExpress.XtraBars.PopupMenu Maitre_ApprentissagePopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiMaitre_ApprentissageNew;
				private DevExpress.XtraBars.BarButtonItem bbiMaitre_ApprentissageEdit;
				private DevExpress.XtraBars.BarButtonItem bbiMaitre_ApprentissageDelete;
				private DevExpress.XtraBars.BarButtonItem bbiMaitre_ApprentissageRefresh;
						private DevExpress.XtraGrid.GridControl Contract_avenant_changementGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Contract_avenant_changementGridView;
		private DevExpress.XtraBars.BarManager Contract_avenant_changementBarManager;
		private DevExpress.XtraBars.Bar Contract_avenant_changementBar;
		private DevExpress.XtraEditors.XtraUserControl Contract_avenant_changementXtraUserControl;
		private DevExpress.XtraBars.PopupMenu Contract_avenant_changementPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiContract_avenant_changementNew;
				private DevExpress.XtraBars.BarButtonItem bbiContract_avenant_changementEdit;
				private DevExpress.XtraBars.BarButtonItem bbiContract_avenant_changementDelete;
				private DevExpress.XtraBars.BarButtonItem bbiContract_avenant_changementRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit Code_PostalLookUpEdit;
		private System.Windows.Forms.BindingSource Code_PostalBindingSource;
		 
	}
}
