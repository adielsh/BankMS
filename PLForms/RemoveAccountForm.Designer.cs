namespace PLForms
{
    partial class RemoveAccountForm
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
            System.Windows.Forms.Label idLabel1;
            this.removeAccountButton = new System.Windows.Forms.Button();
            this.accountIdComboBox = new System.Windows.Forms.ComboBox();
            idLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(150, 28);
            idLabel1.Name = "idLabel1";
            idLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            idLabel1.Size = new System.Drawing.Size(86, 13);
            idLabel1.TabIndex = 5;
            idLabel1.Text = "חשבון למחיקה:";
            // 
            // removeAccountButton
            // 
            this.removeAccountButton.Location = new System.Drawing.Point(81, 83);
            this.removeAccountButton.Name = "removeAccountButton";
            this.removeAccountButton.Size = new System.Drawing.Size(96, 23);
            this.removeAccountButton.TabIndex = 4;
            this.removeAccountButton.Text = "אשר מחיקה";
            this.removeAccountButton.UseVisualStyleBackColor = true;
            this.removeAccountButton.Click += new System.EventHandler(this.removeAccountButton_Click);
            // 
            // accountIdComboBox
            // 
            this.accountIdComboBox.FormattingEnabled = true;
            this.accountIdComboBox.Items.AddRange(new object[] {
            "בחר ערך"});
            this.accountIdComboBox.Location = new System.Drawing.Point(12, 25);
            this.accountIdComboBox.Name = "accountIdComboBox";
            this.accountIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountIdComboBox.TabIndex = 6;
            // 
            // RemoveAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 144);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.accountIdComboBox);
            this.Controls.Add(this.removeAccountButton);
            this.Name = "RemoveAccountForm";
            this.Text = "מחיקת חשבון";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeAccountButton;
        private System.Windows.Forms.ComboBox accountIdComboBox;
    }
}