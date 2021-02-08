using DeliverySystem.Actions;
using DeliverySystem.Models;
using DeliverySystem.PL.Main;
using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DeliverySystem
{
    public partial class FRM_Login : Telerik.WinControls.UI.RadForm
    {
        UserProfile_Actions ActUser = new UserProfile_Actions();
        UserProfile_Model ModelUser = new UserProfile_Model();
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
           
        }
        public void login()
        {
            try
            {
                if (txtPassword.Text.Trim().Length > 0 && txtUserName.Text.Trim().Length > 0)
                {
                    ModelUser.username = txtUserName.Text;
                    ModelUser.password = txtPassword.Text;
                    DataTable dt = ActUser.CheckUserNameAndPassword(ModelUser);
                    if (dt.Rows.Count > 0)
                    {
                        if (int.Parse(dt.Rows[0]["roleUser"].ToString()) != 1)
                        {
                            MessageBox.Show("غير مصرح لك بلدخول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                       
                        SystemInfo.username = ModelUser.username;
                        SystemInfo.Password = ModelUser.password;
                        SystemInfo.roleUser = int.Parse(dt.Rows[0][1].ToString());
                        SystemInfo.id = int.Parse(dt.Rows[0][0].ToString());
                        Hide();
                        new FRM_MainForm().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم او كلمة السر غير صالحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show("حصل خطأ اثناء تسجيل الدخول", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
