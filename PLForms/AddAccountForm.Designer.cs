namespace PLForms
{
    partial class AddAccountForm
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
            this.accountStatusLabel = new System.Windows.Forms.Label();
            this.branchIdLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.creditNumberLabel = new System.Windows.Forms.Label();
            this.accountStatusComboBox = new System.Windows.Forms.ComboBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.branchIdComboBox = new System.Windows.Forms.ComboBox();
            this.creditNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.privateAccountRadioButton = new System.Windows.Forms.RadioButton();
            this.bussinesAccountRadioButton = new System.Windows.Forms.RadioButton();
            this.selectAccountTypeLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.allowedLabel = new System.Windows.Forms.Label();
            this.allowedTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accountStatusLabel
            // 
            this.accountStatusLabel.AutoSize = true;
            this.accountStatusLabel.Location = new System.Drawing.Point(353, 116);
            this.accountStatusLabel.Name = "accountStatusLabel";
            this.accountStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountStatusLabel.Size = new System.Drawing.Size(79, 13);
            this.accountStatusLabel.TabIndex = 1;
            this.accountStatusLabel.Text = "סטטוס חשבון:";
            this.accountStatusLabel.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // branchIdLabel
            // 
            this.branchIdLabel.AutoSize = true;
            this.branchIdLabel.Location = new System.Drawing.Point(353, 175);
            this.branchIdLabel.Name = "branchIdLabel";
            this.branchIdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchIdLabel.Size = new System.Drawing.Size(53, 13);
            this.branchIdLabel.TabIndex = 5;
            this.branchIdLabel.Text = "שם סניף:";
            this.branchIdLabel.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(350, 245);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordLabel.Size = new System.Drawing.Size(79, 13);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "בחירת סיסמא:";
            this.passwordLabel.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(353, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(62, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "שם בעלים:";
            this.nameLabel.Click += new System.EventHandler(this.privateNameLabel_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(350, 37);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.phoneNumberLabel.TabIndex = 23;
            this.phoneNumberLabel.Text = "מספר טלפון:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(353, 150);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.balanceLabel.Size = new System.Drawing.Size(40, 13);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "יתירה:";
            this.balanceLabel.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(350, 202);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creditLabel.Size = new System.Drawing.Size(82, 13);
            this.creditLabel.TabIndex = 7;
            this.creditLabel.Text = "מסגרת אשראי:";
            this.creditLabel.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // creditNumberLabel
            // 
            this.creditNumberLabel.AutoSize = true;
            this.creditNumberLabel.Location = new System.Drawing.Point(350, 280);
            this.creditNumberLabel.Name = "creditNumberLabel";
            this.creditNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creditNumberLabel.Size = new System.Drawing.Size(139, 13);
            this.creditNumberLabel.TabIndex = 19;
            this.creditNumberLabel.Text = "מספר כרטיס אשראי פרטי:";
            this.creditNumberLabel.Click += new System.EventHandler(this.creditNumberLabel_Click);
            // 
            // accountStatusComboBox
            // 
            this.accountStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountStatusComboBox.FormattingEnabled = true;
            this.accountStatusComboBox.Location = new System.Drawing.Point(130, 113);
            this.accountStatusComboBox.Name = "accountStatusComboBox";
            this.accountStatusComboBox.Size = new System.Drawing.Size(200, 21);
            this.accountStatusComboBox.TabIndex = 3;
            this.accountStatusComboBox.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(130, 147);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.balanceTextBox.TabIndex = 4;
            this.balanceTextBox.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(130, 199);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(200, 20);
            this.creditTextBox.TabIndex = 6;
            this.creditTextBox.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(130, 242);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(26, 194);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(70, 61);
            this.AddAccountButton.TabIndex = 12;
            this.AddAccountButton.Text = "הוספה";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // branchIdComboBox
            // 
            this.branchIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchIdComboBox.FormattingEnabled = true;
            this.branchIdComboBox.Location = new System.Drawing.Point(130, 172);
            this.branchIdComboBox.Name = "branchIdComboBox";
            this.branchIdComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.branchIdComboBox.Sorted = true;
            this.branchIdComboBox.TabIndex = 5;
            this.branchIdComboBox.Move += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // creditNumberTextBox
            // 
            this.creditNumberTextBox.Location = new System.Drawing.Point(130, 277);
            this.creditNumberTextBox.Name = "creditNumberTextBox";
            this.creditNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.creditNumberTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(130, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(130, 34);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 0;
            // 
            // privateAccountRadioButton
            // 
            this.privateAccountRadioButton.AutoSize = true;
            this.privateAccountRadioButton.Location = new System.Drawing.Point(26, 60);
            this.privateAccountRadioButton.Name = "privateAccountRadioButton";
            this.privateAccountRadioButton.Size = new System.Drawing.Size(50, 17);
            this.privateAccountRadioButton.TabIndex = 9;
            this.privateAccountRadioButton.TabStop = true;
            this.privateAccountRadioButton.Text = "פרטי";
            this.privateAccountRadioButton.UseVisualStyleBackColor = true;
            this.privateAccountRadioButton.CheckedChanged += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // bussinesAccountRadioButton
            // 
            this.bussinesAccountRadioButton.AutoSize = true;
            this.bussinesAccountRadioButton.Location = new System.Drawing.Point(25, 37);
            this.bussinesAccountRadioButton.Name = "bussinesAccountRadioButton";
            this.bussinesAccountRadioButton.Size = new System.Drawing.Size(51, 17);
            this.bussinesAccountRadioButton.TabIndex = 8;
            this.bussinesAccountRadioButton.TabStop = true;
            this.bussinesAccountRadioButton.Text = "עסקי";
            this.bussinesAccountRadioButton.UseVisualStyleBackColor = true;
            this.bussinesAccountRadioButton.CheckedChanged += new System.EventHandler(this.bussinesAccountRadioButton_CheckedChanged);
            // 
            // selectAccountTypeLabel
            // 
            this.selectAccountTypeLabel.AutoSize = true;
            this.selectAccountTypeLabel.Location = new System.Drawing.Point(23, 17);
            this.selectAccountTypeLabel.Name = "selectAccountTypeLabel";
            this.selectAccountTypeLabel.Size = new System.Drawing.Size(84, 13);
            this.selectAccountTypeLabel.TabIndex = 27;
            this.selectAccountTypeLabel.Text = "בחר סוג חשבון";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(140, 9);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(177, 13);
            this.errorMessageLabel.TabIndex = 35;
            this.errorMessageLabel.Text = "==> תקן את השדות המסומנים <==";
            this.errorMessageLabel.Visible = false;
            // 
            // allowedLabel
            // 
            this.allowedLabel.AutoSize = true;
            this.allowedLabel.Location = new System.Drawing.Point(353, 279);
            this.allowedLabel.Name = "allowedLabel";
            this.allowedLabel.Size = new System.Drawing.Size(75, 13);
            this.allowedLabel.TabIndex = 36;
            this.allowedLabel.Text = "מורשי חתימה";
            this.allowedLabel.Visible = false;
            // 
            // allowedTextBox
            // 
            this.allowedTextBox.Location = new System.Drawing.Point(26, 277);
            this.allowedTextBox.Name = "allowedTextBox";
            this.allowedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allowedTextBox.Size = new System.Drawing.Size(304, 20);
            this.allowedTextBox.TabIndex = 11;
            this.allowedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.allowedTextBox.Visible = false;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(355, 86);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AdressLabel.Size = new System.Drawing.Size(43, 13);
            this.AdressLabel.TabIndex = 38;
            this.AdressLabel.Text = "כתובת:";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(130, 86);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AdressTextBox.Size = new System.Drawing.Size(200, 20);
            this.AdressTextBox.TabIndex = 2;
            this.AdressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(517, 320);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.allowedTextBox);
            this.Controls.Add(this.allowedLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.selectAccountTypeLabel);
            this.Controls.Add(this.bussinesAccountRadioButton);
            this.Controls.Add(this.privateAccountRadioButton);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.creditNumberLabel);
            this.Controls.Add(this.creditNumberTextBox);
            this.Controls.Add(this.branchIdComboBox);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.accountStatusLabel);
            this.Controls.Add(this.accountStatusComboBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.branchIdLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "AddAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "חלון הוספת חשבון";
            this.Load += new System.EventHandler(this.AddAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox accountStatusComboBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.ComboBox branchIdComboBox;
        private System.Windows.Forms.TextBox creditNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.RadioButton privateAccountRadioButton;
        private System.Windows.Forms.RadioButton bussinesAccountRadioButton;
        private System.Windows.Forms.Label creditNumberLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label selectAccountTypeLabel;
        private System.Windows.Forms.Label accountStatusLabel;
        private System.Windows.Forms.Label branchIdLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label allowedLabel;
        private System.Windows.Forms.TextBox allowedTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox AdressTextBox;
    }
}