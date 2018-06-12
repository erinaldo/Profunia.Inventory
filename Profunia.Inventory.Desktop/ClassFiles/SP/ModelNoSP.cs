using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ModelNoSP : DBConnection
	{
		public decimal ModelNoAddWithDifferentModelNo(ModelNoInfo modelnoinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ModelNoAddWithDifferentModelNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
				sprmparam5.Value = modelnoinfo.ModelNo;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = modelnoinfo.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = modelnoinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = modelnoinfo.Extra2;
				decimal decWork = Convert.ToDecimal(sccmd.ExecuteScalar());
				if (decWork > 0m)
				{
					return decWork;
				}
				return 0m;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0m;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void ModelNoEdit(ModelNoInfo modelnoinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ModelNoEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam6.Value = modelnoinfo.ModelNoId;
				sprmparam6 = sccmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
				sprmparam6.Value = modelnoinfo.ModelNo;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = modelnoinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = modelnoinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = modelnoinfo.Extra2;
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

		public DataTable ModelNoViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ModelNoViewAll", base.sqlcon);
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

		public ModelNoInfo ModelNoView(decimal modelNoId)
		{
			ModelNoInfo modelnoinfo = new ModelNoInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ModelNoView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam2.Value = modelNoId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					modelnoinfo.ModelNoId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					modelnoinfo.ModelNo = ((DbDataReader)sdrreader)[1].ToString();
					modelnoinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
					modelnoinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)[3].ToString());
					modelnoinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					modelnoinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return modelnoinfo;
		}

		public void ModelNoDelete(decimal ModelNoId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ModelNoDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam2.Value = ModelNoId;
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

		public int ModelNoGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ModelNoMax", base.sqlcon);
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

		public DataTable ModelNoOnlyViewAll()
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ModelNoOnlyViewAll", base.sqlcon);
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

		public ModelNoInfo ModelNoWithNarrationView(decimal decModelNoId)
		{
			ModelNoInfo modelnoinfo = new ModelNoInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ModelNoWithNarrationView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam2.Value = decModelNoId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					modelnoinfo.ModelNoId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					modelnoinfo.ModelNo = ((DbDataReader)sdrreader)[1].ToString();
					modelnoinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
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
			return modelnoinfo;
		}

		public bool ModelCheckIfExist(string strModelNo, decimal decModelNoId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ModelCheckIfExist", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
				sprmparam3.Value = strModelNo;
				sprmparam3 = sqlcmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam3.Value = decModelNoId;
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

		public bool ModelNoEditParticularFeilds(ModelNoInfo modelnoinfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ModelNoEditParticularFeild", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam4.Value = modelnoinfo.ModelNoId;
				sprmparam4 = sccmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
				sprmparam4.Value = modelnoinfo.ModelNo;
				sprmparam4 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam4.Value = modelnoinfo.Narration;
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

		public decimal ModelNoCheckReferenceAndDelete(decimal decModelNoId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ModelNoCheckReferenceAndDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				sprmparam2.Value = decModelNoId;
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
	}
}
