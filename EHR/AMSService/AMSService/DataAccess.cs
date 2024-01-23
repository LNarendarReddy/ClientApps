using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSService
{
    public static class DataAccess
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void UpdateLeaveStatus()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_UpdateLeaveStatus]";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
        }
        public static DataSet UpdateCompOffStatus()
        {
            DataSet dt = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_CompOffStatus]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dt;
        }
        public static DataSet GetMissedTaskEntry()
        {
            DataSet dt = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_GetMissedTaskEntry]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dt;
        }
        public static DataSet GetMissedTimesheet()
        {
            DataSet dt = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_GetMissedTimesheet]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dt;
        }
        public static DataSet GetMissedcompoff()
        {
            DataSet dt = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_GetMissedCompOff]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dt;
        }
        public static DataSet GetLeaveBalance()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_GetLeaveBalance]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ds;
        }
        public static DataTable UpdateCFLeaves()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_CFLeaves]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dt;
        }
        public static void GetServiceConfig()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Job_GetServiceConfiguration]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        Utility.timeString = Convert.ToString(dt.Rows[0][0]);
                        Utility.stMailIDs = Convert.ToString(dt.Rows[1][0]);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
        }
    }
}
