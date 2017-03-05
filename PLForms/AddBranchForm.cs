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
    public partial class AddBranchForm : Form
    {
        IBL bl;
        public AddBranchForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            errorMessageLabel.Visible = false;
            branchTypeComboBox.DataSource = Enum.GetValues(typeof(BE.BranchType));
            

        }

        private void AddBranchForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBranchButton_Click(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;
            bool error = false;
            branchTypeLabel.ForeColor = Color.Black ;
            nameLabel.ForeColor = Color.Black;
            AdressLabel.ForeColor = Color.Black;

            //try
            //{
            if (branchTypeComboBox.SelectedIndex == 0)
            {
                branchTypeLabel.ForeColor = Color.Red;
                error = true;
                
            }

            if (AdressTextBox.Text.Trim()=="")
            {
                AdressLabel.ForeColor = Color.Red;
                error = true;
            }
            if (nameTextBox.Text.Trim() == "")
            {
                nameLabel.ForeColor = Color.Red;
                error = true;
            }
            if (error)
            {
                errorMessageLabel.Visible = true;
                return;
            }

                Branch b = new Branch
                {
                    BranchType = (BranchType)branchTypeComboBox.SelectedValue,
                    Name = nameTextBox.Text,
                    Adress = AdressTextBox.Text
                };
                //IBL bl = new BL_imp();


                bl.AddBranch(b);
                MessageBox.Show("נוסף");
                AdressTextBox.Text = string.Empty;
                nameTextBox.Text = string.Empty;
                branchTypeComboBox.DataSource = Enum.GetValues(typeof(BE.BranchType));
           // }
            //catch (Exception)
            //{
            //    MessageBox.Show("שגיאה", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
           
        }

        private void AdressLabel_Click(object sender, EventArgs e)
        {

        }

        private void branchTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

