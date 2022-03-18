namespace gtsco2.mvvm.Views.EnseignantView {
    partial class EnseignantView {
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
						this.EvaluationsGridControl = new DevExpress.XtraGrid.GridControl();
			this.EvaluationsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.EvaluationsBarManager = new DevExpress.XtraBars.BarManager();
			this.EvaluationsBar = new DevExpress.XtraBars.Bar();
			this.EvaluationsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.EvaluationsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiEvaluationsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEvaluationsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEvaluationsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEvaluationsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.EvaluationsBarManager)).BeginInit();
						this.PARTICIPEsGridControl = new DevExpress.XtraGrid.GridControl();
			this.PARTICIPEsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.PARTICIPEsBarManager = new DevExpress.XtraBars.BarManager();
			this.PARTICIPEsBar = new DevExpress.XtraBars.Bar();
			this.PARTICIPEsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.PARTICIPEsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiPARTICIPEsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPARTICIPEsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPARTICIPEsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPARTICIPEsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.PARTICIPEsBarManager)).BeginInit();
						this.Suiver_stagiaireGridControl = new DevExpress.XtraGrid.GridControl();
			this.Suiver_stagiaireGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Suiver_stagiaireBarManager = new DevExpress.XtraBars.BarManager();
			this.Suiver_stagiaireBar = new DevExpress.XtraBars.Bar();
			this.Suiver_stagiaireXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Suiver_stagiairePopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiSuiver_stagiaireNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSuiver_stagiaireEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSuiver_stagiaireDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSuiver_stagiaireRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Suiver_stagiaireBarManager)).BeginInit();
									this.Mode_formation1LookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.Mode_formation1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Enseignant Tasks";
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
			this.enseignantViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.enseignantViewBindingSource.DataSource = typeof(gtsco2.basededonne.Enseignant);
			this.dataLayoutControl1.DataSource = enseignantViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//EvaluationsGridControl
			//
			this.EvaluationsGridControl.MainView = this.EvaluationsGridView;
			this.EvaluationsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationsGridControl.MenuManager = this.mainRibbonControl;
            this.EvaluationsGridControl.Name = "EvaluationsGridControl";
            this.EvaluationsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EvaluationsGridView});
			//
			//EvaluationsGridView
			//
            this.EvaluationsGridView.GridControl = this.EvaluationsGridControl;
            this.EvaluationsGridView.Name = "EvaluationsGridView";
            this.EvaluationsGridView.OptionsBehavior.Editable = false;
            this.EvaluationsGridView.OptionsBehavior.ReadOnly = true;
			//
			//EvaluationsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters EvaluationsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters annee_scolaireEvaluationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            annee_scolaireEvaluationsChildPopulateColumnParameters_NotVisible.FieldName = "annee_scolaire";
		    annee_scolaireEvaluationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(annee_scolaireEvaluationsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Enseignant1EvaluationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Enseignant1EvaluationsChildPopulateColumnParameters_NotVisible.FieldName = "Enseignant1";
		    Enseignant1EvaluationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(Enseignant1EvaluationsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModuleEvaluationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModuleEvaluationsChildPopulateColumnParameters_NotVisible.FieldName = "Module";
		    ModuleEvaluationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(ModuleEvaluationsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SemestreEvaluationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SemestreEvaluationsChildPopulateColumnParameters_NotVisible.FieldName = "Semestre";
		    SemestreEvaluationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(SemestreEvaluationsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairEvaluationsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairEvaluationsChildPopulateColumnParameters_NotVisible.FieldName = "Stagiair";
		    StagiairEvaluationsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairEvaluationsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EvaluationsEvaluationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EvaluationsEvaluationsChildPopulateColumnParameters.FieldName = "EvaluationsEvaluations";
            EvaluationsEvaluationsChildPopulateColumnParameters.Path = "Evaluations.Num_STG";
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(EvaluationsEvaluationsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formation1EvaluationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formation1EvaluationsChildPopulateColumnParameters.FieldName = "Mode_formation1Evaluations";
            Mode_formation1EvaluationsChildPopulateColumnParameters.Path = "Mode_formation1.Code_Mode_Formation";
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formation1EvaluationsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PARTICIPEsEvaluationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PARTICIPEsEvaluationsChildPopulateColumnParameters.FieldName = "PARTICIPEsEvaluations";
            PARTICIPEsEvaluationsChildPopulateColumnParameters.Path = "PARTICIPEs.Qualite";
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(PARTICIPEsEvaluationsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Suiver_stagiaireEvaluationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Suiver_stagiaireEvaluationsChildPopulateColumnParameters.FieldName = "Suiver_stagiaireEvaluations";
            Suiver_stagiaireEvaluationsChildPopulateColumnParameters.Path = "Suiver_stagiaire.num_stg";
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(Suiver_stagiaireEvaluationsChildPopulateColumnParameters);
			 
		    this.EvaluationsGridView.PopulateColumns(typeof(gtsco2.basededonne.Evaluation),EvaluationsPopulateColumnsParameters);
			//
			//EvaluationsBindingSource
			//
			System.Windows.Forms.BindingSource EvaluationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			EvaluationsBindingSource.DataSource = typeof(gtsco2.basededonne.Evaluation);
            this.EvaluationsGridControl.DataSource = EvaluationsBindingSource;
			//
			//EvaluationsXtraUserControl
			//
            this.EvaluationsXtraUserControl.Controls.Add(EvaluationsGridControl);
			this.EvaluationsXtraUserControl.Name = "EvaluationsXtraUserControl";
			this.EvaluationsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//EvaluationsNew
			//
			this.bbiEvaluationsNew.Caption = "New";
			this.bbiEvaluationsNew.Name = "bbiEvaluationsNew";
			this.bbiEvaluationsNew.ImageUri.Uri = "New";
			this.bbiEvaluationsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EvaluationsBarManager.Items.Add(this.bbiEvaluationsNew);
			this.EvaluationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsNew));
			this.EvaluationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsNew));
						//
			//EvaluationsEdit
			//
			this.bbiEvaluationsEdit.Caption = "Edit";
			this.bbiEvaluationsEdit.Name = "bbiEvaluationsEdit";
			this.bbiEvaluationsEdit.ImageUri.Uri = "Edit";
			this.bbiEvaluationsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EvaluationsBarManager.Items.Add(this.bbiEvaluationsEdit);
			this.EvaluationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsEdit));
			this.EvaluationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsEdit));
						//
			//EvaluationsDelete
			//
			this.bbiEvaluationsDelete.Caption = "Delete";
			this.bbiEvaluationsDelete.Name = "bbiEvaluationsDelete";
			this.bbiEvaluationsDelete.ImageUri.Uri = "Delete";
			this.bbiEvaluationsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EvaluationsBarManager.Items.Add(this.bbiEvaluationsDelete);
			this.EvaluationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsDelete));
			this.EvaluationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsDelete));
						//
			//EvaluationsRefresh
			//
			this.bbiEvaluationsRefresh.Caption = "Refresh";
			this.bbiEvaluationsRefresh.Name = "bbiEvaluationsRefresh";
			this.bbiEvaluationsRefresh.ImageUri.Uri = "Refresh";
			this.bbiEvaluationsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EvaluationsBarManager.Items.Add(this.bbiEvaluationsRefresh);
			this.EvaluationsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsRefresh));
			this.EvaluationsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEvaluationsRefresh));
						//
			//EvaluationsBar
			//
			this.EvaluationsBar.BarName = "Evaluations";
            this.EvaluationsBar.DockCol = 0;
            this.EvaluationsBar.DockRow = 0;
            this.EvaluationsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.EvaluationsBar.OptionsBar.AllowQuickCustomization = false;
            this.EvaluationsBar.OptionsBar.DrawDragBorder = false;
            this.EvaluationsBar.Text = "Evaluations";
			//
			//EvaluationsBarManager
			//
			this.EvaluationsBarManager.AllowCustomization = false;
            this.EvaluationsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.EvaluationsBar});
            this.EvaluationsBarManager.Form = EvaluationsXtraUserControl;
            this.EvaluationsBarManager.MainMenu = this.EvaluationsBar;
			// 
            // EvaluationsPopUpMenu
            // 
            this.EvaluationsPopUpMenu.Manager = this.EvaluationsBarManager;
            this.EvaluationsPopUpMenu.Name = "EvaluationsPopUpMenu";
			//
			//EvaluationsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters EvaluationsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            EvaluationsRetriveFieldParameters.FieldName = "Evaluations";
            EvaluationsRetriveFieldParameters.ControlForField = EvaluationsXtraUserControl;
			EvaluationsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(EvaluationsRetriveFieldParameters);
						//
			//PARTICIPEsGridControl
			//
			this.PARTICIPEsGridControl.MainView = this.PARTICIPEsGridView;
			this.PARTICIPEsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PARTICIPEsGridControl.MenuManager = this.mainRibbonControl;
            this.PARTICIPEsGridControl.Name = "PARTICIPEsGridControl";
            this.PARTICIPEsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PARTICIPEsGridView});
			//
			//PARTICIPEsGridView
			//
            this.PARTICIPEsGridView.GridControl = this.PARTICIPEsGridControl;
            this.PARTICIPEsGridView.Name = "PARTICIPEsGridView";
            this.PARTICIPEsGridView.OptionsBehavior.Editable = false;
            this.PARTICIPEsGridView.OptionsBehavior.ReadOnly = true;
			//
			//PARTICIPEsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters PARTICIPEsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EnseignantPARTICIPEsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EnseignantPARTICIPEsChildPopulateColumnParameters_NotVisible.FieldName = "Enseignant";
		    EnseignantPARTICIPEsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(EnseignantPARTICIPEsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Proce_verbal_delibationPARTICIPEsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Proce_verbal_delibationPARTICIPEsChildPopulateColumnParameters_NotVisible.FieldName = "Proce_verbal_delibation";
		    Proce_verbal_delibationPARTICIPEsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(Proce_verbal_delibationPARTICIPEsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EvaluationsPARTICIPEsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EvaluationsPARTICIPEsChildPopulateColumnParameters.FieldName = "EvaluationsPARTICIPEs";
            EvaluationsPARTICIPEsChildPopulateColumnParameters.Path = "Evaluations.Num_STG";
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(EvaluationsPARTICIPEsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formation1PARTICIPEsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formation1PARTICIPEsChildPopulateColumnParameters.FieldName = "Mode_formation1PARTICIPEs";
            Mode_formation1PARTICIPEsChildPopulateColumnParameters.Path = "Mode_formation1.Code_Mode_Formation";
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formation1PARTICIPEsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PARTICIPEsPARTICIPEsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PARTICIPEsPARTICIPEsChildPopulateColumnParameters.FieldName = "PARTICIPEsPARTICIPEs";
            PARTICIPEsPARTICIPEsChildPopulateColumnParameters.Path = "PARTICIPEs.Qualite";
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(PARTICIPEsPARTICIPEsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Suiver_stagiairePARTICIPEsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Suiver_stagiairePARTICIPEsChildPopulateColumnParameters.FieldName = "Suiver_stagiairePARTICIPEs";
            Suiver_stagiairePARTICIPEsChildPopulateColumnParameters.Path = "Suiver_stagiaire.num_stg";
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(Suiver_stagiairePARTICIPEsChildPopulateColumnParameters);
			 
		    this.PARTICIPEsGridView.PopulateColumns(typeof(gtsco2.basededonne.PARTICIPE),PARTICIPEsPopulateColumnsParameters);
			//
			//PARTICIPEsBindingSource
			//
			System.Windows.Forms.BindingSource PARTICIPEsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			PARTICIPEsBindingSource.DataSource = typeof(gtsco2.basededonne.PARTICIPE);
            this.PARTICIPEsGridControl.DataSource = PARTICIPEsBindingSource;
			//
			//PARTICIPEsXtraUserControl
			//
            this.PARTICIPEsXtraUserControl.Controls.Add(PARTICIPEsGridControl);
			this.PARTICIPEsXtraUserControl.Name = "PARTICIPEsXtraUserControl";
			this.PARTICIPEsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//PARTICIPEsNew
			//
			this.bbiPARTICIPEsNew.Caption = "New";
			this.bbiPARTICIPEsNew.Name = "bbiPARTICIPEsNew";
			this.bbiPARTICIPEsNew.ImageUri.Uri = "New";
			this.bbiPARTICIPEsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PARTICIPEsBarManager.Items.Add(this.bbiPARTICIPEsNew);
			this.PARTICIPEsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsNew));
			this.PARTICIPEsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsNew));
						//
			//PARTICIPEsEdit
			//
			this.bbiPARTICIPEsEdit.Caption = "Edit";
			this.bbiPARTICIPEsEdit.Name = "bbiPARTICIPEsEdit";
			this.bbiPARTICIPEsEdit.ImageUri.Uri = "Edit";
			this.bbiPARTICIPEsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PARTICIPEsBarManager.Items.Add(this.bbiPARTICIPEsEdit);
			this.PARTICIPEsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsEdit));
			this.PARTICIPEsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsEdit));
						//
			//PARTICIPEsDelete
			//
			this.bbiPARTICIPEsDelete.Caption = "Delete";
			this.bbiPARTICIPEsDelete.Name = "bbiPARTICIPEsDelete";
			this.bbiPARTICIPEsDelete.ImageUri.Uri = "Delete";
			this.bbiPARTICIPEsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PARTICIPEsBarManager.Items.Add(this.bbiPARTICIPEsDelete);
			this.PARTICIPEsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsDelete));
			this.PARTICIPEsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsDelete));
						//
			//PARTICIPEsRefresh
			//
			this.bbiPARTICIPEsRefresh.Caption = "Refresh";
			this.bbiPARTICIPEsRefresh.Name = "bbiPARTICIPEsRefresh";
			this.bbiPARTICIPEsRefresh.ImageUri.Uri = "Refresh";
			this.bbiPARTICIPEsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PARTICIPEsBarManager.Items.Add(this.bbiPARTICIPEsRefresh);
			this.PARTICIPEsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsRefresh));
			this.PARTICIPEsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPARTICIPEsRefresh));
						//
			//PARTICIPEsBar
			//
			this.PARTICIPEsBar.BarName = "PARTICIPEs";
            this.PARTICIPEsBar.DockCol = 0;
            this.PARTICIPEsBar.DockRow = 0;
            this.PARTICIPEsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.PARTICIPEsBar.OptionsBar.AllowQuickCustomization = false;
            this.PARTICIPEsBar.OptionsBar.DrawDragBorder = false;
            this.PARTICIPEsBar.Text = "PARTICIPEs";
			//
			//PARTICIPEsBarManager
			//
			this.PARTICIPEsBarManager.AllowCustomization = false;
            this.PARTICIPEsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.PARTICIPEsBar});
            this.PARTICIPEsBarManager.Form = PARTICIPEsXtraUserControl;
            this.PARTICIPEsBarManager.MainMenu = this.PARTICIPEsBar;
			// 
            // PARTICIPEsPopUpMenu
            // 
            this.PARTICIPEsPopUpMenu.Manager = this.PARTICIPEsBarManager;
            this.PARTICIPEsPopUpMenu.Name = "PARTICIPEsPopUpMenu";
			//
			//PARTICIPEsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters PARTICIPEsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PARTICIPEsRetriveFieldParameters.FieldName = "PARTICIPEs";
            PARTICIPEsRetriveFieldParameters.ControlForField = PARTICIPEsXtraUserControl;
			PARTICIPEsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(PARTICIPEsRetriveFieldParameters);
						//
			//Suiver_stagiaireGridControl
			//
			this.Suiver_stagiaireGridControl.MainView = this.Suiver_stagiaireGridView;
			this.Suiver_stagiaireGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Suiver_stagiaireGridControl.MenuManager = this.mainRibbonControl;
            this.Suiver_stagiaireGridControl.Name = "Suiver_stagiaireGridControl";
            this.Suiver_stagiaireGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Suiver_stagiaireGridView});
			//
			//Suiver_stagiaireGridView
			//
            this.Suiver_stagiaireGridView.GridControl = this.Suiver_stagiaireGridControl;
            this.Suiver_stagiaireGridView.Name = "Suiver_stagiaireGridView";
            this.Suiver_stagiaireGridView.OptionsBehavior.Editable = false;
            this.Suiver_stagiaireGridView.OptionsBehavior.ReadOnly = true;
			//
			//Suiver_stagiairePopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Suiver_stagiairePopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Enseignant1Suiver_stagiaireChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Enseignant1Suiver_stagiaireChildPopulateColumnParameters_NotVisible.FieldName = "Enseignant1";
		    Enseignant1Suiver_stagiaireChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Suiver_stagiairePopulateColumnsParameters.CustomColumnParameters.Add(Enseignant1Suiver_stagiaireChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Semestre1Suiver_stagiaireChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Semestre1Suiver_stagiaireChildPopulateColumnParameters_NotVisible.FieldName = "Semestre1";
		    Semestre1Suiver_stagiaireChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Suiver_stagiairePopulateColumnsParameters.CustomColumnParameters.Add(Semestre1Suiver_stagiaireChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairSuiver_stagiaireChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairSuiver_stagiaireChildPopulateColumnParameters_NotVisible.FieldName = "Stagiair";
		    StagiairSuiver_stagiaireChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Suiver_stagiairePopulateColumnsParameters.CustomColumnParameters.Add(StagiairSuiver_stagiaireChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EvaluationsSuiver_stagiaireChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EvaluationsSuiver_stagiaireChildPopulateColumnParameters.FieldName = "EvaluationsSuiver_stagiaire";
            EvaluationsSuiver_stagiaireChildPopulateColumnParameters.Path = "Evaluations.Num_STG";
			Suiver_stagiairePopulateColumnsParameters.CustomColumnParameters.Add(EvaluationsSuiver_stagiaireChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formation1Suiver_stagiaireChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formation1Suiver_stagiaireChildPopulateColumnParameters.FieldName = "Mode_formation1Suiver_stagiaire";
            Mode_formation1Suiver_stagiaireChildPopulateColumnParameters.Path = "Mode_formation1.Code_Mode_Formation";
			Suiver_stagiairePopulateColumnsParameters.CustomColumnParameters.Add(Mode_formation1Suiver_stagiaireChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PARTICIPEsSuiver_stagiaireChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PARTICIPEsSuiver_stagiaireChildPopulateColumnParameters.FieldName = "PARTICIPEsSuiver_stagiaire";
            PARTICIPEsSuiver_stagiaireChildPopulateColumnParameters.Path = "PARTICIPEs.Qualite";
			Suiver_stagiairePopulateColumnsParameters.CustomColumnParameters.Add(PARTICIPEsSuiver_stagiaireChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Suiver_stagiaireSuiver_stagiaireChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Suiver_stagiaireSuiver_stagiaireChildPopulateColumnParameters.FieldName = "Suiver_stagiaireSuiver_stagiaire";
            Suiver_stagiaireSuiver_stagiaireChildPopulateColumnParameters.Path = "Suiver_stagiaire.num_stg";
			Suiver_stagiairePopulateColumnsParameters.CustomColumnParameters.Add(Suiver_stagiaireSuiver_stagiaireChildPopulateColumnParameters);
			 
		    this.Suiver_stagiaireGridView.PopulateColumns(typeof(gtsco2.basededonne.Suiver_stagiaire),Suiver_stagiairePopulateColumnsParameters);
			//
			//Suiver_stagiaireBindingSource
			//
			System.Windows.Forms.BindingSource Suiver_stagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
			Suiver_stagiaireBindingSource.DataSource = typeof(gtsco2.basededonne.Suiver_stagiaire);
            this.Suiver_stagiaireGridControl.DataSource = Suiver_stagiaireBindingSource;
			//
			//Suiver_stagiaireXtraUserControl
			//
            this.Suiver_stagiaireXtraUserControl.Controls.Add(Suiver_stagiaireGridControl);
			this.Suiver_stagiaireXtraUserControl.Name = "Suiver_stagiaireXtraUserControl";
			this.Suiver_stagiaireXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Suiver_stagiaireNew
			//
			this.bbiSuiver_stagiaireNew.Caption = "New";
			this.bbiSuiver_stagiaireNew.Name = "bbiSuiver_stagiaireNew";
			this.bbiSuiver_stagiaireNew.ImageUri.Uri = "New";
			this.bbiSuiver_stagiaireNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Suiver_stagiaireBarManager.Items.Add(this.bbiSuiver_stagiaireNew);
			this.Suiver_stagiaireBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireNew));
			this.Suiver_stagiairePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireNew));
						//
			//Suiver_stagiaireEdit
			//
			this.bbiSuiver_stagiaireEdit.Caption = "Edit";
			this.bbiSuiver_stagiaireEdit.Name = "bbiSuiver_stagiaireEdit";
			this.bbiSuiver_stagiaireEdit.ImageUri.Uri = "Edit";
			this.bbiSuiver_stagiaireEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Suiver_stagiaireBarManager.Items.Add(this.bbiSuiver_stagiaireEdit);
			this.Suiver_stagiaireBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireEdit));
			this.Suiver_stagiairePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireEdit));
						//
			//Suiver_stagiaireDelete
			//
			this.bbiSuiver_stagiaireDelete.Caption = "Delete";
			this.bbiSuiver_stagiaireDelete.Name = "bbiSuiver_stagiaireDelete";
			this.bbiSuiver_stagiaireDelete.ImageUri.Uri = "Delete";
			this.bbiSuiver_stagiaireDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Suiver_stagiaireBarManager.Items.Add(this.bbiSuiver_stagiaireDelete);
			this.Suiver_stagiaireBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireDelete));
			this.Suiver_stagiairePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireDelete));
						//
			//Suiver_stagiaireRefresh
			//
			this.bbiSuiver_stagiaireRefresh.Caption = "Refresh";
			this.bbiSuiver_stagiaireRefresh.Name = "bbiSuiver_stagiaireRefresh";
			this.bbiSuiver_stagiaireRefresh.ImageUri.Uri = "Refresh";
			this.bbiSuiver_stagiaireRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Suiver_stagiaireBarManager.Items.Add(this.bbiSuiver_stagiaireRefresh);
			this.Suiver_stagiaireBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireRefresh));
			this.Suiver_stagiairePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuiver_stagiaireRefresh));
						//
			//Suiver_stagiaireBar
			//
			this.Suiver_stagiaireBar.BarName = "Suiver_stagiaire";
            this.Suiver_stagiaireBar.DockCol = 0;
            this.Suiver_stagiaireBar.DockRow = 0;
            this.Suiver_stagiaireBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Suiver_stagiaireBar.OptionsBar.AllowQuickCustomization = false;
            this.Suiver_stagiaireBar.OptionsBar.DrawDragBorder = false;
            this.Suiver_stagiaireBar.Text = "Suiver_stagiaire";
			//
			//Suiver_stagiaireBarManager
			//
			this.Suiver_stagiaireBarManager.AllowCustomization = false;
            this.Suiver_stagiaireBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Suiver_stagiaireBar});
            this.Suiver_stagiaireBarManager.Form = Suiver_stagiaireXtraUserControl;
            this.Suiver_stagiaireBarManager.MainMenu = this.Suiver_stagiaireBar;
			// 
            // Suiver_stagiairePopUpMenu
            // 
            this.Suiver_stagiairePopUpMenu.Manager = this.Suiver_stagiaireBarManager;
            this.Suiver_stagiairePopUpMenu.Name = "Suiver_stagiairePopUpMenu";
			//
			//Suiver_stagiaireRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Suiver_stagiaireRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Suiver_stagiaireRetriveFieldParameters.FieldName = "Suiver_stagiaire";
            Suiver_stagiaireRetriveFieldParameters.ControlForField = Suiver_stagiaireXtraUserControl;
			Suiver_stagiaireRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Suiver_stagiaireRetriveFieldParameters);
									//
			//Mode_formation1LookUpEdit
			//
			this.Mode_formation1BindingSource.DataSource = typeof(gtsco2.basededonne.Mode_formation);
			this.Mode_formation1LookUpEdit.Properties.ValueMember = "ID_Mode_Formation"; 
			this.Mode_formation1LookUpEdit.Properties.DisplayMember = "Code_Mode_Formation";
			this.Mode_formation1LookUpEdit.Properties.DataSource = this.Mode_formation1BindingSource;
			this.Mode_formation1LookUpEdit.Name = "Mode_formation1LookUpEdit";
			this.Mode_formation1LookUpEdit.DataBindings.Add("EditValue", enseignantViewBindingSource, "Mode_Formation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Mode_formation1LookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Mode_formation1LookUpEditRetrieveFieldParameters.FieldName = "Mode_Formation";
            Mode_formation1LookUpEditRetrieveFieldParameters.ControlForField = this.Mode_formation1LookUpEdit;
			parameters.CustomListParameters.Add(Mode_formation1LookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Mode_formation1LookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    Mode_formation1LookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Mode_formation1";
		    Mode_formation1LookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(Mode_formation1LookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EnseignantViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//EnseignantView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "EnseignantView";
						((System.ComponentModel.ISupportInitialize)(this.EvaluationsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.PARTICIPEsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.Suiver_stagiaireBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource enseignantViewBindingSource;
				private DevExpress.XtraGrid.GridControl EvaluationsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView EvaluationsGridView;
		private DevExpress.XtraBars.BarManager EvaluationsBarManager;
		private DevExpress.XtraBars.Bar EvaluationsBar;
		private DevExpress.XtraEditors.XtraUserControl EvaluationsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu EvaluationsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiEvaluationsNew;
				private DevExpress.XtraBars.BarButtonItem bbiEvaluationsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiEvaluationsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiEvaluationsRefresh;
						private DevExpress.XtraGrid.GridControl PARTICIPEsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView PARTICIPEsGridView;
		private DevExpress.XtraBars.BarManager PARTICIPEsBarManager;
		private DevExpress.XtraBars.Bar PARTICIPEsBar;
		private DevExpress.XtraEditors.XtraUserControl PARTICIPEsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu PARTICIPEsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiPARTICIPEsNew;
				private DevExpress.XtraBars.BarButtonItem bbiPARTICIPEsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiPARTICIPEsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiPARTICIPEsRefresh;
						private DevExpress.XtraGrid.GridControl Suiver_stagiaireGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Suiver_stagiaireGridView;
		private DevExpress.XtraBars.BarManager Suiver_stagiaireBarManager;
		private DevExpress.XtraBars.Bar Suiver_stagiaireBar;
		private DevExpress.XtraEditors.XtraUserControl Suiver_stagiaireXtraUserControl;
		private DevExpress.XtraBars.PopupMenu Suiver_stagiairePopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiSuiver_stagiaireNew;
				private DevExpress.XtraBars.BarButtonItem bbiSuiver_stagiaireEdit;
				private DevExpress.XtraBars.BarButtonItem bbiSuiver_stagiaireDelete;
				private DevExpress.XtraBars.BarButtonItem bbiSuiver_stagiaireRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit Mode_formation1LookUpEdit;
		private System.Windows.Forms.BindingSource Mode_formation1BindingSource;
		 
	}
}
