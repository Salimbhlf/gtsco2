namespace gtsco2.mvvm.Views.OptionView {
    partial class OptionView {
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
						this.ModulesGridControl = new DevExpress.XtraGrid.GridControl();
			this.ModulesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ModulesBarManager = new DevExpress.XtraBars.BarManager();
			this.ModulesBar = new DevExpress.XtraBars.Bar();
			this.ModulesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ModulesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiModulesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiModulesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiModulesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiModulesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ModulesBarManager)).BeginInit();
									this.Specialite1LookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.Specialite1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Option Tasks";
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
			this.optionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.optionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Option);
			this.dataLayoutControl1.DataSource = optionViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
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
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoesPromoesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoesPromoesChildPopulateColumnParameters.FieldName = "PromoesPromoes";
            PromoesPromoesChildPopulateColumnParameters.Path = "Promoes.Code_Promo";
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(PromoesPromoesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsPromoesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsPromoesChildPopulateColumnParameters.FieldName = "SectionsPromoes";
            SectionsPromoesChildPopulateColumnParameters.Path = "Sections.Code_Section";
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(SectionsPromoesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Specialite1PromoesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Specialite1PromoesChildPopulateColumnParameters.FieldName = "Specialite1Promoes";
            Specialite1PromoesChildPopulateColumnParameters.Path = "Specialite1.Code_SP";
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(Specialite1PromoesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulesPromoesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulesPromoesChildPopulateColumnParameters.FieldName = "ModulesPromoes";
            ModulesPromoesChildPopulateColumnParameters.Path = "Modules.Designation_Module";
			PromoesPopulateColumnsParameters.CustomColumnParameters.Add(ModulesPromoesChildPopulateColumnParameters);
			 
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
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoesSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoesSectionsChildPopulateColumnParameters.FieldName = "PromoesSections";
            PromoesSectionsChildPopulateColumnParameters.Path = "Promoes.Code_Promo";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(PromoesSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsSectionsChildPopulateColumnParameters.FieldName = "SectionsSections";
            SectionsSectionsChildPopulateColumnParameters.Path = "Sections.Code_Section";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(SectionsSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Specialite1SectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Specialite1SectionsChildPopulateColumnParameters.FieldName = "Specialite1Sections";
            Specialite1SectionsChildPopulateColumnParameters.Path = "Specialite1.Code_SP";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(Specialite1SectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulesSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulesSectionsChildPopulateColumnParameters.FieldName = "ModulesSections";
            ModulesSectionsChildPopulateColumnParameters.Path = "Modules.Designation_Module";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(ModulesSectionsChildPopulateColumnParameters);
			 
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
			//ModulesGridControl
			//
			this.ModulesGridControl.MainView = this.ModulesGridView;
			this.ModulesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModulesGridControl.MenuManager = this.mainRibbonControl;
            this.ModulesGridControl.Name = "ModulesGridControl";
            this.ModulesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ModulesGridView});
			//
			//ModulesGridView
			//
            this.ModulesGridView.GridControl = this.ModulesGridControl;
            this.ModulesGridView.Name = "ModulesGridView";
            this.ModulesGridView.OptionsBehavior.Editable = false;
            this.ModulesGridView.OptionsBehavior.ReadOnly = true;
			//
			//ModulesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ModulesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EvaluationsModulesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EvaluationsModulesChildPopulateColumnParameters_NotVisible.FieldName = "Evaluations";
		    EvaluationsModulesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ModulesPopulateColumnsParameters.CustomColumnParameters.Add(EvaluationsModulesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionModulesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionModulesChildPopulateColumnParameters_NotVisible.FieldName = "Option";
		    OptionModulesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ModulesPopulateColumnsParameters.CustomColumnParameters.Add(OptionModulesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoesModulesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoesModulesChildPopulateColumnParameters.FieldName = "PromoesModules";
            PromoesModulesChildPopulateColumnParameters.Path = "Promoes.Code_Promo";
			ModulesPopulateColumnsParameters.CustomColumnParameters.Add(PromoesModulesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsModulesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsModulesChildPopulateColumnParameters.FieldName = "SectionsModules";
            SectionsModulesChildPopulateColumnParameters.Path = "Sections.Code_Section";
			ModulesPopulateColumnsParameters.CustomColumnParameters.Add(SectionsModulesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Specialite1ModulesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Specialite1ModulesChildPopulateColumnParameters.FieldName = "Specialite1Modules";
            Specialite1ModulesChildPopulateColumnParameters.Path = "Specialite1.Code_SP";
			ModulesPopulateColumnsParameters.CustomColumnParameters.Add(Specialite1ModulesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulesModulesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulesModulesChildPopulateColumnParameters.FieldName = "ModulesModules";
            ModulesModulesChildPopulateColumnParameters.Path = "Modules.Designation_Module";
			ModulesPopulateColumnsParameters.CustomColumnParameters.Add(ModulesModulesChildPopulateColumnParameters);
			 
		    this.ModulesGridView.PopulateColumns(typeof(gtsco2.basededonne.Module),ModulesPopulateColumnsParameters);
			//
			//ModulesBindingSource
			//
			System.Windows.Forms.BindingSource ModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ModulesBindingSource.DataSource = typeof(gtsco2.basededonne.Module);
            this.ModulesGridControl.DataSource = ModulesBindingSource;
			//
			//ModulesXtraUserControl
			//
            this.ModulesXtraUserControl.Controls.Add(ModulesGridControl);
			this.ModulesXtraUserControl.Name = "ModulesXtraUserControl";
			this.ModulesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ModulesNew
			//
			this.bbiModulesNew.Caption = "New";
			this.bbiModulesNew.Name = "bbiModulesNew";
			this.bbiModulesNew.ImageUri.Uri = "New";
			this.bbiModulesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ModulesBarManager.Items.Add(this.bbiModulesNew);
			this.ModulesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesNew));
			this.ModulesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesNew));
						//
			//ModulesEdit
			//
			this.bbiModulesEdit.Caption = "Edit";
			this.bbiModulesEdit.Name = "bbiModulesEdit";
			this.bbiModulesEdit.ImageUri.Uri = "Edit";
			this.bbiModulesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ModulesBarManager.Items.Add(this.bbiModulesEdit);
			this.ModulesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesEdit));
			this.ModulesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesEdit));
						//
			//ModulesDelete
			//
			this.bbiModulesDelete.Caption = "Delete";
			this.bbiModulesDelete.Name = "bbiModulesDelete";
			this.bbiModulesDelete.ImageUri.Uri = "Delete";
			this.bbiModulesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ModulesBarManager.Items.Add(this.bbiModulesDelete);
			this.ModulesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesDelete));
			this.ModulesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesDelete));
						//
			//ModulesRefresh
			//
			this.bbiModulesRefresh.Caption = "Refresh";
			this.bbiModulesRefresh.Name = "bbiModulesRefresh";
			this.bbiModulesRefresh.ImageUri.Uri = "Refresh";
			this.bbiModulesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ModulesBarManager.Items.Add(this.bbiModulesRefresh);
			this.ModulesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesRefresh));
			this.ModulesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiModulesRefresh));
						//
			//ModulesBar
			//
			this.ModulesBar.BarName = "Modules";
            this.ModulesBar.DockCol = 0;
            this.ModulesBar.DockRow = 0;
            this.ModulesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ModulesBar.OptionsBar.AllowQuickCustomization = false;
            this.ModulesBar.OptionsBar.DrawDragBorder = false;
            this.ModulesBar.Text = "Modules";
			//
			//ModulesBarManager
			//
			this.ModulesBarManager.AllowCustomization = false;
            this.ModulesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ModulesBar});
            this.ModulesBarManager.Form = ModulesXtraUserControl;
            this.ModulesBarManager.MainMenu = this.ModulesBar;
			// 
            // ModulesPopUpMenu
            // 
            this.ModulesPopUpMenu.Manager = this.ModulesBarManager;
            this.ModulesPopUpMenu.Name = "ModulesPopUpMenu";
			//
			//ModulesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ModulesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ModulesRetriveFieldParameters.FieldName = "Modules";
            ModulesRetriveFieldParameters.ControlForField = ModulesXtraUserControl;
			ModulesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ModulesRetriveFieldParameters);
									//
			//Specialite1LookUpEdit
			//
			this.Specialite1BindingSource.DataSource = typeof(gtsco2.basededonne.Specialite);
			this.Specialite1LookUpEdit.Properties.ValueMember = "ID_Specialité"; 
			this.Specialite1LookUpEdit.Properties.DisplayMember = "Code_SP";
			this.Specialite1LookUpEdit.Properties.DataSource = this.Specialite1BindingSource;
			this.Specialite1LookUpEdit.Name = "Specialite1LookUpEdit";
			this.Specialite1LookUpEdit.DataBindings.Add("EditValue", optionViewBindingSource, "Specialite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Specialite1LookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Specialite1LookUpEditRetrieveFieldParameters.FieldName = "Specialite";
            Specialite1LookUpEditRetrieveFieldParameters.ControlForField = this.Specialite1LookUpEdit;
			parameters.CustomListParameters.Add(Specialite1LookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Specialite1LookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    Specialite1LookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Specialite1";
		    Specialite1LookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(Specialite1LookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.OptionViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.OptionViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//OptionView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "OptionView";
						((System.ComponentModel.ISupportInitialize)(this.PromoesBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.SectionsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.ModulesBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource optionViewBindingSource;
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
						private DevExpress.XtraGrid.GridControl ModulesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ModulesGridView;
		private DevExpress.XtraBars.BarManager ModulesBarManager;
		private DevExpress.XtraBars.Bar ModulesBar;
		private DevExpress.XtraEditors.XtraUserControl ModulesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ModulesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiModulesNew;
				private DevExpress.XtraBars.BarButtonItem bbiModulesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiModulesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiModulesRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit Specialite1LookUpEdit;
		private System.Windows.Forms.BindingSource Specialite1BindingSource;
		 
	}
}
