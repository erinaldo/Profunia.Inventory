using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BankReconciliationSP : DBConnection
	{
		public void BankReconciliationAdd(BankReconciliationInfo bankreconciliationinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BankReconciliationAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
				sprmparam6.Value = bankreconciliationinfo.LedgerPostingId;
				sprmparam6 = sccmd.Parameters.Add("@statementDate", SqlDbType.DateTime);
				sprmparam6.Value = bankreconciliationinfo.StatementDate;
				sprmparam6 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam6.Value = bankreconciliationinfo.ExtraDate;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = bankreconciliationinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = bankreconciliationinfo.Extra2;
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

		public void BankReconciliationEdit(BankReconciliationInfo bankreconciliationinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BankReconciliationEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@reconcileId", SqlDbType.Decimal);
				sprmparam7.Value = bankreconciliationinfo.ReconcileId;
				sprmparam7 = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
				sprmparam7.Value = bankreconciliationinfo.LedgerPostingId;
				sprmparam7 = sccmd.Parameters.Add("@statementDate", SqlDbType.DateTime);
				sprmparam7.Value = bankreconciliationinfo.StatementDate;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = bankreconciliationinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = bankreconciliationinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = bankreconciliationinfo.Extra2;
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

		public DataTable BankReconciliationViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BankReconciliationViewAll", base.sqlcon);
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

		public BankReconciliationInfo BankReconciliationView(decimal reconcileId)
		{
			BankReconciliationInfo bankreconciliationinfo = new BankReconciliationInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BankReconciliationView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@reconcileId", SqlDbType.Decimal);
				sprmparam2.Value = reconcileId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					bankreconciliationinfo.ReconcileId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					bankreconciliationinfo.LedgerPostingId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					bankreconciliationinfo.StatementDate = DateTime.Parse(((DbDataReader)sdrreader)[2].ToString());
					bankreconciliationinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					bankreconciliationinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					bankreconciliationinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return bankreconciliationinfo;
		}

		public void BankReconciliationDelete(decimal ReconcileId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BankReconciliationDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@reconcileId", SqlDbType.Decimal);
				sprmparam2.Value = ReconcileId;
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

		public int BankReconciliationGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BankReconciliationMax", base.sqlcon);
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

		public DataTable BankReconciliationFillReconcile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
		{
			DataTable dtblBank = new DataTable();
			dtblBank.Columns.Add("Sl No", typeof(int));
			dtblBank.Columns["Sl No"].AutoIncrement = true;
			dtblBank.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtblBank.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("BankReconciliationFillreconcile", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sqlda.Fill(dtblBank);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblBank;
		}

		public decimal BankReconciliationLedgerPostingId(decimal decLedgerId)
		{
			decimal decReconcileId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("BankReconciliationLedgerPostingId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal).Value = decLedgerId;
				decReconcileId = decimal.Parse(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decReconcileId;
		}

		public DataTable BankReconciliationUnrecocile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
		{
			DataTable dtblBank = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtblBank.Columns.Add("Sl No", typeof(int));
				dtblBank.Columns["Sl No"].AutoIncrement = true;
				dtblBank.Columns["Sl No"].AutoIncrementSeed = 1L;
				dtblBank.Columns["Sl No"].AutoIncrementStep = 1L;
				SqlDataAdapter sqlda = new SqlDataAdapter("BankReconciliationFillUnrecon", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sqlda.Fill(dtblBank);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblBank;
		}
	}
}
