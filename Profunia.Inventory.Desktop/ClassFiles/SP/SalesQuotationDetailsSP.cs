using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesQuotationDetailsSP : DBConnection
	{
		public void SalesQuotationDetailsAdd(SalesQuotationDetailsInfo salesquotationdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.QuotationMasterId;
				sprmparam12 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.ProductId;
				sprmparam12 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.UnitId;
				sprmparam12 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.UnitConversionId;
				sprmparam12 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.Qty;
				sprmparam12 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.Rate;
				sprmparam12 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.Amount;
				sprmparam12 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam12.Value = salesquotationdetailsinfo.BatchId;
				sprmparam12 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam12.Value = salesquotationdetailsinfo.Slno;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = salesquotationdetailsinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = salesquotationdetailsinfo.Extra2;
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

		public void SalesQuotationDetailsEdit(SalesQuotationDetailsInfo salesquotationdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.QuotationDetailsId;
				sprmparam13 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.QuotationMasterId;
				sprmparam13 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.ProductId;
				sprmparam13 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.UnitId;
				sprmparam13 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.UnitConversionId;
				sprmparam13 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.Qty;
				sprmparam13 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.Rate;
				sprmparam13 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.Amount;
				sprmparam13 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam13.Value = salesquotationdetailsinfo.BatchId;
				sprmparam13 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam13.Value = salesquotationdetailsinfo.Slno;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = salesquotationdetailsinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = salesquotationdetailsinfo.Extra2;
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

		public DataTable SalesQuotationDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationDetailsViewAll", base.sqlcon);
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

		public DataTable VoucherTypeCombofillforSalesQuotationReport()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforSalesQuotationReport", base.sqlcon);
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

		public SalesQuotationDetailsInfo SalesQuotationDetailsView(decimal quotationDetailsId)
		{
			SalesQuotationDetailsInfo salesquotationdetailsinfo = new SalesQuotationDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = quotationDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesquotationdetailsinfo.QuotationDetailsId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					salesquotationdetailsinfo.QuotationMasterId = Convert.ToDecimal(((DbDataReader)sdrreader)[1].ToString());
					salesquotationdetailsinfo.ProductId = Convert.ToDecimal(((DbDataReader)sdrreader)[2].ToString());
					salesquotationdetailsinfo.UnitId = Convert.ToDecimal(((DbDataReader)sdrreader)[3].ToString());
					salesquotationdetailsinfo.UnitConversionId = Convert.ToDecimal(((DbDataReader)sdrreader)[4].ToString());
					salesquotationdetailsinfo.Qty = Convert.ToDecimal(((DbDataReader)sdrreader)[5].ToString());
					salesquotationdetailsinfo.Rate = Convert.ToDecimal(((DbDataReader)sdrreader)[6].ToString());
					salesquotationdetailsinfo.Amount = Convert.ToDecimal(((DbDataReader)sdrreader)[7].ToString());
					salesquotationdetailsinfo.Slno = int.Parse(((DbDataReader)sdrreader)[8].ToString());
					salesquotationdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[11].ToString();
					salesquotationdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[12].ToString();
					salesquotationdetailsinfo.BatchId = Convert.ToDecimal(((DbDataReader)sdrreader)[13].ToString());
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
			return salesquotationdetailsinfo;
		}

		public decimal SalesQuotationDetailsDelete(decimal QuotationDetailsId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = QuotationDetailsId;
				int ineffectedRow = Convert.ToInt32(sccmd.ExecuteNonQuery().ToString());
				if (ineffectedRow > 0)
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

		public bool SalesQuotationRefererenceCheckForEditDetails(decimal decSalesQuotationDetailsId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesQuotationRefererenceCheckForEditDetails", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesQuotationDetailsId;
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

		public DataTable SalesQuotationDetailsViewByMasterId(decimal decSalesQuotationMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationDetailsViewByMasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal).Value = decSalesQuotationMasterId;
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

		public int SalesQuotationDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsMax", base.sqlcon);
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

		public DataTable SalesQuotationDetailsViewByquotationMasterIdWithRemainingBySO(decimal decQuotationMasterId, decimal decSalesOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesQuotationDetailsViewByquotationMasterIdWithRemainingBySO", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decQuotationMasterId;
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decSalesOrderMasterId;
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

		public DataTable SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN(decimal decQuotationMasterId, decimal decDeliveryNoteId)
		{
			DataTable dtblQuotationDetails = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decQuotationMasterId;
				sqlparameter3 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decDeliveryNoteId;
				sqlda.Fill(dtblQuotationDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblQuotationDetails;
		}

		public DataTable SalesInvoiceGridfillAgainestQuotationUsingQuotationDetails(decimal decQuotationMasterId, decimal salesOrderMasterId, decimal voucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestQuotationUsingQuotationDetails", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decQuotationMasterId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = salesOrderMasterId;
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

		public decimal SalesQuatationReferenceCheck(decimal decSalesQuotationDeatilsId)
		{
			decimal decQty = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesQuatationReferenceCheck", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@salesQuatationDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesQuotationDeatilsId;
				decQty = Convert.ToDecimal(sqlcmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decQty;
		}
	}
}
