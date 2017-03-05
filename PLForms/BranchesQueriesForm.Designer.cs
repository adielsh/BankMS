namespace PLForms
{
    partial class BranchesQueriesForm
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
            this.showByBranchTypeComboBox = new System.Windows.Forms.Button();
            this.branchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.brachQueriesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.brachQueriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showByBranchTypeComboBox
            // 
            this.showByBranchTypeComboBox.Location = new System.Drawing.Point(12, 79);
            this.showByBranchTypeComboBox.Name = "showByBranchTypeComboBox";
            this.showByBranchTypeComboBox.Size = new System.Drawing.Size(69, 49);
            this.showByBranchTypeComboBox.TabIndex = 0;
            this.showByBranchTypeComboBox.Text = "הצג";
            this.showByBranchTypeComboBox.UseVisualStyleBackColor = true;
            this.showByBranchTypeComboBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchTypeComboBox
            // 
            this.branchTypeComboBox.FormattingEnabled = true;
            this.branchTypeComboBox.Location = new System.Drawing.Point(105, 35);
            this.branchTypeComboBox.Name = "branchTypeComboBox";
            this.branchTypeComboBox.Size = new System.Drawing.Size(282, 21);
            this.branchTypeComboBox.TabIndex = 1;
            // 
            // brachQueriesGridView
            // 
            this.brachQueriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brachQueriesGridView.Location = new System.Drawing.Point(105, 79);
            this.brachQueriesGridView.Name = "brachQueriesGridView";
            this.brachQueriesGridView.Size = new System.Drawing.Size(282, 166);
            this.brachQueriesGridView.TabIndex = 2;
            // 
            // BranchesQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 308);
            this.Controls.Add(this.brachQueriesGridView);
            this.Controls.Add(this.branchTypeComboBox);
            this.Controls.Add(this.showByBranchTypeComboBox);
            this.Name = "BranchesQueriesForm";
            this.Text = "BranchesQueriesForm";
            this.Load += new System.EventHandler(this.BranchesQueriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brachQueriesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showByBranchTypeComboBox;
        private System.Windows.Forms.ComboBox branchTypeComboBox;
        private System.Windows.Forms.DataGridView brachQueriesGridView;
    }
}