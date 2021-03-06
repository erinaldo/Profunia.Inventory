﻿//This is a source code or part of OpenMiracle project
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
namespace Profunia.Inventory.Desktop.Transfer
{
    public partial class frmCopyDataPrinter : Form
    {
        #region Public Variables
        string strSourceDBPath = string.Empty;
        string strDestinationDBPath = string.Empty;
        string strFailed = string.Empty;
        frmLoading f1;
        #endregion
        #region Functions
        /// <summary>
        /// Create instance of frmJournalVoucher
        /// </summary>
        public frmCopyDataPrinter()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        /// <summary>
        /// On 'Source' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSource_Click(object sender, EventArgs e)
        {
            try
            {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                txtSourcePath.Text = openFileDialog1.FileName;
                lblSuccess.Visible = false;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CopyDP:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Destination' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDestination_Click(object sender, EventArgs e)
        {
            try
            {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                txtDestinationPath.Text = openFileDialog1.FileName;
                lblSuccess.Visible = false;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CopyDP:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Copy' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            strSourceDBPath = txtSourcePath.Text.Trim();
            strDestinationDBPath = txtDestinationPath.Text.Trim();
            try
            {
            if (strSourceDBPath == string.Empty)
            {
                MessageBox.Show("Select source path", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (strDestinationDBPath == string.Empty)
                {
                    MessageBox.Show("Select destination path", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblSuccess.Visible = false;
                    backgroundWorker1.RunWorkerAsync();
                    f1 = new frmLoading();
                    f1.ShowDialog();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CopyDP:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Background worker running on Copy printer settings data from source to destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
            PrinterSettingsCopy psc = new PrinterSettingsCopy();
            strFailed = psc.CopyData(strSourceDBPath, strDestinationDBPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CopyDP:4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Background worker process completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
            f1.Close();
            if (strFailed == string.Empty)
            {
                lblSuccess.Visible = true;
                lblSuccess.Text = "Data copied succesffully";
                lblSuccess.ForeColor = Color.White;
            }
            else
            {
                MessageBox.Show("Failed for the tables\n" + strFailed, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CopyDP:5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
