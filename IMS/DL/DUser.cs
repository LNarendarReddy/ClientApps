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
                    cmd.Parameters.Add("@UserInfoID", ObjEUser.UserInfoID);
                    cmd.Parameters.Add("@UserName", ObjEUser.UserName);
                    cmd.Parameters.Add("@Password", ObjEUser.Password);
                    cmd.Parameters.Add("@UserFullName", ObjEUser.UserFullName);
                    cmd.Parameters.Add("@UserID", ObjEUser.UserID);
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
                throw;
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

        public EUser GetUserCredentials(EUser ObjEUser)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_UserCredentials]";
                    cmd.Parameters.Add("@UserName", ObjEUser.UserName);
                    cmd.Parameters.Add("@Password", ObjEUser.Password);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUser);
                    }
                    if (dsUser != null && dsUser.Tables.Count > 0)
                    {
                        ObjEUser.dtUser = dsUser.Tables[0];
                        //if(dsUser.Tables.Count > 1)
                        //    ObjEUser.dtOrg = dsUser.Tables[1];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to login");
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
                    cmd.Parameters.Add("@UserID", ObjEUser.UserInfoID);
                    cmd.Parameters.Add("@Password", ObjEUser.Password);
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
                throw new Exception("Error occured while chnaging the password");
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
                    cmd.CommandText = "[P_Ins_Organization]";
                    cmd.Parameters.Add("@OrganizationID", ObjEUser.OrganizationID);
                    cmd.Parameters.Add("@Name", ObjEUser.Name);
                    cmd.Parameters.Add("@ContactNumber", ObjEUser.ContactNumber);
                    cmd.Parameters.Add("@GSTIN", ObjEUser.GSTIN);
                    cmd.Parameters.Add("@Hno", ObjEUser.Hno);
                    cmd.Parameters.Add("@Street", ObjEUser.Street);
                    cmd.Parameters.Add("@City", ObjEUser.City);
                    cmd.Parameters.Add("@District", ObjEUser.District);
                    cmd.Parameters.Add("@State", ObjEUser.State);
                    cmd.Parameters.Add("@Country", ObjEUser.Country);
                    cmd.Parameters.Add("@PinCode", ObjEUser.PinCode);
                    cmd.Parameters.Add("@UserID", ObjEUser.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsOrganization);
                    }
                    if (dsOrganization != null && dsOrganization.Tables.Count > 0)
                    {
                        ObjEUser.dtOrg = dsOrganization.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEUser;
        }
    }
}
