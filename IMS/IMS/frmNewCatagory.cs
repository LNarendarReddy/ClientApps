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
using DevExpress.XtraGrid;

namespace IMS
{
    public partial class frmNewCatagory : DevExpress.XtraEditors.XtraForm
    {
        ECategory ObjECategory = new ECategory();
        DCategory ObjDCategory = new DCategory();
        List<Control> Requirefields = new List<Control>();

        public frmNewCatagory()
        {
            InitializeComponent();
        }

        private void frmNewCatagory_Load(object sender, EventArgs e)
        {
            try
            {
                Requirefields.Add(txtCategoryName);
                ObjECategory = ObjDCategory.GetCategory(ObjECategory);
                gcCategory.DataSource = ObjECategory.dtCategory;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(Requirefields))
                    return;
                ObjECategory.CategoryName = txtCategoryName.Text.Trim();
                ObjECategory.UserID = Utility.UserID;
                ObjECategory = ObjDCategory.SaveCategory(ObjECategory);
                gcCategory.DataSource = ObjECategory.dtCategory;
                Utility.Setfocus(gvCategory, "CategoryID", ObjECategory.CategoryID);
                txtCategoryName.Text = string.Empty;
                ObjECategory.CategoryID = -1;
                txtCategoryName.Focus();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = string.Empty;
            ObjECategory.CategoryID = -1;
        }

        private void frmNewCatagory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                btnCancel_Click(null, null);
            }
        }

        private void gvCategory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                   int IValue = 0;
                   if (gvCategory.GetFocusedRowCellValue("CategoryID") != null
                       && int.TryParse(Convert.ToString(gvCategory.GetFocusedRowCellValue("CategoryID")), out IValue))
                   {
                       ObjECategory.CategoryID = IValue;
                       txtCategoryName.Text = Convert.ToString(gvCategory.GetFocusedRowCellValue("CategoryName"));
                   }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gcCategory_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                var grid = sender as GridControl;
                var view = grid.FocusedView as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int IValue = 0;
                    if (gvCategory.GetFocusedRowCellValue("CategoryID") != null
                        && int.TryParse(Convert.ToString(gvCategory.GetFocusedRowCellValue("CategoryID")), out IValue))
                    {
                        var dlgresult = XtraMessageBox.Show("You Want to delete Category..?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dlgresult.ToString().ToLower() == "ok")
                        {
                            ObjECategory.CategoryID = IValue;
                            ObjECategory = ObjDCategory.DeleteCategory(ObjECategory);
                            gvCategory.DeleteSelectedRows();
                            ObjECategory.CategoryID = -1;
                        }
                    }
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}