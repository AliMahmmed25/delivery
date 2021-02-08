using DeliverySystem.Actions.upload;
using DeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DeliverySystem.PL.Main
{
    public partial class FRM_MainForm : Telerik.WinControls.UI.RadForm
    {
        UploadAction uploadAction = new UploadAction();
        UserProfile_Model UserProfile_Model = new UserProfile_Model();
        State_Model State_Model = new State_Model();
        public FRM_MainForm()
        {
            InitializeComponent();
        }

        private void ButtonHelperFolder_Click(object sender, EventArgs e)
        {
            new FRM_BasicFiles().ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataTable dtresult = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt2result = new DataTable();
                dt = uploadAction.GetUsersforupload();
                dt2 = uploadAction.Getstatesforupload();
                if (dt.Rows.Count == 0&&dt2.Rows.Count == 0)
                {
                    MessageBox.Show("جميع البيانات محملة على السيرفر", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        UserProfile_Model.id = int.Parse(dt.Rows[i]["id"].ToString());
                        UserProfile_Model.username = dt.Rows[i]["username"].ToString();
                        UserProfile_Model.password = dt.Rows[i]["password"].ToString();
                        UserProfile_Model.roleUser = int.Parse(dt.Rows[i]["roleUser"].ToString());
                        UserProfile_Model.stateUser = int.Parse(dt.Rows[i]["stateUser"].ToString());
                        UserProfile_Model.dateValidate = Convert.ToDateTime(dt.Rows[i]["dateValidate"].ToString());
                        UserProfile_Model.uuid = dt.Rows[i]["uuid"].ToString();
                        dtresult=uploadAction.user_profileInsertUpdate(UserProfile_Model);
                        if(dtresult.Rows.Count>0)
                            uploadAction.UpdateUserSync(UserProfile_Model.id);
                    }
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        State_Model.id = int.Parse(dt2.Rows[i]["id"].ToString());
                        State_Model.name = dt2.Rows[i]["name"].ToString();
                        State_Model.price = Convert.ToDouble(dt2.Rows[i]["price"].ToString());
                        State_Model.state = int.Parse(dt2.Rows[i]["state"].ToString());
                        dt2result=uploadAction.locationsInsertUpdate(State_Model);
                        if (dt2result.Rows.Count > 0)
                            uploadAction.UpdateStatesSync(State_Model.id);
                    }
                    MessageBox.Show("تم رفع البيانات الى السيرفر", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void FRM_MainForm_Load(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            new FRM_Receipts().ShowDialog();
        }
    }
}
