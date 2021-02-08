using DeliverySystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseControlSystem.CONN;

namespace DeliverySystem.Actions.upload
{
    class DownloadActions
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataAccessLayer2 DAL2 = new DataAccessLayer2();
        public void orderCustomerInserUpdate(Order_Model order_Model)
        {
            DAL2.onOnLine();
            MySqlParameter[] param = new MySqlParameter[11];
            param[0] = new MySqlParameter("@id", order_Model.id);
            param[1] = new MySqlParameter("@uuid", order_Model.uuid);
            param[2] = new MySqlParameter("@customerName", order_Model.customerName);
            param[3] = new MySqlParameter("@customerPhone", order_Model.customerPhone);
            param[4] = new MySqlParameter("@address", order_Model.address);
            param[5] = new MySqlParameter("@note", order_Model.note);
            param[6] = new MySqlParameter("@order_general_deatils_uuid", order_Model.order_general_deatils_uuid);
            param[7] = new MySqlParameter("@amount", order_Model.amount);
            param[8] = new MySqlParameter("@uuidUser", order_Model.useruuid);
            param[9] = new MySqlParameter("@dateCreated", order_Model.date);
            param[10] = new MySqlParameter("@state", order_Model.state);
            DAL2.ExcuCommane("CALL orderCustomerInserUpdate( @id, @uuid,@customerName,@customerPhone, @address, @note, @order_general_deatils_uuid,@amount,@uuidUser,@dateCreated,@state);", param);
            
        }
        public DataSet orderGetByDate(DateTime date)
        {
            DataSet dt = new DataSet();
            DAL2.onOnLine();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@date", date);
            dt = DAL2.SelectDataOnline("CALL orderGetByDate( @date);", param);
            return dt;
        }
        public DataTable Getorder_general_lastdownload()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("Getorder_general_lastdownload", null);
            DAL.Close();
            return dt;
        }
        public DataTable Getuuid()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("Getuuid", null);
            DAL.Close();
            return dt;
        }
        public DataTable Getorders()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("Getorders", null);
            DAL.Close();
            return dt;
        }
        public DataTable Getorder_general_customer(string uuid)
        {
            DAL.onLocal();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@uuid", SqlDbType.VarChar);
            param[0].Value = uuid;
            DataTable dt = DAL.SelectData("Getorder_general_customer", param);
            DAL.Close();
            return dt;
        }
        public void Insertorder(DataSet ds)
        {
            DAL.onLocal();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@order_insert", SqlDbType.Structured);
            param[0].Value = ds.Tables[0];

            param[1] = new SqlParameter("@order_general", SqlDbType.Structured);
            param[1].Value = ds.Tables[1];

            DAL.ExcuteCommand("Insertorder", param);
            DAL.Close();
        }
        public void updateorder_general_lastdownload(DateTime ds)
        {
            DAL.onLocal();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = ds;

            DAL.ExcuteCommand("updateorder_general_lastdownload", param);
            DAL.Close();
        }
        public DataTable Insertorder_genral_customer(Order_Model model)
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = model.id;

            param[1] = new SqlParameter("@uuid", SqlDbType.VarChar);
            param[1].Value = model.uuid;

            param[2] = new SqlParameter("@customerName", SqlDbType.NVarChar);
            param[2].Value = model.customerName;

            param[3] = new SqlParameter("@customerPhone", SqlDbType.NVarChar);
            param[3].Value = model.customerPhone;

            param[4] = new SqlParameter("@address", SqlDbType.NVarChar);
            param[4].Value = model.address;

            param[5] = new SqlParameter("@note", SqlDbType.NVarChar);
            param[5].Value = model.note;

            param[6] = new SqlParameter("@state", SqlDbType.Int);
            param[6].Value = model.state;

            param[7] = new SqlParameter("@order_general_deatils_uuid", SqlDbType.VarChar);
            param[7].Value = model.order_general_deatils_uuid;

            param[8] = new SqlParameter("@noItem", SqlDbType.Float);
            param[8].Value = model.noItem;

            param[9] = new SqlParameter("@amount", SqlDbType.Float);
            param[9].Value = model.amount;

            param[10] = new SqlParameter("@date", SqlDbType.DateTime);
            param[10].Value = model.date;

            param[11] = new SqlParameter("@user", SqlDbType.Int);
            param[11].Value = model.user;

            param[12] = new SqlParameter("@useruuid", SqlDbType.VarChar);
            param[12].Value = model.useruuid;

            dt=DAL.SelectData("Insertorder_genral_customer", param);
            DAL.Close();
            return dt;
        }
    }
}
