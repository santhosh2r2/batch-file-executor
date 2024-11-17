using System.Diagnostics;
using Xunit.Abstractions;

namespace Unit.Tests;

public class Test_Execution(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void CanCreateTempFile()
    {
        //Arrange
        var filename = Path.GetTempFileName();
        testOutputHelper.WriteLine(filename);

        var getExtension = Path.GetExtension(filename);
        var onlyName = Path.GetFileNameWithoutExtension(filename);
        testOutputHelper.WriteLine(getExtension);
        testOutputHelper.WriteLine(onlyName);

        //Act

        var batFilename = filename.Replace(getExtension, ".bat");
        testOutputHelper.WriteLine(batFilename);

        //Assert
        Assert.Contains(onlyName + ".bat", batFilename);
        File.WriteAllText(batFilename, "@echo off; Hello world");


        // remove the temp file
        File.Delete(filename);
        File.Delete(batFilename);
        Process.Start("explorer.exe", Path.GetTempPath());
    }

    [Fact]
    public void ExecuteBatchFile_WithoutPauseCmd()
    {
        const string cmd = "@echo off\necho 'Hello world!'";
        ExecuteBatchFile(cmd);
    }


    private string adminCmd = """
 
                              REM Test if Admin
                              if not "%1"=="am_admin" (
                                  powershell -Command "Start-Process -Verb RunAs -FilePath '%0' -ArgumentList 'am_admin'"
                                  exit /b 
                              )
                              echo Started with Admin privileges...
                              """;


    private void ExecuteBatchFile(string cmd, bool useShell = false, bool createNoWindow = true)
    {
        var start = DateTime.UtcNow;
        var filename = Path.GetTempFileName();

        var getExtension = Path.GetExtension(filename);
        var batchFilename = filename.Replace(getExtension, ".bat");
        File.WriteAllText(batchFilename, cmd);

        // Create a new process start info
        var processStartInfo = new ProcessStartInfo
        {
            FileName = batchFilename,
            RedirectStandardOutput = !useShell,
            RedirectStandardError = !useShell,
            UseShellExecute = useShell,
            CreateNoWindow = createNoWindow
        };
        // Start the process
        using var process = Process.Start(processStartInfo);

        var output = "";
        var error = "";

        if (!useShell)
        {
            // Read the output
            output = process?.StandardOutput.ReadToEnd();
            error = process?.StandardError.ReadToEnd();
        }
        // Wait for the process to exit
        process?.WaitForExit();

        if (!useShell)
        {
            // Display errors, if any
            if (!string.IsNullOrEmpty(error))
            {
                testOutputHelper.WriteLine("Error:");
                testOutputHelper.WriteLine(error);
            }

            testOutputHelper.WriteLine(output);
        }
        File.Delete(batchFilename);

        var end = DateTime.UtcNow;
        testOutputHelper.WriteLine($"Total execution time is: {end - start}");

    }

    [Fact]
    public void ExecuteBatchFile_WithAdminPrivileges()
    {
        const string cmd = """
                           
                           CD C:\Windows\System32\drivers\etc

                           notepad hosts
                           """;
        ExecuteBatchFile(adminCmd + cmd, true);
    }

    [Fact]
    public void ExecuteBatchFile_WithPause()
    {
        const string cmd = """
                           @echo off
                           echo "Hello world!"
                           pause
                           """;
        ExecuteBatchFile(cmd, true);
    }

    [Fact]
    public void ExecuteBatchFile_With5SecondsDelay()
    {
        const string cmd = """
                           @echo off
                           
                           echo Starting process...
                           timeout /t 5 /nobreak
                           echo Process resumed after 5 seconds.
                           
                           """;
        ExecuteBatchFile(cmd, true);

    }
}