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
                    cmd.CommandText = "[HMS_Ins_Branch]";
                    cmd.Parameters.Add("@BranchID", ObjEBranch.BranchID);
                    cmd.Parameters.Add("@OrgID", ObjEBranch.OrgID);
                    cmd.Parameters.Add("@Name", ObjEBranch.Name);
                    cmd.Parameters.Add("@FullAddress", ObjEBranch.FullAddress);
                    cmd.Parameters.Add("@CPerson", ObjEBranch.CPerson);
                    cmd.Parameters.Add("@CNumber", ObjEBranch.CNumber);
                    cmd.Parameters.Add("@CreatedBy", ObjEBranch.UserID);
                    cmd.Parameters.Add("@HindiAddress", ObjEBranch.HindiAddress);
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
                    throw new Exception("Branch Already Exists!!");
                else
                    throw new Exception("Error While Saving Branch");
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
                    cmd.CommandText = "[HMS_Get_Branch]";
                    cmd.Parameters.Add("@OrgID", ObjEBranch.OrgID);
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
                throw new Exception("Error While Retrieving Branch List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBranch;
        }
    }
}
