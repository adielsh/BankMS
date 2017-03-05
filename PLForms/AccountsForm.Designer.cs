namespace PLForms
{
    partial class AccountsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddAccountFormButton = new System.Windows.Forms.Button();
            this.RemoveAccountFormButton = new System.Windows.Forms.Button();
            this.UpdateAccountFormButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".Vilna", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "מה תרצה לבצע?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddAccountFormButton
            // 
            this.AddAccountFormButton.Location = new System.Drawing.Point(231, 63);
            this.AddAccountFormButton.Name = "AddAccountFormButton";
            this.AddAccountFormButton.Size = new System.Drawing.Size(85, 57);
            this.AddAccountFormButton.TabIndex = 1;
            this.AddAccountFormButton.Text = "הוספת חשבון";
            this.AddAccountFormButton.UseVisualStyleBackColor = true;
            this.AddAccountFormButton.Click += new System.EventHandler(this.AddAccountFormButton_Click);
            // 
            // RemoveAccountFormButton
            // 
            this.RemoveAccountFormButton.Location = new System.Drawing.Point(140, 64);
            this.RemoveAccountFormButton.Name = "RemoveAccountFormButton";
            this.RemoveAccountFormButton.Size = new System.Drawing.Size(85, 57);
            this.RemoveAccountFormButton.TabIndex = 2;
            this.RemoveAccountFormButton.Text = "מחיקת חשבון";
            this.RemoveAccountFormButton.UseVisualStyleBackColor = true;
            this.RemoveAccountFormButton.Click += new System.EventHandler(this.RemoveAccountFormButton_Click);
            // 
            // UpdateAccountFormButton
            // 
            this.UpdateAccountFormButton.Location = new System.Drawing.Point(49, 64);
            this.UpdateAccountFormButton.Name = "UpdateAccountFormButton";
            this.UpdateAccountFormButton.Size = new System.Drawing.Size(85, 57);
            this.UpdateAccountFormButton.TabIndex = 3;
            this.UpdateAccountFormButton.Text = "עדכון חשבון";
            this.UpdateAccountFormButton.UseVisualStyleBackColor = true;
            this.UpdateAccountFormButton.Click += new System.EventHandler(this.UpdateAccountFormButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "שאילתות על חשבונות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateAccountFormButton);
            this.Controls.Add(this.RemoveAccountFormButton);
            this.Controls.Add(this.AddAccountFormButton);
            this.Controls.Add(this.label1);
            this.Name = "AccountsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "חשבונות";
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAccountFormButton;
        private System.Windows.Forms.Button RemoveAccountFormButton;
        private System.Windows.Forms.Button UpdateAccountFormButton;
        private System.Windows.Forms.Button button1;
    }
}