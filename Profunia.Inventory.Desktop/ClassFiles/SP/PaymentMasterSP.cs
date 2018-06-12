using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PaymentMasterSP : DBConnection
	{
		public decimal PaymentMasterAdd(PaymentMasterInfo paymentmasterinfo)
		{
			decimal decPaymentMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam13.Value = paymentmasterinfo.VoucherNo;
				sprmparam13 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam13.Value = paymentmasterinfo.InvoiceNo;
				sprmparam13 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam13.Value = paymentmasterinfo.SuffixPrefixId;
				sprmparam13 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam13.Value = paymentmasterinfo.Date;
				sprmparam13 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam13.Value = paymentmasterinfo.LedgerId;
				sprmparam13 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam13.Value = paymentmasterinfo.TotalAmount;
				sprmparam13 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam13.Value = paymentmasterinfo.Narration;
				sprmparam13 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam13.Value = paymentmasterinfo.VoucherTypeId;
				sprmparam13 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam13.Value = paymentmasterinfo.UserId;
				sprmparam13 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam13.Value = paymentmasterinfo.FinancialYearId;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = paymentmasterinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = paymentmasterinfo.Extra2;
				decPaymentMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decPaymentMasterId;
		}

		public decimal PaymentMasterEdit(PaymentMasterInfo paymentmasterinfo)
		{
			decimal decPaymentMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam14.Value = paymentmasterinfo.PaymentMasterId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = paymentmasterinfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = paymentmasterinfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam14.Value = paymentmasterinfo.SuffixPrefixId;
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = paymentmasterinfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = paymentmasterinfo.LedgerId;
				sprmparam14 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam14.Value = paymentmasterinfo.TotalAmount;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = paymentmasterinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = paymentmasterinfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam14.Value = paymentmasterinfo.UserId;
				sprmparam14 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam14.Value = paymentmasterinfo.FinancialYearId;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = paymentmasterinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = paymentmasterinfo.Extra2;
				decPaymentMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decPaymentMasterId;
		}

		public DataTable PaymentMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentMasterViewAll", base.sqlcon);
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

		public PaymentMasterInfo PaymentMasterView(decimal paymentMastertId)
		{
			PaymentMasterInfo paymentmasterinfo = new PaymentMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam2.Value = paymentMastertId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					paymentmasterinfo.PaymentMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					paymentmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					paymentmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					paymentmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					paymentmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					paymentmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					paymentmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					paymentmasterinfo.Narration = ((DbDataReader)sdrreader)[7].ToString();
					paymentmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					paymentmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					paymentmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					paymentmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[12].ToString());
					paymentmasterinfo.Extra1 = ((DbDataReader)sdrreader)[13].ToString();
					paymentmasterinfo.Extra2 = ((DbDataReader)sdrreader)[14].ToString();
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
			return paymentmasterinfo;
		}

		public void PaymentMasterDelete(decimal PaymentMastertId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PaymentMastertId;
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

		public int PaymentMasterMax(decimal decVoucherTypeId)
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterMax", base.sqlcon);
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

		public int PaymentMasterDeleteByReturnValue(decimal PaymentMastertId)
		{
			int inReturnValue = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PaymentMastertId;
				inReturnValue = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inReturnValue;
		}

		public DataTable PaymentMasterSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decledgerId, string strvoucherNo)
		{
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
				SqlCommand sccmd = new SqlCommand("PaymentMasterSearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
				sprmparam5.Value = dtpFromDate;
				sprmparam5 = sccmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
				sprmparam5.Value = dtpToDate;
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decledgerId;
				sprmparam5 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam5.Value = strvoucherNo;
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

		public DataTable PaymentReportSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId)
		{
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
				SqlCommand sccmd = new SqlCommand("PaymentReportSearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
				sprmparam6.Value = dtpFromDate;
				sprmparam6 = sccmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
				sprmparam6.Value = dtpToDate;
				sprmparam6 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam6.Value = decLedgerId;
				sprmparam6 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam6.Value = decVoucherTypeId;
				sprmparam6 = sccmd.Parameters.Add("@cashOrBankId", SqlDbType.Decimal);
				sprmparam6.Value = decCashOrBankId;
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

		public PaymentMasterInfo PaymentMasterViewByMasterId(decimal paymentMastertId)
		{
			PaymentMasterInfo paymentmasterinfo = new PaymentMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterViewByMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam2.Value = paymentMastertId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					paymentmasterinfo.VoucherNo = ((DbDataReader)sdrreader)["voucherNo"].ToString();
					paymentmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)["invoiceNo"].ToString();
					paymentmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)["suffixprefixId"].ToString());
					paymentmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)["date"].ToString());
					paymentmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)["ledgerId"].ToString());
					paymentmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)["totalAmount"].ToString());
					paymentmasterinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					paymentmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
					paymentmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)["userId"].ToString());
					paymentmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)["financialYearId"].ToString());
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
			return paymentmasterinfo;
		}

		public bool PaymentVoucherCheckExistence(string strvoucherNo, decimal decvoucherTypeId, decimal decMasterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentVoucherCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strvoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decvoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decMasterId;
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

		public int PaymentMasterCount()
		{
			int inReturnValue = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentMasterCount", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				inReturnValue = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inReturnValue;
		}

		internal DataSet PaymentVoucherPrinting(decimal decPaymentMasterId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decPaymentMasterId;
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

		internal DataSet PaymentReportPrinting(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentReportPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@FromDate", SqlDbType.DateTime);
				sprmparam7.Value = dtpFromDate;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@ToDate", SqlDbType.DateTime);
				sprmparam7.Value = dtpToDate;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam7.Value = decLedgerId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam7.Value = decVoucherTypeId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@cashOrBankId", SqlDbType.Decimal);
				sprmparam7.Value = decCashOrBankId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam7.Value = decCompanyId;
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

		public decimal paymentMasterIdView(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("paymentMasterIdView", base.sqlcon);
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

		public void PaymentVoucherDelete(decimal decPaymentMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentVoucherDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decPaymentMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("PMSP :5" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}
	}
}
