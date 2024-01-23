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
using System.IO;
using System.Drawing.Imaging;

namespace IMS
{
    public partial class frmOrganization : DevExpress.XtraEditors.XtraForm
    {
        DUser ObjDUser = new DUser();
        EUser ObjEUser = new EUser();
        public bool _Save = false;
        public bool _OpenState = false;
        List<Control> RequireFields = new List<Control>();
        public frmOrganization()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEUser.Name = NameTextEdit.Text;
                ObjEUser.ContactNumber = ContactNumberTextEdit.Text;
                ObjEUser.GSTIN = GSTINTextEdit.Text;
                ObjEUser.Hno = HnoTextEdit.Text;
                ObjEUser.Street = StreetTextEdit.Text;
                ObjEUser.City = CityTextEdit.Text;
                ObjEUser.District = DistrictTextEdit.Text;
                ObjEUser.State = StateTextEdit.Text;
                ObjEUser.Country = CountryTextEdit.Text;
                ObjEUser.PinCode = PinCodeTextEdit.Text;
                ObjEUser = ObjDUser.SaveOrganization(ObjEUser);
                if (ObjEUser.dtOrg != null && ObjEUser.dtOrg.Rows.Count > 0)
                {
                    Utility.Name = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Name"]);
                    Utility.ContactNumber = Convert.ToString(ObjEUser.dtOrg.Rows[0]["ContactNumber"]);
                    Utility.GSTIN = Convert.ToString(ObjEUser.dtOrg.Rows[0]["GSTIN"]);
                    Utility.Hno = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Hno"]);
                    Utility.Street = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Street"]);
                    Utility.District = Convert.ToString(ObjEUser.dtOrg.Rows[0]["District"]);
                    Utility.City = Convert.ToString(ObjEUser.dtOrg.Rows[0]["City"]);
                    Utility.State = Convert.ToString(ObjEUser.dtOrg.Rows[0]["State"]);
                    Utility.Country = Convert.ToString(ObjEUser.dtOrg.Rows[0]["Country"]);
                    Utility.PinCode = Convert.ToString(ObjEUser.dtOrg.Rows[0]["PinCode"]);

                    Bitmap bm = new Bitmap(pictureEdit1.Image);
                    if (bm != null)
                        bm.Save("Logo.png", ImageFormat.Bmp);
                    else
                        throw new Exception("Error While saveing Organization Details");

                    _Save = true;
                    if (!_OpenState)
                        this.Close();
                }
                else
                    throw new Exception("Error While saveing Organization Details");
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void frmOrganization_Load(object sender, EventArgs e)
        {
            try
            {
                RequireFields.Add(NameTextEdit);
                RequireFields.Add(ContactNumberTextEdit);
                RequireFields.Add(GSTINTextEdit);

                NameTextEdit.Text = Utility.Name;
                ContactNumberTextEdit.Text = Utility.ContactNumber;
                GSTINTextEdit.Text = Utility.GSTIN;
                HnoTextEdit.Text = Utility.Hno;
                StreetTextEdit.Text = Utility.Street;
                CityTextEdit.Text = Utility.City;
                DistrictTextEdit.Text = Utility.District;
                StateTextEdit.Text = Utility.State;
                CountryTextEdit.Text = Utility.Country;
                PinCodeTextEdit.Text = Utility.PinCode;
                if (File.Exists("Logo.Png"))
                {
                    byte[] bytes = System.IO.File.ReadAllBytes("Logo.Png");
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    pictureEdit1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Filter =
                  "Images (*.PNG)|*.PNG";
                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    pictureEdit1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}