namespace Batch.File.Executor.UserControls
{
    partial class MainView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainerMainView = new SplitContainer();
            btnBatchFilesettings = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnPlay = new FontAwesome.Sharp.IconButton();
            btnFileSettings = new FontAwesome.Sharp.IconButton();
            btnDeleteFile = new FontAwesome.Sharp.IconButton();
            btnExecute = new FontAwesome.Sharp.IconButton();
            lblFilename = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainerMainView).BeginInit();
            splitContainerMainView.Panel1.SuspendLayout();
            splitContainerMainView.Panel2.SuspendLayout();
            splitContainerMainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // splitContainerMainView
            // 
            splitContainerMainView.Dock = DockStyle.Fill;
            splitContainerMainView.FixedPanel = FixedPanel.Panel1;
            splitContainerMainView.IsSplitterFixed = true;
            splitContainerMainView.Location = new Point(0, 0);
            splitContainerMainView.Name = "splitContainerMainView";
            splitContainerMainView.Orientation = Orientation.Horizontal;
            // 
            // splitContainerMainView.Panel1
            // 
            splitContainerMainView.Panel1.Controls.Add(btnBatchFilesettings);
            splitContainerMainView.Panel1.Controls.Add(btnDelete);
            splitContainerMainView.Panel1.Controls.Add(btnPlay);
            splitContainerMainView.Panel1.Controls.Add(btnFileSettings);
            splitContainerMainView.Panel1.Controls.Add(btnDeleteFile);
            splitContainerMainView.Panel1.Controls.Add(btnExecute);
            splitContainerMainView.Panel1.Controls.Add(lblFilename);
            // 
            // splitContainerMainView.Panel2
            // 
            splitContainerMainView.Panel2.Controls.Add(webView21);
            splitContainerMainView.Panel2.Padding = new Padding(20, 0, 20, 20);
            splitContainerMainView.Size = new Size(1024, 681);
            splitContainerMainView.SplitterDistance = 72;
            splitContainerMainView.TabIndex = 5;
            // 
            // btnBatchFilesettings
            // 
            btnBatchFilesettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBatchFilesettings.BackColor = Color.White;
            btnBatchFilesettings.FlatAppearance.BorderColor = Color.White;
            btnBatchFilesettings.FlatStyle = FlatStyle.Flat;
            btnBatchFilesettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnBatchFilesettings.IconColor = Color.Gray;
            btnBatchFilesettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBatchFilesettings.IconSize = 32;
            btnBatchFilesettings.Location = new Point(848, 13);
            btnBatchFilesettings.Name = "btnBatchFilesettings";
            btnBatchFilesettings.Size = new Size(43, 48);
            btnBatchFilesettings.TabIndex = 8;
            btnBatchFilesettings.UseVisualStyleBackColor = false;
            btnBatchFilesettings.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDelete.IconColor = Color.FromArgb(192, 0, 0);
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 32;
            btnDelete.Location = new Point(961, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(43, 48);
            btnDelete.TabIndex = 7;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPlay.BackColor = Color.White;
            btnPlay.FlatAppearance.BorderColor = Color.White;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            btnPlay.IconColor = Color.FromArgb(0, 192, 0);
            btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPlay.IconSize = 32;
            btnPlay.Location = new Point(904, 13);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(43, 48);
            btnPlay.TabIndex = 6;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnFileSettings
            // 
            btnFileSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFileSettings.BackColor = Color.White;
            btnFileSettings.FlatAppearance.BorderColor = Color.White;
            btnFileSettings.FlatStyle = FlatStyle.Flat;
            btnFileSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnFileSettings.IconColor = Color.Gray;
            btnFileSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFileSettings.IconSize = 32;
            btnFileSettings.Location = new Point(1673, 12);
            btnFileSettings.Name = "btnFileSettings";
            btnFileSettings.Size = new Size(43, 48);
            btnFileSettings.TabIndex = 5;
            btnFileSettings.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteFile.BackColor = Color.White;
            btnDeleteFile.FlatAppearance.BorderColor = Color.White;
            btnDeleteFile.FlatStyle = FlatStyle.Flat;
            btnDeleteFile.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDeleteFile.IconColor = Color.FromArgb(192, 0, 0);
            btnDeleteFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteFile.IconSize = 32;
            btnDeleteFile.Location = new Point(1620, 12);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(43, 48);
            btnDeleteFile.TabIndex = 4;
            btnDeleteFile.UseVisualStyleBackColor = false;
            // 
            // btnExecute
            // 
            btnExecute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExecute.BackColor = Color.White;
            btnExecute.FlatAppearance.BorderColor = Color.White;
            btnExecute.FlatStyle = FlatStyle.Flat;
            btnExecute.IconChar = FontAwesome.Sharp.IconChar.Play;
            btnExecute.IconColor = Color.FromArgb(0, 192, 0);
            btnExecute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExecute.IconSize = 32;
            btnExecute.Location = new Point(1567, 12);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(43, 48);
            btnExecute.TabIndex = 3;
            btnExecute.UseVisualStyleBackColor = false;
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilename.Location = new Point(21, 25);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(141, 29);
            lblFilename.TabIndex = 2;
            lblFilename.Text = "Batch file 2";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(20, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(984, 585);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerMainView);
            Name = "MainView";
            Size = new Size(1024, 681);
            splitContainerMainView.Panel1.ResumeLayout(false);
            splitContainerMainView.Panel1.PerformLayout();
            splitContainerMainView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMainView).EndInit();
            splitContainerMainView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerMainView;
        private FontAwesome.Sharp.IconButton btnFileSettings;
        private FontAwesome.Sharp.IconButton btnDeleteFile;
        private FontAwesome.Sharp.IconButton btnExecute;
        private Label lblFilename;
        private FontAwesome.Sharp.IconButton btnBatchFilesettings;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnPlay;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
