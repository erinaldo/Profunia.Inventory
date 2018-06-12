using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DebitNoteMasterSP : DBConnection
	{
		public decimal DebitNoteMasterAdd(DebitNoteMasterInfo debitnotemasterinfo)
		{
			decimal decDebitNoteMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam12.Value = debitnotemasterinfo.VoucherNo;
				sprmparam12 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam12.Value = debitnotemasterinfo.InvoiceNo;
				sprmparam12 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotemasterinfo.SuffixPrefixId;
				sprmparam12 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam12.Value = debitnotemasterinfo.Date;
				sprmparam12 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotemasterinfo.UserId;
				sprmparam12 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam12.Value = debitnotemasterinfo.TotalAmount;
				sprmparam12 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam12.Value = debitnotemasterinfo.Narration;
				sprmparam12 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotemasterinfo.FinancialYearId;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = debitnotemasterinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = debitnotemasterinfo.Extra2;
				sprmparam12 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotemasterinfo.VoucherTypeId;
				decDebitNoteMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decDebitNoteMasterId;
		}

		public decimal DebitNoteMasterEdit(DebitNoteMasterInfo debitnotemasterinfo)
		{
			decimal decEffectRow = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
				sprmparam14.Value = debitnotemasterinfo.DebitNoteMasterId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = debitnotemasterinfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = debitnotemasterinfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = debitnotemasterinfo.SuffixPrefixId;
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = debitnotemasterinfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = debitnotemasterinfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam14.Value = debitnotemasterinfo.UserId;
				sprmparam14 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = debitnotemasterinfo.TotalAmount;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = debitnotemasterinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = debitnotemasterinfo.FinancialYearId;
				sprmparam14 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam14.Value = debitnotemasterinfo.ExtraDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = debitnotemasterinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = debitnotemasterinfo.Extra2;
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

		public DataTable DebitNoteMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteMasterViewAll", base.sqlcon);
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

		public DebitNoteMasterInfo DebitNoteMasterView(decimal debitNoteMasterId)
		{
			DebitNoteMasterInfo debitnotemasterinfo = new DebitNoteMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
				sprmparam2.Value = debitNoteMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					debitnotemasterinfo.DebitNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					debitnotemasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					debitnotemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					debitnotemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					debitnotemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					debitnotemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					debitnotemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					debitnotemasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					debitnotemasterinfo.Narration = ((DbDataReader)sdrreader)[8].ToString();
					debitnotemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					debitnotemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[10].ToString());
					debitnotemasterinfo.Extra1 = ((DbDataReader)sdrreader)[11].ToString();
					debitnotemasterinfo.Extra2 = ((DbDataReader)sdrreader)[12].ToString();
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
			return debitnotemasterinfo;
		}

		public void DebitNoteMasterDelete(decimal DebitNoteMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
				sprmparam2.Value = DebitNoteMasterId;
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

		public int DebitNoteMasterGetMax(decimal decVoucherTypeId)
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@VoucherTypeId", SqlDbType.Decimal);
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

		public decimal DebitNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@VoucherTypeId", SqlDbType.Decimal);
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

		public bool DebitNoteVoucherCheckExistance(string strInvoiceNo, decimal VoucherTypeId, decimal decMasterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteVoucherCheckExistance", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strInvoiceNo;
				sprmparam4 = sccmd.Parameters.Add("@VoucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = VoucherTypeId;
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

		public DataTable DebitNoteMasterViewAllWithSlNo()
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteMasterViewAll", base.sqlcon);
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

		public DataTable DebitNoteRegisterSearch(string strVoucherNo, string strFromDate, string strToDate)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteRegisterSearch", base.sqlcon);
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

		public DataTable DebitNoteReportSearch(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteReportSearch", base.sqlcon);
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

		internal DataSet DebitNotePrinting(decimal decDebitNoteMasterId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decDebitNoteMasterId;
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

		public DataSet DebitNoteReportPrinting(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decCompanyId)
		{
			DataSet dst = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteReportPrinting", base.sqlcon);
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
				MessageBox.Show("DNM:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dst;
		}

		public void DebitNoteVoucherDelete(decimal decDebitNoteMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteVoucherDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decDebitNoteMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("DNM:2" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public decimal DebitNoteMasterIdView(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteMasterIdView", base.sqlcon);
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
