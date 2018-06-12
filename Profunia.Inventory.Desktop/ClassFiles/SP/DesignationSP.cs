using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DesignationSP : DBConnection
	{
		public bool DesignationAdd(DesignationInfo designationinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DesignationAddIfNotExistsDesignation", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.DesignationName;
				sprmparam7 = sccmd.Parameters.Add("@leaveDays", SqlDbType.Decimal);
				sprmparam7.Value = designationinfo.LeaveDays;
				sprmparam7 = sccmd.Parameters.Add("@advanceAmount", SqlDbType.Decimal);
				sprmparam7.Value = designationinfo.AdvanceAmount;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.Extra2;
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

		public bool DesignationEdit(DesignationInfo designationinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DesignationEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
				sprmparam9.Value = designationinfo.DesignationId;
				sprmparam9 = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
				sprmparam9.Value = designationinfo.DesignationName;
				sprmparam9 = sccmd.Parameters.Add("@leaveDays", SqlDbType.Decimal);
				sprmparam9.Value = designationinfo.LeaveDays;
				sprmparam9 = sccmd.Parameters.Add("@advanceAmount", SqlDbType.Decimal);
				sprmparam9.Value = designationinfo.AdvanceAmount;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = designationinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = designationinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = designationinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = designationinfo.Extra2;
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

		public DataTable DesignationViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DesignationViewAll", base.sqlcon);
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

		public DataTable DesignationViewForGridFill()
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("slNo", typeof(int));
			dtbl.Columns["slNo"].AutoIncrement = true;
			dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["slNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DesignationGridFill", base.sqlcon);
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

		public DesignationInfo DesignationView(decimal designationId)
		{
			DesignationInfo designationinfo = new DesignationInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DesignationView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
				sprmparam2.Value = designationId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					designationinfo.DesignationId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					designationinfo.DesignationName = ((DbDataReader)sdrreader)[1].ToString();
					designationinfo.LeaveDays = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					designationinfo.AdvanceAmount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					designationinfo.Narration = ((DbDataReader)sdrreader)[4].ToString();
					designationinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					designationinfo.Extra1 = ((DbDataReader)sdrreader)[6].ToString();
					designationinfo.Extra2 = ((DbDataReader)sdrreader)[7].ToString();
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
			return designationinfo;
		}

		public bool DesignationDelete(decimal DesignationId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DesignationDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
				sprmparam2.Value = DesignationId;
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

		public int DesignationGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DesignationMax", base.sqlcon);
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

		public DataTable DesignationSearch(string strDesignation)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("slNo", typeof(int));
			dtbl.Columns["slNo"].AutoIncrement = true;
			dtbl.Columns["slNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["slNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DesignationSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation + "%";
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

		public decimal DesignationAddWithReturnIdentity(DesignationInfo designationinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DesignationAddWithReturnIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.DesignationName;
				sprmparam7 = sccmd.Parameters.Add("@leaveDays", SqlDbType.Decimal);
				sprmparam7.Value = designationinfo.LeaveDays;
				sprmparam7 = sccmd.Parameters.Add("@advanceAmount", SqlDbType.Decimal);
				sprmparam7.Value = designationinfo.AdvanceAmount;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = designationinfo.Extra2;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					decIdentity = Convert.ToDecimal(obj.ToString());
				}
				return decIdentity;
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

		public bool DesignationCheckExistanceOfName(string strDesignation, decimal decDesignationId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DesignationCheckExistanceOfName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
				sprmparam3.Value = strDesignation;
				sprmparam3 = sccmd.Parameters.Add("@designationId", SqlDbType.VarChar);
				sprmparam3.Value = decDesignationId;
				object obj = sccmd.ExecuteScalar();
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
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}
	}
}
