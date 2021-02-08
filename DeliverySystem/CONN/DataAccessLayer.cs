using System;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseControlSystem.CONN
{
    class DataAccessLayer
    {
        string Connection = "Server =.;Database=DeliverySystem;Integrated Security=True; Connection Timeout = 120;";
        SqlConnection sqlconnection;

        public void onOnLine()
        {
           //Connection = "Server =.;Database=WarehouseControlServer;Integrated Security=True";
        }
        public void onLocal()
        {
            Connection = "Server =.;Database=DeliverySystem;Integrated Security=True; Connection Timeout =120;";
        }

        public void Open()
        {
            sqlconnection = new SqlConnection(Connection);
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Read Data From SQL DB
        public DataTable SelectData(string stored_procedur, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedur;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataSet SelectDataOnline(string stored_procedur, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedur;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //Insert,Update,Delete into SQL DB
        public void ExcuteCommand(string stored_procedur, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedur;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
