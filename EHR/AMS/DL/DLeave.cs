using EL;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DLeave
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ELeave GetLeaveType(ELeave objELeave)
        {
            objELeave.dtLeaveType = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeaveType]";
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeaveType);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeavePlan(ELeave objELeave)
        {
            objELeave.dtLeavePlan = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeavePlan]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeavePlan);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Plan");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetFYear(ELeave objELeave)
        {
            objELeave.dtFYear = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_FYear]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtFYear);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Financial Years");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave SaveFYear(ELeave objELeave)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_FYear]";
                    cmd.Parameters.AddWithValue("@FYearID", objELeave.FYearID);
                    cmd.Parameters.AddWithValue("@Fromdate", objELeave.FromDate);
                    cmd.Parameters.AddWithValue("@ToDate", objELeave.ToDate);
                    cmd.Parameters.AddWithValue("@EnableAssessment", objELeave.EnableAssessment);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stWorkTypeTaskID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stWorkTypeTaskID, out ivalue))
                        {
                            objELeave.FYearID = ivalue;
                            if (ds.Tables.Count > 1)
                                objELeave.dtFYear = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Saving Financial Year");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeaveDetailsByType(ELeave objELeave)
        {
            objELeave.dtLeaveDetails = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_DeatailsByType]";
                    cmd.Parameters.AddWithValue("@LeaveTypeID", objELeave.LeaveTypeID);
                    cmd.Parameters.AddWithValue("@FYearID", objELeave.FYearID);
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeaveDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetEmployeeList(ELeave objELeave)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeListForLeaveApproval]";
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objELeave.dtEmployeeList = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave SaveCompOff(ELeave objELeave)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_CompLeave]";
                    cmd.Parameters.AddWithValue("@LeaveDate", objELeave.LeaveDate);
                    cmd.Parameters.AddWithValue("@LeaveReason", objELeave.LeaveReason);
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    cmd.Parameters.AddWithValue("@ApporvalLead", objELeave.ApporvalLead);
                    cmd.Parameters.AddWithValue("@LeaveDurationID", objELeave.LeaveDuration);
                    cmd.Parameters.AddWithValue("@CompensatoryLeaveID", objELeave.CompensatoryLeaveID);
                    object ObjReturn = cmd.ExecuteScalar();
                        int ivalue = 0;
                    string stWorkTypeTaskID = Convert.ToString(ObjReturn);
                    if (!int.TryParse(stWorkTypeTaskID, out ivalue))
                    {
                        throw new Exception(stWorkTypeTaskID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                if (ex.Message.Contains("Compensatory"))
                    throw ex;
                else
                    throw new Exception("Error While Saving Compansatory Leave");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }   
        public ELeave GetCompOff(ELeave objELeave)
        {
            objELeave.dsCompOff = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_CompOff]";
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dsCompOff);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Compansatory Leaves");

            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetCompOffForApproval(ELeave objELeave)
        {
            objELeave.dsCompOff = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_CompOffForApporval]";
                    cmd.Parameters.AddWithValue("@LeadID", objELeave.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dsCompOff);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Compansatory Leaves");

            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave ApproveCompOff(ELeave objELeave)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_ApproveCompOff]";
                    cmd.Parameters.AddWithValue("@CompensatoryLeaveApprovalID", objELeave.CompensatoryLeaveApprovalID);
                    cmd.Parameters.AddWithValue("@ApprovalStatus", objELeave.ApprovalStatus);
                    object ObjReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string stWorkTypeTaskID = Convert.ToString(ObjReturn);
                    if (!int.TryParse(stWorkTypeTaskID, out ivalue))
                    {
                        throw new Exception(stWorkTypeTaskID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Approving Compansatory Leave");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave SaveLeave(ELeave objELeave)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Leave]";
                    cmd.Parameters.AddWithValue("@EmployeeLeaveID", objELeave.EmployeeLeaveID);
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    cmd.Parameters.AddWithValue("@FYearID", objELeave.FYearID);
                    cmd.Parameters.AddWithValue("@leaveTypeID", objELeave.LeaveTypeID);
                    cmd.Parameters.AddWithValue("@FromDate", objELeave.FromDate);
                    cmd.Parameters.AddWithValue("@ToDate", objELeave.ToDate);
                    cmd.Parameters.AddWithValue("@LeaveCategory", objELeave.LeaveCategory);
                    cmd.Parameters.AddWithValue("@ReasonForLeave", objELeave. LeaveReason);
                    cmd.Parameters.AddWithValue("@IsDeliveryExists", objELeave.IsDeliveryExists);
                    cmd.Parameters.AddWithValue("@IsCompleted", objELeave.IsCompleted);
                    cmd.Parameters.AddWithValue("@ProjectPlan", objELeave.ProjectPlan);
                    cmd.Parameters.AddWithValue("@EmergencyContact", objELeave.EmergencyContact);
                    cmd.Parameters.AddWithValue("@ApprovalLead", objELeave.ApporvalLead);
                    cmd.Parameters.AddWithValue("@LeaveDuration", objELeave.LeaveDuration);
                    object ObjReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string stWorkTypeTaskID = Convert.ToString(ObjReturn);
                    if (!int.TryParse(stWorkTypeTaskID, out ivalue))
                    {
                        throw new Exception(stWorkTypeTaskID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                if (ex.Message.Contains("Date"))
                    throw ex;
                else if (ex.Message.Contains("Leave days cannot be"))
                    throw ex;
                else if (ex.Message.Contains("selected dates"))
                    throw ex;
                else
                    throw new Exception("Error While Saving Leave");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeaveHistory(ELeave objELeave)
        {
            try
            {
                objELeave.dsLeaveHostory = new DataSet();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeaveHistory]";
                    cmd.Parameters.AddWithValue("@FYearID", objELeave.FYearID);
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dsLeaveHostory);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave History");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeavesForApproval(ELeave objELeave)
        {
                objELeave.dsLeaveHostory = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeavesForApproval]";
                    cmd.Parameters.AddWithValue("@EmployeeID", objELeave.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dsLeaveHostory);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leaves");

            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave ApproveLeave(ELeave objELeave)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_ApproveLeave]";
                    cmd.Parameters.AddWithValue("@LeaveApprovalID", objELeave.LeaveApprovalID);
                    cmd.Parameters.AddWithValue("@Comments", objELeave.Comments);
                    cmd.Parameters.AddWithValue("@ApprovalStatus", objELeave.ApprovalStatus);
                    object ObjReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string stWorkTypeTaskID = Convert.ToString(ObjReturn);
                    if (!int.TryParse(stWorkTypeTaskID, out ivalue))
                    {
                        throw new Exception(stWorkTypeTaskID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Approving Leave");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeaveDuration(ELeave objELeave)
        {
            objELeave.dtLeaveDuration = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeaveDuration]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeaveDuration);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Duration");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeaveDetailsByID(ELeave objELeave)
        {
            objELeave.dtLeaves= new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeaveDetailsByID]";
                    cmd.Parameters.AddWithValue("@EmployeeLeaveID", objELeave.EmployeeLeaveID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeaves);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Details");

            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetCompOffDetailsByID(ELeave objELeave)
        {
            objELeave.dtCompOff = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_CompOffDetailsByID]";
                    cmd.Parameters.AddWithValue("@CompensatoryLeaveID", objELeave.CompensatoryLeaveID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtCompOff);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Details");

            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave CancelLeave(ELeave objELeave)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_LeaveCancelation]";
                    cmd.Parameters.AddWithValue("@EmployeeLeaveID", objELeave.EmployeeLeaveID);                   
                    object ObjReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string stWorkTypeTaskID = Convert.ToString(ObjReturn);
                    if (!int.TryParse(stWorkTypeTaskID, out ivalue))
                    {
                        throw new Exception(stWorkTypeTaskID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Canceling Leave");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave CancelCompOff(ELeave objELeave)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_CompOffCancelation]";
                    cmd.Parameters.AddWithValue("@CompensatoryLeaveID", objELeave.CompensatoryLeaveID);
                    object ObjReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string stWorkTypeTaskID = Convert.ToString(ObjReturn);
                    if (!int.TryParse(stWorkTypeTaskID, out ivalue))
                    {
                        throw new Exception(stWorkTypeTaskID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Canceling Compensatory Off");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeadDetails(ELeave objELeave)
        {
            objELeave.dtLeadDetails = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeadDetails]";
                    cmd.Parameters.AddWithValue("@EmployeeLeaveID", objELeave.EmployeeLeaveID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeadDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Lead Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeadDetailsCompOff(ELeave objELeave)
        {
            objELeave.dtLeadDetails = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeadDetailsForCompOffMail]";
                    cmd.Parameters.AddWithValue("@CompensatoryLeaveID", objELeave.CompensatoryLeaveID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeadDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Lead Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetEmployeeListForCompOffEdit(ELeave objELeave)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeList]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    objELeave.dtEmployeeList = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave ChangeCompoffStatus(ELeave objELeave)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_CompOffStatus]";
                    cmd.Parameters.AddWithValue("@CompensatoryLeaveID", objELeave.CompensatoryLeaveID);
                    cmd.Parameters.AddWithValue("@ChangeStatusComments", objELeave.ChangeStatusComments);
                    object ObjReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string stCompensatoryLeaveID = Convert.ToString(ObjReturn);
                    if (!int.TryParse(stCompensatoryLeaveID, out ivalue))
                        throw new Exception(stCompensatoryLeaveID);
                    else
                        objELeave.CompensatoryLeaveID = stCompensatoryLeaveID;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Changing Status");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetCompOffforLead(ELeave objELeave)
        {
            objELeave.dsCompOff = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_CompOffForLead]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dsCompOff);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Compansatory Leaves");

            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeaveHistoryForLEad(ELeave objELeave)
        {
            try
            {
                objELeave.dsLeaveHostory = new DataSet();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeaveHistoryForLead]";
                    cmd.Parameters.AddWithValue("@FYearID", objELeave.FYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dsLeaveHostory);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave History");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeaveBalance(ELeave objELeave)
        {
            try
            {
                objELeave.dtLeaveBalance = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_GetLeaveBalance]";
                    cmd.Parameters.AddWithValue("@FYearID", objELeave.FYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeaveBalance);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Balance");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetLeaveCalendar(ELeave objELeave)
        {
            try
            {
                objELeave.dtLeaveCalendar = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_LeaveCalendar]";
                    cmd.Parameters.AddWithValue("@SelectedMonth", objELeave.SelectedMonth);
                    cmd.Parameters.AddWithValue("@RoleID", objELeave.RoleID);
                    cmd.Parameters.AddWithValue("@UserID", objELeave.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeaveCalendar);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave calendar");
            }
            finally
            {                                   
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
        public ELeave GetYearlyReport(ELeave objELeave)
        {
            try
            {
                objELeave.dtLeaveBalance = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_LeaveReportYearly]";
                    cmd.Parameters.AddWithValue("@FYearID", objELeave.FYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objELeave.dtLeaveBalance);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leave Yearly Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objELeave;
        }
    }
}
