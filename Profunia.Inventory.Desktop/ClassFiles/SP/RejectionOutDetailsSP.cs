using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class RejectionOutDetailsSP : DBConnection
	{
		public void RejectionOutDetailsAdd(RejectionOutDetailsInfo rejectionoutdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.RejectionOutMasterId;
				sprmparam16 = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.MaterialReceiptDetailsId;
				sprmparam16 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.ProductId;
				sprmparam16 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.Qty;
				sprmparam16 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.Rate;
				sprmparam16 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.UnitId;
				sprmparam16 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.UnitConversionId;
				sprmparam16 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.BatchId;
				sprmparam16 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.GodownId;
				sprmparam16 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.RackId;
				sprmparam16 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam16.Value = rejectionoutdetailsinfo.Amount;
				sprmparam16 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam16.Value = rejectionoutdetailsinfo.Slno;
				sprmparam16 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam16.Value = rejectionoutdetailsinfo.ExtraDate;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = rejectionoutdetailsinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = rejectionoutdetailsinfo.Extra2;
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

		public decimal RejectionOutDetailsAddWithReturnIdentity(RejectionOutDetailsInfo rejectionoutdetailsinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutDetailsAddWithReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.RejectionOutMasterId;
				sprmparam15 = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.MaterialReceiptDetailsId;
				sprmparam15 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.ProductId;
				sprmparam15 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.Qty;
				sprmparam15 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.Rate;
				sprmparam15 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.UnitId;
				sprmparam15 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.UnitConversionId;
				sprmparam15 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.BatchId;
				sprmparam15 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.GodownId;
				sprmparam15 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.RackId;
				sprmparam15 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam15.Value = rejectionoutdetailsinfo.Amount;
				sprmparam15 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam15.Value = rejectionoutdetailsinfo.Slno;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = rejectionoutdetailsinfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = rejectionoutdetailsinfo.Extra2;
				object obj = Convert.ToDecimal(sccmd.ExecuteScalar());
				if (obj != null)
				{
					decIdentity = Convert.ToDecimal(obj);
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
			return decIdentity;
		}

		public void RejectionOutDetailsEdit(RejectionOutDetailsInfo rejectionoutdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@rejectionOutDetailsId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.RejectionOutDetailsId;
				sprmparam17 = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.RejectionOutMasterId;
				sprmparam17 = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.MaterialReceiptDetailsId;
				sprmparam17 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.ProductId;
				sprmparam17 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.Qty;
				sprmparam17 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.Rate;
				sprmparam17 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.UnitId;
				sprmparam17 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.UnitConversionId;
				sprmparam17 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.BatchId;
				sprmparam17 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.GodownId;
				sprmparam17 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.RackId;
				sprmparam17 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = rejectionoutdetailsinfo.Amount;
				sprmparam17 = sccmd.Parameters.Add("@slno", SqlDbType.Int);
				sprmparam17.Value = rejectionoutdetailsinfo.Slno;
				sprmparam17 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam17.Value = rejectionoutdetailsinfo.ExtraDate;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutdetailsinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = rejectionoutdetailsinfo.Extra2;
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

		public DataTable RejectionOutDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RejectionOutDetailsViewAll", base.sqlcon);
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

		public RejectionOutDetailsInfo RejectionOutDetailsView(decimal rejectionOutDetailsId)
		{
			RejectionOutDetailsInfo rejectionoutdetailsinfo = new RejectionOutDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rejectionOutDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = rejectionOutDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					rejectionoutdetailsinfo.RejectionOutDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					rejectionoutdetailsinfo.RejectionOutMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					rejectionoutdetailsinfo.MaterialReceiptDetailsId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					rejectionoutdetailsinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					rejectionoutdetailsinfo.Qty = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					rejectionoutdetailsinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					rejectionoutdetailsinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					rejectionoutdetailsinfo.UnitConversionId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					rejectionoutdetailsinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					rejectionoutdetailsinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					rejectionoutdetailsinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					rejectionoutdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					rejectionoutdetailsinfo.Slno = int.Parse(((DbDataReader)sdrreader)[12].ToString());
					rejectionoutdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[13].ToString());
					rejectionoutdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[14].ToString();
					rejectionoutdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[15].ToString();
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
			return rejectionoutdetailsinfo;
		}

		public void RejectionOutDetailsDelete(decimal RejectionOutDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rejectionOutDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = RejectionOutDetailsId;
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

		public void RejectionOutDetailsDeleteByRejectionOutMasterId(decimal decRejectionOutMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("RejectionOutDetailsDeleteByRejectionOutMasterId", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = cmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				param2.Value = decRejectionOutMasterId;
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

		public int RejectionOutDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionOutDetailsMax", base.sqlcon);
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

		public DataTable VoucherTypeComboFillForRejectionOutReport()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("VoucherTypeComboFillForRejectionOutReport", base.sqlcon);
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

		public DataTable RejectionOutDetailsViewByRejectionOutMasterId(decimal decRejectionOutMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("RejectionOutDetailsViewByRejectionOutMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = decRejectionOutMasterId;
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
