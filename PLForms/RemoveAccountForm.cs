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

    public partial class RemoveAccountForm : Form
    {
        IBL bl;
        public RemoveAccountForm(IBL bl)
        {
            InitializeComponent();
            this.bl = bl;
            
            accountIdComboBox.DataSource = DataSource.AccountsList;
            accountIdComboBox.DisplayMember = "Name";
        }

        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            bl.RemoveAccount((Account)accountIdComboBox.SelectedItem);
            MessageBox.Show("נמחק");
            this.Close();
        }

    }
}
