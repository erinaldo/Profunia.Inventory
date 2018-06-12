using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PDCPayableMasterSP : DBConnection
	{
		public decimal PDCPayableMasterAdd(PDCPayableMasterInfo pdcpayablemasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcpayablemasterinfo.VoucherNo;
				sprmparam16 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcpayablemasterinfo.InvoiceNo;
				sprmparam16 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam16.Value = pdcpayablemasterinfo.SuffixPrefixId;
				sprmparam16 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam16.Value = pdcpayablemasterinfo.Date;
				sprmparam16 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam16.Value = pdcpayablemasterinfo.LedgerId;
				sprmparam16 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam16.Value = pdcpayablemasterinfo.Amount;
				sprmparam16 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcpayablemasterinfo.ChequeNo;
				sprmparam16 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam16.Value = pdcpayablemasterinfo.ChequeDate;
				sprmparam16 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam16.Value = pdcpayablemasterinfo.Narration;
				sprmparam16 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam16.Value = pdcpayablemasterinfo.UserId;
				sprmparam16 = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
				sprmparam16.Value = pdcpayablemasterinfo.BankId;
				sprmparam16 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam16.Value = pdcpayablemasterinfo.VoucherTypeId;
				sprmparam16 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam16.Value = pdcpayablemasterinfo.FinancialYearId;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = pdcpayablemasterinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = pdcpayablemasterinfo.Extra2;
				decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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

		public void PDCPayableMasterEdit(PDCPayableMasterInfo pdcpayablemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.PdcPayableMasterId;
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = pdcpayablemasterinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = pdcpayablemasterinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.SuffixPrefixId;
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = pdcpayablemasterinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.Amount;
				sprmparam17 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam17.Value = pdcpayablemasterinfo.ChequeNo;
				sprmparam17 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam17.Value = pdcpayablemasterinfo.ChequeDate;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = pdcpayablemasterinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.UserId;
				sprmparam17 = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.BankId;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = pdcpayablemasterinfo.FinancialYearId;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = pdcpayablemasterinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = pdcpayablemasterinfo.Extra2;
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

		public DataTable PDCPayableMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCPayableMasterViewAll", base.sqlcon);
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

		public PDCPayableMasterInfo PDCPayableMasterView(decimal pdcPayableMasterId)
		{
			PDCPayableMasterInfo pdcpayablemasterinfo = new PDCPayableMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
				sprmparam2.Value = pdcPayableMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					pdcpayablemasterinfo.PdcPayableMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					pdcpayablemasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					pdcpayablemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					pdcpayablemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					pdcpayablemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					pdcpayablemasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					pdcpayablemasterinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					pdcpayablemasterinfo.ChequeNo = ((DbDataReader)sdrreader)[7].ToString();
					pdcpayablemasterinfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[8].ToString());
					pdcpayablemasterinfo.Narration = ((DbDataReader)sdrreader)[9].ToString();
					pdcpayablemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					pdcpayablemasterinfo.BankId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					pdcpayablemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					pdcpayablemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					pdcpayablemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[14].ToString());
					pdcpayablemasterinfo.Extra1 = ((DbDataReader)sdrreader)[15].ToString();
					pdcpayablemasterinfo.Extra2 = ((DbDataReader)sdrreader)[16].ToString();
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
			return pdcpayablemasterinfo;
		}

		public void PDCPayableMasterDelete(decimal PdcPayableMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PdcPayableMasterId;
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

		public int PDCPayableMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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

		public decimal PDCPayableMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableMaxUnderVoucherType", base.sqlcon);
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

		public DataTable BankAccountComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BankAccountComboFill", base.sqlcon);
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

		public bool PDCpayableCheckExistence(string voucherNo, decimal voucherTypeId, decimal pdcPayableMasterId)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCpayableCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = voucherNo;
				sprmparam4 = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
				sprmparam4.Value = pdcPayableMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				sccmd.ExecuteNonQuery();
				object obj = sccmd.ExecuteScalar();
				if (obj != null && Convert.ToDecimal(obj.ToString()) == 0m)
				{
					isSave = true;
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
			return isSave;
		}

		internal DataSet PDCpayableVoucherPrinting(decimal decPDCpayableId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCpayableVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decPDCpayableId;
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

		public DataTable PDCpayableRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strVoucherNo, string strLedgerName)
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
				SqlCommand sqlcmd = new SqlCommand("PDCpayableRegisterSearch", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
				sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
				sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				SqlDataAdapter sqlda = new SqlDataAdapter();
				sqlda.SelectCommand = sqlcmd;
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

		public DataTable AccountLedgerComboFill(bool Isall)
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewAll", base.sqlcon);
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
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public bool PDCPayableVoucherCheckRreference(decimal decMasterId, decimal voucherTypeId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableVoucherCheckRreference", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.VarChar);
				sprmparam3.Value = decMasterId;
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = voucherTypeId;
				isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public DataTable LedgerPostingIdByPDCpayableId(decimal pdcMasterId)
		{
			DataTable dtblpdcPayableId = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingIdByPDCpayableId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
				sprmparam2.Value = pdcMasterId;
				sdaadapter.Fill(dtblpdcPayableId);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblpdcPayableId;
		}

		public DataTable PdcPayableReportSearch(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcPayableReportSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
				sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
				sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sdaadapter.SelectCommand.Parameters.Add("@chequeDateFrom", SqlDbType.DateTime).Value = dtcheckfromdate;
				sdaadapter.SelectCommand.Parameters.Add("@chequeDateTo", SqlDbType.DateTime).Value = dtCheckdateto;
				sdaadapter.SelectCommand.Parameters.Add("@chequeNo", SqlDbType.Char).Value = strchequeNo;
				sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.Char).Value = strvoucherNo;
				sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
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

		public DataSet PdcpayableReportPrinting(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus, decimal decCompanyId)
		{
			DataSet dst = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcpayableReportPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
				sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
				sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
				sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sdaadapter.SelectCommand.Parameters.Add("@chequeDateFrom", SqlDbType.DateTime).Value = dtcheckfromdate;
				sdaadapter.SelectCommand.Parameters.Add("@chequeDateTo", SqlDbType.DateTime).Value = dtCheckdateto;
				sdaadapter.SelectCommand.Parameters.Add("@chequeNo", SqlDbType.Char).Value = strchequeNo;
				sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.Char).Value = strvoucherNo;
				sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
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

		public bool PDCPayableReferenceCheck(decimal decMasterId, decimal decvoucherTypeId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decMasterId;
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam3.Value = decvoucherTypeId;
				isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public void PDCPayableMasterDelete(decimal PdcpayableId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCPayableMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@PDCPayableMasterId", SqlDbType.Decimal);
				sprmparam4.Value = PdcpayableId;
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

		public decimal PdcPayableMasterIdView(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PdcPayableMasterIdView", base.sqlcon);
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

		public DataTable ChequeReportGridFill(decimal decParty, string strChequeNo, DateTime dtFromDate, DateTime dtTodate, DateTime dtChequefromDate, DateTime dtChequetoDate, bool isIssued)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ChequeReportGridFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
				sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
				sdaadapter.SelectCommand.Parameters.Add("@chequefromDate", SqlDbType.DateTime).Value = dtChequefromDate;
				sdaadapter.SelectCommand.Parameters.Add("@chequetoDate", SqlDbType.DateTime).Value = dtChequetoDate;
				sdaadapter.SelectCommand.Parameters.Add("@issued", SqlDbType.Bit).Value = isIssued;
				sdaadapter.SelectCommand.Parameters.Add("@startText", SqlDbType.VarChar).Value = "";
				sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.VarChar).Value = decParty;
				sdaadapter.SelectCommand.Parameters.Add("@startNo", SqlDbType.VarChar).Value = strChequeNo;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable ChequeReportPartyComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ChequeReportPartyComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}
	}
}
