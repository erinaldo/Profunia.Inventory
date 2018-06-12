using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesMasterSP : DBConnection
	{
		public decimal SalesMasterAdd(SalesMasterInfo salesmasterinfo)
		{
			decimal decSalesMasterId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam31 = new SqlParameter();
				sprmparam31 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.VoucherNo;
				sprmparam31 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.InvoiceNo;
				sprmparam31 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.VoucherTypeId;
				sprmparam31 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.SuffixPrefixId;
				sprmparam31 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam31.Value = salesmasterinfo.Date;
				sprmparam31 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam31.Value = salesmasterinfo.CreditPeriod;
				sprmparam31 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.LedgerId;
				sprmparam31 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.PricinglevelId;
				sprmparam31 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.EmployeeId;
				sprmparam31 = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.SalesAccount;
				sprmparam31 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.DeliveryNoteMasterId;
				sprmparam31 = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.OrderMasterId;
				sprmparam31 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.Narration;
				sprmparam31 = sccmd.Parameters.Add("@customerName", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.CustomerName;
				sprmparam31 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.ExchangeRateId;
				sprmparam31 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.TaxAmount;
				sprmparam31 = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.AdditionalCost;
				sprmparam31 = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.BillDiscount;
				sprmparam31 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.GrandTotal;
				sprmparam31 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.TotalAmount;
				sprmparam31 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.UserId;
				sprmparam31 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.LrNo;
				sprmparam31 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.TransportationCompany;
				sprmparam31 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.QuotationMasterId;
				sprmparam31 = sccmd.Parameters.Add("@POS", SqlDbType.Bit);
				sprmparam31.Value = salesmasterinfo.POS;
				sprmparam31 = sccmd.Parameters.Add("@counterId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.CounterId;
				sprmparam31 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam31.Value = salesmasterinfo.FinancialYearId;
				sprmparam31 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam31.Value = salesmasterinfo.ExtraDate;
				sprmparam31 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.Extra1;
				sprmparam31 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam31.Value = salesmasterinfo.Extra2;
				decSalesMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decSalesMasterId;
		}

		public void SalesMasterEdit(SalesMasterInfo salesmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam32 = new SqlParameter();
				sprmparam32 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.SalesMasterId;
				sprmparam32 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.VoucherNo;
				sprmparam32 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.InvoiceNo;
				sprmparam32 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.VoucherTypeId;
				sprmparam32 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.SuffixPrefixId;
				sprmparam32 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam32.Value = salesmasterinfo.Date;
				sprmparam32 = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
				sprmparam32.Value = salesmasterinfo.CreditPeriod;
				sprmparam32 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.LedgerId;
				sprmparam32 = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.PricinglevelId;
				sprmparam32 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.EmployeeId;
				sprmparam32 = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.SalesAccount;
				sprmparam32 = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.DeliveryNoteMasterId;
				sprmparam32 = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.OrderMasterId;
				sprmparam32 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.Narration;
				sprmparam32 = sccmd.Parameters.Add("@customerName", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.CustomerName;
				sprmparam32 = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.ExchangeRateId;
				sprmparam32 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.TaxAmount;
				sprmparam32 = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.AdditionalCost;
				sprmparam32 = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.BillDiscount;
				sprmparam32 = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.GrandTotal;
				sprmparam32 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.TotalAmount;
				sprmparam32 = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.UserId;
				sprmparam32 = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.LrNo;
				sprmparam32 = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.TransportationCompany;
				sprmparam32 = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.QuotationMasterId;
				sprmparam32 = sccmd.Parameters.Add("@POS", SqlDbType.Bit);
				sprmparam32.Value = salesmasterinfo.POS;
				sprmparam32 = sccmd.Parameters.Add("@counterId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.CounterId;
				sprmparam32 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam32.Value = salesmasterinfo.FinancialYearId;
				sprmparam32 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam32.Value = salesmasterinfo.ExtraDate;
				sprmparam32 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.Extra1;
				sprmparam32 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam32.Value = salesmasterinfo.Extra2;
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

		public DataTable SalesMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesMasterViewAll", base.sqlcon);
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

		public SalesMasterInfo SalesMasterView(decimal salesMasterId)
		{
			SalesMasterInfo salesmasterinfo = new SalesMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesmasterinfo.SalesMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salesmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					salesmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					salesmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salesmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					salesmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					salesmasterinfo.CreditPeriod = int.Parse(((DbDataReader)sdrreader)[6].ToString());
					salesmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					salesmasterinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					salesmasterinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					salesmasterinfo.SalesAccount = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					salesmasterinfo.DeliveryNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					salesmasterinfo.OrderMasterId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					salesmasterinfo.Narration = ((DbDataReader)sdrreader)[13].ToString();
					salesmasterinfo.CustomerName = ((DbDataReader)sdrreader)[14].ToString();
					salesmasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					salesmasterinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[16].ToString());
					salesmasterinfo.AdditionalCost = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
					salesmasterinfo.BillDiscount = decimal.Parse(((DbDataReader)sdrreader)[18].ToString());
					salesmasterinfo.GrandTotal = decimal.Parse(((DbDataReader)sdrreader)[19].ToString());
					salesmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[20].ToString());
					salesmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[21].ToString());
					salesmasterinfo.LrNo = ((DbDataReader)sdrreader)[22].ToString();
					salesmasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[23].ToString();
					salesmasterinfo.QuotationMasterId = decimal.Parse(((DbDataReader)sdrreader)[24].ToString());
					salesmasterinfo.POS = bool.Parse(((DbDataReader)sdrreader)[25].ToString());
					salesmasterinfo.CounterId = decimal.Parse(((DbDataReader)sdrreader)[26].ToString());
					salesmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[27].ToString());
					salesmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[28].ToString());
					salesmasterinfo.Extra1 = ((DbDataReader)sdrreader)[29].ToString();
					salesmasterinfo.Extra2 = ((DbDataReader)sdrreader)[30].ToString();
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
			return salesmasterinfo;
		}

		public SalesMasterInfo SalesMasterView(string salesMasterId)
		{
			SalesMasterInfo salesmasterinfo = new SalesMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesmasterinfo.SalesMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salesmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					salesmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					salesmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salesmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					salesmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					salesmasterinfo.CreditPeriod = int.Parse(((DbDataReader)sdrreader)[6].ToString());
					salesmasterinfo.LedgerId = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					salesmasterinfo.PricinglevelId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					salesmasterinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[9].ToString());
					salesmasterinfo.SalesAccount = decimal.Parse(((DbDataReader)sdrreader)[10].ToString());
					salesmasterinfo.DeliveryNoteMasterId = decimal.Parse(((DbDataReader)sdrreader)[11].ToString());
					salesmasterinfo.OrderMasterId = decimal.Parse(((DbDataReader)sdrreader)[12].ToString());
					salesmasterinfo.Narration = ((DbDataReader)sdrreader)[13].ToString();
					salesmasterinfo.CustomerName = ((DbDataReader)sdrreader)[14].ToString();
					salesmasterinfo.ExchangeRateId = decimal.Parse(((DbDataReader)sdrreader)[15].ToString());
					salesmasterinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[16].ToString());
					salesmasterinfo.AdditionalCost = decimal.Parse(((DbDataReader)sdrreader)[17].ToString());
					salesmasterinfo.BillDiscount = decimal.Parse(((DbDataReader)sdrreader)[18].ToString());
					salesmasterinfo.GrandTotal = decimal.Parse(((DbDataReader)sdrreader)[19].ToString());
					salesmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[20].ToString());
					salesmasterinfo.UserId = decimal.Parse(((DbDataReader)sdrreader)[21].ToString());
					salesmasterinfo.LrNo = ((DbDataReader)sdrreader)[22].ToString();
					salesmasterinfo.TransportationCompany = ((DbDataReader)sdrreader)[23].ToString();
					salesmasterinfo.QuotationMasterId = decimal.Parse(((DbDataReader)sdrreader)[24].ToString());
					salesmasterinfo.POS = bool.Parse(((DbDataReader)sdrreader)[25].ToString());
					salesmasterinfo.CounterId = decimal.Parse(((DbDataReader)sdrreader)[26].ToString());
					salesmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[27].ToString());
					salesmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[28].ToString());
					salesmasterinfo.Extra1 = ((DbDataReader)sdrreader)[29].ToString();
					salesmasterinfo.Extra2 = ((DbDataReader)sdrreader)[30].ToString();
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
			return salesmasterinfo;
		}

		public void SalesMasterDelete(decimal SalesMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = SalesMasterId;
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

		public int SalesMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterMax", base.sqlcon);
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

		public DataTable SalesInvoiceSalesAccountModeComboFill()
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceSalesAccountModeComboFill", base.sqlcon);
			sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
			sqlda.Fill(dtbl);
			return dtbl;
		}

		public decimal SalesMasterVoucherMax(decimal decVoucherTypeId)
		{
			decimal decVoucherNoMax = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterVoucherMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				decVoucherNoMax = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decVoucherNoMax;
		}

		public DataTable SalesMasterViewByInvoiceNoForComboSelection(decimal salesMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesMasterViewForComboFillSelection", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.VarChar);
				sqlparameter2.Value = salesMasterId;
				sqldataadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Account Suit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public SalesMasterInfo SalesMasterViewBySalesMasterId(decimal salesMasterId)
		{
			SalesMasterInfo infoSalesMaster = new SalesMasterInfo();
			SqlDataReader sdrreader2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterViewBySalesMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = salesMasterId;
				sdrreader2 = sccmd.ExecuteReader();
				while (sdrreader2.Read())
				{
					infoSalesMaster.InvoiceNo = ((DbDataReader)sdrreader2)["invoiceNo"].ToString();
					infoSalesMaster.VoucherNo = ((DbDataReader)sdrreader2)["voucherNo"].ToString();
					infoSalesMaster.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sdrreader2)["voucherTypeId"].ToString());
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
			return infoSalesMaster;
		}

		public ProductInfo ProductViewByProductIdforSalesInvoice(string strproductCode)
		{
			ProductInfo productinfo = new ProductInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductViewByProductIdforSalesInvoice", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = strproductCode;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					productinfo.ProductId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					productinfo.ProductCode = ((DbDataReader)sdrreader)[1].ToString();
					productinfo.ProductName = ((DbDataReader)sdrreader)[2].ToString();
					productinfo.GroupId = Convert.ToDecimal(((DbDataReader)sdrreader)[3].ToString());
					productinfo.BrandId = Convert.ToDecimal(((DbDataReader)sdrreader)[4].ToString());
					productinfo.UnitId = Convert.ToDecimal(((DbDataReader)sdrreader)[5].ToString());
					productinfo.SizeId = Convert.ToDecimal(((DbDataReader)sdrreader)[6].ToString());
					productinfo.ModelNoId = Convert.ToDecimal(((DbDataReader)sdrreader)[7].ToString());
					productinfo.TaxId = Convert.ToDecimal(((DbDataReader)sdrreader)[8].ToString());
					productinfo.TaxapplicableOn = ((DbDataReader)sdrreader)[9].ToString();
					productinfo.PurchaseRate = Convert.ToDecimal(((DbDataReader)sdrreader)[10].ToString());
					productinfo.SalesRate = Convert.ToDecimal(((DbDataReader)sdrreader)[11].ToString());
					productinfo.Mrp = Convert.ToDecimal(((DbDataReader)sdrreader)[12].ToString());
					productinfo.MinimumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[13].ToString());
					productinfo.MaximumStock = Convert.ToDecimal(((DbDataReader)sdrreader)[14].ToString());
					productinfo.ReorderLevel = Convert.ToDecimal(((DbDataReader)sdrreader)[15].ToString());
					productinfo.GodownId = Convert.ToDecimal(((DbDataReader)sdrreader)[16].ToString());
					productinfo.RackId = Convert.ToDecimal(((DbDataReader)sdrreader)[17].ToString());
					productinfo.IsallowBatch = bool.Parse(((DbDataReader)sdrreader)[18].ToString());
					productinfo.Ismultipleunit = bool.Parse(((DbDataReader)sdrreader)[19].ToString());
					productinfo.IsBom = bool.Parse(((DbDataReader)sdrreader)[20].ToString());
					productinfo.Isopeningstock = bool.Parse(((DbDataReader)sdrreader)[21].ToString());
					productinfo.Narration = ((DbDataReader)sdrreader)[22].ToString();
					productinfo.IsActive = bool.Parse(((DbDataReader)sdrreader)[23].ToString());
					productinfo.IsshowRemember = bool.Parse(((DbDataReader)sdrreader)[24].ToString());
					productinfo.Extra1 = ((DbDataReader)sdrreader)[25].ToString();
					productinfo.Extra2 = ((DbDataReader)sdrreader)[26].ToString();
					productinfo.ExtraDate = PublicVariables._dtCurrentDate;
					productinfo.PartNo = ((DbDataReader)sdrreader)[28].ToString();
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
			return productinfo;
		}

		public bool SalesInvoiceInvoiceNumberCheckExistence(string strvoucherNo, decimal decsalesMasterId, decimal decVoucherTypeId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesInvoiceInvoiceNumberCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strvoucherNo;
				sprmparam4 = sqlcmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decsalesMasterId;
				sprmparam4 = sqlcmd.Parameters.Add("@vouchertypeId", SqlDbType.Decimal);
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

		public DataSet salesInvoicePrintAfterSave(decimal decsalesMasterId, decimal decCompanyId, decimal decOrderMasterId, decimal decDeliveryNoteMasterId, decimal decQuotationMasterId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("salesInvoicePrintAfterSave", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam6.Value = decsalesMasterId;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam6.Value = decCompanyId;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
				sprmparam6.Value = decOrderMasterId;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
				sprmparam6.Value = decDeliveryNoteMasterId;
				sprmparam6 = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
				sprmparam6.Value = decQuotationMasterId;
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

		public bool SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(decimal decPartyId)
		{
			bool isBillByBill = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam2.Value = decPartyId;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isBillByBill = true;
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
			return isBillByBill;
		}

		public DataTable SalesInvoiceRegisterGridfill(DateTime dtFrom, DateTime dtTo, decimal decVoucherType, decimal decLedgerId, string strVoucherNo, string strSalesMode)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("dgvTxtSlno", typeof(decimal));
			dtbl.Columns["dgvTxtSlno"].AutoIncrement = true;
			dtbl.Columns["dgvTxtSlno"].AutoIncrementSeed = 1L;
			dtbl.Columns["dgvTxtSlno"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceRegisterGridfill", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter7 = new SqlParameter();
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter7.Value = dtFrom;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter7.Value = dtTo;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter7.Value = decVoucherType;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter7.Value = decLedgerId;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sqlparameter7.Value = strVoucherNo;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@salesMode", SqlDbType.VarChar);
				sqlparameter7.Value = strSalesMode;
				sqldataadapter.Fill(dtbl);
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

		public DataTable SalesInvoiceSalesMasterViewBySalesMasterId(decimal decSalesMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceSalesMasterViewBySalesMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.VarChar);
				sqlparameter2.Value = decSalesMasterId;
				sqldataadapter.Fill(dtbl);
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

		public DataTable SalesInvoiceAdditionalCostViewByVoucherNoUnderVoucherType(decimal decVoucherTypeId, string strVoucherNo)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceAdditionalCostViewByVoucherNoUnderVoucherType", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter3.Value = decVoucherTypeId;
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sqlparameter3.Value = strVoucherNo;
				sqldataadapter.Fill(dtbl);
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

		public DataTable salesinvoiceAdditionalCostCheckdrOrCrforSiEdit(decimal decVoucherTypeId, string strVoucherNo)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("salesinvoiceAdditionalCostCheckdrOrCrforSiEdit", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter3 = new SqlParameter();
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter3.Value = decVoucherTypeId;
				sqlparameter3 = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sqlparameter3.Value = strVoucherNo;
				sqldataadapter.Fill(dtbl);
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

		public decimal SalesInvoiceReferenceCheckForEdit(decimal decSalesMasterId)
		{
			decimal decStatus = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesInvoiceReferenceCheckForEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesMasterId;
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

		public decimal SalesInvoiceQuantityDetailsAgainstSalesReturn(decimal decvoucherTypeId, string strvoucherNo)
		{
			decimal decQty = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesInvoiceQuantityDetailsAgainstSalesReturn", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decvoucherTypeId;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strvoucherNo;
				decQty = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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

		public void SalesInvoiceDelete(decimal decSalesMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesInvoiceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decSalesMasterId;
				sprmparam4 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
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

		public bool SalesReturnCheckReferenceForSIDelete(decimal decSalesMasterId)
		{
			bool isReferenceExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnCheckReferenceForSIDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decSalesMasterId;
				isReferenceExist = Convert.ToBoolean(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("SMSP:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isReferenceExist;
		}

		public DataTable SalesInvoiceReportFill(DateTime dtfromDate, DateTime dttoDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decAreaId, string strSalesMode, decimal decEmployeeId, string strProductName, string strVoucherNo, string strstatus, decimal decRouteId, decimal decModelNoId, string strProductCode)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceReportFill", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter14 = new SqlParameter();
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter14.Value = dtfromDate;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter14.Value = dttoDate;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter14.Value = decVoucherTypeId;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter14.Value = decLedgerId;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal);
				sqlparameter14.Value = decAreaId;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@salesMode", SqlDbType.VarChar);
				sqlparameter14.Value = strSalesMode;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sqlparameter14.Value = decEmployeeId;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sqlparameter14.Value = strProductName;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sqlparameter14.Value = strVoucherNo;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
				sqlparameter14.Value = strstatus;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@routeId", SqlDbType.Decimal);
				sqlparameter14.Value = decRouteId;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@modelnoId", SqlDbType.Decimal);
				sqlparameter14.Value = decModelNoId;
				sqlparameter14 = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sqlparameter14.Value = strProductCode;
				sqldataadapter.Fill(dtbl);
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

		public DataTable POSSalesMasterViewBySalesMasterId(decimal decSalesMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("POSSalesMasterViewBySalesMasterId", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.VarChar);
				sqlparameter2.Value = decSalesMasterId;
				sqldataadapter.Fill(dtbl);
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

		public DataSet salesInvoiceReportPrint(DateTime fromDate, DateTime toDate, decimal voucherTypeId, decimal ledgerId, decimal areaId, string salesMode, decimal employeeId, string productName, string voucherNo, string status, decimal routeId, decimal modelnoId, string productCode, decimal companyId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("salesInvoiceReportPrint", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter15 = new SqlParameter();
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter15.Value = fromDate;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter15.Value = toDate;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter15.Value = voucherTypeId;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter15.Value = ledgerId;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal);
				sqlparameter15.Value = areaId;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@salesMode", SqlDbType.VarChar);
				sqlparameter15.Value = salesMode;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sqlparameter15.Value = employeeId;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
				sqlparameter15.Value = productName;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sqlparameter15.Value = voucherNo;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
				sqlparameter15.Value = status;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@routeId", SqlDbType.Decimal);
				sqlparameter15.Value = routeId;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@modelnoId", SqlDbType.Decimal);
				sqlparameter15.Value = modelnoId;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sqlparameter15.Value = productCode;
				sqlparameter15 = sqldataadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sqlparameter15.Value = companyId;
				sqldataadapter.Fill(ds);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public bool DayBookSalesInvoiceOrPOS(decimal decSalesMasterId, decimal decVoucherTypeId)
		{
			bool isPos = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("DayBookSalesInvoiceOrPOS", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal).Value = decSalesMasterId;
				sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				isPos = Convert.ToBoolean(sqlcmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isPos;
		}

		public DataTable FreeSaleReportGridFill(DateTime fromDate, DateTime toDate, string voucherNo, decimal voucherTypeId, decimal groupId, string productCode, decimal ledgerId, decimal decEmployeeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("FreeSaleReportGridFill", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter9 = new SqlParameter();
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter9.Value = fromDate;
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter9.Value = toDate;
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter9.Value = voucherTypeId;
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter9.Value = ledgerId;
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sqlparameter9.Value = decEmployeeId;
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sqlparameter9.Value = voucherNo;
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				sqlparameter9.Value = groupId;
				sqlparameter9 = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sqlparameter9.Value = productCode;
				sqldataadapter.Fill(dtbl);
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

		public DataSet FreeSaleReportPrint(DateTime fromDate, DateTime toDate, string voucherNo, decimal voucherTypeId, decimal groupId, string productCode, decimal ledgerId, decimal decEmployeeId, decimal decCompanyId)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("FreeSaleReportPrint", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter10 = new SqlParameter();
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter10.Value = fromDate;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter10.Value = toDate;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparameter10.Value = voucherTypeId;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter10.Value = ledgerId;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sqlparameter10.Value = decEmployeeId;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sqlparameter10.Value = voucherNo;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				sqlparameter10.Value = groupId;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
				sqlparameter10.Value = productCode;
				sqlparameter10 = sqldataadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sqlparameter10.Value = decCompanyId;
				sqldataadapter.Fill(ds);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public string SaleMasterGetPos(decimal saleMasterId, string voucherName)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SaleMasterGetPos", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@salemasterId", SqlDbType.Decimal).Value = saleMasterId;
				sccmd.Parameters.Add("@voucherName", SqlDbType.VarChar).Value = voucherName;
				return sccmd.ExecuteScalar().ToString();
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

		public decimal SalesMasterIdViewByvoucherNoAndVoucherType(decimal decVoucherTypeId, string strVoucherNo)
		{
			decimal decStock = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesMasterIdViewByvoucherNoAndVoucherType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decVoucherTypeId;
				sprmparam3 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam3.Value = strVoucherNo;
				decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decStock;
		}

		public int SalseMasterReferenceCheck(decimal decSalesMsterId, decimal decSalesDetailsId)
		{
			int inQty = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalseMasterReferenceCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decSalesMsterId;
				sprmparam3 = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
				sprmparam3.Value = decSalesDetailsId;
				inQty = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return inQty;
		}

		public decimal SalesReturnDetailsQtyViewBySalesDetailsId(decimal decSalseDetailsId)
		{
			decimal decQty = 0m;
			object objQty2 = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnDetailsQtyViewBySalesDetailsId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = decSalseDetailsId;
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
	}
}
