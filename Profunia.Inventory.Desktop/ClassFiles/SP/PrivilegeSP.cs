using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PrivilegeSP : DBConnection
	{
		public void PrivilegeAdd(PrivilegeInfo privilegeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PrivilegeAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@formName", SqlDbType.VarChar);
				sprmparam6.Value = privilegeinfo.FormName;
				sprmparam6 = sccmd.Parameters.Add("@action", SqlDbType.VarChar);
				sprmparam6.Value = privilegeinfo.Action;
				sprmparam6 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam6.Value = privilegeinfo.RoleId;
				sprmparam6 = sccmd.Parameters.Add("@exatra1", SqlDbType.VarChar);
				sprmparam6.Value = privilegeinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = privilegeinfo.Extra2;
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

		public void PrivilegeEdit(PrivilegeInfo privilegeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PrivilegeEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam8.Value = privilegeinfo.PrivilegeId;
				sprmparam8 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam8.Value = privilegeinfo.UserId;
				sprmparam8 = sccmd.Parameters.Add("@formName", SqlDbType.VarChar);
				sprmparam8.Value = privilegeinfo.FormName;
				sprmparam8 = sccmd.Parameters.Add("@action", SqlDbType.VarChar);
				sprmparam8.Value = privilegeinfo.Action;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = privilegeinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@exatra1", SqlDbType.VarChar);
				sprmparam8.Value = privilegeinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = privilegeinfo.Extra2;
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

		public DataTable PrivilegeViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PrivilegeViewAll", base.sqlcon);
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

		public PrivilegeInfo PrivilegeView(decimal decRoleId)
		{
			PrivilegeInfo privilegeinfo = new PrivilegeInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PrivilegeView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam2.Value = decRoleId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					privilegeinfo.PrivilegeId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					privilegeinfo.FormName = ((DbDataReader)sdrreader)[1].ToString();
					privilegeinfo.Action = ((DbDataReader)sdrreader)[2].ToString();
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
			return privilegeinfo;
		}

		public void PrivilegeDelete(decimal PrivilegeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PrivilegeDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@privilegeId", SqlDbType.Decimal);
				sprmparam2.Value = PrivilegeId;
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

		public int PrivilegeGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PrivilegeMax", base.sqlcon);
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

		public bool PrivilegeCheck(decimal userId, string formName, string action)
		{
			bool isCheck = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlCmd = new SqlCommand("PrivilegeCheck", base.sqlcon);
				sqlCmd.CommandType = CommandType.StoredProcedure;
				sqlCmd.Parameters.Add("@userId", SqlDbType.Decimal).Value = userId;
				sqlCmd.Parameters.Add("@formName", SqlDbType.VarChar).Value = formName;
				sqlCmd.Parameters.Add("@action", SqlDbType.VarChar).Value = action;
				object obj = sqlCmd.ExecuteScalar();
				isCheck = (obj != null && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isCheck;
		}

		public DataTable PrivilegeSettingsSearch(decimal decRoleId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PrivilegeSettingsSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@roleId", SqlDbType.Decimal).Value = decRoleId;
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

		public DataTable PrivilegeActionSearch(string strAction, decimal decRoleId)
		{
			DataTable dtblAction = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PrivilegeActionSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@formName", SqlDbType.VarChar).Value = strAction;
				sdaadapter.SelectCommand.Parameters.Add("@roleId", SqlDbType.VarChar).Value = decRoleId;
				sdaadapter.Fill(dtblAction);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblAction;
		}

		public void PrivilegeDeleteTabel(decimal RoleId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PrivilegeDeleteTable", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam2.Value = RoleId;
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

		public bool RolePrivilegeSaveCheckExistence(decimal decRoleId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("RolePrivilegeSaveCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam2.Value = decRoleId;
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
