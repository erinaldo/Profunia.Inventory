using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class CreditNoteDetailsSP : DBConnection
	{
		public decimal CreditNoteDetailsAdd(CreditNoteDetailsInfo creditnotedetailsinfo)
		{
			decimal decId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
				sprmparam11.Value = creditnotedetailsinfo.CreditNoteMasterId;
				sprmparam11 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam11.Value = creditnotedetailsinfo.LedgerId;
				sprmparam11 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam11.Value = creditnotedetailsinfo.Credit;
				sprmparam11 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam11.Value = creditnotedetailsinfo.Debit;
				sprmparam11 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam11.Value = creditnotedetailsinfo.ExchangeRateId;
				sprmparam11 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam11.Value = creditnotedetailsinfo.ChequeNo;
				sprmparam11 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam11.Value = creditnotedetailsinfo.ChequeDate;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = creditnotedetailsinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = creditnotedetailsinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = creditnotedetailsinfo.Extra2;
				decId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decId;
		}

		public decimal CreditNoteDetailsEdit(CreditNoteDetailsInfo creditnotedetailsinfo)
		{
			decimal decCreditNoteDetails = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@creditNoteDetailsId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotedetailsinfo.CreditNoteDetailsId;
				sprmparam12 = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotedetailsinfo.CreditNoteMasterId;
				sprmparam12 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotedetailsinfo.LedgerId;
				sprmparam12 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam12.Value = creditnotedetailsinfo.Credit;
				sprmparam12 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam12.Value = creditnotedetailsinfo.ExchangeRateId;
				sprmparam12 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam12.Value = creditnotedetailsinfo.Debit;
				sprmparam12 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam12.Value = creditnotedetailsinfo.ChequeNo;
				sprmparam12 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam12.Value = creditnotedetailsinfo.ChequeDate;
				sprmparam12 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam12.Value = creditnotedetailsinfo.ExtraDate;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = creditnotedetailsinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = creditnotedetailsinfo.Extra2;
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
			return decCreditNoteDetails;
		}

		public DataTable CreditNoteDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteDetailsViewAll", base.sqlcon);
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

		public CreditNoteDetailsInfo CreditNoteDetailsView(decimal creditNoteDetailsId)
		{
			CreditNoteDetailsInfo infoCreditNoteDetails = new CreditNoteDetailsInfo();
			SqlDataReader sdrreader2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@creditNoteDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = creditNoteDetailsId;
				sdrreader2 = sccmd.ExecuteReader();
				while (sdrreader2.Read())
				{
					infoCreditNoteDetails.CreditNoteDetailsId = Convert.ToDecimal(((DbDataReader)sdrreader2)[0].ToString());
					infoCreditNoteDetails.CreditNoteMasterId = Convert.ToDecimal(((DbDataReader)sdrreader2)[1].ToString());
					infoCreditNoteDetails.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader2)[2].ToString());
					infoCreditNoteDetails.Credit = Convert.ToDecimal(((DbDataReader)sdrreader2)[3].ToString());
					infoCreditNoteDetails.Debit = Convert.ToDecimal(((DbDataReader)sdrreader2)[4].ToString());
					infoCreditNoteDetails.ExchangeRateId = Convert.ToDecimal(((DbDataReader)sdrreader2)[5].ToString());
					infoCreditNoteDetails.ChequeNo = ((DbDataReader)sdrreader2)[6].ToString();
					infoCreditNoteDetails.ChequeDate = Convert.ToDateTime(((DbDataReader)sdrreader2)[7].ToString());
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
			return infoCreditNoteDetails;
		}

		public DataTable CreditNoteDetailsViewByMasterId(decimal decMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteDetailsViewByMasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal).Value = decMasterId;
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

		public void CreditNoteDetailsDelete(decimal CreditNoteMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteDetailsDelete", base.sqlcon);
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

		public int CreditNoteDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditNoteDetailsMax", base.sqlcon);
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
	}
}
