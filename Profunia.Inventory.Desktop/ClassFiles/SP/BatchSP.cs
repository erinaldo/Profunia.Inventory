using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BatchSP : DBConnection
	{
		public void BatchAdd(BatchInfo batchinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam10.Value = batchinfo.BatchId;
				sprmparam10 = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.BatchNo;
				sprmparam10 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam10.Value = batchinfo.ProductId;
				sprmparam10 = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
				sprmparam10.Value = batchinfo.ManufacturingDate;
				sprmparam10 = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
				sprmparam10.Value = batchinfo.ExpiryDate;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.Extra2;
				sprmparam10 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam10.Value = batchinfo.ExtraDate;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.narration;
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

		public decimal BatchAddReturnIdentity(BatchInfo batchinfo)
		{
			decimal decBatchId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchAddReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.BatchNo;
				sprmparam10 = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.barcode;
				sprmparam10 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam10.Value = batchinfo.ProductId;
				sprmparam10 = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
				sprmparam10.Value = batchinfo.ManufacturingDate;
				sprmparam10 = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
				sprmparam10.Value = batchinfo.ExpiryDate;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.Extra2;
				sprmparam10 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam10.Value = batchinfo.ExtraDate;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = batchinfo.narration;
				decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decBatchId;
		}

		public decimal BatchAddAndDelete(BatchInfo batchinfo, decimal decProductIdForEdit)
		{
			decimal decBatchId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchAddAndDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.BatchNo;
				sprmparam11 = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.barcode;
				sprmparam11 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam11.Value = batchinfo.ProductId;
				sprmparam11 = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
				sprmparam11.Value = batchinfo.ManufacturingDate;
				sprmparam11 = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
				sprmparam11.Value = batchinfo.ExpiryDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.Extra2;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = batchinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.narration;
				sprmparam11 = sccmd.Parameters.Add("@deleteId", SqlDbType.VarChar);
				sprmparam11.Value = decProductIdForEdit;
				decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decBatchId;
		}

		public void BatchEdit(BatchInfo batchinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam9.Value = batchinfo.BatchId;
				sprmparam9 = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.BatchNo;
				sprmparam9 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam9.Value = batchinfo.ProductId;
				sprmparam9 = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
				sprmparam9.Value = batchinfo.ManufacturingDate;
				sprmparam9 = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
				sprmparam9.Value = batchinfo.ExpiryDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.Extra2;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.narration;
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

		public bool BatchEditForProductEdit(BatchInfo batchinfo)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchEditForProductEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam.Value = batchinfo.BatchId;
				sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam.Value = batchinfo.BatchNo;
				sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam.Value = batchinfo.ProductId;
				sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
				sprmparam.Value = batchinfo.ManufacturingDate;
				sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
				sprmparam.Value = batchinfo.ExpiryDate;
				sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam.Value = batchinfo.Extra1;
				sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam.Value = batchinfo.Extra2;
				sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam.Value = batchinfo.narration;
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

		public DataTable BatchViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewAll", base.sqlcon);
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

		public DataTable BatchViewAll1(DataGridView dgvCurrent, decimal decProductId, int inRowIndex)
		{
			DataTable dtblBatch = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DGVBatchFillByProductName", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sqlparameter2.Value = decProductId;
				sdaadapter.Fill(dtblBatch);
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			try
			{
				DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvCmbBatch"].Index, inRowIndex];
				dgvCurrent[dgvCurrent.Columns["dgvCmbBatch"].Index, inRowIndex].Value = null;
				if (dtblBatch.Rows.Count > 0)
				{
					dgvcmbUnit.DataSource = dtblBatch;
					dgvcmbUnit.DisplayMember = "batchNo";
					dgvcmbUnit.ValueMember = "batchId";
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			return dtblBatch;
		}

		public AutoCompleteStringCollection BatchViewAllWithoutNA()
		{
			AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchViewAllWithoutNA", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					strCollection.Add(((DbDataReader)sdrreader)[1].ToString());
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
			return strCollection;
		}

		public BatchInfo BatchView(decimal batchId)
		{
			BatchInfo batchinfo = new BatchInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam2.Value = batchId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					batchinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)["BatchId"].ToString());
					batchinfo.BatchNo = ((DbDataReader)sdrreader)["BatchNo"].ToString();
					batchinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)["ProductId"].ToString());
					batchinfo.ManufacturingDate = DateTime.Parse(((DbDataReader)sdrreader)["ManufacturingDate"].ToString());
					batchinfo.ExpiryDate = DateTime.Parse(((DbDataReader)sdrreader)["ExpiryDate"].ToString());
					batchinfo.Extra1 = ((DbDataReader)sdrreader)["Extra1"].ToString();
					batchinfo.Extra2 = ((DbDataReader)sdrreader)["Extra2"].ToString();
					batchinfo.narration = ((DbDataReader)sdrreader)["narration"].ToString();
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
			return batchinfo;
		}

		public void BatchDelete(decimal BatchId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam2.Value = BatchId;
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

		public int BatchGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchMax", base.sqlcon);
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

		public void BatchAddParticularFields(BatchInfo batchinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchAddParticularFields", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.BatchNo;
				sprmparam9 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam9.Value = batchinfo.ProductId;
				sprmparam9 = sccmd.Parameters.Add("@barcode", SqlDbType.Decimal);
				sprmparam9.Value = batchinfo.barcode;
				sprmparam9 = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
				sprmparam9.Value = batchinfo.ManufacturingDate;
				sprmparam9 = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
				sprmparam9.Value = batchinfo.ExpiryDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.Extra2;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = batchinfo.narration;
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

		public DataTable BatchSearch(string strBatchNo, string strProductName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("BatchSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@batchNo", SqlDbType.VarChar).Value = strBatchNo;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
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

		public bool BatchNameAndProductNameCheckExistence(string strBatchName, decimal decProductId, decimal decBatchId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("BatchNameAndProductNameCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam4.Value = strBatchName;
				sprmparam4 = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam4.Value = decProductId;
				sprmparam4 = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam4.Value = decBatchId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = Convert.ToDecimal(obj.ToString());
				}
				if (decCount > 0m)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return false;
		}

		public decimal BatchCheckReferences(decimal decBatchId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("BatchCheckReferences", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam2.Value = decBatchId;
				decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decReturnValue;
		}

		public bool BatchNameExistenceChecking(string strBatchNo, decimal decBatchId)
		{
			string strResult = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("BatchNameExistenceChecking", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				sprmparam = sqlcmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam.Value = strBatchNo;
				sprmparam = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam.Value = decBatchId;
				strResult = Convert.ToString(sqlcmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			if (strResult == "1")
			{
				return true;
			}
			return false;
		}

		public void DeleteBatchForProductUpdate(decimal decProductId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeleteBatchForProductUpdate", base.sqlcon);
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

		public DataTable BatchViewForComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewForComboFill", base.sqlcon);
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

		public DataTable BatchViewbyProductIdForComboFill(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewbyProductIdForComboFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				param2.Value = decProductId;
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

		public decimal BatchViewByBarcode(string strBarcode)
		{
			decimal decBatchId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchViewBYBarcode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = strBarcode;
				decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decBatchId;
		}

		public DataTable BatchViewByName(string strBatch, decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewByName", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@batchNo", SqlDbType.VarChar).Value = strBatch;
				sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
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

		public DataTable BatchNamesCorrespondingToProduct(decimal decproductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchNamesCorrespondingToProduct", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decproductId;
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

		public int AutomaticBarcodeGeneration()
		{
			int inBarcode = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AutomaticBarcodeGeneration", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				inBarcode = Convert.ToInt32(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inBarcode;
		}

		public int BatchAddWithBarCode(BatchInfo batchinfo)
		{
			int inResultId = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchAddWithBarCode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.BatchNo;
				sprmparam11 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam11.Value = batchinfo.ProductId;
				sprmparam11 = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
				sprmparam11.Value = batchinfo.ManufacturingDate;
				sprmparam11 = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
				sprmparam11.Value = batchinfo.ExpiryDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.Extra2;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = batchinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.narration;
				sprmparam11 = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.barcode;
				sprmparam11 = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
				sprmparam11.Value = batchinfo.partNo;
				inResultId = Convert.ToInt32(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inResultId;
		}

		public string PartNoReturn(decimal decProductId)
		{
			string strPartNo = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartNoReturn", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				strPartNo = Convert.ToString(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strPartNo;
		}

		public void PartNoUpdate(decimal decProductId, string strPartNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartNoUpdate", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = decProductId;
				sprmparam3 = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
				sprmparam3.Value = strPartNo;
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

		public DataTable ProductCodeViewByBarCode(string barcode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewByBarcode", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam2.Value = barcode;
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
				barCode = Convert.ToString(sccmd.ExecuteScalar());
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

		public int BatchIdForStockPosting(decimal decProductId)
		{
			int inBatchId = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchIdForStockPosting", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				inBatchId = Convert.ToInt32(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inBatchId;
		}

		public BatchInfo BatchAndProductViewByBarcode(string strBarcode)
		{
			BatchInfo batchinfo = new BatchInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchAndProductViewByBarcode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam2.Value = strBarcode;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					batchinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					batchinfo.BatchNo = ((DbDataReader)sdrreader)[1].ToString();
					batchinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					batchinfo.barcode = ((DbDataReader)sdrreader)[3].ToString();
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
			return batchinfo;
		}

		public DataTable BatchViewbyProductIdForComboFillInGrid(decimal decProductId, DataGridView dgvCurrent, int inRowIndex)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("BatchViewbyProductIdForComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				param2.Value = decProductId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			try
			{
				DataGridViewComboBoxCell dgvcmbBatch = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvcmbBatch"].Index, inRowIndex];
				dgvCurrent[dgvCurrent.Columns["dgvcmbBatch"].Index, inRowIndex].Value = null;
				if (dtbl.Rows.Count > 0)
				{
					dgvcmbBatch.DataSource = dtbl;
					dgvcmbBatch.DisplayMember = "batchNo";
					dgvcmbBatch.ValueMember = "batchId";
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			return dtbl;
		}

		public DataTable BatchNoViewByProductId(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("BatchNoViewByProductId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
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

		public decimal BatchIdViewByProductId(decimal decProductId)
		{
			decimal decBatchId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchIdViewByProductId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decBatchId;
		}

		public DataTable BatchViewAllByProductCodeForBarcodePrinting(decimal decProductId, ComboBox cmbBatch, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sda = new SqlDataAdapter("BatchViewAllByProductCodeForBarcodePrinting", base.sqlcon);
				sda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				sda.Fill(dtbl);
				if (isAll)
				{
					if (dtbl.Rows.Count != 0)
					{
						DataRow dr = dtbl.NewRow();
						dr["batchNo"] = "All";
						dr["batchId"] = 0;
						dtbl.Rows.InsertAt(dr, 0);
					}
					else
					{
						cmbBatch.Text = string.Empty;
					}
				}
				cmbBatch.DataSource = dtbl;
				cmbBatch.DisplayMember = "batchNo";
				cmbBatch.ValueMember = "batchId";
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

		public DataTable BarcodePrintingGrideFill(decimal decProductId, decimal decBatchId, decimal decPurchaseMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sda = new SqlDataAdapter("BarcodePrintingGrideFill", base.sqlcon);
				sda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam4.Value = decProductId;
				sprmparam4 = sda.SelectCommand.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam4.Value = decBatchId;
				sprmparam4 = sda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decPurchaseMasterId;
				sda.Fill(dtbl);
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
