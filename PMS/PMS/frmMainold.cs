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
using DevExpress.Skins.XtraForm;
using DevExpress.Skins;
using EL;

namespace PMS
{
    public partial class frmMainold : DevExpress.XtraEditors.XtraForm
    {
        public frmMainold()
        {
            InitializeComponent();
        }

        private void btnOrganizationMaster_Click(object sender, EventArgs e)
        {
            frmOrgMaster Obj = new frmOrgMaster();
            ShowForm(Obj);
        }

        private void btnBranchMaster_Click(object sender, EventArgs e)
        {
            frmBranch Obj = new frmBranch();
            ShowForm(Obj);
        }

        private void btnUserMaster_Click(object sender, EventArgs e)
        {
            EUser ObjEUser = new EUser();
            ObjEUser.BranchID = Utility.BranchID;
            ObjEUser.OrganizationID = Utility.OrgID;
            frmUser Obj = new frmUser(ObjEUser);
            ShowForm(Obj);
        }

        private void btnEmailConfiguration_Click(object sender, EventArgs e)
        {
            frmEmailConfiguration Obj = new frmEmailConfiguration();
            Obj.Show();
        }

        private void btnSMSConfiguration_Click(object sender, EventArgs e)
        {
            frmSMSConfiguration Obj = new frmSMSConfiguration();
            Obj.Show();
        }

        private void ShowForm(XtraForm Obj)
        {
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            if (Obj.Name == "frmStudent")
            {
                int frmWidth = this.ClientRectangle.Width - (this.ClientRectangle.Width / 3);
                int frmHeight = this.ClientRectangle.Height - 20;
                Obj.Size = new Size(frmWidth, frmHeight);
            }

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (fc != null)
                {
                    if (frm.Name == Obj.Name)
                    {
                        frm.Close();
                        break;
                    }
                }
            }
            Obj.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            if (Utility.UserName.ToLower() == "admin" && Utility.Password == "776986")
            {
                btnOrganizationMaster.Visible = true;
                btnBranchMaster.Visible = true;
            }
            if (Utility.UserName.ToLower() == "admin")
            {
                btnUserMaster.Visible = true;
                btnEmailConfiguration.Visible = true;
                btnSMSConfiguration.Visible = true;
            }
            this.Text = this.Text + " - " + Utility.OrgName;
            lblUser.Text = "Logged User : " + Utility.UserName;
        }

        private void ShowReport(XtraForm Obj)
        {
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            int frmWidth = this.ClientRectangle.Width - 220;
            int frmHeight = this.ClientRectangle.Height - 30;
            Obj.Size = new Size(frmWidth, frmHeight);
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (fc != null)
                {
                    if (frm.Name == Obj.Name)
                    {
                        frm.Close();
                        break;
                    }
                }
            }
            Obj.Show();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://gyanasoft.com/");
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            frmChangePassword Obj = new frmChangePassword();
            Obj.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPatientMaster_Click(object sender, EventArgs e)
        {
            frmSearchPatient obj = new frmSearchPatient();
            obj.Show();
        }
        private void btnDoctorMaster_Click(object sender, EventArgs e)
        {
            frmDoctorsMaster obj = new frmDoctorsMaster();
            obj.Show();
        }
        private void btnInvestigationMaster_Click(object sender, EventArgs e)
        {
            frmCategory obj = new frmCategory();
            obj.Show();
        }

        private void btnMedicineMaster_Click(object sender, EventArgs e)
        {
            frmMedicine Obj = new frmMedicine(0);
            Obj.Show();
        }

        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            frmStockUpdate Obj = new frmStockUpdate();
            Obj.Show();
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            frmTreatment Obj = new frmTreatment(true,0);
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void btnPatientHistory_Click(object sender, EventArgs e)
        {
            frmPatientHistory Obj = new frmPatientHistory(-1);
            Obj.MdiParent = this;
            Obj.Show();
        }
    }
}