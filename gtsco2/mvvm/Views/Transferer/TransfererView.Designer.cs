namespace gtsco2.mvvm.Views.TransfererView {
    partial class TransfererView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransfererView));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.transfererViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EtablissementLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.EtablissementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StagiairLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.StagiairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.EtablissementLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForID_etb = new DevExpress.XtraLayout.LayoutControlItem();
            this.StagiairLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemFornum_stg = new DevExpress.XtraLayout.LayoutControlItem();
            this.nom_directeurTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemFornom_directeur = new DevExpress.XtraLayout.LayoutControlItem();
            this.prenom_directeurTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForprenom_directeur = new DevExpress.XtraLayout.LayoutControlItem();
            this.date_transfertDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemFordate_transfert = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfererViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtablissementLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtablissementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StagiairLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StagiairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtablissementLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_etb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StagiairLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornum_stg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_directeurTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom_directeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenom_directeurTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForprenom_directeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_transfertDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_transfertDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_transfert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.EtablissementLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.StagiairLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.nom_directeurTextEdit);
            this.dataLayoutControl1.Controls.Add(this.prenom_directeurTextEdit);
            this.dataLayoutControl1.Controls.Add(this.date_transfertDateEdit);
            this.dataLayoutControl1.DataSource = this.transfererViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 129);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1024, 639);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1024, 639);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // transfererViewBindingSource
            // 
            this.transfererViewBindingSource.DataSource = typeof(gtsco2.basededonne.Transferer);
            // 
            // EtablissementLookUpEdit
            // 
            this.EtablissementLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transfererViewBindingSource, "ID_etb", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EtablissementLookUpEdit.EditValue = "";
            this.EtablissementLookUpEdit.Location = new System.Drawing.Point(141, 12);
            this.EtablissementLookUpEdit.Name = "EtablissementLookUpEdit";
            this.EtablissementLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EtablissementLookUpEdit.Properties.DataSource = this.EtablissementBindingSource;
            this.EtablissementLookUpEdit.Properties.DisplayMember = "Nom_ETAB";
            this.EtablissementLookUpEdit.Properties.PopupView = this.EtablissementLookUpEditView;
            this.EtablissementLookUpEdit.Properties.ValueMember = "ID_ETAB";
            this.EtablissementLookUpEdit.Size = new System.Drawing.Size(871, 20);
            this.EtablissementLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EtablissementLookUpEdit.TabIndex = 4;
            // 
            // EtablissementBindingSource
            // 
            this.EtablissementBindingSource.DataSource = typeof(gtsco2.basededonne.Etablissement);
            // 
            // StagiairLookUpEdit
            // 
            this.StagiairLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transfererViewBindingSource, "num_stg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StagiairLookUpEdit.EditValue = "";
            this.StagiairLookUpEdit.Location = new System.Drawing.Point(141, 36);
            this.StagiairLookUpEdit.Name = "StagiairLookUpEdit";
            this.StagiairLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StagiairLookUpEdit.Properties.DataSource = this.StagiairBindingSource;
            this.StagiairLookUpEdit.Properties.DisplayMember = "Num_STG";
            this.StagiairLookUpEdit.Properties.PopupView = this.StagiairLookUpEditView;
            this.StagiairLookUpEdit.Properties.ValueMember = "Num_STG";
            this.StagiairLookUpEdit.Size = new System.Drawing.Size(871, 20);
            this.StagiairLookUpEdit.StyleController = this.dataLayoutControl1;
            this.StagiairLookUpEdit.TabIndex = 5;
            // 
            // StagiairBindingSource
            // 
            this.StagiairBindingSource.DataSource = typeof(gtsco2.basededonne.Stagiair);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID_etb,
            this.ItemFornum_stg,
            this.ItemFornom_directeur,
            this.ItemForprenom_directeur,
            this.ItemFordate_transfert});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1004, 619);
            // 
            // EtablissementLookUpEditView
            // 
            this.EtablissementLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.EtablissementLookUpEditView.Name = "EtablissementLookUpEditView";
            this.EtablissementLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.EtablissementLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForID_etb
            // 
            this.ItemForID_etb.Control = this.EtablissementLookUpEdit;
            this.ItemForID_etb.Location = new System.Drawing.Point(0, 0);
            this.ItemForID_etb.Name = "ItemForID_etb";
            this.ItemForID_etb.Size = new System.Drawing.Size(1004, 24);
            this.ItemForID_etb.Text = "Numéro d\'établissement ";
            this.ItemForID_etb.TextSize = new System.Drawing.Size(117, 13);
            // 
            // StagiairLookUpEditView
            // 
            this.StagiairLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.StagiairLookUpEditView.Name = "StagiairLookUpEditView";
            this.StagiairLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.StagiairLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ItemFornum_stg
            // 
            this.ItemFornum_stg.Control = this.StagiairLookUpEdit;
            this.ItemFornum_stg.Location = new System.Drawing.Point(0, 24);
            this.ItemFornum_stg.Name = "ItemFornum_stg";
            this.ItemFornum_stg.Size = new System.Drawing.Size(1004, 24);
            this.ItemFornum_stg.Text = "Numero du stagiaire";
            this.ItemFornum_stg.TextSize = new System.Drawing.Size(117, 13);
            // 
            // nom_directeurTextEdit
            // 
            this.nom_directeurTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transfererViewBindingSource, "nom_directeur", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nom_directeurTextEdit.Location = new System.Drawing.Point(141, 60);
            this.nom_directeurTextEdit.Name = "nom_directeurTextEdit";
            this.nom_directeurTextEdit.Size = new System.Drawing.Size(871, 20);
            this.nom_directeurTextEdit.StyleController = this.dataLayoutControl1;
            this.nom_directeurTextEdit.TabIndex = 6;
            // 
            // ItemFornom_directeur
            // 
            this.ItemFornom_directeur.Control = this.nom_directeurTextEdit;
            this.ItemFornom_directeur.Location = new System.Drawing.Point(0, 48);
            this.ItemFornom_directeur.Name = "ItemFornom_directeur";
            this.ItemFornom_directeur.Size = new System.Drawing.Size(1004, 24);
            this.ItemFornom_directeur.Text = "Nom du directeur";
            this.ItemFornom_directeur.TextSize = new System.Drawing.Size(117, 13);
            // 
            // prenom_directeurTextEdit
            // 
            this.prenom_directeurTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transfererViewBindingSource, "prenom_directeur", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.prenom_directeurTextEdit.Location = new System.Drawing.Point(141, 84);
            this.prenom_directeurTextEdit.Name = "prenom_directeurTextEdit";
            this.prenom_directeurTextEdit.Size = new System.Drawing.Size(871, 20);
            this.prenom_directeurTextEdit.StyleController = this.dataLayoutControl1;
            this.prenom_directeurTextEdit.TabIndex = 7;
            // 
            // ItemForprenom_directeur
            // 
            this.ItemForprenom_directeur.Control = this.prenom_directeurTextEdit;
            this.ItemForprenom_directeur.Location = new System.Drawing.Point(0, 72);
            this.ItemForprenom_directeur.Name = "ItemForprenom_directeur";
            this.ItemForprenom_directeur.Size = new System.Drawing.Size(1004, 24);
            this.ItemForprenom_directeur.Text = "Prénom du directeur";
            this.ItemForprenom_directeur.TextSize = new System.Drawing.Size(117, 13);
            // 
            // date_transfertDateEdit
            // 
            this.date_transfertDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transfererViewBindingSource, "date_transfert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.date_transfertDateEdit.EditValue = null;
            this.date_transfertDateEdit.Location = new System.Drawing.Point(141, 108);
            this.date_transfertDateEdit.Name = "date_transfertDateEdit";
            this.date_transfertDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.date_transfertDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_transfertDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_transfertDateEdit.Size = new System.Drawing.Size(871, 20);
            this.date_transfertDateEdit.StyleController = this.dataLayoutControl1;
            this.date_transfertDateEdit.TabIndex = 8;
            // 
            // ItemFordate_transfert
            // 
            this.ItemFordate_transfert.Control = this.date_transfertDateEdit;
            this.ItemFordate_transfert.Location = new System.Drawing.Point(0, 96);
            this.ItemFordate_transfert.Name = "ItemFordate_transfert";
            this.ItemFordate_transfert.Size = new System.Drawing.Size(1004, 523);
            this.ItemFordate_transfert.Text = "Date du transfert";
            this.ItemFordate_transfert.TextSize = new System.Drawing.Size(117, 13);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "Close", this.bbiClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.TransfererViewModel), "ResetLayout", this.bbiResetLayout)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.TransfererViewModel);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Enregistrer ";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Enregistrer et fermer";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Enregistrer et Ajouter";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Annuler les changements";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Supprimer ";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Fermer";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Enregistrer la personnalisation";
            this.bbiSaveLayout.Id = 8;
            this.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiResetLayout
            // 
            this.bbiResetLayout.Caption = "Annuler la personnalisation";
            this.bbiResetLayout.Id = 9;
            this.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiResetLayout.Name = "bbiResetLayout";
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiCustomize,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.bbiSaveLayout,
            this.bbiResetLayout,
            this.mainRibbonControl.SearchEditItem});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1024, 129);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Personnaliser la fenêtre";
            this.bbiCustomize.Id = 1;
            this.bbiCustomize.ImageOptions.ImageUri.Uri = "Customization";
            this.bbiCustomize.Name = "bbiCustomize";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroupLayout});
            this.mainRibbonPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mainRibbonPage.ImageOptions.Image")));
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ACCEUIL";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Transferer Tasks";
            // 
            // ribbonPageGroupLayout
            // 
            this.ribbonPageGroupLayout.AllowTextClipping = false;
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Personnaliser la fenêtre";
            // 
            // TransfererView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "TransfererView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfererViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtablissementLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtablissementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StagiairLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StagiairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtablissementLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_etb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StagiairLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornum_stg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_directeurTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom_directeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenom_directeurTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForprenom_directeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_transfertDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_transfertDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_transfert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
		private System.Windows.Forms.BindingSource transfererViewBindingSource;
						private DevExpress.XtraEditors.GridLookUpEdit EtablissementLookUpEdit;
		private System.Windows.Forms.BindingSource EtablissementBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit StagiairLookUpEdit;
		private System.Windows.Forms.BindingSource StagiairBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView EtablissementLookUpEditView;
        private DevExpress.XtraGrid.Views.Grid.GridView StagiairLookUpEditView;
        private DevExpress.XtraEditors.TextEdit nom_directeurTextEdit;
        private DevExpress.XtraEditors.TextEdit prenom_directeurTextEdit;
        private DevExpress.XtraEditors.DateEdit date_transfertDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_etb;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornum_stg;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornom_directeur;
        private DevExpress.XtraLayout.LayoutControlItem ItemForprenom_directeur;
        private DevExpress.XtraLayout.LayoutControlItem ItemFordate_transfert;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
    }
}
