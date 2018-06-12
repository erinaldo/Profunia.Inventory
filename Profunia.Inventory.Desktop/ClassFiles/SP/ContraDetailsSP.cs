using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ContraDetailsSP : DBConnection
	{
		public decimal ContraDetailsAdd(ContraDetailsInfo contradetailsinfo)
		{
			decimal deceffect = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ContraDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.ContraMasterId;
				sprmparam10 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.LedgerId;
				sprmparam10 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.Amount;
				sprmparam10 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam10.Value = contradetailsinfo.ChequeNo;
				sprmparam10 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam10.Value = contradetailsinfo.ChequeDate;
				sprmparam10 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.ExchangeRateId;
				sprmparam10 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = contradetailsinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = contradetailsinfo.Extra2;
				deceffect = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return deceffect;
		}

		public void ContraDetailsEdit(ContraDetailsInfo contradetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ContraDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@contraDetailsId", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.ContraDetailsId;
				sprmparam10 = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.ContraMasterId;
				sprmparam10 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.LedgerId;
				sprmparam10 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.Amount;
				sprmparam10 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam10.Value = contradetailsinfo.ExchangeRateId;
				sprmparam10 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam10.Value = contradetailsinfo.ChequeNo;
				sprmparam10 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam10.Value = contradetailsinfo.ChequeDate;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = contradetailsinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = contradetailsinfo.Extra2;
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

		public DataTable ContraDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ContraDetailsViewAll", base.sqlcon);
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

		public ContraDetailsInfo ContraDetailsView(decimal contraDetailsId)
		{
			ContraDetailsInfo contradetailsinfo = new ContraDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ContraDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@contraDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = contraDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					contradetailsinfo.ContraDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					contradetailsinfo.ContraMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					contradetailsinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					contradetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					contradetailsinfo.ChequeNo = ((DbDataReader)sdrreader)[4].ToString();
					contradetailsinfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					contradetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
					contradetailsinfo.Extra1 = ((DbDataReader)sdrreader)[7].ToString();
					contradetailsinfo.Extra2 = ((DbDataReader)sdrreader)[8].ToString();
					contradetailsinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)["Currency"].ToString());
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
			return contradetailsinfo;
		}

		public void ContraDetailsDelete(decimal ContraDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ContraDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@contraDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = ContraDetailsId;
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

		public int ContraDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ContraDetailsMax", base.sqlcon);
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

		public DataTable CashOrBankComboFill()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", base.sqlcon);
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

		public decimal ContraDetailsAddReturnWithhIdentity(ContraDetailsInfo contradetailsinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ContraDetailsAddReturnWithhIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
				sprmparam9.Value = contradetailsinfo.ContraMasterId;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = contradetailsinfo.LedgerId;
				sprmparam9 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam9.Value = contradetailsinfo.Amount;
				sprmparam9 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam9.Value = contradetailsinfo.ExchangeRateId;
				sprmparam9 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam9.Value = contradetailsinfo.ChequeNo;
				sprmparam9 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam9.Value = contradetailsinfo.ChequeDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = contradetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = contradetailsinfo.Extra2;
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

		public void ContraVoucherDelete(decimal ContraDetailsId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ContraVoucherDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
				sprmparam4.Value = ContraDetailsId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.Decimal);
				sprmparam4.Value = strVoucherNo;
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

		public DataTable ContraDetailsViewWithMasterId(decimal decpurchaseId)
		{
			DataTable dtblContraDetails = new DataTable();
			SqlDataAdapter sqlda = new SqlDataAdapter();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ContraDetailsViewWithMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal).Value = decpurchaseId;
				sqlda.SelectCommand = sqlcmd;
				sqlda.Fill(dtblContraDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblContraDetails;
		}
	}
}
