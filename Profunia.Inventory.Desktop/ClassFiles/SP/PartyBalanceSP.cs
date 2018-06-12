using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PartyBalanceSP : DBConnection
	{
		public void PartyBalanceAdd(PartyBalanceInfo partybalanceinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = partybalanceinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = partybalanceinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = partybalanceinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = partybalanceinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = partybalanceinfo.AgainstVoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
				sprmparam17.Value = partybalanceinfo.AgainstVoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = partybalanceinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = partybalanceinfo.AgainstInvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
				sprmparam17.Value = partybalanceinfo.ReferenceType;
				sprmparam17 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam17.Value = partybalanceinfo.Debit;
				sprmparam17 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam17.Value = partybalanceinfo.Credit;
				sprmparam17 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam17.Value = partybalanceinfo.CreditPeriod;
				sprmparam17 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam17.Value = partybalanceinfo.ExchangeRateId;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = partybalanceinfo.FinancialYearId;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = partybalanceinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = partybalanceinfo.Extra2;
				int inEffect = sccmd.ExecuteNonQuery();
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

		public void PartyBalanceEdit(PartyBalanceInfo partybalanceinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam18 = new SqlParameter();
				sprmparam18 = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.PartyBalanceId;
				sprmparam18 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam18.Value = partybalanceinfo.Date;
				sprmparam18 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.LedgerId;
				sprmparam18 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.VoucherTypeId;
				sprmparam18 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam18.Value = partybalanceinfo.VoucherNo;
				sprmparam18 = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.AgainstVoucherTypeId;
				sprmparam18 = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
				sprmparam18.Value = partybalanceinfo.AgainstVoucherNo;
				sprmparam18 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam18.Value = partybalanceinfo.InvoiceNo;
				sprmparam18 = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam18.Value = partybalanceinfo.AgainstInvoiceNo;
				sprmparam18 = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
				sprmparam18.Value = partybalanceinfo.ReferenceType;
				sprmparam18 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.Debit;
				sprmparam18 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.Credit;
				sprmparam18 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam18.Value = partybalanceinfo.CreditPeriod;
				sprmparam18 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.ExchangeRateId;
				sprmparam18 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam18.Value = partybalanceinfo.FinancialYearId;
				sprmparam18 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam18.Value = partybalanceinfo.Extra1;
				sprmparam18 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam18.Value = partybalanceinfo.Extra2;
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

		public DataTable PartyBalanceViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PartyBalanceViewAll", base.sqlcon);
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

		public PartyBalanceInfo PartyBalanceView(decimal partyBalanceId)
		{
			PartyBalanceInfo partybalanceinfo = new PartyBalanceInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
				sprmparam2.Value = partyBalanceId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					partybalanceinfo.PartyBalanceId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					partybalanceinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
					partybalanceinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					partybalanceinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					partybalanceinfo.VoucherNo = ((DbDataReader)sdrreader)[4].ToString();
					partybalanceinfo.AgainstVoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					partybalanceinfo.AgainstVoucherNo = ((DbDataReader)sdrreader)[6].ToString();
					partybalanceinfo.InvoiceNo = ((DbDataReader)sdrreader)[7].ToString();
					partybalanceinfo.AgainstInvoiceNo = ((DbDataReader)sdrreader)[8].ToString();
					partybalanceinfo.ReferenceType = ((DbDataReader)sdrreader)[9].ToString();
					partybalanceinfo.Debit = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					partybalanceinfo.Credit = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					partybalanceinfo.CreditPeriod = int.Parse(((DbDataReader)sdrreader)[12].ToString());
					partybalanceinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					partybalanceinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					partybalanceinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[15].ToString());
					partybalanceinfo.Extra1 = ((DbDataReader)sdrreader)[16].ToString();
					partybalanceinfo.Extra2 = ((DbDataReader)sdrreader)[17].ToString();
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
			return partybalanceinfo;
		}

		public void PartyBalanceDelete(decimal PartyBalanceId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
				sprmparam2.Value = PartyBalanceId;
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

		public int PartyBalanceGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceMax", base.sqlcon);
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

		public DataTable PartyBalanceComboViewByLedgerId(decimal decLedgerId, string strCrDr, decimal decVoucherTypeId, string strVoucherNo)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceComboViewByLedgerId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decLedgerId;
				sprmparam5 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam5.Value = strCrDr;
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = decVoucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam5.Value = strVoucherNo;
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
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

		public DataTable PartyBalanceViewByVoucherNoAndVoucherType(decimal decVoucherTypeId, string strVoucherNo, DateTime dtDate)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceViewByVoucherNoAndVoucherType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam4.Value = dtDate;
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
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

		public int PartyBalanceDeleteByVoucherTypeAndVoucherNo(decimal decVoucherTypeId, string strVoucherNo)
		{
			int inEffect = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceDeleteByVoucherTypeAndVoucherNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				inEffect = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inEffect;
		}

		public DataTable AgainstBillDetailsGridViewByLedgerId(decimal decLedgerId, string strCrDr, decimal decVoucherTypeId, decimal decVoucherTypeNameId)
		{
			PartyBalanceInfo partybalanceinfo = new PartyBalanceInfo();
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
				SqlCommand sccmd = new SqlCommand("AgainstBillDetailsGridViewByLedgerId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decLedgerId;
				sprmparam5 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam5.Value = strCrDr;
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = decVoucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeNameId", SqlDbType.Decimal);
				sprmparam5.Value = decVoucherTypeNameId;
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
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

		public PartyBalanceInfo PartyBalanceViewByVoucherNoAndVoucherTypeId(decimal decVoucherTypeId, string strVoucherNo, DateTime dtDate)
		{
			PartyBalanceInfo partybalanceinfo = new PartyBalanceInfo();
			SqlDataReader sdrreader2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceViewByVoucherNoAndVoucherType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam4.Value = dtDate;
				sdrreader2 = sccmd.ExecuteReader();
				while (sdrreader2.Read())
				{
					partybalanceinfo.PartyBalanceId = decimal.Parse(((DbDataReader)sdrreader2)[0].ToString());
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
			return partybalanceinfo;
		}

		public bool PartyBalanceCheckReference(decimal decVoucherTypeId, string strVoucherNo)
		{
			bool isReferenceExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceCheckReference", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				isReferenceExist = Convert.ToBoolean(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("PBSP:2" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isReferenceExist;
		}

		public DataTable BillAllocationSearch(DateTime dtfromdate, DateTime dttodate, string straccountgroup, string strledgername)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("BillAllocationSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtfromdate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dttodate;
				sqlda.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = straccountgroup;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
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

		public DataSet OutstandingViewAll(decimal decledgerId, string strAccountGroup, DateTime dtfromdate, DateTime dttodate)
		{
			DataSet dtbl = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("OutstandingViewAll", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decledgerId;
				sprmparam5 = sccmd.Parameters.Add("@AccountGroup", SqlDbType.VarChar);
				sprmparam5.Value = strAccountGroup;
				sprmparam5 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam5.Value = dtfromdate;
				sprmparam5 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam5.Value = dttodate;
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
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

		public DataTable OutstandingPartyView()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("OutstandingPartyFillView", base.sqlcon);
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

		public DataSet OutstandingPrint(decimal decledgerId, string strAccountGroup, DateTime dtfromdate, DateTime dttodate, decimal decCompanyId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("OutstandingPrint", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam6.Value = dtfromdate;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam6.Value = dttodate;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.VarChar);
				sprmparam6.Value = decledgerId;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.VarChar);
				sprmparam6.Value = decCompanyId;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@AccountGroup", SqlDbType.VarChar);
				sprmparam6.Value = strAccountGroup;
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

		public DataTable AccountLedgerGetByDebtorAndCreditorWithBalance()
		{
			DataTable dtblAccountLedger = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerGetByDebtorAndCreditorWithBalance", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter prm = new SqlParameter();
				sdaadapter.Fill(dtblAccountLedger);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblAccountLedger;
		}

		public void PartyBalanceEditByVoucherNoVoucherTypeIdAndReferenceType(PartyBalanceInfo infoPartyBalance)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceEditByVoucherNoVoucherTypeIdAndReferenceType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam18 = new SqlParameter();
				sprmparam18 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam18.Value = infoPartyBalance.Date;
				sprmparam18 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam18.Value = infoPartyBalance.LedgerId;
				sprmparam18 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam18.Value = infoPartyBalance.VoucherTypeId;
				sprmparam18 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam18.Value = infoPartyBalance.VoucherNo;
				sprmparam18 = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam18.Value = infoPartyBalance.AgainstVoucherTypeId;
				sprmparam18 = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
				sprmparam18.Value = infoPartyBalance.AgainstVoucherNo;
				sprmparam18 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam18.Value = infoPartyBalance.InvoiceNo;
				sprmparam18 = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam18.Value = infoPartyBalance.AgainstInvoiceNo;
				sprmparam18 = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
				sprmparam18.Value = infoPartyBalance.ReferenceType;
				sprmparam18 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam18.Value = infoPartyBalance.Debit;
				sprmparam18 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam18.Value = infoPartyBalance.Credit;
				sprmparam18 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam18.Value = infoPartyBalance.CreditPeriod;
				sprmparam18 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam18.Value = infoPartyBalance.ExchangeRateId;
				sprmparam18 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam18.Value = infoPartyBalance.FinancialYearId;
				sprmparam18 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam18.Value = infoPartyBalance.ExtraDate;
				sprmparam18 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam18.Value = infoPartyBalance.Extra1;
				sprmparam18 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam18.Value = infoPartyBalance.Extra2;
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

		public decimal PartyBalanceAmountViewByVoucherNoVoucherTypeIdAndReferenceType(string strVoucherNo, decimal decVoucherTypeId, string strReferenceType)
		{
			decimal decAmount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceAmountViewByVoucherNoVoucherTypeIdAndReferenceType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
				sprmparam4.Value = strReferenceType;
				decAmount = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decAmount;
		}

		public decimal PartyBalanceAmountCheckForEdit(decimal decLedgerId, decimal decVoucherTypeId, string strVoucherNo, string strDrOrCr)
		{
			decimal decAmountToCheck = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceAmountCheckForEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decLedgerId;
				sprmparam5 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam5.Value = strVoucherNo;
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = decVoucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@CrorDr", SqlDbType.VarChar);
				sprmparam5.Value = strDrOrCr;
				decAmountToCheck = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decAmountToCheck;
		}

		public DataTable AgeingReportVoucherPayable(DateTime ageingDate, decimal decledgerId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter2 = new SqlDataAdapter();
				sqldataadapter2 = new SqlDataAdapter("AgeingReportVoucherPayable", base.sqlcon);
				sqldataadapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
				sqlparameter3.Value = ageingDate;
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter3.Value = decledgerId;
				sqldataadapter2.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("MRSP1:" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable AgeingReportVoucherReceivable(DateTime ageingDate, decimal decledgerId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter2 = new SqlDataAdapter();
				sqldataadapter2 = new SqlDataAdapter("AgeingReportVoucherReceivable", base.sqlcon);
				sqldataadapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
				sqlparameter3.Value = ageingDate;
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter3.Value = decledgerId;
				sqldataadapter2.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("MRSP1:" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable AgeingReportLedgerPayable(DateTime ageingDate, decimal decledgerId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter2 = new SqlDataAdapter();
				sqldataadapter2 = new SqlDataAdapter("AgeingReportLedgerPayable", base.sqlcon);
				sqldataadapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
				sqlparameter3.Value = ageingDate;
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter3.Value = decledgerId;
				sqldataadapter2.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("MRSP1:" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable AgeingReportLedgerReceivable(DateTime ageingDate, decimal decledgerId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter2 = new SqlDataAdapter();
				sqldataadapter2 = new SqlDataAdapter("AgeingReportLedgerReceivable", base.sqlcon);
				sqldataadapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
				sqlparameter3.Value = ageingDate;
				sqlparameter3 = sqldataadapter2.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter3.Value = decledgerId;
				sqldataadapter2.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("MRSP1:" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public decimal PartyBalanceAmountViewForSalesInvoice(string strVoucherNo, decimal decVoucherTypeId, string strReferenceType)
		{
			decimal decAmount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceAmountViewForSalesInvoice", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
				sprmparam4.Value = strReferenceType;
				decAmount = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decAmount;
		}
	}
}
