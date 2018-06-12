using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class UserSP : DBConnection
	{
		public void UserAdd(UserInfo userinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UserAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
				sprmparam8.Value = userinfo.UserName;
				sprmparam8 = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
				sprmparam8.Value = userinfo.Password;
				sprmparam8 = sccmd.Parameters.Add("@active", SqlDbType.Bit);
				sprmparam8.Value = userinfo.Active;
				sprmparam8 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam8.Value = userinfo.RoleId;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = userinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = userinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = userinfo.Extra2;
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

		public void UserEdit(UserInfo userinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UserEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam9.Value = userinfo.UserId;
				sprmparam9 = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
				sprmparam9.Value = userinfo.UserName;
				sprmparam9 = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
				sprmparam9.Value = userinfo.Password;
				sprmparam9 = sccmd.Parameters.Add("@active", SqlDbType.Bit);
				sprmparam9.Value = userinfo.Active;
				sprmparam9 = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
				sprmparam9.Value = userinfo.RoleId;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = userinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = userinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = userinfo.Extra2;
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

		public DataTable UserViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UserViewAll", base.sqlcon);
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

		public UserInfo UserView(decimal userId)
		{
			UserInfo userinfo = new UserInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UserView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam2.Value = userId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					userinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					userinfo.UserName = ((DbDataReader)sdrreader)[1].ToString();
					userinfo.Password = ((DbDataReader)sdrreader)[2].ToString();
					userinfo.Active = bool.Parse(((DbDataReader)sdrreader)[3].ToString());
					userinfo.RoleId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					userinfo.Narration = ((DbDataReader)sdrreader)[5].ToString();
					userinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
					userinfo.Extra1 = ((DbDataReader)sdrreader)[7].ToString();
					userinfo.Extra2 = ((DbDataReader)sdrreader)[8].ToString();
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
			return userinfo;
		}

		public void UserDelete(decimal UserId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UserDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam2.Value = UserId;
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

		public int UserGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UserMax", base.sqlcon);
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

		public DataTable UserCreationViewAll()
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UserCreationViewAll", base.sqlcon);
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

		public bool UserCreationCheckExistence(decimal decUserId, string strUserName)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("UserCreationCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam3.Value = decUserId;
				sprmparam3 = sqlcmd.Parameters.Add("@userName", SqlDbType.VarChar);
				sprmparam3.Value = strUserName;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public DataTable UserCreationViewForGridFill(string strUserName, string strRole)
		{
			DataTable dtbluser = new DataTable();
			dtbluser.Columns.Add("SL.NO", typeof(decimal));
			dtbluser.Columns["SL.NO"].AutoIncrement = true;
			dtbluser.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbluser.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("UserCreationViewForGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@userName", SqlDbType.VarChar).Value = strUserName;
				sqlda.SelectCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = strRole;
				sqlda.Fill(dtbluser);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbluser;
		}

		public decimal UserCreationReferenceDelete(decimal userId)
		{
			decimal decUser = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UserCreationReferenceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam2.Value = userId;
				decUser = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decUser;
		}

		public string LoginCheck(string strUserName)
		{
			string strPsw = string.Empty;
			object obj2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LoginCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
				sprmparam2.Value = strUserName;
				obj2 = sccmd.ExecuteScalar();
				if (obj2 != null)
				{
					strPsw = sccmd.ExecuteScalar().ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("USP:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strPsw;
		}

		public int GetUserIdAfterLogin(string strUserName, string strPassword)
		{
			int inUserId = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GetUserIdAfterLogin", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
				sprmparam3.Value = strUserName;
				sprmparam3 = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
				sprmparam3.Value = strPassword;
				inUserId = int.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("USP:2" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inUserId;
		}

		public void ChangePasswordEdit(UserInfo userinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ChangePasswordEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam4.Value = userinfo.UserId;
				sprmparam4 = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
				sprmparam4.Value = userinfo.UserName;
				sprmparam4 = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
				sprmparam4.Value = userinfo.Password;
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
