using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SizeSP : DBConnection
	{
		public void SizeAdd(SizeInfo sizeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SizeAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam7.Value = sizeinfo.SizeId;
				sprmparam7 = sccmd.Parameters.Add("@size", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Size;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = sizeinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Extra2;
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

		public void SizeEdit(SizeInfo sizeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SizeEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam7.Value = sizeinfo.SizeId;
				sprmparam7 = sccmd.Parameters.Add("@size", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Size;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = sizeinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = sizeinfo.Extra2;
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

		public DataTable SizeViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SizeViewAll", base.sqlcon);
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

		public SizeInfo SizeView(decimal sizeId)
		{
			SizeInfo sizeinfo = new SizeInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SizeView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam2.Value = sizeId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					sizeinfo.SizeId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					sizeinfo.Size = ((DbDataReader)sdrreader)[1].ToString();
					sizeinfo.Narration = ((DbDataReader)sdrreader)[2].ToString();
					sizeinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					sizeinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					sizeinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return sizeinfo;
		}

		public void SizeDelete(decimal SizeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SizeDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam2.Value = SizeId;
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

		public int SizeGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SizeMax", base.sqlcon);
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

		public decimal SizeAdding(SizeInfo infoSize)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SizeAdding", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@size", SqlDbType.VarChar).Value = infoSize.Size;
				sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = infoSize.Narration;
				sqlcmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = infoSize.Extra1;
				sqlcmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = infoSize.Extra2;
				decimal deceffectedrow = Convert.ToDecimal(sqlcmd.ExecuteScalar());
				if (deceffectedrow > 0m)
				{
					return deceffectedrow;
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

		public bool SizeEditing(SizeInfo infoSize)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SizeEditing", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = infoSize.SizeId;
				sqlcmd.Parameters.Add("@size", SqlDbType.VarChar).Value = infoSize.Size;
				sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = infoSize.Narration;
				int ineffectedrow = sqlcmd.ExecuteNonQuery();
				isEdit = (ineffectedrow > 0 && true);
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

		public SizeInfo SizeViewing(decimal decSizeId)
		{
			SizeInfo infoSize = new SizeInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SizeViewing", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoSize.SizeId = decimal.Parse(((DbDataReader)sqldr)["SizeId"].ToString());
					infoSize.Size = ((DbDataReader)sqldr)["Size"].ToString();
					infoSize.Narration = ((DbDataReader)sqldr)["Narration"].ToString();
					infoSize.Extra1 = ((DbDataReader)sqldr)["Extra1"].ToString();
					infoSize.Extra2 = ((DbDataReader)sqldr)["Extra2"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				sqldr.Close();
				base.sqlcon.Close();
			}
			return infoSize;
		}

		public DataTable SizeViewAlling()
		{
			DataTable dtblSize = new DataTable();
			dtblSize.Columns.Add("Sl.No", typeof(decimal));
			dtblSize.Columns["Sl.No"].AutoIncrement = true;
			dtblSize.Columns["Sl.No"].AutoIncrementSeed = 1L;
			dtblSize.Columns["Sl.No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SizeViewAlling", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtblSize);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtblSize;
		}

		public bool SizeNameCheckExistence(string strSizeName, decimal decSizeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SizeNameCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@size", SqlDbType.VarChar);
				sprmparam3.Value = strSizeName;
				sprmparam3 = sqlcmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam3.Value = decSizeId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = decimal.Parse(obj.ToString());
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

		public decimal SizeDeleting(decimal SizeId)
		{
			decimal decId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SizeDeleting", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
				sprmparam2.Value = SizeId;
				decId = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decId;
		}
	}
}
