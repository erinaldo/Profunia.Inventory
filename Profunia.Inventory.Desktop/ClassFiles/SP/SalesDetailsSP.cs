using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesDetailsSP : DBConnection
	{
		public void SalesDetailsAdd(SalesDetailsInfo salesdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam23 = new SqlParameter();
				sprmparam23 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.SalesMasterId;
				sprmparam23 = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.DeliveryNoteDetailsId;
				sprmparam23 = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.OrderDetailsId;
				sprmparam23 = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.QuotationDetailsId;
				sprmparam23 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.ProductId;
				sprmparam23 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.Qty;
				sprmparam23 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.Rate;
				sprmparam23 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.UnitId;
				sprmparam23 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.UnitConversionId;
				sprmparam23 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.Discount;
				sprmparam23 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.TaxId;
				sprmparam23 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.BatchId;
				sprmparam23 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.GodownId;
				sprmparam23 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.RackId;
				sprmparam23 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.TaxAmount;
				sprmparam23 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.GrossAmount;
				sprmparam23 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.NetAmount;
				sprmparam23 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam23.Value = salesdetailsinfo.Amount;
				sprmparam23 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam23.Value = salesdetailsinfo.SlNo;
				sprmparam23 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam23.Value = salesdetailsinfo.ExtraDate;
				sprmparam23 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam23.Value = salesdetailsinfo.Extra1;
				sprmparam23 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam23.Value = salesdetailsinfo.Extra2;
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

		public void SalesDetailsEdit(SalesDetailsInfo salesdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam24 = new SqlParameter();
				sprmparam24 = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.SalesDetailsId;
				sprmparam24 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.SalesMasterId;
				sprmparam24 = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.DeliveryNoteDetailsId;
				sprmparam24 = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.OrderDetailsId;
				sprmparam24 = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.QuotationDetailsId;
				sprmparam24 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.ProductId;
				sprmparam24 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.Qty;
				sprmparam24 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.Rate;
				sprmparam24 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.UnitId;
				sprmparam24 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.UnitConversionId;
				sprmparam24 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.Discount;
				sprmparam24 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.TaxId;
				sprmparam24 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.BatchId;
				sprmparam24 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.GodownId;
				sprmparam24 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.RackId;
				sprmparam24 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.TaxAmount;
				sprmparam24 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.GrossAmount;
				sprmparam24 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.NetAmount;
				sprmparam24 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam24.Value = salesdetailsinfo.Amount;
				sprmparam24 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam24.Value = salesdetailsinfo.SlNo;
				sprmparam24 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam24.Value = salesdetailsinfo.ExtraDate;
				sprmparam24 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam24.Value = salesdetailsinfo.Extra1;
				sprmparam24 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam24.Value = salesdetailsinfo.Extra2;
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

		public DataTable SalesDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesDetailsViewAll", base.sqlcon);
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

		public SalesDetailsInfo SalesDetailsView(decimal salesDetailsId)
		{
			SalesDetailsInfo salesdetailsinfo = new SalesDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = salesDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesdetailsinfo.SalesDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salesdetailsinfo.SalesMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salesdetailsinfo.DeliveryNoteDetailsId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					salesdetailsinfo.OrderDetailsId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salesdetailsinfo.QuotationDetailsId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					salesdetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					salesdetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					salesdetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					salesdetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					salesdetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					salesdetailsinfo.Discount = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					salesdetailsinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					salesdetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					salesdetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					salesdetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					salesdetailsinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					salesdetailsinfo.GrossAmount = decimal.Parse(((DbDataReader)sdrreader)[16].ToString());
					salesdetailsinfo.NetAmount = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
					salesdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[18].ToString());
					salesdetailsinfo.SlNo = int.Parse(((DbDataReader)sdrreader)[19].ToString());
					salesdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[20].ToString());
					salesdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[21].ToString();
					salesdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[22].ToString();
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
			return salesdetailsinfo;
		}

		public void SalesDetailsDelete(decimal SalesDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = SalesDetailsId;
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

		public int SalesDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesDetailsMax", base.sqlcon);
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

		public DataTable SalesDetailsViewForSalesReturnGrideFill(decimal salesMasterId, decimal salesReturnMasterId)
		{
			DataTable dtblSalesReturnGrideFill = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtblSalesReturnGrideFill.Columns.Add("S.No", typeof(int));
				dtblSalesReturnGrideFill.Columns["S.No"].AutoIncrement = true;
				dtblSalesReturnGrideFill.Columns["S.No"].AutoIncrementSeed = 1L;
				dtblSalesReturnGrideFill.Columns["S.No"].AutoIncrementStep = 1L;
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnGrideFillNew", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam4.Value = salesMasterId;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesReturnMasterId;
				sdaadapter.Fill(dtblSalesReturnGrideFill);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSalesReturnGrideFill;
		}

		public DataTable SalesDetailsViewForSalesReturnGrideFill1(decimal decProductId)
		{
			DataTable dtblSalesReturnGrideFill = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnGrideFillNew2", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				sdaadapter.Fill(dtblSalesReturnGrideFill);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSalesReturnGrideFill;
		}

		public DataTable SalesReturnGrideFillNewByProductId(decimal decProductId)
		{
			DataTable dtblSalesReturnGrideFill = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnGrideFillNewByProductId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				sdaadapter.Fill(dtblSalesReturnGrideFill);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSalesReturnGrideFill;
		}

		public DataTable BankOrCashComboFill()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", base.sqlcon);
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
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

		public DataTable VoucherTypeNameComboFillForSalesInvoiceRegister()
		{
			DataTable dtblVoucherType = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeNameComboFillForSalesInvoiceRegister", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblVoucherType);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblVoucherType;
		}

		public DataTable voucherNoViewAllByVoucherTypeIdForSi(decimal decVoucherTypeId)
		{
			DataTable dtblVoucherNo = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("voucherNoViewAllByVoucherTypeIdForSi", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam2.Value = decVoucherTypeId;
				sqlda.Fill(dtblVoucherNo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblVoucherNo;
		}

		public DataTable SalesDetailsViewBySalesMasterId(decimal dcSalesMasterId)
		{
			DataTable dtblSI = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesDetailsViewBySalesMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = dcSalesMasterId;
				sqlda.Fill(dtblSI);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSI;
		}

		public DataTable SalesInvoiceSalesDetailsViewBySalesMasterId(decimal dcSalesMasterId)
		{
			DataTable dtblSidtl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceSalesDetailsViewBySalesMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = dcSalesMasterId;
				sqlda.Fill(dtblSidtl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSidtl;
		}

		public decimal SalesInvoiceReciptVoucherDetailsAgainstSI(decimal decvoucherTypeId, string strvoucherNo)
		{
			decimal decBalAmount = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesInvoiceReciptVoucherDetailsAgainstSI", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decvoucherTypeId;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strvoucherNo;
				decBalAmount = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decBalAmount;
		}

		public DataTable VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypesBasedOnTypeOfVouchers", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = typeOfVouchers;
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

		public DataTable SalesInvoiceDetailsViewByProductCodeForSI(decimal decVoucherTypeId, string strProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceDetailsViewByProductCodeForSI", base.sqlcon);
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
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable SalesInvoiceDetailsViewByProductNameForSI(decimal decVoucherTypeId, string strProductName)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceDetailsViewByProductNameForSI", base.sqlcon);
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
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable SalesInvoiceDetailsViewByBarcodeForSI(decimal decVoucherTypeId, string strBarcode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceDetailsViewByBarcodeForSI", base.sqlcon);
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
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}
	}
}
