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

namespace PLForms
{
    public partial class AccountsForm : Form
    {
        BL.IBL bl;
        public AccountsForm(BL.IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAccountFormButton_Click(object sender, EventArgs e)
        {
            AddAccountForm f = new AddAccountForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void RemoveAccountFormButton_Click(object sender, EventArgs e)
        {
            if (DataSource.AccountsList.Count() == 0)
            {
                MessageBox.Show("קודם שיהיה חשבון למחוק אחי");
                return;
            }

            RemoveAccountForm f = new RemoveAccountForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void UpdateAccountFormButton_Click(object sender, EventArgs e)
        {
            if (DataSource.AccountsList.Count() == 0)
            {
                MessageBox.Show("קודם שיהיה חשבון כלשהו לעדכן אחי");
                return;
            }

            UpdateAccountForm f = new UpdateAccountForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataSource.AccountsList.Count() == 0)
            {
                MessageBox.Show("קודם שיהיה חשבון כלשהו לעשות עליו שאילתא אחי");
                return;
            }

            AccountsQueryForm f = new AccountsQueryForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
