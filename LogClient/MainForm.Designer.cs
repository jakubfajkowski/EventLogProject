namespace EventLogProject {
    partial class MainForm {
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
            this.logTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.randomizeFieldButton = new System.Windows.Forms.Button();
            this.fieldsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedFieldTextBox = new FilteredTextBox();
            this.randomizeAllFieldsButton = new System.Windows.Forms.Button();
            this.autoGenerateButton = new System.Windows.Forms.Button();
            this.clientIdTextBox = new FilteredTextBox();
            this.SuspendLayout();
            // 
            // logTypeComboBox
            // 
            this.logTypeComboBox.FormattingEnabled = true;
            this.logTypeComboBox.Items.AddRange(new object[] {
            "<Add new log type>"});
            this.logTypeComboBox.Location = new System.Drawing.Point(12, 25);
            this.logTypeComboBox.Name = "logTypeComboBox";
            this.logTypeComboBox.Size = new System.Drawing.Size(537, 21);
            this.logTypeComboBox.TabIndex = 0;
            this.logTypeComboBox.Text = "<Select Log Type>";
            this.logTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.logTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log type list:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(165, 92);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // randomizeFieldButton
            // 
            this.randomizeFieldButton.Location = new System.Drawing.Point(336, 92);
            this.randomizeFieldButton.Name = "randomizeFieldButton";
            this.randomizeFieldButton.Size = new System.Drawing.Size(93, 23);
            this.randomizeFieldButton.TabIndex = 4;
            this.randomizeFieldButton.Text = "Randomize Field";
            this.randomizeFieldButton.UseVisualStyleBackColor = true;
            this.randomizeFieldButton.Click += new System.EventHandler(this.randomizeFieldButton_Click);
            // 
            // fieldsComboBox
            // 
            this.fieldsComboBox.FormattingEnabled = true;
            this.fieldsComboBox.Location = new System.Drawing.Point(12, 65);
            this.fieldsComboBox.Name = "fieldsComboBox";
            this.fieldsComboBox.Size = new System.Drawing.Size(272, 21);
            this.fieldsComboBox.TabIndex = 5;
            this.fieldsComboBox.Text = "<Select Additional Field>";
            this.fieldsComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fields:";
            // 
            // selectedFieldTextBox
            // 
            this.selectedFieldTextBox.Location = new System.Drawing.Point(290, 65);
            this.selectedFieldTextBox.Name = "selectedFieldTextBox";
            this.selectedFieldTextBox.Size = new System.Drawing.Size(259, 20);
            this.selectedFieldTextBox.TabIndex = 7;
            this.selectedFieldTextBox.TextChanged += new System.EventHandler(this.selectedFieldTextBox_TextChanged);
            // 
            // randomizeAllFieldsButton
            // 
            this.randomizeAllFieldsButton.Location = new System.Drawing.Point(435, 92);
            this.randomizeAllFieldsButton.Name = "randomizeAllFieldsButton";
            this.randomizeAllFieldsButton.Size = new System.Drawing.Size(114, 23);
            this.randomizeAllFieldsButton.TabIndex = 8;
            this.randomizeAllFieldsButton.Text = "Randomize All Fields";
            this.randomizeAllFieldsButton.UseVisualStyleBackColor = true;
            this.randomizeAllFieldsButton.Click += new System.EventHandler(this.randomizeAllFieldsButton_Click);
            // 
            // autoGenerateButton
            // 
            this.autoGenerateButton.Location = new System.Drawing.Point(246, 92);
            this.autoGenerateButton.Name = "autoGenerateButton";
            this.autoGenerateButton.Size = new System.Drawing.Size(84, 23);
            this.autoGenerateButton.TabIndex = 9;
            this.autoGenerateButton.Text = "Auto Generate";
            this.autoGenerateButton.UseVisualStyleBackColor = true;
            this.autoGenerateButton.Click += new System.EventHandler(this.autoGenerateButton_Click);
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(12, 94);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(147, 20);
            this.clientIdTextBox.TabIndex = 10;
            this.clientIdTextBox.TextChanged += new System.EventHandler(this.clientIdTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 122);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.autoGenerateButton);
            this.Controls.Add(this.randomizeAllFieldsButton);
            this.Controls.Add(this.selectedFieldTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldsComboBox);
            this.Controls.Add(this.randomizeFieldButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "LogClient";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox logTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button randomizeFieldButton;
        private System.Windows.Forms.ComboBox fieldsComboBox;
        private System.Windows.Forms.Label label2;
        private FilteredTextBox selectedFieldTextBox;
        private System.Windows.Forms.Button randomizeAllFieldsButton;
        private System.Windows.Forms.Button autoGenerateButton;
        private FilteredTextBox clientIdTextBox;
    }
}

