namespace PLForms
{
    partial class TransQueryForm
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
            this.TransGridView = new System.Windows.Forms.DataGridView();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectAccountComboBox = new System.Windows.Forms.ComboBox();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showTransPerAccountNdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.betweenDatesButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TransGridView
            // 
            this.TransGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransGridView.Location = new System.Drawing.Point(48, 172);
            this.TransGridView.Name = "TransGridView";
            this.TransGridView.Size = new System.Drawing.Size(527, 183);
            this.TransGridView.TabIndex = 0;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(338, 29);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.fromDateTimePicker.TabIndex = 1;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(338, 64);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.toDateTimePicker.TabIndex = 2;
            // 
            // selectAccountComboBox
            // 
            this.selectAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAccountComboBox.FormattingEnabled = true;
            this.selectAccountComboBox.Location = new System.Drawing.Point(338, 94);
            this.selectAccountComboBox.Name = "selectAccountComboBox";
            this.selectAccountComboBox.Size = new System.Drawing.Size(202, 21);
            this.selectAccountComboBox.TabIndex = 3;
            this.selectAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.selectAccountComboBox_SelectedIndexChanged);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Location = new System.Drawing.Point(549, 35);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(47, 13);
            this.fromDateLabel.TabIndex = 4;
            this.fromDateLabel.Text = "מתאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "עד תאריך";
            // 
            // showTransPerAccountNdateButton
            // 
            this.showTransPerAccountNdateButton.Location = new System.Drawing.Point(202, 92);
            this.showTransPerAccountNdateButton.Name = "showTransPerAccountNdateButton";
            this.showTransPerAccountNdateButton.Size = new System.Drawing.Size(97, 23);
            this.showTransPerAccountNdateButton.TabIndex = 6;
            this.showTransPerAccountNdateButton.Text = "הצג";
            this.showTransPerAccountNdateButton.UseVisualStyleBackColor = true;
            this.showTransPerAccountNdateButton.Click += new System.EventHandler(this.showTransPerAccountNdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "לפי חשבון";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // betweenDatesButton
            // 
            this.betweenDatesButton.Location = new System.Drawing.Point(202, 35);
            this.betweenDatesButton.Name = "betweenDatesButton";
            this.betweenDatesButton.Size = new System.Drawing.Size(97, 23);
            this.betweenDatesButton.TabIndex = 8;
            this.betweenDatesButton.Text = "הצג";
            this.betweenDatesButton.UseVisualStyleBackColor = true;
            this.betweenDatesButton.Click += new System.EventHandler(this.betweenDatesButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(202, 143);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(97, 23);
            this.ShowAllButton.TabIndex = 9;
            this.ShowAllButton.Text = "הצג הכל";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 367);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.betweenDatesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showTransPerAccountNdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.selectAccountComboBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.TransGridView);
            this.Name = "TransQueryForm";
            this.Text = "שאילתות של פעולות";
            this.Load += new System.EventHandler(this.TransQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransGridView;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.ComboBox selectAccountComboBox;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showTransPerAccountNdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button betweenDatesButton;
        private System.Windows.Forms.Button ShowAllButton;
    }
}