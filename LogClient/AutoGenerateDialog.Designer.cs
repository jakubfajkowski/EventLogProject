﻿namespace EventLogProject {
    partial class AutoGenerateDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.usedLogTypesCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timeIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfLogRecordsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLogRecordsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Interval (ms):";
            // 
            // usedLogTypesCheckListBox
            // 
            this.usedLogTypesCheckListBox.FormattingEnabled = true;
            this.usedLogTypesCheckListBox.Location = new System.Drawing.Point(13, 81);
            this.usedLogTypesCheckListBox.Name = "usedLogTypesCheckListBox";
            this.usedLogTypesCheckListBox.Size = new System.Drawing.Size(259, 124);
            this.usedLogTypesCheckListBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(112, 226);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Log Records:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 226);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(94, 23);
            this.progressBar.TabIndex = 7;
            // 
            // timeIntervalNumericUpDown
            // 
            this.timeIntervalNumericUpDown.Location = new System.Drawing.Point(208, 12);
            this.timeIntervalNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeIntervalNumericUpDown.Name = "timeIntervalNumericUpDown";
            this.timeIntervalNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.timeIntervalNumericUpDown.TabIndex = 8;
            this.timeIntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfLogRecordsNumericUpDown
            // 
            this.numberOfLogRecordsNumericUpDown.Location = new System.Drawing.Point(208, 47);
            this.numberOfLogRecordsNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfLogRecordsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfLogRecordsNumericUpDown.Name = "numberOfLogRecordsNumericUpDown";
            this.numberOfLogRecordsNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.numberOfLogRecordsNumericUpDown.TabIndex = 9;
            this.numberOfLogRecordsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AutoGenerateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numberOfLogRecordsNumericUpDown);
            this.Controls.Add(this.timeIntervalNumericUpDown);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.usedLogTypesCheckListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AutoGenerateDialog";
            this.Text = "Auto Generate";
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLogRecordsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox usedLogTypesCheckListBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown timeIntervalNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberOfLogRecordsNumericUpDown;
    }
}