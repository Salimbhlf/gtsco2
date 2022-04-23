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
            this.evaluationCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNum_STG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStagiair = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStagiair1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colannee_scolaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControl_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControl_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRattrapage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnseignant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Année_SCO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Module = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Semestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoyenne_Module_ApRt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoyenne_Module_AvRt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.evaluationCollectionViewBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 126);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1022, 610);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // evaluationCollectionViewBindingSource
            // 
            this.evaluationCollectionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Evaluation);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNum_STG,
            this.colStagiair,
            this.colStagiair1,
            this.colSemestre,
            this.colannee_scolaire,
            this.colControl_1,
            this.colControl_2,
            this.colExam,
            this.colRattrapage,
            this.colEnseignant,
            this.colModule,
            this.colID_Année_SCO,
            this.colID_Module,
            this.colID_Semestre,
            this.colMoyenne_Module_ApRt,
            this.colMoyenne_Module_AvRt});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // colNum_STG
            // 
            this.colNum_STG.FieldName = "Num_STG";
            this.colNum_STG.Name = "colNum_STG";
            this.colNum_STG.Visible = true;
            this.colNum_STG.VisibleIndex = 0;
            // 
            // colStagiair
            // 
            this.colStagiair.Caption = "Nom stagiaire";
            this.colStagiair.FieldName = "Stagiair.Nom";
            this.colStagiair.Name = "colStagiair";
            this.colStagiair.Visible = true;
            this.colStagiair.VisibleIndex = 1;
            // 
            // colStagiair1
            // 
            this.colStagiair1.Caption = "Prenom stagiaire";
            this.colStagiair1.FieldName = "Stagiair.Prenom";
            this.colStagiair1.Name = "colStagiair1";
            this.colStagiair1.Visible = true;
            this.colStagiair1.VisibleIndex = 2;
            // 
            // colSemestre
            // 
            this.colSemestre.Caption = "Semestre";
            this.colSemestre.FieldName = "Semestre.Designation_Semestre";
            this.colSemestre.Name = "colSemestre";
            this.colSemestre.Visible = true;
            this.colSemestre.VisibleIndex = 3;
            // 
            // colannee_scolaire
            // 
            this.colannee_scolaire.Caption = "Année scolaire";
            this.colannee_scolaire.FieldName = "annee_scolaire.Designation";
            this.colannee_scolaire.FieldNameSortGroup = "Année scolaire";
            this.colannee_scolaire.Name = "colannee_scolaire";
            this.colannee_scolaire.Visible = true;
            this.colannee_scolaire.VisibleIndex = 4;
            // 
            // colControl_1
            // 
            this.colControl_1.FieldName = "Control_1";
            this.colControl_1.Name = "colControl_1";
            this.colControl_1.Visible = true;
            this.colControl_1.VisibleIndex = 6;
            // 
            // colControl_2
            // 
            this.colControl_2.FieldName = "Control_2";
            this.colControl_2.Name = "colControl_2";
            this.colControl_2.Visible = true;
            this.colControl_2.VisibleIndex = 7;
            // 
            // colExam
            // 
            this.colExam.FieldName = "Exam";
            this.colExam.Name = "colExam";
            this.colExam.Visible = true;
            this.colExam.VisibleIndex = 8;
            // 
            // colRattrapage
            // 
            this.colRattrapage.FieldName = "Rattrapage";
            this.colRattrapage.Name = "colRattrapage";
            this.colRattrapage.Visible = true;
            this.colRattrapage.VisibleIndex = 10;
            // 
            // colEnseignant
            // 
            this.colEnseignant.FieldName = "Enseignant1.Nom";
            this.colEnseignant.Name = "colEnseignant";
            this.colEnseignant.Visible = true;
            this.colEnseignant.VisibleIndex = 12;
            // 
            // colModule
            // 
            this.colModule.FieldName = "Module.Designation_Module";
            this.colModule.Name = "colModule";
            this.colModule.Visible = true;
            this.colModule.VisibleIndex = 5;
            // 
            // colID_Année_SCO
            // 
            this.colID_Année_SCO.FieldName = "ID_Année_SCO";
            this.colID_Année_SCO.Name = "colID_Année_SCO";
            // 
            // colID_Module
            // 
            this.colID_Module.FieldName = "ID_Module";
            this.colID_Module.Name = "colID_Module";
            // 
            // colID_Semestre
            // 
            this.colID_Semestre.FieldName = "ID_Semestre";
            this.colID_Semestre.Name = "colID_Semestre";
            // 
            // colMoyenne_Module_ApRt
            // 
            this.colMoyenne_Module_ApRt.FieldName = "Moyenne_Module_ApRt";
            this.colMoyenne_Module_ApRt.Name = "colMoyenne_Module_ApRt";
            this.colMoyenne_Module_ApRt.Visible = true;
            this.colMoyenne_Module_ApRt.VisibleIndex = 11;
            // 
            // colMoyenne_Module_AvRt
            // 
            this.colMoyenne_Module_AvRt.FieldName = "Moyenne_Module_AvRt";
            this.colMoyenne_Module_AvRt.Name = "colMoyenne_Module_AvRt";
            this.colMoyenne_Module_AvRt.Visible = true;
            this.colMoyenne_Module_AvRt.VisibleIndex = 9;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1022, 126);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Exporter et imprimer";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 2";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Ajouter";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Modifier";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Supprimer";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Actualiser";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Fichier";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Gestion des évaluations ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Exporter et imprimer";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1022, 27);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.EvaluationCollectionViewModel);
            // 
            // popupMenu
            // 
            this.popupMenu.ItemLinks.Add(this.bbiNew);
            this.popupMenu.ItemLinks.Add(this.bbiEdit);
            this.popupMenu.ItemLinks.Add(this.bbiDelete);
            this.popupMenu.ItemLinks.Add(this.bbiRefresh);
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbonControl;
            // 
            // EvaluationCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 736);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "EvaluationCollectionView";
            this.Text = "Evaluation";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationCollectionViewBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_STG;
        private DevExpress.XtraGrid.Columns.GridColumn colStagiair;
        private DevExpress.XtraGrid.Columns.GridColumn colStagiair1;
        private DevExpress.XtraGrid.Columns.GridColumn colSemestre;
        private DevExpress.XtraGrid.Columns.GridColumn colannee_scolaire;
        private DevExpress.XtraGrid.Columns.GridColumn colControl_1;
        private DevExpress.XtraGrid.Columns.GridColumn colControl_2;
        private DevExpress.XtraGrid.Columns.GridColumn colExam;
        private DevExpress.XtraGrid.Columns.GridColumn colRattrapage;
        private DevExpress.XtraGrid.Columns.GridColumn colEnseignant;
        private DevExpress.XtraGrid.Columns.GridColumn colModule;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Année_SCO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Module;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Semestre;
        private DevExpress.XtraGrid.Columns.GridColumn colMoyenne_Module_ApRt;
        private DevExpress.XtraGrid.Columns.GridColumn colMoyenne_Module_AvRt;
    }
}
