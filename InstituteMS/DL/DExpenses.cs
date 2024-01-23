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
    public class DExpenses
    {
        public EExpenses SaveExpense(EExpenses ObjEExpenses)
        {
            DataSet dsExpenses = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Expenses]";
                    cmd.Parameters.AddWithValue("@ExpensesID", ObjEExpenses.ExpensesID);
                    cmd.Parameters.AddWithValue("@ExpensesDEscription", ObjEExpenses.ExpensesDEscription);
                    cmd.Parameters.AddWithValue("@ExpenseName", ObjEExpenses.ExpenseName);
                    cmd.Parameters.AddWithValue("@Amount", ObjEExpenses.Amount);
                    cmd.Parameters.AddWithValue("@UserID", ObjEExpenses.UserID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEExpenses.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEExpenses.OrgID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsExpenses);
                    }
                    if (dsExpenses != null && dsExpenses.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsExpenses.Tables[0].Rows[0][0]);
                        if (!int.TryParse(str, out IValue))
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Saving Expense", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEExpenses;
        }

        public EExpenses GetExpses(EExpenses ObjEExpenses)
        {
            DataSet dsExpenses = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Expeses]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsExpenses);
                    }
                    if (dsExpenses != null && dsExpenses.Tables.Count > 0)
                        ObjEExpenses.dtExpenses = dsExpenses.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Expenses List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEExpenses;
        }

        public EExpenses GetExpsesName(EExpenses ObjEExpenses)
        {
            DataSet dsExpenses = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_GEt_ExpenseName]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEExpenses.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsExpenses);
                    }
                    if (dsExpenses != null && dsExpenses.Tables.Count > 0)
                        ObjEExpenses.dtExpensesNAme = dsExpenses.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Expenses List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEExpenses;
        }
    }
}
