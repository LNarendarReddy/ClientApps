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
        public EMedicine GetMedicineType(EMedicine ObjEMedicine)
        {
            DataSet dsMedicineType = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_MedicineType]";
                    cmd.Parameters.Add("@BranchID", ObjEMedicine.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicineType);
                    }
                    if (dsMedicineType != null && dsMedicineType.Tables.Count > 0)
                        ObjEMedicine.dtMedicineType = dsMedicineType.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine Type List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine SaveMedicineType(EMedicine ObjEMedicine)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_MedicineType]";
                    cmd.Parameters.Add("@BranchID", ObjEMedicine.BranchID);
                    cmd.Parameters.Add("@OrgID", ObjEMedicine.OrgID);
                    cmd.Parameters.Add("@MedicineTypeID", ObjEMedicine.MedicineTypeID);
                    cmd.Parameters.Add("@TypeName", ObjEMedicine.MedicineType);
                    cmd.Parameters.Add("@UserID", ObjEMedicine.UserID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                        ObjEMedicine.MedicineTypeID = iValue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_PMS_TypeName"))
                    throw new Exception("Medicine Type Already Exists!!");
                else
                    throw new Exception("Error While Saving Medicine Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
        public EMedicine GetMedicinePower(EMedicine ObjEMedicine)
        {
            DataSet dsMedicinePower = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_MedicinePower]";
                    cmd.Parameters.Add("@BranchID", ObjEMedicine.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicinePower);
                    }
                    if (dsMedicinePower != null && dsMedicinePower.Tables.Count > 0)
                        ObjEMedicine.dtMedicinePower = dsMedicinePower.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine Type List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine SaveMedicinePower(EMedicine ObjEMedicine)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_MedicinePower]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEMedicine.OrgID);
                    cmd.Parameters.AddWithValue("@MedicinePowerID", ObjEMedicine.MedicineTypeID);
                    cmd.Parameters.AddWithValue("@PowerName", ObjEMedicine.MedicineType);
                    cmd.Parameters.AddWithValue("@UserID", ObjEMedicine.UserID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                        ObjEMedicine.MedicineTypeID = iValue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_PMS_TypeName"))
                    throw new Exception("Medicine Type Already Exists!!");
                else
                    throw new Exception("Error While Saving Medicine Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
        public EMedicine GetMedicineMessure(EMedicine ObjEMedicine)
        {
            DataSet dsMedicineMeasure = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_MedicineMessure]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicineMeasure);
                    }
                    if (dsMedicineMeasure != null && dsMedicineMeasure.Tables.Count > 0)
                        ObjEMedicine.dtMedicineMeasure = dsMedicineMeasure.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine Type List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine SaveMedicineMessure(EMedicine ObjEMedicine)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_MedicineMessure]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEMedicine.OrgID);
                    cmd.Parameters.AddWithValue("@MedicineMeasureID", ObjEMedicine.MedicineTypeID);
                    cmd.Parameters.AddWithValue("@MeasureType", ObjEMedicine.MedicineType);
                    cmd.Parameters.AddWithValue("@UserID", ObjEMedicine.UserID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                        ObjEMedicine.MedicineTypeID = iValue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_PMS_TypeName"))
                    throw new Exception("Medicine Type Already Exists!!");
                else
                    throw new Exception("Error While Saving Medicine Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine SaveMedicine(EMedicine ObjEMedicine)
        {
            DataSet dsMedicine = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_Medicine]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEMedicine.OrgID);
                    cmd.Parameters.AddWithValue("@UserID", ObjEMedicine.UserID);
                    cmd.Parameters.AddWithValue("@MedicineID", ObjEMedicine.MedicineID);
                    cmd.Parameters.AddWithValue("@MedinceCode", ObjEMedicine.MedicineCode);
                    cmd.Parameters.AddWithValue("@MedinceName", ObjEMedicine.MedinceName);
                    cmd.Parameters.AddWithValue("@MedicineTypeID", ObjEMedicine.MedicineTypeID);
                    cmd.Parameters.AddWithValue("@MedicinePowerID", ObjEMedicine.MedicinePowerID);
                    cmd.Parameters.AddWithValue("@MedicineQuantity", ObjEMedicine.MedicineQuantity);
                    cmd.Parameters.AddWithValue("@MedicineMessureID", ObjEMedicine.MedicineMessureID);
                    cmd.Parameters.AddWithValue("@SPrice", ObjEMedicine.SPrice);
                    cmd.Parameters.AddWithValue("@SoldInLoose", ObjEMedicine.SoldInLoose);
                    cmd.Parameters.AddWithValue("@PackQuantity", ObjEMedicine.PackQuantity);
                    cmd.Parameters.AddWithValue("@PackQuantityMessureID", ObjEMedicine.PackQuantityMessureID);
                    cmd.Parameters.AddWithValue("@ReorderLevel", ObjEMedicine.ReorderLevel);
                    cmd.Parameters.AddWithValue("@CurrentStock", ObjEMedicine.CurrentStock);
                    cmd.Parameters.AddWithValue("@MedicinePosologyQuantity", ObjEMedicine.MedicinePosologyQuantity);
                    cmd.Parameters.AddWithValue("@MedinceQuantityMessure", ObjEMedicine.MedinceQuantityMessure);
                    cmd.Parameters.AddWithValue("@HowmanyTimesValue", ObjEMedicine.HowmanyTimesValue);
                    cmd.Parameters.AddWithValue("@HowManyTimeMessure", ObjEMedicine.HowManyTimeMessure);
                    cmd.Parameters.AddWithValue("@MedinceWhen", ObjEMedicine.MedinceWhen);
                    cmd.Parameters.AddWithValue("@TimeIntervel", ObjEMedicine.TimeIntervel);
                    cmd.Parameters.AddWithValue("@TimeIntervelMessure", ObjEMedicine.TimeIntervelMessure);
                    cmd.Parameters.AddWithValue("@MedicineWith", ObjEMedicine.MedicineWith);
                    cmd.Parameters.AddWithValue("@DayIntervel", ObjEMedicine.DayIntervel);
                    cmd.Parameters.AddWithValue("@NoofBottles", ObjEMedicine.NoofBottles);
                    cmd.Parameters.AddWithValue("@Alternate1", ObjEMedicine.Alternate1);
                    cmd.Parameters.AddWithValue("@Alternate2", ObjEMedicine.Alternate2);
                    cmd.Parameters.AddWithValue("@AlternateCheck", ObjEMedicine.AlternateCheck);
                    cmd.Parameters.AddWithValue("@EmergencySOS", ObjEMedicine.EmergencySOS);
                    cmd.Parameters.AddWithValue("@EmergencyNow", ObjEMedicine.EmergencyNow);
                    cmd.Parameters.AddWithValue("@MedicineWhen2Morning", ObjEMedicine.MedicineWhen2Morning);
                    cmd.Parameters.AddWithValue("@MedicineWhen2noon", ObjEMedicine.MedicineWhen2noon);
                    cmd.Parameters.AddWithValue("@MedicineWhen2Evening", ObjEMedicine.MedicineWhen2Evening);
                    cmd.Parameters.AddWithValue("@MedicineWhen2Night", ObjEMedicine.MedicineWhen2Night);
                    cmd.Parameters.AddWithValue("@KeepinFridge", ObjEMedicine.KeepinFridge);
                    cmd.Parameters.AddWithValue("@InEye", ObjEMedicine.InEye);
                    cmd.Parameters.AddWithValue("@InEar", ObjEMedicine.InEar);
                    cmd.Parameters.AddWithValue("@InNose", ObjEMedicine.InNose);
                    cmd.Parameters.AddWithValue("@InHairRoots", ObjEMedicine.InHairRoots);
                    cmd.Parameters.AddWithValue("@InMouthUlcers", ObjEMedicine.InMouthUlcers);
                    cmd.Parameters.AddWithValue("@ForGargil", ObjEMedicine.ForGargil);
                    cmd.Parameters.AddWithValue("@WithLiquid", ObjEMedicine.WithLiquid);
                    cmd.Parameters.AddWithValue("@WithoutLiquid", ObjEMedicine.WithoutLiquid);
                    cmd.Parameters.AddWithValue("@WithLiquid2", ObjEMedicine.WithLiquid2);
                    cmd.Parameters.AddWithValue("@WithoutLiquid2", ObjEMedicine.WithoutLiquid2);
                    cmd.Parameters.AddWithValue("@FullLiquid", ObjEMedicine.FullLiquid);
                    cmd.Parameters.AddWithValue("@HowtoApply", ObjEMedicine.HowtoApply);
                    cmd.Parameters.AddWithValue("@GenericName", ObjEMedicine.GenericName);
                    cmd.Parameters.AddWithValue("@PosologyCheck", ObjEMedicine.PosologyCheck);
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
                            ObjEMedicine.MedicineID = IValue;
                            //GetMedicinedetails(ObjEMedicine);
                            GetMedicineList(ObjEMedicine);
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_PMS_MedicineName"))
                    throw new Exception("Medicine Already Exists!!");
                else
                    throw new Exception("Error While Saving Medicine Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
        public EMedicine GetMedicineList(EMedicine ObjEMedicine)
        {
            DataSet dsMedicineList = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_MedicineList]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicineList);
                    }
                    if (dsMedicineList != null && dsMedicineList.Tables.Count > 0)
                        ObjEMedicine.dtMedicineList = dsMedicineList.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine Type List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
        public EMedicine GetMedicinedetails(EMedicine ObjEMedicine)
        {
            DataSet dsMedicineDetails = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_Medicinedetails]";
                    cmd.Parameters.AddWithValue("@MedicineID", ObjEMedicine.MedicineID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsMedicineDetails);
                    }
                    if (dsMedicineDetails != null && dsMedicineDetails.Tables.Count > 0)
                        ObjEMedicine.dsMedicineDetails = dsMedicineDetails;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine Type List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
        public EMedicine SaveMedicineStock(EMedicine ObjEMedicine)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_MedicineStock]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEMedicine.OrgID);
                    cmd.Parameters.AddWithValue("@MedicineID", ObjEMedicine.MedicineID);
                    cmd.Parameters.AddWithValue("@NoofPackstoAdd", ObjEMedicine.NoofPackstoAdd);
                    cmd.Parameters.AddWithValue("@NoofPackstoLess", ObjEMedicine.NoofPackstoLess);
                    cmd.Parameters.AddWithValue("@PackQuantity", ObjEMedicine.PackQuantity);
                    cmd.Parameters.AddWithValue("@UserID", ObjEMedicine.UserID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                         ObjEMedicine.MedicineTypeID = iValue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_PMS_TypeName"))
                    throw new Exception("Medicine Type Already Exists!!");
                else
                    throw new Exception("Error While Saving Medicine Type");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
        public EMedicine GetAppointments(EMedicine ObjEMedicine)
        {
            DataTable dtappointment = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_Appointments]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtappointment);
                    }
                    if (dtappointment != null)
                        ObjEMedicine.dtAppointment = dtappointment;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Medicine Type List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }

        public EMedicine UpdateMedicineMessure(EMedicine ObjEMedicine)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Upd_MedicineMessure]";
                    cmd.Parameters.AddWithValue("@MedicineID", ObjEMedicine.MedicineID);
                    cmd.Parameters.AddWithValue("@MedicineMessureID", ObjEMedicine.MedicineMessureID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                        ObjEMedicine.MedicineID = iValue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEMedicine;
        }
    }
}
