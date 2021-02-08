namespace DeliverySystem.PL.Main
{
    partial class FRM_MainForm
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.ButtonHelperFolder = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHelperFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.ButtonHelperFolder);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(72, 35);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(268, 430);
            this.radGroupBox1.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(26, 119);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(213, 35);
            this.radButton1.TabIndex = 140;
            this.radButton1.Text = "رفع البيانات";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // ButtonHelperFolder
            // 
            this.ButtonHelperFolder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHelperFolder.Location = new System.Drawing.Point(26, 66);
            this.ButtonHelperFolder.Name = "ButtonHelperFolder";
            this.ButtonHelperFolder.Size = new System.Drawing.Size(213, 35);
            this.ButtonHelperFolder.TabIndex = 139;
            this.ButtonHelperFolder.Text = "الملفات الاساسية";
            this.ButtonHelperFolder.ThemeName = "TelerikMetroBlue";
            this.ButtonHelperFolder.Click += new System.EventHandler(this.ButtonHelperFolder_Click);
            // 
            // radButton2
            // 
            this.radButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton2.Location = new System.Drawing.Point(26, 21);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(213, 35);
            this.radButton2.TabIndex = 140;
            this.radButton2.Text = "قطع الوصولات";
            this.radButton2.ThemeName = "TelerikMetroBlue";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // FRM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 511);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "FRM_MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة البرنامج ";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.FRM_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHelperFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadButton ButtonHelperFolder;
        public Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        public Telerik.WinControls.UI.RadButton radButton2;
    }
}
