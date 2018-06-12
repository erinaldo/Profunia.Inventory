using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class MonthlySalaryDetailsSP : DBConnection
	{
		public void MonthlySalaryDetailsAdd(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam5.Value = monthlysalarydetailsinfo.EmployeeId;
				sprmparam5 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam5.Value = monthlysalarydetailsinfo.SalaryPackageId;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalarydetailsinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = monthlysalarydetailsinfo.Extra2;
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

		public void MonthlySalaryDetailsEdit(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalarydetailsinfo.MonthlySalaryDetailsId;
				sprmparam6 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalarydetailsinfo.EmployeeId;
				sprmparam6 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalarydetailsinfo.ExtraDate;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalarydetailsinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalarydetailsinfo.Extra2;
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

		public DataTable MonthlySalaryDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalaryDetailsViewAll", base.sqlcon);
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

		public MonthlySalaryDetailsInfo MonthlySalaryDetailsView(decimal monthlySalaryDetailsId)
		{
			MonthlySalaryDetailsInfo monthlysalarydetailsinfo = new MonthlySalaryDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = monthlySalaryDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					monthlysalarydetailsinfo.MonthlySalaryDetailsId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					monthlysalarydetailsinfo.EmployeeId = Convert.ToDecimal(((DbDataReader)sdrreader)[1].ToString());
					monthlysalarydetailsinfo.SalaryPackageId = Convert.ToDecimal(((DbDataReader)sdrreader)[2].ToString());
					monthlysalarydetailsinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)[3].ToString());
					monthlysalarydetailsinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					monthlysalarydetailsinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return monthlysalarydetailsinfo;
		}

		public void MonthlySalaryDetailsDelete(decimal MonthlySalaryDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = MonthlySalaryDetailsId;
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

		public int MonthlySalaryDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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

		public void MonthlySalaryDetailsAddWithMonthlySalaryId(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsAddWithMonthlySalaryId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalarydetailsinfo.EmployeeId;
				sprmparam6 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalarydetailsinfo.SalaryPackageId;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalarydetailsinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = monthlysalarydetailsinfo.Extra2;
				sprmparam6 = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
				sprmparam6.Value = monthlysalarydetailsinfo.MonthlySalaryId;
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

		public void MonthlySalaryDetailsEditUsingMasterIdAndDetailsId(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsEditUsingMasterIdAndDetailsId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
				sprmparam7.Value = monthlysalarydetailsinfo.MonthlySalaryDetailsId;
				sprmparam7 = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
				sprmparam7.Value = monthlysalarydetailsinfo.MonthlySalaryId;
				sprmparam7 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam7.Value = monthlysalarydetailsinfo.EmployeeId;
				sprmparam7 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam7.Value = monthlysalarydetailsinfo.SalaryPackageId;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = monthlysalarydetailsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = monthlysalarydetailsinfo.Extra2;
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

		public void MonthlySalarySettingsDetailsIdDelete(decimal MonthlySalaryDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MonthlySalarySettingsDetailsIdDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = MonthlySalaryDetailsId;
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
