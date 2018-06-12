using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalaryVoucherDetailsSP : DBConnection
	{
		public void SalaryVoucherDetailsAdd(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.SalaryVoucherDetailsId;
				sprmparam13 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.SalaryVoucherMasterId;
				sprmparam13 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.EmployeeId;
				sprmparam13 = sccmd.Parameters.Add("@bonus", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Bonus;
				sprmparam13 = sccmd.Parameters.Add("@deduction", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Deduction;
				sprmparam13 = sccmd.Parameters.Add("@advance", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Advance;
				sprmparam13 = sccmd.Parameters.Add("@lop", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Lop;
				sprmparam13 = sccmd.Parameters.Add("@salary", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Salary;
				sprmparam13 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam13.Value = salaryvoucherdetailsinfo.Status;
				sprmparam13 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam13.Value = salaryvoucherdetailsinfo.ExtraDate;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = salaryvoucherdetailsinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = salaryvoucherdetailsinfo.Extra2;
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

		public void SalaryVoucherDetailsEdit(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam13 = new SqlParameter();
				sprmparam13 = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.SalaryVoucherDetailsId;
				sprmparam13 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.SalaryVoucherMasterId;
				sprmparam13 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.EmployeeId;
				sprmparam13 = sccmd.Parameters.Add("@bonus", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Bonus;
				sprmparam13 = sccmd.Parameters.Add("@deduction", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Deduction;
				sprmparam13 = sccmd.Parameters.Add("@advance", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Advance;
				sprmparam13 = sccmd.Parameters.Add("@lop", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Lop;
				sprmparam13 = sccmd.Parameters.Add("@salary", SqlDbType.Decimal);
				sprmparam13.Value = salaryvoucherdetailsinfo.Salary;
				sprmparam13 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam13.Value = salaryvoucherdetailsinfo.Status;
				sprmparam13 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam13.Value = salaryvoucherdetailsinfo.ExtraDate;
				sprmparam13 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam13.Value = salaryvoucherdetailsinfo.Extra1;
				sprmparam13 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam13.Value = salaryvoucherdetailsinfo.Extra2;
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

		public DataTable SalaryVoucherDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryVoucherDetailsViewAll", base.sqlcon);
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

		public SalaryVoucherDetailsInfo SalaryVoucherDetailsView(decimal salaryVoucherDetailsId)
		{
			SalaryVoucherDetailsInfo salaryvoucherdetailsinfo = new SalaryVoucherDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = salaryVoucherDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salaryvoucherdetailsinfo.SalaryVoucherDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salaryvoucherdetailsinfo.SalaryVoucherMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salaryvoucherdetailsinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					salaryvoucherdetailsinfo.Bonus = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salaryvoucherdetailsinfo.Deduction = decimal.Parse(((DbDataReader)sdrreader)[4].ToString());
					salaryvoucherdetailsinfo.Advance = decimal.Parse(((DbDataReader)sdrreader)[5].ToString());
					salaryvoucherdetailsinfo.Lop = decimal.Parse(((DbDataReader)sdrreader)[6].ToString());
					salaryvoucherdetailsinfo.Salary = decimal.Parse(((DbDataReader)sdrreader)[7].ToString());
					salaryvoucherdetailsinfo.Status = ((DbDataReader)sdrreader)[8].ToString();
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
			return salaryvoucherdetailsinfo;
		}

		public void SalaryVoucherDetailsDelete(decimal SalaryVoucherDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = SalaryVoucherDetailsId;
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

		public int SalaryVoucherDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsMax", base.sqlcon);
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

		public DataTable MonthlySalaryVoucherDetailsViewAll(string strMonth, string Month, string monthYear, bool isEditMode, string strVoucherNoforEdit)
		{
			decimal decEditMode = 0m;
			DataTable dtbl = new DataTable();
			try
			{
				if (isEditMode)
				{
					decEditMode = 1m;
				}
				else
				{
					decEditMode = 0m;
					strVoucherNoforEdit = "0";
				}
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtbl.Columns.Add("SlNo", typeof(decimal));
				dtbl.Columns["SlNo"].AutoIncrement = true;
				dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
				SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalaryVoucherDetailsViewAll", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@strMonth", SqlDbType.VarChar).Value = strMonth;
				sdaadapter.SelectCommand.Parameters.Add("@Month", SqlDbType.VarChar).Value = Month;
				sdaadapter.SelectCommand.Parameters.Add("@monthYear", SqlDbType.VarChar).Value = monthYear;
				sdaadapter.SelectCommand.Parameters.Add("@isEditMode", SqlDbType.Decimal).Value = decEditMode;
				sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNoforEdit;
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

		public void MonthlySalaryVoucherDetailsAdd(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam11.Value = salaryvoucherdetailsinfo.SalaryVoucherMasterId;
				sprmparam11 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam11.Value = salaryvoucherdetailsinfo.EmployeeId;
				sprmparam11 = sccmd.Parameters.Add("@bonus", SqlDbType.Decimal);
				sprmparam11.Value = salaryvoucherdetailsinfo.Bonus;
				sprmparam11 = sccmd.Parameters.Add("@deduction", SqlDbType.Decimal);
				sprmparam11.Value = salaryvoucherdetailsinfo.Deduction;
				sprmparam11 = sccmd.Parameters.Add("@advance", SqlDbType.Decimal);
				sprmparam11.Value = salaryvoucherdetailsinfo.Advance;
				sprmparam11 = sccmd.Parameters.Add("@lop", SqlDbType.Decimal);
				sprmparam11.Value = salaryvoucherdetailsinfo.Lop;
				sprmparam11 = sccmd.Parameters.Add("@salary", SqlDbType.Decimal);
				sprmparam11.Value = salaryvoucherdetailsinfo.Salary;
				sprmparam11 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam11.Value = salaryvoucherdetailsinfo.Status;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = salaryvoucherdetailsinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = salaryvoucherdetailsinfo.Extra2;
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

		public void SalaryVoucherDetailsDeleteUsingMasterId(decimal SalaryVoucherDetailsMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsDeleteUsingMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam2.Value = SalaryVoucherDetailsMasterId;
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

		public int SalaryVoucherDetailsCount(decimal decMasterId)
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsCount", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam2.Value = decMasterId;
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

		public string CheckWhetherSalaryAlreadyPaid(decimal decEmployeeId, DateTime Month)
		{
			string strName = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckWhetherSalaryAlreadyPaid", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam3.Value = decEmployeeId;
				sprmparam3 = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
				sprmparam3.Value = Month;
				strName = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strName;
		}
	}
}
