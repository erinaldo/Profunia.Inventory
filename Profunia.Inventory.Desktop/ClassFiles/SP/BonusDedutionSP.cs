using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class BonusDedutionSP : DBConnection
	{
		public void BonusDedutionAdd(BonusDedutionInfo bonusdedutioninfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BonusDedutionAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
				sprmparam11.Value = bonusdedutioninfo.BonusDeductionId;
				sprmparam11 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam11.Value = bonusdedutioninfo.EmployeeId;
				sprmparam11 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam11.Value = bonusdedutioninfo.Date;
				sprmparam11 = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam11.Value = bonusdedutioninfo.Month;
				sprmparam11 = sccmd.Parameters.Add("@bonusAmount", SqlDbType.Decimal);
				sprmparam11.Value = bonusdedutioninfo.BonusAmount;
				sprmparam11 = sccmd.Parameters.Add("@deductionAmount", SqlDbType.Decimal);
				sprmparam11.Value = bonusdedutioninfo.DeductionAmount;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = bonusdedutioninfo.Narration;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = bonusdedutioninfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = bonusdedutioninfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = bonusdedutioninfo.Extra2;
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

		public void BonusDedutionEdit(BonusDedutionInfo bonusdedutioninfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BonusDedutionEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
				sprmparam10.Value = bonusdedutioninfo.BonusDeductionId;
				sprmparam10 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam10.Value = bonusdedutioninfo.EmployeeId;
				sprmparam10 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam10.Value = bonusdedutioninfo.Date;
				sprmparam10 = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam10.Value = bonusdedutioninfo.Month;
				sprmparam10 = sccmd.Parameters.Add("@bonusAmount", SqlDbType.Decimal);
				sprmparam10.Value = bonusdedutioninfo.BonusAmount;
				sprmparam10 = sccmd.Parameters.Add("@deductionAmount", SqlDbType.Decimal);
				sprmparam10.Value = bonusdedutioninfo.DeductionAmount;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = bonusdedutioninfo.Narration;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = bonusdedutioninfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = bonusdedutioninfo.Extra2;
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

		public DataTable BonusDedutionViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BonusDedutionViewAll", base.sqlcon);
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

		public BonusDedutionInfo BonusDedutionView(decimal bonusDeductionId)
		{
			BonusDedutionInfo bonusdedutioninfo = new BonusDedutionInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BonusDedutionView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
				sprmparam2.Value = bonusDeductionId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					bonusdedutioninfo.BonusDeductionId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					bonusdedutioninfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					bonusdedutioninfo.Date = DateTime.Parse(((DbDataReader)sdrreader)[2].ToString());
					bonusdedutioninfo.Month = DateTime.Parse(((DbDataReader)sdrreader)[3].ToString());
					bonusdedutioninfo.BonusAmount = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					bonusdedutioninfo.DeductionAmount = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					bonusdedutioninfo.Narration = ((DbDataReader)sdrreader)[6].ToString();
					bonusdedutioninfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
					bonusdedutioninfo.Extra1 = ((DbDataReader)sdrreader)[8].ToString();
					bonusdedutioninfo.Extra2 = ((DbDataReader)sdrreader)[9].ToString();
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
			return bonusdedutioninfo;
		}

		public void BonusDedutionDelete(decimal BonusDeductionId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BonusDedutionDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
				sprmparam2.Value = BonusDeductionId;
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

		public int BonusDedutionGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BonusDedutionMax", base.sqlcon);
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

		public DataTable BonusDeductionSearch(string strName, DateTime dtMonth)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("BonusDeductionSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strName;
				sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime).Value = dtMonth;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public DataTable BonusDedutionFill(decimal decBonusDedutionId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("BonusDedutionView", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("bonusDeductionId", SqlDbType.Decimal).Value = decBonusDedutionId;
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

		public BonusDedutionInfo BonusDeductionViewForUpdate(decimal decBonusDeductionId)
		{
			BonusDedutionInfo BonusDeductionInfo = new BonusDedutionInfo();
			EmployeeInfo InfoEmployee = new EmployeeInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("BonusDeductionViewForUpdate", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal).Value = decBonusDeductionId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					BonusDeductionInfo.EmployeeId = decimal.Parse(((DbDataReader)sqldr)["employeeId"].ToString());
					BonusDeductionInfo.Date = DateTime.Parse(((DbDataReader)sqldr)["date"].ToString());
					BonusDeductionInfo.Month = DateTime.Parse(((DbDataReader)sqldr)["month"].ToString());
					BonusDeductionInfo.BonusAmount = decimal.Parse(((DbDataReader)sqldr)["bonusAmount"].ToString());
					BonusDeductionInfo.DeductionAmount = decimal.Parse(((DbDataReader)sqldr)["deductionAmount"].ToString());
					BonusDeductionInfo.Narration = ((DbDataReader)sqldr)["narration"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				sqldr.Close();
				base.sqlcon.Close();
			}
			return BonusDeductionInfo;
		}

		public bool BonusDeductionAddIfNotExist(BonusDedutionInfo bonusdedutioninfo)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("BonusDeductionAddIfNotExist", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam9.Value = bonusdedutioninfo.EmployeeId;
				sprmparam9 = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
				sprmparam9.Value = bonusdedutioninfo.Date;
				sprmparam9 = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam9.Value = bonusdedutioninfo.Month;
				sprmparam9 = sccmd.Parameters.Add("@bonusAmount", SqlDbType.Decimal);
				sprmparam9.Value = bonusdedutioninfo.BonusAmount;
				sprmparam9 = sccmd.Parameters.Add("@deductionAmount", SqlDbType.Decimal);
				sprmparam9.Value = bonusdedutioninfo.DeductionAmount;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = bonusdedutioninfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = bonusdedutioninfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = bonusdedutioninfo.Extra2;
				int ina = sccmd.ExecuteNonQuery();
				isSave = (ina > 0 && true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isSave;
		}

		public bool BonusDeductionMonthCheckExistance(BonusDedutionInfo bonusdedutioninfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("BonusDeductionMonthCheckExistance", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@month", SqlDbType.DateTime).Value = bonusdedutioninfo.Month;
				object obj = sqlcmd.ExecuteScalar();
				isEdit = (obj != null && true);
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

		public DataTable BonusDeductionSearchForPopUp(string strCode, string strName)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SL.NO", typeof(decimal));
			dtbl.Columns["SL.NO"].AutoIncrement = true;
			dtbl.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtbl.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("BonusDeductionSearchForPopUp", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strCode;
				sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strName;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public decimal BonusDeductionReferenceDelete(decimal EmployeeId, DateTime month)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("BonusDeductionReferenceDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@EmployeeId", SqlDbType.Decimal);
				sprmparam3.Value = EmployeeId;
				sprmparam3 = sqlcmd.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam3.Value = month;
				decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
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

		public DataTable BonusDeductionReportGridFill(string strFromdate, string strTodate, string strSalaryMonth, string strDesignation, string strEmployee, string strBonusOrDeduction)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("BonusDeductionReportGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtbl.Columns.Add("Sl No", typeof(int));
				dtbl.Columns["Sl No"].AutoIncrement = true;
				dtbl.Columns["Sl No"].AutoIncrementSeed = 1L;
				dtbl.Columns["Sl No"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strFromdate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strTodate;
				sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = strSalaryMonth;
				sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
				sqlda.SelectCommand.Parameters.Add("@employee", SqlDbType.VarChar).Value = strEmployee;
				sqlda.SelectCommand.Parameters.Add("@bonusOrdeduction", SqlDbType.VarChar).Value = strBonusOrDeduction;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			return dtbl;
		}
	}
}
