namespace PLForms
{
    partial class RemoveTransactionForm
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
            System.Windows.Forms.Label idLabel;
            this.transIdComboBox = new System.Windows.Forms.ComboBox();
            this.removeTransButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(354, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(63, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "בחר פעולה";
            // 
            // transIdComboBox
            // 
            this.transIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transIdComboBox.FormattingEnabled = true;
            this.transIdComboBox.Location = new System.Drawing.Point(131, 34);
            this.transIdComboBox.Name = "transIdComboBox";
            this.transIdComboBox.Size = new System.Drawing.Size(217, 21);
            this.transIdComboBox.TabIndex = 2;
            this.transIdComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // removeTransButton
            // 
            this.removeTransButton.Location = new System.Drawing.Point(12, 32);
            this.removeTransButton.Name = "removeTransButton";
            this.removeTransButton.Size = new System.Drawing.Size(113, 23);
            this.removeTransButton.TabIndex = 3;
            this.removeTransButton.Text = "מחק פעולה";
            this.removeTransButton.UseVisualStyleBackColor = true;
            this.removeTransButton.Click += new System.EventHandler(this.removeTransButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ביטול פעולה שעוד לא התבצעה";
            // 
            // RemoveTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 76);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeTransButton);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.transIdComboBox);
            this.Name = "RemoveTransactionForm";
            this.Text = "RemoveTransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox transIdComboBox;
        private System.Windows.Forms.Button removeTransButton;
        private System.Windows.Forms.Label label1;

    }
}