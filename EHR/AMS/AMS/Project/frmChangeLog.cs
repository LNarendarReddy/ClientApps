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

namespace EHR.Project
{
    public partial class frmChangeLog : DevExpress.XtraEditors.XtraForm
    {
        EProject objEProject = null;
        DProject objDProject = new DProject();
        public frmChangeLog(EProject _objEProject)
        {
            InitializeComponent();
            objEProject = _objEProject;
            gcChangeLog.DataSource = objEProject.dtChangeLog;
        }

        private void frmChangeLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void btnViewChanges_Click(object sender, EventArgs e)
        {
            if (gvChangeLog.FocusedRowHandle < 0)
                return;
            if (Convert.ToInt32(objEProject.Type) == 1 ||
                Convert.ToInt32(objEProject.Type) == 2 ||
                Convert.ToInt32(objEProject.Type) == 3)
            {
                objEProject.ID = gvChangeLog.GetFocusedRowCellValue("ID");
                objDProject.GetChanges(objEProject);
                if(objEProject.dtChanges != null &&
                    objEProject.dtChanges.Rows.Count > 0)
                {
                    frmChanges obj = new frmChanges(Convert.ToString(objEProject.dtChanges.Rows[0][0]));
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.IconOptions.ShowIcon = false;
                    obj.ShowDialog();
                }

            }
            else if (Convert.ToInt32(objEProject.Type) == 4)
            {
                objEProject.ID = gvChangeLog.GetFocusedRowCellValue("ID");
                objDProject.GetChanges(objEProject);
                if (objEProject.dtChanges != null &&
                    objEProject.dtChanges.Rows.Count > 0)
                {
                    frmTestcaseChanges obj = new frmTestcaseChanges(Convert.ToString(objEProject.dtChanges.Rows[0][0]),
                        Convert.ToString(objEProject.dtChanges.Rows[0][1]));
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.IconOptions.ShowIcon = false;
                    obj.ShowDialog();
                }
            }
        }
    }
}