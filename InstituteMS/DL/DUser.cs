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
        public EUser SaveUser(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_UserInfo]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEUser.UserInfoID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEUser.OrganizationID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEUser.BranchID);
                    cmd.Parameters.AddWithValue("@UserName", ObjEUser.UserName);
                    cmd.Parameters.AddWithValue("@Passwordstring", ObjEUser.Password);
                    cmd.Parameters.AddWithValue("@FullName", ObjEUser.FullName);
                    cmd.Parameters.AddWithValue("@CNumber", ObjEUser.CNumber);
                    cmd.Parameters.AddWithValue("@EMail", ObjEUser.Email);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEUser.UserID);
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
                            ObjEUser.UserInfoID = IValue;
                            if (dsUser.Tables.Count > 1)
                                ObjEUser.dtUser = dsUser.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_UName"))
                    throw new Exception("User Already Exists!!", ex);
                else
                    throw new Exception("Error While Saving User!!", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser GetUser(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_UserInfo]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEUser.BranchID);
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
                throw new Exception("Error While Retrieving User List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser SaveOrganization(EUser ObjEUser)
        {
            DataSet dsOrganization = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Org]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEUser.OrganizationID);
                    cmd.Parameters.AddWithValue("@FullName", ObjEUser.Name);
                    cmd.Parameters.AddWithValue("@ShortName", ObjEUser.ShortName);
                    cmd.Parameters.AddWithValue("@FullAddress", ObjEUser.FullAddress);
                    cmd.Parameters.AddWithValue("@CNumber", ObjEUser.CNumber);
                    cmd.Parameters.AddWithValue("@STNumber", ObjEUser.STNumber);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEUser.UserID);
                    cmd.Parameters.AddWithValue("@Exdate", ObjEUser.Exdate);
                    cmd.Parameters.AddWithValue("@OrgName", ObjEUser.OrgSecondName);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsOrganization);
                    }
                    if (dsOrganization != null && dsOrganization.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string str = Convert.ToString(dsOrganization.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out ivalue))
                        {
                            ObjEUser.OrganizationID = ivalue;
                            if (dsOrganization.Tables.Count > 1)
                                ObjEUser.dtOrg = dsOrganization.Tables[1];
                        }
                        else
                        {
                            throw new Exception(str);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_FullName"))
                    throw new Exception("Organizaton Already Exists", ex);
                else if (ex.Message.Contains("UC_ShortName"))
                    throw new Exception("Short Name Already Exists", ex);
                else
                    throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser GetOrganization(EUser ObjEUser)
        {
            DataSet dsOrg = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Org]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsOrg);
                    }
                    if (dsOrg != null && dsOrg.Tables.Count > 0)
                    {
                        ObjEUser.dtOrg = dsOrg.Tables[0];
                        if(dsOrg.Tables.Count > 1)
                            ObjEUser.dtBranch = dsOrg.Tables[1];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Organization", ex);
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
                    cmd.CommandText = "[P_Get_UserCredentials1]";
                    cmd.Parameters.AddWithValue("@UserName", ObjEUser.UserName);
                    cmd.Parameters.AddWithValue("@Password", ObjEUser.Password);
                    cmd.Parameters.AddWithValue("@BranchName", ObjEUser.BranchName);
                    cmd.Parameters.AddWithValue("@OrgName", ObjEUser.ShortName);
                    cmd.Parameters.AddWithValue("@NewBuild", true);
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
                            if (dsUser.Tables.Count > 1)
                            {
                                ObjEUser.dtEmail = dsUser.Tables[1];
                                if (dsUser.Tables.Count > 2)
                                {
                                    ObjEUser.dtSMS = dsUser.Tables[2];
                                    if(dsUser.Tables.Count > 3)
                                    {
                                        ObjEUser.dtOrg = dsUser.Tables[3];
                                        if (dsUser.Tables.Count > 4)
                                        {
                                            ObjEUser.dtBranch = dsUser.Tables[4];
                                        }
                                    }
                                }
                            }
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex){throw ex;}
            finally{SQLCon.Sqlconn().Close();}
            return ObjEUser;
        }

        public EUser SaveEmail(EUser ObjEUser)
        {
            DataSet dsEmail = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_EmailConfiguration]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEUser.OrganizationID);
                    cmd.Parameters.AddWithValue("@Email", ObjEUser.Email);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEUser.UserID);
                    cmd.Parameters.AddWithValue("@Mobile", ObjEUser.Mobile);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsEmail);
                    }
                    if (dsEmail != null && dsEmail.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsEmail.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEUser.OrganizationID = IValue;
                            if (dsEmail.Tables.Count > 1)
                                ObjEUser.dtEmail = dsEmail.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_Email"))
                    throw new Exception("Email Already Exists!!", ex);
                else
                    throw new Exception("Error While Saving Email Configuration!!", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser GetEmail(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_EmailConfiguration]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEUser.OrganizationID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0)
                        ObjEUser.dtEmail = dsUser.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Email List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser UpdateUser(EUser ObjEUser)
        {
            try
            {
                DataSet dsUser = new DataSet();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Upd_Password]";
                    cmd.Parameters.AddWithValue("@UserID", ObjEUser.UserInfoID);
                    cmd.Parameters.AddWithValue("@Password", ObjEUser.Password);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0)
                        ObjEUser.dtUserDetails = dsUser.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured while changing the password", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public EUser SaveSMS(EUser ObjEUser)
        {
            DataSet dsOrganization = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_SMS]";
                    cmd.Parameters.AddWithValue("@URLtext", ObjEUser.URLtext);
                    cmd.Parameters.AddWithValue("@AppKey", ObjEUser.AppKey);
                    cmd.Parameters.AddWithValue("@SenderID", ObjEUser.SenderID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEUser.OrganizationID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex){throw ex;}
            finally{SQLCon.Sqlconn().Close();}
            return ObjEUser;
        }

        public EUser GetSMS(EUser ObjEUser)
        {
            DataSet dsSMS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[p_Get_SMS]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEUser.OrganizationID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsSMS);
                    }
                    if (dsSMS != null && dsSMS.Tables.Count > 0)
                        ObjEUser.dtSMS = dsSMS.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving SMS Details", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }

        public string GetAppVersion()
        {
            string appVersion = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Appversion]";
                    appVersion = Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
              throw new Exception("Error While Retrieving App Vesrion", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return appVersion;
        }
    }
}
