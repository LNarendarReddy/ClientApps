using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EMedicine
    {
        public int MedicineTypeID { get; set; }
        public int OrgID { get; set; }
        public int BranchID { get; set; }
        public int UserID { get; set; }
        public string MedicineType { get; set; }
        public DataTable dtMedicineType { get; set; }
        public DataTable dtMedicinePower { get; set; }
        public DataTable dtMedicineList { get; set; }
        public DataSet dsMedicineDetails { get; set; }
        public int MedicineID { get; set; }
        public string MedinceName { get; set; }
        public int MedicinePowerID { get; set; }
        public double MedicineQuantity { get; set; }
        public int MedicineMessureID { get; set; }
        public double SPrice { get; set; }
        public bool SoldInLoose { get; set; }
        public Decimal PackQuantity { get; set; }
        public int PackQuantityMessureID { get; set; }
        public int ReorderLevel { get; set; }
        public int CurrentStock { get; set; }
        public int MedicinePosologyQuantity { get; set; }
        public int MedinceQuantityMessure { get; set; }
        public int HowmanyTimesValue { get; set; }
        public int HowManyTimeMessure { get; set; }
        public int MedinceWhen { get; set; }
        public int TimeIntervel { get; set; }
        public int TimeIntervelMessure { get; set; }
        public int MedicineWith { get; set; }
        public int DayIntervel { get; set; }
        public bool EmergencySOS { get; set; }
        public bool EmergencyNow { get; set; }
        public bool KeepinFridge { get; set; }
        public bool InEye { get; set; }
        public bool InEar { get; set; }
        public bool InNose { get; set; }
        public bool InHairRoots { get; set; }
        public bool InMouthUlcers { get; set; }
        public bool ForGargil { get; set; }
        public int HowtoApply { get; set; }
        public string MedicineCode { get; set; }
        public string GenericName { get; set; }
        public string PosologyCheck { get; set; }
        public decimal NoofPackstoAdd { get; set; }
        public decimal NoofPackstoLess { get; set; }
        public DataTable dtAppointment { get; set; }

        public DateTime dtAppointmentDate = DateTime.Now;
    }
}
