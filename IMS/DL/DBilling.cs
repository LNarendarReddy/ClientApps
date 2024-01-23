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
    public class DBilling
    {
        public EBilling SaveBilling(EBilling oBJEBilling)
        {
            DataSet dsBilling = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Billing]";
                    cmd.Parameters.Add("@BillID", oBJEBilling.BillID);
                    cmd.Parameters.Add("@PatientID", oBJEBilling.PatientID);
                    cmd.Parameters.Add("@PatientName", oBJEBilling.PatientName);
                    cmd.Parameters.Add("@MobileNumber", oBJEBilling.MobileNumber);
                    cmd.Parameters.Add("@GrandTotal", oBJEBilling.GrandTotal);
                    cmd.Parameters.Add("@NetTotal", oBJEBilling.NetTotal);
                    cmd.Parameters.Add("@Discount", oBJEBilling.Discount);
                    cmd.Parameters.Add("@PaidTotal", oBJEBilling.PaidTotal);
                    cmd.Parameters.Add("@Due", oBJEBilling.Due);
                    cmd.Parameters.Add("@UserID", oBJEBilling.UserID);
                    cmd.Parameters.Add("@dtBilling", oBJEBilling.dtBilling);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBilling);
                    }
                    if (dsBilling != null && dsBilling.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsBilling.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                            oBJEBilling.BillID = IValue;
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Saving Bill");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEBilling;
        }

        public EBilling GetBills(EBilling oBJEBilling)
        {
            DataSet dsBills = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_PatientBills]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBills);
                    }
                    if (dsBills != null && dsBills.Tables.Count > 0)
                    {
                        oBJEBilling.dtBills = dsBills.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Retriving Bills");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEBilling;
        }

        public EBilling GetPatientDue(EBilling oBJEBilling)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_PatientDue]";
                    cmd.Parameters.Add("@PatientID", oBJEBilling.PatientID);
                    object ObjReturn = cmd.ExecuteScalar();
                    decimal DValue = 0;
                    if (decimal.TryParse(Convert.ToString(ObjReturn), out DValue))
                        oBJEBilling.Due = DValue;
                    else
                        oBJEBilling.Due = 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Retriving Patient Due");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEBilling;
        }

        public EBilling ClearDue(EBilling oBJEBilling)
        {
            DataSet dsBilling = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Upd_Due]";
                    cmd.Parameters.Add("@BillID", oBJEBilling.BillID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Clearing Due");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEBilling;
        }
    }
}
