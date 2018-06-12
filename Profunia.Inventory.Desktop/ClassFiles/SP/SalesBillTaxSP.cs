using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesBillTaxSP : DBConnection
	{
		public decimal SalesBillTaxAdd(SalesBillTaxInfo salesbilltaxinfo)
		{
			decimal dcSalesBillTaxId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesBillTaxAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam7.Value = salesbilltaxinfo.SalesMasterId;
				sprmparam7 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = salesbilltaxinfo.TaxId;
				sprmparam7 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam7.Value = salesbilltaxinfo.TaxAmount;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = salesbilltaxinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = salesbilltaxinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = salesbilltaxinfo.Extra2;
				dcSalesBillTaxId = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dcSalesBillTaxId;
		}

		public void SalesBillTaxEdit(SalesBillTaxInfo salesbilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesBillTaxEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@salesBillTaxId", SqlDbType.Decimal);
				sprmparam8.Value = salesbilltaxinfo.SalesBillTaxId;
				sprmparam8 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam8.Value = salesbilltaxinfo.SalesMasterId;
				sprmparam8 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam8.Value = salesbilltaxinfo.TaxId;
				sprmparam8 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam8.Value = salesbilltaxinfo.TaxAmount;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = salesbilltaxinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = salesbilltaxinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = salesbilltaxinfo.Extra2;
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

		public DataTable SalesBillTaxViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesBillTaxViewAll", base.sqlcon);
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

		public SalesBillTaxInfo SalesBillTaxView(decimal salesBillTaxId)
		{
			SalesBillTaxInfo salesbilltaxinfo = new SalesBillTaxInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesBillTaxView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = salesBillTaxId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesbilltaxinfo.SalesBillTaxId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salesbilltaxinfo.SalesMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salesbilltaxinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					salesbilltaxinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salesbilltaxinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					salesbilltaxinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					salesbilltaxinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return salesbilltaxinfo;
		}

		public void SalesBillTaxDelete(decimal SalesBillTaxId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesBillTaxDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = SalesBillTaxId;
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

		public int SalesBillTaxGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesBillTaxMax", base.sqlcon);
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

		public DataTable SalesInvoiceSalesBillTaxViewAllBySalesMasterId(decimal dcSalesmasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesInvoiceSalesBillTaxViewAllBySalesMasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sdaadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sqlparameter2.Value = dcSalesmasterId;
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

		public void SalesBillTaxEditBySalesMasterIdAndTaxId(SalesBillTaxInfo salesbilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesBillTaxEditBySalesMasterIdAndTaxId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
				sprmparam7.Value = salesbilltaxinfo.SalesMasterId;
				sprmparam7 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = salesbilltaxinfo.TaxId;
				sprmparam7 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam7.Value = salesbilltaxinfo.TaxAmount;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = salesbilltaxinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = salesbilltaxinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = salesbilltaxinfo.Extra2;
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
	}
}
