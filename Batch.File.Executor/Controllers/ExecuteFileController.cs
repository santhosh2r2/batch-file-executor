using System.Diagnostics;
using System.Xml.Linq;
using Batch.File.Executor.Models;
using Batch.File.Executor.Service;
using NLog;

namespace Batch.File.Executor.Controllers;



public static class Extensions
{
    private static AppLogger _logger = new();
    public static void Execute(this BatchFile batchfile, bool useShellExecute = false, bool createNoWindow = true)
    {
        _logger.Write(LogLevel.Info, batchfile.Id, $"Execution started - '{batchfile.display_name}'");

        var start = DateTime.UtcNow;
        var filename = Path.GetTempFileName();

        var getExtension = Path.GetExtension(filename);
        var batchFilename = filename.Replace(getExtension, ".bat");
        //var batchFilename = filename.Replace(getExtension, ".vbs");
        System.IO.File.WriteAllText(batchFilename, batchfile.text);

        if (batchfile.text.ToLower().Contains("pause"))
        {
            useShellExecute = true;
            createNoWindow = false;
        }

        // Create a new process start info
        var processStartInfo = new ProcessStartInfo
        {
            FileName = batchFilename,
            // FileName = "cscript.exe",
            // for vbs: Arguments = $"\"{batchFilename}\"",
            RedirectStandardOutput = !useShellExecute,
            RedirectStandardError = !useShellExecute,
            UseShellExecute = useShellExecute,
            CreateNoWindow = createNoWindow
        };
        // Start the process
        using var process = Process.Start(processStartInfo);

        var output = "";
        var error = "";

        if (!useShellExecute)
        {
            // Read the output
            output = process?.StandardOutput.ReadToEnd();
            error = process?.StandardError.ReadToEnd();
        }
        // Wait for the process to exit
        process?.WaitForExit();

        if (!useShellExecute)
        {
            // Display errors, if any
            if (!string.IsNullOrEmpty(error))
            {
                // execution log error
            }

        }
        System.IO.File.Delete(batchFilename);

        var end = DateTime.UtcNow;

        // log entry start and end after this

        // execution log - output
        var executionLog = new ExecutionLog()
        {
            BatchFileId = batchfile.Id,
            time_start = start,
            time_end = end
        };
        batchfile.ExecutionLogs = [executionLog];

        _logger.Write(LogLevel.Info, batchfile.Id, $"Execution finished - '{batchfile.display_name}'");

    }
}