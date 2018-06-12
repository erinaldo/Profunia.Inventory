using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseMasterSP : DBConnection
	{
		public decimal PurchaseMasterAdd(PurchaseMasterInfo purchasemasterinfo)
		{
			decimal decPurchaseMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam27 = new SqlParameter();
				sprmparam27 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.VoucherNo;
				sprmparam27 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.InvoiceNo;
				sprmparam27 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.SuffixPrefixId;
				sprmparam27 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.VoucherTypeId;
				sprmparam27 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam27.Value = purchasemasterinfo.Date;
				sprmparam27 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.LedgerId;
				sprmparam27 = sccmd.Parameters.Add("@vendorInvoiceNo", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.VendorInvoiceNo;
				sprmparam27 = sccmd.Parameters.Add("@vendorInvoiceDate", SqlDbType.DateTime);
				sprmparam27.Value = purchasemasterinfo.VendorInvoiceDate;
				sprmparam27 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.CreditPeriod;
				sprmparam27 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.ExchangeRateId;
				sprmparam27 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.Narration;
				sprmparam27 = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.PurchaseAccount;
				sprmparam27 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.PurchaseOrderMasterId;
				sprmparam27 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.MaterialReceiptMasterId;
				sprmparam27 = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.AdditionalCost;
				sprmparam27 = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.TotalTax;
				sprmparam27 = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.BillDiscount;
				sprmparam27 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.GrandTotal;
				sprmparam27 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.TotalAmount;
				sprmparam27 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.UserId;
				sprmparam27 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.LrNo;
				sprmparam27 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.TransportationCompany;
				sprmparam27 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam27.Value = purchasemasterinfo.FinancialYearId;
				sprmparam27 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam27.Value = purchasemasterinfo.ExtraDate;
				sprmparam27 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.Extra1;
				sprmparam27 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam27.Value = purchasemasterinfo.Extra2;
				decPurchaseMasterId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decPurchaseMasterId;
		}

		public void PurchaseMasterEdit(PurchaseMasterInfo purchasemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam28 = new SqlParameter();
				sprmparam28 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.PurchaseMasterId;
				sprmparam28 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.VoucherNo;
				sprmparam28 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.InvoiceNo;
				sprmparam28 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.SuffixPrefixId;
				sprmparam28 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.VoucherTypeId;
				sprmparam28 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam28.Value = purchasemasterinfo.Date;
				sprmparam28 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.LedgerId;
				sprmparam28 = sccmd.Parameters.Add("@vendorInvoiceNo", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.VendorInvoiceNo;
				sprmparam28 = sccmd.Parameters.Add("@vendorInvoiceDate", SqlDbType.DateTime);
				sprmparam28.Value = purchasemasterinfo.VendorInvoiceDate;
				sprmparam28 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.CreditPeriod;
				sprmparam28 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.ExchangeRateId;
				sprmparam28 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.Narration;
				sprmparam28 = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.PurchaseAccount;
				sprmparam28 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.PurchaseOrderMasterId;
				sprmparam28 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.MaterialReceiptMasterId;
				sprmparam28 = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.AdditionalCost;
				sprmparam28 = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.TotalTax;
				sprmparam28 = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.BillDiscount;
				sprmparam28 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.GrandTotal;
				sprmparam28 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.TotalAmount;
				sprmparam28 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.UserId;
				sprmparam28 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.LrNo;
				sprmparam28 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.TransportationCompany;
				sprmparam28 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam28.Value = purchasemasterinfo.FinancialYearId;
				sprmparam28 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam28.Value = purchasemasterinfo.ExtraDate;
				sprmparam28 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.Extra1;
				sprmparam28 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam28.Value = purchasemasterinfo.Extra2;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable PurchaseMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseMasterViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public PurchaseMasterInfo PurchaseMasterView(decimal purchaseMasterId)
		{
			PurchaseMasterInfo purchasemasterinfo = new PurchaseMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchasemasterinfo.PurchaseMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					purchasemasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					purchasemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					purchasemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					purchasemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					purchasemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					purchasemasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					purchasemasterinfo.VendorInvoiceNo = ((DbDataReader)sdrreader)[7].ToString();
					purchasemasterinfo.VendorInvoiceDate = DateTime.Parse(((DbDataReader)sdrreader)[8].ToString());
					purchasemasterinfo.CreditPeriod = ((DbDataReader)sdrreader)[9].ToString();
					purchasemasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					purchasemasterinfo.Narration = ((DbDataReader)sdrreader)[11].ToString();
					purchasemasterinfo.PurchaseAccount = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					purchasemasterinfo.PurchaseOrderMasterId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					purchasemasterinfo.MaterialReceiptMasterId = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					purchasemasterinfo.AdditionalCost = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					purchasemasterinfo.TotalTax = decimal.Parse(((DbDataReader)sdrreader)[16].ToString());
					purchasemasterinfo.BillDiscount = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
					purchasemasterinfo.GrandTotal = decimal.Parse(((DbDataReader)sdrreader)[18].ToString());
					purchasemasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[19].ToString());
					purchasemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[20].ToString());
					purchasemasterinfo.LrNo = ((DbDataReader)sdrreader)[21].ToString();
					purchasemasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[22].ToString();
					purchasemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[23].ToString());
					purchasemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[24].ToString());
					purchasemasterinfo.Extra1 = ((DbDataReader)sdrreader)[25].ToString();
					purchasemasterinfo.Extra2 = ((DbDataReader)sdrreader)[26].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				sdrreader.Close();
				base.sqlcon.Close();
			}
			return purchasemasterinfo;
		}

		public void PurchaseMasterDelete(decimal PurchaseMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseMasterId;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public int PurchaseMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				max = int.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return max;
		}

		public DataTable PurchaseInvoicePurchaseAccountFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseInvoicePurchaseAccountComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable GetOrderNoCorrespondingtoLedgerByNotInCurrPI(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherType)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("GetOrderNoCorrespondingtoLedgerByNotInCurrPI", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam3.Value = decLedgerId;
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decPurchaseMasterId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable GetOrderNoCorrespondingtoLedger(decimal decLedgerId, decimal decReceiptMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("GetOrderNoCorrespondingtoLedger", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sqlda.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal).Value = decReceiptMasterId;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("pmsp" + ex.ToString());
			}
			return dtbl;
		}

		public decimal PurchaseMasterVoucherMax(decimal decVoucherTypeId)
		{
			decimal decVoucherNoMax = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterVoucherMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				decVoucherNoMax = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decVoucherNoMax;
		}

		public DataTable GetMaterialReceiptNoCorrespondingtoLedgerByNotInCurrPI(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("GetMaterialReceiptNoCorrespondingtoLedgerByNotInCurrPI", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam3.Value = decLedgerId;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decPurchaseMasterId;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable AccountLedgerViewForAdditionalCost()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerViewForAdditionalCost", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable PurchaseInvoiceRegisterFill(string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strPurchaseMode, decimal decVoucherTypeId, string strInvoiceNo)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoiceRegisterFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sdaadapter.SelectCommand.Parameters.Add("@column", SqlDbType.VarChar);
				sprmparam8.Value = strColumn;
				sprmparam8 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam8.Value = dtFromDate;
				sprmparam8 = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam8.Value = dtToDate;
				sprmparam8 = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam8.Value = decLedgerId;
				sprmparam8 = sdaadapter.SelectCommand.Parameters.Add("@purchaseMode", SqlDbType.VarChar);
				sprmparam8.Value = strPurchaseMode;
				sprmparam8 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam8.Value = decVoucherTypeId;
				sprmparam8 = sdaadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam8.Value = strInvoiceNo;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable PurchaseInvoiceNoViewAllByProductCodeAndBatchNoForBarcodePrinting(decimal decProductId, decimal decBatchId, ComboBox cmbPurchaseInvoice, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sda = new SqlDataAdapter("PurchaseInvoiceNoViewAllByProductCodeAndBatchNoForBarcodePrinting", base.sqlcon);
				sda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = decProductId;
				sprmparam3 = sda.SelectCommand.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam3.Value = decBatchId;
				sda.Fill(dtbl);
				if (isAll)
				{
					if (dtbl.Rows.Count != 0)
					{
						DataRow dr = dtbl.NewRow();
						dr["invoiceNo"] = "All";
						dr["purchaseMasterId"] = 0;
						dtbl.Rows.InsertAt(dr, 0);
					}
					else
					{
						cmbPurchaseInvoice.Text = string.Empty;
					}
				}
				cmbPurchaseInvoice.DataSource = dtbl;
				cmbPurchaseInvoice.DisplayMember = "invoiceNo";
				cmbPurchaseInvoice.ValueMember = "purchaseMasterId";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public int PurchaseMasterReferenceCheck(decimal decPurchaseMasterId, decimal decPurchaseDetailsId)
		{
			int inQty = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decPurchaseMasterId;
				sprmparam3 = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
				sprmparam3.Value = decPurchaseDetailsId;
				inQty = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inQty;
		}

		public int PurchaseInvoiceVoucherNoCheckExistance(string strInvoiceNo, string strVoucherNo, decimal decVoucherTypeId, decimal decPurchaseMasterId)
		{
			int inRef = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseInvoiceVoucherNoCheckExistance", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam5.Value = strInvoiceNo;
				sprmparam5 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam5.Value = strVoucherNo;
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = decVoucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decPurchaseMasterId;
				inRef = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inRef;
		}

		public DataTable PurchaseInvoiceNoViewAllForBarcodePrinting(ComboBox cmbPurchaseInvoice, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sda = new SqlDataAdapter("PurchaseInvoiceNoViewAllForBarcodePrinting", base.sqlcon);
				sda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sda.Fill(dtbl);
				if (isAll)
				{
					DataRow dr = dtbl.NewRow();
					dr["invoiceNo"] = "All";
					dr["purchaseMasterId"] = 0;
					dtbl.Rows.InsertAt(dr, 0);
				}
				cmbPurchaseInvoice.DataSource = dtbl;
				cmbPurchaseInvoice.DisplayMember = "invoiceNo";
				cmbPurchaseInvoice.ValueMember = "purchaseMasterId";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable PurchaseInvoiceReportFill(decimal decCompanyId, string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strStatus, string strPurchaseMode, decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, decimal decVoucherTypeId, string strVoucherNo, string strProductCode, string strProductName)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoiceReportFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam14.Value = decCompanyId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@column", SqlDbType.VarChar);
				sprmparam14.Value = strColumn;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam14.Value = dtFromDate;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam14.Value = dtToDate;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = decLedgerId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam14.Value = strStatus;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@purchaseMode", SqlDbType.VarChar);
				sprmparam14.Value = strPurchaseMode;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = decAgainstVoucherTypeId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = strAgainstVoucherNo;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = decVoucherTypeId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = strVoucherNo;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam14.Value = strProductCode;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam14.Value = strProductName;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable GetInvoiceNoCorrespondingtoLedger(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("GetPurchaseReturnInvoiceNoCorrespondingtoLedger", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sqlda.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal).Value = decPurchaseMasterId;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("pmsp" + ex.ToString());
			}
			return dtbl;
		}

		public DataTable GetInvoiceNoCorrespondingtoLedgerInRegister()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("GetInvoiceNoCorrespondingtoLedgerInRegister", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("pmsp" + ex.ToString());
			}
			return dtbl;
		}

		public DataSet PurchaseInvoicePrinting(decimal decCompanyId, decimal decPurchaseOrderMasterId, decimal decMaterialReceiptMasterId, decimal decPurchaseMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoicePrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam5.Value = decCompanyId;
				sprmparam5 = sdaadapter.SelectCommand.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decPurchaseOrderMasterId;
				sprmparam5 = sdaadapter.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decMaterialReceiptMasterId;
				sprmparam5 = sdaadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decPurchaseMasterId;
				sdaadapter.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return ds;
		}

		public DataSet PurchaseInvoiceReportPrinting(decimal decCompanyId, string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strStatus, string strPurchaseMode, decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, decimal decVoucherTypeId, string strVoucherNo, string strProductCode, string strProductName)
		{
			DataSet ds = new DataSet();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoiceReportPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam14.Value = decCompanyId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@column", SqlDbType.VarChar);
				sprmparam14.Value = strColumn;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam14.Value = dtFromDate;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam14.Value = dtToDate;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = decLedgerId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam14.Value = strStatus;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@purchaseMode", SqlDbType.VarChar);
				sprmparam14.Value = strPurchaseMode;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = decAgainstVoucherTypeId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = strAgainstVoucherNo;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = decVoucherTypeId;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = strVoucherNo;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam14.Value = strProductCode;
				sprmparam14 = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam14.Value = strProductName;
				sdaadapter.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return ds;
		}

		public decimal PurchaseMasterIdViewByvoucherNoAndVoucherType(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseMasterIdViewByvoucherNoAndVoucherType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVouchertypeid;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				decid = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decid;
		}
	}
}
