using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class CompanySP : DBConnection
	{
		public void CompanyAdd(CompanyInfo companyinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam23 = new SqlParameter();
				sprmparam23 = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam23.Value = companyinfo.CompanyId;
				sprmparam23 = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.CompanyName;
				sprmparam23 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.MailingName;
				sprmparam23 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Address;
				sprmparam23 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Phone;
				sprmparam23 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Mobile;
				sprmparam23 = sccmd.Parameters.Add("@emailId", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.EmailId;
				sprmparam23 = sccmd.Parameters.Add("@web", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Web;
				sprmparam23 = sccmd.Parameters.Add("@country", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Country;
				sprmparam23 = sccmd.Parameters.Add("@state", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.State;
				sprmparam23 = sccmd.Parameters.Add("@pin", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Pin;
				sprmparam23 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam23.Value = companyinfo.CurrencyId;
				sprmparam23 = sccmd.Parameters.Add("@financialYearFrom", SqlDbType.DateTime);
				sprmparam23.Value = companyinfo.FinancialYearFrom;
				sprmparam23 = sccmd.Parameters.Add("@booksBeginingFrom", SqlDbType.DateTime);
				sprmparam23.Value = companyinfo.BooksBeginingFrom;
				sprmparam23 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Tin;
				sprmparam23 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Cst;
				sprmparam23 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Pan;
				sprmparam23 = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
				sprmparam23.Value = companyinfo.CurrentDate;
				sprmparam23 = sccmd.Parameters.Add("@logo", SqlDbType.Image);
				sprmparam23.Value = companyinfo.Logo;
				sprmparam23 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Extra1;
				sprmparam23 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam23.Value = companyinfo.Extra2;
				sprmparam23 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam23.Value = companyinfo.ExtraDate;
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

		public void CompanyEdit(CompanyInfo companyinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam22 = new SqlParameter();
				sprmparam22 = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam22.Value = companyinfo.CompanyId;
				sprmparam22 = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.CompanyName;
				sprmparam22 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.MailingName;
				sprmparam22 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Address;
				sprmparam22 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Phone;
				sprmparam22 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Mobile;
				sprmparam22 = sccmd.Parameters.Add("@emailId", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.EmailId;
				sprmparam22 = sccmd.Parameters.Add("@web", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Web;
				sprmparam22 = sccmd.Parameters.Add("@country", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Country;
				sprmparam22 = sccmd.Parameters.Add("@state", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.State;
				sprmparam22 = sccmd.Parameters.Add("@pin", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Pin;
				sprmparam22 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam22.Value = companyinfo.CurrencyId;
				sprmparam22 = sccmd.Parameters.Add("@financialYearFrom", SqlDbType.DateTime);
				sprmparam22.Value = companyinfo.FinancialYearFrom;
				sprmparam22 = sccmd.Parameters.Add("@booksBeginingFrom", SqlDbType.DateTime);
				sprmparam22.Value = companyinfo.BooksBeginingFrom;
				sprmparam22 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Tin;
				sprmparam22 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Cst;
				sprmparam22 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Pan;
				sprmparam22 = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
				sprmparam22.Value = companyinfo.CurrentDate;
				sprmparam22 = sccmd.Parameters.Add("@logo", SqlDbType.Image);
				sprmparam22.Value = companyinfo.Logo;
				sprmparam22 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Extra1;
				sprmparam22 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam22.Value = companyinfo.Extra2;
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

		public DataTable CompanyViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CompanyViewAll", base.sqlcon);
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

		public CompanyInfo CompanyView(decimal companyId)
		{
			CompanyInfo companyinfo = new CompanyInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam2.Value = companyId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					companyinfo.CompanyId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					companyinfo.CompanyName = ((DbDataReader)sdrreader)[1].ToString();
					companyinfo.MailingName = ((DbDataReader)sdrreader)[2].ToString();
					companyinfo.Address = ((DbDataReader)sdrreader)[3].ToString();
					companyinfo.Phone = ((DbDataReader)sdrreader)[4].ToString();
					companyinfo.Mobile = ((DbDataReader)sdrreader)[5].ToString();
					companyinfo.EmailId = ((DbDataReader)sdrreader)[6].ToString();
					companyinfo.Web = ((DbDataReader)sdrreader)[7].ToString();
					companyinfo.Country = ((DbDataReader)sdrreader)[8].ToString();
					companyinfo.State = ((DbDataReader)sdrreader)[9].ToString();
					companyinfo.Pin = ((DbDataReader)sdrreader)[10].ToString();
					companyinfo.CurrencyId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					companyinfo.FinancialYearFrom = DateTime.Parse(((DbDataReader)sdrreader)[12].ToString());
					companyinfo.BooksBeginingFrom = DateTime.Parse(((DbDataReader)sdrreader)[13].ToString());
					companyinfo.Tin = ((DbDataReader)sdrreader)[14].ToString();
					companyinfo.Cst = ((DbDataReader)sdrreader)[15].ToString();
					companyinfo.Pan = ((DbDataReader)sdrreader)[16].ToString();
					companyinfo.CurrentDate = DateTime.Parse(((DbDataReader)sdrreader)[17].ToString());
					companyinfo.Logo = (byte[])((DbDataReader)sdrreader)[18];
					companyinfo.Extra1 = ((DbDataReader)sdrreader)[19].ToString();
					companyinfo.Extra2 = ((DbDataReader)sdrreader)[20].ToString();
					companyinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[21].ToString());
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
			return companyinfo;
		}

		public DataTable CompanyViewForDotMatrix()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("CompanyViewForDotMatrix", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtbl;
		}

		public DataTable CompanyViewDataTable(decimal companyId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("CompanyView", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = companyId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public void CompanyDelete(decimal CompanyId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam2.Value = CompanyId;
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

		public int CompanyGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyMax", base.sqlcon);
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

		public decimal CompanyAddParticularFeilds(CompanyInfo companyinfo)
		{
			decimal decCopmanyId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyAddParticularFeilds", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam21 = new SqlParameter();
				sprmparam21 = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.CompanyName;
				sprmparam21 = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.MailingName;
				sprmparam21 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Address;
				sprmparam21 = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Phone;
				sprmparam21 = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Mobile;
				sprmparam21 = sccmd.Parameters.Add("@emailId", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.EmailId;
				sprmparam21 = sccmd.Parameters.Add("@web", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Web;
				sprmparam21 = sccmd.Parameters.Add("@country", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Country;
				sprmparam21 = sccmd.Parameters.Add("@state", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.State;
				sprmparam21 = sccmd.Parameters.Add("@pin", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Pin;
				sprmparam21 = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
				sprmparam21.Value = companyinfo.CurrencyId;
				sprmparam21 = sccmd.Parameters.Add("@financialYearFrom", SqlDbType.DateTime);
				sprmparam21.Value = companyinfo.FinancialYearFrom;
				sprmparam21 = sccmd.Parameters.Add("@booksBeginingFrom", SqlDbType.DateTime);
				sprmparam21.Value = companyinfo.BooksBeginingFrom;
				sprmparam21 = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Tin;
				sprmparam21 = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Cst;
				sprmparam21 = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Pan;
				sprmparam21 = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
				sprmparam21.Value = companyinfo.CurrentDate;
				sprmparam21 = sccmd.Parameters.Add("@logo", SqlDbType.Image);
				sprmparam21.Value = companyinfo.Logo;
				sprmparam21 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Extra1;
				sprmparam21 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam21.Value = companyinfo.Extra2;
				decCopmanyId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decCopmanyId;
		}

		public bool CompanyCheckExistence(string strCompanyName, decimal decCompanyId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("CompanyCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@companyName", SqlDbType.VarChar);
				sprmparam3.Value = strCompanyName;
				sprmparam3 = sqlcmd.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam3.Value = decCompanyId;
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

		public int CompanyCount()
		{
			int inCount = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					try
					{
						base.sqlcon.Open();
					}
					catch
					{
						inCount = -1;
					}
				}
				SqlCommand sccmd = new SqlCommand("CompanyCount", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				inCount = int.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception)
			{
				inCount = -1;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inCount;
		}

		public void CompanyCurrentDateEdit(DateTime dtCurrentDate)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("CompanyCurrentDateEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@companyId", SqlDbType.Decimal).Value = 1;
				sqlcmd.Parameters.Add("@currentDate", SqlDbType.DateTime).Value = dtCurrentDate;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable CompanyViewAllForSelectCompany()
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(decimal));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("CompanyViewAllForSelectCompany", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public decimal CompanyGetIdIfSingleCompany()
		{
			decimal decCompanyId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CompanyGetIdIfSingleCompany", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				decCompanyId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decCompanyId;
		}

		public string StoredProcedureInserter(string strParameter)
		{
			string error = "";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				string str = "IF NOT EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name='StoredProcedureInserter') BEGIN EXECUTE('CREATE PROCEDURE StoredProcedureInserter @parameter varchar(max) AS execute(@parameter)') END";
				SqlCommand sqlcmd = new SqlCommand(str, base.sqlcon);
				sqlcmd.ExecuteNonQuery();
				SqlCommand sccmd = new SqlCommand("StoredProcedureInserter", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@parameter", SqlDbType.VarChar);
				sprmparam2.Value = strParameter;
				sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return error;
		}
	}
}
