using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class AccountLedgerSP : DBConnection
	{
		public void AccountLedgerAdd(AccountLedgerInfo accountledgerinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam28 = new SqlParameter();
				sprmparam28 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.LedgerId;
				sprmparam28 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.AccountGroupId;
				sprmparam28 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.LedgerName;
				sprmparam28 = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.OpeningBalance;
				sprmparam28 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.CrOrDr;
				sprmparam28 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Narration;
				sprmparam28 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.MailingName;
				sprmparam28 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Address;
				sprmparam28 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Phone;
				sprmparam28 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Mobile;
				sprmparam28 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Email;
				sprmparam28 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam28.Value = accountledgerinfo.CreditPeriod;
				sprmparam28 = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.CreditLimit;
				sprmparam28 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.PricinglevelId;
				sprmparam28 = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
				sprmparam28.Value = accountledgerinfo.BillByBill;
				sprmparam28 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Tin;
				sprmparam28 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Cst;
				sprmparam28 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Pan;
				sprmparam28 = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.RouteId;
				sprmparam28 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.BankAccountNumber;
				sprmparam28 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.BranchName;
				sprmparam28 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.BranchCode;
				sprmparam28 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam28.Value = accountledgerinfo.ExtraDate;
				sprmparam28 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Extra1;
				sprmparam28 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Extra2;
				sprmparam28 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.AreaId;
				sprmparam28 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam28.Value = accountledgerinfo.IsDefault;
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

		public void AccountLedgerEdit(AccountLedgerInfo accountledgerinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam28 = new SqlParameter();
				sprmparam28 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.LedgerId;
				sprmparam28 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.AccountGroupId;
				sprmparam28 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.LedgerName;
				sprmparam28 = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.OpeningBalance;
				sprmparam28 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.CrOrDr;
				sprmparam28 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Narration;
				sprmparam28 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.MailingName;
				sprmparam28 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Address;
				sprmparam28 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Phone;
				sprmparam28 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Mobile;
				sprmparam28 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Email;
				sprmparam28 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam28.Value = accountledgerinfo.CreditPeriod;
				sprmparam28 = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.CreditLimit;
				sprmparam28 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.PricinglevelId;
				sprmparam28 = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
				sprmparam28.Value = accountledgerinfo.BillByBill;
				sprmparam28 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Tin;
				sprmparam28 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Cst;
				sprmparam28 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Pan;
				sprmparam28 = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.RouteId;
				sprmparam28 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.BankAccountNumber;
				sprmparam28 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.BranchName;
				sprmparam28 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.BranchCode;
				sprmparam28 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Extra1;
				sprmparam28 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam28.Value = accountledgerinfo.Extra2;
				sprmparam28 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam28.Value = accountledgerinfo.ExtraDate;
				sprmparam28 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam28.Value = accountledgerinfo.AreaId;
				sprmparam28 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam28.Value = accountledgerinfo.IsDefault;
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

		public DataTable AccountLedgerViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewAll", base.sqlcon);
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

		public DataTable AccountLedgerViewAllForComboBox()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewAllForComboBox", base.sqlcon);
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

		public DataTable AccountLedgerSearchForServiceAccountUnderIncome()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerSearchForServiceAccountUnderIncome", base.sqlcon);
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

		public AccountLedgerInfo AccountLedgerView(decimal ledgerId)
		{
			AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = ledgerId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					accountledgerinfo.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader)["ledgerId"].ToString());
					accountledgerinfo.AccountGroupId = Convert.ToDecimal(((DbDataReader)sdrreader)["accountGroupId"].ToString());
					accountledgerinfo.LedgerName = ((DbDataReader)sdrreader)["ledgerName"].ToString();
					accountledgerinfo.OpeningBalance = Convert.ToDecimal(((DbDataReader)sdrreader)["openingBalance"].ToString());
					accountledgerinfo.CrOrDr = ((DbDataReader)sdrreader)["crOrDr"].ToString();
					accountledgerinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					accountledgerinfo.MailingName = ((DbDataReader)sdrreader)["mailingName"].ToString();
					accountledgerinfo.Address = ((DbDataReader)sdrreader)["address"].ToString();
					accountledgerinfo.Phone = ((DbDataReader)sdrreader)["phone"].ToString();
					accountledgerinfo.Mobile = ((DbDataReader)sdrreader)["mobile"].ToString();
					accountledgerinfo.Email = ((DbDataReader)sdrreader)["email"].ToString();
					accountledgerinfo.CreditPeriod = Convert.ToInt32(((DbDataReader)sdrreader)["creditPeriod"].ToString());
					accountledgerinfo.CreditLimit = Convert.ToDecimal(((DbDataReader)sdrreader)["creditLimit"].ToString());
					accountledgerinfo.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrreader)["pricinglevelId"].ToString());
					accountledgerinfo.BillByBill = Convert.ToBoolean(((DbDataReader)sdrreader)["billByBill"].ToString());
					accountledgerinfo.Tin = ((DbDataReader)sdrreader)["tin"].ToString();
					accountledgerinfo.Cst = ((DbDataReader)sdrreader)["cst"].ToString();
					accountledgerinfo.Pan = ((DbDataReader)sdrreader)["pan"].ToString();
					accountledgerinfo.RouteId = Convert.ToDecimal(((DbDataReader)sdrreader)["routeId"].ToString());
					accountledgerinfo.BankAccountNumber = ((DbDataReader)sdrreader)["bankAccountNumber"].ToString();
					accountledgerinfo.BranchName = ((DbDataReader)sdrreader)["branchName"].ToString();
					accountledgerinfo.BranchCode = ((DbDataReader)sdrreader)["branchCode"].ToString();
					accountledgerinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)["extraDate"].ToString());
					accountledgerinfo.Extra1 = ((DbDataReader)sdrreader)["extra1"].ToString();
					accountledgerinfo.Extra2 = ((DbDataReader)sdrreader)["extra2"].ToString();
					accountledgerinfo.AreaId = Convert.ToDecimal(((DbDataReader)sdrreader)["areaId"].ToString());
					accountledgerinfo.IsDefault = Convert.ToBoolean(((DbDataReader)sdrreader)["isDefault"].ToString());
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
			return accountledgerinfo;
		}

		public void AccountLedgerDelete(decimal LedgerId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = LedgerId;
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

		public int AccountLedgerGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerMax", base.sqlcon);
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

		public decimal AccountLedgerAddWithIdentity(AccountLedgerInfo accountledgerinfo)
		{
			decimal decLedgerId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerAddWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam27 = new SqlParameter();
				sprmparam27 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.AccountGroupId;
				sprmparam27 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.LedgerName;
				sprmparam27 = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.OpeningBalance;
				sprmparam27 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.CrOrDr;
				sprmparam27 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Narration;
				sprmparam27 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.MailingName;
				sprmparam27 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Address;
				sprmparam27 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Phone;
				sprmparam27 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Mobile;
				sprmparam27 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Email;
				sprmparam27 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam27.Value = accountledgerinfo.CreditPeriod;
				sprmparam27 = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.CreditLimit;
				sprmparam27 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.PricinglevelId;
				sprmparam27 = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
				sprmparam27.Value = accountledgerinfo.BillByBill;
				sprmparam27 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Tin;
				sprmparam27 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Cst;
				sprmparam27 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Pan;
				sprmparam27 = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.RouteId;
				sprmparam27 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.BankAccountNumber;
				sprmparam27 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.BranchName;
				sprmparam27 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.BranchCode;
				sprmparam27 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Extra1;
				sprmparam27 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Extra2;
				sprmparam27 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam27.Value = accountledgerinfo.ExtraDate;
				sprmparam27 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.AreaId;
				sprmparam27 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam27.Value = accountledgerinfo.IsDefault;
				object obj = sccmd.ExecuteScalar();
				decLedgerId = ((obj == null) ? 0m : Convert.ToDecimal(obj.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decLedgerId;
		}

		public DataTable AccountLedgerSearch(string straccountgroupname, string strledgername)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = straccountgroupname;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public AccountLedgerInfo AccountLedgerViewForEdit(decimal ledgerId)
		{
			AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerViewForEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = ledgerId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					accountledgerinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					accountledgerinfo.AccountGroupId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					accountledgerinfo.LedgerName = ((DbDataReader)sdrreader)[2].ToString();
					accountledgerinfo.OpeningBalance = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					accountledgerinfo.CrOrDr = ((DbDataReader)sdrreader)[4].ToString();
					accountledgerinfo.Narration = ((DbDataReader)sdrreader)[5].ToString();
					accountledgerinfo.MailingName = ((DbDataReader)sdrreader)[6].ToString();
					accountledgerinfo.Address = ((DbDataReader)sdrreader)[7].ToString();
					accountledgerinfo.Phone = ((DbDataReader)sdrreader)[8].ToString();
					accountledgerinfo.Mobile = ((DbDataReader)sdrreader)[9].ToString();
					accountledgerinfo.Email = ((DbDataReader)sdrreader)[10].ToString();
					accountledgerinfo.CreditPeriod = int.Parse(((DbDataReader)sdrreader)[11].ToString());
					accountledgerinfo.CreditLimit = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					accountledgerinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					accountledgerinfo.BillByBill = bool.Parse(((DbDataReader)sdrreader)[14].ToString());
					accountledgerinfo.Tin = ((DbDataReader)sdrreader)[15].ToString();
					accountledgerinfo.Cst = ((DbDataReader)sdrreader)[16].ToString();
					accountledgerinfo.Pan = ((DbDataReader)sdrreader)[17].ToString();
					accountledgerinfo.RouteId = decimal.Parse(((DbDataReader)sdrreader)[18].ToString());
					accountledgerinfo.BankAccountNumber = ((DbDataReader)sdrreader)[19].ToString();
					accountledgerinfo.BranchName = ((DbDataReader)sdrreader)[20].ToString();
					accountledgerinfo.BranchCode = ((DbDataReader)sdrreader)[21].ToString();
					accountledgerinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[22].ToString());
					accountledgerinfo.Extra1 = ((DbDataReader)sdrreader)[23].ToString();
					accountledgerinfo.Extra2 = ((DbDataReader)sdrreader)[24].ToString();
					accountledgerinfo.AreaId = decimal.Parse(((DbDataReader)sdrreader)[25].ToString());
					accountledgerinfo.IsDefault = bool.Parse(((DbDataReader)sdrreader)[26].ToString());
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
			return accountledgerinfo;
		}

		public DataTable AccountLedgerForSecondaryDetails()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerForSecondaryDetails", base.sqlcon);
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
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

		public bool AccountLedgerCheckExistence(string strLedgerName, decimal decLedgerId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam3.Value = strLedgerName;
				sprmparam3 = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam3.Value = decLedgerId;
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

		public DataTable MultipleAccountLedgerComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("MultipleAccountLedgerComboFill", base.sqlcon);
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

		public DataTable cmbAreafillInCustomer()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AreafillInCustomer", base.sqlcon);
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

		public DataTable cmbPricingLevelInCustomer()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PricingLevelFillinCustomer", base.sqlcon);
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

		public DataTable cmbRoutInCustomer(decimal decAreaId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RoutFillinCustomer", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal).Value = decAreaId;
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

		public decimal AccountLedgerAddForCustomer(AccountLedgerInfo accountledgerinfo)
		{
			decimal decledgerid = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerAddForCustomer", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam27 = new SqlParameter();
				sprmparam27 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.AccountGroupId;
				sprmparam27 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.LedgerName;
				sprmparam27 = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.OpeningBalance;
				sprmparam27 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.CrOrDr;
				sprmparam27 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Narration;
				sprmparam27 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.MailingName;
				sprmparam27 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Address;
				sprmparam27 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Phone;
				sprmparam27 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Mobile;
				sprmparam27 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Email;
				sprmparam27 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam27.Value = accountledgerinfo.CreditPeriod;
				sprmparam27 = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.CreditLimit;
				sprmparam27 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.PricinglevelId;
				sprmparam27 = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
				sprmparam27.Value = accountledgerinfo.BillByBill;
				sprmparam27 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Tin;
				sprmparam27 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Cst;
				sprmparam27 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Pan;
				sprmparam27 = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.RouteId;
				sprmparam27 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.BankAccountNumber;
				sprmparam27 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.BranchName;
				sprmparam27 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.BranchCode;
				sprmparam27 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Extra1;
				sprmparam27 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam27.Value = accountledgerinfo.Extra2;
				sprmparam27 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam27.Value = accountledgerinfo.AreaId;
				sprmparam27 = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
				sprmparam27.Value = accountledgerinfo.IsDefault;
				sprmparam27 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam27.Value = accountledgerinfo.ExtraDate;
				object obj = sccmd.ExecuteScalar();
				decledgerid = ((obj == null) ? 0m : Convert.ToDecimal(obj.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decledgerid;
		}

		public bool AccountLedgerCheckExistenceForCustomer(string strLedgerName, decimal decLedgerId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistenceForCustomer", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam3.Value = strLedgerName;
				sprmparam3 = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam3.Value = decLedgerId;
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

		public DataTable AccountLedgerSearchforCustomer(decimal decAreaId, decimal decRouteId, string strledgername)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl.No", typeof(decimal));
			dtbl.Columns["Sl.No"].AutoIncrement = true;
			dtbl.Columns["Sl.No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl.No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerSearchforCustomer", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@areaId", SqlDbType.VarChar).Value = decAreaId;
				sqlda.SelectCommand.Parameters.Add("@routeId", SqlDbType.VarChar).Value = decRouteId;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public AccountLedgerInfo AccountLedgerViewForCustomer(decimal ledgerId)
		{
			AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerViewForCustomer", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = ledgerId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					accountledgerinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					accountledgerinfo.LedgerName = ((DbDataReader)sdrreader)[1].ToString();
					accountledgerinfo.OpeningBalance = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					accountledgerinfo.CrOrDr = ((DbDataReader)sdrreader)[3].ToString();
					accountledgerinfo.Narration = ((DbDataReader)sdrreader)[4].ToString();
					accountledgerinfo.MailingName = ((DbDataReader)sdrreader)[5].ToString();
					accountledgerinfo.Address = ((DbDataReader)sdrreader)[6].ToString();
					accountledgerinfo.Phone = ((DbDataReader)sdrreader)[7].ToString();
					accountledgerinfo.Mobile = ((DbDataReader)sdrreader)[8].ToString();
					accountledgerinfo.Email = ((DbDataReader)sdrreader)[9].ToString();
					accountledgerinfo.CreditPeriod = int.Parse(((DbDataReader)sdrreader)[10].ToString());
					accountledgerinfo.CreditLimit = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					accountledgerinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					accountledgerinfo.BillByBill = bool.Parse(((DbDataReader)sdrreader)[13].ToString());
					accountledgerinfo.Tin = ((DbDataReader)sdrreader)[14].ToString();
					accountledgerinfo.Cst = ((DbDataReader)sdrreader)[15].ToString();
					accountledgerinfo.Pan = ((DbDataReader)sdrreader)[16].ToString();
					accountledgerinfo.RouteId = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
					accountledgerinfo.BankAccountNumber = ((DbDataReader)sdrreader)[18].ToString();
					accountledgerinfo.BranchName = ((DbDataReader)sdrreader)[19].ToString();
					accountledgerinfo.BranchCode = ((DbDataReader)sdrreader)[20].ToString();
					accountledgerinfo.AreaId = decimal.Parse(((DbDataReader)sdrreader)[21].ToString());
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
			return accountledgerinfo;
		}

		public void AccountLedgerEditForCustomer(AccountLedgerInfo accountledgerinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerEditForCustomer", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam24 = new SqlParameter();
				sprmparam24 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam24.Value = accountledgerinfo.LedgerId;
				sprmparam24 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.LedgerName;
				sprmparam24 = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
				sprmparam24.Value = accountledgerinfo.OpeningBalance;
				sprmparam24 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.CrOrDr;
				sprmparam24 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Narration;
				sprmparam24 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.MailingName;
				sprmparam24 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Address;
				sprmparam24 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Phone;
				sprmparam24 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Mobile;
				sprmparam24 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Email;
				sprmparam24 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam24.Value = accountledgerinfo.CreditPeriod;
				sprmparam24 = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
				sprmparam24.Value = accountledgerinfo.CreditLimit;
				sprmparam24 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam24.Value = accountledgerinfo.PricinglevelId;
				sprmparam24 = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
				sprmparam24.Value = accountledgerinfo.BillByBill;
				sprmparam24 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Tin;
				sprmparam24 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Cst;
				sprmparam24 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.Pan;
				sprmparam24 = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
				sprmparam24.Value = accountledgerinfo.RouteId;
				sprmparam24 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.BankAccountNumber;
				sprmparam24 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.BranchName;
				sprmparam24 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam24.Value = accountledgerinfo.BranchCode;
				sprmparam24 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam24.Value = accountledgerinfo.AreaId;
				sprmparam24 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam24.Value = accountledgerinfo.ExtraDate;
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

		public DataTable SupplierSearchAll(decimal deecAreaId, decimal decRouteId, string strledgername)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl.No", typeof(decimal));
			dtbl.Columns["Sl.No"].AutoIncrement = true;
			dtbl.Columns["Sl.No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl.No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SupplierSearchAll", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal).Value = deecAreaId;
				sqlda.SelectCommand.Parameters.Add("@routeId", SqlDbType.Decimal).Value = decRouteId;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public void AccountLedgerEditForSalesman(AccountLedgerInfo accountledgerinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerEditForSalesman", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam21.Value = accountledgerinfo.LedgerId;
				sprmparam21 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.LedgerName;
				sprmparam21 = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
				sprmparam21.Value = accountledgerinfo.OpeningBalance;
				sprmparam21 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.CrOrDr;
				sprmparam21 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Narration;
				sprmparam21 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.MailingName;
				sprmparam21 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Address;
				sprmparam21 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Phone;
				sprmparam21 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Mobile;
				sprmparam21 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Email;
				sprmparam21 = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
				sprmparam21.Value = accountledgerinfo.BillByBill;
				sprmparam21 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Tin;
				sprmparam21 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Cst;
				sprmparam21 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.Pan;
				sprmparam21 = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
				sprmparam21.Value = accountledgerinfo.RouteId;
				sprmparam21 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.BankAccountNumber;
				sprmparam21 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.BranchName;
				sprmparam21 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam21.Value = accountledgerinfo.BranchCode;
				sprmparam21 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam21.Value = accountledgerinfo.AreaId;
				sprmparam21 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam21.Value = accountledgerinfo.ExtraDate;
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

		public bool AccountLedgerCheckExistenceForSalesman(string strLedgerName, decimal decLedgerId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistenceForSalesman", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam3.Value = strLedgerName;
				sprmparam3 = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam3.Value = decLedgerId;
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

		public AccountLedgerInfo AccountLedgerViewForSupplier(decimal ledgerId)
		{
			AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerViewForSupplier", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = ledgerId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					accountledgerinfo.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					accountledgerinfo.LedgerName = ((DbDataReader)sdrreader)[1].ToString();
					accountledgerinfo.OpeningBalance = Convert.ToDecimal(((DbDataReader)sdrreader)[2].ToString());
					accountledgerinfo.CrOrDr = ((DbDataReader)sdrreader)[3].ToString();
					accountledgerinfo.Narration = ((DbDataReader)sdrreader)[4].ToString();
					accountledgerinfo.MailingName = ((DbDataReader)sdrreader)[5].ToString();
					accountledgerinfo.Address = ((DbDataReader)sdrreader)[6].ToString();
					accountledgerinfo.Phone = ((DbDataReader)sdrreader)[7].ToString();
					accountledgerinfo.Mobile = ((DbDataReader)sdrreader)[8].ToString();
					accountledgerinfo.Email = ((DbDataReader)sdrreader)[9].ToString();
					accountledgerinfo.BillByBill = Convert.ToBoolean(((DbDataReader)sdrreader)[10].ToString());
					accountledgerinfo.Tin = ((DbDataReader)sdrreader)[11].ToString();
					accountledgerinfo.Cst = ((DbDataReader)sdrreader)[12].ToString();
					accountledgerinfo.Pan = ((DbDataReader)sdrreader)[13].ToString();
					accountledgerinfo.RouteId = Convert.ToDecimal(((DbDataReader)sdrreader)[14].ToString());
					accountledgerinfo.BankAccountNumber = ((DbDataReader)sdrreader)[15].ToString();
					accountledgerinfo.BranchName = ((DbDataReader)sdrreader)[16].ToString();
					accountledgerinfo.BranchCode = ((DbDataReader)sdrreader)[17].ToString();
					accountledgerinfo.AreaId = Convert.ToDecimal(((DbDataReader)sdrreader)[18].ToString());
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
			return accountledgerinfo;
		}

		public DataTable LedgerPopupSearch(string strledgername, string straccountgroupname, decimal decId1, decimal decId2)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl No", typeof(decimal));
			dtbl.Columns["Sl No"].AutoIncrement = true;
			dtbl.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("LedgerPopupSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
				sqlda.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = straccountgroupname;
				sqlda.SelectCommand.Parameters.Add("@id1", SqlDbType.Decimal).Value = decId1;
				sqlda.SelectCommand.Parameters.Add("@id2", SqlDbType.Decimal).Value = decId2;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable LedgerPopupSearchForServiceAccountsUnderIncome()
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl No", typeof(decimal));
			dtbl.Columns["Sl No"].AutoIncrement = true;
			dtbl.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerSearchForServiceAccountUnderIncome", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable AccountLedgerForBankDetails()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerForBankDetails", base.sqlcon);
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
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

		public decimal AccountLedgerCheckReferences(decimal decledgerId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckReferences", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = decledgerId;
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

		public decimal SupplierCheckreferenceAndDelete(decimal decledgerId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SupplierCheckreferenceAndDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = decledgerId;
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

		public bool AccountGroupIdCheck(string strLedgerName)
		{
			bool isSundryCreditOrDebit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupIdCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam2.Value = strLedgerName;
				isSundryCreditOrDebit = Convert.ToBoolean(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isSundryCreditOrDebit;
		}

		public string CreditOrDebitChecking(decimal decLedgerId)
		{
			string strNature = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CreditOrDebitChecking", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				sprmparam2.Value = decLedgerId;
				strNature = sccmd.ExecuteScalar().ToString();
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

		public void LedgerPostingDeleteByVoucherTypeAndVoucherNo(string strVocuherNumber, decimal decvoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("LedgerPostingDeleteByVoucherTypeAndVoucherNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVocuherNumber;
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decvoucherTypeId;
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

		public void PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType(string strVocuherNumber, decimal decVoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVocuherNumber;
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam3.Value = decVoucherTypeId;
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

		public bool PartyBalanceAgainstReferenceCheck(string strVoucherNo, decimal decVoucherTypeId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PartyBalanceAgainstReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public bool AccountLedgerUnderBankOrCash(string strLedgerId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerUnderCashOrParty", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
				sprmparam2.Value = strLedgerId;
				isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Account Suit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public bool AccountLedgerCheckNegativeBalance(string strLedgerId, string strCrOrDr, decimal dcAmount, string strVoucherType, string strVoucherNo)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerGetCurerntBalanceOfLedgerToCheckNegativeBalance", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
				sprmparam6.Value = strLedgerId;
				sprmparam6 = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
				sprmparam6.Value = strCrOrDr;
				sprmparam6 = sccmd.Parameters.Add("@amt", SqlDbType.Decimal);
				sprmparam6.Value = dcAmount;
				sprmparam6 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam6.Value = strVoucherType;
				sprmparam6 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam6.Value = strVoucherNo;
				isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public DataTable AccountLedgerViewForAdditionalCost()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewForAdditionalCost", base.sqlcon);
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
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

		public AccountLedgerInfo accountLedgerviewbyId(decimal ledgerId)
		{
			AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = ledgerId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					accountledgerinfo.LedgerId = Convert.ToDecimal(((DbDataReader)sdrreader)["ledgerId"].ToString());
					accountledgerinfo.LedgerName = ((DbDataReader)sdrreader)["ledgerName"].ToString();
					accountledgerinfo.CreditPeriod = Convert.ToInt32(((DbDataReader)sdrreader)["creditPeriod"].ToString());
					accountledgerinfo.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrreader)["pricinglevelId"].ToString());
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
			return accountledgerinfo;
		}

		public decimal CheckLedgerBalance(decimal decledgerId)
		{
			decimal inBalance = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckLedgerBalance", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
				sprmparam2.Value = decledgerId;
				inBalance = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inBalance;
		}

		public decimal AccountLedgerIdGetByName(string strLedgerName)
		{
			decimal decLedgerId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountLedgerIdGetByName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam2.Value = strLedgerName;
				decLedgerId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decLedgerId;
		}

		public bool AccountGroupIdCheckSundryCreditorOnly(string strLedgerName)
		{
			bool isSundrycredit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupIdCheckSundryCreditorOnly", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam2.Value = strLedgerName;
				isSundrycredit = Convert.ToBoolean(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isSundrycredit;
		}

		public bool AccountGroupIdCheckSundryDeptor(string strLedgerName)
		{
			bool isSundryDebit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AccountGroupIdCheckSundryDeptor", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam2.Value = strLedgerName;
				isSundryDebit = Convert.ToBoolean(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isSundryDebit;
		}

		public DataTable AccountLedgerViewAllByLedgerName(decimal decaccountGroupId)
		{
			DataTable dtb = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerViewAllByLedgerName", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decaccountGroupId;
				sqlda.Fill(dtb);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtb;
		}

		public DataTable PartyAddressBookSearch(string strType, string strmobile, string strphone, string stremail, string strledgerName)
		{
			DataTable dtblPartyAddressBook = new DataTable();
			dtblPartyAddressBook.Columns.Add("Sl No", typeof(int));
			dtblPartyAddressBook.Columns["Sl No"].AutoIncrement = true;
			dtblPartyAddressBook.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtblPartyAddressBook.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PartyAddressBookSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
				sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgerName;
				sqlda.SelectCommand.Parameters.Add("@mobile", SqlDbType.VarChar).Value = strmobile;
				sqlda.SelectCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = strphone;
				sqlda.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = stremail;
				sqlda.Fill(dtblPartyAddressBook);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblPartyAddressBook;
		}

		internal DataTable PartyAddressBookPrint(string strType, string strmobile, string strphone, string stremail, string strledgerName)
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PartyAddressBookPrint", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam6.Value = strType;
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar);
				sprmparam6.Value = strledgerName;
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam6.Value = strmobile;
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam6.Value = strphone;
				sprmparam6 = sdaadapter.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam6.Value = stremail;
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

		public DataTable AccountLedgerReportFill(DateTime dtFromDate, DateTime dtToDate, decimal decAccountGroupId, decimal decLedgerId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerReportFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sqlda.Fill(dtbl);
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

		public DataTable AccountLedgerViewByAccountGroup(decimal decAccounGroupId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerViewByAccountGroup", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccounGroupId;
				sqlda.Fill(dtbl);
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

		public DataTable AdditionalCostGet()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewForAdditionalCost", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		internal DataSet AccountLedgerReportPrinting(decimal decCompanyId, DateTime fromDate, DateTime toDate, decimal decAccountGroupId, decimal decLedgerId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerReportPrint", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param6 = new SqlParameter();
				param6 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				param6.Value = decCompanyId;
				param6 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param6.Value = fromDate;
				param6 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param6.Value = toDate;
				param6 = sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
				param6.Value = decAccountGroupId;
				param6 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				param6.Value = decLedgerId;
				sqlda.Fill(dSt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dSt;
		}

		public DataSet LedgerDetailsFillCorrespondingToledgerId(DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId)
		{
			DataSet dsLedgerDetails = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("LedgerDetailsFillCorrespondingToledgerId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sqlda.SelectCommand.Parameters.Add("@noOfDecimalPlace", SqlDbType.Decimal).Value = PublicVariables._inNoOfDecimalPlaces;
				sqlda.Fill(dsLedgerDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dsLedgerDetails;
		}

		public DataTable BillAllocationLedgerFill(ComboBox cmbAccountLedger, string strAccountGroup, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BillAllocationLedgerFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
				sprmparam2.Value = strAccountGroup;
				sdaadapter.Fill(dtbl);
				if (isAll)
				{
					DataRow dr = dtbl.NewRow();
					dr["ledgerName"] = "All";
					dr["ledgerId"] = 0;
					dtbl.Rows.InsertAt(dr, 0);
				}
				cmbAccountLedger.DataSource = dtbl;
				cmbAccountLedger.DisplayMember = "ledgerName";
				cmbAccountLedger.ValueMember = "ledgerId";
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

		public bool AccountLedgerCheckExistenceForTax(string strTaxName)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistenceForTax", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@taxName", SqlDbType.VarChar);
				sprmparam2.Value = strTaxName;
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
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return false;
		}
	}
}
