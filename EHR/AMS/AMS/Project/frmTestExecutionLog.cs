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

namespace EHR.Project
{
    public partial class frmTestExecutionLog : DevExpress.XtraEditors.XtraForm
    {
        public frmTestExecutionLog(EProject objEProject)
        {
            InitializeComponent();
            gcChangeLog.DataSource = objEProject.dtTestExecutionLog;
        }
    }
}