using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SuffixPrefixSP : DBConnection
	{
		public void SuffixPrefixAdd(SuffixPrefixInfo suffixprefixinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SuffixPrefixAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
				sprmparam14.Value = suffixprefixinfo.SuffixprefixId;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = suffixprefixinfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam14.Value = suffixprefixinfo.FromDate;
				sprmparam14 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam14.Value = suffixprefixinfo.ToDate;
				sprmparam14 = sccmd.Parameters.Add("@startIndex", SqlDbType.Decimal);
				sprmparam14.Value = suffixprefixinfo.StartIndex;
				sprmparam14 = sccmd.Parameters.Add("@prefix", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Prefix;
				sprmparam14 = sccmd.Parameters.Add("@suffix", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Suffix;
				sprmparam14 = sccmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Int);
				sprmparam14.Value = suffixprefixinfo.WidthOfNumericalPart;
				sprmparam14 = sccmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit);
				sprmparam14.Value = suffixprefixinfo.PrefillWithZero;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam14.Value = suffixprefixinfo.ExtraDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Extra2;
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

		public void SuffixPrefixEdit(SuffixPrefixInfo suffixprefixinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SuffixPrefixEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
				sprmparam14.Value = suffixprefixinfo.SuffixprefixId;
				sprmparam14 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam14.Value = suffixprefixinfo.VoucherTypeId;
				sprmparam14 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam14.Value = suffixprefixinfo.FromDate;
				sprmparam14 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam14.Value = suffixprefixinfo.ToDate;
				sprmparam14 = sccmd.Parameters.Add("@startIndex", SqlDbType.Decimal);
				sprmparam14.Value = suffixprefixinfo.StartIndex;
				sprmparam14 = sccmd.Parameters.Add("@prefix", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Prefix;
				sprmparam14 = sccmd.Parameters.Add("@suffix", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Suffix;
				sprmparam14 = sccmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Int);
				sprmparam14.Value = suffixprefixinfo.WidthOfNumericalPart;
				sprmparam14 = sccmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit);
				sprmparam14.Value = suffixprefixinfo.PrefillWithZero;
				sprmparam14 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Narration;
				sprmparam14 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam14.Value = suffixprefixinfo.ExtraDate;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = suffixprefixinfo.Extra2;
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

		public DataTable SuffixPrefixViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SuffixPrefixViewAll", base.sqlcon);
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

		public SuffixPrefixInfo SuffixPrefixView(decimal suffixprefixId)
		{
			SuffixPrefixInfo suffixprefixinfo = new SuffixPrefixInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SuffixPrefixView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
				sprmparam2.Value = suffixprefixId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					suffixprefixinfo.SuffixprefixId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					suffixprefixinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					suffixprefixinfo.FromDate = DateTime.Parse(((DbDataReader)sdrreader)[2].ToString());
					suffixprefixinfo.ToDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					suffixprefixinfo.StartIndex = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					suffixprefixinfo.Prefix = ((DbDataReader)sdrreader)[5].ToString();
					suffixprefixinfo.Suffix = ((DbDataReader)sdrreader)[6].ToString();
					suffixprefixinfo.WidthOfNumericalPart = int.Parse(((DbDataReader)sdrreader)[7].ToString());
					suffixprefixinfo.PrefillWithZero = bool.Parse(((DbDataReader)sdrreader)[8].ToString());
					suffixprefixinfo.Narration = ((DbDataReader)sdrreader)[9].ToString();
					suffixprefixinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[10].ToString());
					suffixprefixinfo.Extra1 = ((DbDataReader)sdrreader)[11].ToString();
					suffixprefixinfo.Extra2 = ((DbDataReader)sdrreader)[12].ToString();
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
			return suffixprefixinfo;
		}

		public void SuffixPrefixDelete(decimal SuffixprefixId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SuffixPrefixDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
				sprmparam2.Value = SuffixprefixId;
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

		public int SuffixPrefixGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SuffixPrefixMax", base.sqlcon);
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

		public SuffixPrefixInfo GetSuffixPrefixDetails(decimal vouchertypeId, DateTime date)
		{
			SuffixPrefixInfo suffixprefixinfo = new SuffixPrefixInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GetSuffixPrefixDetails", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherId", SqlDbType.Decimal);
				sprmparam3.Value = vouchertypeId;
				sprmparam3 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam3.Value = date;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					suffixprefixinfo.SuffixprefixId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					suffixprefixinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					suffixprefixinfo.FromDate = DateTime.Parse(((DbDataReader)sdrreader)[2].ToString());
					suffixprefixinfo.ToDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					suffixprefixinfo.StartIndex = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					suffixprefixinfo.Prefix = ((DbDataReader)sdrreader)[5].ToString();
					suffixprefixinfo.Suffix = ((DbDataReader)sdrreader)[6].ToString();
					suffixprefixinfo.WidthOfNumericalPart = int.Parse(((DbDataReader)sdrreader)[7].ToString());
					suffixprefixinfo.PrefillWithZero = bool.Parse(((DbDataReader)sdrreader)[8].ToString());
					suffixprefixinfo.Narration = ((DbDataReader)sdrreader)[9].ToString();
					suffixprefixinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[10].ToString());
					suffixprefixinfo.Extra1 = ((DbDataReader)sdrreader)[11].ToString();
					suffixprefixinfo.Extra2 = ((DbDataReader)sdrreader)[12].ToString();
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
			return suffixprefixinfo;
		}

		public DataTable VoucherTypeViewAllInSuffixPrefix()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAllInSuffixPrefix", base.sqlcon);
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

		public DataTable VoucherTypeSearchInSuffixPrefix(string strVoucherTypeName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl No", typeof(decimal));
			dtbl.Columns["Sl No"].AutoIncrement = true;
			dtbl.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeSearchInSuffixPrefix", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool SuffixPrefixCheckExistenceForAdd(string strfromDate, string strtoDate, decimal decvoucherTypeId, decimal decsuffixprefixId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SuffixPrefixCheckExistenceForAdd", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam5.Value = DateTime.Parse(strfromDate);
				sprmparam5 = sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam5.Value = DateTime.Parse(strtoDate);
				sprmparam5 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = decvoucherTypeId;
				sprmparam5 = sqlcmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
				sprmparam5.Value = decsuffixprefixId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = decimal.Parse(obj.ToString());
				}
				if (decCount > 0m)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return false;
		}

		public bool SuffixPrefixAddWithId(SuffixPrefixInfo Infosuffixprefix)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SuffixPrefixAddWithId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = Infosuffixprefix.VoucherTypeId;
				sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Infosuffixprefix.FromDate;
				sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Infosuffixprefix.ToDate;
				sqlcmd.Parameters.Add("@startIndex", SqlDbType.Decimal).Value = Infosuffixprefix.StartIndex;
				sqlcmd.Parameters.Add("@prefix", SqlDbType.VarChar).Value = Infosuffixprefix.Prefix;
				sqlcmd.Parameters.Add("@suffix", SqlDbType.VarChar).Value = Infosuffixprefix.Suffix;
				sqlcmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Decimal).Value = Infosuffixprefix.WidthOfNumericalPart;
				sqlcmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit).Value = Infosuffixprefix.PrefillWithZero;
				sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = Infosuffixprefix.Narration;
				sqlcmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = Infosuffixprefix.Extra1;
				sqlcmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = Infosuffixprefix.Extra2;
				int ineffectedrow = sqlcmd.ExecuteNonQuery();
				isSave = (ineffectedrow > 0 && true);
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

		public bool SuffixPrefixSettingsEdit(SuffixPrefixInfo Infosuffixprefix)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SuffixPrefixSettingsEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal).Value = Infosuffixprefix.SuffixprefixId;
				sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = Infosuffixprefix.VoucherTypeId;
				sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Infosuffixprefix.FromDate;
				sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Infosuffixprefix.ToDate;
				sqlcmd.Parameters.Add("@startIndex", SqlDbType.VarChar).Value = Infosuffixprefix.StartIndex;
				sqlcmd.Parameters.Add("@prefix", SqlDbType.VarChar).Value = Infosuffixprefix.Prefix;
				sqlcmd.Parameters.Add("@suffix", SqlDbType.VarChar).Value = Infosuffixprefix.Suffix;
				sqlcmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Decimal).Value = Infosuffixprefix.WidthOfNumericalPart;
				sqlcmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit).Value = Infosuffixprefix.PrefillWithZero;
				sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = Infosuffixprefix.Narration;
				int ineffectedrow = sqlcmd.ExecuteNonQuery();
				isEdit = (ineffectedrow > 0 && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public decimal SuffixPrefixSettingsDeleting(decimal SuffixprefixId)
		{
			decimal decId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SuffixPrefixSettingsDeleting", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
				sprmparam2.Value = SuffixprefixId;
				decId = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
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
	}
}
