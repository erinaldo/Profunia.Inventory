using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PriceListSP : DBConnection
	{
		public void PriceListAdd(PriceListInfo pricelistinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PriceListAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam8.Value = pricelistinfo.ProductId;
				sprmparam8 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam8.Value = pricelistinfo.PricinglevelId;
				sprmparam8 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam8.Value = pricelistinfo.UnitId;
				sprmparam8 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam8.Value = pricelistinfo.Rate;
				sprmparam8 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam8.Value = pricelistinfo.BatchId;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = pricelistinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = pricelistinfo.Extra2;
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

		public void PriceListEdit(PriceListInfo pricelistinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PriceListEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
				sprmparam9.Value = pricelistinfo.PricelistId;
				sprmparam9 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam9.Value = pricelistinfo.ProductId;
				sprmparam9 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam9.Value = pricelistinfo.PricinglevelId;
				sprmparam9 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam9.Value = pricelistinfo.UnitId;
				sprmparam9 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam9.Value = pricelistinfo.Rate;
				sprmparam9 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam9.Value = pricelistinfo.BatchId;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = pricelistinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = pricelistinfo.Extra2;
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

		public DataTable PriceListViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAll", base.sqlcon);
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

		public PriceListInfo PriceListView(decimal pricelistId)
		{
			PriceListInfo pricelistinfo = new PriceListInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PriceListView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
				sprmparam2.Value = pricelistId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					pricelistinfo.PricelistId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					pricelistinfo.ProductId = Convert.ToDecimal(((DbDataReader)sdrreader)[1].ToString());
					pricelistinfo.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrreader)[2].ToString());
					pricelistinfo.UnitId = Convert.ToDecimal(((DbDataReader)sdrreader)[3].ToString());
					pricelistinfo.BatchId = Convert.ToDecimal(((DbDataReader)sdrreader)[4].ToString());
					pricelistinfo.Rate = Convert.ToDecimal(((DbDataReader)sdrreader)[5].ToString());
					pricelistinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)[6].ToString());
					pricelistinfo.Extra1 = ((DbDataReader)sdrreader)[7].ToString();
					pricelistinfo.Extra2 = ((DbDataReader)sdrreader)[8].ToString();
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
			return pricelistinfo;
		}

		public void PriceListDelete(decimal PricelistId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PriceListDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
				sprmparam2.Value = PricelistId;
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

		public int PriceListGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PriceListMax", base.sqlcon);
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

		public DataTable PricelistProductGroupViewAllForComboBox()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PricelistProductGroupViewAllForComboBox", base.sqlcon);
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

		public DataTable PricelistPricingLevelViewAllForComboBox()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PricelistPricingLevelViewAllForComboBox", base.sqlcon);
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

		public DataTable ProductDetailsViewGridfill(decimal decgroupId, string strProductCode, string strProductName, string strPricingLevelName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductDetailsViewGridfill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
				sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlda.SelectCommand.Parameters.Add("@pricingLevelName", SqlDbType.VarChar).Value = strPricingLevelName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable PriceListGridFill()
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PriceListGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable PriceListPopupGridFill(decimal decPriceLevelId, decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PriceListPopupGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decPriceLevelId;
				sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool PriceListCheckExistence(decimal decpricelistId, decimal decpricinglevelId, decimal decbatchId, decimal decProductId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PriceListCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sqlcmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
				sprmparam5.Value = decpricelistId;
				sprmparam5 = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam5.Value = decpricinglevelId;
				sprmparam5 = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam5.Value = decbatchId;
				sprmparam5 = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam5.Value = decProductId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = Convert.ToDecimal(obj.ToString());
				}
				if (decCount > 0m)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return false;
		}

		public PriceListInfo PriceListViewByBatchIdORProduct(decimal dcBatchId)
		{
			PriceListInfo infoPriceList = new PriceListInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PriceListViewByBatchIdORProduct", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal).Value = dcBatchId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoPriceList.ProductId = Convert.ToDecimal(((DbDataReader)sqldr)["productId"].ToString());
					infoPriceList.BatchId = Convert.ToDecimal(((DbDataReader)sqldr)["batchId"].ToString());
					infoPriceList.PricinglevelId = Convert.ToDecimal(((DbDataReader)sqldr)["pricinglevelId"].ToString());
					infoPriceList.Rate = Convert.ToDecimal(((DbDataReader)sqldr)["rate"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
				sqldr.Close();
			}
			return infoPriceList;
		}

		public DataTable PriceListGridFill(decimal decgroupId, string strproductName, decimal decsizeId, decimal decModelNoId, decimal decpricinglevelId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PriceListReportGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strproductName;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decsizeId;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
				sqlda.SelectCommand.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decpricinglevelId;
				sqlda.Fill(dtbl);
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

		public DataTable PriceListReportPrint(decimal decgroupId, string strproductName, decimal decsizeId, decimal decModelNoId, decimal decpricinglevelId)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PriceListReportPrint", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strproductName;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decsizeId;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
				sqlda.SelectCommand.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decpricinglevelId;
				sqlda.Fill(dtbl);
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

		public decimal PriceListCheckReferenceAndDelete(decimal decpricinglevelId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PriceListCheckReferenceAndDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam2.Value = decpricinglevelId;
				decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
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
