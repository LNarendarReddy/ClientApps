using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ECategory
    {
        private int _CategoryID = -1;
        private string _CategoryName = string.Empty;
        private int _UserID = 0;
        private DataTable _dtCategory = null;

        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
        public string CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DataTable dtCategory
        {
            get { return _dtCategory; }
            set { _dtCategory = value; }
        }
    }
}
