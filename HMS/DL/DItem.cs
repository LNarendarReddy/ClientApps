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
    public class DItem
    {
        public EItem GetItemCategory(EItem ObjEItem)
        {
            DataSet dsItemCategory = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_ItemCategory]";
                    cmd.Parameters.Add("@BranchID", ObjEItem.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsItemCategory);
                    }
                    if (dsItemCategory != null && dsItemCategory.Tables.Count > 0)
                        ObjEItem.dtItemCategory = dsItemCategory.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving item category list");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

        public EItem SaveItemCategory(EItem ObjEItem)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Ins_ItemCategory]";
                    cmd.Parameters.Add("@ItemCategoryID", ObjEItem.ItemCategoryID);
                    cmd.Parameters.Add("@CategoryName", ObjEItem.CategoryName);
                    cmd.Parameters.Add("@BranchID", ObjEItem.BranchID);
                    cmd.Parameters.Add("@OrgID", ObjEItem.OrgID);
                    cmd.Parameters.Add("@UserID", ObjEItem.UserID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                        ObjEItem.ItemCategoryID = iValue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_HMS_TypeName"))
                    throw new Exception("Item Category already exists!!");
                else
                    throw new Exception("Error While Saving Item Category");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

        public EItem SaveItem(EItem ObjEItem)
        {
            DataSet dsItem = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Ins_Item]";
                    cmd.Parameters.AddWithValue("@ItemID", ObjEItem.ItemID);
                    cmd.Parameters.AddWithValue("@ItemCode", ObjEItem.ItemCode);
                    cmd.Parameters.AddWithValue("@ItemName", ObjEItem.ItemName);
                    cmd.Parameters.AddWithValue("@ItemCategoryID", ObjEItem.ItemCategoryID);
                    cmd.Parameters.AddWithValue("@SPrice", ObjEItem.SPrice);
                    cmd.Parameters.AddWithValue("@ServicePrice", ObjEItem.ServicePrice);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEItem.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEItem.OrgID);
                    cmd.Parameters.AddWithValue("@UserID", ObjEItem.UserID);
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
                            ObjEItem.ItemID = IValue;
                            if (dsItem.Tables.Count > 1)
                                ObjEItem.dtItemList = dsItem.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("HMS_UC_ItemCode"))
                    throw new Exception("Item Code Already Exists!!");
                if (ex.Message.Contains("HMS_UC_ItemName"))
                    throw new Exception("Item Name Already Exists!!");
                else
                    throw new Exception("Error While Saving Item");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

        public EItem GetItemByCode(EItem ObjEItem)
        {
            DataSet dsItemDetails = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_ItemByCode]";
                    cmd.Parameters.AddWithValue("@ItemCode", ObjEItem.ItemCode);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsItemDetails);
                    }
                    if (dsItemDetails != null && dsItemDetails.Tables.Count > 0 && dsItemDetails.Tables[0].Rows.Count > 0)
                    {
                        ObjEItem.ItemID = Convert.ToInt32(dsItemDetails.Tables[0].Rows[0]["ItemID"]);
                        ObjEItem.ItemCode = Convert.ToString(dsItemDetails.Tables[0].Rows[0]["ItemCode"]);
                        ObjEItem.ItemName = Convert.ToString(dsItemDetails.Tables[0].Rows[0]["ItemName"]);
                        ObjEItem.SPrice = Convert.ToDouble(dsItemDetails.Tables[0].Rows[0]["SPrice"]);
                        ObjEItem. ServicePrice = Convert.ToDouble(dsItemDetails.Tables[0].Rows[0]["ServicePrice"]);
                    }
                    else
                        throw new Exception("Item does not exists!");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Item does not exists"))
                    throw ex;
                else
                    throw new Exception("Error While Retrieving Item Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

        public EItem GetItemList(EItem ObjEItem)
        {
            DataSet dsUItemList = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_ItemList]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEItem.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUItemList);
                    }
                    if (dsUItemList != null && dsUItemList.Tables.Count > 0)
                        ObjEItem.dtItemList = dsUItemList.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Item List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

        public EItem SaveBilling(EItem ObjEItem)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Ins_Billing]";
                    cmd.Parameters.AddWithValue("@dtItems", ObjEItem.dtItems);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEItem.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEItem.OrgID);
                    cmd.Parameters.AddWithValue("@UserID", ObjEItem.UserID);
                    cmd.Parameters.AddWithValue("@PaymentMode", ObjEItem.PaymentMode);
                    cmd.Parameters.AddWithValue("@IsService", ObjEItem.IsService);
                    cmd.Parameters.AddWithValue("@Billnumber", ObjEItem.NewBillNumber);
                    object objReturn = cmd.ExecuteScalar();
                    int IValue = 0;
                    if (int.TryParse(Convert.ToString(objReturn), out IValue))
                        ObjEItem.BillID = IValue;
                    else
                        throw new Exception("Error while saving Bill");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Bill");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

        public EItem GetNewItemCode(EItem ObjEItem)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_NewItemCode]";
                    object obj = cmd.ExecuteScalar();
                    ObjEItem.ItemCode = Convert.ToString(obj);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving item category list");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

        public EItem GetNewBillNumber(EItem ObjEItem)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[HMS_Get_NewBillNumber]";
                    object obj = cmd.ExecuteScalar();
                    ObjEItem.NewBillNumber = obj;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving item category list");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEItem;
        }

    }
}