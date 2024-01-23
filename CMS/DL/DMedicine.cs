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
                    cmd.CommandText = "[CMS_Get_MedicineType]";
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
                    cmd.CommandText = "[CMS_Ins_MedicineType]";
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
                if (ex.Message.Contains("UC_CMS_TypeName"))
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
                    cmd.CommandText = "[CMS_Ins_Medicine]";
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
                    cmd.Parameters.AddWithValue("@ReorderLevel", ObjEMedicine.ReorderLevel);
                    cmd.Parameters.AddWithValue("@GenericName", ObjEMedicine.GenericName);
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
                            GetMedicineList(ObjEMedicine);
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_CMS_MedicineName"))
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
                    cmd.CommandText = "[CMS_Get_MedicineList]";
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
                throw new Exception("Error While Retrieving Medicine List");
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
                    cmd.CommandText = "[CMS_Get_Medicinedetails]";
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
        public EMedicine GetAppointments(EMedicine ObjEMedicine)
        {
            DataTable dtappointment = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[CMS_Get_Appointments]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEMedicine.BranchID);
                    cmd.Parameters.AddWithValue("@ADate", ObjEMedicine.dtAppointmentDate);
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
    }
}
