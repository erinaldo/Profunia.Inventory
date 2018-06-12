using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class FinancialYearSP : DBConnection
	{
		public void FinancialYearAdd(FinancialYearInfo financialyearinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam4.Value = financialyearinfo.FromDate;
				sprmparam4 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam4.Value = financialyearinfo.ToDate;
				sprmparam4 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam4.Value = financialyearinfo.ExtraDate;
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

		public void FinancialYearEdit(FinancialYearInfo financialyearinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam7.Value = financialyearinfo.FinancialYearId;
				sprmparam7 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam7.Value = financialyearinfo.FromDate;
				sprmparam7 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam7.Value = financialyearinfo.ToDate;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = financialyearinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = financialyearinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = financialyearinfo.Extra2;
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

		public DataTable FinancialYearViewAll()
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
				SqlDataAdapter sdaadapter = new SqlDataAdapter("FinancialYearViewAll", base.sqlcon);
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

		public FinancialYearInfo FinancialYearView(decimal financialYearId)
		{
			FinancialYearInfo financialyearinfo = new FinancialYearInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam2.Value = financialYearId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					financialyearinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					financialyearinfo.FromDate = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
					financialyearinfo.ToDate = DateTime.Parse(((DbDataReader)sdrreader)[2].ToString());
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
			return financialyearinfo;
		}

		public FinancialYearInfo FinancialYearViewForAccountLedger(decimal financialYearId)
		{
			FinancialYearInfo financialyearinfo = new FinancialYearInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearViewForAccountLedger", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam2.Value = financialYearId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					financialyearinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					financialyearinfo.FromDate = DateTime.Parse(((DbDataReader)sdrreader)[1].ToString());
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
			return financialyearinfo;
		}

		public void FinancialYearDelete(decimal FinancialYearId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam2.Value = FinancialYearId;
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

		public string FinancialYearGetMax()
		{
			string strMax = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				strMax = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strMax;
		}

		public decimal FinancialYearAddWithReturnIdentity(FinancialYearInfo financialyearinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearAddWithReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam6.Value = financialyearinfo.FromDate;
				sprmparam6 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam6.Value = financialyearinfo.ToDate;
				sprmparam6 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam6.Value = financialyearinfo.ExtraDate;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = financialyearinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = financialyearinfo.Extra2;
				decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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

		public bool FinancialYearExistenceCheck(DateTime dtFromDate, DateTime dtToDate)
		{
			bool trueOrfalse = true;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FinancialYearExistenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam3.Value = dtFromDate;
				sprmparam3 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam3.Value = dtToDate;
				if (Convert.ToInt32(sccmd.ExecuteScalar().ToString()) == 0)
				{
					trueOrfalse = true;
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
			return trueOrfalse;
		}
	}
}
