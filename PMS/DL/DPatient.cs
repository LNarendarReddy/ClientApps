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
    public class DPatient
    {
        public EPatient SavePatient(EPatient ObjEPatient)
        {
            DataSet dsPatient = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_Patient]";
                    cmd.Parameters.AddWithValue("@PatientID", ObjEPatient.PatientID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEPatient.OrgID);
                    cmd.Parameters.AddWithValue("@RegNo", ObjEPatient.RegNo);
                    cmd.Parameters.AddWithValue("@PName", ObjEPatient.PName);
                    cmd.Parameters.AddWithValue("@DOB", ObjEPatient.PDOB);
                    cmd.Parameters.AddWithValue("@FatheName", ObjEPatient.PFatherName);
                    cmd.Parameters.AddWithValue("@CNumber", ObjEPatient.PCNumber);
                    cmd.Parameters.AddWithValue("@ACnumber", ObjEPatient.ACNumber);
                    cmd.Parameters.AddWithValue("@AadharNumber", ObjEPatient.AdharNumber);
                    cmd.Parameters.AddWithValue("@Email", ObjEPatient.Email);
                    cmd.Parameters.AddWithValue("@FaxNumber", ObjEPatient.FaxNumber);
                    cmd.Parameters.AddWithValue("@PAddress", string.Empty);
                    cmd.Parameters.AddWithValue("@OfficePhone", ObjEPatient.OfficePhone);
                    cmd.Parameters.AddWithValue("@PStatus", ObjEPatient.PStatus);
                    cmd.Parameters.AddWithValue("@PDno", ObjEPatient.DoorNo);
                    cmd.Parameters.AddWithValue("@PVillage", ObjEPatient.Village);
                    cmd.Parameters.AddWithValue("@PCity ", ObjEPatient.City);
                    cmd.Parameters.AddWithValue("@PState ", ObjEPatient.State);
                    cmd.Parameters.AddWithValue("@IsCAddressSame ", ObjEPatient.IsCourierAddressSame);
                    cmd.Parameters.AddWithValue("@PinCode", ObjEPatient.Pincode);
                    cmd.Parameters.AddWithValue("@CourierAddress", ObjEPatient.CourierAddress);
                    cmd.Parameters.AddWithValue("@PFrame", ObjEPatient.PFrame);
                    cmd.Parameters.AddWithValue("@MaritalStatus", ObjEPatient.MaritalStatus);
                    cmd.Parameters.AddWithValue("@PSex", ObjEPatient.PSex);
                    cmd.Parameters.AddWithValue("@PAgeYears", ObjEPatient.PAgeYears);
                    cmd.Parameters.AddWithValue("@PAgeMonths", ObjEPatient.PageMonths);
                    cmd.Parameters.AddWithValue("@PHeight", ObjEPatient.PHeight);
                    cmd.Parameters.AddWithValue("@PWeight", ObjEPatient.PWeight);
                    cmd.Parameters.AddWithValue("@BloodGroup", ObjEPatient.BloodGroup);
                    cmd.Parameters.AddWithValue("@BloodGroupSign", ObjEPatient.BloodGroupSign);
                    cmd.Parameters.AddWithValue("@PermanentBillingRequired", ObjEPatient.PermanentBillingRequired);
                    cmd.Parameters.AddWithValue("@UserID", ObjEPatient.UserID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPatient);
                    }
                    if (dsPatient != null && dsPatient.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsPatient.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEPatient.PatientID = IValue;
                            if (dsPatient.Tables.Count > 1)
                                ObjEPatient.dtPatient = dsPatient.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_PMS_PName"))
                    throw new Exception("Patient Already Exists!!");
                else
                    throw new Exception("Error While Saving Patient!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetPatient(EPatient ObjEPatient)
        {
            DataSet dsPatient = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_PatientDetails]";
                    cmd.Parameters.AddWithValue("@PatientID", ObjEPatient.PatientID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPatient);
                    }
                    if (dsPatient != null && dsPatient.Tables.Count > 0)
                        ObjEPatient.dtPatient = dsPatient.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Patient Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetPatientDetails(EPatient ObjEPatient)
        {
            DataSet dsPatient = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_PatientList]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPatient);
                    }
                    if (dsPatient != null && dsPatient.Tables.Count > 0)
                        ObjEPatient.dtPatientDetails = dsPatient.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Patient List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }
        public EPatient GetAddressDetails(EPatient ObjEPatient)
        {
            DataSet dsPatient = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_PAddress]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPatient);
                    }
                    if (dsPatient != null && dsPatient.Tables.Count > 0)
                        ObjEPatient.dtPatientDetails = dsPatient.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Address Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }
        public EPatient SaveCategory(EPatient ObjEPatient)
        {
            DataSet dsCategory = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_Category]";
                    cmd.Parameters.AddWithValue("@CategoryID", ObjEPatient.CatID);
                    cmd.Parameters.AddWithValue("@CategoryName", ObjEPatient.Category);
                    cmd.Parameters.AddWithValue("@UserID", ObjEPatient.UserID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEPatient.OrgID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCategory);
                    }
                    if (dsCategory != null && dsCategory.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsCategory.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEPatient.CatID = IValue;
                            if (dsCategory.Tables.Count > 1)
                                ObjEPatient.dtCategory = dsCategory.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PMS_UC_TypeName"))
                    throw new Exception("Category Already Exists!!");
                else
                    throw new Exception("Error While Saving Category!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetCategory(EPatient ObjEPatient)
        {
            DataSet dsCat = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_Category]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCat);
                    }
                    if (dsCat != null && dsCat.Tables.Count > 0)
                        ObjEPatient.dtCategory = dsCat.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Category List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }
        public EPatient SaveInvestigationDetails(EPatient ObjEPatient)
        {
            DataSet dsIvsDetails = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_InvestigationDetails]";
                    cmd.Parameters.AddWithValue("@InvestigationDetailsID", ObjEPatient.IvsID);
                    cmd.Parameters.AddWithValue("@CategoryID", ObjEPatient.CatID);
                    cmd.Parameters.AddWithValue("@Description", ObjEPatient.IvsDescription);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEPatient.UserID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEPatient.OrgID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsIvsDetails);
                    }
                    if (dsIvsDetails != null && dsIvsDetails.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsIvsDetails.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEPatient.CatID = IValue;
                            if (dsIvsDetails.Tables.Count > 1)
                                ObjEPatient.dtIvs = dsIvsDetails.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PMS_UC_TypeName"))
                    throw new Exception("Investigation Already Exists!!");
                else
                    throw new Exception("Error While Saving Investigation!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetInvestigationDetails(EPatient ObjEPatient)
        {
            DataSet dsCat = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_InvestigationDetails]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCat);
                    }
                    if (dsCat != null && dsCat.Tables.Count > 0)
                        ObjEPatient.dtIvs = dsCat.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Investigation Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }
        public EPatient SaveAppointment(EPatient ObjEPatient)
        {
            DataSet dsAppointment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_BookAppointment]";
                    cmd.Parameters.AddWithValue("@AppointmentID", ObjEPatient.AppointmentID);
                    cmd.Parameters.AddWithValue("@DoctorID", ObjEPatient.DoctorID);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEPatient.UserID);
                    cmd.Parameters.AddWithValue("@PatientID", ObjEPatient.PatientID);
                    cmd.Parameters.AddWithValue("@AppointmentDate", ObjEPatient.AppointmentDate);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsAppointment);
                    }
                    if (dsAppointment != null && dsAppointment.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsAppointment.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEPatient.AppointmentID = IValue;
                            if (dsAppointment.Tables.Count > 1)
                                ObjEPatient.dtAppointment = dsAppointment.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
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
            return ObjEPatient;
        }

        public EPatient GetAppointment(EPatient ObjEPatient)
        {
            DataSet dsAppointment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Rpt_GetOrgandDoctor]";
                    cmd.Parameters.AddWithValue("@PatientID", ObjEPatient.PatientID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsAppointment);
                    }
                    if (dsAppointment != null && dsAppointment.Tables.Count > 0)
                        ObjEPatient.dtAppointmentDetails = dsAppointment.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Appointment Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetLastTreatmengtID(EPatient ObjEPatient)
        {
            DataSet dsAppointment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_LastVisitTreatmentID]";
                    cmd.Parameters.AddWithValue("@PatientID", ObjEPatient.PatientID);
                    object ObjReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(ObjReturn), out ivalue))
                    {
                        ObjEPatient.TreatmentID = ivalue;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Last treatment ID");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetLastTreatmentDetails(EPatient ObjEPatient)
        {
            DataSet dsTd = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_TreatmentDetails]";
                    cmd.Parameters.AddWithValue("@TreatmentID", ObjEPatient.TreatmentID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsTd);
                    }
                    if (dsTd != null && dsTd.Tables.Count > 0)
                    {
                        ObjEPatient.dtTreatment = dsTd.Tables[0];
                        if(dsTd.Tables.Count > 1)
                        {
                            ObjEPatient.dtTreatmentIVs = dsTd.Tables[1];
                            if (dsTd.Tables.Count > 2)
                            {
                                ObjEPatient.dtMedicine = dsTd.Tables[2];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Last Treatment Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetPatientHistory(EPatient ObjEPatient)
        {
            DataSet dsPh = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_PatientHistory]";
                    cmd.Parameters.AddWithValue("@PatientID", ObjEPatient.PatientID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPh);
                    }
                    if (dsPh != null && dsPh.Tables.Count > 0)
                    {
                        ObjEPatient.dtPatientHistory = dsPh.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Patient History");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetPatientByRegNo(EPatient ObjEPatient)
        {
            DataSet dsPatient = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_PatientDetailsByRegNo]";
                    cmd.Parameters.AddWithValue("@RegNo", ObjEPatient.RegNo);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPatient);
                    }
                    if (dsPatient != null && dsPatient.Tables.Count > 0)
                        ObjEPatient.dtPatient = dsPatient.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Patient Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetAppointmentByDate(EPatient ObjEPatient)
        {
            DataSet dsAppointment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_dailyAppointments]";
                    cmd.Parameters.AddWithValue("@AppointmentDate", ObjEPatient.AppointmentDate);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEPatient.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsAppointment);
                    }
                    if (dsAppointment != null && dsAppointment.Tables.Count > 0)
                        ObjEPatient.dtAppointment = dsAppointment.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Appointment List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }
    }
}
