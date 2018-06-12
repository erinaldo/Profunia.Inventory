using System;using Profunia.Inventory.Desktop.ClassFiles.General;
using Profunia.Inventory.Desktop.ClassFiles.Info;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class FieldSP : DBConnection
	{
		public void FieldsAdd(FieldInfo infoField)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("FieldsAdd", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formId", SqlDbType.VarChar).Value = infoField.FormId;
				sqlcmd.Parameters.Add("@fieldName", SqlDbType.VarChar).Value = infoField.FieldName;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Purchers add", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void FieldsEdit(FieldInfo infoField)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("FieldsEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@fieldId", SqlDbType.VarChar).Value = infoField.FieldId;
				sqlcmd.Parameters.Add("@formId", SqlDbType.VarChar).Value = infoField.FormId;
				sqlcmd.Parameters.Add("@fieldName", SqlDbType.VarChar).Value = infoField.FieldName;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Purchers add", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public FieldInfo FieldsView(int fieldId)
		{
			FieldInfo infoField = new FieldInfo();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("FieldsView", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@fieldId", SqlDbType.Int).Value = fieldId;
				SqlDataReader sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoField.FieldId = int.Parse(((DbDataReader)sqldr)["FieldId"].ToString());
					infoField.FormId = int.Parse(((DbDataReader)sqldr)["FormId"].ToString());
					infoField.FieldName = ((DbDataReader)sqldr)["FieldName"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FieldsView", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return infoField;
		}

		public DataTable FieldsViewAll(int FormId)
		{
			DataTable dtblPurchers = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldaPurchers = new SqlDataAdapter("FieldsViewAll", base.sqlcon);
				sqldaPurchers.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqldaPurchers.SelectCommand.Parameters.Add("@formId", SqlDbType.Int).Value = FormId;
				sqldaPurchers.Fill(dtblPurchers);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FieldsViewAll", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblPurchers;
		}

		public void FieldsDelete(int formId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FieldsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@formId", SqlDbType.Int);
				sprmparam2.Value = formId;
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
