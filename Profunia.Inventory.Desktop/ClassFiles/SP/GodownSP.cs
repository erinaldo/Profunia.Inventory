using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class GodownSP : DBConnection
	{
		public void GodownAdd(GodownInfo godowninfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.GodownName;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.Extra2;
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

		public void GodownEdit(GodownInfo godowninfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam6.Value = godowninfo.GodownId;
				sprmparam6 = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
				sprmparam6.Value = godowninfo.GodownName;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = godowninfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = godowninfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = godowninfo.Extra2;
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

		public DataTable GodownViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("GodownViewAll", base.sqlcon);
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

		public GodownInfo GodownView(decimal godownId)
		{
			GodownInfo godowninfo = new GodownInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam2.Value = godownId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					godowninfo.GodownId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					godowninfo.GodownName = ((DbDataReader)sdrreader)[1].ToString();
					godowninfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
					godowninfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)[3].ToString());
					godowninfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					godowninfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return godowninfo;
		}

		public void GodownDelete(decimal GodownId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam2.Value = GodownId;
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

		public int GodownGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownMax", base.sqlcon);
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

		public DataTable GodownOnlyViewAll()
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("GodownOnlyViewAll", base.sqlcon);
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

		public decimal GodownAddWithoutSameName(GodownInfo godowninfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownAddWithoutSameName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.GodownName;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = godowninfo.Extra2;
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

		public GodownInfo GodownWithNarrationView(decimal decGodownId)
		{
			GodownInfo godowninfo = new GodownInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownWithNarrationView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam2.Value = decGodownId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					godowninfo.GodownId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					godowninfo.GodownName = ((DbDataReader)sdrreader)[1].ToString();
					godowninfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
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
			return godowninfo;
		}

		public bool GodownCheckIfExist(string strGodownName, decimal strGodownId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("GodownCheckIfExist", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@godownName", SqlDbType.VarChar);
				sprmparam3.Value = strGodownName;
				sprmparam3 = sqlcmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam3.Value = strGodownId;
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

		public bool GodownEditParticularField(GodownInfo godowninfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("godownEditParticularField", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam4.Value = godowninfo.GodownId;
				sprmparam4 = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
				sprmparam4.Value = godowninfo.GodownName;
				sprmparam4 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam4.Value = godowninfo.Narration;
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

		public decimal GodownCheckReferenceAndDelete(decimal decGodownId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("GodownCheckReferenceAndDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam2.Value = decGodownId;
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

		public GodownInfo GodownIdByGodownName(string strGodown)
		{
			GodownInfo godowninfo = new GodownInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
				sprmparam2.Value = strGodown;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					godowninfo.GodownId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
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
			return godowninfo;
		}

		public decimal DefaultGodownIDViewByProductName(string productName)
		{
			decimal godownId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GodownIdViewByProductName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam2.Value = productName;
				godownId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return godownId;
		}
	}
}
