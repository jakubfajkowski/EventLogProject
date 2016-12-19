using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogViewer.LogServiceReference;

namespace LogViewer {
    public class Query {
        public LogType logType { get; set; }
        public string clientId { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }
}
