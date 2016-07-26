using System;

namespace Log4NetLibrary
{
    public interface ILogService
    {
        void WriteLog(LogLevel logLevel, String log);
    }
}
