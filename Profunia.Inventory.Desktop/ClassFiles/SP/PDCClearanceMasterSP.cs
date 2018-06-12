using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PDCClearanceMasterSP : DBConnection
	{
		public decimal PDCClearanceMasterAdd(PDCClearanceMasterInfo pdcclearancemasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam15.Value = pdcclearancemasterinfo.VoucherNo;
				sprmparam15 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam15.Value = pdcclearancemasterinfo.InvoiceNo;
				sprmparam15 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam15.Value = pdcclearancemasterinfo.SuffixPrefixId;
				sprmparam15 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam15.Value = pdcclearancemasterinfo.Date;
				sprmparam15 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam15.Value = pdcclearancemasterinfo.LedgerId;
				sprmparam15 = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam15.Value = pdcclearancemasterinfo.Type;
				sprmparam15 = sccmd.Parameters.Add("@againstId", SqlDbType.Decimal);
				sprmparam15.Value = pdcclearancemasterinfo.AgainstId;
				sprmparam15 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam15.Value = pdcclearancemasterinfo.VoucherTypeId;
				sprmparam15 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam15.Value = pdcclearancemasterinfo.Narration;
				sprmparam15 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam15.Value = pdcclearancemasterinfo.Status;
				sprmparam15 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam15.Value = pdcclearancemasterinfo.UserId;
				sprmparam15 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam15.Value = pdcclearancemasterinfo.FinancialYearId;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = pdcclearancemasterinfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = pdcclearancemasterinfo.Extra2;
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

		public void PDCClearanceMasterEdit(PDCClearanceMasterInfo pdcclearancemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
				sprmparam16.Value = pdcclearancemasterinfo.PDCClearanceMasterId;
				sprmparam16 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcclearancemasterinfo.VoucherNo;
				sprmparam16 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam16.Value = pdcclearancemasterinfo.InvoiceNo;
				sprmparam16 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam16.Value = pdcclearancemasterinfo.SuffixPrefixId;
				sprmparam16 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam16.Value = pdcclearancemasterinfo.Date;
				sprmparam16 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam16.Value = pdcclearancemasterinfo.LedgerId;
				sprmparam16 = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam16.Value = pdcclearancemasterinfo.Type;
				sprmparam16 = sccmd.Parameters.Add("@againstId", SqlDbType.Decimal);
				sprmparam16.Value = pdcclearancemasterinfo.AgainstId;
				sprmparam16 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam16.Value = pdcclearancemasterinfo.VoucherTypeId;
				sprmparam16 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam16.Value = pdcclearancemasterinfo.Narration;
				sprmparam16 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam16.Value = pdcclearancemasterinfo.Status;
				sprmparam16 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam16.Value = pdcclearancemasterinfo.UserId;
				sprmparam16 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam16.Value = pdcclearancemasterinfo.FinancialYearId;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = pdcclearancemasterinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = pdcclearancemasterinfo.Extra2;
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

		public DataTable PDCClearanceMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCClearanceMasterViewAll", base.sqlcon);
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

		public PDCClearanceMasterInfo PDCClearanceMasterView(decimal PDCClearanceMasterId)
		{
			PDCClearanceMasterInfo pdcclearancemasterinfo = new PDCClearanceMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PDCClearanceMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					pdcclearancemasterinfo.PDCClearanceMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					pdcclearancemasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					pdcclearancemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					pdcclearancemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					pdcclearancemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					pdcclearancemasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					pdcclearancemasterinfo.Type = ((DbDataReader)sdrreader)[6].ToString();
					pdcclearancemasterinfo.AgainstId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					pdcclearancemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					pdcclearancemasterinfo.Narration = ((DbDataReader)sdrreader)[9].ToString();
					pdcclearancemasterinfo.Status = ((DbDataReader)sdrreader)[10].ToString();
					pdcclearancemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					pdcclearancemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					pdcclearancemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[13].ToString());
					pdcclearancemasterinfo.Extra1 = ((DbDataReader)sdrreader)[14].ToString();
					pdcclearancemasterinfo.Extra2 = ((DbDataReader)sdrreader)[15].ToString();
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
			return pdcclearancemasterinfo;
		}

		public int PDCClearanceMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceMasterMax", base.sqlcon);
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

		public DataTable VouchertypeComboFill()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeForPDCClearance", base.sqlcon);
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

		public decimal PDCClearanceMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceMaxUnderVoucherType", base.sqlcon);
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

		public string PDCClearanceMaxUnderVoucherType(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceMaxUnderVoucherType", base.sqlcon);
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

		public DataTable InvoiceNumberCombofillUnderVoucherType(string strVoucherType, decimal MasterId)
		{
			DataTable dtblpdcPayableId = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("InvoiceNumberCombofillUnderVoucherType", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherType;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@MasterId", SqlDbType.VarChar);
				sprmparam3.Value = MasterId;
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

		public DataTable pdcclearancedetailsFill(string strVoucherType, decimal decmasterId)
		{
			DataTable dtblpdcPayableId = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCClearanceFillDetails", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherType;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@MasterId", SqlDbType.Int);
				sprmparam3.Value = decmasterId;
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

		public bool PDCclearanceCheckExistence(string voucherNo, decimal voucherTypeId, decimal PDCClearanceMasterId)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCclearanceCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = voucherNo;
				sprmparam4 = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
				sprmparam4.Value = PDCClearanceMasterId;
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

		public string TypeOfVoucherReturnUnderVoucherName(string strVoucherType)
		{
			string VoucherType = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TypeOfVoucherReturnUnderVoucherName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
				sprmparam2.Value = strVoucherType;
				VoucherType = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return VoucherType;
		}

		public DataTable PDCClearanceRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string strchequeNo, decimal decBankId, string strstatus)
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
				SqlCommand sqlcmd = new SqlCommand("PDCClearanceRegisterSearch", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
				sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
				sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sqlcmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = voucherTypeName;
				sqlcmd.Parameters.Add("@chequeNo", SqlDbType.VarChar).Value = strchequeNo;
				sqlcmd.Parameters.Add("@bankId", SqlDbType.Decimal).Value = decBankId;
				sqlcmd.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
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

		public void PDCClearanceDelete(decimal PdcClearanceId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
				sprmparam4.Value = PdcClearanceId;
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

		public DataTable PDCClearanceReportSearch(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string voucherNo)
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
				SqlCommand sqlcmd = new SqlCommand("PDCClearanceReportSearch", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
				sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
				sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sqlcmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = voucherTypeName;
				sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = voucherNo;
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

		internal DataSet PDCClearanceVoucherPrinting(decimal decPDCClearanceId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCClearanceVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@pdcClearanceId", SqlDbType.Decimal);
				sprmparam3.Value = decPDCClearanceId;
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

		public decimal PDCClearanceAgainstIdUnderClearanceId(decimal decclearanceId)
		{
			decimal decAgainstId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PDCClearanceAgainstIdUnderClearanceId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decclearanceId;
				decAgainstId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decAgainstId;
		}

		public DataSet PDCClearanceReportPrinting(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string voucherNo, decimal decCompanyId)
		{
			DataSet dtbl = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PDCClearanceReportPrinting", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
				sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
				sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
				sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
				sqlcmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = voucherTypeName;
				sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = voucherNo;
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
	}
}
