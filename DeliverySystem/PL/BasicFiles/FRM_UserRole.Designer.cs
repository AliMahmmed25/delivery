namespace DeliverySystem.PL.BasicFiles
{
    partial class FRM_UserRole
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonNew = new Telerik.WinControls.UI.RadButton();
            this.buttonSave = new Telerik.WinControls.UI.RadButton();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRoleID = new System.Windows.Forms.TextBox();
            this.DGV = new Telerik.WinControls.UI.RadGridView();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Controls.Add(this.label6);
            this.radGroupBox4.HeaderText = "";
            this.radGroupBox4.Location = new System.Drawing.Point(118, 12);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Size = new System.Drawing.Size(234, 46);
            this.radGroupBox4.TabIndex = 187;
            this.radGroupBox4.ThemeName = "Office2010Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(16, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "معالجة نوع المشغل";
            // 
            // ButtonNew
            // 
            this.ButtonNew.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.ButtonNew.Location = new System.Drawing.Point(160, 148);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(134, 36);
            this.ButtonNew.TabIndex = 446;
            this.ButtonNew.Text = "جديد";
            this.ButtonNew.ThemeName = "TelerikMetroBlue";
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(300, 148);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 36);
            this.buttonSave.TabIndex = 445;
            this.buttonSave.Text = "حفظ قيد";
            this.buttonSave.ThemeName = "TelerikMetroBlue";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(71, 106);
            this.textName.Name = "textName";
            this.textName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textName.Size = new System.Drawing.Size(249, 20);
            this.textName.TabIndex = 444;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(356, 106);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 443;
            this.label3.Text = "أسم النوع :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(358, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 441;
            this.label2.Text = "رقم النوع :";
            // 
            // textRoleID
            // 
            this.textRoleID.Enabled = false;
            this.textRoleID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoleID.Location = new System.Drawing.Point(210, 68);
            this.textRoleID.Multiline = true;
            this.textRoleID.Name = "textRoleID";
            this.textRoleID.ReadOnly = true;
            this.textRoleID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textRoleID.Size = new System.Drawing.Size(112, 32);
            this.textRoleID.TabIndex = 442;
            this.textRoleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV
            // 
            this.DGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.DGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.DGV.ForeColor = System.Drawing.Color.Black;
            this.DGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGV.Location = new System.Drawing.Point(22, 190);
            // 
            // 
            // 
            this.DGV.MasterTemplate.AllowAddNewRow = false;
            this.DGV.MasterTemplate.AllowColumnReorder = false;
            this.DGV.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "id";
            gridViewTextBoxColumn1.HeaderText = "رقم النوع";
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.Width = 162;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "name";
            gridViewTextBoxColumn2.HeaderText = "اسم النوع";
            gridViewTextBoxColumn2.Name = "name";
            gridViewTextBoxColumn2.Width = 240;
            this.DGV.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.DGV.MasterTemplate.EnableFiltering = true;
            this.DGV.MasterTemplate.EnableGrouping = false;
            this.DGV.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV.ShowGroupPanel = false;
            this.DGV.Size = new System.Drawing.Size(422, 277);
            this.DGV.TabIndex = 447;
            this.DGV.ThemeName = "TelerikMetroBlue";
            this.DGV.DoubleClick += new System.EventHandler(this.DGV_DoubleClick);
            // 
            // FRM_UserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 501);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRoleID);
            this.Controls.Add(this.radGroupBox4);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_UserRole";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة أنواع المشغلين";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.FRM_UserRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadButton ButtonNew;
        private Telerik.WinControls.UI.RadButton buttonSave;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRoleID;
        private Telerik.WinControls.UI.RadGridView DGV;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
