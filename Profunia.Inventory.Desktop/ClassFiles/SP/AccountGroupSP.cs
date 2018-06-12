using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class AccountGroupSP : DBConnection
	{
		public void AccountGroupAdd(AccountGroupInfo accountgroupinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam11.Value = accountgroupinfo.AccountGroupId;
				sprmparam11 = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.AccountGroupName;
				sprmparam11 = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
				sprmparam11.Value = accountgroupinfo.GroupUnder;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Narration;
				sprmparam11 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam11.Value = accountgroupinfo.IsDefault;
				sprmparam11 = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Nature;
				sprmparam11 = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.Bit);
				sprmparam11.Value = accountgroupinfo.AffectGrossProfit;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = accountgroupinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Extra2;
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

		public void AccountGroupEdit(AccountGroupInfo accountgroupinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam11.Value = accountgroupinfo.AccountGroupId;
				sprmparam11 = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.AccountGroupName;
				sprmparam11 = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
				sprmparam11.Value = accountgroupinfo.GroupUnder;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Narration;
				sprmparam11 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam11.Value = accountgroupinfo.IsDefault;
				sprmparam11 = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Nature;
				sprmparam11 = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.Bit);
				sprmparam11.Value = accountgroupinfo.AffectGrossProfit;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = accountgroupinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = accountgroupinfo.Extra2;
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

		public DataTable AccountGroupViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountGroupViewAll", base.sqlcon);
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

		public AccountGroupInfo AccountGroupView(decimal accountGroupId)
		{
			AccountGroupInfo accountgroupinfo = new AccountGroupInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam2.Value = accountGroupId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					accountgroupinfo.AccountGroupId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					accountgroupinfo.AccountGroupName = ((DbDataReader)sdrreader)[1].ToString();
					accountgroupinfo.GroupUnder = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					accountgroupinfo.Narration = ((DbDataReader)sdrreader)[3].ToString();
					accountgroupinfo.IsDefault = bool.Parse(((DbDataReader)sdrreader)[4].ToString());
					accountgroupinfo.Nature = ((DbDataReader)sdrreader)[5].ToString();
					accountgroupinfo.AffectGrossProfit = ((DbDataReader)sdrreader)[6].ToString();
					accountgroupinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
					accountgroupinfo.Extra1 = ((DbDataReader)sdrreader)[8].ToString();
					accountgroupinfo.Extra2 = ((DbDataReader)sdrreader)[9].ToString();
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
			return accountgroupinfo;
		}

		public DataTable AccountGroupWiseReportForProfitAndLossLedger(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
				SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupWiseReportForProfitAndLossLedger", base.sqlcon);
				sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam4 = new SqlParameter();
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sqlparam4.Value = decAccountGroupId;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmFromDate;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmToDate;
				sqldadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AG:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public void AccountGroupDelete(decimal AccountGroupId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam2.Value = AccountGroupId;
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

		public decimal AccountGroupAddWithIdentity(AccountGroupInfo accountgroupinfo)
		{
			decimal decAccountGroupId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupAddWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
				sprmparam9.Value = accountgroupinfo.AccountGroupName;
				sprmparam9 = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
				sprmparam9.Value = accountgroupinfo.GroupUnder;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = accountgroupinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam9.Value = accountgroupinfo.IsDefault;
				sprmparam9 = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
				sprmparam9.Value = accountgroupinfo.Nature;
				sprmparam9 = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.VarChar);
				sprmparam9.Value = accountgroupinfo.AffectGrossProfit;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = accountgroupinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = accountgroupinfo.Extra2;
				object obj = sccmd.ExecuteScalar();
				decAccountGroupId = ((obj == null) ? 0m : decimal.Parse(obj.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decAccountGroupId;
		}

		public DataTable AccountGroupViewAllComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountGroupViewAllComboFill", base.sqlcon);
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

		public AccountGroupInfo AccountGroupViewForUpdate(decimal decAccountGroupId)
		{
			AccountGroupInfo accountgroupinfo = new AccountGroupInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupViewForUpdate", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
				sqldr = sccmd.ExecuteReader();
				while (sqldr.Read())
				{
					accountgroupinfo.AccountGroupId = decimal.Parse(((DbDataReader)sqldr)["accountGroupId"].ToString());
					accountgroupinfo.AccountGroupName = ((DbDataReader)sqldr)["accountGroupName"].ToString();
					accountgroupinfo.GroupUnder = decimal.Parse(((DbDataReader)sqldr)["groupUnder"].ToString());
					accountgroupinfo.Narration = ((DbDataReader)sqldr)["narration"].ToString();
					accountgroupinfo.IsDefault = bool.Parse(((DbDataReader)sqldr)["isDefault"].ToString());
					accountgroupinfo.Nature = ((DbDataReader)sqldr)["nature"].ToString();
					accountgroupinfo.AffectGrossProfit = ((DbDataReader)sqldr)["affectGrossProfit"].ToString();
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
			return accountgroupinfo;
		}

		public bool AccountGroupCheckExistence(string strAccountGroupName, decimal decAccountGroupId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("AccountGroupCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
				sprmparam3.Value = strAccountGroupName;
				sprmparam3 = sqlcmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam3.Value = decAccountGroupId;
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

		public bool AccountGroupUpdate(AccountGroupInfo accountgroupinfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam10.Value = accountgroupinfo.AccountGroupId;
				sprmparam10 = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
				sprmparam10.Value = accountgroupinfo.AccountGroupName;
				sprmparam10 = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
				sprmparam10.Value = accountgroupinfo.GroupUnder;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = accountgroupinfo.Narration;
				sprmparam10 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam10.Value = accountgroupinfo.IsDefault;
				sprmparam10 = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
				sprmparam10.Value = accountgroupinfo.Nature;
				sprmparam10 = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.VarChar);
				sprmparam10.Value = accountgroupinfo.AffectGrossProfit;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = accountgroupinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = accountgroupinfo.Extra2;
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

		public DataTable AccountGroupSearch(string strAccountGroupName, string strGroupUnder)
		{
			DataTable dtblAccountGroup = new DataTable();
			dtblAccountGroup.Columns.Add("Sl No", typeof(int));
			dtblAccountGroup.Columns["Sl No"].AutoIncrement = true;
			dtblAccountGroup.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtblAccountGroup.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountGroupSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@AccountGroupName", SqlDbType.VarChar).Value = strAccountGroupName;
				sqlda.SelectCommand.Parameters.Add("@Under", SqlDbType.VarChar).Value = strGroupUnder;
				sqlda.Fill(dtblAccountGroup);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblAccountGroup;
		}

		public bool AccountGroupCheckExistenceOfUnderGroup(decimal decAccountGroupId)
		{
			bool isDelete = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("AccountGroupCheckExistenceOfUnderGroup", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isDelete = true;
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
			return isDelete;
		}

		public DataTable AccountGroupViewAllComboFillForAccountLedger()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountGroupViewAllComboFillForAccountLedger", base.sqlcon);
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

		public string MultipleAccountLedgerCrOrDr(string strAccountGroup)
		{
			string strNature = string.Empty;
			try
			{
				SqlDataReader sqlDr2 = null;
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlCmd = new SqlCommand("MultipleAccountLedgerCrOrDr ", base.sqlcon);
				sqlCmd.CommandType = CommandType.StoredProcedure;
				sqlCmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = strAccountGroup;
				sqlDr2 = sqlCmd.ExecuteReader();
				while (sqlDr2.Read())
				{
					strNature = ((DbDataReader)sqlDr2)["nature"].ToString();
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
			return strNature;
		}

		public DataTable CheckWheatherLedgerUnderCash()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CheckWheatherLedgerUnderCash", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AGSP :1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public decimal AccountGroupReferenceDelete(decimal AccountGroupId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupReferenceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam2.Value = AccountGroupId;
				decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
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

		public bool AccountGroupwithLedgerId(decimal decLedgerId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupwithLedgerId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = decLedgerId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isExist = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("AGSP :2" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public DataTable AccountGroupViewAllByGroupUnder(decimal decaccountGroupId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupViewAllByGroupUnder", base.sqlcon);
				sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam2 = new SqlParameter();
				sqlparam2 = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sqlparam2.Value = decaccountGroupId;
				sqldadapter.Fill(dtbl);
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

		public DataTable AccountGroupReportFill(DateTime dtmFromDate, DateTime dtmToDate)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupReportViewAll", base.sqlcon);
				sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam3 = new SqlParameter();
				sqlparam3 = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparam3.Value = dtmFromDate;
				sqlparam3 = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparam3.Value = dtmToDate;
				sqldadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AGSP :3" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable AccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
				SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupWiseReportViewAll", base.sqlcon);
				sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam4 = new SqlParameter();
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sqlparam4.Value = decAccountGroupId;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmFromDate;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmToDate;
				sqldadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AGSP :4" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable CashflowAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
				SqlDataAdapter sqldadapter = new SqlDataAdapter("CashFlowCommen", base.sqlcon);
				sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam4 = new SqlParameter();
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sqlparam4.Value = decAccountGroupId;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmFromDate;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmToDate;
				sqldadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AGSP :5" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable CashInflowLoansAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
				SqlDataAdapter sqldadapter = new SqlDataAdapter("CashInflowLoansLiablity", base.sqlcon);
				sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam4 = new SqlParameter();
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sqlparam4.Value = decAccountGroupId;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmFromDate;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmToDate;
				sqldadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AGSP :6" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable CashOutflowCurrentAssetAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
				SqlDataAdapter sqldadapter = new SqlDataAdapter("CashOutflowCurrentAsset", base.sqlcon);
				sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam4 = new SqlParameter();
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sqlparam4.Value = decAccountGroupId;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmFromDate;
				sqlparam4 = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparam4.Value = dtmToDate;
				sqldadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AGSP :7" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable GroupNameViewForComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("GroupNameViewForComboFill", base.sqlcon);
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

		public DataSet CashBankBookPrinting(decimal decCompanyId, DateTime fromDate, DateTime toDate, bool openingBalance)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("CashBankBookPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam5.Value = decCompanyId;
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam5.Value = fromDate;
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam5.Value = toDate;
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@isShowOpeningBalance", SqlDbType.Bit);
				sprmparam5.Value = openingBalance;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public DataTable BillAllocationAccountGroupFill(ComboBox cmbAccountGroup, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BillAllocationAccountGroupFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtbl);
				if (isAll)
				{
					DataRow dr = dtbl.NewRow();
					dr["accountGroupName"] = "All";
					dr["accountGroupId"] = 0;
					dtbl.Rows.InsertAt(dr, 0);
				}
				cmbAccountGroup.DataSource = dtbl;
				cmbAccountGroup.DisplayMember = "accountGroupName";
				cmbAccountGroup.ValueMember = "accountGroupId";
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

		public string AccountGroupNatureUnderGroup(decimal decAccountGroupId)
		{
			string strNature = string.Empty;
			try
			{
				SqlDataReader sqlDr2 = null;
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlCmd = new SqlCommand("AccountGroupNatureUnderGroup ", base.sqlcon);
				sqlCmd.CommandType = CommandType.StoredProcedure;
				sqlCmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
				sqlDr2 = sqlCmd.ExecuteReader();
				while (sqlDr2.Read())
				{
					strNature = ((DbDataReader)sqlDr2)["nature"].ToString();
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
			return strNature;
		}
	}
}
