using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PricingLevelSP : DBConnection
	{
		public void PricingLevelAdd(PricingLevelInfo pricinglevelinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam6.Value = pricinglevelinfo.PricinglevelId;
				sprmparam6 = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.PricinglevelName;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.Extra2;
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

		public void PricingLevelEdit(PricingLevelInfo pricinglevelinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam6.Value = pricinglevelinfo.PricinglevelId;
				sprmparam6 = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.PricinglevelName;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = pricinglevelinfo.Extra2;
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

		public DataTable PricingLevelViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PricingLevelViewAll", base.sqlcon);
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

		public PricingLevelInfo PricingLevelView(decimal pricinglevelId)
		{
			PricingLevelInfo pricinglevelinfo = new PricingLevelInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam2.Value = pricinglevelId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					pricinglevelinfo.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					pricinglevelinfo.PricinglevelName = ((DbDataReader)sdrreader)[1].ToString();
					pricinglevelinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
					pricinglevelinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					pricinglevelinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return pricinglevelinfo;
		}

		public void PricingLevelDelete(decimal PricinglevelId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam2.Value = PricinglevelId;
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

		public int PricingLevelGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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

		public decimal PricingLevelAddWithoutSamePricingLevel(PricingLevelInfo pricinglevelinfo)
		{
			decimal decPricingLevelId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelAddWithoutSamePricingLevel", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
				sprmparam5.Value = pricinglevelinfo.PricinglevelName;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = pricinglevelinfo.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = pricinglevelinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = pricinglevelinfo.Extra2;
				object obj = sccmd.ExecuteScalar();
				decPricingLevelId = ((obj == null) ? 0m : Convert.ToDecimal(obj.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decPricingLevelId;
		}

		public DataTable PricingLevelOnlyViewAll()
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PricingLevelOnlyViewAll", base.sqlcon);
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

		public PricingLevelInfo PricingLevelWithNarrationView(decimal decPricinglevelId)
		{
			PricingLevelInfo pricinglevelinfo = new PricingLevelInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelWithNarrationView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam2.Value = decPricinglevelId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					pricinglevelinfo.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					pricinglevelinfo.PricinglevelName = ((DbDataReader)sdrreader)[1].ToString();
					pricinglevelinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
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
			return pricinglevelinfo;
		}

		public bool PricingLevelCheckIfExist(string strPricingLevelName, decimal decPricingLevelId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PricingLevelCheckIfExist", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
				sprmparam3.Value = strPricingLevelName;
				sprmparam3 = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam3.Value = decPricingLevelId;
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

		public bool PricingLevelEditParticularFields(PricingLevelInfo pricinglevelinfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PricingLevelEditParticularField", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam4.Value = pricinglevelinfo.PricinglevelId;
				sprmparam4 = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
				sprmparam4.Value = pricinglevelinfo.PricinglevelName;
				sprmparam4 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam4.Value = pricinglevelinfo.Narration;
				int inAffectedRows = sccmd.ExecuteNonQuery();
				isEdit = (inAffectedRows > 0 && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public DataTable PricelistPricingLevelViewAllForComboBox()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PricelistPricingLevelViewAllForComboBox", base.sqlcon);
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

		public decimal PricingLevelCheckReferenceAndDelete(decimal decPricingLevelId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PricingLevelCheckReferenceAndDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam2.Value = decPricingLevelId;
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

		public PricingLevelInfo PricingLevelNameViewForPriceListPopUp(decimal decPricingLevel, decimal decProductId, decimal decUnitId)
		{
			PricingLevelInfo infoPricingLevel = new PricingLevelInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PricingLevelNameViewForPriceListPopUp", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decPricingLevel;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqlcmd.Parameters.Add("@unitId", SqlDbType.Decimal).Value = decUnitId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoPricingLevel.PricinglevelId = Convert.ToDecimal(((DbDataReader)sqldr)["pricinglevelId"].ToString());
					infoPricingLevel.PricinglevelName = ((DbDataReader)sqldr)["pricinglevelName"].ToString();
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
			return infoPricingLevel;
		}
	}
}
