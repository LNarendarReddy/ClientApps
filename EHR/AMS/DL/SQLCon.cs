using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CategisSecurity;
using log4net;

namespace DL
{
    public static class SQLCon
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static SqlConnection ObjCon = new SqlConnection();
        public static string  ServerName = Convert.ToString(ConfigurationManager.AppSettings["ServerName"]);
        public static string DBName = Convert.ToString(ConfigurationManager.AppSettings["DBName"]);
        public static string UserName = Convert.ToString(ConfigurationManager.AppSettings["username"]);
        public static string Password = Convert.ToString(ConfigurationManager.AppSettings["pwd"]);
        
        public static SqlConnection Sqlconn()
        {
            try
            {
                if (ObjCon.State == ConnectionState.Closed)
                    ObjCon = Security.Sqlconn(ServerName, DBName, UserName, Password);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            return ObjCon;
        }

    }
}
