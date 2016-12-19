﻿using EventLogProject.LogServiceReference;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventLogProject {
    public partial class AutoGenerateDialog : Form {
        static Random random = new Random();
        private bool sending = false;

        public AutoGenerateDialog() {
            InitializeComponent();
            updateUsedLogTypesCheckListBox();
        }

        private void updateUsedLogTypesCheckListBox() {
            usedLogTypesCheckListBox.Items.Clear();

            try { 
                LogType[] logTypes = Program.logServiceClient.getLogTypes();

                foreach (LogType logType in logTypes) {
                    BoxItem<LogType> checkListBoxItem = new BoxItem<LogType> {
                        text = logType.name,
                        value = logType
                    };

                    usedLogTypesCheckListBox.Items.Add(checkListBoxItem);
                }
            }
            catch {
                MessageBox.Show("Log type collecting failure.");
            }
        }

        private void startButton_Click(object sender, EventArgs e) {
            if (sending == false) {
                int timeInterval = (int) timeIntervalNumericUpDown.Value;
                int maxLogRecordsNumber = (int) numberOfLogRecordsNumericUpDown.Value;

                if (usedLogTypesCheckListBox.CheckedItems.Count > 0) {
                    List<LogType> usedLogTypes = new List<LogType>();
                    foreach (var usedLogType in usedLogTypesCheckListBox.CheckedItems) {
                        usedLogTypes.Add(((BoxItem<LogType>) usedLogType).value);
                    }

                    Task task = Task.Run(() => {
                        sending = true;
                        initializeProgressBar(maxLogRecordsNumber);

                        try { 
                            for (int i = 0; i < maxLogRecordsNumber; i++) {
                                Thread.Sleep(timeInterval);
                                LogType randomLogType = getRandomLogType(usedLogTypes);
                                LogRecord randomLogRecord = RandomLogRecordGenerator.logRecord(randomLogType);
                                Program.logServiceClient.insertLogRecord(randomLogRecord);
                                progressBar.Value++;
                                if (sending == false) break;
                            }
                        }
                        catch {
                            MessageBox.Show("Auto record insertion failure.");
                        }
                        this.UseWaitCursor = false;
                        sending = false;
                    });
                }
                else MessageBox.Show(this, "You must check at least one log type first.");
            }
            else sending = false;

        }

        private void initializeProgressBar(int max) {
            this.UseWaitCursor = true;
            progressBar.Minimum = 0;
            progressBar.Maximum = max;
            progressBar.Value = 0;
            progressBar.Step = 1;
        }

        private LogType getRandomLogType(List<LogType> usedLogTypes) {
            int randomIndex = random.Next(usedLogTypes.Count);
            return usedLogTypes[randomIndex];
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            sending = false;
            this.Close();
        }
    }
}