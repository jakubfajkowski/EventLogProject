using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LogAgent {
    public class LogService : ILogService {
        private SqlConnection conn;

        private LogService() {
            connectToDatabase();
        }

        public int insertLogRecord(LogRecord logRecord) {
            using (var comm = conn.CreateCommand()) {
                try {
                    var values = logRecord.logType.additionalFields.Values.ToArray();

                    //SQL Injection Vulnerable
                    var commText =
                        "INSERT INTO " + logRecord.logType.name + " " +
                        "VALUES( " +
                        "'" + logRecord.clientId + "', " +
                        "'" + logRecord.timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'" +
                        "{0}" +
                        ")";

                    comm.CommandText = string.Format(commText,
                        createSeparatedList(values.Select(x => "'" + x + "'").ToArray(), ","));

                    comm.CommandType = CommandType.Text;

                    conn.Open();
                    return comm.ExecuteNonQuery();
                }
                catch (Exception) {
                    throw;
                }
                finally {
                    conn?.Close();
                }
            }
        }

        public DataSet selectLogRecord(LogType logType, string clientId, DateTime from, DateTime to,
            int numberOfFirstRecord) {
            try {
                var parametersList = new List<string>();
                foreach (var additionalField in logType.additionalFields)
                    if (!string.IsNullOrEmpty(additionalField.Value))
                        parametersList.Add(additionalField.Key + " LIKE '%" + additionalField.Value + "%'");

                if (!string.IsNullOrEmpty(clientId))
                    parametersList.Add("ClientId LIKE '%" + clientId + "%'");

                var parametersArray = parametersList.ToArray();

                var comm = new SqlCommand("SELECT * FROM " + logType.name + " " +
                                          "WHERE Timestamp >= '" + from.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' " +
                                          "AND Timestamp <= '" + to.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' " +
                                          createSeparatedList(parametersArray, "AND") + " " +
                                          "ORDER BY Timestamp " +
                                          "OFFSET " + numberOfFirstRecord + " ROWS " +
                                          "FETCH NEXT 100 ROWS ONLY ", conn);

                var dataadapter = new SqlDataAdapter(comm);
                var ds = new DataSet();
                conn.Open();
                dataadapter.Fill(ds, logType.name);
                return ds;
            }
            catch (Exception) {
                throw;
            }
            finally {
                conn?.Close();
            }
        }

        public int deleteLogRecord(LogRecord logRecord) {
            using (var comm = conn.CreateCommand()) {
                try {
                    //SQL Injection Vulnerable
                    var commText =
                        "DELETE FROM " + logRecord.logType.name + " " +
                        "WHERE ClientId = '" + logRecord.clientId + "' AND " +
                        "Timestamp = '" + logRecord.timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'";

                    comm.CommandText = commText;

                    comm.CommandType = CommandType.Text;

                    conn.Open();
                    return comm.ExecuteNonQuery();
                }
                catch (Exception) {
                    throw;
                }
                finally {
                    conn?.Close();
                }
            }
        }

        public int registerLogType(LogType logType) {
            using (var comm = conn.CreateCommand()) {
                try {
                    var keys = logType.additionalFields.Keys.ToArray();

                    //SQL Injection Vulnerable
                    var commText =
                        "CREATE TABLE " + logType.name + " " +
                        "( " +
                        "ClientId VARCHAR(255), " +
                        "Timestamp DATETIME" +
                        "{0} " +
                        "CONSTRAINT pk_" + logType.name + "Id PRIMARY KEY(ClientId, Timestamp)" +
                        ")";

                    var sqlAdditionalColumnsDeclaration = keys.Select(x => x + " VARCHAR(255)").ToArray();
                    comm.CommandText = string.Format(commText, createSeparatedList(sqlAdditionalColumnsDeclaration, ","));

                    comm.CommandType = CommandType.Text;

                    conn.Open();
                    return comm.ExecuteNonQuery();
                }
                catch (Exception) {
                    throw;
                }
                finally {
                    conn?.Close();
                }
            }
        }

        public List<LogType> getLogTypes() {
            var logTypes = new List<LogType>();
            try {
                conn.Open();

                var table = conn.GetSchema("Tables");
                foreach (DataRow row in table.Rows)
                    logTypes.Add(getLogTypeUsingDatabase(row["TABLE_NAME"].ToString()));
            }
            catch (Exception) {
                throw;
            }
            finally {
                conn?.Close();
            }

            return logTypes;
        }

        public int deleteLogType(LogType logType) {
            using (var comm = conn.CreateCommand()) {
                try {
                    //SQL Injection Vulnerable
                    var commText = "DROP TABLE " + logType.name;

                    comm.CommandText = commText;

                    comm.CommandType = CommandType.Text;

                    conn.Open();
                    return comm.ExecuteNonQuery();
                }
                catch (Exception) {
                    throw;
                }
                finally {
                    conn?.Close();
                }
            }
        }

        private void connectToDatabase() {
            var connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "(local)";
            connStringBuilder.InitialCatalog = "LogDatabase";
            connStringBuilder.IntegratedSecurity = true;
            connStringBuilder.Pooling = false;


            conn = new SqlConnection(connStringBuilder.ToString());
        }

        private string createSeparatedList(string[] strings, string separator) {
            if (strings.Length > 0)
                return separator + " " + string.Join(separator + " ", strings);
            return "";
        }

        private LogType getLogTypeUsingDatabase(string tableName) {
            var comm = new SqlCommand("select COLUMN_NAME, ORDINAL_POSITION " +
                                      "from INFORMATION_SCHEMA.COLUMNS " +
                                      "where TABLE_NAME = '" + tableName + "' AND ORDINAL_POSITION >= 3", conn);

            var additionalFields = new Dictionary<string, string>();
            using (var reader = comm.ExecuteReader()) {
                while (reader.Read()) additionalFields.Add(reader["COLUMN_NAME"].ToString(), null);
            }

            return new LogType {
                name = tableName,
                additionalFields = additionalFields
            };
        }
    }
}