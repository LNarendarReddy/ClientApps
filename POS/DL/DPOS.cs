using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class DPOS
    {
        public EPOS SavePOS(EPOS ObjEPOS)
        {
            DataSet dsPOS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Ins_POS]";
                    cmd.Parameters.Add("@POSID", ObjEPOS.POSID);
                    cmd.Parameters.Add("@POSName", ObjEPOS.POSName);
                    cmd.Parameters.Add("@POSDescription", ObjEPOS.POSDescription);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPOS);
                    }
                    if (dsPOS != null && dsPOS.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsPOS.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEPOS.POSID = IValue;
                            if (dsPOS.Tables.Count > 1)
                                ObjEPOS.dtPOS = dsPOS.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_PName"))
                    throw new Exception("POS Already Exists!!");
                else
                    throw new Exception("Error While Saving POS!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPOS;
        }

        public EPOS GetPOS(EPOS ObjEPOS)
        {
            DataSet dsPOS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Get_POS]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPOS);
                    }
                    if (dsPOS != null && dsPOS.Tables.Count > 0)
                        ObjEPOS.dtPOS = dsPOS.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving POS List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPOS;
        }
    }
}
