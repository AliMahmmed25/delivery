using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseControlSystem.CONN
{
    class DataAccessLayer2
    {
        public string ConnectionString;

        public void onOnLine()
        {
            ConnectionString = "server=MYSQL5044.site4now.net;Port=3306;CharSet=utf8;database=db_a6e9ba_deliver;uid=a6e9ba_deliver;pwd=ro34ot12;Connect Timeout=30;command timeout=120;";
        }
       

        public void ExcuCommane(String storedProcture, MySqlParameter[] param)
        {
            if (param != null)
            {
                MySqlHelper.ExecuteNonQuery(ConnectionString, storedProcture, param);
            }
            else
            {
                MySqlHelper.ExecuteNonQuery(ConnectionString, storedProcture);
            }
        }

        public DataTable SelectData(String storedProcture, MySqlParameter[] param)
        {
            MySqlDataReader reader;
            if (param != null)
            {
                reader = MySqlHelper.ExecuteReader(ConnectionString, storedProcture, param);
            }
            else
            {
                reader = MySqlHelper.ExecuteReader(ConnectionString, storedProcture);
            }
            DataTable dt = new DataTable();
            dt.Load(reader);
            return dt;
        }
        
        public DataSet SelectDataOnline(string storedProcture, MySqlParameter[] param)
        {
            DataSet ds;
            if (param != null)
            {
                ds = MySqlHelper.ExecuteDataset(ConnectionString, storedProcture, param);
            }
            else
            {
                ds = MySqlHelper.ExecuteDataset(ConnectionString, storedProcture);
            }
            return ds;
        }
    }
}
