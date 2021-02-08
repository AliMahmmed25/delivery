using DeliverySystem.PL.BasicFiles;
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
    public partial class FRM_BasicFiles : Telerik.WinControls.UI.RadForm
    {
        public FRM_BasicFiles()
        {
            InitializeComponent();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            new FRM_UserProfile().ShowDialog();
        }

        private void btn_usertype_Click(object sender, EventArgs e)
        {
            new FRM_UserRole().ShowDialog();
        }

        private void FRM_BasicFiles_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            new FRM_States().ShowDialog();
        }
    }
}
