using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EItem
    {
        public int ItemCategoryID { get; set; }
        public int OrgID { get; set; }
        public int BranchID { get; set; }
        public int UserID { get; set; }
        public string CategoryName { get; set; }
        public DataTable dtItemCategory { get; set; }
        public DataTable dtItemList { get; set; }
        public DataTable dtItems { get; set; }

        public int ItemID = 0;

        public int BillID = 0;

        public int PaymentMode = 0;
        public bool IsService = false;
        public string ItemCode { get; set; }

        public object NewBillNumber = null;
        public string ItemName { get; set; }
        public double SPrice { get; set; }
        public double ServicePrice { get; set; }
        public int ReorderLevel { get; set; }
        public int Quantity { get; set; }

        public int CuurrentStock { get; set; }
    }
}
