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

namespace IMS
{
    public partial class frmNewMedicine : DevExpress.XtraEditors.XtraForm
    {
        List<Control> RequireFields = new List<Control>();
        public string strQuantity = string.Empty;
        public string strUnit = string.Empty;
        public decimal Price = 0;
        public frmNewMedicine()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                strQuantity = Convert.ToString(txtQuantity.EditValue);
                strUnit = Convert.ToString(txtUnit.EditValue);
                decimal DValue = 0;
                if (decimal.TryParse(Convert.ToString(txtPrice.EditValue), out DValue))
                    Price = DValue;
                else
                    throw new Exception("Please Enter Valid Price");
                this.Close();
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

        private void frmNewMedicine_Load(object sender, EventArgs e)
        {
            RequireFields.Add(txtQuantity);
            RequireFields.Add(txtPrice);
            RequireFields.Add(txtUnit);
        }
    }
}