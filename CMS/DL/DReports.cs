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
     public class DReports
    {
        public ERpeorts GetDailyCollectionReport(ERpeorts ObjERpeorts)
        {
            DataSet dsDailyCollectionReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[CMS_Get_DailyCollectionReport]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjERpeorts.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null && dsDailyCollectionReport.Tables.Count > 0)
                        ObjERpeorts.dtDailyCollectionReport = dsDailyCollectionReport.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Daily Collection Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }

        public ERpeorts GetJumboPrintData(ERpeorts ObjERpeorts)
        {
            DataSet dsDailyCollectionReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[CMS_Get_AppointmentJumboPrint]";
                    cmd.Parameters.AddWithValue("@AppointmentDate", ObjERpeorts.AppointmentDate);
                    cmd.Parameters.AddWithValue("@From", ObjERpeorts.FromID);
                    cmd.Parameters.AddWithValue("@To", ObjERpeorts.ToID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null && dsDailyCollectionReport.Tables.Count > 0)
                        ObjERpeorts.dtDailyCollectionReport = dsDailyCollectionReport.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Jumbo Print Data");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }

        public ERpeorts GetNextVisitInfo(ERpeorts ObjERpeorts)
        {
            DataSet dsDailyCollectionReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[CMS_Get_NextVisitInfo]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjERpeorts.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null && dsDailyCollectionReport.Tables.Count > 0)
                        ObjERpeorts.dtDailyCollectionReport = dsDailyCollectionReport.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Next Visit Info");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }
    }
}
