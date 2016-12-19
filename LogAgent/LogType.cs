using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LogAgent {
    [DataContract]
    public class LogType {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Dictionary<string, string> additionalFields { get; set; }
    }
}