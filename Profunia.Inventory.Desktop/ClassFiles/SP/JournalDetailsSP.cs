using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class JournalDetailsSP : DBConnection
	{
		public decimal JournalDetailsAdd(JournalDetailsInfo journaldetailsinfo)
		{
			decimal decId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
				sprmparam11.Value = journaldetailsinfo.JournalMasterId;
				sprmparam11 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam11.Value = journaldetailsinfo.LedgerId;
				sprmparam11 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam11.Value = journaldetailsinfo.Credit;
				sprmparam11 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam11.Value = journaldetailsinfo.Debit;
				sprmparam11 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam11.Value = journaldetailsinfo.ExchangeRateId;
				sprmparam11 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam11.Value = journaldetailsinfo.ChequeNo;
				sprmparam11 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam11.Value = journaldetailsinfo.ChequeDate;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = journaldetailsinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = journaldetailsinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = journaldetailsinfo.Extra2;
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

		public void JournalDetailsEdit(JournalDetailsInfo journaldetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@journalDetailsId", SqlDbType.Decimal);
				sprmparam12.Value = journaldetailsinfo.JournalDetailsId;
				sprmparam12 = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
				sprmparam12.Value = journaldetailsinfo.JournalMasterId;
				sprmparam12 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam12.Value = journaldetailsinfo.LedgerId;
				sprmparam12 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam12.Value = journaldetailsinfo.Credit;
				sprmparam12 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam12.Value = journaldetailsinfo.Debit;
				sprmparam12 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam12.Value = journaldetailsinfo.ExchangeRateId;
				sprmparam12 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam12.Value = journaldetailsinfo.ChequeNo;
				sprmparam12 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam12.Value = journaldetailsinfo.ChequeDate;
				sprmparam12 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam12.Value = journaldetailsinfo.ExtraDate;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = journaldetailsinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = journaldetailsinfo.Extra2;
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

		public DataTable JournalDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalDetailsViewAll", base.sqlcon);
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

		public JournalDetailsInfo JournalDetailsView(decimal journalDetailsId)
		{
			JournalDetailsInfo journaldetailsinfo = new JournalDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@journalDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = journalDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					journaldetailsinfo.JournalDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					journaldetailsinfo.JournalMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					journaldetailsinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					journaldetailsinfo.Credit = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					journaldetailsinfo.Debit = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					journaldetailsinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					journaldetailsinfo.ChequeNo = ((DbDataReader)sdrreader)[6].ToString();
					journaldetailsinfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
					journaldetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[8].ToString());
					journaldetailsinfo.Extra1 = ((DbDataReader)sdrreader)[9].ToString();
					journaldetailsinfo.Extra2 = ((DbDataReader)sdrreader)[10].ToString();
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
			return journaldetailsinfo;
		}

		public void JournalDetailsDelete(decimal JournalDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@journalDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = JournalDetailsId;
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

		public int JournalDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("JournalDetailsMax", base.sqlcon);
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

		public DataTable JournalDetailsViewByMasterId(decimal decMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalDetailsViewByMasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@journalMasterId", SqlDbType.Decimal).Value = decMasterId;
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
