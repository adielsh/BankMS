namespace PLForms
{
    partial class AddTransactionForm
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
            this.sumLabel = new System.Windows.Forms.Label();
            this.transTypeLabel = new System.Windows.Forms.Label();
            this.fromAccountIdLabel = new System.Windows.Forms.Label();
            this.toAccountIdLabel = new System.Windows.Forms.Label();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.transTypeComboBox = new System.Windows.Forms.ComboBox();
            this.toAccountIdComboBox = new System.Windows.Forms.ComboBox();
            this.fromAccountIdComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(294, 125);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sumLabel.Size = new System.Drawing.Size(72, 13);
            this.sumLabel.TabIndex = 22;
            this.sumLabel.Text = "סכום פעולה:";
            // 
            // transTypeLabel
            // 
            this.transTypeLabel.AutoSize = true;
            this.transTypeLabel.Location = new System.Drawing.Point(294, 34);
            this.transTypeLabel.Name = "transTypeLabel";
            this.transTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.transTypeLabel.TabIndex = 26;
            this.transTypeLabel.Text = "סוג פעולה:";
            // 
            // fromAccountIdLabel
            // 
            this.fromAccountIdLabel.AutoSize = true;
            this.fromAccountIdLabel.Location = new System.Drawing.Point(296, 61);
            this.fromAccountIdLabel.Name = "fromAccountIdLabel";
            this.fromAccountIdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromAccountIdLabel.Size = new System.Drawing.Size(80, 13);
            this.fromAccountIdLabel.TabIndex = 18;
            this.fromAccountIdLabel.Text = "חשבון שנחסר:";
            this.fromAccountIdLabel.Click += new System.EventHandler(this.fromAccountIdLabel_Click);
            // 
            // toAccountIdLabel
            // 
            this.toAccountIdLabel.AutoSize = true;
            this.toAccountIdLabel.Location = new System.Drawing.Point(294, 94);
            this.toAccountIdLabel.Name = "toAccountIdLabel";
            this.toAccountIdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toAccountIdLabel.Size = new System.Drawing.Size(83, 13);
            this.toAccountIdLabel.TabIndex = 24;
            this.toAccountIdLabel.Text = "חשבון שמקבל:";
            this.toAccountIdLabel.Visible = false;
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTransactionButton.Location = new System.Drawing.Point(119, 182);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(130, 38);
            this.AddTransactionButton.TabIndex = 4;
            this.AddTransactionButton.Text = "הוספה";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(79, 122);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(200, 20);
            this.sumTextBox.TabIndex = 3;
            // 
            // transTypeComboBox
            // 
            this.transTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transTypeComboBox.FormattingEnabled = true;
            this.transTypeComboBox.Location = new System.Drawing.Point(79, 31);
            this.transTypeComboBox.Name = "transTypeComboBox";
            this.transTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.transTypeComboBox.TabIndex = 0;
            this.transTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.transTypeComboBox_SelectedIndexChanged);
            // 
            // toAccountIdComboBox
            // 
            this.toAccountIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toAccountIdComboBox.FormattingEnabled = true;
            this.toAccountIdComboBox.Location = new System.Drawing.Point(79, 91);
            this.toAccountIdComboBox.Name = "toAccountIdComboBox";
            this.toAccountIdComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toAccountIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.toAccountIdComboBox.TabIndex = 2;
            this.toAccountIdComboBox.Visible = false;
            this.toAccountIdComboBox.SelectedIndexChanged += new System.EventHandler(this.toAccountIdComboBox_SelectedIndexChanged);
            // 
            // fromAccountIdComboBox
            // 
            this.fromAccountIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromAccountIdComboBox.FormattingEnabled = true;
            this.fromAccountIdComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fromAccountIdComboBox.Location = new System.Drawing.Point(79, 58);
            this.fromAccountIdComboBox.Name = "fromAccountIdComboBox";
            this.fromAccountIdComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromAccountIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.fromAccountIdComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(78, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "שים לב! חשבונות חסומים לא מופיעים";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(92, 9);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(177, 13);
            this.errorMessageLabel.TabIndex = 34;
            this.errorMessageLabel.Text = "==> תקן את השדות המסומנים <==";
            this.errorMessageLabel.Visible = false;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 232);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromAccountIdComboBox);
            this.Controls.Add(this.toAccountIdComboBox);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.fromAccountIdLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.toAccountIdLabel);
            this.Controls.Add(this.transTypeLabel);
            this.Controls.Add(this.transTypeComboBox);
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.ComboBox transTypeComboBox;
        private System.Windows.Forms.ComboBox toAccountIdComboBox;
        private System.Windows.Forms.ComboBox fromAccountIdComboBox;
        private System.Windows.Forms.Label fromAccountIdLabel;
        private System.Windows.Forms.Label toAccountIdLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label transTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}