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

        public DataTable dtDailyCollectionReport = new DataTable();

        public DateTime AppointmentDate = DateTime.Now;
        public object FromID = 0;
        public object ToID = 0;
    }
}
