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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.CustomEditor;
using EL;
using DL;

namespace PMS
{
    public partial class frmSearchPatient : DevExpress.XtraEditors.XtraForm
    {
        EPatient Objepatient = new EPatient();
        DPatient ObjdPatient = new DPatient();
        public frmSearchPatient()
        {
            InitializeComponent();
        }
        BindingSource bSource = new BindingSource();
        private void frmSearchPatient_Load(object sender, EventArgs e)
        {
            try
            {
                Binddata();
            }
            catch (Exception ex) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmNewPatient objfrm = new frmNewPatient(-1);
            objfrm.ShowDialog();
            Binddata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Convert.ToInt32(gvSearchPatient.GetFocusedRowCellValue(gdPatientID));
                frmNewPatient Obj = new frmNewPatient(PatientID);
                Obj.IsEdit = true;
                Obj.MdiParent = this.MdiParent;
                Obj.StartPosition = FormStartPosition.Manual;
                Obj.Location = new Point(0, 0);
                Obj.Show();
            }
            catch (Exception ex){}
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Convert.ToInt32(gvSearchPatient.GetFocusedRowCellValue(gdPatientID));
                frmPatientHistory Obj = new frmPatientHistory(PatientID);
                Obj.MdiParent = this.MdiParent;
                Obj.Show();
            }
            catch (Exception ex){}
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Convert.ToInt32(gvSearchPatient.GetFocusedRowCellValue(gdPatientID));
                frmBookAppointment Obj = new frmBookAppointment(PatientID);
                Obj.MdiParent = this.MdiParent;
                Obj.Show();
            }
            catch (Exception ex){}
        }

        private void Binddata()
        {
            try
            {
                Objepatient.BranchID = Utility.BranchID;
                ObjdPatient.GetPatientDetails(Objepatient);
                gdSearchpatient.DataSource = Objepatient.dtPatientDetails;
            }
            catch (Exception ex){}
        }
    }
}