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
using DevExpress.XtraEditors.Controls;

namespace PMS
{
    public partial class frmDoctorsMaster : DevExpress.XtraEditors.XtraForm
    {
        EDoctor objEDoctor = new EDoctor();
        DDoctorMaster objDDoctor = new DDoctorMaster();
        public frmDoctorsMaster()
        {
            InitializeComponent();
            LoadTitle();
            objEDoctor.BranchID = Utility.BranchID;
            objDDoctor.GetDoctorMaster(objEDoctor);
            DataTable dtDoctor = new DataTable();
            dtDoctor = objEDoctor.dtDoctor;
            gdDoctorMaster.DataSource = dtDoctor;
        }
        void riButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

        }
        private void LoadTitle()
        {
            try
            {
                DataTable dtTitle = new DataTable();
                dtTitle.Columns.Add("Title", typeof(string));

                DataRow dr = dtTitle.NewRow();
                dr["Title"] = "Mr.";
                dtTitle.Rows.Add(dr);
                DataRow dr1 = dtTitle.NewRow();
                dr1["Title"] = "Mrs.";
                dtTitle.Rows.Add(dr1);
                DataRow dr2 = dtTitle.NewRow();
                dr2["Title"] = "Ms.";
                dtTitle.Rows.Add(dr2);


                cmbTitle.Properties.DataSource = dtTitle;
                cmbTitle.Properties.DisplayMember = "Title";
                cmbTitle.Properties.ValueMember = "Title";
            }
            catch (Exception ex) { }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                objEDoctor.Title = cmbTitle.EditValue.ToString();
                objEDoctor.Name = txtName.Text.Trim();
                objEDoctor.Age = Convert.ToInt16(txtAge.Text.Trim());
                objEDoctor.qualification = txtQualification.Text.Trim();
                objEDoctor.Address = txtAddress.Text.Trim();
                objEDoctor.Email = txtEmail.Text.Trim();
                objEDoctor.Phone = txtPhone.Text.Trim();
                objEDoctor.AlternatePhone = txtAlternatePhone.Text.Trim();
                objEDoctor.UserID = Utility.UserID;
                objEDoctor.BranchID = Utility.BranchID;
                objEDoctor.OrgID = Utility.OrgID;
                objEDoctor.NAmeHindi = txtNameHindi.EditValue;
                objEDoctor.QualificationHindi = txtQualificationHindi.EditValue;
                objDDoctor.SaveDoctorMaster(objEDoctor);
                gdDoctorMaster.DataSource = objEDoctor.dtDoctor;
                ClearFields();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void ClearFields()
        {
            objEDoctor.DoctorID = -1;
            cmbTitle.EditValue = -1;
            txtName.EditValue = null;
            txtAge.EditValue = null;
            txtQualification.EditValue = null;
            txtAddress.EditValue = null;
            txtEmail.EditValue = null;
            txtPhone.EditValue = null;
            txtAlternatePhone.EditValue = null;
            txtNameHindi.EditValue = null;
            txtQualificationHindi.EditValue = null;
        }
        private void riButton_Click(object sender, EventArgs e)
        {
            int visibleRowHandle = gvDoctorMaster.FocusedRowHandle;
            frmDoctorAvailability Obj = new frmDoctorAvailability(Convert.ToInt32(gvDoctorMaster.GetRowCellValue(visibleRowHandle, gdDoctorID)));
            Obj.MdiParent = this.MdiParent;
            Obj.StartPosition = FormStartPosition.Manual;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void gvDoctorMaster_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int nDoctorID = Convert.ToInt32(gvDoctorMaster.GetFocusedRowCellValue("DoctorID"));                
            }
            catch (Exception ex) { }
        }

        private void frmDoctorsMaster_Load(object sender, EventArgs e)
        {

        }
    }
}