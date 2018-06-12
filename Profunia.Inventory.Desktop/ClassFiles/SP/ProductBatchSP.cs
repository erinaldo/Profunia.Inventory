using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ProductBatchSP : DBConnection
	{
		public void ProductBatchAdd(ProductBatchInfo productbatchinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductBatchAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam8.Value = productbatchinfo.ProductId;
				sprmparam8 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam8.Value = productbatchinfo.BatchId;
				sprmparam8 = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
				sprmparam8.Value = productbatchinfo.PartNo;
				sprmparam8 = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam8.Value = productbatchinfo.Barcode;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = productbatchinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = productbatchinfo.Extra2;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = productbatchinfo.ExtraDate;
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

		public void ProductBatchEdit(ProductBatchInfo productbatchinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductBatchEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@productBatchId", SqlDbType.Decimal);
				sprmparam9.Value = productbatchinfo.ProductBatchId;
				sprmparam9 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam9.Value = productbatchinfo.ProductId;
				sprmparam9 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam9.Value = productbatchinfo.BatchId;
				sprmparam9 = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
				sprmparam9.Value = productbatchinfo.PartNo;
				sprmparam9 = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam9.Value = productbatchinfo.Barcode;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = productbatchinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = productbatchinfo.Extra2;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = productbatchinfo.ExtraDate;
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

		public DataTable ProductBatchViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductBatchViewAll", base.sqlcon);
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

		public ProductBatchInfo ProductBatchView(decimal productBatchId)
		{
			ProductBatchInfo productbatchinfo = new ProductBatchInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductBatchView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productBatchId", SqlDbType.Decimal);
				sprmparam2.Value = productBatchId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					productbatchinfo.ProductBatchId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					productbatchinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					productbatchinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					productbatchinfo.PartNo = ((DbDataReader)sdrreader)[3].ToString();
					productbatchinfo.Barcode = ((DbDataReader)sdrreader)[4].ToString();
					productbatchinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					productbatchinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
					productbatchinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
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
			return productbatchinfo;
		}

		public void ProductBatchDelete(decimal ProductBatchId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductBatchDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productBatchId", SqlDbType.Decimal);
				sprmparam2.Value = ProductBatchId;
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

		public int ProductBatchGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductBatchMax", base.sqlcon);
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

		public string ProductBatchBarcodeViewByBatchId(decimal decBathId)
		{
			string barCode = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductBatchBarcodeViewByBatchId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam2.Value = decBathId;
				barCode = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return barCode;
		}
	}
}
