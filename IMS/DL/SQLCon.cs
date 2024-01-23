using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public static class SQLCon
    {
        static SqlConnection ObjCon = new SqlConnection();
        public static SqlConnection Sqlconn()
        {
            if (ObjCon.State == ConnectionState.Open)
            {
                return ObjCon;
            }
            else
            {
                ObjCon.ConnectionString = ConfigurationManager.ConnectionStrings["IMS"].ToString();
                ObjCon.Open();
                return ObjCon;
            }
        }
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["IMS"].ToString();
        }
    }
}
