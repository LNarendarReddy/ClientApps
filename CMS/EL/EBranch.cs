using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EBranch
    {
        public int OrgID { get; set; }
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string FullAddress { get; set; }
        public string CPerson { get; set; }
        public string CNumber { get; set; }

        public object HindiAddress = string.Empty;
        public int UserID { get; set; }
        public DataTable dtBranch { get; set; }
    }
}
