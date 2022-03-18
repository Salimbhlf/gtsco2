namespace gtsco2.mvvm.Views.PromoView {
    partial class PromoView {
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
						this.DecisionsGridControl = new DevExpress.XtraGrid.GridControl();
			this.DecisionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.DecisionsBarManager = new DevExpress.XtraBars.BarManager();
			this.DecisionsBar = new DevExpress.XtraBars.Bar();
			this.DecisionsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.DecisionsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiDecisionsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiDecisionsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiDecisionsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiDecisionsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.DecisionsBarManager)).BeginInit();
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
									this.Mode_formationLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.Mode_formationBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.OptionLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.OptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Promo Tasks";
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
			this.promoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.promoViewBindingSource.DataSource = typeof(gtsco2.basededonne.Promo);
			this.dataLayoutControl1.DataSource = promoViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//DecisionsGridControl
			//
			this.DecisionsGridControl.MainView = this.DecisionsGridView;
			this.DecisionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecisionsGridControl.MenuManager = this.mainRibbonControl;
            this.DecisionsGridControl.Name = "DecisionsGridControl";
            this.DecisionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DecisionsGridView});
			//
			//DecisionsGridView
			//
            this.DecisionsGridView.GridControl = this.DecisionsGridControl;
            this.DecisionsGridView.Name = "DecisionsGridView";
            this.DecisionsGridView.OptionsBehavior.Editable = false;
            this.DecisionsGridView.OptionsBehavior.ReadOnly = true;
			//
			//DecisionsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters DecisionsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Proce_verbal_delibationDecisionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Proce_verbal_delibationDecisionsChildPopulateColumnParameters_NotVisible.FieldName = "Proce_verbal_delibation";
		    Proce_verbal_delibationDecisionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(Proce_verbal_delibationDecisionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoDecisionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoDecisionsChildPopulateColumnParameters_NotVisible.FieldName = "Promo";
		    PromoDecisionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(PromoDecisionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SemestreDecisionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SemestreDecisionsChildPopulateColumnParameters_NotVisible.FieldName = "Semestre";
		    SemestreDecisionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(SemestreDecisionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairDecisionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairDecisionsChildPopulateColumnParameters_NotVisible.FieldName = "Stagiair";
		    StagiairDecisionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairDecisionsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formationDecisionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formationDecisionsChildPopulateColumnParameters.FieldName = "Mode_formationDecisions";
            Mode_formationDecisionsChildPopulateColumnParameters.Path = "Mode_formation.Code_Mode_Formation";
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formationDecisionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionDecisionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionDecisionsChildPopulateColumnParameters.FieldName = "OptionDecisions";
            OptionDecisionsChildPopulateColumnParameters.Path = "Option.Code_Option";
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(OptionDecisionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DecisionsDecisionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DecisionsDecisionsChildPopulateColumnParameters.FieldName = "DecisionsDecisions";
            DecisionsDecisionsChildPopulateColumnParameters.Path = "Decisions.Type_Decision";
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(DecisionsDecisionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsDecisionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsDecisionsChildPopulateColumnParameters.FieldName = "SectionsDecisions";
            SectionsDecisionsChildPopulateColumnParameters.Path = "Sections.Code_Section";
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(SectionsDecisionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsDecisionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsDecisionsChildPopulateColumnParameters.FieldName = "StagiairsDecisions";
            StagiairsDecisionsChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsDecisionsChildPopulateColumnParameters);
			 
		    this.DecisionsGridView.PopulateColumns(typeof(gtsco2.basededonne.Decision),DecisionsPopulateColumnsParameters);
			//
			//DecisionsBindingSource
			//
			System.Windows.Forms.BindingSource DecisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			DecisionsBindingSource.DataSource = typeof(gtsco2.basededonne.Decision);
            this.DecisionsGridControl.DataSource = DecisionsBindingSource;
			//
			//DecisionsXtraUserControl
			//
            this.DecisionsXtraUserControl.Controls.Add(DecisionsGridControl);
			this.DecisionsXtraUserControl.Name = "DecisionsXtraUserControl";
			this.DecisionsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//DecisionsNew
			//
			this.bbiDecisionsNew.Caption = "New";
			this.bbiDecisionsNew.Name = "bbiDecisionsNew";
			this.bbiDecisionsNew.ImageUri.Uri = "New";
			this.bbiDecisionsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DecisionsBarManager.Items.Add(this.bbiDecisionsNew);
			this.DecisionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsNew));
			this.DecisionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsNew));
						//
			//DecisionsEdit
			//
			this.bbiDecisionsEdit.Caption = "Edit";
			this.bbiDecisionsEdit.Name = "bbiDecisionsEdit";
			this.bbiDecisionsEdit.ImageUri.Uri = "Edit";
			this.bbiDecisionsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DecisionsBarManager.Items.Add(this.bbiDecisionsEdit);
			this.DecisionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsEdit));
			this.DecisionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsEdit));
						//
			//DecisionsDelete
			//
			this.bbiDecisionsDelete.Caption = "Delete";
			this.bbiDecisionsDelete.Name = "bbiDecisionsDelete";
			this.bbiDecisionsDelete.ImageUri.Uri = "Delete";
			this.bbiDecisionsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DecisionsBarManager.Items.Add(this.bbiDecisionsDelete);
			this.DecisionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsDelete));
			this.DecisionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsDelete));
						//
			//DecisionsRefresh
			//
			this.bbiDecisionsRefresh.Caption = "Refresh";
			this.bbiDecisionsRefresh.Name = "bbiDecisionsRefresh";
			this.bbiDecisionsRefresh.ImageUri.Uri = "Refresh";
			this.bbiDecisionsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DecisionsBarManager.Items.Add(this.bbiDecisionsRefresh);
			this.DecisionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsRefresh));
			this.DecisionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecisionsRefresh));
						//
			//DecisionsBar
			//
			this.DecisionsBar.BarName = "Decisions";
            this.DecisionsBar.DockCol = 0;
            this.DecisionsBar.DockRow = 0;
            this.DecisionsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.DecisionsBar.OptionsBar.AllowQuickCustomization = false;
            this.DecisionsBar.OptionsBar.DrawDragBorder = false;
            this.DecisionsBar.Text = "Decisions";
			//
			//DecisionsBarManager
			//
			this.DecisionsBarManager.AllowCustomization = false;
            this.DecisionsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.DecisionsBar});
            this.DecisionsBarManager.Form = DecisionsXtraUserControl;
            this.DecisionsBarManager.MainMenu = this.DecisionsBar;
			// 
            // DecisionsPopUpMenu
            // 
            this.DecisionsPopUpMenu.Manager = this.DecisionsBarManager;
            this.DecisionsPopUpMenu.Name = "DecisionsPopUpMenu";
			//
			//DecisionsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters DecisionsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            DecisionsRetriveFieldParameters.FieldName = "Decisions";
            DecisionsRetriveFieldParameters.ControlForField = DecisionsXtraUserControl;
			DecisionsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(DecisionsRetriveFieldParameters);
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
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formationSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formationSectionsChildPopulateColumnParameters.FieldName = "Mode_formationSections";
            Mode_formationSectionsChildPopulateColumnParameters.Path = "Mode_formation.Code_Mode_Formation";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formationSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionSectionsChildPopulateColumnParameters.FieldName = "OptionSections";
            OptionSectionsChildPopulateColumnParameters.Path = "Option.Code_Option";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(OptionSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DecisionsSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DecisionsSectionsChildPopulateColumnParameters.FieldName = "DecisionsSections";
            DecisionsSectionsChildPopulateColumnParameters.Path = "Decisions.Type_Decision";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(DecisionsSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsSectionsChildPopulateColumnParameters.FieldName = "SectionsSections";
            SectionsSectionsChildPopulateColumnParameters.Path = "Sections.Code_Section";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(SectionsSectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsSectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsSectionsChildPopulateColumnParameters.FieldName = "StagiairsSections";
            StagiairsSectionsChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			SectionsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsSectionsChildPopulateColumnParameters);
			 
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
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Mode_formationStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Mode_formationStagiairsChildPopulateColumnParameters.FieldName = "Mode_formationStagiairs";
            Mode_formationStagiairsChildPopulateColumnParameters.Path = "Mode_formation.Code_Mode_Formation";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(Mode_formationStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionStagiairsChildPopulateColumnParameters.FieldName = "OptionStagiairs";
            OptionStagiairsChildPopulateColumnParameters.Path = "Option.Code_Option";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(OptionStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DecisionsStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DecisionsStagiairsChildPopulateColumnParameters.FieldName = "DecisionsStagiairs";
            DecisionsStagiairsChildPopulateColumnParameters.Path = "Decisions.Type_Decision";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(DecisionsStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsStagiairsChildPopulateColumnParameters.FieldName = "SectionsStagiairs";
            SectionsStagiairsChildPopulateColumnParameters.Path = "Sections.Code_Section";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(SectionsStagiairsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsStagiairsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsStagiairsChildPopulateColumnParameters.FieldName = "StagiairsStagiairs";
            StagiairsStagiairsChildPopulateColumnParameters.Path = "Stagiairs.Num_STG";
			StagiairsPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsStagiairsChildPopulateColumnParameters);
			 
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
			//Mode_formationLookUpEdit
			//
			this.Mode_formationBindingSource.DataSource = typeof(gtsco2.basededonne.Mode_formation);
			this.Mode_formationLookUpEdit.Properties.ValueMember = "ID_Mode_Formation"; 
			this.Mode_formationLookUpEdit.Properties.DisplayMember = "Code_Mode_Formation";
			this.Mode_formationLookUpEdit.Properties.DataSource = this.Mode_formationBindingSource;
			this.Mode_formationLookUpEdit.Name = "Mode_formationLookUpEdit";
			this.Mode_formationLookUpEdit.DataBindings.Add("EditValue", promoViewBindingSource, "Mode_de_formation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Mode_formationLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Mode_formationLookUpEditRetrieveFieldParameters.FieldName = "Mode_de_formation";
            Mode_formationLookUpEditRetrieveFieldParameters.ControlForField = this.Mode_formationLookUpEdit;
			parameters.CustomListParameters.Add(Mode_formationLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Mode_formationLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    Mode_formationLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Mode_formation";
		    Mode_formationLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(Mode_formationLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//OptionLookUpEdit
			//
			this.OptionBindingSource.DataSource = typeof(gtsco2.basededonne.Option);
			this.OptionLookUpEdit.Properties.ValueMember = "ID_Option"; 
			this.OptionLookUpEdit.Properties.DisplayMember = "Code_Option";
			this.OptionLookUpEdit.Properties.DataSource = this.OptionBindingSource;
			this.OptionLookUpEdit.Name = "OptionLookUpEdit";
			this.OptionLookUpEdit.DataBindings.Add("EditValue", promoViewBindingSource, "ID_Option", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters OptionLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            OptionLookUpEditRetrieveFieldParameters.FieldName = "ID_Option";
            OptionLookUpEditRetrieveFieldParameters.ControlForField = this.OptionLookUpEdit;
			parameters.CustomListParameters.Add(OptionLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters OptionLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    OptionLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Option";
		    OptionLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(OptionLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.PromoViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PromoViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//PromoView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "PromoView";
						((System.ComponentModel.ISupportInitialize)(this.DecisionsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.SectionsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource promoViewBindingSource;
				private DevExpress.XtraGrid.GridControl DecisionsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView DecisionsGridView;
		private DevExpress.XtraBars.BarManager DecisionsBarManager;
		private DevExpress.XtraBars.Bar DecisionsBar;
		private DevExpress.XtraEditors.XtraUserControl DecisionsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu DecisionsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiDecisionsNew;
				private DevExpress.XtraBars.BarButtonItem bbiDecisionsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiDecisionsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiDecisionsRefresh;
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
								private DevExpress.XtraEditors.GridLookUpEdit Mode_formationLookUpEdit;
		private System.Windows.Forms.BindingSource Mode_formationBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit OptionLookUpEdit;
		private System.Windows.Forms.BindingSource OptionBindingSource;
		 
	}
}
