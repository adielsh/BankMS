using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;
using DAL;
using BL;

namespace PLForms
{
    public partial class AddAccountForm : Form
    {
        IBL bl;
        public AddAccountForm(IBL bl)
        {
            this.bl = bl;
           
            InitializeComponent();
            errorMessageLabel.Visible = false;
            accountStatusComboBox.DataSource = Enum.GetValues(typeof(BE.AccountStatus));
            branchIdComboBox.DataSource = DataSource.BranchesList;
            branchIdComboBox.ValueMember = "Id";
            branchIdComboBox.DisplayMember = "Name";
            creditNumberLabel.Visible = false;
            creditNumberTextBox.Visible = false;
            allowedLabel.Visible = false;
            allowedTextBox.Visible = false;
            
            

        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {

            try
            {
                errorMessageLabel.Visible = false;
                bool error = false;
                AdressLabel.ForeColor = Color.Black;
                creditNumberLabel.ForeColor = Color.Black;
                creditLabel.ForeColor = Color.Black;
                selectAccountTypeLabel.ForeColor = Color.Black;
                balanceLabel.ForeColor = Color.Black;
                selectAccountTypeLabel.ForeColor = Color.Black;
                nameLabel.ForeColor = Color.Black;
                passwordLabel.ForeColor = Color.Black;
                phoneNumberLabel.ForeColor = Color.Black;
                accountStatusLabel.ForeColor = Color.Black;
                allowedLabel.ForeColor = Color.Black;
             
                int x, y, z;
                long w;
                if (!int.TryParse(balanceTextBox.Text, out x))
                {
                    balanceLabel.ForeColor = Color.Red;
                    error = true;
                }

             
                if (!long.TryParse(phoneNumberTextBox.Text, out w))
                {
                    phoneNumberLabel.ForeColor = Color.Red;
                    error = true;
                }
           
           
                if (!int.TryParse(creditNumberTextBox.Text, out y) && privateAccountRadioButton.Checked == true)
                {
                    creditNumberLabel.ForeColor = Color.Red;
                    error = true;
                }


                if (!int.TryParse(creditTextBox.Text, out z))
                {

                    creditLabel.ForeColor = Color.Red;
                    error = true;
                }
           
                if (privateAccountRadioButton.Checked == false && bussinesAccountRadioButton.Checked == false)
                {
                    selectAccountTypeLabel.ForeColor = Color.Red;
                    error = true;
                }
                
                if (accountStatusComboBox.SelectedIndex==0)
                {

                    accountStatusLabel.ForeColor = Color.Red;
                    error = true;
                }

              

                if (nameTextBox.Text.Trim()=="")
                {
                    nameLabel.ForeColor = Color.Red;
                    error = true;
                }

                if (allowedTextBox.Text.Trim() == ""&&bussinesAccountRadioButton.Checked==true)
                {
                    allowedLabel.ForeColor = Color.Red;
                    error = true;
                }

                if (AdressTextBox.Text.Trim() == "")
                {
                    AdressLabel.ForeColor = Color.Red;
                    error = true;
                }

                if (passwordTextBox.Text.Trim() == "")
                {
                    passwordLabel.ForeColor = Color.Red;
                    error = true;
                }



                if (error == true)
                {
                    errorMessageLabel.Visible = true;
                 
                    return;
                }

                if (privateAccountRadioButton.Checked)
                {
                    PrivateAccount p = new PrivateAccount
                          {
                              Name = nameTextBox.Text,
                              Adress = AdressTextBox.Text,
                              OpenDate = DateTime.Now,
                              Password = passwordTextBox.Text,
                              AccountStatus = (AccountStatus)accountStatusComboBox.SelectedItem,
                              PhoneNumber = phoneNumberTextBox.Text,
                              BranchId = (int)branchIdComboBox.SelectedValue,
                              Balance = x,
                              Credit = z,
                              CreditNumber = y,
                              IsPrivate = true
                          };
                    bl.AddAccount(p);
                    MessageBox.Show("נוסף");
                }
                else 
                {
                    BussinesAccount b = new BussinesAccount
                    {
                        Name = nameTextBox.Text,
                        Adress = AdressTextBox.Text,
                        OpenDate = DateTime.Now,
                        Password = passwordTextBox.Text,
                        PhoneNumber = phoneNumberTextBox.Text,
                        AccountStatus = (AccountStatus)accountStatusComboBox.SelectedItem,
                        BranchId = (int)branchIdComboBox.SelectedValue,
                        Balance = x,
                        Credit = z,
                        IsPrivate = false,
                        Allowed = allowedTextBox.Text.Split().ToList<string>()

                    };
                    
                    bl.AddAccount(b);
                    MessageBox.Show("נוסף");
                    

                }
                nameTextBox.Text = string.Empty;
                AdressTextBox.Text = string.Empty;
                balanceTextBox.Text = string.Empty;
                creditTextBox.Text = string.Empty;
                creditNumberTextBox.Text = string.Empty;
                phoneNumberTextBox.Text = string.Empty;
                accountStatusComboBox.DataSource = Enum.GetValues(typeof(BE.AccountStatus));
                branchIdComboBox.DataSource = DataSource.BranchesList;
                passwordTextBox.Text = string.Empty;
                privateAccountRadioButton.Checked = false;
                bussinesAccountRadioButton.Checked = false;
                allowedTextBox.Text = string.Empty;
                allowedTextBox.Visible = false;
                allowedLabel.Visible = false;


            }

            catch (Exception)
            {
                MessageBox.Show("שגיאה לא צפויה אחינו", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void AddAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void accountStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void privateNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void creditNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void privateAccountRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (privateAccountRadioButton.Checked == true)
            {
                creditNumberTextBox.Visible = true;
                creditNumberLabel.Visible = true;
                allowedLabel.Visible = false;
                allowedTextBox.Visible = false;
            }



            else
            {
                creditNumberTextBox.Visible = false;
                creditNumberLabel.Visible = false;
                allowedLabel.Visible = true;
                allowedTextBox.Visible = true;
            }

        }

        private void bussinesAccountRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (privateAccountRadioButton.Checked == false)
            {
                creditNumberTextBox.Visible = false;
                creditNumberLabel.Visible = false;
                allowedLabel.Visible = true;
                allowedTextBox.Visible = true;
            }



            else
            {
                creditNumberTextBox.Visible = true;
                creditNumberLabel.Visible = true;
                allowedLabel.Visible = false;
                allowedTextBox.Visible = false;
            }
        }
    }
}
