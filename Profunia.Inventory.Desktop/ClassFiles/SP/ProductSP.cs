using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ProductSP : DBConnection
	{
		public decimal ProductAdd(ProductInfo productinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam28 = new SqlParameter();
				sprmparam28 = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam28.Value = productinfo.ProductCode;
				sprmparam28 = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam28.Value = productinfo.ProductName;
				sprmparam28 = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.GroupId;
				sprmparam28 = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.BrandId;
				sprmparam28 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.UnitId;
				sprmparam28 = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.SizeId;
				sprmparam28 = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.ModelNoId;
				sprmparam28 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.TaxId;
				sprmparam28 = sccmd.Parameters.Add("@taxapplicableOn", SqlDbType.VarChar);
				sprmparam28.Value = productinfo.TaxapplicableOn;
				sprmparam28 = sccmd.Parameters.Add("@purchaseRate", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.PurchaseRate;
				sprmparam28 = sccmd.Parameters.Add("@salesRate", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.SalesRate;
				sprmparam28 = sccmd.Parameters.Add("@mrp", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.Mrp;
				sprmparam28 = sccmd.Parameters.Add("@minimumStock", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.MinimumStock;
				sprmparam28 = sccmd.Parameters.Add("@maximumStock", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.MaximumStock;
				sprmparam28 = sccmd.Parameters.Add("@reorderLevel", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.ReorderLevel;
				sprmparam28 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.GodownId;
				sprmparam28 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam28.Value = productinfo.RackId;
				sprmparam28 = sccmd.Parameters.Add("@isallowBatch", SqlDbType.Bit);
				sprmparam28.Value = productinfo.IsallowBatch;
				sprmparam28 = sccmd.Parameters.Add("@ismultipleunit", SqlDbType.Bit);
				sprmparam28.Value = productinfo.Ismultipleunit;
				sprmparam28 = sccmd.Parameters.Add("@isBom", SqlDbType.Bit);
				sprmparam28.Value = productinfo.IsBom;
				sprmparam28 = sccmd.Parameters.Add("@isopeningstock", SqlDbType.Bit);
				sprmparam28.Value = productinfo.Isopeningstock;
				sprmparam28 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam28.Value = productinfo.Narration;
				sprmparam28 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam28.Value = productinfo.IsActive;
				sprmparam28 = sccmd.Parameters.Add("@isshowRemember", SqlDbType.Bit);
				sprmparam28.Value = productinfo.IsshowRemember;
				sprmparam28 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam28.Value = productinfo.Extra1;
				sprmparam28 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam28.Value = productinfo.Extra2;
				sprmparam28 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam28.Value = productinfo.ExtraDate;
				decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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

		public bool ProductEdit(ProductInfo productinfo)
		{
			decimal decCheck = 0m;
			bool isResult = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam29 = new SqlParameter();
				sprmparam29 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.ProductId;
				sprmparam29 = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam29.Value = productinfo.ProductCode;
				sprmparam29 = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam29.Value = productinfo.ProductName;
				sprmparam29 = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.GroupId;
				sprmparam29 = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.BrandId;
				sprmparam29 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.UnitId;
				sprmparam29 = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.SizeId;
				sprmparam29 = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.ModelNoId;
				sprmparam29 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.TaxId;
				sprmparam29 = sccmd.Parameters.Add("@taxapplicableOn", SqlDbType.VarChar);
				sprmparam29.Value = productinfo.TaxapplicableOn;
				sprmparam29 = sccmd.Parameters.Add("@purchaseRate", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.PurchaseRate;
				sprmparam29 = sccmd.Parameters.Add("@salesRate", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.SalesRate;
				sprmparam29 = sccmd.Parameters.Add("@mrp", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.Mrp;
				sprmparam29 = sccmd.Parameters.Add("@minimumStock", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.MinimumStock;
				sprmparam29 = sccmd.Parameters.Add("@maximumStock", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.MaximumStock;
				sprmparam29 = sccmd.Parameters.Add("@reorderLevel", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.ReorderLevel;
				sprmparam29 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.GodownId;
				sprmparam29 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam29.Value = productinfo.RackId;
				sprmparam29 = sccmd.Parameters.Add("@isallowBatch", SqlDbType.Bit);
				sprmparam29.Value = productinfo.IsallowBatch;
				sprmparam29 = sccmd.Parameters.Add("@ismultipleunit", SqlDbType.Bit);
				sprmparam29.Value = productinfo.Ismultipleunit;
				sprmparam29 = sccmd.Parameters.Add("@isBom", SqlDbType.Bit);
				sprmparam29.Value = productinfo.IsBom;
				sprmparam29 = sccmd.Parameters.Add("@isopeningstock", SqlDbType.Bit);
				sprmparam29.Value = productinfo.Isopeningstock;
				sprmparam29 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam29.Value = productinfo.Narration;
				sprmparam29 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam29.Value = productinfo.IsActive;
				sprmparam29 = sccmd.Parameters.Add("@isshowRemember", SqlDbType.Bit);
				sprmparam29.Value = productinfo.IsshowRemember;
				sprmparam29 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam29.Value = productinfo.Extra1;
				sprmparam29 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam29.Value = productinfo.Extra2;
				sprmparam29 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam29.Value = productinfo.ExtraDate;
				decCheck = sccmd.ExecuteNonQuery();
				isResult = (decCheck > 0m && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isResult;
		}

		public DataTable ProductViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAll", base.sqlcon);
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

		public ProductInfo ProductView(decimal productId)
		{
			ProductInfo productinfo = new ProductInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = productId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					productinfo.ProductId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					productinfo.ProductCode = ((DbDataReader)sdrreader)[1].ToString();
					productinfo.ProductName = ((DbDataReader)sdrreader)[2].ToString();
					productinfo.GroupId = Convert.ToDecimal(((DbDataReader)sdrreader)[3].ToString());
					productinfo.BrandId = Convert.ToDecimal(((DbDataReader)sdrreader)[4].ToString());
					productinfo.UnitId = Convert.ToDecimal(((DbDataReader)sdrreader)[5].ToString());
					productinfo.SizeId = Convert.ToDecimal(((DbDataReader)sdrreader)[6].ToString());
					productinfo.ModelNoId = Convert.ToDecimal(((DbDataReader)sdrreader)[7].ToString());
					productinfo.TaxId = Convert.ToDecimal(((DbDataReader)sdrreader)[8].ToString());
					productinfo.TaxapplicableOn = ((DbDataReader)sdrreader)[9].ToString();
					productinfo.PurchaseRate = Convert.ToDecimal(((DbDataReader)sdrreader)[10].ToString());
					productinfo.SalesRate = Convert.ToDecimal(((DbDataReader)sdrreader)[11].ToString());
					productinfo.Mrp = Convert.ToDecimal(((DbDataReader)sdrreader)[12].ToString());
					productinfo.MinimumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[13].ToString());
					productinfo.MaximumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[14].ToString());
					productinfo.ReorderLevel = Convert.ToDecimal(((DbDataReader)sdrreader)[15].ToString());
					productinfo.GodownId = Convert.ToDecimal(((DbDataReader)sdrreader)[16].ToString());
					productinfo.RackId = Convert.ToDecimal(((DbDataReader)sdrreader)[17].ToString());
					productinfo.IsallowBatch = Convert.ToBoolean(((DbDataReader)sdrreader)[18].ToString());
					productinfo.Ismultipleunit = Convert.ToBoolean(((DbDataReader)sdrreader)[19].ToString());
					productinfo.IsBom = Convert.ToBoolean(((DbDataReader)sdrreader)[20].ToString());
					productinfo.Isopeningstock = Convert.ToBoolean(((DbDataReader)sdrreader)[21].ToString());
					productinfo.Narration = ((DbDataReader)sdrreader)[22].ToString();
					productinfo.IsActive = Convert.ToBoolean(((DbDataReader)sdrreader)[23].ToString());
					productinfo.IsshowRemember = Convert.ToBoolean(((DbDataReader)sdrreader)[24].ToString());
					productinfo.Extra1 = ((DbDataReader)sdrreader)[25].ToString();
					productinfo.Extra2 = ((DbDataReader)sdrreader)[26].ToString();
					productinfo.ExtraDate = PublicVariables._dtCurrentDate;
					productinfo.PartNo = ((DbDataReader)sdrreader)[28].ToString();
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
			return productinfo;
		}

		public void ProductDelete(decimal ProductId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = ProductId;
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

		public bool ProductGetMax()
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.ExecuteScalar().ToString();
			}
			catch
			{
				isExist = true;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public DataTable ProductVsBatchReportGridFill(decimal voucherTypeId, string voucherNo, decimal groupId, string productCode, decimal batchId, DateTime FromDate, DateTime ToDate)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sccmd = new SqlCommand("ProductVsBatchReportGridFill", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam8.Value = voucherTypeId;
				sprmparam8 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam8.Value = voucherNo;
				sprmparam8 = sccmd.Parameters.Add("@groupId", SqlDbType.VarChar);
				sprmparam8.Value = groupId;
				sprmparam8 = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam8.Value = productCode;
				sprmparam8 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam8.Value = batchId;
				sprmparam8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam8.Value = FromDate;
				sprmparam8 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam8.Value = ToDate;
				sdaadapter.SelectCommand = sccmd;
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

		public AutoCompleteStringCollection ProudctNameViewAllForAutoComplete()
		{
			AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductNameView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					strCollection.Add(((DbDataReader)sdrreader)[0].ToString());
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

		public AutoCompleteStringCollection ProudctCodesViewAllForAutoComplete()
		{
			AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductCodeView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					strCollection.Add(((DbDataReader)sdrreader)[0].ToString());
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

		public DataTable ChangeProductTaxSearch(ProductInfo infoProduct, int inSelect)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(int));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ChangeProductTaxSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = infoProduct.GroupId;
				sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = infoProduct.ProductCode;
				sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = infoProduct.ProductName;
				sdaadapter.SelectCommand.Parameters.Add("@taxID", SqlDbType.Decimal).Value = infoProduct.TaxId;
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

		public bool ProductCodeCheckExistence(string strProductCode, decimal decProductId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ProductCodeCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam3.Value = strProductCode;
				sprmparam3 = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = decProductId;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public string ProductMax()
		{
			string str = "";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				str = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return str;
		}

		public ProductInfo ProductViewByCode(string strproductCode)
		{
			ProductInfo productinfo = new ProductInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductViewByCode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam2.Value = strproductCode;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					productinfo.ProductId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					productinfo.ProductCode = ((DbDataReader)sdrreader)[1].ToString();
					productinfo.ProductName = ((DbDataReader)sdrreader)[2].ToString();
					productinfo.GroupId = Convert.ToDecimal(((DbDataReader)sdrreader)[3].ToString());
					productinfo.BrandId = Convert.ToDecimal(((DbDataReader)sdrreader)[4].ToString());
					productinfo.UnitId = Convert.ToDecimal(((DbDataReader)sdrreader)[5].ToString());
					productinfo.SizeId = Convert.ToDecimal(((DbDataReader)sdrreader)[6].ToString());
					productinfo.ModelNoId = Convert.ToDecimal(((DbDataReader)sdrreader)[7].ToString());
					productinfo.TaxId = Convert.ToDecimal(((DbDataReader)sdrreader)[8].ToString());
					productinfo.TaxapplicableOn = ((DbDataReader)sdrreader)[9].ToString();
					productinfo.PurchaseRate = Convert.ToDecimal(((DbDataReader)sdrreader)[10].ToString());
					productinfo.SalesRate = Convert.ToDecimal(((DbDataReader)sdrreader)[11].ToString());
					productinfo.Mrp = Convert.ToDecimal(((DbDataReader)sdrreader)[12].ToString());
					productinfo.MinimumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[13].ToString());
					productinfo.MaximumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[14].ToString());
					productinfo.ReorderLevel = Convert.ToDecimal(((DbDataReader)sdrreader)[15].ToString());
					productinfo.GodownId = Convert.ToDecimal(((DbDataReader)sdrreader)[16].ToString());
					productinfo.RackId = Convert.ToDecimal(((DbDataReader)sdrreader)[17].ToString());
					productinfo.IsallowBatch = Convert.ToBoolean(((DbDataReader)sdrreader)[18].ToString());
					productinfo.Ismultipleunit = Convert.ToBoolean(((DbDataReader)sdrreader)[19].ToString());
					productinfo.IsBom = Convert.ToBoolean(((DbDataReader)sdrreader)[20].ToString());
					productinfo.Isopeningstock = Convert.ToBoolean(((DbDataReader)sdrreader)[21].ToString());
					productinfo.Narration = ((DbDataReader)sdrreader)[22].ToString();
					productinfo.IsActive = Convert.ToBoolean(((DbDataReader)sdrreader)[23].ToString());
					productinfo.IsshowRemember = Convert.ToBoolean(((DbDataReader)sdrreader)[24].ToString());
					productinfo.Extra1 = ((DbDataReader)sdrreader)[25].ToString();
					productinfo.Extra2 = ((DbDataReader)sdrreader)[26].ToString();
					productinfo.ExtraDate = PublicVariables._dtCurrentDate;
					productinfo.PartNo = ((DbDataReader)sdrreader)[28].ToString();
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
			return productinfo;
		}

		public decimal BatchIdByPartNoOrBarcode(string strpartNo, string strbarcode)
		{
			decimal decBatchId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductViewByPartNoOrBarcode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
				sprmparam3.Value = strpartNo;
				sprmparam3 = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
				sprmparam3.Value = strbarcode;
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

		public string BarcodeViewByBatchId(decimal decbatchId)
		{
			string strBatchId = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeViewByBatchId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam2.Value = decbatchId;
				if (decbatchId == 0m)
				{
					return strBatchId;
				}
				strBatchId = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strBatchId;
		}

		public DataTable ProductCodeViewAll(ComboBox cmbProductCode, bool Isall)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductCodeViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtbl);
				if (Isall)
				{
					DataRow dr = dtbl.NewRow();
					dr["productId"] = 0;
					dr["productCode"] = "All";
					dtbl.Rows.InsertAt(dr, 0);
				}
				cmbProductCode.DataSource = dtbl;
				cmbProductCode.DisplayMember = "productCode";
				cmbProductCode.ValueMember = "productId";
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

		public ProductInfo ProductViewByName(string strproductName)
		{
			ProductInfo productinfo = new ProductInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductViewByName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam2.Value = strproductName;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					productinfo.ProductId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					productinfo.ProductCode = ((DbDataReader)sdrreader)[1].ToString();
					productinfo.ProductName = ((DbDataReader)sdrreader)[2].ToString();
					productinfo.GroupId = Convert.ToDecimal(((DbDataReader)sdrreader)[3].ToString());
					productinfo.BrandId = Convert.ToDecimal(((DbDataReader)sdrreader)[4].ToString());
					productinfo.UnitId = Convert.ToDecimal(((DbDataReader)sdrreader)[5].ToString());
					productinfo.SizeId = Convert.ToDecimal(((DbDataReader)sdrreader)[6].ToString());
					productinfo.ModelNoId = Convert.ToDecimal(((DbDataReader)sdrreader)[7].ToString());
					productinfo.TaxId = Convert.ToDecimal(((DbDataReader)sdrreader)[8].ToString());
					productinfo.TaxapplicableOn = ((DbDataReader)sdrreader)[9].ToString();
					productinfo.PurchaseRate = Convert.ToDecimal(((DbDataReader)sdrreader)[10].ToString());
					productinfo.SalesRate = Convert.ToDecimal(((DbDataReader)sdrreader)[11].ToString());
					productinfo.Mrp = Convert.ToDecimal(((DbDataReader)sdrreader)[12].ToString());
					productinfo.MinimumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[13].ToString());
					productinfo.MaximumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[14].ToString());
					productinfo.ReorderLevel = Convert.ToDecimal(((DbDataReader)sdrreader)[15].ToString());
					productinfo.GodownId = Convert.ToDecimal(((DbDataReader)sdrreader)[16].ToString());
					productinfo.RackId = Convert.ToDecimal(((DbDataReader)sdrreader)[17].ToString());
					productinfo.IsallowBatch = bool.Parse(((DbDataReader)sdrreader)[18].ToString());
					productinfo.Ismultipleunit = bool.Parse(((DbDataReader)sdrreader)[19].ToString());
					productinfo.IsBom = bool.Parse(((DbDataReader)sdrreader)[20].ToString());
					productinfo.Isopeningstock = bool.Parse(((DbDataReader)sdrreader)[21].ToString());
					productinfo.Narration = ((DbDataReader)sdrreader)[22].ToString();
					productinfo.IsActive = bool.Parse(((DbDataReader)sdrreader)[23].ToString());
					productinfo.IsshowRemember = bool.Parse(((DbDataReader)sdrreader)[24].ToString());
					productinfo.Extra1 = ((DbDataReader)sdrreader)[25].ToString();
					productinfo.Extra2 = ((DbDataReader)sdrreader)[26].ToString();
					productinfo.ExtraDate = PublicVariables._dtCurrentDate;
					productinfo.PartNo = ((DbDataReader)sdrreader)[28].ToString();
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
			return productinfo;
		}

		public DataTable ProductViewAllForComboBox()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAllForComboBox", base.sqlcon);
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

		public ProductInfo ProductViewForStandardRate(decimal decProductId)
		{
			ProductInfo infoProduct = new ProductInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ProductViewForStandardRate", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoProduct.ProductId = Convert.ToDecimal(((DbDataReader)sqldr)["productId"].ToString());
					infoProduct.ProductName = ((DbDataReader)sqldr)["productName"].ToString();
					infoProduct.ProductCode = ((DbDataReader)sqldr)["productCode"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
				sqldr.Close();
			}
			return infoProduct;
		}

		public ProductInfo PriceListPopUpView(decimal decProductId)
		{
			ProductInfo infoProduct = new ProductInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PriceListPopUpView", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoProduct.ProductId = Convert.ToDecimal(((DbDataReader)sqldr)["productId"].ToString());
					infoProduct.ProductName = ((DbDataReader)sqldr)["productName"].ToString();
					infoProduct.ProductCode = ((DbDataReader)sqldr)["productCode"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
				sqldr.Close();
			}
			return infoProduct;
		}

		public DataTable ProductViewAllForBatchByAllowBatch()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAllForBatchByAllowBatch", base.sqlcon);
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

		public void ChangeProductTaxSave(ProductInfo productinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ChangeProductTaxSave", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = productinfo.ProductId;
				sprmparam3 = sccmd.Parameters.Add("@taxId", SqlDbType.VarChar);
				sprmparam3.Value = productinfo.TaxId;
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

		public DataTable ProductRegisterSearch(decimal decGroupId, string strProductName, string strProductCode, decimal decSizeId, decimal decModelNoId, decimal decBrandId, decimal decTaxId, string strTaxApplicabel, decimal decSalseRateFrom, decimal decSalseRateTo, string strActive)
		{
			DataTable dtblProductRegister = new DataTable();
			dtblProductRegister.Columns.Add("SL.NO", typeof(decimal));
			dtblProductRegister.Columns["SL.NO"].AutoIncrement = true;
			dtblProductRegister.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtblProductRegister.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductRegisterSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
				sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
				sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
				sqlda.SelectCommand.Parameters.Add("@taxapplicableOn", SqlDbType.VarChar).Value = strTaxApplicabel;
				sqlda.SelectCommand.Parameters.Add("@salesRateFrom", SqlDbType.Decimal).Value = decSalseRateFrom;
				sqlda.SelectCommand.Parameters.Add("@salesRateTo", SqlDbType.Decimal).Value = decSalseRateTo;
				sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strActive;
				sqlda.Fill(dtblProductRegister);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblProductRegister;
		}

		public DataTable ProductSearchPopupViewAll(string strGroupName, string strProductCode, string strProductName, decimal decSize, decimal decModelNo)
		{
			DataTable dtblProductSearchPopup = new DataTable();
			dtblProductSearchPopup.Columns.Add("SL.NO", typeof(decimal));
			dtblProductSearchPopup.Columns["SL.NO"].AutoIncrement = true;
			dtblProductSearchPopup.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtblProductSearchPopup.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PopupViewAll", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupName", SqlDbType.VarChar).Value = strGroupName;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSize;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNo;
				sqlda.Fill(dtblProductSearchPopup);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblProductSearchPopup;
		}

		public string ProductUnit(decimal decProductId)
		{
			string strUnit = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductUnit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				strUnit = Convert.ToString(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strUnit;
		}

		public DataTable ProductViewGridFillFromBatch(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewGridFillFromBatch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

		public DataTable ProductViewGridFillFromStockPosting(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("ProductViewGridFillFromStockPosting", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
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

		public decimal DeleteProductWithReferenceCheck(decimal ProductId)
		{
			decimal decCheck = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeleteProductWithReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = ProductId;
				decCheck = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decCheck;
		}

		public DataTable ProductViewAllWithoutOneProduct(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAllWithoutOneProduct", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

		public ProductInfo productViewByProductId(decimal decproductId)
		{
			ProductInfo infoproduct = new ProductInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("ProductViewByProductId", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam2 = new SqlParameter();
				sqlparam2 = cmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sqlparam2.Value = decproductId;
				sqldr = cmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoproduct.ProductCode = ((DbDataReader)sqldr)["productCode"].ToString();
					infoproduct.ProductName = ((DbDataReader)sqldr)["productName"].ToString();
					infoproduct.UnitId = Convert.ToDecimal(((DbDataReader)sqldr)["unitId"].ToString());
					infoproduct.GodownId = Convert.ToDecimal(((DbDataReader)sqldr)["godownId"].ToString());
					infoproduct.RackId = Convert.ToDecimal(((DbDataReader)sqldr)["rackId"].ToString());
					infoproduct.IsallowBatch = Convert.ToBoolean(((DbDataReader)sqldr)["isallowBatch"].ToString());
					infoproduct.GroupId = Convert.ToDecimal(((DbDataReader)sqldr)["groupId"].ToString());
					infoproduct.BrandId = Convert.ToDecimal(((DbDataReader)sqldr)["brandId"].ToString());
					infoproduct.Ismultipleunit = Convert.ToBoolean(((DbDataReader)sqldr)["ismultipleunit"].ToString());
					if (((DbDataReader)sqldr)["extraDate"].ToString() != null)
					{
						infoproduct.ExtraDate = Convert.ToDateTime(((DbDataReader)sqldr)["extraDate"].ToString());
					}
					infoproduct.Extra1 = ((DbDataReader)sqldr)["extra1"].ToString();
					infoproduct.Extra2 = ((DbDataReader)sqldr)["extra2"].ToString();
					infoproduct.PartNo = ((DbDataReader)sqldr)["partNo"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("productSp:" + ex.Message.ToString());
			}
			finally
			{
				sqldr.Close();
				base.sqlcon.Close();
			}
			return infoproduct;
		}

		public DataTable ProductNameViewByProductCode(string productCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductNameViewByProductCode", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam2.Value = productCode;
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

		public DataTable ProductCodeAndBarcodeByBatchId(decimal decProductBatchId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductCodeAndBarcodeByBatchId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@BatchId", SqlDbType.VarChar);
				sprmparam2.Value = decProductBatchId;
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

		public DataTable ProductDetailsViewByProductCode(string productCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductDetailsViewByProductCode", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam2.Value = productCode;
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

		public DataTable ProductDetailsCoreespondingToBarcode(string barcode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductDetailsCoreespondingToBarcode", base.sqlcon);
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

		public string ProductCodeViewByProductName(string productName)
		{
			string productCode = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductCodeViewByProductName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam2.Value = productName;
				if (sccmd.ExecuteScalar() != null)
				{
					productCode = sccmd.ExecuteScalar().ToString();
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
			return productCode;
		}

		public decimal SalesInvoiceProductRateForSales(decimal decProductId, DateTime dtdate, decimal decBatchId, decimal decPricingLevelId, decimal decNoofDecplaces)
		{
			decimal decRate = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesInvoiceProductRateForSales", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@productId", SqlDbType.VarChar);
				sprmparam6.Value = decProductId;
				sprmparam6 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam6.Value = dtdate;
				sprmparam6 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam6.Value = decBatchId;
				sprmparam6 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam6.Value = decPricingLevelId;
				sprmparam6 = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
				sprmparam6.Value = decNoofDecplaces;
				decRate = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decRate;
		}

		public DataTable ProductViewsByProductName(string productName)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductViewsByProductName", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam2.Value = productName;
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

		public decimal ProductRateForSales(decimal strProductId, DateTime date, decimal decBatchId, decimal decNoofDecplaces)
		{
			decimal dcRate = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductRateForSales", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam5.Value = strProductId;
				sprmparam5 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam5.Value = date;
				sprmparam5 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam5.Value = decBatchId;
				sprmparam5 = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
				sprmparam5.Value = decNoofDecplaces;
				dcRate = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dcRate;
		}

		public ProductBatchInfo BarcodeViewByProductCode(string strproductCode)
		{
			ProductBatchInfo infoProductBatch = new ProductBatchInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BarcodeViewByProductCode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam2.Value = strproductCode;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					infoProductBatch.Barcode = ((DbDataReader)sdrreader)["barcode"].ToString();
					infoProductBatch.BatchId = Convert.ToDecimal(((DbDataReader)sdrreader)["batchId"].ToString());
					infoProductBatch.ProductId = Convert.ToDecimal(((DbDataReader)sdrreader)["productId"].ToString());
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
			return infoProductBatch;
		}

		public DataTable ProductStatisticsFill(decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId, string strcriteria, string strBatchName)
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
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductStatisticsFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
				sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
				sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
				sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
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

		public DataSet ProductStatisticsReport(decimal decCompanyId, decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId, string strcriteria, string strBatchName)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductStatisticsReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
				sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
				sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
				sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public DataTable ProductSearchForGriddFill(decimal decGodownId, decimal decBrandId, decimal decModelNoId, decimal decRackId, decimal decSizeId, decimal decTaxId, decimal decGroupId, string strIsActive, string strProductCode, string strProductName, string strcriteria, string strBatchName)
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
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductSearchForGriddFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
				sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
				sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
				sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodownId;
				sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal).Value = decRackId;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
				sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strIsActive;
				sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
				sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("PDT:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataSet ProductSearchReport(decimal decCompanyId, decimal decGodownId, decimal decBrandId, decimal decModelNoId, decimal decRackId, decimal decSizeId, decimal decTaxId, decimal decGroupId, string strIsActive, string strProductCode, string strProductName, string strcriteria, string strBatchName)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductSearchReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
				sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
				sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
				sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
				sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodownId;
				sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal).Value = decRackId;
				sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
				sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strIsActive;
				sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
				sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show("PDT:2" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public DataTable ProductFinishedGoodsComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductFinishedGoodsComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("PDT:3" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable RawMaterialsFillForStockJournal(decimal decProductId, decimal decQty)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("RawMaterialsFillForStockJournal", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqlda.SelectCommand.Parameters.Add("@quantity", SqlDbType.Decimal).Value = decQty;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("PDT:4" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable FinishedGoodsFillForStockJournal(decimal decProductId, decimal decQty)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("FinishedGoodsFillForStockJournal", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqlda.SelectCommand.Parameters.Add("@quantity", SqlDbType.Decimal).Value = decQty;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("PDT:5" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable ProductCodeViewAllForBarcodeCodePrinting(ComboBox cmbProductCode, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sda = new SqlDataAdapter("ProductCodeViewAllForBarcodeCodePrinting", base.sqlcon);
				sda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sda.Fill(dtbl);
				if (isAll)
				{
					DataRow dr = dtbl.NewRow();
					dr["productCode"] = "All";
					dr["productId"] = 0;
					dtbl.Rows.InsertAt(dr, 0);
				}
				cmbProductCode.DataSource = dtbl;
				cmbProductCode.DisplayMember = "productCode";
				cmbProductCode.ValueMember = "productId";
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

		public DataTable ProductDetailsForProductSearch(decimal productId)
		{
			ProductInfo productinfo = new ProductInfo();
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sda = new SqlDataAdapter("ProductDetailsForProductSearch", base.sqlcon);
				sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = productId;
				sda.SelectCommand.CommandType = CommandType.StoredProcedure;
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

		public DataTable VoucherWiseProductSearch(decimal decVoucherName, string strVoucherNo, DateTime fromdate, DateTime todate, decimal decGroup, string strProCode, decimal decLedger, string strProductName)
		{
			DataTable dtblProduct = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherWiseProductSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherName;
				sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromdate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = todate;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedger;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroup;
				sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProCode;
				sqlda.SelectCommand.Parameters.Add("@startText", SqlDbType.VarChar).Value = strProductName;
				sqlda.Fill(dtblProduct);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblProduct;
		}

		public bool ProductReferenceCheck(decimal decProductId)
		{
			bool isReferenceExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductReferenceChek", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				isReferenceExist = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isReferenceExist;
		}

		public DataTable ProductCodeViewByProductName(string productName, decimal vouchertypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("productviewbyproductNameforSR", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam3.Value = productName;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam3.Value = vouchertypeId;
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

		public DataTable ProductNameViewByProductCode(string productCode, decimal decProductcode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("productviewbyproductcodeforSR", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam3.Value = productCode;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decProductcode;
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

		public DataTable ProductDetailsCoreespondingToProductCode(string strProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewByCode", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sprmparam2.Value = strProductCode;
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

		public DataTable ProductDetailsCoreespondingToProductName(string strProductName)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewByName", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam2.Value = strProductName;
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

		public decimal BatchReferenceCheckForProductEdit(decimal decProductId)
		{
			decimal decStatus = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchReferenceCheckForProductEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
				decStatus = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStatus;
		}

		public bool PartNoCheckExistence(string strProductCode)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PartNoCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@partNo", SqlDbType.VarChar);
				sprmparam2.Value = strProductCode;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}
	}
}
