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
    public class DDistributor
    {
        public EDistributor SaveDistributor(EDistributor ObjEDistributor)
        {
            DataSet dsDistributor = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Distributor]";
                    cmd.Parameters.Add("@DistributorID", ObjEDistributor.DistributorID);
                    cmd.Parameters.Add("@DistributorName", ObjEDistributor.DistributorName);
                    cmd.Parameters.Add("@ContactPerson", ObjEDistributor.ContactPerson);
                    cmd.Parameters.Add("@EmailID", ObjEDistributor.EmailID);
                    cmd.Parameters.Add("@GSTIN", ObjEDistributor.GSTIN);
                    cmd.Parameters.Add("@MobileNumber", ObjEDistributor.MobileNumber);
                    cmd.Parameters.Add("@BranchName", ObjEDistributor.BranchName);
                    cmd.Parameters.Add("@BAddress", ObjEDistributor.BAddress);
                    cmd.Parameters.Add("@Remarks", ObjEDistributor.Remarks);
                    cmd.Parameters.Add("@UserID", ObjEDistributor.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDistributor);
                    }
                    if (dsDistributor != null && dsDistributor.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsDistributor.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEDistributor.DistributorID = IValue;
                            if (dsDistributor.Tables.Count > 1)
                                ObjEDistributor.dtDistributor = dsDistributor.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_DistributorName"))
                    throw new Exception("Distributor Already Exists");
                else
                    throw new Exception("Error Occured While Saving New Distributor");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEDistributor;
        }

        public EDistributor GetDistributor(EDistributor ObjEDistributor)
        {
            DataSet dsDistributor = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Distributor]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDistributor);
                    }
                    if (dsDistributor != null && dsDistributor.Tables.Count > 0)
                        ObjEDistributor.dtDistributor = dsDistributor.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Distributor List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEDistributor;
        }

        public EDistributor DeleteDistributor(EDistributor ObjEDistributor)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Del_Distributor]";
                    cmd.Parameters.Add("@DistributorID", ObjEDistributor.DistributorID);
                    object ObjeReturn = cmd.ExecuteScalar();
                    string str = Convert.ToString(ObjeReturn);
                    int IValue = 0;
                    if (!int.TryParse(str, out IValue))
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Deleting Distributor");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEDistributor;
        }
    }
}
