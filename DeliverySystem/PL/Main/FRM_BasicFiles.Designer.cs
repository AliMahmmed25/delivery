namespace DeliverySystem.PL.Main
{
    partial class FRM_BasicFiles
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
            this.btn_usertype = new Telerik.WinControls.UI.RadButton();
            this.btn_users = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usertype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.btn_usertype);
            this.radGroupBox1.Controls.Add(this.btn_users);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(36, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(268, 180);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(30, 73);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(213, 35);
            this.radButton1.TabIndex = 141;
            this.radButton1.Text = "اسماء المحافظات";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // btn_usertype
            // 
            this.btn_usertype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usertype.Location = new System.Drawing.Point(30, 126);
            this.btn_usertype.Name = "btn_usertype";
            this.btn_usertype.Size = new System.Drawing.Size(213, 35);
            this.btn_usertype.TabIndex = 140;
            this.btn_usertype.Text = "انواع المشغلين";
            this.btn_usertype.ThemeName = "TelerikMetroBlue";
            this.btn_usertype.Visible = false;
            this.btn_usertype.Click += new System.EventHandler(this.btn_usertype_Click);
            // 
            // btn_users
            // 
            this.btn_users.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Location = new System.Drawing.Point(27, 21);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(213, 35);
            this.btn_users.TabIndex = 139;
            this.btn_users.Text = "اسماء العملاء";
            this.btn_users.ThemeName = "TelerikMetroBlue";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // FRM_BasicFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 220);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BasicFiles";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الملفات الاساسية";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.FRM_BasicFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usertype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadButton btn_usertype;
        public Telerik.WinControls.UI.RadButton btn_users;
        public Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
