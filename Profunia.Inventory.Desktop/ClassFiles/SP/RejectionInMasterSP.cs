using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class RejectionInMasterSP : DBConnection
	{
		public decimal RejectionInMasterAdd(RejectionInMasterInfo rejectioninmasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionInMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectioninmasterinfo.VoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectioninmasterinfo.InvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.VoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.SuffixPrefixId;
				sprmparam19 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam19.Value = rejectioninmasterinfo.Date;
				sprmparam19 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.LedgerId;
				sprmparam19 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.DeliveryNoteMasterId;
				sprmparam19 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.PricinglevelId;
				sprmparam19 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.EmployeeId;
				sprmparam19 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam19.Value = rejectioninmasterinfo.Narration;
				sprmparam19 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.ExchangeRateId;
				sprmparam19 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.TotalAmount;
				sprmparam19 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.UserId;
				sprmparam19 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam19.Value = rejectioninmasterinfo.LrNo;
				sprmparam19 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam19.Value = rejectioninmasterinfo.TransportationCompany;
				sprmparam19 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam19.Value = rejectioninmasterinfo.FinancialYearId;
				sprmparam19 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam19.Value = rejectioninmasterinfo.Extra1;
				sprmparam19 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam19.Value = rejectioninmasterinfo.Extra2;
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

		public void RejectionInMasterEdit(RejectionInMasterInfo rejectioninmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionInMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam20 = new SqlParameter();
				sprmparam20 = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.RejectionInMasterId;
				sprmparam20 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam20.Value = rejectioninmasterinfo.VoucherNo;
				sprmparam20 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam20.Value = rejectioninmasterinfo.InvoiceNo;
				sprmparam20 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.VoucherTypeId;
				sprmparam20 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.SuffixPrefixId;
				sprmparam20 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam20.Value = rejectioninmasterinfo.Date;
				sprmparam20 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.LedgerId;
				sprmparam20 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.DeliveryNoteMasterId;
				sprmparam20 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.PricinglevelId;
				sprmparam20 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.EmployeeId;
				sprmparam20 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam20.Value = rejectioninmasterinfo.Narration;
				sprmparam20 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.ExchangeRateId;
				sprmparam20 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.TotalAmount;
				sprmparam20 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.UserId;
				sprmparam20 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam20.Value = rejectioninmasterinfo.LrNo;
				sprmparam20 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam20.Value = rejectioninmasterinfo.TransportationCompany;
				sprmparam20 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam20.Value = rejectioninmasterinfo.FinancialYearId;
				sprmparam20 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam20.Value = rejectioninmasterinfo.Extra1;
				sprmparam20 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam20.Value = rejectioninmasterinfo.Extra2;
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

		public DataTable CurrencyComboByDate(ComboBox cmbCurrency, DateTime date, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyComboByDate", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sdaadapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
				sqlparameter2.Value = date;
				sdaadapter.Fill(dtbl);
				if (isAll)
				{
					DataRow dRow = dtbl.NewRow();
					dRow["exchangeRateId"] = 0;
					dRow["currencyName"] = "All";
					dtbl.Rows.InsertAt(dRow, 0);
				}
				cmbCurrency.ValueMember = "exchangeRateId";
				cmbCurrency.DisplayMember = "currencyName";
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable DeliveryNoteNoComboFillToLedger(ComboBox cmbDeliveryNoteNo, decimal decLedgerId, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("GetDeliveryNoteNoCorrepondingToLedgerForReport", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
				sdaadapter.Fill(dtbl);
				cmbDeliveryNoteNo.SelectedIndex = -1;
				if (isAll)
				{
					DataRow dRow = dtbl.NewRow();
					dRow["deliveryNoteMasterId"] = 0;
					dRow["voucherNo"] = "All";
					dtbl.Rows.InsertAt(dRow, 0);
				}
				cmbDeliveryNoteNo.DataSource = dtbl;
				cmbDeliveryNoteNo.DisplayMember = "voucherNo";
				cmbDeliveryNoteNo.ValueMember = "deliveryNoteMasterId";
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

		public RejectionInMasterInfo RejectionInMasterView(decimal rejectionInMasterId)
		{
			RejectionInMasterInfo rejectioninmasterinfo = new RejectionInMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionInMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				sprmparam2.Value = rejectionInMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					rejectioninmasterinfo.RejectionInMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					rejectioninmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					rejectioninmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					rejectioninmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					rejectioninmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					rejectioninmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					rejectioninmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					rejectioninmasterinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					rejectioninmasterinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					rejectioninmasterinfo.Narration = ((DbDataReader)sdrreader)[9].ToString();
					rejectioninmasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					rejectioninmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					rejectioninmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					rejectioninmasterinfo.LrNo = ((DbDataReader)sdrreader)[13].ToString();
					rejectioninmasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[14].ToString();
					rejectioninmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					rejectioninmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[16].ToString());
					rejectioninmasterinfo.Extra1 = ((DbDataReader)sdrreader)[17].ToString();
					rejectioninmasterinfo.Extra2 = ((DbDataReader)sdrreader)[18].ToString();
					rejectioninmasterinfo.DeliveryNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[19].ToString());
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
			return rejectioninmasterinfo;
		}

		public bool RejectionInVoucherNoCheckExistence(string strvoucherNo, decimal decVoucherTypeId, decimal decMasterId)
		{
			bool trueOrfalse = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RejectionInVoucherNoCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strvoucherNo;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decMasterId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					trueOrfalse = (Convert.ToInt32(obj.ToString()) == 1 && true);
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

		internal DataSet RejectionInPrinting(decimal decRejectionInMasterId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param3 = new SqlParameter();
				param3 = sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				param3.Value = decRejectionInMasterId;
				param3 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				param3.Value = decCompanyId;
				sqlda.Fill(dSt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dSt;
		}

		public string GetRejectionInVoucherNo(decimal decRejectionInMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("RejectionInVoucherNoViewByRejectionInMstrId", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = cmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				param2.Value = decRejectionInMasterId;
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

		internal DataSet RejectionInReportPrinting(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decDlvryNteMstrId, decimal decEmployeeId, string strProductCode)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param9 = new SqlParameter();
				param9 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param9.Value = fromDate;
				param9 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param9.Value = toDate;
				param9 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				param9.Value = decVoucherTypeId;
				param9 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				param9.Value = strVoucherNo;
				param9 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				param9.Value = decLedgerId;
				param9 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				param9.Value = decDlvryNteMstrId;
				param9 = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				param9.Value = decEmployeeId;
				param9 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				param9.Value = strProductCode;
				sqlda.Fill(dSt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dSt;
		}

		public void RejectionInMasterAndDetailsDelete(decimal decRejectionInMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand cmd = new SqlCommand("RejectionInMasterAndDetailsDelete", base.sqlcon);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = cmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
				param2.Value = decRejectionInMasterId;
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

		public DataTable RejectionInRegisterFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strVoucherNo, decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInRegisterFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param6 = new SqlParameter();
				param6 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param6.Value = fromDate;
				param6 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param6.Value = toDate;
				param6 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				param6.Value = decLedgerId;
				param6 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				param6.Value = strVoucherNo;
				param6 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				param6.Value = decVoucherTypeId;
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

		public DataTable RejectionInReportFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decDeliveryNoteMasterId, decimal decEmployeeId, string strProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInReportFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("slNo", typeof(decimal));
				dtbl.Columns["slNo"].AutoIncrement = true;
				dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param9 = new SqlParameter();
				param9 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				param9.Value = fromDate;
				param9 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				param9.Value = toDate;
				param9 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				param9.Value = decVoucherTypeId;
				param9 = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				param9.Value = strVoucherNo;
				param9 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				param9.Value = decLedgerId;
				param9 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				param9.Value = decDeliveryNoteMasterId;
				param9 = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				param9.Value = decEmployeeId;
				param9 = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				param9.Value = strProductCode;
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

		public DataTable VoucherTypeSelectionFill(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeSelectionComboFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@strVoucherType", SqlDbType.VarChar).Value = strVoucherType;
				sdaadapter.Fill(dtbl);
				cmbVoucherType.SelectedIndex = -1;
				if (isAll)
				{
					DataRow dRow = dtbl.NewRow();
					dRow["voucherTypeName"] = "All";
					dRow["voucherTypeId"] = 0;
					dtbl.Rows.InsertAt(dRow, 0);
				}
				cmbVoucherType.DataSource = dtbl;
				cmbVoucherType.DisplayMember = "voucherTypeName";
				cmbVoucherType.ValueMember = "voucherTypeId";
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
