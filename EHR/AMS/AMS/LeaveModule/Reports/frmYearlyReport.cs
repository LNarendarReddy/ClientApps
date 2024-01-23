﻿using System;
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
using log4net;

namespace EHR.LeaveModule.Reports
{
    public partial class frmYearlyReport : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        public frmYearlyReport()
        {
            InitializeComponent();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcLeaveBalance.ShowRibbonPrintPreview();
        }

        private void frmYearlyReport_Load(object sender, EventArgs e)
        {
            try
            {
                objDLeave.GetFYear(objELeave);
                cmbFYear.Properties.DataSource = objELeave.dtFYear;
                cmbFYear.Properties.ValueMember = "FYearID";
                cmbFYear.Properties.DisplayMember = "FYearName";
                DataTable table = cmbFYear.Properties.DataSource as DataTable;
                foreach (DataRow dr in table.Rows)
                {
                    if (Convert.ToInt16(dr["Selected"]) == 1)
                    {
                        cmbFYear.EditValue = dr["FYearID"];
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void cmbFYear_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                objELeave.FYearID = cmbFYear.EditValue;
                objDLeave.GetYearlyReport(objELeave);
                gcLeaveBalance.DataSource = objELeave.dtLeaveBalance;
                gcFullName.Caption = "Employee Name";
                gcFullName.GroupIndex = 0;
                gcFullName.Visible = false;
                gvLeaveBalance.ExpandAllGroups();
                gvLeaveBalance.ViewCaption = "Leave Report as on : " + DateTime.Now.ToString("dd/MM/yyyy") +
                    " For the financial year : " + cmbFYear.Text;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
    }
}