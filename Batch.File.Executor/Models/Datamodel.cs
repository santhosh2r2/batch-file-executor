using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Batch.File.Executor.Models;

[Table("BatchFile")]
public class BatchFile
{
    public int Id { get; set; }
    public string display_name { get; set; }
    public DateTime created_at { get; set; }
    public DateTime? last_modified_at { get; set; }
    public string text { get; set; }
    public DateTime? last_executed_at { get; set; }
    public string? comment { get; set; }

    public ICollection<ExecutionLog> ExecutionLogs { get; set; } = new List<ExecutionLog>();
    public ICollection<Log> Logs { get; set; } = new List<Log>();
}

[Table("ExecutionLog")]
public class ExecutionLog
{
    public int Id { get; set; }
    public DateTime time_start { get; set; }
    public DateTime time_end { get; set; }
    public int BatchFileId { get; set; }
    public BatchFile BatchFile { get; set; }

    public override string ToString() => $"Execution ID ({Id}): {time_start} - {time_end}";
}
[Table("Log")]
public class Log
{
    public int Id { get; set; }
    public DateTime LogDate { get; set; }
    public string Level { get; set; }
    public string Message { get; set; }
    public int BatchFileId { get; set; }
    public BatchFile BatchFile { get; set; }
}

public class LogItem(Log log)
{
    public Log Log => log;
    public string FullMessasge => $"{Log.LogDate.ToLocalTime():yyyy-MM-dd HH:mm:ss} [{Log.Level}]    {Log.Message}";
    public int Id => Log.Id;
}

public class BatchFileExecutorContext : DbContext
{
    public BatchFileExecutorContext() { }
    public BatchFileExecutorContext(DbContextOptions<BatchFileExecutorContext> options) : base(options) { }

    // Entities
    public DbSet<BatchFile> BatchFiles { get; set; }
    public DbSet<ExecutionLog> ExecutionLogs { get; set; }
    public DbSet<Log> Logs { get; set; }

    // Connection Builder
    protected override void OnConfiguring(DbContextOptionsBuilder? optionsBuilder)
    {
        if (optionsBuilder is { IsConfigured: false })
        {
            optionsBuilder.UseSqlite(@"Data Source=batchfileexecutor.db");
        }
    }
}