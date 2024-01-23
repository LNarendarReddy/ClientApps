using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EStudent
    {
        public int StudentID = -1;
        public object AdmissionNumber;
        public object FullName;
        public object CNumber1;
        public object CNumber2;
        public object Gender;
        public object RFID;
        public object UserID = 0;
        public object Amount = 0;
        public object TType;
        public object Remarks;
        public int TransactionID = -1;
        public Byte[] Imagedata = null;
        public DataTable dtStudent;
        public DataTable dtPayment;
        public DataTable dtReport;
        public string Imagetype = string.Empty;
        public bool _IsContinue = false;
        public object Grade;
        public object Section;
        public object FatherName;
    }
}
