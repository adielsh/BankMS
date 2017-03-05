using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using BE;
using DAL;

namespace PLForms
{
    public partial class BranchesQueriesForm : Form
    {
        IBL bl;
        public BranchesQueriesForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            branchTypeComboBox.DataSource = Enum.GetValues(typeof(BE.BranchType));
            branchTypeComboBox.ValueMember = "BranchType";

            
        }

        private void BranchesQueriesForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if(branchTypeComboBox.SelectedIndex==0)
            brachQueriesGridView.DataSource = bl.GetBranchesByCondition(b => b.BranchType == (BranchType)branchTypeComboBox.SelectedValue);
        }
    }
}
