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
using EL;
using DL;
using HMS.Reports;
using DevExpress.XtraReports.UI;

namespace HMS
{
    public partial class frmBilling : DevExpress.XtraEditors.XtraForm
    {
        EItem ObjEItem = null;
        DItem ObjDItem = new DItem();

        DataTable dtItems = null;
        public frmBilling()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtItems != null && dtItems.Rows.Count > 0)
                {
                    ObjEItem.OrgID = Utility.OrgID;
                    ObjEItem.BranchID = Utility.BranchID;
                    ObjEItem.UserID = Utility.UserID;
                    ObjEItem.PaymentMode = 0;
                    if (chkServiceBill.Checked)
                        ObjEItem.IsService = true;
                    else
                        ObjEItem.IsService = false;
                    ObjEItem.NewBillNumber = txtBillNumber.EditValue;
                    ObjEItem.dtItems = dtItems;
                    ObjDItem.SaveBilling(ObjEItem);
                    lblStatus.Appearance.ForeColor = Color.DarkGreen;
                    lblStatus.Text = "Saved successfully";
                    timer1.Start();


                    rptBill rpt = new rptBill();
                    rpt.Parameters["BillID"].Value = ObjEItem.BillID;
                    rpt.Parameters["OrgName"].Value = Utility.OrgName;
                    rpt.Parameters["Address"].Value = Utility.OrgAddress;
                    rpt.Parameters["Mobile"].Value = Utility.OrgCNumber;
                    rpt.Parameters["BillNumber"].Value = ObjEItem.NewBillNumber;
                    if (!chkServiceBill.Checked)
                        rpt.Parameters["IsServiceBill"].Value = false;
                    else
                        rpt.Parameters["IsServiceBill"].Value = true;
                    rpt.DataSource = dtItems;
                    rpt.ShowPrintMarginsWarning = false;
                    rpt.Print();
                    if (chkServiceBill.Checked)
                        rpt.Print();
                    ClearFields();
                    chkServiceBill.Checked = false;

                    dtItems = new DataTable();
                    dtItems.Columns.Add("ItemID", typeof(int));
                    dtItems.Columns.Add("ItemCode", typeof(string));
                    dtItems.Columns.Add("ItemName", typeof(string));
                    dtItems.Columns.Add("Quantity", typeof(int));
                    dtItems.Columns.Add("SalePrice", typeof(decimal));
                    dtItems.Columns.Add("TotalPrice", typeof(decimal));
                    gcBilling.DataSource = dtItems;

                    ObjDItem.GetNewBillNumber(ObjEItem);
                    txtBillNumber.EditValue = ObjEItem.NewBillNumber;
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrEmpty(txtItemCode.Text))
            {
                try
                {
                    if (!txtItemCode.EnterMoveNextControl)
                        txtItemCode.EnterMoveNextControl = true;
                    ObjEItem = new EItem();
                    ObjEItem.ItemCode = txtItemCode.Text;
                    ObjDItem.GetItemByCode(ObjEItem);
                    txtItemName.EditValue = ObjEItem.ItemID;
                    txtSalePrice.EditValue = ObjEItem.SPrice;
                    txtServicePrice.EditValue = ObjEItem.ServicePrice;
                    txtQuantity.EditValue = 1;
                }
                catch (Exception ex)
                {
                    txtItemCode.EnterMoveNextControl = false;
                    timer1.Start();
                    lblStatus.Appearance.ForeColor = Color.DarkRed;
                    lblStatus.Text = ex.Message;
                    txtItemCode.Text = string.Empty;
                    txtItemName.EditValue = null;
                    txtSalePrice.Text = string.Empty;
                    txtServicePrice.Text = string.Empty;
                    e.Handled = false;
                }
            }
        }

        private void ClearFields()
        {
            txtItemCode.Text = string.Empty;
            txtItemName.EditValue = null;
            txtSalePrice.Text = string.Empty;
            txtServicePrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtItemCode.Focus();
            ObjEItem = new EItem();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            timer1.Stop();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEItem == null)
                    ObjEItem = new EItem();
                ObjEItem.BranchID = Utility.BranchID;
                ObjDItem.GetItemList(ObjEItem);
                txtItemName.Properties.DataSource = ObjEItem.dtItemList;
                txtItemName.Properties.DisplayMember = "ItemName";
                txtItemName.Properties.ValueMember = "ItemID";

                dtItems = new DataTable();
                dtItems.Columns.Add("ItemID", typeof(int));
                dtItems.Columns.Add("ItemCode", typeof(string));
                dtItems.Columns.Add("ItemName", typeof(string));
                dtItems.Columns.Add("Quantity", typeof(int));
                dtItems.Columns.Add("SalePrice", typeof(decimal));
                dtItems.Columns.Add("TotalPrice", typeof(decimal));
                gcBilling.DataSource = dtItems;
                ObjDItem.GetNewBillNumber(ObjEItem);
                txtBillNumber.EditValue = ObjEItem.NewBillNumber;
            }
            catch (Exception ex){}
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char) Keys.Enter && txtItemName.EditValue != null)
                {
                    DataRow sourceDataRow = 
                        (txtItemName.Properties.GetDataSourceRowByKeyValue(txtItemName.EditValue) as DataRowView).Row;
                    txtItemCode.EditValue = sourceDataRow["ItemCode"];
                    txtItemCode.Focus();
                }
            }
            catch (Exception ex){}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int focusrowid = gvBilling.FocusedRowHandle;
                dtItems.Rows.RemoveAt(focusrowid);
                if (dtItems.Rows.Count == 0)
                    chkServiceBill.Checked = false;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void frmBilling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                btnSave_Click(null, null);
            }
            else if (e.KeyData == (Keys.Control | Keys.F))
                txtItemName.Focus();
                
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (txtItemName.EditValue == null)
                        return;
                    DataRow sourceDataRow =
                        (txtItemName.Properties.GetDataSourceRowByKeyValue(txtItemName.EditValue) as DataRowView).Row;

                    object itemid = sourceDataRow["ItemID"];
                    DataRow[] drlist = dtItems.Select("ItemID =" + itemid);
                    if (drlist.Count() > 0)
                    {
                        int I = 0;
                        decimal d = 0;
                        if (decimal.TryParse(txtSalePrice.Text, out d) &&
                            int.TryParse(Convert.ToString(drlist[0]["Quantity"]), out I))
                        {
                            int i = 0;
                            if (int.TryParse(txtQuantity.Text, out i))
                            {
                                if (i == 0)
                                    return;
                                drlist[0]["Quantity"] = I + i;
                                drlist[0]["TotalPrice"] = ((I + i) * d).ToString("n2");
                            }
                        }
                    }
                    else
                    {
                        DataRow drnew = dtItems.NewRow();
                        drnew["ItemID"] = sourceDataRow["ItemID"];
                        drnew["ItemCode"] = sourceDataRow["ItemCode"];
                        drnew["ItemName"] = sourceDataRow["ItemName"];
                        drnew["Quantity"] = txtQuantity.EditValue;
                        decimal dValue = 0;
                        int IValue = 0;
                        if (decimal.TryParse(txtSalePrice.Text, out dValue) &&
                            int.TryParse(txtQuantity.Text, out IValue))
                        {
                            if (IValue == 0)
                                return;
                            drnew["SalePrice"] = dValue.ToString("n2");
                            drnew["TotalPrice"] = ((dValue) * IValue).ToString("n2");
                        }

                        dtItems.Rows.Add(drnew);
                    }
                    btnReset_Click(null, null);
                }
                else if(e.KeyData == (Keys.Shift | Keys.Enter))
                {
                    if (txtItemName.EditValue == null)
                        return;
                    chkServiceBill.Checked = true;
                    DataRow sourceDataRow =
                        (txtItemName.Properties.GetDataSourceRowByKeyValue(txtItemName.EditValue) as DataRowView).Row;

                    object itemid = sourceDataRow["ItemID"];
                    DataRow[] drlist = dtItems.Select("ItemID =" + itemid);
                    if (drlist.Count() > 0)
                    {
                        int I = 0;
                        decimal d = 0;
                        if (decimal.TryParse(txtServicePrice.Text, out d) &&
                            int.TryParse(Convert.ToString(drlist[0]["Quantity"]), out I))
                        {
                            int i = 0;
                            if (int.TryParse(txtQuantity.Text, out i))
                            {
                                if (i == 0)
                                    return;
                                drlist[0]["Quantity"] = I + i;
                                drlist[0]["TotalPrice"] = ((I + i) * d).ToString("n2");
                            }
                        }
                    }
                    else
                    {
                        DataRow drnew = dtItems.NewRow();
                        drnew["ItemID"] = sourceDataRow["ItemID"];
                        drnew["ItemCode"] = sourceDataRow["ItemCode"];
                        drnew["ItemName"] = sourceDataRow["ItemName"];
                        drnew["Quantity"] = txtQuantity.EditValue;
                        decimal dValue = 0;
                        int IValue = 0;
                        if (decimal.TryParse(txtServicePrice.Text, out dValue) &&
                            int.TryParse(txtQuantity.Text, out IValue))
                        {
                            if (IValue == 0)
                                return;
                            drnew["SalePrice"] = dValue.ToString("n2");
                            drnew["TotalPrice"] = ((dValue) * IValue).ToString("n2");
                        }

                        dtItems.Rows.Add(drnew);
                    }
                    btnReset_Click(null, null);
                }
                    
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}