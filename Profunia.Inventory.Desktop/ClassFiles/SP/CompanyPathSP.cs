using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class CompanyPathSP : DBConnection
	{
		public void CompanyPathAdd(CompanyPathInfo companypathinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyPathAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam6.Value = companypathinfo.CompanyName;
				sprmparam6 = sccmd.Parameters.Add("@companyPath", SqlDbType.VarChar);
				sprmparam6.Value = companypathinfo.CompanyPath;
				sprmparam6 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam6.Value = companypathinfo.IsDefault;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = companypathinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = companypathinfo.Extra2;
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

		public void CompanyPathEdit(CompanyPathInfo companypathinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyPathEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam7.Value = companypathinfo.CompanyId;
				sprmparam7 = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam7.Value = companypathinfo.CompanyName;
				sprmparam7 = sccmd.Parameters.Add("@companyPath", SqlDbType.VarChar);
				sprmparam7.Value = companypathinfo.CompanyPath;
				sprmparam7 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam7.Value = companypathinfo.IsDefault;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = companypathinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = companypathinfo.Extra2;
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

		public DataTable CompanyPathViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CompanyPathViewAll", base.sqlcon);
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

		public CompanyPathInfo CompanyPathView(decimal companyId)
		{
			CompanyPathInfo companypathinfo = new CompanyPathInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyPathView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam2.Value = companyId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					companypathinfo.CompanyId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					companypathinfo.CompanyName = ((DbDataReader)sdrreader)[1].ToString();
					companypathinfo.CompanyPath = ((DbDataReader)sdrreader)[2].ToString();
					companypathinfo.IsDefault = bool.Parse(((DbDataReader)sdrreader)[3].ToString());
					companypathinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					companypathinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					companypathinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return companypathinfo;
		}

		public void CompanyPathDelete(decimal CompanyId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyPathDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam2.Value = CompanyId;
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

		public int CompanyPathGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyPathMax", base.sqlcon);
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

		public decimal CompanyViewForDefaultCompany()
		{
			decimal decCompanyId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyViewForDefaultCompany", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				decCompanyId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decCompanyId;
		}
	}
}
