namespace gtsco2.mvvm.Views.Contract_avenant_changementCollectionView {
    partial class Contract_avenant_changementCollectionView {
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
            this.contract_avenant_changementCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colNUM_AV_CHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUM_AV_VALID_CHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_stg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStagiair = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStagiair1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_AV_VALID_CHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_DBT_FORMA_CHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FIN_FORMA_ANCIEN_EMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FIN_FORMA_CHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_avenant_changementCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.contract_avenant_changementCollectionViewBindingSource;
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
            // contract_avenant_changementCollectionViewBindingSource
            // 
            this.contract_avenant_changementCollectionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Contract_avenant_changement);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNUM_AV_CHANG,
            this.colNUM_AV_VALID_CHANG,
            this.colnum_stg,
            this.colStagiair,
            this.colStagiair1,
            this.colDATE_AV_VALID_CHANG,
            this.colid_emp,
            this.colEmployeur,
            this.colDATE_DBT_FORMA_CHANG,
            this.colDATE_FIN_FORMA_ANCIEN_EMP,
            this.colDATE_FIN_FORMA_CHANG});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
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
            this.bbiEdit.Caption = "Modifier";
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
            this.bbiRefresh.Caption = "Actualiser ";
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
            this.ribbonPageGroup1.Text = "Gestion des avenants de contrat changement d\'employeur ";
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
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Contract_avenant_changementCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.Contract_avenant_changementCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.Contract_avenant_changementCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Contract_avenant_changementCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.Contract_avenant_changementCollectionViewModel);
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
            // colNUM_AV_CHANG
            // 
            this.colNUM_AV_CHANG.FieldName = "NUM_AV_CHANG";
            this.colNUM_AV_CHANG.Name = "colNUM_AV_CHANG";
            this.colNUM_AV_CHANG.Visible = true;
            this.colNUM_AV_CHANG.VisibleIndex = 0;
            // 
            // colNUM_AV_VALID_CHANG
            // 
            this.colNUM_AV_VALID_CHANG.FieldName = "NUM_AV_VALID_CHANG";
            this.colNUM_AV_VALID_CHANG.Name = "colNUM_AV_VALID_CHANG";
            this.colNUM_AV_VALID_CHANG.Visible = true;
            this.colNUM_AV_VALID_CHANG.VisibleIndex = 1;
            // 
            // colnum_stg
            // 
            this.colnum_stg.FieldName = "num_stg";
            this.colnum_stg.Name = "colnum_stg";
            this.colnum_stg.Visible = true;
            this.colnum_stg.VisibleIndex = 2;
            // 
            // colStagiair
            // 
            this.colStagiair.Caption = "Nom stagiaire ";
            this.colStagiair.FieldName = "Stagiair.Nom";
            this.colStagiair.Name = "colStagiair";
            this.colStagiair.Visible = true;
            this.colStagiair.VisibleIndex = 3;
            // 
            // colStagiair1
            // 
            this.colStagiair1.Caption = "Prénom stagiaire";
            this.colStagiair1.FieldName = "Stagiair.Prenom";
            this.colStagiair1.Name = "colStagiair1";
            this.colStagiair1.Visible = true;
            this.colStagiair1.VisibleIndex = 4;
            // 
            // colDATE_AV_VALID_CHANG
            // 
            this.colDATE_AV_VALID_CHANG.FieldName = "DATE_AV_VALID_CHANG";
            this.colDATE_AV_VALID_CHANG.Name = "colDATE_AV_VALID_CHANG";
            this.colDATE_AV_VALID_CHANG.Visible = true;
            this.colDATE_AV_VALID_CHANG.VisibleIndex = 6;
            // 
            // colEmployeur
            // 
            this.colEmployeur.FieldName = "Employeur";
            this.colEmployeur.Name = "colEmployeur";
            this.colEmployeur.Visible = true;
            this.colEmployeur.VisibleIndex = 5;
            // 
            // colid_emp
            // 
            this.colid_emp.FieldName = "id_emp";
            this.colid_emp.Name = "colid_emp";
            // 
            // colDATE_DBT_FORMA_CHANG
            // 
            this.colDATE_DBT_FORMA_CHANG.FieldName = "DATE_DBT_FORMA_CHANG";
            this.colDATE_DBT_FORMA_CHANG.Name = "colDATE_DBT_FORMA_CHANG";
            this.colDATE_DBT_FORMA_CHANG.Visible = true;
            this.colDATE_DBT_FORMA_CHANG.VisibleIndex = 7;
            // 
            // colDATE_FIN_FORMA_ANCIEN_EMP
            // 
            this.colDATE_FIN_FORMA_ANCIEN_EMP.FieldName = "DATE_FIN_FORMA_ANCIEN_EMP";
            this.colDATE_FIN_FORMA_ANCIEN_EMP.Name = "colDATE_FIN_FORMA_ANCIEN_EMP";
            this.colDATE_FIN_FORMA_ANCIEN_EMP.Visible = true;
            this.colDATE_FIN_FORMA_ANCIEN_EMP.VisibleIndex = 8;
            // 
            // colDATE_FIN_FORMA_CHANG
            // 
            this.colDATE_FIN_FORMA_CHANG.FieldName = "DATE_FIN_FORMA_CHANG";
            this.colDATE_FIN_FORMA_CHANG.Name = "colDATE_FIN_FORMA_CHANG";
            this.colDATE_FIN_FORMA_CHANG.Visible = true;
            this.colDATE_FIN_FORMA_CHANG.VisibleIndex = 9;
            // 
            // Contract_avenant_changementCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 736);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Contract_avenant_changementCollectionView";
            this.Text = "Avenant de contrat changement d\'employeur ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_avenant_changementCollectionViewBindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource contract_avenant_changementCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_AV_CHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_AV_VALID_CHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_stg;
        private DevExpress.XtraGrid.Columns.GridColumn colStagiair;
        private DevExpress.XtraGrid.Columns.GridColumn colStagiair1;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_AV_VALID_CHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colid_emp;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeur;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_DBT_FORMA_CHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FIN_FORMA_ANCIEN_EMP;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FIN_FORMA_CHANG;
    }
}
