using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesReturnMasterSP : DBConnection
	{
		public decimal SalesReturnMasterAdd(SalesReturnMasterInfo salesreturnmasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam23 = new SqlParameter();
				sprmparam23 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam23.Value = salesreturnmasterinfo.VoucherNo;
				sprmparam23 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam23.Value = salesreturnmasterinfo.InvoiceNo;
				sprmparam23 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.VoucherTypeId;
				sprmparam23 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.SuffixPrefixId;
				sprmparam23 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.LedgerId;
				sprmparam23 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.SalesMasterId;
				sprmparam23 = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.SalesAccount;
				sprmparam23 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.PricinglevelId;
				sprmparam23 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.EmployeeId;
				sprmparam23 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam23.Value = salesreturnmasterinfo.Narration;
				sprmparam23 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.ExchangeRateId;
				sprmparam23 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.Discount;
				sprmparam23 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.TaxAmount;
				sprmparam23 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.UserId;
				sprmparam23 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam23.Value = salesreturnmasterinfo.LrNo;
				sprmparam23 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam23.Value = salesreturnmasterinfo.TransportationCompany;
				sprmparam23 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam23.Value = salesreturnmasterinfo.Date;
				sprmparam23 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.TotalAmount;
				sprmparam23 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.grandTotal;
				sprmparam23 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam23.Value = salesreturnmasterinfo.FinancialYearId;
				sprmparam23 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam23.Value = salesreturnmasterinfo.Extra1;
				sprmparam23 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam23.Value = salesreturnmasterinfo.Extra2;
				decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
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

		public void SalesReturnMasterEdit(SalesReturnMasterInfo salesreturnmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam24 = new SqlParameter();
				sprmparam24 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.SalesReturnMasterId;
				sprmparam24 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam24.Value = salesreturnmasterinfo.VoucherNo;
				sprmparam24 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam24.Value = salesreturnmasterinfo.InvoiceNo;
				sprmparam24 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.VoucherTypeId;
				sprmparam24 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.SuffixPrefixId;
				sprmparam24 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.LedgerId;
				sprmparam24 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.SalesMasterId;
				sprmparam24 = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.SalesAccount;
				sprmparam24 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.PricinglevelId;
				sprmparam24 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.EmployeeId;
				sprmparam24 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam24.Value = salesreturnmasterinfo.Narration;
				sprmparam24 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.ExchangeRateId;
				sprmparam24 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.Discount;
				sprmparam24 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.TaxAmount;
				sprmparam24 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.UserId;
				sprmparam24 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam24.Value = salesreturnmasterinfo.LrNo;
				sprmparam24 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam24.Value = salesreturnmasterinfo.TransportationCompany;
				sprmparam24 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam24.Value = salesreturnmasterinfo.Date;
				sprmparam24 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.TotalAmount;
				sprmparam24 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.grandTotal;
				sprmparam24 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam24.Value = salesreturnmasterinfo.FinancialYearId;
				sprmparam24 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam24.Value = salesreturnmasterinfo.Extra1;
				sprmparam24 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam24.Value = salesreturnmasterinfo.Extra2;
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

		public DataTable SalesReturnMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnMasterViewAll", base.sqlcon);
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

		public SalesReturnMasterInfo SalesReturnMasterView(decimal salesReturnMasterId)
		{
			SalesReturnMasterInfo salesreturnmasterinfo = new SalesReturnMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesReturnMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesreturnmasterinfo.SalesReturnMasterId = decimal.Parse(((DbDataReader)sdrreader)["salesReturnMasterId"].ToString());
					salesreturnmasterinfo.VoucherNo = ((DbDataReader)sdrreader)["voucherNo"].ToString();
					salesreturnmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					salesreturnmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
					salesreturnmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)["suffixPrefixId"].ToString());
					salesreturnmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)["ledgerId"].ToString());
					salesreturnmasterinfo.SalesAccount = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					salesreturnmasterinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)["pricinglevelId"].ToString());
					salesreturnmasterinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)["employeeId"].ToString());
					salesreturnmasterinfo.Narration = ((DbDataReader)sdrreader)[9].ToString();
					salesreturnmasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)["exchangeRateId"].ToString());
					salesreturnmasterinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)["taxAmount"].ToString());
					salesreturnmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)["userId"].ToString());
					salesreturnmasterinfo.LrNo = ((DbDataReader)sdrreader)[13].ToString();
					salesreturnmasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[14].ToString();
					salesreturnmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)["date"].ToString());
					salesreturnmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)["totalAmount"].ToString());
					salesreturnmasterinfo.grandTotal = decimal.Parse(((DbDataReader)sdrreader)["grandTotal"].ToString());
					salesreturnmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)["financialYearId"].ToString());
					salesreturnmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)["extraDate"].ToString());
					salesreturnmasterinfo.Extra1 = ((DbDataReader)sdrreader)["extra1"].ToString();
					salesreturnmasterinfo.Extra2 = ((DbDataReader)sdrreader)[20].ToString();
					salesreturnmasterinfo.Discount = decimal.Parse(((DbDataReader)sdrreader)["discount"].ToString());
					salesreturnmasterinfo.SalesMasterId = decimal.Parse(((DbDataReader)sdrreader)["salesMasterId"].ToString());
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
			return salesreturnmasterinfo;
		}

		public void SalesReturnMasterAndDetailsDelete(decimal SalesReturnMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDeleteOfMasterAndDetails", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = SalesReturnMasterId;
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

		public decimal SalesReturnMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnMasterMax", base.sqlcon);
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

		public string SalesReturnMasterGetMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnMasterMax", base.sqlcon);
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

		public DataTable SalesReturnInvoiceNoComboFill(decimal decVoucherTypeId, decimal salesReturnMasterId, decimal decledgerId)
		{
			DataTable dtblInvoiceNo = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnInvoiceNoComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam6.Value = decVoucherTypeId;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam4.Value = salesReturnMasterId;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam4.Value = decledgerId;
				sqlda.Fill(dtblInvoiceNo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblInvoiceNo;
		}

		public DataTable SalesReturnVoucherTypeComboFill(decimal ledgerIdFromCashOrPartyCombo)
		{
			DataTable dtblVoucherType = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeViewAllByLedgerId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = ledgerIdFromCashOrPartyCombo;
				sqlda.Fill(dtblVoucherType);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblVoucherType;
		}

		public string SalesReturnIdViewBysalesMasterId(decimal salesMasterId)
		{
			string salesReturnId = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnMasterIdViewBySalesMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesMasterId;
				salesReturnId = Convert.ToString(sccmd.ExecuteScalar());
				if (salesReturnId == string.Empty)
				{
					salesReturnId = "0";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return salesReturnId;
		}

		public string TaxRateFindForTaxAmmountCalByTaxId(decimal taxId)
		{
			string taxRate = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxRateFindBySalesdetailsId", base.sqlcon);
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

		public bool SalesReturnNumberCheckExistence(string strinvoiceNo, decimal decSalesReturnMasterId, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesReturnNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strinvoiceNo;
				sprmparam4 = sqlcmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decSalesReturnMasterId;
				sprmparam4 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
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

		public DataSet SalesReturnPrinting(decimal decSalesReturnMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesReturnMasterId;
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

		public DataSet SalesReturnReportPrinting(DateTime fromDate, DateTime toDate, decimal decSalesMan, decimal decCashOrParty, string strVoucherNo, decimal decVoucherTypeName, string strProductCode)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam8.Value = fromDate;
				sprmparam8 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam8.Value = toDate;
				sprmparam8 = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.VarChar);
				sprmparam8.Value = decSalesMan;
				sprmparam8 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.VarChar);
				sprmparam8.Value = decCashOrParty;
				sprmparam8 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam8.Value = strVoucherNo;
				sprmparam8 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam8.Value = decVoucherTypeName;
				sprmparam8 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam8.Value = strProductCode;
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

		public DataTable SalesReturnRegisterGrideFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strInvoiceNo, decimal decAgainstInvoiceNo, decimal decvouchertypeId)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnRegisterGrideFill", base.sqlcon);
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
				param7.Value = decvouchertypeId;
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

		public DataTable SalesReturnReportGrideFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decEmployeeId, string strProductCode, string strVoucherNo)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnReportGrideFill", base.sqlcon);
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
				param8 = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				param8.Value = decEmployeeId;
				param8 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				param8.Value = strVoucherNo;
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

		public void SalesReturnNoComboFillOfSalesReturnRegister(ComboBox cmbSalesReturnNo, bool isAll)
		{
			DataTable dtblSalesReturnno = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnNoComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblSalesReturnno);
				if (isAll)
				{
					DataRow dr = dtblSalesReturnno.NewRow();
					dr["invoiceNo"] = "All";
					dr["salesReturnMasterId"] = 0;
					dtblSalesReturnno.Rows.InsertAt(dr, 0);
				}
				cmbSalesReturnNo.DataSource = dtblSalesReturnno;
				cmbSalesReturnNo.DisplayMember = "invoiceNo";
				cmbSalesReturnNo.ValueMember = "salesReturnMasterId";
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

		public void InvoiceNoComboFillOfSalesReturnRegister(ComboBox cmbInvoiceNo, bool isAll)
		{
			DataTable dtblInvoiceNo = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("AgainstInvoiceNoComboFillInSalesReturnRegister", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblInvoiceNo);
				if (isAll)
				{
					DataRow dr = dtblInvoiceNo.NewRow();
					dr["invoiceNo"] = "All";
					dr["salesMasterId"] = 0;
					dtblInvoiceNo.Rows.InsertAt(dr, 0);
				}
				cmbInvoiceNo.DataSource = dtblInvoiceNo;
				cmbInvoiceNo.DisplayMember = "invoiceNo";
				cmbInvoiceNo.ValueMember = "salesMasterId";
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

		public void VoucherTypeComboFillOfSalesReturnReport(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
		{
			DataTable dtblVoucherName = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeComboFillForSalesReturnReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@strVoucherType", SqlDbType.VarChar).Value = strVoucherType;
				sqlda.Fill(dtblVoucherName);
				if (isAll)
				{
					DataRow dr = dtblVoucherName.NewRow();
					dr["voucherTypeName"] = "All";
					dr["voucherTypeId"] = 0;
					dtblVoucherName.Rows.InsertAt(dr, 0);
				}
				cmbVoucherType.DataSource = dtblVoucherName;
				cmbVoucherType.DisplayMember = "voucherTypeName";
				cmbVoucherType.ValueMember = "voucherTypeId";
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

		public void SalesManComboFillOfSalesReturnReport(ComboBox cmbSalesMan, bool isAll)
		{
			DataTable dtblSalesManName = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesManComboFillForSalesReturnReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblSalesManName);
				if (isAll)
				{
					DataRow dr = dtblSalesManName.NewRow();
					dr["employeeName"] = "All";
					dr["employeeId"] = 0;
					dtblSalesManName.Rows.InsertAt(dr, 0);
				}
				cmbSalesMan.DataSource = dtblSalesManName;
				cmbSalesMan.DisplayMember = "employeeName";
				cmbSalesMan.ValueMember = "employeeId";
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

		public DataTable SalesReturnMasterViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesReturnMasterViewBySalesReturnMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decSalesReturnMasterId;
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

		public DataTable SalesReturnMasterViewBySalesMasterId(decimal decSalesMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesReturnMasterViewAllBySalesMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decSalesMasterId;
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

		public void SalesReturnDelete(decimal decSalesReturnMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decSalesReturnMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
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

		public DataTable vouchertypecompofill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("vouchertypecompofill", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand = sqlcmd;
				sdaadapter.Fill(dtbl);
				DataRow dr = dtbl.NewRow();
				dr["voucherTypeId"] = 0;
				dr["voucherTypeName"] = "NA";
				dtbl.Rows.InsertAt(dr, 0);
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

		public DataTable invoicenumberviewallforvouchertypeIdforSR(decimal vouchertypeId)
		{
			DataTable dtblInvoiceNo = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("invoicenumberviewallforvouchertypeIdforSR", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = vouchertypeId;
				sqlda.Fill(dtblInvoiceNo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblInvoiceNo;
		}
	}
}
