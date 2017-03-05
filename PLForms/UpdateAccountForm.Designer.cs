namespace PLForms
{
    partial class UpdateAccountForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.selectIdComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.selectAccountTypeLabel = new System.Windows.Forms.Label();
            this.bussinesAccountRadioButton = new System.Windows.Forms.RadioButton();
            this.privateAccountRadioButton = new System.Windows.Forms.RadioButton();
            this.allowedTextBox = new System.Windows.Forms.TextBox();
            this.allowedLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.creditNumberLabel = new System.Windows.Forms.Label();
            this.creditNumberTextBox = new System.Windows.Forms.TextBox();
            this.branchIdComboBox = new System.Windows.Forms.ComboBox();
            this.accountStatusLabel = new System.Windows.Forms.Label();
            this.accountStatusComboBox = new System.Windows.Forms.ComboBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.branchIdLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(380, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idLabel.Size = new System.Drawing.Size(107, 13);
            this.idLabel.TabIndex = 34;
            this.idLabel.Text = "בחר חשבון לעדכון:";
            // 
            // selectIdComboBox
            // 
            this.selectIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectIdComboBox.FormattingEnabled = true;
            this.selectIdComboBox.Location = new System.Drawing.Point(155, 12);
            this.selectIdComboBox.Name = "selectIdComboBox";
            this.selectIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.selectIdComboBox.TabIndex = 0;
            this.selectIdComboBox.SelectedIndexChanged += new System.EventHandler(this.selectIdComboBox_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(32, 188);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(93, 46);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "עדכן";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // selectAccountTypeLabel
            // 
            this.selectAccountTypeLabel.AutoSize = true;
            this.selectAccountTypeLabel.Location = new System.Drawing.Point(41, 78);
            this.selectAccountTypeLabel.Name = "selectAccountTypeLabel";
            this.selectAccountTypeLabel.Size = new System.Drawing.Size(84, 13);
            this.selectAccountTypeLabel.TabIndex = 42;
            this.selectAccountTypeLabel.Text = "בחר סוג חשבון";
            // 
            // bussinesAccountRadioButton
            // 
            this.bussinesAccountRadioButton.AutoSize = true;
            this.bussinesAccountRadioButton.Location = new System.Drawing.Point(43, 98);
            this.bussinesAccountRadioButton.Name = "bussinesAccountRadioButton";
            this.bussinesAccountRadioButton.Size = new System.Drawing.Size(51, 17);
            this.bussinesAccountRadioButton.TabIndex = 8;
            this.bussinesAccountRadioButton.TabStop = true;
            this.bussinesAccountRadioButton.Text = "עסקי";
            this.bussinesAccountRadioButton.UseVisualStyleBackColor = true;
            this.bussinesAccountRadioButton.CheckedChanged += new System.EventHandler(this.bussinesAccountRadioButton_CheckedChanged);
            // 
            // privateAccountRadioButton
            // 
            this.privateAccountRadioButton.AutoSize = true;
            this.privateAccountRadioButton.Location = new System.Drawing.Point(44, 121);
            this.privateAccountRadioButton.Name = "privateAccountRadioButton";
            this.privateAccountRadioButton.Size = new System.Drawing.Size(50, 17);
            this.privateAccountRadioButton.TabIndex = 9;
            this.privateAccountRadioButton.TabStop = true;
            this.privateAccountRadioButton.Text = "פרטי";
            this.privateAccountRadioButton.UseVisualStyleBackColor = true;
            this.privateAccountRadioButton.CheckedChanged += new System.EventHandler(this.privateAccountRadioButton_CheckedChanged);
            // 
            // allowedTextBox
            // 
            this.allowedTextBox.Location = new System.Drawing.Point(44, 328);
            this.allowedTextBox.Name = "allowedTextBox";
            this.allowedTextBox.Size = new System.Drawing.Size(311, 20);
            this.allowedTextBox.TabIndex = 14;
            this.allowedTextBox.Visible = false;
            // 
            // allowedLabel
            // 
            this.allowedLabel.AutoSize = true;
            this.allowedLabel.Location = new System.Drawing.Point(378, 330);
            this.allowedLabel.Name = "allowedLabel";
            this.allowedLabel.Size = new System.Drawing.Size(75, 13);
            this.allowedLabel.TabIndex = 60;
            this.allowedLabel.Text = "מורשי חתימה";
            this.allowedLabel.Visible = false;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(165, 49);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(177, 13);
            this.errorMessageLabel.TabIndex = 59;
            this.errorMessageLabel.Text = "==> תקן את השדות המסומנים <==";
            this.errorMessageLabel.Visible = false;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(375, 83);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.phoneNumberLabel.TabIndex = 57;
            this.phoneNumberLabel.Text = "מספר טלפון:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(155, 80);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(378, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(62, 13);
            this.nameLabel.TabIndex = 55;
            this.nameLabel.Text = "שם בעלים:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(155, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // creditNumberLabel
            // 
            this.creditNumberLabel.AutoSize = true;
            this.creditNumberLabel.Location = new System.Drawing.Point(375, 331);
            this.creditNumberLabel.Name = "creditNumberLabel";
            this.creditNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creditNumberLabel.Size = new System.Drawing.Size(139, 13);
            this.creditNumberLabel.TabIndex = 53;
            this.creditNumberLabel.Text = "מספר כרטיס אשראי פרטי:";
            // 
            // creditNumberTextBox
            // 
            this.creditNumberTextBox.Location = new System.Drawing.Point(155, 328);
            this.creditNumberTextBox.Name = "creditNumberTextBox";
            this.creditNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.creditNumberTextBox.TabIndex = 15;
            // 
            // branchIdComboBox
            // 
            this.branchIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchIdComboBox.FormattingEnabled = true;
            this.branchIdComboBox.Location = new System.Drawing.Point(155, 223);
            this.branchIdComboBox.Name = "branchIdComboBox";
            this.branchIdComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.branchIdComboBox.Sorted = true;
            this.branchIdComboBox.TabIndex = 6;
            // 
            // accountStatusLabel
            // 
            this.accountStatusLabel.AutoSize = true;
            this.accountStatusLabel.Location = new System.Drawing.Point(378, 167);
            this.accountStatusLabel.Name = "accountStatusLabel";
            this.accountStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountStatusLabel.Size = new System.Drawing.Size(79, 13);
            this.accountStatusLabel.TabIndex = 43;
            this.accountStatusLabel.Text = "סטטוס חשבון:";
            // 
            // accountStatusComboBox
            // 
            this.accountStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountStatusComboBox.FormattingEnabled = true;
            this.accountStatusComboBox.Location = new System.Drawing.Point(155, 164);
            this.accountStatusComboBox.Name = "accountStatusComboBox";
            this.accountStatusComboBox.Size = new System.Drawing.Size(200, 21);
            this.accountStatusComboBox.TabIndex = 4;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(378, 201);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.balanceLabel.Size = new System.Drawing.Size(40, 13);
            this.balanceLabel.TabIndex = 45;
            this.balanceLabel.Text = "יתירה:";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(155, 198);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.balanceTextBox.TabIndex = 5;
            // 
            // branchIdLabel
            // 
            this.branchIdLabel.AutoSize = true;
            this.branchIdLabel.Location = new System.Drawing.Point(378, 226);
            this.branchIdLabel.Name = "branchIdLabel";
            this.branchIdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchIdLabel.Size = new System.Drawing.Size(53, 13);
            this.branchIdLabel.TabIndex = 47;
            this.branchIdLabel.Text = "שם סניף:";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(375, 253);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creditLabel.Size = new System.Drawing.Size(82, 13);
            this.creditLabel.TabIndex = 48;
            this.creditLabel.Text = "מסגרת אשראי:";
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(155, 250);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(200, 20);
            this.creditTextBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(375, 296);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordLabel.Size = new System.Drawing.Size(79, 13);
            this.passwordLabel.TabIndex = 50;
            this.passwordLabel.Text = "בחירת סיסמא:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(155, 293);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(155, 134);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(200, 20);
            this.AdressTextBox.TabIndex = 3;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(381, 137);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AdressLabel.Size = new System.Drawing.Size(43, 13);
            this.AdressLabel.TabIndex = 62;
            this.AdressLabel.Text = "כתובת:";
            // 
            // UpdateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 360);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.allowedTextBox);
            this.Controls.Add(this.allowedLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.creditNumberLabel);
            this.Controls.Add(this.creditNumberTextBox);
            this.Controls.Add(this.branchIdComboBox);
            this.Controls.Add(this.accountStatusLabel);
            this.Controls.Add(this.accountStatusComboBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.branchIdLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.selectAccountTypeLabel);
            this.Controls.Add(this.bussinesAccountRadioButton);
            this.Controls.Add(this.privateAccountRadioButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.selectIdComboBox);
            this.Name = "UpdateAccountForm";
            this.Text = "עדכון חשבון";
            this.Load += new System.EventHandler(this.UpdateAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectIdComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label selectAccountTypeLabel;
        private System.Windows.Forms.RadioButton bussinesAccountRadioButton;
        private System.Windows.Forms.RadioButton privateAccountRadioButton;
        private System.Windows.Forms.TextBox allowedTextBox;
        private System.Windows.Forms.Label allowedLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label creditNumberLabel;
        private System.Windows.Forms.TextBox creditNumberTextBox;
        private System.Windows.Forms.ComboBox branchIdComboBox;
        private System.Windows.Forms.Label accountStatusLabel;
        private System.Windows.Forms.ComboBox accountStatusComboBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label branchIdLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label AdressLabel;

    }
}