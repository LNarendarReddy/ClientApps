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
    public partial class frmModelPopup : DevExpress.XtraEditors.XtraForm
    {
        string Poptype = string.Empty;
        public string strValue = string.Empty;
        List<Control> Requirefields = new List<Control>();
        public int CurretStock = 0;
        public frmModelPopup(string _Poptype)
        {
            InitializeComponent();
            Poptype = _Poptype;
        }

        private void frmModelPopup_Load(object sender, EventArgs e)
        {
            if (Poptype.ToLower() == "category")
            {
                this.Text = "New Category";
                layoutControlItem1.Text = "Category Name";
            }
            else if (Poptype.ToLower() == "mname")
            {
                this.Text = "New Manufacturer";
                layoutControlItem1.Text = "Manufacturer Name";
            }
            else if (Poptype.ToLower() == "unit")
            {
                this.Text = "New Unit";
                layoutControlItem1.Text = "Unit";
            }
            else if (Poptype.ToLower() == "quantity")
            {
                this.Text = "Quantity";
                layoutControlItem1.Text = "Quantity";
            }
            Requirefields.Add(txtName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(Requirefields))
                    return;

                if (Poptype.ToLower() == "quantity")
                {
                    int IValue = 0;
                    if (int.TryParse(Convert.ToString(txtName.EditValue), out IValue) && IValue <= CurretStock)
                        strValue = Convert.ToString(txtName.EditValue);
                    else
                        throw new Exception("Please enter quantity less than current stock");
                }
                else
                    strValue = Convert.ToString(txtName.EditValue);
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

        private void frmModelPopup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                btnCancel_Click(null, null);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSave_Click(null, null);
        }
    }
}