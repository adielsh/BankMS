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
    public partial class MainForm : Form
    {
        IBL bl;
        public MainForm()
        {
            bl = FactoryBL.getBL();
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AccountsFormButton_Click(object sender, EventArgs e)
        {
            if (DataSource.BranchesList.Count() == 0)
            {
                MessageBox.Show("קודם הזן סניף");
                return;

            }
            AccountsForm f = new AccountsForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();

            
        }

        private void TransactionFormButton_Click(object sender, EventArgs e)
        {
            new TranscationForm(bl).ShowDialog();
        }

        private void BranchesFormButton_Click(object sender, EventArgs e)
        {
            BranchesForm f = new BranchesForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void queriesButton_Click(object sender, EventArgs e)
        {
            if (DataSource.AccountsList.Count() == 0 && DataSource.BranchesList.Count() == 0 && DataSource.TransactionsList.Count() == 0)
            {
                MessageBox.Show("קודם הזן נתונים כלשהם");
                return;

            }
            QueriesForm f = new QueriesForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        }
    }

