using System.ComponentModel;
using FontAwesome.Sharp;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Batch.File.Executor.Controllers;
using Batch.File.Executor.Models;
using Batch.File.Executor.UserControls;
using Batch.File.Executor.Views;
using Button = System.Windows.Forms.Button;
using Control = System.Windows.Forms.Control;
using System.Text;
using Batch.File.Executor.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Web.WebView2.Core;
using NLog;
using NLog.LayoutRenderers;

namespace Batch.File.Executor;

public partial class MainForm : Form
{
    // rounded border reference
    //https://rjcodeadvance.com/crear-formulario-de-bordes-redondeados-suaves-c-winforms/
    //Fields
    private int borderRadius = 10;
    private int borderSize = 2;
    private Color borderColor = Color.White;
    private Color titlebarColor = Color.FromArgb(235, 235, 235);
    private Color containerColor = Color.FromArgb(235, 235, 235);


    private BindingList<BatchFile> _batchFileList;
    private BindingList<LogItem> _logs;
    private BatchFileExecutorContext _context;

    private static AppLogger _logger = new();

    private static string sqlText(int limit) => $"SELECT * from {nameof(Log)} ORDER BY {nameof(Log.LogDate)} desc Limit {limit}";

    void SetIconColors(Button control, Color color)
    {
        control.BackColor = color;
        control.FlatAppearance.BorderColor = color;
    }

    // user-control: MainView
    private MainView? mainView = new()
    {
        Dock = DockStyle.Fill
    };


    public MainForm()
    {
        AppControllerBase.CreateDatabase();
        InitializeComponent();

        this.FormBorderStyle = FormBorderStyle.None;
        this.Padding = new Padding(borderSize);

        this.panelTitleBar.BackColor = titlebarColor;
        this.BackColor = borderColor;
        this.panelContainer.BackColor = containerColor;
        this.panelSidebar.BackColor = borderColor;


        SetIconColors(btnMinimize, titlebarColor);
        SetIconColors(btnMaximize, titlebarColor);
        SetIconColors(btnClose, titlebarColor);
        SetIconColors(btnAbout, titlebarColor);

       
        _context = new BatchFileExecutorContext();
        var files = _context.BatchFiles.ToList();
        _batchFileList = new BindingList<BatchFile>(files);
        listFiles.DataSource = _batchFileList;
        listFiles.DisplayMember = nameof(BatchFile.display_name);
        listFiles.ValueMember = nameof(BatchFile.Id);

        listFiles.SelectedIndex = -1;

        mainView.HandleRemoveBatchFile += OnRemoveBatchFile;
        mainView.LogUpdate += OnLogUpdate;

        _logger.Write(LogLevel.Info, -1, "App started");

        SetLogList();

    }

    private void SetLogList()
    {
        var logs = _context.Logs
            .FromSqlRaw(sqlText(100))
            .ToList();
        _logs = new BindingList<LogItem>(logs.Select(l => new LogItem(l)).ToList());
        listLogs.DataSource = _logs;
        listLogs.DisplayMember = nameof(LogItem.FullMessasge);
        listLogs.ValueMember = nameof(LogItem.Id);
    }

    private void OnLogUpdate(object? sender, EventArgs e)
    {
        SetLogList();
    }


    #region curved border mainform and ui components
    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void MainForm_MouseDown(object sender, MouseEventArgs e)
    {

    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
            return cp;
        }
    }

    // Private methods
    private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
    {
        if (this.WindowState != FormWindowState.Minimized)
        {
            using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (Matrix transform = new Matrix())
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                form.Region = new Region(roundPath);
                if (borderSize >= 1)
                {
                    Rectangle rect = form.ClientRectangle;
                    float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                    float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                    transform.Scale(scaleX, scaleY);
                    transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                    graph.Transform = transform;
                    graph.DrawPath(penBorder, roundPath);
                }
            }
        }
    }

    private void MainForm_Paint(object sender, PaintEventArgs e)
    {
        FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
    }


    private void MainForm_ResizeEnd(object sender, EventArgs e)
    {
        this.Invalidate();
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
        this.Invalidate();
    }

    private void MainForm_Activated(object sender, EventArgs e)
    {
        this.Invalidate();
    }

    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
    {
        using GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius);
        using Pen penBorder = new(borderColor, 1);
        graph.SmoothingMode = SmoothingMode.AntiAlias;
        control.Region = new Region(roundPath);
        graph.DrawPath(penBorder, roundPath);
    }
    private void panelContainer_Paint(object sender, PaintEventArgs e)
    {
        ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
    }


    private void MainForm_Resize(object sender, EventArgs e)
    {
        this.Invalidate();
        panelContainer.Invalidate();
        panelSidebar.Invalidate();
        panelMainView.Invalidate();
    }

    #endregion


    private void btnClose_Click(object sender, EventArgs e)
    {


        Application.Exit();
    }

    enum ScreenSizeMode
    {
        WithTaskbar,
        FullScreen,
        Normal,
        Minimized
    }

    private ScreenSizeMode _screenSize = ScreenSizeMode.Normal;

    private void btnMaximize_Click_1(object sender, EventArgs e)
    {
        switch (_screenSize)
        {
            case ScreenSizeMode.Normal:
                {
                    _screenSize = ScreenSizeMode.WithTaskbar;
                    if (Screen.PrimaryScreen != null) this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                    WindowState = FormWindowState.Maximized;
                    btnMaximize.IconChar = IconChar.Expand;
                    break;
                }
            case ScreenSizeMode.WithTaskbar:
                {
                    WindowState = FormWindowState.Normal;
                    if (Screen.PrimaryScreen != null) this.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
                    WindowState = FormWindowState.Maximized;
                    _screenSize = ScreenSizeMode.FullScreen;
                    btnMaximize.IconChar = IconChar.Compress;
                    break;
                }
            default:
                WindowState = FormWindowState.Normal;
                _screenSize = ScreenSizeMode.Normal;
                btnMaximize.IconChar = IconChar.Maximize;
                this.Size = new Size(1280, 720);
                break;
        }
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
        var popupDialog = new DialogBase("About")
        {
            StartPosition = FormStartPosition.CenterParent
        };
        var result = popupDialog.ShowDialog();

    }

    private void splitContainerSidebar_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panelSidebar_Paint(object sender, PaintEventArgs e)
    {
        ControlRegionAndBorder(panelSidebar, 10, e.Graphics, borderColor);

    }

    private void panelLogs_Paint(object sender, PaintEventArgs e)
    {
        ControlRegionAndBorder(panelLogs, 10, e.Graphics, borderColor);

    }

    private void panelMainView_Paint(object sender, PaintEventArgs e)
    {
        ControlRegionAndBorder(panelMainView, 10, e.Graphics, borderColor);

    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
        _screenSize = ScreenSizeMode.Minimized;
    }

    private Label lblAddUploadFile = new()
    {
        Text = "Add or Upload a batch file",
        Dock = DockStyle.Fill,
        AutoSize = false,
        TextAlign = ContentAlignment.MiddleCenter
    };



    private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetPanels();
    }

    private void SetPanels()
    {
        if (_batchFileList.Count == 0 || listFiles.SelectedIndex == -1)
        {
            panelMainView.Controls.Clear();
            var text = _batchFileList.Count == 0 ? "Add or Upload " : "Select ";
            lblAddUploadFile.Text = $@"{text} File.";
            panelMainView.Controls.Add(lblAddUploadFile);

        }
        else
        {
            if (mainView != null)
            {
                mainView.BatchFile = (BatchFile)listFiles.SelectedItem;

                panelMainView.Controls.Clear();
                panelMainView.Controls.Add(mainView);
                panelMainView.Invalidate();
            }

        }
    }
    private void OnRemoveBatchFile(object? sender, BatchFileEventArgs e)
    {
        // Remove from database
        _context.BatchFiles.Remove(e.File);
        _context.SaveChanges();

        // Remove from binding list
        _batchFileList.Remove(e.File);

        // Rerender the panels
        SetPanels();

        _logger.Write(LogLevel.Info, e.File.Id, $"Removed '{e.File.display_name}' from database");
        SetLogList();

    }


    private void btnUploadFile_Click(object sender, EventArgs e)
    {
        void UploadFileLog(string name)
        {
            _logger.Write(LogLevel.Info, -2, $"Uploading file '{name}'");
            SetLogList();
        }
        var dialog = new DialogUpload();
        if (DialogResult.OK == dialog.ShowDialog())
        {
            var filename = dialog.Filename;
            var content = dialog.FileContent;

            var multiFiles = dialog.Filenames;

            if (multiFiles.Length == 0)
            {
                var file = new BatchFile()
                {
                    display_name = filename,
                    text = content,
                    created_at = DateTime.UtcNow,
                };
                new BatchFileAppController(file).Create();
                _batchFileList.Add(file);
                // workaround: as suggested by this stackoverflow link: 
                // https://stackoverflow.com/a/44749284
                listFiles.SelectedIndex = -1;
                listFiles.SelectedItem = file;
                UploadFileLog(filename);
            }
            else
            {
                _logger.Write(LogLevel.Info, -1, $"Uploading {multiFiles.Length} files ...");
                foreach (var file in multiFiles)
                {
                    var name = Path.GetFileNameWithoutExtension(file);
                    var f = new BatchFile()
                    {
                        display_name = name,
                        text = System.IO.File.ReadAllText(file, Encoding.UTF8),
                        created_at = DateTime.UtcNow,
                    };
                    new BatchFileAppController(f).Create();
                    _batchFileList.Add(f);
                    listFiles.SelectedIndex = -1;
                    listFiles.SelectedItem = f;
                    UploadFileLog(name);
                }
                _logger.Write(LogLevel.Info, -1, "Upload complete.");
                SetLogList();
            }
        }
    }

    private void btnAddNewFile_Click(object sender, EventArgs e)
    {

        var dialog = new DialogNewFile();
        if (DialogResult.OK == dialog.ShowDialog())
        {
            var file = new BatchFile()
            {
                display_name = dialog.Filename,
                text = dialog.FileContent,
                created_at = DateTime.UtcNow,
            };
            new BatchFileAppController(file).Create();
            _batchFileList.Add(file);
            // workaround for initial loading: as suggested by this stackoverflow link: 
            // https://stackoverflow.com/a/44749284
            listFiles.SelectedIndex = -1;
            listFiles.SelectedItem = file;

            _logger.Write(LogLevel.Info, -2, $"Create a new file '{file.display_name}'");
            SetLogList();
        }
    }

    private void btnAppSettings_Click(object sender, EventArgs e)
    {
        var dialog = new DialogBase("App settings");
        dialog.ShowDialog();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void btnDeleteDB_Click(object sender, EventArgs e)
    {
        AppControllerBase.DeleteDatabase();
    }

    private void btnCreateDB_Click(object sender, EventArgs e)
    {
        AppControllerBase.CreateDatabase();

    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _logger.Write(LogLevel.Info, -1, "App exited");
    }
}