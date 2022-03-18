namespace gtsco2.mvvm.Views.EvaluationCollectionView {
    partial class EvaluationCollectionView {
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
			this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
			this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
			// 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.bbiPrintPreview, this.bsiRecordsCount});
																DevExpress.XtraBars.BarButtonItem bbiNew = new DevExpress.XtraBars.BarButtonItem();
			bbiNew.Caption = "New";
			bbiNew.Name = "bbiNew";
			bbiNew.ImageUri.Uri = "New";
						this.ribbonControl.Items.Add(bbiNew);
								DevExpress.XtraBars.BarButtonItem bbiEdit = new DevExpress.XtraBars.BarButtonItem();
			bbiEdit.Caption = "Edit";
			bbiEdit.Name = "bbiEdit";
			bbiEdit.ImageUri.Uri = "Edit";
						this.ribbonControl.Items.Add(bbiEdit);
								DevExpress.XtraBars.BarButtonItem bbiDelete = new DevExpress.XtraBars.BarButtonItem();
			bbiDelete.Caption = "Delete";
			bbiDelete.Name = "bbiDelete";
			bbiDelete.ImageUri.Uri = "Delete";
						this.ribbonControl.Items.Add(bbiDelete);
										DevExpress.XtraBars.BarButtonItem bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
			bbiRefresh.Caption = "Refresh";
			bbiRefresh.Name = "bbiRefresh";
			bbiRefresh.ImageUri.Uri = "Refresh";
						this.ribbonControl.Items.Add(bbiRefresh);
	
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
			this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Evaluation Tasks";
								this.ribbonPageGroup1.ItemLinks.Add(bbiNew);
			this.ribbonPageGroup1.ItemLinks.Add(bbiEdit);
			this.ribbonPageGroup1.ItemLinks.Add(bbiDelete);
					this.ribbonPageGroup1.ItemLinks.Add(bbiRefresh);
	
			// 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Export";
			this.ribbonPageGroup2.AllowTextClipping = false;
			this.ribbonPageGroup2.ShowCaptionButton = false;
			// 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
			// 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
			// 
            // barStaticItem1
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 2";
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            this.bsiRecordsCount.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(5, 116);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(779, 311);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
			this.evaluationCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.evaluationCollectionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Evaluation);
			this.gridControl.DataSource = evaluationCollectionViewBindingSource;

			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters parameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
						//
			//annee_scolaire
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters annee_scolairePopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            annee_scolairePopulateColumnParameters.FieldName = "annee_scolaire";
            annee_scolairePopulateColumnParameters.Path = "annee_scolaire.Designation";
			parameters.CustomColumnParameters.Add(annee_scolairePopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters annee_scolairePopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            annee_scolairePopulateColumnParameters_NotGenerate.FieldName = "ID_Année_SCO";
		    annee_scolairePopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(annee_scolairePopulateColumnParameters_NotGenerate);
									//
			//Enseignant1
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Enseignant1PopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Enseignant1PopulateColumnParameters.FieldName = "Enseignant1";
            Enseignant1PopulateColumnParameters.Path = "Enseignant1.Nom";
			parameters.CustomColumnParameters.Add(Enseignant1PopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Enseignant1PopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Enseignant1PopulateColumnParameters_NotGenerate.FieldName = "Enseignant";
		    Enseignant1PopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Enseignant1PopulateColumnParameters_NotGenerate);
									//
			//Module
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulePopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulePopulateColumnParameters.FieldName = "Module";
            ModulePopulateColumnParameters.Path = "Module.Designation_Module";
			parameters.CustomColumnParameters.Add(ModulePopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulePopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulePopulateColumnParameters_NotGenerate.FieldName = "ID_Module";
		    ModulePopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(ModulePopulateColumnParameters_NotGenerate);
									//
			//Semestre
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SemestrePopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SemestrePopulateColumnParameters.FieldName = "Semestre";
            SemestrePopulateColumnParameters.Path = "Semestre.Designation_Semestre";
			parameters.CustomColumnParameters.Add(SemestrePopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters SemestrePopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SemestrePopulateColumnParameters_NotGenerate.FieldName = "ID_Semestre";
		    SemestrePopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(SemestrePopulateColumnParameters_NotGenerate);
									//
			//Stagiair
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairPopulateColumnParameters.FieldName = "Stagiair";
            StagiairPopulateColumnParameters.Path = "Stagiair.Num_STG";
			parameters.CustomColumnParameters.Add(StagiairPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairPopulateColumnParameters_NotGenerate.FieldName = "Num_STG";
		    StagiairPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(StagiairPopulateColumnParameters_NotGenerate);
						 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters annee_scolairePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            annee_scolairePopulateColumnParameters_NotVisible.FieldName = "annee_scolaire";
		    annee_scolairePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(annee_scolairePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Enseignant1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Enseignant1PopulateColumnParameters_NotVisible.FieldName = "Enseignant1";
		    Enseignant1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Enseignant1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulePopulateColumnParameters_NotVisible.FieldName = "Module";
		    ModulePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(ModulePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SemestrePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SemestrePopulateColumnParameters_NotVisible.FieldName = "Semestre";
		    SemestrePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(SemestrePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters StagiairPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StagiairPopulateColumnParameters_NotVisible.FieldName = "Stagiair";
		    StagiairPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(StagiairPopulateColumnParameters_NotVisible);
						this.gridView.PopulateColumns(typeof(gtsco2.basededonne.Evaluation),parameters);
			// 
            // popupMenu1
            // 
								this.popupMenu.ItemLinks.Add(bbiNew);
			this.popupMenu.ItemLinks.Add(bbiEdit);
			this.popupMenu.ItemLinks.Add(bbiDelete);
					this.popupMenu.ItemLinks.Add(bbiRefresh);
	
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbonControl;
		    // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel);
								this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "New", bbiNew));
			this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "Edit", "SelectedEntity", bbiEdit));
			this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "Delete", "SelectedEntity", bbiDelete));
					this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "Refresh", bbiRefresh));
	
			this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl)});
			//
			//EvaluationCollectionView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
			this.Controls.Add(this.ribbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "EvaluationCollectionView";
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private System.Windows.Forms.BindingSource evaluationCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
	}
}
