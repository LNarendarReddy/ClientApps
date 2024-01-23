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
    public class DBook
    {
        public EBook SaveBook(EBook ObjEBook)
        {
            DataSet dsBook = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_BookInfo]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBook.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEBook.BranchID);
                    cmd.Parameters.AddWithValue("@BookInfoID", ObjEBook.BookInfoID);
                    cmd.Parameters.AddWithValue("@CategoryID", ObjEBook.CategoryID);
                    cmd.Parameters.AddWithValue("@BookName", ObjEBook.BookName);
                    cmd.Parameters.AddWithValue("@AuthorName", ObjEBook.AuthorName);
                    cmd.Parameters.AddWithValue("@UserID", ObjEBook.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBook);
                    }
                    if (dsBook != null && dsBook.Tables.Count > 0)
                    {
                        int IVlaue = 0;
                        string str = Convert.ToString(dsBook.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IVlaue))
                        {
                            ObjEBook.BookInfoID = IVlaue;
                            if (dsBook != null && dsBook.Tables.Count > 1)
                                ObjEBook.dtBook = dsBook.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_BookName"))
                    throw new Exception("Book Already Exists!!", ex);
                else
                    throw new Exception("Error While Saving Book", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBook;
        }

        public EBook GetBook(EBook ObjEBook)
        {
            DataSet dsBook = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_BookInfo]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBook.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEBook.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBook);
                    }
                    if (dsBook != null && dsBook.Tables.Count > 0)
                        ObjEBook.dtBook = dsBook.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Book List" , ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBook;
        }

        public EBook SaveBookStock(EBook ObjEBook)
        {
            DataSet dsBook = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_BookStock]";
                    cmd.Parameters.AddWithValue("@BookinfoID", ObjEBook.BookInfoID);
                    cmd.Parameters.AddWithValue("@Quantity", ObjEBook.Quantity);
                    cmd.Parameters.AddWithValue("@UserID", ObjEBook.UserID);
                    cmd.Parameters.AddWithValue("@BillID", ObjEBook.BillID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBook.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEBook.BranchID);
                    cmd.Parameters.AddWithValue("@StudentName", ObjEBook.StudentName);
                    cmd.Parameters.AddWithValue("@StudentMobile", ObjEBook.StudentMobile);
                    cmd.Parameters.AddWithValue("@StudentID", ObjEBook.StudentID);
                    object Objreturn = cmd.ExecuteScalar();
                    int IVlaue = 0;
                    string str = Convert.ToString(Objreturn);
                    if (!int.TryParse(str, out IVlaue))
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Book stock", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBook;
        }

        public EBook GetBookEntryReport(EBook ObjEBook)
        {
            DataSet dsBook = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_BookEntryReport]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBook.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEBook.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBook);
                    }
                    if (dsBook != null && dsBook.Tables.Count > 0)
                        ObjEBook.dtBook = dsBook.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Book Entry Report", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBook;
        }
        public EBook GetBookSaleReport(EBook ObjEBook)
        {
            DataSet dsBook = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_BookSaleReport]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBook.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEBook.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBook);
                    }
                    if (dsBook != null && dsBook.Tables.Count > 0)
                        ObjEBook.dtBook = dsBook.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Book Sale Report", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBook;
        }
        public EBook GetBookStockReport(EBook ObjEBook)
        {
            DataSet dsBook = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_BookStockReport]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEBook.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEBook.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBook);
                    }
                    if (dsBook != null && dsBook.Tables.Count > 0)
                        ObjEBook.dtBook = dsBook.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Book Stock Report", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEBook;
        }
    }
}

