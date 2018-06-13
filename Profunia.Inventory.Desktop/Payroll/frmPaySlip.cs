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
using System.Data;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;using Profunia.Inventory.Desktop.ClassFiles.SP;
using System.Drawing;using Profunia.Inventory.Desktop.Company;using Profunia.Inventory.Desktop.FinancialStatements;using Profunia.Inventory.Desktop.Masters;using Profunia.Inventory.Desktop.Others;using Profunia.Inventory.Desktop.Payroll;using Profunia.Inventory.Desktop.Registers;using Profunia.Inventory.Desktop.Reminder;using Profunia.Inventory.Desktop.Reports;using Profunia.Inventory.Desktop.Search;using Profunia.Inventory.Desktop.Settings;using Profunia.Inventory.Desktop.Transactions;using Profunia.Inventory.Desktop.Transfer;using Profunia.Inventory.Desktop.Budget;
using Profunia.Inventory.Desktop.ClassFiles.SP;using Profunia.Inventory.Desktop.ClassFiles.Info;using Profunia.Inventory.Desktop.ClassFiles.General;using System.Linq;
using Profunia.Inventory.Desktop.Others;using Profunia.Inventory.Desktop.Reports;using Profunia.Inventory.Desktop.Registers;using Profunia.Inventory.Desktop.Masters;using Profunia.Inventory.Desktop.Search;using System.Windows.Forms;
using Profunia.Inventory.Desktop.CrystalReports;

namespace Profunia.Inventory.Desktop.Payroll
{

    public partial class frmPaySlip : Form
    {
        #region Public Variables
        /// <summary>
        /// public varaible declaration part
        /// </summary>
        #endregion

        #region Functions

        /// <summary>
        /// creates an instance of frmPaySlip class
        /// </summary>
        public frmPaySlip()
        {
            InitializeComponent();
        }
       /// <summary>
       /// Function to fill Employee combobox
       /// </summary>
        public void FillEmployee()
        {
            try
            {
                DataTable dtbl = new DataTable();
                EmployeeSP spEmployee = new EmployeeSP();
                dtbl = spEmployee.EmployeeViewForPaySlip();
                DataRow dr = dtbl.NewRow();
                dr[1] = "--Select--";
                dtbl.Rows.InsertAt(dr, 0);
                cmbEmployee.DataSource = dtbl;
                cmbEmployee.ValueMember = "employeeId";
                cmbEmployee.DisplayMember = "employeeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 1: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to close form
        /// </summary>
        public void FormClose()                                                 
        {
            try
            {
                if (PublicVariables.isMessageClose)
                {
                    Messages.CloseMessage(this);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 2 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for print
        /// </summary>
        public void Print()
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnPrint.Text))
                {
                    if (cmbEmployee.Text == string.Empty || cmbEmployee.Text == "--Select--")
                    {
                        Messages.InformationMessage("Select an employee");
                        cmbEmployee.Focus();
                    }
                    else
                    {
                        SalaryVoucherMasterSP spSalaryVoucherMaster = new SalaryVoucherMasterSP();
                        DateTime dtMon = DateTime.Parse(dtpSalaryMonth.Text);
                        DateTime dtSalaryMonth = new DateTime(dtMon.Year, dtMon.Month, 1);
                        decimal decEmployeeId = Convert.ToDecimal(cmbEmployee.SelectedValue.ToString());
                        DataSet dsPaySlip = spSalaryVoucherMaster.PaySlipPrinting(decEmployeeId, dtSalaryMonth, 1);

                        foreach (DataTable dtbl in dsPaySlip.Tables)
                        {
                            if (dtbl.TableName == "Table1")
                            {
                                if (dtbl.Rows.Count > 0)
                                {
                                    frmReport frmRepor = new frmReport();
                                    frmRepor.MdiParent = formMDI.MDIObj;
                                    frmRepor.PaySlipPrinting(dsPaySlip);
                                }
                                else
                                {
                                    MessageBox.Show("Salary not paid", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
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
                MessageBox.Show("PS 3: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                FormClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 4 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPaySlip_Load(object sender, EventArgs e)
        {
            try
            {
                FillEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 5 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 6 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSalaryMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbEmployee.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 7 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    dtpSalaryMonth.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 8 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbEmployee.Focus();
                    cmbEmployee.SelectionStart = 0;
                    cmbEmployee.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 9 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnPrint.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 10 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPaySlip_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    FormClose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS 11 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
