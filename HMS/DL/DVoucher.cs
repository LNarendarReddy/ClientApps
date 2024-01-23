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
    public class DVoucher
    {
        public EVoucher SaveVoucher(EVoucher ObjEVoucher)
        {
            DataSet dsItem = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[IC_Ins_Vouchers]";
                    cmd.Parameters.AddWithValue("@VoucherNumber", ObjEVoucher.VoucherNumber);
                    cmd.Parameters.AddWithValue("@Amount", ObjEVoucher.Amount);
                    cmd.Parameters.AddWithValue("@RecievedBy", ObjEVoucher.recievedBy);
                    cmd.Parameters.AddWithValue("@Purpose", ObjEVoucher.Purpose);
                    cmd.Parameters.AddWithValue("@UserID", ObjEVoucher.UserID);
                    cmd.Parameters.AddWithValue("@VoucherCategoryID", ObjEVoucher.VoucherCategoryID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsItem);
                    }
                    if (dsItem != null && dsItem.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsItem.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEVoucher.VoucherID = IValue;
                            if (dsItem.Tables.Count > 1)
                                ObjEVoucher.dtList = dsItem.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Voucher");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEVoucher;
        }

        public EVoucher GetItemList(EVoucher ObjEVoucher)
        {
            DataSet dsUItemList = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[IC_Get_Vouchers]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUItemList);
                    }
                    if (dsUItemList != null && dsUItemList.Tables.Count > 0)
                        ObjEVoucher.dtList = dsUItemList.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Voucher List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEVoucher;
        }

        public EVoucher GetNewItemCode(EVoucher ObjEVoucher)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[IC_Get_NewVoucherNumber]";
                    object obj = cmd.ExecuteScalar();
                    ObjEVoucher.VoucherNumber = Convert.ToString(obj);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving New VoucherNumber");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEVoucher;
        }

        public EVoucher GetVoucherCategory(EVoucher ObjEVoucher)
        {
            DataSet dsItemCategory = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[IC_Get_VoucherCategory]";
                    cmd.Parameters.Add("@BranchID", ObjEVoucher.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsItemCategory);
                    }
                    if (dsItemCategory != null && dsItemCategory.Tables.Count > 0)
                        ObjEVoucher.dtVoucherCategory = dsItemCategory.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving category list");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEVoucher;
        }

        public EVoucher SaveVoucherCategory(EVoucher ObjEVoucher)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[IC_Ins_VoucherCategory]";
                    cmd.Parameters.Add("@VoucherCategoryID", ObjEVoucher.VoucherCategoryID);
                    cmd.Parameters.Add("@CategoryName", ObjEVoucher.CategoryName);
                    cmd.Parameters.Add("@BranchID", ObjEVoucher.BranchID);
                    cmd.Parameters.Add("@OrgID", ObjEVoucher.OrgID);
                    cmd.Parameters.Add("@UserID", ObjEVoucher.UserID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                        ObjEVoucher.VoucherCategoryID = iValue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_HMS_VoucherCategoryName"))
                    throw new Exception("Voucher Category already exists!!");
                else
                    throw new Exception("Error While Saving Voucher Category");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEVoucher;
        }

        public EVoucher GetPersonNames(EVoucher ObjEVoucher)
        {
            DataSet dsItemCategory = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[IC_Get_PersonNames]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsItemCategory);
                    }
                    if (dsItemCategory != null && dsItemCategory.Tables.Count > 0)
                        ObjEVoucher.dtPersonNames = dsItemCategory.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Person list");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEVoucher;
        }
    }
}
