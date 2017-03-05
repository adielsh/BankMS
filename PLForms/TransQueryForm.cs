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
    public partial class TransQueryForm : Form
    {
        IBL bl;
        public TransQueryForm(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            selectAccountComboBox.DataSource = DataSource.AccountsList;
            selectAccountComboBox.ValueMember = "Id";

        }

        private void TransQueryForm_Load(object sender, EventArgs e)
        {

        }

        private void showTransPerAccountNdateButton_Click(object sender, EventArgs e)
        {
            TransGridView.DataSource = null;
            TransGridView.DataSource = bl.SumOfTransPerAccount((int)selectAccountComboBox.SelectedValue, (DateTime)fromDateTimePicker.Value, (DateTime)toDateTimePicker.Value);
        }

        private void selectAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void betweenDatesButton_Click(object sender, EventArgs e)
        {
             TransGridView.DataSource = null;
             TransGridView.DataSource = bl.GetAllTarnsFromDateToDate((DateTime)fromDateTimePicker.Value, (DateTime)toDateTimePicker.Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransGridView.DataSource = bl.GetTransByCondition(t => t.Id >= 1);
        }

    }
}
