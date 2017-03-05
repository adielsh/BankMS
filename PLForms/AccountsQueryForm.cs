using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using DAL;
using BE;
namespace PLForms
{
    public partial class AccountsQueryForm : Form
    {
        IBL bl;
        public AccountsQueryForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
           // accountQueryGridView.Columns[0].HeaderText = "";


        }

        private void accountQueryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showAllAccountsButton_Click(object sender, EventArgs e)
        {
            accountQueryGridView.DataSource = null;
            accountQueryGridView.Columns.Cast<Account>();
            accountQueryGridView.DataSource = DataSource.AccountsList;
            int how = bl.HowMuchAccounts();
            howMuchAccountTextBox.Visible = true;

            howMuchAccountTextBox.Text = string.Format("{0} כמות החשבונות סך הכל", how);
           
        }

        private void showByAccountTypeButton_Click(object sender, EventArgs e)
        {
            howMuchAccountTextBox.Visible = false;

            if (accountTypeComboBox.SelectedIndex == 1)
            {
                 accountQueryGridView.DataSource = null;
                 accountQueryGridView.Columns.Cast<PrivateAccount>();
                 accountQueryGridView.DataSource = bl.GetAllPrivateAccounts();

            }
            else if (accountTypeComboBox.SelectedIndex == 2)
            {

                accountQueryGridView.DataSource = null;
                accountQueryGridView.Columns.Cast<BussinesAccount>();
                accountQueryGridView.DataSource = bl.GetAllBussinesAccounts();
            }

        }

        private void showAccountsPerSuButton_Click(object sender, EventArgs e)
        {
            int x;
           

                if (!int.TryParse(sumOfAccountTextBox.Text, out x))
                    MessageBox.Show("הזן סכום חוקי");
                else
                {
                    accountQueryGridView.DataSource = null;
                    if (UpOrDownComboBox.SelectedIndex == 0)
                    {
                        Predicate<Account> p = a => a.Balance >= x;
                       accountQueryGridView.DataSource = bl.GetAccountsByCondition(p);
                    }
                    else if (UpOrDownComboBox.SelectedIndex == 1)
                    {
                        Predicate<Account> p = a => a.Balance < x;
                        accountQueryGridView.DataSource = bl.GetAccountsByCondition(p);
                    }
                 }
                

         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

            
      }


}

