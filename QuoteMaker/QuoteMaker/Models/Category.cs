using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace QuoteMaker.Models
{
    public class Category : EntityBase
    {
        public object CATEGORYID { get; set; }
        public object CATEGORYNAME { get; set; }

        public Dictionary<string, object> Params
        {
            get => Parameters(); 
        }
        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "CATEGORYID", CATEGORYID},
                { "CATEGORYNAME",  CATEGORYNAME},
                { "USERID", UserID}
            };
        }
    }
}
