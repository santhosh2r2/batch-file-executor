using Microsoft.EntityFrameworkCore;
using System;
using Unit.Tests.Models;
using Xunit.Abstractions;

namespace Unit.Tests;

public class Test_EF_Database : IDisposable
{
    private readonly ITestOutputHelper _testOutputHelper;

    private static DbContextOptions<BatchFileExecutorContext> GetInMemoryDatabaseOptions()
    {
        return new DbContextOptionsBuilder<BatchFileExecutorContext>()
            .UseInMemoryDatabase(databaseName: "InMemoryDb")
            .Options;
    }

    private static BatchFileExecutorContext _context;


    /// <summary>
    /// Constructor will be executed for each unit test
    /// </summary>
    public Test_EF_Database(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _context = new BatchFileExecutorContext(GetInMemoryDatabaseOptions());
        _context.Database.EnsureCreated();
    }
    /// <summary>
    /// Dispose will be executed after every unit test
    /// </summary>
    public void Dispose()
    {
        _context.Database.EnsureDeleted();
    }

    [Fact]
    public void CreateAnEntryInTableBatchFile()
    {
        BatchFile? dummy = null;
        // Arrange & Act 

        var batchFile = new BatchFile
        {
            display_name = $"Batch file {_context.BatchFiles.ToList().Count + 1}",
            created_at = DateTime.UtcNow,
            text = "@echo off \n 'Hello world'"
        };

        _context.BatchFiles.Add(batchFile);
        _context.SaveChanges();


        dummy = _context.BatchFiles.FirstOrDefault();

        //Assert
        Assert.NotNull(dummy);
        Assert.Equal("Batch file 1", dummy.display_name);

    }

    [Fact]
    public void CreateAnEntryInTableExecutionLog()
    {
        //Arrange 
        ExecutionLog? dummy = null;
        var startTime = DateTime.UtcNow.AddDays(-2);

        var executionLog = new ExecutionLog()
        {
            time_start = startTime,
            time_end = DateTime.UtcNow,
            BatchFileId = 1
        };

        _context.ExecutionLogs.Add(executionLog);
        _context.SaveChanges();

        //Act
        dummy = _context.ExecutionLogs.FirstOrDefault();

        //Assert
        Assert.NotNull(dummy);
        _testOutputHelper.WriteLine(dummy.ToString());
        Assert.Equal(startTime, dummy.time_start);
    }

    [Fact]
    public void AddExecutionLogsToBatchFile()
    {
        // Arrange
        var batchFile1 = new BatchFile()
        {
            display_name = "BatchFile 1",
            created_at = DateTime.UtcNow,
            text = "@echo off\necho 'Hello world! - BatchFile 1'",
        };

        _context.BatchFiles.AddRange(batchFile1);
        _context.SaveChanges();

        var executionLog1 = new ExecutionLog()
        {
            time_start = DateTime.UtcNow.AddDays(-2),
            time_end = DateTime.UtcNow.AddDays(-1),
        };
        var executionLog2 = new ExecutionLog()
        {
            time_start = DateTime.UtcNow.AddDays(-1),
            time_end = DateTime.UtcNow,
        };
        batchFile1.ExecutionLogs.Add(executionLog1);
        batchFile1.ExecutionLogs.Add(executionLog2);
        _context.SaveChanges();

        // Act
        BatchFile dummy = null;

        dummy = _context.BatchFiles.Single(x => x.Id == 1);

        // Assert
        Assert.NotNull(dummy);
        Assert.Equal(2, dummy.ExecutionLogs.Count);
    }

}