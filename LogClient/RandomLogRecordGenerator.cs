using EventLogProject.LogServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLogProject {
    static class RandomLogRecordGenerator {
        public static LogRecord logRecord(LogType logType) {
            Dictionary<string, string> randomAdditionalFields = new Dictionary<string, string>();
            foreach (string key in logType.additionalFields.Keys)
                randomAdditionalFields.Add(key, additionalField());

            logType.additionalFields = randomAdditionalFields;

            LogRecord logRecord = new LogRecord {
                logType = logType,
                clientId = Program.clientId,
                timestamp = DateTime.Now
            };

            return logRecord;
        }

        public static string additionalField() {
            return getRandomString();
        }

        private static string getRandomString() {
            Guid g = Guid.NewGuid();
            return Convert.ToBase64String(g.ToByteArray());
        }
    }
}