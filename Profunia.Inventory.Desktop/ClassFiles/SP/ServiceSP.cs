using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ServiceSP : DBConnection
	{
		public bool ServiceAdd(ServiceInfo serviceinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
				sprmparam7.Value = serviceinfo.ServiceName;
				sprmparam7 = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
				sprmparam7.Value = serviceinfo.ServiceCategoryId;
				sprmparam7 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam7.Value = serviceinfo.Rate;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = serviceinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = serviceinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = serviceinfo.Extra2;
				int inEffectedRow = sccmd.ExecuteNonQuery();
				if (inEffectedRow > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public bool ServiceEdit(ServiceInfo serviceinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam8.Value = serviceinfo.ServiceId;
				sprmparam8 = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.ServiceName;
				sprmparam8 = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
				sprmparam8.Value = serviceinfo.ServiceCategoryId;
				sprmparam8 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam8.Value = serviceinfo.Rate;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.Extra2;
				int inEffectedRow = sccmd.ExecuteNonQuery();
				if (inEffectedRow > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public DataTable ServiceViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
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

		public ServiceInfo ServiceView(decimal serviceId)
		{
			ServiceInfo serviceinfo = new ServiceInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam2.Value = serviceId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					serviceinfo.ServiceId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					serviceinfo.ServiceName = ((DbDataReader)sdrreader)["serviceName"].ToString();
					serviceinfo.ServiceCategoryId = decimal.Parse(((DbDataReader)sdrreader)["serviceCategoryId"].ToString());
					serviceinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)["rate"].ToString());
					serviceinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
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
			return serviceinfo;
		}

		public ServiceInfo ServiceViewForRate(decimal serviceId)
		{
			ServiceInfo serviceinfo = new ServiceInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceViewForRate", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam2.Value = serviceId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					serviceinfo.ServiceName = ((DbDataReader)sdrreader)["serviceName"].ToString();
					serviceinfo.ServiceCategoryId = decimal.Parse(((DbDataReader)sdrreader)["serviceCategoryId"].ToString());
					serviceinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)["rate"].ToString());
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
			return serviceinfo;
		}

		public void ServiceDelete(decimal ServiceId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam2.Value = ServiceId;
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

		public int ServiceGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceMax", base.sqlcon);
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

		public bool ServiceCheckExistence(string strServiceName, decimal decServiceId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
				sprmparam3.Value = strServiceName;
				sprmparam3 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam3.Value = decServiceId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public DataTable ServiceGridFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceGridFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
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

		public DataTable ServiceSearch(string strBrandName, string strCategoryname)
		{
			EmployeeInfo infoEmployee = new EmployeeInfo();
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ServiceSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@serviceName", SqlDbType.VarChar).Value = strBrandName;
				sqlda.SelectCommand.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = strCategoryname;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public decimal ServiceDeleteReferenceCheck(decimal ServiceId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceDeleteReference", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
				sprmparam2.Value = ServiceId;
				decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decReturnValue;
		}

		public decimal ServiceAddWithReturnIdentity(ServiceInfo serviceinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ServiceAddWithReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.ServiceName;
				sprmparam8 = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
				sprmparam8.Value = serviceinfo.ServiceCategoryId;
				sprmparam8 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam8.Value = serviceinfo.Rate;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = serviceinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = serviceinfo.Extra2;
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
	}
}
