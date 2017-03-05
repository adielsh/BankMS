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
    public partial class UpdateTransForm : Form
    {
        IBL bl;
        public UpdateTransForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            transListToUpdateComboBox.DataSource = bl.GetTransByCondition(t => t.IsUpdated == false);
            
            
        }

        private void TransUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void transListToUpdateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (bl.UpdateTrans((Transaction)transListToUpdateComboBox.SelectedItem))
            {
                MessageBox.Show("בוצע עדכון לפעולה. יישר כוח");
                this.Close();

            }
            else
            {
                MessageBox.Show("עדיין לא מתאפשר לבצע את הפעולה. הכל לטובה");
                this.Close();
            }
        }

        private void UpdateAllTransButton_Click(object sender, EventArgs e)
        {
            bl.AllAccountsUpdate(DataSource.TransactionsList);
            MessageBox.Show("כל העדכונים שהתאפשרו במסגרת היתרה והמסגרת בוצעו לכל החשבונות ברשימה");
            this.Close();
        }
    }
}
