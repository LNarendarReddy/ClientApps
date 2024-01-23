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
using log4net;
using DL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace EHR.User
{
    public partial class frmUserList : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        EUser ObjEUser = null;
        DUser ObjDUser = new DUser();
        public frmUserList(EUser _ObjEUser)
        {
            InitializeComponent();
            ObjEUser = _ObjEUser;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUser obj = new frmUser(ObjEUser);
            ObjEUser.UserInfoID = -1;
            obj.ShowInTaskbar = false;
            obj.IconOptions.ShowIcon = false;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.ShowDialog();
            ObjDUser.GetUser(ObjEUser);
            gcUser.DataSource = ObjEUser.dtUser;
            Utility.Setfocus(gvUser, "UserInfoID", ObjEUser.UserInfoID);

        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DepartmentID", typeof(int));
                dt.Columns.Add("Department", typeof(string));
                DataRow dr1 = dt.NewRow();
                dr1["DepartmentID"] = 1;
                dr1["Department"] = "Developement";
                dt.Rows.Add(dr1);

                DataRow dr2 = dt.NewRow();
                dr2["DepartmentID"] = 2;
                dr2["Department"] = "QA";
                dt.Rows.Add(dr2);

                DataRow dr3 = dt.NewRow();
                dr3["DepartmentID"] = 3;
                dr3["Department"] = "CRM";
                dt.Rows.Add(dr3);

                DataRow dr4 = dt.NewRow();
                dr4["DepartmentID"] = 4;
                dr4["Department"] = "HR";
                dt.Rows.Add(dr4);

                repositoryItemLookUpEdit1.DataSource = dt;
                repositoryItemLookUpEdit1.DisplayMember = "Department";
                repositoryItemLookUpEdit1.ValueMember = "DepartmentID";


                ObjDUser.GetUser(ObjEUser);
                gcUser.DataSource = ObjEUser.dtUser;
            }
            catch (Exception ex){}
        }

        private void gvUser_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvUser.GetFocusedRowCellValue("UserInfoID") != null
                        && int.TryParse(Convert.ToString(gvUser.GetFocusedRowCellValue("UserInfoID")), out IValue))
                    {
                        ObjEUser.UserInfoID = IValue;
                        ObjEUser.UserName = Convert.ToString(gvUser.GetFocusedRowCellValue("UserName"));
                        ObjEUser.FullName = Convert.ToString(gvUser.GetFocusedRowCellValue("FullName"));
                        ObjEUser.CNumber = Convert.ToString(gvUser.GetFocusedRowCellValue("CNumber"));
                        ObjEUser.Email = Convert.ToString(gvUser.GetFocusedRowCellValue("EMail"));
                        ObjEUser.RoleID = gvUser.GetFocusedRowCellValue("RoleID");
                        ObjEUser.DesignationID = gvUser.GetFocusedRowCellValue("DesignationID");
                        ObjEUser.ReportingLeadID = gvUser.GetFocusedRowCellValue("ReportingLeadID");
                        ObjEUser.gender = gvUser.GetFocusedRowCellValue("Gender");
                        ObjEUser.JoiningDate = gvUser.GetFocusedRowCellValue("JoingDate");
                        ObjEUser.DOB = gvUser.GetFocusedRowCellValue("DOB");
                        ObjEUser.DepartmentID = gvUser.GetFocusedRowCellValue("DepatmentID");
                        ObjEUser.EmployeeStatus = gvUser.GetFocusedRowCellValue("EmployeeStatus");
                        ObjEUser.EnableAssessment = gvUser.GetFocusedRowCellValue("EnableAssessmnet");
                        ObjEUser.ResignationDate = gvUser.GetFocusedRowCellValue("ResignationDate");
                        ObjEUser.ProjectedLastWorkingDate = gvUser.GetFocusedRowCellValue("ProjectedLastWorkingDate");
                        ObjEUser.ActualLastWorkingDate = gvUser.GetFocusedRowCellValue("ActualLastWorkingDate");
                        frmUser obj = new frmUser(ObjEUser);
                        obj.ShowInTaskbar = false;
                        obj.IconOptions.ShowIcon = false;
                        obj.StartPosition = FormStartPosition.CenterScreen;
                        obj.ShowDialog();
                        ObjDUser.GetUser(ObjEUser);
                        gcUser.DataSource = ObjEUser.dtUser;
                        Utility.Setfocus(gvUser, "UserInfoID", ObjEUser.UserInfoID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcUser.ShowRibbonPrintPreview();
        }
    }
}