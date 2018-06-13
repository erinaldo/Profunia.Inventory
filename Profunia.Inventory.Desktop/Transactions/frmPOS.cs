//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;using Profunia.Inventory.Desktop.ClassFiles.SP;
using System.Drawing;using Profunia.Inventory.Desktop.Company;using Profunia.Inventory.Desktop.FinancialStatements;using Profunia.Inventory.Desktop.Masters;using Profunia.Inventory.Desktop.Others;using Profunia.Inventory.Desktop.Payroll;using Profunia.Inventory.Desktop.Registers;using Profunia.Inventory.Desktop.Reminder;using Profunia.Inventory.Desktop.Reports;using Profunia.Inventory.Desktop.Search;using Profunia.Inventory.Desktop.Settings;using Profunia.Inventory.Desktop.Transactions;using Profunia.Inventory.Desktop.Transfer;using Profunia.Inventory.Desktop.Budget;
using Profunia.Inventory.Desktop.ClassFiles.SP;using Profunia.Inventory.Desktop.ClassFiles.Info;using Profunia.Inventory.Desktop.ClassFiles.General;using System.Linq;
using Profunia.Inventory.Desktop.Others;using Profunia.Inventory.Desktop.Reports;using Profunia.Inventory.Desktop.Registers;using Profunia.Inventory.Desktop.Masters;using Profunia.Inventory.Desktop.Search;using System.Windows.Forms;
using System.Data.SqlClient;
using Profunia.Inventory.Desktop.CrystalReports;
using PrintWorks;

namespace Profunia.Inventory.Desktop.Transactions
{
    public partial class frmPOS : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        ArrayList lstArrOfRemove = new ArrayList();
        SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
        SalesDetailsInfo InfoSalesDetails = new SalesDetailsInfo();
        StockPostingInfo infoStockPosting = new StockPostingInfo();
        PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
        SalesBillTaxInfo InfoSalesBillTax = new SalesBillTaxInfo();
        SalesMasterSP spSalesMaster = new SalesMasterSP();
        SalesDetailsSP spSalesDetails = new SalesDetailsSP();
        LedgerPostingSP spLedgerPosting = new LedgerPostingSP();
        PartyBalanceSP spPartyBalance = new PartyBalanceSP();
        StockPostingSP spStockPosting = new StockPostingSP();
        SalesBillTaxSP spSalesBillTax = new SalesBillTaxSP();

        decimal DecPOSVoucherTypeId = 0;        //to get the selected voucher type id from frmVoucherTypeSelection       
        decimal decPOSSuffixPrefixId = 0;
        decimal decProductId = 0;               //to fill product using barcode
        decimal decBatchId;
        decimal decCurrentConversionRate;
        decimal decCurrentRate;
        decimal decSalesMasterId = 0;
        decimal decSalesDetailsId = 0;
        string strCashOrParty;
        string strSalesAccount;
        string strCounter;
        string strSalesMan;
        string strPrefix = string.Empty;        //to get the prefix string from frmvouchertypeselection
        string strSuffix = string.Empty;        //to get the suffix string from frmvouchertypeselection
        string strVoucherNo = string.Empty;
        string strTableName = "SalesMaster";
        string strCurrencySymbol = "";
        int rowIdToEdit = 0;
        int maxSerialNo = 0;
        int inNarrationCount = 0;
        bool isAutomatic = false;               //to check whether the voucher number is automatically generated or not
        bool isdontExecuteTextchange = false;
        bool isFromSalesAccountCombo = false;   // for add new new account via button click
        bool isFromCashOrPartyCombo = false;    // for add new new account via button click
        bool isFromSalesManCombo = false;
        bool isFormIdtoEdit = false;
        bool isFromCounterCombo = false;
        bool isAfterFillControls = false;
        bool isFromDiscAmt = false;
        bool isFromBarcode = false;

        TransactionsGeneralFill TransactionGeneralFillObj = new TransactionsGeneralFill();
        frmSalesman frmSalesmanObj = new frmSalesman();
        frmSalesInvoiceRegister objfrmSalesInvoiceRegister;
        frmSalesReport frmSalesReportObj;
        frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();//to use in call from account ledger function
        frmDayBook frmDayBookObj = null;       //To use in call from frmDayBook
        frmAgeingReport frmAgeingObj = null;   //To use in call from frmDayBook
        frmVoucherSearch objVoucherSearch = null;
        frmVoucherWiseProductSearch objVoucherProduct = null;
        frmVatReturnReport frmvatReturnReportObj = null;
        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
        frmLedgerDetails frmledgerDetailsObj;
        #endregion
       
        /// <summary>
        /// Create an instance for frmPOS Class
        /// </summary>
        public frmPOS()
        {
            InitializeComponent();
        }
        public void CallFromVoucherTypeSelection(decimal decPOSVoucherTypeId, string strPOSVoucheTypeName)
        {
            decimal decDailySuffixPrefixId = 0m;
            try
            {
                VoucherTypeSP spVoucherType = new VoucherTypeSP();
                DecPOSVoucherTypeId = decPOSVoucherTypeId;
                isAutomatic = spVoucherType.CheckMethodOfVoucherNumbering(DecPOSVoucherTypeId);
                SuffixPrefixSP spSuffisprefix = new SuffixPrefixSP();
                SuffixPrefixInfo infoSuffixPrefix2 = new SuffixPrefixInfo();
                infoSuffixPrefix2 = spSuffisprefix.GetSuffixPrefixDetails(DecPOSVoucherTypeId, dtpDate.Value);
                decDailySuffixPrefixId = infoSuffixPrefix2.SuffixprefixId;
                strPrefix = infoSuffixPrefix2.Prefix;
                strSuffix = infoSuffixPrefix2.Suffix;
                Text = strPOSVoucheTypeName;
                base.Show();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS1:" + ex.Message;
            }
        }

        public void ClearFunctions()
        {
            try
            {
                CurrencySP SPCurrency = new CurrencySP();
                SettingsSP spSettings = new SettingsSP();
                strCurrencySymbol = SPCurrency.CurrencyView(PublicVariables._decCurrencyId).CurrencySymbol;
                if (spSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    cmbGodown.Visible = true;
                    lblGodown.Visible = true;
                }
                else
                {
                    cmbGodown.Visible = false;
                    lblGodown.Visible = false;
                }
                if (spSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    cmbRack.Visible = true;
                    lblRack.Visible = true;
                }
                else
                {
                    cmbRack.Visible = false;
                    lblRack.Visible = false;
                }
                if (spSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    cmbBatch.Visible = true;
                    lblBatch.Visible = true;
                }
                else
                {
                    cmbBatch.Visible = false;
                    lblBatch.Visible = false;
                }
                if (spSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    lblProductcode.Visible = true;
                    txtProductCode.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtProductCode"].Visible = true;
                }
                else
                {
                    lblProductcode.Visible = false;
                    txtProductCode.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtProductCode"].Visible = false;
                }
                if (spSettings.SettingsStatusCheck("Barcode") == "Yes")
                {
                    lblBarcode.Visible = true;
                    txtBarcode.Visible = true;
                }
                else
                {
                    lblBarcode.Visible = false;
                    txtBarcode.Visible = false;
                }
                if (spSettings.SettingsStatusCheck("ShowDiscountAmount") == "Yes")
                {
                    txtDiscountAmount.Visible = true;
                    lblDiscountAmt.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtDiscount"].Visible = true;
                }
                else
                {
                    txtDiscountAmount.Visible = false;
                    lblDiscountAmt.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtDiscount"].Visible = false;
                }
                if (spSettings.SettingsStatusCheck("ShowDiscountPercentage") == "Yes")
                {
                    txtDiscountPercentage.Visible = true;
                    lblDiscountPercentage.Visible = true;
                }
                else
                {
                    txtDiscountPercentage.Visible = false;
                    lblDiscountPercentage.Visible = false;
                }
                if (spSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    cmbUnit.Visible = true;
                    lblUnit.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtUnit"].Visible = true;
                }
                else
                {
                    cmbUnit.Visible = false;
                    lblUnit.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtUnit"].Visible = false;
                }
                if (spSettings.SettingsStatusCheck("Tax") == "Yes")
                {
                    cmbTax.Visible = true;
                    lblTax.Visible = true;
                    txtTaxAmount.Visible = true;
                    lblTaxAmount.Visible = true;
                    lblTaxTotalAmount.Visible = true;
                    lblLedgerTotal.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtTaxPercentage"].Visible = true;
                    dgvPointOfSales.Columns["dgvtxtTaxAmount"].Visible = true;
                    dgvPOSTax.Visible = true;
                }
                else
                {
                    cmbTax.Visible = false;
                    lblTax.Visible = false;
                    txtTaxAmount.Visible = false;
                    lblTaxAmount.Visible = false;
                    lblTaxTotalAmount.Visible = false;
                    lblLedgerTotal.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtTaxPercentage"].Visible = false;
                    dgvPointOfSales.Columns["dgvtxtTaxAmount"].Visible = false;
                    dgvPOSTax.Visible = false;
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.CustomFormat = "dd-MMMM-yyyy";
                CashorPartyComboFill();
                PricingLevelComboFill();
                salesManComboFill();
                SalesAccountComboFill();
                CounterComboFill();
                ItemComboFill();
                taxGridFill();
                cmbTaxComboFill();
                if (isAutomatic)
                {
                    VoucherNumberGeneration();
                }
                Clear();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS2:" + ex.Message;
            }
        }

        public void Clear()
        {
            try
            {
                SettingsSP spSettings = new SettingsSP();
                cmbPricingLevel.SelectedIndex = 0;
                cmbSalesAccount.SelectedIndex = 0;
                cmbCashOrParty.SelectedIndex = 0;
                cmbSalesMan.SelectedIndex = 0;
                cmbCounter.SelectedIndex = 0;
                txtBarcode.Clear();
                txtProductCode.Clear();
                cmbItem.SelectedIndex = -1;
                txtQuantity.Text = "0";
                txtRate.Text = "0";
                txtDiscountAmount.Text = "0";
                dgvPointOfSales.Rows.Clear();
                txtNarration.Clear();
                txtPaidAmount.Text = "0";
                txtBalance.Text = "0";
                txtTotalAmount.Text = "0";
                txtBillDiscount.Text = "0";
                txtGrandTotal.Text = "0";
                lblTaxTotalAmount.Text = "00.00";
                btnDelete.Enabled = false;
                btnSave.Text = "Save";
                btnClear.Text = "Clear";
                if (!txtVoucherNo.ReadOnly)
                {
                    txtVoucherNo.Clear();
                    txtVoucherNo.Focus();
                }
                else if (spSettings.SettingsStatusCheck("Barcode") == "Yes")
                {
                    txtBarcode.Select();
                }
                else
                {
                    txtProductCode.Select();
                }
                ClearGroupbox();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS3:" + ex.Message;
            }
        }

        public void ClearGroupbox()
        {
            try
            {
                isdontExecuteTextchange = true;
                txtBarcode.Clear();
                txtProductCode.Clear();
                cmbItem.SelectedIndex = -1;
                cmbGodown.SelectedIndex = -1;
                cmbUnit.SelectedIndex = -1;
                cmbRack.SelectedIndex = -1;
                cmbBatch.SelectedIndex = -1;
                txtQuantity.Text = "0";
                txtRate.Text = "0";
                txtGrossValue.Text = "0";
                txtTaxAmount.Text = "0";
                cmbTax.SelectedIndex = -1;
                txtAmount.Text = "0";
                txtNetAmount.Text = "0";
                txtDiscountPercentage.Text = "0";
                txtDiscountAmount.Text = "0";
                isdontExecuteTextchange = false;
                btnAdd.Text = "Add";
                rowIdToEdit = 0;
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS4:" + ex.Message;
            }
        }

        public void VoucherNumberGeneration()
        {
            try
            {
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecPOSVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                if (Convert.ToDecimal(strVoucherNo) != spSalesMaster.SalesMasterVoucherMax(DecPOSVoucherTypeId))
                {
                    strVoucherNo = spSalesMaster.SalesMasterVoucherMax(DecPOSVoucherTypeId).ToString();
                    strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecPOSVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                    if (spSalesMaster.SalesMasterVoucherMax(DecPOSVoucherTypeId) == 0m)
                    {
                        strVoucherNo = "0";
                        strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecPOSVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                    }
                }
                if (isAutomatic)
                {
                    SuffixPrefixSP spSuffisprefix = new SuffixPrefixSP();
                    SuffixPrefixInfo infoSuffixPrefix2 = new SuffixPrefixInfo();
                    infoSuffixPrefix2 = spSuffisprefix.GetSuffixPrefixDetails(DecPOSVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix2.Prefix;
                    strSuffix = infoSuffixPrefix2.Suffix;
                    decPOSSuffixPrefixId = infoSuffixPrefix2.SuffixprefixId;
                    txtVoucherNo.Text = strPrefix + strVoucherNo + strSuffix;
                    txtVoucherNo.ReadOnly = true;
                }
                else
                {
                    txtVoucherNo.ReadOnly = false;
                    txtVoucherNo.Text = string.Empty;
                    strVoucherNo = string.Empty;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS5:" + ex.Message;
            }
        }

        public void CashorPartyComboFill(ComboBox cmbCashOrParty)
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS6:" + ex.Message;
            }
        }

        public void CashorPartyComboFill()
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS7:" + ex.Message;
            }
        }

        public void PricingLevelComboFill()
        {
            try
            {
                TransactionGeneralFillObj.PricingLevelViewAll(cmbPricingLevel, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS8:" + ex.Message;
            }
        }

        public void salesManComboFill()
        {
            try
            {
                DataTable dtbl = new DataTable();
                TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
                dtbl = TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
                cmbSalesMan.DataSource = dtbl;
                cmbSalesMan.ValueMember = "employeeId";
                cmbSalesMan.DisplayMember = "employeeName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS9:" + ex.Message;
            }
        }

        public void SalesAccountComboFill()
        {
            DataTable dtbl = new DataTable();
            try
            {
                dtbl = spSalesMaster.SalesInvoiceSalesAccountModeComboFill();
                cmbSalesAccount.DataSource = dtbl;
                cmbSalesAccount.DisplayMember = "ledgerName";
                cmbSalesAccount.ValueMember = "ledgerId";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS10:" + ex.Message;
            }
        }

        public void CounterComboFill()
        {
            CounterSP SpCounter = new CounterSP();
            DataTable dtbl2 = new DataTable();
            try
            {
                dtbl2 = SpCounter.CounterOnlyViewAll();
                cmbCounter.DataSource = dtbl2;
                cmbCounter.DisplayMember = "counterName";
                cmbCounter.ValueMember = "counterId";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS11:" + ex.Message;
            }
        }

        public void UnitComboFill()
        {
            try
            {
                UnitSP spUnit = new UnitSP();
                DataTable dtblUnit2 = new DataTable();
                dtblUnit2 = spUnit.UnitViewAllByProductId(decProductId);
                cmbUnit.DataSource = dtblUnit2;
                cmbUnit.ValueMember = "unitId";
                cmbUnit.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS12:" + ex.Message;
            }
        }

        public void GodownComboFill()
        {
            try
            {
                DataTable dtblGodown = new DataTable();
                GodownSP spGodown = new GodownSP();
                dtblGodown = spGodown.GodownViewAll();
                cmbGodown.DataSource = dtblGodown;
                cmbGodown.ValueMember = "godownId";
                cmbGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS13:" + ex.Message;
            }
        }

        public void RackComboFill()
        {
            try
            {
                DataTable dtblRack = new DataTable();
                RackSP spRack = new RackSP();
                dtblRack = spRack.RackViewAll();
                cmbRack.DataSource = dtblRack;
                cmbRack.ValueMember = "rackId";
                cmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS14:" + ex.Message;
            }
        }

        public void RackComboFillByGodownId(decimal dcGodownId)
        {
            try
            {
                DataTable dtblRack = new DataTable();
                RackSP spRack = new RackSP();
                dtblRack = spRack.RackNamesCorrespondingToGodownId(dcGodownId);
                cmbRack.DataSource = dtblRack;
                cmbRack.ValueMember = "rackId";
                cmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS15:" + ex.Message;
            }
        }

        public void cmbTaxComboFill()
        {
            try
            {
                TaxSP spTax = new TaxSP();
                DataTable dtblTax2 = new DataTable();
                dtblTax2 = spTax.TaxViewAllByVoucherTypeIdApplicaleForProduct(DecPOSVoucherTypeId);
                cmbTax.DataSource = dtblTax2;
                DataRow dr = dtblTax2.NewRow();
                dr[1] = "NA";
                dtblTax2.Rows.InsertAt(dr, 0);
                cmbTax.ValueMember = "taxId";
                cmbTax.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS16:" + ex.Message;
            }
        }

        public void ItemComboFill()
        {
            try
            {
                ProductSP spProduct = new ProductSP();
                DataTable dtbl2 = new DataTable();
                dtbl2 = spProduct.ProductViewAll();
                cmbItem.DataSource = dtbl2;
                cmbItem.ValueMember = "productId";
                cmbItem.DisplayMember = "productName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS17:" + ex.Message;
            }
        }

        public void ComboTaxFill()
        {
            try
            {
                TaxSP spTax = new TaxSP();
                DataTable dtbl2 = new DataTable();
                dtbl2 = spTax.TaxViewByProductIdApplicableForProduct(decProductId);
                cmbTax.DataSource = dtbl2;
                cmbTax.ValueMember = "taxId";
                cmbTax.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS18:" + ex.Message;
            }
        }

        public void batchcombofill()
        {
            try
            {
                BatchSP spBatch = new BatchSP();
                DataTable dtblBatch2 = new DataTable();
                dtblBatch2 = spBatch.BatchNoViewByProductId(decProductId);
                cmbBatch.DataSource = dtblBatch2;
                cmbBatch.ValueMember = "batchId";
                cmbBatch.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS19:" + ex.Message;
            }
        }

        public void taxGridFill()
        {
            try
            {
                TaxSP spTax = new TaxSP();
                DataTable dtblTax2 = new DataTable();
                SalesBillTaxSP spSalesbillTax = new SalesBillTaxSP();
                dtblTax2 = spTax.TaxViewAllByVoucherTypeId(DecPOSVoucherTypeId);
                dgvPOSTax.DataSource = dtblTax2;
                dgvPOSTax.Columns["dgvtxtTaxAmt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS20:" + ex.Message;
            }
        }

        public void AccountLedgerCreation()
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountLedger", "Save"))
                {
                    if (cmbCashOrParty.SelectedValue != null)
                    {
                        strCashOrParty = cmbCashOrParty.SelectedValue.ToString();
                    }
                    else
                    {
                        strCashOrParty = string.Empty;
                    }
                    if (cmbSalesAccount.SelectedValue != null)
                    {
                        strSalesAccount = cmbSalesAccount.SelectedValue.ToString();
                    }
                    else
                    {
                        strSalesAccount = string.Empty;
                    }
                    frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                    frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                    if (open == null)
                    {
                        frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                        frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                        frmAccountLedgerObj.callFromPOS(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.callFromPOS(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    base.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You don’t have privilege", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS21:" + ex.Message;
            }
        }

        public void ReturnFromAccountLedgerForm(decimal decAccountLedgerId)
        {
            try
            {
                base.Enabled = true;
                CashorPartyComboFill(cmbCashOrParty);
                if (decAccountLedgerId != 0m)
                {
                    cmbCashOrParty.SelectedValue = decAccountLedgerId;
                }
                else if (strCashOrParty != string.Empty)
                {
                    cmbCashOrParty.SelectedValue = strCashOrParty;
                }
                else
                {
                    cmbCashOrParty.SelectedValue = -1;
                }
                cmbCashOrParty.Focus();
                base.WindowState = FormWindowState.Normal;
                base.Activate();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS22:" + ex.Message;
            }
        }

        public void SalesAccountComboFill(ComboBox cmbSalesAccount)
        {
            DataTable dtbl2 = new DataTable();
            try
            {
                dtbl2 = (DataTable)(cmbSalesAccount.DataSource = spSalesMaster.SalesInvoiceSalesAccountModeComboFill());
                cmbSalesAccount.DisplayMember = "ledgerName";
                cmbSalesAccount.ValueMember = "ledgerId";
                cmbSalesAccount.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS23:" + ex.Message;
            }
        }

        public void ReturnFromSalesAccount(decimal decAccountLedgerId)
        {
            try
            {
                base.Enabled = true;
                SalesAccountComboFill(cmbSalesAccount);
                if (decAccountLedgerId != 0m)
                {
                    cmbSalesAccount.SelectedValue = decAccountLedgerId;
                }
                else if (strSalesAccount != string.Empty)
                {
                    cmbSalesAccount.SelectedValue = strSalesAccount;
                }
                else
                {
                    cmbSalesAccount.SelectedValue = -1;
                }
                cmbSalesAccount.Focus();
                base.WindowState = FormWindowState.Normal;
                base.Activate();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS24:" + ex.Message;
            }
        }

        public void ReturnFromCounter(decimal decCounterId)
        {
            try
            {
                base.Enabled = true;
                CounterComboFill();
                if (decCounterId != 0m)
                {
                    cmbCounter.SelectedValue = decCounterId;
                }
                else if (strCounter != string.Empty)
                {
                    cmbCounter.SelectedValue = strCounter;
                }
                else
                {
                    cmbCounter.SelectedValue = -1;
                }
                cmbCounter.Focus();
                base.WindowState = FormWindowState.Normal;
                base.Activate();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS25:" + ex.Message;
            }
        }

        public void FillControlsByBarcode(string strBarcode)
        {
            try
            {
                BatchInfo infoBatch = new BatchInfo();
                BatchSP spBatch = new BatchSP();
                PriceListInfo InfoPriceList2 = new PriceListInfo();
                PriceListSP spPriceList = new PriceListSP();
                infoBatch = spBatch.BatchAndProductViewByBarcode(strBarcode);
                cmbBatch.Text = infoBatch.BatchNo;
                decProductId = infoBatch.ProductId;
                decBatchId = infoBatch.BatchId;
                InfoPriceList2 = spPriceList.PriceListViewByBatchIdORProduct(decBatchId);
                ProductInfo infoProduct2 = new ProductInfo();
                ProductSP spProduct = new ProductSP();
                infoProduct2 = spProduct.ProductView(decProductId);
                txtProductCode.Text = infoProduct2.ProductCode;
                string strProductCode = infoProduct2.ProductCode;
                isFromBarcode = true;
                cmbItem.Text = infoProduct2.ProductName;
                isFromBarcode = false;
                cmbGodown.SelectedValue = infoProduct2.GodownId;
                cmbRack.SelectedValue = infoProduct2.RackId;
                UnitComboFill();
                UnitInfo infoUnit2 = new UnitInfo();
                infoUnit2 = new UnitSP().unitVieWForStandardRate(decProductId);
                cmbUnit.SelectedValue = infoUnit2.UnitId;
                if (InfoPriceList2.PricinglevelId != 0m)
                {
                    cmbPricingLevel.SelectedValue = InfoPriceList2.PricinglevelId;
                }
                else
                {
                    cmbPricingLevel.SelectedIndex = 0;
                }
                ComboTaxFill();
                cmbTax.SelectedValue = infoProduct2.TaxId;
                if (txtProductCode.Text.Trim() != string.Empty && cmbItem.SelectedIndex != -1)
                {
                    decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                    decimal dcRate = new ProductSP().ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                    txtRate.Text = dcRate.ToString();
                    try
                    {
                        if (decimal.Parse(txtQuantity.Text) == 0m)
                        {
                            txtQuantity.Text = "1";
                        }
                    }
                    catch
                    {
                        txtQuantity.Text = "1";
                    }
                    txtQuantity.Focus();
                }
                else
                {
                    txtRate.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS26:" + ex.Message;
            }
        }

        public void FillControlByProductCode(bool isCode)
        {
            decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
            try
            {
                if (isCode)
                {
                    PriceListInfo InfoPriceList2 = new PriceListInfo();
                    ProductInfo infoProduct2 = new ProductInfo();
                    ProductBatchInfo infoProductBatch2 = new ProductBatchInfo();
                    ProductSP spProduct = new ProductSP();
                    PriceListSP spPriceList = new PriceListSP();
                    infoProduct2 = new ProductSP().ProductViewByCode(txtProductCode.Text.Trim());
                    infoProductBatch2 = spProduct.BarcodeViewByProductCode(txtProductCode.Text);
                    decProductId = infoProductBatch2.ProductId;
                    decBatchId = infoProductBatch2.BatchId;
                    InfoPriceList2 = spPriceList.PriceListViewByBatchIdORProduct(decBatchId);
                    batchcombofill();
                    txtBarcode.Text = infoProductBatch2.Barcode;
                    cmbItem.Text = infoProduct2.ProductName;
                    cmbGodown.SelectedValue = infoProduct2.GodownId;
                    cmbRack.SelectedValue = infoProduct2.RackId;
                    UnitComboFill();
                    UnitInfo infoUnit2 = new UnitInfo();
                    infoUnit2 = new UnitSP().unitVieWForStandardRate(decProductId);
                    cmbUnit.SelectedValue = infoUnit2.UnitId;
                    if (InfoPriceList2.PricinglevelId != 0m)
                    {
                        cmbPricingLevel.SelectedValue = InfoPriceList2.PricinglevelId;
                    }
                    else
                    {
                        cmbPricingLevel.SelectedIndex = 0;
                    }
                    ComboTaxFill();
                    cmbTax.SelectedValue = infoProduct2.TaxId;
                    decimal dcRate;
                    if (txtProductCode.Text.Trim() != string.Empty && cmbItem.SelectedIndex != -1)
                    {
                        dcRate = new ProductSP().ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                        txtRate.Text = dcRate.ToString();
                        try
                        {
                            if (decimal.Parse(txtQuantity.Text) == 0m)
                            {
                                txtQuantity.Text = "1";
                            }
                        }
                        catch
                        {
                            txtQuantity.Text = "1";
                        }
                        txtQuantity.Focus();
                    }
                    else
                    {
                        dcRate = new ProductSP().ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                        txtRate.Text = dcRate.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS27:" + ex.Message;
            }
        }

        public void FillControlsByProductName(decimal decProductId)
        {
            try
            {
                PriceListInfo InfoPriceList = new PriceListInfo();
                ProductInfo infoProduct2 = new ProductInfo();
                ProductSP spProduct = new ProductSP();
                PriceListSP spPriceList = new PriceListSP();
                ProductBatchInfo infoProductBatch2 = new ProductBatchInfo();
                infoProduct2 = new ProductSP().ProductView(decProductId);
                txtProductCode.Text = infoProduct2.ProductCode;
                infoProductBatch2 = spProduct.BarcodeViewByProductCode(txtProductCode.Text);
                decProductId = infoProductBatch2.ProductId;
                decBatchId = infoProductBatch2.BatchId;
                InfoPriceList = spPriceList.PriceListViewByBatchIdORProduct(decBatchId);
                batchcombofill();
                txtBarcode.Text = infoProductBatch2.Barcode;
                cmbItem.Text = infoProduct2.ProductName;
                cmbGodown.SelectedValue = infoProduct2.GodownId;
                cmbRack.SelectedValue = infoProduct2.RackId;
                UnitComboFill();
                UnitInfo infoUnit2 = new UnitInfo();
                infoUnit2 = new UnitSP().unitVieWForStandardRate(decProductId);
                cmbUnit.SelectedValue = infoUnit2.UnitId;
                if (InfoPriceList.PricinglevelId != 0m)
                {
                    cmbPricingLevel.SelectedValue = InfoPriceList.PricinglevelId;
                }
                else
                {
                    cmbPricingLevel.SelectedIndex = 0;
                }
                ComboTaxFill();
                cmbTax.SelectedValue = infoProduct2.TaxId;
                if (txtProductCode.Text.Trim() != string.Empty && cmbItem.SelectedIndex != -1)
                {
                    decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                    decimal dcRate = new ProductSP().ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                    txtRate.Text = dcRate.ToString();
                    try
                    {
                        if (decimal.Parse(txtQuantity.Text) == 0m)
                        {
                            txtQuantity.Text = "1";
                        }
                    }
                    catch
                    {
                        txtQuantity.Text = "1";
                    }
                    txtQuantity.Focus();
                }
                TaxAmountCalculation();
                isAfterFillControls = true;
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS28:" + ex.Message;
            }
        }

        public void GrossValueCalculation()
        {
            decimal dcRate = 0m;
            decimal dcQty2 = 0m;
            decimal dcGrossValue2 = 0m;
            try
            {
                if (txtQuantity.Text.Trim() == string.Empty)
                {
                    txtQuantity.Text = "0";
                }
                dcQty2 = Convert.ToDecimal(txtQuantity.Text.Trim());
                if (txtRate.Text.Trim() == string.Empty)
                {
                    txtRate.Text = "0";
                }
                dcRate = Convert.ToDecimal(txtRate.Text.Trim());
                if (dcRate > 0m)
                {
                    dcGrossValue2 = dcQty2 * dcRate;
                    txtGrossValue.Text = Math.Round(dcGrossValue2, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
                else
                {
                    txtGrossValue.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS29:" + ex.Message;
            }
        }

        public void TaxAmountCalculation()
        {
            decimal dcVatAmount = 0m;
            decimal dTaxAmt = 0m;
            decimal dcTotal = 0m;
            decimal dcNetAmount2 = 0m;
            dcNetAmount2 = Convert.ToDecimal(txtNetAmount.Text.Trim());
            TaxSP SpTax = new TaxSP();
            try
            {
                if (dcNetAmount2 != 0m && cmbTax.Visible && cmbTax.SelectedValue != null)
                {
                    TaxInfo InfoTaxMaster = SpTax.TaxView(Convert.ToDecimal(cmbTax.SelectedValue.ToString()));
                    dcVatAmount = (dTaxAmt = Math.Round(dcNetAmount2 * InfoTaxMaster.Rate / 100m, PublicVariables._inNoOfDecimalPlaces));
                    txtTaxAmount.Text = dTaxAmt.ToString();
                }
                else
                {
                    dTaxAmt = 0m;
                    txtTaxAmount.Text = "0";
                }
                dcTotal = dcNetAmount2 + dTaxAmt;
                txtAmount.Text = dcTotal.ToString();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS30:" + ex.Message;
            }
        }

        public void DiscountCalculation()
        {
            decimal dcDiscountAmount = 0m;
            decimal dcDiscountPercentage = 0m;
            decimal dcGrossValue = 0m;
            decimal dcNetValue = 0m;
            try
            {
                if (txtGrossValue.Text.Trim() != null && txtGrossValue.Text.Trim() != string.Empty)
                {
                    dcGrossValue = Convert.ToDecimal(txtGrossValue.Text.Trim());
                }
                if (txtDiscountPercentage.Text.Trim() != null && txtDiscountPercentage.Text.Trim() != string.Empty)
                {
                    dcDiscountPercentage = Convert.ToDecimal(txtDiscountPercentage.Text.Trim());
                }
                if (dcDiscountPercentage > 100m)
                {
                    dcDiscountPercentage = 100m;
                    txtDiscountPercentage.Text = dcDiscountPercentage.ToString();
                }
                decimal num;
                if (dcDiscountPercentage != 0m)
                {
                    dcDiscountAmount = dcGrossValue * dcDiscountPercentage / 100m;
                    TextBox textBox = txtDiscountAmount;
                    num = Math.Round(dcDiscountAmount, PublicVariables._inNoOfDecimalPlaces);
                    textBox.Text = num.ToString();
                }
                else
                {
                    txtDiscountAmount.Text = "0";
                }
                dcNetValue = dcGrossValue;
                if (dcGrossValue > 0m)
                {
                    if (txtDiscountPercentage.Text.Trim() != null && txtDiscountPercentage.Text.Trim() != string.Empty)
                    {
                        dcNetValue = dcGrossValue - dcDiscountAmount;
                        TextBox textBox2 = txtNetAmount;
                        num = Math.Round(dcNetValue, PublicVariables._inNoOfDecimalPlaces);
                        textBox2.Text = num.ToString();
                    }
                    else
                    {
                        txtNetAmount.Text = dcNetValue.ToString();
                    }
                }
                else
                {
                    txtNetAmount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS31:" + ex.Message;
            }
        }

        public void DiscountPerCalculation()
        {
            decimal dcGrossValue = 0m;
            decimal dcDiscountAmount = 0m;
            decimal dcDiscountPercentage2 = 0m;
            try
            {
                if (txtGrossValue.Text.Trim() != null && txtGrossValue.Text.Trim() != string.Empty)
                {
                    dcGrossValue = Convert.ToDecimal(txtGrossValue.Text.Trim());
                }
                if (txtDiscountAmount.Text.Trim() != null && txtDiscountAmount.Text.Trim() != string.Empty)
                {
                    dcDiscountAmount = Convert.ToDecimal(txtDiscountAmount.Text.Trim());
                }
                if (dcGrossValue > 0m && txtDiscountAmount.Text.Trim() != null && txtDiscountAmount.Text.Trim() != string.Empty)
                {
                    dcDiscountPercentage2 = dcDiscountAmount * 100m / dcGrossValue;
                    txtDiscountPercentage.Text = Math.Round(dcDiscountPercentage2, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS32:" + ex.Message;
            }
        }

        public void SerialNoforPOSTax()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow item in (IEnumerable)dgvPOSTax.Rows)
                {
                    item.Cells["dgvtxtSINO"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS33:" + ex.Message;
            }
        }

        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow item in (IEnumerable)dgvPointOfSales.Rows)
                {
                    item.Cells["dgvtxtSlNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS34:" + ex.Message;
            }
        }

        public void AddToGrid()
        {
            try
            {
                SettingsSP spSettings = new SettingsSP();
                if (txtProductCode.Text.Trim() == null && txtProductCode.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter product code");
                    txtProductCode.Focus();
                }
                else if (cmbItem.SelectedIndex == -1 && cmbItem.SelectedValue == null)
                {
                    Messages.InformationMessage("Select a product");
                    cmbItem.Focus();
                }
                else if (Convert.ToDecimal(txtQuantity.Text.Trim()) <= 0m || txtQuantity.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter quantity");
                    txtQuantity.Focus();
                }
                else if (cmbUnit.SelectedValue == null)
                {
                    Messages.InformationMessage("Select a unit");
                    cmbUnit.Focus();
                }
                else if ((spSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && decimal.Parse(txtRate.Text.Trim()) <= 0m) || txtRate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter rate");
                    txtRate.Focus();
                }
                else
                {
                    int inCurrentRowIndex = 0;
                    bool isExecutef = false;
                    if (rowIdToEdit == 0)
                    {
                        dgvPointOfSales.Rows.Add();
                        inCurrentRowIndex = dgvPointOfSales.Rows.Count - 1;
                        isExecutef = true;
                    }
                    else
                    {
                        int i = 0;
                        while (i < dgvPointOfSales.Rows.Count)
                        {
                            if (!(dgvPointOfSales.Rows[i].Cells["rowId"].Value.ToString() == rowIdToEdit.ToString()))
                            {
                                i++;
                                continue;
                            }
                            isExecutef = true;
                            inCurrentRowIndex = i;
                            break;
                        }
                    }
                    if (!isExecutef)
                    {
                        dgvPointOfSales.Rows.Add();
                        inCurrentRowIndex = dgvPointOfSales.Rows.Count - 1;
                    }
                    ProductInfo infoProduct2 = new ProductInfo();
                    BatchInfo infoBatch2 = new BatchInfo();
                    RackInfo infoRack2 = new RackInfo();
                    UnitConvertionInfo InfoUnitConvertion2 = new UnitConvertionInfo();
                    infoProduct2 = new ProductSP().ProductView(decProductId);
                    decimal dcProductBatch = new BatchSP().BatchIdViewByProductId(decProductId);
                    InfoUnitConvertion2 = new UnitConvertionSP().UnitViewAllByProductId(decProductId);
                    infoBatch2 = new BatchSP().BatchView(dcProductBatch);
                    decimal dcGodownId = infoProduct2.GodownId;
                    GodownInfo infoGodown2 = new GodownInfo();
                    infoGodown2 = new GodownSP().GodownView(dcGodownId);
                    decimal dcRackId = infoProduct2.RackId;
                    infoRack2 = new RackSP().RackView(dcRackId);
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtProductCode"].Value = txtProductCode.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtProductName"].Value = cmbItem.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtQuantity"].Value = txtQuantity.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtUnit"].Value = cmbUnit.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = txtRate.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtGrossValue"].Value = txtGrossValue.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtTaxPercentage"].Value = cmbTax.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtTaxAmount"].Value = txtTaxAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtNetAmount"].Value = txtNetAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtDiscount"].Value = txtDiscountAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtTotalAmount"].Value = txtAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxttaxid"].Value = Convert.ToDecimal(cmbTax.SelectedValue);
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtProductId"].Value = infoProduct2.ProductId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtBatchId"].Value = dcProductBatch;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtRackId"].Value = infoProduct2.RackId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtGodownId"].Value = infoProduct2.GodownId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtUnitId"].Value = Convert.ToDecimal(cmbUnit.SelectedValue);
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtunitconversionId"].Value = InfoUnitConvertion2.UnitconvertionId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtBarcode"].Value = txtBarcode.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtBatchno"].Value = infoBatch2.BatchNo;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtGodownName"].Value = infoGodown2.GodownName;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtRackName"].Value = infoRack2.RackName;
                    TotalAmountCalculation();
                    ClearGroupbox();
                    dgvPointOfSales.CurrentCell = dgvPointOfSales[0, dgvPointOfSales.Rows.Count - 1];
                    txtBarcode.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS35:" + ex.Message;
            }
        }

        public void TotalAmountCalculation()
        {
            TaxGridAmountCalculation();
            TaxTotal();
            decimal dTotal = 0m;
            decimal dcTotal = 0m;
            decimal dcTaxTotal2 = 0m;
            decimal dcTotalAmount = 0m;
            try
            {
                foreach (DataGridViewRow item in (IEnumerable)dgvPointOfSales.Rows)
                {
                    if (item.Cells["dgvtxtTaxAmount"].Value != null)
                    {
                        dcTotal += decimal.Parse(item.Cells["dgvtxtTaxAmount"].Value.ToString());
                    }
                }
                foreach (DataGridViewRow item2 in (IEnumerable)dgvPointOfSales.Rows)
                {
                    if (item2.Cells["dgvtxtTotalAmount"].Value != null && item2.Cells["dgvtxtTotalAmount"].Value.ToString() != string.Empty)
                    {
                        dcTotalAmount += Convert.ToDecimal(item2.Cells["dgvtxtTotalAmount"].Value.ToString());
                    }
                }
                if (dgvPOSTax.Rows.Count > 0)
                {
                    dcTaxTotal2 = Convert.ToDecimal(lblTaxTotalAmount.Text.Trim());
                    dTotal = dcTaxTotal2 - dcTotal;
                    txtTotalAmount.Text = (dcTotalAmount + dTotal).ToString();
                }
                else
                {
                    txtTotalAmount.Text = dcTotalAmount.ToString();
                }
                decimal dcTOT = Convert.ToDecimal(txtTotalAmount.Text);
                try
                {
                    decimal.Parse(txtBillDiscount.Text);
                }
                catch
                {
                    txtBillDiscount.Text = "0";
                }
                decimal dcGrandTotal = dcTOT - Convert.ToDecimal(txtBillDiscount.Text);
                txtGrandTotal.Text = dcGrandTotal.ToString();
                decimal dcBalance = 0m;
                dcBalance = ((!(txtPaidAmount.Text != string.Empty)) ? (dcBalance - dcGrandTotal) : (Convert.ToDecimal(txtPaidAmount.Text) - dcGrandTotal));
                txtBalance.Text = dcBalance.ToString();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS36:" + ex.Message;
            }
        }

        public void TaxTotal()
        {
            try
            {
                decimal dTaxTot = 0m;
                foreach (DataGridViewRow item in (IEnumerable)dgvPOSTax.Rows)
                {
                    if (item.Cells["dgvtxtTaxAmt"].Value != null && item.Cells["dgvtxtTaxAmt"].Value.ToString() != string.Empty && item.Cells["dgvtxtTaxAmt"].Value.ToString() != "0")
                    {
                        dTaxTot += Convert.ToDecimal(item.Cells["dgvtxtTaxAmt"].Value.ToString());
                    }
                }
                dTaxTot = Math.Round(dTaxTot, PublicVariables._inNoOfDecimalPlaces);
                lblTaxTotalAmount.Text = dTaxTot.ToString();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS37:" + ex.Message;
            }
        }

        public void TaxAmountForTaxType()
        {
            decimal dTotal = 0m;
            try
            {
                foreach (DataGridViewRow item in (IEnumerable)dgvPOSTax.Rows)
                {
                    foreach (DataGridViewRow item2 in (IEnumerable)dgvPointOfSales.Rows)
                    {
                        if (item2.Cells["dgvtxtTaxPercentage"].Value != null && item2.Cells["dgvtxtTaxAmount"].Value != null && item2.Cells["dgvtxtTaxPercentage"].Value.ToString() != string.Empty && item2.Cells["dgvtxtTaxAmount"].Value.ToString() != string.Empty && item2.Cells["dgvtxttaxid"].Value.ToString() == item.Cells["dgvtxttax"].Value.ToString())
                        {
                            dTotal += Convert.ToDecimal(item2.Cells["dgvtxtTaxAmount"].Value.ToString());
                            dTotal = Math.Round(dTotal, PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                    item.Cells["dgvtxtTaxAmt"].Value = dTotal.ToString();
                    dTotal = 0m;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS38:" + ex.Message;
            }
        }

        public void TaxGridAmountCalculation()
        {
            decimal dTotal = 0m;
            decimal decTaxId = 0m;
            decimal decTaxRate = 0m;
            decimal dcTCessTotal = 0m;
            try
            {
                TaxAmountForTaxType();
                foreach (DataGridViewRow item in (IEnumerable)dgvPointOfSales.Rows)
                {
                    if (item.Cells["dgvtxtTotalAmount"].Value != null && item.Cells["dgvtxtTotalAmount"].Value.ToString() != string.Empty)
                    {
                        dTotal += Convert.ToDecimal(item.Cells["dgvtxtTotalAmount"].Value.ToString());
                    }
                }
                foreach (DataGridViewRow item2 in (IEnumerable)dgvPOSTax.Rows)
                {
                    if (item2.Cells["dgvtxttax"].Value != null && item2.Cells["dgvtxtTaxApplicableOn"].Value != null && item2.Cells["dgvtxttaxCalculateMode"].Value != null && item2.Cells["dgvtxtTaxApplicableOn"].Value.ToString() == "Bill" && item2.Cells["dgvtxttaxCalculateMode"].Value.ToString() == "Bill Amount")
                    {
                        decTaxRate = Convert.ToDecimal(item2.Cells["dgvtxttaxrate"].Value.ToString());
                        decimal decTaxTotal = dTotal * decTaxRate / 100m;
                        item2.Cells["dgvtxtTaxAmt"].Value = Math.Round(decTaxTotal, PublicVariables._inNoOfDecimalPlaces);
                    }
                }
                foreach (DataGridViewRow item3 in (IEnumerable)dgvPOSTax.Rows)
                {
                    if (item3.Cells["dgvtxttax"].Value != null && item3.Cells["dgvtxtTaxApplicableOn"].Value != null && item3.Cells["dgvtxttaxCalculateMode"].Value != null && item3.Cells["dgvtxtTaxApplicableOn"].Value.ToString() == "Bill" && item3.Cells["dgvtxttaxCalculateMode"].Value.ToString() == "Tax Amount")
                    {
                        decTaxId = Convert.ToDecimal(item3.Cells["dgvtxttax"].Value.ToString());
                        DataTable dtbl2 = new DataTable();
                        TaxDetailsSP spTaxDetails = new TaxDetailsSP();
                        dtbl2 = spTaxDetails.TaxDetailsViewallByTaxId(decTaxId);
                        foreach (DataGridViewRow item4 in (IEnumerable)dgvPOSTax.Rows)
                        {
                            foreach (DataRow row in dtbl2.Rows)
                            {
                                if (item4.Cells["dgvtxtTaxAmt"].Value != null)
                                {
                                    decimal deca2 = 0m;
                                    deca2 = Convert.ToDecimal(item4.Cells["dgvtxtTaxAmt"].Value.ToString());
                                    if (item4.Cells["dgvtxttax"].Value != null && deca2 != 0m && item4.Cells["dgvtxttax"].Value.ToString() == row.ItemArray[0].ToString())
                                    {
                                        decTaxRate = Convert.ToDecimal(item3.Cells["dgvtxttaxrate"].Value.ToString());
                                        dTotal = Convert.ToDecimal(item4.Cells["dgvtxtTaxAmt"].Value.ToString());
                                        dcTCessTotal = dTotal * decTaxRate / 100m;
                                        item3.Cells["temp"].Value = Math.Round(dcTCessTotal, PublicVariables._inNoOfDecimalPlaces);
                                        if (item3.Cells["dgvtxttax"].Value.ToString() == decTaxId.ToString())
                                        {
                                            item3.Cells["dgvtxtTaxAmt"].Value = item3.Cells["temp"].Value;
                                        }
                                    }
                                }
                                else
                                {
                                    item3.Cells["dgvtxtTaxAmt"].Value = 0;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS39:" + ex.Message;
            }
        }

        public void RemoveRow()
        {
            try
            {
                if (true)
                {
                    dgvPointOfSales.Rows.RemoveAt(dgvPointOfSales.CurrentRow.Index);
                    SerialNo();
                    TotalAmountCalculation();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS40:" + ex.Message;
            }
        }

        public void ReturnFromSalesman(decimal decSalesmanId)
        {
            try
            {
                if (decSalesmanId != 0m)
                {
                    salesManComboFill();
                    cmbSalesMan.SelectedValue = decSalesmanId;
                }
                else if (strSalesMan != string.Empty)
                {
                    cmbSalesMan.SelectedValue = strSalesMan;
                }
                else
                {
                    cmbSalesMan.SelectedValue = -1;
                }
                base.Enabled = true;
                cmbSalesMan.Focus();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS41:" + ex.Message;
            }
        }

        public void ReturnFromProductCreation(decimal decProductId)
        {
            try
            {
                ItemComboFill();
                if (decProductId != 0m)
                {
                    cmbItem.SelectedValue = decProductId;
                }
                else
                {
                    cmbItem.SelectedValue = -1;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS42:" + ex.Message;
            }
        }

        public void QuantityStatusCheck()
        {
            try
            {
                decimal decProductId = 0m;
                decimal decBatchId2 = 0m;
                decimal decCalcQty = 0m;
                StockPostingSP spStockPosting = new StockPostingSP();
                SettingsSP spSettings = new SettingsSP();
                string strStatus = spSettings.SettingsStatusCheck("NegativeStockStatus");
                bool isNegativeLedger = false;
                if (cmbItem.SelectedIndex != -1)
                {
                    decProductId = Convert.ToDecimal(cmbItem.SelectedValue.ToString());
                    batchcombofill();
                    decBatchId2 = Convert.ToDecimal(cmbBatch.SelectedValue.ToString());
                    decimal decCurrentStock = spStockPosting.StockCheckForProductSale(decProductId, decBatchId2);
                    if (txtQuantity.Text != null || txtQuantity.Text != string.Empty)
                    {
                        decCalcQty = decCurrentStock - Convert.ToDecimal(txtQuantity.Text.Trim().ToString());
                    }
                    if (decCalcQty < 0m)
                    {
                        isNegativeLedger = true;
                    }
                }
                if (isNegativeLedger)
                {
                    if (strStatus == "Warn")
                    {
                        if (MessageBox.Show("Negative Stock balance exists,Do you want to Continue", "Openmiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            AddToGrid();
                        }
                        else
                        {
                            cmbItem.Focus();
                        }
                    }
                    else if (strStatus == "Block")
                    {
                        MessageBox.Show("Cannot continue ,due to negative stock balance", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        cmbItem.Focus();
                    }
                    else
                    {
                        AddToGrid();
                    }
                }
                else
                {
                    AddToGrid();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS43:" + ex.Message;
            }
        }

        public void SaveOrEdit()
        {
            bool isAllOk = true;
            try
            {
                dgvPointOfSales.ClearSelection();
                int inRow = dgvPointOfSales.RowCount;
                if (txtVoucherNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number");
                    txtVoucherNo.Focus();
                }
                else if (spSalesMaster.SalesInvoiceInvoiceNumberCheckExistence(txtVoucherNo.Text.Trim(), 0m, DecPOSVoucherTypeId) && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Invoice number already exist");
                    txtVoucherNo.Focus();
                }
                else if (txtDate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select a date in between financial year");
                    txtDate.Focus();
                }
                else if (cmbCashOrParty.SelectedValue == null)
                {
                    Messages.InformationMessage("Select Cash/Party");
                    cmbCashOrParty.Focus();
                }
                else if (cmbSalesAccount.SelectedValue == null)
                {
                    Messages.InformationMessage("Select sales a/c");
                    cmbSalesAccount.Focus();
                }
                else if (inRow == 0)
                {
                    Messages.InformationMessage("Can't save sales invoice without atleast one product with complete details");
                    txtBarcode.Focus();
                }
                else if (btnSave.Text == "Save")
                {
                    if (dgvPointOfSales.Rows.Count > 0)
                    {
                        isAllOk = true;
                    }
                    if (isAllOk)
                    {
                        TotalAmountCalculation();
                        decimal dcGrandTot2 = Convert.ToDecimal(txtTotalAmount.Text.ToString());
                        if (Convert.ToDecimal(txtBillDiscount.Text.ToString()) >= dcGrandTot2)
                        {
                            Messages.InformationMessage("Bill discount cannot be greater than net amount");
                            txtBillDiscount.Focus();
                        }
                        else if (PublicVariables.isMessageAdd)
                        {
                            if (Messages.SaveMessage())
                            {
                                SaveFunction();
                            }
                            else
                            {
                                txtBillDiscount.Focus();
                            }
                        }
                        else
                        {
                            SaveFunction();
                        }
                    }
                }
                else if (btnSave.Text == "Update")
                {
                    if (dgvPointOfSales.Rows.Count > 0)
                    {
                        isAllOk = true;
                    }
                    if (isAllOk)
                    {
                        TotalAmountCalculation();
                        decimal dcGrandTot2 = Convert.ToDecimal(txtGrandTotal.Text.ToString());
                        if (Convert.ToDecimal(txtBillDiscount.Text.ToString()) > dcGrandTot2)
                        {
                            Messages.InformationMessage("Bill discount cannot be greater than net amount");
                        }
                        else if (PublicVariables.isMessageEdit)
                        {
                            if (Messages.UpdateMessage())
                            {
                                EditFunction();
                            }
                        }
                        else
                        {
                            EditFunction();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS44:" + ex.Message;
            }
        }

        public void SaveFunction()
        {
            LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
            LedgerPostingSP spLedgerPosting = new LedgerPostingSP();
            UnitConvertionSP SPUnitConversion = new UnitConvertionSP();
            ExchangeRateSP spExchangeRate = new ExchangeRateSP();
            try
            {
                InfoSalesMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                InfoSalesMaster.AdditionalCost = 0m;
                InfoSalesMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                InfoSalesMaster.BillDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                if (cmbCounter.SelectedIndex > -1)
                {
                    InfoSalesMaster.CounterId = Convert.ToDecimal(cmbCounter.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.CounterId = 0m;
                }
                InfoSalesMaster.CreditPeriod = 0;
                InfoSalesMaster.CustomerName = string.Empty;
                InfoSalesMaster.Date = Convert.ToDateTime(txtDate.Text);
                InfoSalesMaster.DeliveryNoteMasterId = 0m;
                if (cmbSalesMan.SelectedValue.ToString() != null)
                {
                    InfoSalesMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.EmployeeId = 0m;
                }
                decimal decExachangeRateId = spExchangeRate.ExchangerateViewByCurrencyId(PublicVariables._decCurrencyId);
                InfoSalesMaster.ExchangeRateId = decExachangeRateId;
                InfoSalesMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoSalesMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                InfoSalesMaster.LrNo = string.Empty;
                InfoSalesMaster.Narration = txtNarration.Text.Trim();
                InfoSalesMaster.OrderMasterId = 0m;
                InfoSalesMaster.POS = true;
                if (cmbPricingLevel.SelectedValue.ToString() != null)
                {
                    InfoSalesMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.PricinglevelId = 0m;
                }
                InfoSalesMaster.QuotationMasterId = 0m;
                InfoSalesMaster.SalesAccount = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                InfoSalesMaster.TaxAmount = Convert.ToDecimal(lblTaxTotalAmount.Text.ToString());
                InfoSalesMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                InfoSalesMaster.TransportationCompany = string.Empty;
                InfoSalesMaster.UserId = PublicVariables._decCurrentUserId;
                InfoSalesMaster.VoucherTypeId = DecPOSVoucherTypeId;
                if (isAutomatic)
                {
                    InfoSalesMaster.SuffixPrefixId = decPOSSuffixPrefixId;
                    InfoSalesMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    InfoSalesMaster.SuffixPrefixId = 0m;
                    InfoSalesMaster.VoucherNo = txtVoucherNo.Text;
                }
                InfoSalesMaster.ExtraDate = DateTime.Now;
                InfoSalesMaster.Extra1 = string.Empty;
                InfoSalesMaster.Extra2 = string.Empty;
                decSalesMasterId = spSalesMaster.SalesMasterAdd(InfoSalesMaster);
                int inRowCount = dgvPointOfSales.RowCount;
                InfoSalesDetails.SalesMasterId = decSalesMasterId;
                InfoSalesDetails.ExtraDate = DateTime.Now;
                InfoSalesDetails.Extra1 = string.Empty;
                InfoSalesDetails.Extra2 = string.Empty;
                for (int inI2 = 0; inI2 < inRowCount; inI2++)
                {
                    if (dgvPointOfSales.Rows[inI2].Cells["dgvtxtProductName"].Value != null && dgvPointOfSales.Rows[inI2].Cells["dgvtxtProductName"].Value.ToString() != string.Empty && dgvPointOfSales.Rows[inI2].Cells["dgvtxtQuantity"].Value != null && dgvPointOfSales.Rows[inI2].Cells["dgvtxtQuantity"].Value.ToString() != string.Empty)
                    {
                        InfoSalesDetails.SlNo = Convert.ToInt32(dgvPointOfSales.Rows[inI2].Cells["dgvtxtSlNo"].Value.ToString());
                        InfoSalesDetails.ProductId = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtProductId"].Value.ToString());
                        InfoSalesDetails.Qty = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtQuantity"].Value.ToString());
                        InfoSalesDetails.Rate = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtRate"].Value.ToString());
                        InfoSalesDetails.UnitId = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtUnitId"].Value.ToString());
                        InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtunitconversionId"].Value.ToString());
                        InfoSalesDetails.Discount = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtDiscount"].Value.ToString());
                        InfoSalesDetails.TaxId = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxttaxid"].Value.ToString());
                        InfoSalesDetails.BatchId = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtBatchId"].Value.ToString());
                        InfoSalesDetails.GodownId = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtGodownId"].Value.ToString());
                        InfoSalesDetails.RackId = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtRackId"].Value.ToString());
                        InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtTaxAmount"].Value.ToString());
                        InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtGrossValue"].Value.ToString());
                        InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtNetAmount"].Value.ToString());
                        InfoSalesDetails.Amount = Convert.ToDecimal(dgvPointOfSales.Rows[inI2].Cells["dgvtxtTotalAmount"].Value.ToString());
                        spSalesDetails.SalesDetailsAdd(InfoSalesDetails);
                        infoStockPosting.Date = InfoSalesMaster.Date;
                        infoStockPosting.VoucherTypeId = DecPOSVoucherTypeId;
                        infoStockPosting.VoucherNo = strVoucherNo;
                        infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                        infoStockPosting.AgainstVoucherTypeId = 0m;
                        infoStockPosting.AgainstVoucherNo = "NA";
                        infoStockPosting.AgainstInvoiceNo = "NA";
                        infoStockPosting.ProductId = InfoSalesDetails.ProductId;
                        infoStockPosting.BatchId = InfoSalesDetails.BatchId;
                        infoStockPosting.UnitId = InfoSalesDetails.UnitId;
                        infoStockPosting.GodownId = InfoSalesDetails.GodownId;
                        infoStockPosting.RackId = InfoSalesDetails.RackId;
                        infoStockPosting.InwardQty = 0m;
                        infoStockPosting.OutwardQty = InfoSalesDetails.Qty / SPUnitConversion.UnitConversionRateByUnitConversionId(InfoSalesDetails.UnitConversionId);
                        infoStockPosting.Rate = InfoSalesDetails.Rate;
                        infoStockPosting.FinancialYearId = InfoSalesMaster.FinancialYearId;
                        infoStockPosting.Extra1 = string.Empty;
                        infoStockPosting.Extra2 = string.Empty;
                        spStockPosting.StockPostingAdd(infoStockPosting);
                    }
                }
                int inTaxRowCount = dgvPOSTax.RowCount;
                InfoSalesBillTax.SalesMasterId = decSalesMasterId;
                InfoSalesBillTax.ExtraDate = DateTime.Now;
                InfoSalesBillTax.Extra1 = string.Empty;
                InfoSalesBillTax.Extra2 = string.Empty;
                for (int inI2 = 0; inI2 < inTaxRowCount; inI2++)
                {
                    if (dgvPOSTax.Rows[inI2].Cells["dgvtxttax"].Value != null && dgvPOSTax.Rows[inI2].Cells["dgvtxttax"].Value.ToString() != string.Empty && dgvPOSTax.Rows[inI2].Cells["dgvtxtTaxAmt"].Value != null && dgvPOSTax.Rows[inI2].Cells["dgvtxtTaxAmt"].Value.ToString() != string.Empty)
                    {
                        InfoSalesBillTax.TaxId = Convert.ToInt32(dgvPOSTax.Rows[inI2].Cells["dgvtxttax"].Value.ToString());
                        InfoSalesBillTax.TaxAmount = Convert.ToDecimal(dgvPOSTax.Rows[inI2].Cells["dgvtxtTaxAmt"].Value.ToString());
                        spSalesBillTax.SalesBillTaxAdd(InfoSalesBillTax);
                    }
                }
                ledgerPostingAdd();
                if (spSalesMaster.SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString())))
                {
                    partyBalanceAdd();
                }
                Messages.SavedMessage();
                if (cbxPrintAfterSave.Checked)
                {
                    SettingsSP spSettings = new SettingsSP();
                    if (spSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(decSalesMasterId);
                    }
                    else
                    {
                        Print(decSalesMasterId);
                    }
                }
                ClearFunctions();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS45:" + ex.Message;
            }
        }

        public void ledgerPostingAdd()
        {
            try
            {
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue);
                infoLedgerPosting.Debit = Convert.ToDecimal(txtGrandTotal.Text);
                infoLedgerPosting.Credit = 0m;
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0m;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                spLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                infoLedgerPosting.Debit = 0m;
                infoLedgerPosting.Credit = Convert.ToDecimal(txtTotalAmount.Text);
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0m;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                spLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                decimal decBillDis = 0m;
                decBillDis = Convert.ToDecimal(txtBillDiscount.Text.Trim().ToString());
                if (decBillDis > 0m)
                {
                    infoLedgerPosting.Debit = decBillDis;
                    infoLedgerPosting.Credit = 0m;
                    infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                    infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                    infoLedgerPosting.LedgerId = 8m;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.DetailsId = 0m;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    spLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }
                if (dgvPointOfSales.Columns["dgvtxtTaxPercentage"].Visible)
                {
                    foreach (DataGridViewRow item in (IEnumerable)dgvPOSTax.Rows)
                    {
                        if (item.Cells["dgvtxttax"].Value != null && item.Cells["dgvtxttax"].Value.ToString() != string.Empty)
                        {
                            decimal decTaxAmount2 = 0m;
                            decTaxAmount2 = Convert.ToDecimal(item.Cells["dgvtxtTaxAmt"].Value.ToString());
                            if (decTaxAmount2 > 0m)
                            {
                                infoLedgerPosting.Debit = 0m;
                                infoLedgerPosting.Credit = Convert.ToDecimal(item.Cells["dgvtxtTaxAmt"].Value.ToString());
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(item.Cells["dgvtxtTaxLedgerId"].Value.ToString());
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.DetailsId = 0m;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                spLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS46:" + ex.Message;
            }
        }

        public void partyBalanceAdd()
        {
            try
            {
                infoPartyBalance.Date = InfoSalesMaster.Date;
                infoPartyBalance.LedgerId = InfoSalesMaster.LedgerId;
                infoPartyBalance.VoucherNo = strVoucherNo;
                infoPartyBalance.InvoiceNo = txtVoucherNo.Text.Trim();
                infoPartyBalance.VoucherTypeId = DecPOSVoucherTypeId;
                infoPartyBalance.AgainstVoucherTypeId = 0m;
                infoPartyBalance.AgainstVoucherNo = "NA";
                infoPartyBalance.AgainstInvoiceNo = "NA";
                infoPartyBalance.ReferenceType = "New";
                infoPartyBalance.Debit = InfoSalesMaster.GrandTotal;
                infoPartyBalance.Credit = 0m;
                infoPartyBalance.CreditPeriod = 0;
                infoPartyBalance.ExchangeRateId = InfoSalesMaster.ExchangeRateId;
                infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPartyBalance.ExtraDate = DateTime.Now;
                infoPartyBalance.Extra1 = string.Empty;
                infoPartyBalance.Extra2 = string.Empty;
                spPartyBalance.PartyBalanceAdd(infoPartyBalance);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS47:" + ex.Message;
            }
        }

        public void Print(decimal decSalesMasterId)
        {
            try
            {
                DataSet dsSalesInvoiceTest = spSalesMaster.salesInvoicePrintAfterSave(decSalesMasterId, 1m, InfoSalesMaster.OrderMasterId, InfoSalesMaster.DeliveryNoteMasterId, InfoSalesMaster.QuotationMasterId);
                frmReport frmRepor = new frmReport();
                frmRepor.MdiParent = formMDI.MDIObj;
                frmRepor.SalesInvoicePrinting(dsSalesInvoiceTest);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS48:" + ex.Message;
            }
        }

        public void PrintForDotMatrix(decimal decSalesMasterId)
        {
            try
            {
                DataTable dtblOtherDetails = new DataTable();
                CompanySP spComapany = new CompanySP();
                dtblOtherDetails = spComapany.CompanyViewForDotMatrix();
                DataTable dtblGridDetails = new DataTable();
                dtblGridDetails.Columns.Add("SlNo");
                dtblGridDetails.Columns.Add("BarCode");
                dtblGridDetails.Columns.Add("ProductCode");
                dtblGridDetails.Columns.Add("ProductName");
                dtblGridDetails.Columns.Add("Qty");
                dtblGridDetails.Columns.Add("Unit");
                dtblGridDetails.Columns.Add("Godown");
                dtblGridDetails.Columns.Add("Brand");
                dtblGridDetails.Columns.Add("Tax");
                dtblGridDetails.Columns.Add("TaxAmount");
                dtblGridDetails.Columns.Add("NetAmount");
                dtblGridDetails.Columns.Add("DiscountAmount");
                dtblGridDetails.Columns.Add("DiscountPercentage");
                dtblGridDetails.Columns.Add("SalesRate");
                dtblGridDetails.Columns.Add("PurchaseRate");
                dtblGridDetails.Columns.Add("MRP");
                dtblGridDetails.Columns.Add("Rack");
                dtblGridDetails.Columns.Add("Batch");
                dtblGridDetails.Columns.Add("Rate");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow item in (IEnumerable)dgvPointOfSales.Rows)
                {
                    if (!item.IsNewRow)
                    {
                        DataRow dr = dtblGridDetails.NewRow();
                        dr["SlNo"] = ++inRowCount;
                        if (item.Cells["dgvtxtBarcode"].Value != null)
                        {
                            dr["BarCode"] = item.Cells["dgvtxtBarcode"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtProductCode"].Value != null)
                        {
                            dr["ProductCode"] = item.Cells["dgvtxtProductCode"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtProductName"].Value != null)
                        {
                            dr["ProductName"] = item.Cells["dgvtxtProductName"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtQuantity"].Value != null)
                        {
                            dr["Qty"] = item.Cells["dgvtxtQuantity"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtUnit"].Value != null)
                        {
                            dr["Unit"] = item.Cells["dgvtxtUnit"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtRate"].Value != null)
                        {
                            dr["Rate"] = item.Cells["dgvtxtRate"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtTotalAmount"].Value != null)
                        {
                            dr["Amount"] = item.Cells["dgvtxtTotalAmount"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtTaxAmount"].Value != null)
                        {
                            dr["TaxAmount"] = item.Cells["dgvtxtTaxAmount"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtNetAmount"].Value != null)
                        {
                            dr["NetAmount"] = item.Cells["dgvtxtNetAmount"].Value.ToString();
                        }
                        if (item.Cells["dgvtxtDiscount"].Value != null)
                        {
                            dr["DiscountAmount"] = item.Cells["dgvtxtDiscount"].Value.ToString();
                        }
                        dtblGridDetails.Rows.Add(dr);
                    }
                }
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("SalesMode");
                dtblOtherDetails.Columns.Add("SalesAccount");
                dtblOtherDetails.Columns.Add("SalesMan");
                dtblOtherDetails.Columns.Add("CreditPeriod");
                dtblOtherDetails.Columns.Add("VoucherType");
                dtblOtherDetails.Columns.Add("PricingLevel");
                dtblOtherDetails.Columns.Add("Customer");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("BillDiscount");
                dtblOtherDetails.Columns.Add("GrandTotal");
                dtblOtherDetails.Columns.Add("AmountInWords");
                dtblOtherDetails.Columns.Add("Declaration");
                dtblOtherDetails.Columns.Add("Heading1");
                dtblOtherDetails.Columns.Add("Heading2");
                dtblOtherDetails.Columns.Add("Heading3");
                dtblOtherDetails.Columns.Add("Heading4");
                dtblOtherDetails.Columns.Add("CustomerAddress");
                dtblOtherDetails.Columns.Add("CustomerTIN");
                dtblOtherDetails.Columns.Add("CustomerCST");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["voucherNo"] = txtVoucherNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["SalesAccount"] = cmbSalesAccount.Text;
                dRowOther["SalesMan"] = cmbSalesMan.Text;
                dRowOther["PricingLevel"] = cmbPricingLevel.Text;
                dRowOther["BillDiscount"] = txtBillDiscount.Text;
                dRowOther["GrandTotal"] = txtGrandTotal.Text;
                dRowOther["TotalAmount"] = txtTotalAmount.Text;
                dRowOther["address"] = dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ").Replace("\r", "");
                AccountLedgerSP spAccountLedger = new AccountLedgerSP();
                AccountLedgerInfo infoAccountLedger2 = new AccountLedgerInfo();
                infoAccountLedger2 = spAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = infoAccountLedger2.Address.ToString().Replace("\n", ", ").Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger2.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger2.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtGrandTotal.Text), PublicVariables._decCurrencyId);
                VoucherTypeSP spVoucherType = new VoucherTypeSP();
                DataTable dtblDeclaration = spVoucherType.DeclarationAndHeadingGetByVoucherTypeId(DecPOSVoucherTypeId);
                dRowOther["Declaration"] = dtblDeclaration.Rows[0]["Declaration"].ToString();
                dRowOther["Heading1"] = dtblDeclaration.Rows[0]["Heading1"].ToString();
                dRowOther["Heading2"] = dtblDeclaration.Rows[0]["Heading2"].ToString();
                dRowOther["Heading3"] = dtblDeclaration.Rows[0]["Heading3"].ToString();
                dRowOther["Heading4"] = dtblDeclaration.Rows[0]["Heading4"].ToString();
                int inFormId = spVoucherType.FormIdGetForPrinterSettings(Convert.ToInt32(dtblDeclaration.Rows[0]["masterId"].ToString()));
                DotMatrixPrint.PrintDesign(inFormId, dtblOtherDetails, dtblGridDetails, dtblOtherDetails);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS49:" + ex.Message;
            }
        }

        public bool PrintAfetrSave()
        {
            bool isTick = false;
            try
            {
                isTick = TransactionGeneralFillObj.StatusOfPrintAfterSave();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS50:" + ex.Message;
            }
            return isTick;
        }

        public void EditFunction()
        {
            try
            {
                ExchangeRateSP spExchangeRate = new ExchangeRateSP();
                InfoSalesMaster.SalesMasterId = decSalesMasterId;
                InfoSalesMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                InfoSalesMaster.AdditionalCost = 0m;
                InfoSalesMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                InfoSalesMaster.BillDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                InfoSalesMaster.CounterId = Convert.ToDecimal(cmbCounter.SelectedValue.ToString());
                InfoSalesMaster.CreditPeriod = 0;
                InfoSalesMaster.CustomerName = "";
                InfoSalesMaster.Date = Convert.ToDateTime(txtDate.Text.Trim());
                InfoSalesMaster.DeliveryNoteMasterId = 0m;
                if (cmbSalesMan.SelectedValue.ToString() != null)
                {
                    InfoSalesMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.EmployeeId = 0m;
                }
                decimal decExachangeRateId = spExchangeRate.ExchangerateViewByCurrencyId(PublicVariables._decCurrencyId);
                InfoSalesMaster.ExchangeRateId = decExachangeRateId;
                InfoSalesMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoSalesMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                InfoSalesMaster.LrNo = string.Empty;
                InfoSalesMaster.Narration = txtNarration.Text.Trim();
                InfoSalesMaster.OrderMasterId = 0m;
                InfoSalesMaster.POS = true;
                InfoSalesMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                InfoSalesMaster.QuotationMasterId = 0m;
                InfoSalesMaster.SalesAccount = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                InfoSalesMaster.TaxAmount = Convert.ToDecimal(lblTaxTotalAmount.Text);
                InfoSalesMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                InfoSalesMaster.TransportationCompany = "";
                InfoSalesMaster.UserId = PublicVariables._decCurrentUserId;
                InfoSalesMaster.VoucherTypeId = DecPOSVoucherTypeId;
                if (isAutomatic)
                {
                    InfoSalesMaster.SuffixPrefixId = decPOSSuffixPrefixId;
                }
                else
                {
                    InfoSalesMaster.SuffixPrefixId = 0m;
                }
                if (isAutomatic)
                {
                    InfoSalesMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    InfoSalesMaster.VoucherNo = txtVoucherNo.Text.Trim();
                }
                InfoSalesMaster.ExtraDate = DateTime.Now;
                InfoSalesMaster.Extra1 = string.Empty;
                InfoSalesMaster.Extra2 = string.Empty;
                spSalesMaster.SalesMasterEdit(InfoSalesMaster);
                decimal dcAgainstVopucherTypeId = 0m;
                string strAgainstVoucherNo = "NA";
                spStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(dcAgainstVopucherTypeId, strAgainstVoucherNo, strVoucherNo, InfoSalesMaster.VoucherTypeId);
                spLedgerPosting.LedgerPostDelete(InfoSalesMaster.VoucherNo, InfoSalesMaster.VoucherTypeId);
                removeSalesInvoiceDetails();
                SalesInvoiceDetailsEdit();
                Messages.UpdatedMessage();
                if (objfrmSalesInvoiceRegister != null)
                {
                    if (cbxPrintAfterSave.Checked)
                    {
                        SettingsSP spSettings2 = new SettingsSP();
                        if (spSettings2.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decSalesMasterId);
                        }
                        else
                        {
                            Print(decSalesMasterId);
                        }
                    }
                    objfrmSalesInvoiceRegister.gridFill();
                }
                if (frmSalesReportObj != null)
                {
                    if (cbxPrintAfterSave.Checked)
                    {
                        SettingsSP spSettings2 = new SettingsSP();
                        if (spSettings2.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decSalesMasterId);
                        }
                        else
                        {
                            Print(decSalesMasterId);
                        }
                    }
                    frmSalesReportObj.gridFill();
                }
                base.Close();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS51:" + ex.Message;
            }
        }

        public void removeSalesInvoiceDetails()
        {
            try
            {
                foreach (object item in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(item);
                    spSalesDetails.SalesDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS52:" + ex.Message;
            }
        }

        public void SalesInvoiceDetailsEdit()
        {
            try
            {
                for (int inI = 0; inI < dgvPointOfSales.Rows.Count; inI++)
                {
                    decimal decRefStatus = spSalesMaster.SalesInvoiceReferenceCheckForEdit(decSalesMasterId);
                    if (Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtSalesDetailsId"].Value) == 0m || dgvPointOfSales.Rows[inI].Cells["dgvtxtSalesDetailsId"].Value == null)
                    {
                        InfoSalesDetails.SalesMasterId = decSalesMasterId;
                        InfoSalesDetails.ExtraDate = DateTime.Now;
                        InfoSalesDetails.Extra1 = string.Empty;
                        InfoSalesDetails.Extra2 = string.Empty;
                        if (dgvPointOfSales.Rows[inI].Cells["dgvtxtProductName"].Value != null && dgvPointOfSales.Rows[inI].Cells["dgvtxtProductName"].Value.ToString() != string.Empty && dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value != null && dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString() != string.Empty)
                        {
                            InfoSalesDetails.SlNo = Convert.ToInt32(dgvPointOfSales.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                            InfoSalesDetails.ProductId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtProductId"].Value.ToString());
                            InfoSalesDetails.Qty = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString());
                            InfoSalesDetails.Rate = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                            InfoSalesDetails.UnitId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtUnitId"].Value.ToString());
                            InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtunitconversionId"].Value.ToString());
                            InfoSalesDetails.Discount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtDiscount"].Value.ToString());
                            InfoSalesDetails.TaxId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxttaxid"].Value.ToString());
                            InfoSalesDetails.BatchId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtBatchId"].Value.ToString());
                            InfoSalesDetails.GodownId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGodownId"].Value.ToString());
                            InfoSalesDetails.RackId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRackId"].Value.ToString());
                            InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTaxAmount"].Value.ToString());
                            InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGrossValue"].Value.ToString());
                            InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtNetAmount"].Value.ToString());
                            InfoSalesDetails.Amount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTotalAmount"].Value.ToString());
                            spSalesDetails.SalesDetailsAdd(InfoSalesDetails);
                        }
                    }
                    else
                    {
                        InfoSalesDetails.SalesMasterId = decSalesMasterId;
                        InfoSalesDetails.ExtraDate = DateTime.Now;
                        InfoSalesDetails.Extra1 = string.Empty;
                        InfoSalesDetails.Extra2 = string.Empty;
                        InfoSalesDetails.SalesDetailsId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtSalesDetailsId"].Value);
                        InfoSalesDetails.SlNo = Convert.ToInt32(dgvPointOfSales.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        InfoSalesDetails.ProductId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtProductId"].Value.ToString());
                        InfoSalesDetails.Qty = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString());
                        InfoSalesDetails.Rate = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        InfoSalesDetails.UnitId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtUnitId"].Value.ToString());
                        InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtunitconversionId"].Value.ToString());
                        InfoSalesDetails.Discount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtDiscount"].Value.ToString());
                        InfoSalesDetails.TaxId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxttaxid"].Value.ToString());
                        InfoSalesDetails.BatchId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtBatchId"].Value.ToString());
                        InfoSalesDetails.GodownId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGodownId"].Value.ToString());
                        InfoSalesDetails.RackId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRackId"].Value.ToString());
                        InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTaxAmount"].Value.ToString());
                        InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGrossValue"].Value.ToString());
                        InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtNetAmount"].Value.ToString());
                        InfoSalesDetails.Amount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTotalAmount"].Value.ToString());
                        spSalesDetails.SalesDetailsEdit(InfoSalesDetails);
                    }
                    int inTaxRowCount = dgvPOSTax.RowCount;
                    InfoSalesBillTax.SalesMasterId = decSalesMasterId;
                    InfoSalesBillTax.ExtraDate = DateTime.Now;
                    InfoSalesBillTax.Extra1 = string.Empty;
                    InfoSalesBillTax.Extra2 = string.Empty;
                    for (int inTax = 0; inTax < inTaxRowCount; inTax++)
                    {
                        if (dgvPOSTax.Rows[inTax].Cells["dgvtxttax"].Value != null && dgvPOSTax.Rows[inTax].Cells["dgvtxttax"].Value.ToString() != string.Empty && dgvPOSTax.Rows[inTax].Cells["dgvtxtTaxAmt"].Value != null && dgvPOSTax.Rows[inTax].Cells["dgvtxtTaxAmt"].Value.ToString() != string.Empty)
                        {
                            InfoSalesBillTax.TaxId = Convert.ToInt32(dgvPOSTax.Rows[inTax].Cells["dgvtxttax"].Value.ToString());
                            InfoSalesBillTax.TaxAmount = Convert.ToDecimal(dgvPOSTax.Rows[inTax].Cells["dgvtxtTaxAmt"].Value.ToString());
                            spSalesBillTax.SalesBillTaxEditBySalesMasterIdAndTaxId(InfoSalesBillTax);
                        }
                    }
                    infoStockPosting.Date = InfoSalesMaster.Date;
                    infoStockPosting.VoucherTypeId = DecPOSVoucherTypeId;
                    infoStockPosting.VoucherNo = strVoucherNo;
                    infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                    infoStockPosting.AgainstVoucherTypeId = 0m;
                    infoStockPosting.AgainstVoucherNo = "NA";
                    infoStockPosting.AgainstInvoiceNo = "NA";
                    infoStockPosting.ProductId = InfoSalesDetails.ProductId;
                    infoStockPosting.BatchId = InfoSalesDetails.BatchId;
                    infoStockPosting.UnitId = InfoSalesDetails.UnitId;
                    infoStockPosting.GodownId = InfoSalesDetails.GodownId;
                    infoStockPosting.RackId = InfoSalesDetails.RackId;
                    infoStockPosting.InwardQty = 0m;
                    infoStockPosting.OutwardQty = InfoSalesDetails.Qty;
                    infoStockPosting.Rate = InfoSalesDetails.Rate;
                    infoStockPosting.FinancialYearId = InfoSalesMaster.FinancialYearId;
                    infoStockPosting.Extra1 = string.Empty;
                    infoStockPosting.Extra2 = string.Empty;
                    spStockPosting.StockPostingAdd(infoStockPosting);
                }
                ledgerPostingAdd();
                if (spSalesMaster.SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString())))
                {
                    infoPartyBalance.Date = InfoSalesMaster.Date;
                    infoPartyBalance.LedgerId = InfoSalesMaster.LedgerId;
                    infoPartyBalance.VoucherNo = strVoucherNo;
                    infoPartyBalance.InvoiceNo = txtVoucherNo.Text.Trim();
                    infoPartyBalance.VoucherTypeId = DecPOSVoucherTypeId;
                    infoPartyBalance.AgainstVoucherTypeId = 0m;
                    infoPartyBalance.AgainstVoucherNo = "NA";
                    infoPartyBalance.AgainstInvoiceNo = "NA";
                    infoPartyBalance.ReferenceType = "New";
                    infoPartyBalance.Debit = InfoSalesMaster.GrandTotal;
                    infoPartyBalance.Credit = 0m;
                    infoPartyBalance.CreditPeriod = 0;
                    infoPartyBalance.ExchangeRateId = InfoSalesMaster.ExchangeRateId;
                    infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoPartyBalance.ExtraDate = DateTime.Now;
                    infoPartyBalance.Extra1 = string.Empty;
                    infoPartyBalance.Extra2 = string.Empty;
                    spPartyBalance.PartyBalanceEdit(infoPartyBalance);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS53:" + ex.Message;
            }
        }

        public void CallFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                base.Show();
                objVoucherSearch = frm;
                decSalesMasterId = decId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS54:" + ex.Message;
            }
        }

        public void CallFromSalesRegister(decimal decSalesMasterid, frmSalesInvoiceRegister frmSiRegister)
        {
            try
            {
                objfrmSalesInvoiceRegister = frmSiRegister;
                objfrmSalesInvoiceRegister.Enabled = false;
                decSalesMasterId = decSalesMasterid;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS55:" + ex.Message;
            }
        }

        public void CallFromSalesInvoiceReport(decimal decSalesMasterid, frmSalesReport frmSIReport)
        {
            try
            {
                frmSalesReportObj = frmSIReport;
                decSalesMasterId = decSalesMasterid;
                frmSIReport.Enabled = false;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS56:" + ex.Message;
            }
        }

        public void DetailsFillForEdit()
        {
            try
            {
                VoucherTypeSP spVoucherType = new VoucherTypeSP();
                isFormIdtoEdit = true;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtVoucherNo.ReadOnly = true;
                txtPaidAmount.Text = "0";
                txtBalance.Text = "0";
                txtDate.Focus();
                DataTable dtblMaster = spSalesMaster.POSSalesMasterViewBySalesMasterId(decSalesMasterId);
                txtVoucherNo.Text = dtblMaster.Rows[0]["invoiceNo"].ToString();
                strVoucherNo = dtblMaster.Rows[0]["voucherNo"].ToString();
                decPOSSuffixPrefixId = Convert.ToDecimal(dtblMaster.Rows[0]["suffixPrefixId"].ToString());
                DecPOSVoucherTypeId = Convert.ToDecimal(dtblMaster.Rows[0]["voucherTypeId"].ToString());
                isAutomatic = spVoucherType.CheckMethodOfVoucherNumbering(DecPOSVoucherTypeId);
                txtDate.Text = dtblMaster.Rows[0]["date"].ToString();
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                cmbCashOrParty.SelectedValue = dtblMaster.Rows[0]["ledgerId"].ToString();
                txtNarration.Text = dtblMaster.Rows[0]["narration"].ToString();
                txtTotalAmount.Text = dtblMaster.Rows[0]["totalAmount"].ToString();
                txtBillDiscount.Text = dtblMaster.Rows[0]["billDiscount"].ToString();
                txtGrandTotal.Text = dtblMaster.Rows[0]["grandTotal"].ToString();
                cmbSalesAccount.SelectedValue = dtblMaster.Rows[0]["salesAccount"].ToString();
                cmbCounter.SelectedValue = dtblMaster.Rows[0]["counterId"].ToString();
                cmbPricingLevel.SelectedValue = dtblMaster.Rows[0]["pricingLevelId"].ToString();
                cmbSalesMan.SelectedValue = dtblMaster.Rows[0]["employeeId"].ToString();
                txtBalance.Text = dtblMaster.Rows[0]["grandTotal"].ToString();
                DataTable dtbl3 = new DataTable();
                dtbl3 = spSalesDetails.SalesDetailsViewBySalesMasterId(decSalesMasterId);
                for (int j = 0; j < dtbl3.Rows.Count; j++)
                {
                    dgvPointOfSales.Rows.Add();
                    decSalesDetailsId = Convert.ToDecimal(dtbl3.Rows[j]["salesDetailsId"].ToString());
                    dgvPointOfSales.Rows[j].Cells["dgvtxtSalesDetailsId"].Value = decSalesDetailsId;
                    dgvPointOfSales.Rows[j].Cells["dgvtxtSlNo"].Value = dtbl3.Rows[j]["slNo"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtProductCode"].Value = dtbl3.Rows[j]["productCode"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtProductName"].Value = dtbl3.Rows[j]["productName"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtQuantity"].Value = dtbl3.Rows[j]["qty"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtUnit"].Value = dtbl3.Rows[j]["unitName"].ToString();
                    decimal dcrate = Convert.ToDecimal(dtbl3.Rows[j]["rate"].ToString());
                    dgvPointOfSales.Rows[j].Cells["dgvtxtRate"].Value = Math.Round(dcrate, PublicVariables._inNoOfDecimalPlaces);
                    dgvPointOfSales.Rows[j].Cells["dgvtxtGrossValue"].Value = dtbl3.Rows[j]["grossAmount"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtDiscount"].Value = dtbl3.Rows[j]["discount"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtNetAmount"].Value = dtbl3.Rows[j]["netAmount"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtTaxPercentage"].Value = dtbl3.Rows[j]["taxName"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtTaxAmount"].Value = dtbl3.Rows[j]["taxAmount"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtTotalAmount"].Value = dtbl3.Rows[j]["amount"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtBarcode"].Value = dtbl3.Rows[j]["barcode"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtunitconversionId"].Value = dtbl3.Rows[j]["unitConversionId"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtBatchId"].Value = dtbl3.Rows[j]["batchId"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtRackId"].Value = dtbl3.Rows[j]["rackId"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtGodownId"].Value = dtbl3.Rows[j]["godownId"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtBatchno"].Value = dtbl3.Rows[j]["batchNo"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtGodownName"].Value = dtbl3.Rows[j]["godownName"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtRackName"].Value = dtbl3.Rows[j]["rackName"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxttaxid"].Value = dtbl3.Rows[j]["taxId"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtProductId"].Value = dtbl3.Rows[j]["productId"].ToString();
                    dgvPointOfSales.Rows[j].Cells["dgvtxtUnitId"].Value = dtbl3.Rows[j]["unitId"].ToString();
                }
                taxGridFill();
                dtbl3 = spSalesBillTax.SalesInvoiceSalesBillTaxViewAllBySalesMasterId(decSalesMasterId);
                foreach (DataGridViewRow item in (IEnumerable)dgvPOSTax.Rows)
                {
                    for (int j = 0; j < dtbl3.Rows.Count; j++)
                    {
                        if (dgvPOSTax.Rows[j].Cells["dgvtxttax"].Value != null && dgvPOSTax.Rows[j].Cells["dgvtxttax"].Value.ToString() != string.Empty)
                        {
                            dgvPOSTax.Rows[j].Cells["dgvtxttax"].Value = dtbl3.Rows[j]["taxId"].ToString();
                            dgvPOSTax.Rows[j].Cells["dgvtxtTaxAmt"].Value = dtbl3.Rows[j]["taxAmount"].ToString();
                        }
                    }
                }
                TaxTotal();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS57:" + ex.Message;
            }
        }

        public void DeleteFunction(decimal decSalesInvoiceid)
        {
            try
            {
                PartyBalanceSP spPartyBalance = new PartyBalanceSP();
                spSalesMaster.SalesInvoiceDelete(decSalesMasterId, DecPOSVoucherTypeId, strVoucherNo);
                Messages.DeletedMessage();
                if (objfrmSalesInvoiceRegister != null)
                {
                    base.Close();
                    objfrmSalesInvoiceRegister.Enabled = true;
                    objfrmSalesInvoiceRegister.gridFill();
                }
                else if (frmSalesReportObj != null)
                {
                    base.Close();
                    frmSalesReportObj.Enabled = true;
                    frmSalesReportObj.gridFill();
                }
                else if (frmDayBookObj != null)
                {
                    base.Close();
                }
                else
                {
                    Clear();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS58:" + ex.Message;
            }
        }

        public void callFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmDayBookObj = frmDayBook;
                frmDayBook.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS59:" + ex.Message;
            }
        }

        public void callFromVatReturnReport(frmVatReturnReport frmVatReport, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmvatReturnReportObj = frmVatReport;
                frmVatReport.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS60:" + ex.Message;
            }
        }

        public void callFromAgeing(frmAgeingReport frmAgeing, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmAgeingObj = frmAgeing;
                frmAgeing.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS61:" + ex.Message;
            }
        }

        public void callFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherProductObj, decimal decMasterId)
        {
            try
            {
                base.Show();
                objVoucherProduct = frmVoucherProductObj;
                frmVoucherProductObj.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS62:" + ex.Message;
            }
        }

        public void CallFromLedgerDetails(frmLedgerDetails LedgerDetailsObj, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmledgerDetailsObj = LedgerDetailsObj;
                frmledgerDetailsObj.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS63:" + ex.Message;
            }
        }

        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductSP spProduct = new ProductSP();
            try
            {
                base.Show();
                frmProductSearchPopupObj = frmProductSearchPopup;
                cmbItem.SelectedValue = decproductId;
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS64:" + ex.Message;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpDate.Value;
                txtDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS65:" + ex.Message;
            }
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            try
            {
                ClearFunctions();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS66:" + ex.Message;
            }
        }

        private void dgvPointOfSales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
                maxSerialNo++;
                dgvPointOfSales.Rows[e.RowIndex].Cells["rowId"].Value = maxSerialNo.ToString();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS67:" + ex.Message;
            }
        }

        private void dgvPOSTax_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNoforPOSTax();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS68:" + ex.Message;
            }
        }

        private void btnNewLedger_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = true;
                isFromSalesAccountCombo = false;
                AccountLedgerCreation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS69:" + ex.Message;
            }
        }

        private void btnNewCounter_Click(object sender, EventArgs e)
        {
            isFromCounterCombo = true;
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCounter", "Save"))
                {
                    if (cmbCounter.SelectedValue != null)
                    {
                        strCounter = cmbCounter.SelectedValue.ToString();
                    }
                    else
                    {
                        strCounter = string.Empty;
                    }
                    frmCounter frmCounterObj = new frmCounter();
                    frmCounterObj.MdiParent = formMDI.MDIObj;
                    frmCounter open = Application.OpenForms["frmCounter"] as frmCounter;
                    if (open == null)
                    {
                        frmCounterObj.WindowState = FormWindowState.Normal;
                        frmCounterObj.MdiParent = formMDI.MDIObj;
                        frmCounterObj.callFromPOS(this, isFromCounterCombo);
                    }
                    else
                    {
                        open.callFromPOS(this, isFromCounterCombo);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You don’t have privilege", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS70:" + ex.Message;
            }
        }

        private void btnNewSalesMan_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesman", "Save"))
                {
                    if (cmbSalesMan.SelectedValue != null)
                    {
                        strSalesMan = cmbSalesMan.SelectedValue.ToString();
                    }
                    else
                    {
                        strSalesMan = string.Empty;
                    }
                    frmSalesman frmSalesmanObj = new frmSalesman();
                    frmSalesmanObj.MdiParent = formMDI.MDIObj;
                    frmSalesman open = Application.OpenForms["frmSalesman"] as frmSalesman;
                    if (open == null)
                    {
                        frmSalesmanObj.WindowState = FormWindowState.Normal;
                        frmSalesmanObj.MdiParent = formMDI.MDIObj;
                        frmSalesmanObj.callFromPOS(this);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.callFromPOS(this);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    base.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You don’t have privilege", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS71:" + ex.Message;
            }
        }

        private void btnNewSalesAccount_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = false;
                isFromSalesAccountCombo = true;
                AccountLedgerCreation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS72:" + ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFunctions();
                if (objfrmSalesInvoiceRegister != null)
                {
                    objfrmSalesInvoiceRegister.Close();
                    objfrmSalesInvoiceRegister = null;
                }
                if (frmSalesReportObj != null)
                {
                    frmSalesReportObj.Close();
                    frmSalesReportObj = null;
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Close();
                    frmDayBookObj = null;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Close();
                    frmAgeingObj = null;
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Close();
                    objVoucherSearch = null;
                }
                if (frmledgerDetailsObj != null)
                {
                    frmledgerDetailsObj.Enabled = true;
                    frmledgerDetailsObj = null;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj = null;
                }
                base.BringToFront();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS73:" + ex.Message;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                QuantityStatusCheck();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS74:" + ex.Message;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, base.Name, btnSave.Text))
                {
                    SaveOrEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS75:" + ex.Message;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicVariables.isMessageClose)
                {
                    Messages.CloseMessage(this);
                }
                else
                {
                    base.Close();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS76:" + ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, base.Name, "Delete"))
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage())
                        {
                            DeleteFunction(decSalesMasterId);
                        }
                        dgvPointOfSales.Focus();
                    }
                    else
                    {
                        DeleteFunction(decSalesMasterId);
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS77:" + ex.Message;
            }
        }

        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvPointOfSales.SelectedCells.Count > 0 && dgvPointOfSales.CurrentRow != null)
                {
                    int inRowIndex = dgvPointOfSales.CurrentRow.Index;
                    if (MessageBox.Show("Do you want to remove current row?", "Openmiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (btnSave.Text == "Update")
                        {
                            if (dgvPointOfSales.CurrentRow.Cells["dgvtxtSalesDetailsId"].Value != null && dgvPointOfSales.CurrentRow.Cells["dgvtxtSalesDetailsId"].Value.ToString() != "")
                            {
                                lstArrOfRemove.Add(dgvPointOfSales.CurrentRow.Cells["dgvtxtSalesDetailsId"].Value.ToString());
                                RemoveRow();
                                ClearGroupbox();
                                TotalAmountCalculation();
                            }
                            else
                            {
                                RemoveRow();
                                ClearGroupbox();
                                TotalAmountCalculation();
                            }
                        }
                        else
                        {
                            RemoveRow();
                            ClearGroupbox();
                            TotalAmountCalculation();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS78:" + ex.Message;
            }
        }

        private void dgvPointOfSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPointOfSales.Rows.Count > 0 && dgvPointOfSales.CurrentRow != null && dgvPointOfSales.CurrentRow.Cells["dgvtxtProductCode"].Value != null && dgvPointOfSales.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                {
                    txtProductCode.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString();
                    cmbItem.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                    txtQuantity.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtQuantity"].Value.ToString();
                    cmbUnit.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtUnit"].Value.ToString();
                    txtRate.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtRate"].Value.ToString();
                    txtGrossValue.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtGrossValue"].Value.ToString();
                    cmbTax.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtTaxPercentage"].Value.ToString();
                    txtTaxAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtTaxAmount"].Value.ToString();
                    txtNetAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtNetAmount"].Value.ToString();
                    txtDiscountAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtDiscount"].Value.ToString();
                    txtAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtTotalAmount"].Value.ToString();
                    txtBarcode.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtBarcode"].Value.ToString();
                    cmbBatch.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtBatchno"].Value.ToString();
                    cmbGodown.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtGodownName"].Value.ToString();
                    cmbRack.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtRackName"].Value.ToString();
                    if (dgvPointOfSales.CurrentRow.Cells["rowId"].Value != null && dgvPointOfSales.CurrentRow.Cells["rowId"].Value.ToString() != string.Empty)
                    {
                        rowIdToEdit = int.Parse(dgvPointOfSales.CurrentRow.Cells["rowId"].Value.ToString());
                    }
                    btnAdd.Text = "Edit";
                    txtQuantity.Focus();
                    txtQuantity.SelectAll();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS79:" + ex.Message;
            }
        }

        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            try
            {
                string strBarcode = txtBarcode.Text.Trim();
                FillControlsByBarcode(strBarcode);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS80:" + ex.Message;
            }
        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProductCode.Text.Trim() != string.Empty)
                {
                    FillControlByProductCode(true);
                }
                else
                {
                    txtBarcode.Text = string.Empty;
                    txtProductCode.Text = string.Empty;
                    cmbItem.SelectedIndex = -1;
                    txtQuantity.Text = string.Empty;
                    txtRate.Text = string.Empty;
                    cmbGodown.DataSource = null;
                    cmbRack.DataSource = null;
                    cmbBatch.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS81:" + ex.Message;
            }
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtDate);
                if (txtDate.Text == string.Empty)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string strdate = txtDate.Text;
                dtpDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS82:" + ex.Message;
            }
        }

        private void txtBillDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal decGrandTotal = 0m;
                if (txtBillDiscount.Text.Trim() != string.Empty)
                {
                    decimal decTotal = Convert.ToDecimal(txtTotalAmount.Text.Trim());
                    decimal decBilldiscount = Convert.ToDecimal(txtBillDiscount.Text.Trim());
                    if (decBilldiscount > decTotal)
                    {
                        txtGrandTotal.Text = decTotal.ToString();
                    }
                    else
                    {
                        decGrandTotal = decTotal - decBilldiscount;
                        txtGrandTotal.Text = decGrandTotal.ToString();
                    }
                }
                else
                {
                    txtGrandTotal.Text = txtTotalAmount.Text.Trim();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS83:" + ex.Message;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrossValueCalculation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS84:" + ex.Message;
            }
        }

        private void txtGrossValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DiscountCalculation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS85:" + ex.Message;
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrossValueCalculation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS86:" + ex.Message;
            }
        }

        private void txtDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (isFromDiscAmt)
                {
                    DiscountCalculation();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS87:" + ex.Message;
            }
        }

        private void txtNetAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TaxAmountCalculation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS88:" + ex.Message;
            }
        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                isFromDiscAmt = false;
                DiscountPerCalculation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS89:" + ex.Message;
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalAmountCalculation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS90:" + ex.Message;
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isFromBarcode)
                {
                    cmbUnit.DataSource = null;
                    if (cmbItem.SelectedIndex > -1 && cmbItem.SelectedValue != null && cmbItem.SelectedValue.ToString() != "System.Data.DataRowView" && cmbItem.Text != "System.Data.DataRowView")
                    {
                        GodownComboFill();
                        RackComboFill();
                        decProductId = Convert.ToDecimal(cmbItem.SelectedValue.ToString());
                        FillControlsByProductName(decProductId);
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS91:" + ex.Message;
            }
        }

        private void txtBillDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS92:" + ex.Message;
            }
        }

        private void txtDiscountAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS93:" + ex.Message;
            }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS94:" + ex.Message;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS95:" + ex.Message;
            }
        }

        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj.Activate();
                    frmDayBookObj = null;
                }
                if (objVoucherProduct != null)
                {
                    objVoucherProduct.Enabled = true;
                    objVoucherProduct.FillGrid();
                    objVoucherProduct.Activate();
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                    objVoucherSearch.Activate();
                }
                if (frmvatReturnReportObj != null)
                {
                    frmvatReturnReportObj.Enabled = true;
                    frmvatReturnReportObj.GridFill();
                    frmvatReturnReportObj.Activate();
                }
                if (frmSalesReportObj != null)
                {
                    frmSalesReportObj.Enabled = true;
                    frmSalesReportObj.gridFill();
                    frmSalesReportObj.Activate();
                }
                if (objfrmSalesInvoiceRegister != null)
                {
                    objfrmSalesInvoiceRegister.Enabled = true;
                    objfrmSalesInvoiceRegister.Activate();
                    objfrmSalesInvoiceRegister.gridFill();
                }
                if (frmledgerDetailsObj != null)
                {
                    frmledgerDetailsObj.Enabled = true;
                    frmledgerDetailsObj.Activate();
                    frmledgerDetailsObj.LedgerDetailsView();
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj.BringToFront();
                    frmAgeingObj.FillGrid();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS96:" + ex.Message;
            }
        }

        private void cmbUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                UnitConvertionSP SpUnitConvertion = new UnitConvertionSP();
                if (cmbUnit.SelectedValue != null)
                {
                    DataTable dtblUnitByProduct = new DataTable();
                    dtblUnitByProduct = SpUnitConvertion.UnitConversionIdAndConRateViewallByProductId(decProductId.ToString());
                    foreach (DataRow row in dtblUnitByProduct.Rows)
                    {
                        if (cmbUnit.SelectedValue.ToString() == row.ItemArray[0].ToString())
                        {
                            lblUnitConversion.Text = row.ItemArray[2].ToString();
                            lblUnitConversionRate.Text = row.ItemArray[3].ToString();
                            if (isAfterFillControls)
                            {
                                decimal decNewConversionRate = Convert.ToDecimal(lblUnitConversionRate.Text.ToString());
                                decimal decNewRate = decCurrentRate * decCurrentConversionRate / decNewConversionRate;
                                txtRate.Text = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS97:" + ex.Message;
            }
        }

        private void cmbUnit_Enter(object sender, EventArgs e)
        {
            try
            {
                if (lblUnitConversionRate.Text.Trim() != string.Empty)
                {
                    decCurrentConversionRate = Convert.ToDecimal(lblUnitConversionRate.Text);
                }
                if (txtRate.Text != string.Empty)
                {
                    decCurrentRate = Convert.ToDecimal(txtRate.Text);
                }
                else
                {
                    decCurrentRate = 0m;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS98:" + ex.Message;
            }
        }

        private void txtBillDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBillDiscount.Text == string.Empty)
                {
                    txtBillDiscount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS99:" + ex.Message;
            }
        }

        private void txtBillDiscount_Enter(object sender, EventArgs e)
        {
            try
            {
                txtBillDiscount.Text = string.Empty;
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS100:" + ex.Message;
            }
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS101:" + ex.Message;
            }
        }

        private void txtDiscountPercentage_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscountPercentage.Text.Trim() == string.Empty)
                {
                    txtDiscountPercentage.Text = "0";
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS102:" + ex.Message;
            }
        }

        private void txtDiscountAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                isFromDiscAmt = true;
                if (txtDiscountAmount.Text.Trim() == string.Empty)
                {
                    txtDiscountAmount.Text = "0";
                }
                DiscountCalculation();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS103:" + ex.Message;
            }
        }

        private void txtDiscountPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS104:" + ex.Message;
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (txtProductCode.Visible)
                    {
                        txtProductCode.Focus();
                        txtProductCode.SelectionStart = 0;
                        txtProductCode.SelectionLength = 0;
                    }
                    else
                    {
                        cmbItem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS105:" + ex.Message;
            }
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbItem.Focus();
                }
                else if (e.KeyCode == Keys.Back && (txtProductCode.Text.Trim() == string.Empty || txtProductCode.SelectionStart == 0))
                {
                    if (txtBarcode.Visible)
                    {
                        txtBarcode.SelectionStart = 0;
                        txtBarcode.SelectionLength = 0;
                        txtBarcode.Focus();
                    }
                    else
                    {
                        cmbCounter.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS106:" + ex.Message;
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            string strtxt = txtQuantity.Text.Trim();
            try
            {
                SettingsSP spSettings = new SettingsSP();
                if (e.KeyCode == Keys.Return)
                {
                    if (spSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                    {
                        cmbUnit.Focus();
                    }
                    else
                    {
                        txtRate.Focus();
                        txtRate.Select();
                    }
                }
                else if (e.KeyCode == Keys.Back && txtQuantity.SelectionLength > 0)
                {
                    txtQuantity.Text = strtxt.Trim();
                    txtQuantity.SelectionStart = 0;
                    txtQuantity.SelectionLength = 0;
                    if (spSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                    {
                        cmbBatch.Focus();
                    }
                    else if (spSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                    {
                        cmbRack.Focus();
                    }
                    else
                    {
                        cmbItem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS107:" + ex.Message;
            }
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    btnSave_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS108:" + ex.Message;
            }
        }

        private void txtBillDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    txtPaidAmount.Focus();
                    txtPaidAmount.SelectAll();
                }
                else if (e.KeyCode == Keys.Back && (txtBillDiscount.Text.Trim() == string.Empty || txtBillDiscount.SelectionStart == 0))
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS109:" + ex.Message;
            }
        }

        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                else if (e.Control && e.KeyCode == Keys.S)
                {
                    btnSave_Click(sender, e);
                }
                else if (e.Control && e.KeyCode == Keys.D)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.F9)
                {
                    txtBillDiscount.Focus();
                    txtBillDiscount.SelectAll();
                }
                else if (e.KeyCode == Keys.F4)
                {
                    txtPaidAmount.Focus();
                    txtPaidAmount.SelectAll();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS110:" + ex.Message;
            }
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtPaidAmount.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS111:" + ex.Message;
            }
        }

        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    btnSave.Focus();
                }
                if (txtPaidAmount.Text.Trim() == string.Empty && txtGrandTotal.Text.Trim() != string.Empty)
                {
                    txtBalance.Text = "-" + txtGrandTotal.Text;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS112:" + ex.Message;
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbPricingLevel.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS113:" + ex.Message;
            }
        }

        private void cmbPricingLevel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbSalesMan.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtDate.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS114:" + ex.Message;
            }
        }

        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbCashOrParty.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbPricingLevel.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewSalesMan_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbSalesMan.Focused)
                    {
                        cmbSalesMan.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbSalesMan.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbSalesMan.SelectedIndex > -1)
                    {
                        frmEmployeePopup frmEmployeePopupObj = new frmEmployeePopup();
                        frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                        frmEmployeePopupObj.callFromPOS(this, Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select any Sales Man");
                        cmbSalesMan.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS115:" + ex.Message;
            }
        }

        private void cmbSalesAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbCounter.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewSalesAccount_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbSalesAccount.Focused)
                    {
                        cmbSalesAccount.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbSalesAccount.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbSalesAccount.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromPOS(this, Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString()), "SalesAccount");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS116:" + ex.Message;
            }
        }

        private void cmbCounter_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    txtBarcode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSalesAccount.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewCounter_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS117:" + ex.Message;
            }
        }

        private void txtDiscountPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                isFromDiscAmt = true;
                if (e.KeyCode == Keys.Return)
                {
                    txtDiscountAmount.SelectionStart = 0;
                    txtDiscountAmount.SelectionLength = 0;
                    txtDiscountAmount.Focus();
                }
                else if (e.KeyCode == Keys.Back && (txtDiscountPercentage.Text.Trim() == string.Empty || txtDiscountPercentage.SelectionStart == 0))
                {
                    txtQuantity.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS118:" + ex.Message;
            }
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal dcTotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                decimal dcBillDisc2 = 0m;
                decimal dcGrandTotal2 = 0m;
                dcBillDisc2 = ((!(txtBillDiscount.Text.Trim() != string.Empty)) ? 0m : Convert.ToDecimal(txtBillDiscount.Text));
                dcGrandTotal2 = ((!(dcBillDisc2 < dcTotalAmount)) ? Convert.ToDecimal(txtGrandTotal.Text) : (dcTotalAmount - dcBillDisc2));
                decimal dcBalance = 0m;
                if (txtPaidAmount.Text != string.Empty)
                {
                    dcBalance = decimal.Parse(txtPaidAmount.Text) - dcGrandTotal2;
                }
                txtBalance.Text = dcBalance.ToString();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS119:" + ex.Message;
            }
        }

        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        Messages.CloseMessage(this);
                    }
                    else
                    {
                        base.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS120:" + ex.Message;
            }
        }

        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbSalesAccount.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMan.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewLedger_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbCashOrParty.Focused)
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbCashOrParty.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromPOS(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryDeptors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS121:" + ex.Message;
            }
        }

        private void cmbItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                SettingsSP spSettings = new SettingsSP();
                if (e.KeyCode == Keys.Return)
                {
                    if (spSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                    {
                        cmbGodown.Focus();
                        cmbGodown.SelectionStart = 0;
                    }
                    else if (spSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                    {
                        cmbBatch.Focus();
                    }
                    else
                    {
                        txtQuantity.Focus();
                        txtQuantity.Select();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Visible)
                    {
                        if (txtProductCode.Text.Trim() != string.Empty || txtProductCode.SelectionLength == 0)
                        {
                            txtProductCode.SelectionStart = 0;
                            txtProductCode.Focus();
                        }
                    }
                    else
                    {
                        txtBarcode.Focus();
                        txtBarcode.Select();
                    }
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbItem.Focused)
                    {
                        cmbItem.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbItem.SelectedIndex != -1)
                    {
                        frmProductSearchPopup frmProductSearchPopupObj2 = new frmProductSearchPopup();
                        frmProductSearchPopupObj2.MdiParent = formMDI.MDIObj;
                        frmProductSearchPopupObj2.CallFromPOS(this, cmbItem.SelectedIndex, txtProductCode.Text);
                    }
                    else
                    {
                        frmProductSearchPopup frmProductSearchPopupObj2 = new frmProductSearchPopup();
                        frmProductSearchPopupObj2.MdiParent = formMDI.MDIObj;
                        frmProductSearchPopupObj2.CallFromPOS(this, cmbItem.SelectedIndex, string.Empty);
                    }
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    frmProductCreation frmProductCreationObj = new frmProductCreation();
                    bool isFromItemCombo = true;
                    if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductCreation", "Save"))
                    {
                        if (cmbItem.SelectedValue != null)
                        {
                            string strProductName2 = cmbItem.SelectedValue.ToString();
                        }
                        else
                        {
                            string strProductName2 = string.Empty;
                        }
                        frmProductCreationObj.MdiParent = formMDI.MDIObj;
                        frmProductCreationObj.CallFromPOSForProductCreation(this, isFromItemCombo);
                    }
                    else
                    {
                        MessageBox.Show("You don’t have privilege", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS122:" + ex.Message;
            }
        }

        private void cmbGodown_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbRack.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbItem.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS123:" + ex.Message;
            }
        }

        private void cmbRack_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmbBatch.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbGodown.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS124:" + ex.Message;
            }
        }

        private void cmbBatch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                SettingsSP spSettings = new SettingsSP();
                if (e.KeyCode == Keys.Return)
                {
                    txtQuantity.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (spSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                    {
                        cmbRack.Focus();
                    }
                    else
                    {
                        cmbItem.Focus();
                        cmbItem.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS125:" + ex.Message;
            }
        }

        private void cmbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    txtRate.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtQuantity.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS126:" + ex.Message;
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    btnAdd.Focus();
                }
                else if (e.KeyCode == Keys.Back && txtRate.SelectionStart == 0)
                {
                    txtQuantity.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS127:" + ex.Message;
            }
        }

        private void cmbGodown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGodown.SelectedIndex > -1 && cmbGodown.SelectedValue.ToString() != "System.Data.DataRowView" && cmbGodown.Text != "System.Data.DataRowView")
                {
                    decimal dcGodownId = Convert.ToDecimal(cmbGodown.SelectedValue.ToString());
                    RackComboFillByGodownId(dcGodownId);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS128:" + ex.Message;
            }
        }

        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        cbxPrintAfterSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
                if (e.KeyCode == Keys.Back && (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0))
                {
                    txtRate.Focus();
                    txtRate.SelectionStart = 0;
                    txtRate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS129:" + ex.Message;
            }
        }

        private void cbxPrintAfterSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS130:" + ex.Message;
            }
        }

        private void txtDiscountAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    btnAdd.Focus();
                }
                if (e.KeyCode == Keys.Back && txtDiscountAmount.SelectionStart == 0)
                {
                    txtDiscountPercentage.Focus();
                    txtDiscountPercentage.SelectionLength = 0;
                    txtDiscountPercentage.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS131:" + ex.Message;
            }
        }

        private void cmbTax_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    btnAdd.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtRate.Focus();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS132:" + ex.Message;
            }
        }

        private void txtPaidAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text.Trim() == string.Empty)
                {
                    txtPaidAmount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "POS133:" + ex.Message;
            }
        }

       

       
    }
}
