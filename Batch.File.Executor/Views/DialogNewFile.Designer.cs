namespace Batch.File.Executor.Views
{
    partial class DialogNewFile
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
            btnClose = new FontAwesome.Sharp.IconButton();
            lblPopupTitle = new Label();
            panelTitlebar = new Panel();
            label1 = new Label();
            txtFilename = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            btnSave = new FontAwesome.Sharp.IconButton();
            txtContent = new RichTextBox();
            panelTitlebar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            btnClose.Location = new Point(500, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 34);
            btnClose.TabIndex = 11;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPopupTitle
            // 
            lblPopupTitle.AutoSize = true;
            lblPopupTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPopupTitle.Location = new Point(18, 17);
            lblPopupTitle.Name = "lblPopupTitle";
            lblPopupTitle.Size = new Size(102, 19);
            lblPopupTitle.TabIndex = 12;
            lblPopupTitle.Text = "Add new file";
            // 
            // panelTitlebar
            // 
            panelTitlebar.Controls.Add(lblPopupTitle);
            panelTitlebar.Controls.Add(btnClose);
            panelTitlebar.Dock = DockStyle.Top;
            panelTitlebar.Location = new Point(0, 0);
            panelTitlebar.Name = "panelTitlebar";
            panelTitlebar.Size = new Size(548, 53);
            panelTitlebar.TabIndex = 13;
            panelTitlebar.MouseDown += panelTitlebar_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 0, 0);
            label1.Size = new Size(179, 42);
            label1.TabIndex = 14;
            label1.Text = "Filename";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFilename
            // 
            txtFilename.Font = new Font("Arial", 12F);
            txtFilename.Location = new Point(182, 3);
            txtFilename.MaxLength = 32;
            txtFilename.Multiline = true;
            txtFilename.Name = "txtFilename";
            txtFilename.PlaceholderText = "Enter filename";
            txtFilename.Size = new Size(339, 34);
            txtFilename.TabIndex = 15;
            txtFilename.TextChanged += txtFilename_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.30657F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.69343F));
            tableLayoutPanel1.Controls.Add(btnCancel, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 2);
            tableLayoutPanel1.Controls.Add(txtFilename, 1, 0);
            tableLayoutPanel1.Controls.Add(txtContent, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.633027F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.3669739F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(524, 492);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.DimGray;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 32;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(0, 439);
            btnCancel.Margin = new Padding(0, 3, 0, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(179, 47);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Padding = new Padding(15, 15, 0, 0);
            label2.Size = new Size(173, 394);
            label2.TabIndex = 16;
            label2.Text = "Content";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 32;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(182, 439);
            btnSave.Margin = new Padding(0, 3, 0, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(342, 47);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContent.Location = new Point(182, 45);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(339, 378);
            txtContent.TabIndex = 20;
            txtContent.Text = "@echo off \necho \"Hello world\"\npause";
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // DialogNewFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(548, 576);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelTitlebar);
            Name = "DialogNewFile";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Paint += PopupDialog_Paint;
            panelTitlebar.ResumeLayout(false);
            panelTitlebar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private Label lblPopupTitle;
        private Panel panelTitlebar;
        private Label label1;
        private TextBox txtFilename;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private RichTextBox txtContent;
    }
}
