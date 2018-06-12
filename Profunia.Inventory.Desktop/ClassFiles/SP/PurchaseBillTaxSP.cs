using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PurchaseBillTaxSP : DBConnection
	{
		public void PurchaseBillTaxAdd(PurchaseBillTaxInfo purchasebilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseBillTaxAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam7.Value = purchasebilltaxinfo.PurchaseMasterId;
				sprmparam7 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = purchasebilltaxinfo.TaxId;
				sprmparam7 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam7.Value = purchasebilltaxinfo.TaxAmount;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = purchasebilltaxinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = purchasebilltaxinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = purchasebilltaxinfo.Extra2;
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

		public void PurchaseBillTaxEdit(PurchaseBillTaxInfo purchasebilltaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseBillTaxEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@purchaseBillTaxId", SqlDbType.Decimal);
				sprmparam8.Value = purchasebilltaxinfo.PurchaseBillTaxId;
				sprmparam8 = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam8.Value = purchasebilltaxinfo.PurchaseMasterId;
				sprmparam8 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam8.Value = purchasebilltaxinfo.TaxId;
				sprmparam8 = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
				sprmparam8.Value = purchasebilltaxinfo.TaxAmount;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = purchasebilltaxinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = purchasebilltaxinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = purchasebilltaxinfo.Extra2;
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

		public DataTable PurchaseBillTaxViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseBillTaxViewAll", base.sqlcon);
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

		public PurchaseBillTaxInfo PurchaseBillTaxView(decimal purchaseBillTaxId)
		{
			PurchaseBillTaxInfo purchasebilltaxinfo = new PurchaseBillTaxInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseBillTaxView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = purchaseBillTaxId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					purchasebilltaxinfo.PurchaseBillTaxId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					purchasebilltaxinfo.PurchaseMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					purchasebilltaxinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					purchasebilltaxinfo.TaxAmount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					purchasebilltaxinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					purchasebilltaxinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					purchasebilltaxinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return purchasebilltaxinfo;
		}

		public void PurchaseBillTaxDelete(decimal PurchaseBillTaxId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseBillTaxDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@purchaseBillTaxId", SqlDbType.Decimal);
				sprmparam2.Value = PurchaseBillTaxId;
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

		public int PurchaseBillTaxGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PurchaseBillTaxMax", base.sqlcon);
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

		public DataTable PurchaseBillTaxViewAllByPurchaseMasterId(decimal decPurchaseMasterId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseBillTaxViewAllByPurchaseMasterId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decPurchaseMasterId;
				sdaadapter.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}
	}
}
