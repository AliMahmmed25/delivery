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
    class StateActions
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public DataTable InsertState(State_Model state_Model)
        {
            DAL.onLocal();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[0].Value = state_Model.name;

            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = state_Model.id;

            param[2] = new SqlParameter("@price", SqlDbType.Float);
            param[2].Value = state_Model.price;

            param[3] = new SqlParameter("@state", SqlDbType.Int);
            param[3].Value = state_Model.state;

            param[4] = new SqlParameter("@user", SqlDbType.Int);
            param[4].Value = state_Model.userid;

            param[5] = new SqlParameter("@date", SqlDbType.DateTime);
            param[5].Value = state_Model.Date;
            DataTable dt = DAL.SelectData("InsertState", param);
            DAL.Close();
            return dt;
        }
    }
}
