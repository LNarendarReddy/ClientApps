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
using DevExpress.XtraEditors.Repository;

namespace IMS
{
    public partial class frmExpenses : DevExpress.XtraEditors.XtraForm
    {
        EExpenses ObjEExpenses = null;
        DExpenses ObjDExpenses = null;
        List<Control> RequirteFields = new List<Control>();
        public frmExpenses()
        {
            InitializeComponent();
        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                BindCMB();
                RequirteFields.Add(cmmExpense);
                RequirteFields.Add(txtAmount);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(RequirteFields))
                    return;
                if (ObjEExpenses == null)
                    ObjEExpenses = new EExpenses();
                if (ObjDExpenses == null)
                    ObjDExpenses = new DExpenses();
                int IValue = 0;
                if (int.TryParse(Convert.ToString(cmmExpense.EditValue), out IValue))
                    ObjEExpenses.ExpensesID = IValue;
                ObjEExpenses.ExpenseName = cmmExpense.Text.Trim();
                ObjEExpenses.ExpensesDEscription = txtRemarks.Text;
                decimal DValue = 0;
                if (decimal.TryParse(Convert.ToString(txtAmount.EditValue), out DValue))
                    ObjEExpenses.Amount = DValue;
                ObjEExpenses = ObjDExpenses.SaveExpense(ObjEExpenses);
                BindCMB();
                ClearFields();
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

        private void lookUpEdit1_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                DataRow Row;
                RepositoryItemLookUpEdit Edit;
                Edit = ((LookUpEdit)sender).Properties;
                if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                    return;
                DataTable LookupTable = (DataTable)cmmExpense.Properties.DataSource;
                DataRow[] dr = LookupTable.Select("ExpensesID= -1");
                foreach (DataRow row in dr)
                    LookupTable.Rows.Remove(row);
                Row = LookupTable.NewRow();
                Row["ExpensesID"] = -1;
                Row["ExpenseName"] = e.DisplayValue;
                LookupTable.Rows.Add(Row);
                e.Handled = true;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void ClearFields()
        {
            if (ObjEExpenses == null)
                ObjEExpenses = new EExpenses();
            ObjEExpenses.ExpensesID = -1;
            cmmExpense.EditValue = null;
            txtAmount.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }

        private void BindCMB()
        {
            try
            {
                if (ObjEExpenses == null)
                    ObjEExpenses = new EExpenses();
                if (ObjDExpenses == null)
                    ObjDExpenses = new DExpenses();
                ObjEExpenses = ObjDExpenses.GetExpsesName(ObjEExpenses);
                cmmExpense.Properties.DataSource = ObjEExpenses.dtExpensesNAme;
                cmmExpense.Properties.DisplayMember = "ExpenseName";
                cmmExpense.Properties.ValueMember = "ExpensesID";
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}