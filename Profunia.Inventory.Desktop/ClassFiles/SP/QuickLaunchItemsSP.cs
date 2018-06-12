using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class QuickLaunchItemsSP : DBConnection
	{
		public DataTable QuickLaunchNonSelectedViewAll(bool isSelected)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("QuickLaunchNonSelectedViewAll", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@selected", SqlDbType.Bit).Value = isSelected;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public void QuickLaunchItemsEdit(QuickLaunchItemsInfo infoQuickLaunchItems)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("QuickLaunchItemsEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@quickLaunchItemsId", SqlDbType.Decimal).Value = infoQuickLaunchItems.QuickLaunchItemsId;
				sqlcmd.Parameters.Add("@itemsName", SqlDbType.VarChar).Value = infoQuickLaunchItems.ItemsName;
				sqlcmd.Parameters.Add("@status", SqlDbType.Bit).Value = infoQuickLaunchItems.Status;
				sqlcmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = infoQuickLaunchItems.Extra1;
				sqlcmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = infoQuickLaunchItems.Extra2;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}
	}
}
