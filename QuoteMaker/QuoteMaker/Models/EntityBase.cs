using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Models
{
    public abstract class EntityBase
    {
        public int UserID { get; set; }
        public bool IsSave { get; set; }
        protected abstract Dictionary<string, object> Parameters();
    }
}
