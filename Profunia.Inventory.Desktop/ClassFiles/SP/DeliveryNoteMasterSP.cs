using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DeliveryNoteMasterSP : DBConnection
	{
		public decimal DeliveryNoteMasterAdd(DeliveryNoteMasterInfo deliverynotemasterinfo)
		{
			decimal decDeliveryNoteMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam20 = new SqlParameter();
				sprmparam20 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam20.Value = deliverynotemasterinfo.VoucherNo;
				sprmparam20 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam20.Value = deliverynotemasterinfo.InvoiceNo;
				sprmparam20 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.VoucherTypeId;
				sprmparam20 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.SuffixPrefixId;
				sprmparam20 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam20.Value = deliverynotemasterinfo.Date;
				sprmparam20 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.LedgerId;
				sprmparam20 = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.OrderMasterId;
				sprmparam20 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.PricinglevelId;
				sprmparam20 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.EmployeeId;
				sprmparam20 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam20.Value = deliverynotemasterinfo.Narration;
				sprmparam20 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.ExchangeRateId;
				sprmparam20 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.TotalAmount;
				sprmparam20 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.UserId;
				sprmparam20 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam20.Value = deliverynotemasterinfo.LrNo;
				sprmparam20 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam20.Value = deliverynotemasterinfo.TransportationCompany;
				sprmparam20 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.QuotationMasterId;
				sprmparam20 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam20.Value = deliverynotemasterinfo.FinancialYearId;
				sprmparam20 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam20.Value = deliverynotemasterinfo.Extra1;
				sprmparam20 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam20.Value = deliverynotemasterinfo.Extra2;
				decDeliveryNoteMasterId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decDeliveryNoteMasterId;
		}

		public void DeliveryNoteMasterEdit(DeliveryNoteMasterInfo deliverynotemasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.DeliveryNoteMasterId;
				sprmparam19 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam19.Value = deliverynotemasterinfo.VoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = deliverynotemasterinfo.InvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.VoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.SuffixPrefixId;
				sprmparam19 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam19.Value = deliverynotemasterinfo.Date;
				sprmparam19 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.LedgerId;
				sprmparam19 = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.OrderMasterId;
				sprmparam19 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.PricinglevelId;
				sprmparam19 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.EmployeeId;
				sprmparam19 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam19.Value = deliverynotemasterinfo.Narration;
				sprmparam19 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.ExchangeRateId;
				sprmparam19 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.TotalAmount;
				sprmparam19 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.UserId;
				sprmparam19 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam19.Value = deliverynotemasterinfo.LrNo;
				sprmparam19 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam19.Value = deliverynotemasterinfo.TransportationCompany;
				sprmparam19 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.QuotationMasterId;
				sprmparam19 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam19.Value = deliverynotemasterinfo.FinancialYearId;
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

		public DataTable DeliveryNoteMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteMasterViewAll", base.sqlcon);
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

		public DeliveryNoteMasterInfo DeliveryNoteMasterView(decimal deliveryNoteMasterId)
		{
			DeliveryNoteMasterInfo deliverynotemasterinfo = new DeliveryNoteMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam2.Value = deliveryNoteMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					deliverynotemasterinfo.DeliveryNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					deliverynotemasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					deliverynotemasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					deliverynotemasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					deliverynotemasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					deliverynotemasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					deliverynotemasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					deliverynotemasterinfo.OrderMasterId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					deliverynotemasterinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					deliverynotemasterinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					deliverynotemasterinfo.Narration = ((DbDataReader)sdrreader)[10].ToString();
					deliverynotemasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					deliverynotemasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					deliverynotemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[13].ToString());
					deliverynotemasterinfo.LrNo = ((DbDataReader)sdrreader)[14].ToString();
					deliverynotemasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[15].ToString();
					deliverynotemasterinfo.QuotationMasterId = decimal.Parse(((DbDataReader)sdrreader)[16].ToString());
					deliverynotemasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
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
			return deliverynotemasterinfo;
		}

		public decimal DeliveryNoteMasterDelete(decimal DeliveryNoteMasterId)
		{
			decimal deliveryNoteId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam2.Value = DeliveryNoteMasterId;
				int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
				if (ineffeftedRow > 0)
				{
					deliveryNoteId = 1m;
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
			return deliveryNoteId;
		}

		public decimal StockPostDeletingForDeliveryNote(decimal decVoucherTypeId, string strVoucherNo, string strInvoiceNo)
		{
			decimal deliveryNoteId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("StockPostDeletingForDeliveryNote", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strInvoiceNo;
				sprmparam4 = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.Decimal);
				sprmparam4.Value = strVoucherNo;
				int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
				if (ineffeftedRow > 0)
				{
					deliveryNoteId = 1m;
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
			return deliveryNoteId;
		}

		public DataSet DeliveryNotePrinting(decimal decDeliveryNoteMasterId, decimal decCompanyId, decimal decOrderId, decimal decQuotationId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNotePrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decDeliveryNoteMasterId;
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam5.Value = decCompanyId;
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decOrderId;
				sprmparam5 = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam5.Value = decQuotationId;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public int DeliveryNoteMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterMax", base.sqlcon);
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

		public decimal DeliveryNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliverNoteMasterMax1", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ++max;
		}

		public string DeliveryNoteMasterMax1(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliverNoteMasterMax1", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				max = sccmd.ExecuteScalar().ToString();
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

		public DataTable DeliveryNoteNoCorrespondingToLedger(decimal decledgerid, decimal decrejectioninmasterid, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("GetDeliveryNoteNoCorrespondingtoLedger", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decledgerid;
				sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal).Value = decrejectioninmasterid;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public DeliveryNoteMasterInfo DeliveryNoteMasterViewSalesManAndPricing(decimal deliveryNoteMasterId)
		{
			DeliveryNoteMasterInfo deliverynotemasterinfo = new DeliveryNoteMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterViewSalesManAndPricing", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam2.Value = deliveryNoteMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					deliverynotemasterinfo.DeliveryNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)["deliveryNoteMasterId"].ToString());
					deliverynotemasterinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)["pricinglevelId"].ToString());
					deliverynotemasterinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)["employeeId"].ToString());
					deliverynotemasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)["exchangeRateId"].ToString());
					deliverynotemasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)["userId"].ToString());
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
			return deliverynotemasterinfo;
		}

		public string GetDeliveryNoteVoucherNo(decimal decDeliveryNoteMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("DeliveryNoteVoucherNoViewByDlvryNteMstrId", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = cmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				param2.Value = decDeliveryNoteMasterId;
				return cmd.ExecuteScalar().ToString();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable DeliveryNoteNoCorrespondingToLedgerForReport(decimal decledgerid)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("GetDeliveryNoteNoCorrepondingToLedgerForReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decledgerid;
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

		public DataTable GetDeleveryNoteNoIncludePendingCorrespondingtoLedgerForSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetDeleveryNoteNoIncludePendingCorrespondingtoLedgerForSI", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter4 = new SqlParameter();
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter4.Value = decLedgerId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlparameter4.Value = decSalesMasterId;
				sqlparameter4 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter4.Value = decVoucherTypeId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable SalesInvoiceGridfillAgainestDeliveryNote(decimal DecDeliveryNoteMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestDeliveryNote", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = DecDeliveryNoteMasterId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public bool DeliveryNotNumberCheckExistence(string strInvoiceNo, decimal decDeliveryNoteMasterId, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DeliveryNotNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam4.Value = strInvoiceNo;
				sprmparam4 = sqlcmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decDeliveryNoteMasterId;
				sprmparam4 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public DataTable DeliveryNoteInvoiceViewBasedOnDate(DateTime fromDate, DateTime toDate)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdlda = new SqlDataAdapter("DeliveryNoteInvoiceViewBasedOnDate", base.sqlcon);
				sdlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sdlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter3.Value = fromDate;
				sqlparameter3 = sdlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter3.Value = toDate;
				sdlda.Fill(dtbl);
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

		public DataTable DeliveryNoteRegisterGridFillCorrespondingToInvoiceNoAndLedger(string strInvoiceNo, decimal decLdger, DateTime fromDate, DateTime toDate, int inDecimalPlaces)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdlda = new SqlDataAdapter("DeliveryNoteRegisterGridFillCorrespondingToInvoiceNoAndLedger", base.sqlcon);
				sdlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter6 = new SqlParameter();
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				sqlparameter6 = sdlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sqlparameter6.Value = strInvoiceNo;
				sqlparameter6 = sdlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter6.Value = decLdger;
				sqlparameter6 = sdlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter6.Value = fromDate;
				sqlparameter6 = sdlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter6.Value = toDate;
				sqlparameter6 = sdlda.SelectCommand.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
				sqlparameter6.Value = inDecimalPlaces;
				sdlda.Fill(dtbl);
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

		public DeliveryNoteMasterInfo DeliveryNoteMasterViewAllByMasterId(decimal decDeliveryNoteMasterId)
		{
			DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
			SqlDataReader sdrReader2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DeliveryNoteMasterViewAllByMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sqlcmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				param2.Value = decDeliveryNoteMasterId;
				sdrReader2 = sqlcmd.ExecuteReader();
				while (sdrReader2.Read())
				{
					infoDeliveryNoteMaster.DeliveryNoteMasterId = decimal.Parse(((DbDataReader)sdrReader2)["deliveryNoteMasterId"].ToString());
					infoDeliveryNoteMaster.VoucherNo = ((DbDataReader)sdrReader2)["voucherNo"].ToString();
					infoDeliveryNoteMaster.InvoiceNo = ((DbDataReader)sdrReader2)["invoiceNo"].ToString();
					infoDeliveryNoteMaster.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sdrReader2)["voucherTypeId"].ToString());
					infoDeliveryNoteMaster.SuffixPrefixId = Convert.ToDecimal(((DbDataReader)sdrReader2)["suffixPrefixId"].ToString());
					infoDeliveryNoteMaster.Date = Convert.ToDateTime(((DbDataReader)sdrReader2)["date"].ToString());
					infoDeliveryNoteMaster.LedgerId = Convert.ToDecimal(((DbDataReader)sdrReader2)["ledgerId"].ToString());
					infoDeliveryNoteMaster.PricinglevelId = Convert.ToDecimal(((DbDataReader)sdrReader2)["pricingLevelId"].ToString());
					infoDeliveryNoteMaster.EmployeeId = Convert.ToDecimal(((DbDataReader)sdrReader2)["employeeId"].ToString());
					infoDeliveryNoteMaster.Narration = ((DbDataReader)sdrReader2)["narration"].ToString();
					infoDeliveryNoteMaster.SuffixPrefixId = Convert.ToDecimal(((DbDataReader)sdrReader2)["suffixPrefixId"].ToString());
					infoDeliveryNoteMaster.ExchangeRateId = Convert.ToDecimal(((DbDataReader)sdrReader2)["exchangeRateId"].ToString());
					infoDeliveryNoteMaster.TotalAmount = Convert.ToDecimal(((DbDataReader)sdrReader2)["totalAmount"].ToString());
					infoDeliveryNoteMaster.UserId = Convert.ToDecimal(((DbDataReader)sdrReader2)["userId"].ToString());
					infoDeliveryNoteMaster.TransportationCompany = ((DbDataReader)sdrReader2)["transportationCompany"].ToString();
					infoDeliveryNoteMaster.LrNo = ((DbDataReader)sdrReader2)["lrNo"].ToString();
					infoDeliveryNoteMaster.OrderMasterId = Convert.ToDecimal(((DbDataReader)sdrReader2)["orderMasterId"].ToString());
					infoDeliveryNoteMaster.QuotationMasterId = Convert.ToDecimal(((DbDataReader)sdrReader2)["quotationMasterId"].ToString());
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return infoDeliveryNoteMaster;
		}

		public DataTable DeliveryNoteReportGridBasedOnSalesQuotation(decimal decVoucherTypeId, int inNoOfDecimals)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridBasedOnSalesQuotation", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter3 = new SqlParameter();
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				sqlParameter3 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlParameter3.Value = decVoucherTypeId;
				sqlParameter3 = sqlda.SelectCommand.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
				sqlParameter3.Value = inNoOfDecimals;
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

		public DataTable DeliveryNoteReportGridBasedOnSalesOrder(decimal decVoucherTypeId, int inNoOfDecimals)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridBasedOnSalesOrder", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter3 = new SqlParameter();
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				sqlParameter3 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlParameter3.Value = decVoucherTypeId;
				sqlParameter3 = sqlda.SelectCommand.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
				sqlParameter3.Value = inNoOfDecimals;
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

		public DataTable DeliveryNoteReportGridFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decSalesMan, string strProdCod, string strVoucherNo, decimal decVoucherTypeId, string strStatus, int inDecimalPlaces, string strDeliveryMode, string strInvoiceNo, decimal decAgainstVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter12 = new SqlParameter();
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlParameter12.Value = fromDate;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlParameter12.Value = toDate;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlParameter12.Value = decLedgerId;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sqlParameter12.Value = decSalesMan;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sqlParameter12.Value = strProdCod;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sqlParameter12.Value = strVoucherNo;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sqlParameter12.Value = decVoucherTypeId;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@condition", SqlDbType.VarChar);
				sqlParameter12.Value = strStatus;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@DelMode", SqlDbType.VarChar);
				sqlParameter12.Value = strDeliveryMode;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sqlParameter12.Value = strInvoiceNo;
				sqlParameter12 = sqlda.SelectCommand.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
				sqlParameter12.Value = decAgainstVoucherTypeId;
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

		public DataTable DeliveryNoteReportGridFillCorrespondingToSalesOrder(decimal decSalesOrderId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridFillCorrespondingToSalesOrder", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter2 = new SqlParameter();
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				sqlParameter2 = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
				sqlParameter2.Value = decSalesOrderId;
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

		public DataTable DeliveryNoteReportGridFillCorrespondingToSalesQuotation(decimal decSalesQuotation)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridFillCorrespondingToSalesQuotation", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlParameter2 = new SqlParameter();
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				sqlParameter2 = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sqlParameter2.Value = decSalesQuotation;
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

		public DataSet DeliveryNoteReportPrinting(decimal decCompanyId, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus, string strDeliveryMode, string strInvoiceNo)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam9.Value = decCompanyId;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = decLedgerId;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = decVouchertypeId;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam9.Value = FromDate;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam9.Value = ToDate;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@condition", SqlDbType.VarChar);
				sprmparam9.Value = strStatus;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@DelMode", SqlDbType.VarChar);
				sprmparam9.Value = strDeliveryMode;
				sprmparam9 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam9.Value = strInvoiceNo;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public DataTable VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypesBasedOnTypeOfVouchers", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = typeOfVouchers;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable VoucherTypeViewAllCorrespondingToSalesOrderAndSalesQuotation()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeViewAllCorrespondingToSalesOrderAndSalesQuotation", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool DeliveryNoteCheckReferenceInSalesInvoice(decimal decDeliveryNoteMasterId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteCheckReferenceInSalesInvoice", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal).Value = decDeliveryNoteMasterId;
				isExist = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
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

		public bool DeliveryNoteMasterReferenceCheckRejectionIn(decimal decDeliveryNoteMasterId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterReferenceCheckRejectionIn", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal).Value = decDeliveryNoteMasterId;
				isExist = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
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

		public DataTable DeliveryNoteMasterReferenceCheckRejectionInQty(decimal decDeliveryNoteMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteMasterReferenceCheckRejectionInQty", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sdaadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				param2.Value = decDeliveryNoteMasterId;
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

		public DataTable DeliveryNoteMasterReferenceCheckSalesInvoiceQty(decimal decDeliveryNoteMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteMasterReferenceCheckSalesInvoiceQty", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sdaadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				param2.Value = decDeliveryNoteMasterId;
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
	}
}
