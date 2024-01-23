using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class DTreatment
    {
        public ETreatment SaveTreatment(ETreatment ObjETreatment)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_Treatment]";
                    cmd.Parameters.AddWithValue("@TreatmentID", ObjETreatment.TreatmentID);
                    cmd.Parameters.AddWithValue("@PatientID", ObjETreatment.PatientID);
                    cmd.Parameters.AddWithValue("@ChiefComplaints", ObjETreatment.ChiefComplaints);
                    cmd.Parameters.AddWithValue("@FamilyHistory", ObjETreatment.FamilyHistory);
                    cmd.Parameters.AddWithValue("@SurgicalHistory", ObjETreatment.SurgicalHistory);
                    cmd.Parameters.AddWithValue("@Allergies", ObjETreatment.Allergies);
                    cmd.Parameters.AddWithValue("@MedicalHistory", ObjETreatment.MedicalHistory);
                    cmd.Parameters.AddWithValue("@AppointmentID", ObjETreatment.AppointmentID);
                    cmd.Parameters.AddWithValue("@MedicinePrescriptionforWeek", ObjETreatment.MedicinePrescriptionforWeek);
                    cmd.Parameters.AddWithValue("@ConsultationFees", ObjETreatment.ConsultationFees);
                    cmd.Parameters.AddWithValue("@Discount", ObjETreatment.Discount);
                    cmd.Parameters.AddWithValue("@Isparcel", ObjETreatment.isParcel);
                    cmd.Parameters.AddWithValue("@Isfree", ObjETreatment.isFree);
                    cmd.Parameters.AddWithValue("@IsBillRequired", ObjETreatment.isBillRequired);
                    cmd.Parameters.AddWithValue("@IsPrintPriscription", ObjETreatment.isPrintPrescription);
                    cmd.Parameters.AddWithValue("@dtInvestigations", ObjETreatment.dtInvestigations);
                    cmd.Parameters.AddWithValue("@dtMedicine", ObjETreatment.dtMedicine);
                    cmd.Parameters.AddWithValue("@UserID", ObjETreatment.UserID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjETreatment.BranchID);
                    object Objreturn = cmd.ExecuteScalar();
                    int iValue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out iValue))
                        ObjETreatment.TreatmentID = iValue;
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
            return ObjETreatment;
        }
        public ETreatment GetTreatmentDetails(ETreatment ObjETreatment)
        {
            DataSet dsTreatment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_TreatmentDetails]";
                    cmd.Parameters.AddWithValue("@TreatmentID", ObjETreatment.TreatmentID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsTreatment);
                    }
                    if (dsTreatment != null && dsTreatment.Tables.Count > 0)
                        ObjETreatment.dsTreatmentDetails = dsTreatment;
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
            return ObjETreatment;
        }

    }
}
