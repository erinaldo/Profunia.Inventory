using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class VoucherTypeTaxSP : DBConnection
	{
		public void VoucherTypeTaxAdd(VoucherTypeTaxInfo vouchertypetaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeTaxAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam5.Value = vouchertypetaxinfo.VoucherTypeId;
				sprmparam5 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam5.Value = vouchertypetaxinfo.TaxId;
				sprmparam5 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam5.Value = vouchertypetaxinfo.Extra1;
				sprmparam5 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam5.Value = vouchertypetaxinfo.Extra2;
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

		public void VoucherTypeTaxEdit(VoucherTypeTaxInfo vouchertypetaxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeTaxEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@voucherTypeTaxId", SqlDbType.Decimal);
				sprmparam7.Value = vouchertypetaxinfo.VoucherTypeTaxId;
				sprmparam7 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam7.Value = vouchertypetaxinfo.VoucherTypeId;
				sprmparam7 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = vouchertypetaxinfo.TaxId;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = vouchertypetaxinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = vouchertypetaxinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = vouchertypetaxinfo.Extra2;
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

		public DataTable VoucherTypeTaxViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeTaxViewAll", base.sqlcon);
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

		public VoucherTypeTaxInfo VoucherTypeTaxView(decimal voucherTypeTaxId)
		{
			VoucherTypeTaxInfo vouchertypetaxinfo = new VoucherTypeTaxInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeTaxView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeTaxId", SqlDbType.Decimal);
				sprmparam2.Value = voucherTypeTaxId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					vouchertypetaxinfo.VoucherTypeTaxId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					vouchertypetaxinfo.VoucherTypeId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					vouchertypetaxinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					vouchertypetaxinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					vouchertypetaxinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					vouchertypetaxinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return vouchertypetaxinfo;
		}

		public void VoucherTypeTaxDelete(decimal VoucherTypeTaxId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeTaxDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeTaxId", SqlDbType.Decimal);
				sprmparam2.Value = VoucherTypeTaxId;
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

		public int VoucherTypeTaxGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeTaxMax", base.sqlcon);
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

		public void DeleteVoucherTypeTaxUsingVoucherTypeId(decimal VoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DeleteVoucherTypeTaxUsingVoucherTypeId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = VoucherTypeId;
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
