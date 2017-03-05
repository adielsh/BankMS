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
    public partial class BranchesForm : Form
    {
        IBL bl;
        public BranchesForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            //AddBranchFormButton.Click+=new EventHandler(AddBranchFormButton_Click);
           // RemoveBranchFormButton.Click+=new EventHandler(RemoveBranchFormButton_Click);
           // UpdateBranchFormButton.Click+=new EventHandler(UpdateBranchFormButton_Click);
        }

        private void BranchesForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBranchFormButton_Click(object sender, EventArgs e)
        {
            AddBranchForm f = new AddBranchForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            
        }

        private void RemoveBranchFormButton_Click(object sender, EventArgs e)
        {
            if (DataSource.BranchesList.Count() == 0)
            {
                MessageBox.Show("רשימת סניפים ריקה");
                return;

            }
            RemoveBranchForm f = new RemoveBranchForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void UpdateBranchFormButton_Click(object sender, EventArgs e)
        {
            if (DataSource.BranchesList.Count() == 0)
            {
                MessageBox.Show("רשימת סניפים ריקה");
                return;

            }
            UpdateBranchForm f = new UpdateBranchForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
