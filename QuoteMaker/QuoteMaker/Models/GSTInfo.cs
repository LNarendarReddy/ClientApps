using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Models
{
    public class GSTInfo
    {
        public int GSTID { get; set; }
        public string GSTCODE { get; set; }
        public decimal CGST { get; set; }
        public decimal SGST { get; set; }
        public decimal IGST { get; set; }
        public decimal CESS { get; set; }
        public decimal TAXPercent { get; private set; }

        public void UpdateGST(DataRow dr)
        {
            GSTID = Convert.ToInt32(dr["GSTID"]);
            GSTCODE = Convert.ToString(dr["GSTCODE"]);
            CGST = Convert.ToDecimal(dr["CGST"]);
            SGST = Convert.ToDecimal(dr["SGST"]);
            IGST = Convert.ToDecimal(dr["IGST"]);
            CESS = Convert.ToDecimal(dr["CESS"]);
            TAXPercent = Math.Round((CGST + SGST + CESS) / 100, 3);

        }
        public void UpdateGST(DataRowView dr)
        {
            UpdateGST(dr.Row);
        }
    }
}
