using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class HolidaySP : DBConnection
	{
		public void HolidayAdd(HolidayInfo holidayinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("HolidayAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
				sprmparam8.Value = holidayinfo.HolidayId;
				sprmparam8 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam8.Value = holidayinfo.Date;
				sprmparam8 = sccmd.Parameters.Add("@holidayName", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.HolidayName;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = holidayinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.Extra2;
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

		public void HolidayEdit(HolidayInfo holidayinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("HolidayEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
				sprmparam8.Value = holidayinfo.HolidayId;
				sprmparam8 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam8.Value = holidayinfo.Date;
				sprmparam8 = sccmd.Parameters.Add("@holidayName", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.HolidayName;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = holidayinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = holidayinfo.Extra2;
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

		public DataTable HolidayViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("HolidayViewAll", base.sqlcon);
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

		public HolidayInfo HolidayView(decimal holidayId)
		{
			HolidayInfo holidayinfo = new HolidayInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("HolidayView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
				sprmparam2.Value = holidayId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					holidayinfo.HolidayId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					holidayinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
					holidayinfo.HolidayName = ((DbDataReader)sdrreader)[2].ToString();
					holidayinfo.Narration = ((DbDataReader)sdrreader)[3].ToString();
					holidayinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					holidayinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					holidayinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return holidayinfo;
		}

		public void HolidayDelete(decimal HolidayId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("HolidayDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
				sprmparam2.Value = HolidayId;
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

		public int HolidayGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("HolidayMax", base.sqlcon);
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

		public DataTable HoildaySettingsViewAllLimited(string strMonth, string strYear)
		{
			DataTable dtblHolidaySettings = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("HoildaySettingsViewAllLimited", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@Month", SqlDbType.VarChar).Value = strMonth;
				sqlda.SelectCommand.Parameters.Add("@Year", SqlDbType.VarChar).Value = strYear;
				sqlda.Fill(dtblHolidaySettings);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblHolidaySettings;
		}

		public bool HolidayAddWithIdentity(HolidayInfo holidayinfo)
		{
			bool isSave = true;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("HolidayAddWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam6.Value = holidayinfo.Date;
				sprmparam6 = sccmd.Parameters.Add("@holidayName", SqlDbType.VarChar);
				sprmparam6.Value = holidayinfo.HolidayName;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = holidayinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = holidayinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = holidayinfo.Extra2;
				int inAffected = sccmd.ExecuteNonQuery();
				isSave = (inAffected > 0 && true);
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

		public void HolidaySettingsDeleteByMonth(string strMonth, string strYear)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("HolidaySettingsDeleteByMonth", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@Month", SqlDbType.VarChar).Value = strMonth;
				sqlcmd.Parameters.Add("@Year", SqlDbType.VarChar).Value = strYear;
				sqlcmd.ExecuteNonQuery();
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

		public decimal HolliDayChecking(DateTime date)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("HolliDayChecking", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam2.Value = date;
				decResult = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decResult;
		}
	}
}
