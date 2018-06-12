using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class RejectionInDetailsSP : DBConnection
	{
		public void RejectionInDetailsAdd(RejectionInDetailsInfo rejectionindetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionInDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam15 = new SqlParameter();
				sprmparam15 = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.RejectionInMasterId;
				sprmparam15 = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.DeliveryNoteDetailsId;
				sprmparam15 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.ProductId;
				sprmparam15 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.Qty;
				sprmparam15 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.Rate;
				sprmparam15 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.UnitId;
				sprmparam15 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.UnitConversionId;
				sprmparam15 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.BatchId;
				sprmparam15 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.GodownId;
				sprmparam15 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.RackId;
				sprmparam15 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam15.Value = rejectionindetailsinfo.Amount;
				sprmparam15 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam15.Value = rejectionindetailsinfo.SlNo;
				sprmparam15 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam15.Value = rejectionindetailsinfo.Extra1;
				sprmparam15 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam15.Value = rejectionindetailsinfo.Extra2;
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

		public void RejectionInDetailsEdit(RejectionInDetailsInfo rejectionindetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionInDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@rejectionInDetailsId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.RejectionInDetailsId;
				sprmparam17 = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.RejectionInMasterId;
				sprmparam17 = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.DeliveryNoteDetailsId;
				sprmparam17 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.ProductId;
				sprmparam17 = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.Qty;
				sprmparam17 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.Rate;
				sprmparam17 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.UnitId;
				sprmparam17 = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.UnitConversionId;
				sprmparam17 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.BatchId;
				sprmparam17 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.GodownId;
				sprmparam17 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.RackId;
				sprmparam17 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam17.Value = rejectionindetailsinfo.Amount;
				sprmparam17 = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
				sprmparam17.Value = rejectionindetailsinfo.SlNo;
				sprmparam17 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam17.Value = rejectionindetailsinfo.ExtraDate;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = rejectionindetailsinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = rejectionindetailsinfo.Extra2;
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

		public void DeleteRejectionInDetailsByRejectionInMasterId(decimal decRejectionInMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("RejectionInDetailsDeleteByRejectionInMasterId", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = cmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				param2.Value = decRejectionInMasterId;
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

		public DataTable RejectionInDetailsViewByRejectionInMasterId(decimal decRejectionInMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInDetailsViewByRejectionInMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				param2.Value = decRejectionInMasterId;
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
