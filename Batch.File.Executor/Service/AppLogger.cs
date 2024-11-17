using NLog;

namespace Batch.File.Executor.Service;

public class AppLogger
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    public void Write(LogLevel logLevel, int batchFileId, string message)
    {
        var logEventInfo = new LogEventInfo(logLevel, Logger.Name, message)
        {
            Properties =
            {
                ["BatchFileId"] = batchFileId,
            }
        };

        Logger.Log(logEventInfo);
    }
}

