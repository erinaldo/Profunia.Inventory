//using Profunia.Inventory.Desktop.Controls;
using Profunia.Inventory.Desktop.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    partial class formMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       	private void InitializeComponent()
        {
            components = new Container();
           // ComponentResourceManager resources = new ComponentResourceManager(typeof(formMDI));
            menuStrip = new MenuStrip();
            companyToolStripMenuItem = new ToolStripMenuItem();
            createCompanyToolStripMenuItem = new ToolStripMenuItem();
            SelectCompanyToolStripMenuItem = new ToolStripMenuItem();
            editCompanyToolStripMenuItem1 = new ToolStripMenuItem();
            BackUpToolStripMenuItem = new ToolStripMenuItem();
            RestoreToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            mastersToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            accountGroupToolStripMenuItem = new ToolStripMenuItem();
            accountLedgerToolStripMenuItem = new ToolStripMenuItem();
            multipleAccountLedgersToolStripMenuItem = new ToolStripMenuItem();
            productGroupToolStripMenuItem = new ToolStripMenuItem();
            productCreationToolStripMenuItem = new ToolStripMenuItem();
            multipleProductCreationToolStripMenuItem = new ToolStripMenuItem();
            batchToolStripMenuItem = new ToolStripMenuItem();
            brandToolStripMenuItem = new ToolStripMenuItem();
            modelNumberToolStripMenuItem = new ToolStripMenuItem();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            unitToolStripMenuItem = new ToolStripMenuItem();
            godownToolStripMenuItem = new ToolStripMenuItem();
            rackToolStripMenuItem = new ToolStripMenuItem();
            pricingLevelToolStripMenuItem = new ToolStripMenuItem();
            priceListToolStripMenuItem = new ToolStripMenuItem();
            standardRateToolStripMenuItem = new ToolStripMenuItem();
            taxToolStripMenuItem = new ToolStripMenuItem();
            currencyToolStripMenuItem = new ToolStripMenuItem();
            exchangeRateToolStripMenuItem = new ToolStripMenuItem();
            serviceCategoryToolStripMenuItem = new ToolStripMenuItem();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            voucherTypeToolStripMenuItem = new ToolStripMenuItem();
            areaToolStripMenuItem = new ToolStripMenuItem();
            routeToolStripMenuItem = new ToolStripMenuItem();
            counterToolStripMenuItem = new ToolStripMenuItem();
            productRegisterToolStripMenuItem = new ToolStripMenuItem();
            salesManToolStripMenuItem1 = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            contraVoucherToolStripMenuItem = new ToolStripMenuItem();
            paymentVoucherToolStripMenuItem = new ToolStripMenuItem();
            receiptVoucherToolStripMenuItem = new ToolStripMenuItem();
            journalVoucherToolStripMenuItem = new ToolStripMenuItem();
            pdcPayableToolStripMenuItem = new ToolStripMenuItem();
            pdcReceivableToolStripMenuItem = new ToolStripMenuItem();
            pdcClearanceToolStripMenuItem = new ToolStripMenuItem();
            bankReconciliationToolStripMenuItem = new ToolStripMenuItem();
            purchaseOrderToolStripMenuItem = new ToolStripMenuItem();
            materialRecieptToolStripMenuItem = new ToolStripMenuItem();
            rejectionOutToolStripMenuItem = new ToolStripMenuItem();
            purchaseInvoiceToolStripMenuItem = new ToolStripMenuItem();
            purchaseReturnToolStripMenuItem = new ToolStripMenuItem();
            salesQuatationToolStripMenuItem = new ToolStripMenuItem();
            salesOrderToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            rejectionInToolStripMenuItem = new ToolStripMenuItem();
            salesInvoiceToolStripMenuItem = new ToolStripMenuItem();
            pOSToolStripMenuItem = new ToolStripMenuItem();
            salesReturnToolStripMenuItem = new ToolStripMenuItem();
            physicalStockToolStripMenuItem = new ToolStripMenuItem();
            serviceVoucherToolStripMenuItem = new ToolStripMenuItem();
            creditNoteToolStripMenuItem = new ToolStripMenuItem();
            debitNoteToolStripMenuItem = new ToolStripMenuItem();
            stockJournalToolStripMenuItem = new ToolStripMenuItem();
            billAllocationToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            ContraRegisterToolStripMenuItem = new ToolStripMenuItem();
            paymentRegisterToolStripMenuItem = new ToolStripMenuItem();
            receiptRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            journalRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            pDCPayableRegisterToolStripMenuItem = new ToolStripMenuItem();
            pDCReceivableRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            PDCClearanceRegisterToolStripMenuItem = new ToolStripMenuItem();
            frmPurchaseOrderRegistertoolStripMenuItem = new ToolStripMenuItem();
            materialReceiptRegisterToolStripMenuItem = new ToolStripMenuItem();
            rejectionOutRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            purchaseInvoiceRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            purchaseReturnRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            salesQuotationRegisterToolStripMenuItem = new ToolStripMenuItem();
            salesOrderRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            deliveryNoteRegisterToolStripMenuItem = new ToolStripMenuItem();
            rejectionInRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            salesInvoiceRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            salesReturnRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            physicalStockRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            serviceVoucherRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            creditNoteRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            debitNoteRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            stockJournalRegisterToolStripMenuItem = new ToolStripMenuItem();
            payrollToolStripMenuItem = new ToolStripMenuItem();
            designationToolStripMenuItem1 = new ToolStripMenuItem();
            payHeadToolStripMenuItem1 = new ToolStripMenuItem();
            salaryPackageCreationToolStripMenuItem = new ToolStripMenuItem();
            salaryPackageRegisterToolStripMenuItem = new ToolStripMenuItem();
            employeeCreationToolStripMenuItem = new ToolStripMenuItem();
            employeeRegisterToolStripMenuItem = new ToolStripMenuItem();
            holidaySettingsToolStripMenuItem = new ToolStripMenuItem();
            monthlySalarySettingsToolStripMenuItem = new ToolStripMenuItem();
            mmAttendance = new ToolStripMenuItem();
            advancePaymentToolStripMenuItem = new ToolStripMenuItem();
            mmadvanceRegisterToolStripMenuItem = new ToolStripMenuItem();
            bonusDeductionToolStripMenuItem1 = new ToolStripMenuItem();
            bonusDeductionRegisterToolStripMenuItem1 = new ToolStripMenuItem();
            frmMonthlySalaryVoucherToolStripMenuItem = new ToolStripMenuItem();
            monthlySalaryRegisterToolStripMenuItem = new ToolStripMenuItem();
            DailySalaryVouchertoolStripMenuItem1 = new ToolStripMenuItem();
            dailySalaryRegisterToolStripMenuItem = new ToolStripMenuItem();
            paySlipToolStripMenuItem = new ToolStripMenuItem();
            budgetToolStripMenuItem = new ToolStripMenuItem();
            budgetingToolStripMenuItem = new ToolStripMenuItem();
            budgetVarianceToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            changeCurrentDateToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem1 = new ToolStripMenuItem();
            roleToolStripMenuItem = new ToolStripMenuItem();
            rolePrivileToolStripMenuItem = new ToolStripMenuItem();
            userCreationToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            newFinancialYearToolStripMenuItem = new ToolStripMenuItem();
            changeFinancialYearToolStripMenuItem = new ToolStripMenuItem();
            bracodeSettingsToolStripMenuItem = new ToolStripMenuItem();
            barcodePrintingToolStripMenuItem = new ToolStripMenuItem();
            suffixPrefixSettingsToolStripMenuItem = new ToolStripMenuItem();
            changeProductTaxToolStripMenuItem = new ToolStripMenuItem();
            dotmatrixPrintDesignerToolStripMenuItem = new ToolStripMenuItem();
            rebuildIndexingToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            productSearchToolStripMenuItem = new ToolStripMenuItem();
            voucherSearchToolStripMenuItem = new ToolStripMenuItem();
            voucherWiseProductSearchToolStripMenuItem = new ToolStripMenuItem();
            reminderToolStripMenuItem = new ToolStripMenuItem();
            personalReminderToolStripMenuItem = new ToolStripMenuItem();
            overduePurchaseOrderToolStripMenuItem = new ToolStripMenuItem();
            overdueSalesOrderToolStripMenuItem = new ToolStripMenuItem();
            shortExpiryToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            financialStatementToolStripMenuItem = new ToolStripMenuItem();
            trialBalanceToolStripMenuItem = new ToolStripMenuItem();
            balanceSheetToolStripMenuItem = new ToolStripMenuItem();
            profitAndLossToolStripMenuItem = new ToolStripMenuItem();
            cashFlowToolStripMenuItem = new ToolStripMenuItem();
            fundFlowToolStripMenuItem = new ToolStripMenuItem();
            chartOfAccountToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem18 = new ToolStripMenuItem();
            contraReportToolStripMenuItem = new ToolStripMenuItem();
            paymentReportToolStripMenuItem = new ToolStripMenuItem();
            receiptReportToolStripMenuItem = new ToolStripMenuItem();
            journalReportToolStripMenuItem = new ToolStripMenuItem();
            pDCPayableReportToolStripMenuItem = new ToolStripMenuItem();
            pDCReceivableReportToolStripMenuItem = new ToolStripMenuItem();
            pDCClearanceToolStripMenuItem1 = new ToolStripMenuItem();
            purchaseOrderReportToolStripMenuItem = new ToolStripMenuItem();
            materialReceiptReportToolStripMenuItem = new ToolStripMenuItem();
            rejectionOutReportToolStripMenuItem = new ToolStripMenuItem();
            purchaseInvoiceReportToolStripMenuItem = new ToolStripMenuItem();
            purchaseReturnReportToolStripMenuItem = new ToolStripMenuItem();
            salesQuotationReportToolStripMenuItem = new ToolStripMenuItem();
            salesOrderReportToolStripMenuItem = new ToolStripMenuItem();
            deliveryNoteReportToolStripMenuItem = new ToolStripMenuItem();
            rejectionInReportToolStripMenuItem = new ToolStripMenuItem();
            salesInvoiceReportToolStripMenuItem = new ToolStripMenuItem();
            salesReturnReportToolStripMenuItem = new ToolStripMenuItem();
            physicalStockReportToolStripMenuItem = new ToolStripMenuItem();
            serviceReportToolStripMenuItem = new ToolStripMenuItem();
            creditNoteReportToolStripMenuItem = new ToolStripMenuItem();
            debitNoteReportToolStripMenuItem = new ToolStripMenuItem();
            stockJournalReportToolStripMenuItem = new ToolStripMenuItem();
            payrollToolStripMenuItem1 = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            dailyAttendanceToolStripMenuItem = new ToolStripMenuItem();
            monthlyAttendanceToolStripMenuItem = new ToolStripMenuItem();
            dailySalaryToolStripMenuItem = new ToolStripMenuItem();
            monthlySalaryToolStripMenuItem = new ToolStripMenuItem();
            payheadToolStripMenuItem = new ToolStripMenuItem();
            salaryPackageToolStripMenuItem = new ToolStripMenuItem();
            advancePaymentToolStripMenuItem1 = new ToolStripMenuItem();
            bonusDeductionToolStripMenuItem = new ToolStripMenuItem();
            employeeAddressBookToolStripMenuItem = new ToolStripMenuItem();
            dayBookToolStripMenuItem1 = new ToolStripMenuItem();
            cashBToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            PartyAddressBooktoolStripMenuItem = new ToolStripMenuItem();
            StockReporttoolStripMenuItem = new ToolStripMenuItem();
            ShortExpiryReporttoolStripMenuItem = new ToolStripMenuItem();
            ProductStaticstoolStripMenuItem = new ToolStripMenuItem();
            PriceListReporttoolStripMenuItem = new ToolStripMenuItem();
            TaxReporttoolStripMenuItem = new ToolStripMenuItem();
            VatReporttoolStripMenuItem = new ToolStripMenuItem();
            ChequeReporttoolStripMenuItem = new ToolStripMenuItem();
            freeSaleReportToolStripMenuItem = new ToolStripMenuItem();
            productVsBatchReportToolStripMenuItem = new ToolStripMenuItem();
            utilitiesToolStripMenuItem = new ToolStripMenuItem();
            miracleSkateToolStripMenuItem = new ToolStripMenuItem();
            miracleIToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ContactUsToolStripMenuItem = new ToolStripMenuItem();
            dateToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            BackgrndWrkrLoading = new BackgroundWorker();
            //ucCalculator1 = new ucCalculator();
            ucQuickLaunch1 = new UserControlQuickLaunch();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            base.SuspendLayout();
            menuStrip.BackColor = Color.WhiteSmoke;
            menuStrip.Items.AddRange(new ToolStripItem[16]
            {
                companyToolStripMenuItem,
                mastersToolStripMenuItem,
                transactionToolStripMenuItem,
                registerToolStripMenuItem,
                payrollToolStripMenuItem,
                budgetToolStripMenuItem,
                settingsToolStripMenuItem,
                searchToolStripMenuItem,
                reminderToolStripMenuItem,
                financialStatementToolStripMenuItem,
                reportsToolStripMenuItem,
                utilitiesToolStripMenuItem,
                helpToolStripMenuItem,
                exitToolStripMenuItem,
                ContactUsToolStripMenuItem,
                dateToolStripMenuItem
            });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1078, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            companyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[7]
            {
                createCompanyToolStripMenuItem,
                SelectCompanyToolStripMenuItem,
                editCompanyToolStripMenuItem1,
                BackUpToolStripMenuItem,
                RestoreToolStripMenuItem,
                logoutToolStripMenuItem,
                closeToolStripMenuItem
            });
            companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            companyToolStripMenuItem.Size = new Size(71, 20);
            companyToolStripMenuItem.Text = "&Company";
            createCompanyToolStripMenuItem.Name = "createCompanyToolStripMenuItem";
            createCompanyToolStripMenuItem.Size = new Size(163, 22);
            createCompanyToolStripMenuItem.Text = "Create Company";
            createCompanyToolStripMenuItem.Click += createCompanyToolStripMenuItem_Click;
            SelectCompanyToolStripMenuItem.Name = "SelectCompanyToolStripMenuItem";
            SelectCompanyToolStripMenuItem.Size = new Size(163, 22);
            SelectCompanyToolStripMenuItem.Text = "Select Company";
            SelectCompanyToolStripMenuItem.Click += SelectCompanyToolStripMenuItem_Click;
            editCompanyToolStripMenuItem1.Font = new Font("Tahoma", 8.25f);
            editCompanyToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            editCompanyToolStripMenuItem1.Name = "editCompanyToolStripMenuItem1";
            editCompanyToolStripMenuItem1.Size = new Size(163, 22);
            editCompanyToolStripMenuItem1.Text = "Edit Company";
            editCompanyToolStripMenuItem1.Click += editCompanyToolStripMenuItem1_Click;
            BackUpToolStripMenuItem.Name = "BackUpToolStripMenuItem";
            BackUpToolStripMenuItem.Size = new Size(163, 22);
            BackUpToolStripMenuItem.Text = "BackUp";
            BackUpToolStripMenuItem.Click += BackUpToolStripMenuItem_Click;
            RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem";
            RestoreToolStripMenuItem.Size = new Size(163, 22);
            RestoreToolStripMenuItem.Text = "Restore";
            RestoreToolStripMenuItem.Click += RestoreToolStripMenuItem_Click;
            logoutToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            logoutToolStripMenuItem.ForeColor = SystemColors.ControlText;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(163, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            closeToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            closeToolStripMenuItem.ForeColor = SystemColors.ControlText;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(163, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            mastersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[29]
            {
                customerToolStripMenuItem,
                supplierToolStripMenuItem,
                accountGroupToolStripMenuItem,
                accountLedgerToolStripMenuItem,
                multipleAccountLedgersToolStripMenuItem,
                productGroupToolStripMenuItem,
                productCreationToolStripMenuItem,
                multipleProductCreationToolStripMenuItem,
                batchToolStripMenuItem,
                brandToolStripMenuItem,
                modelNumberToolStripMenuItem,
                sizeToolStripMenuItem,
                unitToolStripMenuItem,
                godownToolStripMenuItem,
                rackToolStripMenuItem,
                pricingLevelToolStripMenuItem,
                priceListToolStripMenuItem,
                standardRateToolStripMenuItem,
                taxToolStripMenuItem,
                currencyToolStripMenuItem,
                exchangeRateToolStripMenuItem,
                serviceCategoryToolStripMenuItem,
                servicesToolStripMenuItem,
                voucherTypeToolStripMenuItem,
                areaToolStripMenuItem,
                routeToolStripMenuItem,
                counterToolStripMenuItem,
                productRegisterToolStripMenuItem,
                salesManToolStripMenuItem1
            });
            mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            mastersToolStripMenuItem.Size = new Size(60, 20);
            mastersToolStripMenuItem.Text = "&Masters";
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(211, 22);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(211, 22);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            accountGroupToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            accountGroupToolStripMenuItem.ForeColor = SystemColors.ControlText;
            accountGroupToolStripMenuItem.Name = "accountGroupToolStripMenuItem";
            accountGroupToolStripMenuItem.Size = new Size(211, 22);
            accountGroupToolStripMenuItem.Text = "Account Group";
            accountGroupToolStripMenuItem.Click += accountGroupToolStripMenuItem_Click;
            accountLedgerToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            accountLedgerToolStripMenuItem.ForeColor = SystemColors.ControlText;
            accountLedgerToolStripMenuItem.Name = "accountLedgerToolStripMenuItem";
            accountLedgerToolStripMenuItem.Size = new Size(211, 22);
            accountLedgerToolStripMenuItem.Text = "Account Ledger";
            accountLedgerToolStripMenuItem.Click += accountLedgerToolStripMenuItem_Click;
            multipleAccountLedgersToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            multipleAccountLedgersToolStripMenuItem.ForeColor = SystemColors.ControlText;
            multipleAccountLedgersToolStripMenuItem.Name = "multipleAccountLedgersToolStripMenuItem";
            multipleAccountLedgersToolStripMenuItem.Size = new Size(211, 22);
            multipleAccountLedgersToolStripMenuItem.Text = "Multiple Account Ledgers";
            multipleAccountLedgersToolStripMenuItem.Click += multipleAccountLedgersToolStripMenuItem_Click;
            productGroupToolStripMenuItem.Name = "productGroupToolStripMenuItem";
            productGroupToolStripMenuItem.Size = new Size(211, 22);
            productGroupToolStripMenuItem.Text = "Product Group";
            productGroupToolStripMenuItem.Click += productGroupToolStripMenuItem_Click;
            productCreationToolStripMenuItem.Name = "productCreationToolStripMenuItem";
            productCreationToolStripMenuItem.Size = new Size(211, 22);
            productCreationToolStripMenuItem.Text = "Product Creation";
            productCreationToolStripMenuItem.Click += productCreationToolStripMenuItem_Click;
            multipleProductCreationToolStripMenuItem.Name = "multipleProductCreationToolStripMenuItem";
            multipleProductCreationToolStripMenuItem.Size = new Size(211, 22);
            multipleProductCreationToolStripMenuItem.Text = "Multiple Product Creation";
            multipleProductCreationToolStripMenuItem.Click += multipleProductCreationToolStripMenuItem_Click;
            batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            batchToolStripMenuItem.Size = new Size(211, 22);
            batchToolStripMenuItem.Text = "Batch";
            batchToolStripMenuItem.Click += batchToolStripMenuItem_Click;
            brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            brandToolStripMenuItem.Size = new Size(211, 22);
            brandToolStripMenuItem.Text = "Brand";
            brandToolStripMenuItem.Click += brandToolStripMenuItem_Click;
            modelNumberToolStripMenuItem.Name = "modelNumberToolStripMenuItem";
            modelNumberToolStripMenuItem.Size = new Size(211, 22);
            modelNumberToolStripMenuItem.Text = "Model Number";
            modelNumberToolStripMenuItem.Click += modelNumberToolStripMenuItem_Click;
            sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            sizeToolStripMenuItem.Size = new Size(211, 22);
            sizeToolStripMenuItem.Text = "Size";
            sizeToolStripMenuItem.Click += sizeToolStripMenuItem_Click;
            unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            unitToolStripMenuItem.Size = new Size(211, 22);
            unitToolStripMenuItem.Text = "Unit";
            unitToolStripMenuItem.Click += unitToolStripMenuItem_Click;
            godownToolStripMenuItem.Name = "godownToolStripMenuItem";
            godownToolStripMenuItem.Size = new Size(211, 22);
            godownToolStripMenuItem.Text = "Godown";
            godownToolStripMenuItem.Click += godownToolStripMenuItem_Click;
            rackToolStripMenuItem.Name = "rackToolStripMenuItem";
            rackToolStripMenuItem.Size = new Size(211, 22);
            rackToolStripMenuItem.Text = "Rack";
            rackToolStripMenuItem.Click += rackToolStripMenuItem_Click;
            pricingLevelToolStripMenuItem.Name = "pricingLevelToolStripMenuItem";
            pricingLevelToolStripMenuItem.Size = new Size(211, 22);
            pricingLevelToolStripMenuItem.Text = "Pricing Level";
            pricingLevelToolStripMenuItem.Click += pricingLevelToolStripMenuItem_Click;
            priceListToolStripMenuItem.Name = "priceListToolStripMenuItem";
            priceListToolStripMenuItem.Size = new Size(211, 22);
            priceListToolStripMenuItem.Text = "Price List";
            priceListToolStripMenuItem.Click += priceListToolStripMenuItem_Click;
            standardRateToolStripMenuItem.Name = "standardRateToolStripMenuItem";
            standardRateToolStripMenuItem.Size = new Size(211, 22);
            standardRateToolStripMenuItem.Text = "Standard Rate";
            standardRateToolStripMenuItem.Click += standardRateToolStripMenuItem_Click;
            taxToolStripMenuItem.Name = "taxToolStripMenuItem";
            taxToolStripMenuItem.Size = new Size(211, 22);
            taxToolStripMenuItem.Text = "Tax";
            taxToolStripMenuItem.Click += taxToolStripMenuItem_Click;
            currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            currencyToolStripMenuItem.Size = new Size(211, 22);
            currencyToolStripMenuItem.Text = "Currency";
            currencyToolStripMenuItem.Click += currencyToolStripMenuItem_Click;
            exchangeRateToolStripMenuItem.Name = "exchangeRateToolStripMenuItem";
            exchangeRateToolStripMenuItem.Size = new Size(211, 22);
            exchangeRateToolStripMenuItem.Text = "Exchange Rate";
            exchangeRateToolStripMenuItem.Click += exchangeRateToolStripMenuItem_Click;
            serviceCategoryToolStripMenuItem.Name = "serviceCategoryToolStripMenuItem";
            serviceCategoryToolStripMenuItem.Size = new Size(211, 22);
            serviceCategoryToolStripMenuItem.Text = "Service Category";
            serviceCategoryToolStripMenuItem.Click += serviceCategoryToolStripMenuItem_Click;
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(211, 22);
            servicesToolStripMenuItem.Text = "Services";
            servicesToolStripMenuItem.Click += servicesToolStripMenuItem_Click;
            voucherTypeToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            voucherTypeToolStripMenuItem.ForeColor = SystemColors.ControlText;
            voucherTypeToolStripMenuItem.Name = "voucherTypeToolStripMenuItem";
            voucherTypeToolStripMenuItem.Size = new Size(211, 22);
            voucherTypeToolStripMenuItem.Text = "Voucher Type";
            voucherTypeToolStripMenuItem.Click += voucherTypeToolStripMenuItem_Click;
            areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            areaToolStripMenuItem.Size = new Size(211, 22);
            areaToolStripMenuItem.Text = "Area";
            areaToolStripMenuItem.Click += areaToolStripMenuItem_Click;
            routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            routeToolStripMenuItem.Size = new Size(211, 22);
            routeToolStripMenuItem.Text = "Route";
            routeToolStripMenuItem.Click += routeToolStripMenuItem_Click;
            counterToolStripMenuItem.Name = "counterToolStripMenuItem";
            counterToolStripMenuItem.Size = new Size(211, 22);
            counterToolStripMenuItem.Text = "Counter";
            counterToolStripMenuItem.Click += counterToolStripMenuItem_Click;
            productRegisterToolStripMenuItem.Name = "productRegisterToolStripMenuItem";
            productRegisterToolStripMenuItem.Size = new Size(211, 22);
            productRegisterToolStripMenuItem.Text = "Product Register";
            productRegisterToolStripMenuItem.Click += productRegisterToolStripMenuItem_Click;
            salesManToolStripMenuItem1.Name = "salesManToolStripMenuItem1";
            salesManToolStripMenuItem1.Size = new Size(211, 22);
            salesManToolStripMenuItem1.Text = "Salesman";
            salesManToolStripMenuItem1.Click += salesmanToolStripMenuItem_Click;
            transactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[26]
            {
                contraVoucherToolStripMenuItem,
                paymentVoucherToolStripMenuItem,
                receiptVoucherToolStripMenuItem,
                journalVoucherToolStripMenuItem,
                pdcPayableToolStripMenuItem,
                pdcReceivableToolStripMenuItem,
                pdcClearanceToolStripMenuItem,
                bankReconciliationToolStripMenuItem,
                purchaseOrderToolStripMenuItem,
                materialRecieptToolStripMenuItem,
                rejectionOutToolStripMenuItem,
                purchaseInvoiceToolStripMenuItem,
                purchaseReturnToolStripMenuItem,
                salesQuatationToolStripMenuItem,
                salesOrderToolStripMenuItem,
                toolStripMenuItem3,
                rejectionInToolStripMenuItem,
                salesInvoiceToolStripMenuItem,
                pOSToolStripMenuItem,
                salesReturnToolStripMenuItem,
                physicalStockToolStripMenuItem,
                serviceVoucherToolStripMenuItem,
                creditNoteToolStripMenuItem,
                debitNoteToolStripMenuItem,
                stockJournalToolStripMenuItem,
                billAllocationToolStripMenuItem
            });
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(86, 20);
            transactionToolStripMenuItem.Text = "&Transactions";
            contraVoucherToolStripMenuItem.Name = "contraVoucherToolStripMenuItem";
            contraVoucherToolStripMenuItem.ShortcutKeys = Keys.F4;
            contraVoucherToolStripMenuItem.Size = new Size(215, 22);
            contraVoucherToolStripMenuItem.Text = "Contra Voucher";
            contraVoucherToolStripMenuItem.Click += contraVoucherToolStripMenuItem_Click;
            paymentVoucherToolStripMenuItem.Name = "paymentVoucherToolStripMenuItem";
            paymentVoucherToolStripMenuItem.ShortcutKeys = Keys.F5;
            paymentVoucherToolStripMenuItem.Size = new Size(215, 22);
            paymentVoucherToolStripMenuItem.Text = "Payment Voucher";
            paymentVoucherToolStripMenuItem.Click += paymentVoucherToolStripMenuItem_Click;
            receiptVoucherToolStripMenuItem.Name = "receiptVoucherToolStripMenuItem";
            receiptVoucherToolStripMenuItem.ShortcutKeys = Keys.F6;
            receiptVoucherToolStripMenuItem.Size = new Size(215, 22);
            receiptVoucherToolStripMenuItem.Text = "Receipt Voucher";
            receiptVoucherToolStripMenuItem.Click += receiptVoucherToolStripMenuItem_Click;
            journalVoucherToolStripMenuItem.Name = "journalVoucherToolStripMenuItem";
            journalVoucherToolStripMenuItem.ShortcutKeys = Keys.F7;
            journalVoucherToolStripMenuItem.Size = new Size(215, 22);
            journalVoucherToolStripMenuItem.Text = "Journal Voucher";
            journalVoucherToolStripMenuItem.Click += journalVoucherToolStripMenuItem_Click;
            pdcPayableToolStripMenuItem.Name = "pdcPayableToolStripMenuItem";
            pdcPayableToolStripMenuItem.ShortcutKeys = (Keys)262224;
            pdcPayableToolStripMenuItem.Size = new Size(215, 22);
            pdcPayableToolStripMenuItem.Text = "PDC Payable";
            pdcPayableToolStripMenuItem.Click += pdcPayableToolStripMenuItem_Click;
            pdcReceivableToolStripMenuItem.Name = "pdcReceivableToolStripMenuItem";
            pdcReceivableToolStripMenuItem.ShortcutKeys = (Keys)262226;
            pdcReceivableToolStripMenuItem.Size = new Size(215, 22);
            pdcReceivableToolStripMenuItem.Text = "PDC Receivable";
            pdcReceivableToolStripMenuItem.Click += pdcReceivableToolStripMenuItem_Click;
            pdcClearanceToolStripMenuItem.Name = "pdcClearanceToolStripMenuItem";
            pdcClearanceToolStripMenuItem.ShortcutKeys = (Keys)131139;
            pdcClearanceToolStripMenuItem.Size = new Size(215, 22);
            pdcClearanceToolStripMenuItem.Text = "PDC Clearance";
            pdcClearanceToolStripMenuItem.Click += pdcClearanceToolStripMenuItem_Click;
            bankReconciliationToolStripMenuItem.Name = "bankReconciliationToolStripMenuItem";
            bankReconciliationToolStripMenuItem.ShortcutKeys = (Keys)262210;
            bankReconciliationToolStripMenuItem.Size = new Size(215, 22);
            bankReconciliationToolStripMenuItem.Text = "Bank Reconciliation";
            bankReconciliationToolStripMenuItem.Click += bankReconciliationToolStripMenuItem_Click;
            purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            purchaseOrderToolStripMenuItem.ShortcutKeys = (Keys)65656;
            purchaseOrderToolStripMenuItem.Size = new Size(215, 22);
            purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            purchaseOrderToolStripMenuItem.Click += purchaseOrderToolStripMenuItem_Click;
            materialRecieptToolStripMenuItem.Name = "materialRecieptToolStripMenuItem";
            materialRecieptToolStripMenuItem.ShortcutKeys = (Keys)262264;
            materialRecieptToolStripMenuItem.Size = new Size(215, 22);
            materialRecieptToolStripMenuItem.Text = "Material Reciept";
            materialRecieptToolStripMenuItem.Click += materialRecieptToolStripMenuItem_Click;
            rejectionOutToolStripMenuItem.Name = "rejectionOutToolStripMenuItem";
            rejectionOutToolStripMenuItem.ShortcutKeys = (Keys)262261;
            rejectionOutToolStripMenuItem.Size = new Size(215, 22);
            rejectionOutToolStripMenuItem.Text = "Rejection Out";
            rejectionOutToolStripMenuItem.Click += rejectionOutToolStripMenuItem_Click;
            purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            purchaseInvoiceToolStripMenuItem.ShortcutKeys = Keys.F9;
            purchaseInvoiceToolStripMenuItem.Size = new Size(215, 22);
            purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            purchaseInvoiceToolStripMenuItem.Click += purchaseInvoiceToolStripMenuItem_Click;
            purchaseReturnToolStripMenuItem.Name = "purchaseReturnToolStripMenuItem";
            purchaseReturnToolStripMenuItem.ShortcutKeys = (Keys)131152;
            purchaseReturnToolStripMenuItem.Size = new Size(215, 22);
            purchaseReturnToolStripMenuItem.Text = "Purchase Return";
            purchaseReturnToolStripMenuItem.Click += purchaseReturnToolStripMenuItem_Click;
            salesQuatationToolStripMenuItem.Name = "salesQuatationToolStripMenuItem";
            salesQuatationToolStripMenuItem.ShortcutKeys = (Keys)262225;
            salesQuatationToolStripMenuItem.Size = new Size(215, 22);
            salesQuatationToolStripMenuItem.Text = "Sales Quotation";
            salesQuatationToolStripMenuItem.Click += salesQuatationToolStripMenuItem_Click;
            salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            salesOrderToolStripMenuItem.ShortcutKeys = (Keys)65655;
            salesOrderToolStripMenuItem.Size = new Size(215, 22);
            salesOrderToolStripMenuItem.Text = "Sales Order";
            salesOrderToolStripMenuItem.Click += salesOrderToolStripMenuItem_Click;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShortcutKeys = (Keys)262263;
            toolStripMenuItem3.Size = new Size(215, 22);
            toolStripMenuItem3.Text = "Delivery Note";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            rejectionInToolStripMenuItem.Name = "rejectionInToolStripMenuItem";
            rejectionInToolStripMenuItem.ShortcutKeys = (Keys)131189;
            rejectionInToolStripMenuItem.Size = new Size(215, 22);
            rejectionInToolStripMenuItem.Text = "Rejection In";
            rejectionInToolStripMenuItem.Click += rejectionInToolStripMenuItem_Click;
            salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            salesInvoiceToolStripMenuItem.ShortcutKeys = Keys.F8;
            salesInvoiceToolStripMenuItem.Size = new Size(215, 22);
            salesInvoiceToolStripMenuItem.Text = "Sales Invoice";
            salesInvoiceToolStripMenuItem.Click += salesInvoiceToolStripMenuItem_Click;
            pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            pOSToolStripMenuItem.ShortcutKeys = Keys.F1;
            pOSToolStripMenuItem.Size = new Size(215, 22);
            pOSToolStripMenuItem.Text = "POS";
            pOSToolStripMenuItem.Click += pOSToolStripMenuItem_Click;
            salesReturnToolStripMenuItem.Name = "salesReturnToolStripMenuItem";
            salesReturnToolStripMenuItem.ShortcutKeys = (Keys)262227;
            salesReturnToolStripMenuItem.Size = new Size(215, 22);
            salesReturnToolStripMenuItem.Text = "Sales Return";
            salesReturnToolStripMenuItem.Click += salesReturnToolStripMenuItem_Click;
            physicalStockToolStripMenuItem.Name = "physicalStockToolStripMenuItem";
            physicalStockToolStripMenuItem.ShortcutKeys = (Keys)262265;
            physicalStockToolStripMenuItem.Size = new Size(215, 22);
            physicalStockToolStripMenuItem.Text = "Physical Stock";
            physicalStockToolStripMenuItem.Click += physicalStockToolStripMenuItem_Click;
            serviceVoucherToolStripMenuItem.Name = "serviceVoucherToolStripMenuItem";
            serviceVoucherToolStripMenuItem.ShortcutKeys = Keys.F3;
            serviceVoucherToolStripMenuItem.Size = new Size(215, 22);
            serviceVoucherToolStripMenuItem.Text = "Service Voucher";
            serviceVoucherToolStripMenuItem.Click += serviceVoucherToolStripMenuItem_Click;
            creditNoteToolStripMenuItem.Name = "creditNoteToolStripMenuItem";
            creditNoteToolStripMenuItem.ShortcutKeys = (Keys)131191;
            creditNoteToolStripMenuItem.Size = new Size(215, 22);
            creditNoteToolStripMenuItem.Text = "Credit Note";
            creditNoteToolStripMenuItem.Click += creditNoteToolStripMenuItem_Click;
            debitNoteToolStripMenuItem.Name = "debitNoteToolStripMenuItem";
            debitNoteToolStripMenuItem.ShortcutKeys = (Keys)131192;
            debitNoteToolStripMenuItem.Size = new Size(215, 22);
            debitNoteToolStripMenuItem.Text = "Debit Note";
            debitNoteToolStripMenuItem.Click += debitNoteToolStripMenuItem_Click;
            stockJournalToolStripMenuItem.Name = "stockJournalToolStripMenuItem";
            stockJournalToolStripMenuItem.ShortcutKeys = (Keys)262262;
            stockJournalToolStripMenuItem.Size = new Size(215, 22);
            stockJournalToolStripMenuItem.Text = "Stock Journal";
            stockJournalToolStripMenuItem.Click += stockJournalToolStripMenuItem_Click;
            billAllocationToolStripMenuItem.Name = "billAllocationToolStripMenuItem";
            billAllocationToolStripMenuItem.ShortcutKeys = (Keys)131138;
            billAllocationToolStripMenuItem.Size = new Size(215, 22);
            billAllocationToolStripMenuItem.Text = "Bill Allocation";
            billAllocationToolStripMenuItem.Click += billAllocationToolStripMenuItem_Click;
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[23]
            {
                ContraRegisterToolStripMenuItem,
                paymentRegisterToolStripMenuItem,
                receiptRegisterToolStripMenuItem1,
                journalRegisterToolStripMenuItem1,
                pDCPayableRegisterToolStripMenuItem,
                pDCReceivableRegisterToolStripMenuItem1,
                PDCClearanceRegisterToolStripMenuItem,
                frmPurchaseOrderRegistertoolStripMenuItem,
                materialReceiptRegisterToolStripMenuItem,
                rejectionOutRegisterToolStripMenuItem1,
                purchaseInvoiceRegisterToolStripMenuItem1,
                purchaseReturnRegisterToolStripMenuItem1,
                salesQuotationRegisterToolStripMenuItem,
                salesOrderRegisterToolStripMenuItem1,
                deliveryNoteRegisterToolStripMenuItem,
                rejectionInRegisterToolStripMenuItem1,
                salesInvoiceRegisterToolStripMenuItem1,
                salesReturnRegisterToolStripMenuItem1,
                physicalStockRegisterToolStripMenuItem1,
                serviceVoucherRegisterToolStripMenuItem1,
                creditNoteRegisterToolStripMenuItem1,
                debitNoteRegisterToolStripMenuItem1,
                stockJournalRegisterToolStripMenuItem
            });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(66, 20);
            registerToolStripMenuItem.Text = "&Registers";
            ContraRegisterToolStripMenuItem.Name = "ContraRegisterToolStripMenuItem";
            ContraRegisterToolStripMenuItem.Size = new Size(166, 22);
            ContraRegisterToolStripMenuItem.Text = "Contra Register";
            ContraRegisterToolStripMenuItem.Click += ContraRegisterToolStripMenuItem_Click;
            paymentRegisterToolStripMenuItem.Name = "paymentRegisterToolStripMenuItem";
            paymentRegisterToolStripMenuItem.Size = new Size(166, 22);
            paymentRegisterToolStripMenuItem.Text = "Payment Register";
            paymentRegisterToolStripMenuItem.Click += paymentRegisterToolStripMenuItem_Click;
            receiptRegisterToolStripMenuItem1.Name = "receiptRegisterToolStripMenuItem1";
            receiptRegisterToolStripMenuItem1.Size = new Size(166, 22);
            receiptRegisterToolStripMenuItem1.Text = "Receipt Register";
            receiptRegisterToolStripMenuItem1.Click += receiptRegisterToolStripMenuItem1_Click;
            journalRegisterToolStripMenuItem1.Name = "journalRegisterToolStripMenuItem1";
            journalRegisterToolStripMenuItem1.Size = new Size(166, 22);
            journalRegisterToolStripMenuItem1.Text = "Journal Register";
            journalRegisterToolStripMenuItem1.Click += journalRegisterToolStripMenuItem1_Click;
            pDCPayableRegisterToolStripMenuItem.Name = "pDCPayableRegisterToolStripMenuItem";
            pDCPayableRegisterToolStripMenuItem.Size = new Size(166, 22);
            pDCPayableRegisterToolStripMenuItem.Text = "PDC Payable";
            pDCPayableRegisterToolStripMenuItem.Click += PDCPayableRegisterToolStripMenuItem_Click;
            pDCReceivableRegisterToolStripMenuItem1.Name = "pDCReceivableRegisterToolStripMenuItem1";
            pDCReceivableRegisterToolStripMenuItem1.Size = new Size(166, 22);
            pDCReceivableRegisterToolStripMenuItem1.Text = "PDC Receivable";
            pDCReceivableRegisterToolStripMenuItem1.Click += PDCReceivableRegisterToolStripMenuItem1_Click;
            PDCClearanceRegisterToolStripMenuItem.Name = "PDCClearanceRegisterToolStripMenuItem";
            PDCClearanceRegisterToolStripMenuItem.Size = new Size(166, 22);
            PDCClearanceRegisterToolStripMenuItem.Text = "PDC Clearance";
            PDCClearanceRegisterToolStripMenuItem.Click += PDCClearanceRegisterToolStripMenuItem_Click;
            frmPurchaseOrderRegistertoolStripMenuItem.Name = "frmPurchaseOrderRegistertoolStripMenuItem";
            frmPurchaseOrderRegistertoolStripMenuItem.Size = new Size(166, 22);
            frmPurchaseOrderRegistertoolStripMenuItem.Text = "Purchase Order";
            frmPurchaseOrderRegistertoolStripMenuItem.Click += frmPurchaseOrderRegistertoolStripMenuItem_Click;
            materialReceiptRegisterToolStripMenuItem.Name = "materialReceiptRegisterToolStripMenuItem";
            materialReceiptRegisterToolStripMenuItem.Size = new Size(166, 22);
            materialReceiptRegisterToolStripMenuItem.Text = "Material Receipt";
            materialReceiptRegisterToolStripMenuItem.Click += materialReceiptRegisterToolStripMenuItem_Click;
            rejectionOutRegisterToolStripMenuItem1.Name = "rejectionOutRegisterToolStripMenuItem1";
            rejectionOutRegisterToolStripMenuItem1.Size = new Size(166, 22);
            rejectionOutRegisterToolStripMenuItem1.Text = "Rejection Out";
            rejectionOutRegisterToolStripMenuItem1.Click += rejectionOutRegisterToolStripMenuItem1_Click;
            purchaseInvoiceRegisterToolStripMenuItem1.Name = "purchaseInvoiceRegisterToolStripMenuItem1";
            purchaseInvoiceRegisterToolStripMenuItem1.Size = new Size(166, 22);
            purchaseInvoiceRegisterToolStripMenuItem1.Text = "Purchase Invoice";
            purchaseInvoiceRegisterToolStripMenuItem1.Click += purchaseInvoiceRegisterToolStripMenuItem1_Click_1;
            purchaseReturnRegisterToolStripMenuItem1.Name = "purchaseReturnRegisterToolStripMenuItem1";
            purchaseReturnRegisterToolStripMenuItem1.Size = new Size(166, 22);
            purchaseReturnRegisterToolStripMenuItem1.Text = "Purchase Return";
            purchaseReturnRegisterToolStripMenuItem1.Click += purchaseReturnRegisterToolStripMenuItem1_Click;
            salesQuotationRegisterToolStripMenuItem.Name = "salesQuotationRegisterToolStripMenuItem";
            salesQuotationRegisterToolStripMenuItem.Size = new Size(166, 22);
            salesQuotationRegisterToolStripMenuItem.Text = "Sales Quotation";
            salesQuotationRegisterToolStripMenuItem.Click += salesQuotationRegisterToolStripMenuItem_Click;
            salesOrderRegisterToolStripMenuItem1.Name = "salesOrderRegisterToolStripMenuItem1";
            salesOrderRegisterToolStripMenuItem1.Size = new Size(166, 22);
            salesOrderRegisterToolStripMenuItem1.Text = "Sales Order";
            salesOrderRegisterToolStripMenuItem1.Click += salesOrderRegisterToolStripMenuItem1_Click;
            deliveryNoteRegisterToolStripMenuItem.Name = "deliveryNoteRegisterToolStripMenuItem";
            deliveryNoteRegisterToolStripMenuItem.Size = new Size(166, 22);
            deliveryNoteRegisterToolStripMenuItem.Text = "Delivery Note";
            deliveryNoteRegisterToolStripMenuItem.Click += deliveryNoteRegisterToolStripMenuItem_Click;
            rejectionInRegisterToolStripMenuItem1.Name = "rejectionInRegisterToolStripMenuItem1";
            rejectionInRegisterToolStripMenuItem1.Size = new Size(166, 22);
            rejectionInRegisterToolStripMenuItem1.Text = "Rejection In";
            rejectionInRegisterToolStripMenuItem1.Click += rejectionInRegisterToolStripMenuItem1_Click;
            salesInvoiceRegisterToolStripMenuItem1.Name = "salesInvoiceRegisterToolStripMenuItem1";
            salesInvoiceRegisterToolStripMenuItem1.Size = new Size(166, 22);
            salesInvoiceRegisterToolStripMenuItem1.Text = "Sales Invoice";
            salesInvoiceRegisterToolStripMenuItem1.Click += salesInvoiceRegisterToolStripMenuItem1_Click;
            salesReturnRegisterToolStripMenuItem1.Name = "salesReturnRegisterToolStripMenuItem1";
            salesReturnRegisterToolStripMenuItem1.Size = new Size(166, 22);
            salesReturnRegisterToolStripMenuItem1.Text = "Sales Return";
            salesReturnRegisterToolStripMenuItem1.Click += salesReturnRegisterToolStripMenuItem1_Click;
            physicalStockRegisterToolStripMenuItem1.Name = "physicalStockRegisterToolStripMenuItem1";
            physicalStockRegisterToolStripMenuItem1.Size = new Size(166, 22);
            physicalStockRegisterToolStripMenuItem1.Text = "Physical Stock";
            physicalStockRegisterToolStripMenuItem1.Click += physicalStockRegisterToolStripMenuItem1_Click;
            serviceVoucherRegisterToolStripMenuItem1.Name = "serviceVoucherRegisterToolStripMenuItem1";
            serviceVoucherRegisterToolStripMenuItem1.Size = new Size(166, 22);
            serviceVoucherRegisterToolStripMenuItem1.Text = "Service Register";
            serviceVoucherRegisterToolStripMenuItem1.Click += serviceVoucherRegisterToolStripMenuItem1_Click;
            creditNoteRegisterToolStripMenuItem1.Name = "creditNoteRegisterToolStripMenuItem1";
            creditNoteRegisterToolStripMenuItem1.Size = new Size(166, 22);
            creditNoteRegisterToolStripMenuItem1.Text = "Credit Note";
            creditNoteRegisterToolStripMenuItem1.Click += creditNoteRegisterToolStripMenuItem1_Click;
            debitNoteRegisterToolStripMenuItem1.Name = "debitNoteRegisterToolStripMenuItem1";
            debitNoteRegisterToolStripMenuItem1.Size = new Size(166, 22);
            debitNoteRegisterToolStripMenuItem1.Text = "Debit Note";
            debitNoteRegisterToolStripMenuItem1.Click += debitNoteRegisterToolStripMenuItem1_Click;
            stockJournalRegisterToolStripMenuItem.Name = "stockJournalRegisterToolStripMenuItem";
            stockJournalRegisterToolStripMenuItem.Size = new Size(166, 22);
            stockJournalRegisterToolStripMenuItem.Text = "Stock Journal";
            stockJournalRegisterToolStripMenuItem.Click += stockJournalRegisterToolStripMenuItem_Click;
            payrollToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[18]
            {
                designationToolStripMenuItem1,
                payHeadToolStripMenuItem1,
                salaryPackageCreationToolStripMenuItem,
                salaryPackageRegisterToolStripMenuItem,
                employeeCreationToolStripMenuItem,
                employeeRegisterToolStripMenuItem,
                holidaySettingsToolStripMenuItem,
                monthlySalarySettingsToolStripMenuItem,
                mmAttendance,
                advancePaymentToolStripMenuItem,
                mmadvanceRegisterToolStripMenuItem,
                bonusDeductionToolStripMenuItem1,
                bonusDeductionRegisterToolStripMenuItem1,
                frmMonthlySalaryVoucherToolStripMenuItem,
                monthlySalaryRegisterToolStripMenuItem,
                DailySalaryVouchertoolStripMenuItem1,
                dailySalaryRegisterToolStripMenuItem,
                paySlipToolStripMenuItem
            });
            payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            payrollToolStripMenuItem.Size = new Size(55, 20);
            payrollToolStripMenuItem.Text = "&Payroll";
            designationToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            designationToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            designationToolStripMenuItem1.Name = "designationToolStripMenuItem1";
            designationToolStripMenuItem1.Size = new Size(198, 22);
            designationToolStripMenuItem1.Text = "Designation";
            designationToolStripMenuItem1.Click += designationToolStripMenuItem1_Click;
            payHeadToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            payHeadToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            payHeadToolStripMenuItem1.Name = "payHeadToolStripMenuItem1";
            payHeadToolStripMenuItem1.Size = new Size(198, 22);
            payHeadToolStripMenuItem1.Text = "Pay Head";
            payHeadToolStripMenuItem1.Click += payHeadToolStripMenuItem1_Click;
            salaryPackageCreationToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryPackageCreationToolStripMenuItem.ForeColor = SystemColors.ControlText;
            salaryPackageCreationToolStripMenuItem.Name = "salaryPackageCreationToolStripMenuItem";
            salaryPackageCreationToolStripMenuItem.Size = new Size(198, 22);
            salaryPackageCreationToolStripMenuItem.Text = "Salary Package Creation";
            salaryPackageCreationToolStripMenuItem.Click += salaryPackageCreationToolStripMenuItem_Click;
            salaryPackageRegisterToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryPackageRegisterToolStripMenuItem.ForeColor = SystemColors.ControlText;
            salaryPackageRegisterToolStripMenuItem.Name = "salaryPackageRegisterToolStripMenuItem";
            salaryPackageRegisterToolStripMenuItem.Size = new Size(198, 22);
            salaryPackageRegisterToolStripMenuItem.Text = "Salary Package Register";
            salaryPackageRegisterToolStripMenuItem.Click += salaryPackageRegisterToolStripMenuItem_Click;
            employeeCreationToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeCreationToolStripMenuItem.ForeColor = SystemColors.ControlText;
            employeeCreationToolStripMenuItem.Name = "employeeCreationToolStripMenuItem";
            employeeCreationToolStripMenuItem.Size = new Size(198, 22);
            employeeCreationToolStripMenuItem.Text = "Employee Creation";
            employeeCreationToolStripMenuItem.Click += employeeCreationToolStripMenuItem_Click;
            employeeRegisterToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeRegisterToolStripMenuItem.ForeColor = SystemColors.ControlText;
            employeeRegisterToolStripMenuItem.Name = "employeeRegisterToolStripMenuItem";
            employeeRegisterToolStripMenuItem.Size = new Size(198, 22);
            employeeRegisterToolStripMenuItem.Text = "Employee Register";
            employeeRegisterToolStripMenuItem.Click += employeeRegisterToolStripMenuItem_Click;
            holidaySettingsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            holidaySettingsToolStripMenuItem.ForeColor = SystemColors.ControlText;
            holidaySettingsToolStripMenuItem.Name = "holidaySettingsToolStripMenuItem";
            holidaySettingsToolStripMenuItem.Size = new Size(198, 22);
            holidaySettingsToolStripMenuItem.Text = "Holiday Settings";
            holidaySettingsToolStripMenuItem.Click += holidaySettingsToolStripMenuItem_Click;
            monthlySalarySettingsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthlySalarySettingsToolStripMenuItem.ForeColor = SystemColors.ControlText;
            monthlySalarySettingsToolStripMenuItem.Name = "monthlySalarySettingsToolStripMenuItem";
            monthlySalarySettingsToolStripMenuItem.Size = new Size(198, 22);
            monthlySalarySettingsToolStripMenuItem.Text = "Monthly Salary Settings";
            monthlySalarySettingsToolStripMenuItem.Click += monthlySalarySettingsToolStripMenuItem_Click;
            mmAttendance.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            mmAttendance.ForeColor = SystemColors.ControlText;
            mmAttendance.Name = "mmAttendance";
            mmAttendance.Size = new Size(198, 22);
            mmAttendance.Text = "Attendance";
            mmAttendance.Click += mmAttendance_Click;
            advancePaymentToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            advancePaymentToolStripMenuItem.ForeColor = SystemColors.ControlText;
            advancePaymentToolStripMenuItem.Name = "advancePaymentToolStripMenuItem";
            advancePaymentToolStripMenuItem.Size = new Size(198, 22);
            advancePaymentToolStripMenuItem.Text = "Advance Payment";
            advancePaymentToolStripMenuItem.Click += advancePaymentToolStripMenuItem_Click;
            mmadvanceRegisterToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            mmadvanceRegisterToolStripMenuItem.ForeColor = SystemColors.ControlText;
            mmadvanceRegisterToolStripMenuItem.Name = "mmadvanceRegisterToolStripMenuItem";
            mmadvanceRegisterToolStripMenuItem.Size = new Size(198, 22);
            mmadvanceRegisterToolStripMenuItem.Text = "Advance Register";
            mmadvanceRegisterToolStripMenuItem.Click += mmadvanceRegisterToolStripMenuItem_Click;
            bonusDeductionToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            bonusDeductionToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            bonusDeductionToolStripMenuItem1.Name = "bonusDeductionToolStripMenuItem1";
            bonusDeductionToolStripMenuItem1.Size = new Size(198, 22);
            bonusDeductionToolStripMenuItem1.Text = "Bonus Deduction";
            bonusDeductionToolStripMenuItem1.Click += bonusDeductionToolStripMenuItem1_Click;
            bonusDeductionRegisterToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            bonusDeductionRegisterToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            bonusDeductionRegisterToolStripMenuItem1.Name = "bonusDeductionRegisterToolStripMenuItem1";
            bonusDeductionRegisterToolStripMenuItem1.Size = new Size(198, 22);
            bonusDeductionRegisterToolStripMenuItem1.Text = "Bonus Deduction Register";
            bonusDeductionRegisterToolStripMenuItem1.Click += bonusDeductionRegisterToolStripMenuItem1_Click;
            frmMonthlySalaryVoucherToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmMonthlySalaryVoucherToolStripMenuItem.ForeColor = SystemColors.ControlText;
            frmMonthlySalaryVoucherToolStripMenuItem.Name = "frmMonthlySalaryVoucherToolStripMenuItem";
            frmMonthlySalaryVoucherToolStripMenuItem.Size = new Size(198, 22);
            frmMonthlySalaryVoucherToolStripMenuItem.Text = "Monthly Salary Voucher";
            frmMonthlySalaryVoucherToolStripMenuItem.Click += frmMonthlySalaryVoucherToolStripMenuItem_Click;
            monthlySalaryRegisterToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthlySalaryRegisterToolStripMenuItem.ForeColor = SystemColors.ControlText;
            monthlySalaryRegisterToolStripMenuItem.Name = "monthlySalaryRegisterToolStripMenuItem";
            monthlySalaryRegisterToolStripMenuItem.Size = new Size(198, 22);
            monthlySalaryRegisterToolStripMenuItem.Text = "Monthly Salary Register";
            monthlySalaryRegisterToolStripMenuItem.Click += monthlySalaryRegisterToolStripMenuItem_Click;
            DailySalaryVouchertoolStripMenuItem1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DailySalaryVouchertoolStripMenuItem1.ForeColor = SystemColors.ControlText;
            DailySalaryVouchertoolStripMenuItem1.Name = "DailySalaryVouchertoolStripMenuItem1";
            DailySalaryVouchertoolStripMenuItem1.Size = new Size(198, 22);
            DailySalaryVouchertoolStripMenuItem1.Text = "Daily Salary Voucher";
            DailySalaryVouchertoolStripMenuItem1.Click += DailySalaryVouchertoolStripMenuItem1_Click;
            dailySalaryRegisterToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dailySalaryRegisterToolStripMenuItem.ForeColor = SystemColors.ControlText;
            dailySalaryRegisterToolStripMenuItem.Name = "dailySalaryRegisterToolStripMenuItem";
            dailySalaryRegisterToolStripMenuItem.Size = new Size(198, 22);
            dailySalaryRegisterToolStripMenuItem.Text = "Daily Salary Register";
            dailySalaryRegisterToolStripMenuItem.Click += dailySalaryRegisterToolStripMenuItem_Click;
            paySlipToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            paySlipToolStripMenuItem.ForeColor = SystemColors.ControlText;
            paySlipToolStripMenuItem.Name = "paySlipToolStripMenuItem";
            paySlipToolStripMenuItem.Size = new Size(198, 22);
            paySlipToolStripMenuItem.Text = "Pay Slip";
            paySlipToolStripMenuItem.Click += paySlipToolStripMenuItem_Click;
            budgetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
                budgetingToolStripMenuItem,
                budgetVarianceToolStripMenuItem
            });
            budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            budgetToolStripMenuItem.Size = new Size(57, 20);
            budgetToolStripMenuItem.Text = "&Budget";
            budgetingToolStripMenuItem.Name = "budgetingToolStripMenuItem";
            budgetingToolStripMenuItem.Size = new Size(160, 22);
            budgetingToolStripMenuItem.Text = "Budget";
            budgetingToolStripMenuItem.Click += budgetingToolStripMenuItem_Click;
            budgetVarianceToolStripMenuItem.Name = "budgetVarianceToolStripMenuItem";
            budgetVarianceToolStripMenuItem.Size = new Size(160, 22);
            budgetVarianceToolStripMenuItem.Text = "Budget Variance";
            budgetVarianceToolStripMenuItem.Click += budgetVarianceToolStripMenuItem_Click;
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[14]
            {
                changeCurrentDateToolStripMenuItem,
                settingsToolStripMenuItem1,
                roleToolStripMenuItem,
                rolePrivileToolStripMenuItem,
                userCreationToolStripMenuItem,
                changePasswordToolStripMenuItem,
                newFinancialYearToolStripMenuItem,
                changeFinancialYearToolStripMenuItem,
                bracodeSettingsToolStripMenuItem,
                barcodePrintingToolStripMenuItem,
                suffixPrefixSettingsToolStripMenuItem,
                changeProductTaxToolStripMenuItem,
                dotmatrixPrintDesignerToolStripMenuItem,
                rebuildIndexingToolStripMenuItem
            });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "&Settings";
            changeCurrentDateToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            changeCurrentDateToolStripMenuItem.ForeColor = SystemColors.ControlText;
            changeCurrentDateToolStripMenuItem.Name = "changeCurrentDateToolStripMenuItem";
            changeCurrentDateToolStripMenuItem.ShortcutKeys = Keys.F2;
            changeCurrentDateToolStripMenuItem.Size = new Size(203, 22);
            changeCurrentDateToolStripMenuItem.Text = "Change Current Date";
            changeCurrentDateToolStripMenuItem.Click += changeCurrentDateToolStripMenuItem_Click;
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.ShortcutKeys = Keys.F11;
            settingsToolStripMenuItem1.Size = new Size(203, 22);
            settingsToolStripMenuItem1.Text = "Settings";
            settingsToolStripMenuItem1.Click += settingsToolStripMenuItem1_Click;
            roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            roleToolStripMenuItem.Size = new Size(203, 22);
            roleToolStripMenuItem.Text = "Role";
            roleToolStripMenuItem.Click += roleToolStripMenuItem_Click;
            rolePrivileToolStripMenuItem.Name = "rolePrivileToolStripMenuItem";
            rolePrivileToolStripMenuItem.Size = new Size(203, 22);
            rolePrivileToolStripMenuItem.Text = "Role Privilege Settings";
            rolePrivileToolStripMenuItem.Click += rolePrivileToolStripMenuItem_Click;
            userCreationToolStripMenuItem.Name = "userCreationToolStripMenuItem";
            userCreationToolStripMenuItem.Size = new Size(203, 22);
            userCreationToolStripMenuItem.Text = "User Creation";
            userCreationToolStripMenuItem.Click += userCreationToolStripMenuItem_Click;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(203, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            newFinancialYearToolStripMenuItem.Name = "newFinancialYearToolStripMenuItem";
            newFinancialYearToolStripMenuItem.Size = new Size(203, 22);
            newFinancialYearToolStripMenuItem.Text = "New Financial Year";
            newFinancialYearToolStripMenuItem.Click += newFinancialYearToolStripMenuItem_Click;
            changeFinancialYearToolStripMenuItem.Name = "changeFinancialYearToolStripMenuItem";
            changeFinancialYearToolStripMenuItem.Size = new Size(203, 22);
            changeFinancialYearToolStripMenuItem.Text = "Change Financial Year";
            changeFinancialYearToolStripMenuItem.Click += changeFinancialYearToolStripMenuItem_Click;
            bracodeSettingsToolStripMenuItem.Name = "bracodeSettingsToolStripMenuItem";
            bracodeSettingsToolStripMenuItem.Size = new Size(203, 22);
            bracodeSettingsToolStripMenuItem.Text = "Barcode Settings";
            bracodeSettingsToolStripMenuItem.Click += bracodeSettingsToolStripMenuItem_Click;
            barcodePrintingToolStripMenuItem.Name = "barcodePrintingToolStripMenuItem";
            barcodePrintingToolStripMenuItem.Size = new Size(203, 22);
            barcodePrintingToolStripMenuItem.Text = "Barcode Printing";
            barcodePrintingToolStripMenuItem.Click += barcodePrintingToolStripMenuItem_Click;
            suffixPrefixSettingsToolStripMenuItem.Name = "suffixPrefixSettingsToolStripMenuItem";
            suffixPrefixSettingsToolStripMenuItem.Size = new Size(203, 22);
            suffixPrefixSettingsToolStripMenuItem.Text = "Suffix Prefix Settings";
            suffixPrefixSettingsToolStripMenuItem.Click += suffixPrefixSettingsToolStripMenuItem_Click;
            changeProductTaxToolStripMenuItem.Name = "changeProductTaxToolStripMenuItem";
            changeProductTaxToolStripMenuItem.Size = new Size(203, 22);
            changeProductTaxToolStripMenuItem.Text = "Change Product Tax";
            changeProductTaxToolStripMenuItem.Click += changeProductTaxToolStripMenuItem_Click;
            dotmatrixPrintDesignerToolStripMenuItem.Name = "dotmatrixPrintDesignerToolStripMenuItem";
            dotmatrixPrintDesignerToolStripMenuItem.Size = new Size(203, 22);
            dotmatrixPrintDesignerToolStripMenuItem.Text = "Dotmatrix Print Designer";
            dotmatrixPrintDesignerToolStripMenuItem.Click += dotmatrixPrintDesignerToolStripMenuItem_Click;
            rebuildIndexingToolStripMenuItem.Name = "rebuildIndexingToolStripMenuItem";
            rebuildIndexingToolStripMenuItem.Size = new Size(203, 22);
            rebuildIndexingToolStripMenuItem.Text = "Rebuild Index";
            rebuildIndexingToolStripMenuItem.Click += rebuildIndexingToolStripMenuItem_Click;
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
            {
                productSearchToolStripMenuItem,
                voucherSearchToolStripMenuItem,
                voucherWiseProductSearchToolStripMenuItem
            });
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(54, 20);
            searchToolStripMenuItem.Text = "&Search";
            productSearchToolStripMenuItem.Name = "productSearchToolStripMenuItem";
            productSearchToolStripMenuItem.Size = new Size(229, 22);
            productSearchToolStripMenuItem.Text = "Product Search";
            productSearchToolStripMenuItem.Click += productSearchToolStripMenuItem_Click;
            voucherSearchToolStripMenuItem.Name = "voucherSearchToolStripMenuItem";
            voucherSearchToolStripMenuItem.Size = new Size(229, 22);
            voucherSearchToolStripMenuItem.Text = "Voucher Search";
            voucherSearchToolStripMenuItem.Click += voucherSearchToolStripMenuItem_Click;
            voucherWiseProductSearchToolStripMenuItem.Name = "voucherWiseProductSearchToolStripMenuItem";
            voucherWiseProductSearchToolStripMenuItem.Size = new Size(229, 22);
            voucherWiseProductSearchToolStripMenuItem.Text = "Voucher Wise Product Search";
            voucherWiseProductSearchToolStripMenuItem.Click += voucherWiseProductSearchToolStripMenuItem_Click;
            reminderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
            {
                personalReminderToolStripMenuItem,
                overduePurchaseOrderToolStripMenuItem,
                overdueSalesOrderToolStripMenuItem,
                shortExpiryToolStripMenuItem,
                stockToolStripMenuItem
            });
            reminderToolStripMenuItem.Name = "reminderToolStripMenuItem";
            reminderToolStripMenuItem.Size = new Size(70, 20);
            reminderToolStripMenuItem.Text = "&Reminder";
            personalReminderToolStripMenuItem.Name = "personalReminderToolStripMenuItem";
            personalReminderToolStripMenuItem.Size = new Size(203, 22);
            personalReminderToolStripMenuItem.Text = "Personal Reminder";
            personalReminderToolStripMenuItem.Click += personalReminderToolStripMenuItem_Click;
            overduePurchaseOrderToolStripMenuItem.Name = "overduePurchaseOrderToolStripMenuItem";
            overduePurchaseOrderToolStripMenuItem.Size = new Size(203, 22);
            overduePurchaseOrderToolStripMenuItem.Text = "Overdue Purchase Order";
            overduePurchaseOrderToolStripMenuItem.Click += overduePurchaseOrderToolStripMenuItem_Click;
            overdueSalesOrderToolStripMenuItem.Name = "overdueSalesOrderToolStripMenuItem";
            overdueSalesOrderToolStripMenuItem.Size = new Size(203, 22);
            overdueSalesOrderToolStripMenuItem.Text = "Overdue Sales Order";
            overdueSalesOrderToolStripMenuItem.Click += overdueSalesOrderToolStripMenuItem_Click;
            shortExpiryToolStripMenuItem.Name = "shortExpiryToolStripMenuItem";
            shortExpiryToolStripMenuItem.Size = new Size(203, 22);
            shortExpiryToolStripMenuItem.Text = "Short Expiry";
            shortExpiryToolStripMenuItem.Click += shortExpiryToolStripMenuItem_Click;
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(203, 22);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            financialStatementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
            {
                trialBalanceToolStripMenuItem,
                balanceSheetToolStripMenuItem,
                profitAndLossToolStripMenuItem,
                cashFlowToolStripMenuItem,
                fundFlowToolStripMenuItem,
                chartOfAccountToolStripMenuItem
            });
            financialStatementToolStripMenuItem.Name = "financialStatementToolStripMenuItem";
            financialStatementToolStripMenuItem.Size = new Size(128, 20);
            financialStatementToolStripMenuItem.Text = "&Financial Statements";
            trialBalanceToolStripMenuItem.Name = "trialBalanceToolStripMenuItem";
            trialBalanceToolStripMenuItem.Size = new Size(165, 22);
            trialBalanceToolStripMenuItem.Text = "Trial Balance";
            trialBalanceToolStripMenuItem.Click += trialBalanceToolStripMenuItem_Click;
            balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            balanceSheetToolStripMenuItem.Size = new Size(165, 22);
            balanceSheetToolStripMenuItem.Text = "Balance Sheet";
            balanceSheetToolStripMenuItem.Click += balanceSheetToolStripMenuItem_Click;
            profitAndLossToolStripMenuItem.Name = "profitAndLossToolStripMenuItem";
            profitAndLossToolStripMenuItem.Size = new Size(165, 22);
            profitAndLossToolStripMenuItem.Text = "Profit and Loss";
            profitAndLossToolStripMenuItem.Click += profitAndLossToolStripMenuItem_Click;
            cashFlowToolStripMenuItem.Name = "cashFlowToolStripMenuItem";
            cashFlowToolStripMenuItem.Size = new Size(165, 22);
            cashFlowToolStripMenuItem.Text = "Cash Flow";
            cashFlowToolStripMenuItem.Click += cashFlowToolStripMenuItem_Click;
            fundFlowToolStripMenuItem.Name = "fundFlowToolStripMenuItem";
            fundFlowToolStripMenuItem.Size = new Size(165, 22);
            fundFlowToolStripMenuItem.Text = "Fund Flow";
            fundFlowToolStripMenuItem.Click += fundFlowToolStripMenuItem_Click;
            chartOfAccountToolStripMenuItem.Name = "chartOfAccountToolStripMenuItem";
            chartOfAccountToolStripMenuItem.Size = new Size(165, 22);
            chartOfAccountToolStripMenuItem.Text = "Chart of Account";
            chartOfAccountToolStripMenuItem.Click += chartOfAccountToolStripMenuItem_Click;
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[18]
            {
                toolStripMenuItem18,
                payrollToolStripMenuItem1,
                dayBookToolStripMenuItem1,
                cashBToolStripMenuItem,
                toolStripMenuItem6,
                toolStripMenuItem7,
                toolStripMenuItem8,
                toolStripMenuItem9,
                PartyAddressBooktoolStripMenuItem,
                StockReporttoolStripMenuItem,
                ShortExpiryReporttoolStripMenuItem,
                ProductStaticstoolStripMenuItem,
                PriceListReporttoolStripMenuItem,
                TaxReporttoolStripMenuItem,
                VatReporttoolStripMenuItem,
                ChequeReporttoolStripMenuItem,
                freeSaleReportToolStripMenuItem,
                productVsBatchReportToolStripMenuItem
            });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "&Reports";
            toolStripMenuItem18.DropDownItems.AddRange(new ToolStripItem[23]
            {
                contraReportToolStripMenuItem,
                paymentReportToolStripMenuItem,
                receiptReportToolStripMenuItem,
                journalReportToolStripMenuItem,
                pDCPayableReportToolStripMenuItem,
                pDCReceivableReportToolStripMenuItem,
                pDCClearanceToolStripMenuItem1,
                purchaseOrderReportToolStripMenuItem,
                materialReceiptReportToolStripMenuItem,
                rejectionOutReportToolStripMenuItem,
                purchaseInvoiceReportToolStripMenuItem,
                purchaseReturnReportToolStripMenuItem,
                salesQuotationReportToolStripMenuItem,
                salesOrderReportToolStripMenuItem,
                deliveryNoteReportToolStripMenuItem,
                rejectionInReportToolStripMenuItem,
                salesInvoiceReportToolStripMenuItem,
                salesReturnReportToolStripMenuItem,
                physicalStockReportToolStripMenuItem,
                serviceReportToolStripMenuItem,
                creditNoteReportToolStripMenuItem,
                debitNoteReportToolStripMenuItem,
                stockJournalReportToolStripMenuItem
            });
            toolStripMenuItem18.Name = "toolStripMenuItem18";
            toolStripMenuItem18.Size = new Size(202, 22);
            toolStripMenuItem18.Text = "Transactions";
            contraReportToolStripMenuItem.Name = "contraReportToolStripMenuItem";
            contraReportToolStripMenuItem.Size = new Size(201, 22);
            contraReportToolStripMenuItem.Text = "Contra Report";
            contraReportToolStripMenuItem.Click += contraReportToolStripMenuItem_Click;
            paymentReportToolStripMenuItem.Name = "paymentReportToolStripMenuItem";
            paymentReportToolStripMenuItem.Size = new Size(201, 22);
            paymentReportToolStripMenuItem.Text = "Payment Report";
            paymentReportToolStripMenuItem.Click += paymentReportToolStripMenuItem_Click;
            receiptReportToolStripMenuItem.Name = "receiptReportToolStripMenuItem";
            receiptReportToolStripMenuItem.Size = new Size(201, 22);
            receiptReportToolStripMenuItem.Text = "Receipt Report";
            receiptReportToolStripMenuItem.Click += receiptReportToolStripMenuItem_Click;
            journalReportToolStripMenuItem.Name = "journalReportToolStripMenuItem";
            journalReportToolStripMenuItem.Size = new Size(201, 22);
            journalReportToolStripMenuItem.Text = "Journal Report";
            journalReportToolStripMenuItem.Click += journalReportToolStripMenuItem_Click;
            pDCPayableReportToolStripMenuItem.Name = "pDCPayableReportToolStripMenuItem";
            pDCPayableReportToolStripMenuItem.Size = new Size(201, 22);
            pDCPayableReportToolStripMenuItem.Text = "PDC Payable Report";
            pDCPayableReportToolStripMenuItem.Click += pDCPayableReportToolStripMenuItem_Click;
            pDCReceivableReportToolStripMenuItem.Name = "pDCReceivableReportToolStripMenuItem";
            pDCReceivableReportToolStripMenuItem.Size = new Size(201, 22);
            pDCReceivableReportToolStripMenuItem.Text = "PDC Receivable Report";
            pDCReceivableReportToolStripMenuItem.Click += pDCReceivableReportToolStripMenuItem_Click;
            pDCClearanceToolStripMenuItem1.Name = "pDCClearanceToolStripMenuItem1";
            pDCClearanceToolStripMenuItem1.Size = new Size(201, 22);
            pDCClearanceToolStripMenuItem1.Text = "PDC Clearance Report";
            pDCClearanceToolStripMenuItem1.Click += pDCClearanceToolStripMenuItem1_Click;
            purchaseOrderReportToolStripMenuItem.Name = "purchaseOrderReportToolStripMenuItem";
            purchaseOrderReportToolStripMenuItem.Size = new Size(201, 22);
            purchaseOrderReportToolStripMenuItem.Text = "Purchase Order Report";
            purchaseOrderReportToolStripMenuItem.Click += purchaseOrderReportToolStripMenuItem_Click;
            materialReceiptReportToolStripMenuItem.Name = "materialReceiptReportToolStripMenuItem";
            materialReceiptReportToolStripMenuItem.Size = new Size(201, 22);
            materialReceiptReportToolStripMenuItem.Text = "Material Receipt Report";
            materialReceiptReportToolStripMenuItem.Click += materialReceiptReportToolStripMenuItem_Click;
            rejectionOutReportToolStripMenuItem.Name = "rejectionOutReportToolStripMenuItem";
            rejectionOutReportToolStripMenuItem.Size = new Size(201, 22);
            rejectionOutReportToolStripMenuItem.Text = "Rejection Out Report";
            rejectionOutReportToolStripMenuItem.Click += rejectionOutReportToolStripMenuItem_Click;
            purchaseInvoiceReportToolStripMenuItem.Name = "purchaseInvoiceReportToolStripMenuItem";
            purchaseInvoiceReportToolStripMenuItem.Size = new Size(201, 22);
            purchaseInvoiceReportToolStripMenuItem.Text = "Purchase Invoice Report";
            purchaseInvoiceReportToolStripMenuItem.Click += purchaseInvoiceReportToolStripMenuItem_Click;
            purchaseReturnReportToolStripMenuItem.Name = "purchaseReturnReportToolStripMenuItem";
            purchaseReturnReportToolStripMenuItem.Size = new Size(201, 22);
            purchaseReturnReportToolStripMenuItem.Text = "Purchase Return Report";
            purchaseReturnReportToolStripMenuItem.Click += purchaseReturnReportToolStripMenuItem_Click;
            salesQuotationReportToolStripMenuItem.Name = "salesQuotationReportToolStripMenuItem";
            salesQuotationReportToolStripMenuItem.Size = new Size(201, 22);
            salesQuotationReportToolStripMenuItem.Text = "Sales Quotation Report";
            salesQuotationReportToolStripMenuItem.Click += salesQuotationReportToolStripMenuItem_Click;
            salesOrderReportToolStripMenuItem.Name = "salesOrderReportToolStripMenuItem";
            salesOrderReportToolStripMenuItem.Size = new Size(201, 22);
            salesOrderReportToolStripMenuItem.Text = "Sales Order Report";
            salesOrderReportToolStripMenuItem.Click += salesOrderReportToolStripMenuItem_Click;
            deliveryNoteReportToolStripMenuItem.Name = "deliveryNoteReportToolStripMenuItem";
            deliveryNoteReportToolStripMenuItem.Size = new Size(201, 22);
            deliveryNoteReportToolStripMenuItem.Text = "Delivery Note Report";
            deliveryNoteReportToolStripMenuItem.Click += deliveryNoteReportToolStripMenuItem_Click;
            rejectionInReportToolStripMenuItem.Name = "rejectionInReportToolStripMenuItem";
            rejectionInReportToolStripMenuItem.Size = new Size(201, 22);
            rejectionInReportToolStripMenuItem.Text = "Rejection In Report";
            rejectionInReportToolStripMenuItem.Click += rejectionInReportToolStripMenuItem_Click;
            salesInvoiceReportToolStripMenuItem.Name = "salesInvoiceReportToolStripMenuItem";
            salesInvoiceReportToolStripMenuItem.Size = new Size(201, 22);
            salesInvoiceReportToolStripMenuItem.Text = "Sales Invoice Report";
            salesInvoiceReportToolStripMenuItem.Click += salesInvoiceReportToolStripMenuItem_Click;
            salesReturnReportToolStripMenuItem.Name = "salesReturnReportToolStripMenuItem";
            salesReturnReportToolStripMenuItem.Size = new Size(201, 22);
            salesReturnReportToolStripMenuItem.Text = "Sales Return Report";
            salesReturnReportToolStripMenuItem.Click += salesReturnReportToolStripMenuItem_Click;
            physicalStockReportToolStripMenuItem.Name = "physicalStockReportToolStripMenuItem";
            physicalStockReportToolStripMenuItem.Size = new Size(201, 22);
            physicalStockReportToolStripMenuItem.Text = "Physical Stock Report";
            physicalStockReportToolStripMenuItem.Click += physicalStockReportToolStripMenuItem_Click;
            serviceReportToolStripMenuItem.Name = "serviceReportToolStripMenuItem";
            serviceReportToolStripMenuItem.Size = new Size(201, 22);
            serviceReportToolStripMenuItem.Text = "Service Report";
            serviceReportToolStripMenuItem.Click += serviceReportToolStripMenuItem_Click;
            creditNoteReportToolStripMenuItem.Name = "creditNoteReportToolStripMenuItem";
            creditNoteReportToolStripMenuItem.Size = new Size(201, 22);
            creditNoteReportToolStripMenuItem.Text = "Credit Note Report";
            creditNoteReportToolStripMenuItem.Click += creditNoteReportToolStripMenuItem_Click;
            debitNoteReportToolStripMenuItem.Name = "debitNoteReportToolStripMenuItem";
            debitNoteReportToolStripMenuItem.Size = new Size(201, 22);
            debitNoteReportToolStripMenuItem.Text = "Debit Note Report";
            debitNoteReportToolStripMenuItem.Click += debitNoteReportToolStripMenuItem_Click;
            stockJournalReportToolStripMenuItem.Name = "stockJournalReportToolStripMenuItem";
            stockJournalReportToolStripMenuItem.Size = new Size(201, 22);
            stockJournalReportToolStripMenuItem.Text = "Stock Journal Report";
            stockJournalReportToolStripMenuItem.Click += stockJournalReportToolStripMenuItem_Click;
            payrollToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[10]
            {
                employeeToolStripMenuItem,
                dailyAttendanceToolStripMenuItem,
                monthlyAttendanceToolStripMenuItem,
                dailySalaryToolStripMenuItem,
                monthlySalaryToolStripMenuItem,
                payheadToolStripMenuItem,
                salaryPackageToolStripMenuItem,
                advancePaymentToolStripMenuItem1,
                bonusDeductionToolStripMenuItem,
                employeeAddressBookToolStripMenuItem
            });
            payrollToolStripMenuItem1.Font = new Font("Tahoma", 8.25f);
            payrollToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            payrollToolStripMenuItem1.Name = "payrollToolStripMenuItem1";
            payrollToolStripMenuItem1.Size = new Size(202, 22);
            payrollToolStripMenuItem1.Text = "Payroll";
            employeeToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            employeeToolStripMenuItem.ForeColor = SystemColors.ControlText;
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(188, 22);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            dailyAttendanceToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            dailyAttendanceToolStripMenuItem.ForeColor = SystemColors.ControlText;
            dailyAttendanceToolStripMenuItem.Name = "dailyAttendanceToolStripMenuItem";
            dailyAttendanceToolStripMenuItem.Size = new Size(188, 22);
            dailyAttendanceToolStripMenuItem.Text = "Daily Attendance";
            dailyAttendanceToolStripMenuItem.Click += dailyAttendanceToolStripMenuItem_Click;
            monthlyAttendanceToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            monthlyAttendanceToolStripMenuItem.ForeColor = SystemColors.ControlText;
            monthlyAttendanceToolStripMenuItem.Name = "monthlyAttendanceToolStripMenuItem";
            monthlyAttendanceToolStripMenuItem.Size = new Size(188, 22);
            monthlyAttendanceToolStripMenuItem.Text = "Monthly Attendance";
            monthlyAttendanceToolStripMenuItem.Click += monthlyAttendanceToolStripMenuItem_Click;
            dailySalaryToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            dailySalaryToolStripMenuItem.ForeColor = SystemColors.ControlText;
            dailySalaryToolStripMenuItem.Name = "dailySalaryToolStripMenuItem";
            dailySalaryToolStripMenuItem.Size = new Size(188, 22);
            dailySalaryToolStripMenuItem.Text = "Daily Salary";
            dailySalaryToolStripMenuItem.Click += dailySalaryToolStripMenuItem_Click;
            monthlySalaryToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            monthlySalaryToolStripMenuItem.ForeColor = SystemColors.ControlText;
            monthlySalaryToolStripMenuItem.Name = "monthlySalaryToolStripMenuItem";
            monthlySalaryToolStripMenuItem.Size = new Size(188, 22);
            monthlySalaryToolStripMenuItem.Text = "Monthly Salary";
            monthlySalaryToolStripMenuItem.Click += monthlySalaryToolStripMenuItem_Click;
            payheadToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            payheadToolStripMenuItem.ForeColor = SystemColors.ControlText;
            payheadToolStripMenuItem.Name = "payheadToolStripMenuItem";
            payheadToolStripMenuItem.Size = new Size(188, 22);
            payheadToolStripMenuItem.Text = "Payhead";
            payheadToolStripMenuItem.Click += payheadToolStripMenuItem_Click;
            salaryPackageToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            salaryPackageToolStripMenuItem.ForeColor = SystemColors.ControlText;
            salaryPackageToolStripMenuItem.Name = "salaryPackageToolStripMenuItem";
            salaryPackageToolStripMenuItem.Size = new Size(188, 22);
            salaryPackageToolStripMenuItem.Text = "Salary Package";
            salaryPackageToolStripMenuItem.Click += salaryPackageToolStripMenuItem_Click;
            advancePaymentToolStripMenuItem1.Font = new Font("Tahoma", 8.25f);
            advancePaymentToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            advancePaymentToolStripMenuItem1.Name = "advancePaymentToolStripMenuItem1";
            advancePaymentToolStripMenuItem1.Size = new Size(188, 22);
            advancePaymentToolStripMenuItem1.Text = "Advance Payment";
            advancePaymentToolStripMenuItem1.Click += advancePaymentToolStripMenuItem1_Click;
            bonusDeductionToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            bonusDeductionToolStripMenuItem.ForeColor = SystemColors.ControlText;
            bonusDeductionToolStripMenuItem.Name = "bonusDeductionToolStripMenuItem";
            bonusDeductionToolStripMenuItem.Size = new Size(188, 22);
            bonusDeductionToolStripMenuItem.Text = "Bonus Deduction";
            bonusDeductionToolStripMenuItem.Click += bonusDeductionToolStripMenuItem_Click;
            employeeAddressBookToolStripMenuItem.Font = new Font("Tahoma", 8.25f);
            employeeAddressBookToolStripMenuItem.ForeColor = SystemColors.ControlText;
            employeeAddressBookToolStripMenuItem.Name = "employeeAddressBookToolStripMenuItem";
            employeeAddressBookToolStripMenuItem.Size = new Size(188, 22);
            employeeAddressBookToolStripMenuItem.Text = "Employee Address Book";
            employeeAddressBookToolStripMenuItem.Click += employeeAddressBookToolStripMenuItem_Click;
            dayBookToolStripMenuItem1.Name = "dayBookToolStripMenuItem1";
            dayBookToolStripMenuItem1.Size = new Size(202, 22);
            dayBookToolStripMenuItem1.Text = "Day Book";
            dayBookToolStripMenuItem1.Click += dayBookToolStripMenuItem1_Click;
            cashBToolStripMenuItem.Name = "cashBToolStripMenuItem";
            cashBToolStripMenuItem.Size = new Size(202, 22);
            cashBToolStripMenuItem.Text = "Cash/Bank Book";
            cashBToolStripMenuItem.Click += cashBToolStripMenuItem_Click;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(202, 22);
            toolStripMenuItem6.Text = "Account Group Report";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(202, 22);
            toolStripMenuItem7.Text = "Account Ledger Report";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(202, 22);
            toolStripMenuItem8.Text = "Outstanding Report";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(202, 22);
            toolStripMenuItem9.Text = "Ageing Report";
            toolStripMenuItem9.Click += toolStripMenuItem9_Click;
            PartyAddressBooktoolStripMenuItem.Name = "PartyAddressBooktoolStripMenuItem";
            PartyAddressBooktoolStripMenuItem.Size = new Size(202, 22);
            PartyAddressBooktoolStripMenuItem.Text = "Party's Address Book";
            PartyAddressBooktoolStripMenuItem.Click += PartyAddressBooktoolStripMenuItem_Click;
            StockReporttoolStripMenuItem.Name = "StockReporttoolStripMenuItem";
            StockReporttoolStripMenuItem.Size = new Size(202, 22);
            StockReporttoolStripMenuItem.Text = "Stock Report";
            StockReporttoolStripMenuItem.Click += StockReporttoolStripMenuItem_Click;
            ShortExpiryReporttoolStripMenuItem.Name = "ShortExpiryReporttoolStripMenuItem";
            ShortExpiryReporttoolStripMenuItem.Size = new Size(202, 22);
            ShortExpiryReporttoolStripMenuItem.Text = "Short Expiry Report";
            ShortExpiryReporttoolStripMenuItem.Click += ShortExpiryReporttoolStripMenuItem_Click;
            ProductStaticstoolStripMenuItem.Name = "ProductStaticstoolStripMenuItem";
            ProductStaticstoolStripMenuItem.Size = new Size(202, 22);
            ProductStaticstoolStripMenuItem.Text = "Product Statistics";
            ProductStaticstoolStripMenuItem.Click += ProductStaticstoolStripMenuItem_Click;
            PriceListReporttoolStripMenuItem.Name = "PriceListReporttoolStripMenuItem";
            PriceListReporttoolStripMenuItem.Size = new Size(202, 22);
            PriceListReporttoolStripMenuItem.Text = "Price List Report";
            PriceListReporttoolStripMenuItem.Click += PriceListReporttoolStripMenuItem_Click;
            TaxReporttoolStripMenuItem.Name = "TaxReporttoolStripMenuItem";
            TaxReporttoolStripMenuItem.Size = new Size(202, 22);
            TaxReporttoolStripMenuItem.Text = "Tax Report";
            TaxReporttoolStripMenuItem.Click += TaxReporttoolStripMenuItem_Click;
            VatReporttoolStripMenuItem.Name = "VatReporttoolStripMenuItem";
            VatReporttoolStripMenuItem.Size = new Size(202, 22);
            VatReporttoolStripMenuItem.Text = "VAT Return Report";
            VatReporttoolStripMenuItem.Click += VatReporttoolStripMenuItem_Click;
            ChequeReporttoolStripMenuItem.Name = "ChequeReporttoolStripMenuItem";
            ChequeReporttoolStripMenuItem.Size = new Size(202, 22);
            ChequeReporttoolStripMenuItem.Text = "Cheque Report";
            ChequeReporttoolStripMenuItem.Click += ChequeReporttoolStripMenuItem_Click;
            freeSaleReportToolStripMenuItem.Name = "freeSaleReportToolStripMenuItem";
            freeSaleReportToolStripMenuItem.Size = new Size(202, 22);
            freeSaleReportToolStripMenuItem.Text = "Free Sale Report";
            freeSaleReportToolStripMenuItem.Click += freeSaleReportToolStripMenuItem_Click;
            productVsBatchReportToolStripMenuItem.Name = "productVsBatchReportToolStripMenuItem";
            productVsBatchReportToolStripMenuItem.Size = new Size(202, 22);
            productVsBatchReportToolStripMenuItem.Text = "Product Vs Batch Report";
            productVsBatchReportToolStripMenuItem.Click += productVsBatchReportToolStripMenuItem_Click;
            utilitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
                miracleSkateToolStripMenuItem,
                miracleIToolStripMenuItem
            });
            utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            utilitiesToolStripMenuItem.Size = new Size(58, 20);
            utilitiesToolStripMenuItem.Text = "Utilities";
            miracleSkateToolStripMenuItem.Name = "miracleSkateToolStripMenuItem";
            miracleSkateToolStripMenuItem.Size = new Size(144, 22);
            miracleSkateToolStripMenuItem.Text = "Miracle Skate";
            miracleSkateToolStripMenuItem.Click += miracleSkateToolStripMenuItem_Click;
            miracleIToolStripMenuItem.Name = "miracleIToolStripMenuItem";
            miracleIToolStripMenuItem.Size = new Size(144, 22);
            miracleIToolStripMenuItem.Text = "Miracle I";
            miracleIToolStripMenuItem.Click += miracleIToolStripMenuItem_Click;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
                aboutUsToolStripMenuItem,
                contentsToolStripMenuItem
            });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(123, 22);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(123, 22);
            contentsToolStripMenuItem.Text = "Contents";
            contentsToolStripMenuItem.Click += contentsToolStripMenuItem_Click;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem";
            ContactUsToolStripMenuItem.Size = new Size(77, 20);
            ContactUsToolStripMenuItem.Text = "Contact Us";
            ContactUsToolStripMenuItem.Click += ContactUsToolStripMenuItem_Click;
            dateToolStripMenuItem.BackColor = Color.Gainsboro;
            dateToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
            dateToolStripMenuItem.ForeColor = Color.Black;
            dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            dateToolStripMenuItem.Size = new Size(12, 20);
            dateToolStripMenuItem.Click += dateToolStripMenuItem_Click;
            statusStrip.Items.AddRange(new ToolStripItem[1]
            {
                toolStripStatusLabel
            });
            statusStrip.Location = new Point(0, 638);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1078, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            statusStrip.Visible = false;
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            BackgrndWrkrLoading.DoWork += BackgrndWrkrLoading_DoWork;
            BackgrndWrkrLoading.RunWorkerCompleted += BackgrndWrkrLoading_RunWorkerCompleted;
            //ucCalculator1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            //ucCalculator1.BackColor = Color.DimGray;
            //ucCalculator1.BorderStyle = BorderStyle.FixedSingle;
            //ucCalculator1.Cursor = Cursors.NoMove2D;
            //ucCalculator1.Location = new Point(479, 282);
            //ucCalculator1.Name = "ucCalculator1";
            //ucCalculator1.Size = new Size(150, 195);
            //ucCalculator1.TabIndex = 8;
            //ucCalculator1.Visible = false;
            ucQuickLaunch1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            ucQuickLaunch1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            ucQuickLaunch1.BackColor = Color.Gray;
            ucQuickLaunch1.BorderStyle = BorderStyle.FixedSingle;
            ucQuickLaunch1.Cursor = Cursors.NoMove2D;
            ucQuickLaunch1.Location = new Point(860, 116);
            ucQuickLaunch1.Name = "ucQuickLaunch1";
            ucQuickLaunch1.Size = new Size(190, 530);
            ucQuickLaunch1.TabIndex = 4;
            ucQuickLaunch1.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            //BackgroundImage = Resources.ms_sql;
            BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(1078, 660);
            //base.Controls.Add(ucCalculator1);
           // base.Controls.Add(ucQuickLaunch1);
            base.Controls.Add(statusStrip);
            base.Controls.Add(menuStrip);
            DoubleBuffered = true;
           // base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.IsMdiContainer = true;
            base.KeyPreview = true;
            base.MainMenuStrip = menuStrip;
            base.Name = "formMDI";
            Text = "Openmiracle";
            base.WindowState = FormWindowState.Maximized;
            base.Load += formMDI_Load;
            base.KeyDown += formMDI_KeyDown;
            base.Resize += formMDI_Resize;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        #endregion
        //private System.Windows.Forms.StatusStrip statusStrip;
        //private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        //private System.Windows.Forms.ToolTip toolTip;
        //private System.Windows.Forms.MenuStrip menuStrip;
        //private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem createCompanyToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem SelectCompanyToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem editCompanyToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem BackUpToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem RestoreToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem accountGroupToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem accountLedgerToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem multipleAccountLedgersToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem productGroupToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem productCreationToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem multipleProductCreationToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem modelNumberToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem godownToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem rackToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pricingLevelToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem priceListToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem standardRateToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem taxToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem exchangeRateToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem serviceCategoryToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem voucherTypeToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem counterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem productRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesManToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem contraVoucherToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem paymentVoucherToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem receiptVoucherToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem journalVoucherToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pdcPayableToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pdcReceivableToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pdcClearanceToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem bankReconciliationToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem materialRecieptToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem rejectionOutToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem purchaseReturnToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesQuatationToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        //private System.Windows.Forms.ToolStripMenuItem rejectionInToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesReturnToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem physicalStockToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem serviceVoucherToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem creditNoteToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem debitNoteToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem stockJournalToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem billAllocationToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem ContraRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem paymentRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem receiptRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem journalRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem pDCPayableRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pDCReceivableRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem PDCClearanceRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem frmPurchaseOrderRegistertoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem materialReceiptRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem rejectionOutRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem purchaseReturnRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem salesQuotationRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesOrderRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem deliveryNoteRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem rejectionInRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem salesInvoiceRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem salesReturnRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem physicalStockRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem serviceVoucherRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem creditNoteRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem debitNoteRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem stockJournalRegisterToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem designationToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem payHeadToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem salaryPackageCreationToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salaryPackageRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem employeeCreationToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem employeeRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem holidaySettingsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem monthlySalarySettingsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem mmAttendance;
        //private System.Windows.Forms.ToolStripMenuItem advancePaymentToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem mmadvanceRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem bonusDeductionToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem bonusDeductionRegisterToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem frmMonthlySalaryVoucherToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem monthlySalaryRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem DailySalaryVouchertoolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem dailySalaryRegisterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem paySlipToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem budgetToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem budgetingToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem budgetVarianceToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem changeCurrentDateToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem rolePrivileToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem userCreationToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem newFinancialYearToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem changeFinancialYearToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem bracodeSettingsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem barcodePrintingToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem suffixPrefixSettingsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem changeProductTaxToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem dotmatrixPrintDesignerToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem rebuildIndexingToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem productSearchToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem voucherSearchToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem voucherWiseProductSearchToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem reminderToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem personalReminderToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem overduePurchaseOrderToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem overdueSalesOrderToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem shortExpiryToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem financialStatementToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem trialBalanceToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem profitAndLossToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem cashFlowToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem fundFlowToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem chartOfAccountToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        //private System.Windows.Forms.ToolStripMenuItem contraReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem paymentReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem receiptReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem journalReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pDCPayableReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pDCReceivableReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem pDCClearanceToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem purchaseOrderReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem materialReceiptReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem rejectionOutReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem purchaseReturnReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesQuotationReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesOrderReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem deliveryNoteReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem rejectionInReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesInvoiceReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salesReturnReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem physicalStockReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem serviceReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem creditNoteReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem debitNoteReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem stockJournalReportToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem dailyAttendanceToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem monthlyAttendanceToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem dailySalaryToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem monthlySalaryToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem payheadToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem salaryPackageToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem advancePaymentToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem bonusDeductionToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem employeeAddressBookToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem dayBookToolStripMenuItem1;
        //private System.Windows.Forms.ToolStripMenuItem cashBToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        //private System.Windows.Forms.ToolStripMenuItem PartyAddressBooktoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem StockReporttoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem ShortExpiryReporttoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem ProductStaticstoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem PriceListReporttoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem TaxReporttoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem VatReporttoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem ChequeReporttoolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem freeSaleReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem productVsBatchReportToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem miracleSkateToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem miracleIToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem ContactUsToolStripMenuItem;
        //public System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        //private IContainer components = null;

        private MenuStrip menuStrip;

        private StatusStrip statusStrip;

        private ToolStripStatusLabel toolStripStatusLabel;

        private ToolStripMenuItem registerToolStripMenuItem;

        private ToolStripMenuItem ContraRegisterToolStripMenuItem;

        private ToolTip toolTip;

        private ToolStripMenuItem employeeCreationToolStripMenuItem;

        private ToolStripMenuItem salaryPackageCreationToolStripMenuItem;

        private ToolStripMenuItem advancePaymentToolStripMenuItem;

        private ToolStripMenuItem employeeRegisterToolStripMenuItem;

        private ToolStripMenuItem mmAttendance;

        private ToolStripMenuItem mmadvanceRegisterToolStripMenuItem;

        private ToolStripMenuItem monthlySalarySettingsToolStripMenuItem;

        private ToolStripMenuItem frmMonthlySalaryVoucherToolStripMenuItem;

        private ToolStripMenuItem holidaySettingsToolStripMenuItem;

        private ToolStripMenuItem bonusDeductionToolStripMenuItem1;

        private ToolStripMenuItem bonusDeductionRegisterToolStripMenuItem1;

        private ToolStripMenuItem mastersToolStripMenuItem;

        private ToolStripMenuItem accountGroupToolStripMenuItem;

        private ToolStripMenuItem productGroupToolStripMenuItem;

        private ToolStripMenuItem multipleAccountLedgersToolStripMenuItem;

        private ToolStripMenuItem brandToolStripMenuItem;

        private ToolStripMenuItem unitToolStripMenuItem;

        private ToolStripMenuItem exchangeRateToolStripMenuItem;

        private ToolStripMenuItem multipleProductCreationToolStripMenuItem;

        private ToolStripMenuItem priceListToolStripMenuItem;

        private ToolStripMenuItem pricingLevelToolStripMenuItem;

        private ToolStripMenuItem productRegisterToolStripMenuItem;

        private ToolStripMenuItem serviceCategoryToolStripMenuItem;

        private ToolStripMenuItem servicesToolStripMenuItem;

        private ToolStripMenuItem standardRateToolStripMenuItem;

        private ToolStripMenuItem voucherTypeToolStripMenuItem;

        private ToolStripMenuItem accountLedgerToolStripMenuItem;

        private ToolStripMenuItem DailySalaryVouchertoolStripMenuItem1;

        private ToolStripMenuItem dailySalaryRegisterToolStripMenuItem;

        private ToolStripMenuItem salaryPackageRegisterToolStripMenuItem;

        private ToolStripMenuItem monthlySalaryRegisterToolStripMenuItem;

        private ToolStripMenuItem areaToolStripMenuItem;

        private ToolStripMenuItem counterToolStripMenuItem;

        private ToolStripMenuItem customerToolStripMenuItem;

        private ToolStripMenuItem supplierToolStripMenuItem;

        private ToolStripMenuItem productCreationToolStripMenuItem;

        private ToolStripMenuItem routeToolStripMenuItem;

        private ToolStripMenuItem transactionToolStripMenuItem;

        private ToolStripMenuItem journalVoucherToolStripMenuItem;

        private ToolStripMenuItem pdcClearanceToolStripMenuItem;

        private ToolStripMenuItem companyToolStripMenuItem;

        private ToolStripMenuItem createCompanyToolStripMenuItem;

        private ToolStripMenuItem SelectCompanyToolStripMenuItem;

        private ToolStripMenuItem designationToolStripMenuItem1;

        private ToolStripMenuItem payHeadToolStripMenuItem1;

        private ToolStripMenuItem paymentVoucherToolStripMenuItem;

        private ToolStripMenuItem receiptVoucherToolStripMenuItem;

        private ToolStripMenuItem pdcPayableToolStripMenuItem;

        private ToolStripMenuItem pdcReceivableToolStripMenuItem;

        private ToolStripMenuItem bankReconciliationToolStripMenuItem;

        private ToolStripMenuItem purchaseOrderToolStripMenuItem;

        private ToolStripMenuItem materialRecieptToolStripMenuItem;

        private ToolStripMenuItem rejectionOutToolStripMenuItem;

        private ToolStripMenuItem purchaseInvoiceToolStripMenuItem;

        private ToolStripMenuItem purchaseReturnToolStripMenuItem;

        private ToolStripMenuItem salesQuatationToolStripMenuItem;

        private ToolStripMenuItem salesOrderToolStripMenuItem;

        private ToolStripMenuItem rejectionInToolStripMenuItem;

        private ToolStripMenuItem salesInvoiceToolStripMenuItem;

        private ToolStripMenuItem salesReturnToolStripMenuItem;

        private ToolStripMenuItem physicalStockToolStripMenuItem;

        private ToolStripMenuItem serviceVoucherToolStripMenuItem;

        private ToolStripMenuItem creditNoteToolStripMenuItem;

        private ToolStripMenuItem debitNoteToolStripMenuItem;

        private ToolStripMenuItem paySlipToolStripMenuItem;

        private ToolStripMenuItem paymentRegisterToolStripMenuItem;

        private ToolStripMenuItem receiptRegisterToolStripMenuItem1;

        private ToolStripMenuItem journalRegisterToolStripMenuItem1;

        private ToolStripMenuItem pDCPayableRegisterToolStripMenuItem;

        private ToolStripMenuItem pDCReceivableRegisterToolStripMenuItem1;

        private ToolStripMenuItem materialReceiptRegisterToolStripMenuItem;

        private ToolStripMenuItem rejectionOutRegisterToolStripMenuItem1;

        private ToolStripMenuItem purchaseInvoiceRegisterToolStripMenuItem1;

        private ToolStripMenuItem purchaseReturnRegisterToolStripMenuItem1;

        private ToolStripMenuItem salesQuotationRegisterToolStripMenuItem;

        private ToolStripMenuItem salesOrderRegisterToolStripMenuItem1;

        private ToolStripMenuItem deliveryNoteRegisterToolStripMenuItem;

        private ToolStripMenuItem rejectionInRegisterToolStripMenuItem1;

        private ToolStripMenuItem salesInvoiceRegisterToolStripMenuItem1;

        private ToolStripMenuItem salesReturnRegisterToolStripMenuItem1;

        private ToolStripMenuItem physicalStockRegisterToolStripMenuItem1;

        private ToolStripMenuItem serviceVoucherRegisterToolStripMenuItem1;

        private ToolStripMenuItem creditNoteRegisterToolStripMenuItem1;

        private ToolStripMenuItem debitNoteRegisterToolStripMenuItem1;

        private ToolStripMenuItem stockJournalRegisterToolStripMenuItem;

        private ToolStripMenuItem settingsToolStripMenuItem;

        private ToolStripMenuItem searchToolStripMenuItem;

        private ToolStripMenuItem reminderToolStripMenuItem;

        private ToolStripMenuItem financialStatementToolStripMenuItem;

        private ToolStripMenuItem reportsToolStripMenuItem;

        private ToolStripMenuItem stockJournalToolStripMenuItem;

        private ToolStripMenuItem barcodePrintingToolStripMenuItem;

        private ToolStripMenuItem bracodeSettingsToolStripMenuItem;

        private ToolStripMenuItem changeCurrentDateToolStripMenuItem;

        private ToolStripMenuItem changeFinancialYearToolStripMenuItem;

        private ToolStripMenuItem changePasswordToolStripMenuItem;

        private ToolStripMenuItem newFinancialYearToolStripMenuItem;

        private ToolStripMenuItem settingsToolStripMenuItem1;

        private ToolStripMenuItem userCreationToolStripMenuItem;

        private ToolStripMenuItem productSearchToolStripMenuItem;

        private ToolStripMenuItem voucherSearchToolStripMenuItem;

        private ToolStripMenuItem voucherWiseProductSearchToolStripMenuItem;

        private ToolStripMenuItem overduePurchaseOrderToolStripMenuItem;

        private ToolStripMenuItem overdueSalesOrderToolStripMenuItem;

        private ToolStripMenuItem personalReminderToolStripMenuItem;

        private ToolStripMenuItem shortExpiryToolStripMenuItem;

        private ToolStripMenuItem stockToolStripMenuItem;

        private ToolStripMenuItem editCompanyToolStripMenuItem1;

        private ToolStripMenuItem closeToolStripMenuItem;

        private ToolStripMenuItem roleToolStripMenuItem;

        private ToolStripMenuItem rolePrivileToolStripMenuItem;

        private ToolStripMenuItem budgetingToolStripMenuItem;

        private ToolStripMenuItem budgetVarianceToolStripMenuItem;

        private ToolStripMenuItem helpToolStripMenuItem;

        private ToolStripMenuItem exitToolStripMenuItem;

        private ToolStripMenuItem profitAndLossToolStripMenuItem;

        private ToolStripMenuItem balanceSheetToolStripMenuItem;

        private ToolStripMenuItem trialBalanceToolStripMenuItem;

        private ToolStripMenuItem cashFlowToolStripMenuItem;

        private ToolStripMenuItem fundFlowToolStripMenuItem;

        private ToolStripMenuItem chartOfAccountToolStripMenuItem;

        private ToolStripMenuItem cashBToolStripMenuItem;

        private ToolStripMenuItem dayBookToolStripMenuItem1;

        private ToolStripMenuItem employeeToolStripMenuItem;

        private ToolStripMenuItem dailyAttendanceToolStripMenuItem;

        private ToolStripMenuItem monthlyAttendanceToolStripMenuItem;

        private ToolStripMenuItem dailySalaryToolStripMenuItem;

        private ToolStripMenuItem monthlySalaryToolStripMenuItem;

        private ToolStripMenuItem payheadToolStripMenuItem;

        private ToolStripMenuItem salaryPackageToolStripMenuItem;

        private ToolStripMenuItem advancePaymentToolStripMenuItem1;

        private ToolStripMenuItem bonusDeductionToolStripMenuItem;

        private ToolStripMenuItem employeeAddressBookToolStripMenuItem;

        private ToolStripMenuItem BackUpToolStripMenuItem;

        private ToolStripMenuItem RestoreToolStripMenuItem;

        private ToolStripMenuItem toolStripMenuItem3;

        private ToolStripMenuItem billAllocationToolStripMenuItem;

        private ToolStripMenuItem PDCClearanceRegisterToolStripMenuItem;

        private ToolStripMenuItem frmPurchaseOrderRegistertoolStripMenuItem;

        private ToolStripMenuItem toolStripMenuItem6;

        private ToolStripMenuItem toolStripMenuItem7;

        private ToolStripMenuItem toolStripMenuItem18;

        private ToolStripMenuItem contraReportToolStripMenuItem;

        private ToolStripMenuItem paymentReportToolStripMenuItem;

        private ToolStripMenuItem receiptReportToolStripMenuItem;

        private ToolStripMenuItem journalReportToolStripMenuItem;

        private ToolStripMenuItem serviceReportToolStripMenuItem;

        private ToolStripMenuItem pDCPayableReportToolStripMenuItem;

        private ToolStripMenuItem pDCReceivableReportToolStripMenuItem;

        private ToolStripMenuItem pDCClearanceToolStripMenuItem1;

        private ToolStripMenuItem purchaseOrderReportToolStripMenuItem;

        private ToolStripMenuItem materialReceiptReportToolStripMenuItem;

        private ToolStripMenuItem rejectionOutReportToolStripMenuItem;

        private ToolStripMenuItem purchaseInvoiceReportToolStripMenuItem;

        private ToolStripMenuItem purchaseReturnReportToolStripMenuItem;

        private ToolStripMenuItem salesQuotationReportToolStripMenuItem;

        private ToolStripMenuItem salesOrderReportToolStripMenuItem;

        private ToolStripMenuItem deliveryNoteReportToolStripMenuItem;

        private ToolStripMenuItem rejectionInReportToolStripMenuItem;

        private ToolStripMenuItem salesInvoiceReportToolStripMenuItem;

        private ToolStripMenuItem salesReturnReportToolStripMenuItem;

        private ToolStripMenuItem stockJournalReportToolStripMenuItem;

        private ToolStripMenuItem physicalStockReportToolStripMenuItem;

        private ToolStripMenuItem creditNoteReportToolStripMenuItem;

        private ToolStripMenuItem debitNoteReportToolStripMenuItem;

        private ToolStripMenuItem toolStripMenuItem8;

        private ToolStripMenuItem toolStripMenuItem9;

        private ToolStripMenuItem PartyAddressBooktoolStripMenuItem;

        private ToolStripMenuItem StockReporttoolStripMenuItem;

        private ToolStripMenuItem ShortExpiryReporttoolStripMenuItem;

        private ToolStripMenuItem ProductStaticstoolStripMenuItem;

        private ToolStripMenuItem PriceListReporttoolStripMenuItem;

        private ToolStripMenuItem TaxReporttoolStripMenuItem;

        private ToolStripMenuItem VatReporttoolStripMenuItem;

        private ToolStripMenuItem ChequeReporttoolStripMenuItem;

        private ToolStripMenuItem changeProductTaxToolStripMenuItem;

        private ToolStripMenuItem suffixPrefixSettingsToolStripMenuItem;

        private ToolStripMenuItem freeSaleReportToolStripMenuItem;

        private ToolStripMenuItem productVsBatchReportToolStripMenuItem;

        private ToolStripMenuItem dotmatrixPrintDesignerToolStripMenuItem;

        private ToolStripMenuItem salesManToolStripMenuItem1;

        private ToolStripMenuItem pOSToolStripMenuItem;

        private ToolStripMenuItem contraVoucherToolStripMenuItem;

        public ToolStripMenuItem logoutToolStripMenuItem;

        public ToolStripMenuItem taxToolStripMenuItem;

        public ToolStripMenuItem budgetToolStripMenuItem;

        public ToolStripMenuItem payrollToolStripMenuItem;

        public ToolStripMenuItem currencyToolStripMenuItem;

        public ToolStripMenuItem batchToolStripMenuItem;

        public ToolStripMenuItem sizeToolStripMenuItem;

        public ToolStripMenuItem godownToolStripMenuItem;

        public ToolStripMenuItem rackToolStripMenuItem;

        public ToolStripMenuItem modelNumberToolStripMenuItem;

        public ToolStripMenuItem payrollToolStripMenuItem1;

        public ToolStripMenuItem dateToolStripMenuItem;

        private ToolStripMenuItem aboutUsToolStripMenuItem;

        private ToolStripMenuItem contentsToolStripMenuItem;

        private ToolStripMenuItem rebuildIndexingToolStripMenuItem;

        private BackgroundWorker BackgrndWrkrLoading;

        private ToolStripMenuItem ContactUsToolStripMenuItem;

        private ToolStripMenuItem utilitiesToolStripMenuItem;

        private ToolStripMenuItem miracleSkateToolStripMenuItem;

        private ToolStripMenuItem miracleIToolStripMenuItem;

        private UserControlQuickLaunch ucQuickLaunch1;

        //private ucCalculator ucCalculator1;

        public static formMDI MDIObj;

        private int childFormNumber = 0;

        public static string DBConnectionType;

        public static bool isEstimateDB = false;

        public static string strEstimateCompanyPath = string.Empty;

        public static bool demoProject = false;

        public static string strVouchertype;

    }
}



