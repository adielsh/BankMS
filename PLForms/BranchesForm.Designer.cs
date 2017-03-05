namespace PLForms
{
    partial class BranchesForm
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
            this.UpdateBranchFormButton = new System.Windows.Forms.Button();
            this.RemoveBranchFormButton = new System.Windows.Forms.Button();
            this.AddBranchFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateBranchFormButton
            // 
            this.UpdateBranchFormButton.Location = new System.Drawing.Point(43, 85);
            this.UpdateBranchFormButton.Name = "UpdateBranchFormButton";
            this.UpdateBranchFormButton.Size = new System.Drawing.Size(85, 57);
            this.UpdateBranchFormButton.TabIndex = 2;
            this.UpdateBranchFormButton.Text = "עדכון סניף";
            this.UpdateBranchFormButton.UseVisualStyleBackColor = true;
            this.UpdateBranchFormButton.Click += new System.EventHandler(this.UpdateBranchFormButton_Click);
            // 
            // RemoveBranchFormButton
            // 
            this.RemoveBranchFormButton.Location = new System.Drawing.Point(146, 85);
            this.RemoveBranchFormButton.Name = "RemoveBranchFormButton";
            this.RemoveBranchFormButton.Size = new System.Drawing.Size(85, 57);
            this.RemoveBranchFormButton.TabIndex = 1;
            this.RemoveBranchFormButton.Text = "מחיקת סניף";
            this.RemoveBranchFormButton.UseVisualStyleBackColor = true;
            this.RemoveBranchFormButton.Click += new System.EventHandler(this.RemoveBranchFormButton_Click);
            // 
            // AddBranchFormButton
            // 
            this.AddBranchFormButton.Location = new System.Drawing.Point(254, 85);
            this.AddBranchFormButton.Name = "AddBranchFormButton";
            this.AddBranchFormButton.Size = new System.Drawing.Size(85, 57);
            this.AddBranchFormButton.TabIndex = 0;
            this.AddBranchFormButton.Text = "הוספת סניף";
            this.AddBranchFormButton.UseVisualStyleBackColor = true;
            this.AddBranchFormButton.Click += new System.EventHandler(this.AddBranchFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".Vilna", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "מה תרצה לבצע?";
            // 
            // BranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 193);
            this.Controls.Add(this.UpdateBranchFormButton);
            this.Controls.Add(this.RemoveBranchFormButton);
            this.Controls.Add(this.AddBranchFormButton);
            this.Controls.Add(this.label1);
            this.Name = "BranchesForm";
            this.Text = "BranchesForm";
            this.Load += new System.EventHandler(this.BranchesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBranchFormButton;
        private System.Windows.Forms.Button RemoveBranchFormButton;
        private System.Windows.Forms.Button AddBranchFormButton;
        private System.Windows.Forms.Label label1;

    }
}