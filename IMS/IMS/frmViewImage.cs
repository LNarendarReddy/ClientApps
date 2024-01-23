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

namespace IMS
{
    public partial class frmViewImage : DevExpress.XtraEditors.XtraForm
    {
        public byte[] imageSource = null;
        public frmViewImage()
        {
            InitializeComponent();
        }

        private void frmViewImage_Load(object sender, EventArgs e)
        {
            Bitmap image;
            using (MemoryStream stream = new MemoryStream(imageSource))
            {
                image = new Bitmap(stream);
            }
            pictureEdit1.Image = image;
        }
    }
}