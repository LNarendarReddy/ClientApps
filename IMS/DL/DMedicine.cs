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
    public class DMedicine
    {
        public EMedicine SaveMedicine(EMedicine ObjEMedicine)
        {
            DataSet dsMedicine = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Medicine]";
                    cmd.Parameters.Add("@MedicineID", ObjEMedicine.MedicineID);
                    cmd.Parameters.Add("@MedicineName", ObjEMedicine.MedicineName);
                    cmd.Parameters.Add("@CategoryID", ObjEMedicine.CategoryID);
                    cmd.Parameters.Add("@MID", ObjEMedicine.MID);
                    cmd.Parameters.Add("@MName", ObjEMedicine.MName);
                    cmd.Parameters.Add("@UnitID", ObjEMedicine.UnitID);
                    cmd.Parameters.Add("@Unit", ObjEMedicine.Unit);
                    cmd.Parameters.Add("@ReOrderLevel", ObjEMedicine.ReOrderLevel);
                    cmd.Parameters.Add("@Location", ObjEMedicine.Location);
                    cmd.Parameters.Add("@UserID", ObjEMedicine.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicine);
                    }
                    if (dsMedicine != null && dsMedicine.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsMedicine.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEMedicine.CategoryID = IValue;
                            if (dsMedicine.Tables.Count > 1)
                                ObjEMedicine.dtMedicine = dsMedicine.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_MedicineName"))
                    throw new Exception("Medicine Already Exists");
                else
                    throw new Exception("Error Occured While Saving New Medicine");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine GetMedicine(EMedicine ObjEMedicine)
        {
            DataSet dsMedicine = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Medicine]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicine);
                    }
                    if (dsMedicine != null && dsMedicine.Tables.Count > 0)
                        ObjEMedicine.dtMedicine = dsMedicine.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine GetMedicineForBilling(EMedicine ObjEMedicine)
        {
            DataSet dsMedicine = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_MedicineforBilling]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicine);
                    }
                    if (dsMedicine != null && dsMedicine.Tables.Count > 0)
                        ObjEMedicine.dtMedicine = dsMedicine.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine DeleteMedicine(EMedicine ObjEMedicine)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Del_Medicine]";
                    cmd.Parameters.Add("@MedicineID", ObjEMedicine.MedicineID);
                    object ObjeReturn = cmd.ExecuteScalar();
                    string str = Convert.ToString(ObjeReturn);
                    int IValue = 0;
                    if (!int.TryParse(str, out IValue))
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Deleting Medicine");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine SaveUnit(EMedicine ObjEMedicine)
        {
            DataSet dsUnit = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Unit]";
                    cmd.Parameters.Add("@UnitID", ObjEMedicine.UnitID);
                    cmd.Parameters.Add("@Unit", ObjEMedicine.Unit);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUnit);
                    }
                    if (dsUnit != null && dsUnit.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsUnit.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEMedicine.UnitID = IValue;
                            if (dsUnit.Tables.Count > 1)
                                ObjEMedicine.dtUnit = dsUnit.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_Unit"))
                    throw new Exception("Unit Already Exists");
                else
                    throw new Exception("Error Occured While Saving New Unit");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine GetUnit(EMedicine ObjEMedicine)
        {
            DataSet dsUnit = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Unit]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsUnit);
                    }
                    if (dsUnit != null && dsUnit.Tables.Count > 0)
                        ObjEMedicine.dtUnit = dsUnit.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Unit List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine SaveManufacturer(EMedicine ObjEMedicine)
        {
            DataSet dsMaufacturer = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Maufacturer]";
                    cmd.Parameters.Add("@MaufacturerID", ObjEMedicine.MID);
                    cmd.Parameters.Add("@MaufacturerName", ObjEMedicine.MName);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMaufacturer);
                    }
                    if (dsMaufacturer != null && dsMaufacturer.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsMaufacturer.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEMedicine.MID = IValue;
                            if (dsMaufacturer.Tables.Count > 1)
                                ObjEMedicine.dtManufacturer = dsMaufacturer.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_MaufacturerName"))
                    throw new Exception("Maufacturer Already Exists");
                else
                    throw new Exception("Error Occured While Saving New Maufacturer");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine GetManufacturer(EMedicine ObjEMedicine)
        {
            DataSet dsMaufacturer = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Maufacturer]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMaufacturer);
                    }
                    if (dsMaufacturer != null && dsMaufacturer.Tables.Count > 0)
                        ObjEMedicine.dtManufacturer = dsMaufacturer.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Unit List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine GetReOrderReport(EMedicine ObjEMedicine)
        {
            DataSet dsReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_ReorderReport]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsReport);
                    }
                    if (dsReport != null && dsReport.Tables.Count > 0)
                        ObjEMedicine.dtReOrderReport = dsReport.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Reorder Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine GetPriceComparision(EMedicine ObjEMedicine)
        {
            DataSet dsReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_PriceComparision]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsReport);
                    }
                    if (dsReport != null && dsReport.Tables.Count > 0)
                        ObjEMedicine.dtPriceComparision = dsReport.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Price Comparision Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
    }
}
