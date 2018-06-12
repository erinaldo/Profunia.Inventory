using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BarcodeSettingsSP : DBConnection
	{
		public void BarcodeSettingsAdd(BarcodeSettingsInfo barcodesettingsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeSettingsAddorEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@showProductCode", SqlDbType.Bit);
				sprmparam19.Value = barcodesettingsinfo.ShowProductCode;
				sprmparam19 = sccmd.Parameters.Add("@showCompanyName", SqlDbType.Bit);
				sprmparam19.Value = barcodesettingsinfo.ShowCompanyName;
				sprmparam19 = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.CompanyName;
				sprmparam19 = sccmd.Parameters.Add("@showPurchaseRate", SqlDbType.Bit);
				sprmparam19.Value = barcodesettingsinfo.ShowPurchaseRate;
				sprmparam19 = sccmd.Parameters.Add("@showMRP", SqlDbType.Bit);
				sprmparam19.Value = barcodesettingsinfo.ShowMRP;
				sprmparam19 = sccmd.Parameters.Add("@point", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Point;
				sprmparam19 = sccmd.Parameters.Add("@zero", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Zero;
				sprmparam19 = sccmd.Parameters.Add("@one", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.One;
				sprmparam19 = sccmd.Parameters.Add("@two", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Two;
				sprmparam19 = sccmd.Parameters.Add("@three", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Three;
				sprmparam19 = sccmd.Parameters.Add("@four", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Four;
				sprmparam19 = sccmd.Parameters.Add("@five", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Five;
				sprmparam19 = sccmd.Parameters.Add("@six", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Six;
				sprmparam19 = sccmd.Parameters.Add("@seven", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Seven;
				sprmparam19 = sccmd.Parameters.Add("@eight", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Eight;
				sprmparam19 = sccmd.Parameters.Add("@nine", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Nine;
				sprmparam19 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Extra1;
				sprmparam19 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam19.Value = barcodesettingsinfo.Extra2;
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

		public void BarcodeSettingsEdit(BarcodeSettingsInfo barcodesettingsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeSettingsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@barcodeSettingsId", SqlDbType.Decimal);
				sprmparam21.Value = barcodesettingsinfo.BarcodeSettingsId;
				sprmparam21 = sccmd.Parameters.Add("@showProductCode", SqlDbType.Bit);
				sprmparam21.Value = barcodesettingsinfo.ShowProductCode;
				sprmparam21 = sccmd.Parameters.Add("@showCompanyName", SqlDbType.Bit);
				sprmparam21.Value = barcodesettingsinfo.ShowCompanyName;
				sprmparam21 = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.CompanyName;
				sprmparam21 = sccmd.Parameters.Add("@showPurchaseRate", SqlDbType.Bit);
				sprmparam21.Value = barcodesettingsinfo.ShowPurchaseRate;
				sprmparam21 = sccmd.Parameters.Add("@showMRP", SqlDbType.Bit);
				sprmparam21.Value = barcodesettingsinfo.ShowMRP;
				sprmparam21 = sccmd.Parameters.Add("@point", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Point;
				sprmparam21 = sccmd.Parameters.Add("@zero", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Zero;
				sprmparam21 = sccmd.Parameters.Add("@one", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.One;
				sprmparam21 = sccmd.Parameters.Add("@two", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Two;
				sprmparam21 = sccmd.Parameters.Add("@three", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Three;
				sprmparam21 = sccmd.Parameters.Add("@four", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Four;
				sprmparam21 = sccmd.Parameters.Add("@five", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Five;
				sprmparam21 = sccmd.Parameters.Add("@six", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Six;
				sprmparam21 = sccmd.Parameters.Add("@seven", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Seven;
				sprmparam21 = sccmd.Parameters.Add("@eight", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Eight;
				sprmparam21 = sccmd.Parameters.Add("@nine", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Nine;
				sprmparam21 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Extra1;
				sprmparam21 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam21.Value = barcodesettingsinfo.Extra2;
				sprmparam21 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam21.Value = barcodesettingsinfo.ExtraDate;
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

		public DataTable BarcodeSettingsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BarcodeSettingsViewAll", base.sqlcon);
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

		public BarcodeSettingsInfo BarcodeSettingsView(decimal barcodeSettingsId)
		{
			BarcodeSettingsInfo barcodesettingsinfo = new BarcodeSettingsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeSettingsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@barcodeSettingsId", SqlDbType.Decimal);
				sprmparam2.Value = barcodeSettingsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					barcodesettingsinfo.BarcodeSettingsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					barcodesettingsinfo.ShowProductCode = bool.Parse(((DbDataReader)sdrreader)[1].ToString());
					barcodesettingsinfo.ShowCompanyName = bool.Parse(((DbDataReader)sdrreader)[2].ToString());
					barcodesettingsinfo.CompanyName = ((DbDataReader)sdrreader)[3].ToString();
					barcodesettingsinfo.ShowPurchaseRate = bool.Parse(((DbDataReader)sdrreader)[4].ToString());
					barcodesettingsinfo.ShowMRP = bool.Parse(((DbDataReader)sdrreader)[5].ToString());
					barcodesettingsinfo.Point = ((DbDataReader)sdrreader)[6].ToString();
					barcodesettingsinfo.Zero = ((DbDataReader)sdrreader)[7].ToString();
					barcodesettingsinfo.One = ((DbDataReader)sdrreader)[8].ToString();
					barcodesettingsinfo.Two = ((DbDataReader)sdrreader)[9].ToString();
					barcodesettingsinfo.Three = ((DbDataReader)sdrreader)[10].ToString();
					barcodesettingsinfo.Four = ((DbDataReader)sdrreader)[11].ToString();
					barcodesettingsinfo.Five = ((DbDataReader)sdrreader)[12].ToString();
					barcodesettingsinfo.Six = ((DbDataReader)sdrreader)[13].ToString();
					barcodesettingsinfo.Seven = ((DbDataReader)sdrreader)[14].ToString();
					barcodesettingsinfo.Eight = ((DbDataReader)sdrreader)[15].ToString();
					barcodesettingsinfo.Nine = ((DbDataReader)sdrreader)[16].ToString();
					barcodesettingsinfo.Extra1 = ((DbDataReader)sdrreader)[17].ToString();
					barcodesettingsinfo.Extra2 = ((DbDataReader)sdrreader)[18].ToString();
					barcodesettingsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[19].ToString());
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
			return barcodesettingsinfo;
		}

		public BarcodeSettingsInfo BarcodeSettingsViewForBarCodePrinting()
		{
			BarcodeSettingsInfo barcodesettingsinfo = new BarcodeSettingsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeSettingsViewForBarcodePrinting", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					barcodesettingsinfo.BarcodeSettingsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					barcodesettingsinfo.ShowProductCode = bool.Parse(((DbDataReader)sdrreader)[2].ToString());
					barcodesettingsinfo.ShowCompanyName = bool.Parse(((DbDataReader)sdrreader)[1].ToString());
					barcodesettingsinfo.CompanyName = ((DbDataReader)sdrreader)[3].ToString();
					barcodesettingsinfo.ShowPurchaseRate = bool.Parse(((DbDataReader)sdrreader)[4].ToString());
					barcodesettingsinfo.ShowMRP = bool.Parse(((DbDataReader)sdrreader)[5].ToString());
					barcodesettingsinfo.Point = ((DbDataReader)sdrreader)[6].ToString();
					barcodesettingsinfo.Zero = ((DbDataReader)sdrreader)[7].ToString();
					barcodesettingsinfo.One = ((DbDataReader)sdrreader)[8].ToString();
					barcodesettingsinfo.Two = ((DbDataReader)sdrreader)[9].ToString();
					barcodesettingsinfo.Three = ((DbDataReader)sdrreader)[10].ToString();
					barcodesettingsinfo.Four = ((DbDataReader)sdrreader)[11].ToString();
					barcodesettingsinfo.Five = ((DbDataReader)sdrreader)[12].ToString();
					barcodesettingsinfo.Six = ((DbDataReader)sdrreader)[13].ToString();
					barcodesettingsinfo.Seven = ((DbDataReader)sdrreader)[14].ToString();
					barcodesettingsinfo.Eight = ((DbDataReader)sdrreader)[15].ToString();
					barcodesettingsinfo.Nine = ((DbDataReader)sdrreader)[16].ToString();
					barcodesettingsinfo.Extra1 = ((DbDataReader)sdrreader)[17].ToString();
					barcodesettingsinfo.Extra2 = ((DbDataReader)sdrreader)[18].ToString();
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
			return barcodesettingsinfo;
		}

		public void BarcodeSettingsDelete(decimal BarcodeSettingsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeSettingsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@barcodeSettingsId", SqlDbType.Decimal);
				sprmparam2.Value = BarcodeSettingsId;
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

		public int BarcodeSettingsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeSettingsMax", base.sqlcon);
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
