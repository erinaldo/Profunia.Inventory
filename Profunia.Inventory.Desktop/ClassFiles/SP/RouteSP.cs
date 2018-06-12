using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class RouteSP : DBConnection
	{
		public void RouteAdd(RouteInfo routeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.RouteName;
				sprmparam7 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam7.Value = routeinfo.AreaId;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = routeinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.Extra2;
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

		public void RouteEdit(RouteInfo routeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
				sprmparam8.Value = routeinfo.RouteId;
				sprmparam8 = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
				sprmparam8.Value = routeinfo.RouteName;
				sprmparam8 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam8.Value = routeinfo.AreaId;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = routeinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = routeinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = routeinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = routeinfo.Extra2;
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

		public DataTable RouteViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RouteViewAll", base.sqlcon);
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

		public RouteInfo RouteView(decimal routeId)
		{
			RouteInfo routeinfo = new RouteInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
				sprmparam2.Value = routeId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					routeinfo.RouteId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					routeinfo.RouteName = ((DbDataReader)sdrreader)[1].ToString();
					routeinfo.AreaId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					routeinfo.Narration = ((DbDataReader)sdrreader)[3].ToString();
					routeinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					routeinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					routeinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return routeinfo;
		}

		public void RouteDelete(decimal RouteId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
				sprmparam2.Value = RouteId;
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

		public int RouteGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteMax", base.sqlcon);
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

		public DataTable AreafillInRoute()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("AreafillInRoute", base.sqlcon);
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

		public bool RouteCheckExistence(string strRouteName, decimal decRouteId, decimal decAreaId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("RouteCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sqlcmd.Parameters.Add("@routeName", SqlDbType.VarChar);
				sprmparam4.Value = strRouteName;
				sprmparam4 = sqlcmd.Parameters.Add("@routeId", SqlDbType.Decimal);
				sprmparam4.Value = decRouteId;
				sprmparam4 = sqlcmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam4.Value = decAreaId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = decimal.Parse(obj.ToString());
				}
				if (decCount > 0m)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return false;
		}

		public decimal RouteAddParticularFields(RouteInfo routeinfo)
		{
			decimal decAreaId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteAddParticularFields", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
				sprmparam6.Value = routeinfo.RouteName;
				sprmparam6 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam6.Value = routeinfo.AreaId;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = routeinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = routeinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = routeinfo.Extra2;
				object objRouteId = sccmd.ExecuteScalar();
				decAreaId = ((objRouteId == null) ? 0m : decimal.Parse(objRouteId.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decAreaId;
		}

		public bool RouteEditing(RouteInfo routeinfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteEditing", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
				sprmparam7.Value = routeinfo.RouteId;
				sprmparam7 = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.RouteName;
				sprmparam7 = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
				sprmparam7.Value = routeinfo.AreaId;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = routeinfo.Extra2;
				int ina = sccmd.ExecuteNonQuery();
				isEdit = (ina > 0 && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public DataTable RouteSearch(string strRouteName, string strAreaName)
		{
			DataTable dtblRoute = new DataTable();
			dtblRoute.Columns.Add("Sl No", typeof(decimal));
			dtblRoute.Columns["Sl No"].AutoIncrement = true;
			dtblRoute.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtblRoute.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("RouteSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@routeName", SqlDbType.VarChar).Value = strRouteName;
				sqlda.SelectCommand.Parameters.Add("@areaName", SqlDbType.VarChar).Value = strAreaName;
				sqlda.Fill(dtblRoute);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtblRoute;
		}

		public decimal RouteDeleting(decimal RouteId)
		{
			decimal decId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RouteDeleting", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
				sprmparam2.Value = RouteId;
				decId = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decId;
		}

		public DataTable RouteViewForComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("RouteViewForComboFill", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand = sqlcmd;
				sdaadapter.Fill(dtbl);
				DataRow dr = dtbl.NewRow();
				dr["routeId"] = 0;
				dr["routeName"] = "All";
				dtbl.Rows.InsertAt(dr, 0);
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

		public DataTable RouteViewByArea(decimal decAreaId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RouteViewByArea", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal).Value = decAreaId;
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
	}
}
