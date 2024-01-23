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
                    cmd.CommandText = "[P_Ins_Patient]";
                    cmd.Parameters.Add("@PatientID", ObjEPatient.PatientID);
                    cmd.Parameters.Add("@PatientName", ObjEPatient.PatientName);
                    cmd.Parameters.Add("@MobileNumber", ObjEPatient.MobileNumber);
                    cmd.Parameters.Add("@Age", ObjEPatient.Age);
                    cmd.Parameters.Add("@Gender", ObjEPatient.Gender);
                    cmd.Parameters.Add("@Email", ObjEPatient.Email);
                    cmd.Parameters.Add("@CPerson1", ObjEPatient.CPerson1);
                    cmd.Parameters.Add("@CPMobile1", ObjEPatient.CPMobile1);
                    cmd.Parameters.Add("@CPerson2", ObjEPatient.CPerson2);
                    cmd.Parameters.Add("@CPMobile2", ObjEPatient.CPMobile2);
                    cmd.Parameters.Add("@AadhaarNumber", ObjEPatient.AadhaarNumber);
                    cmd.Parameters.Add("@UserID", ObjEPatient.UserID);
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
                if (ex.Message.Contains("UC_NameNumber"))
                    throw new Exception("Patient Already Exists");
                else
                    throw new Exception("Error Occured While Saving New Patient");
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
                    cmd.CommandText = "[P_Get_Patient]";
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
                throw new Exception("Error While Retrieving Patient List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient DeletePatient(EPatient ObjEPatient)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Del_Patient]";
                    cmd.Parameters.Add("@PatientID", ObjEPatient.PatientID);
                    object ObjeReturn = cmd.ExecuteScalar();
                    string str = Convert.ToString(ObjeReturn);
                    int IValue = 0;
                    if (!int.TryParse(str, out IValue))
                        throw new Exception(str);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Deleting Patient");
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
                    cmd.CommandText = "[P_Get_PatientDetails]";
                    cmd.Parameters.Add("@PatientID", ObjEPatient.PatientID);
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
                throw new Exception("Error While Retrieving Patient Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient SaveConsultation(EPatient ObjEPatient)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Consultation]";
                    cmd.Parameters.Add("@PatientID", ObjEPatient.PatientID);
                    cmd.Parameters.Add("@PatientName", ObjEPatient.PatientName);
                    cmd.Parameters.Add("@MobileNumber", ObjEPatient.MobileNumber);
                    cmd.Parameters.Add("@ServiceID", ObjEPatient.ServiceID);
                    cmd.Parameters.Add("@ServiceName", ObjEPatient.ServiceName);
                    cmd.Parameters.Add("@Price", ObjEPatient.Price);
                    cmd.Parameters.Add("@UserID ", ObjEPatient.UserID);
                    object ObjReturn = cmd.ExecuteScalar();
                    int IValue = 0;
                    if (int.TryParse(Convert.ToString(ObjReturn), out IValue))
                        ObjEPatient.ConsultationID = IValue;
                    else
                        throw new Exception(Convert.ToString(ObjReturn));
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_NameNumber"))
                    throw new Exception("Patient Already Exists");
                else
                    throw new Exception("Error Occured While Saving Consultation");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetConsultationReport(EPatient ObjEPatient)
        {
            DataSet dsReport = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_ConsultationReport]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsReport);
                    }
                    if (dsReport != null && dsReport.Tables.Count > 0)
                        ObjEPatient.dtReport = dsReport.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Consultation Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient SaveService(EPatient ObjEPatient)
        {
            try
            {
                DataSet dsService = new DataSet();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Service]";
                    cmd.Parameters.Add("@ServiceName", ObjEPatient.ServiceName);
                    cmd.Parameters.Add("@Cost", ObjEPatient.Price);
                    cmd.Parameters.Add("@UserID ", ObjEPatient.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsService);
                    }
                    int IValue = 0;
                    if(dsService != null && dsService.Tables.Count > 0)
                    {
                        string strReturn = Convert.ToString(dsService.Tables[0].Rows[0][0]);
                        if (int.TryParse(strReturn, out IValue))
                        {
                            ObjEPatient.ServiceID = IValue;
                            if (dsService.Tables.Count > 1)
                                ObjEPatient.dtService = dsService.Tables[1];
                        }
                        else
                            throw new Exception(strReturn);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_ServiceName"))
                    throw new Exception("Service Already Exists");
                else
                    throw new Exception("Error Occured While Saving Service");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }

        public EPatient GetServices(EPatient ObjEPatient)
        {
            DataSet dsService = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Services]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsService);
                    }
                    if (dsService != null && dsService.Tables.Count > 0)
                        ObjEPatient.dtService = dsService.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Services");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEPatient;
        }
    }
}
