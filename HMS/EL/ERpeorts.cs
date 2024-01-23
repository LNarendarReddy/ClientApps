using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ERpeorts
    {
        public int BranchID = 0;

        public int UserID = 0;

        public int DayCloseID = 0;

        public DataSet dsDailyCollectionReport = new DataSet();

        public DataTable dtDenominations = new DataTable();
    }
}
