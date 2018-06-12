using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class RoleSP : DBConnection
	{
		public decimal RoleAdd(RoleInfo infoRole)
		{
			decimal decRoleIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RoleAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@role", SqlDbType.VarChar);
				sprmparam5.Value = infoRole.Role;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = infoRole.Narration;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = infoRole.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = infoRole.Extra2;
				decRoleIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decRoleIdentity;
		}

		public void RoleEdit(RoleInfo infoRole)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RoleEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam6.Value = infoRole.RoleId;
				sprmparam6 = sccmd.Parameters.Add("@role", SqlDbType.VarChar);
				sprmparam6.Value = infoRole.Role;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = infoRole.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = infoRole.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = infoRole.Extra2;
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

		public DataTable RoleViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RoleViewAll", base.sqlcon);
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

		public RoleInfo RoleView(decimal roleId)
		{
			RoleInfo infoRole = new RoleInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RoleView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam2.Value = roleId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					infoRole.RoleId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					infoRole.Role = ((DbDataReader)sdrreader)[1].ToString();
					infoRole.Narration = ((DbDataReader)sdrreader)[2].ToString();
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
			return infoRole;
		}

		public DataTable RoleViewGridFill()
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RoleViewAll", base.sqlcon);
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

		public decimal RoleReferenceDelete(decimal RoleId)
		{
			decimal decRole = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RoleReferenceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam2.Value = RoleId;
				decRole = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decRole;
		}

		public bool RoleCheckExistence(decimal decRoleId, string strRole)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("RoleCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam3.Value = decRoleId;
				sprmparam3 = sqlcmd.Parameters.Add("@role", SqlDbType.VarChar);
				sprmparam3.Value = strRole;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isEdit = true;
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
			return isEdit;
		}
	}
}
