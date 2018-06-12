using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalaryPackageSP : DBConnection
	{
		public decimal SalaryPackageAdd(SalaryPackageInfo salarypackageinfo)
		{
			decimal decIdentity = -1m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageWithRetunIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@salaryPackageName", SqlDbType.VarChar);
				sprmparam7.Value = salarypackageinfo.SalaryPackageName;
				sprmparam7 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam7.Value = salarypackageinfo.IsActive;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = salarypackageinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam7.Value = salarypackageinfo.TotalAmount;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = salarypackageinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = salarypackageinfo.Extra2;
				object obj = sccmd.ExecuteScalar();
				decIdentity = ((obj == null) ? -1m : Convert.ToDecimal(obj.ToString()));
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

		public void SalaryPackageEdit(SalaryPackageInfo salarypackageinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam8.Value = salarypackageinfo.SalaryPackageId;
				sprmparam8 = sccmd.Parameters.Add("@salaryPackageName", SqlDbType.VarChar);
				sprmparam8.Value = salarypackageinfo.SalaryPackageName;
				sprmparam8 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam8.Value = salarypackageinfo.IsActive;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = salarypackageinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam8.Value = salarypackageinfo.TotalAmount;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = salarypackageinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = salarypackageinfo.Extra2;
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

		public DataTable SalaryPackageViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageViewAll", base.sqlcon);
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

		public SalaryPackageInfo SalaryPackageView(decimal salaryPackageId)
		{
			SalaryPackageInfo salarypackageinfo = new SalaryPackageInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam2.Value = salaryPackageId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salarypackageinfo.SalaryPackageId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					salarypackageinfo.SalaryPackageName = ((DbDataReader)sdrreader)[1].ToString();
					salarypackageinfo.IsActive = Convert.ToBoolean(((DbDataReader)sdrreader)[2].ToString());
					salarypackageinfo.Narration = ((DbDataReader)sdrreader)[3].ToString();
					salarypackageinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					salarypackageinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return salarypackageinfo;
		}

		public void SalaryPackageDelete(decimal SalaryPackageId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam2.Value = SalaryPackageId;
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

		public int SalaryPackageGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageMax", base.sqlcon);
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

		public DataTable SalaryPackageViewAllForMonthlySalarySettings()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageViewAllForMonthlySalarySettings", base.sqlcon);
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

		public void SalaryPackageDeleteAll(decimal SalaryPackageId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageDeleteAll", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam2.Value = SalaryPackageId;
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

		public bool SalaryPackageNameCheckExistance(string strSalaryPackageName)
		{
			bool isExists = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalaryPackageNameCheckExistance", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@salaryPackageName", SqlDbType.VarChar);
				sprmparam2.Value = strSalaryPackageName;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null)
				{
					isExists = true;
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
			return isExists;
		}

		public DataTable SalaryPackageregisterSearch(string strSalaryPackageName, string strStatus)
		{
			SalaryPackageSP spSalaryPackage = new SalaryPackageSP();
			DataTable dtblSalaryPackage = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageregisterSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblSalaryPackage.Columns.Add("SLNO", typeof(decimal));
				dtblSalaryPackage.Columns["SLNO"].AutoIncrement = true;
				dtblSalaryPackage.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtblSalaryPackage.Columns["SLNO"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@salaryPackageName", SqlDbType.VarChar).Value = strSalaryPackageName;
				sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strStatus;
				sqlda.Fill(dtblSalaryPackage);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtblSalaryPackage;
		}

		public DataTable SalaryPackageViewAllForSalaryPackageReport(string strPackageName, string strStatus)
		{
			DataTable dtblSalaryPackage = new DataTable();
			dtblSalaryPackage.Columns.Add("SlNo", typeof(int));
			dtblSalaryPackage.Columns["SlNo"].AutoIncrement = true;
			dtblSalaryPackage.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblSalaryPackage.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageViewAllForSalaryPackageReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@packageName", SqlDbType.VarChar).Value = strPackageName;
				sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
				sqlda.Fill(dtblSalaryPackage);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblSalaryPackage;
		}

		public DataTable SalaryPackageViewAllForActive()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageViewAllForActive", base.sqlcon);
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
	}
}
