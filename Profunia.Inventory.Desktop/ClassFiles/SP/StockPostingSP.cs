using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class StockPostingSP : DBConnection
	{
		public decimal StockPostingAdd(StockPostingInfo stockpostinginfo)
		{
			decimal decProductId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam19.Value = stockpostinginfo.Date;
				sprmparam19 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.VoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam19.Value = stockpostinginfo.VoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = stockpostinginfo.InvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.ProductId;
				sprmparam19 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.BatchId;
				sprmparam19 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.UnitId;
				sprmparam19 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.GodownId;
				sprmparam19 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.RackId;
				sprmparam19 = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.AgainstVoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = stockpostinginfo.AgainstInvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
				sprmparam19.Value = stockpostinginfo.AgainstVoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@inwardQty", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.InwardQty;
				sprmparam19 = sccmd.Parameters.Add("@outwardQty", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.OutwardQty;
				sprmparam19 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.Rate;
				sprmparam19 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam19.Value = stockpostinginfo.FinancialYearId;
				sprmparam19 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam19.Value = stockpostinginfo.Extra1;
				sprmparam19 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam19.Value = stockpostinginfo.Extra2;
				decProductId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decProductId;
		}

		public bool StockPostingEdit(StockPostingInfo stockpostinginfo)
		{
			decimal decresult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				sprmparam = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.StockPostingId;
				sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam.Value = stockpostinginfo.Date;
				sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.VoucherTypeId;
				sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam.Value = stockpostinginfo.VoucherNo;
				sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam.Value = stockpostinginfo.InvoiceNo;
				sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.ProductId;
				sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.BatchId;
				sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.UnitId;
				sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.GodownId;
				sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.RackId;
				sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.AgainstVoucherTypeId;
				sprmparam = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam.Value = stockpostinginfo.AgainstInvoiceNo;
				sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
				sprmparam.Value = stockpostinginfo.AgainstVoucherNo;
				sprmparam = sccmd.Parameters.Add("@inwardQty", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.InwardQty;
				sprmparam = sccmd.Parameters.Add("@outwardQty", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.OutwardQty;
				sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.Rate;
				sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam.Value = stockpostinginfo.FinancialYearId;
				sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam.Value = stockpostinginfo.ExtraDate;
				sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam.Value = stockpostinginfo.Extra1;
				sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam.Value = stockpostinginfo.Extra2;
				decresult = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			if (decresult > 0m)
			{
				return true;
			}
			return false;
		}

		public DataTable StockPostingViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("StockPostingViewAll", base.sqlcon);
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

		public StockPostingInfo StockPostingView(decimal stockPostingId)
		{
			StockPostingInfo stockpostinginfo = new StockPostingInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
				sprmparam2.Value = stockPostingId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					stockpostinginfo.StockPostingId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					stockpostinginfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
					stockpostinginfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					stockpostinginfo.VoucherNo = ((DbDataReader)sdrreader)[3].ToString();
					stockpostinginfo.InvoiceNo = ((DbDataReader)sdrreader)[4].ToString();
					stockpostinginfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					stockpostinginfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					stockpostinginfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					stockpostinginfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					stockpostinginfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					stockpostinginfo.AgainstVoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					stockpostinginfo.AgainstInvoiceNo = ((DbDataReader)sdrreader)[11].ToString();
					stockpostinginfo.AgainstVoucherNo = ((DbDataReader)sdrreader)[12].ToString();
					stockpostinginfo.InwardQty = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					stockpostinginfo.OutwardQty = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					stockpostinginfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					stockpostinginfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[16].ToString());
					stockpostinginfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[17].ToString());
					stockpostinginfo.Extra1 = ((DbDataReader)sdrreader)[18].ToString();
					stockpostinginfo.Extra2 = ((DbDataReader)sdrreader)[19].ToString();
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
			return stockpostinginfo;
		}

		public void StockPostingDelete(decimal StockPostingId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
				sprmparam2.Value = StockPostingId;
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

		public int StockPostingGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingMax", base.sqlcon);
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

		public void StpDeleteForProductUpdation(decimal decProductId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StpDeleteForProductUpdation", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
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

		public bool StpDeleteForRowRemove(decimal decStpId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StpDeleteForRowRemove", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				sprmparam = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
				sprmparam.Value = decStpId;
				decResult = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			if (decResult > 0m)
			{
				return true;
			}
			return false;
		}

		public int ReturnBatchIdFromStockPosting(decimal decProductId)
		{
			int inResult = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReturnBatchIdFromStockPosting", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				inResult = Convert.ToInt32(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inResult;
		}

		public void DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo(decimal decAgnstVouTypeId, string strAgnstVouNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decAgnstVouTypeId;
				cmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strAgnstVouNo;
				cmd.ExecuteNonQuery();
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

		public void DeleteStockPostingForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("DeleteStockPostingForStockJournalEdit", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				cmd.ExecuteNonQuery();
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

		public decimal StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, string strVoucherNo, decimal decVoucherTypeId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decAgainstVoucherTypeId;
				sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strAgainstVoucherNo;
				sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
				decResult = ((ineffeftedRow <= 0) ? 0m : 1m);
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

		public void StockPostingDeleteByVoucherTypeIdAndVoucherNoAndInvoiceNo(decimal voucherTypeId, string voucherNo, string invoiceNo, decimal productId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingDeleteByVoucherTypeIdAndVoucherNoAndInvoiceNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = voucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam5.Value = voucherNo;
				sprmparam5 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam5.Value = invoiceNo;
				sprmparam5 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam5.Value = productId;
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

		public decimal ProductGetCurrentStock(decimal decProductId, decimal decGodownId, decimal decBatchId, decimal decRackId)
		{
			decimal decStock = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductGetCurrentStock", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam5.Value = decProductId;
				sprmparam5 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam5.Value = decGodownId;
				sprmparam5 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam5.Value = decBatchId;
				sprmparam5 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam5.Value = decRackId;
				decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStock;
		}

		public DataTable StockReportGridFill1(string strProductName, decimal decBrandid, decimal decmodelNoId, string strproductCode, decimal decgodownId, decimal decrackId, decimal decsizeId, decimal dectaxId, decimal decgrpId, string strBatchName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("StockReportGridFill1", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandid;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decmodelNoId;
				sqlda.SelectCommand.Parameters.Add("@productCode ", SqlDbType.VarChar).Value = strproductCode;
				sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decgodownId;
				sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal).Value = decrackId;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decsizeId;
				sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = dectaxId;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgrpId;
				sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("SPSP:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataSet StockReportPrint(string strProductName, decimal decBrandid, decimal decmodelNoId, string strproductCode, decimal decgodownId, decimal decrackId, decimal decsizeId, decimal dectaxId, decimal decgrpId, string strBatchName)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("StockReportCrystalReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlprm10 = new SqlParameter();
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
				sqlprm10.Value = decBrandid;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sqlprm10.Value = decmodelNoId;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@productCode ", SqlDbType.VarChar);
				sqlprm10.Value = strproductCode;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
				sqlprm10.Value = decgodownId;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
				sqlprm10.Value = decrackId;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sqlprm10.Value = decsizeId;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				sqlprm10.Value = dectaxId;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				sqlprm10.Value = decgrpId;
				sqlprm10 = sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar);
				sqlprm10.Value = strBatchName;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show("SPSP:2" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public decimal StockCheckForProductSale(decimal decProductId, decimal decBatchId)
		{
			decimal decStock = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StocKCheckForProductSale", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = decProductId;
				sprmparam3 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam3.Value = decBatchId;
				decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStock;
		}

		public decimal BatchViewByProductId(decimal decProductId)
		{
			decimal decStock = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchViewByProductId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStock;
		}

		public decimal StockPostingDeleteForSalesInvoiceAgainstDeliveryNote(decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, string strVoucherNo, decimal decVoucherTypeId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingDeleteForSalesInvoiceAgainstDeliveryNote", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decAgainstVoucherTypeId;
				sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strAgainstVoucherNo;
				sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
				decResult = ((ineffeftedRow <= 0) ? 0m : 1m);
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

		public void StockPostingDeleteByVoucherTypeAndVoucherNo(string strVoucherNo, decimal decVoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostingDeleteByVoucherTypeAndVoucherNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
	}
}
