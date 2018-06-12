using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class UnitConvertionSP : DBConnection
	{
		public void UnitConvertionAdd(UnitConvertionInfo unitconvertioninfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitConvertionAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam8.Value = unitconvertioninfo.ProductId;
				sprmparam8 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam8.Value = unitconvertioninfo.UnitId;
				sprmparam8 = sccmd.Parameters.Add("@conversionRate", SqlDbType.Decimal);
				sprmparam8.Value = unitconvertioninfo.ConversionRate;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = unitconvertioninfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = unitconvertioninfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@quantities", SqlDbType.VarChar);
				sprmparam8.Value = unitconvertioninfo.Quantities;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = unitconvertioninfo.Extra2;
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

		public void UnitConvertionEdit(UnitConvertionInfo unitconvertioninfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitConvertionEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
				sprmparam8.Value = unitconvertioninfo.UnitconvertionId;
				sprmparam8 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam8.Value = unitconvertioninfo.ProductId;
				sprmparam8 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam8.Value = unitconvertioninfo.UnitId;
				sprmparam8 = sccmd.Parameters.Add("@conversionRate", SqlDbType.Decimal);
				sprmparam8.Value = unitconvertioninfo.ConversionRate;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = unitconvertioninfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = unitconvertioninfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = unitconvertioninfo.Extra2;
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

		public DataTable UnitConvertionViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitConvertionViewAll", base.sqlcon);
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

		public UnitConvertionInfo UnitConvertionView(decimal unitconvertionId)
		{
			UnitConvertionInfo unitconvertioninfo = new UnitConvertionInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitConvertionView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
				sprmparam2.Value = unitconvertionId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					unitconvertioninfo.UnitconvertionId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					unitconvertioninfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					unitconvertioninfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					unitconvertioninfo.ConversionRate = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					unitconvertioninfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					unitconvertioninfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					unitconvertioninfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return unitconvertioninfo;
		}

		public decimal UnitConvertionDelete(decimal UnitconvertionId)
		{
			decimal decConfirm = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitConvertionDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
				sprmparam2.Value = UnitconvertionId;
				decConfirm = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decConfirm;
		}

		public decimal MulUnitDeleteForUpdation(decimal decProductId)
		{
			decimal decConfirm = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MulUnitDeleteForUpdation", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				decConfirm = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decConfirm;
		}

		public int UnitConvertionGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitConvertionMax", base.sqlcon);
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

		public DataTable UnitConverstionTableForEdit(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("UnitConverstionTableForEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sdaadapter.SelectCommand = sqlcmd;
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

		public decimal MulUnitRemoveRows(decimal decUnitConvetionId)
		{
			decimal decConfirm = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MulUnitRemoveRows", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
				sprmparam2.Value = decUnitConvetionId;
				decConfirm = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decConfirm;
		}

		public void UnitConverstionEditWhenProductUpdating(UnitConvertionInfo unitConvertionInfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitConverstionEditWhenProductUpdating", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = unitConvertionInfo.ProductId;
				sprmparam3 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam3.Value = unitConvertionInfo.UnitId;
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

		public decimal UnitConversionRateByUnitConversionId(decimal decConversionId)
		{
			decimal decConversionRate = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ConversionRateById", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitconversionId", SqlDbType.Decimal);
				sprmparam2.Value = decConversionId;
				decConversionRate = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decConversionRate;
		}

		public DataTable DGVUnitConvertionRateByUnitId(decimal decUnitId, string productName)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ConversionRateViewByUnitId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@unitId", SqlDbType.Decimal).Value = decUnitId;
				sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = productName;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable UnitsOfPerticularProduct(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitsOfPerticularProduct", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.VarChar).Value = decProductId;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public UnitConvertionInfo UnitViewAllByProductId(decimal dcProductid)
		{
			UnitConvertionInfo UnitConvertionInfo = new UnitConvertionInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitViewAllByProductId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = dcProductid;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					UnitConvertionInfo.UnitconvertionId = decimal.Parse(((DbDataReader)sdrreader)["unitconversionId"].ToString());
					UnitConvertionInfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)["unitId"].ToString());
					UnitConvertionInfo.ConversionRate = decimal.Parse(((DbDataReader)sdrreader)["conversionRate"].ToString());
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
			return UnitConvertionInfo;
		}

		public DataTable UnitConversionIdAndConRateViewallByProductId(string strProductId)
		{
			DataTable dtblConversionIdViewAll = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitConversionIdAndConRateViewallByProductId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.VarChar);
				sqlparameter2.Value = strProductId;
				sdaadapter.Fill(dtblConversionIdViewAll);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblConversionIdViewAll;
		}

		public decimal UnitconversionIdViewByUnitIdAndProductId(decimal unitId, decimal productId)
		{
			decimal decValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("UnitconversionIdViewByUnitIdAndProductId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam3.Value = unitId;
				sprmparam3 = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = productId;
				decValue = Convert.ToDecimal(sqlcmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decValue;
		}
	}
}
