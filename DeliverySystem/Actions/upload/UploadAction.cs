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
    class UploadAction
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataAccessLayer2 DAL2 = new DataAccessLayer2();
        //DAL.onLocal();
        //        MySqlParameter[] param = new MySqlParameter[1];

        //param[0] = new MySqlParameter("@idCar", int.Parse(idCar));

        //DataTable data = DAL.SelectData("Call CarDetailsByIdCar(@idCar);", param);
        public DataTable user_profileInsertUpdate(UserProfile_Model userProfile)
        {
            DataTable dt = new DataTable();
            DAL2.onOnLine();
            MySqlParameter[] param = new MySqlParameter[7];
            param[0] = new MySqlParameter("@id", userProfile.id);
            param[1] = new MySqlParameter("@username", userProfile.username);
            param[2] = new MySqlParameter("@password", userProfile.password);
            param[3] = new MySqlParameter("@roleUser", userProfile.roleUser);
            param[4] = new MySqlParameter("@stateUser", userProfile.stateUser);
            param[5] = new MySqlParameter("@dateValidate", userProfile.dateValidate);
            param[6] = new MySqlParameter("@uuid", userProfile.uuid);
            dt= DAL2.SelectData("CALL user_profileInsertUpdate( @id, @username,@password,@roleUser, @stateUser, @dateValidate, @uuid);",param);
            return dt;
        }
        public DataTable locationsInsertUpdate(State_Model state_Model)
        {
            DataTable dt = new DataTable();
            DAL2.onOnLine();
            MySqlParameter[] param = new MySqlParameter[4];
            param[0] = new MySqlParameter("@id", state_Model.id);
            param[1] = new MySqlParameter("@name", state_Model.name);
            param[2] = new MySqlParameter("@price", state_Model.price);
            param[3] = new MySqlParameter("@state", state_Model.state);
            dt = DAL2.SelectData("CALL locationsInsertUpdate( @id, @name,@price,@state );", param);
            return dt;
        }
        public DataTable GetUsersforupload()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("GetUsersforupload", null);
            DAL.Close();
            return dt;
        }
        public void UpdateUserSync(int id)
        {
            DAL.onLocal();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.ExcuteCommand("UpdateUserSync", param);
            DAL.Close();
        }
        public void UpdateStatesSync(int id)
        {
            DAL.onLocal();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.ExcuteCommand("UpdateStatesSync", param);
            DAL.Close();
        }
        public DataTable Getstatesforupload()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("Getstatesforupload", null);
            DAL.Close();
            return dt;
        }
    }
}
