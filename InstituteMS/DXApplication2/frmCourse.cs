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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace InstituteMS
{
    public partial class frmCourse : DevExpress.XtraEditors.XtraForm
    {
        ECourse ObjECourse = new ECourse();
        DCourse ObjDCourse = new DCourse();
        public frmCourse()
        {
            InitializeComponent();
        }
        private void frmCourse_Load(object sender, EventArgs e)
        {
            try
            {
                ObjECourse.BranchID = Utility.BranchID;
                ObjDCourse.GetCourse(ObjECourse);
                gcCourse.DataSource = ObjECourse.dtCourse;

                ObjDCourse.GetMainCourse(ObjECourse);
                ObjECourse.dtMainCourse.TableName = "MainCourse";
                cmbMainCourse.Properties.DataSource = ObjECourse.dtMainCourse;
                cmbMainCourse.Properties.DisplayMember = "Name";
                cmbMainCourse.Properties.ValueMember = "MainCourseID";
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                NameTextEdit.Text = NameTextEdit.Text.Trim();
                txtShortName.Text = txtShortName.Text.Trim();
                FeesTextEdit.Text = FeesTextEdit.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                decimal DValue = 0;
                ObjECourse.Name = NameTextEdit.Text;
                ObjECourse.Duration = 0;
                ObjECourse.ShortName = txtShortName.Text;
                ObjECourse.MainCourseName = cmbMainCourse.Text;
                int IValue = -1;
                if (int.TryParse(Convert.ToString(cmbMainCourse.EditValue), out IValue))
                    ObjECourse.MainCourseID = IValue;
                else
                    ObjECourse.MainCourseID = IValue;

                ObjECourse.ShortName = txtShortName.Text;
                if (decimal.TryParse(Convert.ToString(FeesTextEdit.EditValue), out DValue))
                    ObjECourse.Fees = DValue;
                ObjECourse.OrgID = Utility.OrgID;
                ObjECourse.BranchID = Utility.BranchID;
                ObjDCourse.SaveCourse(ObjECourse);
                gcCourse.DataSource = ObjECourse.dtCourse;
                Utility.Setfocus(gvCourse, "CourseID", ObjECourse.CourseID);
                btnReset_Click(null, null);
            }
            catch (Exception ex) { Utility.ShowError(ex); }   
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjECourse.CourseID = -1;
            NameTextEdit.Text = string.Empty;
            FeesTextEdit.Text = string.Empty;
            cmbMainCourse.Enabled = true;
            txtShortName.Enabled = false;
            cmbMainCourse.Focus();
        }
        private void gvCourse_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvCourse.GetFocusedRowCellValue("CourseID") != null
                        && int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("CourseID")), out IValue))
                    {
                        ObjECourse.CourseID = IValue;
                        NameTextEdit.Text = Convert.ToString(gvCourse.GetFocusedRowCellValue("Name"));
                        txtShortName.Text = Convert.ToString(gvCourse.GetFocusedRowCellValue("ShortName"));
                        FeesTextEdit.Text = Convert.ToString(gvCourse.GetFocusedRowCellValue("Fees"));
                        cmbMainCourse.EditValue = gvCourse.GetFocusedRowCellValue("MainCourseID");
                        cmbMainCourse.Enabled = false;
                        txtShortName.Enabled = false;
                    }
                }
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }
        private void cmbMainCourse_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                DataRow Row;
                RepositoryItemLookUpEdit Edit;
                Edit = ((LookUpEdit)sender).Properties;
                if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                    return;
                DataTable LookupTable = (DataTable)cmbMainCourse.Properties.DataSource;
                DataRow[] dr = LookupTable.Select("MainCourseID= -1");
                foreach (DataRow row in dr)
                    LookupTable.Rows.Remove(row);
                Row = LookupTable.NewRow();
                Row["MainCourseID"] = -1;
                Row["Name"] = e.DisplayValue;
                txtShortName.Text = string.Empty;
                txtShortName.Enabled = true;
                LookupTable.Rows.Add(Row);
                e.Handled = true;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void cmbMainCourse_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                if (editor.EditValue != null)
                {
                    DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                    txtShortName.Text = Convert.ToString(row["ShortName"]);
                }
                else
                {
                    txtShortName.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnDeleteCourse_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if(gvCourse.FocusedRowHandle>= 0)
                {
                    if(int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("CourseID")),out ObjECourse.CourseID))
                    {
                         ObjDCourse.DeleteCourse(ObjECourse);
                    }
                }
            }
            catch (Exception ex)
            {

                Utility.ShowError(ex);
            }
        }
    }
}