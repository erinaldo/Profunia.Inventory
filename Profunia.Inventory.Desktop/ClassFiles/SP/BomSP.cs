using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BomSP : DBConnection
	{
		public void BomAdd(BomInfo bominfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.ProductId;
				sprmparam8 = sccmd.Parameters.Add("@rowmaterialId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.RowmaterialId;
				sprmparam8 = sccmd.Parameters.Add("@quantity", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.Quantity;
				sprmparam8 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.UnitId;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = bominfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = bominfo.Extra2;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = bominfo.ExtraDate;
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

		public void BomFromDatatable(BomInfo bominfo, decimal decId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomFromDatatable", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam8.Value = decId;
				sprmparam8 = sccmd.Parameters.Add("@rowmaterialId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.RowmaterialId;
				sprmparam8 = sccmd.Parameters.Add("@quantity", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.Quantity;
				sprmparam8 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.UnitId;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = bominfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = bominfo.Extra2;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = bominfo.ExtraDate;
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

		public void BomEdit(BomInfo bominfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.ProductId;
				sprmparam8 = sccmd.Parameters.Add("@rowmaterialId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.RowmaterialId;
				sprmparam8 = sccmd.Parameters.Add("@quantity", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.Quantity;
				sprmparam8 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam8.Value = bominfo.UnitId;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = bominfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = bominfo.Extra2;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = bominfo.ExtraDate;
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

		public DataTable BomViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BomViewAll", base.sqlcon);
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

		public BomInfo BomView(decimal bomId)
		{
			BomInfo bominfo = new BomInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@bomId", SqlDbType.Decimal);
				sprmparam2.Value = bomId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					bominfo.BomId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					bominfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					bominfo.RowmaterialId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					bominfo.Quantity = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					bominfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					bominfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					bominfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
					bominfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
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
			return bominfo;
		}

		public void BomDelete(decimal BomId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@bomId", SqlDbType.Decimal);
				sprmparam2.Value = BomId;
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

		public int BomGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomMax", base.sqlcon);
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

		public DataTable ProduBomForEdit(decimal deProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("ProduBomForEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = deProductId;
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

		public decimal BomDeleteForUpdation(decimal decProduciId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomDeleteForUpdation", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProduciId;
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
			return decResult;
		}

		public decimal BomRemoveRow(decimal decBomId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomRemoveRow", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@bomId", SqlDbType.Decimal);
				sprmparam2.Value = decBomId;
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
			return decResult;
		}

		public decimal BomRemoveRows(decimal decBomId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BomRemoveRows", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@bomId", SqlDbType.Decimal);
				sprmparam2.Value = decBomId;
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
			return decResult;
		}

		public void UpdateBom(BomInfo bominfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UpdateBom", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@bomId", SqlDbType.Decimal);
				sprmparam9.Value = bominfo.BomId;
				sprmparam9 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam9.Value = bominfo.ProductId;
				sprmparam9 = sccmd.Parameters.Add("@rowmaterialId", SqlDbType.Decimal);
				sprmparam9.Value = bominfo.RowmaterialId;
				sprmparam9 = sccmd.Parameters.Add("@quantity", SqlDbType.Decimal);
				sprmparam9.Value = bominfo.Quantity;
				sprmparam9 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam9.Value = bominfo.UnitId;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = bominfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = bominfo.Extra2;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = bominfo.ExtraDate;
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
