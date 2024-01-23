using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DPrinter
    {
        public EPrinter SavePrinter(EPrinter ObjEPrinter)
        {
            DataSet dsPrinterSettings = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[CMS_Ins_PrinterSettings]";
                    cmd.Parameters.Add("@PrinterSettingsID", ObjEPrinter.PrinterSettingsID);
                    cmd.Parameters.Add("@PrinterID", ObjEPrinter.PrinterID);
                    cmd.Parameters.Add("@UserID", ObjEPrinter.UserID);
                    cmd.Parameters.Add("@PrinterType", ObjEPrinter.PrinterType);
                    cmd.Parameters.Add("@PrinterName", ObjEPrinter.PrinterName);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPrinterSettings);
                    }
                    if (dsPrinterSettings != null && dsPrinterSettings.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsPrinterSettings.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEPrinter.PrinterSettingsID = IValue;
                            if (dsPrinterSettings.Tables.Count > 1)
                                ObjEPrinter.dtPrinters = dsPrinterSettings.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while saving printer settings ");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPrinter;
        }

        public EPrinter GetPrinterType(EPrinter ObjEPrinter)
        {
            DataSet dsPrinterType = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[CMS_Get_PrinterType]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPrinterType);
                    }
                    ObjEPrinter.dtPrinterType = dsPrinterType.Tables[0];
                }
            }
            catch (Exception ex){throw ex;}
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPrinter;
        }

        public EPrinter GetPrinters(EPrinter ObjEPrinter)
        {
            DataSet dsPrinters = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[CMS_Get_PrinterSettings]";
                    cmd.Parameters.Add("@UserID", ObjEPrinter.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPrinters);
                    }
                    ObjEPrinter.dtPrinters = dsPrinters.Tables[0];
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPrinter;
        }
    }
}
