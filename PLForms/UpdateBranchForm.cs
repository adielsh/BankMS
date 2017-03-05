using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BL;
using BE;


namespace PLForms
{
    public partial class UpdateBranchForm : Form
    {
        IBL bl;
        public UpdateBranchForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            selectIdComboBox.DataSource = DataSource.BranchesList;
            selectIdComboBox.ValueMember = "Id";
            branchTypeComboBox.DataSource = Enum.GetValues(typeof(BE.BranchType));

        }

        private void UpdateBranchForm_Load(object sender, EventArgs e)
        {

        }



        private void selectIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch selc_b = (Branch)selectIdComboBox.SelectedItem;
            nameTextBox.Text = selc_b.Name;
            branchTypeComboBox.Text = selc_b.BranchType.ToString();
            AdressTextBox.Text = selc_b.Adress;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Branch b = new Branch
            {
                Id = (int)selectIdComboBox.SelectedValue,
                BranchType = (BranchType)branchTypeComboBox.SelectedValue,
                Name = nameTextBox.Text,
                Adress = AdressTextBox.Text
            };
            bl.UpdateBranch(b);
            MessageBox.Show("עודכן");
            this.Close();
        }

        private void branchTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
