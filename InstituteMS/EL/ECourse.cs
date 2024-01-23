using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ECourse
    {
        public int CourseID = 0;
        public int BranchID = 0;
        public int OrgID = 0;
        public int Duration = 0;
        public decimal Fees = 0;
        public string Name = string.Empty;
        public string ShortName = string.Empty;
        public string FullAddress = string.Empty;
        public string CPerson = string.Empty;
        public string CNumber = string.Empty;
        public int UserID = 0;

        public int MainCourseID = 0;
        public string MainCourseName = string.Empty;

        public DataTable dtCourse;
        public DataTable dtMainCourse;
    }
}
