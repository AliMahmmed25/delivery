namespace DeliverySystem.PL.BasicFiles
{
    partial class FRM_States
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.DGV = new Telerik.WinControls.UI.RadGridView();
            this.ButtonNew = new Telerik.WinControls.UI.RadButton();
            this.buttonSave = new Telerik.WinControls.UI.RadButton();
            this.textname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textstateID = new System.Windows.Forms.TextBox();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboStute = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmboStute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.DGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.DGV.ForeColor = System.Drawing.Color.Black;
            this.DGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGV.Location = new System.Drawing.Point(12, 258);
            // 
            // 
            // 
            this.DGV.MasterTemplate.AllowAddNewRow = false;
            this.DGV.MasterTemplate.AllowColumnReorder = false;
            this.DGV.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "id";
            gridViewTextBoxColumn1.HeaderText = "رقم المحافظة";
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.Width = 103;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "name";
            gridViewTextBoxColumn2.HeaderText = "اسم المحافظة";
            gridViewTextBoxColumn2.Name = "name";
            gridViewTextBoxColumn2.Width = 161;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "price";
            gridViewTextBoxColumn3.HeaderText = "سعر التوصيل";
            gridViewTextBoxColumn3.Name = "price";
            gridViewTextBoxColumn3.Width = 120;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "state";
            gridViewTextBoxColumn4.HeaderText = "حالة المحافظة";
            gridViewTextBoxColumn4.Name = "state";
            gridViewTextBoxColumn4.Width = 135;
            this.DGV.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.DGV.MasterTemplate.EnableFiltering = true;
            this.DGV.MasterTemplate.EnableGrouping = false;
            this.DGV.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV.ShowGroupPanel = false;
            this.DGV.Size = new System.Drawing.Size(537, 298);
            this.DGV.TabIndex = 454;
            this.DGV.ThemeName = "TelerikMetroBlue";
            this.DGV.Click += new System.EventHandler(this.DGV_Click);
            this.DGV.DoubleClick += new System.EventHandler(this.DGV_DoubleClick);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.ButtonNew.Location = new System.Drawing.Point(248, 216);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(134, 36);
            this.ButtonNew.TabIndex = 453;
            this.ButtonNew.Text = "جديد";
            this.ButtonNew.ThemeName = "TelerikMetroBlue";
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(388, 216);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 36);
            this.buttonSave.TabIndex = 452;
            this.buttonSave.Text = "حفظ قيد";
            this.buttonSave.ThemeName = "TelerikMetroBlue";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(152, 110);
            this.textname.Name = "textname";
            this.textname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textname.Size = new System.Drawing.Size(249, 20);
            this.textname.TabIndex = 451;
            this.textname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(437, 108);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 450;
            this.label3.Text = "أسم المحافظة :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(437, 76);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 448;
            this.label2.Text = "رقم المحافظة :";
            // 
            // textstateID
            // 
            this.textstateID.Enabled = false;
            this.textstateID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstateID.Location = new System.Drawing.Point(289, 72);
            this.textstateID.Multiline = true;
            this.textstateID.Name = "textstateID";
            this.textstateID.ReadOnly = true;
            this.textstateID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textstateID.Size = new System.Drawing.Size(112, 32);
            this.textstateID.TabIndex = 449;
            this.textstateID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Controls.Add(this.label6);
            this.radGroupBox4.HeaderText = "";
            this.radGroupBox4.Location = new System.Drawing.Point(78, 12);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Size = new System.Drawing.Size(435, 46);
            this.radGroupBox4.TabIndex = 455;
            this.radGroupBox4.ThemeName = "Office2010Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(16, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "معالجة اسماء المحافظات واسعار التوصيل";
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(152, 146);
            this.textprice.Name = "textprice";
            this.textprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textprice.Size = new System.Drawing.Size(249, 20);
            this.textprice.TabIndex = 457;
            this.textprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textprice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(437, 144);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 456;
            this.label1.Text = "سعر التوصيل:";
            // 
            // cmboStute
            // 
            this.cmboStute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmboStute.DisplayMember = "Store_Name";
            this.cmboStute.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "مسموح";
            radListDataItem2.Text = "غير مسموح";
            this.cmboStute.Items.Add(radListDataItem1);
            this.cmboStute.Items.Add(radListDataItem2);
            this.cmboStute.Location = new System.Drawing.Point(153, 182);
            this.cmboStute.Name = "cmboStute";
            this.cmboStute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboStute.Size = new System.Drawing.Size(248, 23);
            this.cmboStute.TabIndex = 459;
            this.cmboStute.ThemeName = "TelerikMetroBlue";
            this.cmboStute.ValueMember = "Store_No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(439, 180);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 458;
            this.label4.Text = "حالة المحافظة :";
            // 
            // FRM_States
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 569);
            this.Controls.Add(this.cmboStute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGroupBox4);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textstateID);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "FRM_States";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة المحافظات";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.FRM_States_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmboStute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DGV;
        private Telerik.WinControls.UI.RadButton ButtonNew;
        private Telerik.WinControls.UI.RadButton buttonSave;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textstateID;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList cmboStute;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
