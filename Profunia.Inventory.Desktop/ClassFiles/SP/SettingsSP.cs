using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SettingsSP : DBConnection
	{
		public void SettingsAdd(SettingsInfo settingsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SettingsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@settingsId", SqlDbType.Decimal);
				sprmparam7.Value = settingsinfo.SettingsId;
				sprmparam7 = sccmd.Parameters.Add("@settingsName", SqlDbType.VarChar);
				sprmparam7.Value = settingsinfo.SettingsName;
				sprmparam7 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam7.Value = settingsinfo.Status;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.VarChar);
				sprmparam7.Value = settingsinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = settingsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = settingsinfo.Extra2;
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

		public void SettingsEdit(SettingsInfo settingsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SettingsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@settingsId", SqlDbType.Decimal);
				sprmparam3.Value = settingsinfo.SettingsId;
				sprmparam3 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam3.Value = settingsinfo.Status;
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

		public DataTable SettingsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SettingsViewAll", base.sqlcon);
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

		public DataTable SettingsToCopyViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SettingsToCopyViewAll", base.sqlcon);
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

		public DataTable SettinsCheckReference()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SettinsCheckReference", base.sqlcon);
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

		public SettingsInfo SettingsView(string strsettingsName)
		{
			SettingsInfo settingsinfo = new SettingsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SettingsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@settingsName", SqlDbType.VarChar);
				sprmparam2.Value = strsettingsName;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					settingsinfo.SettingsId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					settingsinfo.SettingsName = ((DbDataReader)sdrreader)[1].ToString();
					settingsinfo.Status = ((DbDataReader)sdrreader)[2].ToString();
					settingsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					settingsinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					settingsinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return settingsinfo;
		}

		public SettingsInfo SettingsToCopyView(string strsettingsName)
		{
			SettingsInfo settingsinfo = new SettingsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SettingsToCopyView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@settingsName", SqlDbType.VarChar);
				sprmparam2.Value = strsettingsName;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					settingsinfo.SettingsId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					settingsinfo.SettingsName = ((DbDataReader)sdrreader)[1].ToString();
					settingsinfo.Status = ((DbDataReader)sdrreader)[2].ToString();
					settingsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					settingsinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					settingsinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return settingsinfo;
		}

		public int SettingsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SettingsMax", base.sqlcon);
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

		public bool AutomaticProductCodeGeneration()
		{
			string strStatus = string.Empty;
			bool isTrue = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AutomaticProductCodeGeneration", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				strStatus = sccmd.ExecuteScalar().ToString();
				isTrue = (strStatus == "Yes" && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isTrue;
		}

		public bool ShowProductCode()
		{
			string strStatus = string.Empty;
			bool isTrue = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ShowProductCode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				strStatus = sccmd.ExecuteScalar().ToString();
				isTrue = (strStatus == "Yes" && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isTrue;
		}

		public bool ShowBarcode()
		{
			string strStatus = "";
			bool isTrue = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ShowBarcode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				strStatus = sccmd.ExecuteScalar().ToString();
				isTrue = (strStatus == "Yes" && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isTrue;
		}

		public bool ShowCurrencySymbol()
		{
			string strStatus = "";
			bool isTrue = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ShowCurrencySymbol", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				strStatus = sccmd.ExecuteScalar().ToString();
				isTrue = (strStatus == "Yes" && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isTrue;
		}

		public decimal SettingsGetId(string strsettingsName)
		{
			decimal decSettingsId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SettingsGetId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@settingsName", SqlDbType.VarChar).Value = strsettingsName;
				decSettingsId = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decSettingsId;
		}

		public bool SettingsToCopyStatusCheck(string strSettingsName)
		{
			decimal decStatus = 0m;
			bool blStatus = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SettingsToCopyStatusCheck", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@settingsName", SqlDbType.VarChar).Value = strSettingsName;
				decStatus = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
				blStatus = (decStatus == 1m && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return blStatus;
		}

		public string SettingsStatusCheck(string strSettingsName)
		{
			string strStatus = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SettingsStatusCheck", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@settingsName", SqlDbType.VarChar).Value = strSettingsName;
				strStatus = Convert.ToString(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strStatus;
		}
	}
}
