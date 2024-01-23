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
        public EReports GetDailyCollection(EReports ObjEReports)
        {
            DataSet dsBranch = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_DailyCollection]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEReports.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBranch);
                    }
                    if (dsBranch != null && dsBranch.Tables.Count > 0)
                        ObjEReports.dtDailCollection = dsBranch.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Daily Collection", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEReports;
        }

        public EReports GetStudentReport(EReports ObjEReports)
        {
            DataSet dsBranch = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_StudentReport]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEReports.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBranch);
                    }
                    if (dsBranch != null && dsBranch.Tables.Count > 0)
                        ObjEReports.dtStudentReport = dsBranch.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Student Report", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEReports;
        }

        public EReports GetDueReport(EReports ObjEReports)
        {
            DataSet dsBranch = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_DueReport]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEReports.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBranch);
                    }
                    if (dsBranch != null && dsBranch.Tables.Count > 0)
                        ObjEReports.dtDueReport = dsBranch.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Due Report", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEReports;
        }

        public EReports GetExpenses(EReports ObjEReports)
        {
            DataSet dsBranch = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Expeses]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEReports.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBranch);
                    }
                    if (dsBranch != null && dsBranch.Tables.Count > 0)
                        ObjEReports.dtExpenses = dsBranch.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Expenses", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEReports;
        }

        public EReports GetEnquiryReport(EReports ObjEReports)
        {
            DataSet dsBranch = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_get_studentenquiry]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEReports.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBranch);
                    }
                    if (dsBranch != null && dsBranch.Tables.Count > 0)
                        ObjEReports.dtEnquiry = dsBranch.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Enquiry List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEReports;
        }

        public EReports GetDailyCollectionForMessage(EReports ObjEReports)
        {
            DataSet dsDCR = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_DailyCollectionForMessage]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEReports.BranchID);
                    cmd.Parameters.AddWithValue("@CollectionDate", ObjEReports.ColelctionDAte);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDCR);
                    }
                    if (dsDCR != null && dsDCR.Tables.Count > 0)
                        ObjEReports.dtDCR = dsDCR.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving DCR", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEReports;
        }
    }
}
