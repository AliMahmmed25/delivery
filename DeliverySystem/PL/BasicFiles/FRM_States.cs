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

namespace DeliverySystem.PL.BasicFiles
{
    public partial class FRM_States : Telerik.WinControls.UI.RadForm
    {
        StateActions act = new StateActions();
        cmb_Actions cmb = new cmb_Actions();
        State_Model state_Model = new State_Model();
        public FRM_States()
        {
            InitializeComponent();
        }
        int tap_index = 1;
        void tabArrange()
        {
            textname.TabIndex = tap_index++;
            textprice.TabIndex = tap_index++;
            cmboStute.TabIndex = tap_index++;
            buttonSave.TabIndex = tap_index++;
            ButtonNew.TabIndex = tap_index++;
        }
        void afteraction()
        {
            textstateID.Text = "??";
            textname.Text = "";
            textprice.Text = "";
            cmboStute.SelectedIndex = -1;
            DGV.DataSource = cmb.cmb_GetStates();
            textname.Focus();

        }
        void insertupdate()
        {
            if (textname.Text.Length == 0 || textprice.Text.Length == 0 || cmboStute.SelectedIndex == -1 )
            {
                DialogResult dialogResult = MessageBox.Show("..يرجى ملئ جميع الحقول المفعلة", "! خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textstateID.Text == "??")
                state_Model.id = 0;
            else state_Model.id = Convert.ToInt32(textstateID.Text);
            state_Model.name = textname.Text.Trim();
            state_Model.price = Convert.ToDouble(textprice.Text.Trim());
            state_Model.state= Convert.ToInt32(cmboStute.SelectedIndex);
            state_Model.userid = SystemInfo.id;
            state_Model.Date = DateTime.Now;
            act.InsertState(state_Model);
            afteraction();

        }
        private void FRM_States_Load(object sender, EventArgs e)
        {
            tabArrange();
            afteraction();
        }

        private void textprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            afteraction();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            insertupdate();
        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
            textstateID.Text=DGV.CurrentRow.Cells[0].Value.ToString();
            textname.Text=DGV.CurrentRow.Cells[1].Value.ToString();
            textprice.Text = DGV.CurrentRow.Cells[2].Value.ToString();
            cmboStute.SelectedIndex = cmboStute.FindString(DGV.CurrentRow.Cells[3].Value.ToString());
        }

        private void DGV_Click(object sender, EventArgs e)
        {

        }
    }
}
