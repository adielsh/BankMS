namespace PLForms
{
    partial class UpdateTransForm
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
            this.transListToUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateAllTransButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transListToUpdateComboBox
            // 
            this.transListToUpdateComboBox.FormattingEnabled = true;
            this.transListToUpdateComboBox.Location = new System.Drawing.Point(107, 48);
            this.transListToUpdateComboBox.Name = "transListToUpdateComboBox";
            this.transListToUpdateComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transListToUpdateComboBox.Size = new System.Drawing.Size(358, 21);
            this.transListToUpdateComboBox.TabIndex = 0;
            this.transListToUpdateComboBox.SelectedIndexChanged += new System.EventHandler(this.transListToUpdateComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "בחר פעולה";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 46);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "סע !";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateAllTransButton
            // 
            this.UpdateAllTransButton.Location = new System.Drawing.Point(208, 84);
            this.UpdateAllTransButton.Name = "UpdateAllTransButton";
            this.UpdateAllTransButton.Size = new System.Drawing.Size(133, 23);
            this.UpdateAllTransButton.TabIndex = 3;
            this.UpdateAllTransButton.Text = "עשה זאת לכולם";
            this.UpdateAllTransButton.UseVisualStyleBackColor = true;
            this.UpdateAllTransButton.Click += new System.EventHandler(this.UpdateAllTransButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ביצוע פעולות שניתנות לביצוע";
            // 
            // UpdateTransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 115);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateAllTransButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transListToUpdateComboBox);
            this.Name = "UpdateTransForm";
            this.Text = "TransUpdateForm";
            this.Load += new System.EventHandler(this.TransUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox transListToUpdateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button UpdateAllTransButton;
        private System.Windows.Forms.Label label2;
    }
}