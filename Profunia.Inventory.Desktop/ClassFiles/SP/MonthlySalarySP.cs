using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class MonthlySalarySP : DBConnection
	{
		public void MonthlySalaryAdd(MonthlySalaryInfo monthlysalaryinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam5.Value = monthlysalaryinfo.SalaryMonth;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalaryinfo.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalaryinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalaryinfo.Extra2;
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

		public void MonthlySalaryEdit(MonthlySalaryInfo monthlysalaryinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalaryinfo.MonthlySalaryId;
				sprmparam6 = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam6.Value = monthlysalaryinfo.SalaryMonth;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalaryinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalaryinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalaryinfo.Extra2;
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

		public DataTable MonthlySalaryViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalaryViewAll", base.sqlcon);
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

		public MonthlySalaryInfo MonthlySalaryView(decimal monthlySalaryId)
		{
			MonthlySalaryInfo monthlysalaryinfo = new MonthlySalaryInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
				sprmparam2.Value = monthlySalaryId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					monthlysalaryinfo.MonthlySalaryId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					monthlysalaryinfo.SalaryMonth = Convert.ToDateTime(((DbDataReader)sdrreader)[1].ToString());
					monthlysalaryinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
					monthlysalaryinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)[3].ToString());
					monthlysalaryinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					monthlysalaryinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return monthlysalaryinfo;
		}

		public void MonthlySalaryDelete(decimal MonthlySalaryId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
				sprmparam2.Value = MonthlySalaryId;
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

		public int MonthlySalaryGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryMax", base.sqlcon);
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

		public bool CheckSalaryStatusForAdvancePayment(decimal decEmployeeId, DateTime date)
		{
			bool isStatus = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckSalaryStatusForAdvancePayment", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam3.Value = decEmployeeId;
				sprmparam3 = sccmd.Parameters.Add("@month", SqlDbType.Date);
				sprmparam3.Value = date;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					isStatus = true;
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
			return isStatus;
		}

		public decimal MonthlySalaryAddWithIdentity(MonthlySalaryInfo monthlysalaryinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryAddWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam5.Value = monthlysalaryinfo.SalaryMonth;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalaryinfo.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalaryinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalaryinfo.Extra2;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					decIdentity = Convert.ToDecimal(obj.ToString());
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
			return decIdentity;
		}

		public void MonthlySalaryDeleteAll(decimal decMonthlySalaryId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDeleteAll", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
				sprmparam2.Value = decMonthlySalaryId;
				int inWorked = sccmd.ExecuteNonQuery();
				if (inWorked > 0)
				{
					goto end_IL_0001;
				}
				end_IL_0001:;
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

		public DataTable MonthlySalarySettingsEmployeeViewAll(DateTime dtSalaryMonth)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalarySettingsEmployeeViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = dtSalaryMonth;
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

		public decimal MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(DateTime dtSalaryMonth)
		{
			decimal i = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam2.Value = dtSalaryMonth;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					i = Convert.ToDecimal(obj.ToString());
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
			return i;
		}

		public void MonthlySalarySettingsEdit(MonthlySalaryInfo monthlysalaryinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalarySettingsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalaryinfo.MonthlySalaryId;
				sprmparam6 = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
				sprmparam6.Value = monthlysalaryinfo.SalaryMonth;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalaryinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalaryinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalaryinfo.Extra2;
				int ineffectedrow = sccmd.ExecuteNonQuery();
				if (ineffectedrow > 0)
				{
					goto end_IL_0001;
				}
				end_IL_0001:;
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

		public DataTable MonthlySalryViewAllForMonthlySalaryReports(DateTime dtpFromDate, DateTime dtpToDate, string strDesignation, string strEmployeeCode, DateTime dtpSalaryMonth)
		{
			DataTable dtblMonthlySalry = new DataTable();
			dtblMonthlySalry.Columns.Add("SlNo", typeof(int));
			dtblMonthlySalry.Columns["SlNo"].AutoIncrement = true;
			dtblMonthlySalry.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblMonthlySalry.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("MonthlySalryViewAllForMonthlySalaryReports", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtpFromDate;
				sqlda.SelectCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtpToDate;
				sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = dtpSalaryMonth;
				sqlda.Fill(dtblMonthlySalry);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblMonthlySalry;
		}

		public bool CheckSalaryAlreadyPaidOrNotForAdvancePayment(decimal decEmployeeId, DateTime date)
		{
			bool isPaid = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckSalaryAlreadyPaidOrNotForAdvancePayment", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam3.Value = decEmployeeId;
				sprmparam3 = sccmd.Parameters.Add("@month", SqlDbType.Date);
				sprmparam3.Value = date;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					isPaid = true;
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
			return isPaid;
		}
	}
}
