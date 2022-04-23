namespace gtsco2.mvvm.Views.Avenant_contrat_prorogationCollectionView {
    partial class Avenant_contrat_prorogationCollectionView {
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
            this.avenant_contrat_prorogationCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNum_validation_cont_proro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_stg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStagiair = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStagiair1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_dbt_proro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_fin_proro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_validation_cont_proro = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.avenant_contrat_prorogationCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.avenant_contrat_prorogationCollectionViewBindingSource;
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
            // avenant_contrat_prorogationCollectionViewBindingSource
            // 
            this.avenant_contrat_prorogationCollectionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Avenant_contrat_prorogation);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNum_validation_cont_proro,
            this.colNum_stg,
            this.colStagiair,
            this.colStagiair1,
            this.colEmployeur,
            this.coldate_dbt_proro,
            this.coldate_fin_proro,
            this.colDuree,
            this.coldate_validation_cont_proro});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // colNum_validation_cont_proro
            // 
            this.colNum_validation_cont_proro.Caption = "Numéro validation contrat prorogation";
            this.colNum_validation_cont_proro.FieldName = "Num_validation_cont_proro";
            this.colNum_validation_cont_proro.Name = "colNum_validation_cont_proro";
            this.colNum_validation_cont_proro.Visible = true;
            this.colNum_validation_cont_proro.VisibleIndex = 3;
            this.colNum_validation_cont_proro.Width = 203;
            // 
            // colNum_stg
            // 
            this.colNum_stg.FieldName = "Num_stg";
            this.colNum_stg.Name = "colNum_stg";
            this.colNum_stg.Visible = true;
            this.colNum_stg.VisibleIndex = 0;
            this.colNum_stg.Width = 102;
            // 
            // colStagiair
            // 
            this.colStagiair.FieldName = "Stagiair.Nom";
            this.colStagiair.Name = "colStagiair";
            this.colStagiair.Visible = true;
            this.colStagiair.VisibleIndex = 1;
            this.colStagiair.Width = 119;
            // 
            // colStagiair1
            // 
            this.colStagiair1.Caption = "Prénom";
            this.colStagiair1.FieldName = "Stagiair.Prenom";
            this.colStagiair1.Name = "colStagiair1";
            this.colStagiair1.Visible = true;
            this.colStagiair1.VisibleIndex = 2;
            this.colStagiair1.Width = 119;
            // 
            // colEmployeur
            // 
            this.colEmployeur.FieldName = "Employeur.Nom_Emp";
            this.colEmployeur.Name = "colEmployeur";
            this.colEmployeur.Visible = true;
            this.colEmployeur.VisibleIndex = 4;
            this.colEmployeur.Width = 98;
            // 
            // coldate_dbt_proro
            // 
            this.coldate_dbt_proro.Caption = "Date début prorogation ";
            this.coldate_dbt_proro.FieldName = "date_dbt_proro";
            this.coldate_dbt_proro.Name = "coldate_dbt_proro";
            this.coldate_dbt_proro.Visible = true;
            this.coldate_dbt_proro.VisibleIndex = 6;
            this.coldate_dbt_proro.Width = 103;
            // 
            // coldate_fin_proro
            // 
            this.coldate_fin_proro.Caption = "Date fin prorogation ";
            this.coldate_fin_proro.FieldName = "date_fin_proro";
            this.coldate_fin_proro.Name = "coldate_fin_proro";
            this.coldate_fin_proro.Visible = true;
            this.coldate_fin_proro.VisibleIndex = 7;
            this.coldate_fin_proro.Width = 93;
            // 
            // colDuree
            // 
            this.colDuree.Caption = "Durée (mois)";
            this.colDuree.FieldName = "Duree";
            this.colDuree.Name = "colDuree";
            this.colDuree.Visible = true;
            this.colDuree.VisibleIndex = 8;
            this.colDuree.Width = 82;
            // 
            // coldate_validation_cont_proro
            // 
            this.coldate_validation_cont_proro.Caption = "Date validation contrat prorogation";
            this.coldate_validation_cont_proro.FieldName = "date_validation_cont_proro";
            this.coldate_validation_cont_proro.Name = "coldate_validation_cont_proro";
            this.coldate_validation_cont_proro.Visible = true;
            this.coldate_validation_cont_proro.VisibleIndex = 5;
            this.coldate_validation_cont_proro.Width = 144;
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
            this.bbiDelete.Caption = "Supprimer ";
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
            this.ribbonPageGroup1.Text = "Gestion des avenants de contrat de prorogation";
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
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Avenant_contrat_prorogationCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.Avenant_contrat_prorogationCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.Avenant_contrat_prorogationCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Avenant_contrat_prorogationCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.Avenant_contrat_prorogationCollectionViewModel);
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
            // Avenant_contrat_prorogationCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 736);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Avenant_contrat_prorogationCollectionView";
            this.Text = "Avenant contrat prorogation";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avenant_contrat_prorogationCollectionViewBindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource avenant_contrat_prorogationCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_validation_cont_proro;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_stg;
        private DevExpress.XtraGrid.Columns.GridColumn colStagiair;
        private DevExpress.XtraGrid.Columns.GridColumn colStagiair1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeur;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_dbt_proro;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_fin_proro;
        private DevExpress.XtraGrid.Columns.GridColumn colDuree;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_validation_cont_proro;
    }
}
