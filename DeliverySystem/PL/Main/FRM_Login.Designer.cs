namespace DeliverySystem
{
    partial class FRM_Login
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.label3 = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(183, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "نظام التوصيل";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Controls.Add(this.btnLogin);
            this.radPanel1.Controls.Add(this.txtPassword);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.txtUserName);
            this.radPanel1.Location = new System.Drawing.Point(12, 90);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.EnableElementShadow = true;
            this.radPanel1.RootElement.ShadowDepth = 3;
            this.radPanel1.RootElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.radPanel1.Size = new System.Drawing.Size(453, 174);
            this.radPanel1.TabIndex = 24;
            this.radPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(304, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = ": اسم المستخدم";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(22, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(401, 39);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "تسجيل دخول";
            this.btnLogin.ThemeName = "TelerikMetroBlue";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(22, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(267, 26);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(304, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = ": كلمة المرور";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserName.Location = new System.Drawing.Point(22, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(267, 26);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 309);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
    }
}