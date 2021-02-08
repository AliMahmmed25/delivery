using DeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseControlSystem.CONN;

namespace DeliverySystem.Actions
{
    class UserProfile_Actions
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public DataTable CheckUserNameAndPassword(UserProfile_Model userProfile)
        {
            DAL.onLocal();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar);
            param[0].Value = userProfile.username;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar);
            param[1].Value = userProfile.password;

            DataTable dt = DAL.SelectData("CheckUserNameAndPassword", param);
            DAL.Close();
            return dt;
        }
        public DataTable InsertUser(UserProfile_Model userProfile)
        {
            DAL.onLocal();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = userProfile.id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[1].Value = userProfile.username;

            param[2] = new SqlParameter("@password", SqlDbType.NVarChar);
            param[2].Value = userProfile.password;

            param[3] = new SqlParameter("@roleuser", SqlDbType.Int);
            param[3].Value = userProfile.roleUser;

            param[4] = new SqlParameter("@stateUser", SqlDbType.Int);
            param[4].Value = userProfile.stateUser;

            param[5] = new SqlParameter("@dateValidate", SqlDbType.DateTime);
            param[5].Value = userProfile.dateValidate;

            param[6] = new SqlParameter("@user", SqlDbType.Int);
            param[6].Value = userProfile.user;

            param[7] = new SqlParameter("@date", SqlDbType.DateTime);
            param[7].Value = userProfile.date;

            param[8] = new SqlParameter("@state", SqlDbType.Int);
            param[8].Value = userProfile.state;
            DataTable dt = DAL.SelectData("InsertUser", param);
            DAL.Close();
            return dt;
        }
        public DataTable UserProfileCheckNameDoublicate(string UserProfileName)
        {
            DAL.onLocal();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@username", SqlDbType.NVarChar);
            param[0].Value = UserProfileName;

            DataTable DT = DAL.SelectData("UserProfileCheckNameDoublicate", param);
            DAL.Close();
            return DT;

        }

        public DataTable InsertUserRole(UserRole_Model userRole)
        {
            DAL.onLocal();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[0].Value = userRole.name;

            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = userRole.id;

            param[2] = new SqlParameter("@user", SqlDbType.Int);
            param[2].Value = userRole.userid;

            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = userRole.Date;
            DataTable dt = DAL.SelectData("InsertUserRole", param);
            DAL.Close();
            return dt;
        }
        public DataTable GetUsers()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("GetUsers", null);
            DAL.Close();
            return dt;
        }
    }
}
