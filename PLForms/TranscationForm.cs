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
    
    public partial class TranscationForm : Form
    {
        IBL bl;
        public TranscationForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            
        }

        private void AddTransFormButton_Click(object sender, EventArgs e)
        {
            //if (DataSource.AccountsList.Count() == 0)
            //{
            //    MessageBox.Show("אין חשבונות רשומים");
            //    return;
            //}
            AddTransactionForm f = new AddTransactionForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
             
             
        }

        private void RemoveTransFormButton_Click(object sender, EventArgs e)
        {
            if (DataSource.TransactionsList.Count() == 0)
            {
                MessageBox.Show("אין פעולות רשומות");
                return;
            }
            RemoveTransactionForm f = new RemoveTransactionForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
             
        }

        private void UpdateTransFormButton_Click(object sender, EventArgs e)
        {
            if (DataSource.TransactionsList.Count() == 0)
            {
                MessageBox.Show("אין פעולות רשומות");
                return;
            }
            UpdateTransForm f = new UpdateTransForm(bl);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void TranscationForm_Load(object sender, EventArgs e)
        {

        }

    }
}
