using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QuoteMaker.Models;
using QuoteMaker.Repository;
using QuoteMaker.UI.Items;
using QuoteMaker.UI.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuoteMaker.UI.Quote
{
    public partial class frmCreateQuote : XtraForm
    {
        object ItemPriceID = null;
        Quotation quotation = null;
        QuotationDetail quotationDetail = null;

        public frmCreateQuote()
        {
            InitializeComponent();
        }

        private void frmCreateQuote_Load(object sender, EventArgs e)
        {
            try
            {
                ((frmMain)MdiParent).RefreshBaseLineData += frmCreateQuote_RefreshBaseLineData;

                cmbGST.Properties.DataSource = Utility.GetGSTInfoList();
                cmbGST.Properties.ValueMember = "GSTID";
                cmbGST.Properties.DisplayMember = "GSTCODE";

                frmCreateQuote_RefreshBaseLineData(null, null);

                if (quotation == null)
                    quotation = new Quotation();
                quotation.UserID = Utility.UserID;

                Dictionary<string, object> keyValuePairs= new Dictionary<string, object>()
                {
                    { "USERID", Utility.UserID}
                };
                DataSet ds = new RepositoryBase().GetDataset("USP_R_QUOTEDRAFT", keyValuePairs);
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (int.TryParse(Convert.ToString(ds.Tables[0].Rows[0][0]), out int ivalue))
                    {
                        quotation.QUOTATIONID = ivalue;
                        txtCustomerName.EditValue = ds.Tables[0].Rows[0]["QUOTATIONID"];
                        txtCustomerNumber.EditValue = ds.Tables[0].Rows[0]["CUSTOMERNAME"];
                        txtCustomerAddress.EditValue = ds.Tables[0].Rows[0]["CUSTOMERNUMBER"];
                        txtOverAllDiscount.EditValue = ds.Tables[0].Rows[0]["CUSTOMERADDRESS"];
                        gcQuote.DataSource = quotation.dataTable = ds.Tables[1].Copy();
                        txtCustomerName.Enabled = false;
                        txtCustomerNumber.Enabled = false;
                        txtCustomerAddress.Enabled = false;
                    }
                    else
                    {
                        quotation.dataTable = new DataTable();
                        quotation.dataTable.Columns.Add("QUOTATIONDETAILID", typeof(int));
                        quotation.dataTable.Columns.Add("ITEMID", typeof(int));
                        quotation.dataTable.Columns.Add("ITEMCODEID", typeof(int));
                        quotation.dataTable.Columns.Add("ITEMPRICEID", typeof(int));
                        quotation.dataTable.Columns.Add("SKUCODE", typeof(string));
                        quotation.dataTable.Columns.Add("ITEMCODE", typeof(string));
                        quotation.dataTable.Columns.Add("ITEMNAME", typeof(string));
                        quotation.dataTable.Columns.Add("MRP", typeof(decimal));
                        quotation.dataTable.Columns.Add("SALEPRICE", typeof(decimal));
                        quotation.dataTable.Columns.Add("QUANTITY", typeof(int));
                        quotation.dataTable.Columns.Add("DISCPER", typeof(decimal));
                        quotation.dataTable.Columns.Add("DISCFLAT", typeof(decimal));
                        quotation.dataTable.Columns.Add("TOTALDISCOUNT", typeof(decimal));
                        quotation.dataTable.Columns.Add("NETPRICE", typeof(decimal));
                        quotation.dataTable.Columns.Add("GSTCODE", typeof(string));
                        quotation.dataTable.Columns.Add("GST", typeof(decimal));
                        gcQuote.DataSource = quotation.dataTable;
                    }  
                }
                txtOverAllDiscount.EditValue = 0.00;
                txtDiscountPer.EditValue = 0.00;
                txtDiscountFlat.EditValue = 0.00;
            }
            catch (Exception) { }
        }

        private void frmCreateQuote_RefreshBaseLineData(object sender, EventArgs e)
        {
            object selectedValue = cmbItemCode.EditValue;

            cmbItemCode.Properties.DataSource = Utility.GetItemCodeList();
            cmbItemCode.Properties.ValueMember = "ITEMCODEID";
            cmbItemCode.Properties.DisplayMember = "ITEMCODE";
            cmbItemCode.EditValue = selectedValue;
        }

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            try
            {
                int iValue = 0;
                if (int.TryParse(Convert.ToString(quotation.QUOTATIONID), out iValue) && iValue > 0)
                {
                    if (!dxValidationProvider1.Validate() || 
                        XtraMessageBox.Show("Are you sure want to save quotation?","Confirm",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                    quotation.QUOTATIONID = new RepositoryBase().Execute<int>("USP_U_QUOTATION",
                        new Dictionary<string, object> {{ "QUOTATIONID", quotation.QUOTATIONID }});
                    
                    DataSet ds = new RepositoryBase().GetDataset("USP_R_QUOTATION",
                        new Dictionary<string, object> { { "QUOTATIONID", quotation.QUOTATIONID } });

                    rptQuote rpt = new rptQuote(ds.Tables[0], ds.Tables[1]);
                    rpt.ShowPrintMarginsWarning = false;
                    rpt.ShowRibbonPreview();
                    txtCustomerName.EditValue = null;
                    txtCustomerNumber.EditValue = null;
                    txtCustomerAddress.EditValue = null;
                    txtOverAllDiscount.EditValue = 0.00;

                    txtCustomerName.Enabled = true;
                    txtCustomerNumber.Enabled = true;
                    txtCustomerAddress.Enabled = true;
                    txtOverAllDiscount.Enabled = true;

                    quotation.QUOTATIONID = 0;
                    quotation.dataTable = quotation.dataTable.Clone();
                    gcQuote.DataSource = quotation.dataTable;
                    txtCustomerName.Focus();
                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbItemCode_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbItemCode.EditValue != null)
                {
                    
                    int rowhandle = cmbLookupView.LocateByValue("ITEMCODEID", cmbItemCode.EditValue);
                    txtItemName.EditValue = cmbLookupView.GetRowCellValue(rowhandle,"ITEMNAME");
                    DataTable dtMRPList = new RepositoryBase().GetDataTable("USP_R_ITEMMRPLIST",
                      new Dictionary<string, object> { { "ITEMCODEID", cmbItemCode.EditValue } });
                    if (dtMRPList.Rows.Count > 1)
                    {
                        frmMRPList obj = new frmMRPList(dtMRPList);
                        obj.ShowDialog();
                        if (obj._IsSave)
                        {

                            txtMRP.EditValue = ((DataRowView)obj.drSelected)["MRP"];
                            txtSalePrice.EditValue = ((DataRowView)obj.drSelected)["SALEPRICE"];
                            ItemPriceID = ((DataRowView)obj.drSelected)["ITEMPRICEID"];
                            cmbGST.EditValue = ((DataRowView)obj.drSelected)["GSTID"];
                        }
                    }
                    else
                    {
                        txtMRP.EditValue = dtMRPList.Rows[0]["MRP"];
                        txtSalePrice.EditValue = dtMRPList.Rows[0]["SALEPRICE"];
                        ItemPriceID = dtMRPList.Rows[0]["ITEMPRICEID"];
                        cmbGST.EditValue = dtMRPList.Rows[0]["GSTID"];
                    }
                    txtQuantity.EditValue = 1;
                    txtDiscountPer.EditValue = 0;
                    txtDiscountFlat.EditValue = 0;
                    SendKeys.Send("{ENTER}");
                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                try
                {
                    gvQuote.GridControl.BindingContext = new BindingContext();
                    gvQuote.GridControl.DataSource = gvQuote.DataSource;
                    gvQuote.AddNewRow();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveQuotation()
        {
            try
            {
                if (quotation == null)
                {
                    quotation = new Quotation();
                    quotation.QUOTATIONID = 0;
                }
                quotation.CUSTOMERNAME = txtCustomerName.EditValue;
                quotation.CUSTOMERNUMBER = txtCustomerNumber.EditValue;
                quotation.CUSTOMERADDRESS = txtCustomerAddress.EditValue;
                quotation.UserID = Utility.UserID;

                Dictionary<string, object> Params = new Dictionary<string, object>()
                {
                    {"QUOTATIONID", quotation.QUOTATIONID },
                    {"CUSTOMERNAME", quotation.CUSTOMERNAME },
                    {"CUSTOMERNUMBER", quotation.CUSTOMERNUMBER },
                    {"CUSTOMERADDRESS", quotation.CUSTOMERADDRESS},
                    {"OVERALLDISCFLAT", 0},
                    {"USERID", Utility.UserID}
                };

                quotation.QUOTATIONID = new RepositoryBase().Execute<int>("USP_CU_QUOTATION", Params);
                txtCustomerName.Enabled = false;
                txtCustomerNumber.Enabled = false;
                txtCustomerAddress.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Are you sure want to delete item?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                new RepositoryBase().Execute<int>("USP_D_QUOTATIONDETAIL",
                      new Dictionary<string, object> { { "QUOTATIONDETAILID", gvQuote.GetFocusedRowCellValue("QUOTATIONDETAILID") } });
                gvQuote.DeleteRow(gvQuote.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void gvQuote_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, "QUOTATIONDETAILID", quotationDetail.QUOTATIONDETAILID);
                view.SetRowCellValue(e.RowHandle, "ITEMID", cmbLookupView.GetFocusedRowCellValue("ITEMID"));
                view.SetRowCellValue(e.RowHandle, "ITEMCODEID", cmbItemCode.EditValue);
                view.SetRowCellValue(e.RowHandle, "ITEMPRICEID", ItemPriceID);
                view.SetRowCellValue(e.RowHandle, "SKUCODE", cmbLookupView.GetFocusedRowCellValue("SKUCODE"));
                view.SetRowCellValue(e.RowHandle, "ITEMCODE", cmbItemCode.Text);
                view.SetRowCellValue(e.RowHandle, "ITEMNAME", txtItemName.EditValue);
                view.SetRowCellValue(e.RowHandle, "MRP", txtMRP.EditValue);
                view.SetRowCellValue(e.RowHandle, "SALEPRICE", txtSalePrice.EditValue);
                view.SetRowCellValue(e.RowHandle, "QUANTITY", txtQuantity.EditValue);
                view.SetRowCellValue(e.RowHandle, "DISCPER", txtDiscountPer.EditValue);
                view.SetRowCellValue(e.RowHandle, "DISCFLAT", txtDiscountFlat.EditValue);
                view.SetRowCellValue(e.RowHandle, "TOTALDISCOUNT", txtTotalDiscount.EditValue);
                view.SetRowCellValue(e.RowHandle, "NETPRICE", txtNetPrice.EditValue);
                view.SetRowCellValue(e.RowHandle, "GST", txtGST.EditValue);
                view.SetRowCellValue(e.RowHandle, "GSTCODE", cmbGST.Text);
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            calculatereadonlyfields();
        }

        private void calculatereadonlyfields()
        {
            int.TryParse(txtQuantity.Text, out int quantity);
            decimal.TryParse(txtSalePrice.Text, out decimal saleprice);
            decimal totalprice = quantity * saleprice;
            decimal discountPer = (!string.IsNullOrEmpty(txtDiscountPer.Text) || txtDiscountPer.EditValue != null) ? Convert.ToDecimal(txtDiscountPer.EditValue) : 0;
            decimal discountFlat = txtDiscountPer.EditValue != null && discountPer == 0 && txtDiscountFlat.EditValue != null
                ? Convert.ToDecimal(txtDiscountFlat.EditValue) : 0;
            decimal appliedDiscount = discountFlat > 0
                    ? discountFlat
                    : discountPer > 0
                        ? Math.Round(totalprice * (discountPer / 100), 4)
                        : 0;

            decimal finalPriceWOT = totalprice - appliedDiscount;
            decimal appliedGST = 0.0M;
            decimal cGST = 0.0M;
            decimal sGST = 0.0M;
            //decimal iGST = 0.0M;
            decimal cess = 0.0M;
            if (cmbGST.GetSelectedDataRow() is GSTInfo gstInfo)
            {
                decimal finalPriceToConsider = finalPriceWOT;
                cGST = Math.Round(finalPriceToConsider * gstInfo.CGST / 100, 2);
                sGST = Math.Round(finalPriceToConsider * gstInfo.SGST / 100, 2);
                cess = Math.Round(finalPriceToConsider * gstInfo.CESS / 100, 2);
                appliedGST = cGST + sGST + cess;
                //appliedGST = iGST = Math.Round(finalPriceToConsider * gstInfo.IGST / 100, 2);
            }

            decimal finalPrice = finalPriceWOT + appliedGST;
            txtTPWOT.EditValue = totalprice;
            txtTotalPriceWT.EditValue = (totalprice - appliedDiscount) + appliedGST;
            txtTPAfterDisc.EditValue = finalPriceWOT;
            txtTotalDiscount.EditValue = appliedDiscount;
            txtGST.EditValue = appliedGST;
            txtNetPrice.EditValue = finalPrice;
        }

        private void bntDiscardQuotation_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure want to discard quotation?", "Confirm", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Dictionary<string, object> Params = new Dictionary<string, object> {
                { "QUOTATIONID", quotation.QUOTATIONID},
                { "UserID", Utility.UserID }
            };
            new RepositoryBase().Execute<int>("USP_D_QUOTATION", Params);
            txtCustomerName.EditValue = null;
            txtCustomerNumber.EditValue = null;
            txtCustomerAddress.EditValue = null;
            txtOverAllDiscount.EditValue = null;
            txtCustomerName.Enabled = true;
            txtCustomerNumber.Enabled = true;
            txtCustomerAddress.Enabled = true;
            quotation.QUOTATIONID = 0;
            quotation.dataTable = quotation.dataTable.Clone();
            gcQuote.DataSource = quotation.dataTable;
            txtCustomerName.Focus();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider2.Validate()) return;
            try
            {
                if (Convert.ToInt32(quotation.QUOTATIONID) == 0) SaveQuotation();

                quotationDetail = new QuotationDetail();
                quotationDetail.QUOTATIONDETAILID = 0;
                quotationDetail.QUOTATIONID = quotation.QUOTATIONID;
                quotationDetail.ITEMPRICEID = Convert.ToInt32(ItemPriceID);
                quotationDetail.QUANTITY = Convert.ToInt32(txtQuantity.EditValue);
                quotationDetail.DISCPER = Convert.ToDecimal(txtDiscountPer.EditValue);
                quotationDetail.DISCOUNTFLAT = Convert.ToDecimal(txtDiscountFlat.EditValue);
                quotationDetail.TOTALDISCOUNT = Convert.ToDecimal(txtTotalDiscount.EditValue);
                quotationDetail.GST = Convert.ToDecimal(txtGST.EditValue);
                quotationDetail.NETPRICE = Convert.ToDecimal(txtNetPrice.EditValue);
                quotationDetail.UserID = Utility.UserID;

                Dictionary<string, object> Params = new Dictionary<string, object>()
                {
                    {"QUOTATIONDETAILID", quotationDetail.QUOTATIONDETAILID },
                    {"QUOTATIONID", quotationDetail.QUOTATIONID },
                    {"ITEMPRICEID", quotationDetail.ITEMPRICEID},
                    {"QUANTITY", quotationDetail.QUANTITY},
                    {"DISCPER", quotationDetail.DISCOUNTPER },
                    {"DISCFLAT", quotationDetail.DISCOUNTFLAT},
                    {"TOTALDISCOUNT", quotationDetail.TOTALDISCOUNT },
                    {"GST", quotationDetail.GST },
                    {"NETPRICE", quotationDetail.NETPRICE },
                    {"USERID", Utility.UserID}
                };

                quotationDetail.QUOTATIONDETAILID = 
                    new RepositoryBase().Execute<int>("USP_CU_QUOTATIONDETAIL", Params);

                RefreshGrid();
                quotationDetail.QUOTATIONDETAILID = 0;
                cmbItemCode.EditValue = null;
                txtItemName.EditValue = null;
                txtMRP.EditValue = null;
                txtSalePrice.EditValue = null;
                txtQuantity.EditValue = null;
                txtDiscountPer.EditValue = 0.00;
                txtDiscountFlat.EditValue = 0.00;
                cmbGST.EditValue = null;
                cmbItemCode.Focus();
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void txtDiscountPer_EditValueChanged(object sender, EventArgs e)
        {
            txtDiscountFlat.EditValue = 0;
            calculatereadonlyfields();
        }

        private void txtDiscountFlat_EditValueChanged(object sender, EventArgs e)
        {
            txtDiscountPer.EditValue = 0;
            calculatereadonlyfields();
        }
    }
}