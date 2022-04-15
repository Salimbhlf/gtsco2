namespace gtsco2.mvvm.user.Views.UserView {
    partial class UserView {
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
            this.ID_userTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PrenomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NomeutlisatureTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MotedePasseTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RoleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhotoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID_user = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrenom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNomeutlisature = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMotedePasse = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRole = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhoto = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.ID_userTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrenomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeutlisatureTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotedePasseTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNomeutlisature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotedePasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.ID_userTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PrenomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NomeutlisatureTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MotedePasseTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RoleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhotoPictureEdit);
            this.dataLayoutControl1.DataSource = this.userViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 126);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(732, 318);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // ID_userTextEdit
            // 
            this.ID_userTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userViewBindingSource, "ID_user", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ID_userTextEdit.Location = new System.Drawing.Point(122, 12);
            this.ID_userTextEdit.Name = "ID_userTextEdit";
            this.ID_userTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ID_userTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ID_userTextEdit.Properties.Mask.EditMask = "N0";
            this.ID_userTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ID_userTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ID_userTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_userTextEdit.Size = new System.Drawing.Size(598, 20);
            this.ID_userTextEdit.StyleController = this.dataLayoutControl1;
            this.ID_userTextEdit.TabIndex = 4;
            // 
            // userViewBindingSource
            // 
            this.userViewBindingSource.DataSource = typeof(gtsco2.basededonne.User);
            // 
            // NomTextEdit
            // 
            this.NomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userViewBindingSource, "Nom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NomTextEdit.Location = new System.Drawing.Point(122, 36);
            this.NomTextEdit.Name = "NomTextEdit";
            this.NomTextEdit.Size = new System.Drawing.Size(598, 20);
            this.NomTextEdit.StyleController = this.dataLayoutControl1;
            this.NomTextEdit.TabIndex = 5;
            // 
            // PrenomTextEdit
            // 
            this.PrenomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userViewBindingSource, "Prenom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PrenomTextEdit.Location = new System.Drawing.Point(122, 60);
            this.PrenomTextEdit.Name = "PrenomTextEdit";
            this.PrenomTextEdit.Size = new System.Drawing.Size(598, 20);
            this.PrenomTextEdit.StyleController = this.dataLayoutControl1;
            this.PrenomTextEdit.TabIndex = 6;
            // 
            // NomeutlisatureTextEdit
            // 
            this.NomeutlisatureTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userViewBindingSource, "Nomeutlisature", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NomeutlisatureTextEdit.Location = new System.Drawing.Point(122, 84);
            this.NomeutlisatureTextEdit.Name = "NomeutlisatureTextEdit";
            this.NomeutlisatureTextEdit.Size = new System.Drawing.Size(598, 20);
            this.NomeutlisatureTextEdit.StyleController = this.dataLayoutControl1;
            this.NomeutlisatureTextEdit.TabIndex = 7;
            // 
            // MotedePasseTextEdit
            // 
            this.MotedePasseTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userViewBindingSource, "MotedePasse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MotedePasseTextEdit.Location = new System.Drawing.Point(122, 108);
            this.MotedePasseTextEdit.Name = "MotedePasseTextEdit";
            this.MotedePasseTextEdit.Size = new System.Drawing.Size(598, 20);
            this.MotedePasseTextEdit.StyleController = this.dataLayoutControl1;
            this.MotedePasseTextEdit.TabIndex = 8;
            // 
            // RoleTextEdit
            // 
            this.RoleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userViewBindingSource, "Role", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoleTextEdit.Location = new System.Drawing.Point(122, 132);
            this.RoleTextEdit.Name = "RoleTextEdit";
            this.RoleTextEdit.Size = new System.Drawing.Size(598, 20);
            this.RoleTextEdit.StyleController = this.dataLayoutControl1;
            this.RoleTextEdit.TabIndex = 9;
            // 
            // PhotoPictureEdit
            // 
            this.PhotoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userViewBindingSource, "Photo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PhotoPictureEdit.Location = new System.Drawing.Point(122, 156);
            this.PhotoPictureEdit.Name = "PhotoPictureEdit";
            this.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PhotoPictureEdit.Size = new System.Drawing.Size(598, 150);
            this.PhotoPictureEdit.StyleController = this.dataLayoutControl1;
            this.PhotoPictureEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(732, 318);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID_user,
            this.ItemForNom,
            this.ItemForPrenom,
            this.ItemForNomeutlisature,
            this.ItemForMotedePasse,
            this.ItemForRole,
            this.ItemForPhoto});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(712, 298);
            // 
            // ItemForID_user
            // 
            this.ItemForID_user.Control = this.ID_userTextEdit;
            this.ItemForID_user.Location = new System.Drawing.Point(0, 0);
            this.ItemForID_user.Name = "ItemForID_user";
            this.ItemForID_user.Size = new System.Drawing.Size(712, 24);
            this.ItemForID_user.Text = "Numéro d\'utilisateur ";
            this.ItemForID_user.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForNom
            // 
            this.ItemForNom.Control = this.NomTextEdit;
            this.ItemForNom.Location = new System.Drawing.Point(0, 24);
            this.ItemForNom.Name = "ItemForNom";
            this.ItemForNom.Size = new System.Drawing.Size(712, 24);
            this.ItemForNom.Text = "Nom ";
            this.ItemForNom.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForPrenom
            // 
            this.ItemForPrenom.Control = this.PrenomTextEdit;
            this.ItemForPrenom.Location = new System.Drawing.Point(0, 48);
            this.ItemForPrenom.Name = "ItemForPrenom";
            this.ItemForPrenom.Size = new System.Drawing.Size(712, 24);
            this.ItemForPrenom.Text = "Prénom";
            this.ItemForPrenom.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForNomeutlisature
            // 
            this.ItemForNomeutlisature.Control = this.NomeutlisatureTextEdit;
            this.ItemForNomeutlisature.Location = new System.Drawing.Point(0, 72);
            this.ItemForNomeutlisature.Name = "ItemForNomeutlisature";
            this.ItemForNomeutlisature.Size = new System.Drawing.Size(712, 24);
            this.ItemForNomeutlisature.Text = "Nom d\'utilisateur ";
            this.ItemForNomeutlisature.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForMotedePasse
            // 
            this.ItemForMotedePasse.Control = this.MotedePasseTextEdit;
            this.ItemForMotedePasse.Location = new System.Drawing.Point(0, 96);
            this.ItemForMotedePasse.Name = "ItemForMotedePasse";
            this.ItemForMotedePasse.Size = new System.Drawing.Size(712, 24);
            this.ItemForMotedePasse.Text = "Mot de Passe";
            this.ItemForMotedePasse.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForRole
            // 
            this.ItemForRole.Control = this.RoleTextEdit;
            this.ItemForRole.Location = new System.Drawing.Point(0, 120);
            this.ItemForRole.Name = "ItemForRole";
            this.ItemForRole.Size = new System.Drawing.Size(712, 24);
            this.ItemForRole.Text = "Rôle";
            this.ItemForRole.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForPhoto
            // 
            this.ItemForPhoto.Control = this.PhotoPictureEdit;
            this.ItemForPhoto.Location = new System.Drawing.Point(0, 144);
            this.ItemForPhoto.Name = "ItemForPhoto";
            this.ItemForPhoto.Size = new System.Drawing.Size(712, 154);
            this.ItemForPhoto.StartNewLine = true;
            this.ItemForPhoto.Text = "Photo";
            this.ItemForPhoto.TextSize = new System.Drawing.Size(98, 13);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "Close", this.bbiClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtsco2.mvvm.user.ViewModels.UserViewModel), "ResetLayout", this.bbiResetLayout)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
            this.mvvmContext.ViewModelType = typeof(gtsco2.mvvm.user.ViewModels.UserViewModel);
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
            this.bbiSaveAndClose.Caption = "Enregistrer et fermer ";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Enregistrer et crée";
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
            this.bbiClose.Caption = "Fermer ";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Enregistrer la personnalisation ";
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
            this.mainRibbonControl.Size = new System.Drawing.Size(732, 126);
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
            this.mainRibbonPage.Text = "Home";
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
            this.mainRibbonPageGroup.Text = "Option";
            // 
            // ribbonPageGroupLayout
            // 
            this.ribbonPageGroupLayout.AllowTextClipping = false;
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Personnalisation la fenêtre";
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(732, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ID_userTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrenomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeutlisatureTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotedePasseTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNomeutlisature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotedePasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoto)).EndInit();
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
		private System.Windows.Forms.BindingSource userViewBindingSource;
        private DevExpress.XtraEditors.TextEdit ID_userTextEdit;
        private DevExpress.XtraEditors.TextEdit NomTextEdit;
        private DevExpress.XtraEditors.TextEdit PrenomTextEdit;
        private DevExpress.XtraEditors.TextEdit NomeutlisatureTextEdit;
        private DevExpress.XtraEditors.TextEdit MotedePasseTextEdit;
        private DevExpress.XtraEditors.TextEdit RoleTextEdit;
        private DevExpress.XtraEditors.PictureEdit PhotoPictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_user;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrenom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNomeutlisature;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMotedePasse;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRole;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoto;
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
