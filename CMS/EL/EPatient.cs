using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EPatient
    {
        public int IvsID { get; set; }
        public int CatID { get; set; }
        public string Category { get; set; }
        public string IvsDescription { get; set; }
        public int PatientID { get; set; }
        public int UserID { get; set; }
        public DataTable dtCategory { get; set; }
        public DataTable dtIvs { get; set; }
        public int BranchID { get; set; }
        public int OrgID { get; set; }
        public object RegNo { get; set; }
        public string PName { get; set; }
        public DateTime PDOB { get; set; }
        public string PFatherName { get; set; }
        public string PCNumber { get; set; }
        public string AdharNumber { get; set; }
        public string Email { get; set; }
        public string FaxNumber { get; set; }
        public string OfficePhone { get; set; }
        public string PAddress { get; set; }
        public string Pincode { get; set; }
        public string CourierAddress { get; set; }
        public int PFrame { get; set; }
        public int MaritalStatus { get; set; }
        public int PSex { get; set; }
        public object PAgeYears { get; set; }
        public int PageMonths { get; set; }
        public decimal PHeight { get; set; }
        public decimal PWeight { get; set; }
        public int BloodGroup { get; set; }
        public int BloodGroupSign { get; set; }
        public bool PermanentBillingRequired { get; set; }
        public DataTable dtPatient { get; set; }
        public DataTable dtPatientDetails { get; set; }
        public string ACNumber { get; set; }
        public string DoorNo { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public object IsCourierAddressSame { get; set; }
        public object Status { get; set; }
        public object PStatus { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public DataTable dtAppointment { get; set; }

        public DataTable dtTreatment = new DataTable();
        public DataTable dtPatientHistory = new DataTable();

        public DataTable dtTreatmentIVs = new DataTable();
        public DataTable dtMedicine = new DataTable();
        public int TreatmentID { get; set; }

        public DataTable dtNonTreatedOldPatients = new DataTable();

        public DataTable dtTreatedOldPatients = new DataTable();

        public DataTable dtNonTreatedNewPatients = new DataTable();

        public DataTable dtTreatedNewPatients = new DataTable();

        public bool IsNewPatient = false;
    }
}
