using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DeliveryNoteDetailsSP : DBConnection
	{
		public void DeliveryNoteDetailsAdd(DeliveryNoteDetailsInfo deliverynotedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.DeliveryNoteMasterId;
				sprmparam16 = sccmd.Parameters.Add("@orderDetails1Id", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.OrderDetails1Id;
				sprmparam16 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.ProductId;
				sprmparam16 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.Qty;
				sprmparam16 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.Rate;
				sprmparam16 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.UnitId;
				sprmparam16 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.UnitConversionId;
				sprmparam16 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.Amount;
				sprmparam16 = sccmd.Parameters.Add("@quotationDetails1Id", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.QuotationDetails1Id;
				sprmparam16 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.BatchId;
				sprmparam16 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.GodownId;
				sprmparam16 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam16.Value = deliverynotedetailsinfo.RackId;
				sprmparam16 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam16.Value = deliverynotedetailsinfo.SlNo;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = deliverynotedetailsinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = deliverynotedetailsinfo.Extra2;
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

		public void DeliveryNoteDetailsEdit(DeliveryNoteDetailsInfo deliverynotedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.DeliveryNoteDetails1Id;
				sprmparam15 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.DeliveryNoteMasterId;
				sprmparam15 = sccmd.Parameters.Add("@orderDetails1Id", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.OrderDetails1Id;
				sprmparam15 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.ProductId;
				sprmparam15 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.Qty;
				sprmparam15 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.Rate;
				sprmparam15 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.UnitId;
				sprmparam15 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.UnitConversionId;
				sprmparam15 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.Amount;
				sprmparam15 = sccmd.Parameters.Add("@quotationDetails1Id", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.QuotationDetails1Id;
				sprmparam15 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.BatchId;
				sprmparam15 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.GodownId;
				sprmparam15 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam15.Value = deliverynotedetailsinfo.RackId;
				sprmparam15 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam15.Value = deliverynotedetailsinfo.SlNo;
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

		public DataTable DeliveryNoteDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteDetailsViewAll", base.sqlcon);
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

		public DeliveryNoteDetailsInfo DeliveryNoteDetailsView(decimal deliveryNoteDetails1Id)
		{
			DeliveryNoteDetailsInfo deliverynotedetailsinfo = new DeliveryNoteDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@deliveryNoteDetails1Id", SqlDbType.Decimal);
				sprmparam2.Value = deliveryNoteDetails1Id;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					deliverynotedetailsinfo.DeliveryNoteDetails1Id = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					deliverynotedetailsinfo.DeliveryNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					deliverynotedetailsinfo.OrderDetails1Id = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					deliverynotedetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					deliverynotedetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					deliverynotedetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					deliverynotedetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					deliverynotedetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					deliverynotedetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					deliverynotedetailsinfo.QuotationDetails1Id = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					deliverynotedetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					deliverynotedetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					deliverynotedetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					deliverynotedetailsinfo.SlNo = int.Parse(((DbDataReader)sdrreader)[13].ToString());
					deliverynotedetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[14].ToString());
					deliverynotedetailsinfo.Extra1 = ((DbDataReader)sdrreader)[15].ToString();
					deliverynotedetailsinfo.Extra2 = ((DbDataReader)sdrreader)[16].ToString();
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
			return deliverynotedetailsinfo;
		}

		public decimal DeliveryNoteDetailsDelete(decimal DeliveryNoteDetailsId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = DeliveryNoteDetailsId;
				int ineffectedRow = Convert.ToInt32(sccmd.ExecuteNonQuery().ToString());
				decResult = ((ineffectedRow <= 0) ? 0m : 1m);
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

		public int DeliveryNoteDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsMax", base.sqlcon);
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

		public DataTable DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending(decimal decDeliveryNoteMasterId, decimal decRejectionInMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam3 = new SqlParameter();
				sqlparam3 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlparam3.Value = decDeliveryNoteMasterId;
				sqlparam3 = sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				sqlparam3.Value = decRejectionInMasterId;
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

		public DataTable SalesInvoiceGridfillAgainestDeliveryNoteUsingDeliveryNoteDetails(decimal decDeliveryNoteMasterId, decimal SIMasterId, decimal voucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestDeliveryNoteUsingDeliveryNoteDetails", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decDeliveryNoteMasterId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = SIMasterId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter4.Value = voucherTypeId;
				sqldataadapter.Fill(dtbl);
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

		public DataTable DeliveryNoteDetailsViewByDeliveryNoteMasterId(decimal decDeliveryNoteMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteDetailsViewByDeliveryNoteMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter2 = new SqlParameter();
				sqlParameter2 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlParameter2.Value = decDeliveryNoteMasterId;
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

		public DeliveryNoteDetailsInfo QuantityEditingAfterCheckingSalesAndRejectionInForDeliveryNote(decimal decDeliveryNoteId, decimal decProductId)
		{
			DeliveryNoteDetailsInfo infoDeliveryNoteDetails = new DeliveryNoteDetailsInfo();
			SqlDataReader sdrReader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("QuantityEditingAfterCheckingSalesAndRejectionInForDeliveryNote", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decDeliveryNoteId;
				sprmparam3 = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = decProductId;
				sdrReader = sqlcmd.ExecuteReader();
				while (sdrReader.Read())
				{
					infoDeliveryNoteDetails.Qty = Convert.ToDecimal(((DbDataReader)sdrReader)["Qty"].ToString());
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
			return infoDeliveryNoteDetails;
		}
	}
}
