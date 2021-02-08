using DeliverySystem.Actions;
using DeliverySystem.Actions.Genral;
using DeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WarehouseControlSystem.CONN;

namespace DeliverySystem.PL.BasicFiles
{
    public partial class FRM_UserRole : Telerik.WinControls.UI.RadForm
    {
        UserProfile_Actions act = new UserProfile_Actions();
        cmb_Actions cmb = new cmb_Actions();
        UserRole_Model userRole_Model = new UserRole_Model();
        public FRM_UserRole()
        {
            InitializeComponent();
        }
        int tap_index = 1;
        void tabArrange()
        {
            textName.TabIndex = tap_index++;
            buttonSave.TabIndex = tap_index++;
            ButtonNew.TabIndex = tap_index++;
        }
        private void FRM_UserRole_Load(object sender, EventArgs e)
        {
            tabArrange();
            afteraction();
        }
        void afteraction()
        {
            textRoleID.Text = "??";
            textName.Text = "";
            textName.Focus();
            DGV.DataSource = cmb.GetUserRole();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.Text.Length == 0)

                {
                    DialogResult dialogResult = MessageBox.Show("..يرجى ملئ جميع الحقول المفعلة", "! خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    userRole_Model.name = textName.Text.Trim();
                    if (textRoleID.Text == "??")
                        userRole_Model.id = 0;
                    else userRole_Model.id = Convert.ToInt32(textRoleID.Text);
                    userRole_Model.userid = SystemInfo.id;
                    userRole_Model.Date = DateTime.Now;
                    act.InsertUserRole(userRole_Model);
                    afteraction();


                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
            textRoleID.Text= DGV.CurrentRow.Cells[0].Value.ToString();
            textName.Text= DGV.CurrentRow.Cells[1].Value.ToString();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            afteraction();
        }
    }
}
