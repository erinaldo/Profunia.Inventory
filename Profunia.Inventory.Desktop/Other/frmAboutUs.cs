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
namespace Profunia.Inventory.Desktop.Others
{
    public partial class frmAboutUs : Form
    {
        #region Function
        /// <summary>
        /// Creates an instance of frmAboutUs class
        /// </summary>
        public frmAboutUs()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        /// <summary>
        /// On link label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbtnOM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.openmiracle.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AU1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On link label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbtnCybro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://cybrosys.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AU2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAboutUs_KeyDown(object sender, KeyEventArgs e)
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
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AU: 28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
