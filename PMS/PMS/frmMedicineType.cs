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

namespace PMS
{
    public partial class frmMedicineType : DevExpress.XtraEditors.XtraForm
    {
        EMedicine ObjEMedicine = new EMedicine();
        DMedicine ObjDMedicine = new DMedicine();
        public frmMedicineType()
        {
            InitializeComponent();
        }

        private void frmMedicineType_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjDMedicine.GetMedicineType(ObjEMedicine);
                gcMedicineType.DataSource = ObjEMedicine.dtMedicineType;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void gvMedicineType_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["MedicineTypeID"], -1);
            }
            catch (Exception ex){}
        }

        private void gvMedicineType_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                ObjEMedicine.MedicineType = Convert.ToString(row["TypeName"]);
                ObjEMedicine.MedicineTypeID = Convert.ToInt32(row["MedicineTypeID"]);
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjEMedicine.OrgID = Utility.OrgID;
                ObjEMedicine.UserID = Utility.UserID;
                ObjDMedicine.SaveMedicineType(ObjEMedicine);
                row["MedicineTypeID"] = ObjEMedicine.MedicineTypeID;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}