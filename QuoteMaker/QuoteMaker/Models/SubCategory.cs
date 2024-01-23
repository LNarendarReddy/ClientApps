using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Models
{
    public class SubCategory : EntityBase
    {
        public object SUBCATEGORYID { get; set; }
        public object SUBCATEGORYNAME { get; set; }
        public object CATEGORYID { get; set; }

        public Dictionary<string, object> Params
        {
            get => Parameters();
        }
        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "SUBCATEGORYID", SUBCATEGORYID},
                { "SUBCATEGORYNAME",  SUBCATEGORYNAME},
                { "CATEGORYID", CATEGORYID},
                { "USERID", UserID}
            };
        }
    }
}
