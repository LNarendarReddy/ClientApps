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
using DL;
using EL;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace IMS
{
    public partial class frmInvoiceBills : DevExpress.XtraEditors.XtraForm
    {
        DInvoice ObjDInvoice = new DInvoice();
        EInvoice ObjEInvoice = new EInvoice();
        public frmInvoiceBills()
        {
            InitializeComponent();
        }

        private void frmInvoiceBills_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEInvoice = ObjDInvoice.GetInvoices(ObjEInvoice);
                if (ObjEInvoice.dsInvoices != null)
                {
                    DataColumn keyColumn = ObjEInvoice.dsInvoices.Tables[0].Columns["InvoiceID"];
                    DataColumn foreignKeyColumn = ObjEInvoice.dsInvoices.Tables[1].Columns["InvoiceID"];
                    ObjEInvoice.dsInvoices.Relations.Add("InvoicePayments", keyColumn, foreignKeyColumn);
                    gcInvoices.DataSource = ObjEInvoice.dsInvoices.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                gcInvoices.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvInvoices.GetFocusedRowCellValue("InvoiceID")), out IValue))
                {
                    ObjEInvoice.InvoiceID = IValue;
                    ObjEInvoice = ObjDInvoice.GetInvoiceImage(ObjEInvoice);
                    if (!string.IsNullOrEmpty(ObjEInvoice.ImagePath))
                    {
                        if (File.Exists(ObjEInvoice.ImagePath))
                        {
                            Process.Start(ObjEInvoice.ImagePath);
                            ObjEInvoice.ImagePath = string.Empty;
                        }
                        else
                        {
                            ObjEInvoice.ImagePath = string.Empty;
                            throw new Exception("File Does not exists on Disk");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnPayment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int IValue = 0;
                decimal DValue = 0;
                if (int.TryParse(Convert.ToString(gvInvoices.GetFocusedRowCellValue("InvoiceID")), out IValue))
                {
                    ObjEInvoice.InvoiceID = IValue;
                    ObjEInvoice.InvoiceNumber = Convert.ToString(gvInvoices.GetFocusedRowCellValue("InvoiceNumber"));
                    if (decimal.TryParse(Convert.ToString(gvInvoices.GetFocusedRowCellValue("InvoiceTotal")), out DValue))
                        ObjEInvoice.GrandTotal = DValue;
                    if (decimal.TryParse(Convert.ToString(gvInvoices.GetFocusedRowCellValue("Due")), out DValue))
                        ObjEInvoice.Due = DValue;
                    if (ObjEInvoice.Due > 0)
                    {
                        frmPayment obj = new frmPayment(ObjEInvoice);
                        obj.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnViewinvoice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int IValue = 0;
                    if (gvInvoices.GetFocusedRowCellValue("InvoiceID") != null
                        && int.TryParse(Convert.ToString(gvInvoices.GetFocusedRowCellValue("InvoiceID")), out IValue))
                    {
                        frmStockEntry Obj = new frmStockEntry();
                        Obj._IsLoad = true;
                        Obj._InvoiceID = IValue;
                        Obj.StartPosition = FormStartPosition.CenterParent;
                        Obj.ShowDialog();
                    }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}