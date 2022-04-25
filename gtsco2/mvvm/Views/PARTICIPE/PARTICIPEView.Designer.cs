namespace gtsco2.mvvm.Views.PARTICIPEView {
    partial class PARTICIPEView {
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
            this.EnseignantLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.pARTICIPEViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EnseignantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EnseignantLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_Enseignant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenom_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNiveau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoste_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecialite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMode_Formation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Proce_verbal_delibationLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.Proce_verbal_delibationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Proce_verbal_delibationLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_PV_Délibiration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_PV_Délibiraiton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_PV_Délibiration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QualiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Qualite_arTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid_Enseignant = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForID_PV_Délibiration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQualite = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQualite_ar = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proce_verbal_delibationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proce_verbal_delibationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proce_verbal_delibationLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qualite_arTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_Enseignant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_PV_Délibiration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQualite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQualite_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.EnseignantLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.Proce_verbal_delibationLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.QualiteTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Qualite_arTextEdit);
            this.dataLayoutControl1.DataSource = this.pARTICIPEViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 126);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(725, 113);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // EnseignantLookUpEdit
            // 
            this.EnseignantLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pARTICIPEViewBindingSource, "id_Enseignant", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EnseignantLookUpEdit.EditValue = "";
            this.EnseignantLookUpEdit.Location = new System.Drawing.Point(169, 12);
            this.EnseignantLookUpEdit.Name = "EnseignantLookUpEdit";
            this.EnseignantLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EnseignantLookUpEdit.Properties.DataSource = this.EnseignantBindingSource;
            this.EnseignantLookUpEdit.Properties.DisplayMember = "Nom";
            this.EnseignantLookUpEdit.Properties.NullText = "";
            this.EnseignantLookUpEdit.Properties.NullValuePrompt = "Saisir ou sélectionner l\'enseignant ";
            this.EnseignantLookUpEdit.Properties.PopupView = this.EnseignantLookUpEditView;
            this.EnseignantLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.EnseignantLookUpEdit.Properties.ValueMember = "id_Enseignant";
            this.EnseignantLookUpEdit.Size = new System.Drawing.Size(544, 20);
            this.EnseignantLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EnseignantLookUpEdit.TabIndex = 4;
            // 
            // pARTICIPEViewBindingSource
            // 
            this.pARTICIPEViewBindingSource.DataSource = typeof(gtsco2.basededonne.PARTICIPE);
            // 
            // EnseignantBindingSource
            // 
            this.EnseignantBindingSource.DataSource = typeof(gtsco2.basededonne.Enseignant);
            // 
            // EnseignantLookUpEditView
            // 
            this.EnseignantLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_Enseignant,
            this.colNom,
            this.colNom_ar,
            this.colprenom,
            this.colPrenom_ar,
            this.colNiveau,
            this.colPoste,
            this.colPoste_ar,
            this.colSpecialite,
            this.colMode_Formation});
            this.EnseignantLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.EnseignantLookUpEditView.Name = "EnseignantLookUpEditView";
            this.EnseignantLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.EnseignantLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colid_Enseignant
            // 
            this.colid_Enseignant.FieldName = "id_Enseignant";
            this.colid_Enseignant.Name = "colid_Enseignant";
            // 
            // colNom
            // 
            this.colNom.FieldName = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 0;
            // 
            // colNom_ar
            // 
            this.colNom_ar.FieldName = "Nom_ar";
            this.colNom_ar.Name = "colNom_ar";
            // 
            // colprenom
            // 
            this.colprenom.FieldName = "prenom";
            this.colprenom.Name = "colprenom";
            this.colprenom.Visible = true;
            this.colprenom.VisibleIndex = 1;
            // 
            // colPrenom_ar
            // 
            this.colPrenom_ar.FieldName = "Prenom_ar";
            this.colPrenom_ar.Name = "colPrenom_ar";
            // 
            // colNiveau
            // 
            this.colNiveau.FieldName = "Niveau";
            this.colNiveau.Name = "colNiveau";
            this.colNiveau.Visible = true;
            this.colNiveau.VisibleIndex = 2;
            // 
            // colPoste
            // 
            this.colPoste.FieldName = "Poste";
            this.colPoste.Name = "colPoste";
            this.colPoste.Visible = true;
            this.colPoste.VisibleIndex = 3;
            // 
            // colPoste_ar
            // 
            this.colPoste_ar.FieldName = "Poste_ar";
            this.colPoste_ar.Name = "colPoste_ar";
            // 
            // colSpecialite
            // 
            this.colSpecialite.FieldName = "Specialite";
            this.colSpecialite.Name = "colSpecialite";
            this.colSpecialite.Visible = true;
            this.colSpecialite.VisibleIndex = 4;
            // 
            // colMode_Formation
            // 
            this.colMode_Formation.FieldName = "Mode_Formation";
            this.colMode_Formation.Name = "colMode_Formation";
            this.colMode_Formation.Visible = true;
            this.colMode_Formation.VisibleIndex = 5;
            // 
            // Proce_verbal_delibationLookUpEdit
            // 
            this.Proce_verbal_delibationLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pARTICIPEViewBindingSource, "ID_PV_Délibiration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Proce_verbal_delibationLookUpEdit.EditValue = "";
            this.Proce_verbal_delibationLookUpEdit.Location = new System.Drawing.Point(169, 36);
            this.Proce_verbal_delibationLookUpEdit.Name = "Proce_verbal_delibationLookUpEdit";
            this.Proce_verbal_delibationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Proce_verbal_delibationLookUpEdit.Properties.DataSource = this.Proce_verbal_delibationBindingSource;
            this.Proce_verbal_delibationLookUpEdit.Properties.DisplayMember = "ID_PV_Délibiration";
            this.Proce_verbal_delibationLookUpEdit.Properties.NullText = "";
            this.Proce_verbal_delibationLookUpEdit.Properties.NullValuePrompt = "Saisir ou sélectionner le numéro de PV de délibération";
            this.Proce_verbal_delibationLookUpEdit.Properties.PopupView = this.Proce_verbal_delibationLookUpEditView;
            this.Proce_verbal_delibationLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Proce_verbal_delibationLookUpEdit.Properties.ValueMember = "ID_PV_Délibiration";
            this.Proce_verbal_delibationLookUpEdit.Size = new System.Drawing.Size(544, 20);
            this.Proce_verbal_delibationLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Proce_verbal_delibationLookUpEdit.TabIndex = 5;
            // 
            // Proce_verbal_delibationBindingSource
            // 
            this.Proce_verbal_delibationBindingSource.DataSource = typeof(gtsco2.basededonne.Proce_verbal_delibation);
            // 
            // Proce_verbal_delibationLookUpEditView
            // 
            this.Proce_verbal_delibationLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_PV_Délibiration,
            this.colNum_PV_Délibiraiton,
            this.colDate_PV_Délibiration});
            this.Proce_verbal_delibationLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.Proce_verbal_delibationLookUpEditView.Name = "Proce_verbal_delibationLookUpEditView";
            this.Proce_verbal_delibationLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.Proce_verbal_delibationLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colID_PV_Délibiration
            // 
            this.colID_PV_Délibiration.FieldName = "ID_PV_Délibiration";
            this.colID_PV_Délibiration.Name = "colID_PV_Délibiration";
            // 
            // colNum_PV_Délibiraiton
            // 
            this.colNum_PV_Délibiraiton.FieldName = "Num_PV_Délibiraiton";
            this.colNum_PV_Délibiraiton.Name = "colNum_PV_Délibiraiton";
            this.colNum_PV_Délibiraiton.Visible = true;
            this.colNum_PV_Délibiraiton.VisibleIndex = 0;
            // 
            // colDate_PV_Délibiration
            // 
            this.colDate_PV_Délibiration.FieldName = "Date_PV_Délibiration";
            this.colDate_PV_Délibiration.Name = "colDate_PV_Délibiration";
            this.colDate_PV_Délibiration.Visible = true;
            this.colDate_PV_Délibiration.VisibleIndex = 1;
            // 
            // QualiteTextEdit
            // 
            this.QualiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pARTICIPEViewBindingSource, "Qualite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QualiteTextEdit.Location = new System.Drawing.Point(169, 60);
            this.QualiteTextEdit.Name = "QualiteTextEdit";
            this.QualiteTextEdit.Size = new System.Drawing.Size(239, 20);
            this.QualiteTextEdit.StyleController = this.dataLayoutControl1;
            this.QualiteTextEdit.TabIndex = 6;
            // 
            // Qualite_arTextEdit
            // 
            this.Qualite_arTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pARTICIPEViewBindingSource, "Qualite_ar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Qualite_arTextEdit.Location = new System.Drawing.Point(412, 60);
            this.Qualite_arTextEdit.Name = "Qualite_arTextEdit";
            this.Qualite_arTextEdit.Size = new System.Drawing.Size(240, 20);
            this.Qualite_arTextEdit.StyleController = this.dataLayoutControl1;
            this.Qualite_arTextEdit.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(725, 113);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_Enseignant,
            this.ItemForID_PV_Délibiration,
            this.ItemForQualite,
            this.ItemForQualite_ar});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(705, 93);
            // 
            // ItemForid_Enseignant
            // 
            this.ItemForid_Enseignant.Control = this.EnseignantLookUpEdit;
            this.ItemForid_Enseignant.Location = new System.Drawing.Point(0, 0);
            this.ItemForid_Enseignant.Name = "ItemForid_Enseignant";
            this.ItemForid_Enseignant.Size = new System.Drawing.Size(705, 24);
            this.ItemForid_Enseignant.Text = "Numéro d\'enseignant";
            this.ItemForid_Enseignant.TextSize = new System.Drawing.Size(145, 13);
            // 
            // ItemForID_PV_Délibiration
            // 
            this.ItemForID_PV_Délibiration.Control = this.Proce_verbal_delibationLookUpEdit;
            this.ItemForID_PV_Délibiration.Location = new System.Drawing.Point(0, 24);
            this.ItemForID_PV_Délibiration.Name = "ItemForID_PV_Délibiration";
            this.ItemForID_PV_Délibiration.Size = new System.Drawing.Size(705, 24);
            this.ItemForID_PV_Délibiration.Text = "Numéro du P.V de délibération";
            this.ItemForID_PV_Délibiration.TextSize = new System.Drawing.Size(145, 13);
            // 
            // ItemForQualite
            // 
            this.ItemForQualite.Control = this.QualiteTextEdit;
            this.ItemForQualite.Location = new System.Drawing.Point(0, 48);
            this.ItemForQualite.Name = "ItemForQualite";
            this.ItemForQualite.Size = new System.Drawing.Size(400, 45);
            this.ItemForQualite.Text = "Qualité de l\'enseignant";
            this.ItemForQualite.TextSize = new System.Drawing.Size(145, 13);
            // 
            // ItemForQualite_ar
            // 
            this.ItemForQualite_ar.Control = this.Qualite_arTextEdit;
            this.ItemForQualite_ar.Location = new System.Drawing.Point(400, 48);
            this.ItemForQualite_ar.Name = "ItemForQualite_ar";
            this.ItemForQualite_ar.Size = new System.Drawing.Size(305, 45);
            this.ItemForQualite_ar.Text = "ميزة الأستاذ";
            this.ItemForQualite_ar.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForQualite_ar.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForQualite_ar.TextSize = new System.Drawing.Size(56, 13);
            this.ItemForQualite_ar.TextToControlDistance = 5;
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "Close", this.bbiClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel), "ResetLayout", this.bbiResetLayout)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.ViewModels.PARTICIPEViewModel);
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
            this.bbiSaveAndClose.Caption = "Enregistrer et Fermer";
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
            this.bbiDelete.Caption = "Supprimer";
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
            this.mainRibbonControl.SearchEditItem,
            this.bbiCustomize,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.bbiSaveLayout,
            this.bbiResetLayout});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(725, 126);
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
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Fichier";
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
            this.mainRibbonPageGroup.Text = "Gestion des participants à la délibération";
            // 
            // ribbonPageGroupLayout
            // 
            this.ribbonPageGroupLayout.AllowTextClipping = false;
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Personnalisation de la fenêtre";
            // 
            // PARTICIPEView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "PARTICIPEView";
            this.Size = new System.Drawing.Size(725, 239);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proce_verbal_delibationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proce_verbal_delibationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proce_verbal_delibationLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qualite_arTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_Enseignant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_PV_Délibiration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQualite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQualite_ar)).EndInit();
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
		private System.Windows.Forms.BindingSource pARTICIPEViewBindingSource;
						private DevExpress.XtraEditors.GridLookUpEdit EnseignantLookUpEdit;
		private System.Windows.Forms.BindingSource EnseignantBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit Proce_verbal_delibationLookUpEdit;
		private System.Windows.Forms.BindingSource Proce_verbal_delibationBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView EnseignantLookUpEditView;
        private DevExpress.XtraGrid.Views.Grid.GridView Proce_verbal_delibationLookUpEditView;
        private DevExpress.XtraEditors.TextEdit QualiteTextEdit;
        private DevExpress.XtraEditors.TextEdit Qualite_arTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_Enseignant;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_PV_Délibiration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQualite;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQualite_ar;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Enseignant;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenom_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colNiveau;
        private DevExpress.XtraGrid.Columns.GridColumn colPoste;
        private DevExpress.XtraGrid.Columns.GridColumn colPoste_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecialite;
        private DevExpress.XtraGrid.Columns.GridColumn colMode_Formation;
        private DevExpress.XtraGrid.Columns.GridColumn colID_PV_Délibiration;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_PV_Délibiraiton;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_PV_Délibiration;
    }
}
