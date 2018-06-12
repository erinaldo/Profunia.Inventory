using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PaymentDetailsSP : DBConnection
	{
		public decimal PaymentDetailsAdd(PaymentDetailsInfo paymentdetailsinfo)
		{
			decimal decPaymentDetailsId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam9.Value = paymentdetailsinfo.PaymentMasterId;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = paymentdetailsinfo.LedgerId;
				sprmparam9 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam9.Value = paymentdetailsinfo.Amount;
				sprmparam9 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam9.Value = paymentdetailsinfo.ExchangeRateId;
				sprmparam9 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam9.Value = paymentdetailsinfo.ChequeNo;
				sprmparam9 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam9.Value = paymentdetailsinfo.ChequeDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = paymentdetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = paymentdetailsinfo.Extra2;
				decPaymentDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decPaymentDetailsId;
		}

		public decimal PaymentDetailsEdit(PaymentDetailsInfo paymentdetailsinfo)
		{
			decimal decPaymentDetailsId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@paymentDetailsId", SqlDbType.Decimal);
				sprmparam10.Value = paymentdetailsinfo.PaymentDetailsId;
				sprmparam10 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam10.Value = paymentdetailsinfo.PaymentMasterId;
				sprmparam10 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam10.Value = paymentdetailsinfo.LedgerId;
				sprmparam10 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam10.Value = paymentdetailsinfo.Amount;
				sprmparam10 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam10.Value = paymentdetailsinfo.ExchangeRateId;
				sprmparam10 = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
				sprmparam10.Value = paymentdetailsinfo.ChequeNo;
				sprmparam10 = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
				sprmparam10.Value = paymentdetailsinfo.ChequeDate;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = paymentdetailsinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = paymentdetailsinfo.Extra2;
				decPaymentDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decPaymentDetailsId;
		}

		public DataTable PaymentDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentDetailsViewAll", base.sqlcon);
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

		public PaymentDetailsInfo PaymentDetailsView(decimal paymentDetailsId)
		{
			PaymentDetailsInfo paymentdetailsinfo = new PaymentDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@paymentDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = paymentDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					paymentdetailsinfo.PaymentDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					paymentdetailsinfo.PaymentMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					paymentdetailsinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					paymentdetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					paymentdetailsinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)["exchangeRateId"].ToString());
					paymentdetailsinfo.ChequeNo = ((DbDataReader)sdrreader)[4].ToString();
					paymentdetailsinfo.ChequeDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					paymentdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
					paymentdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[7].ToString();
					paymentdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[8].ToString();
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
			return paymentdetailsinfo;
		}

		public void PaymentDetailsDelete(decimal PaymentDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@paymentDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = PaymentDetailsId;
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

		public int PaymentDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentDetailsMax", base.sqlcon);
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

		public DataTable PaymentDetailsViewByMasterId(decimal paymentMastertId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PaymentDetailsViewByMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
				sprmparam2.Value = paymentMastertId;
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
