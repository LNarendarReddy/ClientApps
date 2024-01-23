using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EDoctor
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string qualification { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AlternatePhone { get; set; }
        public int UserID { get; set; }
        public int DoctorID { get; set; }
        public int BranchID { get; set; }
        public int OrgID { get; set; }
        public DateTime AvialableDate { get; set; }
        public DataTable dtDoctor { get; set; }
        public object DoctorAvailabilityID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DataTable dtDoctorAvail { get; set; }

        public object NAmeHindi = string.Empty;

        public object QualificationHindi = string.Empty;
    }
}
