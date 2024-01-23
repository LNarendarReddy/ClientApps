using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EReports
    {
        public int BranchID = -1;
        public DataTable dtDailCollection = null;
        public DataTable dtStudentReport = null;
        public DataTable dtDueReport = null;
        public DataTable dtExpenses = null;
        public DataTable dtEnquiry = null;
        public DataTable dtDCR = null;
        public DateTime ColelctionDAte = DateTime.Now;
    }
}
