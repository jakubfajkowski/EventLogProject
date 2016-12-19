using EventLogProject;

namespace LogViewer {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.logTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fieldsComboBox = new System.Windows.Forms.ComboBox();
            this.timestampGroupBox = new System.Windows.Forms.GroupBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.additionalFieldsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clientIdTextBox = new EventLogProject.FilteredTextBox();
            this.selectedFieldTextBox = new EventLogProject.FilteredTextBox();
            this.deleteTableButton = new System.Windows.Forms.Button();
            this.timestampGroupBox.SuspendLayout();
            this.additionalFieldsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logTypeComboBox
            // 
            this.logTypeComboBox.FormattingEnabled = true;
            this.logTypeComboBox.Location = new System.Drawing.Point(12, 31);
            this.logTypeComboBox.Name = "logTypeComboBox";
            this.logTypeComboBox.Size = new System.Drawing.Size(213, 21);
            this.logTypeComboBox.TabIndex = 0;
            this.logTypeComboBox.Text = "<Select Log Type>";
            this.logTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.logTypeComboBox_SelectedIndexChanged);
            // 
            // fieldsComboBox
            // 
            this.fieldsComboBox.FormattingEnabled = true;
            this.fieldsComboBox.Location = new System.Drawing.Point(6, 15);
            this.fieldsComboBox.Name = "fieldsComboBox";
            this.fieldsComboBox.Size = new System.Drawing.Size(189, 21);
            this.fieldsComboBox.TabIndex = 1;
            this.fieldsComboBox.Text = "<Select Additional Field>";
            this.fieldsComboBox.SelectedIndexChanged += new System.EventHandler(this.additionalFieldsComboBox_SelectedIndexChanged);
            // 
            // timestampGroupBox
            // 
            this.timestampGroupBox.Controls.Add(this.toDateTimePicker);
            this.timestampGroupBox.Controls.Add(this.fromDateTimePicker);
            this.timestampGroupBox.Controls.Add(this.label2);
            this.timestampGroupBox.Controls.Add(this.label1);
            this.timestampGroupBox.Location = new System.Drawing.Point(438, 12);
            this.timestampGroupBox.Name = "timestampGroupBox";
            this.timestampGroupBox.Size = new System.Drawing.Size(252, 74);
            this.timestampGroupBox.TabIndex = 4;
            this.timestampGroupBox.TabStop = false;
            this.timestampGroupBox.Text = "Timestamp";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(45, 46);
            this.toDateTimePicker.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 8;
            this.toDateTimePicker.Value = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(46, 19);
            this.fromDateTimePicker.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 7;
            this.fromDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(277, 92);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(200, 23);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "Select Table";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // additionalFieldsGroupBox
            // 
            this.additionalFieldsGroupBox.Controls.Add(this.selectedFieldTextBox);
            this.additionalFieldsGroupBox.Controls.Add(this.fieldsComboBox);
            this.additionalFieldsGroupBox.Location = new System.Drawing.Point(231, 16);
            this.additionalFieldsGroupBox.Name = "additionalFieldsGroupBox";
            this.additionalFieldsGroupBox.Size = new System.Drawing.Size(201, 70);
            this.additionalFieldsGroupBox.TabIndex = 6;
            this.additionalFieldsGroupBox.TabStop = false;
            this.additionalFieldsGroupBox.Text = "Additional Fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Client Id:";
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(66, 59);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(159, 20);
            this.clientIdTextBox.TabIndex = 8;
            // 
            // selectedFieldTextBox
            // 
            this.selectedFieldTextBox.Location = new System.Drawing.Point(6, 42);
            this.selectedFieldTextBox.Name = "selectedFieldTextBox";
            this.selectedFieldTextBox.Size = new System.Drawing.Size(189, 20);
            this.selectedFieldTextBox.TabIndex = 2;
            this.selectedFieldTextBox.TextChanged += new System.EventHandler(this.selectedFieldTextBox_TextChanged);
            // 
            // deleteTableButton
            // 
            this.deleteTableButton.Location = new System.Drawing.Point(490, 92);
            this.deleteTableButton.Name = "deleteTableButton";
            this.deleteTableButton.Size = new System.Drawing.Size(200, 23);
            this.deleteTableButton.TabIndex = 9;
            this.deleteTableButton.Text = "Delete Table";
            this.deleteTableButton.UseVisualStyleBackColor = true;
            this.deleteTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 124);
            this.Controls.Add(this.deleteTableButton);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.additionalFieldsGroupBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.timestampGroupBox);
            this.Controls.Add(this.logTypeComboBox);
            this.Name = "MainForm";
            this.Text = "Log Viewer";
            this.timestampGroupBox.ResumeLayout(false);
            this.timestampGroupBox.PerformLayout();
            this.additionalFieldsGroupBox.ResumeLayout(false);
            this.additionalFieldsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox logTypeComboBox;
        private System.Windows.Forms.ComboBox fieldsComboBox;
        private System.Windows.Forms.GroupBox timestampGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.GroupBox additionalFieldsGroupBox;
        private FilteredTextBox selectedFieldTextBox;
        private System.Windows.Forms.Label label3;
        private FilteredTextBox clientIdTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Button deleteTableButton;
    }
}

