using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class MasterSPrint : DBConnection
	{
		public int MasterAdd(MasterInfo infoMaster)
		{
			int retunvalue = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterAdd", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formName", SqlDbType.Int).Value = infoMaster.FormName;
				sqlcmd.Parameters.Add("@isTwoLineForHedder", SqlDbType.Bit).Value = infoMaster.IsTwoLineForHedder;
				sqlcmd.Parameters.Add("@isTwoLineForDetails", SqlDbType.Bit).Value = infoMaster.IsTwoLineForDetails;
				sqlcmd.Parameters.Add("@pageSize1", SqlDbType.Int).Value = infoMaster.PageSize1;
				sqlcmd.Parameters.Add("@pageSizeOther", SqlDbType.Int).Value = infoMaster.PageSizeOther;
				sqlcmd.Parameters.Add("@blankLneForFooter", SqlDbType.Int).Value = infoMaster.BlankLneForFooter;
				sqlcmd.Parameters.Add("@footerLocation", SqlDbType.VarChar).Value = infoMaster.FooterLocation;
				sqlcmd.Parameters.Add("@lineCountBetweenTwo", SqlDbType.Int).Value = infoMaster.LineCountBetweenTwo;
				sqlcmd.Parameters.Add("@pitch", SqlDbType.VarChar).Value = infoMaster.Pitch;
				sqlcmd.Parameters.Add("@condensed", SqlDbType.VarChar).Value = infoMaster.Condensed;
				sqlcmd.Parameters.Add("@lineCountAfterPrint", SqlDbType.VarChar).Value = infoMaster.LineCountAfterPrint;
				retunvalue = int.Parse(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterAdd", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return retunvalue;
		}

		public void MasterCopyAdd(MasterInfo infoMaster)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterCopyAdd", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = infoMaster.MasterId;
				sqlcmd.Parameters.Add("@formName", SqlDbType.Int).Value = infoMaster.FormName;
				sqlcmd.Parameters.Add("@isTwoLineForHedder", SqlDbType.Bit).Value = infoMaster.IsTwoLineForHedder;
				sqlcmd.Parameters.Add("@isTwoLineForDetails", SqlDbType.Bit).Value = infoMaster.IsTwoLineForDetails;
				sqlcmd.Parameters.Add("@pageSize1", SqlDbType.Int).Value = infoMaster.PageSize1;
				sqlcmd.Parameters.Add("@pageSizeOther", SqlDbType.Int).Value = infoMaster.PageSizeOther;
				sqlcmd.Parameters.Add("@blankLneForFooter", SqlDbType.Int).Value = infoMaster.BlankLneForFooter;
				sqlcmd.Parameters.Add("@footerLocation", SqlDbType.VarChar).Value = infoMaster.FooterLocation;
				sqlcmd.Parameters.Add("@lineCountBetweenTwo", SqlDbType.Int).Value = infoMaster.LineCountBetweenTwo;
				sqlcmd.Parameters.Add("@pitch", SqlDbType.VarChar).Value = infoMaster.Pitch;
				sqlcmd.Parameters.Add("@condensed", SqlDbType.VarChar).Value = infoMaster.Condensed;
				sqlcmd.Parameters.Add("@lineCountAfterPrint", SqlDbType.VarChar).Value = infoMaster.LineCountAfterPrint;
				sqlcmd.ExecuteScalar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterCopyAdd", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void MasterEdit(MasterInfo infoMaster)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = infoMaster.MasterId;
				sqlcmd.Parameters.Add("@formName", SqlDbType.Int).Value = infoMaster.FormName;
				sqlcmd.Parameters.Add("@isTwoLineForHedder", SqlDbType.Bit).Value = infoMaster.IsTwoLineForHedder;
				sqlcmd.Parameters.Add("@isTwoLineForDetails", SqlDbType.Bit).Value = infoMaster.IsTwoLineForDetails;
				sqlcmd.Parameters.Add("@pageSize1", SqlDbType.Int).Value = infoMaster.PageSize1;
				sqlcmd.Parameters.Add("@pageSizeOther", SqlDbType.Int).Value = infoMaster.PageSizeOther;
				sqlcmd.Parameters.Add("@blankLneForFooter", SqlDbType.Int).Value = infoMaster.BlankLneForFooter;
				sqlcmd.Parameters.Add("@footerLocation", SqlDbType.VarChar).Value = infoMaster.FooterLocation;
				sqlcmd.Parameters.Add("@lineCountBetweenTwo", SqlDbType.Int).Value = infoMaster.LineCountBetweenTwo;
				sqlcmd.Parameters.Add("@pitch", SqlDbType.VarChar).Value = infoMaster.Pitch;
				sqlcmd.Parameters.Add("@condensed", SqlDbType.VarChar).Value = infoMaster.Condensed;
				sqlcmd.Parameters.Add("@lineCountAfterPrint", SqlDbType.VarChar).Value = infoMaster.LineCountAfterPrint;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterEdit", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void MasterCopyEdit(MasterInfo infoMaster)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterCopyEdit", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = infoMaster.MasterId;
				sqlcmd.Parameters.Add("@formName", SqlDbType.Int).Value = infoMaster.FormName;
				sqlcmd.Parameters.Add("@isTwoLineForHedder", SqlDbType.Bit).Value = infoMaster.IsTwoLineForHedder;
				sqlcmd.Parameters.Add("@isTwoLineForDetails", SqlDbType.Bit).Value = infoMaster.IsTwoLineForDetails;
				sqlcmd.Parameters.Add("@pageSize1", SqlDbType.Int).Value = infoMaster.PageSize1;
				sqlcmd.Parameters.Add("@pageSizeOther", SqlDbType.Int).Value = infoMaster.PageSizeOther;
				sqlcmd.Parameters.Add("@blankLneForFooter", SqlDbType.Int).Value = infoMaster.BlankLneForFooter;
				sqlcmd.Parameters.Add("@footerLocation", SqlDbType.VarChar).Value = infoMaster.FooterLocation;
				sqlcmd.Parameters.Add("@lineCountBetweenTwo", SqlDbType.Int).Value = infoMaster.LineCountBetweenTwo;
				sqlcmd.Parameters.Add("@pitch", SqlDbType.VarChar).Value = infoMaster.Pitch;
				sqlcmd.Parameters.Add("@condensed", SqlDbType.VarChar).Value = infoMaster.Condensed;
				sqlcmd.Parameters.Add("@lineCountAfterPrint", SqlDbType.VarChar).Value = infoMaster.LineCountAfterPrint;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterCopyEdit", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public void MasterDelate(decimal MasterId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterDelete", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = MasterId;
				sqlcmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterDelate");
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public MasterInfo MasterViewByFormName(int formName)
		{
			MasterInfo infoMaster = new MasterInfo();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterViewByFormName", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formName", SqlDbType.Int).Value = formName;
				SqlDataReader sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoMaster.MasterId = int.Parse(((DbDataReader)sqldr)["masterId"].ToString());
					infoMaster.FormName = int.Parse(((DbDataReader)sqldr)["formName"].ToString());
					infoMaster.IsTwoLineForHedder = bool.Parse(((DbDataReader)sqldr)["isTwoLineForHedder"].ToString());
					infoMaster.IsTwoLineForDetails = bool.Parse(((DbDataReader)sqldr)["isTwoLineForDetails"].ToString());
					infoMaster.PageSize1 = int.Parse(((DbDataReader)sqldr)["pageSize1"].ToString());
					infoMaster.PageSizeOther = int.Parse(((DbDataReader)sqldr)["pageSizeOther"].ToString());
					infoMaster.BlankLneForFooter = int.Parse(((DbDataReader)sqldr)["blankLneForFooter"].ToString());
					infoMaster.FooterLocation = ((DbDataReader)sqldr)["footerLocation"].ToString();
					infoMaster.LineCountBetweenTwo = int.Parse(((DbDataReader)sqldr)["lineCountBetweenTwo"].ToString());
					infoMaster.Pitch = ((DbDataReader)sqldr)["pitch"].ToString();
					infoMaster.Condensed = ((DbDataReader)sqldr)["condensed"].ToString();
					infoMaster.LineCountAfterPrint = int.Parse(((DbDataReader)sqldr)["lineCountAfterPrint"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterViewByFormName", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return infoMaster;
		}

		public MasterInfo MasterCopyViewByFormName(int formName)
		{
			MasterInfo infoMaster = new MasterInfo();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterCopyViewByFormName", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@formName", SqlDbType.Int).Value = formName;
				SqlDataReader sqldr = sqlcmd.ExecuteReader();
				while (sqldr.Read())
				{
					infoMaster.MasterId = int.Parse(((DbDataReader)sqldr)["masterId"].ToString());
					infoMaster.FormName = int.Parse(((DbDataReader)sqldr)["formName"].ToString());
					infoMaster.IsTwoLineForHedder = bool.Parse(((DbDataReader)sqldr)["isTwoLineForHedder"].ToString());
					infoMaster.IsTwoLineForDetails = bool.Parse(((DbDataReader)sqldr)["isTwoLineForDetails"].ToString());
					infoMaster.PageSize1 = int.Parse(((DbDataReader)sqldr)["pageSize1"].ToString());
					infoMaster.PageSizeOther = int.Parse(((DbDataReader)sqldr)["pageSizeOther"].ToString());
					infoMaster.BlankLneForFooter = int.Parse(((DbDataReader)sqldr)["blankLneForFooter"].ToString());
					infoMaster.FooterLocation = ((DbDataReader)sqldr)["footerLocation"].ToString();
					infoMaster.LineCountBetweenTwo = int.Parse(((DbDataReader)sqldr)["lineCountBetweenTwo"].ToString());
					infoMaster.Pitch = ((DbDataReader)sqldr)["pitch"].ToString();
					infoMaster.Condensed = ((DbDataReader)sqldr)["condensed"].ToString();
					infoMaster.LineCountAfterPrint = int.Parse(((DbDataReader)sqldr)["lineCountAfterPrint"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterViewByFormName", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return infoMaster;
		}

		public DataTable FormViewAll()
		{
			DataTable dtblPurchers = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldaPurchers = new SqlDataAdapter("FormViewAll", base.sqlcon);
				sqldaPurchers.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqldaPurchers.Fill(dtblPurchers);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FormViewAll", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblPurchers;
		}

		public DataTable FieldsViewAll(int fieldId)
		{
			DataTable dtblPurchers = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldaPurchers = new SqlDataAdapter("FieldsViewAll", base.sqlcon);
				sqldaPurchers.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqldaPurchers.SelectCommand.Parameters.Add("@formId", SqlDbType.Int).Value = fieldId;
				sqldaPurchers.Fill(dtblPurchers);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "FieldsViewAll", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblPurchers;
		}

		public bool MasterCopyExistCheck(int masterId)
		{
			bool isOk = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("MasterCopyExistCheck", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@masterId", SqlDbType.Int).Value = masterId;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null)
				{
					isOk = bool.Parse(obj.ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "MasterCopyExistCheck", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isOk;
		}
	}
}
