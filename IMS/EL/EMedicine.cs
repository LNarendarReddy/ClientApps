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
        private int _MedicineID = -1;
        private string _MedicineName = string.Empty;
        private int _CategoryID = 0;
        private string _CategoryName = string.Empty;
        private int _MID = 0;
        private string _MName = string.Empty;
        private int _UnitID = 0;
        private string _Unit = string.Empty;
        private int _ReOrderLevel = 0;
        private string _Location = string.Empty;
        private int _UserID = 0;
        private DataTable _dtMedicine = null;
        private DataTable _dtUnit = null;
        private DataTable _dtManufacturer = null;
        private DataTable _dtReOrderReport = null;
        private DataTable _dtPriceComparision = null;


        public int MedicineID
        {
            get{return _MedicineID;}
            set {_MedicineID = value;}
        }
        public string MedicineName
            {
                get { return _MedicineName; }
                set { _MedicineName = value; }
        }
        public int CategoryID
            {
                get { return _CategoryID; }
                set { _CategoryID = value; }
        }
        public string CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }
        public int MID
            {
                get { return _MID; }
                set { _MID = value; }
        }
        public string MName
            {
                get { return _MName; }
                set { _MName = value; }
        }
        public int UnitID
            {
                get { return _UnitID; }
                set { _UnitID = value; }
        }
        public string Unit
            {
                get { return _Unit; }
                set { _Unit = value; }
        }
        public int ReOrderLevel
            {
                get { return _ReOrderLevel; }
                set { _ReOrderLevel = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DataTable dtMedicine
        {
            get { return _dtMedicine; }
            set { _dtMedicine = value; }
        }
        public DataTable dtUnit
        {
            get { return _dtUnit; }
            set { _dtUnit = value; }
        }
        public DataTable dtManufacturer
        {
            get { return _dtManufacturer; }
            set { _dtManufacturer = value; }
        }
        public DataTable dtReOrderReport
        {
            get { return _dtReOrderReport; }
            set { _dtReOrderReport = value; }
        }
        public DataTable dtPriceComparision
        {
            get { return _dtPriceComparision; }
            set { _dtPriceComparision = value; }
        }
    }
}
