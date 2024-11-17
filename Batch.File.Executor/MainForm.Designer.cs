namespace Batch.File.Executor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelContainer = new Panel();
            panelLogs = new Panel();
            listLogs = new ListBox();
            panelMainView = new Panel();
            panelSidebar = new Panel();
            splitContainerSidebar = new SplitContainer();
            btnUploadFile = new FontAwesome.Sharp.IconButton();
            lblSidebarDivider = new Label();
            btnAddNewFile = new FontAwesome.Sharp.IconButton();
            btnAppSettings = new FontAwesome.Sharp.IconButton();
            listFiles = new ListBox();
            labelSidebar = new Label();
            panelTitleBar = new Panel();
            btnCreateDB = new Button();
            btnDeleteDB = new Button();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnAbout = new FontAwesome.Sharp.IconButton();
            labelTitle = new Label();
            panelContainer.SuspendLayout();
            panelLogs.SuspendLayout();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerSidebar).BeginInit();
            splitContainerSidebar.Panel1.SuspendLayout();
            splitContainerSidebar.Panel2.SuspendLayout();
            splitContainerSidebar.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(panelLogs);
            panelContainer.Controls.Add(panelMainView);
            panelContainer.Controls.Add(panelSidebar);
            panelContainer.Controls.Add(panelTitleBar);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1264, 681);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // panelLogs
            // 
            panelLogs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLogs.BackColor = Color.White;
            panelLogs.Controls.Add(listLogs);
            panelLogs.Location = new Point(12, 530);
            panelLogs.Name = "panelLogs";
            panelLogs.Padding = new Padding(20);
            panelLogs.Size = new Size(1240, 139);
            panelLogs.TabIndex = 5;
            panelLogs.Paint += panelLogs_Paint;
            // 
            // listLogs
            // 
            listLogs.BorderStyle = BorderStyle.None;
            listLogs.Dock = DockStyle.Fill;
            listLogs.Font = new Font("Courier New", 9.75F);
            listLogs.FormattingEnabled = true;
            listLogs.Items.AddRange(new object[] { "2024-08-18 18:00:01.785 - Execution of 'Batch file 2' complete", "", "2024-08-18 18:00:00.245 - Execution of 'Batch file 2' started" });
            listLogs.Location = new Point(20, 20);
            listLogs.Name = "listLogs";
            listLogs.SelectionMode = SelectionMode.None;
            listLogs.Size = new Size(1200, 99);
            listLogs.TabIndex = 5;
            listLogs.TabStop = false;
            listLogs.UseTabStops = false;
            // 
            // panelMainView
            // 
            panelMainView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMainView.BackColor = Color.White;
            panelMainView.Location = new Point(398, 48);
            panelMainView.Name = "panelMainView";
            panelMainView.Size = new Size(854, 465);
            panelMainView.TabIndex = 4;
            panelMainView.Paint += panelMainView_Paint;
            // 
            // panelSidebar
            // 
            panelSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSidebar.Controls.Add(splitContainerSidebar);
            panelSidebar.Controls.Add(labelSidebar);
            panelSidebar.Location = new Point(12, 48);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(374, 465);
            panelSidebar.TabIndex = 3;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // splitContainerSidebar
            // 
            splitContainerSidebar.Dock = DockStyle.Fill;
            splitContainerSidebar.FixedPanel = FixedPanel.Panel1;
            splitContainerSidebar.Location = new Point(0, 0);
            splitContainerSidebar.Name = "splitContainerSidebar";
            splitContainerSidebar.Orientation = Orientation.Horizontal;
            // 
            // splitContainerSidebar.Panel1
            // 
            splitContainerSidebar.Panel1.Controls.Add(btnUploadFile);
            splitContainerSidebar.Panel1.Controls.Add(lblSidebarDivider);
            splitContainerSidebar.Panel1.Controls.Add(btnAddNewFile);
            splitContainerSidebar.Panel1.Controls.Add(btnAppSettings);
            // 
            // splitContainerSidebar.Panel2
            // 
            splitContainerSidebar.Panel2.Controls.Add(listFiles);
            splitContainerSidebar.Panel2.Padding = new Padding(20, 0, 20, 20);
            splitContainerSidebar.Size = new Size(374, 465);
            splitContainerSidebar.SplitterDistance = 94;
            splitContainerSidebar.TabIndex = 5;
            splitContainerSidebar.Paint += splitContainerSidebar_Paint;
            // 
            // btnUploadFile
            // 
            btnUploadFile.BackColor = Color.White;
            btnUploadFile.FlatAppearance.BorderColor = Color.White;
            btnUploadFile.FlatStyle = FlatStyle.Flat;
            btnUploadFile.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnUploadFile.IconColor = Color.DimGray;
            btnUploadFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUploadFile.IconSize = 32;
            btnUploadFile.Location = new Point(63, 15);
            btnUploadFile.Name = "btnUploadFile";
            btnUploadFile.Size = new Size(43, 48);
            btnUploadFile.TabIndex = 2;
            btnUploadFile.UseVisualStyleBackColor = false;
            btnUploadFile.Click += btnUploadFile_Click;
            // 
            // lblSidebarDivider
            // 
            lblSidebarDivider.BorderStyle = BorderStyle.Fixed3D;
            lblSidebarDivider.Location = new Point(18, 72);
            lblSidebarDivider.Name = "lblSidebarDivider";
            lblSidebarDivider.Size = new Size(339, 2);
            lblSidebarDivider.TabIndex = 4;
            // 
            // btnAddNewFile
            // 
            btnAddNewFile.BackColor = Color.White;
            btnAddNewFile.FlatAppearance.BorderColor = Color.White;
            btnAddNewFile.FlatStyle = FlatStyle.Flat;
            btnAddNewFile.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAddNewFile.IconColor = Color.DimGray;
            btnAddNewFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNewFile.IconSize = 32;
            btnAddNewFile.Location = new Point(14, 15);
            btnAddNewFile.Name = "btnAddNewFile";
            btnAddNewFile.Size = new Size(43, 48);
            btnAddNewFile.TabIndex = 1;
            btnAddNewFile.UseVisualStyleBackColor = false;
            btnAddNewFile.Click += btnAddNewFile_Click;
            // 
            // btnAppSettings
            // 
            btnAppSettings.BackColor = Color.White;
            btnAppSettings.FlatAppearance.BorderColor = Color.White;
            btnAppSettings.FlatStyle = FlatStyle.Flat;
            btnAppSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnAppSettings.IconColor = Color.DimGray;
            btnAppSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAppSettings.IconSize = 32;
            btnAppSettings.Location = new Point(316, 15);
            btnAppSettings.Name = "btnAppSettings";
            btnAppSettings.Size = new Size(43, 48);
            btnAppSettings.TabIndex = 3;
            btnAppSettings.UseVisualStyleBackColor = false;
            btnAppSettings.Visible = false;
            btnAppSettings.Click += btnAppSettings_Click;
            // 
            // listFiles
            // 
            listFiles.BorderStyle = BorderStyle.None;
            listFiles.Dock = DockStyle.Fill;
            listFiles.FormattingEnabled = true;
            listFiles.ItemHeight = 20;
            listFiles.Location = new Point(20, 0);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(334, 347);
            listFiles.TabIndex = 0;
            listFiles.SelectedIndexChanged += listFiles_SelectedIndexChanged;
            // 
            // labelSidebar
            // 
            labelSidebar.AutoSize = true;
            labelSidebar.Location = new Point(159, 202);
            labelSidebar.Name = "labelSidebar";
            labelSidebar.Size = new Size(54, 20);
            labelSidebar.TabIndex = 0;
            labelSidebar.Text = "sidebar";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(btnCreateDB);
            panelTitleBar.Controls.Add(btnDeleteDB);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnAbout);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.ForeColor = SystemColors.ControlDarkDark;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1264, 50);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnCreateDB
            // 
            btnCreateDB.Location = new Point(266, 7);
            btnCreateDB.Name = "btnCreateDB";
            btnCreateDB.Size = new Size(152, 35);
            btnCreateDB.TabIndex = 13;
            btnCreateDB.Text = "Create Database";
            btnCreateDB.UseVisualStyleBackColor = true;
            btnCreateDB.Visible = false;
            btnCreateDB.Click += btnCreateDB_Click;
            // 
            // btnDeleteDB
            // 
            btnDeleteDB.Location = new Point(424, 7);
            btnDeleteDB.Name = "btnDeleteDB";
            btnDeleteDB.Size = new Size(152, 35);
            btnDeleteDB.TabIndex = 12;
            btnDeleteDB.Text = "Delete Database";
            btnDeleteDB.UseVisualStyleBackColor = true;
            btnDeleteDB.Visible = false;
            btnDeleteDB.Click += btnDeleteDB_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.White;
            btnMinimize.FlatAppearance.BorderColor = Color.White;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gray;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 24;
            btnMinimize.Location = new Point(1132, 8);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(36, 34);
            btnMinimize.TabIndex = 11;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.Gray;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 24;
            btnClose.Location = new Point(1216, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 34);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.White;
            btnMaximize.FlatAppearance.BorderColor = Color.White;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMaximize.IconColor = Color.Gray;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 24;
            btnMaximize.Location = new Point(1174, 8);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(36, 34);
            btnMaximize.TabIndex = 9;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click_1;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.White;
            btnAbout.FlatAppearance.BorderColor = Color.White;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnAbout.IconColor = Color.DimGray;
            btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbout.IconSize = 24;
            btnAbout.Location = new Point(190, 8);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(36, 34);
            btnAbout.TabIndex = 8;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Visible = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ActiveCaptionText;
            labelTitle.Location = new Point(9, 13);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(183, 22);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "Batch file executor";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContainer);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch File (.bat) Executor";
            Activated += MainForm_Activated;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ResizeEnd += MainForm_ResizeEnd;
            SizeChanged += MainForm_SizeChanged;
            Paint += MainForm_Paint;
            MouseDown += MainForm_MouseDown;
            Resize += MainForm_Resize;
            panelContainer.ResumeLayout(false);
            panelLogs.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            splitContainerSidebar.Panel1.ResumeLayout(false);
            splitContainerSidebar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerSidebar).EndInit();
            splitContainerSidebar.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContainer;
        private Panel panelTitleBar;
        private Label labelTitle;
        private Panel panelSidebar;
        private Panel panelLogs;
        private Panel panelMainView;
        private Label labelSidebar;
        private FontAwesome.Sharp.IconButton btnAddNewFile;
        private FontAwesome.Sharp.IconButton btnAppSettings;
        private FontAwesome.Sharp.IconButton btnUploadFile;
        private Label lblSidebarDivider;
        private SplitContainer splitContainerSidebar;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private ListBox listFiles;
        private Button btnDeleteDB;
        private Button btnCreateDB;
        private ListBox listLogs;
    }
}
