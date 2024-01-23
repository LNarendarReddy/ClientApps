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
using InstituteMS.Report;

namespace InstituteMS
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
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

        private void btnCourseMaster_Click(object sender, EventArgs e)
        {
            frmCourse Obj = new frmCourse();
            ShowForm(Obj);
        }

        private void btnStudentMaster_Click(object sender, EventArgs e)
        {
            frmStudent Obj = new frmStudent();
            ShowForm(Obj);
        }

        private void btnFeesPayments_Click(object sender, EventArgs e)
        {

        }

        private void btnEmailConfiguration_Click(object sender, EventArgs e)
        {
            frmEmailConfiguration Obj = new frmEmailConfiguration();
            Obj.ShowDialog();
        }

        private void btnSMSConfiguration_Click(object sender, EventArgs e)
        {
            frmSMSConfiguration Obj = new frmSMSConfiguration();
            Obj.ShowDialog();
        }

        private void ShowForm(XtraForm Obj)
        {
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            if (Obj.Name == "frmStudent")
            {
                int frmWidth = this.ClientRectangle.Width - (this.ClientRectangle.Width / 3);
                int frmHeight = this.ClientRectangle.Height-20;
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
            if(Utility.UserName.ToLower() == "admin")
            {
                btnUserMaster.Visible = true;
                btnEmailConfiguration.Visible = true;
                btnSMSConfiguration.Visible = true;
            }
            if(Utility.OrgShortName == "RCC" || Utility.OrgShortName == "POLICE")
            {
                btnBookEntryReport.Visible = false;
                btnBookMaster.Visible = false;
                btnBookSaleReport.Visible = false;
                btnBookSales.Visible = false;
                btnBookStockReport.Visible = false;
                btnBookStockEntry.Visible = false;
            }
            this.Text = this.Text + " - " + Utility.OrgName;
            lblUser.Text = "Logged User : " + Utility.UserName;
            lblVersion.Text = $"Application Version : {Utility.AppVersion} (08-08-2022)";
        }

        private void btnDailyCollection_Click(object sender, EventArgs e)
        {
            frmDailyCollection Obj = new frmDailyCollection();
            ShowReport(Obj);
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            frmStudentReport Obj = new frmStudentReport();
            ShowReport(Obj);
        }

        private void btnDueReport_Click(object sender, EventArgs e)
        {
            frmDueReport Obj = new frmDueReport();
            ShowReport(Obj);
        }

        private void ShowReport(XtraForm Obj)
        {
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            int frmWidth = this.ClientRectangle.Width - 220;
            int frmHeight = this.ClientRectangle.Height-30;
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

        private void btbExpenses_Click(object sender, EventArgs e)
        {
            frmExpenses Obj = new frmExpenses();
            Obj.ShowDialog();
        }

        private void btnExpensesReport_Click(object sender, EventArgs e)
        {
            frmExpensesReport Obj = new frmExpensesReport();
            ShowReport(Obj);
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            frmChangePassword Obj = new frmChangePassword();
            Obj.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rptEnquiryReport_Click(object sender, EventArgs e)
        {
            frmEnquiryReport Obj = new frmEnquiryReport();
            ShowReport(Obj);
        }

        private void btnStudentEnquiry_Click(object sender, EventArgs e)
        {
            frmStudentEnquiry Obj = new frmStudentEnquiry();
            ShowForm(Obj);
        }

        private void btnBookMaster_Click(object sender, EventArgs e)
        {
            frmBookMaster Obj = new frmBookMaster();
            ShowForm(Obj);
        }

        private void btnBookStockEntry_Click(object sender, EventArgs e)
        {
            frmBookStockEntry Obj = new frmBookStockEntry();
            ShowForm(Obj);
        }

        private void btnBookSales_Click(object sender, EventArgs e)
        {
            frmBookSales Obj = new frmBookSales();
            ShowForm(Obj);
        }

        private void btnBookEntryReport_Click(object sender, EventArgs e)
        {
            frmBookEntryReport Obj = new frmBookEntryReport();
            ShowReport(Obj);
        }

        private void btnBookSaleReport_Click(object sender, EventArgs e)
        {
            frmBookSaleReport Obj = new frmBookSaleReport();
            ShowReport(Obj);
        }

        private void btnBookStockReport_Click(object sender, EventArgs e)
        {
            frmBookStockReport Obj = new frmBookStockReport();
            ShowReport(Obj);
        }
    }
}