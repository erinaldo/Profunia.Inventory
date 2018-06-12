using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseReturnBilltaxSP : DBConnection
	{
		public void PurchaseReturnBilltaxAdd(PurchaseReturnBilltaxInfo purchasereturnbilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam6.Value = purchasereturnbilltaxinfo.PurchaseReturnMasterId;
				sprmparam6 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam6.Value = purchasereturnbilltaxinfo.TaxId;
				sprmparam6 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam6.Value = purchasereturnbilltaxinfo.TaxAmount;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = purchasereturnbilltaxinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = purchasereturnbilltaxinfo.Extra2;
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

		public void PurchaseReturnBilltaxEdit(PurchaseReturnBilltaxInfo purchasereturnbilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@purchaseReturnBillTaxId", SqlDbType.Decimal);
				sprmparam8.Value = purchasereturnbilltaxinfo.PurchaseReturnBillTaxId;
				sprmparam8 = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
				sprmparam8.Value = purchasereturnbilltaxinfo.PurchaseReturnMasterId;
				sprmparam8 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam8.Value = purchasereturnbilltaxinfo.TaxId;
				sprmparam8 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam8.Value = purchasereturnbilltaxinfo.TaxAmount;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = purchasereturnbilltaxinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = purchasereturnbilltaxinfo.Extra2;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = purchasereturnbilltaxinfo.ExtraDate;
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

		public DataTable PurchaseReturnBilltaxViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseReturnBilltaxViewAll", base.sqlcon);
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

		public PurchaseReturnBilltaxInfo PurchaseReturnBilltaxView(decimal purchaseReturnBillTaxId)
		{
			PurchaseReturnBilltaxInfo purchasereturnbilltaxinfo = new PurchaseReturnBilltaxInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseReturnBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseReturnBillTaxId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchasereturnbilltaxinfo.PurchaseReturnBillTaxId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					purchasereturnbilltaxinfo.PurchaseReturnMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					purchasereturnbilltaxinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					purchasereturnbilltaxinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					purchasereturnbilltaxinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					purchasereturnbilltaxinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
					purchasereturnbilltaxinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
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
			return purchasereturnbilltaxinfo;
		}

		public void PurchaseReturnBilltaxDelete(decimal PurchaseReturnBillTaxId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseReturnBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseReturnBillTaxId;
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

		public int PurchaseReturnBilltaxGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxMax", base.sqlcon);
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
	}
}
