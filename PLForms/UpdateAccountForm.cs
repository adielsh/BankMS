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
    public partial class UpdateAccountForm : Form
    {
        IBL bl;
        public UpdateAccountForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();

            selectIdComboBox.DataSource = DataSource.AccountsList;
            selectIdComboBox.ValueMember = "Id";
            //selectIdComboBox.DisplayMember = "Id";            
            accountStatusComboBox.DataSource = Enum.GetValues(typeof(BE.AccountStatus));
            branchIdComboBox.DataSource = DataSource.BranchesList;
            branchIdComboBox.ValueMember = "Id";
            //   branchIdComboBox.DisplayMember = "Name";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            try
            {
                errorMessageLabel.Visible = false;
                bool error = false;
                creditNumberLabel.ForeColor = Color.Black;
                AdressLabel.ForeColor = Color.Black;
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

                if (AdressTextBox.Text.Trim() == "")
                {
                    AdressLabel.ForeColor = Color.Red;
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

                if (accountStatusComboBox.SelectedIndex == 0)
                {

                    accountStatusLabel.ForeColor = Color.Red;
                    error = true;
                }



                if (nameTextBox.Text.Trim() == "")
                {
                    nameLabel.ForeColor = Color.Red;
                    error = true;
                }

                if (allowedTextBox.Text.Trim() == "" && bussinesAccountRadioButton.Checked == true)
                {
                    allowedLabel.ForeColor = Color.Red;
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

                if (privateAccountRadioButton.Checked == true)
                {
                    PrivateAccount p = new PrivateAccount
                    {
                        Id = (int)selectIdComboBox.SelectedValue,
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
                    bl.UpdateAccount(p);
                    MessageBox.Show("עודכן");
                }
                else
                {
                    BussinesAccount b = new BussinesAccount
                    {
                        Id = (int)selectIdComboBox.SelectedValue,
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

                    bl.UpdateAccount(b);
                    MessageBox.Show("עודכן");


                }
            }

            catch (Exception)
            {
                MessageBox.Show("שגיאה לא צפויה אחינו", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //נסיונות קודמים

        // {

        //    Account selc_a = (Account)selectIdComboBox.SelectedItem;


        //    bool error = false;
        //    creditLabel.ForeColor = Color.Black;
        //    selectedAccountTypeLabel.ForeColor = Color.Black;
        //    balanceLabel.ForeColor = Color.Black;
        //    selectedAccountTypeLabel.ForeColor = Color.Black;
        //    creditNumberLabel.ForeColor = Color.Black;



        //    int x, y, z;
        //    if (!int.TryParse(balanceTextBox.Text, out x))
        //    {
        //        balanceLabel.ForeColor = Color.Red;
        //        error = true;
        //    }

        //    if (!int.TryParse(creditTextBox.Text, out y))
        //    {

        //        creditLabel.ForeColor = Color.Red;
        //        error = true;
        //    }

        //    if (!int.TryParse(creditNumberTextBox.Text, out z)&&selc_a.IsPrivate==true)
        //    {

        //        creditNumberLabel.ForeColor = Color.Red;
        //        error = true;
        //    }


        //    if (error == true)
        //    {
        //        MessageBox.Show("תקן את השדות המסומנים");
        //        return;
        //    }


        //     if (selc_a.IsPrivate == true)
        //     {
        //            creditNumberLabel.Visible = true;
        //            creditNumberTextBox.Visible = true;
        //             PrivateAccount p = new PrivateAccount
        //             {
        //                 Id = (int)selectIdComboBox.SelectedValue,
        //                 Name = nameTextBox.Text,
        //                 OpenDate = selc_a.OpenDate,
        //                 Password = passwordTextBox.Text,
        //                 PhoneNumber = phoneNumberTextBox.Text,
        //                 AccountStatus = (AccountStatus)accountStatusComboBox.SelectedValue,
        //                 BranchId = (int)branchIdComboBox.SelectedValue,
        //                 Balance = x,
        //                 Credit = y,
        //                 CreditNumber = z,
        //                 IsPrivate = false,


        //             };
        //             bl.UpdateAccount(p);
        //             //selectIdComboBox.Update();
        //             MessageBox.Show("עודכן");
        //             this.Close();

        //      }
        //else if (selc_a.IsPrivate == false)
        //     {
        //         creditNumberLabel.Visible = false;
        //         creditNumberTextBox.Visible = false;


        //             BussinesAccount b = new BussinesAccount
        //             {
        //                 Id = (int)selectIdComboBox.SelectedValue,
        //                 Name = nameTextBox.Text,
        //                 OpenDate = selc_a.OpenDate,
        //                 PhoneNumber = phoneNumberTextBox.Text,
        //                 Password = passwordTextBox.Text,
        //                 AccountStatus = (AccountStatus)accountStatusComboBox.SelectedItem,
        //                 BranchId = (int)branchIdComboBox.SelectedValue,
        //                 Balance = x,
        //                 Credit = y,
        //                 IsPrivate = false,
        //                 Allowed = allowedTextBox.Text.Split().ToList<string>()
        //             };
        //             bl.UpdateAccount(b);
        //             selectIdComboBox.Update();
        //             MessageBox.Show("עודכן");
        //             this.Close();
        //         }
        //    }

        private void selectIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selc_a = (Account)selectIdComboBox.SelectedItem;

            accountStatusComboBox.Text = selc_a.AccountStatus.ToString();
            branchIdComboBox.Text = (DataSource.BranchesList.FirstOrDefault(b => b.Id == selc_a.BranchId)).Name;
            balanceTextBox.Text = selc_a.Balance.ToString();
            AdressTextBox.Text = selc_a.Adress.ToString();
            creditTextBox.Text = selc_a.Credit.ToString();
            phoneNumberTextBox.Text = selc_a.PhoneNumber;
            passwordTextBox.Text = selc_a.Password;
            nameTextBox.Text = selc_a.Name;


            if (selc_a.IsPrivate == true)
            {
                PrivateAccount priv_selc_a = (PrivateAccount)selc_a;
                privateAccountRadioButton.Checked = true;
                creditNumberLabel.Visible = true;
                creditNumberTextBox.Visible = true;
                creditNumberTextBox.Text = priv_selc_a.CreditNumber.ToString();
                allowedLabel.Visible = false;
                allowedTextBox.Visible = false;
                

            }
            else
            {
                BussinesAccount buss_selc_b = (BussinesAccount)selc_a;
                bussinesAccountRadioButton.Checked = true;
                allowedLabel.Visible = true;
                allowedTextBox.Visible = true;
                allowedTextBox.Text = string.Join("", buss_selc_b.Allowed.ToArray());
                creditNumberLabel.Visible = false;
                creditNumberTextBox.Visible = false;
                

            }
        }

        private void creditLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAccountForm_Load(object sender, EventArgs e)
        {

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
    }
}





 

