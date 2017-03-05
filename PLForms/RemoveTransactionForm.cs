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
    public partial class RemoveTransactionForm : Form
    {
        IBL bl;
        public RemoveTransactionForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            transIdComboBox.DataSource = bl.GetTransByCondition(t => t.IsUpdated == false);
           
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeTransButton_Click(object sender, EventArgs e)
        {
           if( bl.RemoveTrans((Transaction)transIdComboBox.SelectedItem))
            MessageBox.Show("פעולה נמחקה");
           else
               MessageBox.Show("שגיאה");
             
        }

    }
}
