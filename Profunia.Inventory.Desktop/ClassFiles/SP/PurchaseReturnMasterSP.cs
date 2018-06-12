using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseReturnMasterSP : DBConnection
	{
		public void PurchaseReturnMasterAdd(PurchaseReturnMasterInfo purchasereturnmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam23 = new SqlParameter();
				sprmparam23 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.PurchaseReturnMasterId;
				sprmparam23 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.VoucherNo;
				sprmparam23 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.InvoiceNo;
				sprmparam23 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.SuffixPrefixId;
				sprmparam23 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.VoucherTypeId;
				sprmparam23 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam23.Value = purchasereturnmasterinfo.Date;
				sprmparam23 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.PurchaseMasterId;
				sprmparam23 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.LedgerId;
				sprmparam23 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.Discount;
				sprmparam23 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.ExchangeRateId;
				sprmparam23 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.Narration;
				sprmparam23 = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.PurchaseAccount;
				sprmparam23 = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.TotalTax;
				sprmparam23 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.GrandTotal;
				sprmparam23 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.TotalAmount;
				sprmparam23 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.UserId;
				sprmparam23 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.LrNo;
				sprmparam23 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.TransportationCompany;
				sprmparam23 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.FinancialYearId;
				sprmparam23 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam23.Value = purchasereturnmasterinfo.ExtraDate;
				sprmparam23 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.Extra1;
				sprmparam23 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.Extra2;
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

		public void PurchaseReturnMasterEdit(PurchaseReturnMasterInfo purchasereturnmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam23 = new SqlParameter();
				sprmparam23 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.PurchaseReturnMasterId;
				sprmparam23 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.VoucherNo;
				sprmparam23 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.InvoiceNo;
				sprmparam23 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.SuffixPrefixId;
				sprmparam23 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.VoucherTypeId;
				sprmparam23 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam23.Value = purchasereturnmasterinfo.Date;
				sprmparam23 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.PurchaseMasterId;
				sprmparam23 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.LedgerId;
				sprmparam23 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.Discount;
				sprmparam23 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.Narration;
				sprmparam23 = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.PurchaseAccount;
				sprmparam23 = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.TotalTax;
				sprmparam23 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.GrandTotal;
				sprmparam23 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.TotalAmount;
				sprmparam23 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.UserId;
				sprmparam23 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.LrNo;
				sprmparam23 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.ExchangeRateId;
				sprmparam23 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.TransportationCompany;
				sprmparam23 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam23.Value = purchasereturnmasterinfo.FinancialYearId;
				sprmparam23 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam23.Value = purchasereturnmasterinfo.ExtraDate;
				sprmparam23 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.Extra1;
				sprmparam23 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam23.Value = purchasereturnmasterinfo.Extra2;
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

		public DataTable PurchaseReturnMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseReturnMasterViewAll", base.sqlcon);
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

		public PurchaseReturnMasterInfo PurchaseReturnMasterView(decimal purchaseReturnMasterId)
		{
			PurchaseReturnMasterInfo purchasereturnmasterinfo = new PurchaseReturnMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseReturnMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchasereturnmasterinfo.PurchaseReturnMasterId = Convert.ToDecimal(((DbDataReader)sdrreader)["purchaseReturnMasterId"].ToString());
					purchasereturnmasterinfo.VoucherNo = ((DbDataReader)sdrreader)["voucherNo"].ToString();
					purchasereturnmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)["invoiceNo"].ToString();
					purchasereturnmasterinfo.SuffixPrefixId = Convert.ToDecimal(((DbDataReader)sdrreader)["suffixPrefixId"].ToString());
					purchasereturnmasterinfo.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
					purchasereturnmasterinfo.Date = Convert.ToDateTime(((DbDataReader)sdrreader)["date"].ToString());
					purchasereturnmasterinfo.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader)["ledgerId"].ToString());
					purchasereturnmasterinfo.Discount = Convert.ToDecimal(((DbDataReader)sdrreader)["discount"].ToString());
					purchasereturnmasterinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					purchasereturnmasterinfo.PurchaseAccount = Convert.ToDecimal(((DbDataReader)sdrreader)["purchaseAccount"].ToString());
					purchasereturnmasterinfo.TotalTax = Convert.ToDecimal(((DbDataReader)sdrreader)["totalTax"].ToString());
					purchasereturnmasterinfo.TotalAmount = Convert.ToDecimal(((DbDataReader)sdrreader)["totalAmount"].ToString());
					purchasereturnmasterinfo.GrandTotal = Convert.ToDecimal(((DbDataReader)sdrreader)["grandTotal"].ToString());
					purchasereturnmasterinfo.UserId = Convert.ToDecimal(((DbDataReader)sdrreader)["userId"].ToString());
					purchasereturnmasterinfo.LrNo = ((DbDataReader)sdrreader)["lrNo"].ToString();
					purchasereturnmasterinfo.TransportationCompany = ((DbDataReader)sdrreader)["transportationCompany"].ToString();
					purchasereturnmasterinfo.FinancialYearId = Convert.ToDecimal(((DbDataReader)sdrreader)["financialYearId"].ToString());
					purchasereturnmasterinfo.PurchaseMasterId = Convert.ToDecimal(((DbDataReader)sdrreader)["purchaseMasterId"].ToString());
					purchasereturnmasterinfo.ExchangeRateId = Convert.ToDecimal(((DbDataReader)sdrreader)["exchangeRateId"].ToString());
					purchasereturnmasterinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)["extraDate"].ToString());
					purchasereturnmasterinfo.Extra1 = ((DbDataReader)sdrreader)["extra1"].ToString();
					purchasereturnmasterinfo.Extra2 = ((DbDataReader)sdrreader)["extra2"].ToString();
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
			return purchasereturnmasterinfo;
		}

		public void PurchaseReturnMasterDelete(decimal PurchaseReturnMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseReturnMasterId;
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

		public int PurchaseReturnMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterMax", base.sqlcon);
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

		public decimal PurchaseReturnMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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

		public string PurchaseReturnMasterGetMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				max = sccmd.ExecuteScalar().ToString();
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

		public string TaxRateFromPurchaseDetails(decimal taxId)
		{
			string taxRate = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxRateFromPurchaseDetails", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam2.Value = taxId;
				taxRate = Convert.ToString(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return taxRate;
		}

		public decimal PurchaseReturnMasterAddWithReturnIdentity(PurchaseReturnMasterInfo purchasereturnmasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterAddWithReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam22 = new SqlParameter();
				sprmparam22 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam22.Value = purchasereturnmasterinfo.VoucherNo;
				sprmparam22 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam22.Value = purchasereturnmasterinfo.InvoiceNo;
				sprmparam22 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.SuffixPrefixId;
				sprmparam22 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.VoucherTypeId;
				sprmparam22 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam22.Value = purchasereturnmasterinfo.Date;
				sprmparam22 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.PurchaseMasterId;
				sprmparam22 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.LedgerId;
				sprmparam22 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.Discount;
				sprmparam22 = sccmd.Parameters.Add("@ExchangeRateId", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.ExchangeRateId;
				sprmparam22 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam22.Value = purchasereturnmasterinfo.Narration;
				sprmparam22 = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.PurchaseAccount;
				sprmparam22 = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.TotalTax;
				sprmparam22 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.GrandTotal;
				sprmparam22 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.TotalAmount;
				sprmparam22 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.UserId;
				sprmparam22 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam22.Value = purchasereturnmasterinfo.LrNo;
				sprmparam22 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam22.Value = purchasereturnmasterinfo.TransportationCompany;
				sprmparam22 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam22.Value = purchasereturnmasterinfo.FinancialYearId;
				sprmparam22 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam22.Value = purchasereturnmasterinfo.ExtraDate;
				sprmparam22 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam22.Value = purchasereturnmasterinfo.Extra1;
				sprmparam22 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam22.Value = purchasereturnmasterinfo.Extra2;
				decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decIdentity;
		}

		public DataSet PurchaseReturnPrinting(decimal decPurchaseReturnMasterId, decimal decCompanyId, decimal decPurchaseMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decPurchaseReturnMasterId;
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam4.Value = decCompanyId;
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decPurchaseMasterId;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public void PurchaseReturnMasterAndDetailsDelete(decimal decPurchaseReturnMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterAndDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPurchaseReturnMasterId;
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

		public DataTable PurchaseReturnRegisterFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strInvoiceNo, decimal decAgainstInvoiceNo, decimal decVoucherType)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnRegisterFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("slNo", typeof(decimal));
				dtblReg.Columns["slNo"].AutoIncrement = true;
				dtblReg.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblReg.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param7 = new SqlParameter();
				param7 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param7.Value = fromDate;
				param7 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param7.Value = toDate;
				param7 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				param7.Value = decLedgerId;
				param7 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				param7.Value = strInvoiceNo;
				param7 = sqlda.SelectCommand.Parameters.Add("@againstInvoiceNo", SqlDbType.Decimal);
				param7.Value = decAgainstInvoiceNo;
				param7 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				param7.Value = decVoucherType;
				sqlda.Fill(dtblReg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblReg;
		}

		public DataTable PurchaseReturnMasterViewByPurchaseMasterId(decimal decPurchaseMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseReturnMasterViewAllByPurchaseMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decPurchaseMasterId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable PurchaseReturnViewByPurchaseReturnMasterId(decimal decPurchaseReturnMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseReturnViewByPurchaseReturnMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decPurchaseReturnMasterId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable PurchaseReturnReportGridFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decInvoiceNo, string strProductCode, string strVoucherNo)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnReportGridfill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("slNo", typeof(decimal));
				dtblReg.Columns["slNo"].AutoIncrement = true;
				dtblReg.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblReg.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param8 = new SqlParameter();
				param8 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param8.Value = fromDate;
				param8 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param8.Value = toDate;
				param8 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				param8.Value = decLedgerId;
				param8 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				param8.Value = decVoucherTypeId;
				param8 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				param8.Value = strVoucherNo;
				param8 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.Decimal);
				param8.Value = decInvoiceNo;
				param8 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				param8.Value = strProductCode;
				sqlda.Fill(dtblReg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblReg;
		}

		public DataSet PurchaseReturnReportPrinting(DateTime fromDate, DateTime toDate, decimal decCashOrParty, string strVoucherNo, decimal decVoucherTypeName, decimal decProductCode, decimal decCompanyId, decimal decInvoiceNo)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam9.Value = fromDate;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam9.Value = toDate;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = decCashOrParty;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam9.Value = strVoucherNo;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = decVoucherTypeName;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam9.Value = decProductCode;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam9.Value = decCompanyId;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.Decimal);
				sprmparam9.Value = decInvoiceNo;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public DataTable GetInvoiceNoCorrespondingtoLedgerForPurchaseReturnReport(decimal decLedgerId, decimal decVoucherId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetInvoiceNoCorrespondingtoLedgerForPurchaseReturnReport", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter3.Value = decLedgerId;
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter3.Value = decVoucherId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public bool PurchaseReturnNumberCheckExistence(string strinvoiceNo, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PurchaseReturnNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam3.Value = strinvoiceNo;
				sprmparam3 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}
	}
}
