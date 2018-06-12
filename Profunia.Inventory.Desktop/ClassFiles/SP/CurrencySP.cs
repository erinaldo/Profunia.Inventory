using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class CurrencySP : DBConnection
	{
		public void CurrencyAdd(CurrencyInfo currencyinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CurrencyAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam11.Value = currencyinfo.CurrencyId;
				sprmparam11 = sccmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
				sprmparam11.Value = currencyinfo.CurrencySymbol;
				sprmparam11 = sccmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
				sprmparam11.Value = currencyinfo.CurrencyName;
				sprmparam11 = sccmd.Parameters.Add("@subunitName", SqlDbType.VarChar);
				sprmparam11.Value = currencyinfo.SubunitName;
				sprmparam11 = sccmd.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
				sprmparam11.Value = currencyinfo.NoOfDecimalPlaces;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = currencyinfo.Narration;
				sprmparam11 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam11.Value = currencyinfo.IsDefault;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = currencyinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = currencyinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = currencyinfo.Extra2;
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

		public void CurrencyEdit(CurrencyInfo currencyinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CurrencyEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam10.Value = currencyinfo.CurrencyId;
				sprmparam10 = sccmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
				sprmparam10.Value = currencyinfo.CurrencySymbol;
				sprmparam10 = sccmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
				sprmparam10.Value = currencyinfo.CurrencyName;
				sprmparam10 = sccmd.Parameters.Add("@subunitName", SqlDbType.VarChar);
				sprmparam10.Value = currencyinfo.SubunitName;
				sprmparam10 = sccmd.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
				sprmparam10.Value = currencyinfo.NoOfDecimalPlaces;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = currencyinfo.Narration;
				sprmparam10 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam10.Value = currencyinfo.IsDefault;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = currencyinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = currencyinfo.Extra2;
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

		public DataTable CurrencyViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAll", base.sqlcon);
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

		public DataTable CurrencyViewAllByDate(DateTime date)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAllByDate", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam2.Value = date;
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

		public CurrencyInfo CurrencyView(decimal currencyId)
		{
			CurrencyInfo currencyinfo = new CurrencyInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CurrencyView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam2.Value = currencyId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					currencyinfo.CurrencyId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					currencyinfo.CurrencySymbol = ((DbDataReader)sdrreader)[1].ToString();
					currencyinfo.CurrencyName = ((DbDataReader)sdrreader)[2].ToString();
					currencyinfo.SubunitName = ((DbDataReader)sdrreader)[3].ToString();
					currencyinfo.NoOfDecimalPlaces = int.Parse(((DbDataReader)sdrreader)[4].ToString());
					currencyinfo.Narration = ((DbDataReader)sdrreader)[5].ToString();
					currencyinfo.IsDefault = bool.Parse(((DbDataReader)sdrreader)[6].ToString());
					currencyinfo.Extra1 = ((DbDataReader)sdrreader)[8].ToString();
					currencyinfo.Extra2 = ((DbDataReader)sdrreader)[9].ToString();
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
			return currencyinfo;
		}

		public void CurrencyDelete(decimal CurrencyId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CurrencyDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam2.Value = CurrencyId;
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

		public int CurrencyGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CurrencyMax", base.sqlcon);
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

		public DataTable CurrencyViewAllForCombo()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAllForCombo", base.sqlcon);
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

		public DataTable CurrencyViewAllForExchangeRateCombo()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAllForExchangeRateCombo", base.sqlcon);
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

		public decimal CurrencyAddwithIdentity(CurrencyInfo currencyinfo)
		{
			decimal decCurrencyId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CurrencyAddwithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
				sprmparam9.Value = currencyinfo.CurrencySymbol;
				sprmparam9 = sccmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
				sprmparam9.Value = currencyinfo.CurrencyName;
				sprmparam9 = sccmd.Parameters.Add("@subunitName", SqlDbType.VarChar);
				sprmparam9.Value = currencyinfo.SubunitName;
				sprmparam9 = sccmd.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
				sprmparam9.Value = currencyinfo.NoOfDecimalPlaces;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = currencyinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam9.Value = currencyinfo.IsDefault;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = currencyinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = currencyinfo.Extra2;
				object ObjCurrencytId = sccmd.ExecuteScalar();
				decCurrencyId = ((ObjCurrencytId == null) ? 0m : Convert.ToDecimal(ObjCurrencytId.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decCurrencyId;
		}

		public bool CurrencyNameCheckExistence(string strName, string strCurrencySymb, decimal decCurrencyId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("CurrencyNameCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
				sprmparam4.Value = strName;
				sprmparam4 = sqlcmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
				sprmparam4.Value = strCurrencySymb;
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

		public DataTable CurrencySearch(string strname, string strsymbol)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("CurrencySearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@currencyName", SqlDbType.VarChar).Value = strname;
				sqlda.SelectCommand.Parameters.Add("@currencySymbol", SqlDbType.VarChar).Value = strsymbol;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public decimal CurrencyCheckReferences(decimal decCurrencyId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("CurrencyCheckReferences", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam2.Value = decCurrencyId;
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

		public string CurrencySymbolById(decimal decCurrencyId)
		{
			string strReturnValue = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("CurrencySymbolById", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam2.Value = decCurrencyId;
				strReturnValue = sqlcmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strReturnValue;
		}

		public string GetCurrencySymbolByExchangeRateId(decimal decExchangeRateId)
		{
			string strCurrencySymbol = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("GetCurrencySymbolByExchangeRateId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam2.Value = decExchangeRateId;
				strCurrencySymbol = sqlcmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strCurrencySymbol;
		}

		public string GetDefaultCurrencySymbol()
		{
			string strCurrencySymbol = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("GetDefaultCurrencySymbol", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				strCurrencySymbol = sqlcmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strCurrencySymbol;
		}

		public bool DefaultCurrencyCheck(decimal decCurrencyId)
		{
			bool isDefault = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DefaultCurrencyCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
				isDefault = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isDefault;
		}

		public void DefaultCurrencySet(decimal decCurrencyId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DefaultCurrencySet", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
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
	}
}
