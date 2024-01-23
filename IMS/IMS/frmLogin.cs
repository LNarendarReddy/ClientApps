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
using DL;
using EL;

namespace IMS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        DUser ObjDUser = new DUser();
        EUser ObjEUser = new EUser();
        List<Control> RequireFields = new List<Control>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(RequireFields))
                    return;
                string CDate = DateTime.Now.ToString("MM/dd/yyyy");
                if (Convert.ToDateTime(CDate) >= Convert.ToDateTime("07/02/2019"))
                {
                    string str1 = RandomString(31);
                    throw new Exception(str1 + "\n\rPlease contact your administrator");
                }
                ObjEUser.UserName = txtUserName.Text.Trim().ToLower();
                ObjEUser.Password = txtPassword.Text;
                ObjEUser = ObjDUser.GetUserCredentials(ObjEUser);
                string str = Convert.ToString(ObjEUser.dtUser.Rows[0][0]);
                int IValue = 0;
                if (int.TryParse(str, out IValue))
                {
                    Utility.UserID = IValue;
                    Utility.UserName = Convert.ToString(ObjEUser.dtUser.Rows[0]["UserName"]);
                    Utility.UserFullName = Convert.ToString(ObjEUser.dtUser.Rows[0]["UserFullName"]);
                    Utility.Password = Convert.ToString(ObjEUser.dtUser.Rows[0]["Password"]);
                    this.Hide();
                    //if (ObjEUser.dtOrg.Rows.Count > 0)
                    //{
                    //    Utility.Name = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Name"]);
                    //    Utility.ContactNumber = Convert.ToString(ObjEUser.dtOrg.Rows[0]["ContactNumber"]);
                    //    Utility.GSTIN = Convert.ToString(ObjEUser.dtOrg.Rows[0]["GSTIN"]);
                    //    Utility.Hno = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Hno"]);
                    //    Utility.Street = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Street"]);
                    //    Utility.District = Convert.ToString(ObjEUser.dtOrg.Rows[0]["District"]);
                    //    Utility.City = Convert.ToString(ObjEUser.dtOrg.Rows[0]["City"]);
                    //    Utility.State = Convert.ToString(ObjEUser.dtOrg.Rows[0]["State"]);
                    //    Utility.Country = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Country"]);
                    //    Utility.PinCode = Convert.ToString(ObjEUser.dtOrg.Rows[0]["PinCode"]);
                    //    frmParent Obj = new frmParent();
                    //    Obj.ShowDialog();
                    //}
                    //else
                    //{
                    //    frmOrganization Obj = new frmOrganization();
                    //    Obj.ShowDialog();   
                    //    if(Obj._Save)
                    //    {
                            frmParent ObjParent = new frmParent();
                            ObjParent.ShowDialog();
                        //}
                    //}
                    this.Close();
                }
                else
                    throw new Exception(str);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            RequireFields.Add(txtUserName);
            RequireFields.Add(txtPassword);   
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(null, null);
        }
    }
}