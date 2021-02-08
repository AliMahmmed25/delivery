namespace DeliverySystem.PL.BasicFiles
{
    partial class FRM_UserProfile
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboRole = new Telerik.WinControls.UI.RadDropDownList();
            this.textUserPasswprd = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateEndWork = new Telerik.WinControls.UI.RadDateTimePicker();
            this.MasterTemplate = new Telerik.WinControls.UI.RadGridView();
            this.ButtonNew = new Telerik.WinControls.UI.RadButton();
            this.buttonSave = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboStute = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbostate = new Telerik.WinControls.UI.RadDropDownList();
            this.label8 = new System.Windows.Forms.Label();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmboRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEndWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmboStute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbostate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Controls.Add(this.label6);
            this.radGroupBox4.HeaderText = "";
            this.radGroupBox4.Location = new System.Drawing.Point(159, 12);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Size = new System.Drawing.Size(263, 46);
            this.radGroupBox4.TabIndex = 186;
            this.radGroupBox4.ThemeName = "Office2010Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(16, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "واجهة أسماء المشغلين";
            // 
            // cmboRole
            // 
            this.cmboRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmboRole.DisplayMember = "Store_Name";
            this.cmboRole.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboRole.Location = new System.Drawing.Point(165, 175);
            this.cmboRole.Name = "cmboRole";
            this.cmboRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboRole.Size = new System.Drawing.Size(249, 23);
            this.cmboRole.TabIndex = 435;
            this.cmboRole.ThemeName = "TelerikMetroBlue";
            this.cmboRole.ValueMember = "Store_No";
            this.cmboRole.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmboRole_SelectedIndexChanged);
            // 
            // textUserPasswprd
            // 
            this.textUserPasswprd.Location = new System.Drawing.Point(165, 140);
            this.textUserPasswprd.Name = "textUserPasswprd";
            this.textUserPasswprd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textUserPasswprd.Size = new System.Drawing.Size(249, 20);
            this.textUserPasswprd.TabIndex = 434;
            this.textUserPasswprd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(165, 107);
            this.textUserName.Name = "textUserName";
            this.textUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textUserName.Size = new System.Drawing.Size(249, 20);
            this.textUserName.TabIndex = 433;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUserName.Leave += new System.EventHandler(this.textUserName_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(445, 175);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 432;
            this.label7.Text = "نوعه :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(445, 138);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 431;
            this.label5.Text = "الرمز السري :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(445, 107);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 430;
            this.label3.Text = "أسم العميل :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(445, 73);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 428;
            this.label2.Text = "رقم العميل :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textUserID
            // 
            this.textUserID.Enabled = false;
            this.textUserID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserID.Location = new System.Drawing.Point(304, 69);
            this.textUserID.Multiline = true;
            this.textUserID.Name = "textUserID";
            this.textUserID.ReadOnly = true;
            this.textUserID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textUserID.Size = new System.Drawing.Size(112, 32);
            this.textUserID.TabIndex = 429;
            this.textUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(416, 209);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 436;
            this.label1.Text = "تاريخ نهاية الترخيص :";
            // 
            // DateEndWork
            // 
            this.DateEndWork.CustomFormat = "dd/MM/yyyy";
            this.DateEndWork.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.DateEndWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEndWork.Location = new System.Drawing.Point(166, 211);
            this.DateEndWork.Name = "DateEndWork";
            this.DateEndWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateEndWork.Size = new System.Drawing.Size(248, 23);
            this.DateEndWork.TabIndex = 437;
            this.DateEndWork.TabStop = false;
            this.DateEndWork.Text = "1/30/2021";
            this.DateEndWork.ThemeName = "TelerikMetroBlue";
            this.DateEndWork.Value = new System.DateTime(2021, 1, 30, 3, 53, 17, 0);
            // 
            // MasterTemplate
            // 
            this.MasterTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.MasterTemplate.Cursor = System.Windows.Forms.Cursors.Default;
            this.MasterTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.MasterTemplate.ForeColor = System.Drawing.Color.Black;
            this.MasterTemplate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasterTemplate.Location = new System.Drawing.Point(16, 357);
            // 
            // 
            // 
            this.MasterTemplate.MasterTemplate.AllowAddNewRow = false;
            this.MasterTemplate.MasterTemplate.AllowColumnReorder = false;
            this.MasterTemplate.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "id";
            gridViewTextBoxColumn1.HeaderText = "رقم المشغل";
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.Width = 63;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "uuid";
            gridViewTextBoxColumn2.HeaderText = "uuid";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "uuid";
            gridViewTextBoxColumn2.Width = 232;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "username";
            gridViewTextBoxColumn3.HeaderText = "اسم المشغل";
            gridViewTextBoxColumn3.Name = "username";
            gridViewTextBoxColumn3.Width = 115;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "password";
            gridViewTextBoxColumn4.HeaderText = "الرقم السري";
            gridViewTextBoxColumn4.Name = "password";
            gridViewTextBoxColumn4.Width = 61;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "name";
            gridViewTextBoxColumn5.HeaderText = "نوع المستخدم";
            gridViewTextBoxColumn5.Name = "name";
            gridViewTextBoxColumn5.Width = 82;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "stateUser";
            gridViewTextBoxColumn6.HeaderText = "حالة المشغل";
            gridViewTextBoxColumn6.Name = "stateUser";
            gridViewTextBoxColumn6.Width = 76;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "dateValidate";
            gridViewTextBoxColumn7.HeaderText = "تاريخ نهاية العمل";
            gridViewTextBoxColumn7.Name = "dateValidate";
            gridViewTextBoxColumn7.Width = 101;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "state";
            gridViewTextBoxColumn8.HeaderText = "المحافظة";
            gridViewTextBoxColumn8.Name = "state";
            gridViewTextBoxColumn8.Width = 76;
            this.MasterTemplate.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.MasterTemplate.MasterTemplate.EnableFiltering = true;
            this.MasterTemplate.MasterTemplate.EnableGrouping = false;
            this.MasterTemplate.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.MasterTemplate.Name = "MasterTemplate";
            this.MasterTemplate.ReadOnly = true;
            this.MasterTemplate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MasterTemplate.ShowGroupPanel = false;
            this.MasterTemplate.Size = new System.Drawing.Size(589, 256);
            this.MasterTemplate.TabIndex = 438;
            this.MasterTemplate.ThemeName = "TelerikMetroBlue";
            this.MasterTemplate.DoubleClick += new System.EventHandler(this.DGV_DoubleClick);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.ButtonNew.Location = new System.Drawing.Point(266, 311);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(134, 36);
            this.ButtonNew.TabIndex = 440;
            this.ButtonNew.Text = "جديد";
            this.ButtonNew.ThemeName = "TelerikMetroBlue";
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(406, 311);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 36);
            this.buttonSave.TabIndex = 439;
            this.buttonSave.Text = "حفظ قيد";
            this.buttonSave.ThemeName = "TelerikMetroBlue";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(445, 250);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 441;
            this.label4.Text = "حالة المشغل :";
            // 
            // cmboStute
            // 
            this.cmboStute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmboStute.DisplayMember = "Store_Name";
            this.cmboStute.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "فعال";
            radListDataItem2.Text = "متوقف";
            this.cmboStute.Items.Add(radListDataItem1);
            this.cmboStute.Items.Add(radListDataItem2);
            this.cmboStute.Location = new System.Drawing.Point(166, 250);
            this.cmboStute.Name = "cmboStute";
            this.cmboStute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboStute.Size = new System.Drawing.Size(248, 23);
            this.cmboStute.TabIndex = 442;
            this.cmboStute.ThemeName = "TelerikMetroBlue";
            this.cmboStute.ValueMember = "Store_No";
            // 
            // cmbostate
            // 
            this.cmbostate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbostate.DisplayMember = "Store_Name";
            this.cmbostate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbostate.Location = new System.Drawing.Point(166, 285);
            this.cmbostate.Name = "cmbostate";
            this.cmbostate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbostate.Size = new System.Drawing.Size(249, 23);
            this.cmbostate.TabIndex = 444;
            this.cmbostate.ThemeName = "TelerikMetroBlue";
            this.cmbostate.ValueMember = "Store_No";
            this.cmbostate.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(446, 285);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 443;
            this.label8.Text = "المحافظة :";
            this.label8.Visible = false;
            // 
            // FRM_UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 616);
            this.Controls.Add(this.cmbostate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmboStute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.MasterTemplate);
            this.Controls.Add(this.DateEndWork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboRole);
            this.Controls.Add(this.textUserPasswprd);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.radGroupBox4);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_UserProfile";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة أسماء المشغلين";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.FRM_UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmboRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEndWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmboStute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbostate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadDropDownList cmboRole;
        private System.Windows.Forms.TextBox textUserPasswprd;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker DateEndWork;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
        private Telerik.WinControls.UI.RadButton ButtonNew;
        private Telerik.WinControls.UI.RadButton buttonSave;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList cmboStute;
        private Telerik.WinControls.UI.RadDropDownList cmbostate;
        private System.Windows.Forms.Label label8;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
