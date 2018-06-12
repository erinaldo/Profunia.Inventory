using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class MaterialReceiptMasterSP : DBConnection
	{
		public decimal MaterialReceiptMasterAdd(MaterialReceiptMasterInfo materialreceiptmasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam18 = new SqlParameter();
				sprmparam18 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam18.Value = materialreceiptmasterinfo.VoucherNo;
				sprmparam18 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam18.Value = materialreceiptmasterinfo.InvoiceNo;
				sprmparam18 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.SuffixPrefixId;
				sprmparam18 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.VoucherTypeId;
				sprmparam18 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam18.Value = materialreceiptmasterinfo.Date;
				sprmparam18 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.LedgerId;
				sprmparam18 = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.OrderMasterId;
				sprmparam18 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam18.Value = materialreceiptmasterinfo.Narration;
				sprmparam18 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.exchangeRateId;
				sprmparam18 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.TotalAmount;
				sprmparam18 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.UserId;
				sprmparam18 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam18.Value = materialreceiptmasterinfo.LrNo;
				sprmparam18 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam18.Value = materialreceiptmasterinfo.TransportationCompany;
				sprmparam18 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam18.Value = materialreceiptmasterinfo.FinancialYearId;
				sprmparam18 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam18.Value = materialreceiptmasterinfo.ExtraDate;
				sprmparam18 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam18.Value = materialreceiptmasterinfo.Extra1;
				sprmparam18 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam18.Value = materialreceiptmasterinfo.Extra2;
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

		public void MaterialReceiptMasterEdit(MaterialReceiptMasterInfo materialreceiptmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam19 = new SqlParameter();
				sprmparam19 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.MaterialReceiptMasterId;
				sprmparam19 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam19.Value = materialreceiptmasterinfo.VoucherNo;
				sprmparam19 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam19.Value = materialreceiptmasterinfo.InvoiceNo;
				sprmparam19 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.SuffixPrefixId;
				sprmparam19 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.VoucherTypeId;
				sprmparam19 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam19.Value = materialreceiptmasterinfo.Date;
				sprmparam19 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.LedgerId;
				sprmparam19 = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.OrderMasterId;
				sprmparam19 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam19.Value = materialreceiptmasterinfo.Narration;
				sprmparam19 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.exchangeRateId;
				sprmparam19 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.TotalAmount;
				sprmparam19 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.UserId;
				sprmparam19 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam19.Value = materialreceiptmasterinfo.LrNo;
				sprmparam19 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam19.Value = materialreceiptmasterinfo.TransportationCompany;
				sprmparam19 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam19.Value = materialreceiptmasterinfo.FinancialYearId;
				sprmparam19 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam19.Value = materialreceiptmasterinfo.ExtraDate;
				sprmparam19 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam19.Value = materialreceiptmasterinfo.Extra1;
				sprmparam19 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam19.Value = materialreceiptmasterinfo.Extra2;
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

		public DataTable MaterialReceiptMasterViewAll(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sccmd = new SqlCommand("MaterialReceiptRgistersearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam5.Value = strInvoiceNo;
				sprmparam5 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam5.Value = decLedgerId;
				sprmparam5 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam5.Value = FromDate;
				sprmparam5 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam5.Value = ToDate;
				sdaadapter.SelectCommand = sccmd;
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

		public DataTable MaterialReceiptReportViewAll(decimal decOrderId, string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, string strProductCode, DateTime FromDate, DateTime ToDate, string strStatus)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(int));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sccmd = new SqlCommand("MaterialReceiptReportsearch", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam9.Value = decOrderId;
				sprmparam9 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam9.Value = strInvoiceNo;
				sprmparam9 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam9.Value = decLedgerId;
				sprmparam9 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam9.Value = decVouchertypeId;
				sprmparam9 = sccmd.Parameters.Add("@strproductCode", SqlDbType.VarChar);
				sprmparam9.Value = strProductCode;
				sprmparam9 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam9.Value = FromDate;
				sprmparam9 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam9.Value = ToDate;
				sprmparam9 = sccmd.Parameters.Add("@condition", SqlDbType.VarChar);
				sprmparam9.Value = strStatus;
				sdaadapter.SelectCommand = sccmd;
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

		public decimal MaterialReceiptQuantityDetailsAgainstPurcahseInvoiceAndRejectionOut(decimal decMaterialReceiptDetailsId)
		{
			decimal decQty = 0m;
			object objQty2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptQuantityDetailsAgainstPurcahseInvoiceAndRejectionOut", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@materialReceiptDetilsId", SqlDbType.Decimal);
				sprmparam2.Value = decMaterialReceiptDetailsId;
				objQty2 = sccmd.ExecuteScalar();
				if (objQty2 != null)
				{
					decQty = Convert.ToDecimal(objQty2.ToString());
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
			return decQty;
		}

		public decimal MaterialReceiptMasterReferenceCheck(decimal decMaterialReceiptMasterId)
		{
			decimal decStatus = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decMaterialReceiptMasterId;
				decStatus = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStatus;
		}

		public decimal MaterialReceiptDetailsReferenceCheck(decimal decMaterialReceiptDetailsId)
		{
			decimal decStatus = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = decMaterialReceiptDetailsId;
				decStatus = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStatus;
		}

		public DataSet MaterialReceiptReportPrinting(decimal decCompanyId, string strInvoiceNo, string strStatus, decimal decLedgerId, string strProductCode, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, decimal decOrderMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam10.Value = decCompanyId;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam10.Value = strInvoiceNo;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam10.Value = decLedgerId;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@strProductCode", SqlDbType.VarChar);
				sprmparam10.Value = strProductCode;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam10.Value = decVouchertypeId;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam10.Value = FromDate;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam10.Value = ToDate;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@condition", SqlDbType.VarChar);
				sprmparam10.Value = strStatus;
				sprmparam10 = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam10.Value = decOrderMasterId;
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

		public MaterialReceiptMasterInfo MaterialReceiptMasterView(decimal materialReceiptMasterId)
		{
			MaterialReceiptMasterInfo materialreceiptmasterinfo = new MaterialReceiptMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = materialReceiptMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					materialreceiptmasterinfo.MaterialReceiptMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					materialreceiptmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					materialreceiptmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					materialreceiptmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					materialreceiptmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					materialreceiptmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					materialreceiptmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					materialreceiptmasterinfo.OrderMasterId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					materialreceiptmasterinfo.Narration = ((DbDataReader)sdrreader)[8].ToString();
					materialreceiptmasterinfo.exchangeRateId = Convert.ToDecimal(((DbDataReader)sdrreader)[9].ToString());
					materialreceiptmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					materialreceiptmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					materialreceiptmasterinfo.LrNo = ((DbDataReader)sdrreader)[12].ToString();
					materialreceiptmasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[13].ToString();
					materialreceiptmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[14].ToString());
					materialreceiptmasterinfo.Extra1 = ((DbDataReader)sdrreader)[15].ToString();
					materialreceiptmasterinfo.Extra2 = ((DbDataReader)sdrreader)[16].ToString();
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
			return materialreceiptmasterinfo;
		}

		public decimal MaterialReceiptDelete(decimal MaterialReceiptMasterId)
		{
			decimal decResult = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = MaterialReceiptMasterId;
				int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
				decResult = ((ineffeftedRow <= 0) ? 0m : 1m);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decResult;
		}

		public DataTable GetOrderNoCorrespondingtoLedgerForMaterialReceiptRpt(decimal decLedgerId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetOrderNoCorrespondingtoLedgerForMaterialReceiptRpt", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter2.Value = decLedgerId;
				sqldataadapter.Fill(dtbl);
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

		public decimal MaterialReceiptMasterGetMaxPlusOne(decimal decVoucherTypeId)
		{
			decimal max = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterMax", base.sqlcon);
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
			return max;
		}

		public string MaterialReceiptMasterGetMax(decimal decVoucherTypeId)
		{
			string max = "0";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterMax", base.sqlcon);
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

		public DataTable ShowMaterialReceiptNoForRejectionOut(decimal decLedgerId, decimal decRejectionOutMasterId, decimal decVoucherTypeId)
		{
			DataTable dtblRejectionOut = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ShowMaterialReceiptNoForRejectionOut", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam4.Value = decLedgerId;
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decRejectionOutMasterId;
				sprmparam4 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sdaadapter.Fill(dtblRejectionOut);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblRejectionOut;
		}

		public bool MaterialReceiptNumberCheckExistence(string strinvoiceNo, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MaterialReceiptNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam3.Value = strinvoiceNo;
				sprmparam3 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
				sprmparam3.Value = decVoucherTypeId;
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

		public DataTable MaterialReceiptNoCorrespondingToLedgerForReport(decimal decledgerid)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("GetMaterialReceiptNoCorrepondingToLedgerForReport", base.sqlcon);
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

		public DataSet MaterialReceiptPrinting(decimal decmaterialReceiptMasterId, decimal decCompanyId, decimal decOrderMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decmaterialReceiptMasterId;
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam4.Value = decCompanyId;
				sprmparam4 = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decOrderMasterId;
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

		public DataTable MaterialReceiptMasterViewByReceiptMasterId(decimal decMaterialReceiptMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptMasterViewByReceiptMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decMaterialReceiptMasterId;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}
	}
}
