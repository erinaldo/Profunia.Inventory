using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesReturnDetailsSP : DBConnection
	{
		public decimal SalesReturnDetailsAdd(SalesReturnDetailsInfo salesreturndetailsinfo)
		{
			decimal decSalesReturnDetailsId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam20 = new SqlParameter();
				sprmparam20 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.SalesReturnMasterId;
				sprmparam20 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.ProductId;
				sprmparam20 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.Qty;
				sprmparam20 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.Rate;
				sprmparam20 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.UnitId;
				sprmparam20 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.UnitConversionId;
				sprmparam20 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.Discount;
				sprmparam20 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.TaxId;
				sprmparam20 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.BatchId;
				sprmparam20 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.GodownId;
				sprmparam20 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.RackId;
				sprmparam20 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.TaxAmount;
				sprmparam20 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.GrossAmount;
				sprmparam20 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.NetAmount;
				sprmparam20 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.Amount;
				sprmparam20 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam20.Value = salesreturndetailsinfo.SlNo;
				sprmparam20 = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
				sprmparam20.Value = salesreturndetailsinfo.SalesDetailsId;
				sprmparam20 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam20.Value = salesreturndetailsinfo.Extra1;
				sprmparam20 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam20.Value = salesreturndetailsinfo.Extra2;
				decSalesReturnDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decSalesReturnDetailsId;
		}

		public void SalesReturnDetailsEdit(SalesReturnDetailsInfo salesreturndetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@salesReturnDetailsId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.SalesReturnDetailsId;
				sprmparam21 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.SalesReturnMasterId;
				sprmparam21 = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.SalesDetailsId;
				sprmparam21 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.ProductId;
				sprmparam21 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.Qty;
				sprmparam21 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.Rate;
				sprmparam21 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.UnitId;
				sprmparam21 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.UnitConversionId;
				sprmparam21 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.Discount;
				sprmparam21 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.TaxId;
				sprmparam21 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.BatchId;
				sprmparam21 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.GodownId;
				sprmparam21 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.RackId;
				sprmparam21 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.TaxAmount;
				sprmparam21 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.GrossAmount;
				sprmparam21 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.NetAmount;
				sprmparam21 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam21.Value = salesreturndetailsinfo.Amount;
				sprmparam21 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam21.Value = salesreturndetailsinfo.SlNo;
				sprmparam21 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam21.Value = salesreturndetailsinfo.Extra1;
				sprmparam21 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam21.Value = salesreturndetailsinfo.Extra2;
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

		public DataTable SalesReturnDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnDetailsViewAll", base.sqlcon);
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

		public SalesReturnDetailsInfo SalesReturnDetailsView(decimal salesReturnDetailsId)
		{
			SalesReturnDetailsInfo salesreturndetailsinfo = new SalesReturnDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesReturnDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = salesReturnDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesreturndetailsinfo.SalesReturnDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salesreturndetailsinfo.SalesReturnMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salesreturndetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					salesreturndetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salesreturndetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					salesreturndetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					salesreturndetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					salesreturndetailsinfo.Discount = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					salesreturndetailsinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					salesreturndetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					salesreturndetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					salesreturndetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					salesreturndetailsinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					salesreturndetailsinfo.GrossAmount = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					salesreturndetailsinfo.NetAmount = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					salesreturndetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					salesreturndetailsinfo.SlNo = int.Parse(((DbDataReader)sdrreader)[16].ToString());
					salesreturndetailsinfo.SalesDetailsId = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
					salesreturndetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[18].ToString());
					salesreturndetailsinfo.Extra1 = ((DbDataReader)sdrreader)[19].ToString();
					salesreturndetailsinfo.Extra2 = ((DbDataReader)sdrreader)[20].ToString();
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
			return salesreturndetailsinfo;
		}

		public void SalesReturnDetailsDelete(decimal SalesReturnDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesReturnDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = SalesReturnDetailsId;
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

		public int SalesReturnDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDetailsMax", base.sqlcon);
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

		public DataTable SalesReturnDetailsViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesReturnDetailsViewBySalesReturnMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decSalesReturnMasterId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "OPen Tally", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable productviewbybarcodeforSR(string strProductCode, decimal vouchertypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("productviewbybarcodeforSR", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam3.Value = strProductCode;
				sprmparam3 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam3.Value = vouchertypeId;
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
