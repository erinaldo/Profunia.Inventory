using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class AdditionalCostSP : DBConnection
	{
		public void AdditionalCostAdd(AdditionalCostInfo additionalcostinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdditionalCostAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.VoucherTypeId;
				sprmparam9 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam9.Value = additionalcostinfo.VoucherNo;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.LedgerId;
				sprmparam9 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.Debit;
				sprmparam9 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.Credit;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = additionalcostinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = additionalcostinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = additionalcostinfo.Extra2;
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

		public void AdditionalCostEdit(AdditionalCostInfo additionalcostinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdditionalCostEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@additionalCostId", SqlDbType.Decimal);
				sprmparam10.Value = additionalcostinfo.AdditionalCostId;
				sprmparam10 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam10.Value = additionalcostinfo.VoucherTypeId;
				sprmparam10 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam10.Value = additionalcostinfo.VoucherNo;
				sprmparam10 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam10.Value = additionalcostinfo.LedgerId;
				sprmparam10 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam10.Value = additionalcostinfo.Debit;
				sprmparam10 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam10.Value = additionalcostinfo.Credit;
				sprmparam10 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam10.Value = additionalcostinfo.ExtraDate;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = additionalcostinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = additionalcostinfo.Extra2;
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

		public DataTable AdditionalCostViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AdditionalCostViewAll", base.sqlcon);
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

		public AdditionalCostInfo AdditionalCostView(decimal additionalCostId)
		{
			AdditionalCostInfo additionalcostinfo = new AdditionalCostInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdditionalCostView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@additionalCostId", SqlDbType.Decimal);
				sprmparam2.Value = additionalCostId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					additionalcostinfo.AdditionalCostId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					additionalcostinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					additionalcostinfo.VoucherNo = ((DbDataReader)sdrreader)[2].ToString();
					additionalcostinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					additionalcostinfo.Debit = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					additionalcostinfo.Credit = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					additionalcostinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
					additionalcostinfo.Extra1 = ((DbDataReader)sdrreader)[7].ToString();
					additionalcostinfo.Extra2 = ((DbDataReader)sdrreader)[8].ToString();
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
			return additionalcostinfo;
		}

		public void AdditionalCostDelete(decimal AdditionalCostId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdditionalCostDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@additionalCostId", SqlDbType.Decimal);
				sprmparam2.Value = AdditionalCostId;
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

		public int AdditionalCostGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdditionalCostMax", base.sqlcon);
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

		public DataTable AdditionalCostViewAllByVoucherTypeIdAndVoucherNo(decimal decVoucherTypeId, string strVoucherNo)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AdditionalCostViewAllByVoucherTypeIdAndVoucherNo", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public void AdditionalCostEditByVoucherTypeIdAndVoucherNo(AdditionalCostInfo additionalcostinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("AdditionalCostEditByVoucherTypeIdAndVoucherNo", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.VoucherTypeId;
				sprmparam9 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam9.Value = additionalcostinfo.VoucherNo;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.LedgerId;
				sprmparam9 = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.Debit;
				sprmparam9 = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
				sprmparam9.Value = additionalcostinfo.Credit;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = additionalcostinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = additionalcostinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = additionalcostinfo.Extra2;
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

		public DataSet StockJournalAdditionalCostForRegisteOrReport(string strVoucherNo, decimal decVoucherTypeId)
		{
			DataSet dsData = new DataSet();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalAdditionalCostForRegisteOrReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sqlda.Fill(dsData);
			}
			catch (Exception)
			{
				throw;
			}
			return dsData;
		}

		public void DeleteAdditionalCostForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("DeleteAdditionalCostForStockJournalEdit", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
				cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				cmd.ExecuteNonQuery();
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
