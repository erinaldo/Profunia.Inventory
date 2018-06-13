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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Profunia.Inventory.Desktop.CrystalReports.Reports;
using Profunia.Inventory.Desktop.CrystalReports.Reports.ProductStatisticsReports;
using CrystalDecisions.CrystalReports.Engine;
using Profunia.Inventory.Desktop.ClassFiles.General;
using Profunia.Inventory.Desktop.ClassFiles.SP;
using Profunia.Inventory.Desktop.CrystalReports.Reports;
using Profunia.Inventory.Desktop.Payroll;
using System.Collections;

namespace Profunia.Inventory.Desktop.CrystalReports
{
    public partial class frmReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmPaySlip frmPaySlipObject;
        #endregion

       
        /// <summary>
        /// Create an instance for frmReport Class
        /// </summary>
        public frmReport()
        {
            InitializeComponent();
        }
        /// <summary>
        internal void StockJournalPrinting(DataSet dsStockJournal)
        {
            try
            {
                crptStockJournal crptStockJournalObj = new crptStockJournal();
                foreach (DataTable table in dsStockJournal.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptStockJournalObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptStockJournalObj.Database.Tables["dtblStockJournalMaster"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptStockJournalObj.Database.Tables["dtblStockJournalDetailsConsumption"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table3")
                    {
                        crptStockJournalObj.Database.Tables["dtblStockJournalDetailsProduction"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptStockJournalObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptStockJournalObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV1 " + ex.Message;
            }
        }

        public void CallFromPaySlip(frmPaySlip frmPaySlip, decimal decEmployeeId, DateTime dtSalaryMonth)
        {
            try
            {
                frmPaySlipObject = frmPaySlip;
                base.Show();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV2 " + ex.Message;
            }
        }

        internal void PaySlipPrinting(DataSet dsPaySlip)
        {
            try
            {
                decimal decTotalAdd = 0m;
                decimal decTotalDed = 0m;
                decimal decNetPay = 0m;
                crptPaySlip crptPaySlip = new crptPaySlip();
                foreach (DataTable table in dsPaySlip.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPaySlip.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPaySlip.Database.Tables["dtblEmployeeDetails"].SetDataSource(table);
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["ADDamount"].ToString() != string.Empty)
                            {
                                decTotalAdd += Convert.ToDecimal(row["ADDamount"].ToString());
                            }
                            if (row["DEDamount"].ToString() != string.Empty)
                            {
                                decTotalDed += Convert.ToDecimal(row["DEDamount"].ToString());
                            }
                        }
                        {
                            IEnumerator enumerator2 = table.Rows.GetEnumerator();
                            try
                            {
                                if (enumerator2.MoveNext())
                                {
                                    DataRow drow3 = (DataRow)enumerator2.Current;
                                    if (drow3["LOP"].ToString() != string.Empty)
                                    {
                                        decTotalDed += Convert.ToDecimal(drow3["LOP"].ToString());
                                    }
                                    if (drow3["Deduction"].ToString() != string.Empty)
                                    {
                                        decTotalDed += Convert.ToDecimal(drow3["Deduction"].ToString());
                                    }
                                    if (drow3["Advance"].ToString() != string.Empty)
                                    {
                                        decTotalDed += Convert.ToDecimal(drow3["Advance"].ToString());
                                    }
                                    if (drow3["Bonus"].ToString() != string.Empty)
                                    {
                                        decTotalAdd += Convert.ToDecimal(drow3["Bonus"].ToString());
                                    }
                                }
                            }
                            finally
                            {
                                IDisposable disposable = enumerator2 as IDisposable;
                                if (disposable != null)
                                {
                                    disposable.Dispose();
                                }
                            }
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        DataColumn dtClmn = new DataColumn("AmountInWords");
                        table.Columns.Add(dtClmn);
                        decNetPay = decTotalAdd - decTotalDed;
                        foreach (DataRow row2 in table.Rows)
                        {
                            row2["AmountInWords"] = new NumToText().AmountWords(decNetPay, PublicVariables._decCurrencyId);
                        }
                        crptPaySlip.Database.Tables["dtblOther"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPaySlip;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPaySlip.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV3 " + ex.Message;
            }
        }

        internal void PhysicalStockPrinting(DataSet dsPhysicalStock)
        {
            try
            {
                crptPhysicalStock crptPhysicalStock = new crptPhysicalStock();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsPhysicalStock.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPhysicalStock.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("AmountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["AmountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptPhysicalStock.Database.Tables["dtblOtherDetails"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        DataColumn dtClmnSlNo = new DataColumn("SlNo");
                        table.Columns.Add(dtClmnSlNo);
                        int inRowIndex = 0;
                        foreach (DataRow row2 in table.Rows)
                        {
                            row2["SlNo"] = ++inRowIndex;
                        }
                        crptPhysicalStock.Database.Tables["dtblGridDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPhysicalStock;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPhysicalStock.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV4 " + ex.Message;
            }
        }

        internal void StockJournalReportPrint(DataSet dsStockJournalReport)
        {
            try
            {
                crptStockJournalReport crptStockJournalReportObj = new crptStockJournalReport();
                foreach (DataTable table in dsStockJournalReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptStockJournalReportObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptStockJournalReportObj.Database.Tables["dtblStockJournalReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptStockJournalReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptStockJournalReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV5 " + ex.Message;
            }
        }

        internal void ContraVoucherPrinting(DataSet dsCOntraVoucher)
        {
            try
            {
                crptContraVoucher crptContraVoucher = new crptContraVoucher();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsCOntraVoucher.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptContraVoucher.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("AmountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["AmountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptContraVoucher.Database.Tables["dtblOtherDetails"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        foreach (DataRow row2 in table.Rows)
                        {
                            if (row2["chequeDate"].ToString() == "01 Jan 1753")
                            {
                                row2["chequeDate"] = string.Empty;
                            }
                        }
                        DataColumn dtClmnSlNo = new DataColumn("SlNo");
                        table.Columns.Add(dtClmnSlNo);
                        int inRowIndex = 0;
                        foreach (DataRow row3 in table.Rows)
                        {
                            row3["SlNo"] = ++inRowIndex;
                        }
                        crptContraVoucher.Database.Tables["dtblGridDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptContraVoucher;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptContraVoucher.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV6 " + ex.Message;
            }
        }

        internal void PaymentVoucherPrinting(DataSet dsPaymentVoucher)
        {
            try
            {
                crptPaymentVoucher crptPaymentVoucher = new crptPaymentVoucher();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsPaymentVoucher.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPaymentVoucher.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("Amount In Words");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["Amount In Words"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptPaymentVoucher.Database.Tables["dtblPaymentMaster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        foreach (DataRow row2 in table.Rows)
                        {
                            if (row2["chequeNo"].ToString() == string.Empty)
                            {
                                row2["chequeDate"] = string.Empty;
                            }
                        }
                        DataColumn dtClmnSlNo = new DataColumn("SlNo");
                        table.Columns.Add(dtClmnSlNo);
                        int inRowIndex = 0;
                        foreach (DataRow row3 in table.Rows)
                        {
                            row3["SlNo"] = ++inRowIndex;
                        }
                        crptPaymentVoucher.Database.Tables["dtblPaymentDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPaymentVoucher;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPaymentVoucher.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV7 " + ex.Message;
            }
        }

        internal void PaymentReportPrinting(DataSet dsPaymentReport)
        {
            try
            {
                crptPaymentReport crptPaymentReport = new crptPaymentReport();
                foreach (DataTable table in dsPaymentReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPaymentReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPaymentReport.Database.Tables["dtblPaymentMaster"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPaymentReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPaymentReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV8 " + ex.Message;
            }
        }

        internal void ReceiptReportPrinting(DataSet dsReceiptReport)
        {
            try
            {
                crptReceiptReport crptReceiptReport = new crptReceiptReport();
                foreach (DataTable table in dsReceiptReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptReceiptReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptReceiptReport.Database.Tables["dtblReceiptMaster"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptReceiptReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptReceiptReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV9 " + ex.Message;
            }
        }

        internal void ReceiptVoucherPrinting(DataSet dsReceiptVoucher)
        {
            try
            {
                crptReceiptVoucher crptReceiptVoucher = new crptReceiptVoucher();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsReceiptVoucher.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptReceiptVoucher.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("Amount In Words");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["Amount In Words"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptReceiptVoucher.Database.Tables["dtblReceiptMaster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        foreach (DataRow row2 in table.Rows)
                        {
                            if (row2["chequeNo"].ToString() == string.Empty)
                            {
                                row2["chequeDate"] = string.Empty;
                            }
                        }
                        DataColumn dtClmnSlNo = new DataColumn("SlNo");
                        table.Columns.Add(dtClmnSlNo);
                        int inRowIndex = 0;
                        foreach (DataRow row3 in table.Rows)
                        {
                            row3["SlNo"] = ++inRowIndex;
                        }
                        crptReceiptVoucher.Database.Tables["dtblReceiptDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptReceiptVoucher;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptReceiptVoucher.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV10 " + ex.Message;
            }
        }

        internal void JournalVoucherPrinting(DataSet dsJournalVoucher)
        {
            try
            {
                crptJournalVoucher crptJournalVoucher = new crptJournalVoucher();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsJournalVoucher.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptJournalVoucher.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn3 = new DataColumn("Amount In Words");
                            table.Columns.Add(dtClmn3);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["Amount In Words"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptJournalVoucher.Database.Tables["dtblJournalMaster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        DataColumn dtClmn3 = new DataColumn("CreditOrDebit");
                        table.Columns.Add(dtClmn3);
                        DataColumn dtClmn = new DataColumn("Amount");
                        table.Columns.Add(dtClmn);
                        foreach (DataRow row2 in table.Rows)
                        {
                            if (row2["chequeNo"].ToString() == string.Empty)
                            {
                                row2["chequeDate"] = string.Empty;
                            }
                            if (Convert.ToDecimal(row2["debit"].ToString()) == 0m)
                            {
                                row2["Amount"] = Convert.ToDecimal(row2["credit"].ToString());
                                row2["CreditOrDebit"] = "Cr";
                            }
                            else
                            {
                                row2["Amount"] = Convert.ToDecimal(row2["debit"].ToString());
                                row2["CreditOrDebit"] = "Dr";
                            }
                        }
                        crptJournalVoucher.Database.Tables["dtblJournalDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptJournalVoucher;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptJournalVoucher.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV11 " + ex.Message;
            }
        }

        internal void ServiceVoucherPrinting(DataSet dsServiceVoucher)
        {
            try
            {
                decimal decGrandTotal = 0m;
                crptServiceVoucher crptServiceVoucher = new crptServiceVoucher();
                foreach (DataTable table in dsServiceVoucher.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptServiceVoucher.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptServiceVoucher.Database.Tables["dtblServiceMaster"].SetDataSource(table);
                        foreach (DataRow row in table.Rows)
                        {
                            decGrandTotal = Convert.ToDecimal(row["grandTotal"].ToString());
                        }
                        crptServiceVoucher.Database.Tables["dtblServiceMaster"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        DataColumn dtClmn = new DataColumn("AmountInWords");
                        table.Columns.Add(dtClmn);
                        foreach (DataRow row2 in table.Rows)
                        {
                            row2["AmountInWords"] = new NumToText().AmountWords(decGrandTotal, PublicVariables._decCurrencyId);
                        }
                        DataColumn dtClmnSlNo = new DataColumn("SlNo");
                        table.Columns.Add(dtClmnSlNo);
                        int inRowIndex = 0;
                        foreach (DataRow row3 in table.Rows)
                        {
                            row3["SlNo"] = ++inRowIndex;
                        }
                        crptServiceVoucher.Database.Tables["dtblServiceVoucherDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptServiceVoucher;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptServiceVoucher.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV12 " + ex.Message;
            }
        }

        internal void EmployeeAddressBookPrinting(DataSet dsEmployeeAddressBook)
        {
            try
            {
                crptEmployeeAddressBook crptEmployeeAddressBook = new crptEmployeeAddressBook();
                foreach (DataTable table in dsEmployeeAddressBook.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptEmployeeAddressBook.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptEmployeeAddressBook.Database.Tables["dtblGridDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptEmployeeAddressBook;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptEmployeeAddressBook.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV13 " + ex.Message;
            }
        }

        internal void ProductBatchReportPrinting(DataSet dsProductBatchReport)
        {
            try
            {
                crptProductBatchReport crptProductBatchReport = new crptProductBatchReport();
                foreach (DataTable table in dsProductBatchReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptProductBatchReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptProductBatchReport.Database.Tables["dtblProductBatch"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptProductBatchReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptProductBatchReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV14 " + ex.Message;
            }
        }

        internal void MonthlyAttendancePrinting(DataSet dsMonthlyAttendance)
        {
            try
            {
                crptMonthlyAttendance crptMonthlyAttendance = new crptMonthlyAttendance();
                foreach (DataTable table in dsMonthlyAttendance.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptMonthlyAttendance.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptMonthlyAttendance.Database.Tables["dtblGridDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptMonthlyAttendance;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptMonthlyAttendance.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV15 " + ex.Message;
            }
        }

        internal void DailyAttendanceReportPrinting(DataSet dsDailyAttendanceReport)
        {
            try
            {
                crptDailyAttendanceReport crptDailyAttendanceReport = new crptDailyAttendanceReport();
                foreach (DataTable table in dsDailyAttendanceReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptDailyAttendanceReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptDailyAttendanceReport.Database.Tables["dtblAttendance"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptDailyAttendanceReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDailyAttendanceReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV16 " + ex.Message;
            }
        }

        internal void DailySalaryReport(DataSet dsDailySalaryReport)
        {
            try
            {
                crptDailySalaryReport crptdailySalaryReport = new crptDailySalaryReport();
                foreach (DataTable table in dsDailySalaryReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptdailySalaryReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptdailySalaryReport.Database.Tables["dtblDailySalaryreport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptdailySalaryReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptdailySalaryReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV17 " + ex.Message;
            }
        }

        internal void PurchaseOrderPrinting(DataSet dsPurchaseOrderReport)
        {
            try
            {
                decimal decTotalAmount = 0m;
                crptPurchaseOrderReport crptPurchaseOrderobj = new crptPurchaseOrderReport();
                foreach (DataTable table in dsPurchaseOrderReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPurchaseOrderobj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptPurchaseOrderobj.Database.Tables["dtblPurchaseOrderMaster"].SetDataSource(table);
                        }
                    }
                    else
                    {
                        crptPurchaseOrderobj.Database.Tables["dtblPurchaseOrderDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPurchaseOrderobj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPurchaseOrderobj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV18 " + ex.Message;
            }
        }

        internal void MaterialReceiptPrinting(DataSet dsMaterialReceiptReport)
        {
            try
            {
                decimal decTotalAmount = 0m;
                crptMaterialreceipt crptMaterialreceiptObj = new crptMaterialreceipt();
                foreach (DataTable table in dsMaterialReceiptReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptMaterialreceiptObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptMaterialreceiptObj.Database.Tables["dtblMaterialReceiptMaster"].SetDataSource(table);
                        }
                    }
                    else
                    {
                        crptMaterialreceiptObj.Database.Tables["dtblMaterialReceiptDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptMaterialreceiptObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptMaterialreceiptObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV19 " + ex.Message;
            }
        }

        internal void PurchaseInvoicePrinting(DataSet dsPurchaseInvoice)
        {
            try
            {
                decimal decTotalAmount = 0m;
                crptPurchaseInvoice crptPurchaseInvoiceObj = new crptPurchaseInvoice();
                foreach (DataTable table in dsPurchaseInvoice.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPurchaseInvoiceObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["grandTotal"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["grandTotal"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptPurchaseInvoiceObj.Database.Tables["dtblPurchaseMaster"].SetDataSource(table);
                        }
                    }
                    else
                    {
                        crptPurchaseInvoiceObj.Database.Tables["dtblPurchaseDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPurchaseInvoiceObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPurchaseInvoiceObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV20 " + ex.Message;
            }
        }

        internal void PurchaseReportPrinting(DataSet dsPurchaseReport, string strTotal)
        {
            try
            {
                crptPurchaseReport crptPurchaseReportObj = new crptPurchaseReport();
                foreach (DataTable table in dsPurchaseReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPurchaseReportObj.Database.Tables["dtblCompanyReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPurchaseReportObj.Database.Tables["dtblPurchaseReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPurchaseReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPurchaseReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV21 " + ex.Message;
            }
        }

        internal void SalesOrderPrinting(DataSet dsSalesOrderReport)
        {
            try
            {
                decimal decTotalAmount = 0m;
                crptSalesOrderReport crptSalesOrderobj = new crptSalesOrderReport();
                foreach (DataTable table in dsSalesOrderReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptSalesOrderobj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptSalesOrderobj.Database.Tables["dtblSalesOrderMaster"].SetDataSource(table);
                        }
                    }
                    else
                    {
                        crptSalesOrderobj.Database.Tables["dtblSalesOrderDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptSalesOrderobj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesOrderobj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV22 " + ex.Message;
            }
        }

        internal void SalesQuotationPrinting(DataSet dsSalesQuotation)
        {
            try
            {
                crptSalesQuotation crptSalesQuotationObj = new crptSalesQuotation();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsSalesQuotation.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptSalesQuotationObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptSalesQuotationObj.Database.Tables["dtblSalesQuotationMaster"].SetDataSource(table);
                        }
                    }
                    else
                    {
                        crptSalesQuotationObj.Database.Tables["dtblSalesQuotationDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptSalesQuotationObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesQuotationObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV23 " + ex.Message;
            }
        }

        internal void SalesQuotationReportPrinting(DataSet dsSalesQuotation, string strGrandTotal)
        {
            try
            {
                DataTable dtblGrandTotal = new DataTable();
                dtblGrandTotal.Columns.Add("GrandTotal", typeof(string));
                DataRow dr = dtblGrandTotal.NewRow();
                dr[0] = strGrandTotal;
                dtblGrandTotal.Rows.InsertAt(dr, 0);
                crptSalesQuotationReport crptSalesQuotationObj = new crptSalesQuotationReport();
                foreach (DataTable table in dsSalesQuotation.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptSalesQuotationObj.Database.Tables["dtblCompanyReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptSalesQuotationObj.Database.Tables["dtblSalesQuotationReportDetails"].SetDataSource(table);
                    }
                }
                crptSalesQuotationObj.Database.Tables["dtblGrandTotal"].SetDataSource(dtblGrandTotal);
                crptViewer.ReportSource = crptSalesQuotationObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesQuotationObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV24 " + ex.Message;
            }
        }

        internal void PriceListReportPrinting(DataSet dsPriceListReport)
        {
            try
            {
                crptPricelistDynamic crptDynamic = new crptPricelistDynamic();
                DataTable dtblnew = new DataTable();
                foreach (DataTable table in dsPriceListReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptDynamic.Database.Tables["dtblCompanyReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptDynamic.Database.Tables["dtblPriceListGridFill"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table3")
                    {
                        dtblnew = table;
                        crptDynamic.Database.Tables["dtblOptions"].SetDataSource(table);
                    }
                }
                LineObject line9 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line11"];
                LineObject line8 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line12"];
                LineObject line7 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line14"];
                foreach (DataRow row in dtblnew.Rows)
                {
                    int l = 1;
                    int k = 6;
                    int right;
                    if (row["PurchaseRate"].ToString() == "True")
                    {
                        crptDynamic.SetParameterValue("field" + l, "Purchase Rate");
                        l++;
                    }
                    else
                    {
                        crptDynamic.SetParameterValue("field" + k, "None");
                        LineObject line6 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line0" + k];
                        line6.ObjectFormat.EnableSuppress = true;
                        LineObject lineObject = line9;
                        right = line9.Right;
                        lineObject.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject2 = line8;
                        right = line8.Right;
                        lineObject2.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject3 = line7;
                        right = line7.Right;
                        lineObject3.Right = int.Parse(right.ToString()) - 1790;
                        k--;
                    }
                    if (row["SalesRate"].ToString() == "True")
                    {
                        crptDynamic.SetParameterValue("field" + l, "Sales Rate");
                        l++;
                    }
                    else
                    {
                        crptDynamic.SetParameterValue("field" + k, "None");
                        LineObject line6 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line0" + k];
                        line6.ObjectFormat.EnableSuppress = true;
                        LineObject lineObject4 = line9;
                        right = line9.Right;
                        lineObject4.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject5 = line8;
                        right = line8.Right;
                        lineObject5.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject6 = line7;
                        right = line7.Right;
                        lineObject6.Right = int.Parse(right.ToString()) - 1790;
                        k--;
                    }
                    if (row["LastSalesRate"].ToString() == "True")
                    {
                        crptDynamic.SetParameterValue("field" + l, "Last Sales Rate");
                        l++;
                    }
                    else
                    {
                        crptDynamic.SetParameterValue("field" + k, "None");
                        LineObject line6 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line0" + k];
                        line6.ObjectFormat.EnableSuppress = true;
                        LineObject lineObject7 = line9;
                        right = line9.Right;
                        lineObject7.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject8 = line8;
                        right = line8.Right;
                        lineObject8.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject9 = line7;
                        right = line7.Right;
                        lineObject9.Right = int.Parse(right.ToString()) - 1790;
                        k--;
                    }
                    if (row["StandardRate"].ToString() == "True")
                    {
                        crptDynamic.SetParameterValue("field" + l, "Standard Rate");
                        l++;
                    }
                    else
                    {
                        crptDynamic.SetParameterValue("field" + k, "None");
                        LineObject line6 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line0" + k];
                        line6.ObjectFormat.EnableSuppress = true;
                        LineObject lineObject10 = line9;
                        right = line9.Right;
                        lineObject10.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject11 = line8;
                        right = line8.Right;
                        lineObject11.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject12 = line7;
                        right = line7.Right;
                        lineObject12.Right = int.Parse(right.ToString()) - 1790;
                        k--;
                    }
                    if (row["MRP"].ToString() == "True")
                    {
                        crptDynamic.SetParameterValue("field" + l, "MRP");
                        l++;
                    }
                    else
                    {
                        crptDynamic.SetParameterValue("field" + k, "None");
                        LineObject line6 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line0" + k];
                        line6.ObjectFormat.EnableSuppress = true;
                        LineObject lineObject13 = line9;
                        right = line9.Right;
                        lineObject13.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject14 = line8;
                        right = line8.Right;
                        lineObject14.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject15 = line7;
                        right = line7.Right;
                        lineObject15.Right = int.Parse(right.ToString()) - 1790;
                        k--;
                    }
                    if (row["Price"].ToString() == "True")
                    {
                        crptDynamic.SetParameterValue("field" + l, "Price");
                        l++;
                    }
                    else
                    {
                        crptDynamic.SetParameterValue("field" + k, "None");
                        LineObject line6 = (LineObject)crptDynamic.ReportDefinition.ReportObjects["Line0" + k];
                        line6.ObjectFormat.EnableSuppress = true;
                        LineObject lineObject16 = line9;
                        right = line9.Right;
                        lineObject16.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject17 = line8;
                        right = line8.Right;
                        lineObject17.Right = int.Parse(right.ToString()) - 1790;
                        LineObject lineObject18 = line7;
                        right = line7.Right;
                        lineObject18.Right = int.Parse(right.ToString()) - 1790;
                        k--;
                    }
                }
                crptViewer.ReportSource = crptDynamic;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDynamic.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV25 " + ex.Message;
            }
        }

        internal void RejectionOutPrinting(DataSet dsRejectionOut)
        {
            try
            {
                crptRejectionOut crptRejectionOutObj = new crptRejectionOut();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsRejectionOut.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptRejectionOutObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("AmountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["TotalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["TotalAmount"].ToString());
                                row["AmountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptRejectionOutObj.Database.Tables["dtblRejectionOutMaster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptRejectionOutObj.Database.Tables["dtblRejectionOutDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptRejectionOutObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptRejectionOutObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV26 " + ex.Message;
            }
        }

        internal void RejectionOutReportPrinting(DataSet dsRejectionOutReport)
        {
            try
            {
                crptRejectionOutReport crptRejectionOutReportObj = new crptRejectionOutReport();
                foreach (DataTable table in dsRejectionOutReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptRejectionOutReportObj.Database.Tables["dtblCompanyReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptRejectionOutReportObj.Database.Tables["dtblDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptRejectionOutReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptRejectionOutReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV27 " + ex.Message;
            }
        }

        internal void BonusDeductionReportPrinting(DataSet dsBonusDeductionReport)
        {
            try
            {
                crptBonusAndDeduction crptBonusAndDeduction = new crptBonusAndDeduction();
                foreach (DataTable table in dsBonusDeductionReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptBonusAndDeduction.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptBonusAndDeduction.Database.Tables["dtblBonusAndDeductionReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptBonusAndDeduction;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptBonusAndDeduction.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV28 " + ex.Message;
            }
        }

        internal void EmployeeReportPrinting(DataSet dsEmployeeReport)
        {
            try
            {
                crptEmployeeReport crptEmployeeReport = new crptEmployeeReport();
                foreach (DataTable table in dsEmployeeReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptEmployeeReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptEmployeeReport.Database.Tables["dtblEmployee"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptEmployeeReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptEmployeeReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV29 " + ex.Message;
            }
        }

        internal void MonthlySalaryReportPrinting(DataSet dsMonthlySalaryReport)
        {
            try
            {
                crptMonthlySalaryReport crptMonthlySalaryReport = new crptMonthlySalaryReport();
                foreach (DataTable table in dsMonthlySalaryReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptMonthlySalaryReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptMonthlySalaryReport.Database.Tables["dtblMonthlySalary"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptMonthlySalaryReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptMonthlySalaryReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV30 " + ex.Message;
            }
        }

        internal void SalaryPackageReport(DataSet dsSalaryPackageReport)
        {
            try
            {
                crptSalaryPackageReport crptsalaryPackageReport = new crptSalaryPackageReport();
                foreach (DataTable table in dsSalaryPackageReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptsalaryPackageReport.Database.Tables["dtblSalaryPackageReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptsalaryPackageReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptsalaryPackageReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptsalaryPackageReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV31 " + ex.Message;
            }
        }

        internal void PayHeadReport(DataSet dsPayHeadReport)
        {
            try
            {
                crptPayHeadReport crptpayHeadReport = new crptPayHeadReport();
                foreach (DataTable table in dsPayHeadReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptpayHeadReport.Database.Tables["dtblPayHeadReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptpayHeadReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptpayHeadReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptpayHeadReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV32 " + ex.Message;
            }
        }

        internal void AdvancePaymentReportPrinting(DataSet dsAdvancePaymentReport)
        {
            try
            {
                crptAdvancePayment crptAdvancePayment = new crptAdvancePayment();
                foreach (DataTable table in dsAdvancePaymentReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptAdvancePayment.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptAdvancePayment.Database.Tables["dtblAdvancePayment"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptAdvancePayment;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptAdvancePayment.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV33 " + ex.Message;
            }
        }

        internal void SalaryPackageDetailsReport(DataSet dsSalaryPakegedetailReport)
        {
            try
            {
                crptSalaryPackageDetails crptsalaryPackageDetails = new crptSalaryPackageDetails();
                foreach (DataTable table in dsSalaryPakegedetailReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptsalaryPackageDetails.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptsalaryPackageDetails.Database.Tables["dtblSalaryPackageDetails"].SetDataSource(table);
                    }
                    else
                    {
                        crptsalaryPackageDetails.Database.Tables["dtblOtherDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptsalaryPackageDetails;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptsalaryPackageDetails.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV34 " + ex.Message;
            }
        }

        public void JournalreportReportPrinting(DataSet dsJournalreport)
        {
            try
            {
                crptJournalReport crptJournalReport = new crptJournalReport();
                foreach (DataTable table in dsJournalreport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptJournalReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptJournalReport.Database.Tables["dtblJournalReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptJournalReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptJournalReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV35 " + ex.Message;
            }
        }

        public void PurchaseOrderReportPrinting(DataSet dsPurchaseOrderReport, string strTotal)
        {
            try
            {
                DataTable dtblTotalAmount = new DataTable();
                dtblTotalAmount.Columns.Add("Grandtotal", typeof(string));
                DataRow dr = dtblTotalAmount.NewRow();
                dr[0] = strTotal;
                dtblTotalAmount.Rows.InsertAt(dr, 0);
                crptPurchaseOrderReport1 crptPurchaseOrderReport = new crptPurchaseOrderReport1();
                foreach (DataTable table in dsPurchaseOrderReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPurchaseOrderReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPurchaseOrderReport.Database.Tables["dtblPurchaseOrderReport"].SetDataSource(table);
                    }
                }
                crptPurchaseOrderReport.Database.Tables["dtblTotal"].SetDataSource(dtblTotalAmount);
                crptViewer.ReportSource = crptPurchaseOrderReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPurchaseOrderReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV36 " + ex.Message;
            }
        }

        internal void PhysicalStockReport(DataSet dsPhysicalStock)
        {
            try
            {
                crptPhysicalStockReport crptPhysicalStockReport = new crptPhysicalStockReport();
                foreach (DataTable table in dsPhysicalStock.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptPhysicalStockReport.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptPhysicalStockReport.Database.Tables["dtblPhysicalStockReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPhysicalStockReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPhysicalStockReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV37 " + ex.Message;
            }
        }

        internal void ContraVoucherReport(DataSet dsContraVoucher)
        {
            try
            {
                crptContraVoucherReport crptContrReport = new crptContraVoucherReport();
                foreach (DataTable table in dsContraVoucher.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptContrReport.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptContrReport.Database.Tables["dtblContraVoucherReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptContrReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptContrReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV38 " + ex.Message;
            }
        }

        internal void ServiceVoucherReport(DataSet dsServiceVoucherReport)
        {
            try
            {
                crptServiceVoucherReport crptServiceVoucherReportObj = new crptServiceVoucherReport();
                foreach (DataTable table in dsServiceVoucherReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptServiceVoucherReportObj.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptServiceVoucherReportObj.Database.Tables["dtblServiceVoucherReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptServiceVoucherReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptServiceVoucherReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV39 " + ex.Message;
            }
        }

        internal void DebitNotePrinting(DataSet dsDebitNote)
        {
            try
            {
                crptDebitNote crptDebitNote = new crptDebitNote();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsDebitNote.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptDebitNote.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn3 = new DataColumn("Amount In Words");
                            table.Columns.Add(dtClmn3);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["Amount In Words"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptDebitNote.Database.Tables["dtblDebitNoteMaster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        DataColumn dtClmn3 = new DataColumn("CreditOrDebit");
                        table.Columns.Add(dtClmn3);
                        DataColumn dtClmn = new DataColumn("Amount");
                        table.Columns.Add(dtClmn);
                        foreach (DataRow row2 in table.Rows)
                        {
                            if (row2["chequeNo"].ToString() == string.Empty)
                            {
                                row2["chequeDate"] = string.Empty;
                            }
                            if (Convert.ToDecimal(row2["debit"].ToString()) == 0m)
                            {
                                row2["Amount"] = Convert.ToDecimal(row2["credit"].ToString());
                                row2["CreditOrDebit"] = "Cr";
                            }
                            else
                            {
                                row2["Amount"] = Convert.ToDecimal(row2["debit"].ToString());
                                row2["CreditOrDebit"] = "Dr";
                            }
                        }
                        crptDebitNote.Database.Tables["dtblDebitNoteDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptDebitNote;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDebitNote.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV40 " + ex.Message;
            }
        }

        public void DebitNoteReportPrinting(DataSet dsDebitNoteReport)
        {
            try
            {
                crptDebitNoteReport crptDebitNoteReport = new crptDebitNoteReport();
                foreach (DataTable table in dsDebitNoteReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptDebitNoteReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptDebitNoteReport.Database.Tables["dtblDebitNoteReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptDebitNoteReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDebitNoteReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV41 " + ex.Message;
            }
        }

        internal void CreditNotePrinting(DataSet dsCreditNote)
        {
            try
            {
                crptCreditNote crptCreditNote = new crptCreditNote();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsCreditNote.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptCreditNote.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn3 = new DataColumn("Amount In Words");
                            table.Columns.Add(dtClmn3);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["Amount In Words"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptCreditNote.Database.Tables["dtblCredittNoteMaster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        DataColumn dtClmn3 = new DataColumn("CreditOrDebit");
                        table.Columns.Add(dtClmn3);
                        DataColumn dtClmn = new DataColumn("Amount");
                        table.Columns.Add(dtClmn);
                        foreach (DataRow row2 in table.Rows)
                        {
                            if (row2["chequeNo"].ToString() == string.Empty)
                            {
                                row2["chequeDate"] = string.Empty;
                            }
                            if (Convert.ToDecimal(row2["debit"].ToString()) == 0m)
                            {
                                row2["Amount"] = Convert.ToDecimal(row2["credit"].ToString());
                                row2["CreditOrDebit"] = "Cr";
                            }
                            else
                            {
                                row2["Amount"] = Convert.ToDecimal(row2["debit"].ToString());
                                row2["CreditOrDebit"] = "Dr";
                            }
                        }
                        crptCreditNote.Database.Tables["dtblCreditNoteDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptCreditNote;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptCreditNote.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV42 " + ex.Message;
            }
        }

        public void CreditNoteReportPrinting(DataSet dsCreditNoteReport)
        {
            try
            {
                crptCreditNoteReport crptCreditNoteReport = new crptCreditNoteReport();
                foreach (DataTable table in dsCreditNoteReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptCreditNoteReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptCreditNoteReport.Database.Tables["dtblCreditNoteReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptCreditNoteReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptCreditNoteReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV43 " + ex.Message;
            }
        }

        internal void PDCpayableReportPrinting(DataSet dspdcPayableReport)
        {
            try
            {
                crptPdcPayable crptpdcpayable = new crptPdcPayable();
                foreach (DataTable table in dspdcPayableReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptpdcpayable.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptpdcpayable.Database.Tables["dtblOtherDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptpdcpayable;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptpdcpayable.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV44" + ex.Message;
            }
        }

        internal void RejectionInPrinting(DataSet dsRejectionIn)
        {
            try
            {
                decimal decTotalAmount = 0m;
                crptRejectionIn crptRejectionInObj = new crptRejectionIn();
                foreach (DataTable table in dsRejectionIn.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptRejectionInObj.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptRejectionInObj.Database.Tables["dtblRejectionInMaster"].SetDataSource(table);
                        }
                        crptRejectionInObj.Database.Tables["dtblRejectionInMaster"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptRejectionInObj.Database.Tables["dtblRejectionInDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptRejectionInObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptRejectionInObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV45 " + ex.Message;
            }
        }

        internal void RejectionInReportPrinting(DataSet dsRejectionInReport)
        {
            try
            {
                crptRejectionInReport crptRejectionInReportObj = new crptRejectionInReport();
                foreach (DataTable table in dsRejectionInReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptRejectionInReportObj.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        table.Columns.Add("slNo");
                        int inSlNo = 1;
                        foreach (DataRow row in table.Rows)
                        {
                            row["slNo"] = inSlNo++;
                        }
                        crptRejectionInReportObj.Database.Tables["dtblRejectionInMaster"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptRejectionInReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptRejectionInReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV46 " + ex.Message;
            }
        }

        internal void DeliveryNotePrinting(DataSet dsDeliveryNote)
        {
            try
            {
                crptDeliveryNote crptDeliveryNoteObj = new crptDeliveryNote();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsDeliveryNote.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptDeliveryNoteObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["totalAmount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["totalAmount"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptDeliveryNoteObj.Database.Tables["dtblDeliveryNoteMster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptDeliveryNoteObj.Database.Tables["dtblDeliveryNoteDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptDeliveryNoteObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDeliveryNoteObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV47 " + ex.Message;
            }
        }

        internal void PurchaseReturnReportPrinting(DataSet dsPurchaseReturnReportPrinting, string strTotalAmount)
        {
            try
            {
                DataTable dtblGrandTotal = new DataTable();
                dtblGrandTotal.Columns.Add("GrandTotal", typeof(string));
                DataRow dr = dtblGrandTotal.NewRow();
                dr[0] = strTotalAmount;
                dtblGrandTotal.Rows.InsertAt(dr, 0);
                crptPurchaseReturnReport crptPurchaseReturnReportObj = new crptPurchaseReturnReport();
                foreach (DataTable table in dsPurchaseReturnReportPrinting.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptPurchaseReturnReportObj.Database.Tables["dtblPurchaseReturnMaster"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptPurchaseReturnReportObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    crptPurchaseReturnReportObj.Database.Tables["dtblGrandTotal"].SetDataSource(dtblGrandTotal);
                }
                crptViewer.ReportSource = crptPurchaseReturnReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPurchaseReturnReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV48 " + ex.Message;
            }
        }

        internal void SalesReturnReportPrinting(DataSet dsSalesReturnReportPrinting)
        {
            try
            {
                decimal decTotalAmount = 0m;
                crptSalesReturnReporting crptSalesReturnReportObj = new crptSalesReturnReporting();
                foreach (DataTable table in dsSalesReturnReportPrinting.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptSalesReturnReportObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptSalesReturnReportObj.Database.Tables["dtblSalesReturnMaster"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["GrandTotal"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["GrandTotal"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptSalesReturnReportObj.Database.Tables["dtblSalesReturnMasterGrandTotal"].SetDataSource(table);
                        }
                    }
                }
                crptViewer.ReportSource = crptSalesReturnReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesReturnReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV49" + ex.Message;
            }
        }

        internal void SalesReturnPrinting(DataSet dsSalesReturnPrinting)
        {
            try
            {
                crptSalesReturn crptSalesReturnobj = new crptSalesReturn();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsSalesReturnPrinting.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptSalesReturnobj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["grandTotal"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["grandTotal"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptSalesReturnobj.Database.Tables["dtblSalesReturnMaster"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptSalesReturnobj.Database.Tables["dtblSalesReturnDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptSalesReturnobj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesReturnobj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV50 " + ex.Message;
            }
        }

        internal void PurchaseReturnPrinting(DataSet dsPurchaseReturnReport)
        {
            try
            {
                crptPurchaseReturn crptPurchaseReturnObj = new crptPurchaseReturn();
                decimal decGrandAmount = 0m;
                foreach (DataTable table in dsPurchaseReturnReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPurchaseReturnObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["grandTotal"].ToString() != string.Empty)
                            {
                                decGrandAmount = Convert.ToDecimal(row["grandTotal"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decGrandAmount, PublicVariables._decCurrencyId);
                            }
                            crptPurchaseReturnObj.Database.Tables["dtblPurchaseReturnMaster"].SetDataSource(table);
                        }
                    }
                    else
                    {
                        crptPurchaseReturnObj.Database.Tables["dtblPurchaseReturnDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPurchaseReturnObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPurchaseReturnObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV51 " + ex.Message;
            }
        }

        public void PdcpayablereportReportPrinting(DataSet dspdcpayablereport)
        {
            try
            {
                crptPdcPayableReport crptPdcpayableReport = new crptPdcPayableReport();
                foreach (DataTable table in dspdcpayablereport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPdcpayableReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPdcpayableReport.Database.Tables["dtblpdcpayableReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPdcpayableReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPdcpayableReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV52 " + ex.Message;
            }
        }

        public void PdcreceivablereportReportPrinting(DataSet dspdcpayablereport)
        {
            try
            {
                crptPDCReceivableReport crptPDCReceivableReport = new crptPDCReceivableReport();
                foreach (DataTable table in dspdcpayablereport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPDCReceivableReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPDCReceivableReport.Database.Tables["dtblpdcReceivableReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPDCReceivableReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPDCReceivableReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV53 " + ex.Message;
            }
        }

        public void SalesOrderReportPrinting(DataSet dsSalesOrderReport, string strTotal)
        {
            try
            {
                DataTable dtblTotalAmount = new DataTable();
                dtblTotalAmount.Columns.Add("Grandtotal", typeof(string));
                DataRow dr = dtblTotalAmount.NewRow();
                dr[0] = strTotal;
                dtblTotalAmount.Rows.InsertAt(dr, 0);
                crptSalesOrderReportPrinting crptSalesOrderReportObj = new crptSalesOrderReportPrinting();
                foreach (DataTable table in dsSalesOrderReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptSalesOrderReportObj.Database.Tables["dtblCompanyReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptSalesOrderReportObj.Database.Tables["dtblSalesOrderReport"].SetDataSource(table);
                    }
                }
                crptSalesOrderReportObj.Database.Tables["dtblTotal"].SetDataSource(dtblTotalAmount);
                crptViewer.ReportSource = crptSalesOrderReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesOrderReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV54 " + ex.Message;
            }
        }

        public void MaterialReceiptReportPrinting(DataSet dsMaterialReceiptReport)
        {
            try
            {
                crptMaterialReceiptReport crptMaterialReceiptReportObj = new crptMaterialReceiptReport();
                foreach (DataTable table in dsMaterialReceiptReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptMaterialReceiptReportObj.Database.Tables["dtblCompanyReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptMaterialReceiptReportObj.Database.Tables["dtblMaterialReceiptReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptMaterialReceiptReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptMaterialReceiptReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV55 " + ex.Message;
            }
        }

        internal void SalesInvoicePrinting(DataSet dsSalesInvoiceReport)
        {
            try
            {
                crptSalesInvoice crptSalesInvoiceObj = new crptSalesInvoice();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dsSalesInvoiceReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptSalesInvoiceObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("amountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["grandTotal"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["grandTotal"].ToString());
                                row["amountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptSalesInvoiceObj.Database.Tables["dtblSalesMaster"].SetDataSource(table);
                        }
                    }
                    else
                    {
                        crptSalesInvoiceObj.Database.Tables["dtblSalesDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptSalesInvoiceObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesInvoiceObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV56 " + ex.Message;
            }
        }

        internal void SalesInvoiceReportPrinting(DataSet dsSalesInvoiceReport)
        {
            try
            {
                crptSalesInvoiceReport crptSalesInvoiceReportObj = new crptSalesInvoiceReport();
                foreach (DataTable table in dsSalesInvoiceReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptSalesInvoiceReportObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptSalesInvoiceReportObj.Database.Tables["dtblSalesMaster"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptSalesInvoiceReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptSalesInvoiceReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV57 " + ex.Message;
            }
        }

        public void DeliveryNoteReportPrinting(DataSet dsDeliveryNoteReport)
        {
            try
            {
                crptDeliveryNoteReport crptDeliveryNoteReportObj = new crptDeliveryNoteReport();
                foreach (DataTable table in dsDeliveryNoteReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptDeliveryNoteReportObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptDeliveryNoteReportObj.Database.Tables["dtblDeliveryNoteReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptDeliveryNoteReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDeliveryNoteReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV58 " + ex.Message;
            }
        }

        internal void PDCreceivableVoucherPrinting(DataSet dspdcreceivablePrinting)
        {
            try
            {
                crptPDCreceivable crptPdcReceivable = new crptPDCreceivable();
                decimal decTotalAmount = 0m;
                foreach (DataTable table in dspdcreceivablePrinting.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPdcReceivable.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DataColumn dtClmn = new DataColumn("AmountInWords");
                            table.Columns.Add(dtClmn);
                            if (row["Amount"].ToString() != string.Empty)
                            {
                                decTotalAmount = Convert.ToDecimal(row["Amount"].ToString());
                                row["AmountInWords"] = new NumToText().AmountWords(decTotalAmount, PublicVariables._decCurrencyId);
                            }
                            crptPdcReceivable.Database.Tables["dtblOtherDetails"].SetDataSource(table);
                        }
                    }
                }
                crptViewer.ReportSource = crptPdcReceivable;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPdcReceivable.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV59" + ex.Message;
            }
        }

        internal void PrintChartOfAccounts(DataTable dtblChartOfAccounts)
        {
            try
            {
                crptChartOfAccount crptChartofAccounts = new crptChartOfAccount();
                crptChartofAccounts.Database.Tables["dtblChartOfAccounts"].SetDataSource(dtblChartOfAccounts);
                crptViewer.ReportSource = crptChartofAccounts;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptChartofAccounts.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV60 " + ex.Message;
            }
        }

        public void PdcReceivablereportReportPrinting(DataSet dspdcReceivablereport)
        {
            try
            {
                crptPDCReceivableReport crptPdcreport = new crptPDCReceivableReport();
                foreach (DataTable table in dspdcReceivablereport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPdcreport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPdcreport.Database.Tables["dtblpdcreceivableReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPdcreport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPdcreport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV61 " + ex.Message;
            }
        }

        public void PartyAddressBookPrint(DataSet dsPartyAddressBook)
        {
            try
            {
                crptPartyAddressBook crptPartyAddressBook = new crptPartyAddressBook();
                foreach (DataTable table in dsPartyAddressBook.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptPartyAddressBook.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptPartyAddressBook.Database.Tables["PartyAddressDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPartyAddressBook;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPartyAddressBook.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV62 " + ex.Message;
            }
        }

        internal void ProfitAndLossReportPrinting(DataSet dsProfitAndLossReport)
        {
            try
            {
                crptProfitAndLoss crptProfitAndLossReport = new crptProfitAndLoss();
                foreach (DataTable table in dsProfitAndLossReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptProfitAndLossReport.Database.Tables["dtblProfit"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptProfitAndLossReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptProfitAndLossReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptProfitAndLossReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV63 " + ex.Message;
            }
        }

        internal void BalanceSheetReportPrint(DataSet dsAgeing)
        {
            try
            {
                crptBalanceSheet crptBalanceSheet = new crptBalanceSheet();
                foreach (DataTable table in dsAgeing.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptBalanceSheet.Database.Tables["dtblBalanceSheet"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptBalanceSheet.Database.Tables["dtblCompanyReport1"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptBalanceSheet;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptBalanceSheet.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV64 " + ex.Message;
            }
        }

        internal void AgeingReportPrint(DataSet dsAgeing)
        {
            try
            {
                crptAgeing crptAgeing = new crptAgeing();
                foreach (DataTable table in dsAgeing.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptAgeing.Database.Tables["dtblageing"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptAgeing.Database.Tables["dtblCompanyReport1"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptAgeing;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptAgeing.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV65 " + ex.Message;
            }
        }

        internal void AgeingReportPrint1(DataSet dsAgeing)
        {
            try
            {
                crptAgeing1 crptAgeing = new crptAgeing1();
                foreach (DataTable table in dsAgeing.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptAgeing.Database.Tables["dtblageing1"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptAgeing.Database.Tables["dtblCompanyReport1"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptAgeing;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptAgeing.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV66 " + ex.Message;
            }
        }

        internal void ProductStatisticsReport(DataSet dsProductStatistics, string strLevels)
        {
            try
            {
                crptProductStatisticsReport crptProductStatisticsReport = new crptProductStatisticsReport();
                crptProductStatisticsFastMoving crptProductStatisticsFastMoving = new crptProductStatisticsFastMoving();
                crptProductStatisticsMaximumLevel crptProductStatisticsMaximumLevel = new crptProductStatisticsMaximumLevel();
                crptProductStatisticsMinimumLevel crptProductStatisticsMinimumLevel = new crptProductStatisticsMinimumLevel();
                crptProductStatisticsNegativeStock crptProductStatisticsNegativeStock = new crptProductStatisticsNegativeStock();
                crptProductStatisticsReorderLevel crptProductStatisticsReorderLevel = new crptProductStatisticsReorderLevel();
                crptProductStatisticsSlowMoving crptProductStatisticsSlowMoving = new crptProductStatisticsSlowMoving();
                crptProductStatisticsUnUsed crptProductStatisticsUnused = new crptProductStatisticsUnUsed();
                foreach (DataTable table in dsProductStatistics.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        if (strLevels == "Minimum Level")
                        {
                            crptProductStatisticsMinimumLevel.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Maximum Level")
                        {
                            crptProductStatisticsMaximumLevel.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Negative Stock")
                        {
                            crptProductStatisticsNegativeStock.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Reorder Level")
                        {
                            crptProductStatisticsReorderLevel.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "UnUsed")
                        {
                            crptProductStatisticsUnused.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Fast Movings")
                        {
                            crptProductStatisticsFastMoving.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Slow Movings")
                        {
                            crptProductStatisticsSlowMoving.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table1")
                    {
                        if (strLevels == "Minimum Level")
                        {
                            crptProductStatisticsMinimumLevel.Database.Tables["dtblProductStatistics"].SetDataSource(table);
                        }
                        if (strLevels == "Maximum Level")
                        {
                            crptProductStatisticsMaximumLevel.Database.Tables["dtblProductStatistics"].SetDataSource(table);
                        }
                        if (strLevels == "Negative Stock")
                        {
                            crptProductStatisticsNegativeStock.Database.Tables["dtblProductStatistics"].SetDataSource(table);
                        }
                        if (strLevels == "Reorder Level")
                        {
                            crptProductStatisticsReorderLevel.Database.Tables["dtblProductStatistics"].SetDataSource(table);
                        }
                        if (strLevels == "UnUsed")
                        {
                            crptProductStatisticsUnused.Database.Tables["dtblProductStatistics"].SetDataSource(table);
                        }
                        if (strLevels == "Fast Movings")
                        {
                            crptProductStatisticsFastMoving.Database.Tables["dtblProductStatistics"].SetDataSource(table);
                        }
                        if (strLevels == "Slow Movings")
                        {
                            crptProductStatisticsSlowMoving.Database.Tables["dtblProductStatistics"].SetDataSource(table);
                        }
                    }
                }
                if (strLevels == "Minimum Level")
                {
                    crptViewer.ReportSource = crptProductStatisticsMinimumLevel;
                }
                if (strLevels == "Maximum Level")
                {
                    crptViewer.ReportSource = crptProductStatisticsMaximumLevel;
                }
                if (strLevels == "Negative Stock")
                {
                    crptViewer.ReportSource = crptProductStatisticsNegativeStock;
                }
                if (strLevels == "Reorder Level")
                {
                    crptViewer.ReportSource = crptProductStatisticsReorderLevel;
                }
                if (strLevels == "UnUsed")
                {
                    crptViewer.ReportSource = crptProductStatisticsUnused;
                }
                if (strLevels == "Fast Movings")
                {
                    crptViewer.ReportSource = crptProductStatisticsFastMoving;
                }
                if (strLevels == "Slow Movings")
                {
                    crptViewer.ReportSource = crptProductStatisticsSlowMoving;
                }
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptProductStatisticsReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV67 " + ex.Message;
            }
        }

        internal void FundFlow(DataSet dsFundFlow)
        {
            try
            {
                crptFundFlow crptFundFlow = new crptFundFlow();
                foreach (DataTable table in dsFundFlow.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptFundFlow.Database.Tables["dtblFund"].SetDataSource(table);
                    }
                    if (table.TableName == "Table2")
                    {
                        crptFundFlow.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    if (table.TableName == "Table3")
                    {
                        crptFundFlow.Database.Tables["dtblWC"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptFundFlow;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptFundFlow.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV68 " + ex.Message;
            }
        }

        internal void Budget(DataSet dsBudget)
        {
            try
            {
                crptBudget crptBudget = new crptBudget();
                foreach (DataTable table in dsBudget.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptBudget.Database.Tables["dtblBudget"].SetDataSource(table);
                    }
                    if (table.TableName == "Table2")
                    {
                        crptBudget.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptBudget;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptBudget.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV69" + ex.Message;
            }
        }

        internal void TrailBalanceReportPrinting(DataSet dsTrailReport)
        {
            try
            {
                crptTrialBalance crpttrail = new crptTrialBalance();
                foreach (DataTable table in dsTrailReport.Tables)
                {
                    if (table.TableName == "Table2")
                    {
                        crpttrail.Database.Tables["dtbl_Company"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crpttrail.Database.Tables["dtbltrailbal"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crpttrail;
                SettingsSP spstting = new SettingsSP();
                if (spstting.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crpttrail.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV70 " + ex.Message;
            }
        }

        internal void TaxCrystalReportPrint(DataSet dsTaxReport, bool isBillwise)
        {
            try
            {
                crptTaxReportBillWise crptTaxReportBillWise = new crptTaxReportBillWise();
                crptTaxReportProductWise crptTaxReportProductWise = new crptTaxReportProductWise();
                foreach (DataTable table in dsTaxReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        if (isBillwise)
                        {
                            crptTaxReportBillWise.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        else
                        {
                            crptTaxReportProductWise.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                    }
                    if (table.TableName == "Table1")
                    {
                        if (isBillwise)
                        {
                            crptTaxReportBillWise.Database.Tables["dtblTaxReport"].SetDataSource(table);
                        }
                        else
                        {
                            crptTaxReportProductWise.Database.Tables["dtblTaxReport"].SetDataSource(table);
                        }
                    }
                }
                if (isBillwise)
                {
                    crptViewer.ReportSource = crptTaxReportBillWise;
                }
                else
                {
                    crptViewer.ReportSource = crptTaxReportProductWise;
                }
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptTaxReportBillWise.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV71 " + ex.Message;
            }
        }

        internal void ProductSearchReport(DataSet dsProductSearch, string strLevels)
        {
            try
            {
                crptProductSearchReport crptProductSearchReport = new crptProductSearchReport();
                crptProductSearchMinimumStock crptProductSearchMinimumStock = new crptProductSearchMinimumStock();
                crptProductSearchMaximum crptProductSearchMaximum = new crptProductSearchMaximum();
                crptProductSearchNegativeStock crptProductSearchNegativeStock = new crptProductSearchNegativeStock();
                crptProductSearchReorderStock crptProductSearchReorderStock = new crptProductSearchReorderStock();
                foreach (DataTable table in dsProductSearch.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        if (strLevels == "All")
                        {
                            crptProductSearchReport.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Minimum Level")
                        {
                            crptProductSearchMinimumStock.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Maximum Level")
                        {
                            crptProductSearchMaximum.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Negative Stock")
                        {
                            crptProductSearchNegativeStock.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                        if (strLevels == "Reorder Level")
                        {
                            crptProductSearchReorderStock.Database.Tables["dtblCompany"].SetDataSource(table);
                        }
                    }
                    else if (table.TableName == "Table1")
                    {
                        if (strLevels == "All")
                        {
                            crptProductSearchReport.Database.Tables["dtblProductSearch"].SetDataSource(table);
                        }
                        if (strLevels == "Minimum Level")
                        {
                            crptProductSearchMinimumStock.Database.Tables["dtblProductSearch"].SetDataSource(table);
                        }
                        if (strLevels == "Maximum Level")
                        {
                            crptProductSearchMaximum.Database.Tables["dtblProductSearch"].SetDataSource(table);
                        }
                        if (strLevels == "Negative Stock")
                        {
                            crptProductSearchNegativeStock.Database.Tables["dtblProductSearch"].SetDataSource(table);
                        }
                        if (strLevels == "Reorder Level")
                        {
                            crptProductSearchReorderStock.Database.Tables["dtblProductSearch"].SetDataSource(table);
                        }
                    }
                }
                if (strLevels == "All")
                {
                    crptViewer.ReportSource = crptProductSearchReport;
                }
                if (strLevels == "Minimum Level")
                {
                    crptViewer.ReportSource = crptProductSearchMinimumStock;
                }
                if (strLevels == "Maximum Level")
                {
                    crptViewer.ReportSource = crptProductSearchMaximum;
                }
                if (strLevels == "Negative Stock")
                {
                    crptViewer.ReportSource = crptProductSearchNegativeStock;
                }
                if (strLevels == "Reorder Level")
                {
                    crptViewer.ReportSource = crptProductSearchReorderStock;
                }
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptProductSearchReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV72 " + ex.Message;
            }
        }

        internal void CashBankBookPrinting(DataSet dsCashBankBook)
        {
            try
            {
                crptCashBankBookReport crptCashbank = new crptCashBankBookReport();
                foreach (DataTable table in dsCashBankBook.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptCashbank.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptCashbank.Database.Tables["dtblCashBankBookDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptCashbank;
                SettingsSP spstting = new SettingsSP();
                if (spstting.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptCashbank.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV73 " + ex.Message;
            }
        }

        internal void AccountLedgerReportPrinting(DataSet dsAccountLedgerReport)
        {
            try
            {
                crptAccountLedgerReport crptAccountledgerReportObj = new crptAccountLedgerReport();
                foreach (DataTable table in dsAccountLedgerReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptAccountledgerReportObj.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptAccountledgerReportObj.Database.Tables["dtblAccountLedgerReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptAccountledgerReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptAccountledgerReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV74 " + ex.Message;
            }
        }

        internal void ShortExpiryReportPrinting(DataSet dsShortExpiryReport)
        {
            try
            {
                crptShortExpiryReport crptShortExpiryReportObj = new crptShortExpiryReport();
                foreach (DataTable table in dsShortExpiryReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptShortExpiryReportObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        table.Columns.Add("slNo");
                        int inSlNo = 1;
                        foreach (DataRow row in table.Rows)
                        {
                            row["slNo"] = inSlNo++;
                        }
                        crptShortExpiryReportObj.Database.Tables["dtblShortExpiryGrid"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptShortExpiryReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptShortExpiryReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV75 " + ex.Message;
            }
        }

        internal void CashflowReportPrinting(DataSet dsCashFlowReport)
        {
            try
            {
                crptCashFlow crptCashFlow = new crptCashFlow();
                foreach (DataTable table in dsCashFlowReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptCashFlow.Database.Tables["dtblCashflow"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptCashFlow.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptCashFlow;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptCashFlow.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV76 " + ex.Message;
            }
        }

        internal void OutstandingPrinting(DataSet dsOutstandingPrinting)
        {
            try
            {
                crptOutstanding crptOutstandingObj = new crptOutstanding();
                foreach (DataTable table in dsOutstandingPrinting.Tables)
                {
                    if (table.TableName == "Table2")
                    {
                        crptOutstandingObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptOutstandingObj.Database.Tables["dtblOutStanding"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptOutstandingObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptOutstandingObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV77 " + ex.Message;
            }
        }

        internal void dayBookReportPrintingDetailed(DataSet dsDayBookReport)
        {
            try
            {
                crptDayBookReportDetailed crptDayBookReportDetailed = new crptDayBookReportDetailed();
                foreach (DataTable table in dsDayBookReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptDayBookReportDetailed.Database.Tables["dtblDayBook"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptDayBookReportDetailed.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptDayBookReportDetailed;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDayBookReportDetailed.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV78 " + ex.Message;
            }
        }

        internal void dayBookReportPrintingCondensed(DataSet dsDayBookReportCondensed)
        {
            try
            {
                crptDayBookReportCondenced crptDaybookReportCondensed = new crptDayBookReportCondenced();
                foreach (DataTable table in dsDayBookReportCondensed.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptDaybookReportCondensed.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptDaybookReportCondensed.Database.Tables["dtblDayBook"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptDaybookReportCondensed;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptDaybookReportCondensed.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV79 " + ex.Message;
            }
        }

        internal void StockReportPrinting(DataSet dsStockReport, string strGrandTotal)
        {
            try
            {
                DataTable dtblGrandTotal = new DataTable();
                dtblGrandTotal.Columns.Add("Total", typeof(string));
                DataRow dr = dtblGrandTotal.NewRow();
                dr[0] = strGrandTotal;
                dtblGrandTotal.Rows.InsertAt(dr, 0);
                crptStockReport crptStockReportObj = new crptStockReport();
                foreach (DataTable table in dsStockReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptStockReportObj.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptStockReportObj.Database.Tables["dtblStockReport"].SetDataSource(table);
                    }
                }
                crptStockReportObj.Database.Tables["dtblTotal"].SetDataSource(dtblGrandTotal);
                crptViewer.ReportSource = crptStockReportObj;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptStockReportObj.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV80 " + ex.Message;
            }
        }

        internal void ChequeReportPrinting(DataSet dsChequeReport)
        {
            try
            {
                crptChequeReport crptChequeReport = new crptChequeReport();
                foreach (DataTable table in dsChequeReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptChequeReport.Database.Tables["dtblChequeReport"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptChequeReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptChequeReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptChequeReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV81 " + ex.Message;
            }
        }

        internal void freeSaleReport(DataSet dsFreeSale)
        {
            try
            {
                crptFreeSaleReport crptFreeSaleReport = new crptFreeSaleReport();
                foreach (DataTable table in dsFreeSale.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptFreeSaleReport.Database.Tables["dtblCompanyDetails"].SetDataSource(table);
                    }
                    if (table.TableName == "Table1")
                    {
                        crptFreeSaleReport.Database.Tables["dtblFreeSaleReport"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptFreeSaleReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptFreeSaleReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV82 " + ex.Message;
            }
        }

        internal void vatreturnReport(DataSet dtblReport)
        {
            try
            {
                crptVatreturnReport crptVatreport = new crptVatreturnReport();
                foreach (DataTable table in dtblReport.Tables)
                {
                    if (table.TableName == "Table2")
                    {
                        crptVatreport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptVatreport.Database.Tables["dtblVatreturn"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptVatreport;
                base.Show();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV83 " + ex.Message;
            }
        }

        internal void PDCClearancevoucherPrinting(DataSet dsPDCClearanceVoucher)
        {
            try
            {
                crptPDCClearanceVoucher crptClearanceReport = new crptPDCClearanceVoucher();
                foreach (DataTable table in dsPDCClearanceVoucher.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptClearanceReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptClearanceReport.Database.Tables["dtblPDCClearance"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptClearanceReport.Database.Tables["dtblPDCClearanceDetails"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptClearanceReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptClearanceReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV84" + ex.Message;
            }
        }

        internal void vatreturnReportFormat(DataSet dtblReport)
        {
            try
            {
                crptVatReport crptVatreport = new crptVatReport();
                foreach (DataTable table in dtblReport.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptVatreport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptVatreport.Database.Tables["dtblVat2"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table3")
                    {
                        crptVatreport.Database.Tables["dtblTotal"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptVatreport;
                base.Show();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV85 " + ex.Message;
            }
        }

        internal void PDCClearanceReportPrinting(DataSet dsPDCClearanceReport)
        {
            try
            {
                crptPDCClearanceReport crptPDCClear = new crptPDCClearanceReport();
                foreach (DataTable table in dsPDCClearanceReport.Tables)
                {
                    if (table.TableName == "Table")
                    {
                        crptPDCClear.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table1")
                    {
                        crptPDCClear.Database.Tables["dtblPDCClearance"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptPDCClear;
                SettingsSP spSettings = new SettingsSP();
                base.Show();
                base.BringToFront();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptPDCClear.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV86" + ex.Message;
            }
        }

        internal void AccountGroup(DataSet dsAccountGroup)
        {
            try
            {
                crptAccountGroupReport crptAccountGroupReport = new crptAccountGroupReport();
                foreach (DataTable table in dsAccountGroup.Tables)
                {
                    if (table.TableName == "Table1")
                    {
                        crptAccountGroupReport.Database.Tables["dtblAccountGroup"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table2")
                    {
                        crptAccountGroupReport.Database.Tables["dtblCompany"].SetDataSource(table);
                    }
                    else if (table.TableName == "Table3")
                    {
                        crptAccountGroupReport.Database.Tables["dtblSum"].SetDataSource(table);
                    }
                }
                crptViewer.ReportSource = crptAccountGroupReport;
                SettingsSP spSettings = new SettingsSP();
                if (spSettings.SettingsStatusCheck("DirectPrint") == "No")
                {
                    base.Show();
                    base.BringToFront();
                }
                else
                {
                    crptAccountGroupReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "CRV87 " + ex.Message;
            }
        }

        private void frmReport_KeyDown(object sender, KeyEventArgs e)
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
                formMDI.infoError.ErrorString = "CRV88 " + ex.Message;
            }
        }
    }
}
