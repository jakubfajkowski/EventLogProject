using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogAgentTest.LogServiceReference;
using System.Collections.Generic;
using System;
using System.Data;

namespace LogAgentTest {
    [TestClass]
    public class LogServiceTest {
        LogServiceClient logServiceClient = new LogServiceClient();

        [TestMethod]
        public void registerLogTypeTest() {
            LogType logType = initializeLogType();

            logServiceClient.registerLogType(logType);
        }

        [TestMethod]
        public void getLogTypesTest() {
            logServiceClient.getLogTypes();
        }

        [TestMethod]
        public void insertLogRecordTest() {
            LogRecord logRecord = initializeLogRecord();

            logServiceClient.insertLogRecord(logRecord);
        }

        [TestMethod]
        public void selectLogRecordTest() {
            LogType logType = initializeLogType();
            DataSet ds = logServiceClient.selectLogRecord(logType, "", DateTime.Today, DateTime.Now, 0);
        }

        [TestMethod]
        public void deleteLogRecordTest() {
            LogRecord logRecord = initializeLogRecord();

            logServiceClient.deleteLogRecord(logRecord);
        }

        [TestMethod]
        public void deleteLogTypeTest() {
            LogType logType = initializeLogType();

            logServiceClient.deleteLogType(logType);
        }

        private LogType initializeLogType() {
            LogType logType = new LogType {
                name = "testName",
                additionalFields = new Dictionary<string, string>()
            };

            logType.additionalFields.Add("a", null);
            logType.additionalFields.Add("b", null);

            return logType;
        }

        private LogRecord initializeLogRecord() {
            LogType logType = new LogType {
                name = "testName",
                additionalFields = new Dictionary<string, string>()
            };

            logType.additionalFields.Add("a", "val a");
            logType.additionalFields.Add("b", "val b");

            LogRecord logRecord = new LogRecord {
                logType = logType,
                clientId = "testClient",
                timestamp = DateTime.Now
            };

            return logRecord;
        }
    }
}