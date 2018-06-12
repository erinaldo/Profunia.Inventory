using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseReturnDetailsSP : DBConnection
	{
		public void PurchaseReturnDetailsAdd(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.PurchaseReturnDetailsId;
				sprmparam21 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.PurchaseReturnMasterId;
				sprmparam21 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.ProductId;
				sprmparam21 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Qty;
				sprmparam21 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Rate;
				sprmparam21 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.UnitId;
				sprmparam21 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.UnitConversionId;
				sprmparam21 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Discount;
				sprmparam21 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.TaxId;
				sprmparam21 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.BatchId;
				sprmparam21 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.GodownId;
				sprmparam21 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.RackId;
				sprmparam21 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.TaxAmount;
				sprmparam21 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.GrossAmount;
				sprmparam21 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.NetAmount;
				sprmparam21 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Amount;
				sprmparam21 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam21.Value = purchasereturndetailsinfo.SlNo;
				sprmparam21 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam21.Value = purchasereturndetailsinfo.ExtraDate;
				sprmparam21 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam21.Value = purchasereturndetailsinfo.Extra1;
				sprmparam21 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam21.Value = purchasereturndetailsinfo.Extra2;
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

		public void PurchaseReturnDetailsEdit(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.PurchaseReturnDetailsId;
				sprmparam21 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.PurchaseReturnMasterId;
				sprmparam21 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.ProductId;
				sprmparam21 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Qty;
				sprmparam21 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Rate;
				sprmparam21 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.UnitId;
				sprmparam21 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.UnitConversionId;
				sprmparam21 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Discount;
				sprmparam21 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.TaxId;
				sprmparam21 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.BatchId;
				sprmparam21 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.GodownId;
				sprmparam21 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.RackId;
				sprmparam21 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.TaxAmount;
				sprmparam21 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.GrossAmount;
				sprmparam21 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.NetAmount;
				sprmparam21 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Amount;
				sprmparam21 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam21.Value = purchasereturndetailsinfo.SlNo;
				sprmparam21 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam21.Value = purchasereturndetailsinfo.ExtraDate;
				sprmparam21 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam21.Value = purchasereturndetailsinfo.Extra1;
				sprmparam21 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam21.Value = purchasereturndetailsinfo.Extra2;
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

		public DataTable PurchaseReturnDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseReturnDetailsViewAll", base.sqlcon);
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

		public PurchaseReturnDetailsInfo PurchaseReturnDetailsView(decimal purchaseReturnDetailsId)
		{
			PurchaseReturnDetailsInfo purchasereturndetailsinfo = new PurchaseReturnDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseReturnDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchasereturndetailsinfo.PurchaseReturnDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					purchasereturndetailsinfo.PurchaseReturnMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					purchasereturndetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					purchasereturndetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					purchasereturndetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					purchasereturndetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					purchasereturndetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					purchasereturndetailsinfo.Discount = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					purchasereturndetailsinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					purchasereturndetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					purchasereturndetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					purchasereturndetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					purchasereturndetailsinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					purchasereturndetailsinfo.GrossAmount = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					purchasereturndetailsinfo.NetAmount = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					purchasereturndetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					purchasereturndetailsinfo.SlNo = int.Parse(((DbDataReader)sdrreader)[16].ToString());
					purchasereturndetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[17].ToString());
					purchasereturndetailsinfo.Extra1 = ((DbDataReader)sdrreader)[18].ToString();
					purchasereturndetailsinfo.Extra2 = ((DbDataReader)sdrreader)[19].ToString();
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
			return purchasereturndetailsinfo;
		}

		public void PurchaseReturnDetailsDelete(decimal PurchaseReturnDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseReturnDetailsId;
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

		public int PurchaseReturnDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsMax", base.sqlcon);
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

		public decimal PurchaseReturnDetailsAddWithReturnIdentity(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsAddWithReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.PurchaseReturnMasterId;
				sprmparam21 = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.PurchaseDetailsId;
				sprmparam21 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.ProductId;
				sprmparam21 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Qty;
				sprmparam21 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Rate;
				sprmparam21 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.UnitId;
				sprmparam21 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.UnitConversionId;
				sprmparam21 = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Discount;
				sprmparam21 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.TaxId;
				sprmparam21 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.BatchId;
				sprmparam21 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.GodownId;
				sprmparam21 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.RackId;
				sprmparam21 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.TaxAmount;
				sprmparam21 = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.GrossAmount;
				sprmparam21 = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.NetAmount;
				sprmparam21 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam21.Value = purchasereturndetailsinfo.Amount;
				sprmparam21 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam21.Value = purchasereturndetailsinfo.SlNo;
				sprmparam21 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam21.Value = purchasereturndetailsinfo.ExtraDate;
				sprmparam21 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam21.Value = purchasereturndetailsinfo.Extra1;
				sprmparam21 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam21.Value = purchasereturndetailsinfo.Extra2;
				decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decIdentity;
		}

		public DataTable PurchaseReturnDetailsViewByMasterId(decimal decPurchaseReturnMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("PurchaseReturnDetailsViewByMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal).Value = decPurchaseReturnMasterId;
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

		public DataTable VoucherTypeComboFillForPurchaseReturn()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherTypeComboFillForPurchaseReturn", base.sqlcon);
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

		public decimal PurchaseReturnDetailsQtyViewByPurchaseDetailsId(decimal decPurchaseDetailsId)
		{
			decimal decQty = 0m;
			object objQty2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsQtyViewByPurchaseDetailsId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = decPurchaseDetailsId;
				objQty2 = sccmd.ExecuteScalar();
				if (objQty2 != null)
				{
					decQty = Convert.ToDecimal(objQty2.ToString());
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
			return decQty;
		}
	}
}
