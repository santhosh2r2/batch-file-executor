using Batch.File.Executor.Controllers;
using Batch.File.Executor.Models;
using Batch.File.Executor.Service;
using NLog;

namespace Batch.File.Executor.UserControls;

public partial class MainView : UserControl
{
    private BatchFile? _batchFile;
    public BatchFile? BatchFile
    {
        get => _batchFile;
        set
        {
            _batchFile = value;
            if (BatchFile == null) return;
            lblFilename.Text = BatchFile.display_name;
            if (webView21 != null) SetEditorContent(BatchFile.text);
        }
    }

    public event EventHandler LogUpdate;

    private static AppLogger _logger = new();

    public event EventHandler<BatchFileEventArgs>? HandleRemoveBatchFile = null;

    public MainView()
    {
        InitializeComponent();
        InitializeWebView2Async();

    }

    #region Monaco Editor

    // Method to set content dynamically in the Monaco Editor
    private async void SetEditorContent(string content)
    {
        // Execute JavaScript in the WebView2 to update the editor content
        var script = $"setEditorContent({EscapeJavaScriptString(content)});";
        if (webView21.CoreWebView2 != null) await webView21.ExecuteScriptAsync(script);
    }

    // Utility method to escape JavaScript strings to prevent errors
    private static string EscapeJavaScriptString(string s)
    {
        return "\"" + s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r") + "\"";
    }


    private async void InitializeWebView2Async()
    {
        // Ensure WebView2 is ready before loading the content
        await webView21.EnsureCoreWebView2Async(null);

        // Get the path of the HTML file containing the Monaco Editor
        var currentDirectory = Directory.GetCurrentDirectory();
        var editorHtmlPath = Path.Combine(currentDirectory, "editor.html");

        // Load the editor.html file into the WebView2
        webView21.Source = new Uri(editorHtmlPath);

    }



    #endregion
    public void btnPlay_Click(object sender, EventArgs e)
    {
        if (BatchFile == null) return;
        BatchFile.Execute();

        var app = new BatchFileAppController(BatchFile);
        app.Update();
        _logger.Write(LogLevel.Info, BatchFile.Id, $"Updated entries in database for '{BatchFile.display_name}'");
        LogUpdate?.Invoke(sender, e);

    }
    public void btnDelete_Click(object sender, EventArgs e)
    {
        if (BatchFile == null) return;

        HandleRemoveBatchFile?.Invoke(this, new BatchFileEventArgs(BatchFile));
    }



}