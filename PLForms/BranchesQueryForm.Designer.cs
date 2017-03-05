namespace PLForms
{
    partial class BranchesQueryForm
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
            this.showByTypeButton = new System.Windows.Forms.Button();
            this.branchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.brachQueriesGridView = new System.Windows.Forms.DataGridView();
            this.showAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brachQueriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showByTypeButton
            // 
            this.showByTypeButton.Location = new System.Drawing.Point(87, 52);
            this.showByTypeButton.Name = "showByTypeButton";
            this.showByTypeButton.Size = new System.Drawing.Size(75, 21);
            this.showByTypeButton.TabIndex = 0;
            this.showByTypeButton.Text = "הצג";
            this.showByTypeButton.UseVisualStyleBackColor = true;
            this.showByTypeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchTypeComboBox
            // 
            this.branchTypeComboBox.FormattingEnabled = true;
            this.branchTypeComboBox.Location = new System.Drawing.Point(171, 53);
            this.branchTypeComboBox.Name = "branchTypeComboBox";
            this.branchTypeComboBox.Size = new System.Drawing.Size(282, 21);
            this.branchTypeComboBox.TabIndex = 1;
            // 
            // brachQueriesGridView
            // 
            this.brachQueriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brachQueriesGridView.Location = new System.Drawing.Point(87, 100);
            this.brachQueriesGridView.Name = "brachQueriesGridView";
            this.brachQueriesGridView.Size = new System.Drawing.Size(426, 275);
            this.brachQueriesGridView.TabIndex = 2;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(87, 12);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 34);
            this.showAllButton.TabIndex = 3;
            this.showAllButton.Text = "הצג את כולם";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "לפי סוג סניף";
            // 
            // BranchesQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.brachQueriesGridView);
            this.Controls.Add(this.branchTypeComboBox);
            this.Controls.Add(this.showByTypeButton);
            this.Name = "BranchesQueryForm";
            this.Text = "BranchesQueriesForm";
            this.Load += new System.EventHandler(this.BranchesQueriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brachQueriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showByTypeButton;
        private System.Windows.Forms.ComboBox branchTypeComboBox;
        private System.Windows.Forms.DataGridView brachQueriesGridView;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label label1;
    }
}