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
                    cmd.CommandText = "[HMS_Get_DailyCollectionReport]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null)
                        ObjERpeorts.dsDailyCollectionReport = dsDailyCollectionReport;
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

        public ERpeorts SaveDayClosure(ERpeorts ObjERpeorts)
        {
            DataSet dsDailyCollectionReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Ins_DayClosure]";
                    cmd.Parameters.Add("@UserID", ObjERpeorts.UserID);
                    cmd.Parameters.Add("@dtDenominations", ObjERpeorts.dtDenominations);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null)
                    {
                        if(dsDailyCollectionReport.Tables.Count == 1 && dsDailyCollectionReport.Tables[0].Rows.Count > 0)
                        {
                                throw new Exception("No Bills to close");
                        }
                        else
                            ObjERpeorts.dsDailyCollectionReport = dsDailyCollectionReport;
                    }                  
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("close"))
                    throw ex;
                else
                    throw new Exception("Error While Retrieving Day Closure Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }

        public ERpeorts GetDayClosure(ERpeorts ObjERpeorts)
        {
            DataSet dsDailyCollectionReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_Dayclosure]";
                    cmd.Parameters.Add("@DayCloseID", ObjERpeorts.DayCloseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null)
                        ObjERpeorts.dsDailyCollectionReport = dsDailyCollectionReport;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Day Closure Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }

        public ERpeorts GetDayClosureList(ERpeorts ObjERpeorts)
        {
            DataSet dsDailyCollectionReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_DayClosures]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null)
                        ObjERpeorts.dsDailyCollectionReport = dsDailyCollectionReport;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Day Closure List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }

        public ERpeorts GetAllVouchers(ERpeorts ObjERpeorts)
        {
            DataSet dsDailyCollectionReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_AllVouchers]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDailyCollectionReport);
                    }
                    if (dsDailyCollectionReport != null)
                        ObjERpeorts.dsDailyCollectionReport = dsDailyCollectionReport;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Vouchers");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjERpeorts;
        }
    }
}
