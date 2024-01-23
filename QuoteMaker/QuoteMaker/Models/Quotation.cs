using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Models
{
    public class Quotation: EntityBase
    {
        public int QUOTATIONID { get; set; }
        public object CUSTOMERNAME { get; set; }
        public  object CUSTOMERNUMBER { get; set; }
        public object CUSTOMERADDRESS { get; set; }
        public decimal OVERALLDISCFLAT { get; set; }
        public DataTable dataTable { get; set; }

        public Dictionary<string, object> Params 
        { 
            get => Parameters(); 
        }

        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "QUOTATIONID", QUOTATIONID},
                { "CUSTOMERNAME",  CUSTOMERNAME},
                { "CUSTOMERNUMBER", CUSTOMERNUMBER},
                { "CUSTOMERADDRESS",  CUSTOMERADDRESS},
                { "OVERALLDISCFLAT", OVERALLDISCFLAT},
                { "USERID", UserID}
            };
        }
    }
}
