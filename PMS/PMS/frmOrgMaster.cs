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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using EL;
using DL;
using DevExpress.DataAccess.Sql;
using PMS.Properties;

namespace PMS
{
    public partial class frmOrgMaster : DevExpress.XtraEditors.XtraForm
    {
        EUser ObjEUser = new EUser();
        EStudent ObjEStudent = new EStudent();
        public frmOrgMaster()
        {
            InitializeComponent();
        }

        private void frmOrgMaster_Load(object sender, EventArgs e)
        {
            try
            {
                EUser objEUser = new EUser();
                DUser objDUser = new DUser();
                objDUser.GetOrganization(objEUser);
                gcOrg.DataSource = objEUser.dtOrg;
            }
            catch (Exception ex){}
        }

        private void gvOrg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvOrg.GetFocusedRowCellValue("OrgID") != null
                        && int.TryParse(Convert.ToString(gvOrg.GetFocusedRowCellValue("OrgID")), out IValue))
                    {
                        ObjEUser.OrganizationID = IValue;
                        ObjEUser.FullName = Convert.ToString(gvOrg.GetFocusedRowCellValue("FullName"));
                        ObjEUser.ShortName = Convert.ToString(gvOrg.GetFocusedRowCellValue("ShortName"));
                        ObjEUser.FullAddress = Convert.ToString(gvOrg.GetFocusedRowCellValue("FullAddress"));
                        ObjEUser.CNumber = Convert.ToString(gvOrg.GetFocusedRowCellValue("CNumber"));
                        ObjEUser.STNumber = Convert.ToString(gvOrg.GetFocusedRowCellValue("STNumber"));
                        DateTime dt = DateTime.Now;
                        if (DateTime.TryParse(Convert.ToString(gvOrg.GetFocusedRowCellValue("ExpiryDate")), out dt))
                            ObjEUser.Exdate = dt;
                        else
                            ObjEUser.Exdate = dt;
                        frmOrganization Obj = new frmOrganization(ObjEUser);
                        Obj.Show();
                        if(Obj.IsContinue)
                        {
                            gcOrg.DataSource = ObjEUser.dtOrg;
                            Utility.Setfocus(gvOrg, "OrgID", ObjEUser.OrganizationID);
                            ObjEUser.OrganizationID = -1;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEUser.OrganizationID = -1;
                frmOrganization Obj = new frmOrganization(ObjEUser);
                Obj.Show();
                if (Obj.IsContinue)
                {
                    gcOrg.DataSource = ObjEUser.dtOrg;
                    Utility.Setfocus(gvOrg, "OrgID", ObjEUser.OrganizationID);
                    ObjEUser.OrganizationID = -1;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnOrginalLogo_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (gvOrg.GetFocusedRowCellValue("OrgID") != null
                    && int.TryParse(Convert.ToString(gvOrg.GetFocusedRowCellValue("OrgID")), out IValue))
                {
                    ObjEStudent = new EStudent();
                    ObjEStudent.OrgID = IValue;
                    ObjEStudent.Imagetype = "OL";
                    frmViewImage Obj = new frmViewImage(ObjEStudent);
                    Obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void btnShortLogo_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (gvOrg.GetFocusedRowCellValue("OrgID") != null
                    && int.TryParse(Convert.ToString(gvOrg.GetFocusedRowCellValue("OrgID")), out IValue))
                {
                    ObjEStudent = new EStudent();
                    ObjEStudent.OrgID = IValue;
                    ObjEStudent.Imagetype = "OS";
                    frmViewImage Obj = new frmViewImage(ObjEStudent);
                    Obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void btnGenerateEText_Click(object sender, EventArgs e)
        {
            txtEText.Text = Utility.Encrypt(txtPlaintext.Text);
        }

        private void btnGeneratePlainText_Click(object sender, EventArgs e)
        {
            txtPlaintext.Text = Utility.Decrypt(txtEText.Text);
        }
    }
}