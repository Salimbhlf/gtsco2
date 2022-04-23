namespace gtsco2.mvvm.Views.EmployeurCollectionView {
    partial class EmployeurCollectionView {
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
            this.employeurCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.colID_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Emp_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatut_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecteur_Activité_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNature_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse_Emp_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode_Postal_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFonction_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQouta_MIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuota_max = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeurCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.employeurCollectionViewBindingSource;
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
            // employeurCollectionViewBindingSource
            // 
            this.employeurCollectionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Employeur);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Emp,
            this.colNom_Emp,
            this.colNom_Emp_ar,
            this.colTel_Emp,
            this.colMail_Emp,
            this.colType_Emp,
            this.colStatut_Emp,
            this.colSecteur_Activité_Emp,
            this.colNature_Emp,
            this.colAdresse_Emp,
            this.colAdresse_Emp_ar,
            this.colCode_Postal_Emp,
            this.colFax_Emp,
            this.colFonction_Emp,
            this.colQouta_MIN,
            this.colQuota_max});
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
            this.ribbonPageGroup1.Text = "Gestion des Employeurs";
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
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.EmployeurCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.EmployeurCollectionViewModel);
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
            // colID_Emp
            // 
            this.colID_Emp.FieldName = "ID_Emp";
            this.colID_Emp.Name = "colID_Emp";
            // 
            // colNom_Emp
            // 
            this.colNom_Emp.FieldName = "Nom_Emp";
            this.colNom_Emp.Name = "colNom_Emp";
            this.colNom_Emp.Visible = true;
            this.colNom_Emp.VisibleIndex = 0;
            // 
            // colNom_Emp_ar
            // 
            this.colNom_Emp_ar.FieldName = "Nom_Emp_ar";
            this.colNom_Emp_ar.Name = "colNom_Emp_ar";
            // 
            // colTel_Emp
            // 
            this.colTel_Emp.FieldName = "Tel_Emp";
            this.colTel_Emp.Name = "colTel_Emp";
            this.colTel_Emp.Visible = true;
            this.colTel_Emp.VisibleIndex = 1;
            // 
            // colMail_Emp
            // 
            this.colMail_Emp.FieldName = "Mail_Emp";
            this.colMail_Emp.Name = "colMail_Emp";
            this.colMail_Emp.Visible = true;
            this.colMail_Emp.VisibleIndex = 2;
            // 
            // colType_Emp
            // 
            this.colType_Emp.FieldName = "Type_Emp";
            this.colType_Emp.Name = "colType_Emp";
            this.colType_Emp.Visible = true;
            this.colType_Emp.VisibleIndex = 6;
            // 
            // colStatut_Emp
            // 
            this.colStatut_Emp.FieldName = "Statut_Emp";
            this.colStatut_Emp.Name = "colStatut_Emp";
            this.colStatut_Emp.Visible = true;
            this.colStatut_Emp.VisibleIndex = 7;
            // 
            // colSecteur_Activité_Emp
            // 
            this.colSecteur_Activité_Emp.FieldName = "Secteur_Activité_Emp";
            this.colSecteur_Activité_Emp.Name = "colSecteur_Activité_Emp";
            this.colSecteur_Activité_Emp.Visible = true;
            this.colSecteur_Activité_Emp.VisibleIndex = 8;
            // 
            // colNature_Emp
            // 
            this.colNature_Emp.FieldName = "Nature_Emp";
            this.colNature_Emp.Name = "colNature_Emp";
            this.colNature_Emp.Visible = true;
            this.colNature_Emp.VisibleIndex = 9;
            // 
            // colAdresse_Emp
            // 
            this.colAdresse_Emp.FieldName = "Adresse_Emp";
            this.colAdresse_Emp.Name = "colAdresse_Emp";
            this.colAdresse_Emp.Visible = true;
            this.colAdresse_Emp.VisibleIndex = 4;
            // 
            // colAdresse_Emp_ar
            // 
            this.colAdresse_Emp_ar.FieldName = "Adresse_Emp_ar";
            this.colAdresse_Emp_ar.Name = "colAdresse_Emp_ar";
            // 
            // colCode_Postal_Emp
            // 
            this.colCode_Postal_Emp.FieldName = "Code_Postal_Emp";
            this.colCode_Postal_Emp.Name = "colCode_Postal_Emp";
            this.colCode_Postal_Emp.Visible = true;
            this.colCode_Postal_Emp.VisibleIndex = 3;
            // 
            // colFax_Emp
            // 
            this.colFax_Emp.FieldName = "Fax_Emp";
            this.colFax_Emp.Name = "colFax_Emp";
            this.colFax_Emp.Visible = true;
            this.colFax_Emp.VisibleIndex = 5;
            // 
            // colFonction_Emp
            // 
            this.colFonction_Emp.FieldName = "Fonction_Emp";
            this.colFonction_Emp.Name = "colFonction_Emp";
            this.colFonction_Emp.Visible = true;
            this.colFonction_Emp.VisibleIndex = 10;
            // 
            // colQouta_MIN
            // 
            this.colQouta_MIN.FieldName = "Qouta_MIN";
            this.colQouta_MIN.Name = "colQouta_MIN";
            this.colQouta_MIN.Visible = true;
            this.colQouta_MIN.VisibleIndex = 11;
            // 
            // colQuota_max
            // 
            this.colQuota_max.FieldName = "Quota_max";
            this.colQuota_max.Name = "colQuota_max";
            this.colQuota_max.Visible = true;
            this.colQuota_max.VisibleIndex = 12;
            // 
            // EmployeurCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 736);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "EmployeurCollectionView";
            this.Text = "Employeur";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeurCollectionViewBindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource employeurCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Emp_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colTel_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colMail_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colType_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colStatut_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colSecteur_Activité_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colNature_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse_Emp_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Postal_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colFax_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colFonction_Emp;
        private DevExpress.XtraGrid.Columns.GridColumn colQouta_MIN;
        private DevExpress.XtraGrid.Columns.GridColumn colQuota_max;
    }
}
