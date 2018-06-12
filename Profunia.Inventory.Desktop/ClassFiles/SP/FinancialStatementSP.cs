using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class FinancialStatementSP : DBConnection
	{
		public DataSet FundFlow(DateTime strfromDate, DateTime strtoDate)
		{
			DataSet dsetFundflow = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("FundFlow", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strfromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strtoDate;
				sqlda.Fill(dsetFundflow);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dsetFundflow;
		}

		public DataSet BalanceSheet(DateTime fromDate, DateTime toDate)
		{
			DataSet dset = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BalanceSheet", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter prm3 = new SqlParameter();
				prm3 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				prm3.Value = fromDate;
				prm3 = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				prm3.Value = toDate;
				sdaadapter.Fill(dset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dset;
		}

		public DataSet ProfitAndLossAnalysis(DateTime dtFromdate, DateTime dtTodate)
		{
			DataSet dset = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ProfitAndLossAnalysis", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
				sqlda.Fill(dset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dset;
		}

		public DataTable FundFlowReportPrintCompany(decimal decCompanyId)
		{
			DataTable dtblFund = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("FundFlowReportPrintCompany", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
				sqlda.Fill(dtblFund);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblFund;
		}

		public DataTable ProfitAndLossReportPrintCompany(decimal decCompanyId)
		{
			DataTable dtblProfit = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ProfitAndLossReportPrintCompany", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
				sqlda.Fill(dtblProfit);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblProfit;
		}

		public DataSet TrialBalance(DateTime fromDate, DateTime toDate, decimal decAccountGroupId)
		{
			DataTable dtbl = new DataTable();
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("Trialbalance", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;
				sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public decimal StockValueGetOnDate(DateTime date, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
		{
			decimal dcstockValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				object obj = null;
				SqlParameter prm8 = new SqlParameter();
				SqlCommand sccmd = new SqlCommand();
				if (calculationMethod == "FIFO")
				{
					if (isOpeningStock)
					{
						if (!isFromBalanceSheet)
						{
							sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStock", base.sqlcon);
							prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
							prm8.Value = PublicVariables._dtFromDate;
						}
						else
						{
							sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStockForBalancesheet", base.sqlcon);
							prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
							prm8.Value = PublicVariables._dtToDate;
						}
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByFIFO", base.sqlcon);
					}
				}
				else if (calculationMethod == "Average Cost")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByAVCOForOpeningStockForBalanceSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByAVCOForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = PublicVariables._dtToDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByAVCO", base.sqlcon);
					}
				}
				else if (calculationMethod == "High Cost")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByHighCostForOpeningStockBlncSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByHighCostForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = PublicVariables._dtFromDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByHighCost", base.sqlcon);
					}
				}
				else if (calculationMethod == "Low Cost")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByLowCostForOpeningStockForBlncSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByLowCostForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = PublicVariables._dtFromDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByLowCost", base.sqlcon);
					}
				}
				else if (calculationMethod == "Last Purchase Rate")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStockBlncSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = PublicVariables._dtFromDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRate", base.sqlcon);
					}
				}
				sccmd.CommandType = CommandType.StoredProcedure;
				prm8 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				prm8.Value = date;
				obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					decimal.TryParse(obj.ToString(), out dcstockValue);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dcstockValue;
		}

		public decimal StockValueGetOnDate(DateTime date, DateTime dtToDate, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
		{
			decimal dcstockValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				object obj = null;
				SqlParameter prm8 = new SqlParameter();
				SqlCommand sccmd = new SqlCommand();
				if (calculationMethod == "FIFO")
				{
					if (isOpeningStock)
					{
						if (!isFromBalanceSheet)
						{
							sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStock", base.sqlcon);
							prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
							prm8.Value = PublicVariables._dtToDate;
						}
						else
						{
							sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStockForBalancesheet", base.sqlcon);
							prm8 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
							prm8.Value = PublicVariables._dtToDate;
						}
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByFIFO", base.sqlcon);
					}
				}
				else if (calculationMethod == "Average Cost")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByAVCOForOpeningStockForBalanceSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByAVCOForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = dtToDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByAVCO", base.sqlcon);
					}
				}
				else if (calculationMethod == "High Cost")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByHighCostForOpeningStockBlncSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByHighCostForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = PublicVariables._dtToDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByHighCost", base.sqlcon);
					}
				}
				else if (calculationMethod == "Low Cost")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByLowCostForOpeningStockForBlncSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByLowCostForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = PublicVariables._dtToDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByLowCost", base.sqlcon);
					}
				}
				else if (calculationMethod == "Last Purchase Rate")
				{
					if (isOpeningStock)
					{
						sccmd = (isFromBalanceSheet ? new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStockBlncSheet", base.sqlcon) : new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStock", base.sqlcon));
						prm8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
						prm8.Value = dtToDate;
					}
					else
					{
						sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRate", base.sqlcon);
					}
				}
				sccmd.CommandType = CommandType.StoredProcedure;
				prm8 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				prm8.Value = date;
				obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					decimal.TryParse(obj.ToString(), out dcstockValue);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dcstockValue;
		}

		public DataTable DayBook(DateTime dtFromDate, DateTime dtToDate, decimal decVoucherTypeId, decimal decLedgerId, bool blCondenced)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl No");
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DayBook", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sqlda.SelectCommand.Parameters.Add("@iscondensed", SqlDbType.VarChar).Value = blCondenced;
				sqlda.Fill(dtbl);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable DayBookReportPrintCompany()
		{
			DataTable dtblDayBook = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DayBookReportPrintCompany", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblDayBook);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblDayBook;
		}

		public DataSet ProfitAndLossAnalysisUpToaDateForBalansheet(DateTime fromDate, DateTime toDate)
		{
			DataSet dset = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForBalansheet", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter prm3 = new SqlParameter();
				prm3 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				prm3.Value = fromDate;
				prm3 = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				prm3.Value = toDate;
				sdaadapter.Fill(dset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dset;
		}

		public DataSet ProfitAndLossAnalysisUpToaDateForPreviousYears(DateTime toDate)
		{
			DataSet dset = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForPreviousYears", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter prm2 = new SqlParameter();
				prm2 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				prm2.Value = toDate;
				sdaadapter.Fill(dset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dset;
		}

		public DataSet CashFlow(DateTime strfromDate, DateTime strtoDate)
		{
			DataSet dsetCashflow = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("CashFlow", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strfromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strtoDate;
				sqlda.Fill(dsetCashflow);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dsetCashflow;
		}

		public DataTable CashflowReportPrintCompany(decimal decCompanyId)
		{
			DataTable dtblCashFlow = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("CashFlowReportPrintCompany", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblCashFlow);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblCashFlow;
		}

		public DataTable CashOrBankBookGridFill(DateTime fromDate, DateTime toDate, string groupId, bool isShowOpBalance)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankBookGridFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter prm4 = new SqlParameter();
				prm4 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				prm4.Value = fromDate;
				prm4 = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				prm4.Value = toDate;
				prm4 = sdaadapter.SelectCommand.Parameters.Add("@isShowOpeningBalance", SqlDbType.Bit);
				prm4.Value = isShowOpBalance;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("CB01" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}
	}
}
