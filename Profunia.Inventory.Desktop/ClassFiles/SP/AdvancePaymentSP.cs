using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class AdvancePaymentSP : DBConnection
	{
		public void AdvancePaymentAdd(AdvancePaymentInfo advancepaymentinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancePaymentAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.EmployeeId;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.Amount;
				sprmparam17 = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.SalaryMonth;
				sprmparam17 = sccmd.Parameters.Add("@chequenumber", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Chequenumber;
				sprmparam17 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.ChequeDate;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.ExtraDate;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Extra2;
				sprmparam17 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.SuffixPrefixId;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.FinancialYearId;
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

		public void AdvancePaymentEdit(AdvancePaymentInfo advancepaymentinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancePaymentEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.AdvancePaymentId;
				sprmparam17 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.EmployeeId;
				sprmparam17 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.LedgerId;
				sprmparam17 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.VoucherNo;
				sprmparam17 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.InvoiceNo;
				sprmparam17 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.Date;
				sprmparam17 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.Amount;
				sprmparam17 = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.SalaryMonth;
				sprmparam17 = sccmd.Parameters.Add("@chequenumber", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Chequenumber;
				sprmparam17 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.ChequeDate;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Extra2;
				sprmparam17 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.SuffixPrefixId;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.FinancialYearId;
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

		public DataTable AdvancePaymentViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AdvancePaymentViewAll", base.sqlcon);
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

		public AdvancePaymentInfo AdvancePaymentView(decimal advancePaymentId)
		{
			AdvancePaymentInfo advancepaymentinfo = new AdvancePaymentInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancePaymentView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
				sprmparam2.Value = advancePaymentId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					advancepaymentinfo.AdvancePaymentId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					advancepaymentinfo.EmployeeId = Convert.ToDecimal(((DbDataReader)sdrreader)[1].ToString());
					advancepaymentinfo.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader)[2].ToString());
					advancepaymentinfo.VoucherNo = ((DbDataReader)sdrreader)[3].ToString();
					advancepaymentinfo.InvoiceNo = ((DbDataReader)sdrreader)[4].ToString();
					advancepaymentinfo.Date = Convert.ToDateTime(((DbDataReader)sdrreader)[5].ToString());
					advancepaymentinfo.Amount = Convert.ToDecimal(((DbDataReader)sdrreader)[6].ToString());
					advancepaymentinfo.SalaryMonth = Convert.ToDateTime(((DbDataReader)sdrreader)[7].ToString());
					advancepaymentinfo.Chequenumber = ((DbDataReader)sdrreader)[8].ToString();
					advancepaymentinfo.ChequeDate = Convert.ToDateTime(((DbDataReader)sdrreader)[9].ToString());
					advancepaymentinfo.Narration = ((DbDataReader)sdrreader)[10].ToString();
					advancepaymentinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)[11].ToString());
					advancepaymentinfo.Extra1 = ((DbDataReader)sdrreader)[12].ToString();
					advancepaymentinfo.Extra2 = ((DbDataReader)sdrreader)[13].ToString();
					advancepaymentinfo.SuffixPrefixId = Convert.ToDecimal(((DbDataReader)sdrreader)[14].ToString());
					advancepaymentinfo.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sdrreader)[15].ToString());
					advancepaymentinfo.FinancialYearId = Convert.ToDecimal(((DbDataReader)sdrreader)[16].ToString());
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
			return advancepaymentinfo;
		}

		public void AdvancePaymentDelete(decimal AdvancePaymentId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancePaymentDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
				sprmparam2.Value = AdvancePaymentId;
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

		public string AdvancePaymentGetMax(decimal decVoucherTypeId)
		{
			string Max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancPaymentVoucherNoGetMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				Max = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return Max;
		}

		public decimal AdvancePaymentGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal Max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancPaymentVoucherNoGetMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				Max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ++Max;
		}

		public DataTable AdvancePaymentAddWithIdentity(AdvancePaymentInfo advancepaymentinfo, bool IsAutomatic)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("AdvancePaymentAddWithIdentity", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.EmployeeId;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.LedgerId;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.VoucherNo;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.InvoiceNo;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.Date;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.Amount;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.SalaryMonth;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@chequenumber", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Chequenumber;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam17.Value = advancepaymentinfo.ChequeDate;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Narration;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Extra1;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = advancepaymentinfo.Extra2;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.SuffixPrefixId;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.VoucherTypeId;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam17.Value = advancepaymentinfo.FinancialYearId;
				sprmparam17 = sqlda.SelectCommand.Parameters.Add("@IsAutomatic", SqlDbType.Bit);
				sprmparam17.Value = IsAutomatic;
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

		public DataTable CashOrBankComboFill()
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

		public DataTable AdvancePaymentEmployeeComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AdvancePaymentEmployeeComboFill", base.sqlcon);
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

		public DataTable AdvancePaymentSalaryMonthComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AdvancePaymentSalaryMonthComboFill", base.sqlcon);
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

		public decimal AdvancePaymentAmountchecking(decimal EmployeeId)
		{
			decimal decadvanceAmount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancePaymentAmountchecking", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@EmployeeId", SqlDbType.Decimal);
				sprmparam2.Value = EmployeeId;
				object advanceAmount = sccmd.ExecuteScalar();
				decadvanceAmount = ((advanceAmount == null) ? 0m : Convert.ToDecimal(advanceAmount.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decadvanceAmount;
		}

		public void AdvancePaymentVoucherTypecheckReference(decimal PayHeadId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancePaymentDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
				sprmparam2.Value = PayHeadId;
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

		public DataTable AdvanceRegisterSearch(string strAdvanceVoucher, string strEmployeeCode, string strEmployeeName, string dtpDate, string strVouchertypeName)
		{
			EmployeeInfo infoEmployee = new EmployeeInfo();
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("AdvanceRegisterSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strAdvanceVoucher;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
				sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpDate;
				sqlda.SelectCommand.Parameters.Add("@VoucherTypeName", SqlDbType.VarChar).Value = strVouchertypeName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool AdvancePaymentCheckExistence(string voucherNo, decimal voucherTypeId, decimal advancePaymentId)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdvancePaymentCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = voucherNo;
				sprmparam4 = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
				sprmparam4.Value = advancePaymentId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				sccmd.ExecuteNonQuery();
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
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

		public bool CheckSalaryAlreadyPaidOrNot(decimal decEmployeeId, DateTime date)
		{
			bool isPaid = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckSalaryAlreadyPaidOrNot", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam3.Value = decEmployeeId;
				sprmparam3 = sccmd.Parameters.Add("@month", SqlDbType.Date);
				sprmparam3.Value = date;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					isPaid = true;
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
			return isPaid;
		}

		public DataTable VoucherTypeNameComboFillAdvanceRegister()
		{
			DataTable dtblVoucherTypeName = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlDa = new SqlDataAdapter("VoucherTypeNameComboFillAdvanceRegister", base.sqlcon);
				sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlDa.Fill(dtblVoucherTypeName);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblVoucherTypeName;
		}

		public DataTable AdvancePaymentViewAllForAdvancePaymentReport(DateTime dtpFromDate, DateTime dtpToDate, string strEmployeeCode, DateTime dtpSalaryMonth)
		{
			DataTable dtblAdvancePayment = new DataTable();
			dtblAdvancePayment.Columns.Add("SlNo", typeof(int));
			dtblAdvancePayment.Columns["SlNo"].AutoIncrement = true;
			dtblAdvancePayment.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblAdvancePayment.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("AdvancePaymentViewAllForAdvancePaymentReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtpFromDate;
				sqlda.SelectCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtpToDate;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = dtpSalaryMonth;
				sqlda.Fill(dtblAdvancePayment);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblAdvancePayment;
		}
	}
}
