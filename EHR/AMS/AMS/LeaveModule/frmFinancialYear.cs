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
using log4net;

namespace EHR
{
    public partial class frmFinancialYear : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        public frmFinancialYear()
        {
            InitializeComponent();
        }

        private void frmFinancialYear_Load(object sender, EventArgs e)
        {
            try
            {
                objDLeave.GetFYear(objELeave);
                gcFYear.DataSource = objELeave.dtFYear;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void gvFYear_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["FYearID"], -1);
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }

        private void gvFYear_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                objELeave.FYearID = Convert.ToString(row["FYearID"]);
                objELeave.FromDate = row["FromDate"];
                objELeave.ToDate = row["ToDate"];
                objELeave.EnableAssessment = row["EnableAssessment"];
                objDLeave.SaveFYear(objELeave);
                gcFYear.DataSource = objELeave.dtFYear;
                Utility.Setfocus(gvFYear, "FYearID", objELeave.FYearID);
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }
    }
}