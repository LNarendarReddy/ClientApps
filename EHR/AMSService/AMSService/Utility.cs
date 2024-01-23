using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSService
{
    public static class Utility
    {
        public static string stParagraphBoldstart = "<p style=\"font-family:Bahnschrift Light; font-size:100%; font-weight:bold;\">";
        public static string stParagraphstart = "<p style=\"font-family:Bahnschrift Light; font-size:80%; font-weight:regular;\">";
        public static string stParagraphend = "</p>";


        public static string stTableStart = "<table border = 1 cellpadding = 3 cellspacing= 0 width = 800>";
        public static string stTableEnd = "</table>";
        public static string stTableHeaderStart = "<tr style=\"background-color:#E7EEEC; font-family:Bahnschrift Light; font-size:100%; font-weight:bold;\">";
        public static string stRowStart = "<tr style=\"font-family:Bahnschrift Light; font-size:80%; font-weight:regular;\">";
        public static string stRowEnd = "</tr>";
        public static string stCellHeaderLeftStart = "<th style =\"text-align:left;\">";
        public static string stCellHeaderCenterStart = "<th style =\"text-align:center; \">";
        public static string stCellHeaderEnd = "</th>";
        public static string stCellRowLeftStart = "<td style =\"text-align:left;\">";
        public static string stCellRowCenterStart = "<td style =\"text-align:center;\">";
        public static string stCellRowEnd = "</td>";

        public static string stMailIDs = string.Empty;
        public static string timeString = string.Empty;
    }
}
