namespace PLForms
{
    partial class QueriesForm
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
            this.byAccountQueriesButton = new System.Windows.Forms.Button();
            this.byTransQueriesButton = new System.Windows.Forms.Button();
            this.byBranchQueriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // byAccountQueriesButton
            // 
            this.byAccountQueriesButton.Location = new System.Drawing.Point(224, 28);
            this.byAccountQueriesButton.Name = "byAccountQueriesButton";
            this.byAccountQueriesButton.Size = new System.Drawing.Size(103, 42);
            this.byAccountQueriesButton.TabIndex = 0;
            this.byAccountQueriesButton.Text = "שאילתות לפי חשבון";
            this.byAccountQueriesButton.UseVisualStyleBackColor = true;
            this.byAccountQueriesButton.Click += new System.EventHandler(this.byAccountQueriesButton_Click);
            // 
            // byTransQueriesButton
            // 
            this.byTransQueriesButton.Location = new System.Drawing.Point(13, 28);
            this.byTransQueriesButton.Name = "byTransQueriesButton";
            this.byTransQueriesButton.Size = new System.Drawing.Size(107, 43);
            this.byTransQueriesButton.TabIndex = 1;
            this.byTransQueriesButton.Text = "שאילתות לפי פעולה";
            this.byTransQueriesButton.UseVisualStyleBackColor = true;
            this.byTransQueriesButton.Click += new System.EventHandler(this.byTransQueriesButton_Click);
            // 
            // byBranchQueriesButton
            // 
            this.byBranchQueriesButton.Location = new System.Drawing.Point(126, 28);
            this.byBranchQueriesButton.Name = "byBranchQueriesButton";
            this.byBranchQueriesButton.Size = new System.Drawing.Size(95, 41);
            this.byBranchQueriesButton.TabIndex = 2;
            this.byBranchQueriesButton.Text = "שאילתות לפי סניף";
            this.byBranchQueriesButton.UseVisualStyleBackColor = true;
            this.byBranchQueriesButton.Click += new System.EventHandler(this.byBranchQueriesButton_Click);
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 91);
            this.Controls.Add(this.byBranchQueriesButton);
            this.Controls.Add(this.byTransQueriesButton);
            this.Controls.Add(this.byAccountQueriesButton);
            this.Name = "QueriesForm";
            this.Text = "QueriesForm";
            this.Load += new System.EventHandler(this.QueriesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button byAccountQueriesButton;
        private System.Windows.Forms.Button byTransQueriesButton;
        private System.Windows.Forms.Button byBranchQueriesButton;
    }
}