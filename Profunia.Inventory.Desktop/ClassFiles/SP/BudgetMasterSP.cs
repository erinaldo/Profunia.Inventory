using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BudgetMasterSP : DBConnection
	{
		public decimal BudgetMasterAdd(BudgetMasterInfo budgetmasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@budgetName", SqlDbType.VarChar);
				sprmparam10.Value = budgetmasterinfo.BudgetName;
				sprmparam10 = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam10.Value = budgetmasterinfo.Type;
				sprmparam10 = sccmd.Parameters.Add("@totalDr", SqlDbType.Decimal);
				sprmparam10.Value = budgetmasterinfo.TotalDr;
				sprmparam10 = sccmd.Parameters.Add("@totalCr", SqlDbType.Decimal);
				sprmparam10.Value = budgetmasterinfo.TotalCr;
				sprmparam10 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam10.Value = budgetmasterinfo.FromDate;
				sprmparam10 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam10.Value = budgetmasterinfo.ToDate;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = budgetmasterinfo.Narration;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = budgetmasterinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = budgetmasterinfo.Extra2;
				decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decIdentity;
		}

		public void BudgetMasterEdit(BudgetMasterInfo budgetmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
				sprmparam11.Value = budgetmasterinfo.BudgetMasterId;
				sprmparam11 = sccmd.Parameters.Add("@budgetName", SqlDbType.VarChar);
				sprmparam11.Value = budgetmasterinfo.BudgetName;
				sprmparam11 = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam11.Value = budgetmasterinfo.Type;
				sprmparam11 = sccmd.Parameters.Add("@totalDr", SqlDbType.Decimal);
				sprmparam11.Value = budgetmasterinfo.TotalDr;
				sprmparam11 = sccmd.Parameters.Add("@totalCr", SqlDbType.Decimal);
				sprmparam11.Value = budgetmasterinfo.TotalCr;
				sprmparam11 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam11.Value = budgetmasterinfo.FromDate;
				sprmparam11 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam11.Value = budgetmasterinfo.ToDate;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = budgetmasterinfo.Narration;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = budgetmasterinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = budgetmasterinfo.Extra2;
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

		public DataTable BudgetMasterViewAll(string strStartText, string strType)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BudgetMasterViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@startText", SqlDbType.VarChar);
				sprmparam3.Value = strStartText;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam3.Value = strType;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public BudgetMasterInfo BudgetMasterView(decimal budgetMasterId)
		{
			BudgetMasterInfo budgetmasterinfo = new BudgetMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
				sprmparam2.Value = budgetMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					budgetmasterinfo.BudgetMasterId = Convert.ToDecimal(((DbDataReader)sdrreader)["budgetMasterId"].ToString());
					budgetmasterinfo.BudgetName = ((DbDataReader)sdrreader)["budgetName"].ToString();
					budgetmasterinfo.Type = ((DbDataReader)sdrreader)["type"].ToString();
					budgetmasterinfo.TotalDr = Convert.ToDecimal(((DbDataReader)sdrreader)["totalDr"].ToString());
					budgetmasterinfo.TotalCr = Convert.ToDecimal(((DbDataReader)sdrreader)["totalCr"].ToString());
					budgetmasterinfo.FromDate = DateTime.Parse(((DbDataReader)sdrreader)["fromDate"].ToString());
					budgetmasterinfo.ToDate = DateTime.Parse(((DbDataReader)sdrreader)["toDate"].ToString());
					budgetmasterinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					budgetmasterinfo.Extra1 = ((DbDataReader)sdrreader)["extra1"].ToString();
					budgetmasterinfo.Extra2 = ((DbDataReader)sdrreader)["extra2"].ToString();
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
			return budgetmasterinfo;
		}

		public decimal BudgetMasterDelete(decimal BudgetMasterId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetDetailsDeleteWithMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
				sprmparam2.Value = BudgetMasterId;
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

		public int BudgetMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetMasterMax", base.sqlcon);
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

		public bool BudgetCheckExistanceOfName(string strBudgetName, decimal decBudgetMasterId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BudgetCheckExistanceOfName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@budgetName", SqlDbType.VarChar);
				sprmparam3.Value = strBudgetName;
				sprmparam3 = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decBudgetMasterId;
				object obj = sccmd.ExecuteScalar();
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

		public DataTable BudgetSearchGridFill(string strBudgetName, string strType)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("BudgetSearchGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@budgetName", SqlDbType.VarChar).Value = strBudgetName;
				sqlda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable BudgetViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BudgetViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable BudgetVariance(decimal decbudgetId)
		{
			DataTable dtblBudget = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("BudgetVariance", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@budgetMasterId", SqlDbType.Decimal).Value = decbudgetId;
				sqlda.Fill(dtblBudget);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblBudget;
		}
	}
}
