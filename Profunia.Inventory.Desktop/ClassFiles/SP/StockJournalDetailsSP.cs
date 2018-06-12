using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class StockJournalDetailsSP : DBConnection
	{
		public void StockJournalDetailsAdd(StockJournalDetailsInfo stockjournaldetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.StockJournalMasterId;
				sprmparam16 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.ProductId;
				sprmparam16 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.Qty;
				sprmparam16 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.Rate;
				sprmparam16 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.UnitId;
				sprmparam16 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.UnitConversionId;
				sprmparam16 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.BatchId;
				sprmparam16 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.GodownId;
				sprmparam16 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.RackId;
				sprmparam16 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam16.Value = stockjournaldetailsinfo.Amount;
				sprmparam16 = sccmd.Parameters.Add("@consumptionOrProduction", SqlDbType.VarChar);
				sprmparam16.Value = stockjournaldetailsinfo.ConsumptionOrProduction;
				sprmparam16 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam16.Value = stockjournaldetailsinfo.Slno;
				sprmparam16 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam16.Value = stockjournaldetailsinfo.ExtraDate;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = stockjournaldetailsinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = stockjournaldetailsinfo.Extra2;
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

		public void StockJournalDetailsEdit(StockJournalDetailsInfo stockjournaldetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@stockJournalDetailsId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.StockJournalDetailsId;
				sprmparam17 = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.StockJournalMasterId;
				sprmparam17 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.ProductId;
				sprmparam17 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.Qty;
				sprmparam17 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.Rate;
				sprmparam17 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.UnitId;
				sprmparam17 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.UnitConversionId;
				sprmparam17 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.BatchId;
				sprmparam17 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.GodownId;
				sprmparam17 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.RackId;
				sprmparam17 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = stockjournaldetailsinfo.Amount;
				sprmparam17 = sccmd.Parameters.Add("@consumptionOrProduction", SqlDbType.VarChar);
				sprmparam17.Value = stockjournaldetailsinfo.ConsumptionOrProduction;
				sprmparam17 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam17.Value = stockjournaldetailsinfo.Slno;
				sprmparam17 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam17.Value = stockjournaldetailsinfo.ExtraDate;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = stockjournaldetailsinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = stockjournaldetailsinfo.Extra2;
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

		public DataTable StockJournalDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("StockJournalDetailsViewAll", base.sqlcon);
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

		public StockJournalDetailsInfo StockJournalDetailsView(decimal stockJournalDetailsId)
		{
			StockJournalDetailsInfo stockjournaldetailsinfo = new StockJournalDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@stockJournalDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = stockJournalDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					stockjournaldetailsinfo.StockJournalDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					stockjournaldetailsinfo.StockJournalMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					stockjournaldetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					stockjournaldetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					stockjournaldetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					stockjournaldetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					stockjournaldetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					stockjournaldetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					stockjournaldetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					stockjournaldetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					stockjournaldetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					stockjournaldetailsinfo.ConsumptionOrProduction = ((DbDataReader)sdrreader)[11].ToString();
					stockjournaldetailsinfo.Slno = int.Parse(((DbDataReader)sdrreader)[12].ToString());
					stockjournaldetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[13].ToString());
					stockjournaldetailsinfo.Extra1 = ((DbDataReader)sdrreader)[14].ToString();
					stockjournaldetailsinfo.Extra2 = ((DbDataReader)sdrreader)[15].ToString();
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
			return stockjournaldetailsinfo;
		}

		public void StockJournalDetailsDelete(decimal StockJournalDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@stockJournalDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = StockJournalDetailsId;
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

		public int StockJournalDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockJournalDetailsMax", base.sqlcon);
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

		public DataTable StockJournalDetailsByProductCode(decimal decVoucherTypeId, string strProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsByProductCode", base.sqlcon);
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

		public DataTable StockJournalDetailsByProductName(decimal decVoucherTypeId, string strProductName)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsByProductName", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam3.Value = strProductName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable StockJournalDetailsViewByBarcode(decimal decVoucherTypeId, string strBarcode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsViewByBarcode", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam3.Value = strBarcode;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataSet StockJournalDetailsForRegisterOrReport(decimal decMasterId)
		{
			DataSet dsData = new DataSet();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsForRegisterOrReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal).Value = decMasterId;
				sqlda.Fill(dsData);
			}
			catch (Exception)
			{
				throw;
			}
			return dsData;
		}
	}
}
