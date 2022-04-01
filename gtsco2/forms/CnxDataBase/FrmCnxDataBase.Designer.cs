
namespace gtsco2.forms.CnxDataBase
{
    partial class FrmCnxDataBase
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEditSercver = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit3Nometu = new DevExpress.XtraEditors.TextEdit();
            this.textEditPs = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator5 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSercver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3Nometu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditSercver);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Controls.Add(this.textEdit3Nometu);
            this.layoutControl1.Controls.Add(this.textEditPs);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(732, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(398, 186);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEditSercver
            // 
            this.textEditSercver.Location = new System.Drawing.Point(127, 35);
            this.textEditSercver.Name = "textEditSercver";
            this.textEditSercver.Size = new System.Drawing.Size(259, 20);
            this.textEditSercver.StyleController = this.layoutControl1;
            this.textEditSercver.TabIndex = 4;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(127, 60);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Authentification Windows",
            "Authentification SQL serveur"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(259, 20);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 6;
            // 
            // textEdit3Nometu
            // 
            this.textEdit3Nometu.Location = new System.Drawing.Point(127, 85);
            this.textEdit3Nometu.Name = "textEdit3Nometu";
            this.textEdit3Nometu.Size = new System.Drawing.Size(259, 20);
            this.textEdit3Nometu.StyleController = this.layoutControl1;
            this.textEdit3Nometu.TabIndex = 7;
            // 
            // textEditPs
            // 
            this.textEditPs.Location = new System.Drawing.Point(127, 109);
            this.textEditPs.Name = "textEditPs";
            this.textEditPs.Size = new System.Drawing.Size(259, 20);
            this.textEditPs.StyleController = this.layoutControl1;
            this.textEditPs.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 133);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(374, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Connecter ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.simpleLabelItem1,
            this.simpleSeparator3,
            this.simpleSeparator5,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(398, 186);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditSercver;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem1.Text = "Nom de serveur";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBoxEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem3.Text = "Authentification";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit3Nometu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem4.Text = "        Nom d\'utilisateur";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEditPs;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem5.Text = "        Mot de passe";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(103, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.MaxSize = new System.Drawing.Size(378, 23);
            this.simpleLabelItem1.MinSize = new System.Drawing.Size(378, 23);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(378, 23);
            this.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleLabelItem1.Text = "Se Connecter au serveur";
            this.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 47);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(378, 1);
            // 
            // simpleSeparator5
            // 
            this.simpleSeparator5.AllowHotTrack = false;
            this.simpleSeparator5.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.simpleSeparator5.AppearanceItemCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleSeparator5.AppearanceItemCaption.BorderColor = System.Drawing.Color.Transparent;
            this.simpleSeparator5.AppearanceItemCaption.Options.UseBackColor = true;
            this.simpleSeparator5.AppearanceItemCaption.Options.UseBorderColor = true;
            this.simpleSeparator5.AppearanceItemCaptionDisabled.BackColor = System.Drawing.Color.Transparent;
            this.simpleSeparator5.AppearanceItemCaptionDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.simpleSeparator5.AppearanceItemCaptionDisabled.Options.UseBackColor = true;
            this.simpleSeparator5.AppearanceItemCaptionDisabled.Options.UseBorderColor = true;
            this.simpleSeparator5.Location = new System.Drawing.Point(0, 72);
            this.simpleSeparator5.Name = "simpleSeparator5";
            this.simpleSeparator5.Size = new System.Drawing.Size(378, 1);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(378, 45);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmCnxDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 186);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmCnxDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Se Connecter au serveur";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditSercver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3Nometu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEditSercver;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3Nometu;
        private DevExpress.XtraEditors.TextEdit textEditPs;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}