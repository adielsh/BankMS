namespace PLForms
{
    partial class MainForm
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
            this.AccountsFormButton = new System.Windows.Forms.Button();
            this.TransactionFormButton = new System.Windows.Forms.Button();
            this.BranchesFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.queriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountsFormButton
            // 
            this.AccountsFormButton.Location = new System.Drawing.Point(295, 67);
            this.AccountsFormButton.Name = "AccountsFormButton";
            this.AccountsFormButton.Size = new System.Drawing.Size(103, 44);
            this.AccountsFormButton.TabIndex = 1;
            this.AccountsFormButton.Text = "חשבונות";
            this.AccountsFormButton.UseVisualStyleBackColor = true;
            this.AccountsFormButton.Click += new System.EventHandler(this.AccountsFormButton_Click);
            // 
            // TransactionFormButton
            // 
            this.TransactionFormButton.Location = new System.Drawing.Point(185, 66);
            this.TransactionFormButton.Name = "TransactionFormButton";
            this.TransactionFormButton.Size = new System.Drawing.Size(104, 45);
            this.TransactionFormButton.TabIndex = 2;
            this.TransactionFormButton.Text = "פעולות בנקאיות";
            this.TransactionFormButton.UseVisualStyleBackColor = true;
            this.TransactionFormButton.Click += new System.EventHandler(this.TransactionFormButton_Click);
            // 
            // BranchesFormButton
            // 
            this.BranchesFormButton.Location = new System.Drawing.Point(404, 67);
            this.BranchesFormButton.Name = "BranchesFormButton";
            this.BranchesFormButton.Size = new System.Drawing.Size(104, 44);
            this.BranchesFormButton.TabIndex = 0;
            this.BranchesFormButton.Text = "סניפים";
            this.BranchesFormButton.UseVisualStyleBackColor = true;
            this.BranchesFormButton.Click += new System.EventHandler(this.BranchesFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font(".Vilna", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "עם מה תרצה להתעסק היום?";
            // 
            // queriesButton
            // 
            this.queriesButton.Location = new System.Drawing.Point(77, 66);
            this.queriesButton.Name = "queriesButton";
            this.queriesButton.Size = new System.Drawing.Size(102, 45);
            this.queriesButton.TabIndex = 3;
            this.queriesButton.Text = "שאילתות";
            this.queriesButton.UseVisualStyleBackColor = true;
            this.queriesButton.Click += new System.EventHandler(this.queriesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::PLForms.Properties.Resources._3742462452;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(572, 308);
            this.Controls.Add(this.queriesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BranchesFormButton);
            this.Controls.Add(this.TransactionFormButton);
            this.Controls.Add(this.AccountsFormButton);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "MainForm";
            this.Text = "מערכת בנק ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccountsFormButton;
        private System.Windows.Forms.Button TransactionFormButton;
        private System.Windows.Forms.Button BranchesFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button queriesButton;
    }
}

