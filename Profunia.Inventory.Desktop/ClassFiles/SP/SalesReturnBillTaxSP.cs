using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalesReturnBillTaxSP : DBConnection
	{
		public void SalesReturnBillTaxAdd(SalesReturnBillTaxInfo salesreturnbilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam6.Value = salesreturnbilltaxinfo.SalesReturnMasterId;
				sprmparam6 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam6.Value = salesreturnbilltaxinfo.TaxId;
				sprmparam6 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam6.Value = salesreturnbilltaxinfo.TaxAmount;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = salesreturnbilltaxinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = salesreturnbilltaxinfo.Extra2;
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

		public void SalesReturnBillTaxEdit(SalesReturnBillTaxInfo salesreturnbilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@salesReturnBillTaxId", SqlDbType.Decimal);
				sprmparam8.Value = salesreturnbilltaxinfo.SalesReturnBillTaxId;
				sprmparam8 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam8.Value = salesreturnbilltaxinfo.SalesReturnMasterId;
				sprmparam8 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam8.Value = salesreturnbilltaxinfo.TaxId;
				sprmparam8 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam8.Value = salesreturnbilltaxinfo.TaxAmount;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = salesreturnbilltaxinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = salesreturnbilltaxinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = salesreturnbilltaxinfo.Extra2;
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

		public DataTable SalesReturnBillTaxViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnBillTaxViewAll", base.sqlcon);
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

		public SalesReturnBillTaxInfo SalesReturnBillTaxView(decimal salesReturnBillTaxId)
		{
			SalesReturnBillTaxInfo salesreturnbilltaxinfo = new SalesReturnBillTaxInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesReturnBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = salesReturnBillTaxId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salesreturnbilltaxinfo.SalesReturnBillTaxId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salesreturnbilltaxinfo.SalesReturnMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salesreturnbilltaxinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					salesreturnbilltaxinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salesreturnbilltaxinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					salesreturnbilltaxinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					salesreturnbilltaxinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return salesreturnbilltaxinfo;
		}

		public void SalesReturnBillTaxDelete(decimal SalesReturnBillTaxId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesReturnBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = SalesReturnBillTaxId;
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

		public int SalesReturnBillTaxGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxMax", base.sqlcon);
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

		public DataTable TaxDetailsViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxDetailsViewBySalesReturnMasterId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal).Value = decSalesReturnMasterId;
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

		public void SalesReturnBillTaxDeleteBySalesReturnMasterId(decimal SalesReturnMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxDeleteBySalesReturnMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
				sprmparam2.Value = SalesReturnMasterId;
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
