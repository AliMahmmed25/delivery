using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseControlSystem.CONN;

namespace DeliverySystem.Actions.Genral
{
    class cmb_Actions
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public DataTable GetUserRole()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("cmb_GetUserRole", null);
            DAL.Close();
            return dt;
        }
        public DataTable cmb_GetStates()
        {
            DAL.onLocal();
            DAL.Open();
            DataTable dt = DAL.SelectData("cmb_GetStates", null);
            DAL.Close();
            return dt;
        }
        public DataTable cmb_GetUserid5(int stateid)
        {
            DAL.onLocal();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@stateid", SqlDbType.Int);
            param[0].Value = stateid;
            DataTable dt = DAL.SelectData("cmb_GetUserid5", param);
            DAL.Close();
            return dt;
        }
    }
}
