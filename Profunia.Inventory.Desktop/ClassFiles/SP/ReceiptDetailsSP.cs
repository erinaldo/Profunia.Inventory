using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ReceiptDetailsSP : DBConnection
	{
		public decimal ReceiptDetailsAdd(ReceiptDetailsInfo receiptdetailsinfo)
		{
			decimal decReceiptDetailsId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam9.Value = receiptdetailsinfo.ReceiptMasterId;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = receiptdetailsinfo.LedgerId;
				sprmparam9 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam9.Value = receiptdetailsinfo.Amount;
				sprmparam9 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam9.Value = receiptdetailsinfo.ExchangeRateId;
				sprmparam9 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam9.Value = receiptdetailsinfo.ChequeNo;
				sprmparam9 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam9.Value = receiptdetailsinfo.ChequeDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = receiptdetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = receiptdetailsinfo.Extra2;
				decReceiptDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decReceiptDetailsId;
		}

		public decimal ReceiptDetailsEdit(ReceiptDetailsInfo receiptdetailsinfo)
		{
			decimal decReceiptDetailsId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
				sprmparam10.Value = receiptdetailsinfo.ReceiptDetailsId;
				sprmparam10 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam10.Value = receiptdetailsinfo.ReceiptMasterId;
				sprmparam10 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam10.Value = receiptdetailsinfo.LedgerId;
				sprmparam10 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam10.Value = receiptdetailsinfo.Amount;
				sprmparam10 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam10.Value = receiptdetailsinfo.ExchangeRateId;
				sprmparam10 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam10.Value = receiptdetailsinfo.ChequeNo;
				sprmparam10 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam10.Value = receiptdetailsinfo.ChequeDate;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = receiptdetailsinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = receiptdetailsinfo.Extra2;
				decReceiptDetailsId = sccmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decReceiptDetailsId;
		}

		public DataTable ReceiptDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptDetailsViewAll", base.sqlcon);
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

		public ReceiptDetailsInfo ReceiptDetailsView(decimal receiptDetailsId)
		{
			ReceiptDetailsInfo receiptdetailsinfo = new ReceiptDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = receiptDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					receiptdetailsinfo.ReceiptDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					receiptdetailsinfo.ReceiptMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					receiptdetailsinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					receiptdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					receiptdetailsinfo.ChequeNo = ((DbDataReader)sdrreader)[4].ToString();
					receiptdetailsinfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					receiptdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
					receiptdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[7].ToString();
					receiptdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[8].ToString();
					receiptdetailsinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
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
			return receiptdetailsinfo;
		}

		public void ReceiptDetailsDelete(decimal ReceiptDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = ReceiptDetailsId;
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

		public int ReceiptDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptDetailsMax", base.sqlcon);
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

		public DataTable ReceiptDetailsViewByMasterId(decimal decreceiptMastertId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReceiptDetailsViewByMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decreceiptMastertId;
				SqlDataAdapter sqlda = new SqlDataAdapter();
				sqlda.SelectCommand = sccmd;
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
	}
}
