using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DetailsSP : DBConnection
	{
		public int DetailsAdd(DetailsInfo infoDetails)
		{
			int retunvalue = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DetailsAdd", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = infoDetails.MasterId;
				sqlcmd.Parameters.Add("@name", SqlDbType.VarChar).Value = infoDetails.Name;
				sqlcmd.Parameters.Add("@text", SqlDbType.VarChar).Value = infoDetails.Text;
				sqlcmd.Parameters.Add("@row", SqlDbType.Int).Value = infoDetails.Row;
				sqlcmd.Parameters.Add("@columns", SqlDbType.Int).Value = infoDetails.Columns;
				sqlcmd.Parameters.Add("@width", SqlDbType.Int).Value = infoDetails.Width;
				sqlcmd.Parameters.Add("@dbf", SqlDbType.VarChar).Value = infoDetails.DBF;
				sqlcmd.Parameters.Add("@DorH", SqlDbType.VarChar).Value = infoDetails.DorH;
				sqlcmd.Parameters.Add("@repeat", SqlDbType.VarChar).Value = infoDetails.Repeat;
				sqlcmd.Parameters.Add("@align", SqlDbType.VarChar).Value = infoDetails.Align;
				sqlcmd.Parameters.Add("@repeatAll", SqlDbType.VarChar).Value = infoDetails.RepeatAll;
				sqlcmd.Parameters.Add("@footerRepeatAll", SqlDbType.VarChar).Value = infoDetails.FooterRepeatAll;
				sqlcmd.Parameters.Add("@textWrap", SqlDbType.VarChar).Value = infoDetails.TextWrap;
				sqlcmd.Parameters.Add("@wrapLineCount", SqlDbType.VarChar).Value = infoDetails.WrapLineCount;
				sqlcmd.Parameters.Add("@fieldsForExtra", SqlDbType.VarChar).Value = infoDetails.FieldsForExtra;
				sqlcmd.Parameters.Add("@extraFieldName", SqlDbType.VarChar).Value = infoDetails.ExtraFieldName;
				retunvalue = int.Parse(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "DetailsAdd", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return retunvalue;
		}

		public int DetailsCopyAdd(DetailsInfo infoDetails)
		{
			int retunvalue = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DetailsCopyAdd", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = infoDetails.MasterId;
				sqlcmd.Parameters.Add("@name", SqlDbType.VarChar).Value = infoDetails.Name;
				sqlcmd.Parameters.Add("@text", SqlDbType.VarChar).Value = infoDetails.Text;
				sqlcmd.Parameters.Add("@row", SqlDbType.Int).Value = infoDetails.Row;
				sqlcmd.Parameters.Add("@columns", SqlDbType.Int).Value = infoDetails.Columns;
				sqlcmd.Parameters.Add("@width", SqlDbType.Int).Value = infoDetails.Width;
				sqlcmd.Parameters.Add("@dbf", SqlDbType.VarChar).Value = infoDetails.DBF;
				sqlcmd.Parameters.Add("@DorH", SqlDbType.VarChar).Value = infoDetails.DorH;
				sqlcmd.Parameters.Add("@repeat", SqlDbType.VarChar).Value = infoDetails.Repeat;
				sqlcmd.Parameters.Add("@align", SqlDbType.VarChar).Value = infoDetails.Align;
				sqlcmd.Parameters.Add("@repeatAll", SqlDbType.VarChar).Value = infoDetails.RepeatAll;
				sqlcmd.Parameters.Add("@footerRepeatAll", SqlDbType.VarChar).Value = infoDetails.FooterRepeatAll;
				sqlcmd.Parameters.Add("@textWrap", SqlDbType.VarChar).Value = infoDetails.TextWrap;
				sqlcmd.Parameters.Add("@wrapLineCount", SqlDbType.VarChar).Value = infoDetails.WrapLineCount;
				sqlcmd.Parameters.Add("@fieldsForExtra", SqlDbType.VarChar).Value = infoDetails.FieldsForExtra;
				sqlcmd.Parameters.Add("@extraFieldName", SqlDbType.VarChar).Value = infoDetails.ExtraFieldName;
				retunvalue = int.Parse(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "DetailsCopyAdd", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return retunvalue;
		}

		public void DetailsEdit(DetailsInfo infoDetails)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DetailsEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@detailsId", SqlDbType.Int).Value = infoDetails.DetailsId;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = infoDetails.MasterId;
				sqlcmd.Parameters.Add("@name", SqlDbType.VarChar).Value = infoDetails.Name;
				sqlcmd.Parameters.Add("@text", SqlDbType.Bit).Value = infoDetails.Text;
				sqlcmd.Parameters.Add("@row", SqlDbType.Bit).Value = infoDetails.Row;
				sqlcmd.Parameters.Add("@columns", SqlDbType.Int).Value = infoDetails.Columns;
				sqlcmd.Parameters.Add("@width", SqlDbType.Int).Value = infoDetails.Width;
				sqlcmd.Parameters.Add("@dbf", SqlDbType.Int).Value = infoDetails.DBF;
				sqlcmd.Parameters.Add("@DorH", SqlDbType.VarChar).Value = infoDetails.DorH;
				sqlcmd.Parameters.Add("@repeat", SqlDbType.Int).Value = infoDetails.Repeat;
				sqlcmd.Parameters.Add("@align", SqlDbType.Int).Value = infoDetails.Align;
				sqlcmd.Parameters.Add("@repeatAll", SqlDbType.Int).Value = infoDetails.RepeatAll;
				sqlcmd.Parameters.Add("@footerRepeatAll", SqlDbType.Int).Value = infoDetails.FooterRepeatAll;
				sqlcmd.Parameters.Add("@textWrap", SqlDbType.VarChar).Value = infoDetails.TextWrap;
				sqlcmd.Parameters.Add("@wrapLineCount", SqlDbType.VarChar).Value = infoDetails.WrapLineCount;
				sqlcmd.Parameters.Add("@fieldsForExtra", SqlDbType.VarChar).Value = infoDetails.FieldsForExtra;
				sqlcmd.Parameters.Add("@extraFieldName", SqlDbType.VarChar).Value = infoDetails.ExtraFieldName;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "DetailsEdit", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable DetailsViewAll(int MasterId)
		{
			DataTable dtblPurchers = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldaPurchers = new SqlDataAdapter("DetailsViewAll", base.sqlcon);
				sqldaPurchers.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqldaPurchers.SelectCommand.Parameters.Add("@masterId", SqlDbType.Int).Value = MasterId;
				sqldaPurchers.Fill(dtblPurchers);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "DetailsViewAll", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblPurchers;
		}

		public DataTable DetailsCopyViewAll(int MasterId)
		{
			DataTable dtblPurchers = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldaPurchers = new SqlDataAdapter("DetailsCopyViewAll", base.sqlcon);
				sqldaPurchers.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqldaPurchers.SelectCommand.Parameters.Add("@masterId", SqlDbType.Int).Value = MasterId;
				sqldaPurchers.Fill(dtblPurchers);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "DetailsViewAll", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblPurchers;
		}

		public void DetailsDelete(int masterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
				sprmparam2.Value = masterId;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "DetailsDelete");
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void DetailsCopyDelete(int masterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DetailsCopyDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
				sprmparam2.Value = masterId;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "DetailsCopyDelete");
			}
			finally
			{
				base.sqlcon.Close();
			}
		}
	}
}
