using System.Data.Entity;
using Microsoft.Extensions.Logging.Abstractions;
using NLog;
using Unit.Tests.Models;
using Xunit.Abstractions;

namespace Unit.Tests;

public class TestLogger
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

public static class LogLevelHelper
{
    private static readonly Random Random = new Random();
    private static readonly LogLevel[] LogLevels =
    [
        LogLevel.Trace,
        LogLevel.Debug,
        LogLevel.Info,
        LogLevel.Warn,
        LogLevel.Error,
        LogLevel.Fatal
    ];

    public static LogLevel GetRandomLogLevel()
    {
        var index = Random.Next(LogLevels.Length);
        return LogLevels[index];
    }
}


public class Test_NLog
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Test_NLog(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    private static readonly TestLogger _logger = new();
    [Fact]
    public void CreateASingleLog()
    {
        var context = new BatchFileExecutorContext();
        var batchFileId = context.BatchFiles.ToList().Count + 1;
        var batchFile = new BatchFile
        {
            display_name = $"Batch file {batchFileId}",
            created_at = DateTime.UtcNow,
            text = "@echo off \n 'Hello world'"
        };

        context.BatchFiles.Add(batchFile);
        context.SaveChanges();

        var logLevel = LogLevelHelper.GetRandomLogLevel();

        //_logger.Write(logLevel, 1, $"{logLevel.ToString().ToUpper()} Message for '{batchFileId}'");
        _logger.Write(logLevel, batchFileId, $"{logLevel.ToString().ToUpper()} Message for '{batchFileId}'");
        //NLog.LogManager.Shutdown();
    }


    [Fact]
    public void CreateALogTableEntry()
    {
        var context = new BatchFileExecutorContext();
        var batchFileId = context.BatchFiles.ToList().Count + 1;
        var batchFile = new BatchFile
        {
            display_name = $"Batch file {batchFileId}",
            created_at = DateTime.UtcNow,
            text = "@echo off \n 'Hello world'"
        };

        var logEntry1 = new Log()
        {
            Level = "INFO",
            LogDate = DateTime.UtcNow,
            Message = "This is info text"
        };
        batchFile.Logs.Add(logEntry1);

        context.BatchFiles.Add(batchFile);
        context.SaveChanges();
    }

    [Fact]
    public void GetBatchFileEntry()
    {
        const int id = 1;
        const int totalLogs = 5;

        var context = new BatchFileExecutorContext();

        //var executionLog = new ExecutionLog()
        //{
        //    time_start = DateTime.UtcNow,
        //    time_end = DateTime.UtcNow,
        //    BatchFileId = id
        //};

        //context.ExecutionLogs.Add(executionLog);
        //context.SaveChanges();

        var entry = context.BatchFiles.AsNoTracking() // Only use this if you don’t need change tracking
            .Include(e => e.Logs)
            .SingleOrDefault(x => x.Id == id);

        Assert.NotNull(entry);
        context.Entry(entry)
                    .Collection(b => b.Logs)
                    .Load();
        context.Entry(entry)
            .Collection(b => b.ExecutionLogs)
            .Load();
        Assert.Equal(id, entry.Id);
        Assert.NotNull(entry.Logs);
        Assert.Equal(totalLogs, entry.Logs.Count);
        _testOutputHelper.WriteLine(entry.Logs.ToString());
        _testOutputHelper.WriteLine("Total number of logs: " + entry.Logs.Count.ToString());
    }
}