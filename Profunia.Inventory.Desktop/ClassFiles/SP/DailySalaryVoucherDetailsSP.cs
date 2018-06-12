using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class DailySalaryVoucherDetailsSP : DBConnection
	{
		public void DailySalaryVoucherDetailsAdd(DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam7.Value = dailysalaryvoucherdetailsinfo.DailySalaryVocherMasterId;
				sprmparam7 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam7.Value = dailysalaryvoucherdetailsinfo.EmployeeId;
				sprmparam7 = sccmd.Parameters.Add("@wage", SqlDbType.Decimal);
				sprmparam7.Value = dailysalaryvoucherdetailsinfo.Wage;
				sprmparam7 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam7.Value = dailysalaryvoucherdetailsinfo.Status;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = dailysalaryvoucherdetailsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = dailysalaryvoucherdetailsinfo.Extra2;
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

		public void DailySalaryVoucherDetailsEdit(DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@dailySalaryVoucherDetailsId", SqlDbType.Decimal);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.DailySalaryVoucherDetailsId;
				sprmparam9 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.DailySalaryVocherMasterId;
				sprmparam9 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.EmployeeId;
				sprmparam9 = sccmd.Parameters.Add("@wage", SqlDbType.Decimal);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.Wage;
				sprmparam9 = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.Status;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = dailysalaryvoucherdetailsinfo.Extra2;
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

		public DataTable DailySalaryVoucherDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DailySalaryVoucherDetailsViewAll", base.sqlcon);
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

		public DailySalaryVoucherDetailsInfo DailySalaryVoucherDetailsView(decimal dailySalaryVoucherDetailsId)
		{
			DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo = new DailySalaryVoucherDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailySalaryVoucherDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = dailySalaryVoucherDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					dailysalaryvoucherdetailsinfo.DailySalaryVoucherDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					dailysalaryvoucherdetailsinfo.DailySalaryVocherMasterId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					dailysalaryvoucherdetailsinfo.EmployeeId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					dailysalaryvoucherdetailsinfo.Wage = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					dailysalaryvoucherdetailsinfo.Status = ((DbDataReader)sdrreader)[4].ToString();
					dailysalaryvoucherdetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					dailysalaryvoucherdetailsinfo.Extra1 = ((DbDataReader)sdrreader)[6].ToString();
					dailysalaryvoucherdetailsinfo.Extra2 = ((DbDataReader)sdrreader)[7].ToString();
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
			return dailysalaryvoucherdetailsinfo;
		}

		public void DailySalaryVoucherDetailsDelete(decimal DailySalaryVoucherDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailySalaryVoucherDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = DailySalaryVoucherDetailsId;
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

		public int DailySalaryVoucherDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsMax", base.sqlcon);
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

		public DataTable DailySalaryVoucherDetailsGridViewAll(string strSalaryDate, bool isEditMode, string strVoucherNumber)
		{
			int invalue = 0;
			DataTable dtblDailySalaryVoucherDetailsGridViewAll = new DataTable();
			dtblDailySalaryVoucherDetailsGridViewAll.Columns.Add("Sl.No", typeof(decimal));
			dtblDailySalaryVoucherDetailsGridViewAll.Columns["Sl.No"].AutoIncrement = true;
			dtblDailySalaryVoucherDetailsGridViewAll.Columns["Sl.No"].AutoIncrementSeed = 1L;
			dtblDailySalaryVoucherDetailsGridViewAll.Columns["Sl.No"].AutoIncrementStep = 1L;
			try
			{
				if (isEditMode)
				{
					invalue = 1;
				}
				else
				{
					invalue = 0;
					strVoucherNumber = "0";
				}
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("DailySalaryVoucherDetailsGridViewall", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@salaryDate", SqlDbType.DateTime).Value = DateTime.Parse(strSalaryDate);
				sdaadapter.SelectCommand.Parameters.Add("@VOucherNoforEdit", SqlDbType.Decimal).Value = decimal.Parse(invalue.ToString());
				sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNumber;
				sdaadapter.Fill(dtblDailySalaryVoucherDetailsGridViewAll);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblDailySalaryVoucherDetailsGridViewAll;
		}

		public int DailySalaryVoucherDetailsCount(decimal decMasterId)
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsCount", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
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

		public void DailySalaryVoucherDetailsDeleteUsingMasterId(decimal DailySalaryVoucherDetailsMasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsDeleteUsingMasterId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
				sprmparam2.Value = DailySalaryVoucherDetailsMasterId;
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

		public string CheckWhetherDailySalaryAlreadyPaid(decimal decEmployeeId, DateTime SalaryDate)
		{
			string strName = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckWhetherDailySalaryAlreadyPaid", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam3.Value = decEmployeeId;
				sprmparam3 = sccmd.Parameters.Add("@salaryDate", SqlDbType.DateTime);
				sprmparam3.Value = SalaryDate;
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
