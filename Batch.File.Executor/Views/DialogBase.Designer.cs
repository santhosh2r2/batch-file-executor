namespace Batch.File.Executor.Views
{
    partial class DialogBase
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
            panelTitlebar.SuspendLayout();
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
            lblPopupTitle.Size = new Size(96, 19);
            lblPopupTitle.TabIndex = 12;
            lblPopupTitle.Text = "Popup Title";
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
            // DialogNewFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(548, 573);
            Controls.Add(panelTitlebar);
            Name = "DialogNewFile";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Paint += PopupDialog_Paint;
            panelTitlebar.ResumeLayout(false);
            panelTitlebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private Label lblPopupTitle;
        private Panel panelTitlebar;
    }
}
