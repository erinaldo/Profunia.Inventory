using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DebitNoteDetailsSP : DBConnection
	{
		public decimal DebitNoteDetailsAdd(DebitNoteDetailsInfo debitnotedetailsinfo)
		{
			decimal decDebitNoteDetails = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
				sprmparam11.Value = debitnotedetailsinfo.DebitNoteMasterId;
				sprmparam11 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam11.Value = debitnotedetailsinfo.LedgerId;
				sprmparam11 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam11.Value = debitnotedetailsinfo.Credit;
				sprmparam11 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam11.Value = debitnotedetailsinfo.Debit;
				sprmparam11 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam11.Value = debitnotedetailsinfo.ExchangeRateId;
				sprmparam11 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam11.Value = debitnotedetailsinfo.ChequeNo;
				sprmparam11 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam11.Value = debitnotedetailsinfo.ChequeDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = debitnotedetailsinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = debitnotedetailsinfo.Extra2;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = debitnotedetailsinfo.ExtraDate;
				decDebitNoteDetails = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decDebitNoteDetails;
		}

		public void DebitNoteDetailsEdit(DebitNoteDetailsInfo debitnotedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@debitNoteDetailsId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotedetailsinfo.DebitNoteDetailsId;
				sprmparam12 = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotedetailsinfo.DebitNoteMasterId;
				sprmparam12 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotedetailsinfo.LedgerId;
				sprmparam12 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam12.Value = debitnotedetailsinfo.Credit;
				sprmparam12 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam12.Value = debitnotedetailsinfo.Debit;
				sprmparam12 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam12.Value = debitnotedetailsinfo.ExchangeRateId;
				sprmparam12 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam12.Value = debitnotedetailsinfo.ChequeNo;
				sprmparam12 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam12.Value = debitnotedetailsinfo.ChequeDate;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = debitnotedetailsinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = debitnotedetailsinfo.Extra2;
				sprmparam12 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam12.Value = debitnotedetailsinfo.ExtraDate;
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

		public DataTable DebitNoteDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteDetailsViewAll", base.sqlcon);
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

		public DebitNoteDetailsInfo DebitNoteDetailsView(decimal debitNoteDetailsId)
		{
			DebitNoteDetailsInfo debitnotedetailsinfo = new DebitNoteDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@debitNoteDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = debitNoteDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					debitnotedetailsinfo.DebitNoteDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					debitnotedetailsinfo.DebitNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					debitnotedetailsinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					debitnotedetailsinfo.Credit = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					debitnotedetailsinfo.Debit = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					debitnotedetailsinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					debitnotedetailsinfo.ChequeNo = ((DbDataReader)sdrreader)[6].ToString();
					debitnotedetailsinfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
					debitnotedetailsinfo.Extra1 = ((DbDataReader)sdrreader)[8].ToString();
					debitnotedetailsinfo.Extra2 = ((DbDataReader)sdrreader)[9].ToString();
					debitnotedetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[10].ToString());
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
			return debitnotedetailsinfo;
		}

		public void DebitNoteDetailsDelete(decimal DebitNoteDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@debitNoteDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = DebitNoteDetailsId;
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

		public int DebitNoteDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DebitNoteDetailsMax", base.sqlcon);
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

		public DataTable DebitNoteDetailsViewByMasterId(decimal decMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteDetailsViewByMasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal).Value = decMasterId;
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
	}
}
