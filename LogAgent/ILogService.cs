using System;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

namespace LogAgent {
    [ServiceContract]
    public interface ILogService {
        [OperationContract]
        int insertLogRecord(LogRecord logRecord);

        [OperationContract]
        DataSet selectLogRecord(LogType logType, string clientId, DateTime from, DateTime to, int numberOfFirstRecord);

        [OperationContract]
        int deleteLogRecord(LogRecord logRecord);

        [OperationContract]
        int registerLogType(LogType log);

        [OperationContract]
        List<LogType> getLogTypes();

        [OperationContract]
        int deleteLogType(LogType log);
    }
}