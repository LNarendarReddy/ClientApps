using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EPrinter
    {
        public int UserID = -1;
        public object PrinterID = null;
        public object PrinterType = null;
        public object PrinterName = null;
        public DataTable dtPrinters = null;
        public DataTable dtPrinterType = null;
        public int PrinterSettingsID = 0;
    }
}
