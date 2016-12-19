using System;
using System.Runtime.Serialization;

namespace LogAgent {
    [DataContract]
    public class LogRecord {
        [DataMember]
        public LogType logType { get; private set; }

        [DataMember]
        public string clientId { get; private set; }

        [DataMember]
        public DateTime timestamp { get; private set; }
    }
}