
namespace gtsco2.forms.Page_de_garde.forjour
{
    partial class forjourETd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forjourETd));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.comboBoxjour1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxjour2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxjour1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxjour2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboBoxjour1);
            this.layoutControl1.Controls.Add(this.comboBoxjour2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(950, 84, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(486, 145);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(486, 145);
            this.Root.TextVisible = false;
            // 
            // comboBoxjour1
            // 
            this.comboBoxjour1.Location = new System.Drawing.Point(12, 28);
            this.comboBoxjour1.Name = "comboBoxjour1";
            this.comboBoxjour1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxjour1.Properties.Items.AddRange(new object[] {
            "Samedi",
            "Dimanche ",
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi"});
            this.comboBoxjour1.Size = new System.Drawing.Size(228, 20);
            this.comboBoxjour1.StyleController = this.layoutControl1;
            this.comboBoxjour1.TabIndex = 6;
            // 
            // comboBoxjour2
            // 
            this.comboBoxjour2.Location = new System.Drawing.Point(244, 28);
            this.comboBoxjour2.Name = "comboBoxjour2";
            this.comboBoxjour2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxjour2.Properties.Items.AddRange(new object[] {
            "Samedi",
            "Dimanche ",
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi"});
            this.comboBoxjour2.Size = new System.Drawing.Size(230, 20);
            this.comboBoxjour2.StyleController = this.layoutControl1;
            this.comboBoxjour2.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(244, 52);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(230, 36);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Imprime";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBoxjour1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(232, 125);
            this.layoutControlItem3.Text = "jour1";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(25, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBoxjour2;
            this.layoutControlItem4.Location = new System.Drawing.Point(232, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(234, 40);
            this.layoutControlItem4.Text = "jour2";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(25, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(232, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(234, 85);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // forjourETd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 145);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("forjourETd.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "forjourETd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmforimolierdesabsonce";
            this.Load += new System.EventHandler(this.forjourETd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxjour1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxjour2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxjour1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxjour2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}