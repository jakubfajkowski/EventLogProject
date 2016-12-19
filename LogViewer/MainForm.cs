using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LogViewer.LogServiceReference;

namespace LogViewer {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            updateLogTypeComboBox();
        }

        private void updateLogTypeComboBox() {
            logTypeComboBox.Items.Clear();

            try { 
                LogType[] logTypes = Program.logServiceClient.getLogTypes();

                foreach (LogType logType in logTypes) {
                    BoxItem<LogType> comboBoxItem = new BoxItem<LogType> {
                        text = logType.name,
                        value = logType
                    };

                    logTypeComboBox.Items.Add(comboBoxItem);
                }
            }
            catch {
                MessageBox.Show("Log type collecting failure.");
            }

    logTypeComboBox.Text = "<Select Log Type>";
        }

        private void updateFieldsTypeComboBox(BoxItem<string> comboBoxItem) {
            fieldsComboBox.Items.Add(comboBoxItem);
            fieldsComboBox.Text = "<Select Additional Field>";
        }

        private void logTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            LogType logType = ((BoxItem<LogType>) logTypeComboBox.SelectedItem).value;

            fieldsComboBox.Items.Clear();

            foreach (KeyValuePair<string, string> additionalField in logType.additionalFields) {
                BoxItem<string> comboBoxItem = new BoxItem<string> {
                    text = additionalField.Key,
                    value = additionalField.Value
                };

                updateFieldsTypeComboBox(comboBoxItem);
            }
        }

        private void additionalFieldsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectedFieldTextBox.Text = ((BoxItem<string>) fieldsComboBox.SelectedItem).value;
        }

        private void selectedFieldTextBox_TextChanged(object sender, EventArgs e) {
            BoxItem<string> selectedBoxItem = ((BoxItem<string>) fieldsComboBox.SelectedItem);
            if (selectedBoxItem != null) {
                selectedBoxItem.value = selectedFieldTextBox.Text;

                string key = ((BoxItem<string>) fieldsComboBox.SelectedItem).ToString();
                ((BoxItem<LogType>) logTypeComboBox.SelectedItem).value.additionalFields[key] =
                    selectedFieldTextBox.Text;
            }
            else MessageBox.Show(this, "You must choose field first.");
        }

        private void selectButton_Click(object sender, EventArgs e) {
            BoxItem<LogType> selectedBoxItem = ((BoxItem<LogType>) logTypeComboBox.SelectedItem);

            if (selectedBoxItem != null) {
                Query query = new Query {
                    logType = selectedBoxItem.value,
                    clientId = clientIdTextBox.Text,
                    from = fromDateTimePicker.Value,
                    to = toDateTimePicker.Value
                };
                TableDialog tableDialog = new TableDialog {query = query};
                tableDialog.Show(this);
            }
            else MessageBox.Show(this, "You must choose log type first.");
        }

        private void deleteTableButton_Click(object sender, EventArgs e) {
            BoxItem<LogType> selectedBoxItem = ((BoxItem<LogType>)logTypeComboBox.SelectedItem);

            if (selectedBoxItem != null) {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete table" + logTypeComboBox.Text, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    LogType logType = selectedBoxItem.value;

                    try { 
                        Program.logServiceClient.deleteLogType(logType);
                        updateLogTypeComboBox();
                        fieldsComboBox.Text = "<Select Additional Field>";
                    }
                    catch {
                        MessageBox.Show("Log type deleting failure.");
                    }
            }
            }
            else MessageBox.Show(this, "You must choose log type first.");
        }
    }
}