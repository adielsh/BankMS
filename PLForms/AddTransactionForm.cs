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
    
    
    public partial class AddTransactionForm : Form
    {
        IBL bl;
        public AddTransactionForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            
            transTypeComboBox.DataSource = Enum.GetValues(typeof(TransType));
            fromAccountIdComboBox.DataSource = bl.GetAccountsByCondition(a => a.AccountStatus != BE.AccountStatus.חסום);
            fromAccountIdComboBox.ValueMember = "Id";
            fromAccountIdComboBox.DisplayMember = string.Format("חשבון {0} שם {1} ", "Id", "Name");
            //fromAccountIdComboBox.DisplayMember = DataSource.AccountsList.ToString();
            toAccountIdComboBox.DataSource = bl.GetAccountsByCondition(a => a.AccountStatus != BE.AccountStatus.חסום);
            toAccountIdComboBox.BindingContext = new BindingContext();
            toAccountIdComboBox.ValueMember = "Id";
           // toAccountIdComboBox.ValueMember = DataSource.AccountsList.ToString();
            
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            errorMessageLabel.Visible = false;
            fromAccountIdLabel.ForeColor = Color.Black;
            toAccountIdLabel.ForeColor = Color.Black;
            sumLabel.ForeColor = Color.Black;
            transTypeLabel.ForeColor = Color.Black;
            fromAccountIdLabel.ForeColor = Color.Black;
            toAccountIdLabel.ForeColor = Color.Black;

            int x;
            if (transTypeComboBox.SelectedIndex==0)
            {
                transTypeLabel.ForeColor = Color.Red;
                error = true;
            }


            if (fromAccountIdComboBox.SelectedIndex == toAccountIdComboBox.SelectedIndex&&(transTypeComboBox.SelectedIndex!=1&&transTypeComboBox.SelectedIndex!=4))
            {
                
                error = true;
                fromAccountIdLabel.ForeColor = Color.Red;
                toAccountIdLabel.ForeColor = Color.Red;
            }

            if (!int.TryParse(sumTextBox.Text, out x))
            {
                sumLabel.ForeColor = Color.Red;
                error = true;
            }
            if (error == true)
            {
                errorMessageLabel.Visible = true;
                return;
            }
            Transaction t = new Transaction
            {
                FromAccountId = (int)fromAccountIdComboBox.SelectedValue,
               // FromAccountId = (int)((Account)fromAccountIdComboBox.SelectedItem).Id,
                ToAccountId = (int)toAccountIdComboBox.SelectedValue,
               // ToAccountId = (int)((Account)toAccountIdComboBox.SelectedItem).Id,
                Sum = x,
                Time = DateTime.Today,
                TransType = (TransType)transTypeComboBox.SelectedValue,
                IsUpdated = false
                
            };
            if (bl.AddTrans(t)==true)
            {
                MessageBox.Show("נרשמה והתבצעה הפעולה");
                
                this.Close();
            }

            else
            {
                MessageBox.Show(" פעולה נרשמה אך לא בוצעה, כנראה אין מספיק מסגרת או יתירה");
                return;

            }


        }

        private void fromAccountIdLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void toAccountIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void transTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transTypeComboBox.SelectedIndex == 4 )
            {

                toAccountIdComboBox.Visible = false;
                toAccountIdLabel.Visible = false;
                fromAccountIdComboBox.Visible = true;
                fromAccountIdLabel.Visible = true;
                
            }

            else if (transTypeComboBox.SelectedIndex == 1)
            {
                fromAccountIdComboBox.Visible = false;
                fromAccountIdLabel.Visible = false;
                toAccountIdComboBox.Visible = true;
                toAccountIdLabel.Visible = true;
            }
            else
            {
                toAccountIdComboBox.Visible = true;
                toAccountIdLabel.Visible = true;
                fromAccountIdComboBox.Visible = true;
                fromAccountIdLabel.Visible = true;

                
            }

        }
    }
}
