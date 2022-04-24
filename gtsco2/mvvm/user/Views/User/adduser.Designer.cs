﻿
namespace gtsco2.mvvm.user.Views.User
{
    partial class adduser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.NomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PrenomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NomeutlisatureTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MotedePasseTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Root1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.autoGeneratedGroup0 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrenom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNomeutlisature = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMotedePasse = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrenomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeutlisatureTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotedePasseTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoGeneratedGroup0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNomeutlisature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotedePasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            this.SuspendLayout();
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
            this.bbiReset,
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
            this.mainRibbonControl.Size = new System.Drawing.Size(651, 126);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.Id = 1;
            this.bbiCustomize.ImageOptions.ImageUri.Uri = "Customization";
            this.bbiCustomize.Name = "bbiCustomize";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Enregistrer ";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Enregistrer et fermer ";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Fermer";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save Layout";
            this.bbiSaveLayout.Id = 8;
            this.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiResetLayout
            // 
            this.bbiResetLayout.Caption = "Reset Layout";
            this.bbiResetLayout.Id = 9;
            this.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiResetLayout.Name = "bbiResetLayout";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Gestion des utilisateur ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.NomTextEdit);
            this.layoutControl1.Controls.Add(this.PrenomTextEdit);
            this.layoutControl1.Controls.Add(this.NomeutlisatureTextEdit);
            this.layoutControl1.Controls.Add(this.MotedePasseTextEdit);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 126);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(651, 211);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // NomTextEdit
            // 
            this.NomTextEdit.Location = new System.Drawing.Point(157, 39);
            this.NomTextEdit.Name = "NomTextEdit";
            this.NomTextEdit.Size = new System.Drawing.Size(472, 20);
            this.NomTextEdit.StyleController = this.layoutControl1;
            this.NomTextEdit.TabIndex = 5;
            // 
            // PrenomTextEdit
            // 
            this.PrenomTextEdit.Location = new System.Drawing.Point(157, 63);
            this.PrenomTextEdit.Name = "PrenomTextEdit";
            this.PrenomTextEdit.Size = new System.Drawing.Size(472, 20);
            this.PrenomTextEdit.StyleController = this.layoutControl1;
            this.PrenomTextEdit.TabIndex = 6;
            // 
            // NomeutlisatureTextEdit
            // 
            this.NomeutlisatureTextEdit.Location = new System.Drawing.Point(157, 87);
            this.NomeutlisatureTextEdit.Name = "NomeutlisatureTextEdit";
            this.NomeutlisatureTextEdit.Size = new System.Drawing.Size(472, 20);
            this.NomeutlisatureTextEdit.StyleController = this.layoutControl1;
            this.NomeutlisatureTextEdit.TabIndex = 7;
            // 
            // MotedePasseTextEdit
            // 
            this.MotedePasseTextEdit.Location = new System.Drawing.Point(157, 111);
            this.MotedePasseTextEdit.Name = "MotedePasseTextEdit";
            this.MotedePasseTextEdit.Size = new System.Drawing.Size(472, 20);
            this.MotedePasseTextEdit.StyleController = this.layoutControl1;
            this.MotedePasseTextEdit.TabIndex = 8;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Admin";
            this.comboBoxEdit1.Location = new System.Drawing.Point(157, 135);
            this.comboBoxEdit1.MenuManager = this.mainRibbonControl;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Admin",
            " "});
            this.comboBoxEdit1.Properties.ReadOnly = true;
            this.comboBoxEdit1.Size = new System.Drawing.Size(472, 20);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Root1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(651, 211);
            this.Root.TextVisible = false;
            // 
            // Root1
            // 
            this.Root1.CustomizationFormText = "Root";
            this.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root1.GroupBordersVisible = false;
            this.Root1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.autoGeneratedGroup0});
            this.Root1.Location = new System.Drawing.Point(0, 0);
            this.Root1.Name = "Root1";
            this.Root1.OptionsItemText.TextToControlDistance = 3;
            this.Root1.Size = new System.Drawing.Size(631, 191);
            this.Root1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root1.Text = "Root";
            this.Root1.TextVisible = false;
            // 
            // autoGeneratedGroup0
            // 
            this.autoGeneratedGroup0.AllowDrawBackground = false;
            this.autoGeneratedGroup0.CustomizationFormText = "autoGeneratedGroup0";
            this.autoGeneratedGroup0.GroupBordersVisible = false;
            this.autoGeneratedGroup0.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNom,
            this.ItemForPrenom,
            this.ItemForNomeutlisature,
            this.ItemForMotedePasse,
            this.layoutControlItem1,
            this.simpleLabelItem1});
            this.autoGeneratedGroup0.Location = new System.Drawing.Point(0, 0);
            this.autoGeneratedGroup0.Name = "autoGeneratedGroup0";
            this.autoGeneratedGroup0.OptionsItemText.TextToControlDistance = 3;
            this.autoGeneratedGroup0.Size = new System.Drawing.Size(611, 171);
            // 
            // ItemForNom
            // 
            this.ItemForNom.Control = this.NomTextEdit;
            this.ItemForNom.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ItemForNom.CustomizationFormText = "Nom";
            this.ItemForNom.Location = new System.Drawing.Point(0, 17);
            this.ItemForNom.Name = "ItemForNom";
            this.ItemForNom.Size = new System.Drawing.Size(611, 24);
            this.ItemForNom.Text = "Nom";
            this.ItemForNom.TextSize = new System.Drawing.Size(123, 13);
            // 
            // ItemForPrenom
            // 
            this.ItemForPrenom.Control = this.PrenomTextEdit;
            this.ItemForPrenom.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ItemForPrenom.CustomizationFormText = "Prenom";
            this.ItemForPrenom.Location = new System.Drawing.Point(0, 41);
            this.ItemForPrenom.Name = "ItemForPrenom";
            this.ItemForPrenom.Size = new System.Drawing.Size(611, 24);
            this.ItemForPrenom.Text = "Prénom";
            this.ItemForPrenom.TextSize = new System.Drawing.Size(123, 13);
            // 
            // ItemForNomeutlisature
            // 
            this.ItemForNomeutlisature.Control = this.NomeutlisatureTextEdit;
            this.ItemForNomeutlisature.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ItemForNomeutlisature.CustomizationFormText = "Nomeutlisature";
            this.ItemForNomeutlisature.Location = new System.Drawing.Point(0, 65);
            this.ItemForNomeutlisature.Name = "ItemForNomeutlisature";
            this.ItemForNomeutlisature.Size = new System.Drawing.Size(611, 24);
            this.ItemForNomeutlisature.Text = "Nom d\'utilisateur";
            this.ItemForNomeutlisature.TextSize = new System.Drawing.Size(123, 13);
            // 
            // ItemForMotedePasse
            // 
            this.ItemForMotedePasse.Control = this.MotedePasseTextEdit;
            this.ItemForMotedePasse.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ItemForMotedePasse.CustomizationFormText = "Motede Passe";
            this.ItemForMotedePasse.Location = new System.Drawing.Point(0, 89);
            this.ItemForMotedePasse.Name = "ItemForMotedePasse";
            this.ItemForMotedePasse.Size = new System.Drawing.Size(611, 24);
            this.ItemForMotedePasse.Text = "Mot de Passe";
            this.ItemForMotedePasse.TextSize = new System.Drawing.Size(123, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.comboBoxEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 113);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(611, 58);
            this.layoutControlItem1.Text = "Rôle";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(123, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(611, 17);
            this.simpleLabelItem1.Text = "Ajouter un administrateur";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(123, 13);
            // 
            // adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 337);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "adduser";
            this.Text = "Ajouter un utilisateur ";
            this.Load += new System.EventHandler(this.adduser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrenomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeutlisatureTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotedePasseTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoGeneratedGroup0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNomeutlisature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotedePasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiCustomize;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit NomTextEdit;
        private DevExpress.XtraEditors.TextEdit PrenomTextEdit;
        private DevExpress.XtraEditors.TextEdit NomeutlisatureTextEdit;
        private DevExpress.XtraEditors.TextEdit MotedePasseTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root1;
        private DevExpress.XtraLayout.LayoutControlGroup autoGeneratedGroup0;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrenom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNomeutlisature;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMotedePasse;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    }
}