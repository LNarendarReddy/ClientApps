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
    public class DBranch
    {
        public EBranch SaveBranch(EBranch ObjEBranch)
        {
            DataSet dsBranch = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Branch]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEBranch.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBranch.OrgID);
                    cmd.Parameters.AddWithValue("@Name", ObjEBranch.Name);
                    cmd.Parameters.AddWithValue("@FullAddress", ObjEBranch.FullAddress);
                    cmd.Parameters.AddWithValue("@CPerson", ObjEBranch.CPerson);
                    cmd.Parameters.AddWithValue("@CNumber", ObjEBranch.CNumber);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEBranch.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBranch);
                    }
                    if (dsBranch != null && dsBranch.Tables.Count > 0)
                    {
                        int IVlaue = 0;
                        string str = Convert.ToString(dsBranch.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IVlaue))
                        {
                            ObjEBranch.BranchID = IVlaue;
                            if (dsBranch != null && dsBranch.Tables.Count > 1)
                                ObjEBranch.dtBranch = dsBranch.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_BName"))
                    throw new Exception("Branch Already Exists!!", ex);
                else
                    throw new Exception("Error While Saving Branch", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBranch;
        }

        public EBranch GetBranch(EBranch ObjEBranch)
        {
            DataSet dsBranch = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Branch]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBranch.OrgID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBranch);
                    }
                    if (dsBranch != null && dsBranch.Tables.Count > 0)
                        ObjEBranch.dtBranch = dsBranch.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Branch List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBranch;
        }
    }
}
