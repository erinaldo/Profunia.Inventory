using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class CreditNoteMasterSP : DBConnection
	{
		public decimal CreditNoteMasterAdd(CreditNoteMasterInfo creditnotemasterinfo)
		{
			decimal identity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam12.Value = creditnotemasterinfo.VoucherNo;
				sprmparam12 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam12.Value = creditnotemasterinfo.InvoiceNo;
				sprmparam12 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotemasterinfo.SuffixPrefixId;
				sprmparam12 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam12.Value = creditnotemasterinfo.Date;
				sprmparam12 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotemasterinfo.UserId;
				sprmparam12 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam12.Value = creditnotemasterinfo.TotalAmount;
				sprmparam12 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam12.Value = creditnotemasterinfo.Narration;
				sprmparam12 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotemasterinfo.FinancialYearId;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = creditnotemasterinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = creditnotemasterinfo.Extra2;
				sprmparam12 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotemasterinfo.VoucherTypeId;
				identity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return identity;
		}

		public DataTable CreditNoteRegisterSearch(string strVoucherNo, string strFromDate, string strToDate)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteRegisterSearch", base.sqlcon);
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

		public decimal CreditNoteMasterEdit(CreditNoteMasterInfo creditnotemasterinfo)
		{
			decimal decCreditNoteMaster = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
				sprmparam14.Value = creditnotemasterinfo.CreditNoteMasterId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = creditnotemasterinfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = creditnotemasterinfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = creditnotemasterinfo.SuffixPrefixId;
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = creditnotemasterinfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam14.Value = creditnotemasterinfo.UserId;
				sprmparam14 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = creditnotemasterinfo.TotalAmount;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = creditnotemasterinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = creditnotemasterinfo.FinancialYearId;
				sprmparam14 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam14.Value = creditnotemasterinfo.ExtraDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = creditnotemasterinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = creditnotemasterinfo.Extra2;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = creditnotemasterinfo.VoucherTypeId;
				decCreditNoteMaster = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decCreditNoteMaster;
		}

		public DataTable CreditNoteMasterViewAll()
		{
			DataTable dtblCreditNote = new DataTable();
			dtblCreditNote.Columns.Add("SL.NO", typeof(decimal));
			dtblCreditNote.Columns["SL.NO"].AutoIncrement = true;
			dtblCreditNote.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtblCreditNote.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteMasterViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtblCreditNote);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblCreditNote;
		}

		public CreditNoteMasterInfo CreditNoteMasterView(decimal creditNoteMasterId)
		{
			CreditNoteMasterInfo creditnotemasterinfo = new CreditNoteMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
				sprmparam2.Value = creditNoteMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					creditnotemasterinfo.CreditNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					creditnotemasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					creditnotemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					creditnotemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					creditnotemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					creditnotemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					creditnotemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					creditnotemasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					creditnotemasterinfo.Narration = ((DbDataReader)sdrreader)[8].ToString();
					creditnotemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					creditnotemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[10].ToString());
					creditnotemasterinfo.Extra1 = ((DbDataReader)sdrreader)[11].ToString();
					creditnotemasterinfo.Extra2 = ((DbDataReader)sdrreader)[12].ToString();
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
			return creditnotemasterinfo;
		}

		public void CreditNoteMasterDelete(decimal CreditNoteMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
				sprmparam2.Value = CreditNoteMasterId;
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

		public string CreditNoteMasterGetMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteMasterMax", base.sqlcon);
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

		public decimal CreditNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteMasterMax", base.sqlcon);
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

		public bool CreditNoteCheckExistence(string strInvoiceNo, decimal voucherTypeId, decimal decMasterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strInvoiceNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@masterId", SqlDbType.Decimal);
				sprmparam4.Value = decMasterId;
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

		public DataTable CreditNoteReportSearch(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteReportSearch", base.sqlcon);
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

		internal DataSet CreditNotePrinting(decimal decCreditNoteMasterId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNotePrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@CreditNoteMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decCreditNoteMasterId;
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

		public DataSet CreditNoteReportPrinting(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decCompanyId)
		{
			DataSet dst = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteReportPrinting", base.sqlcon);
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
				MessageBox.Show("CNMSP :1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dst;
		}

		public void CreditNoteVoucherDelete(decimal decCreditNoteMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteVoucherDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decCreditNoteMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("CNM:2" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public decimal CreditNoteMasterIdView(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteMasterIdView", base.sqlcon);
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
