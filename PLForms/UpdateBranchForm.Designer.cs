namespace PLForms
{
    partial class UpdateBranchForm
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
            System.Windows.Forms.Label branchTypeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            this.branchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.selectIdComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            branchTypeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // branchTypeLabel
            // 
            branchTypeLabel.AutoSize = true;
            branchTypeLabel.Location = new System.Drawing.Point(212, 95);
            branchTypeLabel.Name = "branchTypeLabel";
            branchTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            branchTypeLabel.Size = new System.Drawing.Size(55, 13);
            branchTypeLabel.TabIndex = 1;
            branchTypeLabel.Text = "סוג סניף:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(183, 31);
            idLabel.Name = "idLabel";
            idLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            idLabel.Size = new System.Drawing.Size(64, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "מספר סניף:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(212, 125);
            nameLabel.Name = "nameLabel";
            nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameLabel.Size = new System.Drawing.Size(53, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "שם סניף:";
            // 
            // branchTypeComboBox
            // 
            this.branchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchTypeComboBox.FormattingEnabled = true;
            this.branchTypeComboBox.Location = new System.Drawing.Point(29, 95);
            this.branchTypeComboBox.Name = "branchTypeComboBox";
            this.branchTypeComboBox.Size = new System.Drawing.Size(168, 21);
            this.branchTypeComboBox.TabIndex = 1;
            this.branchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.branchTypeComboBox_SelectedIndexChanged);
            // 
            // selectIdComboBox
            // 
            this.selectIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectIdComboBox.FormattingEnabled = true;
            this.selectIdComboBox.Location = new System.Drawing.Point(54, 28);
            this.selectIdComboBox.Name = "selectIdComboBox";
            this.selectIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectIdComboBox.TabIndex = 0;
            this.selectIdComboBox.SelectedIndexChanged += new System.EventHandler(this.selectIdComboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(29, 122);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(98, 208);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "עדכן";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 152);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "כתובת:";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(29, 152);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(168, 20);
            this.AdressTextBox.TabIndex = 3;
            // 
            // UpdateBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(branchTypeLabel);
            this.Controls.Add(this.branchTypeComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.selectIdComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "UpdateBranchForm";
            this.Text = "UpdateBranchForm";
            this.Load += new System.EventHandler(this.UpdateBranchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox branchTypeComboBox;
        private System.Windows.Forms.ComboBox selectIdComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdressTextBox;
    }
}