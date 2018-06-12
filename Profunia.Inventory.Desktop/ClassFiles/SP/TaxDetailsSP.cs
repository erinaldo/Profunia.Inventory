using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class TaxDetailsSP : DBConnection
	{
		public void TaxDetailsAdd(TaxDetailsInfo taxdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
				sprmparam7.Value = taxdetailsinfo.TaxdetailsId;
				sprmparam7 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = taxdetailsinfo.TaxId;
				sprmparam7 = sccmd.Parameters.Add("@selectedtaxId", SqlDbType.Decimal);
				sprmparam7.Value = taxdetailsinfo.SelectedtaxId;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = taxdetailsinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = taxdetailsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = taxdetailsinfo.Extra2;
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

		public void TaxDetailsEdit(TaxDetailsInfo taxdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
				sprmparam7.Value = taxdetailsinfo.TaxdetailsId;
				sprmparam7 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = taxdetailsinfo.TaxId;
				sprmparam7 = sccmd.Parameters.Add("@selectedtaxId", SqlDbType.Decimal);
				sprmparam7.Value = taxdetailsinfo.SelectedtaxId;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = taxdetailsinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = taxdetailsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = taxdetailsinfo.Extra2;
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

		public DataTable TaxDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxDetailsViewAll", base.sqlcon);
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

		public TaxDetailsInfo TaxDetailsView(decimal taxdetailsId)
		{
			TaxDetailsInfo taxdetailsinfo = new TaxDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
				sprmparam2.Value = taxdetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					taxdetailsinfo.TaxdetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					taxdetailsinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					taxdetailsinfo.SelectedtaxId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					taxdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					taxdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					taxdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return taxdetailsinfo;
		}

		public void TaxDetailsDelete(decimal TaxdetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
				sprmparam2.Value = TaxdetailsId;
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

		public int TaxDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDetailsMax", base.sqlcon);
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

		public void TaxDetailsAddWithoutId(TaxDetailsInfo taxdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDetailsAddWithoutId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam5.Value = taxdetailsinfo.TaxId;
				sprmparam5 = sccmd.Parameters.Add("@selectedtaxId", SqlDbType.Decimal);
				sprmparam5.Value = taxdetailsinfo.SelectedtaxId;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = taxdetailsinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = taxdetailsinfo.Extra2;
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

		public void TaxDetailsDeleteWithTaxId(decimal TaxdetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDetailsDeleteWithTaxId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam2.Value = TaxdetailsId;
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

		public DataTable TaxDetailsViewallByTaxId(decimal decTaxId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxDetailsViewallByTaxId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam2.Value = decTaxId;
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
