namespace gtsco2.mvvm.Views.SpecialiteView {
    partial class SpecialiteView {
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
						this.OptionsGridControl = new DevExpress.XtraGrid.GridControl();
			this.OptionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.OptionsBarManager = new DevExpress.XtraBars.BarManager();
			this.OptionsBar = new DevExpress.XtraBars.Bar();
			this.OptionsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.OptionsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiOptionsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiOptionsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiOptionsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiOptionsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.OptionsBarManager)).BeginInit();
									this.BranchLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.BranchBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Specialite Tasks";
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
			this.specialiteViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.specialiteViewBindingSource.DataSource = typeof(gtsco2.basededonne.Specialite);
			this.dataLayoutControl1.DataSource = specialiteViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//OptionsGridControl
			//
			this.OptionsGridControl.MainView = this.OptionsGridView;
			this.OptionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsGridControl.MenuManager = this.mainRibbonControl;
            this.OptionsGridControl.Name = "OptionsGridControl";
            this.OptionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OptionsGridView});
			//
			//OptionsGridView
			//
            this.OptionsGridView.GridControl = this.OptionsGridControl;
            this.OptionsGridView.Name = "OptionsGridView";
            this.OptionsGridView.OptionsBehavior.Editable = false;
            this.OptionsGridView.OptionsBehavior.ReadOnly = true;
			//
			//OptionsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters OptionsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulesOptionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulesOptionsChildPopulateColumnParameters_NotVisible.FieldName = "Modules";
		    ModulesOptionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			OptionsPopulateColumnsParameters.CustomColumnParameters.Add(ModulesOptionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Specialite1OptionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Specialite1OptionsChildPopulateColumnParameters_NotVisible.FieldName = "Specialite1";
		    Specialite1OptionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			OptionsPopulateColumnsParameters.CustomColumnParameters.Add(Specialite1OptionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PromoesOptionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PromoesOptionsChildPopulateColumnParameters_NotVisible.FieldName = "Promoes";
		    PromoesOptionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			OptionsPopulateColumnsParameters.CustomColumnParameters.Add(PromoesOptionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SectionsOptionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SectionsOptionsChildPopulateColumnParameters_NotVisible.FieldName = "Sections";
		    SectionsOptionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			OptionsPopulateColumnsParameters.CustomColumnParameters.Add(SectionsOptionsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionsOptionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionsOptionsChildPopulateColumnParameters.FieldName = "OptionsOptions";
            OptionsOptionsChildPopulateColumnParameters.Path = "Options.Code_Option";
			OptionsPopulateColumnsParameters.CustomColumnParameters.Add(OptionsOptionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BranchOptionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BranchOptionsChildPopulateColumnParameters.FieldName = "BranchOptions";
            BranchOptionsChildPopulateColumnParameters.Path = "Branch.Code_Branche";
			OptionsPopulateColumnsParameters.CustomColumnParameters.Add(BranchOptionsChildPopulateColumnParameters);
			 
		    this.OptionsGridView.PopulateColumns(typeof(gtsco2.basededonne.Option),OptionsPopulateColumnsParameters);
			//
			//OptionsBindingSource
			//
			System.Windows.Forms.BindingSource OptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			OptionsBindingSource.DataSource = typeof(gtsco2.basededonne.Option);
            this.OptionsGridControl.DataSource = OptionsBindingSource;
			//
			//OptionsXtraUserControl
			//
            this.OptionsXtraUserControl.Controls.Add(OptionsGridControl);
			this.OptionsXtraUserControl.Name = "OptionsXtraUserControl";
			this.OptionsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//OptionsNew
			//
			this.bbiOptionsNew.Caption = "New";
			this.bbiOptionsNew.Name = "bbiOptionsNew";
			this.bbiOptionsNew.ImageUri.Uri = "New";
			this.bbiOptionsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.OptionsBarManager.Items.Add(this.bbiOptionsNew);
			this.OptionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsNew));
			this.OptionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsNew));
						//
			//OptionsEdit
			//
			this.bbiOptionsEdit.Caption = "Edit";
			this.bbiOptionsEdit.Name = "bbiOptionsEdit";
			this.bbiOptionsEdit.ImageUri.Uri = "Edit";
			this.bbiOptionsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.OptionsBarManager.Items.Add(this.bbiOptionsEdit);
			this.OptionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsEdit));
			this.OptionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsEdit));
						//
			//OptionsDelete
			//
			this.bbiOptionsDelete.Caption = "Delete";
			this.bbiOptionsDelete.Name = "bbiOptionsDelete";
			this.bbiOptionsDelete.ImageUri.Uri = "Delete";
			this.bbiOptionsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.OptionsBarManager.Items.Add(this.bbiOptionsDelete);
			this.OptionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsDelete));
			this.OptionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsDelete));
						//
			//OptionsRefresh
			//
			this.bbiOptionsRefresh.Caption = "Refresh";
			this.bbiOptionsRefresh.Name = "bbiOptionsRefresh";
			this.bbiOptionsRefresh.ImageUri.Uri = "Refresh";
			this.bbiOptionsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.OptionsBarManager.Items.Add(this.bbiOptionsRefresh);
			this.OptionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsRefresh));
			this.OptionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiOptionsRefresh));
						//
			//OptionsBar
			//
			this.OptionsBar.BarName = "Options";
            this.OptionsBar.DockCol = 0;
            this.OptionsBar.DockRow = 0;
            this.OptionsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.OptionsBar.OptionsBar.AllowQuickCustomization = false;
            this.OptionsBar.OptionsBar.DrawDragBorder = false;
            this.OptionsBar.Text = "Options";
			//
			//OptionsBarManager
			//
			this.OptionsBarManager.AllowCustomization = false;
            this.OptionsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.OptionsBar});
            this.OptionsBarManager.Form = OptionsXtraUserControl;
            this.OptionsBarManager.MainMenu = this.OptionsBar;
			// 
            // OptionsPopUpMenu
            // 
            this.OptionsPopUpMenu.Manager = this.OptionsBarManager;
            this.OptionsPopUpMenu.Name = "OptionsPopUpMenu";
			//
			//OptionsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters OptionsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            OptionsRetriveFieldParameters.FieldName = "Options";
            OptionsRetriveFieldParameters.ControlForField = OptionsXtraUserControl;
			OptionsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(OptionsRetriveFieldParameters);
									//
			//BranchLookUpEdit
			//
			this.BranchBindingSource.DataSource = typeof(gtsco2.basededonne.Branch);
			this.BranchLookUpEdit.Properties.ValueMember = "Code_Branche"; 
			this.BranchLookUpEdit.Properties.DisplayMember = "Code_Branche";
			this.BranchLookUpEdit.Properties.DataSource = this.BranchBindingSource;
			this.BranchLookUpEdit.Name = "BranchLookUpEdit";
			this.BranchLookUpEdit.DataBindings.Add("EditValue", specialiteViewBindingSource, "ID_Branche", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters BranchLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            BranchLookUpEditRetrieveFieldParameters.FieldName = "ID_Branche";
            BranchLookUpEditRetrieveFieldParameters.ControlForField = this.BranchLookUpEdit;
			parameters.CustomListParameters.Add(BranchLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters BranchLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    BranchLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Branch";
		    BranchLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(BranchLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SpecialiteViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//SpecialiteView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "SpecialiteView";
						((System.ComponentModel.ISupportInitialize)(this.OptionsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource specialiteViewBindingSource;
				private DevExpress.XtraGrid.GridControl OptionsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView OptionsGridView;
		private DevExpress.XtraBars.BarManager OptionsBarManager;
		private DevExpress.XtraBars.Bar OptionsBar;
		private DevExpress.XtraEditors.XtraUserControl OptionsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu OptionsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiOptionsNew;
				private DevExpress.XtraBars.BarButtonItem bbiOptionsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiOptionsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiOptionsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit BranchLookUpEdit;
		private System.Windows.Forms.BindingSource BranchBindingSource;
		 
	}
}
