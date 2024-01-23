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
    public partial class frmMedicineStock : DevExpress.XtraEditors.XtraForm
    {
        DMedicine ObjDMedicine = new DMedicine();
        EMedicine ObjEMedicine = new EMedicine();
        public frmMedicineStock()
        {
            InitializeComponent();
        }

        private void frmMedicineStock_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEMedicine = ObjDMedicine.GetMedicineForBilling(ObjEMedicine);
                gcMedicineList.DataSource = ObjEMedicine.dtMedicine;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}