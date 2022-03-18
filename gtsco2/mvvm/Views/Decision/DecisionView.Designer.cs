namespace gtsco2.mvvm.Views.DecisionView {
    partial class DecisionView {
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
									this.Proce_verbal_delibationLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.Proce_verbal_delibationBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.PromoLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.PromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.SemestreLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.SemestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.StagiairLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.StagiairBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
            this.mainRibbonPageGroup.Text = "Decision Tasks";
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
			this.decisionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.decisionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Decision);
			this.dataLayoutControl1.DataSource = decisionViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
									//
			//Proce_verbal_delibationLookUpEdit
			//
			this.Proce_verbal_delibationBindingSource.DataSource = typeof(gtsco2.basededonne.Proce_verbal_delibation);
			this.Proce_verbal_delibationLookUpEdit.Properties.ValueMember = "ID_PV_Délibiration"; 
			this.Proce_verbal_delibationLookUpEdit.Properties.DisplayMember = "ID_PV_Délibiration";
			this.Proce_verbal_delibationLookUpEdit.Properties.DataSource = this.Proce_verbal_delibationBindingSource;
			this.Proce_verbal_delibationLookUpEdit.Name = "Proce_verbal_delibationLookUpEdit";
			this.Proce_verbal_delibationLookUpEdit.DataBindings.Add("EditValue", decisionViewBindingSource, "ID_PV_Délibiration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Proce_verbal_delibationLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Proce_verbal_delibationLookUpEditRetrieveFieldParameters.FieldName = "ID_PV_Délibiration";
            Proce_verbal_delibationLookUpEditRetrieveFieldParameters.ControlForField = this.Proce_verbal_delibationLookUpEdit;
			parameters.CustomListParameters.Add(Proce_verbal_delibationLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Proce_verbal_delibationLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    Proce_verbal_delibationLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Proce_verbal_delibation";
		    Proce_verbal_delibationLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(Proce_verbal_delibationLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//PromoLookUpEdit
			//
			this.PromoBindingSource.DataSource = typeof(gtsco2.basededonne.Promo);
			this.PromoLookUpEdit.Properties.ValueMember = "ID_Promo"; 
			this.PromoLookUpEdit.Properties.DisplayMember = "Code_Promo";
			this.PromoLookUpEdit.Properties.DataSource = this.PromoBindingSource;
			this.PromoLookUpEdit.Name = "PromoLookUpEdit";
			this.PromoLookUpEdit.DataBindings.Add("EditValue", decisionViewBindingSource, "ID_Promo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PromoLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            PromoLookUpEditRetrieveFieldParameters.FieldName = "ID_Promo";
            PromoLookUpEditRetrieveFieldParameters.ControlForField = this.PromoLookUpEdit;
			parameters.CustomListParameters.Add(PromoLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters PromoLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    PromoLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Promo";
		    PromoLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(PromoLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//SemestreLookUpEdit
			//
			this.SemestreBindingSource.DataSource = typeof(gtsco2.basededonne.Semestre);
			this.SemestreLookUpEdit.Properties.ValueMember = "ID_Semestre"; 
			this.SemestreLookUpEdit.Properties.DisplayMember = "Designation_Semestre";
			this.SemestreLookUpEdit.Properties.DataSource = this.SemestreBindingSource;
			this.SemestreLookUpEdit.Name = "SemestreLookUpEdit";
			this.SemestreLookUpEdit.DataBindings.Add("EditValue", decisionViewBindingSource, "ID_Semestre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters SemestreLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            SemestreLookUpEditRetrieveFieldParameters.FieldName = "ID_Semestre";
            SemestreLookUpEditRetrieveFieldParameters.ControlForField = this.SemestreLookUpEdit;
			parameters.CustomListParameters.Add(SemestreLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters SemestreLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    SemestreLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Semestre";
		    SemestreLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(SemestreLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//StagiairLookUpEdit
			//
			this.StagiairBindingSource.DataSource = typeof(gtsco2.basededonne.Stagiair);
			this.StagiairLookUpEdit.Properties.ValueMember = "Num_STG"; 
			this.StagiairLookUpEdit.Properties.DisplayMember = "Num_STG";
			this.StagiairLookUpEdit.Properties.DataSource = this.StagiairBindingSource;
			this.StagiairLookUpEdit.Name = "StagiairLookUpEdit";
			this.StagiairLookUpEdit.DataBindings.Add("EditValue", decisionViewBindingSource, "Num_STG", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters StagiairLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            StagiairLookUpEditRetrieveFieldParameters.FieldName = "Num_STG";
            StagiairLookUpEditRetrieveFieldParameters.ControlForField = this.StagiairLookUpEdit;
			parameters.CustomListParameters.Add(StagiairLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters StagiairLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    StagiairLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Stagiair";
		    StagiairLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(StagiairLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.DecisionViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.DecisionViewModel), "ResetLayout", bbiResetLayout));
					    this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//DecisionView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "DecisionView";
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
		private System.Windows.Forms.BindingSource decisionViewBindingSource;
						private DevExpress.XtraEditors.GridLookUpEdit Proce_verbal_delibationLookUpEdit;
		private System.Windows.Forms.BindingSource Proce_verbal_delibationBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit PromoLookUpEdit;
		private System.Windows.Forms.BindingSource PromoBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit SemestreLookUpEdit;
		private System.Windows.Forms.BindingSource SemestreBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit StagiairLookUpEdit;
		private System.Windows.Forms.BindingSource StagiairBindingSource;
		 
	}
}
