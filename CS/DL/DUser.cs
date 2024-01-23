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
    public class DUser
    {

        public List<EmployeeModel> GetUser()
        {
            List<EmployeeModel> l = new List<EmployeeModel>();
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
                    }
                    l = (from DataRow row in dt.Rows

                           select new EmployeeModel
                           {
                               UserInfoID = Convert.ToInt32(row["UserInfoID"]),
                               OrgID = 1,
                               BranchID = 1,
                               UserName = Convert.ToString(row["UserName"]),
                               Passwordstring = Convert.ToString(row["Passwordstring"]),
                               FullName = Convert.ToString(row["FullName"]),
                               CNumber = Convert.ToString(row["CNumber"]),
                               EMail = Convert.ToString(row["EMail"]),
                               RoleID = Convert.ToInt32(row["RoleID"]),
                               DesignationID = Convert.ToInt32(row["DesignationID"]),
                               ReportingLeadID = Convert.ToInt32(row["ReportingLeadID"]),
                               RoleName = Convert.ToString(row["RoleName"]),
                               DesignationName = Convert.ToString(row["DesignationName"]),
                               ReportingLead = Convert.ToString(row["ReportingLead"])
                           }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving User List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return l;
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
                    cmd.Parameters.Add("@UserinfoId", Id);
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

        public EmployeeModel SaveUser(EmployeeModel ObjEmployeeModel)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_UserInfo]";
                    cmd.Parameters.Add("@UserInfoID", ObjEmployeeModel.UserInfoID);
                    cmd.Parameters.Add("@UserName", ObjEmployeeModel.UserName);
                    cmd.Parameters.Add("@Passwordstring", ObjEmployeeModel.Passwordstring);
                    cmd.Parameters.Add("@FullName", ObjEmployeeModel.FullName);
                    cmd.Parameters.Add("@CNumber", ObjEmployeeModel.CNumber);
                    cmd.Parameters.Add("@EMail", ObjEmployeeModel.EMail);
                    cmd.Parameters.Add("@RoleID", ObjEmployeeModel.RoleID);
                    cmd.Parameters.Add("@DesignationID", ObjEmployeeModel.DesignationID);
                    cmd.Parameters.Add("@ReportingLeadID", ObjEmployeeModel.ReportingLeadID);
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
                            ObjEmployeeModel.UserInfoID = IValue;
                        }
                        else
                            throw new Exception(str);
                    }
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
                    cmd.Parameters.Add("@UserInfoID", ObjEmployeeModel.UserInfoID);
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
                    cmd.Parameters.Add("@UserName", ObjEUser.UserName);
                    cmd.Parameters.Add("@Password", ObjEUser.Password);
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
            catch (Exception ex){throw;}
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
                    cmd.Parameters.Add("@UserInfoID", ObjEUser.UserInfoID);
                    cmd.Parameters.Add("@Password", ObjEUser.Password);
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
            catch (Exception ex) { throw; }
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
                    cmd.Parameters.Add("@EmployeeID", ObjEUser.EmployeeID);
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
                throw new Exception("Error While Retrieving User List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }
    }
}
