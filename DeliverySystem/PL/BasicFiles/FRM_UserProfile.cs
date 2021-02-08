using DeliverySystem.Actions;
using DeliverySystem.Actions.Genral;
using DeliverySystem.Models;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DeliverySystem.PL.BasicFiles
{
    public partial class FRM_UserProfile : Telerik.WinControls.UI.RadForm
    {
        UserProfile_Actions act = new UserProfile_Actions();
        UserProfile_Model model = new UserProfile_Model();

        public FRM_UserProfile()
        {
            InitializeComponent();
        }
        int tap_index = 1;
        void tabArrange()
        {
            textUserName.TabIndex = tap_index++;
            textUserPasswprd.TabIndex = tap_index++;
            cmboRole.TabIndex = tap_index++;
            DateEndWork.TabIndex = tap_index++;
            cmboStute.TabIndex= tap_index++;
            buttonSave.TabIndex = tap_index++;
            ButtonNew.TabIndex = tap_index++;
        }
        void afterAction()
        {
            textUserID.Text = "??";
            textUserName.Text = "";
            textUserPasswprd.Text = "";
            cmboRole.SelectedIndex = -1;
            cmboStute.SelectedIndex = -1;
            cmbostate.SelectedIndex = -1;
            DateEndWork.Value = DateTime.Now;
            MasterTemplate.DataSource = act.GetUsers();
            textUserName.Focus();
        }
        void insertupdate()
        {
            if(textUserName.Text.Length==0|| textUserPasswprd.Text.Length == 0 ||cmboRole.SelectedIndex==-1||cmboStute.SelectedIndex==-1)
            {
                DialogResult dialogResult = MessageBox.Show("..يرجى ملئ جميع الحقول المفعلة", "! خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (textUserID.Text == "??")
                    model.id = 0;
                else model.id = Convert.ToInt32(textUserID.Text);
                model.username = textUserName.Text.Trim();
                model.password=textUserPasswprd.Text.Trim();
                model.roleUser = Convert.ToInt32(cmboRole.SelectedItem.Value);
                model.stateUser= Convert.ToInt32(cmboStute.SelectedIndex);
                model.dateValidate = DateEndWork.Value;
                model.user = SystemInfo.id;
                model.date = DateTime.Now;
                if (cmbostate.Visible==true)
                    model.state = Convert.ToInt32(cmbostate.SelectedValue);
                else model.state = 0;
                act.InsertUser(model);
                afterAction();
            }
        }

        private void FRM_UserProfile_Load(object sender, EventArgs e)
        {
            tabArrange();
            cmboRole.DataSource = new cmb_Actions().GetUserRole();
            cmboRole.DisplayMember = "name";
            cmboRole.ValueMember = "id";
            cmboRole.SelectedIndex = -1;
            cmbostate.DataSource = new cmb_Actions().cmb_GetStates();
            cmbostate.DisplayMember = "name";
            cmbostate.ValueMember = "id";
            cmbostate.SelectedIndex = -1;
            afterAction();


        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            afterAction();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            insertupdate();
        }

        private void textUserName_Leave(object sender, EventArgs e)
        {
            if (act.UserProfileCheckNameDoublicate(textUserName.Text).Rows.Count > 0 )
            {
                RadMessageBox.Show("اسم المشغل مدخل مسبقا", "تنبيه", MessageBoxButtons.OK, RadMessageIcon.Info);
                textUserName.Clear();
            }
        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
               textUserID.Text = MasterTemplate.CurrentRow.Cells[0].Value.ToString();
            textUserName.Text = MasterTemplate.CurrentRow.Cells[2].Value.ToString();
            textUserPasswprd.Text = MasterTemplate.CurrentRow.Cells[3].Value.ToString();
            cmboRole.SelectedIndex = cmboRole.FindString(MasterTemplate.CurrentRow.Cells[4].Value.ToString());
            DateEndWork.Text = MasterTemplate.CurrentRow.Cells[6].Value.ToString();
            cmboStute.SelectedIndex = cmboStute.FindString( MasterTemplate.CurrentRow.Cells[5].Value.ToString());
            cmbostate.SelectedIndex = cmbostate.FindString(MasterTemplate.CurrentRow.Cells[7].Value.ToString());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmboRole_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cmboRole.SelectedIndex==4)
            {
                label8.Visible = true;
                cmbostate.Visible = true;
            }
            else
            {
                label8.Visible = false;
                cmbostate.Visible = false;
            }
        }
    }
}
