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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace CMS
{
    public partial class frmDoctorAvailability : DevExpress.XtraEditors.XtraForm
    {
        EDoctor objEDoctor = new EDoctor();
        DDoctor objDDoctor = new DDoctor();
        int DoctorID;
        public frmDoctorAvailability(int nDoctorID)
        {
            InitializeComponent();
            DoctorID = nDoctorID;
            LoadDoctorAvailability();
        }
        private void LoadDoctorAvailability()
        {
            try
            {
                objEDoctor.DoctorID = DoctorID;
                objDDoctor.GetDoctorAvailability(objEDoctor);
                gridControl1.DataSource = objEDoctor.dtDoctorAvail;
                //RepositoryItemDateEdit riDateEdit = new RepositoryItemDateEdit();
                //gridControl1.RepositoryItems.Add(riDateEdit);
                //gridView1.Columns[0].ColumnEdit = riDateEdit;
                //gridView1.Columns[1].ColumnEdit = riDateEdit;
                gvDoctorAvail.AddNewRow();
            }
            catch (Exception ex) { }
        }

        private void gvDoctorAvail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["DoctorAvailabilityID"], -1);
            }
            catch (Exception ex) { }
        }

        private void gvDoctorAvail_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                objEDoctor.FromDate = Convert.ToDateTime(row["FromDate"]);
                objEDoctor.DoctorAvailabilityID = Convert.ToInt32(row["DoctorAvailabilityID"]);
                objEDoctor.BranchID = Utility.BranchID;
                objEDoctor.OrgID = Utility.OrgID;
                objEDoctor.UserID = Utility.UserID;
                objDDoctor.SaveDoctorAvailability(objEDoctor);
                row["DoctorAvailabilityID"] = objEDoctor.DoctorAvailabilityID;
            }
            catch (Exception ex) { }
        }

    }
}