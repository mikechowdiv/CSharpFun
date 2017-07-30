using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                string connStr = ConfigurationManager.ConnectionStrings["AWConnection"].ToString();

                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);
                sb.ApplicationName = ApplicationName ?? sb.ApplicationName;
                sb.ConnectTimeout = (ConnectionTimeout > 0 ) ? ConnectionTimeout : sb.ConnectTimeout;

                return sb.ToString();
            }
        }

        //returns an opened connection to the caller
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }


        //overrides the connection timeout
        public static int ConnectionTimeout { get; set; }

        //property used to override the name of the application
        public static string ApplicationName
        {
            get;set;
        }
    }
}
