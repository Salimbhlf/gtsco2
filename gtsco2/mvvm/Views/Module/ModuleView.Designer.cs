namespace gtsco2.mvvm.Views.ModuleView {
    partial class ModuleView {
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
            this.mainRibbonPageGroup.Text = "Module Tasks";
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
			this.moduleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.moduleViewBindingSource.DataSource = typeof(gtsco2.basededonne.Module);
			this.dataLayoutControl1.DataSource = moduleViewBindingSource;
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters OptionEvaluationsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            OptionEvaluationsChildPopulateColumnParameters.FieldName = "OptionEvaluations";
            OptionEvaluationsChildPopulateColumnParameters.Path = "Option.Code_Option";
			EvaluationsPopulateColumnsParameters.CustomColumnParameters.Add(OptionEvaluationsChildPopulateColumnParameters);
			 
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
			//OptionLookUpEdit
			//
			this.OptionBindingSource.DataSource = typeof(gtsco2.basededonne.Option);
			this.OptionLookUpEdit.Properties.ValueMember = "ID_Option"; 
			this.OptionLookUpEdit.Properties.DisplayMember = "Code_Option";
			this.OptionLookUpEdit.Properties.DataSource = this.OptionBindingSource;
			this.OptionLookUpEdit.Name = "OptionLookUpEdit";
			this.OptionLookUpEdit.DataBindings.Add("EditValue", moduleViewBindingSource, "ID_Option", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
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
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.ModuleViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.ModuleViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//ModuleView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ModuleView";
						((System.ComponentModel.ISupportInitialize)(this.EvaluationsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource moduleViewBindingSource;
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
								private DevExpress.XtraEditors.GridLookUpEdit OptionLookUpEdit;
		private System.Windows.Forms.BindingSource OptionBindingSource;
		 
	}
}
