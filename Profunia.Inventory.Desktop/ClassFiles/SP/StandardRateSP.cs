using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class StandardRateSP : DBConnection
	{
		public void StandardRateAdd(StandardRateInfo standardrateinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StandardRateAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
				sprmparam11.Value = standardrateinfo.StandardRateId;
				sprmparam11 = sccmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
				sprmparam11.Value = standardrateinfo.ApplicableFrom;
				sprmparam11 = sccmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
				sprmparam11.Value = standardrateinfo.ApplicableTo;
				sprmparam11 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam11.Value = standardrateinfo.ProductId;
				sprmparam11 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam11.Value = standardrateinfo.UnitId;
				sprmparam11 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam11.Value = standardrateinfo.Rate;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = standardrateinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam11.Value = standardrateinfo.BatchId;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = standardrateinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = standardrateinfo.Extra2;
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

		public void StandardRateEdit(StandardRateInfo standardrateinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StandardRateEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
				sprmparam10.Value = standardrateinfo.StandardRateId;
				sprmparam10 = sccmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
				sprmparam10.Value = standardrateinfo.ApplicableFrom;
				sprmparam10 = sccmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
				sprmparam10.Value = standardrateinfo.ApplicableTo;
				sprmparam10 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam10.Value = standardrateinfo.ProductId;
				sprmparam10 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam10.Value = standardrateinfo.UnitId;
				sprmparam10 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam10.Value = standardrateinfo.BatchId;
				sprmparam10 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam10.Value = standardrateinfo.Rate;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = standardrateinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = standardrateinfo.Extra2;
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

		public DataTable StandardRateViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("StandardRateViewAll", base.sqlcon);
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

		public StandardRateInfo StandardRateView(decimal standardRateId)
		{
			StandardRateInfo standardrateinfo = new StandardRateInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StandardRateView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
				sprmparam2.Value = standardRateId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					standardrateinfo.StandardRateId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					standardrateinfo.ApplicableFrom = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
					standardrateinfo.ApplicableTo = DateTime.Parse(((DbDataReader)sdrreader)[2].ToString());
					standardrateinfo.ProductId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					standardrateinfo.UnitId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					standardrateinfo.BatchId = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					standardrateinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					standardrateinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
					standardrateinfo.Extra1 = ((DbDataReader)sdrreader)[8].ToString();
					standardrateinfo.Extra2 = ((DbDataReader)sdrreader)[9].ToString();
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
			return standardrateinfo;
		}

		public void StandardRateDelete(decimal StandardRateId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StandardRateDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
				sprmparam2.Value = StandardRateId;
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

		public int StandardRateGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StandardRateMax", base.sqlcon);
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

		public decimal StandardRateAddParticularfields(StandardRateInfo standardrateinfo)
		{
			decimal decStandardRateId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StandardRateAddParticularfields", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
				sprmparam9.Value = standardrateinfo.ApplicableFrom;
				sprmparam9 = sccmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
				sprmparam9.Value = standardrateinfo.ApplicableTo;
				sprmparam9 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam9.Value = standardrateinfo.ProductId;
				sprmparam9 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam9.Value = standardrateinfo.UnitId;
				sprmparam9 = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam9.Value = standardrateinfo.BatchId;
				sprmparam9 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam9.Value = standardrateinfo.Rate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = standardrateinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = standardrateinfo.Extra2;
				object ObjStandardRateId = sccmd.ExecuteScalar();
				decStandardRateId = ((ObjStandardRateId == null) ? 0m : Convert.ToDecimal(ObjStandardRateId.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStandardRateId;
		}

		public bool StandardrateCheckExistence(decimal decstandardRateId, DateTime dtapplicableFrom, DateTime dtapplicableTo, decimal decProductId, decimal decBatchId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("StandardrateCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sqlcmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
				sprmparam6.Value = decstandardRateId;
				sprmparam6 = sqlcmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
				sprmparam6.Value = dtapplicableFrom;
				sprmparam6 = sqlcmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
				sprmparam6.Value = dtapplicableTo;
				sprmparam6 = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam6.Value = decProductId;
				sprmparam6 = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
				sprmparam6.Value = decBatchId;
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

		public DataTable StandardRateGridFill(decimal decProductId)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("StandardRateGridFill", base.sqlcon);
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
	}
}
