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
        private int _PatientID = -1;
        private string _PatientName = string.Empty;
        private string _MobileNumber = string.Empty;
        private int _Age = 0;
        private string _Gender = string.Empty;
        private string _Email = string.Empty;
        private string _CPerson1 = string.Empty;
        private string _CPMobile1 = string.Empty;
        private string _CPerson2 = string.Empty;
        private string _CPMobile2 = string.Empty;
        private string _AadhaarNumber = string.Empty;
        private int _UserID = 0;
        private DataTable _dtPatient = null;
        private DataTable _dtReport = null;
        private DataTable _dtPatientDetails = null;
        private DataTable _dtService = null;

        private int _ConsultationID = -1;
        private int _ServiceID = -1;
        private string _ServiceName = string.Empty;
        private decimal _Price = 0;

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
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string CPerson1
        {
            get { return _CPerson1; }
            set { _CPerson1 = value; }
        }
        public string CPMobile1
        {
            get { return _CPMobile1; }
            set { _CPMobile1 = value; }
        }
        public string CPerson2
        {
            get { return _CPerson2; }
            set { _CPerson2 = value; }
        }
        public string CPMobile2
        {
            get { return _CPMobile2; }
            set { _CPMobile2 = value; }
        }
        public string AadhaarNumber
        {
            get { return _AadhaarNumber; }
            set { _AadhaarNumber = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DataTable dtPatient
        {
            get { return _dtPatient; }
            set { _dtPatient = value; }
        }
        public DataTable dtReport
        {
            get { return _dtReport; }
            set { _dtReport = value; }
        }
        public DataTable dtPatientDetails
        {
            get { return _dtPatientDetails; }
            set { _dtPatientDetails = value; }
        }
        public DataTable dtService
        {
            get { return _dtService; }
            set { _dtService = value; }
        }

        public int ConsultationID
        {
            get { return _ConsultationID; }
            set { _ConsultationID = value; }
        }
        public int ServiceID
        {
            get { return _ServiceID; }
            set { _ServiceID = value; }
        }
        public string ServiceName
        {
            get { return _ServiceName; }
            set { _ServiceName = value; }
        }
        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
    }
}
