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
    public class DCategory
    {
        public ECategory SaveCategory(ECategory ObjECategory)
        {
            DataSet dsCategory = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Category]";
                    cmd.Parameters.Add("@CategoryID", ObjECategory.CategoryID);
                    cmd.Parameters.Add("@CategoryName", ObjECategory.CategoryName);
                    cmd.Parameters.Add("@UserID", ObjECategory.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCategory);
                    }
                    if (dsCategory != null && dsCategory.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsCategory.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjECategory.CategoryID = IValue;
                            if (dsCategory.Tables.Count > 1)
                                ObjECategory.dtCategory = dsCategory.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_Name"))
                    throw new Exception("Category Already Exists");
                else
                    throw new Exception("Error Occured While Saving New Category");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjECategory;
        }

        public ECategory GetCategory(ECategory ObjECategory)
        {
            DataSet dsCategory = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Category]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCategory);
                    }
                    if (dsCategory != null && dsCategory.Tables.Count > 0)
                        ObjECategory.dtCategory = dsCategory.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Category List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjECategory;
        }

        public ECategory DeleteCategory(ECategory ObjECategory)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Del_Category]";
                    cmd.Parameters.Add("@CategoryID", ObjECategory.CategoryID);
                    object ObjeReturn = cmd.ExecuteScalar();
                    string str = Convert.ToString(ObjeReturn);
                    int IValue = 0;
                    if (!int.TryParse(str, out IValue))
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Deleting Category");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjECategory;
        }
    }
}
