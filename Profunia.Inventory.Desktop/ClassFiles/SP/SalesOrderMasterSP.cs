using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesOrderMasterSP : DBConnection
	{
		public decimal SalesOrderMasterAdd(SalesOrderMasterInfo salesordermasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam19.Value = salesordermasterinfo.VoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = salesordermasterinfo.InvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.VoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.SuffixPrefixId;
				sprmparam19 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam19.Value = salesordermasterinfo.Date;
				sprmparam19 = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
				sprmparam19.Value = salesordermasterinfo.DueDate;
				sprmparam19 = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
				sprmparam19.Value = salesordermasterinfo.Cancelled;
				sprmparam19 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.LedgerId;
				sprmparam19 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.PricinglevelId;
				sprmparam19 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.EmployeeId;
				sprmparam19 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam19.Value = salesordermasterinfo.Narration;
				sprmparam19 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.TotalAmount;
				sprmparam19 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.UserId;
				sprmparam19 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.QuotationMasterId;
				sprmparam19 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.FinancialYearId;
				sprmparam19 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam19.Value = salesordermasterinfo.ExchangeRateId;
				sprmparam19 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam19.Value = salesordermasterinfo.Extra1;
				sprmparam19 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam19.Value = salesordermasterinfo.Extra2;
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

		public void SalesOrderMasterEdit(SalesOrderMasterInfo salesordermasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam20 = new SqlParameter();
				sprmparam20 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.SalesOrderMasterId;
				sprmparam20 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam20.Value = salesordermasterinfo.VoucherNo;
				sprmparam20 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam20.Value = salesordermasterinfo.InvoiceNo;
				sprmparam20 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.VoucherTypeId;
				sprmparam20 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.SuffixPrefixId;
				sprmparam20 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam20.Value = salesordermasterinfo.Date;
				sprmparam20 = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
				sprmparam20.Value = salesordermasterinfo.DueDate;
				sprmparam20 = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
				sprmparam20.Value = salesordermasterinfo.Cancelled;
				sprmparam20 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.LedgerId;
				sprmparam20 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.PricinglevelId;
				sprmparam20 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.EmployeeId;
				sprmparam20 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam20.Value = salesordermasterinfo.Narration;
				sprmparam20 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.TotalAmount;
				sprmparam20 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.UserId;
				sprmparam20 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.QuotationMasterId;
				sprmparam20 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.FinancialYearId;
				sprmparam20 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam20.Value = salesordermasterinfo.ExchangeRateId;
				sprmparam20 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam20.Value = salesordermasterinfo.Extra1;
				sprmparam20 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam20.Value = salesordermasterinfo.Extra2;
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

		public DataTable SalesOrderMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderMasterViewAll", base.sqlcon);
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

		public SalesOrderMasterInfo SalesOrderMasterView(decimal salesOrderMasterId)
		{
			SalesOrderMasterInfo salesordermasterinfo = new SalesOrderMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesOrderMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesordermasterinfo.SalesOrderMasterId = Convert.ToDecimal(((DbDataReader)sdrreader)["salesOrderMasterId"].ToString());
					salesordermasterinfo.VoucherNo = ((DbDataReader)sdrreader)["voucherNo"].ToString();
					salesordermasterinfo.InvoiceNo = ((DbDataReader)sdrreader)["invoiceNo"].ToString();
					salesordermasterinfo.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
					salesordermasterinfo.SuffixPrefixId = Convert.ToDecimal(((DbDataReader)sdrreader)["suffixPrefixId"].ToString());
					salesordermasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)["date"].ToString());
					salesordermasterinfo.DueDate = DateTime.Parse(((DbDataReader)sdrreader)["dueDate"].ToString());
					salesordermasterinfo.Cancelled = Convert.ToBoolean(((DbDataReader)sdrreader)["cancelled"].ToString());
					salesordermasterinfo.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader)["ledgerId"].ToString());
					salesordermasterinfo.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrreader)["pricinglevelId"].ToString());
					salesordermasterinfo.EmployeeId = Convert.ToDecimal(((DbDataReader)sdrreader)["employeeId"].ToString());
					salesordermasterinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					salesordermasterinfo.TotalAmount = Convert.ToDecimal(((DbDataReader)sdrreader)["totalAmount"].ToString());
					salesordermasterinfo.ExchangeRateId = Convert.ToDecimal(((DbDataReader)sdrreader)["exchangeRateId"].ToString());
					salesordermasterinfo.QuotationMasterId = Convert.ToDecimal(((DbDataReader)sdrreader)["quotationMasterId"].ToString());
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
			return salesordermasterinfo;
		}

		public void SalesOrderMasterDeletee(decimal SalesOrderMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = SalesOrderMasterId;
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

		public decimal SalesOrderMasterDelete(decimal SalesOrderMasterId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = SalesOrderMasterId;
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

		public int SalesOrderMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterMax", base.sqlcon);
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

		public decimal SalesOrderMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterMax1", base.sqlcon);
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

		public string SalesOrderMasterGetMax1(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderMasterMax1", base.sqlcon);
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

		public DataTable SalesInvoiceGridfillAgainestSalesOrder(decimal strOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestSalesOrder", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.VarChar);
				sqlparameter2.Value = strOrderMasterId;
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

		public DataTable SalesOrderMasterViewBySalesOrderMasterId(decimal decSalesOrderMasterId)
		{
			DataTable dtblOrder = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderMasterViewBySalesOrderMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decSalesOrderMasterId;
				sqlda.Fill(dtblOrder);
			}
			catch (Exception ex)
			{
				MessageBox.Show("DNOrder" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblOrder;
		}

		public bool SalesOrderNumberCheckExistence(string strinvoiceNo, decimal decSalesorderMasterId, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesOrderNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strinvoiceNo;
				sprmparam4 = sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decSalesorderMasterId;
				sprmparam4 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
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

		public string SalesOrderVoucherMasterMax(decimal decVoucherTypeId)
		{
			string max = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderVoucherMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
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

		public DataSet SalesOrderPrinting(decimal decSalesOrderMasterId, decimal decCompanyId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decSalesOrderMasterId;
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam3.Value = decCompanyId;
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

		public decimal SalesOrderVoucherMasterMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderVoucherMasterMax", base.sqlcon);
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

		public DataTable SalesOrderRegisterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
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
				SqlCommand sccmd = new SqlCommand("SalesOrderRegisterSearch", base.sqlcon);
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
				sprmparam7 = sccmd.Parameters.Add("@Status", SqlDbType.VarChar);
				sprmparam7.Value = strCondition;
				sprmparam7 = sccmd.Parameters.Add("@CurrentDate", SqlDbType.DateTime);
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

		public DataTable SalesOrderOverDueReminder(DateTime FromDate, DateTime ToDate, string strCondition, DateTime dueOn, string decLedgerId)
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
				SqlCommand sccmd = new SqlCommand("SalesOrderOverDueReminder", base.sqlcon);
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

		public void SalesOrderNoComboFillOfSalesOrderRegister(ComboBox cmbSalesOrderNo, bool isAll)
		{
			DataTable dtblSalesOrderNo = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderNoComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblSalesOrderNo);
				if (isAll)
				{
					DataRow dr = dtblSalesOrderNo.NewRow();
					dr["invoiceNo"] = "All";
					dr["salesOrderMasterId"] = 0;
					dtblSalesOrderNo.Rows.InsertAt(dr, 0);
				}
				cmbSalesOrderNo.DataSource = dtblSalesOrderNo;
				cmbSalesOrderNo.DisplayMember = "invoiceNo";
				cmbSalesOrderNo.ValueMember = "salesOrderMasterId";
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

		public DataTable SalesOrderReportViewAll(string strInvoiceNo, decimal decLedgerId, string strProductCode, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus, decimal decEmployeeId, string strSalesQuotationNo, decimal decAreaId, decimal decGroupId, decimal decRouteId)
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
				SqlCommand sccmd = new SqlCommand("SalesOrderReportSearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam13.Value = strInvoiceNo;
				sprmparam13 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam13.Value = decLedgerId;
				sprmparam13 = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam13.Value = strProductCode;
				sprmparam13 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam13.Value = decVouchertypeId;
				sprmparam13 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam13.Value = FromDate;
				sprmparam13 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam13.Value = ToDate;
				sprmparam13 = sccmd.Parameters.Add("@Status", SqlDbType.VarChar);
				sprmparam13.Value = strStatus;
				sprmparam13 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam13.Value = decEmployeeId;
				sprmparam13 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.VarChar);
				sprmparam13.Value = strSalesQuotationNo;
				sprmparam13 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam13.Value = decAreaId;
				sprmparam13 = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam13.Value = decGroupId;
				sprmparam13 = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
				sprmparam13.Value = decRouteId;
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

		public bool SalesOrderCancelCheckStatus(decimal decSalesOrderMasterId)
		{
			string str = string.Empty;
			bool isTrue = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderCancelCheckStatus", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesOrderMasterId;
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

		public bool SalesOrderRefererenceCheckForEditMaster(decimal decSalesOrderMasterId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesOrderRefererenceCheckForEditMaster", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesOrderMasterId;
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

		public void SalesOrderCancel(decimal salesOrderMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderCancel", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesOrderMasterId;
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

		public DataTable GetSalesOrderNoIncludePendingCorrespondingtoLedgerforSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesOrderNoIncludePendingCorrespondingtoLedgerforSI", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter4.Value = decLedgerId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decSalesMasterId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter4.Value = decVoucherTypeId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable GetSalesOrderNoIncludePendingCorrespondingtoLedgerforDN(decimal decLedgerId, decimal decVoucherTypeId, decimal decdeliveryNoteMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesOrderNoIncludePendingCorrespondingtoLedgerforDN", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter4.Value = decLedgerId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter4.Value = decVoucherTypeId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decdeliveryNoteMasterId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable GetSalesOrderInvoiceNumberCorrespondingToLedgerId(decimal decLedgerId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesOrderInvoiceNumberCorrespondingToLedgerId", base.sqlcon);
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

		public DataTable VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypesBasedOnTypeOfVouchers", base.sqlcon);
			sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
			sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = typeOfVouchers;
			sqlda.Fill(dtbl);
			return dtbl;
		}

		public DataTable SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty1(decimal decSalesOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty1", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sdaadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				param2.Value = decSalesOrderMasterId;
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

		public DataTable SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty(decimal decSalesOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sdaadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				param2.Value = decSalesOrderMasterId;
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
