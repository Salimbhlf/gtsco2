namespace gtsco2.mvvm.Views.Mode_formationView {
    partial class Mode_formationView {
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
						this.EnseignantsGridControl = new DevExpress.XtraGrid.GridControl();
			this.EnseignantsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.EnseignantsBarManager = new DevExpress.XtraBars.BarManager();
			this.EnseignantsBar = new DevExpress.XtraBars.Bar();
			this.EnseignantsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.EnseignantsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiEnseignantsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEnseignantsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEnseignantsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiEnseignantsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.EnseignantsBarManager)).BeginInit();
						this.PromoesGridControl = new DevExpress.XtraGrid.GridControl();
			this.PromoesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.PromoesBarManager = new DevExpress.XtraBars.BarManager();
			this.PromoesBar = new DevExpress.XtraBars.Bar();
			this.PromoesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.PromoesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiPromoesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPromoesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPromoesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiPromoesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.PromoesBarManager)).BeginInit();
						this.SectionsGridControl = new DevExpress.XtraGrid.GridControl();
			this.SectionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.SectionsBarManager = new DevExpress.XtraBars.BarManager();
			this.SectionsBar = new DevExpress.XtraBars.Bar();
			this.SectionsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.SectionsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiSectionsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSectionsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSectionsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSectionsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.SectionsBarManager)).BeginInit();
						 
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
            this.mainRibbonPageGroup.Text = "Mode_formation Tasks";
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
			this.mode_formationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mode_formationViewBindingSource.DataSource = typeof(gtsco2.basededonne.Mode_formation);
			this.dataLayoutControl1.DataSource = mode_formationViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//EnseignantsGridControl
			//
			this.EnseignantsGridControl.MainView = this.EnseignantsGridView;
			this.EnseignantsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnseignantsGridControl.MenuManager = this.mainRibbonControl;
            this.EnseignantsGridControl.Name = "EnseignantsGridControl";
            this.EnseignantsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EnseignantsGridView});
			//
			//EnseignantsGridView
			//
            this.EnseignantsGridView.GridControl = this.EnseignantsGridControl;
            this.EnseignantsGridView.Name = "EnseignantsGridView";
            this.EnseignantsGridView.OptionsBehavior.Editable = false;
            this.EnseignantsGridView.OptionsBehavior.ReadOnly = true;
			//
			//EnseignantsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters EnseignantsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formation1EnseignantsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formation1EnseignantsChildPopulateColumnParameters_NotVisible.FieldName = "Mode_formation1";
		    Mode_formation1EnseignantsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EnseignantsPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formation1EnseignantsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EvaluationsEnseignantsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EvaluationsEnseignantsChildPopulateColumnParameters_NotVisible.FieldName = "Evaluations";
		    EvaluationsEnseignantsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EnseignantsPopulateColumnsParameters.CustomColumnParameters.Add(EvaluationsEnseignantsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Suiver_stagiaireEnseignantsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Suiver_stagiaireEnseignantsChildPopulateColumnParameters_NotVisible.FieldName = "Suiver_stagiaire";
		    Suiver_stagiaireEnseignantsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EnseignantsPopulateColumnsParameters.CustomColumnParameters.Add(Suiver_stagiaireEnseignantsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PARTICIPEsEnseignantsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PARTICIPEsEnseignantsChildPopulateColumnParameters_NotVisible.FieldName = "PARTICIPEs";
		    PARTICIPEsEnseignantsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			EnseignantsPopulateColumnsParameters.CustomColumnParameters.Add(PARTICIPEsEnseignantsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EnseignantsEnseignantsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EnseignantsEnseignantsChildPopulateColumnParameters.FieldName = "EnseignantsEnseignants";
            EnseignantsEnseignantsChildPopulateColumnParameters.Path = "Enseignants.Nom";
			EnseignantsPopulateColumnsParameters.CustomColumnParameters.Add(EnseignantsEnseignantsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoesEnseignantsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoesEnseignantsChildPopulateColumnParameters.FieldName = "PromoesEnseignants";
            PromoesEnseignantsChildPopulateColumnParameters.Path = "Promoes.Code_Promo";
			EnseignantsPopulateColumnsParameters.CustomColumnParameters.Add(PromoesEnseignantsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsEnseignantsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsEnseignantsChildPopulateColumnParameters.FieldName = "SectionsEnseignants";
            SectionsEnseignantsChildPopulateColumnParameters.Path = "Sections.Code_Section";
			EnseignantsPopulateColumnsParameters.CustomColumnParameters.Add(SectionsEnseignantsChildPopulateColumnParameters);
			 
		    this.EnseignantsGridView.PopulateColumns(typeof(gtsco2.basededonne.Enseignant),EnseignantsPopulateColumnsParameters);
			//
			//EnseignantsBindingSource
			//
			System.Windows.Forms.BindingSource EnseignantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			EnseignantsBindingSource.DataSource = typeof(gtsco2.basededonne.Enseignant);
            this.EnseignantsGridControl.DataSource = EnseignantsBindingSource;
			//
			//EnseignantsXtraUserControl
			//
            this.EnseignantsXtraUserControl.Controls.Add(EnseignantsGridControl);
			this.EnseignantsXtraUserControl.Name = "EnseignantsXtraUserControl";
			this.EnseignantsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//EnseignantsNew
			//
			this.bbiEnseignantsNew.Caption = "New";
			this.bbiEnseignantsNew.Name = "bbiEnseignantsNew";
			this.bbiEnseignantsNew.ImageUri.Uri = "New";
			this.bbiEnseignantsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EnseignantsBarManager.Items.Add(this.bbiEnseignantsNew);
			this.EnseignantsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsNew));
			this.EnseignantsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsNew));
						//
			//EnseignantsEdit
			//
			this.bbiEnseignantsEdit.Caption = "Edit";
			this.bbiEnseignantsEdit.Name = "bbiEnseignantsEdit";
			this.bbiEnseignantsEdit.ImageUri.Uri = "Edit";
			this.bbiEnseignantsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EnseignantsBarManager.Items.Add(this.bbiEnseignantsEdit);
			this.EnseignantsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsEdit));
			this.EnseignantsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsEdit));
						//
			//EnseignantsDelete
			//
			this.bbiEnseignantsDelete.Caption = "Delete";
			this.bbiEnseignantsDelete.Name = "bbiEnseignantsDelete";
			this.bbiEnseignantsDelete.ImageUri.Uri = "Delete";
			this.bbiEnseignantsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EnseignantsBarManager.Items.Add(this.bbiEnseignantsDelete);
			this.EnseignantsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsDelete));
			this.EnseignantsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsDelete));
						//
			//EnseignantsRefresh
			//
			this.bbiEnseignantsRefresh.Caption = "Refresh";
			this.bbiEnseignantsRefresh.Name = "bbiEnseignantsRefresh";
			this.bbiEnseignantsRefresh.ImageUri.Uri = "Refresh";
			this.bbiEnseignantsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.EnseignantsBarManager.Items.Add(this.bbiEnseignantsRefresh);
			this.EnseignantsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsRefresh));
			this.EnseignantsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnseignantsRefresh));
						//
			//EnseignantsBar
			//
			this.EnseignantsBar.BarName = "Enseignants";
            this.EnseignantsBar.DockCol = 0;
            this.EnseignantsBar.DockRow = 0;
            this.EnseignantsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.EnseignantsBar.OptionsBar.AllowQuickCustomization = false;
            this.EnseignantsBar.OptionsBar.DrawDragBorder = false;
            this.EnseignantsBar.Text = "Enseignants";
			//
			//EnseignantsBarManager
			//
			this.EnseignantsBarManager.AllowCustomization = false;
            this.EnseignantsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.EnseignantsBar});
            this.EnseignantsBarManager.Form = EnseignantsXtraUserControl;
            this.EnseignantsBarManager.MainMenu = this.EnseignantsBar;
			// 
            // EnseignantsPopUpMenu
            // 
            this.EnseignantsPopUpMenu.Manager = this.EnseignantsBarManager;
            this.EnseignantsPopUpMenu.Name = "EnseignantsPopUpMenu";
			//
			//EnseignantsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters EnseignantsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            EnseignantsRetriveFieldParameters.FieldName = "Enseignants";
            EnseignantsRetriveFieldParameters.ControlForField = EnseignantsXtraUserControl;
			EnseignantsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(EnseignantsRetriveFieldParameters);
						//
			//PromoesGridControl
			//
			this.PromoesGridControl.MainView = this.PromoesGridView;
			this.PromoesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromoesGridControl.MenuManager = this.mainRibbonControl;
            this.PromoesGridControl.Name = "PromoesGridControl";
            this.PromoesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PromoesGridView});
			//
			//PromoesGridView
			//
            this.PromoesGridView.GridControl = this.PromoesGridControl;
            this.PromoesGridView.Name = "PromoesGridView";
            this.PromoesGridView.OptionsBehavior.Editable = false;
            this.PromoesGridView.OptionsBehavior.ReadOnly = true;
			//
			//PromoesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters PromoesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DecisionsPromoesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DecisionsPromoesChildPopulateColumnParameters_NotVisible.FieldName = "Decisions";
		    DecisionsPromoesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(DecisionsPromoesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formationPromoesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formationPromoesChildPopulateColumnParameters_NotVisible.FieldName = "Mode_formation";
		    Mode_formationPromoesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formationPromoesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionPromoesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionPromoesChildPopulateColumnParameters_NotVisible.FieldName = "Option";
		    OptionPromoesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(OptionPromoesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsPromoesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsPromoesChildPopulateColumnParameters_NotVisible.FieldName = "Sections";
		    SectionsPromoesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(SectionsPromoesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsPromoesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsPromoesChildPopulateColumnParameters_NotVisible.FieldName = "Stagiairs";
		    StagiairsPromoesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsPromoesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EnseignantsPromoesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EnseignantsPromoesChildPopulateColumnParameters.FieldName = "EnseignantsPromoes";
            EnseignantsPromoesChildPopulateColumnParameters.Path = "Enseignants.Nom";
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(EnseignantsPromoesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoesPromoesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoesPromoesChildPopulateColumnParameters.FieldName = "PromoesPromoes";
            PromoesPromoesChildPopulateColumnParameters.Path = "Promoes.Code_Promo";
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(PromoesPromoesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsPromoesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsPromoesChildPopulateColumnParameters.FieldName = "SectionsPromoes";
            SectionsPromoesChildPopulateColumnParameters.Path = "Sections.Code_Section";
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(SectionsPromoesChildPopulateColumnParameters);
			 
		    this.PromoesGridView.PopulateColumns(typeof(gtsco2.basededonne.Promo),PromoesPopulateColumnsParameters);
			//
			//PromoesBindingSource
			//
			System.Windows.Forms.BindingSource PromoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			PromoesBindingSource.DataSource = typeof(gtsco2.basededonne.Promo);
            this.PromoesGridControl.DataSource = PromoesBindingSource;
			//
			//PromoesXtraUserControl
			//
            this.PromoesXtraUserControl.Controls.Add(PromoesGridControl);
			this.PromoesXtraUserControl.Name = "PromoesXtraUserControl";
			this.PromoesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//PromoesNew
			//
			this.bbiPromoesNew.Caption = "New";
			this.bbiPromoesNew.Name = "bbiPromoesNew";
			this.bbiPromoesNew.ImageUri.Uri = "New";
			this.bbiPromoesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PromoesBarManager.Items.Add(this.bbiPromoesNew);
			this.PromoesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesNew));
			this.PromoesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesNew));
						//
			//PromoesEdit
			//
			this.bbiPromoesEdit.Caption = "Edit";
			this.bbiPromoesEdit.Name = "bbiPromoesEdit";
			this.bbiPromoesEdit.ImageUri.Uri = "Edit";
			this.bbiPromoesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PromoesBarManager.Items.Add(this.bbiPromoesEdit);
			this.PromoesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesEdit));
			this.PromoesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesEdit));
						//
			//PromoesDelete
			//
			this.bbiPromoesDelete.Caption = "Delete";
			this.bbiPromoesDelete.Name = "bbiPromoesDelete";
			this.bbiPromoesDelete.ImageUri.Uri = "Delete";
			this.bbiPromoesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PromoesBarManager.Items.Add(this.bbiPromoesDelete);
			this.PromoesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesDelete));
			this.PromoesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesDelete));
						//
			//PromoesRefresh
			//
			this.bbiPromoesRefresh.Caption = "Refresh";
			this.bbiPromoesRefresh.Name = "bbiPromoesRefresh";
			this.bbiPromoesRefresh.ImageUri.Uri = "Refresh";
			this.bbiPromoesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.PromoesBarManager.Items.Add(this.bbiPromoesRefresh);
			this.PromoesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesRefresh));
			this.PromoesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiPromoesRefresh));
						//
			//PromoesBar
			//
			this.PromoesBar.BarName = "Promoes";
            this.PromoesBar.DockCol = 0;
            this.PromoesBar.DockRow = 0;
            this.PromoesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.PromoesBar.OptionsBar.AllowQuickCustomization = false;
            this.PromoesBar.OptionsBar.DrawDragBorder = false;
            this.PromoesBar.Text = "Promoes";
			//
			//PromoesBarManager
			//
			this.PromoesBarManager.AllowCustomization = false;
            this.PromoesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.PromoesBar});
            this.PromoesBarManager.Form = PromoesXtraUserControl;
            this.PromoesBarManager.MainMenu = this.PromoesBar;
			// 
            // PromoesPopUpMenu
            // 
            this.PromoesPopUpMenu.Manager = this.PromoesBarManager;
            this.PromoesPopUpMenu.Name = "PromoesPopUpMenu";
			//
			//PromoesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters PromoesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PromoesRetriveFieldParameters.FieldName = "Promoes";
            PromoesRetriveFieldParameters.ControlForField = PromoesXtraUserControl;
			PromoesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(PromoesRetriveFieldParameters);
						//
			//SectionsGridControl
			//
			this.SectionsGridControl.MainView = this.SectionsGridView;
			this.SectionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionsGridControl.MenuManager = this.mainRibbonControl;
            this.SectionsGridControl.Name = "SectionsGridControl";
            this.SectionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SectionsGridView});
			//
			//SectionsGridView
			//
            this.SectionsGridView.GridControl = this.SectionsGridControl;
            this.SectionsGridView.Name = "SectionsGridView";
            this.SectionsGridView.OptionsBehavior.Editable = false;
            this.SectionsGridView.OptionsBehavior.ReadOnly = true;
			//
			//SectionsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters SectionsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formationSectionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formationSectionsChildPopulateColumnParameters_NotVisible.FieldName = "Mode_formation";
		    Mode_formationSectionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formationSectionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionSectionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionSectionsChildPopulateColumnParameters_NotVisible.FieldName = "Option";
		    OptionSectionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(OptionSectionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoSectionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoSectionsChildPopulateColumnParameters_NotVisible.FieldName = "Promo";
		    PromoSectionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(PromoSectionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsSectionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsSectionsChildPopulateColumnParameters_NotVisible.FieldName = "Stagiairs";
		    StagiairsSectionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsSectionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SemestreSectionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SemestreSectionsChildPopulateColumnParameters_NotVisible.FieldName = "Semestre";
		    SemestreSectionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(SemestreSectionsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EnseignantsSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EnseignantsSectionsChildPopulateColumnParameters.FieldName = "EnseignantsSections";
            EnseignantsSectionsChildPopulateColumnParameters.Path = "Enseignants.Nom";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(EnseignantsSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoesSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoesSectionsChildPopulateColumnParameters.FieldName = "PromoesSections";
            PromoesSectionsChildPopulateColumnParameters.Path = "Promoes.Code_Promo";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(PromoesSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsSectionsChildPopulateColumnParameters.FieldName = "SectionsSections";
            SectionsSectionsChildPopulateColumnParameters.Path = "Sections.Code_Section";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(SectionsSectionsChildPopulateColumnParameters);
			 
		    this.SectionsGridView.PopulateColumns(typeof(gtsco2.basededonne.Section),SectionsPopulateColumnsParameters);
			//
			//SectionsBindingSource
			//
			System.Windows.Forms.BindingSource SectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			SectionsBindingSource.DataSource = typeof(gtsco2.basededonne.Section);
            this.SectionsGridControl.DataSource = SectionsBindingSource;
			//
			//SectionsXtraUserControl
			//
            this.SectionsXtraUserControl.Controls.Add(SectionsGridControl);
			this.SectionsXtraUserControl.Name = "SectionsXtraUserControl";
			this.SectionsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//SectionsNew
			//
			this.bbiSectionsNew.Caption = "New";
			this.bbiSectionsNew.Name = "bbiSectionsNew";
			this.bbiSectionsNew.ImageUri.Uri = "New";
			this.bbiSectionsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SectionsBarManager.Items.Add(this.bbiSectionsNew);
			this.SectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsNew));
			this.SectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsNew));
						//
			//SectionsEdit
			//
			this.bbiSectionsEdit.Caption = "Edit";
			this.bbiSectionsEdit.Name = "bbiSectionsEdit";
			this.bbiSectionsEdit.ImageUri.Uri = "Edit";
			this.bbiSectionsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SectionsBarManager.Items.Add(this.bbiSectionsEdit);
			this.SectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsEdit));
			this.SectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsEdit));
						//
			//SectionsDelete
			//
			this.bbiSectionsDelete.Caption = "Delete";
			this.bbiSectionsDelete.Name = "bbiSectionsDelete";
			this.bbiSectionsDelete.ImageUri.Uri = "Delete";
			this.bbiSectionsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SectionsBarManager.Items.Add(this.bbiSectionsDelete);
			this.SectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsDelete));
			this.SectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsDelete));
						//
			//SectionsRefresh
			//
			this.bbiSectionsRefresh.Caption = "Refresh";
			this.bbiSectionsRefresh.Name = "bbiSectionsRefresh";
			this.bbiSectionsRefresh.ImageUri.Uri = "Refresh";
			this.bbiSectionsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SectionsBarManager.Items.Add(this.bbiSectionsRefresh);
			this.SectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsRefresh));
			this.SectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSectionsRefresh));
						//
			//SectionsBar
			//
			this.SectionsBar.BarName = "Sections";
            this.SectionsBar.DockCol = 0;
            this.SectionsBar.DockRow = 0;
            this.SectionsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.SectionsBar.OptionsBar.AllowQuickCustomization = false;
            this.SectionsBar.OptionsBar.DrawDragBorder = false;
            this.SectionsBar.Text = "Sections";
			//
			//SectionsBarManager
			//
			this.SectionsBarManager.AllowCustomization = false;
            this.SectionsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.SectionsBar});
            this.SectionsBarManager.Form = SectionsXtraUserControl;
            this.SectionsBarManager.MainMenu = this.SectionsBar;
			// 
            // SectionsPopUpMenu
            // 
            this.SectionsPopUpMenu.Manager = this.SectionsBarManager;
            this.SectionsPopUpMenu.Name = "SectionsPopUpMenu";
			//
			//SectionsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters SectionsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            SectionsRetriveFieldParameters.FieldName = "Sections";
            SectionsRetriveFieldParameters.ControlForField = SectionsXtraUserControl;
			SectionsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(SectionsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Mode_formationViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//Mode_formationView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "Mode_formationView";
						((System.ComponentModel.ISupportInitialize)(this.EnseignantsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.PromoesBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.SectionsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource mode_formationViewBindingSource;
				private DevExpress.XtraGrid.GridControl EnseignantsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView EnseignantsGridView;
		private DevExpress.XtraBars.BarManager EnseignantsBarManager;
		private DevExpress.XtraBars.Bar EnseignantsBar;
		private DevExpress.XtraEditors.XtraUserControl EnseignantsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu EnseignantsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiEnseignantsNew;
				private DevExpress.XtraBars.BarButtonItem bbiEnseignantsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiEnseignantsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiEnseignantsRefresh;
						private DevExpress.XtraGrid.GridControl PromoesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView PromoesGridView;
		private DevExpress.XtraBars.BarManager PromoesBarManager;
		private DevExpress.XtraBars.Bar PromoesBar;
		private DevExpress.XtraEditors.XtraUserControl PromoesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu PromoesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiPromoesNew;
				private DevExpress.XtraBars.BarButtonItem bbiPromoesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiPromoesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiPromoesRefresh;
						private DevExpress.XtraGrid.GridControl SectionsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView SectionsGridView;
		private DevExpress.XtraBars.BarManager SectionsBarManager;
		private DevExpress.XtraBars.Bar SectionsBar;
		private DevExpress.XtraEditors.XtraUserControl SectionsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu SectionsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiSectionsNew;
				private DevExpress.XtraBars.BarButtonItem bbiSectionsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiSectionsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiSectionsRefresh;
						 
	}
}
