using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EBook
    {
        public DataTable dtBook = null;
        public int BookInfoID = -1;
        public string BookName = string.Empty;
        public string AuthorName = string.Empty;
        public int CategoryID = 0;
        public int UserID = 0;
        public int OrgID = 0;
        public int BranchID = 0;

        public int BillID = 0;
        public int Quantity = 0;
        public int StudentID = 0;
        public string StudentName = string.Empty;
        public string StudentMobile = string.Empty;
    }
}
