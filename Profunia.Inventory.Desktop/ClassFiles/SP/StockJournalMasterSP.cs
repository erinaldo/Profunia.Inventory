using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class StockJournalMasterSP : DBConnection
	{
		public decimal StockJournalMasterAdd(StockJournalMasterInfo stockjournalmasterinfo)
		{
			decimal decStockJournalMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam12.Value = stockjournalmasterinfo.VoucherNo;
				sprmparam12 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam12.Value = stockjournalmasterinfo.InvoiceNo;
				sprmparam12 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam12.Value = stockjournalmasterinfo.SuffixPrefixId;
				sprmparam12 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam12.Value = stockjournalmasterinfo.VoucherTypeId;
				sprmparam12 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam12.Value = stockjournalmasterinfo.Date;
				sprmparam12 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam12.Value = stockjournalmasterinfo.Narration;
				sprmparam12 = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
				sprmparam12.Value = stockjournalmasterinfo.AdditionalCost;
				sprmparam12 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam12.Value = stockjournalmasterinfo.FinancialYearId;
				sprmparam12 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam12.Value = stockjournalmasterinfo.FinancialYearId;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = stockjournalmasterinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = stockjournalmasterinfo.Extra2;
				decStockJournalMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStockJournalMasterId;
		}

		public void StockJournalMasterEdit(StockJournalMasterInfo stockjournalmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
				sprmparam13.Value = stockjournalmasterinfo.StockJournalMasterId;
				sprmparam13 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam13.Value = stockjournalmasterinfo.VoucherNo;
				sprmparam13 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam13.Value = stockjournalmasterinfo.InvoiceNo;
				sprmparam13 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam13.Value = stockjournalmasterinfo.SuffixPrefixId;
				sprmparam13 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam13.Value = stockjournalmasterinfo.VoucherTypeId;
				sprmparam13 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam13.Value = stockjournalmasterinfo.Date;
				sprmparam13 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam13.Value = stockjournalmasterinfo.Narration;
				sprmparam13 = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
				sprmparam13.Value = stockjournalmasterinfo.AdditionalCost;
				sprmparam13 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam13.Value = stockjournalmasterinfo.FinancialYearId;
				sprmparam13 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam13.Value = stockjournalmasterinfo.ExtraDate;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = stockjournalmasterinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = stockjournalmasterinfo.Extra2;
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

		public DataTable StockJournalMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("StockJournalMasterViewAll", base.sqlcon);
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

		public StockJournalMasterInfo StockJournalMasterView(decimal stockJournalMasterId)
		{
			StockJournalMasterInfo stockjournalmasterinfo = new StockJournalMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
				sprmparam2.Value = stockJournalMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					stockjournalmasterinfo.StockJournalMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					stockjournalmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					stockjournalmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					stockjournalmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					stockjournalmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					stockjournalmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					stockjournalmasterinfo.Narration = ((DbDataReader)sdrreader)[6].ToString();
					stockjournalmasterinfo.AdditionalCost = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					stockjournalmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					stockjournalmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[9].ToString());
					stockjournalmasterinfo.Extra1 = ((DbDataReader)sdrreader)[10].ToString();
					stockjournalmasterinfo.Extra2 = ((DbDataReader)sdrreader)[11].ToString();
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
			return stockjournalmasterinfo;
		}

		public void StockJournalMasterDelete(decimal StockJournalMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
				sprmparam2.Value = StockJournalMasterId;
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

		public int StockJournalMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalMasterMax", base.sqlcon);
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

		public decimal StockJournalMasterMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockMasterMax", base.sqlcon);
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
			return ++max;
		}

		public decimal StockJournalMasterMax(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockMasterMax", base.sqlcon);
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

		public DataTable StockJournalRegisterGrideFill(DateTime fromDate, DateTime toDate, string invoiceNo)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalRegisterGrideFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("slNo", typeof(decimal));
				dtblReg.Columns["slNo"].AutoIncrement = true;
				dtblReg.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblReg.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param4 = new SqlParameter();
				param4 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param4.Value = fromDate;
				param4 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param4.Value = toDate;
				param4 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				param4.Value = invoiceNo;
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

		public DataTable StockJournalReportGrideFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strinvoiceNo, string strProductCode, string strProductName)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalReportGrideFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("slNo", typeof(int));
				dtblReg.Columns["slNo"].AutoIncrement = true;
				dtblReg.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblReg.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param7 = new SqlParameter();
				param7 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param7.Value = fromDate;
				param7 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param7.Value = toDate;
				param7 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				param7.Value = decVoucherTypeId;
				param7 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				param7.Value = strinvoiceNo;
				param7 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				param7.Value = strProductCode;
				param7 = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				param7.Value = strProductName;
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

		public void VoucherTypeComboFillForStockJournalReport(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
		{
			DataTable dtblVoucherName = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeComboFillForStockJournalReport", base.sqlcon);
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

		public bool StockJournalInvoiceNumberCheckExistence(string strinvoiceNo, decimal decStockMasterId, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("StockJournalInvoiceNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strinvoiceNo;
				sprmparam4 = sqlcmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decStockMasterId;
				sprmparam4 = sqlcmd.Parameters.Add("@vouchertypeId", SqlDbType.Decimal);
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

		public DataTable StockJournalMasterFillForRegisterOrReport(decimal decMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalMasterFillForRegisterOrReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal).Value = decMasterId;
				sqlda.Fill(dtbl);
			}
			catch (Exception)
			{
				throw;
			}
			return dtbl;
		}

		public void StockJournalDeleteAllTables(decimal decStockJournalMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalDeleteAllTables", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decStockJournalMasterId;
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

		public DataSet StockJournalPrinting(decimal decMasterId)
		{
			DataSet dsData = new DataSet();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal).Value = decMasterId;
				sqlda.Fill(dsData);
			}
			catch (Exception)
			{
				throw;
			}
			return dsData;
		}
	}
}
