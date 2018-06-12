using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BudgetDetailsSP : DBConnection
	{
		public void BudgetDetailsAdd(BudgetDetailsInfo budgetdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
				sprmparam7.Value = budgetdetailsinfo.BudgetMasterId;
				sprmparam7 = sccmd.Parameters.Add("@particular", SqlDbType.VarChar);
				sprmparam7.Value = budgetdetailsinfo.Particular;
				sprmparam7 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam7.Value = budgetdetailsinfo.Credit;
				sprmparam7 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam7.Value = budgetdetailsinfo.Debit;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = budgetdetailsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = budgetdetailsinfo.Extra2;
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

		public void BudgetDetailsEdit(BudgetDetailsInfo budgetdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@budgetDetailsId", SqlDbType.Decimal);
				sprmparam8.Value = budgetdetailsinfo.BudgetDetailsId;
				sprmparam8 = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
				sprmparam8.Value = budgetdetailsinfo.BudgetMasterId;
				sprmparam8 = sccmd.Parameters.Add("@particular", SqlDbType.VarChar);
				sprmparam8.Value = budgetdetailsinfo.Particular;
				sprmparam8 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam8.Value = budgetdetailsinfo.Credit;
				sprmparam8 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam8.Value = budgetdetailsinfo.Debit;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = budgetdetailsinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = budgetdetailsinfo.Extra2;
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

		public DataTable BudgetDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BudgetDetailsViewAll", base.sqlcon);
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

		public BudgetDetailsInfo BudgetDetailsView(decimal budgetDetailsId)
		{
			BudgetDetailsInfo budgetdetailsinfo = new BudgetDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@budgetDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = budgetDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					budgetdetailsinfo.BudgetDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					budgetdetailsinfo.BudgetMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					budgetdetailsinfo.Particular = ((DbDataReader)sdrreader)[2].ToString();
					budgetdetailsinfo.Credit = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					budgetdetailsinfo.Debit = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					budgetdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					budgetdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
					budgetdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
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
			return budgetdetailsinfo;
		}

		public DataTable BudgetDetailsViewByMasterId(decimal decBudgetMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("BudgetDetailsViewByMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal).Value = decBudgetMasterId;
				sdaadapter.SelectCommand = sqlcmd;
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

		public void BudgetDetailsDelete(decimal BudgetDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@budgetDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = BudgetDetailsId;
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

		public int BudgetDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetDetailsMax", base.sqlcon);
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
	}
}
