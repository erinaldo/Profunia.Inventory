using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class SalaryPackageDetailsSP : DBConnection
	{
		public bool SalaryPackageDetailsAdd(SalaryPackageDetailsInfo salarypackagedetailsinfo)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam7.Value = salarypackagedetailsinfo.SalaryPackageId;
				sprmparam7 = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
				sprmparam7.Value = salarypackagedetailsinfo.PayHeadId;
				sprmparam7 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam7.Value = salarypackagedetailsinfo.Amount;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = salarypackagedetailsinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = salarypackagedetailsinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = salarypackagedetailsinfo.Extra2;
				int inValue = sccmd.ExecuteNonQuery();
				if (inValue > 0)
				{
					isSave = true;
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
			return isSave;
		}

		public void SalaryPackageDetailsEdit(SalaryPackageDetailsInfo salarypackagedetailsinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@salaryPackageDetailsId", SqlDbType.Decimal);
				sprmparam9.Value = salarypackagedetailsinfo.SalaryPackageDetailsId;
				sprmparam9 = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam9.Value = salarypackagedetailsinfo.SalaryPackageId;
				sprmparam9 = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
				sprmparam9.Value = salarypackagedetailsinfo.PayHeadId;
				sprmparam9 = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
				sprmparam9.Value = salarypackagedetailsinfo.Amount;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = salarypackagedetailsinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam9.Value = salarypackagedetailsinfo.ExtraDate;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = salarypackagedetailsinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = salarypackagedetailsinfo.Extra2;
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

		public DataTable SalaryPackageDetailsViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageDetailsViewAll", base.sqlcon);
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

		public SalaryPackageDetailsInfo SalaryPackageDetailsView(decimal salaryPackageDetailsId)
		{
			SalaryPackageDetailsInfo salarypackagedetailsinfo = new SalaryPackageDetailsInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryPackageDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = salaryPackageDetailsId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					salarypackagedetailsinfo.SalaryPackageDetailsId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					salarypackagedetailsinfo.SalaryPackageId = decimal.Parse(((DbDataReader)sdrreader)[1].ToString());
					salarypackagedetailsinfo.PayHeadId = decimal.Parse(((DbDataReader)sdrreader)[2].ToString());
					salarypackagedetailsinfo.Amount = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					salarypackagedetailsinfo.Narration = ((DbDataReader)sdrreader)[4].ToString();
					salarypackagedetailsinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[5].ToString());
					salarypackagedetailsinfo.Extra1 = ((DbDataReader)sdrreader)[6].ToString();
					salarypackagedetailsinfo.Extra2 = ((DbDataReader)sdrreader)[7].ToString();
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
			return salarypackagedetailsinfo;
		}

		public void SalaryPackageDetailsDelete(decimal SalaryPackageDetailsId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@salaryPackageDetailsId", SqlDbType.Decimal);
				sprmparam2.Value = SalaryPackageDetailsId;
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

		public int SalaryPackageDetailsGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsMax", base.sqlcon);
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

		public string PayHeadTypeView(decimal payHeadId)
		{
			string price = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("PayHeadTypeView", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@payHeadId", SqlDbType.Decimal).Value = payHeadId;
				price = sqlcmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				Messages.ErrorMessage(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return price;
		}

		public DataTable SalaryPackageDetailsViewWithSalaryPackageId(decimal decSalaryPackageId)
		{
			DataTable dtblSalaryPackageDetails = new DataTable();
			dtblSalaryPackageDetails.Columns.Add("SL.NO", typeof(decimal));
			dtblSalaryPackageDetails.Columns["SL.NO"].AutoIncrement = true;
			dtblSalaryPackageDetails.Columns["SL.NO"].AutoIncrementSeed = 1L;
			dtblSalaryPackageDetails.Columns["SL.NO"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageDetailsViewWithSalaryPackageId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@salaryPackageId", SqlDbType.Decimal).Value = decSalaryPackageId;
				sqlda.Fill(dtblSalaryPackageDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSalaryPackageDetails;
		}

		public void SalaryPackageDetailsDeleteWithSalaryPackageId(decimal SalaryPackageId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("SalaryPackageDetailsDeleteWithSalaryPackageId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
				sprmparam2.Value = SalaryPackageId;
				int inWorked = sqlcmd.ExecuteNonQuery();
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

		public DataTable SalaryPackageDetailsForSalaryPackageDetailsReport(string strPackageName)
		{
			DataTable dtblSalaryPackageDetails = new DataTable();
			dtblSalaryPackageDetails.Columns.Add("SlNo", typeof(int));
			dtblSalaryPackageDetails.Columns["SlNo"].AutoIncrement = true;
			dtblSalaryPackageDetails.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblSalaryPackageDetails.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageDetailsForSalaryPackageDetailsReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@packageName", SqlDbType.VarChar).Value = strPackageName;
				sqlda.Fill(dtblSalaryPackageDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblSalaryPackageDetails;
		}
	}
}
