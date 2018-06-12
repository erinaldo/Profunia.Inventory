using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalaryVoucherMasterSP : DBConnection
	{
		public void SalaryVoucherMasterAdd(SalaryVoucherMasterInfo salaryvouchermasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam15.Value = salaryvouchermasterinfo.SalaryVoucherMasterId;
				sprmparam15 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam15.Value = salaryvouchermasterinfo.LedgerId;
				sprmparam15 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam15.Value = salaryvouchermasterinfo.VoucherNo;
				sprmparam15 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam15.Value = salaryvouchermasterinfo.InvoiceNo;
				sprmparam15 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam15.Value = salaryvouchermasterinfo.Date;
				sprmparam15 = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam15.Value = salaryvouchermasterinfo.Month;
				sprmparam15 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam15.Value = salaryvouchermasterinfo.TotalAmount;
				sprmparam15 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam15.Value = salaryvouchermasterinfo.Narration;
				sprmparam15 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam15.Value = salaryvouchermasterinfo.ExtraDate;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = salaryvouchermasterinfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = salaryvouchermasterinfo.Extra2;
				sprmparam15 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam15.Value = salaryvouchermasterinfo.SuffixPrefixId;
				sprmparam15 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam15.Value = salaryvouchermasterinfo.VoucherTypeId;
				sprmparam15 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam15.Value = salaryvouchermasterinfo.FinancialYearId;
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

		public void SalaryVoucherMasterEdit(SalaryVoucherMasterInfo salaryvouchermasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.SalaryVoucherMasterId;
				sprmparam14 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.LedgerId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = salaryvouchermasterinfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam14.Value = salaryvouchermasterinfo.Month;
				sprmparam14 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.TotalAmount;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.Extra2;
				sprmparam14 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.SuffixPrefixId;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.FinancialYearId;
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

		public DataTable SalaryVoucherMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryVoucherMasterViewAll", base.sqlcon);
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

		public SalaryVoucherMasterInfo SalaryVoucherMasterView(decimal salaryVoucherMasterId)
		{
			SalaryVoucherMasterInfo salaryvouchermasterinfo = new SalaryVoucherMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salaryVoucherMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salaryvouchermasterinfo.SalaryVoucherMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salaryvouchermasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salaryvouchermasterinfo.VoucherNo = ((DbDataReader)sdrreader)[2].ToString();
					salaryvouchermasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[3].ToString();
					salaryvouchermasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					salaryvouchermasterinfo.Month = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					salaryvouchermasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					salaryvouchermasterinfo.Narration = ((DbDataReader)sdrreader)[7].ToString();
					salaryvouchermasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[8].ToString());
					salaryvouchermasterinfo.Extra1 = ((DbDataReader)sdrreader)[9].ToString();
					salaryvouchermasterinfo.Extra2 = ((DbDataReader)sdrreader)[10].ToString();
					salaryvouchermasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					salaryvouchermasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					salaryvouchermasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
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
			return salaryvouchermasterinfo;
		}

		public void SalaryVoucherMasterDelete(decimal SalaryVoucherMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam2.Value = SalaryVoucherMasterId;
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

		public string SalaryVoucherMasterGetMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterMax", base.sqlcon);
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

		public decimal SalaryVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterMax", base.sqlcon);
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

		public DataTable MonthlySalaryVoucherMasterAddWithIdentity(SalaryVoucherMasterInfo salaryvouchermasterinfo, bool IsAutomatic)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("MonthlySalaryVoucherMasterAddWithIdentity", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.LedgerId;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.VoucherNo;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.InvoiceNo;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = salaryvouchermasterinfo.Date;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam14.Value = salaryvouchermasterinfo.Month;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.TotalAmount;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.Narration;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.Extra1;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = salaryvouchermasterinfo.Extra2;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.SuffixPrefixId;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.VoucherTypeId;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = salaryvouchermasterinfo.FinancialYearId;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@isAutomatic", SqlDbType.Bit);
				sprmparam14.Value = IsAutomatic;
				sqlda.Fill(dtbl);
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

		public bool MonthlySalaryVoucherCheckExistence(string voucherNo, decimal voucherTypeId, decimal masterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryVoucherCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = voucherNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam4.Value = masterId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					trueOrfalse = true;
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

		public DataTable MonthlySalaryRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, DateTime dtMonth, string strVoucherNo, string strLedgerName, string strVoucherTypeName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl No", typeof(decimal));
			dtbl.Columns["Sl No"].AutoIncrement = true;
			dtbl.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("MonthlySalaryRegisterSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtdateFrom;
				sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtdateTo;
				sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime).Value = dtMonth;
				sqlda.SelectCommand.Parameters.Add("@VoucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		internal DataSet PaySlipPrinting(decimal decEmployeeId, DateTime dsSalaryMonth, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PaySlipPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam4.Value = decEmployeeId;
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam4.Value = dsSalaryMonth;
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam4.Value = decCompanyId;
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
	}
}
