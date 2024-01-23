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
                    cmd.CommandText = "[CMS_Ins_Treatment]";
                    cmd.Parameters.AddWithValue("@TreatmentID", ObjETreatment.TreatmentID);
                    cmd.Parameters.AddWithValue("@PatientID", ObjETreatment.PatientID);
                    cmd.Parameters.AddWithValue("@ChiefComplaints", ObjETreatment.ChiefComplaints);
                    cmd.Parameters.AddWithValue("@AppointmentID", ObjETreatment.AppointmentID);
                    cmd.Parameters.AddWithValue("@MedicinePrescriptionforWeek", ObjETreatment.MedicinePrescriptionforWeek);
                    cmd.Parameters.AddWithValue("@AmountPerWeek", ObjETreatment.AmountPerWeek);
                    cmd.Parameters.AddWithValue("@ConsultationFees", ObjETreatment.ConsultationFees);
                    cmd.Parameters.AddWithValue("@TotalAmount", ObjETreatment.TotalAmount);
                    cmd.Parameters.AddWithValue("@Paidamount", ObjETreatment.PaidAmount);
                    cmd.Parameters.AddWithValue("@Due", ObjETreatment.Due);
                    cmd.Parameters.AddWithValue("@Isfree", ObjETreatment.isFree);
                    cmd.Parameters.AddWithValue("@IsBillRequired", ObjETreatment.isBillRequired);
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
                    throw new Exception("Error while saving treatment");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjETreatment;
        }
    }
}
