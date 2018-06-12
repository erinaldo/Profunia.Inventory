using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseOrderDetailsSP : DBConnection
	{
		public void PurchaseOrderDetailsAdd(PurchaseOrderDetailsInfo purchaseorderdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam11.Value = purchaseorderdetailsinfo.PurchaseOrderMasterId;
				sprmparam11 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam11.Value = purchaseorderdetailsinfo.ProductId;
				sprmparam11 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam11.Value = purchaseorderdetailsinfo.Qty;
				sprmparam11 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam11.Value = purchaseorderdetailsinfo.Rate;
				sprmparam11 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam11.Value = purchaseorderdetailsinfo.UnitId;
				sprmparam11 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam11.Value = purchaseorderdetailsinfo.UnitConversionId;
				sprmparam11 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam11.Value = purchaseorderdetailsinfo.Amount;
				sprmparam11 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam11.Value = purchaseorderdetailsinfo.SlNo;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = purchaseorderdetailsinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = purchaseorderdetailsinfo.Extra2;
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

		public void PurchaseOrderDetailsEdit(PurchaseOrderDetailsInfo purchaseorderdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam12 = new SqlParameter();
				sprmparam12 = sccmd.Parameters.Add("@purchaseOrderDetailsId", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.PurchaseOrderDetailsId;
				sprmparam12 = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.PurchaseOrderMasterId;
				sprmparam12 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.ProductId;
				sprmparam12 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.Qty;
				sprmparam12 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.Rate;
				sprmparam12 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.UnitId;
				sprmparam12 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.UnitConversionId;
				sprmparam12 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam12.Value = purchaseorderdetailsinfo.Amount;
				sprmparam12 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam12.Value = purchaseorderdetailsinfo.SlNo;
				sprmparam12 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam12.Value = purchaseorderdetailsinfo.Extra1;
				sprmparam12 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam12.Value = purchaseorderdetailsinfo.Extra2;
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

		public DataTable PurchaseOrderDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseOrderDetailsViewAll", base.sqlcon);
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

		public PurchaseOrderDetailsInfo PurchaseOrderDetailsView(decimal purchaseOrderDetailsId)
		{
			PurchaseOrderDetailsInfo purchaseorderdetailsinfo = new PurchaseOrderDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseOrderDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseOrderDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchaseorderdetailsinfo.PurchaseOrderDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					purchaseorderdetailsinfo.PurchaseOrderMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					purchaseorderdetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					purchaseorderdetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					purchaseorderdetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					purchaseorderdetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					purchaseorderdetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					purchaseorderdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					purchaseorderdetailsinfo.SlNo = int.Parse(((DbDataReader)sdrreader)[8].ToString());
					purchaseorderdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[9].ToString());
					purchaseorderdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[10].ToString();
					purchaseorderdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[11].ToString();
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
			return purchaseorderdetailsinfo;
		}

		public decimal PurchaseOrderDetailsDelete(decimal PurchaseOrderDetailsId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseOrderDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseOrderDetailsId;
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

		public int PurchaseOrderDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsMax", base.sqlcon);
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

		public DataTable PurchaseOrderDetailsViewByMasterId(decimal decpurchaseOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("PurchaseOrderDetailsViewByMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal).Value = decpurchaseOrderMasterId;
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

		public DataTable PurchaseOrderDetailsViewWithRemaining(decimal decpurchaseOrderMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("PurchaseOrderDetailsViewWithRemaining", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal).Value = decpurchaseOrderMasterId;
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

		public DataTable VoucherTypeCombofillforPurchaseOrderReport()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforPurchaseOrderReport", base.sqlcon);
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

		public DataTable PurchaseOrderDetailsViewByOrderMasterIdWithRemaining(decimal decOrderMasterId, decimal decReceiptMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseOrderDetailsViewByOrderMasterIdWithRemaining", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decOrderMasterId;
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decReceiptMasterId;
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

		public DataTable PurchaseOrderDetailsViewByOrderMasterIdWithRemainingByNotInCurrPI(decimal decPurchaseOrderMasterId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseOrderDetailsViewByOrderMasterIdWithRemainingByNotInCurrPI", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqlda.SelectCommand.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decPurchaseOrderMasterId;
				sqlparameter4 = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decPurchaseMasterId;
				sqlparameter4 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter4.Value = decVoucherTypeId;
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

		public DataTable PurchaseOrderDetailsViewByOrderMasterIdWithRemainingForEdit(decimal decOrderMasterId, decimal decReceiptMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseOrderDetailsViewByOrderMasterIdWithRemainingForEdit", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decOrderMasterId;
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sqlparameter3.Value = decReceiptMasterId;
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
	}
}
