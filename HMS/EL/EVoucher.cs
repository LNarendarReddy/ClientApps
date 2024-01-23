using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EVoucher
    {
        public int VoucherID = 0;
        public object VoucherNumber = 0;
        public object Amount = 0;
        public object recievedBy = string.Empty;
        public object Purpose = string.Empty;
        public int UserID = 0;
        public DataTable dtList = new DataTable();

        public int VoucherCategoryID = 0;
        public string CategoryName = string.Empty;
        public int BranchID = 0;
        public int OrgID = 0;
        public DataTable dtVoucherCategory = new DataTable();
        public DataTable dtPersonNames = new DataTable();
    }
}
