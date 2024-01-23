using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class frmParent : DevExpress.XtraEditors.XtraForm
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            timer1.Start();
        }

        private void bnNewCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNewCatagory Obj = new frmNewCatagory();
            Obj.MdiParent = this;
            Obj.Location = new Point(0,0);
            Obj.Show();
        }

        private void nbNewDistributor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDistributor Obj = new frmDistributor();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbAddPatient_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPatient Obj = new frmPatient();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbNewMedicine_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMedicine Obj = new frmMedicine();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbBilling_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBilling Obj = new frmBilling();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbStockEntry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStockEntry Obj = new frmStockEntry();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbPatientBills_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPatientBills Obj = new frmPatientBills();
            ShowForm(Obj);
        }

        private void nbInvoice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInvoiceBills Obj = new frmInvoiceBills();
            ShowForm(Obj);
        }

        private void nbCurrentStock_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMedicineStock Obj = new frmMedicineStock();
            ShowForm(Obj);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsTime.Text = DateTime.Now.ToString();
        }

        private void nbReOrderReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReOrderReport Obj = new frmReOrderReport();
            ShowForm(Obj);
        }

        private void nbPriceComparision_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPriceComparision Obj = new frmPriceComparision();
            ShowForm(Obj);
        }

        private void nbConsultation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultation Obj = new frmConsultation();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbConsultationReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultationReport Obj = new frmConsultationReport();
            ShowForm(Obj);
        }

        private void nbNewUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmUser Obj = new frmUser();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbExpenses_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmExpenses Obj = new frmExpenses();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void nbExpensesReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmExpensesReport Obj = new frmExpensesReport();
            ShowForm(Obj);
        }

        private void nbResetPassword_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmResetPassword Obj = new frmResetPassword();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void ShowForm(XtraForm Obj)
        {
            Obj.MdiParent = this;
            int frmWidth = this.ClientRectangle.Width - 228;
            int frmHeight = this.ClientRectangle.Height - 26;
            Obj.Location = new Point(0, 0);
            Obj.Size = new Size(frmWidth, frmHeight);
            Obj.Show();
        }

        private void bOrganization_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmOrganization Obj = new frmOrganization();
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.Manual;
            Obj.Location = new Point(0, 0);
            Obj._OpenState = true;
            Obj.Show();
        }

        private void nbAccount_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAccount Obj = new frmAccount();
            Obj.MdiParent = this;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }
    }
}
