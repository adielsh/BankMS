namespace PLForms
{
    partial class RemoveBranchForm
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
            System.Windows.Forms.Label branchIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBranchForm));
            this.branchIdComboBox = new System.Windows.Forms.ComboBox();
            this.removeAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            branchIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // branchIdLabel
            // 
            resources.ApplyResources(branchIdLabel, "branchIdLabel");
            branchIdLabel.Name = "branchIdLabel";
            branchIdLabel.Click += new System.EventHandler(this.branchIdLabel_Click);
            // 
            // branchIdComboBox
            // 
            resources.ApplyResources(this.branchIdComboBox, "branchIdComboBox");
            this.branchIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchIdComboBox.FormattingEnabled = true;
            this.branchIdComboBox.Name = "branchIdComboBox";
            this.branchIdComboBox.SelectedIndexChanged += new System.EventHandler(this.branchIdComboBox_SelectedIndexChanged);
            // 
            // removeAccountButton
            // 
            resources.ApplyResources(this.removeAccountButton, "removeAccountButton");
            this.removeAccountButton.Name = "removeAccountButton";
            this.removeAccountButton.UseVisualStyleBackColor = true;
            this.removeAccountButton.Click += new System.EventHandler(this.removeAccountButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RemoveBranchForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeAccountButton);
            this.Controls.Add(branchIdLabel);
            this.Controls.Add(this.branchIdComboBox);
            this.Name = "RemoveBranchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox branchIdComboBox;
        private System.Windows.Forms.Button removeAccountButton;
        private System.Windows.Forms.Label label1;
    }
}