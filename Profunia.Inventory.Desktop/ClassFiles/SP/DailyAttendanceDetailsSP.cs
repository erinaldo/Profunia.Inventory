using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DailyAttendanceDetailsSP : DBConnection
	{
		public void DailyAttendanceDetailsAdd(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
				sprmparam9.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
				sprmparam9 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam9.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
				sprmparam9 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam9.Value = dailyattendancedetailsinfo.EmployeeId;
				sprmparam9 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Status;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = dailyattendancedetailsinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Extra2;
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

		public void DailyAttendanceDetailsEdit(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
				sprmparam9.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
				sprmparam9 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam9.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
				sprmparam9 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam9.Value = dailyattendancedetailsinfo.EmployeeId;
				sprmparam9 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Status;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = dailyattendancedetailsinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = dailyattendancedetailsinfo.Extra2;
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

		public DataTable DailyAttendanceDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DailyAttendanceDetailsViewAll", base.sqlcon);
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

		public DailyAttendanceDetailsInfo DailyAttendanceDetailsView(decimal dailyAttendanceDetailsId)
		{
			DailyAttendanceDetailsInfo dailyattendancedetailsinfo = new DailyAttendanceDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = dailyAttendanceDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					dailyattendancedetailsinfo.DailyAttendanceDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					dailyattendancedetailsinfo.DailyAttendanceMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					dailyattendancedetailsinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					dailyattendancedetailsinfo.Status = ((DbDataReader)sdrreader)[3].ToString();
					dailyattendancedetailsinfo.Narration = ((DbDataReader)sdrreader)[4].ToString();
					dailyattendancedetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					dailyattendancedetailsinfo.Extra1 = ((DbDataReader)sdrreader)[6].ToString();
					dailyattendancedetailsinfo.Extra2 = ((DbDataReader)sdrreader)[7].ToString();
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
			return dailyattendancedetailsinfo;
		}

		public void DailyAttendanceDetailsDelete(decimal DailyAttendanceDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = DailyAttendanceDetailsId;
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

		public int DailyAttendanceDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsMax", base.sqlcon);
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

		public DataTable DailyAttendanceDetailsSearchGridFill(string strDate)
		{
			DataTable dtblAttendance = new DataTable();
			dtblAttendance.Columns.Add("Sl NO", typeof(decimal));
			dtblAttendance.Columns["Sl NO"].AutoIncrement = true;
			dtblAttendance.Columns["Sl NO"].AutoIncrementSeed = 1L;
			dtblAttendance.Columns["Sl NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DailyAttendanceDetailsSearchGridFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Parse(strDate);
				sdaadapter.Fill(dtblAttendance);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblAttendance;
		}

		public void DailyAttendanceDetailsAddUsingMasterId(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsAddUsingMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
				sprmparam7 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam7.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
				sprmparam7 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam7.Value = dailyattendancedetailsinfo.EmployeeId;
				sprmparam7 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancedetailsinfo.Status;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancedetailsinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancedetailsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = dailyattendancedetailsinfo.Extra2;
				int ineffectedrow = sccmd.ExecuteNonQuery();
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

		public void DailyAttendanceDetailsDeleteAll(decimal decdailyAttendanceMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsDeleteAll", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decdailyAttendanceMasterId;
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

		public void DailyAttendanceDetailsEditUsingMasterId(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsEditUsingMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
				sprmparam8.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
				sprmparam8 = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
				sprmparam8.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
				sprmparam8 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam8.Value = dailyattendancedetailsinfo.EmployeeId;
				sprmparam8 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam8.Value = dailyattendancedetailsinfo.Status;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = dailyattendancedetailsinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = dailyattendancedetailsinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = dailyattendancedetailsinfo.Extra2;
				int ina = sccmd.ExecuteNonQuery();
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
