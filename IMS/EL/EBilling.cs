using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EBilling
    {
        private int _BillID = -1;
        private int _PatientID = 0;
        private string _PatientName = string.Empty;
        private string _MobileNumber = string.Empty;
        private decimal _GrandTotal = 0;
        private decimal _NetTotal = 0;
        private decimal _Discount = 0;
        private decimal _PaidTotal = 0;
        private decimal _Due = 0;
        private int _UserID = 0;
        private DataTable _dtBilling = null;
        private DataTable _dtBills = null;


        public int BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }
        public int PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        public string PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value; }
        }
        public string MobileNumber
        {
            get { return _MobileNumber; }
            set { _MobileNumber = value; }
        }
        public decimal GrandTotal
        {
            get { return _GrandTotal; }
            set { _GrandTotal = value; }
        }
        public decimal NetTotal
        {
            get { return _NetTotal; }
            set { _NetTotal = value; }
        }
        public decimal Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }
        public decimal PaidTotal
        {
            get { return _PaidTotal; }
            set { _PaidTotal = value; }
        }
        public decimal Due
        {
            get { return _Due; }
            set { _Due = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DataTable dtBilling
        {
            get { return _dtBilling; }
            set { _dtBilling = value; }
        }
        public DataTable dtBills
        {
            get { return _dtBills; }
            set { _dtBills = value; }
        }
    }
}
