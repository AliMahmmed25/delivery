using DeliverySystem.Actions.Genral;
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
    public partial class FRM_Receipts : Telerik.WinControls.UI.RadForm
    {
        DownloadActions act = new DownloadActions();
        DataTable datastuts = new DataTable();
        DataTable dateuser = new DataTable();
        cmb_Actions cmb = new cmb_Actions();
        Order_Model Order_Model = new Order_Model();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable maxid = new DataTable();
        public FRM_Receipts()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            cmboStute.DisplayMember = "name";
            cmboStute.ValueMember = "id";
            datastuts = cmb.cmb_GetStates();
            cmboStute.DataSource = datastuts;
            cmboStute.SelectedIndex = -1;

           
            DataSet ds = new DataSet();
            dt = act.Getorder_general_lastdownload();
            DateTime date = Convert.ToDateTime(dt.Rows[0][0].ToString());
            ds = act.orderGetByDate(date);
            act.updateorder_general_lastdownload(DateTime.Now);
            act.Insertorder(ds);
            dt3 = act.Getorders();
            DGV.DataSource = dt3;
           
        }
        int tapindex = 1;
        public void taporder()
        {
            txtcustomername.TabIndex = tapindex++;
            txtphone.TabIndex = tapindex++; 
            txtnoItem.TabIndex = tapindex++;
            txtaddress.TabIndex = tapindex++;
            txtnote.TabIndex = tapindex++;
            txtamount.TabIndex = tapindex++;
            btnsave.TabIndex = tapindex++;
            txtcustomername.Focus();
        }
        public void afteraction()
        {
            txtcustomername.Text = "";
            txtphone.Text = "";
            txtnoItem.Text = "";
            txtaddress.Text = "";
            txtnote.Text = "";
            txtamount.Text = "";
            cmboStute.SelectedIndex = -1;
            tapcontrol.SelectedPage = radPageViewPage2;
            txtcustomername.Focus();
            loadcustomertable();
        }
        public void loadcustomertable()
        {
            dt4 = act.Getorder_general_customer(DGV.CurrentRow.Cells[10].Value.ToString());
            DGV2.DataSource = dt4;
            if (dt4.Rows.Count<Convert.ToInt32( DGV.CurrentRow.Cells[4].Value.ToString()))
            {
                tapcontrol.Enabled = true;
            }
            else tapcontrol.Enabled = false;
        }

        private void FRM_Receipts_Load(object sender, EventArgs e)
        {
            try
            {
                loaddata();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = "؟؟";
            txtCompany.Text= DGV.CurrentRow.Cells[1].Value.ToString();
            txtItemname.Text= DGV.CurrentRow.Cells[2].Value.ToString();
            txtItemPrice.Text= DGV.CurrentRow.Cells[3].Value.ToString();
            cmboStute.SelectedIndex= cmboStute.FindString(DGV.CurrentRow.Cells[6].Value.ToString());
            txtDeliveryprice.Text= DGV.CurrentRow.Cells[7].Value.ToString();
            cmbouser.DisplayMember = "username";
            cmbouser.ValueMember = "uuid";
            dateuser = cmb.cmb_GetUserid5(Convert.ToInt32(cmboStute.SelectedValue));
            cmbouser.DataSource = dateuser;
            cmbouser.SelectedIndex = 0;
            DGV2.DataSource = null;
            loadcustomertable();
            taporder();
            afteraction();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcustomername.Text.Length == 0 || txtphone.Text.Length == 0 || txtnoItem.Text.Length == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("..يرجى ملئ جميع الحقول المفعلة", "! خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtid.Text == "؟؟")
                    Order_Model.id = 0;
                else Order_Model.id = Convert.ToInt32(txtid.Text);
                Order_Model.uuid = act.Getuuid().Rows[0]["uuid"].ToString();
                Order_Model.customerName = txtcustomername.Text.Trim();
                Order_Model.customerPhone = txtphone.Text.Trim();
                Order_Model.address = txtaddress.Text.Trim();
                Order_Model.note = txtnote.Text.Trim();
                Order_Model.state = 0;
                Order_Model.order_general_deatils_uuid = DGV.CurrentRow.Cells[10].Value.ToString();
                Order_Model.noItem = Convert.ToDouble(txtnoItem.Text.Trim());
                Order_Model.amount = Convert.ToDouble(txtamount.Text.Trim());
                Order_Model.user = SystemInfo.id;
                Order_Model.date = DateTime.Now;
                Order_Model.useruuid = cmbouser.SelectedValue.ToString();
                int sumnoitem = 0;
                for (int i = 0; i < DGV2.Rows.Count; i++)
                {

                    sumnoitem += Convert.ToInt32(DGV2.Rows[i].Cells[7].Value.ToString());
                }
                if (txtid.Text == "؟؟")
                    if ((sumnoitem + Order_Model.noItem) > Convert.ToInt32(DGV.CurrentRow.Cells[5].Value.ToString()))
                        MessageBox.Show("عدد المواد اكبر من عدد مواد الوصل الكلي");
                    else
                    {
                        Order_Model.id = Convert.ToInt32(act.Insertorder_genral_customer(Order_Model).Rows[0][0].ToString());
                        act.orderCustomerInserUpdate(Order_Model);
                        afteraction();
                    }
                else if (((sumnoitem + Order_Model.noItem) - Convert.ToInt32(DGV2.CurrentRow.Cells[7].Value.ToString())) > Convert.ToInt32(DGV.CurrentRow.Cells[5].Value.ToString()))
                    MessageBox.Show("عدد المواد اكبر من عدد مواد الوصل الكلي");
                else
                {
                    Order_Model.id = Convert.ToInt32(act.Insertorder_genral_customer(Order_Model).Rows[0][0].ToString());
                    Order_Model.uuid = act.Insertorder_genral_customer(Order_Model).Rows[0][1].ToString();
                    act.orderCustomerInserUpdate(Order_Model);
                    afteraction();
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void txtnoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
        }

        private void txtnoItem_Leave(object sender, EventArgs e)
        {
            if (txtnoItem.Text.Length > 0)
            {
                double price = Convert.ToDouble(txtItemPrice.Text.Trim());
                double deliveryprice = Convert.ToDouble(txtDeliveryprice.Text.Trim());
                int noitem = Convert.ToInt32(txtnoItem.Text.Trim());
                double amount = (price + deliveryprice) * noitem;
                txtamount.Text = Convert.ToString(amount);
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text.Length < 11)
            {
                MessageBox.Show("يجب ادخال رقم هاتف صحيح");
                txtphone.Focus();
            }
        }

        private void DGV2_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = DGV2.CurrentRow.Cells[0].Value.ToString();
            txtCompany.Text=DGV.CurrentRow.Cells[1].Value.ToString();
            txtItemname.Text = DGV.CurrentRow.Cells[2].Value.ToString();
            txtItemPrice.Text = DGV.CurrentRow.Cells[3].Value.ToString();
            cmboStute.SelectedIndex = cmboStute.FindString(DGV.CurrentRow.Cells[6].Value.ToString());
            txtDeliveryprice.Text = DGV.CurrentRow.Cells[7].Value.ToString();
            txtcustomername.Text= DGV2.CurrentRow.Cells[1].Value.ToString();
            txtphone.Text = DGV2.CurrentRow.Cells[2].Value.ToString();
            txtnoItem.Text= DGV2.CurrentRow.Cells[7].Value.ToString();
            txtaddress.Text = DGV2.CurrentRow.Cells[4].Value.ToString();
            txtnote.Text = DGV2.CurrentRow.Cells[10].Value.ToString();
            txtamount.Text = DGV2.CurrentRow.Cells[9].Value.ToString();
            cmbouser.SelectedIndex = cmbouser.FindString(DGV2.CurrentRow.Cells[11].Value.ToString());
            tapcontrol.Enabled = true;
        }
    }
}
