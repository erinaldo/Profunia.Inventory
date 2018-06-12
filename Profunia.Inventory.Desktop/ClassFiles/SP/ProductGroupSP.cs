using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ProductGroupSP : DBConnection
	{
		public decimal ProductGroupAdd(ProductGroupInfo productgroupinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductGroupAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam6 = new SqlParameter();
				sprmparam6 = sccmd.Parameters.Add("@groupName", SqlDbType.VarChar);
				sprmparam6.Value = productgroupinfo.GroupName;
				sprmparam6 = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
				sprmparam6.Value = productgroupinfo.GroupUnder;
				sprmparam6 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam6.Value = productgroupinfo.Narration;
				sprmparam6 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam6.Value = productgroupinfo.Extra1;
				sprmparam6 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam6.Value = productgroupinfo.Extra2;
				decimal decIdForOtherForms = Convert.ToDecimal(sccmd.ExecuteScalar());
				if (decIdForOtherForms > 0m)
				{
					return decIdForOtherForms;
				}
				return 0m;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0m;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void ProductGroupEdit(ProductGroupInfo productgroupinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductGroupEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam7.Value = productgroupinfo.GroupId;
				sprmparam7 = sccmd.Parameters.Add("@groupName", SqlDbType.VarChar);
				sprmparam7.Value = productgroupinfo.GroupName;
				sprmparam7 = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
				sprmparam7.Value = productgroupinfo.GroupUnder;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = productgroupinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = productgroupinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = productgroupinfo.Extra2;
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

		public DataTable ProductGroupViewAll()
		{
			DataTable dtblProductGroup = new DataTable();
			dtblProductGroup.Columns.Add("SL.NO", typeof(decimal));
			dtblProductGroup.Columns["SL.NO"].AutoIncrement = true;
			dtblProductGroup.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtblProductGroup.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductGroupViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtblProductGroup);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblProductGroup;
		}

		public DataTable ProductGroupViewForGridFill(string strGroupName, string strGroupUnder)
		{
			DataTable dtblProductGroup = new DataTable();
			dtblProductGroup.Columns.Add("SL.NO", typeof(decimal));
			dtblProductGroup.Columns["SL.NO"].AutoIncrement = true;
			dtblProductGroup.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtblProductGroup.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductGroupViewForGridFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@groupName", SqlDbType.VarChar).Value = strGroupName;
				sdaadapter.SelectCommand.Parameters.Add("@groupUnder", SqlDbType.VarChar).Value = strGroupUnder;
				sdaadapter.Fill(dtblProductGroup);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblProductGroup;
		}

		public ProductGroupInfo ProductGroupView(decimal groupId)
		{
			ProductGroupInfo productgroupinfo = new ProductGroupInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductGroupView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam2.Value = groupId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					productgroupinfo.GroupId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					productgroupinfo.GroupName = ((DbDataReader)sdrreader)[1].ToString();
					productgroupinfo.GroupUnder = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					productgroupinfo.Narration = ((DbDataReader)sdrreader)[3].ToString();
					productgroupinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					productgroupinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
					productgroupinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[6].ToString());
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
			return productgroupinfo;
		}

		public void ProductGroupDelete(decimal GroupId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductGroupDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam2.Value = GroupId;
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

		public int ProductGroupGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductGroupMax", base.sqlcon);
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

		public DataTable ProductGroupViewForComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("ProductGroupViewForComboFill", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand = sqlcmd;
				sdaadapter.Fill(dtbl);
				DataRow dr = dtbl.NewRow();
				dr["groupId"] = 0;
				dr["groupName"] = "All";
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

		public DataTable ProductGroupViewForComboFillForProductGroup()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter();
				SqlCommand sqlcmd = new SqlCommand("ProductGroupViewForComboFill", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand = sqlcmd;
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

		public DataTable ProductAndUnitViewAllForGridFill(decimal decgroupId, string strProductCode, string strProductName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("ProductAndUnitViewAllForGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
				sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
				sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool ProductGroupCheckExistence(string strProductGroupName, decimal decProductGroupId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ProductGroupCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam3.Value = decProductGroupId;
				sprmparam3 = sqlcmd.Parameters.Add("@groupName", SqlDbType.VarChar);
				sprmparam3.Value = strProductGroupName;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isEdit = true;
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isEdit;
		}

		public decimal ProductGroupReferenceDelete(decimal ProductGroupId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ProductGroupReferenceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
				sprmparam2.Value = ProductGroupId;
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

		public bool ProductGroupCheckExistenceOfUnderGroup(decimal decProductGroupId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("ProductGroupCheckExistenceOfUnderGroup", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decProductGroupId;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 1)
				{
					isExist = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}
	}
}
