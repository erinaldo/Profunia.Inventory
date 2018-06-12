using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class LedgerPostingSP : DBConnection
	{
		public void LedgerPostingAdd(LedgerPostingInfo ledgerpostinginfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = ledgerpostinginfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.LedgerId;
				sprmparam14 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.Debit;
				sprmparam14 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.Credit;
				sprmparam14 = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.DetailsId;
				sprmparam14 = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.YearId;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.ChequeNo;
				sprmparam14 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam14.Value = ledgerpostinginfo.ChequeDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.Extra2;
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

		public void LedgerPostingEdit(LedgerPostingInfo ledgerpostinginfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
				sprmparam15.Value = ledgerpostinginfo.LedgerPostingId;
				sprmparam15 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam15.Value = ledgerpostinginfo.Date;
				sprmparam15 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam15.Value = ledgerpostinginfo.VoucherTypeId;
				sprmparam15 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam15.Value = ledgerpostinginfo.VoucherNo;
				sprmparam15 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam15.Value = ledgerpostinginfo.LedgerId;
				sprmparam15 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam15.Value = ledgerpostinginfo.Debit;
				sprmparam15 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam15.Value = ledgerpostinginfo.Credit;
				sprmparam15 = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
				sprmparam15.Value = ledgerpostinginfo.DetailsId;
				sprmparam15 = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
				sprmparam15.Value = ledgerpostinginfo.YearId;
				sprmparam15 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam15.Value = ledgerpostinginfo.InvoiceNo;
				sprmparam15 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam15.Value = ledgerpostinginfo.ChequeNo;
				sprmparam15 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam15.Value = ledgerpostinginfo.ChequeDate;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = ledgerpostinginfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = ledgerpostinginfo.Extra2;
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

		public DataTable LedgerPostingViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingViewAll", base.sqlcon);
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

		public LedgerPostingInfo LedgerPostingView(decimal ledgerPostingId)
		{
			LedgerPostingInfo ledgerpostinginfo = new LedgerPostingInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
				sprmparam2.Value = ledgerPostingId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					ledgerpostinginfo.LedgerPostingId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					ledgerpostinginfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
					ledgerpostinginfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					ledgerpostinginfo.VoucherNo = ((DbDataReader)sdrreader)[3].ToString();
					ledgerpostinginfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					ledgerpostinginfo.Debit = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					ledgerpostinginfo.Credit = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					ledgerpostinginfo.DetailsId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					ledgerpostinginfo.YearId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					ledgerpostinginfo.InvoiceNo = ((DbDataReader)sdrreader)[10].ToString();
					ledgerpostinginfo.ChequeNo = ((DbDataReader)sdrreader)[11].ToString();
					ledgerpostinginfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[12].ToString());
					ledgerpostinginfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[13].ToString());
					ledgerpostinginfo.Extra1 = ((DbDataReader)sdrreader)[14].ToString();
					ledgerpostinginfo.Extra2 = ((DbDataReader)sdrreader)[15].ToString();
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
			return ledgerpostinginfo;
		}

		public void LedgerPostingDelete(decimal LedgerPostingId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
				sprmparam2.Value = LedgerPostingId;
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

		public int LedgerPostingGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingMax", base.sqlcon);
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

		public void LedgerPostDelete(string strVoucherNo, decimal decVoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
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

		public DataTable GetLedgerPostingIds(string voucherNo, decimal voucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("GetLedgerPostingIds", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = voucherNo;
				sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = voucherTypeId;
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

		public void LedgerPostingEditByVoucherTypeAndVoucherNo(LedgerPostingInfo ledgerpostinginfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingEditByVoucherTypeAndVoucherNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = ledgerpostinginfo.Date;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.LedgerId;
				sprmparam14 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.Debit;
				sprmparam14 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.Credit;
				sprmparam14 = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.DetailsId;
				sprmparam14 = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
				sprmparam14.Value = ledgerpostinginfo.YearId;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.ChequeNo;
				sprmparam14 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam14.Value = ledgerpostinginfo.ChequeDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = ledgerpostinginfo.Extra2;
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

		public decimal LedgerPostingIdFromDetailsId(decimal decDetailsId, string strVoucherNo, decimal decVoucherTypeId)
		{
			decimal decLedgerPostingId = 0m;
			SqlDataReader sqldr2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingIdFromDetailsId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
				sprmparam4.Value = decDetailsId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sqldr2 = sccmd.ExecuteReader();
				while (sqldr2.Read())
				{
					decLedgerPostingId = Convert.ToDecimal(((DbDataReader)sqldr2)["ledgerPostingId"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("LPSP:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decLedgerPostingId;
		}

		public void LedgerPostDeleteByDetailsId(decimal decDetailsId, string strVoucherNo, decimal decVoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostDeleteByDetailsId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@DetailsId", SqlDbType.Decimal);
				sprmparam4.Value = decDetailsId;
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

		public decimal LedgerPostingIdForTotalAmount(string strVoucherNo, decimal decVoucherTypeId)
		{
			decimal decLedgerPostingId = 0m;
			SqlDataReader sqldr2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingIdForTotalAmount", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sqldr2 = sccmd.ExecuteReader();
				while (sqldr2.Read())
				{
					decLedgerPostingId = Convert.ToDecimal(((DbDataReader)sqldr2)["ledgerPostingId"].ToString());
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
			return decLedgerPostingId;
		}

		public void LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndLedgerIdAndVoucherNo(decimal voucherTypeId, string voucherNo, string invoiceNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndVoucherNoAndInvoiceNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = voucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = voucherNo;
				sprmparam4 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = invoiceNo;
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

		public void LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(LedgerPostingInfo infoLedgerPosting)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam14.Value = infoLedgerPosting.Date;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = infoLedgerPosting.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam14.Value = infoLedgerPosting.VoucherNo;
				sprmparam14 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam14.Value = infoLedgerPosting.LedgerId;
				sprmparam14 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam14.Value = infoLedgerPosting.Debit;
				sprmparam14 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam14.Value = infoLedgerPosting.Credit;
				sprmparam14 = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
				sprmparam14.Value = infoLedgerPosting.DetailsId;
				sprmparam14 = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
				sprmparam14.Value = infoLedgerPosting.YearId;
				sprmparam14 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam14.Value = infoLedgerPosting.InvoiceNo;
				sprmparam14 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam14.Value = infoLedgerPosting.ChequeNo;
				sprmparam14 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam14.Value = infoLedgerPosting.ChequeDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = infoLedgerPosting.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = infoLedgerPosting.Extra2;
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

		public void LedgerPostingDeleteByVoucherTypeIdAndLedgerIdAndVoucherNoAndExtra(decimal voucherTypeId, decimal decLedgerId, string strVoucherNo, string strAddCash)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingDeleteByVoucherTypeIdAndLedgerIdAndVoucherNoAndExtra", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = voucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decLedgerId;
				sprmparam5 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam5.Value = strVoucherNo;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = strAddCash;
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

		public void DeleteLedgerPostingForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("DeleteLedgerPostingForStockJournalEdit", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				cmd.ExecuteNonQuery();
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

		public void LedgerPostingDeleteByVoucherNoVoucherTypeIdAndLedgerId(string strVoucherNo, decimal decVoucherTypeId, decimal decLedgerId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("LedgerPostingDeleteByVoucherNoVoucherTypeIdAndLedgerId", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				cmd.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				cmd.ExecuteNonQuery();
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
	}
}
