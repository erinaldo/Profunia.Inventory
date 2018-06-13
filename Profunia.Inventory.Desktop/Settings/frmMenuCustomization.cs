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
using Profunia.Inventory.Desktop.ClassFiles.General;
using Profunia.Inventory.Desktop.ClassFiles.Info;
using Profunia.Inventory.Desktop.ClassFiles.SP;
using Profunia.Inventory.Desktop.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;using Profunia.Inventory.Desktop.Company;using Profunia.Inventory.Desktop.FinancialStatements;using Profunia.Inventory.Desktop.Masters;using Profunia.Inventory.Desktop.Others;using Profunia.Inventory.Desktop.Payroll;using Profunia.Inventory.Desktop.Registers;using Profunia.Inventory.Desktop.Reminder;using Profunia.Inventory.Desktop.Reports;using Profunia.Inventory.Desktop.Search;using Profunia.Inventory.Desktop.Settings;using Profunia.Inventory.Desktop.Transactions;using Profunia.Inventory.Desktop.Transfer;using Profunia.Inventory.Desktop.Budget;
using Profunia.Inventory.Desktop.ClassFiles.SP;using Profunia.Inventory.Desktop.ClassFiles.Info;using Profunia.Inventory.Desktop.ClassFiles.General;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Profunia.Inventory.Desktop.Settings
{
    public partial class frmMenuCustomization : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        private DataTable dtblNonSelected = new DataTable();

        private DataTable dtblSelected = new DataTable();

        private UserControlQuickLaunch ucQuick = new UserControlQuickLaunch();
        #endregion

        /// <summary>
        /// Create An instance for frmMenuCustomization class
        /// </summary>
        public frmMenuCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill NonSelected Items List
        /// </summary>
        public void FillNonSelectedList()
        {
            try
            {
                QuickLaunchItemsSP spQuickLaunchItems = new QuickLaunchItemsSP();
                dtblNonSelected = spQuickLaunchItems.QuickLaunchNonSelectedViewAll(false);
                lstbxNonSelected.DataSource = dtblNonSelected;
                lstbxNonSelected.ValueMember = "quickLaunchItemsId";
                lstbxNonSelected.DisplayMember = "itemsName";
                dtblSelected = spQuickLaunchItems.QuickLaunchNonSelectedViewAll(true);
                lstbxSelected.DataSource = dtblSelected;
                lstbxSelected.ValueMember = "quickLaunchItemsId";
                lstbxSelected.DisplayMember = "itemsName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("MC:1 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //public void FillNonSelectedList()
        //{
        //    try
        //    {
        //        QuickLaunchItemsSP spQuickLaunchItems = new QuickLaunchItemsSP();
        //        dtblNonSelected = spQuickLaunchItems.QuickLaunchNonSelectedViewAll(false);
        //        lstbxNonSelected.DataSource = dtblNonSelected;
        //        lstbxNonSelected.ValueMember = "quickLaunchItemsId";
        //        lstbxNonSelected.DisplayMember = "itemsName";
        //        dtblSelected = spQuickLaunchItems.QuickLaunchNonSelectedViewAll(true);
        //        lstbxSelected.DataSource = dtblSelected;
        //        lstbxSelected.ValueMember = "quickLaunchItemsId";
        //        lstbxSelected.DisplayMember = "itemsName";
        //    }
        //    catch (Exception ex)
        //    {
        //        formMDI.infoError.ErrorString = "MC:1 " + ex.Message;
        //    }
        //}

        public void Clear()
        {
            try
            {
                lstbxNonSelected.SelectedIndex = -1;
                lstbxSelected.SelectedIndex = -1;
                lstbxNonSelected.ClearSelected();
                lstbxSelected.ClearSelected();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:2 " + ex.Message;
            }
        }

        private void SaveorEdit()
        {
            try
            {
                QuickLaunchItemsInfo infoQuickLaunchItems = new QuickLaunchItemsInfo();
                QuickLaunchItemsSP spQuickLaunchItems = new QuickLaunchItemsSP();
                if (dtblSelected.Rows.Count >= 1)
                {
                    foreach (DataRow row in dtblSelected.Rows)
                    {
                        infoQuickLaunchItems.ItemsName = row.ItemArray[0].ToString();
                        infoQuickLaunchItems.QuickLaunchItemsId = Convert.ToDecimal(row.ItemArray[1]);
                        infoQuickLaunchItems.Status = true;
                        infoQuickLaunchItems.Extra1 = string.Empty;
                        infoQuickLaunchItems.Extra2 = string.Empty;
                        spQuickLaunchItems.QuickLaunchItemsEdit(infoQuickLaunchItems);
                    }
                    foreach (DataRow row2 in dtblNonSelected.Rows)
                    {
                        infoQuickLaunchItems.ItemsName = row2.ItemArray[0].ToString();
                        infoQuickLaunchItems.QuickLaunchItemsId = Convert.ToDecimal(row2.ItemArray[1]);
                        infoQuickLaunchItems.Status = false;
                        infoQuickLaunchItems.Extra1 = string.Empty;
                        infoQuickLaunchItems.Extra2 = string.Empty;
                        spQuickLaunchItems.QuickLaunchItemsEdit(infoQuickLaunchItems);
                    }
                    Messages.SavedMessage();
                    base.Close();
                }
                else
                {
                    MessageBox.Show("Select atleast one form in quick launch", "Openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:3 " + ex.Message;
            }
        }

        private void frmMenuCustomization_Load(object sender, EventArgs e)
        {
            try
            {
                FillNonSelectedList();
                Clear();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:4 " + ex.Message;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstbxSelected.Items.Count < 19 && lstbxNonSelected.SelectedItems.Count + lstbxSelected.Items.Count <= 19)
                {
                    foreach (DataRowView selectedItem in lstbxNonSelected.SelectedItems)
                    {
                        if (lstbxSelected.Items.Count < 19)
                        {
                            DataRow dr = dtblSelected.NewRow();
                            dr[0] = selectedItem.Row.ItemArray[0].ToString();
                            dr[1] = Convert.ToDecimal(selectedItem.Row.ItemArray[1]);
                            dtblSelected.Rows.Add(dr);
                        }
                    }
                    int[] selectedIndx = new int[20];
                    int index = 0;
                    for (int j = 0; j < lstbxNonSelected.Items.Count; j++)
                    {
                        if (lstbxNonSelected.GetSelected(j))
                        {
                            selectedIndx[index] = j;
                            index++;
                        }
                    }
                    for (int i = 0; i < index; i++)
                    {
                        dtblNonSelected.Rows.RemoveAt(selectedIndx[i] - i);
                    }
                    Clear();
                }
                else
                {
                    Messages.InformationMessage("Cannot add more than nineteen item");
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:5 " + ex.Message;
            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRowView selectedItem in lstbxSelected.SelectedItems)
                {
                    DataRow dr = dtblNonSelected.NewRow();
                    dr[0] = selectedItem.Row.ItemArray[0].ToString();
                    dr[1] = Convert.ToDecimal(selectedItem.Row.ItemArray[1]);
                    dtblNonSelected.Rows.Add(dr);
                }
                int[] selectedIndx = new int[20];
                int index = 0;
                for (int j = 0; j < lstbxSelected.Items.Count; j++)
                {
                    if (lstbxSelected.GetSelected(j))
                    {
                        selectedIndx[index] = j;
                        index++;
                    }
                }
                for (int i = 0; i < index; i++)
                {
                    dtblSelected.Rows.RemoveAt(selectedIndx[i] - i);
                }
                Clear();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:6 " + ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                FillNonSelectedList();
                Clear();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:7 " + ex.Message;
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
                formMDI.infoError.ErrorString = "MC:8 " + ex.Message;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicVariables.isMessageAdd)
                {
                    if (Messages.SaveConfirmation())
                    {
                        SaveorEdit();
                    }
                }
                else
                {
                    SaveorEdit();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:9 " + ex.Message;
            }
        }

        private void frmMenuCustomization_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ucQuick.Enabled = true;
                ucQuick.ReturnFromCustomization();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:10 " + ex.Message;
            }
        }

        private void frmMenuCustomization_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Common.ExecuteShortCutKey(e, btnSave, btnClose);
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:11 " + ex.Message;
            }
        }

        public void Shows(UserControlQuickLaunch ucObj)
        {
            try
            {
                ucQuick = ucObj;
                base.Show();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "MC:12 " + ex.Message;
            }
        }


    }
}