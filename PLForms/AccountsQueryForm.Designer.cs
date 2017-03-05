namespace PLForms
{
    partial class AccountsQueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accountQueryGridView = new System.Windows.Forms.DataGridView();
            this.showAllAccountsButton = new System.Windows.Forms.Button();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.showByAccountTypeButton = new System.Windows.Forms.Button();
            this.showAccountsPerSuButton = new System.Windows.Forms.Button();
            this.UpOrDownComboBox = new System.Windows.Forms.ComboBox();
            this.sumOfAccountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.howMuchAccountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.accountQueryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountQueryGridView
            // 
            this.accountQueryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountQueryGridView.Location = new System.Drawing.Point(25, 151);
            this.accountQueryGridView.Name = "accountQueryGridView";
            this.accountQueryGridView.Size = new System.Drawing.Size(745, 299);
            this.accountQueryGridView.TabIndex = 2;
            this.accountQueryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountQueryGridView_CellContentClick);
            // 
            // showAllAccountsButton
            // 
            this.showAllAccountsButton.Location = new System.Drawing.Point(551, 10);
            this.showAllAccountsButton.Name = "showAllAccountsButton";
            this.showAllAccountsButton.Size = new System.Drawing.Size(115, 52);
            this.showAllAccountsButton.TabIndex = 3;
            this.showAllAccountsButton.Text = "הצג את כל החשבונות";
            this.showAllAccountsButton.UseVisualStyleBackColor = true;
            this.showAllAccountsButton.Click += new System.EventHandler(this.showAllAccountsButton_Click);
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "",
            "פרטי",
            "עסקי"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(243, 41);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.accountTypeComboBox.TabIndex = 4;
            this.accountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.accountTypeComboBox_SelectedIndexChanged);
            // 
            // showByAccountTypeButton
            // 
            this.showByAccountTypeButton.Location = new System.Drawing.Point(132, 41);
            this.showByAccountTypeButton.Name = "showByAccountTypeButton";
            this.showByAccountTypeButton.Size = new System.Drawing.Size(89, 23);
            this.showByAccountTypeButton.TabIndex = 5;
            this.showByAccountTypeButton.Text = "הצג";
            this.showByAccountTypeButton.UseVisualStyleBackColor = true;
            this.showByAccountTypeButton.Click += new System.EventHandler(this.showByAccountTypeButton_Click);
            // 
            // showAccountsPerSuButton
            // 
            this.showAccountsPerSuButton.Location = new System.Drawing.Point(132, 79);
            this.showAccountsPerSuButton.Name = "showAccountsPerSuButton";
            this.showAccountsPerSuButton.Size = new System.Drawing.Size(89, 23);
            this.showAccountsPerSuButton.TabIndex = 6;
            this.showAccountsPerSuButton.Text = "הצג";
            this.showAccountsPerSuButton.UseVisualStyleBackColor = true;
            this.showAccountsPerSuButton.Click += new System.EventHandler(this.showAccountsPerSuButton_Click);
            // 
            // UpOrDownComboBox
            // 
            this.UpOrDownComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpOrDownComboBox.FormattingEnabled = true;
            this.UpOrDownComboBox.Items.AddRange(new object[] {
            "יתירה מעל",
            "יתירה מתחת"});
            this.UpOrDownComboBox.Location = new System.Drawing.Point(404, 79);
            this.UpOrDownComboBox.Name = "UpOrDownComboBox";
            this.UpOrDownComboBox.Size = new System.Drawing.Size(121, 21);
            this.UpOrDownComboBox.TabIndex = 7;
            // 
            // sumOfAccountTextBox
            // 
            this.sumOfAccountTextBox.Location = new System.Drawing.Point(243, 82);
            this.sumOfAccountTextBox.Name = "sumOfAccountTextBox";
            this.sumOfAccountTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumOfAccountTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "הצג חשבונות לפי תנאי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "הצגה לפי סוג חשבון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "סכום";
            // 
            // howMuchAccountTextBox
            // 
            this.howMuchAccountTextBox.Location = new System.Drawing.Point(25, 125);
            this.howMuchAccountTextBox.Name = "howMuchAccountTextBox";
            this.howMuchAccountTextBox.ReadOnly = true;
            this.howMuchAccountTextBox.Size = new System.Drawing.Size(148, 20);
            this.howMuchAccountTextBox.TabIndex = 12;
            this.howMuchAccountTextBox.Visible = false;
            this.howMuchAccountTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AccountsQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 470);
            this.Controls.Add(this.howMuchAccountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumOfAccountTextBox);
            this.Controls.Add(this.UpOrDownComboBox);
            this.Controls.Add(this.showAccountsPerSuButton);
            this.Controls.Add(this.showByAccountTypeButton);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.showAllAccountsButton);
            this.Controls.Add(this.accountQueryGridView);
            this.Name = "AccountsQueryForm";
            this.Text = "AccountsQueryForm";
            ((System.ComponentModel.ISupportInitialize)(this.accountQueryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accountQueryGridView;
        private System.Windows.Forms.Button showAllAccountsButton;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Button showByAccountTypeButton;
        private System.Windows.Forms.Button showAccountsPerSuButton;
        private System.Windows.Forms.ComboBox UpOrDownComboBox;
        private System.Windows.Forms.TextBox sumOfAccountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox howMuchAccountTextBox;
    }
}