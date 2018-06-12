using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class PayHeadSP : DBConnection
	{
		public void PayHeadAdd(PayHeadInfo payheadinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PayHeadAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
				sprmparam7.Value = payheadinfo.PayHeadName;
				sprmparam7 = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam7.Value = payheadinfo.Type;
				sprmparam7 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam7.Value = payheadinfo.Narration;
				sprmparam7 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam7.Value = payheadinfo.ExtraDate;
				sprmparam7 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam7.Value = payheadinfo.Extra1;
				sprmparam7 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam7.Value = payheadinfo.Extra2;
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

		public void PayHeadEdit(PayHeadInfo payheadinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PayHeadEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
				sprmparam5.Value = payheadinfo.PayHeadId;
				sprmparam5 = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
				sprmparam5.Value = payheadinfo.PayHeadName;
				sprmparam5 = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam5.Value = payheadinfo.Type;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = payheadinfo.Narration;
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

		public DataTable PayHeadViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtbl.Columns.Add("Slno:", typeof(int));
				dtbl.Columns["Slno:"].AutoIncrement = true;
				dtbl.Columns["Slno:"].AutoIncrementSeed = 1L;
				dtbl.Columns["Slno:"].AutoIncrementStep = 1L;
				SqlDataAdapter sdaadapter = new SqlDataAdapter("PayHeadViewAll", base.sqlcon);
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

		public PayHeadInfo PayHeadView(decimal payHeadId)
		{
			PayHeadInfo payheadinfo = new PayHeadInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PayHeadView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
				sprmparam2.Value = payHeadId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					payheadinfo.PayHeadId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					payheadinfo.PayHeadName = ((DbDataReader)sdrreader)[1].ToString();
					payheadinfo.Type = ((DbDataReader)sdrreader)[2].ToString();
					payheadinfo.Narration = ((DbDataReader)sdrreader)[3].ToString();
					payheadinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[4].ToString());
					payheadinfo.Extra1 = ((DbDataReader)sdrreader)[5].ToString();
					payheadinfo.Extra2 = ((DbDataReader)sdrreader)[6].ToString();
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
			return payheadinfo;
		}

		public void PayHeadDelete(decimal PayHeadId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PayHeadDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
				sprmparam2.Value = PayHeadId;
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

		public int PayHeadGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PayHeadMax", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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

		public DataTable PayHeadSearch(string a)
		{
			DataTable dtblpayhead = new DataTable();
			dtblpayhead.Columns.Add("Slno:", typeof(int));
			dtblpayhead.Columns["Slno:"].AutoIncrement = true;
			dtblpayhead.Columns["Slno:"].AutoIncrementSeed = 1L;
			dtblpayhead.Columns["Slno:"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("PayHeadSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@a", SqlDbType.VarChar).Value = a;
				sqlda.Fill(dtblpayhead);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblpayhead;
		}

		public bool PayheadCheckExistence(string PaheadName, decimal PayHeadId)
		{
			bool isSave = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PayheadCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
				sprmparam3.Value = PaheadName;
				sprmparam3 = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
				sprmparam3.Value = PayHeadId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
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

		public bool PayHeadDeleteVoucherTypeCheckReference(decimal PayHeadId)
		{
			bool inPayHeadId = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("PayHeadDeleteVoucherTypeCheckReference", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@PayHeadId", SqlDbType.Decimal);
				sprmparam2.Value = PayHeadId;
				int ina = sccmd.ExecuteNonQuery();
				if (ina == -1)
				{
					inPayHeadId = true;
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
			return inPayHeadId;
		}

		public bool payheadTypeCheckeferences(decimal PayHeadId, string PayHeadName, string Type, string Narration)
		{
			bool RefPayHeadId = true;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("payheadTypeCheckeferences", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam5 = new SqlParameter();
				sprmparam5 = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
				sprmparam5.Value = PayHeadId;
				sprmparam5 = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
				sprmparam5.Value = PayHeadName;
				sprmparam5 = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
				sprmparam5.Value = Type;
				sprmparam5 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam5.Value = Narration;
				int invalue = Convert.ToInt32(sccmd.ExecuteScalar());
				if (invalue == 1)
				{
					RefPayHeadId = false;
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
			return RefPayHeadId;
		}

		public DataTable PayHeadViewAllForPayHeadReport(string strPayHeadName, string strType)
		{
			DataTable dtblPayHead = new DataTable();
			dtblPayHead.Columns.Add("SlNo", typeof(int));
			dtblPayHead.Columns["SlNo"].AutoIncrement = true;
			dtblPayHead.Columns["SlNo"].AutoIncrementSeed = 1L;
			dtblPayHead.Columns["SlNo"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("PayHeadViewAllForPayHeadReport", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@payheadName", SqlDbType.VarChar).Value = strPayHeadName;
				sqlda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
				sqlda.Fill(dtblPayHead);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dtblPayHead;
		}
	}
}
