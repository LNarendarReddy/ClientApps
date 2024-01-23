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
        public int StudentID = 0;
        public string FullName = string.Empty;
        public string CName = string.Empty;
        public string CNumber = string.Empty;
        public string AYear = string.Empty;
        public string Gender = string.Empty;
        public string EmailID = string.Empty;
        public int UserID = 0;
        public int BranchID = 0;
        public int OrgID = 0;
        public bool _IsContinue = false;
        public int EnquiryID = 0;

        public int StudentCourseMapID = -1;
        public int CourseID = 0;
        public int FeepaymentID = 0;
        public DateTime DueDate = DateTime.Now;
        public decimal Fees = 0;
        public decimal Balance = 0;
        public decimal Advance = 0;
        public string PaymentMode = string.Empty;
        public string Remarks = string.Empty;
        public int Medium = 0;
        public bool IDIssued = false;
        public bool MAIssued = false;
        public decimal Payment = 0;
        public string BNumber = string.Empty;
        public string Timings = string.Empty;
        public int Duration = 0;
        public Byte[] Imagedata = null;
        public int MainCourseID = 0;

        public DataTable dtStudent;
        public DataTable dtCourse;
        public DataTable dtPayment;
        public string Imagetype = string.Empty;

        public string course = string.Empty;
        public string fees_enquiry = string.Empty;
    }
}
