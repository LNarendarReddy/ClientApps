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
    public partial class frmVoucherCategory : DevExpress.XtraEditors.XtraForm
    {
        EVoucher ObjEVoucher = new EVoucher();
        DVoucher ObjDVoucher = new DVoucher();
        public frmVoucherCategory()
        {
            InitializeComponent();
        }
        
        private void frmItemCategory_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEVoucher.BranchID = Utility.BranchID;
                ObjDVoucher.GetVoucherCategory(ObjEVoucher);
                gcItemCategory.DataSource = ObjEVoucher.dtVoucherCategory;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void gvItemCategory_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["VoucherCategoryID"], -1);
            }
            catch (Exception ex){}
        }

        private void gvItemCategory_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                ObjEVoucher.CategoryName = Convert.ToString(row["CategoryName"]);
                ObjEVoucher.VoucherCategoryID = Convert.ToInt32(row["VoucherCategoryID"]);
                ObjEVoucher.BranchID = Utility.BranchID;
                ObjEVoucher.OrgID = Utility.OrgID;
                ObjEVoucher.UserID = Utility.UserID;
                ObjDVoucher.SaveVoucherCategory(ObjEVoucher);
                row["VoucherCategoryID"] = ObjEVoucher.VoucherCategoryID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}