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
    public class DAccount
    {
        public EAccount GetAccount(EAccount oBJEAccount)
        {
            DataSet dsAccount = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Account]";
                    cmd.Parameters.Add("@FromDate", oBJEAccount.FromDate);
                    cmd.Parameters.Add("@TodDate", oBJEAccount.ToDate);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsAccount);
                    }
                    if (dsAccount != null && dsAccount.Tables.Count > 0)
                    {
                        oBJEAccount.dtIncome = dsAccount.Tables[0].Copy();
                        if(dsAccount.Tables.Count > 1)
                            oBJEAccount.dtExpenses = dsAccount.Tables[1].Copy();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Retriving Accounts");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEAccount;
        }
    }
}
