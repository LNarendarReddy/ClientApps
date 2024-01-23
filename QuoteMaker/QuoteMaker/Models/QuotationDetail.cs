using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Models
{
    public class QuotationDetail : EntityBase
    {
        public int QUOTATIONDETAILID { get; set; }
        public int QUOTATIONID { get; set; }
        public int ITEMPRICEID { get; set; }
        public decimal DISCPER { get; set; }
        public decimal DISCFLAT { get; set; }
        public int QUANTITY { get; set; }
        public Decimal DISCOUNTPER { get; set; }
        public Decimal DISCOUNTFLAT { get; set; }
        public Decimal TOTALDISCOUNT { get; set; }
        public Decimal NETPRICE { get; set; }

        public Decimal GST { get; set; }

        public Dictionary<string, object> Params
        {
            get => Parameters();
        }
        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "QUOTATIONDETAILID", QUOTATIONDETAILID},
                { "QUOTATIONID",  QUOTATIONID},
                { "ITEMPRICEID", ITEMPRICEID},
                { "DISCPER",  DISCPER},
                { "DISCFLAT", DISCFLAT},
                { "USERID", UserID}
            };
        }
    }
}
