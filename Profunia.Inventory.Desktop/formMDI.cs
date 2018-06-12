using Profunia.Inventory.Desktop.Budget;
using Profunia.Inventory.Desktop.ClassFiles;
using Profunia.Inventory.Desktop.ClassFiles.General;
using Profunia.Inventory.Desktop.ClassFiles.Info;
using Profunia.Inventory.Desktop.ClassFiles.SP;
using Profunia.Inventory.Desktop.Company;
using Profunia.Inventory.Desktop.FinancialStatements;
using Profunia.Inventory.Desktop.Masters;
using Profunia.Inventory.Desktop.Others;
using Profunia.Inventory.Desktop.Payroll;
using Profunia.Inventory.Desktop.Registers;
using Profunia.Inventory.Desktop.Reminder;
using Profunia.Inventory.Desktop.Reports;
using Profunia.Inventory.Desktop.Search;
using Profunia.Inventory.Desktop.Settings;
using Profunia.Inventory.Desktop.Transactions;
using Profunia.Inventory.Desktop.Transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Profunia.Inventory.Desktop
{
    public partial class formMDI : Form
    {
        private SettingsSP spSettings = new SettingsSP();

        private frmLoading frmLoadingObj = new frmLoading();

        private myLabel lblQuickLaunch = new myLabel();

        private myLabel lblCalculator = new myLabel();

        private myLabel lblMiracleI = new myLabel();
        public static ErrorMessageInfo infoError = new ErrorMessageInfo();

        private class myLabel : Label
        {
            public int RotateAngle
            {
                get;
                set;
            }

            public string NewText
            {
                get;
                set;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Brush b = new SolidBrush(ForeColor);
                e.Graphics.TranslateTransform((float)(base.Width / 2 + 10), (float)(base.Height / 9));
                e.Graphics.RotateTransform((float)RotateAngle);
                e.Graphics.DrawString(NewText, new Font(Font.FontFamily, 10f), b, 0f, 0f);
                base.OnPaint(e);
            }
        }

        public formMDI()
        {
            InitializeComponent();
            //ControlMover.Init(ucCalculator1);
            //ControlMover.Init(ucQuickLaunch1);
            //infoError.PropertyChanged += CategoryInfo_PropertyChanged;
        }

        public void CurrentDateBefore()
        {
            try
            {
                CompanyInfo infoComapany = new CompanyInfo();
                CompanySP spCompany = new CompanySP();
                DateTime sysDate = PublicVariables._dtCurrentDate = DateTime.Today;
                DateTime date = new DateTime(sysDate.Year, 4, 1);
                DateTime dtFromDate2 = default(DateTime);
                DateTime dtToDate2 = default(DateTime);
                if (sysDate < date)
                {
                    dtFromDate2 = new DateTime(sysDate.Year - 1, 4, 1);
                    dtToDate2 = new DateTime(sysDate.Year, 3, 31);
                }
                else
                {
                    dtFromDate2 = new DateTime(sysDate.Year, 4, 1);
                    dtToDate2 = new DateTime(sysDate.Year + 1, 3, 31);
                }
                PublicVariables._dtFromDate = dtFromDate2;
                PublicVariables._dtToDate = dtToDate2;
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI1:" + ex.Message;
            }
        }

        public void CurrentDate()
        {
            try
            {
                CompanyInfo infoComapany = new CompanyInfo();
                CompanySP spCompany = new CompanySP();
                FinancialYearInfo infoFinancialYear2 = new FinancialYearInfo();
                FinancialYearSP spFinancialYear = new FinancialYearSP();
                infoComapany = spCompany.CompanyView(1m);
                PublicVariables._dtCurrentDate = infoComapany.CurrentDate;
                infoFinancialYear2 = spFinancialYear.FinancialYearView(1m);
                PublicVariables._dtFromDate = infoFinancialYear2.FromDate;
                PublicVariables._dtToDate = infoFinancialYear2.ToDate;
                dateToolStripMenuItem.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI2:" + ex.Message;
            }
        }

        public void CurrentSettings()
        {
            try
            {
                SettingsSP spSettings = new SettingsSP();
                SettingsInfo infoSettings = new SettingsInfo();
                if (spSettings.SettingsStatusCheck("AddConfirmationFor") == "Yes")
                {
                    if (spSettings.SettingsStatusCheck("Add") == "Yes")
                    {
                        PublicVariables.isMessageAdd = true;
                    }
                    else
                    {
                        PublicVariables.isMessageAdd = false;
                    }
                    if (spSettings.SettingsStatusCheck("Edit") == "Yes")
                    {
                        PublicVariables.isMessageEdit = true;
                    }
                    else
                    {
                        PublicVariables.isMessageEdit = false;
                    }
                    if (spSettings.SettingsStatusCheck("Delete") == "Yes")
                    {
                        PublicVariables.isMessageDelete = true;
                    }
                    else
                    {
                        PublicVariables.isMessageDelete = false;
                    }
                    if (spSettings.SettingsStatusCheck("Close") == "Yes")
                    {
                        PublicVariables.isMessageClose = true;
                    }
                    else
                    {
                        PublicVariables.isMessageClose = false;
                    }
                }
                else
                {
                    PublicVariables.isMessageAdd = (PublicVariables.isMessageClose = (PublicVariables.isMessageDelete = (PublicVariables.isMessageEdit = false)));
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI3:" + ex.Message;
            }
        }

        public void ShowCurrentDate()
        {
            try
            {
                dateToolStripMenuItem.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI4:" + ex.Message;
            }
        }

        public void CompanyCount()
        {
            try
            {
                CompanySP spCompany = new CompanySP();
                decimal decCount = spCompany.CompanyCount();
                if (decCount > 0m)
                {
                    SelectCompanyToolStripMenuItem.Enabled = true;
                }
                else
                {
                    SelectCompanyToolStripMenuItem.Enabled = false;
                }
                SelectCompanyToolStripMenuItem.Enabled = true;
                createCompanyToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI5:" + ex.Message;
            }
        }

        public void CallFromLogin()
        {
            //try
            //{
            //    MenuStripEnabling();
            //    createCompanyToolStripMenuItem.Enabled = false;
            //    SelectCompanyToolStripMenuItem.Enabled = false;
            //    editCompanyToolStripMenuItem1.Enabled = true;
            //    BackUpToolStripMenuItem.Enabled = true;
            //    RestoreToolStripMenuItem.Enabled = true;
            //    dateToolStripMenuItem.Enabled = true;
            //    logoutToolStripMenuItem.Enabled = true;
            //}
            //catch (Exception ex)
            //{
            //    infoError.ErrorString = "MDI6:" + ex.Message;
            //}
        }

        public void MenuStripDisabling()
        {
            try
            {
                companyToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem in companyToolStripMenuItem.DropDownItems)
                {
                    dropDownItem.Enabled = false;
                }
                mastersToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem2 in mastersToolStripMenuItem.DropDownItems)
                {
                    dropDownItem2.Enabled = false;
                }
                transactionToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem3 in transactionToolStripMenuItem.DropDownItems)
                {
                    dropDownItem3.Enabled = false;
                }
                registerToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem4 in registerToolStripMenuItem.DropDownItems)
                {
                    dropDownItem4.Enabled = false;
                }
                payrollToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem5 in payrollToolStripMenuItem.DropDownItems)
                {
                    dropDownItem5.Enabled = false;
                }
                settingsToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem6 in settingsToolStripMenuItem.DropDownItems)
                {
                    dropDownItem6.Enabled = false;
                }
                searchToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem7 in searchToolStripMenuItem.DropDownItems)
                {
                    dropDownItem7.Enabled = false;
                }
                reminderToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem8 in reminderToolStripMenuItem.DropDownItems)
                {
                    dropDownItem8.Enabled = false;
                }
                financialStatementToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem9 in financialStatementToolStripMenuItem.DropDownItems)
                {
                    dropDownItem9.Enabled = false;
                }
                reportsToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem10 in reportsToolStripMenuItem.DropDownItems)
                {
                    dropDownItem10.Enabled = false;
                }
                budgetToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem11 in budgetToolStripMenuItem.DropDownItems)
                {
                    dropDownItem11.Enabled = false;
                }
                utilitiesToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem12 in utilitiesToolStripMenuItem.DropDownItems)
                {
                    dropDownItem12.Enabled = false;
                }
                exitToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem13 in exitToolStripMenuItem.DropDownItems)
                {
                    dropDownItem13.Enabled = false;
                }
                logoutToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem14 in logoutToolStripMenuItem.DropDownItems)
                {
                    dropDownItem14.Enabled = false;
                }
                ContactUsToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem dropDownItem15 in ContactUsToolStripMenuItem.DropDownItems)
                {
                    dropDownItem15.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI7:" + ex.Message;
            }
        }

        public void MenuStripEnabling()
        {
            try
            {
                companyToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem in companyToolStripMenuItem.DropDownItems)
                {
                    dropDownItem.Enabled = true;
                }
                mastersToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem2 in mastersToolStripMenuItem.DropDownItems)
                {
                    dropDownItem2.Enabled = true;
                }
                transactionToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem3 in transactionToolStripMenuItem.DropDownItems)
                {
                    dropDownItem3.Enabled = true;
                }
                registerToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem4 in registerToolStripMenuItem.DropDownItems)
                {
                    dropDownItem4.Enabled = true;
                }
                payrollToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem5 in payrollToolStripMenuItem.DropDownItems)
                {
                    dropDownItem5.Enabled = true;
                }
                settingsToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem6 in settingsToolStripMenuItem.DropDownItems)
                {
                    dropDownItem6.Enabled = true;
                }
                searchToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem7 in searchToolStripMenuItem.DropDownItems)
                {
                    dropDownItem7.Enabled = true;
                }
                reminderToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem8 in reminderToolStripMenuItem.DropDownItems)
                {
                    dropDownItem8.Enabled = true;
                }
                financialStatementToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem9 in financialStatementToolStripMenuItem.DropDownItems)
                {
                    dropDownItem9.Enabled = true;
                }
                reportsToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem10 in reportsToolStripMenuItem.DropDownItems)
                {
                    dropDownItem10.Enabled = true;
                }
                budgetToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem11 in budgetToolStripMenuItem.DropDownItems)
                {
                    dropDownItem11.Enabled = true;
                }
                utilitiesToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem12 in utilitiesToolStripMenuItem.DropDownItems)
                {
                    dropDownItem12.Enabled = true;
                }
                helpToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem13 in helpToolStripMenuItem.DropDownItems)
                {
                    dropDownItem13.Enabled = true;
                }
                exitToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem14 in exitToolStripMenuItem.DropDownItems)
                {
                    dropDownItem14.Enabled = true;
                }
                logoutToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem15 in logoutToolStripMenuItem.DropDownItems)
                {
                    dropDownItem15.Enabled = true;
                }
                ContactUsToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem dropDownItem16 in ContactUsToolStripMenuItem.DropDownItems)
                {
                    dropDownItem16.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI8:" + ex.Message;
            }
        }

        public void LogOut()
        {
            try
            {
                Form[] mdiChildren = base.MdiChildren;
                foreach (Form frm in mdiChildren)
                {
                    frm.Close();
                }
                MenuStripDisabling();
                companyToolStripMenuItem.Enabled = true;
                exitToolStripMenuItem.Enabled = true;
                frmLogin frmLoginObj = new frmLogin();
                frmLoginObj.MdiParent = MDIObj;
                frmLoginObj.CallFromFormMdi(this);
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI9:" + ex.Message;
            }
        }

        public void ShowQuickLaunchMenu()
        {
            try
            {
                lblQuickLaunch.Visible = true;
                lblCalculator.Visible = true;
                lblMiracleI.Visible = true;
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI10:" + ex.Message;
            }
        }

        public void ContraVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmContraVoucher))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Contra Voucher";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI11:" + ex.Message;
            }
        }

        public void StockJournalClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmStockJournal))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Stock Journal";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI12:" + ex.Message;
            }
        }

        public void PaymentVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPaymentVoucher))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Payment Voucher";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI13:" + ex.Message;
            }
        }

        public void PDCPayableClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPdcPayable))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "PDC Payable";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI14:" + ex.Message;
            }
        }

        public void ReceiptVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmReceiptVoucher))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Receipt Voucher";
                    frm.CallFromVoucherMenu(strVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI15:" + ex.Message;
            }
        }

        public void JournalVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmJournalVoucher))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strJournalVoucherType = "Journal Voucher";
                    frm.CallFromVoucherMenu(strJournalVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI16:" + ex.Message;
            }
        }

        public void PDCReceivableClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPdcReceivable))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "PDC Receivable";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI17:" + ex.Message;
            }
        }

        public void PurchaseOrderClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPurchaseOrder))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Purchase Order";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI18:" + ex.Message;
            }
        }

        public void MaterialReceiptClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmMaterialReceipt))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Material Receipt";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI19:" + ex.Message;
            }
        }

        public void RejectionOutClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmRejectionOut))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Rejection Out";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI20:" + ex.Message;
            }
        }

        public void PurchaseInvoiceClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPurchaseInvoice))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Purchase Invoice";
                    frm.CallFromVoucherMenu(strVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI21:" + ex.Message;
            }
        }

        public void PurchaseReturnClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPurchaseReturn))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Purchase Return";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI22:" + ex.Message;
            }
        }

        public void SalesQuotationClick()
        {
            try
            {
                bool IsActive = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmSalesQuotation))
                    {
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                        openForm.Activate();
                        IsActive = true;
                    }
                }
                if (!IsActive)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Sales Quotation";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI23:" + ex.Message;
            }
        }

        public void SalesOrderClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmSalesOrder))
                    {
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                        openForm.Activate();
                        IsActivate = true;
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Sales Order";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI24:" + ex.Message;
            }
        }

        public void RejectionInClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmRejectionIn))
                    {
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                        openForm.Activate();
                        IsActivate = true;
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Rejection In";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI25:" + ex.Message;
            }
        }

        public void SalesInvoiceClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmSalesInvoice))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Sales Invoice";
                    frm.CallFromVoucherMenu(strVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI26:" + ex.Message;
            }
        }

        public void SalesReturnClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmSalesReturn))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Sales Return";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI27:" + ex.Message;
            }
        }

        public void CreditNoteClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmCreditNote))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strCreditNote = "Credit Note";
                    frm.CallFromVoucherMenu(strCreditNote);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI28:" + ex.Message;
            }
        }

        public void DebitNoteClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmDebitNote))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDebitVoucherType = "Debit Note";
                    frm.CallFromVoucherMenu(strDebitVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI29:" + ex.Message;
            }
        }

        public void PhysicalStockClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPhysicalStock))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strPhysicalStockVoucherType = "Physical Stock";
                    frm.CallFromVoucherMenu(strPhysicalStockVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI30:" + ex.Message;
            }
        }

        public void ServiceVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmServiceVoucher))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strServiceVoucherType = "Service Voucher";
                    frm.CallFromVoucherMenu(strServiceVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI31:" + ex.Message;
            }
        }

        public void DeliveryNoteClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmDeliveryNote))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Delivery Note";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI32:" + ex.Message;
            }
        }

        public void PDCClearenceClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPdcClearance))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "PDC Clearance";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI33:" + ex.Message;
            }
        }

        public void POSClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmPOS))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Sales Invoice";
                    strVouchertype = "POS";
                    frm.CallFromVoucherMenu(strVoucherType);
                    strVouchertype = "";
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI34:" + ex.Message;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            try
            {
                Form childForm = new Form();
                childForm.MdiParent = this;
                childForm.Text = "Window " + childFormNumber++;
                childForm.Show();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI35:" + ex.Message;
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI36:" + ex.Message;
            }
        }

        private void formMDI_Load(object sender, EventArgs e)
        {
            try
            {
                MDIObj = this;
                MenuStripDisabling();
                companyToolStripMenuItem.Enabled = true;
                editCompanyToolStripMenuItem1.Enabled = false;
                BackUpToolStripMenuItem.Enabled = false;
                RestoreToolStripMenuItem.Enabled = false;
                dateToolStripMenuItem.Enabled = false;
                exitToolStripMenuItem.Enabled = true;
                createCompanyToolStripMenuItem.Enabled = true;
                SelectCompanyToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = false;
                CompanySP spCompany = new CompanySP();
                decimal decCompanyCount = spCompany.CompanyCount();
                lblQuickLaunch.AutoSize = false;
                lblQuickLaunch.Visible = false;
                lblQuickLaunch.Width = 25;
                lblQuickLaunch.Cursor = Cursors.Hand;
                lblQuickLaunch.BackColor = Color.DimGray;
                lblQuickLaunch.Height = 105;
                lblQuickLaunch.TextAlign = ContentAlignment.MiddleCenter;
                lblQuickLaunch.ForeColor = Color.WhiteSmoke;
                lblQuickLaunch.NewText = "Quick Launch";
                lblQuickLaunch.RotateAngle = 90;
                myLabel myLabel = lblQuickLaunch;
                Point location = ucQuickLaunch1.Location;
                int x = location.X + ucQuickLaunch1.Width;
                location = ucQuickLaunch1.Location;
                myLabel.Location = new Point(x, location.Y);
                lblQuickLaunch.Click += lblQuickLaunch_Click;
                base.Controls.Add(lblQuickLaunch);
                lblCalculator.AutoSize = false;
                lblCalculator.Visible = false;
                lblCalculator.Width = 25;
                lblCalculator.Cursor = Cursors.Hand;
                lblCalculator.BackColor = Color.DimGray;
                lblCalculator.Height = 80;
                lblCalculator.TextAlign = ContentAlignment.MiddleCenter;
                lblCalculator.ForeColor = Color.WhiteSmoke;
                lblCalculator.NewText = "Calculator";
                lblCalculator.RotateAngle = 90;
                myLabel myLabel2 = lblCalculator;
                location = ucQuickLaunch1.Location;
                int x2 = location.X + ucQuickLaunch1.Width;
                location = ucQuickLaunch1.Location;
                myLabel2.Location = new Point(x2, location.Y + 110);
                lblCalculator.Click += lblCalculator_Click;
                base.Controls.Add(lblCalculator);
                lblMiracleI.AutoSize = false;
                lblMiracleI.Visible = false;
                lblMiracleI.Width = 25;
                lblMiracleI.Cursor = Cursors.Hand;
                lblMiracleI.BackColor = Color.DimGray;
                lblMiracleI.Height = 68;
                lblMiracleI.TextAlign = ContentAlignment.MiddleCenter;
                lblMiracleI.ForeColor = Color.Wheat;
                lblMiracleI.NewText = "Miracle I";
                lblMiracleI.RotateAngle = 90;
                myLabel myLabel3 = lblMiracleI;
                location = ucQuickLaunch1.Location;
                int x3 = location.X + ucQuickLaunch1.Width;
                location = ucQuickLaunch1.Location;
                myLabel3.Location = new Point(x3, location.Y + 210);
                lblMiracleI.Click += lblMiracleI_Click;
                base.Controls.Add(lblMiracleI);
                if (decCompanyCount != -1m)
                {
                    if (decCompanyCount == 1m)
                    {
                        PublicVariables._decCurrentCompanyId = spCompany.CompanyGetIdIfSingleCompany();
                        CurrentDate();
                        frmLogin frmLoginObj2 = new frmLogin();
                        frmLoginObj2.MdiParent = MDIObj;
                        frmLoginObj2.CallFromFormMdi(this);
                    }
                    else if (decCompanyCount < 1m)
                    {
                        CurrentDateBefore();
                        frmCompanyCreation frmCompanyCreationObj = new frmCompanyCreation();
                        frmCompanyCreationObj.MdiParent = MDIObj;
                        frmCompanyCreationObj.CallFromFormMdi();
                        SelectCompanyToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        PublicVariables._decCurrentCompanyId = 0m;
                        CompanyPathSP spCompanyPath = new CompanyPathSP();
                        decimal decDefaultCompanyId = spCompanyPath.CompanyViewForDefaultCompany();
                        if (decDefaultCompanyId > 0m)
                        {
                            PublicVariables._decCurrentCompanyId = decDefaultCompanyId;
                            CurrentDate();
                            frmLogin frmLoginObj2 = new frmLogin();
                            frmLoginObj2.MdiParent = MDIObj;
                            frmLoginObj2.CallFromFormMdi(this);
                        }
                        else
                        {
                            CurrentDate();
                            frmSelectCompany frmSelectCompanyObj = new frmSelectCompany();
                            frmSelectCompanyObj.MdiParent = MDIObj;
                            frmSelectCompanyObj.CallFromMdi();
                        }
                    }
                    CurrentSettings();
                }
                else
                {
                    createCompanyToolStripMenuItem.Enabled = false;
                    SelectCompanyToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI37:" + ex.Message;
            }
        }

        private void lblMiracleI_Click(object sender, EventArgs e)
        {
            try
            {
                miracleIToolStripMenuItem.PerformClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI247:" + ex.Message;
            }
        }

        private void lblCalculator_Click(object sender, EventArgs e)
        {
            try
            {
               // ucCalculator1.Visible = (!ucCalculator1.Visible && true);
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI39:" + ex.Message;
            }
        }

        public void CategoryInfo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            try
            {
                frmErrorReporter objErrorReporter = new frmErrorReporter(e.PropertyName);
                objErrorReporter.MdiParent = this;
                objErrorReporter.Show();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI38:" + ex.Message;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI39:" + ex.Message;
            }
        }

        private void lblQuickLaunch_Click(object sender, EventArgs e)
        {
            ucQuickLaunch1.Visible = (!ucQuickLaunch1.Visible && true);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                base.Close();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI40:" + ex.Message;
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                base.LayoutMdi(MdiLayout.Cascade);
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI41:" + ex.Message;
            }
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                base.LayoutMdi(MdiLayout.TileVertical);
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI42:" + ex.Message;
            }
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                base.LayoutMdi(MdiLayout.TileHorizontal);
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI43:" + ex.Message;
            }
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                base.LayoutMdi(MdiLayout.ArrangeIcons);
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI44:" + ex.Message;
            }
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form[] mdiChildren = base.MdiChildren;
                foreach (Form childForm in mdiChildren)
                {
                    childForm.Close();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI45:" + ex.Message;
            }
        }

        private void employeeCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployeeCreation frm = new frmEmployeeCreation();
                frmEmployeeCreation open = Application.OpenForms["frmEmployeeCreation"] as frmEmployeeCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI46:" + ex.Message;
            }
        }

        private void salaryPackageCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalaryPackageCreation frm = new frmSalaryPackageCreation();
                frmSalaryPackageCreation open = Application.OpenForms["frmSalaryPackageCreation"] as frmSalaryPackageCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI47:" + ex.Message;
            }
        }

        private void advancePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmAdvancePayment))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    string strVoucherType = "Advance Payment";
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.CallFromVoucherMenu(strVoucherType);
                    }
                    else
                    {
                        open.CallFromVoucherMenu(strVoucherType);
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI48:" + ex.Message;
            }
        }

        private void employeeRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployeeRegister frmEmployeeRegister = new frmEmployeeRegister();
                frmEmployeeRegister open = Application.OpenForms["frmEmployeeRegister"] as frmEmployeeRegister;
                if (open == null)
                {
                    frmEmployeeRegister.MdiParent = this;
                    frmEmployeeRegister.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI49:" + ex.Message;
            }
        }

        private void mmAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                frmAttendance objAttendance = new frmAttendance();
                frmAttendance open = Application.OpenForms["frmAttendance"] as frmAttendance;
                if (open == null)
                {
                    objAttendance.MdiParent = this;
                    objAttendance.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI50:" + ex.Message;
            }
        }

        private void mmadvanceRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdvanceRegister objAdvanceRegister = new frmAdvanceRegister();
                frmAdvanceRegister open = Application.OpenForms["frmAdvanceRegister"] as frmAdvanceRegister;
                if (open == null)
                {
                    objAdvanceRegister.MdiParent = this;
                    objAdvanceRegister.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI51:" + ex.Message;
            }
        }

        private void monthlySalarySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMonthlySalarySettings objMonthlySalarySettings = new frmMonthlySalarySettings();
                frmMonthlySalarySettings open = Application.OpenForms["frmMonthlySalarySettings"] as frmMonthlySalarySettings;
                if (open == null)
                {
                    objMonthlySalarySettings.MdiParent = this;
                    objMonthlySalarySettings.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI52:" + ex.Message;
            }
        }

        private void frmMonthlySalaryVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmMonthlySalaryVoucher))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    string strVoucherType = "Monthly Salary Voucher";
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.CallFromVoucherMenu(strVoucherType);
                    }
                    else
                    {
                        open.CallFromVoucherMenu(strVoucherType);
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI53:" + ex.Message;
            }
        }

        private void holidaySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHolydaySettings frm = new frmHolydaySettings();
                frmHolydaySettings open = Application.OpenForms["frmHolydaySettings"] as frmHolydaySettings;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI54:" + ex.Message;
            }
        }

        private void bonusDeductionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmBonusDeduction frm = new frmBonusDeduction();
                frmBonusDeduction open = Application.OpenForms["frmBonusDeduction"] as frmBonusDeduction;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI55:" + ex.Message;
            }
        }

        private void bonusDeductionRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmBonusDeductionRegister frm = new frmBonusDeductionRegister();
                frmBonusDeductionRegister open = Application.OpenForms["frmBonusDeductionRegister"] as frmBonusDeductionRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI56:" + ex.Message;
            }
        }

        private void accountGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountGroup frm = new frmAccountGroup();
                frmAccountGroup open = Application.OpenForms["frmAccountGroup"] as frmAccountGroup;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI57:" + ex.Message;
            }
        }

        private void productGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductGroup frm = new frmProductGroup();
                frmProductGroup open = Application.OpenForms["frmProductGroup"] as frmProductGroup;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI58:" + ex.Message;
            }
        }

        private void multipleAccountLedgersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmmultipleAccountLedger frm = new frmmultipleAccountLedger();
                frmmultipleAccountLedger open = Application.OpenForms["frmmultipleAccountLedger"] as frmmultipleAccountLedger;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI59:" + ex.Message;
            }
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBatch frm = new frmBatch();
                frmBatch open = Application.OpenForms["frmBatch"] as frmBatch;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI60:" + ex.Message;
            }
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrand frm = new frmBrand();
                frmBrand open = Application.OpenForms["frmBrand"] as frmBrand;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI61:" + ex.Message;
            }
        }

        private void modelNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModalNo frm = new frmModalNo();
                frmModalNo open = Application.OpenForms["frmModalNo"] as frmModalNo;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI62:" + ex.Message;
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSize frm = new frmSize();
                frmSize open = Application.OpenForms["frmSize"] as frmSize;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI63:" + ex.Message;
            }
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUnit frm = new frmUnit();
                frmUnit open = Application.OpenForms["frmUnit"] as frmUnit;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI64:" + ex.Message;
            }
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCurrency frm = new frmCurrency();
                frmCurrency open = Application.OpenForms["frmCurrency"] as frmCurrency;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI65:" + ex.Message;
            }
        }

        private void exchangeRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmExchangeRate frm = new frmExchangeRate();
                frmExchangeRate open = Application.OpenForms["frmExchangeRate"] as frmExchangeRate;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI66:" + ex.Message;
            }
        }

        private void godownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGodown frm = new frmGodown();
                frmGodown open = Application.OpenForms["frmGodown"] as frmGodown;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI67:" + ex.Message;
            }
        }

        private void multipleProductCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMultipleProductCreation frm = new frmMultipleProductCreation();
                frmMultipleProductCreation open = Application.OpenForms["frmMultipleProductCreation"] as frmMultipleProductCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI68:" + ex.Message;
            }
        }

        private void priceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPriceList frm = new frmPriceList();
                frmPriceList open = Application.OpenForms["frmPriceList"] as frmPriceList;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI69:" + ex.Message;
            }
        }

        private void pricingLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPricingLevel frm = new frmPricingLevel();
                frmPricingLevel open = Application.OpenForms["frmPricingLevel"] as frmPricingLevel;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI70:" + ex.Message;
            }
        }

        private void productRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductRegister frm = new frmProductRegister();
                frmProductRegister open = Application.OpenForms["frmProductRegister"] as frmProductRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI71:" + ex.Message;
            }
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRack frm = new frmRack();
                frmRack open = Application.OpenForms["frmRack"] as frmRack;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI72:" + ex.Message;
            }
        }

        private void serviceCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServiceCategory frm = new frmServiceCategory();
                frmServiceCategory open = Application.OpenForms["frmServiceCategory"] as frmServiceCategory;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI73:" + ex.Message;
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServices frm = new frmServices();
                frmServices open = Application.OpenForms["frmServices"] as frmServices;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI74:" + ex.Message;
            }
        }

        private void standardRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmStandardRate frm = new frmStandardRate();
                frmStandardRate open = Application.OpenForms["frmStandardRate"] as frmStandardRate;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI75:" + ex.Message;
            }
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTax frm = new frmTax();
                frmTax open = Application.OpenForms["frmTax"] as frmTax;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI76:" + ex.Message;
            }
        }

        private void voucherTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVoucherType frm = new frmVoucherType();
                frmVoucherType open = Application.OpenForms["frmVoucherType"] as frmVoucherType;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI77:" + ex.Message;
            }
        }

        private void accountLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountLedger frm = new frmAccountLedger();
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI78:" + ex.Message;
            }
        }

        private void dailySalaryRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDailySalaryRegister frm = new frmDailySalaryRegister();
                frmDailySalaryRegister open = Application.OpenForms["frmDailySalaryRegister"] as frmDailySalaryRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI79:" + ex.Message;
            }
        }

        private void DailySalaryVouchertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsActivate = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmDailySalaryVoucher))
                    {
                        openForm.Activate();
                        IsActivate = true;
                        if (openForm.WindowState == FormWindowState.Minimized)
                        {
                            openForm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    string strVoucherType = "Daily Salary Voucher";
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.CallFromVoucherMenu(strVoucherType);
                    }
                    else
                    {
                        open.CallFromVoucherMenu(strVoucherType);
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI80:" + ex.Message;
            }
        }

        private void salaryPackageRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalaryPackageRegister frm = new frmSalaryPackageRegister();
                frmSalaryPackageRegister open = Application.OpenForms["frmSalaryPackageRegister"] as frmSalaryPackageRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI81:" + ex.Message;
            }
        }

        private void monthlySalaryRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMonthlySalaryRegister frm = new frmMonthlySalaryRegister();
                frmMonthlySalaryRegister open = Application.OpenForms["frmMonthlySalaryRegister"] as frmMonthlySalaryRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI82:" + ex.Message;
            }
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmArea frm = new frmArea();
                frmArea open = Application.OpenForms["frmArea"] as frmArea;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI83:" + ex.Message;
            }
        }

        private void counterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCounter frm = new frmCounter();
                frmCounter open = Application.OpenForms["frmCounter"] as frmCounter;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI84:" + ex.Message;
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomer frm = new frmCustomer();
                frmCustomer open = Application.OpenForms["frmCustomer"] as frmCustomer;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI85:" + ex.Message;
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSupplier frm = new frmSupplier();
                frmSupplier open = Application.OpenForms["frmSupplier"] as frmSupplier;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI86:" + ex.Message;
            }
        }

        private void productCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductCreation frm = new frmProductCreation();
                frmProductCreation open = Application.OpenForms["frmProductCreation"] as frmProductCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI87:" + ex.Message;
            }
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRoute frm = new frmRoute();
                frmRoute open = Application.OpenForms["frmRoute"] as frmRoute;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI88:" + ex.Message;
            }
        }

        private void salesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalesman frm = new frmSalesman();
                frmSalesman open = Application.OpenForms["frmSalesman"] as frmSalesman;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI89:" + ex.Message;
            }
        }

        private void productBomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductBom frm = new frmProductBom();
                frmProductBom open = Application.OpenForms["frmProductBom"] as frmProductBom;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI90:" + ex.Message;
            }
        }

        private void productMultipleUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductMultipleUnit frm = new frmProductMultipleUnit();
                frmProductMultipleUnit open = Application.OpenForms["frmProductMultipleUnit"] as frmProductMultipleUnit;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI91:" + ex.Message;
            }
        }

        private void designationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmDesignation frm = new frmDesignation();
                frmDesignation open = Application.OpenForms["frmDesignation"] as frmDesignation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI92:" + ex.Message;
            }
        }

        private void payHeadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPayHead frm = new frmPayHead();
                frmPayHead open = Application.OpenForms["frmPayHead"] as frmPayHead;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI93:" + ex.Message;
            }
        }

        private void contraVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ContraVoucherClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI94:" + ex.Message;
            }
        }

        private void paymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentVoucherClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI95:" + ex.Message;
            }
        }

        private void pdcPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PDCPayableClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI96:" + ex.Message;
            }
        }

        private void receiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReceiptVoucherClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI97:" + ex.Message;
            }
        }

        private void journalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                JournalVoucherClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI98:" + ex.Message;
            }
        }

        private void pdcReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PDCReceivableClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI99:" + ex.Message;
            }
        }

        private void bankReconciliationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankReconciliation frm = new frmBankReconciliation();
                frmBankReconciliation open = Application.OpenForms["frmBankReconciliation"] as frmBankReconciliation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI100:" + ex.Message;
            }
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrderClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI101:" + ex.Message;
            }
        }

        private void materialRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialReceiptClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI102:" + ex.Message;
            }
        }

        private void rejectionOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RejectionOutClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI103:" + ex.Message;
            }
        }

        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseInvoiceClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI104:" + ex.Message;
            }
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseReturnClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI105:" + ex.Message;
            }
        }

        private void salesQuatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesQuotationClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI106:" + ex.Message;
            }
        }

        private void salesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesOrderClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI107:" + ex.Message;
            }
        }

        private void rejectionInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RejectionInClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI108:" + ex.Message;
            }
        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesInvoiceClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI109:" + ex.Message;
            }
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesReturnClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI110:" + ex.Message;
            }
        }

        private void physicalStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PhysicalStockClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI111:" + ex.Message;
            }
        }

        private void serviceVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceVoucherClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI112:" + ex.Message;
            }
        }

        private void creditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CreditNoteClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI113:" + ex.Message;
            }
        }

        private void debitNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DebitNoteClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI114:" + ex.Message;
            }
        }

        private void partyBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPartyBalance frm = new frmPartyBalance();
                frmPartyBalance open = Application.OpenForms["frmPartyBalance"] as frmPartyBalance;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI115:" + ex.Message;
            }
        }

        private void createCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PublicVariables._decCurrentCompanyId = 0m;
                PublicVariables._dtFromDate = Convert.ToDateTime("01-Jan-0001");
                PublicVariables._dtToDate = Convert.ToDateTime("31-Dec-9999");
                List<Form> openForms = new List<Form>();
                foreach (Form openForm in Application.OpenForms)
                {
                    openForms.Add(openForm);
                }
                foreach (Form item in openForms)
                {
                    if (item.Name != "formMDI")
                    {
                        item.Close();
                    }
                }
                frmCompanyCreation frm = new frmCompanyCreation();
                frmCompanyCreation open = Application.OpenForms["frmCompanyCreation"] as frmCompanyCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI116:" + ex.Message;
            }
        }

        private void paySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPaySlip objPaySlip = new frmPaySlip();
                frmPaySlip open = Application.OpenForms["frmPaySlip"] as frmPaySlip;
                if (open == null)
                {
                    objPaySlip.MdiParent = this;
                    objPaySlip.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI117:" + ex.Message;
            }
        }

        private void ContraRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmContraRegister", "View"))
                {
                    frmContraRegister objContraRegister = new frmContraRegister();
                    frmContraRegister open = Application.OpenForms["frmContraRegister"] as frmContraRegister;
                    if (open == null)
                    {
                        objContraRegister.MdiParent = this;
                        objContraRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI118:" + ex.Message;
            }
        }

        private void paymentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPaymentRegister", "View"))
                {
                    frmPaymentRegister objPaymentRegister = new frmPaymentRegister();
                    frmPaymentRegister open = Application.OpenForms["frmPaymentRegister"] as frmPaymentRegister;
                    if (open == null)
                    {
                        objPaymentRegister.MdiParent = this;
                        objPaymentRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI119:" + ex.Message;
            }
        }

        private void receiptRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmReceiptRegister", "View"))
                {
                    frmReceiptRegister objReceiptRegister = new frmReceiptRegister();
                    frmReceiptRegister open = Application.OpenForms["frmReceiptRegister"] as frmReceiptRegister;
                    if (open == null)
                    {
                        objReceiptRegister.MdiParent = this;
                        objReceiptRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI120:" + ex.Message;
            }
        }

        private void journalRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmJournalRegister", "View"))
                {
                    frmJournalRegister objJournalRegister = new frmJournalRegister();
                    frmJournalRegister open = Application.OpenForms["frmJournalRegister"] as frmJournalRegister;
                    if (open == null)
                    {
                        objJournalRegister.MdiParent = this;
                        objJournalRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI121:" + ex.Message;
            }
        }

        private void PDCPayableRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCPayableRegister", "View"))
                {
                    frmPDCPayableRegister objPDCPayableRegister = new frmPDCPayableRegister();
                    frmPDCPayableRegister open = Application.OpenForms["frmPDCPayableRegister"] as frmPDCPayableRegister;
                    if (open == null)
                    {
                        objPDCPayableRegister.MdiParent = this;
                        objPDCPayableRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI122:" + ex.Message;
            }
        }

        private void PDCReceivableRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCReceivableRegister", "View"))
                {
                    frmPDCReceivableRegister objPDCReceivableRegister = new frmPDCReceivableRegister();
                    frmPDCReceivableRegister open = Application.OpenForms["frmPDCReceivableRegister"] as frmPDCReceivableRegister;
                    if (open == null)
                    {
                        objPDCReceivableRegister.MdiParent = this;
                        objPDCReceivableRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI123:" + ex.Message;
            }
        }

        private void materialReceiptRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMaterialReceiptRegister", "View"))
                {
                    frmMaterialReceiptRegister objMaterialReceiptRegister = new frmMaterialReceiptRegister();
                    frmMaterialReceiptRegister open = Application.OpenForms["frmMaterialReceiptRegister"] as frmMaterialReceiptRegister;
                    if (open == null)
                    {
                        objMaterialReceiptRegister.MdiParent = this;
                        objMaterialReceiptRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI124:" + ex.Message;
            }
        }

        private void rejectionOutRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionOutRegister", "View"))
                {
                    frmRejectionOutRegister objRejectionOutRegister = new frmRejectionOutRegister();
                    frmRejectionOutRegister open = Application.OpenForms["frmRejectionOutRegister"] as frmRejectionOutRegister;
                    if (open == null)
                    {
                        objRejectionOutRegister.MdiParent = this;
                        objRejectionOutRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI125:" + ex.Message;
            }
        }

        private void purchaseInvoiceRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPurchaseInvoiceRegister objPurchaseInvoiceRegister = new frmPurchaseInvoiceRegister();
                frmPurchaseInvoiceRegister open = Application.OpenForms["frmPurchaseInvoiceRegister"] as frmPurchaseInvoiceRegister;
                if (open == null)
                {
                    objPurchaseInvoiceRegister.MdiParent = this;
                    objPurchaseInvoiceRegister.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI126:" + ex.Message;
            }
        }

        private void purchaseReturnRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseReturnRegister", "View"))
                {
                    frmPurchaseReturnRegister objPurchaseReturnRegister = new frmPurchaseReturnRegister();
                    frmPurchaseReturnRegister open = Application.OpenForms["frmPurchaseReturnRegister"] as frmPurchaseReturnRegister;
                    if (open == null)
                    {
                        objPurchaseReturnRegister.MdiParent = this;
                        objPurchaseReturnRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI127:" + ex.Message;
            }
        }

        private void salesQuotationRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesQuotationRegister", "View"))
                {
                    frmSalesQuotationRegister objSalesQuotationRegister = new frmSalesQuotationRegister();
                    frmSalesQuotationRegister open = Application.OpenForms["frmSalesQuotationRegister"] as frmSalesQuotationRegister;
                    if (open == null)
                    {
                        objSalesQuotationRegister.MdiParent = this;
                        objSalesQuotationRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI128:" + ex.Message;
            }
        }

        private void salesOrderRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesOrderRegister", "View"))
                {
                    frmSalesOrderRegister objSalesOrderRegister = new frmSalesOrderRegister();
                    frmSalesOrderRegister open = Application.OpenForms["frmSalesOrderRegister"] as frmSalesOrderRegister;
                    if (open == null)
                    {
                        objSalesOrderRegister.MdiParent = this;
                        objSalesOrderRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI129:" + ex.Message;
            }
        }

        private void deliveryNoteRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDeliveryNoteRegister", "View"))
                {
                    frmDeliveryNoteRegister objDeliveryNoteRegister = new frmDeliveryNoteRegister();
                    frmDeliveryNoteRegister open = Application.OpenForms["frmDeliveryNoteRegister"] as frmDeliveryNoteRegister;
                    if (open == null)
                    {
                        objDeliveryNoteRegister.MdiParent = this;
                        objDeliveryNoteRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI130:" + ex.Message;
            }
        }

        private void rejectionInRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionInRegister", "View"))
                {
                    frmRejectionInRegister objRejectionInRegister = new frmRejectionInRegister();
                    frmRejectionInRegister open = Application.OpenForms["frmRejectionInRegister"] as frmRejectionInRegister;
                    if (open == null)
                    {
                        objRejectionInRegister.MdiParent = this;
                        objRejectionInRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI131:" + ex.Message;
            }
        }

        private void salesInvoiceRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesInvoiceRegister", "View"))
                {
                    frmSalesInvoiceRegister objSalesInvoiceRegister = new frmSalesInvoiceRegister();
                    frmSalesInvoiceRegister open = Application.OpenForms["frmSalesInvoiceRegister"] as frmSalesInvoiceRegister;
                    if (open == null)
                    {
                        objSalesInvoiceRegister.MdiParent = this;
                        objSalesInvoiceRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI132:" + ex.Message;
            }
        }

        private void salesReturnRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesReturnRegister", "View"))
                {
                    frmSalesReturnRegister objSalesReturnRegister = new frmSalesReturnRegister();
                    frmSalesReturnRegister open = Application.OpenForms["frmSalesReturnRegister"] as frmSalesReturnRegister;
                    if (open == null)
                    {
                        objSalesReturnRegister.MdiParent = this;
                        objSalesReturnRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI133:" + ex.Message;
            }
        }

        private void physicalStockRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPhysicalStockRegister", "View"))
                {
                    frmPhysicalStockRegister objPhysicalStockRegister = new frmPhysicalStockRegister();
                    frmPhysicalStockRegister open = Application.OpenForms["frmPhysicalStockRegister"] as frmPhysicalStockRegister;
                    if (open == null)
                    {
                        objPhysicalStockRegister.MdiParent = this;
                        objPhysicalStockRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI134:" + ex.Message;
            }
        }

        private void serviceVoucherRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmServiceVoucherRegister", "View"))
                {
                    frmServiceVoucherRegister objServiceVoucherRegister = new frmServiceVoucherRegister();
                    frmServiceVoucherRegister open = Application.OpenForms["frmServiceVoucherRegister"] as frmServiceVoucherRegister;
                    if (open == null)
                    {
                        objServiceVoucherRegister.MdiParent = this;
                        objServiceVoucherRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI135:" + ex.Message;
            }
        }

        private void creditNoteRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCreditNoteRegister", "View"))
                {
                    frmCreditNoteRegister objCreditNoteRegister = new frmCreditNoteRegister();
                    frmCreditNoteRegister open = Application.OpenForms["frmCreditNoteRegister"] as frmCreditNoteRegister;
                    if (open == null)
                    {
                        objCreditNoteRegister.MdiParent = this;
                        objCreditNoteRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI136:" + ex.Message;
            }
        }

        private void debitNoteRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDebitNoteRegister", "View"))
                {
                    frmDebitNoteRegister objDebitNoteRegister = new frmDebitNoteRegister();
                    frmDebitNoteRegister open = Application.OpenForms["frmDebitNoteRegister"] as frmDebitNoteRegister;
                    if (open == null)
                    {
                        objDebitNoteRegister.MdiParent = this;
                        objDebitNoteRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI137:" + ex.Message;
            }
        }

        private void stockJournalRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStockJournalRegister", "View"))
                {
                    frmStockJournalRegister objStockJournalRegister = new frmStockJournalRegister();
                    frmStockJournalRegister open = Application.OpenForms["frmStockJournalRegister"] as frmStockJournalRegister;
                    if (open == null)
                    {
                        objStockJournalRegister.MdiParent = this;
                        objStockJournalRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI138:" + ex.Message;
            }
        }

        private void stockJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StockJournalClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI139:" + ex.Message;
            }
        }

        private void barcodePrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmBarcodePrinting", "View"))
                {
                    frmBarcodePrinting objBarcodePrinting = new frmBarcodePrinting();
                    frmBarcodePrinting open = Application.OpenForms["frmBarcodePrinting"] as frmBarcodePrinting;
                    if (open == null)
                    {
                        objBarcodePrinting.MdiParent = this;
                        objBarcodePrinting.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI140:" + ex.Message;
            }
        }

        private void bracodeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBarcodeSettings objBracodeSettings = new frmBarcodeSettings();
                frmBarcodeSettings open = Application.OpenForms["frmBarcodeSettings"] as frmBarcodeSettings;
                if (open == null)
                {
                    objBracodeSettings.MdiParent = this;
                    objBracodeSettings.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI141:" + ex.Message;
            }
        }

        private void changeCurrentDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangeCurrentDate objChangeCurrentDate = new frmChangeCurrentDate();
                frmChangeCurrentDate open = Application.OpenForms["frmChangeCurrentDate"] as frmChangeCurrentDate;
                if (open == null)
                {
                    objChangeCurrentDate.MdiParent = this;
                    objChangeCurrentDate.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI142:" + ex.Message;
            }
        }

        private void changeFinancialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangeFinancialYear objChangeFinancialYear = new frmChangeFinancialYear();
                frmChangeFinancialYear open = Application.OpenForms["frmChangeFinancialYear"] as frmChangeFinancialYear;
                if (open == null)
                {
                    objChangeFinancialYear.MdiParent = this;
                    objChangeFinancialYear.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI143:" + ex.Message;
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangePassword objChangePassword = new frmChangePassword();
                frmChangePassword open = Application.OpenForms["frmChangePassword"] as frmChangePassword;
                if (open == null)
                {
                    objChangePassword.MdiParent = this;
                    objChangePassword.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI144:" + ex.Message;
            }
        }

        private void newFinancialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewFinancialYear objNewFinancialYear = new frmNewFinancialYear();
                frmNewFinancialYear open = Application.OpenForms["frmNewFinancialYear"] as frmNewFinancialYear;
                if (open == null)
                {
                    objNewFinancialYear.MdiParent = this;
                    objNewFinancialYear.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI145:" + ex.Message;
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmSettings objSettings = new frmSettings();
                frmSettings open = Application.OpenForms["frmSettings"] as frmSettings;
                if (open == null)
                {
                    objSettings.MdiParent = this;
                    objSettings.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI146:" + ex.Message;
            }
        }

        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserCreation objUserCreation = new frmUserCreation();
                frmUserCreation open = Application.OpenForms["frmUserCreation"] as frmUserCreation;
                if (open == null)
                {
                    objUserCreation.MdiParent = this;
                    objUserCreation.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI147:" + ex.Message;
            }
        }

        private void productSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductSearch", "View"))
                {
                    frmProductSearch objProductSearch = new frmProductSearch();
                    frmProductSearch open = Application.OpenForms["frmProductSearch"] as frmProductSearch;
                    if (open == null)
                    {
                        objProductSearch.MdiParent = this;
                        objProductSearch.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI148:" + ex.Message;
            }
        }

        private void voucherSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmVoucherSearch", "View"))
                {
                    frmVoucherSearch objVoucherSearch = new frmVoucherSearch();
                    frmVoucherSearch open = Application.OpenForms["frmVoucherSearch"] as frmVoucherSearch;
                    if (open == null)
                    {
                        objVoucherSearch.MdiParent = this;
                        objVoucherSearch.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI149:" + ex.Message;
            }
        }

        private void voucherWiseProductSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmVoucherWiseProductSearch", "View"))
                {
                    frmVoucherWiseProductSearch objVoucherWiseProductSearch = new frmVoucherWiseProductSearch();
                    frmVoucherWiseProductSearch open = Application.OpenForms["frmVoucherWiseProductSearch"] as frmVoucherWiseProductSearch;
                    if (open == null)
                    {
                        objVoucherWiseProductSearch.MdiParent = this;
                        objVoucherWiseProductSearch.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI150:" + ex.Message;
            }
        }

        private void overduePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmOverduePurchaseOrder", "View"))
                {
                    frmOverduePurchaseOrder objOverduePurchaseOrder = new frmOverduePurchaseOrder();
                    frmOverduePurchaseOrder open = Application.OpenForms["frmOverduePurchaseOrder"] as frmOverduePurchaseOrder;
                    if (open == null)
                    {
                        objOverduePurchaseOrder.MdiParent = this;
                        objOverduePurchaseOrder.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI151:" + ex.Message;
            }
        }

        private void overdueSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmOverdueSalesOrder", "View"))
                {
                    frmOverdueSalesOrder objOverdueSalesOrder = new frmOverdueSalesOrder();
                    frmOverdueSalesOrder open = Application.OpenForms["frmOverdueSalesOrder"] as frmOverdueSalesOrder;
                    if (open == null)
                    {
                        objOverdueSalesOrder.MdiParent = this;
                        objOverdueSalesOrder.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI152:" + ex.Message;
            }
        }

        private void personalReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPersonalReminder", "Save"))
                {
                    frmPersonalReminder objPersonalReminder = new frmPersonalReminder();
                    frmPersonalReminder open = Application.OpenForms["frmPersonalReminder"] as frmPersonalReminder;
                    if (open == null)
                    {
                        objPersonalReminder.MdiParent = this;
                        objPersonalReminder.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI153:" + ex.Message;
            }
        }

        private void shortExpiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmShortExpiry", "View"))
                {
                    frmShortExpiry objShortExpiry = new frmShortExpiry();
                    frmShortExpiry open = Application.OpenForms["frmShortExpiry"] as frmShortExpiry;
                    if (open == null)
                    {
                        objShortExpiry.MdiParent = this;
                        objShortExpiry.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI154:" + ex.Message;
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStock", "View"))
                {
                    frmStock objStock = new frmStock();
                    frmStock open = Application.OpenForms["frmStock"] as frmStock;
                    if (open == null)
                    {
                        objStock.MdiParent = this;
                        objStock.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI155:" + ex.Message;
            }
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateToolStripMenuItem.Text != string.Empty)
                {
                    changeCurrentDateToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI156:" + ex.Message;
            }
        }

        private void editCompanyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCompanyCreation frm = new frmCompanyCreation();
                frmCompanyCreation open = Application.OpenForms["frmCompanyCreation"] as frmCompanyCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                    frm.CompanyViewForEdit();
                }
                else
                {
                    open.Activate();
                    open.CompanyViewForEdit();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI157:" + ex.Message;
            }
        }

        private void rolePrivileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRolePrivilegeSettings frm = new frmRolePrivilegeSettings();
                frmRolePrivilegeSettings open = Application.OpenForms["frmRolePrivilegeSettings"] as frmRolePrivilegeSettings;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI158:" + ex.Message;
            }
        }

        private void budgetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBudget frm = new frmBudget();
                frmBudget open = Application.OpenForms["frmBudget"] as frmBudget;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI159:" + ex.Message;
            }
        }

        private void budgetVarianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBudgetVariance frm = new frmBudgetVariance();
                frmBudgetVariance open = Application.OpenForms["frmBudgetVariance"] as frmBudgetVariance;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI160:" + ex.Message;
            }
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRole frm = new frmRole();
                frmRole open = Application.OpenForms["frmRole"] as frmRole;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI161:" + ex.Message;
            }
        }

        private void employeeAddressBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmEmployeeAddressBook", "View"))
                {
                    frmEmployeeAddressBook frmEmployeeAddressBookObj = new frmEmployeeAddressBook();
                    frmEmployeeAddressBook open = Application.OpenForms["frmEmployeeAddressBook"] as frmEmployeeAddressBook;
                    if (open == null)
                    {
                        frmEmployeeAddressBookObj.MdiParent = this;
                        frmEmployeeAddressBookObj.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI162:" + ex.Message;
            }
        }

        private void payheadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPayHeadReport", "View"))
                {
                    frmPayHeadReport frm = new frmPayHeadReport();
                    frmPayHeadReport open = Application.OpenForms["frmPayHeadReport"] as frmPayHeadReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI163:" + ex.Message;
            }
        }

        private void dailySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDailySalaryReport", "View"))
                {
                    frmDailySalaryReport frm = new frmDailySalaryReport();
                    frmDailySalaryReport open = Application.OpenForms["frmDailySalaryReport"] as frmDailySalaryReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI164:" + ex.Message;
            }
        }

        private void changeProductTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangeProductTax frm = new frmChangeProductTax();
                frmChangeProductTax open = Application.OpenForms["frmChangeProductTax"] as frmChangeProductTax;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI165:" + ex.Message;
            }
        }

        private void suffixPrefixSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSuffixPrefixSettings frm = new frmSuffixPrefixSettings();
                frmSuffixPrefixSettings open = Application.OpenForms["frmSuffixPrefixSettings"] as frmSuffixPrefixSettings;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI166:" + ex.Message;
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmEmployeeReport", "View"))
                {
                    frmEmployeeReport frm = new frmEmployeeReport();
                    frmEmployeeReport open = Application.OpenForms["frmEmployeeReport"] as frmEmployeeReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI167:" + ex.Message;
            }
        }

        private void dailyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDailyAttendanceReport", "View"))
                {
                    frmDailyAttendanceReport frm = new frmDailyAttendanceReport();
                    frmDailyAttendanceReport open = Application.OpenForms["frmDailyAttendanceReport"] as frmDailyAttendanceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI168:" + ex.Message;
            }
        }

        private void monthlyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMonthlyAttendanceReport", "View"))
                {
                    frmMonthlyAttendanceReport frm = new frmMonthlyAttendanceReport();
                    frmMonthlyAttendanceReport open = Application.OpenForms["frmMonthlyAttendanceReport"] as frmMonthlyAttendanceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI169:" + ex.Message;
            }
        }

        private void monthlySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMonthlySalaryReport", "View"))
                {
                    frmMonthlySalaryReport frm = new frmMonthlySalaryReport();
                    frmMonthlySalaryReport open = Application.OpenForms["frmMonthlySalaryReport"] as frmMonthlySalaryReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI170:" + ex.Message;
            }
        }

        private void advancePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAdvancePaymentReport", "View"))
                {
                    frmAdvancePaymentReport frm = new frmAdvancePaymentReport();
                    frmAdvancePaymentReport open = Application.OpenForms["frmAdvancePaymentReport"] as frmAdvancePaymentReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI171:" + ex.Message;
            }
        }

        private void bonusDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmBonusDeductionReport", "View"))
                {
                    frmBonusDeductionReport frm = new frmBonusDeductionReport();
                    frmBonusDeductionReport open = Application.OpenForms["frmBonusDeductionReport"] as frmBonusDeductionReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI172:" + ex.Message;
            }
        }

        private void dayBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDayBook", "View"))
                {
                    frmDayBook frm = new frmDayBook();
                    frmDayBook open = Application.OpenForms["frmDayBook"] as frmDayBook;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI173:" + ex.Message;
            }
        }

        private void cashBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCashBankBook", "View"))
                {
                    frmCashBankBookReport frm = new frmCashBankBookReport();
                    frmCashBankBookReport open = Application.OpenForms["frmCashBankBookReport"] as frmCashBankBookReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI174:" + ex.Message;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountLedgerReport", "View"))
                {
                    frmAccountLedgerReport frm = new frmAccountLedgerReport();
                    frmAccountLedgerReport open = Application.OpenForms["frmAccountLedgerReport"] as frmAccountLedgerReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI175:" + ex.Message;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmOutstandingReport", "View"))
                {
                    frmOutstandingReport frm = new frmOutstandingReport();
                    frmOutstandingReport open = Application.OpenForms["frmOutstandingReport"] as frmOutstandingReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI176:" + ex.Message;
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAgeingReport", "View"))
                {
                    frmAgeingReport frm = new frmAgeingReport();
                    frmAgeingReport open = Application.OpenForms["frmAgeingReport"] as frmAgeingReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI177:" + ex.Message;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountGroupwiseReport", "View"))
                {
                    frmAccountGroupReport frm = new frmAccountGroupReport();
                    frmAccountGroupReport open = Application.OpenForms["frmAccountGroupReport"] as frmAccountGroupReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI178:" + ex.Message;
            }
        }

        private void salaryPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalaryPackageReport", "View"))
                {
                    frmSalaryPackageReport frm = new frmSalaryPackageReport();
                    frmSalaryPackageReport open = Application.OpenForms["frmSalaryPackageReport"] as frmSalaryPackageReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI179:" + ex.Message;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.Count > 2)
                {
                    string strForm = (Application.OpenForms.Count - 2 == 1) ? " form." : " froms.";
                    if (MessageBox.Show("You are about to close " + (Application.OpenForms.Count - 2).ToString() + strForm + " Are you sure to exit? ", "Openmiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                else if (Messages.CloseConfirmation())
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI180:" + ex.Message;
            }
        }

        private void salaryPackageDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalaryPackageDetailsReport", "View"))
                {
                    frmSalaryPackageDetailsReport frm = new frmSalaryPackageDetailsReport();
                    frmSalaryPackageDetailsReport open = Application.OpenForms["frmSalaryPackageDetailsReport"] as frmSalaryPackageDetailsReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI181:" + ex.Message;
            }
        }

        private void frmPurchaseOrderRegistertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseOrderRegister", "View"))
                {
                    frmPurchaseOrderRegister frm = new frmPurchaseOrderRegister();
                    frmPurchaseOrderRegister open = Application.OpenForms["frmPurchaseOrderRegister"] as frmPurchaseOrderRegister;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI182:" + ex.Message;
            }
        }

        private void PDCClearanceRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPdcClearanceRegister", "View"))
                {
                    frmPdcClearanceRegister frm = new frmPdcClearanceRegister();
                    frmPdcClearanceRegister open = Application.OpenForms["frmPdcClearanceRegister"] as frmPdcClearanceRegister;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI183:" + ex.Message;
            }
        }

        private void contraReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmContraReport", "View"))
                {
                    frmContraReport frm = new frmContraReport();
                    frmContraReport open = Application.OpenForms["frmContraReport"] as frmContraReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI184:" + ex.Message;
            }
        }

        private void paymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPaymentReport", "View"))
                {
                    frmPaymentReport frm = new frmPaymentReport();
                    frmPaymentReport open = Application.OpenForms["frmPaymentReport"] as frmPaymentReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI185:" + ex.Message;
            }
        }

        private void creditNoteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCreditNoteReport", "View"))
                {
                    frmCreditNoteReport frm = new frmCreditNoteReport();
                    frmCreditNoteReport open = Application.OpenForms["frmCreditNoteReport"] as frmCreditNoteReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI186:" + ex.Message;
            }
        }

        private void debitNoteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDebitNoteReport", "View"))
                {
                    frmDebitNoteReport frm = new frmDebitNoteReport();
                    frmDebitNoteReport open = Application.OpenForms["frmDebitNoteReport"] as frmDebitNoteReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI187:" + ex.Message;
            }
        }

        private void journalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmJournalReport", "View"))
                {
                    frmJournalReport frm = new frmJournalReport();
                    frmJournalReport open = Application.OpenForms["frmJournalReport"] as frmJournalReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI188:" + ex.Message;
            }
        }

        private void pDCClearanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCClearanceReport", "View"))
                {
                    frmPDCClearanceReport frm = new frmPDCClearanceReport();
                    frmPDCClearanceReport open = Application.OpenForms["frmPDCClearanceReport"] as frmPDCClearanceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI189:" + ex.Message;
            }
        }

        private void serviceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmServiceReport", "View"))
                {
                    frmServiceReport frm = new frmServiceReport();
                    frmServiceReport open = Application.OpenForms["frmServiceReport"] as frmServiceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI190:" + ex.Message;
            }
        }

        private void pDCPayableReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCPayableReport", "View"))
                {
                    frmPDCPayableReport frm = new frmPDCPayableReport();
                    frmPDCPayableReport open = Application.OpenForms["frmPDCPayableReport"] as frmPDCPayableReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI191:" + ex.Message;
            }
        }

        private void pDCReceivableReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCReceivableReport", "View"))
                {
                    frmPDCRecievableReport frm = new frmPDCRecievableReport();
                    frmPDCRecievableReport open = Application.OpenForms["frmPDCRecievableReport"] as frmPDCRecievableReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI192:" + ex.Message;
            }
        }

        private void purchaseOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseOrderReport", "View"))
                {
                    frmPurchaseOrderReport frm = new frmPurchaseOrderReport();
                    frmPurchaseOrderReport open = Application.OpenForms["frmPurchaseOrderReport"] as frmPurchaseOrderReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI193:" + ex.Message;
            }
        }

        private void receiptReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmReceiptReport", "View"))
                {
                    frmReceiptReport frmReceptReport = new frmReceiptReport();
                    frmReceiptReport open = Application.OpenForms["frmReceiptReport"] as frmReceiptReport;
                    if (open == null)
                    {
                        frmReceptReport.MdiParent = this;
                        frmReceptReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI194:" + ex.Message;
            }
        }

        private void physicalStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPhysicalStockReport", "View"))
                {
                    frmPhysicalStockReport frm = new frmPhysicalStockReport();
                    frmPhysicalStockReport open = Application.OpenForms["frmPhysicalStockReport"] as frmPhysicalStockReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI195:" + ex.Message;
            }
        }

        private void PartyAddressBooktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPartyAddressBook", "View"))
                {
                    frmPartyAddressBook frm = new frmPartyAddressBook();
                    frmPartyAddressBook open = Application.OpenForms["frmPartyAddressBook"] as frmPartyAddressBook;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI196:" + ex.Message;
            }
        }

        private void PriceListReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPriceListReport", "View"))
                {
                    frmPriceListReport frm = new frmPriceListReport();
                    frmPriceListReport open = Application.OpenForms["frmPriceListReport"] as frmPriceListReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI197:" + ex.Message;
            }
        }

        private void TaxReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmTaxReport", "View"))
                {
                    frmTaxReport frm = new frmTaxReport();
                    frmTaxReport open = Application.OpenForms["frmTaxReport"] as frmTaxReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI198:" + ex.Message;
            }
        }

        private void ChequeReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmChequeReport", "View"))
                {
                    frmChequeReport frm = new frmChequeReport();
                    frmChequeReport open = Application.OpenForms["frmChequeReport"] as frmChequeReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI199:" + ex.Message;
            }
        }

        private void ShortExpiryReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmShortExpiryReport", "View"))
                {
                    frmShortExpiryReport frm = new frmShortExpiryReport();
                    frmShortExpiryReport open = Application.OpenForms["frmShortExpiryReport"] as frmShortExpiryReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI200:" + ex.Message;
            }
        }

        private void ProductStaticstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductStatistics", "View"))
                {
                    frmProductStatistics frm = new frmProductStatistics();
                    frmProductStatistics open = Application.OpenForms["frmProductStatistics"] as frmProductStatistics;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI201:" + ex.Message;
            }
        }

        private void VatReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmVatReturnReport", "View"))
                {
                    frmVatReturnReport frm = new frmVatReturnReport();
                    frmVatReturnReport open = Application.OpenForms["frmVatReturnReport"] as frmVatReturnReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI202:" + ex.Message;
            }
        }

        private void StockReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStockReport", "View"))
                {
                    frmStockReport frm = new frmStockReport();
                    frmStockReport open = Application.OpenForms["frmStockReport"] as frmStockReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI203:" + ex.Message;
            }
        }

        private void freeSaleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmFreeSaleReport", "View"))
                {
                    frmFreeSaleReport frm = new frmFreeSaleReport();
                    frmFreeSaleReport open = Application.OpenForms["frmFreeSaleReport"] as frmFreeSaleReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI204:" + ex.Message;
            }
        }

        private void productVsBatchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductVsBatchReport", "View"))
                {
                    frmProductVsBatchReport frm = new frmProductVsBatchReport();
                    frmProductVsBatchReport open = Application.OpenForms["frmProductVsBatchReport"] as frmProductVsBatchReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI205:" + ex.Message;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to logout ? ", "Openmiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LogOut();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI206:" + ex.Message;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                DeliveryNoteClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI207:" + ex.Message;
            }
        }

        private void pdcClearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PDCClearenceClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI208:" + ex.Message;
            }
        }

        private void purchaseInvoiceRegisterToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseInvoiceRegister", "View"))
                {
                    frmPurchaseInvoiceRegister objPurchaseInvoiceRegister = new frmPurchaseInvoiceRegister();
                    frmPurchaseInvoiceRegister open = Application.OpenForms["frmPurchaseInvoiceRegister"] as frmPurchaseInvoiceRegister;
                    if (open == null)
                    {
                        objPurchaseInvoiceRegister.MdiParent = this;
                        objPurchaseInvoiceRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI209:" + ex.Message;
            }
        }

        private void materialReceiptReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMaterialReceiptReport", "View"))
                {
                    frmMaterialReceiptReport objMaterialReceiptReport = new frmMaterialReceiptReport();
                    frmMaterialReceiptReport open = Application.OpenForms["frmMaterialReceiptReport"] as frmMaterialReceiptReport;
                    if (open == null)
                    {
                        objMaterialReceiptReport.MdiParent = this;
                        objMaterialReceiptReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI210:" + ex.Message;
            }
        }

        private void billAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBillallocation objBillallocation = new frmBillallocation();
                frmBillallocation open = Application.OpenForms["frmBillallocation"] as frmBillallocation;
                if (open == null)
                {
                    objBillallocation.MdiParent = this;
                    objBillallocation.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI211:" + ex.Message;
            }
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Form> openForms = new List<Form>();
                foreach (Form openForm in Application.OpenForms)
                {
                    openForms.Add(openForm);
                }
                foreach (Form item in openForms)
                {
                    if (item.Name != "formMDI")
                    {
                        item.Close();
                    }
                }
                MDIObj = this;
                ucQuickLaunch1.Visible = false;
                lblQuickLaunch.Visible = false;
                //ucCalculator1.Visible = false;
                lblCalculator.Visible = false;
                lblMiracleI.Visible = false;
                PublicVariables._decCurrentCompanyId = 0m;
                MenuStripDisabling();
                companyToolStripMenuItem.Enabled = true;
                editCompanyToolStripMenuItem1.Enabled = false;
                BackUpToolStripMenuItem.Enabled = false;
                RestoreToolStripMenuItem.Enabled = false;
                dateToolStripMenuItem.Enabled = false;
                exitToolStripMenuItem.Enabled = true;
                createCompanyToolStripMenuItem.Enabled = true;
                SelectCompanyToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;
                MDIObj.Text = "Openmiracle";
                CompanySP spCompany = new CompanySP();
                decimal decCompanyCount = spCompany.CompanyCount();
                if (decCompanyCount == 1m)
                {
                    PublicVariables._decCurrentCompanyId = spCompany.CompanyGetIdIfSingleCompany();
                    CurrentDate();
                    frmLogin frmLoginObj2 = new frmLogin();
                    frmLoginObj2.MdiParent = MDIObj;
                    frmLoginObj2.CallFromFormMdi(this);
                }
                else if (decCompanyCount < 1m)
                {
                    CurrentDateBefore();
                    frmCompanyCreation frmCompanyCreationObj = new frmCompanyCreation();
                    frmCompanyCreationObj.MdiParent = MDIObj;
                    frmCompanyCreationObj.CallFromFormMdi();
                }
                else
                {
                    PublicVariables._decCurrentCompanyId = 0m;
                    CompanyPathSP spCompanyPath = new CompanyPathSP();
                    decimal decDefaultCompanyId = spCompanyPath.CompanyViewForDefaultCompany();
                    if (decDefaultCompanyId > 0m)
                    {
                        PublicVariables._decCurrentCompanyId = decDefaultCompanyId;
                        CurrentDate();
                        frmLogin frmLoginObj2 = new frmLogin();
                        frmLoginObj2.MdiParent = MDIObj;
                        frmLoginObj2.CallFromFormMdi(this);
                    }
                    else
                    {
                        CurrentDate();
                        frmSelectCompany frmSelectCompanyObj = new frmSelectCompany();
                        frmSelectCompanyObj.MdiParent = MDIObj;
                        frmSelectCompanyObj.CallFromMdi();
                    }
                }
                CurrentSettings();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI212:" + ex.Message;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCompany", "Close"))
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
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI:213" + ex.Message;
            }
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmTrialBalance", "View"))
                {
                    frmTrialBalance objTrialBalance = new frmTrialBalance();
                    frmTrialBalance open = Application.OpenForms["frmTrialBalance"] as frmTrialBalance;
                    if (open == null)
                    {
                        objTrialBalance.MdiParent = this;
                        objTrialBalance.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI214:" + ex.Message;
            }
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmBalanceSheet", "View"))
                {
                    frmBalanceSheet objBalanceSheet = new frmBalanceSheet();
                    frmBalanceSheet open = Application.OpenForms["frmBalanceSheet"] as frmBalanceSheet;
                    if (open == null)
                    {
                        objBalanceSheet.MdiParent = this;
                        objBalanceSheet.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI215:" + ex.Message;
            }
        }

        private void profitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProfitAndLoss", "View"))
                {
                    frmProfitAndLoss objProfitAndLoss = new frmProfitAndLoss();
                    frmProfitAndLoss open = Application.OpenForms["frmProfitAndLoss"] as frmProfitAndLoss;
                    if (open == null)
                    {
                        objProfitAndLoss.MdiParent = this;
                        objProfitAndLoss.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI216:" + ex.Message;
            }
        }

        private void cashFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCashFlow", "View"))
                {
                    frmCashFlow objCashFlow = new frmCashFlow();
                    frmCashFlow open = Application.OpenForms["frmCashFlow"] as frmCashFlow;
                    if (open == null)
                    {
                        objCashFlow.MdiParent = this;
                        objCashFlow.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI217:" + ex.Message;
            }
        }

        private void fundFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmFundFlow", "View"))
                {
                    frmFundFlow objFundFlow = new frmFundFlow();
                    frmFundFlow open = Application.OpenForms["frmFundFlow"] as frmFundFlow;
                    if (open == null)
                    {
                        objFundFlow.MdiParent = this;
                        objFundFlow.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI218:" + ex.Message;
            }
        }

        private void chartOfAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmChartOfAccount", "View"))
                {
                    frmChartOfAccount objChartOfAccount = new frmChartOfAccount();
                    frmChartOfAccount open = Application.OpenForms["frmChartOfAccount"] as frmChartOfAccount;
                    if (open == null)
                    {
                        objChartOfAccount.MdiParent = this;
                        objChartOfAccount.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI219:" + ex.Message;
            }
        }

        private void stockJournalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStockJournalReport", "View"))
                {
                    frmStockJournelReport objStockJournel = new frmStockJournelReport();
                    frmStockJournelReport open = Application.OpenForms["frmStockJournelReport"] as frmStockJournelReport;
                    if (open == null)
                    {
                        objStockJournel.MdiParent = this;
                        objStockJournel.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI220:" + ex.Message;
            }
        }

        private void salesReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesReturnReport", "View"))
                {
                    frmSalesReturnReport objSalesReturnReport = new frmSalesReturnReport();
                    frmSalesReturnReport open = Application.OpenForms["frmSalesReturnReport"] as frmSalesReturnReport;
                    if (open == null)
                    {
                        objSalesReturnReport.MdiParent = this;
                        objSalesReturnReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI221:" + ex.Message;
            }
        }

        private void salesInvoiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesInvoiceReport", "View"))
                {
                    frmSalesReport objSalesReport = new frmSalesReport();
                    frmSalesReport open = Application.OpenForms["frmSalesReport"] as frmSalesReport;
                    if (open == null)
                    {
                        objSalesReport.MdiParent = this;
                        objSalesReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI222:" + ex.Message;
            }
        }

        private void rejectionOutReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionOutReport", "View"))
                {
                    frmRejectionOutReport objRejectionOutReport = new frmRejectionOutReport();
                    frmRejectionOutReport open = Application.OpenForms["frmRejectionOutReport"] as frmRejectionOutReport;
                    if (open == null)
                    {
                        objRejectionOutReport.MdiParent = this;
                        objRejectionOutReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI223:" + ex.Message;
            }
        }

        private void purchaseInvoiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseInvoiceReport", "View"))
                {
                    frmPurchaseReport objPurchaseReport = new frmPurchaseReport();
                    frmPurchaseReport open = Application.OpenForms["frmPurchaseReport"] as frmPurchaseReport;
                    if (open == null)
                    {
                        objPurchaseReport.MdiParent = this;
                        objPurchaseReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI224:" + ex.Message;
            }
        }

        private void purchaseReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseReturnReport", "View"))
                {
                    frmPurchaseReturnReport objPurchaseReturnReport = new frmPurchaseReturnReport();
                    frmPurchaseReturnReport open = Application.OpenForms["frmPurchaseReturnReport"] as frmPurchaseReturnReport;
                    if (open == null)
                    {
                        objPurchaseReturnReport.MdiParent = this;
                        objPurchaseReturnReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI225:" + ex.Message;
            }
        }

        private void salesQuotationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesQuotationReport", "View"))
                {
                    frmSalesQuotationReport objSalesQuotationReport = new frmSalesQuotationReport();
                    frmSalesQuotationReport open = Application.OpenForms["frmSalesQuotationReport"] as frmSalesQuotationReport;
                    if (open == null)
                    {
                        objSalesQuotationReport.MdiParent = this;
                        objSalesQuotationReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI226:" + ex.Message;
            }
        }

        private void salesOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesOrderReport", "View"))
                {
                    frmSalesOrderReport objSalesOrderReport = new frmSalesOrderReport();
                    frmSalesOrderReport open = Application.OpenForms["frmSalesOrderReport"] as frmSalesOrderReport;
                    if (open == null)
                    {
                        objSalesOrderReport.MdiParent = this;
                        objSalesOrderReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI227:" + ex.Message;
            }
        }

        private void deliveryNoteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDeliveryNoteReport", "View"))
                {
                    frmDeliveryNoteReport objDeliveryNoteReport = new frmDeliveryNoteReport();
                    frmDeliveryNoteReport open = Application.OpenForms["frmDeliveryNoteReport"] as frmDeliveryNoteReport;
                    if (open == null)
                    {
                        objDeliveryNoteReport.MdiParent = this;
                        objDeliveryNoteReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI228:" + ex.Message;
            }
        }

        private void rejectionInReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionInReport", "View"))
                {
                    frmRejectionInReport objRejectionInReport = new frmRejectionInReport();
                    frmRejectionInReport open = Application.OpenForms["frmRejectionInReport"] as frmRejectionInReport;
                    if (open == null)
                    {
                        objRejectionInReport.MdiParent = this;
                        objRejectionInReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI229:" + ex.Message;
            }
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                POSClick();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI230:" + ex.Message;
            }
        }

        private void dotmatrixPrintDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    frmPrintDesigner objRejectionInReport = new frmPrintDesigner();
            //    frmPrintDesigner open = Application.OpenForms["frmPrintDesigner"] as frmPrintDesigner;
            //    if (open == null)
            //    {
            //        objRejectionInReport.MdiParent = this;
            //        objRejectionInReport.Show();
            //    }
            //    else
            //    {
            //        open.Activate();
            //        if (open.WindowState == FormWindowState.Minimized)
            //        {
            //            open.WindowState = FormWindowState.Normal;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    infoError.ErrorString = "MDI231:" + ex.Message;
            //}
        }

        private void accountGroupWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountGroupwiseReport", "View"))
                {
                    frmAccountGroupwiseReport frm = new frmAccountGroupwiseReport();
                    frmAccountGroupwiseReport open = Application.OpenForms["frmAccountGroupwiseReport"] as frmAccountGroupwiseReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI232:" + ex.Message;
            }
        }

        private void SelectCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectCompany frm = new frmSelectCompany();
                frmSelectCompany open = Application.OpenForms["frmSelectCompany"] as frmSelectCompany;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    frm = open;
                    frm.Activate();
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI233:" + ex.Message;
            }
        }

        private void BackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCompany", "BackUp"))
                {
                    BackupRestore backUpRestoreObj = new BackupRestore();
                    backUpRestoreObj.TakeBackUp();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI234:" + ex.Message;
            }
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCompany", "Restore"))
                {
                    BackupRestore backUpRestoreObj = new BackupRestore();
                    backUpRestoreObj.ReStoreDB();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI235:" + ex.Message;
            }
        }

        private void formMDI_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Alt && e.Shift && e.KeyCode == Keys.Q)
                {
                    frmQueryLogin frm = new frmQueryLogin();
                    frmQueryLogin _isOpen = Application.OpenForms["frmQueryLogin"] as frmQueryLogin;
                    if (_isOpen == null)
                    {
                        frm.WindowState = FormWindowState.Normal;
                        frm.MdiParent = MDIObj;
                        frm.Show();
                    }
                    else
                    {
                        _isOpen.MdiParent = MDIObj;
                        if (_isOpen.WindowState == FormWindowState.Minimized)
                        {
                            _isOpen.WindowState = FormWindowState.Normal;
                        }
                        if (_isOpen.Enabled)
                        {
                            _isOpen.Activate();
                            _isOpen.BringToFront();
                        }
                    }
                    SendKeys.Send("{F10}");
                }
                if (e.Alt && e.Shift && e.KeyCode == Keys.C)
                {
                    DialogResult Confirmation = MessageBox.Show("You may loose your MsSql Server instance configuration integrated with Openmiracle. Do you want to continue ?", "Openmiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (Confirmation == DialogResult.Yes)
                    {
                        SClass ClassS = new SClass();
                        ClassS.UpdateAppConfig("MsSqlServer", string.Empty);
                        ClassS.UpdateAppConfig("ApplicationPath", string.Empty);
                        ClassS.UpdateAppConfig("isServerConnection", string.Empty);
                        Environment.Exit(0);
                    }
                }
                if (e.Alt && e.Shift && e.KeyCode == Keys.F1)
                {
                    string Server = (ConfigurationManager.AppSettings["MsSqlServer"] != null) ? ConfigurationManager.AppSettings["MsSqlServer"].ToString() : "";
                    string UserId = (ConfigurationManager.AppSettings["MsSqlUserId"] != null) ? ConfigurationManager.AppSettings["MsSqlUserId"].ToString() : "";
                    string Password = (ConfigurationManager.AppSettings["MsSqlPassword"] != null) ? ConfigurationManager.AppSettings["MsSqlPassword"].ToString() : "";
                    string Path = (ConfigurationManager.AppSettings["ApplicationPath"] != null) ? ConfigurationManager.AppSettings["ApplicationPath"].ToString() : "";
                    string isServerConnection = (ConfigurationManager.AppSettings["isServerConnection"] != null) ? ConfigurationManager.AppSettings["isServerConnection"].ToString() : "";
                    MessageBox.Show("Server : " + Server + "\nUser Id : " + UserId + "\nPassword : " + Password + "\nPath : " + Path + "\nIsServerConnection :" + isServerConnection);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI236:" + ex.Message;
            }
        }

        private void formMDI_Resize(object sender, EventArgs e)
        {
            try
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType() == typeof(frmMessage))
                    {
                        openForm.Location = new Point(0, MDIObj.Height - 270);
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI237:" + ex.Message;
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("hh.exe", Application.StartupPath + "\\Openmiracle.chm");
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI238:" + ex.Message;
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAboutUs frmAboutUs = new frmAboutUs();
                frmAboutUs _isOpen = Application.OpenForms["frmAboutUs"] as frmAboutUs;
                if (_isOpen == null)
                {
                    frmAboutUs.WindowState = FormWindowState.Normal;
                    frmAboutUs.MdiParent = MDIObj;
                    frmAboutUs.Show();
                }
                else
                {
                    _isOpen.MdiParent = MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    if (_isOpen.Enabled)
                    {
                        _isOpen.Activate();
                        _isOpen.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI239:" + ex.Message;
            }
        }

        private void rebuildIndexingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BackgrndWrkrLoading.RunWorkerAsync();
                frmLoadingObj.ShowDialog();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI240:" + ex.Message;
            }
        }

        private void BackgrndWrkrLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                frmLoadingObj.Close();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI241:" + ex.Message;
            }
        }

        private void BackgrndWrkrLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ExecuteIndex spExicuteIndex = new ExecuteIndex();
                spExicuteIndex.ExicuteIdex();
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI242:" + ex.Message;
            }
        }

        private void ContactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSendMail objfrmSendMail = new frmSendMail();
                frmSendMail open = Application.OpenForms["frmSendMail"] as frmSendMail;
                if (open == null)
                {
                    objfrmSendMail.MdiParent = this;
                    objfrmSendMail.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI243:" + ex.Message;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                ucQuickLaunch1.Visible = (!ucQuickLaunch1.Visible && true);
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI244:" + ex.Message;
            }
        }

        private void formMDI_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                if (base.WindowState == FormWindowState.Maximized)
                {
                    ucQuickLaunch1.Visible = (ucQuickLaunch1.Visible && true);
                }
                else
                {
                    ucQuickLaunch1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI245:" + ex.Message;
            }
        }

        private void miracleSkateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetConnection sclass = new GetConnection();
                using (XmlWriter writer = XmlWriter.Create("Connection.xml"))
                {
                    writer.WriteStartElement("Connection");
                    writer.WriteElementString("conection", sclass.GetCurrentConnctionString());
                    writer.WriteEndElement();
                    writer.Flush();
                }
                if (Process.GetProcessesByName("MiracleSkate").Length == 0)
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = "MiracleSkate.EXE";
                    Process.Start(processStartInfo);
                }
                else
                {
                    MessageBox.Show("Miracle Skate is opend.!", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI246:" + ex.Message;
            }
        }

        private void miracleIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetConnection sclass = new GetConnection();
                using (XmlWriter writer = XmlWriter.Create("Connection.xml"))
                {
                    writer.WriteStartElement("Connection");
                    writer.WriteElementString("conection", sclass.GetCurrentConnctionString());
                    writer.WriteEndElement();
                    writer.Flush();
                }
                if (Process.GetProcessesByName("MiracleI").Length == 0)
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = "MiracleI.EXE";
                    Process.Start(processStartInfo);
                }
                else
                {
                    MessageBox.Show("MiracleI is opend.!", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                infoError.ErrorString = "MDI247:" + ex.Message;
            }
        }

    }

}
