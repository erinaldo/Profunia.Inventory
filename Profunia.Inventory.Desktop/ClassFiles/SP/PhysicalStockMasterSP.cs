using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PhysicalStockMasterSP : DBConnection
	{
		public decimal PhysicalStockMasterAdd(PhysicalStockMasterInfo physicalstockmasterinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockMasterAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam11.Value = physicalstockmasterinfo.VoucherNo;
				sprmparam11 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam11.Value = physicalstockmasterinfo.InvoiceNo;
				sprmparam11 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam11.Value = physicalstockmasterinfo.SuffixPrefixId;
				sprmparam11 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam11.Value = physicalstockmasterinfo.VoucherTypeId;
				sprmparam11 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam11.Value = physicalstockmasterinfo.Date;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = physicalstockmasterinfo.Narration;
				sprmparam11 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam11.Value = physicalstockmasterinfo.TotalAmount;
				sprmparam11 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam11.Value = physicalstockmasterinfo.FinancialYearId;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = physicalstockmasterinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = physicalstockmasterinfo.Extra2;
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

		public void PhysicalStockMasterEdit(PhysicalStockMasterInfo physicalstockmasterinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockMasterEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam13.Value = physicalstockmasterinfo.PhysicalStockMasterId;
				sprmparam13 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam13.Value = physicalstockmasterinfo.VoucherNo;
				sprmparam13 = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sprmparam13.Value = physicalstockmasterinfo.InvoiceNo;
				sprmparam13 = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
				sprmparam13.Value = physicalstockmasterinfo.SuffixPrefixId;
				sprmparam13 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam13.Value = physicalstockmasterinfo.VoucherTypeId;
				sprmparam13 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam13.Value = physicalstockmasterinfo.Date;
				sprmparam13 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam13.Value = physicalstockmasterinfo.Narration;
				sprmparam13 = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
				sprmparam13.Value = physicalstockmasterinfo.TotalAmount;
				sprmparam13 = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
				sprmparam13.Value = physicalstockmasterinfo.FinancialYearId;
				sprmparam13 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam13.Value = physicalstockmasterinfo.ExtraDate;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = physicalstockmasterinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = physicalstockmasterinfo.Extra2;
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

		public DataTable PhysicalStockMasterViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PhysicalStockMasterViewAll", base.sqlcon);
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

		public PhysicalStockMasterInfo PhysicalStockMasterView(decimal physicalStockMasterId)
		{
			PhysicalStockMasterInfo physicalstockmasterinfo = new PhysicalStockMasterInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockMasterView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam2.Value = physicalStockMasterId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					physicalstockmasterinfo.PhysicalStockMasterId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					physicalstockmasterinfo.VoucherNo = ((DbDataReader)sdrreader)[1].ToString();
					physicalstockmasterinfo.InvoiceNo = ((DbDataReader)sdrreader)[2].ToString();
					physicalstockmasterinfo.SuffixPrefixId = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					physicalstockmasterinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					physicalstockmasterinfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					physicalstockmasterinfo.Narration = ((DbDataReader)sdrreader)[6].ToString();
					physicalstockmasterinfo.TotalAmount = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					physicalstockmasterinfo.FinancialYearId = decimal.Parse(((DbDataReader)sdrreader)[8].ToString());
					physicalstockmasterinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[9].ToString());
					physicalstockmasterinfo.Extra1 = ((DbDataReader)sdrreader)[10].ToString();
					physicalstockmasterinfo.Extra2 = ((DbDataReader)sdrreader)[11].ToString();
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
			return physicalstockmasterinfo;
		}

		public void PhysicalStockMasterDelete(decimal PhysicalStockMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockMasterDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam2.Value = PhysicalStockMasterId;
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

		public int PhysicalStockMasterGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PhysicalStockMasterMax", base.sqlcon);
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

		public decimal PhysicalStockMasterVoucherMax(decimal decVoucherTypeId)
		{
			decimal decVoucherNoMax = 0m;
			try
			{
				SqlCommand sccmd = new SqlCommand("PhysicalStockMasterVoucherMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				return Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception)
			{
				throw;
			}
		}

		public DataSet PhysicalStockPrinting(decimal decPhysicalStockMasterId, decimal decCompanyId)
		{
			DataSet dSt = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PhysicalStockPrinting", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam3.Value = decPhysicalStockMasterId;
				sprmparam3 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam3.Value = decCompanyId;
				sdaadapter.Fill(dSt);
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

		public DataTable PhysicalStockRegisterGridFill(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherNo)
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
				SqlCommand sccmd = new SqlCommand("PhysicalStockRegisterGridFill", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@dateFrom", SqlDbType.DateTime);
				sprmparam4.Value = dtDateFrom;
				sprmparam4 = sccmd.Parameters.Add("@dateTo", SqlDbType.DateTime);
				sprmparam4.Value = dtDateTo;
				sprmparam4 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				SqlDataAdapter sqlda = new SqlDataAdapter();
				sqlda.SelectCommand = sccmd;
				sqlda.Fill(dtbl);
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

		public DataTable PhysicalStockViewbyMasterId(decimal decPhysicalStockMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("PhysicalStockViewbyMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal).Value = decPhysicalStockMasterId;
				sdaadapter.SelectCommand = sqlcmd;
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

		public void PhysicalStockDelete(decimal decPhysicalStockMasterId, decimal decVoucherTypeId, string strVoucherNo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("PhysicalStockDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
				sprmparam4.Value = decPhysicalStockMasterId;
				sprmparam4 = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam4.Value = decVoucherTypeId;
				sprmparam4 = sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam4.Value = strVoucherNo;
				sqlcmd.ExecuteNonQuery();
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

		public DataTable PhysicalStockReportFill(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherNo, string strProductName, decimal decProductCode, decimal decVoucherTypeId)
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
				SqlCommand sccmd = new SqlCommand("PhysicalStockReportFill", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@dateFrom", SqlDbType.DateTime);
				sprmparam7.Value = dtDateFrom;
				sprmparam7 = sccmd.Parameters.Add("@dateTo", SqlDbType.DateTime);
				sprmparam7.Value = dtDateTo;
				sprmparam7 = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
				sprmparam7.Value = strVoucherNo;
				sprmparam7 = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
				sprmparam7.Value = strProductName;
				sprmparam7 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam7.Value = decProductCode;
				sprmparam7 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam7.Value = decVoucherTypeId;
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

		public decimal BatchViewByProductId(decimal decProductId)
		{
			decimal decStock = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BatchViewByProductId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
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
	}
}
