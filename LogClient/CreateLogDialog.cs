using EventLogProject.LogServiceReference;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EventLogProject {
    public partial class CreateLogDialog : Form {
        public CreateLogDialog() {
            InitializeComponent();
        }

        private void addFieldButton_Click(object sender, EventArgs e) {
            if (newFieldNameTextBox.Text != "") {
                if (!logTypeFieldsListBox.Items.Contains(newFieldNameTextBox.Text))
                    logTypeFieldsListBox.Items.Add(newFieldNameTextBox.Text);
                else MessageBox.Show(this, "Fields cannot be duplicated.");
            }
            else MessageBox.Show(this, "Field name not specified.");

            
        }

        private void deleteFieldButton_Click(object sender, EventArgs e) {
            logTypeFieldsListBox.Items.Remove(logTypeFieldsListBox.SelectedItem);
        }

        private void registerButton_Click(object sender, EventArgs e) {
            Dictionary<string, string> additionalFields = new Dictionary<string, string>();
            foreach (string item in logTypeFieldsListBox.Items)
                additionalFields.Add(item, null);

            LogType logType = new LogType {
                name = logTypeNameTextBox.Text,
                additionalFields = additionalFields
            };

            try {
                Program.logServiceClient.registerLogType(logType);
                MessageBox.Show("Log type " + logType.name + " registered.");
                this.Close();
            }
            catch {
                MessageBox.Show("Log type " + logType.name + " registration failure.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}