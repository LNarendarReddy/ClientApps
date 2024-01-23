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

namespace HMS
{
    public partial class frmItemCategory : DevExpress.XtraEditors.XtraForm
    {
        EItem ObjEItem = new EItem();
        DItem ObjDItem = new DItem();
        public frmItemCategory()
        {
            InitializeComponent();
        }

        private void frmItemCategory_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEItem.BranchID = Utility.BranchID;
                ObjDItem.GetItemCategory(ObjEItem);
                gcItemCategory.DataSource = ObjEItem.dtItemCategory;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void gvItemCategory_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["ItemCategoryID"], -1);
            }
            catch (Exception ex){}
        }

        private void gvItemCategory_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                ObjEItem.CategoryName = Convert.ToString(row["CategoryName"]);
                ObjEItem.ItemCategoryID = Convert.ToInt32(row["ItemCategoryID"]);
                ObjEItem.BranchID = Utility.BranchID;
                ObjEItem.OrgID = Utility.OrgID;
                ObjEItem.UserID = Utility.UserID;
                ObjDItem.SaveItemCategory(ObjEItem);
                row["ItemCategoryID"] = ObjEItem.ItemCategoryID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}