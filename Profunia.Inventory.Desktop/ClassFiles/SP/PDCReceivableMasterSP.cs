using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PDCReceivableMasterSP : DBConnection
	{
		public decimal PDCReceivableMasterAdd(PDCReceivableMasterInfo pdcreceivablemasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcreceivablemasterinfo.VoucherNo;
				sprmparam16 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcreceivablemasterinfo.InvoiceNo;
				sprmparam16 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam16.Value = pdcreceivablemasterinfo.SuffixPrefixId;
				sprmparam16 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam16.Value = pdcreceivablemasterinfo.Date;
				sprmparam16 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam16.Value = pdcreceivablemasterinfo.LedgerId;
				sprmparam16 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam16.Value = pdcreceivablemasterinfo.Amount;
				sprmparam16 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcreceivablemasterinfo.ChequeNo;
				sprmparam16 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam16.Value = pdcreceivablemasterinfo.ChequeDate;
				sprmparam16 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam16.Value = pdcreceivablemasterinfo.Narration;
				sprmparam16 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam16.Value = pdcreceivablemasterinfo.UserId;
				sprmparam16 = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
				sprmparam16.Value = pdcreceivablemasterinfo.BankId;
				sprmparam16 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam16.Value = pdcreceivablemasterinfo.VoucherTypeId;
				sprmparam16 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam16.Value = pdcreceivablemasterinfo.FinancialYearId;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = pdcreceivablemasterinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = pdcreceivablemasterinfo.Extra2;
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

		public void PDCReceivableMasterEdit(PDCReceivableMasterInfo pdcreceivablemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam18 = new SqlParameter();
				sprmparam18 = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.PdcReceivableMasterId;
				sprmparam18 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam18.Value = pdcreceivablemasterinfo.VoucherNo;
				sprmparam18 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam18.Value = pdcreceivablemasterinfo.InvoiceNo;
				sprmparam18 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.SuffixPrefixId;
				sprmparam18 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam18.Value = pdcreceivablemasterinfo.Date;
				sprmparam18 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.LedgerId;
				sprmparam18 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.Amount;
				sprmparam18 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam18.Value = pdcreceivablemasterinfo.ChequeNo;
				sprmparam18 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam18.Value = pdcreceivablemasterinfo.ChequeDate;
				sprmparam18 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam18.Value = pdcreceivablemasterinfo.Narration;
				sprmparam18 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.UserId;
				sprmparam18 = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.BankId;
				sprmparam18 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.VoucherTypeId;
				sprmparam18 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam18.Value = pdcreceivablemasterinfo.FinancialYearId;
				sprmparam18 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam18.Value = pdcreceivablemasterinfo.ExtraDate;
				sprmparam18 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam18.Value = pdcreceivablemasterinfo.Extra1;
				sprmparam18 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam18.Value = pdcreceivablemasterinfo.Extra2;
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

		public DataTable PDCReceivableMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCReceivableMasterViewAll", base.sqlcon);
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

		public PDCReceivableMasterInfo PDCReceivableMasterView(decimal pdcReceivableMasterId)
		{
			PDCReceivableMasterInfo pdcreceivablemasterinfo = new PDCReceivableMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam2.Value = pdcReceivableMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					pdcreceivablemasterinfo.PdcReceivableMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					pdcreceivablemasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					pdcreceivablemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					pdcreceivablemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					pdcreceivablemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					pdcreceivablemasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					pdcreceivablemasterinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					pdcreceivablemasterinfo.ChequeNo = ((DbDataReader)sdrreader)[7].ToString();
					pdcreceivablemasterinfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[8].ToString());
					pdcreceivablemasterinfo.Narration = ((DbDataReader)sdrreader)[9].ToString();
					pdcreceivablemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					pdcreceivablemasterinfo.BankId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					pdcreceivablemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					pdcreceivablemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					pdcreceivablemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[14].ToString());
					pdcreceivablemasterinfo.Extra1 = ((DbDataReader)sdrreader)[15].ToString();
					pdcreceivablemasterinfo.Extra2 = ((DbDataReader)sdrreader)[16].ToString();
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
			return pdcreceivablemasterinfo;
		}

		public void PDCReceivableMasterDelete(decimal PdcReceivableMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PdcReceivableMasterId;
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

		public int PDCReceivableMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableMasterMax", base.sqlcon);
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

		public decimal PDCReceivableMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableMaxUnderVoucherType", base.sqlcon);
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

		public string PDCReceivableMaxUnderVoucherType(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableMaxUnderVoucherType", base.sqlcon);
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

		public bool PDCReceivableCheckExistence(string voucherNo, decimal voucherTypeId, decimal decpdcReceivableId)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = voucherNo;
				sprmparam4 = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decpdcReceivableId;
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

		public bool PDCReceivableVoucherCheckRreferenceUpdating(decimal decMasterId, decimal voucherTypeId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableVoucherCheckRreferenceUpdating", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.VarChar);
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

		public void PDCReceivableDeleteMaster(decimal PdcReceivableId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableDeleteMaster", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam4.Value = PdcReceivableId;
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

		public DataTable LedgerPostingIdByPDCReceivableId(decimal pdcMasterId)
		{
			DataTable dtblpdcReceivableId = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingIdByPDCReceivableId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam2.Value = pdcMasterId;
				sdaadapter.Fill(dtblpdcReceivableId);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblpdcReceivableId;
		}

		internal DataSet PDCReceivableVoucherPrinting(decimal decPDCReceivableId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCReceivableVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decPDCReceivableId;
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

		public DataTable PDCReceivableRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strVoucherNo, string strLedgerName)
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
				SqlCommand sqlcmd = new SqlCommand("PDCReceivableRegisterSearch", base.sqlcon);
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

		public DataTable PdcReceivableReportSearch(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcReceivableReportSearch", base.sqlcon);
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

		public DataSet PdcreceivableReportPrinting(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus, decimal decCompanyId)
		{
			DataSet dst = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcreceivableReportPrinting", base.sqlcon);
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

		public decimal PdcReceivableMasterIdView(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PdcReceivableMasterIdView", base.sqlcon);
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

		public bool PDCReceivableReferenceCheck(decimal decPDCReceivableMasterId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCReceivableReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPDCReceivableMasterId;
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
	}
}
