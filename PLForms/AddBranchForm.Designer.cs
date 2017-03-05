namespace PLForms
{
    partial class AddBranchForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.branchTypeLabel = new System.Windows.Forms.Label();
            this.AddBranchButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.branchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(182, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(53, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "שם סניף:";
            // 
            // branchTypeLabel
            // 
            this.branchTypeLabel.AutoSize = true;
            this.branchTypeLabel.Location = new System.Drawing.Point(180, 26);
            this.branchTypeLabel.Name = "branchTypeLabel";
            this.branchTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchTypeLabel.Size = new System.Drawing.Size(55, 13);
            this.branchTypeLabel.TabIndex = 8;
            this.branchTypeLabel.Text = "סוג סניף:";
            // 
            // AddBranchButton
            // 
            this.AddBranchButton.Location = new System.Drawing.Point(56, 128);
            this.AddBranchButton.Name = "AddBranchButton";
            this.AddBranchButton.Size = new System.Drawing.Size(120, 27);
            this.AddBranchButton.TabIndex = 3;
            this.AddBranchButton.Text = "הוספה";
            this.AddBranchButton.UseVisualStyleBackColor = true;
            this.AddBranchButton.Click += new System.EventHandler(this.AddBranchButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(53, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // branchTypeComboBox
            // 
            this.branchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchTypeComboBox.FormattingEnabled = true;
            this.branchTypeComboBox.Location = new System.Drawing.Point(53, 23);
            this.branchTypeComboBox.Name = "branchTypeComboBox";
            this.branchTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.branchTypeComboBox.TabIndex = 0;
            this.branchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.branchTypeComboBox_SelectedIndexChanged);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(182, 89);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AdressLabel.Size = new System.Drawing.Size(43, 13);
            this.AdressLabel.TabIndex = 10;
            this.AdressLabel.Text = "כתובת:";
            this.AdressLabel.Click += new System.EventHandler(this.AdressLabel_Click);
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(53, 86);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(123, 20);
            this.AdressTextBox.TabIndex = 2;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(34, 7);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(177, 13);
            this.errorMessageLabel.TabIndex = 36;
            this.errorMessageLabel.Text = "==> תקן את השדות המסומנים <==";
            this.errorMessageLabel.Visible = false;
            // 
            // AddBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 167);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.branchTypeLabel);
            this.Controls.Add(this.branchTypeComboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.AddBranchButton);
            this.Name = "AddBranchForm";
            this.Text = "חלון הוספת סניף";
            this.Load += new System.EventHandler(this.AddBranchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBranchButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox branchTypeComboBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label branchTypeLabel;
        private System.Windows.Forms.Label errorMessageLabel;

    }
}