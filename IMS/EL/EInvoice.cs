using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EInvoice
    {
        private int _InvoiceID = -1;
        private int _MedicineID = -1;
        private int _BatchNoID = -1;
        private int _DistributorID = 0;
        private string _InvoiceNumber = string.Empty;
        private DateTime _InvoiceDate;
        private int _UserID = 0;
        private decimal _GrandTotal = 0;
        private decimal _CGST = 0;
        private decimal _SGST = 0;
        private decimal _Paid = 0;
        private decimal _Due = 0;
        private string _ImagePath = string.Empty;
        private int _PaymentMode = -1;
        private string _Remarks = string.Empty;

        private DataTable _dtStockEntry = null;
        private DataTable _dtBatchNumber = null;
        private DataTable _dtBatchDetails = null;
        private DataTable _dtInvoices = null;
        private DataTable _dtInvoiceDetails = null;
        private DataSet _dsInvoices = null;

        private byte[] _ImageData = null;

        public int InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; }
        }
        public int MedicineID
        {
            get { return _MedicineID; }
            set { _MedicineID = value; }
        }
        public int BatchNoID
        {
            get { return _BatchNoID; }
            set { _BatchNoID = value; }
        }
        public int DistributorID
        {
            get { return _DistributorID; }
            set { _DistributorID = value; }
        }
        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
        }
        public DateTime InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public decimal GrandTotal
        {
            get { return _GrandTotal; }
            set { _GrandTotal = value; }
        }
        public decimal CGST
        {
            get { return _CGST; }
            set { _CGST = value; }
        }
        public decimal SGST
        {
            get { return _SGST; }
            set { _SGST = value; }
        }
        public decimal Paid
        {
            get { return _Paid; }
            set { _Paid = value; }
        }
        public decimal Due
        {
            get { return _Due; }
            set { _Due = value; }
        }
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        public int PaymentMode
        {
            get { return _PaymentMode; }
            set { _PaymentMode = value; }
        }

        public DataTable dtStockEntry
        {
            get { return _dtStockEntry; }
            set { _dtStockEntry = value; }
        }
        public DataTable dtBatchNumber
        {
            get { return _dtBatchNumber; }
            set { _dtBatchNumber = value; }
        }
        public DataTable dtBatchDetails
        {
            get { return _dtBatchDetails; }
            set { _dtBatchDetails = value; }
        }
        public DataTable dtInvoices
        {
            get { return _dtInvoices; }
            set { _dtInvoices = value; }
        }
        public DataTable dtInvoiceDetails
        {
            get { return _dtInvoiceDetails; }
            set { _dtInvoiceDetails = value; }
        }
        public DataSet dsInvoices
        {
            get { return _dsInvoices; }
            set { _dsInvoices = value; }
        }
        public byte[] ImageData
        {
            get { return _ImageData; }
            set { _ImageData = value; }
        }
    }
}
