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
using DevExpress.XtraGrid;
using DevExpress.Data;
using log4net;
using DevExpress.XtraSplashScreen;

namespace EHR
{
    public partial class frmTaskEntry : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        ETimeSheet objETimeSheet = null;
        DTimeSheet objDTimeSheet = new DTimeSheet();
        int IValue = 0;
        public frmTaskEntry(ETimeSheet _objETimeSheet)
        {
            objETimeSheet = _objETimeSheet;
            InitializeComponent();
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                objDTimeSheet.GetTaskMaster(objETimeSheet);

                cmbTask.Properties.DataSource = objETimeSheet.dtTask;
                cmbTask.Properties.ValueMember = "TaskID";
                cmbTask.Properties.DisplayMember = "TaskDescription";


                cmbSubTask.Properties.DataSource = objETimeSheet.dtSubTask;
                cmbSubTask.Properties.ValueMember = "SubTaskID";
                cmbSubTask.Properties.DisplayMember = "SubTaskDescription";
                cmbSubTask.CascadingOwner = cmbTask;
                cmbSubTask.Properties.CascadingMember = "TaskID";

                cmbWorkType.Properties.DataSource = objETimeSheet.dtWorkType;
                cmbWorkType.Properties.ValueMember = "WorkTypeID";
                cmbWorkType.Properties.DisplayMember = "WorkTypedescription";
                cmbWorkType.CascadingOwner = cmbSubTask;
                cmbWorkType.Properties.CascadingMember = "SubTaskID";
                objDTimeSheet.GetTodayHours(objETimeSheet);
                string stHours = Convert.ToString(objETimeSheet.TodayHours / 60).PadLeft(2, '0');
                string stMins = Convert.ToString(objETimeSheet.TodayHours % 60).PadLeft(2, '0');
                txtTotalHours.EditValue = stHours + ":" + stMins;
                txtTaskHours.EditValue = "00:00";
                if (!objETimeSheet.IsEdit)
                {
                    objETimeSheet.dtEmployeeTask = new DataTable();
                    objETimeSheet.dtEmployeeTask.Columns.Add("TaskID", typeof(int));
                    objETimeSheet.dtEmployeeTask.Columns.Add("SubTaskID", typeof(int));
                    objETimeSheet.dtEmployeeTask.Columns.Add("WorkTypeID", typeof(int));
                    objETimeSheet.dtEmployeeTask.Columns.Add("Hours", typeof(int));
                    objETimeSheet.dtEmployeeTask.Columns.Add("EmployeeTaskDescription", typeof(string));
                    objETimeSheet.dtEmployeeTask.Columns.Add("TaskDescription", typeof(string));
                    objETimeSheet.dtEmployeeTask.Columns.Add("SubTaskDescription", typeof(string));
                    objETimeSheet.dtEmployeeTask.Columns.Add("WorkTypedescription", typeof(string));
                    objETimeSheet.dtEmployeeTask.Columns.Add("stHours", typeof(string));
                    gcTaskManagement.DataSource = objETimeSheet.dtEmployeeTask;
                    txtRemainingHours.EditValue = stHours + ":" + stMins;
                }
                else
                {
                    objDTimeSheet.GetEmployeeTaskByID(objETimeSheet);
                    gcTaskManagement.DataSource = objETimeSheet.dtEmployeeTask;
                    IValue = objETimeSheet.Taskmins;
                    string stHours1 = Convert.ToString((objETimeSheet.TodayHours - objETimeSheet.Taskmins) / 60).PadLeft(2, '0');
                    string stMins1 = Convert.ToString((objETimeSheet.TodayHours - objETimeSheet.Taskmins) % 60).PadLeft(2, '0');
                }
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void frmTaskEntry_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbTask_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSubTask.EditValue = null;
                cmbWorkType.EditValue = null;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                DataRow drnew = objETimeSheet.dtEmployeeTask.NewRow();
                drnew["TaskID"] = cmbTask.EditValue;
                drnew["SubTaskID"] = cmbSubTask.EditValue;
                drnew["WorkTypeID"] = cmbWorkType.EditValue;
                drnew["TaskDescription"] = cmbTask.Text;
                drnew["SubTaskDescription"] = cmbSubTask.Text;
                drnew["WorkTypedescription"] = cmbWorkType.Text;
                drnew["EmployeeTaskDescription"] = txtTaskDescription.Text;
                drnew["stHours"] = txtTaskHours.Text;

                string []stMinutes = txtTaskHours.Text.Split(':');

                int Ivalue = 0;
                int TMinutes = 0;
                if (int.TryParse(stMinutes[0], out Ivalue))
                {
                    TMinutes = Ivalue * 60;
                    if (int.TryParse(stMinutes[1], out Ivalue))
                        TMinutes += Ivalue;
                }
                if (TMinutes <= 0)
                    return;
                drnew["Hours"] = TMinutes;
                objETimeSheet.dtEmployeeTask.Rows.Add(drnew);
                gcTaskManagement.DataSource = objETimeSheet.dtEmployeeTask;
                cmbTask.EditValue = null;
                txtTaskDescription.Text = string.Empty;
                txtTaskHours.EditValue = "00:00";
                cmbTask.Focus();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvTaskManagement.FocusedRowHandle >= 0)
                    gvTaskManagement.DeleteRow(gvTaskManagement.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void gvTaskManagement_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                // Initialization. 
                if (e.SummaryProcess == CustomSummaryProcess.Start)
                {
                    IValue = 0;
                }
                // Calculation.
                if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                {
                    int TMinutes = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Hours"));
                    IValue += TMinutes;
                }
                // Finalization. 
                if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                {
                    string stHours = Convert.ToString(IValue / 60).PadLeft(2,'0');
                    string stMins = Convert.ToString(IValue % 60).PadLeft(2, '0');
                    e.TotalValue = stHours + ":" + stMins;

                    string stHours1 = Convert.ToString((objETimeSheet.TodayHours - IValue) / 60).PadLeft(2, '0');
                    string stMins1 = Convert.ToString((objETimeSheet.TodayHours - IValue) % 60).PadLeft(2, '0');
                    txtRemainingHours.EditValue = stHours1 + ":" + stMins1;

                }
            }
            catch (Exception  ex){ Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (objETimeSheet.TodayHours != IValue)
                    throw new Exception("Total hours not matching with logged hours");
                objETimeSheet._IsSave = true;
                if (objETimeSheet.IsEdit)
                {
                    DataTable dtTemp = objETimeSheet.dtEmployeeTask.Clone();
                    foreach (DataColumn dc in dtTemp.Columns)
                    {
                        if (dc.ColumnName == "TaskDescription" || dc.ColumnName == "SubTaskDescription" ||
                            dc.ColumnName == "WorkTypedescription" || dc.ColumnName == "stHours")
                            objETimeSheet.dtEmployeeTask.Columns.Remove(dc.ColumnName);
                    }
                    objDTimeSheet.SaveEmployeeTask(objETimeSheet);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void gvTaskManagement_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if(e.Column.FieldName == "stHours")
                {
                    string st = Convert.ToString(e.Value);
                    if(!string.IsNullOrEmpty(st))
                    {
                        int IHrs = 0,IMins = 0;
                        int TOtalMins = 0;
                        string[] stvalues = st.Split(':');
                        if(int.TryParse(stvalues[0],out IHrs) && int.TryParse(stvalues[1], out IMins))
                        {
                            int OldMins = 0;
                            if (int.TryParse(Convert.ToString(objETimeSheet.dtEmployeeTask.Rows[e.RowHandle]["Hours"]), out OldMins))
                            {
                                TOtalMins = IHrs * 60;
                                TOtalMins += IMins;
                                objETimeSheet.dtEmployeeTask.Rows[e.RowHandle]["Hours"] = TOtalMins;

                                int newMins = (IValue - OldMins) + TOtalMins;
                                string stHours1 = Convert.ToString((objETimeSheet.TodayHours - newMins) / 60).PadLeft(2, '0');
                                string stMins1 = Convert.ToString((objETimeSheet.TodayHours - newMins) % 60).PadLeft(2, '0');
                                txtRemainingHours.EditValue = stHours1 + ":" + stMins1;
                                IValue = newMins;
                            }
                        }
                    }
                }
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); Utility.ShowError(ex);}
        }
    }
}