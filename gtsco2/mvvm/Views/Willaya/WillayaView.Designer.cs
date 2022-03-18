namespace gtsco2.mvvm.Views.WillayaView {
    partial class WillayaView {
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
						this.CommunesGridControl = new DevExpress.XtraGrid.GridControl();
			this.CommunesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CommunesBarManager = new DevExpress.XtraBars.BarManager();
			this.CommunesBar = new DevExpress.XtraBars.Bar();
			this.CommunesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.CommunesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiCommunesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCommunesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCommunesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiCommunesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.CommunesBarManager)).BeginInit();
						 
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
            this.mainRibbonPageGroup.Text = "Willaya Tasks";
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
			this.willayaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.willayaViewBindingSource.DataSource = typeof(gtsco2.basededonne.Willaya);
			this.dataLayoutControl1.DataSource = willayaViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//CommunesGridControl
			//
			this.CommunesGridControl.MainView = this.CommunesGridView;
			this.CommunesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommunesGridControl.MenuManager = this.mainRibbonControl;
            this.CommunesGridControl.Name = "CommunesGridControl";
            this.CommunesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CommunesGridView});
			//
			//CommunesGridView
			//
            this.CommunesGridView.GridControl = this.CommunesGridControl;
            this.CommunesGridView.Name = "CommunesGridView";
            this.CommunesGridView.OptionsBehavior.Editable = false;
            this.CommunesGridView.OptionsBehavior.ReadOnly = true;
			//
			//CommunesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters CommunesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Code_PostalCommunesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Code_PostalCommunesChildPopulateColumnParameters_NotVisible.FieldName = "Code_Postal";
		    Code_PostalCommunesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CommunesPopulateColumnsParameters.CustomColumnParameters.Add(Code_PostalCommunesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters WillayaCommunesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            WillayaCommunesChildPopulateColumnParameters_NotVisible.FieldName = "Willaya";
		    WillayaCommunesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CommunesPopulateColumnsParameters.CustomColumnParameters.Add(WillayaCommunesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Maitre_ApprentissageCommunesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Maitre_ApprentissageCommunesChildPopulateColumnParameters_NotVisible.FieldName = "Maitre_Apprentissage";
		    Maitre_ApprentissageCommunesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CommunesPopulateColumnsParameters.CustomColumnParameters.Add(Maitre_ApprentissageCommunesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairsCommunesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairsCommunesChildPopulateColumnParameters_NotVisible.FieldName = "Stagiairs";
		    StagiairsCommunesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			CommunesPopulateColumnsParameters.CustomColumnParameters.Add(StagiairsCommunesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CommunesCommunesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CommunesCommunesChildPopulateColumnParameters.FieldName = "CommunesCommunes";
            CommunesCommunesChildPopulateColumnParameters.Path = "Communes.Commune_name";
			CommunesPopulateColumnsParameters.CustomColumnParameters.Add(CommunesCommunesChildPopulateColumnParameters);
			 
		    this.CommunesGridView.PopulateColumns(typeof(gtsco2.basededonne.Commune),CommunesPopulateColumnsParameters);
			//
			//CommunesBindingSource
			//
			System.Windows.Forms.BindingSource CommunesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			CommunesBindingSource.DataSource = typeof(gtsco2.basededonne.Commune);
            this.CommunesGridControl.DataSource = CommunesBindingSource;
			//
			//CommunesXtraUserControl
			//
            this.CommunesXtraUserControl.Controls.Add(CommunesGridControl);
			this.CommunesXtraUserControl.Name = "CommunesXtraUserControl";
			this.CommunesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//CommunesNew
			//
			this.bbiCommunesNew.Caption = "New";
			this.bbiCommunesNew.Name = "bbiCommunesNew";
			this.bbiCommunesNew.ImageUri.Uri = "New";
			this.bbiCommunesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CommunesBarManager.Items.Add(this.bbiCommunesNew);
			this.CommunesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesNew));
			this.CommunesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesNew));
						//
			//CommunesEdit
			//
			this.bbiCommunesEdit.Caption = "Edit";
			this.bbiCommunesEdit.Name = "bbiCommunesEdit";
			this.bbiCommunesEdit.ImageUri.Uri = "Edit";
			this.bbiCommunesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CommunesBarManager.Items.Add(this.bbiCommunesEdit);
			this.CommunesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesEdit));
			this.CommunesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesEdit));
						//
			//CommunesDelete
			//
			this.bbiCommunesDelete.Caption = "Delete";
			this.bbiCommunesDelete.Name = "bbiCommunesDelete";
			this.bbiCommunesDelete.ImageUri.Uri = "Delete";
			this.bbiCommunesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CommunesBarManager.Items.Add(this.bbiCommunesDelete);
			this.CommunesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesDelete));
			this.CommunesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesDelete));
						//
			//CommunesRefresh
			//
			this.bbiCommunesRefresh.Caption = "Refresh";
			this.bbiCommunesRefresh.Name = "bbiCommunesRefresh";
			this.bbiCommunesRefresh.ImageUri.Uri = "Refresh";
			this.bbiCommunesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.CommunesBarManager.Items.Add(this.bbiCommunesRefresh);
			this.CommunesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesRefresh));
			this.CommunesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiCommunesRefresh));
						//
			//CommunesBar
			//
			this.CommunesBar.BarName = "Communes";
            this.CommunesBar.DockCol = 0;
            this.CommunesBar.DockRow = 0;
            this.CommunesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.CommunesBar.OptionsBar.AllowQuickCustomization = false;
            this.CommunesBar.OptionsBar.DrawDragBorder = false;
            this.CommunesBar.Text = "Communes";
			//
			//CommunesBarManager
			//
			this.CommunesBarManager.AllowCustomization = false;
            this.CommunesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.CommunesBar});
            this.CommunesBarManager.Form = CommunesXtraUserControl;
            this.CommunesBarManager.MainMenu = this.CommunesBar;
			// 
            // CommunesPopUpMenu
            // 
            this.CommunesPopUpMenu.Manager = this.CommunesBarManager;
            this.CommunesPopUpMenu.Name = "CommunesPopUpMenu";
			//
			//CommunesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters CommunesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CommunesRetriveFieldParameters.FieldName = "Communes";
            CommunesRetriveFieldParameters.ControlForField = CommunesXtraUserControl;
			CommunesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(CommunesRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.WillayaViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.WillayaViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//WillayaView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "WillayaView";
						((System.ComponentModel.ISupportInitialize)(this.CommunesBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource willayaViewBindingSource;
				private DevExpress.XtraGrid.GridControl CommunesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView CommunesGridView;
		private DevExpress.XtraBars.BarManager CommunesBarManager;
		private DevExpress.XtraBars.Bar CommunesBar;
		private DevExpress.XtraEditors.XtraUserControl CommunesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu CommunesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiCommunesNew;
				private DevExpress.XtraBars.BarButtonItem bbiCommunesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiCommunesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiCommunesRefresh;
						 
	}
}
