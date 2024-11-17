using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;

namespace Batch.File.Executor.Views;

public partial class DialogUpload : Form
{
    public string Filename = "";
    public string FileContent = "";
    public string[] Filenames = [];

    private int borderRadius = 10;
    private int borderSize = 2;
    private Color borderColor = Color.White;

    private Color titlebarColor = Color.FromArgb(235, 235, 235);
    private Color containerColor = Color.FromArgb(196, 196, 196);


    private static void SetIconColors(Button control, Color color)
    {
        control.BackColor = color;
        control.FlatAppearance.BorderColor = color;
    }
    private void CheckIfSavingIsPossible()
    {
        var filename = txtFilename.Text;
        var content = txtContent.Text;
        var canSave = !string.IsNullOrEmpty(filename) && !string.IsNullOrEmpty(content);

        btnSave.Enabled = canSave;
        if (!canSave)
        {
            btnSave.BackColor = Color.DarkGray;
            btnSave.FlatAppearance.BorderColor = Color.DarkGray;
            btnSave.ForeColor = Color.LightGray;
        }
        else
        {
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSave.ForeColor = Color.White;
        }

    }


    public DialogUpload()
    {
        InitializeComponent();
        FormBorderStyle = FormBorderStyle.None;
        BackColor = containerColor;
        panelTitlebar.BackColor = titlebarColor;
        SetIconColors(btnClose, titlebarColor);

        CheckIfSavingIsPossible();
    }


    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
            return cp;
        }
    }


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

    private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
    {
        using GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius);
        using Pen penBorder = new(borderColor, 1);
        graph.SmoothingMode = SmoothingMode.AntiAlias;
        control.Region = new Region(roundPath);
        graph.DrawPath(penBorder, roundPath);
    }

    private void PopupDialog_Paint(object sender, PaintEventArgs e)
    {
        ControlRegionAndBorder(this, borderRadius - (borderSize / 2), e.Graphics, borderColor);

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Hide();
    }


    private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Filename = txtFilename.Text;
        FileContent = txtContent.Text;
    }



    private void txtFilename_TextChanged(object sender, EventArgs e)
    {
        CheckIfSavingIsPossible();

    }

    private void txtContent_TextChanged(object sender, EventArgs e)
    {
        CheckIfSavingIsPossible();
    }

    private void btnOpenFile_Click(object sender, EventArgs e)
    {
        var openDialog = new OpenFileDialog()
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            Filter = "Batch files|*.bat",
            Multiselect = true,

        };

        var result = openDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            if (openDialog.FileNames.Length > 1)
            {
                Filenames = openDialog.FileNames;

                txtFilename.Text = $"Selected '{Filenames.Length}' files";
                txtContent.Text = string.Join(Environment.NewLine, Filenames.Select(Path.GetFileNameWithoutExtension).ToList());
            }
            else
            {
                txtFilename.Text = Path.GetFileNameWithoutExtension(openDialog.FileName);
                txtContent.Text = System.IO.File.ReadAllText(openDialog.FileName, Encoding.UTF8);
                Filenames = [];
            }
        }
        CheckIfSavingIsPossible();
    }
}