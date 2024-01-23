using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EL;
using DL;
using static PMS.Utility;

namespace PMS
{
    public partial class frmPrinterMaster : DevExpress.XtraEditors.XtraForm
    {
        EPrinter ObjEPrinter = null;
        DPrinter ObjDPrinter = null;

        public frmPrinterMaster()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSAve_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEPrinter.UserID = Utility.UserID;
                ObjEPrinter.PrinterID = cmbPrinterType.EditValue;
                ObjEPrinter.PrinterType = cmbPrinterType.Text;
                ObjEPrinter.PrinterName =  cmbPrinterName.Text;
                ObjDPrinter.SavePrinter(ObjEPrinter);
                gcPrinters.DataSource = ObjEPrinter.dtPrinters;
                Utility.Setfocus(gvPrinters, "PrinterSettingsID", Convert.ToInt32(ObjEPrinter.PrinterSettingsID));
                switch (cmbPrinterType.Text)
                {
                    case "NewSmallPrint":
                        PrintersType.NewSmallPrint = cmbPrinterName.Text;
                        break;
                    case "NewBigPrint":
                        PrintersType.NewBigPrint = cmbPrinterName.Text;
                        break;
                    case "Treatment":
                        PrintersType.TreatmentPrint = cmbPrinterName.Text;
                        break;
                    default:
                        break;
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void frmPrinterMaster_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Utility.UserName;
            if (ObjEPrinter == null)
                ObjEPrinter = new EPrinter();
            if (ObjDPrinter == null)
                ObjDPrinter = new DPrinter();
            ObjDPrinter.GetPrinterType(ObjEPrinter);
            cmbPrinterType.Properties.DataSource = ObjEPrinter.dtPrinterType;
            cmbPrinterType.Properties.DisplayMember  = "PrinterType";
            cmbPrinterType.Properties.ValueMember = "PrinterID";
            btnDetect_Click(null, null);
            ObjEPrinter.UserID = Utility.UserID;
            ObjDPrinter.GetPrinters(ObjEPrinter);
            gcPrinters.DataSource = ObjEPrinter.dtPrinters;
        }
        private void ClearFields()
        {
            cmbPrinterType.EditValue = null;
            cmbPrinterName.EditValue = null;
            ObjEPrinter.PrinterSettingsID = -1;
            cmbPrinterType.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ivalue = 0;
               if(gvPrinters.FocusedRowHandle >= 0 && int.TryParse(Convert.ToString(gvPrinters.GetFocusedRowCellValue("PrinterSettingsID")),out ivalue))
                {
                    ObjEPrinter.PrinterSettingsID = ivalue;
                    cmbPrinterType.EditValue = gvPrinters.GetFocusedRowCellValue("PrinterID");
                    cmbPrinterName.EditValue = gvPrinters.GetFocusedRowCellValue("PrinterName");
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private DataTable BindPrinterType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PrinterID", typeof(int));
            dt.Columns.Add("PrinterType", typeof(string));

            List<string> l = new List<string>();
            l.Add("NewSmallPrint");
            l.Add("NewBigPrint");
            l.Add("DuplicatePrint");
            l.Add("Samjawan");
            l.Add("JumboList");
            l.Add("History");
            DataRow dr = null;
            int i = 0;
            foreach(string s in l)
            {
                i++;
                dr = dt.NewRow();
                dr["PrinterID"] = i;
                dr["PrinterType"] = s;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private void btnDetect_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> l = new List<string>();
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    l.Add(printer);
                }
                cmbPrinterName.Properties.DataSource = l;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}