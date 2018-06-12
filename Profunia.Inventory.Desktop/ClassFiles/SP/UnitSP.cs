using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class UnitSP : DBConnection
	{
		public decimal UnitAdd(UnitInfo unitinfo)
		{
			decimal decIdentity = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
				sprmparam7.Value = unitinfo.UnitName;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = unitinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
				sprmparam7.Value = unitinfo.noOfDecimalplaces;
				sprmparam7 = sccmd.Parameters.Add("@formalName", SqlDbType.VarChar);
				sprmparam7.Value = unitinfo.formalName;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = unitinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = unitinfo.Extra2;
				decIdentity = decimal.Parse(sccmd.ExecuteScalar().ToString());
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

		public bool UnitEdit(UnitInfo unitinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam8.Value = unitinfo.UnitId;
				sprmparam8 = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
				sprmparam8.Value = unitinfo.UnitName;
				sprmparam8 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam8.Value = unitinfo.Narration;
				sprmparam8 = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
				sprmparam8.Value = unitinfo.noOfDecimalplaces;
				sprmparam8 = sccmd.Parameters.Add("@formalName", SqlDbType.VarChar);
				sprmparam8.Value = unitinfo.formalName;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = unitinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = unitinfo.Extra2;
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

		public DataTable UnitViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAll", base.sqlcon);
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

		public UnitInfo UnitView(decimal unitId)
		{
			UnitInfo unitinfo = new UnitInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam2.Value = unitId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					unitinfo.UnitId = Convert.ToDecimal(((DbDataReader)sdrreader)["unitId"]);
					unitinfo.UnitName = ((DbDataReader)sdrreader)["unitName"].ToString();
					unitinfo.Narration = ((DbDataReader)sdrreader)["narration"].ToString();
					unitinfo.noOfDecimalplaces = Convert.ToDecimal(((DbDataReader)sdrreader)["noOfDecimalplaces"].ToString());
					unitinfo.formalName = ((DbDataReader)sdrreader)["formalName"].ToString();
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
			return unitinfo;
		}

		public void UnitDelete(decimal UnitId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam2.Value = UnitId;
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

		public int UnitGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitMax", base.sqlcon);
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

		public DataTable UnitSearch(string strUnitName)
		{
			EmployeeInfo infoEmployee = new EmployeeInfo();
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("UnitSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("SLNO", typeof(decimal));
				dtbl.Columns["SLNO"].AutoIncrement = true;
				dtbl.Columns["SLNO"].AutoIncrementSeed = 1L;
				dtbl.Columns["SLNO"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@unitName", SqlDbType.VarChar).Value = strUnitName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool UnitCheckExistence(string strUnitName, decimal decUnitid)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
				sprmparam3.Value = strUnitName;
				sprmparam3 = sccmd.Parameters.Add("@unitId", SqlDbType.VarChar);
				sprmparam3.Value = decUnitid;
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

		public UnitInfo unitVieWForStandardRate(decimal decProductId)
		{
			UnitInfo infoUnit = new UnitInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("unitVieWForStandardRate", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoUnit.UnitId = Convert.ToDecimal(((DbDataReader)sqldr)["unitId"].ToString());
					infoUnit.UnitName = ((DbDataReader)sqldr)["unitName"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
				sqldr.Close();
			}
			return infoUnit;
		}

		public UnitInfo UnitViewForPriceListPopUp(decimal decProductId)
		{
			UnitInfo infoUnit = new UnitInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("UnitViewForPriceListPopUp", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoUnit.UnitId = Convert.ToDecimal(((DbDataReader)sqldr)["unitId"].ToString());
					infoUnit.UnitName = ((DbDataReader)sqldr)["unitName"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
				sqldr.Close();
			}
			return infoUnit;
		}

		public decimal UnitDeleteCheck(decimal UnitId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitDeleteCheckexistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam2.Value = UnitId;
				decReturnValue = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
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

		public string UnitName(decimal UnitId)
		{
			string strReturnValue = "";
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam2.Value = UnitId;
				strReturnValue = Convert.ToString(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strReturnValue;
		}

		public decimal UnitIdByUnitName(string UnitName)
		{
			decimal decUnitId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitIdBYUnitName", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
				sprmparam2.Value = UnitName;
				decUnitId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decUnitId;
		}

		public DataTable UnitViewAllWithoutPerticularId(decimal decUnitId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitViewAllWithoutPerticularId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam2.Value = decUnitId;
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAllWithoutPerticularId", base.sqlcon);
				sdaadapter.SelectCommand = sccmd;
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

		public DataTable DGVUnitComboFillByProductId(DataGridView dgvCurrent, string strProductId, int inRowIndex)
		{
			DataTable dtblUnitViewAll = new DataTable();
			string strUnitName = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAllByProductIdForSalesReturn", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter2 = new SqlParameter();
				sqlparameter2 = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.VarChar);
				sqlparameter2.Value = strProductId;
				sdaadapter.Fill(dtblUnitViewAll);
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
				DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvCmbUnit"].Index, inRowIndex];
				dgvCurrent[dgvCurrent.Columns["dgvCmbUnit"].Index, inRowIndex].Value = null;
				if (dtblUnitViewAll.Rows.Count > 0)
				{
					dgvcmbUnit.DataSource = dtblUnitViewAll;
					{
						IEnumerator enumerator = dtblUnitViewAll.Rows.GetEnumerator();
						try
						{
							if (enumerator.MoveNext())
							{
								DataRow item = (DataRow)enumerator.Current;
								strUnitName = item["unitName"].ToString();
								if (strUnitName != "NA")
								{
									DataRow dr = dtblUnitViewAll.NewRow();
									dr["unitName"] = "NA";
									dr["unitId"] = 1;
									dtblUnitViewAll.Rows.InsertAt(dr, 0);
								}
							}
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					dgvcmbUnit.DisplayMember = "unitName";
					dgvcmbUnit.ValueMember = "unitId";
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblUnitViewAll;
		}

		public string UnitConversionCheck(decimal decUnitId, decimal decProductId)
		{
			string strQuantities = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("UnitConversionCheck", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
				sprmparam3.Value = decUnitId;
				sprmparam3 = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam3.Value = decProductId;
				strQuantities = Convert.ToString(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strQuantities;
		}

		public DataTable UnitViewAllByProductId(decimal decProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("UnitViewAllByProductId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				sprmparam2.Value = decProductId;
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
	}
}
