using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class VoucherTypeSP : DBConnection
	{
		public void VoucherTypeAdd(VoucherTypeInfo vouchertypeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.VoucherTypeName;
				sprmparam16 = sccmd.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.TypeOfVoucher;
				sprmparam16 = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.MethodOfVoucherNumbering;
				sprmparam16 = sccmd.Parameters.Add("@isTaxApplicable", SqlDbType.Bit);
				sprmparam16.Value = vouchertypeinfo.IsTaxApplicable;
				sprmparam16 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Narration;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Extra2;
				sprmparam16 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam16.Value = vouchertypeinfo.IsActive;
				sprmparam16 = sccmd.Parameters.Add("@IsDefault", SqlDbType.Bit);
				sprmparam16.Value = vouchertypeinfo.IsDefault;
				sprmparam16 = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
				sprmparam16.Value = vouchertypeinfo.MasterId;
				sprmparam16 = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Declarartion;
				sprmparam16 = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading1;
				sprmparam16 = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading2;
				sprmparam16 = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading3;
				sprmparam16 = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading4;
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

		public void VoucherTypeEdit(VoucherTypeInfo vouchertypeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam17 = new SqlParameter();
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam17.Value = vouchertypeinfo.VoucherTypeId;
				sprmparam17 = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.VoucherTypeName;
				sprmparam17 = sccmd.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.TypeOfVoucher;
				sprmparam17 = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.MethodOfVoucherNumbering;
				sprmparam17 = sccmd.Parameters.Add("@isTaxApplicable", SqlDbType.Bit);
				sprmparam17.Value = vouchertypeinfo.IsTaxApplicable;
				sprmparam17 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Narration;
				sprmparam17 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Extra1;
				sprmparam17 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Extra2;
				sprmparam17 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam17.Value = vouchertypeinfo.IsActive;
				sprmparam17 = sccmd.Parameters.Add("@IsDefault", SqlDbType.Bit);
				sprmparam17.Value = vouchertypeinfo.IsDefault;
				sprmparam17 = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
				sprmparam17.Value = vouchertypeinfo.MasterId;
				sprmparam17 = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Declarartion;
				sprmparam17 = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Heading1;
				sprmparam17 = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Heading2;
				sprmparam17 = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Heading3;
				sprmparam17 = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
				sprmparam17.Value = vouchertypeinfo.Heading4;
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

		public DataTable VoucherWiseProductSearchCombofill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherWiseProductSearchCombofill", base.sqlcon);
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

		public DataTable VoucherTypeViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAll", base.sqlcon);
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

		public void voucherTypeComboFill(ComboBox cmbVoucherType, bool isAll)
		{
			DataTable dtbl = new DataTable();
			SqlDataAdapter sdaadapter = new SqlDataAdapter("voucherTypeSelectionForVoucherSearch", base.sqlcon);
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.Fill(dtbl);
				if (isAll)
				{
					DataRow dr = dtbl.NewRow();
					dr["voucherTypeName"] = "All";
					dr["voucherTypeId"] = 0;
					dtbl.Rows.InsertAt(dr, 0);
				}
				cmbVoucherType.DataSource = dtbl;
				cmbVoucherType.ValueMember = "voucherTypeId";
				cmbVoucherType.DisplayMember = "voucherTypeName";
				cmbVoucherType.SelectedIndex = 0;
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

		public string TypeOfVoucherView(string strvoucherTypeName)
		{
			string StrTypeOfVoucher = string.Empty;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("GetTypeOfVoucherFromVoucherType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@voucherType", SqlDbType.VarChar).Value = strvoucherTypeName;
				StrTypeOfVoucher = sccmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return StrTypeOfVoucher;
		}

		public VoucherTypeInfo VoucherTypeView(decimal voucherTypeId)
		{
			VoucherTypeInfo vouchertypeinfo = new VoucherTypeInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = voucherTypeId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					vouchertypeinfo.VoucherTypeId = Convert.ToDecimal(((DbDataReader)sdrreader)[0].ToString());
					vouchertypeinfo.VoucherTypeName = ((DbDataReader)sdrreader)[1].ToString();
					vouchertypeinfo.TypeOfVoucher = ((DbDataReader)sdrreader)[2].ToString();
					vouchertypeinfo.MethodOfVoucherNumbering = ((DbDataReader)sdrreader)[3].ToString();
					vouchertypeinfo.IsTaxApplicable = Convert.ToBoolean(((DbDataReader)sdrreader)[4].ToString());
					vouchertypeinfo.Narration = ((DbDataReader)sdrreader)[5].ToString();
					vouchertypeinfo.ExtraDate = Convert.ToDateTime(((DbDataReader)sdrreader)[6].ToString());
					vouchertypeinfo.Extra1 = ((DbDataReader)sdrreader)[7].ToString();
					vouchertypeinfo.Extra2 = ((DbDataReader)sdrreader)[8].ToString();
					vouchertypeinfo.IsActive = Convert.ToBoolean(((DbDataReader)sdrreader)[9].ToString());
					vouchertypeinfo.MasterId = Convert.ToInt32(((DbDataReader)sdrreader)[10].ToString());
					vouchertypeinfo.Declarartion = ((DbDataReader)sdrreader)[11].ToString();
					vouchertypeinfo.Heading1 = ((DbDataReader)sdrreader)[12].ToString();
					vouchertypeinfo.Heading2 = ((DbDataReader)sdrreader)[13].ToString();
					vouchertypeinfo.Heading3 = ((DbDataReader)sdrreader)[14].ToString();
					vouchertypeinfo.Heading4 = ((DbDataReader)sdrreader)[15].ToString();
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
			return vouchertypeinfo;
		}

		public void VoucherTypeDelete(decimal VoucherTypeId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = VoucherTypeId;
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

		public int VoucherTypeGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeMax", base.sqlcon);
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

		public DataTable VoucherTypeSelectionComboFill(string strVoucherType)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeSelectionComboFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@strVoucherType", SqlDbType.VarChar).Value = strVoucherType;
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

		public DataTable VoucherTypeViewAllByVoucherNo()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAllByVoucherNo", base.sqlcon);
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

		public DataTable VoucherNoCombofillByVoucherType(decimal decGodown)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherNoCombofillByVoucherType", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decGodown;
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

		public bool CheckMethodOfVoucherNumbering(decimal voucherTypeId)
		{
			VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
			SqlDataReader sdrreader2 = null;
			bool isAutomatic = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckMethodOfVoucherNumbering", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = voucherTypeId;
				sdrreader2 = sccmd.ExecuteReader();
				while (sdrreader2.Read())
				{
					infoVoucherType.MethodOfVoucherNumbering = ((DbDataReader)sdrreader2)["methodOfVoucherNumbering"].ToString();
				}
				if (infoVoucherType.MethodOfVoucherNumbering == "Automatic")
				{
					isAutomatic = true;
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
			return isAutomatic;
		}

		public DataTable VoucherTypeSearch(string strVoucherName, string strTypeOfvoucher)
		{
			DataTable dtblSearch = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtblSearch.Columns.Add("SlNo", typeof(decimal));
				dtblSearch.Columns["SlNo"].AutoIncrement = true;
				dtblSearch.Columns["SlNo"].AutoIncrementSeed = 1L;
				dtblSearch.Columns["SlNo"].AutoIncrementStep = 1L;
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeSearch", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherName;
				sdaadapter.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = strTypeOfvoucher;
				sdaadapter.Fill(dtblSearch);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblSearch;
		}

		public DataTable TypeOfVoucherComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TypeOfVoucherComboFill", base.sqlcon);
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

		public decimal VoucherTypeAddWithIdentity(VoucherTypeInfo vouchertypeinfo)
		{
			decimal decVoucherTypeId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeAddWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam16 = new SqlParameter();
				sprmparam16 = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.VoucherTypeName;
				sprmparam16 = sccmd.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.TypeOfVoucher;
				sprmparam16 = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.MethodOfVoucherNumbering;
				sprmparam16 = sccmd.Parameters.Add("@isTaxApplicable", SqlDbType.Bit);
				sprmparam16.Value = vouchertypeinfo.IsTaxApplicable;
				sprmparam16 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Narration;
				sprmparam16 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Extra1;
				sprmparam16 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Extra2;
				sprmparam16 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam16.Value = vouchertypeinfo.IsActive;
				sprmparam16 = sccmd.Parameters.Add("@IsDefault", SqlDbType.Bit);
				sprmparam16.Value = vouchertypeinfo.IsDefault;
				sprmparam16 = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
				sprmparam16.Value = vouchertypeinfo.MasterId;
				sprmparam16 = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Declarartion;
				sprmparam16 = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading1;
				sprmparam16 = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading2;
				sprmparam16 = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading3;
				sprmparam16 = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
				sprmparam16.Value = vouchertypeinfo.Heading4;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					decVoucherTypeId = Convert.ToDecimal(obj.ToString());
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
			return decVoucherTypeId;
		}

		public bool VoucherTypeCheckExistence(string strvoucherTypeName, decimal decvoucherTypeId)
		{
			bool isExists = true;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeCheckExistence", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam3.Value = decvoucherTypeId;
				sprmparam3 = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
				sprmparam3.Value = strvoucherTypeName;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					isExists = (obj.ToString() == "0" && true);
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
			return isExists;
		}

		public DataTable GetTaxIdForTaxSelection(decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("GetTaxIdForTaxSelection", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public bool CheckForDefaultVoucherType(decimal decVoucherTypeId)
		{
			bool isDefault = true;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("CheckForDefaultVoucherType", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					isDefault = (obj.ToString() == "1" && true);
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
			return isDefault;
		}

		public void VoucherTypeEditForDefaultVouchers(VoucherTypeInfo vouchertypeinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeEditForDefaultVouchers", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam10.Value = vouchertypeinfo.VoucherTypeId;
				sprmparam10 = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
				sprmparam10.Value = vouchertypeinfo.MethodOfVoucherNumbering;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = vouchertypeinfo.Narration;
				sprmparam10 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam10.Value = vouchertypeinfo.IsActive;
				sprmparam10 = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
				sprmparam10.Value = vouchertypeinfo.Declarartion;
				sprmparam10 = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
				sprmparam10.Value = vouchertypeinfo.Heading1;
				sprmparam10 = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
				sprmparam10.Value = vouchertypeinfo.Heading2;
				sprmparam10 = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
				sprmparam10.Value = vouchertypeinfo.Heading3;
				sprmparam10 = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
				sprmparam10.Value = vouchertypeinfo.Heading4;
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

		public bool VoucherTypeChechReferences(decimal decVoucherTypeId)
		{
			bool isActive = true;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherTypeChechReferences", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
				object obj = sccmd.ExecuteScalar();
				if (obj != null)
				{
					isActive = (obj.ToString() == "1" && true);
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
			return isActive;
		}

		public DataTable VoucherTypeNameComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeNameComboFill", base.sqlcon);
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

		public DataTable VoucherTypeViewAllForAgainstBillDetails()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAllForAgainstBillDetails", base.sqlcon);
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

		public DataTable VoucherTypeNameViewAllForComboFill(decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeNameViewAllForComboFill", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam2.Value = decVoucherTypeId;
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

		public DataTable DeclarationAndHeadingGetByVoucherTypeId(decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("DeclarationAndHeadingGetByVoucherTypeId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public DataTable VoucherSearchFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decEmployeeId)
		{
			DataTable dtbl = new DataTable();
			dtbl.Columns.Add("Sl No");
			dtbl.Columns["Sl No"].AutoIncrement = true;
			dtbl.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtbl.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqldataadapter = new SqlDataAdapter("VoucherSearch", base.sqlcon);
				sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparameter7 = new SqlParameter();
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
				sqlparameter7.Value = fromDate;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
				sqlparameter7.Value = toDate;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@voucherType", SqlDbType.Decimal);
				sqlparameter7.Value = decVoucherTypeId;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
				sqlparameter7.Value = strVoucherNo;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sqlparameter7.Value = decLedgerId;
				sqlparameter7 = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
				sqlparameter7.Value = decEmployeeId;
				sqldataadapter.Fill(dtbl);
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

		public DataTable VatComboFill()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("VatComboFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable VatGridFill(DateTime fromDate, DateTime toDate, string voucherName, decimal decVoucherTypeId, string format, string tax)
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("VatGridFill", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime).Value = fromDate;
				sqlda.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime).Value = toDate;
				sqlda.SelectCommand.Parameters.Add("@voucherName", SqlDbType.VarChar).Value = voucherName;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sqlda.SelectCommand.Parameters.Add("@format", SqlDbType.VarChar).Value = format;
				sqlda.SelectCommand.Parameters.Add("@tax", SqlDbType.VarChar).Value = tax;
				sqlda.Fill(dtbl);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public DataTable VatViewTaxNames()
		{
			DataTable dtbl = new DataTable();
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("VatViewTaxNames", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.Fill(dtbl);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtbl;
		}

		public string VoucherreportsumQty(decimal dSalesId, string strVoucherType)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("VoucherreportsumQty", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal).Value = dSalesId;
				sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
				return sccmd.ExecuteScalar().ToString();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
		}

		public int FormIdGetForPrinterSettings(int inMasterId)
		{
			int frmId = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("FormIdGetForPrinterSettings", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				sccmd.Parameters.Add("@masterId", SqlDbType.Decimal).Value = inMasterId;
				frmId = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				base.sqlcon.Close();
			}
			return frmId;
		}

		public VoucherTypeInfo TypeOfVoucherBasedOnVoucherTypeId(decimal decVoucherTypeId)
		{
			SqlDataReader sdrReader = null;
			VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("TypeOfVoucherBasedOnVoucherTypeId", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sdrReader = sqlcmd.ExecuteReader();
				while (sdrReader.Read())
				{
					infoVoucherType.TypeOfVoucher = ((DbDataReader)sdrReader)["typeOfVoucher"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("VTSP:1" + ex.Message, "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			finally
			{
				sdrReader.Close();
				base.sqlcon.Close();
			}
			return infoVoucherType;
		}

		public DataTable TypeOfVoucherCombofillForVatAndTaxReport()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TypeOfVoucherCombofillForVatAndTaxReport", base.sqlcon);
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

		public DataTable VoucherTypeCombofillForTaxAndVat(string strVoucherType)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeNameCorrespondingToTypeOfVoucher", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sdaadapter.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = strVoucherType;
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
