using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ExchangeRateSP : DBConnection
	{
		public void ExchangeRateAdd(ExchangeRateInfo exchangerateinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangeRateAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam8.Value = exchangerateinfo.CurrencyId;
				sprmparam8 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam8.Value = exchangerateinfo.Date;
				sprmparam8 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam8.Value = exchangerateinfo.Rate;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = exchangerateinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = exchangerateinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = exchangerateinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = exchangerateinfo.Extra2;
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

		public void ExchangeRateEdit(ExchangeRateInfo exchangerateinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangeRateEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam8.Value = exchangerateinfo.ExchangeRateId;
				sprmparam8 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam8.Value = exchangerateinfo.CurrencyId;
				sprmparam8 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam8.Value = exchangerateinfo.Date;
				sprmparam8 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam8.Value = exchangerateinfo.Rate;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = exchangerateinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = exchangerateinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = exchangerateinfo.Extra2;
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

		public DataTable ExchangeRateViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ExchangeRateViewAll", base.sqlcon);
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

		public ExchangeRateInfo ExchangeRateView(decimal exchangeRateId)
		{
			ExchangeRateInfo exchangerateinfo = new ExchangeRateInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangeRateView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam2.Value = exchangeRateId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					exchangerateinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					exchangerateinfo.CurrencyId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					exchangerateinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[2].ToString());
					exchangerateinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					exchangerateinfo.Narration = ((DbDataReader)sdrreader)[4].ToString();
					exchangerateinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					exchangerateinfo.Extra1 = ((DbDataReader)sdrreader)[6].ToString();
					exchangerateinfo.Extra2 = ((DbDataReader)sdrreader)[7].ToString();
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
			return exchangerateinfo;
		}

		public void ExchangeRateDelete(decimal ExchangeRateId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangeRateDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam2.Value = ExchangeRateId;
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

		public int ExchangeRateGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangeRateMax", base.sqlcon);
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

		public void ExchangeRateAddParticularFields(ExchangeRateInfo exchangerateinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangeRateAddParticularFields", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam7.Value = exchangerateinfo.CurrencyId;
				sprmparam7 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam7.Value = exchangerateinfo.Date;
				sprmparam7 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam7.Value = exchangerateinfo.Rate;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = exchangerateinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = exchangerateinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = exchangerateinfo.Extra2;
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

		public DataTable ExchangeRateSearch(string strCurrencyname, DateTime dtDateFrom, DateTime dtDateTo)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ExchangeRateSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@currencyName", SqlDbType.VarChar).Value = strCurrencyname;
				sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtDateTo;
				sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtDateFrom;
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

		public bool ExchangeRateCheckExistence(DateTime dtDate, decimal decCurrencyId, decimal decExchangeRateId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ExchangeRateCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam4.Value = dtDate;
				sprmparam4 = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam4.Value = decExchangeRateId;
				sprmparam4 = sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam4.Value = decCurrencyId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = Convert.ToDecimal(obj.ToString());
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

		public decimal GetExchangeRateId(decimal decCurrencyId, DateTime dtDate)
		{
			decimal decCount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("GetExchangeRateId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
				sqlcmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtDate;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null)
				{
					decCount = Convert.ToDecimal(obj.ToString());
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
			return decCount;
		}

		public decimal ExchangeRateCheckReferences(decimal decExchangeRateId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ExchangeRateCheckReferences", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam2.Value = decExchangeRateId;
				decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decReturnValue;
		}

		public decimal GetExchangeRateByExchangeRateId(decimal decExchangeRateId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("GetExchangeRateByExchangeRateId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam2.Value = decExchangeRateId;
				decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decReturnValue;
		}

		public decimal ExchangeRateViewByExchangeRateId(decimal decExchangeRateId)
		{
			decimal exchangeRate = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangeRateViewByExchangeRateId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam2.Value = decExchangeRateId;
				exchangeRate = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return exchangeRate;
		}

		public int NoOfDecimalNumberViewByExchangeRateId(decimal decExchangeRateId)
		{
			int NoOfDecimalNumber = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("NoOfDecimalNumberViewByExchangeRateId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam2.Value = decExchangeRateId;
				NoOfDecimalNumber = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return NoOfDecimalNumber;
		}

		public int NoOfDecimalNumberViewByCurrencyId(decimal decCurrencyId)
		{
			int NoOfDecimalNumber = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("NoOfDecimalNumberViewByCurrencyId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam2.Value = decCurrencyId;
				NoOfDecimalNumber = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return NoOfDecimalNumber;
		}

		public decimal ExchangerateViewByCurrencyId(decimal decCurrencyId)
		{
			decimal decExchangerateId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ExchangerateViewByCurrencyId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam2.Value = decCurrencyId;
				decExchangerateId = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decExchangerateId;
		}

		public bool ExchangeRateCheckExistanceForUpdationAndDelete(DateTime dtDate, decimal decExchangeRateId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ExchangeRateCheckExistanceForUpdationAndDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam3.Value = dtDate;
				sprmparam3 = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam3.Value = decExchangeRateId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = Convert.ToDecimal(obj.ToString());
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
	}
}
