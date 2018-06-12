using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BrandSP : DBConnection
	{
		public decimal BrandAdd(BrandInfo brandinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BrandAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@brandName", SqlDbType.VarChar);
				sprmparam7.Value = brandinfo.BrandName;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = brandinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@manufacturer", SqlDbType.VarChar);
				sprmparam7.Value = brandinfo.Manufacturer;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = brandinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = brandinfo.Extra2;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = brandinfo.ExtraDate;
				decimal inEffectedRow = Convert.ToDecimal(sccmd.ExecuteScalar());
				if (inEffectedRow > 0m)
				{
					return inEffectedRow;
				}
				return 0m;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0m;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public bool BrandEdit(BrandInfo brandinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BrandEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
				sprmparam8.Value = brandinfo.BrandId;
				sprmparam8 = sccmd.Parameters.Add("@brandName", SqlDbType.VarChar);
				sprmparam8.Value = brandinfo.BrandName;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = brandinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@manufacturer", SqlDbType.VarChar);
				sprmparam8.Value = brandinfo.Manufacturer;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = brandinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = brandinfo.Extra2;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = brandinfo.ExtraDate;
				int inEffectedRow = sccmd.ExecuteNonQuery();
				if (inEffectedRow > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable BrandViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BrandViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
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

		public BrandInfo BrandView(decimal brandId)
		{
			BrandInfo brandinfo = new BrandInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BrandView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
				sprmparam2.Value = brandId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					brandinfo.BrandName = ((DbDataReader)sdrreader)[1].ToString();
					brandinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
					brandinfo.Manufacturer = ((DbDataReader)sdrreader)[3].ToString();
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
			return brandinfo;
		}

		public void BrandDelete(decimal BrandId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BrandDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
				sprmparam2.Value = BrandId;
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

		public int BrandGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BrandMax", base.sqlcon);
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

		public DataTable BrandSearch(string strBrandName)
		{
			EmployeeInfo infoEmployee = new EmployeeInfo();
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("BrandSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@brandName", SqlDbType.VarChar).Value = strBrandName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool BrandCheckIfExist(string strBrandName, decimal decBrandId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BrandCheckIfExist", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@brandName", SqlDbType.VarChar);
				sprmparam3.Value = strBrandName;
				sprmparam3 = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
				sprmparam3.Value = decBrandId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public decimal BrandDeleteCheckExistence(decimal BrandId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BrandDeleteCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
				sprmparam2.Value = BrandId;
				decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
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
	}
}
