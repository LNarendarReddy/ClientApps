using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Models
{
    public class GST : EntityBase
    {
        public object GSTID { get; set; }
        public object GSTCODE { get; set; }
        public object CGST { get; set; }
        public object SGST { get; set; }
        public object IGST { get; set; }
        public object CESS { get; set; }

        public Dictionary<string, object> Params
        {
            get => Parameters();
        }
        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "GSTID", GSTID},
                { "GSTCODE",  GSTCODE},
                { "CGST", CGST},
                { "SGST",  SGST},
                { "IGST", IGST},
                { "GSTCCESSODE",  CESS},
                { "USERID", UserID}
            };
        }
    }
}
