using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class RackSP : DBConnection
	{
		public decimal RackAdd(RackInfo rackinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RackAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@rackName", SqlDbType.VarChar);
				sprmparam7.Value = rackinfo.RackName;
				sprmparam7 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam7.Value = rackinfo.GodownId;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = rackinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = rackinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = rackinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = rackinfo.Extra2;
				decimal decEffectedRow = Convert.ToDecimal(sccmd.ExecuteScalar());
				if (decEffectedRow > 0m)
				{
					return decEffectedRow;
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

		public bool RackEdit(RackInfo rackinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RackEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam8.Value = rackinfo.RackId;
				sprmparam8 = sccmd.Parameters.Add("@rackName", SqlDbType.VarChar);
				sprmparam8.Value = rackinfo.RackName;
				sprmparam8 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam8.Value = rackinfo.GodownId;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = rackinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = rackinfo.ExtraDate;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = rackinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = rackinfo.Extra2;
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

		public DataTable RackViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RackViewAll", base.sqlcon);
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

		public RackInfo RackView(decimal rackId)
		{
			RackInfo rackinfo = new RackInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RackView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam2.Value = rackId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					rackinfo.RackId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					rackinfo.RackName = ((DbDataReader)sdrreader)[1].ToString();
					rackinfo.GodownId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					rackinfo.Narration = ((DbDataReader)sdrreader)[3].ToString();
					rackinfo.Extra1 = ((DbDataReader)sdrreader)[4].ToString();
					rackinfo.Extra2 = ((DbDataReader)sdrreader)[5].ToString();
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
			return rackinfo;
		}

		public void RackDelete(decimal RackId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RackDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam2.Value = RackId;
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

		public int RackGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RackMax", base.sqlcon);
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

		public DataTable RackViewAllByGodownId(DataGridView dgvCurrent, decimal godownId, int inRowIndex)
		{
			DataTable dtblRack = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RackViewAllByGodownId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.VarChar);
				sqlparameter2.Value = godownId;
				sdaadapter.Fill(dtblRack);
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			try
			{
				DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvCmbRack"].Index, inRowIndex];
				dgvCurrent[dgvCurrent.Columns["dgvCmbRack"].Index, inRowIndex].Value = null;
				if (dtblRack.Rows.Count > 0)
				{
					dgvcmbUnit.DataSource = dtblRack;
					dgvcmbUnit.DisplayMember = "rackName";
					dgvcmbUnit.ValueMember = "rackId";
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			return dtblRack;
		}

		public DataTable RackViewAllByGodownForCombo(decimal godownId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("RackViewAllByGodownForCombo", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param2 = new SqlParameter();
				param2 = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
				param2.Value = godownId;
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

		public DataTable RackViewAllByGodown(decimal decGodown)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RackViewAllByGodown", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodown;
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

		public DataTable RackFillForStock(decimal decGodown)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RackFillForStock", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodown;
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

		public bool RackCheckExistence(string strRackName, decimal decRackId, decimal decGodownId)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RackCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam4 = new SqlParameter();
				sprmparam4 = sccmd.Parameters.Add("@rackName", SqlDbType.VarChar);
				sprmparam4.Value = strRackName;
				sprmparam4 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam4.Value = decRackId;
				sprmparam4 = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
				sprmparam4.Value = decGodownId;
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

		public DataTable RackSearch(string strRackName, string strGodownname)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RackSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
				sdaadapter.SelectCommand.Parameters.Add("@rackName", SqlDbType.VarChar).Value = strRackName;
				sdaadapter.SelectCommand.Parameters.Add("@godownName", SqlDbType.VarChar).Value = strGodownname;
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

		public decimal RackDeleteReference(decimal RackId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("RackDeleteReference", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
				sprmparam2.Value = RackId;
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

		public DataTable RejectionOutRackViewFromGodownId()
		{
			DataTable dtblGodown = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RejectionOutRackViewFromGodownId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtblGodown);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblGodown;
		}

		public DataTable RackNamesCorrespondingToGodownId(decimal decgodownId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("RackNamesCorrespondingToGodownId", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.VarChar).Value = decgodownId;
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
	}
}
