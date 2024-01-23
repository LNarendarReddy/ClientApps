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
using log4net;
using DL;
using EL;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data.Filtering;

namespace EHR.Project
{
    public partial class frmSelectTestcases : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = new EProject();
        public frmSelectTestcases(EProject _objEProject)
        {
            InitializeComponent();
            objEProject = _objEProject;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               DataView dv = GetFilteredData(gvTestcase.Columns.View);
                objEProject.dtSelectedCases = dv.ToTable().Copy();
                DataTable dtTemp = objEProject.dtSelectedCases.Clone();
                foreach(DataColumn dc in dtTemp.Columns)
                {
                    if (dc.ColumnName != "TestcaseID")
                        objEProject.dtSelectedCases.Columns.Remove(dc.ColumnName);
                }
                objEProject.UserID = Utility.UserID;
                objDProject.SaveSelectedTestcases(objEProject);
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void frmSelectTestcases_Load(object sender, EventArgs e)
        {
            objDProject.GetTestcase(objEProject);
            gcTestcase.DataSource = objEProject.dtTestcase;
        }
        private DataView GetFilteredData(ColumnView view)
        {
            if (view == null) return null;
            if (view.ActiveFilter == null || !view.ActiveFilterEnabled
                || view.ActiveFilter.Expression == "")
                return view.DataSource as DataView;

            DataTable table = ((DataView)view.DataSource).Table;
            DataView filteredDataView = new DataView(table);
            filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(view.ActiveFilterCriteria);
            return filteredDataView;
        }
    }
}