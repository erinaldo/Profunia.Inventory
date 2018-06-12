using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ReceiptMasterSP : DBConnection
	{
		public decimal ReceiptMasterAdd(ReceiptMasterInfo receiptmasterinfo)
		{
			decimal decRecieptMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam13.Value = receiptmasterinfo.VoucherNo;
				sprmparam13 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam13.Value = receiptmasterinfo.InvoiceNo;
				sprmparam13 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam13.Value = receiptmasterinfo.SuffixPrefixId;
				sprmparam13 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam13.Value = receiptmasterinfo.Date;
				sprmparam13 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam13.Value = receiptmasterinfo.LedgerId;
				sprmparam13 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam13.Value = receiptmasterinfo.TotalAmount;
				sprmparam13 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam13.Value = receiptmasterinfo.Narration;
				sprmparam13 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam13.Value = receiptmasterinfo.VoucherTypeId;
				sprmparam13 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam13.Value = receiptmasterinfo.UserId;
				sprmparam13 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam13.Value = receiptmasterinfo.FinancialYearId;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = receiptmasterinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = receiptmasterinfo.Extra2;
				decRecieptMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decRecieptMasterId;
		}

		public decimal ReceiptMasterEdit(ReceiptMasterInfo receiptmasterinfo)
		{
			decimal decRecieptMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam15.Value = receiptmasterinfo.ReceiptMasterId;
				sprmparam15 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam15.Value = receiptmasterinfo.VoucherNo;
				sprmparam15 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam15.Value = receiptmasterinfo.InvoiceNo;
				sprmparam15 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam15.Value = receiptmasterinfo.SuffixPrefixId;
				sprmparam15 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam15.Value = receiptmasterinfo.Date;
				sprmparam15 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam15.Value = receiptmasterinfo.LedgerId;
				sprmparam15 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam15.Value = receiptmasterinfo.TotalAmount;
				sprmparam15 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam15.Value = receiptmasterinfo.Narration;
				sprmparam15 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam15.Value = receiptmasterinfo.VoucherTypeId;
				sprmparam15 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam15.Value = receiptmasterinfo.UserId;
				sprmparam15 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam15.Value = receiptmasterinfo.FinancialYearId;
				sprmparam15 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam15.Value = receiptmasterinfo.ExtraDate;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = receiptmasterinfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = receiptmasterinfo.Extra2;
				decRecieptMasterId = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decRecieptMasterId;
		}

		public DataTable ReceiptMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptMasterViewAll", base.sqlcon);
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

		public ReceiptMasterInfo ReceiptMasterView(decimal receiptMasterId)
		{
			ReceiptMasterInfo receiptmasterinfo = new ReceiptMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = receiptMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					receiptmasterinfo.ReceiptMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					receiptmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					receiptmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					receiptmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					receiptmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					receiptmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					receiptmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					receiptmasterinfo.Narration = ((DbDataReader)sdrreader)[7].ToString();
					receiptmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					receiptmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					receiptmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					receiptmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[11].ToString());
					receiptmasterinfo.Extra1 = ((DbDataReader)sdrreader)[12].ToString();
					receiptmasterinfo.Extra2 = ((DbDataReader)sdrreader)[13].ToString();
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
			return receiptmasterinfo;
		}

		public void ReceiptMasterDelete(decimal ReceiptMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = ReceiptMasterId;
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

		public decimal ReceiptMasterGetMax(decimal decVoucherTypeId)
		{
			decimal decMax = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RecieptMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				decMax = int.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decMax;
		}

		public DataTable ReceiptMasterSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decledgerId, string strvoucherNo)
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
				SqlCommand sccmd = new SqlCommand("ReceiptMasterSearch", base.sqlcon);
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

		public ReceiptMasterInfo ReceiptMasterViewByMasterId(decimal decReceiptMastertId)
		{
			ReceiptMasterInfo InfoReceiptMaster = new ReceiptMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptMasterViewByMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decReceiptMastertId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					InfoReceiptMaster.VoucherNo = ((DbDataReader)sdrreader)["voucherNo"].ToString();
					InfoReceiptMaster.InvoiceNo = ((DbDataReader)sdrreader)["invoiceNo"].ToString();
					InfoReceiptMaster.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)["suffixprefixId"].ToString());
					InfoReceiptMaster.Date = DateTime.Parse(((DbDataReader)sdrreader)["date"].ToString());
					InfoReceiptMaster.LedgerId = decimal.Parse(((DbDataReader)sdrreader)["ledgerId"].ToString());
					InfoReceiptMaster.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)["totalAmount"].ToString());
					InfoReceiptMaster.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					InfoReceiptMaster.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)["voucherTypeId"].ToString());
					InfoReceiptMaster.UserId = decimal.Parse(((DbDataReader)sdrreader)["userId"].ToString());
					InfoReceiptMaster.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)["financialYearId"].ToString());
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
			return InfoReceiptMaster;
		}

		public DataTable ReceiptReportSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId)
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
				SqlCommand sccmd = new SqlCommand("ReceiptReportSearch", base.sqlcon);
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

		public bool ReceiptVoucherCheckExistence(string strvoucherNo, decimal decvoucherTypeId, decimal decMasterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptVoucherCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strvoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decvoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
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

		internal DataSet ReceiptVoucherPrinting(decimal decPaymentMasterId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptVoucherPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPaymentMasterId;
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

		internal DataSet ReceiptReportPrinting(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptReportPrinting", base.sqlcon);
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

		public decimal ReceiptMasterIdView(decimal decVouchertypeid, string strVoucherNo)
		{
			decimal decid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptMasterIdView", base.sqlcon);
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

		public void ReceiptVoucherDelete(decimal decReceiptMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptVoucherDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decReceiptMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("RMSP :5" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}
	}
}
