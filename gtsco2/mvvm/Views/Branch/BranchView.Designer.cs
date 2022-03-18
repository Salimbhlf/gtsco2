namespace gtsco2.mvvm.Views.BranchView {
    partial class BranchView {
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
						this.SpecialitesGridControl = new DevExpress.XtraGrid.GridControl();
			this.SpecialitesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.SpecialitesBarManager = new DevExpress.XtraBars.BarManager();
			this.SpecialitesBar = new DevExpress.XtraBars.Bar();
			this.SpecialitesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.SpecialitesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiSpecialitesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSpecialitesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSpecialitesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSpecialitesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.SpecialitesBarManager)).BeginInit();
						 
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
            this.mainRibbonPageGroup.Text = "Branch Tasks";
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
			this.branchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.branchViewBindingSource.DataSource = typeof(gtsco2.basededonne.Branch);
			this.dataLayoutControl1.DataSource = branchViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//SpecialitesGridControl
			//
			this.SpecialitesGridControl.MainView = this.SpecialitesGridView;
			this.SpecialitesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecialitesGridControl.MenuManager = this.mainRibbonControl;
            this.SpecialitesGridControl.Name = "SpecialitesGridControl";
            this.SpecialitesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SpecialitesGridView});
			//
			//SpecialitesGridView
			//
            this.SpecialitesGridView.GridControl = this.SpecialitesGridControl;
            this.SpecialitesGridView.Name = "SpecialitesGridView";
            this.SpecialitesGridView.OptionsBehavior.Editable = false;
            this.SpecialitesGridView.OptionsBehavior.ReadOnly = true;
			//
			//SpecialitesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters SpecialitesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BranchSpecialitesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BranchSpecialitesChildPopulateColumnParameters_NotVisible.FieldName = "Branch";
		    BranchSpecialitesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SpecialitesPopulateColumnsParameters.CustomColumnParameters.Add(BranchSpecialitesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionsSpecialitesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionsSpecialitesChildPopulateColumnParameters_NotVisible.FieldName = "Options";
		    OptionsSpecialitesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SpecialitesPopulateColumnsParameters.CustomColumnParameters.Add(OptionsSpecialitesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SpecialitesSpecialitesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SpecialitesSpecialitesChildPopulateColumnParameters.FieldName = "SpecialitesSpecialites";
            SpecialitesSpecialitesChildPopulateColumnParameters.Path = "Specialites.Code_SP";
			SpecialitesPopulateColumnsParameters.CustomColumnParameters.Add(SpecialitesSpecialitesChildPopulateColumnParameters);
			 
		    this.SpecialitesGridView.PopulateColumns(typeof(gtsco2.basededonne.Specialite),SpecialitesPopulateColumnsParameters);
			//
			//SpecialitesBindingSource
			//
			System.Windows.Forms.BindingSource SpecialitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			SpecialitesBindingSource.DataSource = typeof(gtsco2.basededonne.Specialite);
            this.SpecialitesGridControl.DataSource = SpecialitesBindingSource;
			//
			//SpecialitesXtraUserControl
			//
            this.SpecialitesXtraUserControl.Controls.Add(SpecialitesGridControl);
			this.SpecialitesXtraUserControl.Name = "SpecialitesXtraUserControl";
			this.SpecialitesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//SpecialitesNew
			//
			this.bbiSpecialitesNew.Caption = "New";
			this.bbiSpecialitesNew.Name = "bbiSpecialitesNew";
			this.bbiSpecialitesNew.ImageUri.Uri = "New";
			this.bbiSpecialitesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SpecialitesBarManager.Items.Add(this.bbiSpecialitesNew);
			this.SpecialitesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesNew));
			this.SpecialitesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesNew));
						//
			//SpecialitesEdit
			//
			this.bbiSpecialitesEdit.Caption = "Edit";
			this.bbiSpecialitesEdit.Name = "bbiSpecialitesEdit";
			this.bbiSpecialitesEdit.ImageUri.Uri = "Edit";
			this.bbiSpecialitesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SpecialitesBarManager.Items.Add(this.bbiSpecialitesEdit);
			this.SpecialitesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesEdit));
			this.SpecialitesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesEdit));
						//
			//SpecialitesDelete
			//
			this.bbiSpecialitesDelete.Caption = "Delete";
			this.bbiSpecialitesDelete.Name = "bbiSpecialitesDelete";
			this.bbiSpecialitesDelete.ImageUri.Uri = "Delete";
			this.bbiSpecialitesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SpecialitesBarManager.Items.Add(this.bbiSpecialitesDelete);
			this.SpecialitesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesDelete));
			this.SpecialitesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesDelete));
						//
			//SpecialitesRefresh
			//
			this.bbiSpecialitesRefresh.Caption = "Refresh";
			this.bbiSpecialitesRefresh.Name = "bbiSpecialitesRefresh";
			this.bbiSpecialitesRefresh.ImageUri.Uri = "Refresh";
			this.bbiSpecialitesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SpecialitesBarManager.Items.Add(this.bbiSpecialitesRefresh);
			this.SpecialitesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesRefresh));
			this.SpecialitesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSpecialitesRefresh));
						//
			//SpecialitesBar
			//
			this.SpecialitesBar.BarName = "Specialites";
            this.SpecialitesBar.DockCol = 0;
            this.SpecialitesBar.DockRow = 0;
            this.SpecialitesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.SpecialitesBar.OptionsBar.AllowQuickCustomization = false;
            this.SpecialitesBar.OptionsBar.DrawDragBorder = false;
            this.SpecialitesBar.Text = "Specialites";
			//
			//SpecialitesBarManager
			//
			this.SpecialitesBarManager.AllowCustomization = false;
            this.SpecialitesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.SpecialitesBar});
            this.SpecialitesBarManager.Form = SpecialitesXtraUserControl;
            this.SpecialitesBarManager.MainMenu = this.SpecialitesBar;
			// 
            // SpecialitesPopUpMenu
            // 
            this.SpecialitesPopUpMenu.Manager = this.SpecialitesBarManager;
            this.SpecialitesPopUpMenu.Name = "SpecialitesPopUpMenu";
			//
			//SpecialitesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters SpecialitesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            SpecialitesRetriveFieldParameters.FieldName = "Specialites";
            SpecialitesRetriveFieldParameters.ControlForField = SpecialitesXtraUserControl;
			SpecialitesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(SpecialitesRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.BranchViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.BranchViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//BranchView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "BranchView";
						((System.ComponentModel.ISupportInitialize)(this.SpecialitesBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource branchViewBindingSource;
				private DevExpress.XtraGrid.GridControl SpecialitesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView SpecialitesGridView;
		private DevExpress.XtraBars.BarManager SpecialitesBarManager;
		private DevExpress.XtraBars.Bar SpecialitesBar;
		private DevExpress.XtraEditors.XtraUserControl SpecialitesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu SpecialitesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiSpecialitesNew;
				private DevExpress.XtraBars.BarButtonItem bbiSpecialitesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiSpecialitesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiSpecialitesRefresh;
						 
	}
}
