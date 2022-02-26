
namespace gtsco2.forms
{
    partial class Navigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigation));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addabsbtn = new DevExpress.XtraEditors.SimpleButton();
            this.absbt = new DevExpress.XtraEditors.SimpleButton();
            this.evabtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(841, 450);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.addabsbtn);
            this.flowLayoutPanel1.Controls.Add(this.absbt);
            this.flowLayoutPanel1.Controls.Add(this.evabtn);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton5);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton7);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton9);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton1);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton8);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton10);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton11);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton12);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(837, 446);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // addabsbtn
            // 
            this.addabsbtn.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.addabsbtn.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addabsbtn.Appearance.BorderColor = System.Drawing.Color.White;
            this.addabsbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addabsbtn.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.addabsbtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.addabsbtn.Appearance.Options.UseBackColor = true;
            this.addabsbtn.Appearance.Options.UseBorderColor = true;
            this.addabsbtn.Appearance.Options.UseFont = true;
            this.addabsbtn.Appearance.Options.UseForeColor = true;
            this.addabsbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addabsbtn.ImageOptions.Image")));
            this.addabsbtn.Location = new System.Drawing.Point(3, 3);
            this.addabsbtn.Name = "addabsbtn";
            this.addabsbtn.Size = new System.Drawing.Size(202, 87);
            this.addabsbtn.TabIndex = 5;
            this.addabsbtn.Text = "Saisie \r\ndes absences";
            this.addabsbtn.ToolTip = "Mentionné le nombre de séances absenté par jour";
            this.addabsbtn.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.addabsbtn.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // absbt
            // 
            this.absbt.Appearance.BackColor = System.Drawing.Color.Lime;
            this.absbt.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.absbt.Appearance.BorderColor = System.Drawing.Color.White;
            this.absbt.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absbt.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.absbt.Appearance.ForeColor = System.Drawing.Color.Black;
            this.absbt.Appearance.Options.UseBackColor = true;
            this.absbt.Appearance.Options.UseBorderColor = true;
            this.absbt.Appearance.Options.UseFont = true;
            this.absbt.Appearance.Options.UseForeColor = true;
            this.absbt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("absbt.ImageOptions.Image")));
            this.absbt.Location = new System.Drawing.Point(211, 3);
            this.absbt.Name = "absbt";
            this.absbt.Size = new System.Drawing.Size(202, 87);
            this.absbt.TabIndex = 2;
            this.absbt.Text = "Affichage \r\ndes absences";
            this.absbt.ToolTip = "Calculer et afficher le nombre et les sanctions d\'absences";
            this.absbt.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.absbt.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // evabtn
            // 
            this.evabtn.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.evabtn.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.evabtn.Appearance.BorderColor = System.Drawing.Color.White;
            this.evabtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evabtn.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.evabtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.evabtn.Appearance.Options.UseBackColor = true;
            this.evabtn.Appearance.Options.UseBorderColor = true;
            this.evabtn.Appearance.Options.UseFont = true;
            this.evabtn.Appearance.Options.UseForeColor = true;
            this.evabtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("evabtn.ImageOptions.Image")));
            this.evabtn.Location = new System.Drawing.Point(419, 3);
            this.evabtn.Name = "evabtn";
            this.evabtn.Size = new System.Drawing.Size(202, 87);
            this.evabtn.TabIndex = 3;
            this.evabtn.Text = "Affichage \r\ndes moyennes";
            this.evabtn.ToolTip = "Calculer et afficher les moyennes d\'une section";
            this.evabtn.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.evabtn.Click += new System.EventHandler(this.evabtn_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.Gray;
            this.simpleButton5.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.simpleButton5.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseBorderColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(627, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(202, 87);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Affichage \r\ndes notes /module\r\n";
            this.simpleButton5.ToolTip = "Afficher et visualiser les notes d\'une section";
            this.simpleButton5.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.simpleButton7.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.simpleButton7.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseBorderColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Appearance.Options.UseForeColor = true;
            this.simpleButton7.Location = new System.Drawing.Point(3, 96);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(202, 87);
            this.simpleButton7.TabIndex = 6;
            this.simpleButton7.Text = "Evaluation";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.BackColor = System.Drawing.Color.Blue;
            this.simpleButton9.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.simpleButton9.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton9.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton9.Appearance.Options.UseBackColor = true;
            this.simpleButton9.Appearance.Options.UseBorderColor = true;
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Appearance.Options.UseForeColor = true;
            this.simpleButton9.Location = new System.Drawing.Point(211, 96);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(202, 87);
            this.simpleButton9.TabIndex = 8;
            this.simpleButton9.Text = "Evaluation";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Fuchsia;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(419, 96);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(202, 87);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Evaluation";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.Color.Blue;
            this.simpleButton8.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.simpleButton8.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton8.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.Appearance.Options.UseBorderColor = true;
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Appearance.Options.UseForeColor = true;
            this.simpleButton8.Location = new System.Drawing.Point(627, 96);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(202, 87);
            this.simpleButton8.TabIndex = 7;
            this.simpleButton8.Text = "Evaluation";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.BackColor = System.Drawing.Color.Blue;
            this.simpleButton10.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.simpleButton10.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton10.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton10.Appearance.Options.UseBackColor = true;
            this.simpleButton10.Appearance.Options.UseBorderColor = true;
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.Appearance.Options.UseForeColor = true;
            this.simpleButton10.Location = new System.Drawing.Point(3, 189);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(202, 87);
            this.simpleButton10.TabIndex = 9;
            this.simpleButton10.Text = "Evaluation";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.BackColor = System.Drawing.Color.Blue;
            this.simpleButton11.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.simpleButton11.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton11.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton11.Appearance.Options.UseBackColor = true;
            this.simpleButton11.Appearance.Options.UseBorderColor = true;
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Appearance.Options.UseForeColor = true;
            this.simpleButton11.Location = new System.Drawing.Point(211, 189);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(202, 87);
            this.simpleButton11.TabIndex = 10;
            this.simpleButton11.Text = "Evaluation";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.BackColor = System.Drawing.Color.Blue;
            this.simpleButton12.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.simpleButton12.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton12.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton12.Appearance.Options.UseBackColor = true;
            this.simpleButton12.Appearance.Options.UseBorderColor = true;
            this.simpleButton12.Appearance.Options.UseFont = true;
            this.simpleButton12.Appearance.Options.UseForeColor = true;
            this.simpleButton12.Location = new System.Drawing.Point(419, 189);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(202, 87);
            this.simpleButton12.TabIndex = 11;
            this.simpleButton12.Text = "Evaluation";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "Navigation";
            this.Text = "Navigation";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton absbt;
        private DevExpress.XtraEditors.SimpleButton evabtn;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton addabsbtn;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
    }
}