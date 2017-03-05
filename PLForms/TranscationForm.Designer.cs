namespace PLForms
{
    partial class TranscationForm
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
            this.UpdateTransFormButton = new System.Windows.Forms.Button();
            this.RemoveTransFormButton = new System.Windows.Forms.Button();
            this.AddTransFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateTransFormButton
            // 
            this.UpdateTransFormButton.Location = new System.Drawing.Point(24, 121);
            this.UpdateTransFormButton.Name = "UpdateTransFormButton";
            this.UpdateTransFormButton.Size = new System.Drawing.Size(85, 57);
            this.UpdateTransFormButton.TabIndex = 2;
            this.UpdateTransFormButton.Text = "עדכון פעולה";
            this.UpdateTransFormButton.UseVisualStyleBackColor = true;
            this.UpdateTransFormButton.Click += new System.EventHandler(this.UpdateTransFormButton_Click);
            // 
            // RemoveTransFormButton
            // 
            this.RemoveTransFormButton.Location = new System.Drawing.Point(127, 121);
            this.RemoveTransFormButton.Name = "RemoveTransFormButton";
            this.RemoveTransFormButton.Size = new System.Drawing.Size(85, 57);
            this.RemoveTransFormButton.TabIndex = 1;
            this.RemoveTransFormButton.Text = "מחיקת פעולה";
            this.RemoveTransFormButton.UseVisualStyleBackColor = true;
            this.RemoveTransFormButton.Click += new System.EventHandler(this.RemoveTransFormButton_Click);
            // 
            // AddTransFormButton
            // 
            this.AddTransFormButton.Location = new System.Drawing.Point(235, 121);
            this.AddTransFormButton.Name = "AddTransFormButton";
            this.AddTransFormButton.Size = new System.Drawing.Size(85, 57);
            this.AddTransFormButton.TabIndex = 0;
            this.AddTransFormButton.Text = "הוספת פעולה";
            this.AddTransFormButton.UseVisualStyleBackColor = true;
            this.AddTransFormButton.Click += new System.EventHandler(this.AddTransFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".Vilna", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "מה תרצה לבצע?";
            // 
            // TranscationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 244);
            this.Controls.Add(this.UpdateTransFormButton);
            this.Controls.Add(this.RemoveTransFormButton);
            this.Controls.Add(this.AddTransFormButton);
            this.Controls.Add(this.label1);
            this.Name = "TranscationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "חלון פעולות";
            this.Load += new System.EventHandler(this.TranscationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateTransFormButton;
        private System.Windows.Forms.Button RemoveTransFormButton;
        private System.Windows.Forms.Button AddTransFormButton;
        private System.Windows.Forms.Label label1;
    }
}