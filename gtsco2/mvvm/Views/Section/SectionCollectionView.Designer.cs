namespace gtsco2.mvvm.Views.SectionCollectionView {
    partial class SectionCollectionView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionCollectionView));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sectionCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSectionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode_Section = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOption1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOption2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMode_formation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMode_formation1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colannee_scolaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnnee_secolir_en_coure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemestre_en_coure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Mode_Formation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Option = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Promo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.sectionCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sectionCollectionViewBindingSource;
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
            // sectionCollectionViewBindingSource
            // 
            this.sectionCollectionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Section);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSectionID,
            this.colCode_Section,
            this.colPromo,
            this.colOption,
            this.colOption1,
            this.colOption2,
            this.colMode_formation,
            this.colMode_formation1,
            this.colannee_scolaire,
            this.colAnnee_secolir_en_coure,
            this.colSemestre,
            this.colSemestre_en_coure,
            this.colID_Mode_Formation,
            this.colID_Option,
            this.colID_Promo});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // colSectionID
            // 
            this.colSectionID.FieldName = "SectionID";
            this.colSectionID.Name = "colSectionID";
            // 
            // colCode_Section
            // 
            this.colCode_Section.FieldName = "Code_Section";
            this.colCode_Section.Name = "colCode_Section";
            this.colCode_Section.Visible = true;
            this.colCode_Section.VisibleIndex = 0;
            // 
            // colPromo
            // 
            this.colPromo.FieldName = "Promo.Code_Promo";
            this.colPromo.Name = "colPromo";
            this.colPromo.Visible = true;
            this.colPromo.VisibleIndex = 1;
            // 
            // colOption
            // 
            this.colOption.FieldName = "Option.Designation_Option";
            this.colOption.Name = "colOption";
            this.colOption.Visible = true;
            this.colOption.VisibleIndex = 2;
            // 
            // colOption1
            // 
            this.colOption1.Caption = "Code option";
            this.colOption1.FieldName = "Option.Code_Option";
            this.colOption1.Name = "colOption1";
            this.colOption1.Visible = true;
            this.colOption1.VisibleIndex = 3;
            // 
            // colOption2
            // 
            this.colOption2.Caption = "Désignation option";
            this.colOption2.FieldName = "Option.Designation_Option";
            this.colOption2.Name = "colOption2";
            this.colOption2.Visible = true;
            this.colOption2.VisibleIndex = 4;
            // 
            // colMode_formation
            // 
            this.colMode_formation.Caption = "Code mode formation";
            this.colMode_formation.FieldName = "Mode_formation.Code_Mode_Formation";
            this.colMode_formation.Name = "colMode_formation";
            this.colMode_formation.Visible = true;
            this.colMode_formation.VisibleIndex = 7;
            // 
            // colMode_formation1
            // 
            this.colMode_formation1.Caption = "mode formation";
            this.colMode_formation1.FieldName = "Mode_formation.Désignation_Mode_Formation";
            this.colMode_formation1.Name = "colMode_formation1";
            this.colMode_formation1.Visible = true;
            this.colMode_formation1.VisibleIndex = 8;
            // 
            // colannee_scolaire
            // 
            this.colannee_scolaire.FieldName = "annee_scolaire";
            this.colannee_scolaire.Name = "colannee_scolaire";
            // 
            // colAnnee_secolir_en_coure
            // 
            this.colAnnee_secolir_en_coure.Caption = "Année scolaire en cours";
            this.colAnnee_secolir_en_coure.FieldName = "annee_scolaire.Designation";
            this.colAnnee_secolir_en_coure.Name = "colAnnee_secolir_en_coure";
            this.colAnnee_secolir_en_coure.Visible = true;
            this.colAnnee_secolir_en_coure.VisibleIndex = 6;
            // 
            // colSemestre
            // 
            this.colSemestre.FieldName = "Semestre.Designation_Semestre";
            this.colSemestre.Name = "colSemestre";
            // 
            // colSemestre_en_coure
            // 
            this.colSemestre_en_coure.Caption = "Semestre en cours";
            this.colSemestre_en_coure.FieldName = "Semestre.Designation_Semestre";
            this.colSemestre_en_coure.Name = "colSemestre_en_coure";
            this.colSemestre_en_coure.Visible = true;
            this.colSemestre_en_coure.VisibleIndex = 5;
            // 
            // colID_Mode_Formation
            // 
            this.colID_Mode_Formation.FieldName = "ID_Mode_Formation";
            this.colID_Mode_Formation.Name = "colID_Mode_Formation";
            // 
            // colID_Option
            // 
            this.colID_Option.FieldName = "ID_Option";
            this.colID_Option.Name = "colID_Option";
            // 
            // colID_Promo
            // 
            this.colID_Promo.FieldName = "ID_Promo";
            this.colID_Promo.Name = "colID_Promo";
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
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
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
            this.bbiEdit.Caption = "Modifier ";
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
            this.ribbonPageGroup1.Text = "Gestion des Sections";
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
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SectionCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.SectionCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.SectionCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.SectionCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.SectionCollectionViewModel);
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
            // SectionCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 736);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SectionCollectionView.IconOptions.LargeImage")));
            this.Name = "SectionCollectionView";
            this.Text = "Section";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionCollectionViewBindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource sectionCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Section;
        private DevExpress.XtraGrid.Columns.GridColumn colPromo;
        private DevExpress.XtraGrid.Columns.GridColumn colOption;
        private DevExpress.XtraGrid.Columns.GridColumn colOption1;
        private DevExpress.XtraGrid.Columns.GridColumn colOption2;
        private DevExpress.XtraGrid.Columns.GridColumn colMode_formation;
        private DevExpress.XtraGrid.Columns.GridColumn colMode_formation1;
        private DevExpress.XtraGrid.Columns.GridColumn colannee_scolaire;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnee_secolir_en_coure;
        private DevExpress.XtraGrid.Columns.GridColumn colSemestre;
        private DevExpress.XtraGrid.Columns.GridColumn colSemestre_en_coure;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Mode_Formation;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Option;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Promo;
    }
}
