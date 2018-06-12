using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseDetailsSP : DBConnection
	{
		public void PurchaseDetailsAdd(PurchaseDetailsInfo purchasedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam22 = new SqlParameter();
				sprmparam22 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.PurchaseMasterId;
				sprmparam22 = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.ReceiptDetailsId;
				sprmparam22 = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.OrderDetailsId;
				sprmparam22 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.ProductId;
				sprmparam22 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.Qty;
				sprmparam22 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.Rate;
				sprmparam22 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.UnitId;
				sprmparam22 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.UnitConversionId;
				sprmparam22 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.Discount;
				sprmparam22 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.TaxId;
				sprmparam22 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.BatchId;
				sprmparam22 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.GodownId;
				sprmparam22 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.RackId;
				sprmparam22 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.TaxAmount;
				sprmparam22 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.GrossAmount;
				sprmparam22 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.NetAmount;
				sprmparam22 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam22.Value = purchasedetailsinfo.Amount;
				sprmparam22 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam22.Value = purchasedetailsinfo.SlNo;
				sprmparam22 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam22.Value = purchasedetailsinfo.ExtraDate;
				sprmparam22 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam22.Value = purchasedetailsinfo.Extra1;
				sprmparam22 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam22.Value = purchasedetailsinfo.Extra2;
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

		public void PurchaseDetailsEdit(PurchaseDetailsInfo purchasedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam23 = new SqlParameter();
				sprmparam23 = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.PurchaseDetailsId;
				sprmparam23 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.PurchaseMasterId;
				sprmparam23 = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.ReceiptDetailsId;
				sprmparam23 = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.OrderDetailsId;
				sprmparam23 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.ProductId;
				sprmparam23 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.Qty;
				sprmparam23 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.Rate;
				sprmparam23 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.UnitId;
				sprmparam23 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.UnitConversionId;
				sprmparam23 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.Discount;
				sprmparam23 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.TaxId;
				sprmparam23 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.BatchId;
				sprmparam23 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.GodownId;
				sprmparam23 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.RackId;
				sprmparam23 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.TaxAmount;
				sprmparam23 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.GrossAmount;
				sprmparam23 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.NetAmount;
				sprmparam23 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam23.Value = purchasedetailsinfo.Amount;
				sprmparam23 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam23.Value = purchasedetailsinfo.SlNo;
				sprmparam23 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam23.Value = purchasedetailsinfo.ExtraDate;
				sprmparam23 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam23.Value = purchasedetailsinfo.Extra1;
				sprmparam23 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam23.Value = purchasedetailsinfo.Extra2;
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

		public DataTable PurchaseDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseDetailsViewAll", base.sqlcon);
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

		public PurchaseDetailsInfo PurchaseDetailsView(decimal purchaseDetailsId)
		{
			PurchaseDetailsInfo purchasedetailsinfo = new PurchaseDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchasedetailsinfo.PurchaseDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					purchasedetailsinfo.PurchaseMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					purchasedetailsinfo.ReceiptDetailsId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					purchasedetailsinfo.OrderDetailsId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					purchasedetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					purchasedetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					purchasedetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					purchasedetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					purchasedetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					purchasedetailsinfo.Discount = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					purchasedetailsinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					purchasedetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					purchasedetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					purchasedetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					purchasedetailsinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					purchasedetailsinfo.GrossAmount = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					purchasedetailsinfo.NetAmount = decimal.Parse(((DbDataReader)sdrreader)[16].ToString());
					purchasedetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
					purchasedetailsinfo.SlNo = int.Parse(((DbDataReader)sdrreader)[18].ToString());
					purchasedetailsinfo.PurchaseDetailsId = decimal.Parse(((DbDataReader)sdrreader)[19].ToString());
					purchasedetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[20].ToString());
					purchasedetailsinfo.Extra1 = ((DbDataReader)sdrreader)[21].ToString();
					purchasedetailsinfo.Extra2 = ((DbDataReader)sdrreader)[22].ToString();
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
			return purchasedetailsinfo;
		}

		public void PurchaseDetailsDelete(decimal PurchaseDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseDetailsId;
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

		public int PurchaseDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseDetailsMax", base.sqlcon);
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

		public DataTable PurchaseDetailsViewByPurchaseMasterIdWithRemaining(decimal decPurchaseMasterId, decimal decPurchaseReturnMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseDetailsViewByPurchaseMasterIdWithRemaining", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decPurchaseMasterId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decPurchaseReturnMasterId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter4.Value = decVoucherTypeId;
				sqldataadapter.Fill(dtbl);
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

		public DataTable PurchaseDetailsViewByProductCodeForPI(decimal decVoucherTypeId, string strProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByProductCodeForPI", base.sqlcon);
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

		public DataTable PurchaseDetailsViewByProductNameForPI(decimal decVoucherTypeId, string strProductName)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByProductNameForPI", base.sqlcon);
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

		public DataTable PurchaseDetailsViewByBarcodeForPI(decimal decVoucherTypeId, string strBarcode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByBarcodeForPI", base.sqlcon);
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

		public DataTable PurchaseDetailsViewByPurchaseMasterId(decimal decPurchaseMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByPurchaseMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPurchaseMasterId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public void PurchaseDetailsDeleteByPurchaseMasterId(decimal decPurchaseMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseDetailsDeleteByPurchaseMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPurchaseMasterId;
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

		public DataTable VoucherTypeComboFillForPurchaseInvoice()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherTypeComboFillForPurchaseInvoice", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand = sqlcmd;
				sdaadapter.Fill(dtbl);
				DataRow dr = dtbl.NewRow();
				dr["voucherTypeId"] = 0;
				dr["voucherTypeName"] = "NA";
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
