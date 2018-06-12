using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PhysicalStockDetailsSP : DBConnection
	{
		public void PhysicalStockDetailsAdd(PhysicalStockDetailsInfo physicalstockdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.PhysicalStockMasterId;
				sprmparam14 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.ProductId;
				sprmparam14 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.Qty;
				sprmparam14 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.Rate;
				sprmparam14 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.UnitId;
				sprmparam14 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.UnitConversionId;
				sprmparam14 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.BatchId;
				sprmparam14 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.GodownId;
				sprmparam14 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.RackId;
				sprmparam14 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam14.Value = physicalstockdetailsinfo.Amount;
				sprmparam14 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam14.Value = physicalstockdetailsinfo.Slno;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = physicalstockdetailsinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = physicalstockdetailsinfo.Extra2;
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

		public void PhysicalStockDetailsEdit(PhysicalStockDetailsInfo physicalstockdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@physicalStockDetailsId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.PhysicalStockDetailsId;
				sprmparam15 = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.PhysicalStockMasterId;
				sprmparam15 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.ProductId;
				sprmparam15 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.Qty;
				sprmparam15 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.Rate;
				sprmparam15 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.UnitId;
				sprmparam15 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.UnitConversionId;
				sprmparam15 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.BatchId;
				sprmparam15 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.GodownId;
				sprmparam15 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.RackId;
				sprmparam15 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam15.Value = physicalstockdetailsinfo.Amount;
				sprmparam15 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam15.Value = physicalstockdetailsinfo.Slno;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = physicalstockdetailsinfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = physicalstockdetailsinfo.Extra2;
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

		public DataTable PhysicalStockDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PhysicalStockDetailsViewAll", base.sqlcon);
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

		public PhysicalStockDetailsInfo PhysicalStockDetailsView(decimal physicalStockDetailsId)
		{
			PhysicalStockDetailsInfo physicalstockdetailsinfo = new PhysicalStockDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@physicalStockDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = physicalStockDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					physicalstockdetailsinfo.PhysicalStockDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					physicalstockdetailsinfo.PhysicalStockMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					physicalstockdetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					physicalstockdetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					physicalstockdetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					physicalstockdetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					physicalstockdetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					physicalstockdetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					physicalstockdetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					physicalstockdetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					physicalstockdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					physicalstockdetailsinfo.Slno = int.Parse(((DbDataReader)sdrreader)[11].ToString());
					physicalstockdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[12].ToString());
					physicalstockdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[13].ToString();
					physicalstockdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[14].ToString();
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
			return physicalstockdetailsinfo;
		}

		public void PhysicalStockDetailsDelete(decimal PhysicalStockDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@physicalStockDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = PhysicalStockDetailsId;
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

		public int PhysicalStockDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsMax", base.sqlcon);
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

		public void PhysicalStockDetailsDeleteWhenUpdate(decimal decMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsDeleteWhenUpdate", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decMasterId;
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

		public DataTable PhysicalStockDetailsViewByProductCode(decimal decVoucherTypeId, string strProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PhysicalStockDetailsViewByProductCode", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam3.Value = strProductCode;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}
	}
}
