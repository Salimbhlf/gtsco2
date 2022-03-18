namespace gtsco2.mvvm.Views.CommuneView {
    partial class CommuneView {
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
						this.Code_PostalGridControl = new DevExpress.XtraGrid.GridControl();
			this.Code_PostalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Code_PostalBarManager = new DevExpress.XtraBars.BarManager();
			this.Code_PostalBar = new DevExpress.XtraBars.Bar();
			this.Code_PostalXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Code_PostalPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiCode_PostalNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCode_PostalEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCode_PostalDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCode_PostalRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Code_PostalBarManager)).BeginInit();
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
									this.WillayaLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.WillayaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Commune Tasks";
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
			this.communeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.communeViewBindingSource.DataSource = typeof(gtsco2.basededonne.Commune);
			this.dataLayoutControl1.DataSource = communeViewBindingSource;
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalStagiairsChildPopulateColumnParameters.FieldName = "Code_PostalStagiairs";
            Code_PostalStagiairsChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters WillayaStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            WillayaStagiairsChildPopulateColumnParameters.FieldName = "WillayaStagiairs";
            WillayaStagiairsChildPopulateColumnParameters.Path = "Willaya.Wilaya_name__ar";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(WillayaStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageStagiairsChildPopulateColumnParameters.FieldName = "Maitre_ApprentissageStagiairs";
            Maitre_ApprentissageStagiairsChildPopulateColumnParameters.Path = "Maitre_Apprentissage.Nom_Maitre_Apprentissage";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageStagiairsChildPopulateColumnParameters);
			 
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
			//Code_PostalGridControl
			//
			this.Code_PostalGridControl.MainView = this.Code_PostalGridView;
			this.Code_PostalGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Code_PostalGridControl.MenuManager = this.mainRibbonControl;
            this.Code_PostalGridControl.Name = "Code_PostalGridControl";
            this.Code_PostalGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Code_PostalGridView});
			//
			//Code_PostalGridView
			//
            this.Code_PostalGridView.GridControl = this.Code_PostalGridControl;
            this.Code_PostalGridView.Name = "Code_PostalGridView";
            this.Code_PostalGridView.OptionsBehavior.Editable = false;
            this.Code_PostalGridView.OptionsBehavior.ReadOnly = true;
			//
			//Code_PostalPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Code_PostalPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommuneCode_PostalChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommuneCode_PostalChildPopulateColumnParameters_NotVisible.FieldName = "Commune";
		    CommuneCode_PostalChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(CommuneCode_PostalChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeursCode_PostalChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeursCode_PostalChildPopulateColumnParameters_NotVisible.FieldName = "Employeurs";
		    EmployeursCode_PostalChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(EmployeursCode_PostalChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EtablissementsCode_PostalChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EtablissementsCode_PostalChildPopulateColumnParameters_NotVisible.FieldName = "Etablissements";
		    EtablissementsCode_PostalChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(EtablissementsCode_PostalChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsCode_PostalChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsCode_PostalChildPopulateColumnParameters_NotVisible.FieldName = "Stagiairs";
		    StagiairsCode_PostalChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsCode_PostalChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsCode_PostalChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsCode_PostalChildPopulateColumnParameters.FieldName = "StagiairsCode_Postal";
            StagiairsCode_PostalChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsCode_PostalChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalCode_PostalChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalCode_PostalChildPopulateColumnParameters.FieldName = "Code_PostalCode_Postal";
            Code_PostalCode_PostalChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalCode_PostalChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters WillayaCode_PostalChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            WillayaCode_PostalChildPopulateColumnParameters.FieldName = "WillayaCode_Postal";
            WillayaCode_PostalChildPopulateColumnParameters.Path = "Willaya.Wilaya_name__ar";
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(WillayaCode_PostalChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageCode_PostalChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageCode_PostalChildPopulateColumnParameters.FieldName = "Maitre_ApprentissageCode_Postal";
            Maitre_ApprentissageCode_PostalChildPopulateColumnParameters.Path = "Maitre_Apprentissage.Nom_Maitre_Apprentissage";
			Code_PostalPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageCode_PostalChildPopulateColumnParameters);
			 
		    this.Code_PostalGridView.PopulateColumns(typeof(gtsco2.basededonne.Code_Postal),Code_PostalPopulateColumnsParameters);
			//
			//Code_PostalBindingSource
			//
			System.Windows.Forms.BindingSource Code_PostalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			Code_PostalBindingSource.DataSource = typeof(gtsco2.basededonne.Code_Postal);
            this.Code_PostalGridControl.DataSource = Code_PostalBindingSource;
			//
			//Code_PostalXtraUserControl
			//
            this.Code_PostalXtraUserControl.Controls.Add(Code_PostalGridControl);
			this.Code_PostalXtraUserControl.Name = "Code_PostalXtraUserControl";
			this.Code_PostalXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Code_PostalNew
			//
			this.bbiCode_PostalNew.Caption = "New";
			this.bbiCode_PostalNew.Name = "bbiCode_PostalNew";
			this.bbiCode_PostalNew.ImageUri.Uri = "New";
			this.bbiCode_PostalNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Code_PostalBarManager.Items.Add(this.bbiCode_PostalNew);
			this.Code_PostalBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalNew));
			this.Code_PostalPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalNew));
						//
			//Code_PostalEdit
			//
			this.bbiCode_PostalEdit.Caption = "Edit";
			this.bbiCode_PostalEdit.Name = "bbiCode_PostalEdit";
			this.bbiCode_PostalEdit.ImageUri.Uri = "Edit";
			this.bbiCode_PostalEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Code_PostalBarManager.Items.Add(this.bbiCode_PostalEdit);
			this.Code_PostalBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalEdit));
			this.Code_PostalPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalEdit));
						//
			//Code_PostalDelete
			//
			this.bbiCode_PostalDelete.Caption = "Delete";
			this.bbiCode_PostalDelete.Name = "bbiCode_PostalDelete";
			this.bbiCode_PostalDelete.ImageUri.Uri = "Delete";
			this.bbiCode_PostalDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Code_PostalBarManager.Items.Add(this.bbiCode_PostalDelete);
			this.Code_PostalBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalDelete));
			this.Code_PostalPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalDelete));
						//
			//Code_PostalRefresh
			//
			this.bbiCode_PostalRefresh.Caption = "Refresh";
			this.bbiCode_PostalRefresh.Name = "bbiCode_PostalRefresh";
			this.bbiCode_PostalRefresh.ImageUri.Uri = "Refresh";
			this.bbiCode_PostalRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Code_PostalBarManager.Items.Add(this.bbiCode_PostalRefresh);
			this.Code_PostalBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalRefresh));
			this.Code_PostalPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCode_PostalRefresh));
						//
			//Code_PostalBar
			//
			this.Code_PostalBar.BarName = "Code_Postal";
            this.Code_PostalBar.DockCol = 0;
            this.Code_PostalBar.DockRow = 0;
            this.Code_PostalBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Code_PostalBar.OptionsBar.AllowQuickCustomization = false;
            this.Code_PostalBar.OptionsBar.DrawDragBorder = false;
            this.Code_PostalBar.Text = "Code_Postal";
			//
			//Code_PostalBarManager
			//
			this.Code_PostalBarManager.AllowCustomization = false;
            this.Code_PostalBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Code_PostalBar});
            this.Code_PostalBarManager.Form = Code_PostalXtraUserControl;
            this.Code_PostalBarManager.MainMenu = this.Code_PostalBar;
			// 
            // Code_PostalPopUpMenu
            // 
            this.Code_PostalPopUpMenu.Manager = this.Code_PostalBarManager;
            this.Code_PostalPopUpMenu.Name = "Code_PostalPopUpMenu";
			//
			//Code_PostalRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Code_PostalRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Code_PostalRetriveFieldParameters.FieldName = "Code_Postal";
            Code_PostalRetriveFieldParameters.ControlForField = Code_PostalXtraUserControl;
			Code_PostalRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Code_PostalRetriveFieldParameters);
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "Code_PostalMaitre_Apprentissage";
            Code_PostalMaitre_ApprentissageChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalMaitre_ApprentissageChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters WillayaMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            WillayaMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "WillayaMaitre_Apprentissage";
            WillayaMaitre_ApprentissageChildPopulateColumnParameters.Path = "Willaya.Wilaya_name__ar";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(WillayaMaitre_ApprentissageChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters.FieldName = "Maitre_ApprentissageMaitre_Apprentissage";
            Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters.Path = "Maitre_Apprentissage.Nom_Maitre_Apprentissage";
			Maitre_ApprentissagePopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageMaitre_ApprentissageChildPopulateColumnParameters);
			 
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
			//WillayaLookUpEdit
			//
			this.WillayaBindingSource.DataSource = typeof(gtsco2.basededonne.Willaya);
			this.WillayaLookUpEdit.Properties.ValueMember = "Wilaya_Code"; 
			this.WillayaLookUpEdit.Properties.DisplayMember = "Wilaya_name__ar";
			this.WillayaLookUpEdit.Properties.DataSource = this.WillayaBindingSource;
			this.WillayaLookUpEdit.Name = "WillayaLookUpEdit";
			this.WillayaLookUpEdit.DataBindings.Add("EditValue", communeViewBindingSource, "Code_Willaya", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters WillayaLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            WillayaLookUpEditRetrieveFieldParameters.FieldName = "Code_Willaya";
            WillayaLookUpEditRetrieveFieldParameters.ControlForField = this.WillayaLookUpEdit;
			parameters.CustomListParameters.Add(WillayaLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters WillayaLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    WillayaLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Willaya";
		    WillayaLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(WillayaLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.CommuneViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.CommuneViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//CommuneView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "CommuneView";
						((System.ComponentModel.ISupportInitialize)(this.StagiairsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.Code_PostalBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.Maitre_ApprentissageBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource communeViewBindingSource;
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
						private DevExpress.XtraGrid.GridControl Code_PostalGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Code_PostalGridView;
		private DevExpress.XtraBars.BarManager Code_PostalBarManager;
		private DevExpress.XtraBars.Bar Code_PostalBar;
		private DevExpress.XtraEditors.XtraUserControl Code_PostalXtraUserControl;
		private DevExpress.XtraBars.PopupMenu Code_PostalPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiCode_PostalNew;
				private DevExpress.XtraBars.BarButtonItem bbiCode_PostalEdit;
				private DevExpress.XtraBars.BarButtonItem bbiCode_PostalDelete;
				private DevExpress.XtraBars.BarButtonItem bbiCode_PostalRefresh;
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
								private DevExpress.XtraEditors.GridLookUpEdit WillayaLookUpEdit;
		private System.Windows.Forms.BindingSource WillayaBindingSource;
		 
	}
}
