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
using System.IO;
using EL;
using DL;

namespace InstituteMS
{
    public partial class frmViewImage : DevExpress.XtraEditors.XtraForm
    {

        EStudent ObjEStudent = null;
        DStudent ObjDStudent = new DStudent();
        public frmViewImage(EStudent _ObjEStudent)
        {
            InitializeComponent();
            ObjEStudent = _ObjEStudent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (picImage.Image != null)
                {
                    ObjEStudent.Imagedata = ConvertImagetoBinary(picImage.Image);
                    ObjEStudent.UserID = Utility.UserID;
                    if (ObjEStudent.Imagetype == "S")
                        ObjDStudent.Saveimage(ObjEStudent);
                    else if (ObjEStudent.Imagetype == "OS")
                        ObjDStudent.SaveOrgShortLogo(ObjEStudent);
                    else if (ObjEStudent.Imagetype == "OL")
                        ObjDStudent.SaveLongLogo(ObjEStudent);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private byte[] ConvertImagetoBinary(Image img)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    ObjEStudent.Imagedata = photo_aray;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjEStudent.Imagedata;
        }

        private Image BinaryToImage(byte[] b)
        {
            if (b == null)
                return null;

            MemoryStream memStream = new MemoryStream();
            memStream.Write(b, 0, b.Length);
            return Image.FromStream(memStream);
        }

        private void frmViewImage_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEStudent.Imagetype == "S")
                    ObjDStudent.GetImage(ObjEStudent);
                else if (ObjEStudent.Imagetype == "OS")
                {
                    ObjDStudent.GetOrgShortLogo(ObjEStudent);
                    picImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Never;
                }
                else if (ObjEStudent.Imagetype == "OL")
                {
                    ObjDStudent.GetOrgLongLogo(ObjEStudent);
                    picImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Never;
                }
                picImage.Image = BinaryToImage(ObjEStudent.Imagedata);
            }
            catch (Exception ex) { }
        }
    }
}