using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DailySalaryVoucherMasterSP : DBConnection
	{
		public void DailySalaryVoucherMasterAdd(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam15.Value = dailysalaryvouchermasterinfo.DailySalaryVoucehrMasterId;
				sprmparam15 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam15.Value = dailysalaryvouchermasterinfo.LedgerId;
				sprmparam15 = sccmd.Parameters.Add("@voucherNumber", SqlDbType.VarChar);
				sprmparam15.Value = dailysalaryvouchermasterinfo.VoucherNo;
				sprmparam15 = sccmd.Parameters.Add("@invoiceNumber", SqlDbType.VarChar);
				sprmparam15.Value = dailysalaryvouchermasterinfo.InvoiceNo;
				sprmparam15 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam15.Value = dailysalaryvouchermasterinfo.Date;
				sprmparam15 = sccmd.Parameters.Add("@salaryDate", SqlDbType.DateTime);
				sprmparam15.Value = dailysalaryvouchermasterinfo.SalaryDate;
				sprmparam15 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam15.Value = dailysalaryvouchermasterinfo.TotalAmount;
				sprmparam15 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam15.Value = dailysalaryvouchermasterinfo.Narration;
				sprmparam15 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam15.Value = dailysalaryvouchermasterinfo.ExtraDate;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = dailysalaryvouchermasterinfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = dailysalaryvouchermasterinfo.Extra2;
				sprmparam15 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam15.Value = dailysalaryvouchermasterinfo.SuffixPrefixId;
				sprmparam15 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam15.Value = dailysalaryvouchermasterinfo.VoucherTypeId;
				sprmparam15 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam15.Value = dailysalaryvouchermasterinfo.FinancialYearId;
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

		public void DailySalaryVoucherMasterEdit(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.DailySalaryVoucehrMasterId;
				sprmparam14 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.LedgerId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@salaryDate", SqlDbType.DateTime);
				sprmparam14.Value = dailysalaryvouchermasterinfo.SalaryDate;
				sprmparam14 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.TotalAmount;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Extra2;
				sprmparam14 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.SuffixPrefixId;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.FinancialYearId;
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

		public DataTable DailySalaryVoucherMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DailySalaryVoucherMasterViewAll", base.sqlcon);
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

		public DailySalaryVoucherMasterInfo DailySalaryVoucherMasterView(decimal dailySalaryVoucehrMasterId)
		{
			DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo = new DailySalaryVoucherMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam2.Value = dailySalaryVoucehrMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					dailysalaryvouchermasterinfo.DailySalaryVoucehrMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					dailysalaryvouchermasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					dailysalaryvouchermasterinfo.VoucherNo = ((DbDataReader)sdrreader)[2].ToString();
					dailysalaryvouchermasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[3].ToString();
					dailysalaryvouchermasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					dailysalaryvouchermasterinfo.SalaryDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					dailysalaryvouchermasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					dailysalaryvouchermasterinfo.Narration = ((DbDataReader)sdrreader)[7].ToString();
					dailysalaryvouchermasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[8].ToString());
					dailysalaryvouchermasterinfo.Extra1 = ((DbDataReader)sdrreader)[9].ToString();
					dailysalaryvouchermasterinfo.Extra2 = ((DbDataReader)sdrreader)[10].ToString();
					dailysalaryvouchermasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					dailysalaryvouchermasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
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
			return dailysalaryvouchermasterinfo;
		}

		public void DailySalaryVoucherMasterDelete(decimal DailySalaryVoucehrMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam2.Value = DailySalaryVoucehrMasterId;
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

		public string DailySalaryVoucherMasterGetMax(decimal voucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = voucherTypeId;
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
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterMax", base.sqlcon);
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

		public DataTable DailySalaryVoucherMasterAddWithIdentity(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo, bool IsAutomatic)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DailySalaryVoucherMasterAddWithIdentity", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.LedgerId;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.VoucherNo;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.InvoiceNo;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Date;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@salaryDate", SqlDbType.DateTime);
				sprmparam14.Value = dailysalaryvouchermasterinfo.SalaryDate;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.TotalAmount;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Narration;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Extra1;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = dailysalaryvouchermasterinfo.Extra2;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.SuffixPrefixId;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.VoucherTypeId;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@isAutomatic", SqlDbType.Bit);
				sprmparam14.Value = IsAutomatic;
				sprmparam14 = sqlda.SelectCommand.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = dailysalaryvouchermasterinfo.FinancialYearId;
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

		public DataTable DailySalaryVoucherCashOrBankLedgersComboFill()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", base.sqlcon);
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
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

		public DataTable DailySalaryRegisterSearch(DateTime dtVoucherDateFrom, DateTime dtVoucherDateTo, DateTime dtSalaryDateFrom, DateTime dtSalaryDateTo, string strInvoiceNo)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("DailySalaryRegisterSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherDateFrom", SqlDbType.DateTime).Value = dtVoucherDateFrom;
				sqlda.SelectCommand.Parameters.Add("@voucherDateTo", SqlDbType.DateTime).Value = dtVoucherDateTo;
				sqlda.SelectCommand.Parameters.Add("@salaryDateFrom", SqlDbType.DateTime).Value = dtSalaryDateFrom;
				sqlda.SelectCommand.Parameters.Add("@salaryDateTo", SqlDbType.DateTime).Value = dtSalaryDateTo;
				sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar).Value = strInvoiceNo;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DailySalaryVoucherMasterInfo DailySalaryVoucherViewFromRegister(decimal decDailySalaryVoucehrMasterId)
		{
			DailySalaryVoucherMasterInfo infoDailySalaryVoucherMaster = new DailySalaryVoucherMasterInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DailySalaryVoucherViewFromRegister", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal).Value = decDailySalaryVoucehrMasterId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoDailySalaryVoucherMaster.Date = Convert.ToDateTime(((DbDataReader)sqldr)["date"].ToString());
					infoDailySalaryVoucherMaster.VoucherNo = ((DbDataReader)sqldr)["voucherNo"].ToString();
					infoDailySalaryVoucherMaster.InvoiceNo = ((DbDataReader)sqldr)["invoiceNo"].ToString();
					infoDailySalaryVoucherMaster.SalaryDate = Convert.ToDateTime(((DbDataReader)sqldr)["salaryDate"].ToString());
					infoDailySalaryVoucherMaster.LedgerId = Convert.ToDecimal(((DbDataReader)sqldr)["ledgerId"].ToString());
					infoDailySalaryVoucherMaster.TotalAmount = Convert.ToDecimal(((DbDataReader)sqldr)["totalAmount"].ToString());
					infoDailySalaryVoucherMaster.Narration = ((DbDataReader)sqldr)["narration"].ToString();
					infoDailySalaryVoucherMaster.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sqldr)["voucherTypeId"].ToString());
					infoDailySalaryVoucherMaster.SuffixPrefixId = Convert.ToDecimal(((DbDataReader)sqldr)["suffixPrefixId"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				sqldr.Close();
				base.sqlcon.Close();
			}
			return infoDailySalaryVoucherMaster;
		}

		public bool DailySalaryVoucherCheckExistence(string voucherNumber, decimal voucherTypeId, decimal masterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = voucherNumber;
				sprmparam4 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam4.Value = masterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					trueOrfalse = true;
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
			return trueOrfalse;
		}
	}
}
