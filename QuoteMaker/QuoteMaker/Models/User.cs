using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Models
{
    public class User : EntityBase
    {
        public object USERID { get; set; }
        public object ROLEID { get; set; }
        public object USERNAME { get; set; }
        public object PASSWORDSTRING { get; set; }
        public object FULLNAME { get; set; }
        public object CNUMBER { get; set; }
        public object EMAIL { get; set; }
        public object ISOTP { get; set; }
        public object GENDER { get; set; }
        public object DOB { get; set; }

        public Dictionary<string, object> Params
        {
            get => Parameters();
        }
        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "USERID", USERID},
                { "ROLEID",  ROLEID},
                { "USERNAME", USERNAME},
                { "PASSWORDSTRING", PASSWORDSTRING},
                { "FULLNAME",  FULLNAME},
                { "CNUMBER", CNUMBER},
                { "EMAIL", EMAIL},
                { "GENDER", GENDER},
                { "DOB", DOB},
                {"CUSERID", UserID }
            };
        }
    }
}
