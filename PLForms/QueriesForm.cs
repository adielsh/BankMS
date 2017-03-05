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
    public partial class QueriesForm : Form
    {
        IBL bl;
        public QueriesForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void QueriesForm_Load(object sender, EventArgs e)
        {

        }

        private void byAccountQueriesButton_Click(object sender, EventArgs e)
        {

            if (DataSource.AccountsList.Count() == 0)
            {
                MessageBox.Show("קודם הזן חשבון");
                return;

            }
            AccountsQueryForm f = new AccountsQueryForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void byBranchQueriesButton_Click(object sender, EventArgs e)
        {
            if (DataSource.BranchesList.Count() == 0)
            {
                MessageBox.Show("קודם הזן סניף");
                return;

            }
            BranchesQueryForm f = new BranchesQueryForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void byTransQueriesButton_Click(object sender, EventArgs e)
        {
            if (DataSource.TransactionsList.Count()==0)
            {
                MessageBox.Show("קודם הזו פעולות");
                return;

            }
            TransQueryForm f = new TransQueryForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
