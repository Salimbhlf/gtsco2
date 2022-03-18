namespace gtsco2.mvvm.Views.Maitre_ApprentissageView {
    partial class Maitre_ApprentissageView {
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
									this.CommuneLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.CommuneBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.EmployeurLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.EmployeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Maitre_Apprentissage Tasks";
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
			this.maitre_ApprentissageViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.maitre_ApprentissageViewBindingSource.DataSource = typeof(gtsco2.basededonne.Maitre_Apprentissage);
			this.dataLayoutControl1.DataSource = maitre_ApprentissageViewBindingSource;
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommuneStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommuneStagiairsChildPopulateColumnParameters.FieldName = "CommuneStagiairs";
            CommuneStagiairsChildPopulateColumnParameters.Path = "Commune.Commune_name";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(CommuneStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeurStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeurStagiairsChildPopulateColumnParameters.FieldName = "EmployeurStagiairs";
            EmployeurStagiairsChildPopulateColumnParameters.Path = "Employeur.Type_Emp";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(EmployeurStagiairsChildPopulateColumnParameters);
			 
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
			//CommuneLookUpEdit
			//
			this.CommuneBindingSource.DataSource = typeof(gtsco2.basededonne.Commune);
			this.CommuneLookUpEdit.Properties.ValueMember = "Commune_id"; 
			this.CommuneLookUpEdit.Properties.DisplayMember = "Commune_name";
			this.CommuneLookUpEdit.Properties.DataSource = this.CommuneBindingSource;
			this.CommuneLookUpEdit.Name = "CommuneLookUpEdit";
			this.CommuneLookUpEdit.DataBindings.Add("EditValue", maitre_ApprentissageViewBindingSource, "Commune_Maitre_Apprentissage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CommuneLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CommuneLookUpEditRetrieveFieldParameters.FieldName = "Commune_Maitre_Apprentissage";
            CommuneLookUpEditRetrieveFieldParameters.ControlForField = this.CommuneLookUpEdit;
			parameters.CustomListParameters.Add(CommuneLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CommuneLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    CommuneLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Commune";
		    CommuneLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(CommuneLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//EmployeurLookUpEdit
			//
			this.EmployeurBindingSource.DataSource = typeof(gtsco2.basededonne.Employeur);
			this.EmployeurLookUpEdit.Properties.ValueMember = "ID_Emp"; 
			this.EmployeurLookUpEdit.Properties.DisplayMember = "Type_Emp";
			this.EmployeurLookUpEdit.Properties.DataSource = this.EmployeurBindingSource;
			this.EmployeurLookUpEdit.Name = "EmployeurLookUpEdit";
			this.EmployeurLookUpEdit.DataBindings.Add("EditValue", maitre_ApprentissageViewBindingSource, "ID_Emp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters EmployeurLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            EmployeurLookUpEditRetrieveFieldParameters.FieldName = "ID_Emp";
            EmployeurLookUpEditRetrieveFieldParameters.ControlForField = this.EmployeurLookUpEdit;
			parameters.CustomListParameters.Add(EmployeurLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters EmployeurLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    EmployeurLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Employeur";
		    EmployeurLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(EmployeurLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//Maitre_ApprentissageView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "Maitre_ApprentissageView";
						((System.ComponentModel.ISupportInitialize)(this.StagiairsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource maitre_ApprentissageViewBindingSource;
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
								private DevExpress.XtraEditors.GridLookUpEdit CommuneLookUpEdit;
		private System.Windows.Forms.BindingSource CommuneBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit EmployeurLookUpEdit;
		private System.Windows.Forms.BindingSource EmployeurBindingSource;
		 
	}
}
