﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QuoteMaker.Models;
using QuoteMaker.Repository;
using QuoteMaker.UI.Reports;

namespace QuoteMaker
{
    public static class Utility
    {
        private static DataTable dtGST;
        private static DataTable dtItemSKUList;
        private static DataTable dtItemCodeList;
        private static DataTable dtItemCodeFiltered;
        private static List<GSTInfo> gstInfoList;

        public static int UserID = 4;
        public static string UserName = string.Empty;
        public static string Password = string.Empty;
        public static string FullName = string.Empty;
        public static string Role = string.Empty;
        public static int RoleID = 0;
        public static string Email = string.Empty;
        public static string RegKey = @"Software\QuoteMaker";
        public static string AppVersion = "1.0.0";
        public static string VersionDate = "(17-06-2023)";

        public static void Setfocus(GridView view, string ColumnName, object Value)
        {
            try
            {
                int rowHandle = view.LocateByValue(ColumnName, Value);
                if (rowHandle != GridControl.InvalidRowHandle)
                    view.FocusedRowHandle = rowHandle;
            }
            catch (Exception ex) { }
        }
        private static byte[] Encrypt(byte[] input)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("NSoftSol", new byte[] { 0x43, 0x87, 0x23, 0x72, 0x45, 0x56, 0x68, 0x14, 0x62, 0x84 });
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
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
        public static string Encrypt(string input)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input)));
        }
        public static string Decrypt(string input)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
        }
        private static void FillItemBaseline()
        {
            DataSet dsItemBaseline = new RepositoryBase().GetDataset("USP_R_ITEMCODES");
            dtItemSKUList = dsItemBaseline.Tables[0];
            dtItemCodeList = dsItemBaseline.Tables[1];
        }

        private static void FillGSTBaseLine()
        {
            dtGST = new RepositoryBase().GetDataTable("USP_R_GST");
            gstInfoList = new List<GSTInfo>();
            foreach (DataRow dr in dtGST.Rows)
            {
                GSTInfo gstInfo = new GSTInfo();
                gstInfo.UpdateGST(dr);
                gstInfoList.Add(gstInfo);
            }
        }

        public static DataTable GetGSTBaseline()
        {
            if (dtGST == null)
            {
                FillGSTBaseLine();
            }

            return dtGST;
        }

        public static DataTable GetItemSKUList()
        {
            if (dtItemSKUList == null)
            {
                FillItemBaseline();
            }

            return dtItemSKUList;
        }
        public static DataTable GetItemCodeList()
        {
            if (dtItemCodeList == null)
            {
                FillItemBaseline();
            }
            return dtItemCodeList;
        }

        public static IEnumerable<GSTInfo> GetGSTInfoList()
        {
            if (dtGST == null)
            {
                FillGSTBaseLine();
            }

            return gstInfoList;
        }

        public static void FillBaseLine()
        {
            FillItemBaseline();
            GetGSTBaseline();
        }

        public static void PrintBarCode(object ItemCode, object ItemName,
            string SalePrice, object oQuantity, object MRP, object CategoryID)
        {
            try
            {
                int Quantity = 0;
                if (int.TryParse(Convert.ToString(oQuantity), out Quantity))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ItemCode", typeof(string));
                    dt.Columns.Add("ItemName", typeof(string));
                    dt.Columns.Add("SalePrice", typeof(string));
                    dt.Columns.Add("MRP", typeof(string));
                    DataRow dr = null;
                    for (int i = 0; i < Quantity; i++)
                    {
                        dr = dt.NewRow();
                        dr["ItemCode"] = ItemCode;
                        dr["ItemName"] = ItemName;
                        dr["SalePrice"] = SalePrice;
                        dr["MRP"] = MRP;
                        dt.Rows.Add(dr);
                    }
                    rptBarcode rpt = new rptBarcode();
                    rpt.DataSource = dt;
                    rpt.ShowPrintMarginsWarning = false;
                    rpt.Parameters["BatchNumber"].Value = "";
                    rpt.Parameters["PackedDate"].Value = DateTime.Now.ToString("MM/yyyy");
                    rpt.Parameters["CategoryID"].Value = CategoryID;
                    rpt.CreateDocument();
                    ReportPrintTool printTool = new ReportPrintTool(rpt);
                    printTool.Print();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<int> LocateAllRowsByValue(this GridView view, string fieldName, object value)
        {
            List<int> list = new List<int>();
            int rowHandle = view.LocateByValue(fieldName, value);
            while (rowHandle != GridControl.InvalidRowHandle)
            {
                list.Add(rowHandle);
                rowHandle = view.LocateByValue(rowHandle + 1, view.Columns[fieldName], value);
            }
            return list;
        }

        public static DataTable ImportExcelXLS(string FilePath, bool hasHeaders = true)
        {
            DataTable dt = new DataTable();
            try
            {
                string HDR = hasHeaders ? "Yes" : "No";
                string strConn;
                if (FilePath.Substring(FilePath.LastIndexOf('.')).ToLower() == ".xlsx")
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FilePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
                else
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";

                DataSet output = new DataSet();
                using (OleDbConnection conn = new OleDbConnection(strConn))
                {
                    conn.Open();
                    DataTable schemaTable = conn.GetOleDbSchemaTable(
                        OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                    foreach (DataRow schemaRow in schemaTable.Rows)
                    {
                        string sheet = schemaRow["TABLE_NAME"].ToString();

                        if (!sheet.EndsWith("_"))
                        {
                            try
                            {
                                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                                cmd.CommandType = CommandType.Text;

                                DataTable outputTable = new DataTable(sheet);
                                output.Tables.Add(outputTable);
                                new OleDbDataAdapter(cmd).Fill(outputTable);
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message + string.Format("Sheet:{0}.File:F{1}", sheet, FilePath), ex);
                            }
                        }
                    }
                }
                if (output != null && output.Tables.Count > 0)
                    dt = output.Tables[0].Copy();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
