using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class JournalMasterSP : DBConnection
	{
		public decimal JournalMasterAdd(JournalMasterInfo journalmasterinfo)
		{
			decimal decId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam13.Value = journalmasterinfo.VoucherNo;
				sprmparam13 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam13.Value = journalmasterinfo.InvoiceNo;
				sprmparam13 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam13.Value = journalmasterinfo.SuffixPrefixId;
				sprmparam13 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam13.Value = journalmasterinfo.Date;
				sprmparam13 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam13.Value = journalmasterinfo.TotalAmount;
				sprmparam13 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam13.Value = journalmasterinfo.Narration;
				sprmparam13 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam13.Value = journalmasterinfo.UserId;
				sprmparam13 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam13.Value = journalmasterinfo.VoucherTypeId;
				sprmparam13 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam13.Value = journalmasterinfo.FinancialYearId;
				sprmparam13 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam13.Value = journalmasterinfo.ExtraDate;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = journalmasterinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = journalmasterinfo.Extra2;
				decId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decId;
		}

		public decimal JournalMasterEdit(JournalMasterInfo journalmasterinfo)
		{
			decimal decEffectRow = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
				sprmparam14.Value = journalmasterinfo.JournalMasterId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = journalmasterinfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = journalmasterinfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = journalmasterinfo.SuffixPrefixId;
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = journalmasterinfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = journalmasterinfo.TotalAmount;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = journalmasterinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam14.Value = journalmasterinfo.UserId;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = journalmasterinfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = journalmasterinfo.FinancialYearId;
				sprmparam14 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam14.Value = journalmasterinfo.ExtraDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = journalmasterinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = journalmasterinfo.Extra2;
				decEffectRow = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decEffectRow;
		}

		public DataTable JournalMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalMasterViewAll", base.sqlcon);
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

		public JournalMasterInfo JournalMasterView(decimal journalMasterId)
		{
			JournalMasterInfo journalmasterinfo = new JournalMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
				sprmparam2.Value = journalMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					journalmasterinfo.JournalMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					journalmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					journalmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					journalmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					journalmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					journalmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					journalmasterinfo.Narration = ((DbDataReader)sdrreader)[6].ToString();
					journalmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					journalmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					journalmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					journalmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[10].ToString());
					journalmasterinfo.Extra1 = ((DbDataReader)sdrreader)[11].ToString();
					journalmasterinfo.Extra2 = ((DbDataReader)sdrreader)[12].ToString();
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
			return journalmasterinfo;
		}

		public void JournalMasterDelete(decimal JournalMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
				sprmparam2.Value = JournalMasterId;
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

		public int JournalMasterGetMax(decimal decVoucherTypeId)
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
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

		public decimal JournalMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalMasterMax", base.sqlcon);
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

		public decimal JournalGetMasterId(decimal decVoucherNo)
		{
			decimal decJornalMasterId = 0m;
			SqlDataReader sqldr2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalGetMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam2.Value = decVoucherNo;
				sqldr2 = sccmd.ExecuteReader();
				while (sqldr2.Read())
				{
					decJornalMasterId = decimal.Parse(((DbDataReader)sqldr2)[0].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("JMSP :5" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decJornalMasterId;
		}

		public DataTable JournalMasterViewAllWithSlNo()
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalMasterViewAll", base.sqlcon);
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

		public DataTable JournalRegisterSearch(string strVoucherNo, string strFromDate, string strToDate)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalRegisterSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strFromDate.ToString());
				sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strToDate.ToString());
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

		public bool JournalVoucherCheckExistance(string strInvoiceNo, decimal voucherTypeId, decimal decMasterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalVoucherCheckExistance", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strInvoiceNo;
				sprmparam4 = sccmd.Parameters.Add("@masterId", SqlDbType.Decimal);
				sprmparam4.Value = decMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				trueOrfalse = Convert.ToBoolean(sccmd.ExecuteScalar());
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

		internal DataSet JournalVoucherPrinting(decimal decJournalMasterId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decJournalMasterId;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam3.Value = decCompanyId;
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

		public DataTable JournalReportSearch(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalReportSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strFromDate.ToString());
				sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strToDate.ToString());
				sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
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

		public DataSet JournalReportPrinting(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decCompanyId)
		{
			DataSet dst = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalReportPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam6.Value = decCompanyId;
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam6.Value = Convert.ToDateTime(strFromDate);
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam6.Value = Convert.ToDateTime(strToDate);
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam6.Value = decVoucherTypeId;
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam6.Value = decLedgerId;
				sdaadapter.Fill(dst);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dst;
		}

		public void JournalVoucherDelete(decimal decJournalMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalVoucherDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decJournalMasterId;
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

		public decimal JournalMasterIdView(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalMasterIdView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVouchertypeid;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				decid = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decid;
		}
	}
}
