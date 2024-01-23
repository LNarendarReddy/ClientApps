using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EAccount
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public DataTable dtIncome { get; set; }
        public DataTable dtExpenses { get; set; }
    }
}
