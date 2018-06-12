using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class RejectionOutMasterSP : DBConnection
	{
		public void RejectionOutMasterAdd(RejectionOutMasterInfo rejectionoutmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.RejectionOutMasterId;
				sprmparam19 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.VoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.InvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.SuffixPrefixId;
				sprmparam19 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.VoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.MaterialReceiptMasterId;
				sprmparam19 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam19.Value = rejectionoutmasterinfo.Date;
				sprmparam19 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.LedgerId;
				sprmparam19 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.Narration;
				sprmparam19 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.ExchangeRateId;
				sprmparam19 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.TotalAmount;
				sprmparam19 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.UserId;
				sprmparam19 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.LrNo;
				sprmparam19 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.TransportationCompany;
				sprmparam19 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.FinancialYearId;
				sprmparam19 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam19.Value = rejectionoutmasterinfo.ExtraDate;
				sprmparam19 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.Extra1;
				sprmparam19 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.Extra2;
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

		public decimal RejectionOutMasterAddWithReturnIdentity(RejectionOutMasterInfo rejectionoutmasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterAddWithReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutmasterinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutmasterinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.SuffixPrefixId;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.MaterialReceiptMasterId;
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = rejectionoutmasterinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutmasterinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.ExchangeRateId;
				sprmparam17 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.TotalAmount;
				sprmparam17 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.UserId;
				sprmparam17 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutmasterinfo.LrNo;
				sprmparam17 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutmasterinfo.TransportationCompany;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutmasterinfo.FinancialYearId;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutmasterinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutmasterinfo.Extra2;
				object obj = Convert.ToDecimal(sccmd.ExecuteScalar());
				if (obj != null)
				{
					decIdentity = Convert.ToDecimal(obj);
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
			return decIdentity;
		}

		public DataTable RejectionOutMasterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate)
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
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterSearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam5.Value = strInvoiceNo;
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decLedgerId;
				sprmparam5 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam5.Value = FromDate;
				sprmparam5 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam5.Value = ToDate;
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

		public void RejectionOutMasterAndDetailsDelete(decimal decRejectionOutMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("RejectionOutMasterAndDetailsDelete", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = cmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				param2.Value = decRejectionOutMasterId;
				cmd.ExecuteNonQuery();
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

		public string GetRejectionOutVoucherNo(decimal decRejectionOutMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("RejectionOutVoucherNoViewByRejectionOutMasterId", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = cmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				param2.Value = decRejectionOutMasterId;
				return cmd.ExecuteScalar().ToString();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void RejectionOutMasterEdit(RejectionOutMasterInfo rejectionoutmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.RejectionOutMasterId;
				sprmparam19 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.VoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.InvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.SuffixPrefixId;
				sprmparam19 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.VoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.MaterialReceiptMasterId;
				sprmparam19 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam19.Value = rejectionoutmasterinfo.Date;
				sprmparam19 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.LedgerId;
				sprmparam19 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.Narration;
				sprmparam19 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.ExchangeRateId;
				sprmparam19 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.TotalAmount;
				sprmparam19 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.UserId;
				sprmparam19 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.LrNo;
				sprmparam19 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.TransportationCompany;
				sprmparam19 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam19.Value = rejectionoutmasterinfo.FinancialYearId;
				sprmparam19 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam19.Value = rejectionoutmasterinfo.ExtraDate;
				sprmparam19 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.Extra1;
				sprmparam19 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam19.Value = rejectionoutmasterinfo.Extra2;
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

		public DataTable RejectionOutMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RejectionOutMasterViewAll", base.sqlcon);
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

		public RejectionOutMasterInfo RejectionOutMasterView(decimal rejectionOutMasterId)
		{
			RejectionOutMasterInfo rejectionoutmasterinfo = new RejectionOutMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam2.Value = rejectionOutMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					rejectionoutmasterinfo.RejectionOutMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					rejectionoutmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					rejectionoutmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					rejectionoutmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					rejectionoutmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					rejectionoutmasterinfo.MaterialReceiptMasterId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					rejectionoutmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
					rejectionoutmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					rejectionoutmasterinfo.Narration = ((DbDataReader)sdrreader)[8].ToString();
					rejectionoutmasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					rejectionoutmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					rejectionoutmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					rejectionoutmasterinfo.LrNo = ((DbDataReader)sdrreader)[12].ToString();
					rejectionoutmasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[13].ToString();
					rejectionoutmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					rejectionoutmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[15].ToString());
					rejectionoutmasterinfo.Extra1 = ((DbDataReader)sdrreader)[16].ToString();
					rejectionoutmasterinfo.Extra2 = ((DbDataReader)sdrreader)[17].ToString();
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
			return rejectionoutmasterinfo;
		}

		public void RejectionOutMasterDelete(decimal RejectionOutMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam2.Value = RejectionOutMasterId;
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

		public decimal RejectionOutMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterMax", base.sqlcon);
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

		public string RejectionOutMasterGetMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutMasterMax", base.sqlcon);
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

		public bool RejectionOutNumberCheckExistence(string strinvoiceNo, decimal decRejectionOutMasterId, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("RejectionOutNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strinvoiceNo;
				sprmparam4 = sqlcmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decRejectionOutMasterId;
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

		public DataSet RejectionOutPrinting(decimal decRejectionOutMasterId, decimal decCompanyId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RejectionOutPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decRejectionOutMasterId;
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

		public DataTable RejectionOutReportFill(string strinvoiceNo, string strProductCode, string strProductName, decimal decLedgerId, DateTime FromDate, DateTime ToDate, decimal decReceiptMasterId, decimal decVoucherTypeId)
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
				SqlCommand sccmd = new SqlCommand("RejectionOutReportFill", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam9.Value = strinvoiceNo;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = decLedgerId;
				sprmparam9 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam9.Value = FromDate;
				sprmparam9 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam9.Value = ToDate;
				sprmparam9 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam9.Value = decReceiptMasterId;
				sprmparam9 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = decVoucherTypeId;
				sprmparam9 = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam9.Value = strProductCode;
				sprmparam9 = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam9.Value = strProductName;
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

		internal DataSet RejectionOutReportPrinting(decimal decmaterialReceiptMasterId, decimal decCompanyId, DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, string strProductCode, string strProductName)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RejectionOutReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param10 = new SqlParameter();
				param10 = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				param10.Value = decmaterialReceiptMasterId;
				param10 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				param10.Value = decCompanyId;
				param10 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param10.Value = fromDate;
				param10 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param10.Value = toDate;
				param10 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				param10.Value = decVoucherTypeId;
				param10 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				param10.Value = strVoucherNo;
				param10 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				param10.Value = decLedgerId;
				param10 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				param10.Value = strProductCode;
				param10 = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				param10.Value = strProductName;
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
	}
}
