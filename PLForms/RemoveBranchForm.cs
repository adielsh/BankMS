using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;
using BL;
using DAL;

namespace PLForms
{
    public partial class RemoveBranchForm : Form
    {

        IBL bl;
        public RemoveBranchForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
           //removeAccountButton.Click+=new EventHandler(removeAccountButton_Click);
           // branchIdComboBox.SelectedValueChanged+=new EventHandler(branchIdComboBox_SelectedValueChanged);   
            branchIdComboBox.DataSource = DataSource.BranchesList;
            //branchIdComboBox.ValueMember = DataSource.BranchesList;
        }

        private void branchIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            if (bl.RemoveBranch(((Branch)branchIdComboBox.SelectedItem))==true)
            {
                MessageBox.Show("נמחק");
                this.Close();
            }
            else
            {
                MessageBox.Show("קודם מחק חשבונות, אחרת אין לאן להעביר אותם");
                this.Close();
            }
        }
        private void branchIdComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //branchIdComboBox.Update();
            //branchIdComboBox.DataSource = DataSource.BranchesList;
            //branchIdComboBox.DisplayMember = "Name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void branchIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
