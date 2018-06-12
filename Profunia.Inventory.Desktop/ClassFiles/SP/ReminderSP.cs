using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class ReminderSP : DBConnection
	{
		public bool ReminderAdd(ReminderInfo reminderinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReminderAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam7.Value = reminderinfo.FromDate;
				sprmparam7 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam7.Value = reminderinfo.ToDate;
				sprmparam7 = sccmd.Parameters.Add("@remindAbout", SqlDbType.VarChar);
				sprmparam7.Value = reminderinfo.RemindAbout;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = reminderinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = reminderinfo.Extra2;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = reminderinfo.ExtraDate;
				int inEffectedRows = sccmd.ExecuteNonQuery();
				if (inEffectedRows > 0)
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

		public bool RemainderEdit(ReminderInfo remainderinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReminderEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam8 = new SqlParameter();
				sprmparam8 = sccmd.Parameters.Add("@reminderId", SqlDbType.Decimal);
				sprmparam8.Value = remainderinfo.ReminderId;
				sprmparam8 = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sprmparam8.Value = remainderinfo.FromDate;
				sprmparam8 = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
				sprmparam8.Value = remainderinfo.ToDate;
				sprmparam8 = sccmd.Parameters.Add("@remindAbout", SqlDbType.VarChar);
				sprmparam8.Value = remainderinfo.RemindAbout;
				sprmparam8 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam8.Value = remainderinfo.Extra1;
				sprmparam8 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam8.Value = remainderinfo.Extra2;
				sprmparam8 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam8.Value = remainderinfo.ExtraDate;
				int inEffectedRows = sccmd.ExecuteNonQuery();
				if (inEffectedRows > 0)
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

		public DataTable RemainderViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("ReminderViewAll", base.sqlcon);
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

		public ReminderInfo RemainderView(decimal remainder)
		{
			ReminderInfo remainderinfo = new ReminderInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReminderView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@reminderId", SqlDbType.Decimal);
				sprmparam2.Value = remainder;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					remainderinfo.FromDate = DateTime.Parse(((DbDataReader)sdrreader)["fromDate"].ToString());
					remainderinfo.ToDate = DateTime.Parse(((DbDataReader)sdrreader)["toDate"].ToString());
					remainderinfo.RemindAbout = ((DbDataReader)sdrreader)["remindAbout"].ToString();
					remainderinfo.Extra1 = ((DbDataReader)sdrreader)["extra1"].ToString();
					remainderinfo.Extra2 = ((DbDataReader)sdrreader)["extra2"].ToString();
					remainderinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)["extraDate"].ToString());
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
			return remainderinfo;
		}

		public bool RemainderDelete(decimal Remainder)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReminderDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@reminderId", SqlDbType.Decimal);
				sprmparam2.Value = Remainder;
				decimal decNoEffectedRows = sccmd.ExecuteNonQuery();
				if (decNoEffectedRows > 0m)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return false;
		}

		public int RemainderGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("ReminderMax", base.sqlcon);
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

		public DataTable ReminderSearch(string strfromDate, string strToDate)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(int));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ReminderSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strfromDate;
				sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strToDate;
				sqlda.SelectCommand.Parameters.Add("@userId", SqlDbType.VarChar).Value = PublicVariables._decCurrentUserId.ToString();
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

		public DataTable OverDuePurchaseOrdersCorrespondingAccountLedger(decimal decLedgerId)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(int));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("OverDuePurchaseOrdersCorrespondingAccountLedger", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@accountLedgerId", SqlDbType.Decimal).Value = decLedgerId;
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

		public DataTable ShortExpiryReminderGridFill(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReminderGridSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("slNo", typeof(decimal));
				dtblReg.Columns["slNo"].AutoIncrement = true;
				dtblReg.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblReg.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param9 = new SqlParameter();
				param9 = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				param9.Value = groupId;
				param9 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				param9.Value = productId;
				param9 = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
				param9.Value = brandId;
				param9 = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
				param9.Value = sizeId;
				param9 = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				param9.Value = modelNoId;
				param9 = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				param9.Value = taxId;
				param9 = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
				param9.Value = godownId;
				param9 = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
				param9.Value = rackId;
				sqlda.Fill(dtblReg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblReg;
		}

		public DataTable OverdueSalesOrderCorrespondingAccountLedger(decimal decLedgerId)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("SlNo", typeof(int));
			dtbl.Columns["SlNo"].AutoIncrement = true;
			dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
			dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("OverdueSalesOrderCorrespondingAccountLedger", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@accountLedgerId", SqlDbType.Decimal).Value = decLedgerId;
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

		public DataTable StockSearch(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId, string strcriteria)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("StockSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("Sl No", typeof(decimal));
				dtblReg.Columns["Sl No"].AutoIncrement = true;
				dtblReg.Columns["Sl No"].AutoIncrementSeed = 1L;
				dtblReg.Columns["Sl No"].AutoIncrementStep = 1L;
				SqlParameter param10 = new SqlParameter();
				param10 = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				param10.Value = groupId;
				param10 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				param10.Value = productId;
				param10 = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
				param10.Value = brandId;
				param10 = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
				param10.Value = sizeId;
				param10 = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				param10.Value = modelNoId;
				param10 = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				param10.Value = taxId;
				param10 = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
				param10.Value = godownId;
				param10 = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
				param10.Value = rackId;
				param10 = sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar);
				param10.Value = strcriteria;
				sqlda.Fill(dtblReg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblReg;
		}

		public DataTable ShortExpiryReportGridFill(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal godownId, decimal rackId, decimal tExpiry, string cExpiry, DateTime today)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReportGridSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("slNo", typeof(decimal));
				dtblReg.Columns["slNo"].AutoIncrement = true;
				dtblReg.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblReg.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param11 = new SqlParameter();
				param11 = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				param11.Value = groupId;
				param11 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				param11.Value = productId;
				param11 = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
				param11.Value = brandId;
				param11 = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
				param11.Value = sizeId;
				param11 = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				param11.Value = modelNoId;
				param11 = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
				param11.Value = godownId;
				param11 = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
				param11.Value = rackId;
				param11 = sqlda.SelectCommand.Parameters.Add("@tExpiry", SqlDbType.Decimal);
				param11.Value = tExpiry;
				param11 = sqlda.SelectCommand.Parameters.Add("@cExpiry", SqlDbType.VarChar);
				param11.Value = cExpiry;
				param11 = sqlda.SelectCommand.Parameters.Add("@today", SqlDbType.DateTime);
				param11.Value = today;
				sqlda.Fill(dtblReg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblReg;
		}

		public DataSet ShortExpiryReportPrinting(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal godownId, decimal rackId, decimal tExpiry, string cExpiry, DateTime today, decimal companyId)
		{
			DataSet dtblSER = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReportPrinting", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter param12 = new SqlParameter();
				param12 = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				param12.Value = groupId;
				param12 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				param12.Value = productId;
				param12 = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
				param12.Value = brandId;
				param12 = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
				param12.Value = sizeId;
				param12 = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				param12.Value = modelNoId;
				param12 = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
				param12.Value = godownId;
				param12 = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
				param12.Value = rackId;
				param12 = sqlda.SelectCommand.Parameters.Add("@tExpiry", SqlDbType.Decimal);
				param12.Value = tExpiry;
				param12 = sqlda.SelectCommand.Parameters.Add("@cExpiry", SqlDbType.VarChar);
				param12.Value = cExpiry;
				param12 = sqlda.SelectCommand.Parameters.Add("@today", SqlDbType.DateTime);
				param12.Value = today;
				param12 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				param12.Value = companyId;
				sqlda.Fill(dtblSER);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSER;
		}

		public DataTable ShortExpiryReminder(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId)
		{
			DataTable dtblReg = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReminder", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				dtblReg.Columns.Add("slNo", typeof(decimal));
				dtblReg.Columns["slNo"].AutoIncrement = true;
				dtblReg.Columns["slNo"].AutoIncrementSeed = 1L;
				dtblReg.Columns["slNo"].AutoIncrementStep = 1L;
				SqlParameter param9 = new SqlParameter();
				param9 = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
				param9.Value = groupId;
				param9 = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
				param9.Value = productId;
				param9 = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
				param9.Value = brandId;
				param9 = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
				param9.Value = sizeId;
				param9 = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
				param9.Value = modelNoId;
				param9 = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				param9.Value = taxId;
				param9 = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
				param9.Value = godownId;
				param9 = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
				param9.Value = rackId;
				sqlda.Fill(dtblReg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblReg;
		}
	}
}
