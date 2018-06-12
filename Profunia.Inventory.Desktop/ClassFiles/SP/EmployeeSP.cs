using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class EmployeeSP : DBConnection
	{
		public void EmployeeAdd(EmployeeInfo employeeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeeAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam36 = new SqlParameter();
				sprmparam36 = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
				sprmparam36.Value = employeeinfo.DesignationId;
				sprmparam36 = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.EmployeeName;
				sprmparam36 = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.EmployeeCode;
				sprmparam36 = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.Dob;
				sprmparam36 = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.MaritalStatus;
				sprmparam36 = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Gender;
				sprmparam36 = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Qualification;
				sprmparam36 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Address;
				sprmparam36 = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PhoneNumber;
				sprmparam36 = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.MobileNumber;
				sprmparam36 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Email;
				sprmparam36 = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.JoiningDate;
				sprmparam36 = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.TerminationDate;
				sprmparam36 = sccmd.Parameters.Add("@active", SqlDbType.Bit);
				sprmparam36.Value = employeeinfo.IsActive;
				sprmparam36 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Narration;
				sprmparam36 = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BloodGroup;
				sprmparam36 = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PassportNo;
				sprmparam36 = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.PassportExpiryDate;
				sprmparam36 = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.LabourCardNumber;
				sprmparam36 = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.LabourCardExpiryDate;
				sprmparam36 = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.VisaNumber;
				sprmparam36 = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.VisaExpiryDate;
				sprmparam36 = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.SalaryType;
				sprmparam36 = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
				sprmparam36.Value = employeeinfo.DailyWage;
				sprmparam36 = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BankName;
				sprmparam36 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BranchName;
				sprmparam36 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BankAccountNumber;
				sprmparam36 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BranchCode;
				sprmparam36 = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PanNumber;
				sprmparam36 = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PfNumber;
				sprmparam36 = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.EsiNumber;
				sprmparam36 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.ExtraDate;
				sprmparam36 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Extra1;
				sprmparam36 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Extra2;
				sprmparam36 = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
				sprmparam36.Value = employeeinfo.DefaultPackageId;
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

		public DataTable EmployeeViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("EmployeeViewAll", base.sqlcon);
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

		public void EmployeeDelete(decimal EmployeeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeeDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam2.Value = EmployeeId;
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

		public int EmployeeGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeeMax", base.sqlcon);
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

		public bool EmployeeAddIfNotExistsEmployeeCode(EmployeeInfo employeeinfo)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeeAddWithDifferentEmployeeCode", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam36 = new SqlParameter();
				sprmparam36 = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
				sprmparam36.Value = employeeinfo.DesignationId;
				sprmparam36 = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.EmployeeName;
				sprmparam36 = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.EmployeeCode;
				sprmparam36 = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.Dob;
				sprmparam36 = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.MaritalStatus;
				sprmparam36 = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Gender;
				sprmparam36 = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Qualification;
				sprmparam36 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Address;
				sprmparam36 = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PhoneNumber;
				sprmparam36 = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.MobileNumber;
				sprmparam36 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Email;
				sprmparam36 = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.JoiningDate;
				sprmparam36 = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.TerminationDate;
				sprmparam36 = sccmd.Parameters.Add("@active", SqlDbType.Bit);
				sprmparam36.Value = employeeinfo.IsActive;
				sprmparam36 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Narration;
				sprmparam36 = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BloodGroup;
				sprmparam36 = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PassportNo;
				sprmparam36 = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.PassportExpiryDate;
				sprmparam36 = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.LabourCardNumber;
				sprmparam36 = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.LabourCardExpiryDate;
				sprmparam36 = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.VisaNumber;
				sprmparam36 = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.VisaExpiryDate;
				sprmparam36 = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.SalaryType;
				sprmparam36 = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
				sprmparam36.Value = employeeinfo.DailyWage;
				sprmparam36 = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BankName;
				sprmparam36 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BranchName;
				sprmparam36 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BankAccountNumber;
				sprmparam36 = sccmd.Parameters.Add("@micrCodeNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.BranchCode;
				sprmparam36 = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PanNumber;
				sprmparam36 = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.PfNumber;
				sprmparam36 = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.EsiNumber;
				sprmparam36 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam36.Value = employeeinfo.ExtraDate;
				sprmparam36 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Extra1;
				sprmparam36 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam36.Value = employeeinfo.Extra2;
				sprmparam36 = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
				sprmparam36.Value = employeeinfo.DefaultPackageId;
				int inWorked = sccmd.ExecuteNonQuery();
				isSave = (inWorked > 0 && true);
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

		public void EmployeeDeleteCheck(decimal EmployeeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeeDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam2.Value = EmployeeId;
				int inWorked = sccmd.ExecuteNonQuery();
				if (inWorked > 0)
				{
					Messages.DeletedMessage();
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
		}

		public DataTable EmployeeSearch(EmployeeInfo infoEmployee)
		{
			DataTable dtblEmployee = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblEmployee.Columns.Add("SlNo", typeof(decimal));
				dtblEmployee.Columns["SlNo"].AutoIncrement = true;
				dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1L;
				dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1L;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = infoEmployee.EmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = infoEmployee.EmployeeName;
				sqlda.SelectCommand.Parameters.Add("@designationId", SqlDbType.Decimal).Value = infoEmployee.DesignationId;
				sqlda.SelectCommand.Parameters.Add("@salaryType", SqlDbType.VarChar).Value = infoEmployee.SalaryType;
				sqlda.SelectCommand.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar).Value = infoEmployee.BankAccountNumber;
				sqlda.SelectCommand.Parameters.Add("@passportNumber", SqlDbType.VarChar).Value = infoEmployee.PassportNo;
				sqlda.SelectCommand.Parameters.Add("@labourCardNumber", SqlDbType.VarChar).Value = infoEmployee.LabourCardNumber;
				sqlda.SelectCommand.Parameters.Add("@visaNumber", SqlDbType.VarChar).Value = infoEmployee.VisaNumber;
				sqlda.Fill(dtblEmployee);
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			return dtblEmployee;
		}

		public EmployeeInfo EmployeeView(decimal employeeId)
		{
			EmployeeInfo infoemployee = new EmployeeInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("EmployeeView", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam2.Value = employeeId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoemployee.EmployeeId = Convert.ToDecimal(((DbDataReader)sqldr)["employeeId"].ToString());
					infoemployee.DesignationId = Convert.ToDecimal(((DbDataReader)sqldr)["designationId"].ToString());
					infoemployee.EmployeeName = ((DbDataReader)sqldr)["employeeName"].ToString();
					infoemployee.EmployeeCode = ((DbDataReader)sqldr)["employeeCode"].ToString();
					infoemployee.Dob = Convert.ToDateTime(((DbDataReader)sqldr)["dob"].ToString());
					infoemployee.MaritalStatus = ((DbDataReader)sqldr)["maritalStatus"].ToString();
					infoemployee.Gender = ((DbDataReader)sqldr)["gender"].ToString();
					infoemployee.Qualification = ((DbDataReader)sqldr)["qualification"].ToString();
					infoemployee.Address = ((DbDataReader)sqldr)["address"].ToString();
					infoemployee.PhoneNumber = ((DbDataReader)sqldr)["phoneNumber"].ToString();
					infoemployee.MobileNumber = ((DbDataReader)sqldr)["mobileNumber"].ToString();
					infoemployee.Email = ((DbDataReader)sqldr)["email"].ToString();
					infoemployee.JoiningDate = Convert.ToDateTime(((DbDataReader)sqldr)["joiningDate"].ToString());
					infoemployee.TerminationDate = Convert.ToDateTime(((DbDataReader)sqldr)["terminationDate"].ToString());
					infoemployee.IsActive = bool.Parse(((DbDataReader)sqldr)["isActive"].ToString());
					infoemployee.Narration = ((DbDataReader)sqldr)["narration"].ToString();
					infoemployee.BloodGroup = ((DbDataReader)sqldr)["bloodGroup"].ToString();
					infoemployee.PassportNo = ((DbDataReader)sqldr)["passportNo"].ToString();
					infoemployee.PassportExpiryDate = Convert.ToDateTime(((DbDataReader)sqldr)["passportExpiryDate"].ToString());
					infoemployee.LabourCardNumber = ((DbDataReader)sqldr)["labourCardNumber"].ToString();
					infoemployee.LabourCardExpiryDate = Convert.ToDateTime(((DbDataReader)sqldr)["labourCardExpiryDate"].ToString());
					infoemployee.VisaNumber = ((DbDataReader)sqldr)["visaNumber"].ToString();
					infoemployee.VisaExpiryDate = Convert.ToDateTime(((DbDataReader)sqldr)["visaExpiryDate"].ToString());
					infoemployee.SalaryType = ((DbDataReader)sqldr)["salaryType"].ToString();
					infoemployee.DailyWage = Convert.ToDecimal(((DbDataReader)sqldr)["dailyWage"].ToString());
					infoemployee.BankName = ((DbDataReader)sqldr)["bankName"].ToString();
					infoemployee.BranchName = ((DbDataReader)sqldr)["branchName"].ToString();
					infoemployee.BankAccountNumber = ((DbDataReader)sqldr)["bankAccountNumber"].ToString();
					infoemployee.BranchCode = ((DbDataReader)sqldr)["branchCode"].ToString();
					infoemployee.PanNumber = ((DbDataReader)sqldr)["panNumber"].ToString();
					infoemployee.PfNumber = ((DbDataReader)sqldr)["pfNumber"].ToString();
					infoemployee.EsiNumber = ((DbDataReader)sqldr)["esiNumber"].ToString();
					infoemployee.DefaultPackageId = Convert.ToDecimal(((DbDataReader)sqldr)["defaultPackageId"].ToString());
				}
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				sqldr.Close();
				base.sqlcon.Close();
			}
			return infoemployee;
		}

		public bool EmployeeCodeCheckExistance(string strEmployeeCode, decimal decEmployeeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("EmployeeCodeCheckExistance", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
				sprmparam3.Value = strEmployeeCode;
				sprmparam3 = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam3.Value = decEmployeeId;
				object obj = sqlcmd.ExecuteScalar();
				decimal decCount = 0m;
				if (obj != null)
				{
					decCount = Convert.ToDecimal(obj.ToString());
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

		public bool EmployeeEdit(EmployeeInfo employeeinfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeeEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam37 = new SqlParameter();
				sprmparam37 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam37.Value = employeeinfo.EmployeeId;
				sprmparam37 = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
				sprmparam37.Value = employeeinfo.DesignationId;
				sprmparam37 = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.EmployeeName;
				sprmparam37 = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.EmployeeCode;
				sprmparam37 = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
				sprmparam37.Value = employeeinfo.Dob;
				sprmparam37 = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.MaritalStatus;
				sprmparam37 = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.Gender;
				sprmparam37 = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.Qualification;
				sprmparam37 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.Address;
				sprmparam37 = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.PhoneNumber;
				sprmparam37 = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.MobileNumber;
				sprmparam37 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.Email;
				sprmparam37 = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
				sprmparam37.Value = employeeinfo.JoiningDate;
				sprmparam37 = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
				sprmparam37.Value = employeeinfo.TerminationDate;
				sprmparam37 = sccmd.Parameters.Add("@active", SqlDbType.Bit);
				sprmparam37.Value = employeeinfo.IsActive;
				sprmparam37 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.Narration;
				sprmparam37 = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.BloodGroup;
				sprmparam37 = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.PassportNo;
				sprmparam37 = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
				sprmparam37.Value = employeeinfo.PassportExpiryDate;
				sprmparam37 = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.LabourCardNumber;
				sprmparam37 = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
				sprmparam37.Value = employeeinfo.LabourCardExpiryDate;
				sprmparam37 = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.VisaNumber;
				sprmparam37 = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
				sprmparam37.Value = employeeinfo.VisaExpiryDate;
				sprmparam37 = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.SalaryType;
				sprmparam37 = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
				sprmparam37.Value = employeeinfo.DailyWage;
				sprmparam37 = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.BankName;
				sprmparam37 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.BranchName;
				sprmparam37 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.BankAccountNumber;
				sprmparam37 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.BranchCode;
				sprmparam37 = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.PanNumber;
				sprmparam37 = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.PfNumber;
				sprmparam37 = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.EsiNumber;
				sprmparam37 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam37.Value = employeeinfo.ExtraDate;
				sprmparam37 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.Extra1;
				sprmparam37 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam37.Value = employeeinfo.Extra2;
				sprmparam37 = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
				sprmparam37.Value = employeeinfo.DefaultPackageId;
				int inAffectedRows = sccmd.ExecuteNonQuery();
				isEdit = (inAffectedRows > 0 && true);
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

		public decimal EmployeeAddWithReturnIdentity(EmployeeInfo employeeinfo)
		{
			decimal decEmployee = -1m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeeForTakingEmployeeId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam35 = new SqlParameter();
				sprmparam35 = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
				sprmparam35.Value = employeeinfo.DesignationId;
				sprmparam35 = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.EmployeeName;
				sprmparam35 = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.EmployeeCode;
				sprmparam35 = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
				sprmparam35.Value = employeeinfo.Dob;
				sprmparam35 = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.MaritalStatus;
				sprmparam35 = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.Gender;
				sprmparam35 = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.Qualification;
				sprmparam35 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.Address;
				sprmparam35 = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.PhoneNumber;
				sprmparam35 = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.MobileNumber;
				sprmparam35 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.Email;
				sprmparam35 = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
				sprmparam35.Value = employeeinfo.JoiningDate;
				sprmparam35 = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
				sprmparam35.Value = employeeinfo.TerminationDate;
				sprmparam35 = sccmd.Parameters.Add("@active", SqlDbType.Bit);
				sprmparam35.Value = employeeinfo.IsActive;
				sprmparam35 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.Narration;
				sprmparam35 = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.BloodGroup;
				sprmparam35 = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.PassportNo;
				sprmparam35 = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
				sprmparam35.Value = employeeinfo.PassportExpiryDate;
				sprmparam35 = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.LabourCardNumber;
				sprmparam35 = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
				sprmparam35.Value = employeeinfo.LabourCardExpiryDate;
				sprmparam35 = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.VisaNumber;
				sprmparam35 = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
				sprmparam35.Value = employeeinfo.VisaExpiryDate;
				sprmparam35 = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.SalaryType;
				sprmparam35 = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
				sprmparam35.Value = employeeinfo.DailyWage;
				sprmparam35 = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.BankName;
				sprmparam35 = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.BranchName;
				sprmparam35 = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.BankAccountNumber;
				sprmparam35 = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.BranchCode;
				sprmparam35 = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.PanNumber;
				sprmparam35 = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.PfNumber;
				sprmparam35 = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.EsiNumber;
				sprmparam35 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.Extra1;
				sprmparam35 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam35.Value = employeeinfo.Extra2;
				sprmparam35 = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
				sprmparam35.Value = employeeinfo.DefaultPackageId;
				object AdvancePaymentId = sccmd.ExecuteScalar();
				decEmployee = ((AdvancePaymentId == null) ? -1m : Convert.ToDecimal(AdvancePaymentId.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decEmployee;
		}

		public string SalesmanGetDesignationId()
		{
			string strdesignationId = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesManGetDesignationId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam = new SqlParameter();
				strdesignationId = sqlcmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return strdesignationId;
		}

		public DataTable SalesmanViewAll()
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl.No", typeof(decimal));
			dtbl.Columns["Sl.No"].AutoIncrement = true;
			dtbl.Columns["Sl.No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl.No"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesmanViewAll", base.sqlcon);
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

		public EmployeeInfo SalesmanViewSpecificFeilds(decimal employeeId)
		{
			EmployeeInfo infoemployee = new EmployeeInfo();
			SqlDataReader sqldr = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesmanViewSpecificFeilds", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam2.Value = employeeId;
				sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoemployee.EmployeeId = Convert.ToDecimal(((DbDataReader)sqldr)["employeeId"].ToString());
					infoemployee.EmployeeName = ((DbDataReader)sqldr)["employeeName"].ToString();
					infoemployee.EmployeeCode = ((DbDataReader)sqldr)["employeeCode"].ToString();
					infoemployee.Email = ((DbDataReader)sqldr)["email"].ToString();
					infoemployee.PhoneNumber = ((DbDataReader)sqldr)["phoneNumber"].ToString();
					infoemployee.MobileNumber = ((DbDataReader)sqldr)["mobileNumber"].ToString();
					infoemployee.Address = ((DbDataReader)sqldr)["address"].ToString();
					infoemployee.Narration = ((DbDataReader)sqldr)["narration"].ToString();
					infoemployee.IsActive = Convert.ToBoolean(((DbDataReader)sqldr)["isActive"].ToString());
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
			return infoemployee;
		}

		public DataTable SalesmanSearch(string strEmployeeCode, string strEmployeeName, string strPhoneNumber, string strMobileNumber, string strIsActive)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl.No", typeof(decimal));
			dtbl.Columns["Sl.No"].AutoIncrement = true;
			dtbl.Columns["Sl.No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl.No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SalesmanSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
				sqlda.SelectCommand.Parameters.Add("@mobileNumber", SqlDbType.VarChar).Value = strMobileNumber;
				sqlda.SelectCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = strPhoneNumber;
				sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strIsActive;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtbl;
		}

		public bool SalesmanEdit(EmployeeInfo employeeinfo)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalesmanEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam10.Value = employeeinfo.EmployeeId;
				sprmparam10 = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
				sprmparam10.Value = employeeinfo.EmployeeName;
				sprmparam10 = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
				sprmparam10.Value = employeeinfo.EmployeeCode;
				sprmparam10 = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
				sprmparam10.Value = employeeinfo.Address;
				sprmparam10 = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
				sprmparam10.Value = employeeinfo.PhoneNumber;
				sprmparam10 = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
				sprmparam10.Value = employeeinfo.MobileNumber;
				sprmparam10 = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
				sprmparam10.Value = employeeinfo.Email;
				sprmparam10 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam10.Value = employeeinfo.IsActive;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = employeeinfo.Narration;
				int inAffectedRows = sccmd.ExecuteNonQuery();
				isEdit = (inAffectedRows > 0 && true);
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

		public decimal SalesmanCheckReferenceAndDelete(decimal decEmployeeId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalesmanCheckReferenceAndDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam2.Value = decEmployeeId;
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

		public DataTable EmployeeViewForPaySlip()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("EmployeeViewForPaySlip", base.sqlcon);
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

		public decimal EmployeeCheckReferences(decimal decEmployeeId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("EmployeeCheckReferences", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam2.Value = decEmployeeId;
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

		public DataTable EmployeeViewSalesman()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("EmployeeViewSalesman", base.sqlcon);
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

		public DataTable EmployeeViewAllForEmployeeAddressBook(string strEmployeeCode, string strMobile, string strPhone, string strEmail)
		{
			DataTable dtblEmployee = new DataTable();
			dtblEmployee.Columns.Add("SlNo", typeof(int));
			dtblEmployee.Columns["SlNo"].AutoIncrement = true;
			dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewAllForEmployeeAddressBook", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@mobile", SqlDbType.VarChar).Value = strMobile;
				sqlda.SelectCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = strPhone;
				sqlda.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = strEmail;
				sqlda.Fill(dtblEmployee);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return dtblEmployee;
		}

		public DataTable EmployeeViewAllForDailySalaryReport(string strEmployeeCode, string strDesignation, DateTime dtFromDate, DateTime dtToDate, string strStatus)
		{
			DataTable dtblEmployee = new DataTable();
			dtblEmployee.Columns.Add("SlNo", typeof(int));
			dtblEmployee.Columns["SlNo"].AutoIncrement = true;
			dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewAllForDailySalaryReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
				sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
				sqlda.Fill(dtblEmployee);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblEmployee;
		}

		public DataTable EmployeeViewAllEmployeeReport(string strDesignation, string strEmployeeCode, string strStatus)
		{
			DataTable dtblEmployee = new DataTable();
			dtblEmployee.Columns.Add("SlNo", typeof(int));
			dtblEmployee.Columns["SlNo"].AutoIncrement = true;
			dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewAllEmployeeReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@designationName", SqlDbType.VarChar).Value = strDesignation;
				sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
				sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
				sqlda.Fill(dtblEmployee);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblEmployee;
		}

		public DataTable EmployeeViewByDesignationAndStatus(string strDesignationName, string strStatus)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewByDesignationAndStatus", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@designationName", SqlDbType.VarChar).Value = strDesignationName;
				sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
				sqlda.Fill(dtbl);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtbl;
		}

		public void EmployeePackageEdit(decimal decEmployeeId, decimal decPackageId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("EmployeePackageEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sprmparam3.Value = decEmployeeId;
				sprmparam3 = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
				sprmparam3.Value = decPackageId;
				int ina = sccmd.ExecuteNonQuery();
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
	}
}
