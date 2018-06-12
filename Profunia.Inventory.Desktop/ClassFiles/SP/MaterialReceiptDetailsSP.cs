using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class MaterialReceiptDetailsSP : DBConnection
	{
		public void MaterialReceiptDetailsAdd(MaterialReceiptDetailsInfo materialreceiptdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.MaterialReceiptMasterId;
				sprmparam16 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.ProductId;
				sprmparam16 = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.OrderDetailsId;
				sprmparam16 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.Qty;
				sprmparam16 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.Rate;
				sprmparam16 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.UnitId;
				sprmparam16 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.UnitConversionId;
				sprmparam16 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.BatchId;
				sprmparam16 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.GodownId;
				sprmparam16 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.RackId;
				sprmparam16 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam16.Value = materialreceiptdetailsinfo.Amount;
				sprmparam16 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam16.Value = materialreceiptdetailsinfo.Slno;
				sprmparam16 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam16.Value = materialreceiptdetailsinfo.ExtraDate;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = materialreceiptdetailsinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@exta2", SqlDbType.VarChar);
				sprmparam16.Value = materialreceiptdetailsinfo.Exta2;
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

		public void MaterialReceiptDetailsEdit(MaterialReceiptDetailsInfo materialreceiptdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.MaterialReceiptDetailsId;
				sprmparam17 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.MaterialReceiptMasterId;
				sprmparam17 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.ProductId;
				sprmparam17 = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.OrderDetailsId;
				sprmparam17 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.Qty;
				sprmparam17 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.Rate;
				sprmparam17 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.UnitId;
				sprmparam17 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.UnitConversionId;
				sprmparam17 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.BatchId;
				sprmparam17 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.GodownId;
				sprmparam17 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.RackId;
				sprmparam17 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = materialreceiptdetailsinfo.Amount;
				sprmparam17 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam17.Value = materialreceiptdetailsinfo.Slno;
				sprmparam17 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam17.Value = materialreceiptdetailsinfo.ExtraDate;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = materialreceiptdetailsinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@exta2", SqlDbType.VarChar);
				sprmparam17.Value = materialreceiptdetailsinfo.Exta2;
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

		public DataTable MaterialReceiptDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("MaterialReceiptDetailsViewAll", base.sqlcon);
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

		public MaterialReceiptDetailsInfo MaterialReceiptDetailsView(decimal materialReceiptDetailsId)
		{
			MaterialReceiptDetailsInfo materialreceiptdetailsinfo = new MaterialReceiptDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = materialReceiptDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					materialreceiptdetailsinfo.MaterialReceiptDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					materialreceiptdetailsinfo.MaterialReceiptMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					materialreceiptdetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					materialreceiptdetailsinfo.OrderDetailsId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					materialreceiptdetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					materialreceiptdetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					materialreceiptdetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					materialreceiptdetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					materialreceiptdetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					materialreceiptdetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					materialreceiptdetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					materialreceiptdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					materialreceiptdetailsinfo.Slno = int.Parse(((DbDataReader)sdrreader)[12].ToString());
					materialreceiptdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[14].ToString();
					materialreceiptdetailsinfo.Exta2 = ((DbDataReader)sdrreader)[15].ToString();
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
			return materialreceiptdetailsinfo;
		}

		public int MaterialReceiptDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsMax", base.sqlcon);
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

		public DataTable MaterialReceiptDetailsViewByMasterId(decimal decMaterialReceiptMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("MaterialReceiptDetailsViewByMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal).Value = decMaterialReceiptMasterId;
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

		public DataTable VoucherTypeCombofillforMaterialReceipt()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforMaterialReceipt", base.sqlcon);
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

		public DataTable ShowMaterialReceiptDetailsViewbyMaterialReceiptDetailsIdWithPending(decimal decmaterialReceiptMasterId, decimal decrejectionOutMasterId)
		{
			DataTable dtblReceiptDetails = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ShowMaterialReceiptDetailsViewbyMaterialReceiptDetailsIdWithPending", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decmaterialReceiptMasterId;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decrejectionOutMasterId;
				sdaadapter.Fill(dtblReceiptDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblReceiptDetails;
		}

		public void MaterialReceiptDetailsDelete(decimal MaterialReceiptDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
				sprmparam2.Value = MaterialReceiptDetailsId;
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

		public DataTable MaterialReceiptDetailsViewByMaterialReceiptMasterIdWithRemainingByNotInCurrPI(decimal decMaterialReceiptMasterId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptDetailsViewByMaterialReceiptMasterIdWithRemainingByNotInCurrPI", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decMaterialReceiptMasterId;
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decPurchaseMasterId;
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
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
