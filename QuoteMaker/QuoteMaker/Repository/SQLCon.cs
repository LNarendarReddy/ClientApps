﻿using DevExpress.Accessibility;
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

namespace QuoteMaker.Repository
{
    internal class SQLCon
    {
        static SqlConnection ObjCon = new SqlConnection();
        
        public static SqlConnection Sqlconn()
        {
            try
            {
                if (ObjCon?.State == ConnectionState.Open)
                {
                    return ObjCon;
                }
                else

                {
                    string ServerName = Decrypt(ConfigurationManager.AppSettings[$"ServerName"].ToString());
                    string DBName = Decrypt(ConfigurationManager.AppSettings[$"DBName"].ToString());
                    string UserName = Decrypt(ConfigurationManager.AppSettings[$"username"].ToString());
                    string Password = Decrypt(ConfigurationManager.AppSettings[$"pwd"].ToString());

                    ObjCon = new SqlConnection();
                    string str = "Data Source = " + ServerName + "; Initial Catalog = " + DBName + "; User Id = " + UserName + "; Password = " + Password + "; Pooling = True; Connect Timeout = 1024; Max Pool Size = 2000";
                    ObjCon.ConnectionString = str;
                    ObjCon.Open();
                }
            }
            catch (Exception ex) { throw ex; }
            return ObjCon;
        }

        public static string Decrypt(string input)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
        }

        private static byte[] Decrypt(byte[] input)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("NSoftSol", new byte[] { 0x43, 0x87, 0x23, 0x72, 0x45, 0x56, 0x68, 0x14, 0x62, 0x84 });
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
