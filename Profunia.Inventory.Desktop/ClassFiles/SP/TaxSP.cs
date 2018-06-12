using System;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles.SP
{
	internal class TaxSP : DBConnection
	{
		public void TaxAdd(TaxInfo taxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxAdd", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam11 = new SqlParameter();
				sprmparam11 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam11.Value = taxinfo.TaxId;
				sprmparam11 = sccmd.Parameters.Add("@taxName", SqlDbType.VarChar);
				sprmparam11.Value = taxinfo.TaxName;
				sprmparam11 = sccmd.Parameters.Add("@applicableOn", SqlDbType.VarChar);
				sprmparam11.Value = taxinfo.ApplicableOn;
				sprmparam11 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam11.Value = taxinfo.Rate;
				sprmparam11 = sccmd.Parameters.Add("@calculatingMode", SqlDbType.VarChar);
				sprmparam11.Value = taxinfo.CalculatingMode;
				sprmparam11 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam11.Value = taxinfo.Narration;
				sprmparam11 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam11.Value = taxinfo.IsActive;
				sprmparam11 = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
				sprmparam11.Value = taxinfo.ExtraDate;
				sprmparam11 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam11.Value = taxinfo.Extra1;
				sprmparam11 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam11.Value = taxinfo.Extra2;
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

		public void TaxEdit(TaxInfo taxinfo)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxEdit", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam10 = new SqlParameter();
				sprmparam10 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam10.Value = taxinfo.TaxId;
				sprmparam10 = sccmd.Parameters.Add("@taxName", SqlDbType.VarChar);
				sprmparam10.Value = taxinfo.TaxName;
				sprmparam10 = sccmd.Parameters.Add("@applicableOn", SqlDbType.VarChar);
				sprmparam10.Value = taxinfo.ApplicableOn;
				sprmparam10 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam10.Value = taxinfo.Rate;
				sprmparam10 = sccmd.Parameters.Add("@calculatingMode", SqlDbType.VarChar);
				sprmparam10.Value = taxinfo.CalculatingMode;
				sprmparam10 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam10.Value = taxinfo.Narration;
				sprmparam10 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam10.Value = taxinfo.IsActive;
				sprmparam10 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam10.Value = taxinfo.Extra1;
				sprmparam10 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam10.Value = taxinfo.Extra2;
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

		public DataTable TaxViewAll()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAll", base.sqlcon);
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

		public TaxInfo TaxView(decimal taxId)
		{
			TaxInfo taxinfo = new TaxInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxView", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam2.Value = taxId;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					taxinfo.TaxId = decimal.Parse(((DbDataReader)sdrreader)[0].ToString());
					taxinfo.TaxName = ((DbDataReader)sdrreader)[1].ToString();
					taxinfo.ApplicableOn = ((DbDataReader)sdrreader)[2].ToString();
					taxinfo.Rate = decimal.Parse(((DbDataReader)sdrreader)[3].ToString());
					taxinfo.CalculatingMode = ((DbDataReader)sdrreader)[4].ToString();
					taxinfo.Narration = ((DbDataReader)sdrreader)[5].ToString();
					taxinfo.IsActive = bool.Parse(((DbDataReader)sdrreader)[6].ToString());
					taxinfo.ExtraDate = DateTime.Parse(((DbDataReader)sdrreader)[7].ToString());
					taxinfo.Extra1 = ((DbDataReader)sdrreader)[8].ToString();
					taxinfo.Extra2 = ((DbDataReader)sdrreader)[9].ToString();
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
			return taxinfo;
		}

		public void TaxDelete(decimal TaxId)
		{
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam2.Value = TaxId;
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

		public int TaxGetMax()
		{
			int max = 0;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxMax", base.sqlcon);
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

		public bool TaxCheckExistence(decimal decTaxId, string strTaxName)
		{
			bool isEdit = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("TaxCheckExistence", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sqlcmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam3.Value = decTaxId;
				sprmparam3 = sqlcmd.Parameters.Add("@taxName", SqlDbType.VarChar);
				sprmparam3.Value = strTaxName;
				object obj = sqlcmd.ExecuteScalar();
				if (obj != null && int.Parse(obj.ToString()) == 0)
				{
					isEdit = true;
				}
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

		public decimal TaxAddWithIdentity(TaxInfo taxinfo)
		{
			decimal decTaxId = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxAddWithIdentity", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam9 = new SqlParameter();
				sprmparam9 = sccmd.Parameters.Add("@taxName", SqlDbType.VarChar);
				sprmparam9.Value = taxinfo.TaxName;
				sprmparam9 = sccmd.Parameters.Add("@applicableOn", SqlDbType.VarChar);
				sprmparam9.Value = taxinfo.ApplicableOn;
				sprmparam9 = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
				sprmparam9.Value = taxinfo.Rate;
				sprmparam9 = sccmd.Parameters.Add("@calculatingMode", SqlDbType.VarChar);
				sprmparam9.Value = taxinfo.CalculatingMode;
				sprmparam9 = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
				sprmparam9.Value = taxinfo.Narration;
				sprmparam9 = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
				sprmparam9.Value = taxinfo.IsActive;
				sprmparam9 = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
				sprmparam9.Value = taxinfo.Extra1;
				sprmparam9 = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
				sprmparam9.Value = taxinfo.Extra2;
				object objTaxId = sccmd.ExecuteScalar();
				decTaxId = ((objTaxId == null) ? 0m : decimal.Parse(objTaxId.ToString()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return decTaxId;
		}

		public DataTable TaxViewAllForTaxSelection()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAllForTaxSelection", base.sqlcon);
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

		public DataTable TaxSearch(string strTaxName, string strApplicableOn, string strCalculatingMode, string strActive)
		{
			DataTable dtblTaxSearch = new DataTable();
			dtblTaxSearch.Columns.Add("Sl No", typeof(decimal));
			dtblTaxSearch.Columns["Sl No"].AutoIncrement = true;
			dtblTaxSearch.Columns["Sl No"].AutoIncrementSeed = 1L;
			dtblTaxSearch.Columns["Sl No"].AutoIncrementStep = 1L;
			try
			{
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxSearch", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@taxName", SqlDbType.VarChar).Value = strTaxName;
				sqlda.SelectCommand.Parameters.Add("@applicableOn", SqlDbType.VarChar).Value = strApplicableOn;
				sqlda.SelectCommand.Parameters.Add("@calculatingMode", SqlDbType.VarChar).Value = strCalculatingMode;
				sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strActive;
				sqlda.Fill(dtblTaxSearch);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dtblTaxSearch;
		}

		public bool TaxReferenceCheck(decimal decTaxId)
		{
			bool isExist = false;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sqlcmd = new SqlCommand("TaxReferenceCheck", base.sqlcon);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sqlcmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam2.Value = decTaxId;
				isExist = bool.Parse(sqlcmd.ExecuteScalar().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return isExist;
		}

		public DataTable TaxViewAllForVoucherType()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtbl.Columns.Add("SlNo", typeof(decimal));
				dtbl.Columns["SlNo"].AutoIncrement = true;
				dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAllForVoucherType", base.sqlcon);
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

		public DataTable TaxIdForTaxSelectionUpdate(decimal decTaxId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxIdForTaxSelectionUpdate", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
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

		public decimal TaxReferenceDelete(decimal TaxId, decimal decLedgerId)
		{
			decimal decReturnValue = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxReferenceDelete", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam3 = new SqlParameter();
				sprmparam3 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam3.Value = TaxId;
				sprmparam3 = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
				sprmparam3.Value = decLedgerId;
				decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
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

		public decimal TaxRateFindByTaxId(decimal decTaxId)
		{
			decimal dcRate = 0m;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxRateFindByTaxId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam2.Value = decTaxId;
				dcRate = Convert.ToDecimal(sccmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				base.sqlcon.Close();
			}
			return dcRate;
		}

		public DataTable TaxViewAllByVoucherTypeId(decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public DataTable TaxViewAllByVoucherTypeIdForPurchaseInvoice(decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdForPurchaseInvoice", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public DataTable TaxViewAllByVoucherTypeIdWithCess(decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdWithCess", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public DataTable TaxIdCorrespondingToCessTaxId(decimal decTaxId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxIdCorrespondingToCessTaxId", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
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

		public DataTable TaxViewAllByVoucherTypeId1(decimal decVoucherTypeId, string strTaxApplicable)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdApplicableOnProduct", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
				sqlda.SelectCommand.Parameters.Add("@applicableOn", SqlDbType.VarChar).Value = strTaxApplicable;
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

		public TaxInfo TaxViewByProductId(string strProductCode)
		{
			TaxInfo taxInfo = new TaxInfo();
			SqlDataReader sdrreader = null;
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlCommand sccmd = new SqlCommand("TaxViewByProductId", base.sqlcon);
				sccmd.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam2 = new SqlParameter();
				sprmparam2 = sccmd.Parameters.Add("@productId", SqlDbType.VarChar);
				sprmparam2.Value = strProductCode;
				sdrreader = sccmd.ExecuteReader();
				while (sdrreader.Read())
				{
					taxInfo.TaxId = Convert.ToDecimal(((DbDataReader)sdrreader)["taxId"].ToString());
					taxInfo.TaxName = ((DbDataReader)sdrreader)["taxName"].ToString();
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
			return taxInfo;
		}

		public DataTable TaxViewAllByVoucherTypeIdApplicaleForProduct(decimal decVoucherTypeId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdApplicaleForProduct", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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

		public DataTable TaxViewByProductIdApplicableForProduct(decimal dcProductId)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewByProductIdApplicableForProduct", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = dcProductId;
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

		public DataTable TotalBillTaxCalculationBtapplicableOn()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TotalBillTaxViewAllByApplicableOn", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
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

		public DataTable TaxViewAllForProduct()
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAllForProduct", base.sqlcon);
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

		public DataTable TaxReportGridFillByProductwise(DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, string strTypeofVoucher, bool isInput)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtbl.Columns.Add("SlNo", typeof(int));
				dtbl.Columns["SlNo"].AutoIncrement = true;
				dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxReportGridFillByProductwise", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
				sprmparam7.Value = fromdate;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
				sprmparam7.Value = todate;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = dectaxId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam7.Value = decvoucherTypeId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
				sprmparam7.Value = strTypeofVoucher;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
				sprmparam7.Value = isInput;
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

		public DataSet TaxCrystalReportGridFillByProductwise(decimal deccompanyId, DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, bool isInput)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxCrystalReportGridFillByProductwise", base.sqlcon);
				sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sprmparam7 = new SqlParameter();
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sprmparam7.Value = deccompanyId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
				sprmparam7.Value = fromdate;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
				sprmparam7.Value = todate;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				sprmparam7.Value = dectaxId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sprmparam7.Value = decvoucherTypeId;
				sprmparam7 = sdaadapter.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
				sprmparam7.Value = isInput;
				sdaadapter.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}

		public DataTable TaxReportGridFillByBillWise(DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, string strTypeofVoucher, bool isInput)
		{
			DataTable dtbl = new DataTable();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				dtbl.Columns.Add("SlNo", typeof(int));
				dtbl.Columns["SlNo"].AutoIncrement = true;
				dtbl.Columns["SlNo"].AutoIncrementSeed = 1L;
				dtbl.Columns["SlNo"].AutoIncrementStep = 1L;
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxReportGridFillByBillWise", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam7 = new SqlParameter();
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
				sqlparam7.Value = fromdate;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
				sqlparam7.Value = todate;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				sqlparam7.Value = dectaxId;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparam7.Value = decvoucherTypeId;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
				sqlparam7.Value = strTypeofVoucher;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
				sqlparam7.Value = isInput;
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

		public DataSet TaxCrystalReportGridFillByBillWise(decimal deccompanyId, DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, bool isInput)
		{
			DataSet ds = new DataSet();
			try
			{
				if (base.sqlcon.State == ConnectionState.Closed)
				{
					base.sqlcon.Open();
				}
				SqlDataAdapter sqlda = new SqlDataAdapter("TaxCrystalReportGridFillByBillWise", base.sqlcon);
				sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlParameter sqlparam7 = new SqlParameter();
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
				sqlparam7.Value = deccompanyId;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
				sqlparam7.Value = fromdate;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
				sqlparam7.Value = todate;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
				sqlparam7.Value = dectaxId;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
				sqlparam7.Value = decvoucherTypeId;
				sqlparam7 = sqlda.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
				sqlparam7.Value = isInput;
				sqlda.Fill(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				base.sqlcon.Close();
			}
			return ds;
		}
	}
}
