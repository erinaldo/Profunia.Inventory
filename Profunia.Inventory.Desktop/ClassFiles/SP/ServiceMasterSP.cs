using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ServiceMasterSP : DBConnection
	{
		public decimal ServiceMasterAdd(ServiceMasterInfo servicemasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam22 = new SqlParameter();
				sprmparam22 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.ServiceMasterId;
				sprmparam22 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam22.Value = servicemasterinfo.VoucherNo;
				sprmparam22 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam22.Value = servicemasterinfo.InvoiceNo;
				sprmparam22 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.SuffixPrefixId;
				sprmparam22 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam22.Value = servicemasterinfo.Date;
				sprmparam22 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.LedgerId;
				sprmparam22 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.TotalAmount;
				sprmparam22 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam22.Value = servicemasterinfo.Narration;
				sprmparam22 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.UserId;
				sprmparam22 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam22.Value = servicemasterinfo.CreditPeriod;
				sprmparam22 = sccmd.Parameters.Add("@serviceAccount", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.ServiceAccount;
				sprmparam22 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.ExchangeRateId;
				sprmparam22 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.EmployeeId;
				sprmparam22 = sccmd.Parameters.Add("@customer", SqlDbType.VarChar);
				sprmparam22.Value = servicemasterinfo.Customer;
				sprmparam22 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.Discount;
				sprmparam22 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.GrandTotal;
				sprmparam22 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.VoucherTypeId;
				sprmparam22 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam22.Value = servicemasterinfo.FinancialYearId;
				sprmparam22 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam22.Value = servicemasterinfo.ExtraDate;
				sprmparam22 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam22.Value = servicemasterinfo.Extra1;
				sprmparam22 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam22.Value = servicemasterinfo.Extra2;
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

		public decimal ServiceMasterAddReturnWithIdentity(ServiceMasterInfo servicemasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceMasterAddReturnWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam21.Value = servicemasterinfo.VoucherNo;
				sprmparam21 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam21.Value = servicemasterinfo.InvoiceNo;
				sprmparam21 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.SuffixPrefixId;
				sprmparam21 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam21.Value = servicemasterinfo.Date;
				sprmparam21 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.LedgerId;
				sprmparam21 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.TotalAmount;
				sprmparam21 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam21.Value = servicemasterinfo.Narration;
				sprmparam21 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.UserId;
				sprmparam21 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam21.Value = servicemasterinfo.CreditPeriod;
				sprmparam21 = sccmd.Parameters.Add("@serviceAccount", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.ServiceAccount;
				sprmparam21 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.ExchangeRateId;
				sprmparam21 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.EmployeeId;
				sprmparam21 = sccmd.Parameters.Add("@customer", SqlDbType.VarChar);
				sprmparam21.Value = servicemasterinfo.Customer;
				sprmparam21 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.Discount;
				sprmparam21 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.GrandTotal;
				sprmparam21 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.VoucherTypeId;
				sprmparam21 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam21.Value = servicemasterinfo.FinancialYearId;
				sprmparam21 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam21.Value = servicemasterinfo.ExtraDate;
				sprmparam21 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam21.Value = servicemasterinfo.Extra1;
				sprmparam21 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam21.Value = servicemasterinfo.Extra2;
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

		public void ServiceMasterEdit(ServiceMasterInfo servicemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam20 = new SqlParameter();
				sprmparam20 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.ServiceMasterId;
				sprmparam20 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.SuffixPrefixId;
				sprmparam20 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam20.Value = servicemasterinfo.Date;
				sprmparam20 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.LedgerId;
				sprmparam20 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.TotalAmount;
				sprmparam20 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam20.Value = servicemasterinfo.Narration;
				sprmparam20 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.UserId;
				sprmparam20 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam20.Value = servicemasterinfo.CreditPeriod;
				sprmparam20 = sccmd.Parameters.Add("@serviceAccount", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.ServiceAccount;
				sprmparam20 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.ExchangeRateId;
				sprmparam20 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.EmployeeId;
				sprmparam20 = sccmd.Parameters.Add("@customer", SqlDbType.VarChar);
				sprmparam20.Value = servicemasterinfo.Customer;
				sprmparam20 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.Discount;
				sprmparam20 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.GrandTotal;
				sprmparam20 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.VoucherTypeId;
				sprmparam20 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam20.Value = servicemasterinfo.FinancialYearId;
				sprmparam20 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam20.Value = servicemasterinfo.ExtraDate;
				sprmparam20 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam20.Value = servicemasterinfo.Extra1;
				sprmparam20 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam20.Value = servicemasterinfo.Extra2;
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

		public DataTable ServiceMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceMasterViewAll", base.sqlcon);
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

		public ServiceMasterInfo ServiceMasterView(decimal serviceMasterId)
		{
			ServiceMasterInfo servicemasterinfo = new ServiceMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = serviceMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					servicemasterinfo.ServiceMasterId = decimal.Parse(((DbDataReader)sdrreader)["serviceMasterId"].ToString());
					servicemasterinfo.VoucherNo = ((DbDataReader)sdrreader)["voucherNo"].ToString();
					servicemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)["invoiceNo"].ToString();
					servicemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)["suffixPrefixId"].ToString());
					servicemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)["date"].ToString());
					servicemasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)["ledgerId"].ToString());
					servicemasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)["totalAmount"].ToString());
					servicemasterinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					servicemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)["userId"].ToString());
					servicemasterinfo.CreditPeriod = int.Parse(((DbDataReader)sdrreader)["creditPeriod"].ToString());
					servicemasterinfo.ServiceAccount = decimal.Parse(((DbDataReader)sdrreader)["serviceAccount"].ToString());
					servicemasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)["exchangeRateId"].ToString());
					servicemasterinfo.EmployeeId = Convert.ToDecimal(((DbDataReader)sdrreader)["employeeId"].ToString());
					servicemasterinfo.Customer = ((DbDataReader)sdrreader)["customer"].ToString();
					servicemasterinfo.Discount = decimal.Parse(((DbDataReader)sdrreader)["discount"].ToString());
					servicemasterinfo.GrandTotal = decimal.Parse(((DbDataReader)sdrreader)["grandTotal"].ToString());
					servicemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
					servicemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)["financialYearId"].ToString());
					servicemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)["extraDate"].ToString());
					servicemasterinfo.Extra1 = ((DbDataReader)sdrreader)["extra1"].ToString();
					servicemasterinfo.Extra2 = ((DbDataReader)sdrreader)["extra2"].ToString();
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
			return servicemasterinfo;
		}

		public void ServiceMasterDelete(decimal ServiceMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = ServiceMasterId;
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

		public int ServiceMasterGetMax(decimal decVoucherTypeId)
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceVoucherMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public bool ServiceVoucherCheckExistence(string strInvoiceNo, decimal voucherTypeId, decimal masterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceVoucherCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strInvoiceNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam4.Value = masterId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					trueOrfalse = (int.Parse(obj.ToString()) == 0 && true);
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
			return trueOrfalse;
		}

		public DataTable ServiceVoucherRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, string strVoucherNo, string strLedgerName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ServiceRegisterSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtdateFrom;
				sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtdateTo;
				sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable ServiceReportSearch(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherTypeName, string strLedgerName, string strEmployeeName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ServiceReportSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtDateFrom;
				sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtDateTo;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		internal DataSet ServiceVoucherPrinting(decimal decserviceMasterId, decimal decCompanyId, decimal decExchangeRateId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decserviceMasterId;
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam4.Value = decCompanyId;
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam4.Value = decExchangeRateId;
				sdaadapter.Fill(dSt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dSt;
		}

		public DataTable LedgerPostingIdByServiceMaasterId(decimal decServiceMasterId)
		{
			DataTable dtblServiceMasterId = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingIdByServiceMaasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decServiceMasterId;
				sdaadapter.Fill(dtblServiceMasterId);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblServiceMasterId;
		}

		public DataTable ServiceReport(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherTypeName, string strLedgerName, string strEmployeeName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(int));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ServiceReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtDateFrom;
				sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtDateTo;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public ServiceMasterInfo GetServiceVoucherTypeIdByServiceMasterIdAndVocherNo(decimal decServiceMasterId, decimal decVoucherNo)
		{
			ServiceMasterInfo servicemasterinfo = new ServiceMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GetServiceVoucherTypeIdByServiceMasterIdAndVocherNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decServiceMasterId;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherNo;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					servicemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
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
			return servicemasterinfo;
		}

		public void ServiceVoucherDelete(decimal decPartyBalanceId, decimal decVoucherTypeId, string strVoucherNo, decimal decServiceMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceVoucherDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
				sprmparam5.Value = decPartyBalanceId;
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = decVoucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam5.Value = strVoucherNo;
				sprmparam5 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decServiceMasterId;
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
	}
}
