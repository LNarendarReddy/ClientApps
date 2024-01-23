using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ETreatment
    {
        public int TreatmentID { get; set; }
        public int PatientID { get; set; }
        public object ChiefComplaints { get; set; }
        public string FamilyHistory { get; set; }
        public string SurgicalHistory { get; set; }
        public string Allergies { get; set; }
        public string MedicalHistory { get; set; }
        public int AppointmentID { get; set; }
        public object MedicinePrescriptionforWeek { get; set; }

        public object AmountPerWeek { get; set; }
        public object ConsultationFees { get; set; }

        public object TotalAmount { get; set; }

        public object PaidAmount { get; set; }
        public object Due { get; set; }
        public decimal Discount { get; set; }
        public bool isParcel { get; set; }
        public bool isFree { get; set; }
        public bool isBillRequired { get; set; }
        public bool isPrintPrescription { get; set; }
        public int BranchID { get; set; }
        public int UserID { get; set; }
        public DataTable dtInvestigations { get; set; }
        public DataTable dtMedicine { get; set; }
        public DataSet dsTreatmentDetails { get; set; }
    }
}
