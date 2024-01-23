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

namespace DL
{
    public static class SQLCon
    {
        static SqlConnection ObjCon = new SqlConnection();
        public static string  ServerName = Decrypt(ConfigurationManager.AppSettings["ServerName"].ToString());
        public static string DBName = Decrypt(ConfigurationManager.AppSettings["DBName"].ToString());
        public static string UserName = Decrypt(ConfigurationManager.AppSettings["username"].ToString());
        public static string Password = Decrypt(ConfigurationManager.AppSettings["pwd"].ToString());
        public static string pwed = Decrypt("2g09x3Vdha65WRmX+VQ49w==");
        
        public static SqlConnection Sqlconn()
        {
            if (ObjCon.State == ConnectionState.Open)
            {
                return ObjCon;
            }
            else
            {
                string temp = pwed;
                string str = "Data Source = " + ServerName + "; Initial Catalog = "+ DBName + "; User Id = "+ UserName + "; Password = "+ Password +"; Pooling = True; Connect Timeout = 1024; Max Pool Size = 200";
                ObjCon.ConnectionString = str;
                ObjCon.Open();
                return ObjCon;
            }
        }

        public static string Decrypt(string input)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
        }

        private static byte[] Decrypt(byte[] input)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("CategisOTTO", new byte[] { 0x43, 0x87, 0x23, 0x72, 0x45, 0x56, 0x68, 0x14, 0x62, 0x84 });
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
        }

    }
}
