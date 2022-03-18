namespace gtsco2.mvvm.Views.Proce_verbal_delibationView {
    partial class Proce_verbal_delibationView {
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
            this.mainRibbonPageGroup.Text = "Proce_verbal_delibation Tasks";
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
			this.proce_verbal_delibationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proce_verbal_delibationViewBindingSource.DataSource = typeof(gtsco2.basededonne.Proce_verbal_delibation);
			this.dataLayoutControl1.DataSource = proce_verbal_delibationViewBindingSource;
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
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DecisionsDecisionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DecisionsDecisionsChildPopulateColumnParameters.FieldName = "DecisionsDecisions";
            DecisionsDecisionsChildPopulateColumnParameters.Path = "Decisions.Type_Decision";
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(DecisionsDecisionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PARTICIPEsDecisionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PARTICIPEsDecisionsChildPopulateColumnParameters.FieldName = "PARTICIPEsDecisions";
            PARTICIPEsDecisionsChildPopulateColumnParameters.Path = "PARTICIPEs.Qualite";
			DecisionsPopulateColumnsParameters.CustomColumnParameters.Add(PARTICIPEsDecisionsChildPopulateColumnParameters);
			 
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
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DecisionsPARTICIPEsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DecisionsPARTICIPEsChildPopulateColumnParameters.FieldName = "DecisionsPARTICIPEs";
            DecisionsPARTICIPEsChildPopulateColumnParameters.Path = "Decisions.Type_Decision";
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(DecisionsPARTICIPEsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PARTICIPEsPARTICIPEsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PARTICIPEsPARTICIPEsChildPopulateColumnParameters.FieldName = "PARTICIPEsPARTICIPEs";
            PARTICIPEsPARTICIPEsChildPopulateColumnParameters.Path = "PARTICIPEs.Qualite";
			PARTICIPEsPopulateColumnsParameters.CustomColumnParameters.Add(PARTICIPEsPARTICIPEsChildPopulateColumnParameters);
			 
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
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Proce_verbal_delibationViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//Proce_verbal_delibationView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "Proce_verbal_delibationView";
						((System.ComponentModel.ISupportInitialize)(this.DecisionsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.PARTICIPEsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource proce_verbal_delibationViewBindingSource;
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
						 
	}
}
