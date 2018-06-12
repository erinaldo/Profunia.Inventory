using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesOrderDetailsSP : DBConnection
	{
		public void SalesOrderDetailsAdd(SalesOrderDetailsInfo salesorderdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.SalesOrderMasterId;
				sprmparam13 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.ProductId;
				sprmparam13 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.Qty;
				sprmparam13 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.Rate;
				sprmparam13 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.UnitId;
				sprmparam13 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.UnitConversionId;
				sprmparam13 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.Amount;
				sprmparam13 = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.QuotationDetailsId;
				sprmparam13 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam13.Value = salesorderdetailsinfo.BatchId;
				sprmparam13 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam13.Value = salesorderdetailsinfo.SlNo;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = salesorderdetailsinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = salesorderdetailsinfo.Extra2;
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

		public void SalesOrderDetailsEdit(SalesOrderDetailsInfo salesorderdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam14 = new SqlParameter();
				sprmparam14 = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.SalesOrderDetailsId;
				sprmparam14 = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.SalesOrderMasterId;
				sprmparam14 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.ProductId;
				sprmparam14 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.Qty;
				sprmparam14 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.Rate;
				sprmparam14 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.UnitId;
				sprmparam14 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.UnitConversionId;
				sprmparam14 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.Amount;
				sprmparam14 = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.QuotationDetailsId;
				sprmparam14 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam14.Value = salesorderdetailsinfo.BatchId;
				sprmparam14 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam14.Value = salesorderdetailsinfo.SlNo;
				sprmparam14 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam14.Value = salesorderdetailsinfo.Extra1;
				sprmparam14 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam14.Value = salesorderdetailsinfo.Extra2;
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

		public DataTable SalesOrderDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderDetailsViewAll", base.sqlcon);
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

		public SalesOrderDetailsInfo SalesOrderDetailsView(decimal salesOrderDetailsId)
		{
			SalesOrderDetailsInfo salesorderdetailsinfo = new SalesOrderDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = salesOrderDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesorderdetailsinfo.SalesOrderDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salesorderdetailsinfo.SalesOrderMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salesorderdetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					salesorderdetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salesorderdetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					salesorderdetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					salesorderdetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					salesorderdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					salesorderdetailsinfo.QuotationDetailsId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					salesorderdetailsinfo.SlNo = int.Parse(((DbDataReader)sdrreader)[9].ToString());
					salesorderdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[10].ToString());
					salesorderdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[11].ToString();
					salesorderdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[12].ToString();
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
			return salesorderdetailsinfo;
		}

		public void SalesOrderDetailsDelete(decimal SalesOrderDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = SalesOrderDetailsId;
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

		public decimal SalesOrderDetailsDeletee(decimal SalesOrderDetailsId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderDetailsDeletee", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = SalesOrderDetailsId;
				int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery().ToString());
				if (ineffeftedRow > 0)
				{
					decResult = 1m;
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
			return decResult;
		}

		public int SalesOrderDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesOrderDetailsMax", base.sqlcon);
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

		public DataTable SalesInvoiceGridfillAgainestSalesOrderUsingSalesDetails(decimal decSalesOrderMasterId, decimal salesMasterId, decimal voucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceGridfillAgainestSalesOrderUsingSalesDetails", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decSalesOrderMasterId;
				sqlparameter4 = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = salesMasterId;
				sqlparameter4 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter4.Value = voucherTypeId;
				sqlda.Fill(dtbl);
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

		public bool SalesOrderRefererenceCheckForEditDetails(decimal decSalesOrderDetailsId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesOrderRefererenceCheckForEditDetails", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesOrderDetailsId;
				isEdit = Convert.ToBoolean(sqlcmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public DataTable SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining(decimal decsalesOrderMasterId, decimal decDeliveryNoteMasterId)
		{
			DataTable dtblOrder = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decsalesOrderMasterId;
				sqlparameter3 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decDeliveryNoteMasterId;
				sqlda.Fill(dtblOrder);
			}
			catch (Exception ex)
			{
				MessageBox.Show("DNOrder" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblOrder;
		}

		public DataTable SalesOrderDetailsViewByMasterId(decimal decSalesOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("SalesOrderDetailsViewByMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal).Value = decSalesOrderMasterId;
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

		public DataTable VoucherNoCombofillforSalesOrderReport()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherNoCombofillforSalesOrderReport", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand = sqlcmd;
				sdaadapter.Fill(dtbl);
				DataRow dr = dtbl.NewRow();
				dr["salesOrderMasterId"] = 0;
				dr["invoiceNo"] = "All";
				dtbl.Rows.InsertAt(dr, 0);
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

		public SalesOrderDetailsInfo QuantityEditingAfterCheckingSalesQuotationForSalesOrder(decimal decSalesOrderId, decimal decProductId)
		{
			SalesOrderDetailsInfo infoSalesOrderDetails = new SalesOrderDetailsInfo();
			SqlDataReader sdrReader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("QuantityEditingAfterCheckingSalesQuotationForSalesOrder", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decSalesOrderId;
				sprmparam3 = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = decProductId;
				sdrReader = sqlcmd.ExecuteReader();
				while (sdrReader.Read())
				{
					infoSalesOrderDetails.Qty = Convert.ToDecimal(((DbDataReader)sdrReader)["Qty"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				sdrReader.Close();
				base.sqlcon.Close();
			}
			return infoSalesOrderDetails;
		}

		public DataTable VoucherTypeCombofillforSalesOrderReport()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforSalesOrderReport", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand = sqlcmd;
				sdaadapter.Fill(dtbl);
				DataRow dr = dtbl.NewRow();
				dr["voucherTypeId"] = 0;
				dr["voucherTypeName"] = "All";
				dtbl.Rows.InsertAt(dr, 0);
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
