using System;
using System.Data;
using System.Windows.Forms;
using LogViewer.LogServiceReference;

namespace LogViewer {
    public partial class TableDialog : Form {
        public Query query { private get; set; }
        private DataSet logDataSet;
        private int currentPage = 0;

        public TableDialog() {
            InitializeComponent();
        }

        private void TableDialog_Load(object sender, EventArgs e) {
            performQuery();
            refreshDataGridView();
        }

        private void refreshDataGridView() {
            dataGridView.DataSource = logDataSet;
            dataGridView.DataMember = logDataSet.Tables[0].ToString();
            dataGridView.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
            updatePageLabel();
        }

        private void previousPageButton_Click(object sender, EventArgs e) {
            if (currentPage > 0) {
                currentPage--;
                performQuery();
                refreshDataGridView();
                nextPageButton.Enabled = true;
            }
            if (currentPage == 0) {
                previousPageButton.Enabled = false;
            }
        }

        private void nextPageButton_Click(object sender, EventArgs e) {
            if (dataGridView.RowCount == 101) {
                currentPage++;
                performQuery();
                refreshDataGridView();
                previousPageButton.Enabled = true;
            }
            if (dataGridView.RowCount != 101) {
                nextPageButton.Enabled = false;
            }
        }

        private void updatePageLabel() {
            pageLabel.Text = $"Showing: {currentPage*100} - {currentPage*100 + dataGridView.RowCount - 1}";
        }

        private void performQuery() {
            LogType logType = query.logType;
            string clientId = query.clientId;
            DateTime from = query.from;
            DateTime to = query.to;

            try { 
                logDataSet = Program.logServiceClient.selectLogRecord(logType, clientId, from, to, 100 * currentPage);
            }
            catch {
                MessageBox.Show("Log type " + logType.name + " selection failure.");
            }
}

        private void deleteButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows) {
                string name = dataGridView.DataMember;
                string clientId = (string) item.Cells["ClientId"].Value;
                DateTime timestamp = (DateTime) item.Cells["Timestamp"].Value;

                LogType logType = new LogType {
                    name = name
                };
                LogRecord logRecordToDelete = new LogRecord {
                    logType = logType,
                    clientId = clientId,
                    timestamp = timestamp
                };

                try { 
                    Program.logServiceClient.deleteLogRecord(logRecordToDelete);
                }
                catch {
                    MessageBox.Show("Log record deleting failure.");
                }

            dataGridView.Rows.RemoveAt(item.Index);
            }
        }
    }
}