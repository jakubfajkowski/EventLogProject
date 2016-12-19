namespace EventLogProject {
    partial class CreateLogDialog {
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
            this.addFieldButton = new System.Windows.Forms.Button();
            this.deleteFieldButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logTypeNameTextBox = new FilteredTextBox();
            this.logTypeFieldsListBox = new System.Windows.Forms.ListBox();
            this.newFieldNameTextBox = new FilteredTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFieldButton
            // 
            this.addFieldButton.Location = new System.Drawing.Point(216, 111);
            this.addFieldButton.Name = "addFieldButton";
            this.addFieldButton.Size = new System.Drawing.Size(75, 23);
            this.addFieldButton.TabIndex = 0;
            this.addFieldButton.Text = "Add Field";
            this.addFieldButton.UseVisualStyleBackColor = true;
            this.addFieldButton.Click += new System.EventHandler(this.addFieldButton_Click);
            // 
            // deleteFieldButton
            // 
            this.deleteFieldButton.Location = new System.Drawing.Point(216, 140);
            this.deleteFieldButton.Name = "deleteFieldButton";
            this.deleteFieldButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFieldButton.TabIndex = 1;
            this.deleteFieldButton.Text = "Delete Field";
            this.deleteFieldButton.UseVisualStyleBackColor = true;
            this.deleteFieldButton.Click += new System.EventHandler(this.deleteFieldButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(216, 169);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log Type Name:";
            // 
            // logTypeNameTextBox
            // 
            this.logTypeNameTextBox.Location = new System.Drawing.Point(102, 16);
            this.logTypeNameTextBox.Name = "logTypeNameTextBox";
            this.logTypeNameTextBox.Size = new System.Drawing.Size(103, 20);
            this.logTypeNameTextBox.TabIndex = 5;
            // 
            // logTypeFieldsListBox
            // 
            this.logTypeFieldsListBox.FormattingEnabled = true;
            this.logTypeFieldsListBox.Location = new System.Drawing.Point(12, 54);
            this.logTypeFieldsListBox.Name = "logTypeFieldsListBox";
            this.logTypeFieldsListBox.Size = new System.Drawing.Size(193, 134);
            this.logTypeFieldsListBox.TabIndex = 6;
            // 
            // newFieldNameTextBox
            // 
            this.newFieldNameTextBox.Location = new System.Drawing.Point(102, 200);
            this.newFieldNameTextBox.Name = "newFieldNameTextBox";
            this.newFieldNameTextBox.Size = new System.Drawing.Size(103, 20);
            this.newFieldNameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Field Name:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(216, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateLogDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 229);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newFieldNameTextBox);
            this.Controls.Add(this.logTypeFieldsListBox);
            this.Controls.Add(this.logTypeNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.deleteFieldButton);
            this.Controls.Add(this.addFieldButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateLogDialog";
            this.Text = "Create Log Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFieldButton;
        private System.Windows.Forms.Button deleteFieldButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private FilteredTextBox logTypeNameTextBox;
        private System.Windows.Forms.ListBox logTypeFieldsListBox;
        private FilteredTextBox newFieldNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
    }
}