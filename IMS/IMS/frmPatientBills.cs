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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IMS.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace IMS
{
    public partial class frmPatientBills : DevExpress.XtraEditors.XtraForm
    {
        DBilling ObjDBilling = new DBilling();
        EBilling ObjEBilling = new EBilling();
        public frmPatientBills()
        {
            InitializeComponent();
        }

        private void frmPatientBills_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEBilling = ObjDBilling.GetBills(ObjEBilling);
                gcBills.DataSource = ObjEBilling.dtBills;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvBills_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvBills.GetFocusedRowCellValue("BillID") != null
                        && int.TryParse(Convert.ToString(gvBills.GetFocusedRowCellValue("BillID")), out IValue))
                    {
                        rptPatient rpt = new Reports.rptPatient();
                        ReportPrintTool printTool = new ReportPrintTool(rpt);
                        rpt.Parameters["BillID"].Value = IValue;
                        rpt.ShowPreview();
                    }
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
                gcBills.ShowRibbonPrintPreview();
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

        private void btnClearDue_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int IValue = 0;
                if(int.TryParse(Convert.ToString(gvBills.GetFocusedRowCellValue("BillID")),out IValue))
                {
                    decimal due = 0;
                    decimal Paid = 0;
                    ObjEBilling.BillID = IValue;
                    ObjEBilling = ObjDBilling.ClearDue(ObjEBilling);
                    if(decimal.TryParse(Convert.ToString(gvBills.GetFocusedRowCellValue("Due")),out due) &&
                        decimal.TryParse(Convert.ToString(gvBills.GetFocusedRowCellValue("PaidTotal")),out Paid))
                    {
                        int i = gvBills.FocusedRowHandle;
                        decimal Total = Paid + due;
                        gvBills.SetRowCellValue(i, "PaidTotal", Total);
                        gvBills.SetRowCellValue(i, "Due", 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnViewbill_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int IValue = 0;
                if (gvBills.GetFocusedRowCellValue("BillID") != null
                    && int.TryParse(Convert.ToString(gvBills.GetFocusedRowCellValue("BillID")), out IValue))
                {
                    rptPatient rpt = new Reports.rptPatient();
                    ReportPrintTool printTool = new ReportPrintTool(rpt);
                    rpt.Parameters["BillID"].Value = IValue;
                    rpt.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}