using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DailyAttendanceMasterSP : DBConnection
	{
		public void DailyAttendanceMasterAdd(DailyAttendanceMasterInfo dailyattendancemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam7.Value = dailyattendancemasterinfo.DailyAttendanceMasterId;
				sprmparam7 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam7.Value = dailyattendancemasterinfo.Date;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancemasterinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = dailyattendancemasterinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancemasterinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancemasterinfo.Extra2;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void DailyAttendanceMasterEdit(DailyAttendanceMasterInfo dailyattendancemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam7.Value = dailyattendancemasterinfo.DailyAttendanceMasterId;
				sprmparam7 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam7.Value = dailyattendancemasterinfo.Date;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancemasterinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = dailyattendancemasterinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancemasterinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancemasterinfo.Extra2;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable DailyAttendanceMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DailyAttendanceMasterViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DailyAttendanceMasterInfo DailyAttendanceMasterView(decimal dailyAttendanceMasterId)
		{
			DailyAttendanceMasterInfo dailyattendancemasterinfo = new DailyAttendanceMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = dailyAttendanceMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					dailyattendancemasterinfo.DailyAttendanceMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					dailyattendancemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
					dailyattendancemasterinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
					dailyattendancemasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					dailyattendancemasterinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					dailyattendancemasterinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				sdrreader.Close();
				base.sqlcon.Close();
			}
			return dailyattendancemasterinfo;
		}

		public void DailyAttendanceMasterDelete(decimal DailyAttendanceMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = DailyAttendanceMasterId;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public int DailyAttendanceMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				max = int.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return max;
		}

		public decimal DailyAttendanceAddToMaster(DailyAttendanceMasterInfo dailyattendancemasterinfo)
		{
			decimal incount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceAddToMaster", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam5.Value = dailyattendancemasterinfo.Date;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = dailyattendancemasterinfo.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = dailyattendancemasterinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = dailyattendancemasterinfo.Extra2;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					incount = decimal.Parse(obj.ToString());
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return incount;
		}

		public void DailyAttendanceEditMaster(DailyAttendanceMasterInfo dailyattendancemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceEditMaster", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam6.Value = dailyattendancemasterinfo.DailyAttendanceMasterId;
				sprmparam6 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam6.Value = dailyattendancemasterinfo.Date;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = dailyattendancemasterinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = dailyattendancemasterinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = dailyattendancemasterinfo.Extra2;
				int ineffectedrow = sccmd.ExecuteNonQuery();
				if (ineffectedrow > 0)
				{
					goto end_IL_0001;
				}
				end_IL_0001:;
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable DailyAttendanceViewForDailyAttendanceReport(string strDate, string strStatus, string strEmployeeCode, string strDesignation)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("DailyAttendanceViewForDailyAttendanceReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SlNo", typeof(decimal));
				dtbl.Columns["SlNo"].AutoIncrement = true;
				dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@workingDay", SqlDbType.VarChar).Value = strDate;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
				sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			return dtbl;
		}

		public bool DailyAttendanceMasterMasterIdSearch(string strDate)
		{
			decimal deccountMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DailyAttendanceMasterMasterIdSearch", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@date", SqlDbType.VarChar).Value = strDate;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null)
				{
					deccountMasterId = decimal.Parse(obj.ToString());
				}
				if (deccountMasterId > 0m)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return false;
		}

		public DataTable MonthlyAttendanceReportFill(DateTime dtMonth, decimal decEmployeeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("MonthlyAttendanceReportFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime).Value = dtMonth;
				sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal).Value = decEmployeeId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtbl;
		}
	}
}
