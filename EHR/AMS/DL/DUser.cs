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
    public class DUser
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public EUser GetUser(EUser objEUser)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_UserInfo]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        objEUser.dtUser = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving User List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEUser;
        }

        public List<RoleModel> GetRole()
        {
            List<RoleModel> l = new List<RoleModel>();
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Role]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    l = (from DataRow row in dt.Rows

                         select new RoleModel
                         {
                             RoleID = row["RoleID"],
                             RoleName = row["RoleName"]
                         }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Role List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return l;
        }

        public List<DesignationModel> GetDesignation()
        {
            List<DesignationModel> l = new List<DesignationModel>();
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Designation]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    l = (from DataRow row in dt.Rows

                         select new DesignationModel
                         {
                             DesignationID = row["DesignationID"],
                             DesignationName = row["DesignationName"]
                         }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Designation List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return l;
        }

        public List<ReportingLeadModel> GetReportingLead()
        {
            List<ReportingLeadModel> l = new List<ReportingLeadModel>();
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ReportingLeads]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    l = (from DataRow row in dt.Rows

                         select new ReportingLeadModel
                         {
                             ReportingLeadID = row["ReportingLeadID"],
                             ReportingLead = row["ReportingLead"]
                         }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Reporting Lead List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return l;
        }

        public EmployeeModel GetUserDetails(int Id = 0)
        {
            EmployeeModel e = new EmployeeModel();
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_UserDetails]";
                    cmd.Parameters.AddWithValue("@UserinfoId", Id);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        e.UserInfoID = Convert.ToInt32(dt.Rows[0]["UserInfoID"]);
                        e.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                        e.Passwordstring = Convert.ToString(dt.Rows[0]["Passwordstring"]);
                        e.FullName = Convert.ToString(dt.Rows[0]["FullName"]);
                        e.CNumber = Convert.ToString(dt.Rows[0]["CNumber"]);
                        e.EMail = Convert.ToString(dt.Rows[0]["EMail"]);
                        e.RoleID = Convert.ToInt32(dt.Rows[0]["RoleID"]);
                        e.DesignationID = Convert.ToInt32(dt.Rows[0]["DesignationID"]);
                        e.ReportingLeadID = Convert.ToInt32(dt.Rows[0]["ReportingLeadID"]);
                        e.RoleName = Convert.ToString(dt.Rows[0]["RoleName"]);
                        e.DesignationName = Convert.ToString(dt.Rows[0]["DesignationName"]);
                        e.ReportingLead = Convert.ToString(dt.Rows[0]["ReportingLead"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving User Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return e;
        }

        public EUser SaveUser(EUser objEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_UserInfo]";
                    cmd.Parameters.AddWithValue("@UserInfoID", objEUser.UserInfoID);
                    cmd.Parameters.AddWithValue("@UserName", objEUser.UserName);
                    cmd.Parameters.AddWithValue("@Passwordstring", objEUser.Password);
                    cmd.Parameters.AddWithValue("@FullName", objEUser.FullName);
                    cmd.Parameters.AddWithValue("@CNumber", objEUser.CNumber);
                    cmd.Parameters.AddWithValue("@EMail", objEUser.Email);
                    cmd.Parameters.AddWithValue("@RoleID", objEUser.RoleID);
                    cmd.Parameters.AddWithValue("@DesignationID", objEUser.DesignationID);
                    cmd.Parameters.AddWithValue("@ReportingLeadID", objEUser.ReportingLeadID);
                    cmd.Parameters.AddWithValue("@Gender", objEUser.gender);
                    cmd.Parameters.AddWithValue("@JoiningDate", objEUser.JoiningDate);
                    cmd.Parameters.AddWithValue("@DOB", objEUser.DOB);
                    cmd.Parameters.AddWithValue("@DepartmentID", objEUser.DepartmentID);
                    cmd.Parameters.AddWithValue("@EmployeeStatus", objEUser.EmployeeStatus);
                    cmd.Parameters.AddWithValue("@EnableAssessment", objEUser.EnableAssessment);
                    cmd.Parameters.AddWithValue("@ResignationDate", objEUser.ResignationDate);
                    cmd.Parameters.AddWithValue("@ProjectedLastWorkingDate", objEUser.ProjectedLastWorkingDate);
                    cmd.Parameters.AddWithValue("@ActaulLastWorkingDate", objEUser.ActualLastWorkingDate);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsUser.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            objEUser.UserInfoID = IValue;
                            objEUser.dtUser = dsUser.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                if (ex.Message.Contains("UC_UName"))
                    throw new Exception("User Already Exists!!");
                else
                    throw new Exception("Error While Saving User!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEUser;
        }

        public EmployeeModel DeleteEmployee(EmployeeModel ObjEmployeeModel)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Del_UserInfo]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEmployeeModel.UserInfoID);
                    object objReturn = cmd.ExecuteScalar();
                    int IValue = 0;
                    string str = Convert.ToString(objReturn);
                    if (int.TryParse(str, out IValue))
                    {
                        ObjEmployeeModel.UserInfoID = IValue;
                    }
                    else
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_UName"))
                    throw new Exception("User Already Exists!!");
                else
                    throw new Exception("Error While Saving User!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEmployeeModel;
        }

        public EUser GetRolesandDesignations(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_RoleandDesignations]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0)
                    {
                        ObjEUser.dtRoles = dsUser.Tables[0];
                        if (dsUser != null && dsUser.Tables.Count > 1)
                        {
                            ObjEUser.dtDesignations = dsUser.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Roles and Designations List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser GetUserCredentials(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_UserCredentials1]";
                    cmd.Parameters.AddWithValue("@UserName", ObjEUser.UserName);
                    cmd.Parameters.AddWithValue("@Password", ObjEUser.Password);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0 &&
                        dsUser.Tables[0].Rows.Count > 0)
                    {
                        int Ivalue = 0;
                        string str = Convert.ToString(dsUser.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out Ivalue))
                        {
                            ObjEUser.dtUserDetails = dsUser.Tables[0];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex){
                Log.Error(ex.Message, ex); throw ex;}
            finally{SQLCon.Sqlconn().Close();}
            return ObjEUser;
        }

        public EUser ChangePassword(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_Password]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEUser.UserInfoID);
                    cmd.Parameters.AddWithValue("@Password", ObjEUser.Password);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0 &&
                        dsUser.Tables[0].Rows.Count > 0)
                    {
                        int Ivalue = 0;
                        string str = Convert.ToString(dsUser.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out Ivalue))
                        {
                            ObjEUser.dtUserDetails = dsUser.Tables[0];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex) {
                Log.Error(ex.Message, ex); throw ex; }
            finally { SQLCon.Sqlconn().Close(); }
            return ObjEUser;
        }

        public EUser GetUserDetailsByID(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeDetialsByID]";
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEUser.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0)
                        ObjEUser.dtUser = dsUser.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving User List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser GetDBVersion(EUser ObjEUser)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Check_DBVersion]";
                    object objReturn = cmd.ExecuteScalar();
                    ObjEUser.DBVersion = Convert.ToString(objReturn);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retreiving DB Version");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser GetLookupValues(EUser ObjEUser)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LookupValues]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        ObjEUser.ReminderDays = dt.Rows[0][1];
                        ObjEUser.CompExpiryDays = dt.Rows[1][1];
                        ObjEUser.JobRunTime = dt.Rows[2][1];
                        ObjEUser.LeavBalanceMailday = dt.Rows[3][1];
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retreiving Lookup Values");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }
        public EUser UpdateLookupValues(EUser ObjEUser)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReminderDays", ObjEUser.ReminderDays);
                    cmd.Parameters.AddWithValue("@CompExpiryDays", ObjEUser.CompExpiryDays);
                    cmd.Parameters.AddWithValue("@JobRunTime", ObjEUser.JobRunTime);
                    cmd.Parameters.AddWithValue("@LeavBalanceMailday", ObjEUser.LeavBalanceMailday);
                    cmd.CommandText = "[AMS_Upd_LookupValues]";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Updating Lookup Values");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }
    }
}
