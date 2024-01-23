using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DInvoice
    {
        public EInvoice SaveInvoice(EInvoice ObjEInvoice)
        {
            DataSet dsStockEntry = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Invoice]";
                    cmd.Parameters.Add("@InvoiceID", ObjEInvoice.InvoiceID);
                    cmd.Parameters.Add("@DistributorID", ObjEInvoice.DistributorID);
                    cmd.Parameters.Add("@InvoiceNumber", ObjEInvoice.InvoiceNumber);
                    cmd.Parameters.Add("@InvoiceDate", ObjEInvoice.InvoiceDate);
                    cmd.Parameters.Add("@GrandTotal", ObjEInvoice.GrandTotal);
                    cmd.Parameters.Add("@CGST", ObjEInvoice.CGST);
                    cmd.Parameters.Add("@SGST", ObjEInvoice.SGST);
                    cmd.Parameters.Add("@UserID", ObjEInvoice.UserID);
                    cmd.Parameters.Add("@dtStockEntry", ObjEInvoice.dtStockEntry);
                    cmd.Parameters.Add("@ImagePath", ObjEInvoice.ImagePath);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsStockEntry);
                    }
                    if (dsStockEntry != null && dsStockEntry.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsStockEntry.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                            ObjEInvoice.InvoiceID = IValue;
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Saving Invoice");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEInvoice;
        }

        public EInvoice GetBatchNumbers(EInvoice ObjEInvoice)
        {
            DataSet dsBatchNumber = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_BatchNumber]";
                    cmd.Parameters.Add("@MedicineID", ObjEInvoice.MedicineID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBatchNumber);
                    }
                    if (dsBatchNumber != null && dsBatchNumber.Tables.Count > 0)
                        ObjEInvoice.dtBatchNumber = dsBatchNumber.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Batch Numbers");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEInvoice;
        }

        public EInvoice GetBatchDetails(EInvoice ObjEInvoice)
        {
            DataSet dsBatchDetails = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_BatchDetails]";
                    cmd.Parameters.Add("@BatchNoID", ObjEInvoice.BatchNoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsBatchDetails);
                    }
                    if (dsBatchDetails != null && dsBatchDetails.Tables.Count > 0)
                        ObjEInvoice.dtBatchDetails = dsBatchDetails.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Batch Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEInvoice;
        }

        public EInvoice GetInvoices(EInvoice oBJEInvoice)
        {
            DataSet dsInvoices = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_InvoiceBills]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsInvoices);
                    }
                    if (dsInvoices != null && dsInvoices.Tables.Count > 0)
                    {
                        oBJEInvoice.dsInvoices = dsInvoices.Copy();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Retriving Invoices");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEInvoice;
        }

        public EInvoice GetDistributorDue(EInvoice oBJEInvoice)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_DistributorDue]";
                    cmd.Parameters.Add("@DistributorID", oBJEInvoice.DistributorID);
                    object ObjReturn = cmd.ExecuteScalar();
                    decimal DValue = 0;
                    if (decimal.TryParse(Convert.ToString(ObjReturn), out DValue))
                        oBJEInvoice.Due = DValue;
                    else
                        oBJEInvoice.Due = 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Retrieving Distributor Due");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEInvoice;
        }

        public EInvoice GetInvoiceImage(EInvoice oBJEInvoice)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_InvoiceImage]";
                    cmd.Parameters.Add("@InvoiceID", oBJEInvoice.InvoiceID);
                    object ObjReturn = cmd.ExecuteScalar();
                    oBJEInvoice.ImagePath = Convert.ToString(ObjReturn);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Retrieving InvoiceImage");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEInvoice;
        }

        public EInvoice SavePayment(EInvoice ObjEInvoice)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Payment]";
                    cmd.Parameters.Add("@InvoiceID", ObjEInvoice.InvoiceID);
                    cmd.Parameters.Add("@Amount", ObjEInvoice.Paid);
                    cmd.Parameters.Add("@UserID", ObjEInvoice.UserID);
                    cmd.Parameters.Add("@PaymentMode", ObjEInvoice.PaymentMode);
                    cmd.Parameters.Add("@Remarks", ObjEInvoice.Remarks);
                    Object Objreturn = cmd.ExecuteScalar();
                    int IValue = 0;
                    if (!int.TryParse(Convert.ToString(Objreturn), out IValue))
                        throw new Exception("Error while saving the payment");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Saving payment");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEInvoice;
        }

        public EInvoice GetInvoiceDetails(EInvoice oBJEInvoice)
        {
            DataSet dsInvoicedetails = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_InvoiceDetails]";
                    cmd.Parameters.Add("@InvoiceID", oBJEInvoice.InvoiceID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsInvoicedetails);
                    }
                    if (dsInvoicedetails != null && dsInvoicedetails.Tables.Count > 0)
                    {
                        oBJEInvoice.dtInvoiceDetails = dsInvoicedetails.Tables[0].Copy();
                        if(dsInvoicedetails.Tables.Count > 1 && dsInvoicedetails.Tables[1].Rows.Count > 0)
                        {
                            DateTime dt = DateTime.Now;
                            int IValue = 0;
                            decimal DValue = 0;
                            oBJEInvoice.InvoiceNumber = Convert.ToString(dsInvoicedetails.Tables[1].Rows[0]["InvoiceNumber"]);
                            if (DateTime.TryParse(Convert.ToString(dsInvoicedetails.Tables[1].Rows[0]["Invoicedate"]), out dt))
                                oBJEInvoice.InvoiceDate = dt;
                            if (int.TryParse(Convert.ToString(dsInvoicedetails.Tables[1].Rows[0]["DistributorID"]), out IValue))
                                oBJEInvoice.DistributorID = IValue;
                            if (int.TryParse(Convert.ToString(dsInvoicedetails.Tables[1].Rows[0]["DistributorID"]), out IValue))
                                oBJEInvoice.DistributorID = IValue;
                            if (decimal.TryParse(Convert.ToString(dsInvoicedetails.Tables[1].Rows[0]["InvoiceTotal"]), out DValue))
                                oBJEInvoice.GrandTotal = DValue;
                            if (decimal.TryParse(Convert.ToString(dsInvoicedetails.Tables[1].Rows[0]["CGST"]), out DValue))
                                oBJEInvoice.CGST = DValue;
                            if (decimal.TryParse(Convert.ToString(dsInvoicedetails.Tables[1].Rows[0]["SGST"]), out DValue))
                                oBJEInvoice.SGST = DValue;
                        }
                            
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured While Retriving Invoice Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return oBJEInvoice;
        }

    }
}
