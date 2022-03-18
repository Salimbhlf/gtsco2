namespace gtsco2.mvvm.Views.EtablissementView {
    partial class EtablissementView {
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
						this.TransferersGridControl = new DevExpress.XtraGrid.GridControl();
			this.TransferersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.TransferersBarManager = new DevExpress.XtraBars.BarManager();
			this.TransferersBar = new DevExpress.XtraBars.Bar();
			this.TransferersXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.TransferersPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiTransferersNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiTransferersEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiTransferersDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiTransferersRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.TransferersBarManager)).BeginInit();
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
            this.mainRibbonPageGroup.Text = "Etablissement Tasks";
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
			this.etablissementViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.etablissementViewBindingSource.DataSource = typeof(gtsco2.basededonne.Etablissement);
			this.dataLayoutControl1.DataSource = etablissementViewBindingSource;
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TransferersStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TransferersStagiairsChildPopulateColumnParameters.FieldName = "TransferersStagiairs";
            TransferersStagiairsChildPopulateColumnParameters.Path = "Transferers.num_stg";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(TransferersStagiairsChildPopulateColumnParameters);
			 
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
			//TransferersGridControl
			//
			this.TransferersGridControl.MainView = this.TransferersGridView;
			this.TransferersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransferersGridControl.MenuManager = this.mainRibbonControl;
            this.TransferersGridControl.Name = "TransferersGridControl";
            this.TransferersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TransferersGridView});
			//
			//TransferersGridView
			//
            this.TransferersGridView.GridControl = this.TransferersGridControl;
            this.TransferersGridView.Name = "TransferersGridView";
            this.TransferersGridView.OptionsBehavior.Editable = false;
            this.TransferersGridView.OptionsBehavior.ReadOnly = true;
			//
			//TransferersPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters TransferersPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EtablissementTransferersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EtablissementTransferersChildPopulateColumnParameters_NotVisible.FieldName = "Etablissement";
		    EtablissementTransferersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			TransferersPopulateColumnsParameters.CustomColumnParameters.Add(EtablissementTransferersChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairTransferersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairTransferersChildPopulateColumnParameters_NotVisible.FieldName = "Stagiair";
		    StagiairTransferersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			TransferersPopulateColumnsParameters.CustomColumnParameters.Add(StagiairTransferersChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsTransferersChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsTransferersChildPopulateColumnParameters.FieldName = "StagiairsTransferers";
            StagiairsTransferersChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			TransferersPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsTransferersChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalTransferersChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalTransferersChildPopulateColumnParameters.FieldName = "Code_PostalTransferers";
            Code_PostalTransferersChildPopulateColumnParameters.Path = "Code_Postal.post_Adresse_ar";
			TransferersPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalTransferersChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TransferersTransferersChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TransferersTransferersChildPopulateColumnParameters.FieldName = "TransferersTransferers";
            TransferersTransferersChildPopulateColumnParameters.Path = "Transferers.num_stg";
			TransferersPopulateColumnsParameters.CustomColumnParameters.Add(TransferersTransferersChildPopulateColumnParameters);
			 
		    this.TransferersGridView.PopulateColumns(typeof(gtsco2.basededonne.Transferer),TransferersPopulateColumnsParameters);
			//
			//TransferersBindingSource
			//
			System.Windows.Forms.BindingSource TransferersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			TransferersBindingSource.DataSource = typeof(gtsco2.basededonne.Transferer);
            this.TransferersGridControl.DataSource = TransferersBindingSource;
			//
			//TransferersXtraUserControl
			//
            this.TransferersXtraUserControl.Controls.Add(TransferersGridControl);
			this.TransferersXtraUserControl.Name = "TransferersXtraUserControl";
			this.TransferersXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//TransferersNew
			//
			this.bbiTransferersNew.Caption = "New";
			this.bbiTransferersNew.Name = "bbiTransferersNew";
			this.bbiTransferersNew.ImageUri.Uri = "New";
			this.bbiTransferersNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.TransferersBarManager.Items.Add(this.bbiTransferersNew);
			this.TransferersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersNew));
			this.TransferersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersNew));
						//
			//TransferersEdit
			//
			this.bbiTransferersEdit.Caption = "Edit";
			this.bbiTransferersEdit.Name = "bbiTransferersEdit";
			this.bbiTransferersEdit.ImageUri.Uri = "Edit";
			this.bbiTransferersEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.TransferersBarManager.Items.Add(this.bbiTransferersEdit);
			this.TransferersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersEdit));
			this.TransferersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersEdit));
						//
			//TransferersDelete
			//
			this.bbiTransferersDelete.Caption = "Delete";
			this.bbiTransferersDelete.Name = "bbiTransferersDelete";
			this.bbiTransferersDelete.ImageUri.Uri = "Delete";
			this.bbiTransferersDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.TransferersBarManager.Items.Add(this.bbiTransferersDelete);
			this.TransferersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersDelete));
			this.TransferersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersDelete));
						//
			//TransferersRefresh
			//
			this.bbiTransferersRefresh.Caption = "Refresh";
			this.bbiTransferersRefresh.Name = "bbiTransferersRefresh";
			this.bbiTransferersRefresh.ImageUri.Uri = "Refresh";
			this.bbiTransferersRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.TransferersBarManager.Items.Add(this.bbiTransferersRefresh);
			this.TransferersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersRefresh));
			this.TransferersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransferersRefresh));
						//
			//TransferersBar
			//
			this.TransferersBar.BarName = "Transferers";
            this.TransferersBar.DockCol = 0;
            this.TransferersBar.DockRow = 0;
            this.TransferersBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.TransferersBar.OptionsBar.AllowQuickCustomization = false;
            this.TransferersBar.OptionsBar.DrawDragBorder = false;
            this.TransferersBar.Text = "Transferers";
			//
			//TransferersBarManager
			//
			this.TransferersBarManager.AllowCustomization = false;
            this.TransferersBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.TransferersBar});
            this.TransferersBarManager.Form = TransferersXtraUserControl;
            this.TransferersBarManager.MainMenu = this.TransferersBar;
			// 
            // TransferersPopUpMenu
            // 
            this.TransferersPopUpMenu.Manager = this.TransferersBarManager;
            this.TransferersPopUpMenu.Name = "TransferersPopUpMenu";
			//
			//TransferersRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters TransferersRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            TransferersRetriveFieldParameters.FieldName = "Transferers";
            TransferersRetriveFieldParameters.ControlForField = TransferersXtraUserControl;
			TransferersRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(TransferersRetriveFieldParameters);
									//
			//Code_PostalLookUpEdit
			//
			this.Code_PostalBindingSource.DataSource = typeof(gtsco2.basededonne.Code_Postal);
			this.Code_PostalLookUpEdit.Properties.ValueMember = "ID_Code_Postal"; 
			this.Code_PostalLookUpEdit.Properties.DisplayMember = "post_Adresse_ar";
			this.Code_PostalLookUpEdit.Properties.DataSource = this.Code_PostalBindingSource;
			this.Code_PostalLookUpEdit.Name = "Code_PostalLookUpEdit";
			this.Code_PostalLookUpEdit.DataBindings.Add("EditValue", etablissementViewBindingSource, "Code_Postal_EATB", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Code_PostalLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Code_PostalLookUpEditRetrieveFieldParameters.FieldName = "Code_Postal_EATB";
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
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EtablissementViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//EtablissementView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "EtablissementView";
						((System.ComponentModel.ISupportInitialize)(this.StagiairsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.TransferersBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource etablissementViewBindingSource;
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
						private DevExpress.XtraGrid.GridControl TransferersGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView TransferersGridView;
		private DevExpress.XtraBars.BarManager TransferersBarManager;
		private DevExpress.XtraBars.Bar TransferersBar;
		private DevExpress.XtraEditors.XtraUserControl TransferersXtraUserControl;
		private DevExpress.XtraBars.PopupMenu TransferersPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiTransferersNew;
				private DevExpress.XtraBars.BarButtonItem bbiTransferersEdit;
				private DevExpress.XtraBars.BarButtonItem bbiTransferersDelete;
				private DevExpress.XtraBars.BarButtonItem bbiTransferersRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit Code_PostalLookUpEdit;
		private System.Windows.Forms.BindingSource Code_PostalBindingSource;
		 
	}
}
