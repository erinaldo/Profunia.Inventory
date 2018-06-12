using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class FormSP : DBConnection
	{
		public int FormAdd(FormInfo infoForm)
		{
			int retunvalue = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("FormAdd", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formName", SqlDbType.VarChar).Value = infoForm.FormName;
				retunvalue = int.Parse(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FormAdd", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return retunvalue;
		}

		public bool FormEdit(FormInfo infoForm)
		{
			bool isOk = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("FormEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formId", SqlDbType.VarChar).Value = infoForm.FormId;
				sqlcmd.Parameters.Add("@formName", SqlDbType.VarChar).Value = infoForm.FormName;
				isOk = bool.Parse(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FormEdit", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isOk;
		}

		public void FormEditFull(FormInfo infoForm)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("FormEditFull", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formId", SqlDbType.VarChar).Value = infoForm.FormId;
				sqlcmd.Parameters.Add("@formName", SqlDbType.VarChar).Value = infoForm.FormName;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FormEditFull", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public FormInfo FormView(int formId)
		{
			FormInfo infoForm = new FormInfo();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("FormView", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formId", SqlDbType.Int).Value = formId;
				SqlDataReader sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoForm.FormId = int.Parse(((DbDataReader)sqldr)["formId"].ToString());
					infoForm.FormName = ((DbDataReader)sqldr)["formName"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FormView", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return infoForm;
		}

		public DataTable FormViewAll()
		{
			DataTable dtblPurchers = new DataTable();
			try
			{
				dtblPurchers.Columns.Add("slNo", typeof(int));
				dtblPurchers.Columns["slNo"].AutoIncrement = true;
				dtblPurchers.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblPurchers.Columns["slNo"].AutoIncrementStep = 1L;
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldaPurchers = new SqlDataAdapter("FormViewAll", base.sqlcon);
				sqldaPurchers.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqldaPurchers.Fill(dtblPurchers);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FormViewAll", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblPurchers;
		}

		public bool FormDelete(int formId)
		{
			bool isOk = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FormDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@formId", SqlDbType.Int);
				sprmparam2.Value = formId;
				isOk = bool.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "FormDelete");
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isOk;
		}
	}
}
