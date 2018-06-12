using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ServiceDetailsSP : DBConnection
	{
		public void ServiceDetailsAdd(ServiceDetailsInfo servicedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.ServiceDetailsId;
				sprmparam9 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.ServiceMasterId;
				sprmparam9 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.ServiceId;
				sprmparam9 = sccmd.Parameters.Add("@measure", SqlDbType.VarChar);
				sprmparam9.Value = servicedetailsinfo.Measure;
				sprmparam9 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.Amount;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = servicedetailsinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = servicedetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = servicedetailsinfo.Extra2;
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

		public decimal ServiceDetailsAddReturnWithIdentity(ServiceDetailsInfo servicedetailsinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDetailsAddReturnWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam8.Value = servicedetailsinfo.ServiceMasterId;
				sprmparam8 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam8.Value = servicedetailsinfo.ServiceId;
				sprmparam8 = sccmd.Parameters.Add("@measure", SqlDbType.VarChar);
				sprmparam8.Value = servicedetailsinfo.Measure;
				sprmparam8 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam8.Value = servicedetailsinfo.Amount;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = servicedetailsinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = servicedetailsinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = servicedetailsinfo.Extra2;
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

		public void ServiceDetailsEdit(ServiceDetailsInfo servicedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.ServiceDetailsId;
				sprmparam9 = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.ServiceMasterId;
				sprmparam9 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.ServiceId;
				sprmparam9 = sccmd.Parameters.Add("@measure", SqlDbType.VarChar);
				sprmparam9.Value = servicedetailsinfo.Measure;
				sprmparam9 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam9.Value = servicedetailsinfo.Amount;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = servicedetailsinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = servicedetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = servicedetailsinfo.Extra2;
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

		public DataTable ServiceDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceDetailsViewAll", base.sqlcon);
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

		public ServiceDetailsInfo ServiceDetailsView(decimal serviceDetailsId)
		{
			ServiceDetailsInfo servicedetailsinfo = new ServiceDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = serviceDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					servicedetailsinfo.ServiceDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					servicedetailsinfo.ServiceMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					servicedetailsinfo.ServiceId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					servicedetailsinfo.Measure = ((DbDataReader)sdrreader)[3].ToString();
					servicedetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					servicedetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					servicedetailsinfo.Extra1 = ((DbDataReader)sdrreader)[6].ToString();
					servicedetailsinfo.Extra2 = ((DbDataReader)sdrreader)[7].ToString();
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
			return servicedetailsinfo;
		}

		public void ServiceDetailsDelete(decimal ServiceDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = ServiceDetailsId;
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

		public int ServiceDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDetailsMax", base.sqlcon);
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

		public DataTable ServiceDetailsViewWithMasterId(decimal decServiceMasterId)
		{
			DataTable dtblServiceDetails = new DataTable();
			dtblServiceDetails.Columns.Add("Slno", typeof(decimal));
			dtblServiceDetails.Columns["Slno"].AutoIncrement = true;
			dtblServiceDetails.Columns["Slno"].AutoIncrementSeed = 1L;
			dtblServiceDetails.Columns["Slno"].AutoIncrementStep = 1L;
			SqlDataAdapter sqlda = new SqlDataAdapter();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ServiceDetailsViewWithMasterId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal).Value = decServiceMasterId;
				sqlda.SelectCommand = sqlcmd;
				sqlda.Fill(dtblServiceDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblServiceDetails;
		}
	}
}
