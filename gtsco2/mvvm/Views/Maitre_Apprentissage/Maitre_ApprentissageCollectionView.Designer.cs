namespace gtsco2.mvvm.Views.Maitre_ApprentissageCollectionView {
    partial class Maitre_ApprentissageCollectionView {
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
            this.maitre_ApprentissageCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenom_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQualification_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfil_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoste_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colE_Mail_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnciennté_Entriprise_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnciennté_Métier_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAyant_Suivie_Stage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommune = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommune_Maitre_Apprentissage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNbr_Stagiaire_Former = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Emp = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.maitre_ApprentissageCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.maitre_ApprentissageCollectionViewBindingSource;
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
            // maitre_ApprentissageCollectionViewBindingSource
            // 
            this.maitre_ApprentissageCollectionViewBindingSource.DataSource = typeof(gtsco2.basededonne.Maitre_Apprentissage);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Maitre_Apprentissage,
            this.colNom_Maitre_Apprentissage,
            this.colPrenom_Maitre_Apprentissage,
            this.colQualification_Maitre_Apprentissage,
            this.colProfil_Maitre_Apprentissage,
            this.colTel_Maitre_Apprentissage,
            this.colPoste_Maitre_Apprentissage,
            this.colE_Mail_Maitre_Apprentissage,
            this.colEmployeur,
            this.colAdresse_Maitre_Apprentissage,
            this.colAnciennté_Entriprise_Maitre_Apprentissage,
            this.colAnciennté_Métier_Maitre_Apprentissage,
            this.colAyant_Suivie_Stage,
            this.colCommune,
            this.colCommune_Maitre_Apprentissage,
            this.colNbr_Stagiaire_Former,
            this.colID_Emp});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // colID_Maitre_Apprentissage
            // 
            this.colID_Maitre_Apprentissage.FieldName = "ID_Maitre_Apprentissage";
            this.colID_Maitre_Apprentissage.Name = "colID_Maitre_Apprentissage";
            // 
            // colNom_Maitre_Apprentissage
            // 
            this.colNom_Maitre_Apprentissage.FieldName = "Nom_Maitre_Apprentissage";
            this.colNom_Maitre_Apprentissage.Name = "colNom_Maitre_Apprentissage";
            this.colNom_Maitre_Apprentissage.Visible = true;
            this.colNom_Maitre_Apprentissage.VisibleIndex = 0;
            // 
            // colPrenom_Maitre_Apprentissage
            // 
            this.colPrenom_Maitre_Apprentissage.FieldName = "Prenom_Maitre_Apprentissage";
            this.colPrenom_Maitre_Apprentissage.Name = "colPrenom_Maitre_Apprentissage";
            this.colPrenom_Maitre_Apprentissage.Visible = true;
            this.colPrenom_Maitre_Apprentissage.VisibleIndex = 1;
            // 
            // colQualification_Maitre_Apprentissage
            // 
            this.colQualification_Maitre_Apprentissage.FieldName = "Qualification_Maitre_Apprentissage";
            this.colQualification_Maitre_Apprentissage.Name = "colQualification_Maitre_Apprentissage";
            this.colQualification_Maitre_Apprentissage.Visible = true;
            this.colQualification_Maitre_Apprentissage.VisibleIndex = 4;
            // 
            // colProfil_Maitre_Apprentissage
            // 
            this.colProfil_Maitre_Apprentissage.FieldName = "Profil_Maitre_Apprentissage";
            this.colProfil_Maitre_Apprentissage.Name = "colProfil_Maitre_Apprentissage";
            this.colProfil_Maitre_Apprentissage.Visible = true;
            this.colProfil_Maitre_Apprentissage.VisibleIndex = 6;
            // 
            // colTel_Maitre_Apprentissage
            // 
            this.colTel_Maitre_Apprentissage.FieldName = "Tel_Maitre_Apprentissage";
            this.colTel_Maitre_Apprentissage.Name = "colTel_Maitre_Apprentissage";
            this.colTel_Maitre_Apprentissage.Visible = true;
            this.colTel_Maitre_Apprentissage.VisibleIndex = 2;
            // 
            // colPoste_Maitre_Apprentissage
            // 
            this.colPoste_Maitre_Apprentissage.FieldName = "Poste_Maitre_Apprentissage";
            this.colPoste_Maitre_Apprentissage.Name = "colPoste_Maitre_Apprentissage";
            this.colPoste_Maitre_Apprentissage.Visible = true;
            this.colPoste_Maitre_Apprentissage.VisibleIndex = 7;
            // 
            // colE_Mail_Maitre_Apprentissage
            // 
            this.colE_Mail_Maitre_Apprentissage.FieldName = "E_Mail_Maitre_Apprentissage";
            this.colE_Mail_Maitre_Apprentissage.Name = "colE_Mail_Maitre_Apprentissage";
            this.colE_Mail_Maitre_Apprentissage.Visible = true;
            this.colE_Mail_Maitre_Apprentissage.VisibleIndex = 3;
            // 
            // colEmployeur
            // 
            this.colEmployeur.FieldName = "Employeur.Nom_Emp";
            this.colEmployeur.Name = "colEmployeur";
            this.colEmployeur.Visible = true;
            this.colEmployeur.VisibleIndex = 8;
            // 
            // colAdresse_Maitre_Apprentissage
            // 
            this.colAdresse_Maitre_Apprentissage.FieldName = "Adresse_Maitre_Apprentissage";
            this.colAdresse_Maitre_Apprentissage.Name = "colAdresse_Maitre_Apprentissage";
            // 
            // colAnciennté_Entriprise_Maitre_Apprentissage
            // 
            this.colAnciennté_Entriprise_Maitre_Apprentissage.FieldName = "Anciennté_Entriprise_Maitre_Apprentissage";
            this.colAnciennté_Entriprise_Maitre_Apprentissage.Name = "colAnciennté_Entriprise_Maitre_Apprentissage";
            this.colAnciennté_Entriprise_Maitre_Apprentissage.Visible = true;
            this.colAnciennté_Entriprise_Maitre_Apprentissage.VisibleIndex = 9;
            // 
            // colAnciennté_Métier_Maitre_Apprentissage
            // 
            this.colAnciennté_Métier_Maitre_Apprentissage.FieldName = "Anciennté_Métier_Maitre_Apprentissage";
            this.colAnciennté_Métier_Maitre_Apprentissage.Name = "colAnciennté_Métier_Maitre_Apprentissage";
            this.colAnciennté_Métier_Maitre_Apprentissage.Visible = true;
            this.colAnciennté_Métier_Maitre_Apprentissage.VisibleIndex = 10;
            // 
            // colAyant_Suivie_Stage
            // 
            this.colAyant_Suivie_Stage.FieldName = "Ayant_Suivie_Stage";
            this.colAyant_Suivie_Stage.Name = "colAyant_Suivie_Stage";
            this.colAyant_Suivie_Stage.Visible = true;
            this.colAyant_Suivie_Stage.VisibleIndex = 5;
            // 
            // colCommune
            // 
            this.colCommune.FieldName = "Commune";
            this.colCommune.Name = "colCommune";
            // 
            // colCommune_Maitre_Apprentissage
            // 
            this.colCommune_Maitre_Apprentissage.FieldName = "Commune_Maitre_Apprentissage";
            this.colCommune_Maitre_Apprentissage.Name = "colCommune_Maitre_Apprentissage";
            // 
            // colNbr_Stagiaire_Former
            // 
            this.colNbr_Stagiaire_Former.FieldName = "Nbr_Stagiaire_Former";
            this.colNbr_Stagiaire_Former.Name = "colNbr_Stagiaire_Former";
            this.colNbr_Stagiaire_Former.Visible = true;
            this.colNbr_Stagiaire_Former.VisibleIndex = 11;
            // 
            // colID_Emp
            // 
            this.colID_Emp.FieldName = "ID_Emp";
            this.colID_Emp.Name = "colID_Emp";
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
            this.bbiEdit.Caption = "Modifer";
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
            this.ribbonPageGroup1.Text = "Gestion du Maitre Apprentissage";
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
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.Maitre_ApprentissageCollectionViewModel);
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
            // Maitre_ApprentissageCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 736);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Maitre_ApprentissageCollectionView";
            this.Text = "Maitre apprentissage";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maitre_ApprentissageCollectionViewBindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource maitre_ApprentissageCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenom_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colQualification_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colProfil_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colTel_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colPoste_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colE_Mail_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeur;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colAnciennté_Entriprise_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colAnciennté_Métier_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colAyant_Suivie_Stage;
        private DevExpress.XtraGrid.Columns.GridColumn colCommune;
        private DevExpress.XtraGrid.Columns.GridColumn colCommune_Maitre_Apprentissage;
        private DevExpress.XtraGrid.Columns.GridColumn colNbr_Stagiaire_Former;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Emp;
    }
}
