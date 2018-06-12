using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseOrderMasterSP : DBConnection
	{
		public decimal PurchaseOrderMasterAdd(PurchaseOrderMasterInfo purchaseordermasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = purchaseordermasterinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = purchaseordermasterinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.SuffixPrefixId;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = purchaseordermasterinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
				sprmparam17.Value = purchaseordermasterinfo.DueDate;
				sprmparam17 = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
				sprmparam17.Value = purchaseordermasterinfo.Cancelled;
				sprmparam17 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.EmployeeId;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = purchaseordermasterinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.TotalAmount;
				sprmparam17 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.UserId;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.FinancialYearId;
				sprmparam17 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam17.Value = purchaseordermasterinfo.exchangeRateId;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = purchaseordermasterinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = purchaseordermasterinfo.Extra2;
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

		public void PurchaseOrderMasterEdit(PurchaseOrderMasterInfo purchaseordermasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam18 = new SqlParameter();
				sprmparam18 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.PurchaseOrderMasterId;
				sprmparam18 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam18.Value = purchaseordermasterinfo.VoucherNo;
				sprmparam18 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam18.Value = purchaseordermasterinfo.InvoiceNo;
				sprmparam18 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.SuffixPrefixId;
				sprmparam18 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.VoucherTypeId;
				sprmparam18 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam18.Value = purchaseordermasterinfo.Date;
				sprmparam18 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.LedgerId;
				sprmparam18 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.exchangeRateId;
				sprmparam18 = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
				sprmparam18.Value = purchaseordermasterinfo.DueDate;
				sprmparam18 = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
				sprmparam18.Value = purchaseordermasterinfo.Cancelled;
				sprmparam18 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.EmployeeId;
				sprmparam18 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam18.Value = purchaseordermasterinfo.Narration;
				sprmparam18 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.TotalAmount;
				sprmparam18 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.UserId;
				sprmparam18 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam18.Value = purchaseordermasterinfo.FinancialYearId;
				sprmparam18 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam18.Value = purchaseordermasterinfo.Extra1;
				sprmparam18 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam18.Value = purchaseordermasterinfo.Extra2;
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

		public void PurchaseOrderCancel(decimal purchaseOrderMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderCancel", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseOrderMasterId;
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

		public DataTable PurchaseOrderMasterViewAll(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sccmd = new SqlCommand("PurchaseOrderRgistersearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam7.Value = strInvoiceNo;
				sprmparam7 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam7.Value = decLedgerId;
				sprmparam7 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam7.Value = FromDate;
				sprmparam7 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam7.Value = ToDate;
				sprmparam7 = sccmd.Parameters.Add("@conditon", SqlDbType.VarChar);
				sprmparam7.Value = strCondition;
				sprmparam7 = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
				sprmparam7.Value = PublicVariables._dtCurrentDate;
				sdaadapter.SelectCommand = sccmd;
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

		public DataTable PurchaseOrderOverDueReminder(DateTime FromDate, DateTime ToDate, string strCondition, DateTime dueOn, string decLedgerId)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sccmd = new SqlCommand("PurchaseOrderOverDueReminder", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam6.Value = FromDate;
				sprmparam6 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam6.Value = ToDate;
				sprmparam6 = sccmd.Parameters.Add("@conditon", SqlDbType.VarChar);
				sprmparam6.Value = strCondition;
				sprmparam6 = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
				sprmparam6.Value = dueOn;
				sprmparam6 = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
				sprmparam6.Value = decLedgerId;
				sdaadapter.SelectCommand = sccmd;
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

		public DataTable PurchaseOrdeReportViewAll(string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(int));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sccmd = new SqlCommand("PurchaseOrderReportsearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam8.Value = strInvoiceNo;
				sprmparam8 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam8.Value = decLedgerId;
				sprmparam8 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam8.Value = decVouchertypeId;
				sprmparam8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam8.Value = FromDate;
				sprmparam8 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam8.Value = ToDate;
				sprmparam8 = sccmd.Parameters.Add("@Status", SqlDbType.VarChar);
				sprmparam8.Value = strStatus;
				sprmparam8 = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
				sprmparam8.Value = PublicVariables._dtCurrentDate;
				sdaadapter.SelectCommand = sccmd;
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

		public PurchaseOrderMasterInfo PurchaseOrderMasterView(decimal purchaseOrderMasterId)
		{
			PurchaseOrderMasterInfo purchaseordermasterinfo = new PurchaseOrderMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseOrderMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchaseordermasterinfo.VoucherNo = ((DbDataReader)sdrreader)["voucherNo"].ToString();
					purchaseordermasterinfo.InvoiceNo = ((DbDataReader)sdrreader)["invoiceNo"].ToString();
					purchaseordermasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)["suffixPrefixId"].ToString());
					purchaseordermasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
					purchaseordermasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)["date"].ToString());
					purchaseordermasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)["ledgerId"].ToString());
					purchaseordermasterinfo.DueDate = DateTime.Parse(((DbDataReader)sdrreader)["dueDate"].ToString());
					purchaseordermasterinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					purchaseordermasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)["totalAmount"].ToString());
					purchaseordermasterinfo.exchangeRateId = decimal.Parse(((DbDataReader)sdrreader)["exchangeRateId"].ToString());
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
			return purchaseordermasterinfo;
		}

		public decimal PurchaseOrderMasterDelete(decimal PurchaseOrderMasterId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseOrderMasterId;
				int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
				if (ineffeftedRow > 0)
				{
					decResult = 1m;
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
			return decResult;
		}

		public int PurchaseOrderMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterMax", base.sqlcon);
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

		public string PurchaseOrderVoucherMasterMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderVoucherMasterMax", base.sqlcon);
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

		public string VoucherNoMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherNoMax", base.sqlcon);
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

		public bool PurchaseOrderNumberCheckExistence(string strinvoiceNo, decimal decPurchaseorderMasterId, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PurchaseOrderNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strinvoiceNo;
				sprmparam4 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sqlcmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decPurchaseorderMasterId;
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

		public decimal DueDays(DateTime dtStartDate, DateTime dtEndDate)
		{
			decimal decDueDays = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DueDays", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtStartDate;
				sqlcmd.Parameters.Add("@duedate", SqlDbType.DateTime).Value = dtEndDate;
				decDueDays = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decDueDays;
		}

		public decimal ExchangeRateIdByCurrencyId(decimal decCurrencyId)
		{
			decimal decCount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ExchangeRateIdByCurrencyId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
				object obj = sqlcmd.ExecuteScalar();
				decCount = Convert.ToDecimal(obj.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decCount;
		}

		public bool PurchaseOrderCancelCheckStatus(decimal decPurchaseorderMasterId)
		{
			string str = string.Empty;
			bool isTrue = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderCancelCheckStatus", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPurchaseorderMasterId;
				str = sccmd.ExecuteScalar().ToString();
				isTrue = (str == "True" && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isTrue;
		}

		public DataSet PurchaseOrderPrinting(decimal decPurcahseOrderMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseOrderPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPurcahseOrderMasterId;
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

		public DataSet PurchaseOrderReportPrinting(decimal decCompanyId, string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseOrderReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam9.Value = decCompanyId;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam9.Value = strInvoiceNo;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = decLedgerId;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = decVouchertypeId;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam9.Value = FromDate;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam9.Value = ToDate;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@Status", SqlDbType.VarChar);
				sprmparam9.Value = strStatus;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@currentDate", SqlDbType.DateTime);
				sprmparam9.Value = PublicVariables._dtCurrentDate;
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

		public DataTable PurchaseOrderMasterViewByOrderMasterId(decimal decOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseOrderMasterViewByOrderMasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decOrderMasterId;
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
	}
}
