using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesQuotationMasterSP : DBConnection
	{
		public decimal SalesQuotationMasterAdd(SalesQuotationMasterInfo salesquotationmasterinfo)
		{
			decimal decSalesQuotationmasterIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.SuffixPrefixId;
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = salesquotationmasterinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.PricinglevelId;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.EmployeeId;
				sprmparam17 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.userId;
				sprmparam17 = sccmd.Parameters.Add("@approved", SqlDbType.Bit);
				sprmparam17.Value = salesquotationmasterinfo.Approved;
				sprmparam17 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.TotalAmount;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.FinancialYearId;
				sprmparam17 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.ExchangeRateId;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.Extra2;
				decSalesQuotationmasterIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decSalesQuotationmasterIdentity;
		}

		public void SalesQuotationMasterEdit(SalesQuotationMasterInfo salesquotationmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.QuotationMasterId;
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.SuffixPrefixId;
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = salesquotationmasterinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.PricinglevelId;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.EmployeeId;
				sprmparam17 = sccmd.Parameters.Add("@approved", SqlDbType.Bit);
				sprmparam17.Value = salesquotationmasterinfo.Approved;
				sprmparam17 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.TotalAmount;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.FinancialYearId;
				sprmparam17 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam17.Value = salesquotationmasterinfo.ExchangeRateId;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = salesquotationmasterinfo.Extra2;
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

		public DataTable SalesQuotationMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationMasterViewAll", base.sqlcon);
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

		public DataTable SalesQuotationRegisterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
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
				SqlCommand sccmd = new SqlCommand("SalesQuotationRegisterSearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@quotationNo", SqlDbType.VarChar);
				sprmparam6.Value = strInvoiceNo;
				sprmparam6 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam6.Value = decLedgerId;
				sprmparam6 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam6.Value = FromDate;
				sprmparam6 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam6.Value = ToDate;
				sprmparam6 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam6.Value = strCondition;
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

		public DataTable SalesQuotationReportSearch(string strVoucherNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition, decimal EmployeeId, decimal voucherTypeId, string ProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sccmd = new SqlCommand("SalesQuotationReportSearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam9.Value = strVoucherNo;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = decLedgerId;
				sprmparam9 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam9.Value = FromDate;
				sprmparam9 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam9.Value = ToDate;
				sprmparam9 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam9.Value = strCondition;
				sprmparam9 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam9.Value = EmployeeId;
				sprmparam9 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = voucherTypeId;
				sprmparam9 = sccmd.Parameters.Add("@ProductCode", SqlDbType.VarChar);
				sprmparam9.Value = ProductCode;
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

		public SalesQuotationMasterInfo SalesQuotationMasterView(decimal quotationMasterId)
		{
			SalesQuotationMasterInfo salesquotationmasterinfo = new SalesQuotationMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam2.Value = quotationMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesquotationmasterinfo.QuotationMasterId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					salesquotationmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					salesquotationmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					salesquotationmasterinfo.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sdrreader)[3].ToString());
					salesquotationmasterinfo.SuffixPrefixId = Convert.ToDecimal(((DbDataReader)sdrreader)[4].ToString());
					salesquotationmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					salesquotationmasterinfo.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrreader)[6].ToString());
					salesquotationmasterinfo.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader)[7].ToString());
					salesquotationmasterinfo.EmployeeId = Convert.ToDecimal(((DbDataReader)sdrreader)[8].ToString());
					salesquotationmasterinfo.Approved = bool.Parse(((DbDataReader)sdrreader)[9].ToString());
					salesquotationmasterinfo.TotalAmount = Convert.ToDecimal(((DbDataReader)sdrreader)[10].ToString());
					salesquotationmasterinfo.Narration = ((DbDataReader)sdrreader)[11].ToString();
					salesquotationmasterinfo.FinancialYearId = Convert.ToDecimal(((DbDataReader)sdrreader)[12].ToString());
					salesquotationmasterinfo.ExchangeRateId = Convert.ToDecimal(((DbDataReader)sdrreader)[13].ToString());
					salesquotationmasterinfo.Extra1 = ((DbDataReader)sdrreader)[14].ToString();
					salesquotationmasterinfo.Extra2 = ((DbDataReader)sdrreader)[15].ToString();
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
			return salesquotationmasterinfo;
		}

		public decimal SalesQuotationMasterDelete(decimal quotationMasterId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam2.Value = quotationMasterId;
				int ineffectedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
				if (ineffectedRow > 0)
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

		public int SalesQuotationMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationMasterMax", base.sqlcon);
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

		public decimal SalesQuotationMaxGetPlusOne(decimal voucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationMasterGetMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = voucherTypeId;
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

		public string SalesQuotationMasterGetMax(decimal voucherTypeId)
		{
			string max = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationMasterGetMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = voucherTypeId;
				max = Convert.ToString(sccmd.ExecuteScalar());
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

		public decimal CheckingStastusForSalesQuotation(decimal decSaleQuotationMasterId)
		{
			decimal decCount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckingStastusForSalesQuotation", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSaleQuotationMasterId;
				decCount = Convert.ToDecimal(sccmd.ExecuteScalar());
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

		public DataSet SalesQuotationPrinting(decimal decSalesQuotationMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesQuotationPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesQuotationMasterId;
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

		public bool CheckSalesQuotationNumberExistance(string strInvoiceNo, decimal decSalesQuotationVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("CheckSalesQuotationNumberExistance", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam3.Value = strInvoiceNo;
				sprmparam3 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decSalesQuotationVoucherTypeId;
				isEdit = Convert.ToBoolean(sqlcmd.ExecuteScalar());
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

		public bool SalesQuotationRefererenceCheckForEditMaster(decimal decSalesQuotationMasterId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesQuotationRefererenceCheckForEditMaster", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesQuotationMasterId;
				isEdit = Convert.ToBoolean(sqlcmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public DataTable QuotationMasterViewByQuotationMasterId(decimal decQuotationMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("QuotationMasterViewByQuotationMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decQuotationMasterId;
				sqldataadapter.Fill(dtbl);
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

		public DataTable GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt(decimal decLedgerId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter2.Value = decLedgerId;
				sqldataadapter.Fill(dtbl);
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

		public DataTable GetSalesQuotationNumberCorrespondingToLedgerForDN(decimal decLedgerId, decimal decVoucherTypeId, decimal decDeliveryNoteMasterId)
		{
			DataTable dtbLQuotation = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapeter = new SqlDataAdapter("GetSalesQuotationNumberCorrespondingToLedgerForDN", base.sqlcon);
				sqldataadapeter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter4 = new SqlParameter();
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlParameter4.Value = decLedgerId;
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlParameter4.Value = decVoucherTypeId;
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlParameter4.Value = decDeliveryNoteMasterId;
				sqldataadapeter.Fill(dtbLQuotation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbLQuotation;
		}

		public DataTable GetSalesQuotationNumberCorrespondingToLedger(decimal decLedgerId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesQuotationNumberCorrespondingToLedger", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter3.Value = decLedgerId;
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter3.Value = decVoucherTypeId;
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

		public DataTable SalesQuotationMasterBatchFill(DataGridView dgvproduct, decimal DecProductId, int InRowIndex)
		{
			DataTable dtblBatchViewAll = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationMasterBatchFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sqlparameter2.Value = DecProductId;
				sdaadapter.Fill(dtblBatchViewAll);
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			try
			{
				DataGridViewComboBoxCell dgvcmbBatch = (DataGridViewComboBoxCell)dgvproduct[dgvproduct.Columns["dgvcmbBatch"].Index, InRowIndex];
				if (dtblBatchViewAll.Rows.Count > 0)
				{
					dgvcmbBatch.DataSource = dtblBatchViewAll;
					dgvcmbBatch.DisplayMember = "batchNo";
					dgvcmbBatch.ValueMember = "batchId";
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			return dtblBatchViewAll;
		}

		public DataTable SalesQuotationMasterViewByQuotationMasterId(decimal decQuotationMasterId)
		{
			DataTable dtblQuotationmaster = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesQuotationMasterViewByQuotationMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decQuotationMasterId;
				sqlda.Fill(dtblQuotationmaster);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblQuotationmaster;
		}

		public DataTable SalesInvoiceGridfillAgainestQuotation(decimal decQuotationMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestQuotation", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decQuotationMasterId;
				sqldataadapter.Fill(dtbl);
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

		public DataTable GetSalesQuotationIncludePendingCorrespondingtoLedgerForSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbLQuotation = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapeter = new SqlDataAdapter("GetSalesQuotationIncludePendingCorrespondingtoLedgerForSI", base.sqlcon);
				sqldataadapeter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter4 = new SqlParameter();
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlParameter4.Value = decLedgerId;
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlParameter4.Value = decSalesMasterId;
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlParameter4.Value = decVoucherTypeId;
				sqldataadapeter.Fill(dtbLQuotation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbLQuotation;
		}

		public DataTable GetSalesQuotationNumberCorrespondingToLedgerForSO(decimal decLedgerId, decimal decVoucherTypeId, decimal decSalesOrderMasterId)
		{
			DataTable dtblQuotation = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapeter = new SqlDataAdapter("GetSalesQuotationNumberCorrespondingToLedgerForSO", base.sqlcon);
				sqldataadapeter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter4 = new SqlParameter();
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlParameter4.Value = decLedgerId;
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlParameter4.Value = decVoucherTypeId;
				sqlParameter4 = sqldataadapeter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sqlParameter4.Value = decSalesOrderMasterId;
				sqldataadapeter.Fill(dtblQuotation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblQuotation;
		}
	}
}
