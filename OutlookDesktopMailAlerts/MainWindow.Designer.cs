namespace OutlookDesktopMailAlerts
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            notifyIconODMA = new NotifyIcon(components);
            contextMenuODMA = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            widgetToolStripMenuItem = new ToolStripMenuItem();
            widgetHideShowToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panelFolders = new Panel();
            labelUnreadFolders = new Label();
            label1 = new Label();
            panelInbox = new Panel();
            labelUnreadInbox = new Label();
            label4 = new Label();
            labelNewMailItems = new Label();
            labelNewMail = new Label();
            labelUnreadTitle = new Label();
            panelMain = new Panel();
            pictureBoxLogo = new PictureBox();
            panelNew = new Panel();
            label2 = new Label();
            toolTipLogo = new ToolTip(components);
            toolTipNewMail = new ToolTip(components);
            toolTipUnreadInbox = new ToolTip(components);
            toolTipUnreadFolders = new ToolTip(components);
            contextMenuODMA.SuspendLayout();
            panelFolders.SuspendLayout();
            panelInbox.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelNew.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIconODMA
            // 
            notifyIconODMA.ContextMenuStrip = contextMenuODMA;
            notifyIconODMA.Icon = (Icon)resources.GetObject("notifyIconODMA.Icon");
            notifyIconODMA.Text = "Outlook Desktop Mail Alerts";
            notifyIconODMA.Visible = true;
            // 
            // contextMenuODMA
            // 
            contextMenuODMA.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, widgetToolStripMenuItem, exitToolStripMenuItem });
            contextMenuODMA.Name = "contextMenuStrip1";
            contextMenuODMA.Size = new Size(117, 70);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // widgetToolStripMenuItem
            // 
            widgetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { widgetHideShowToolStripMenuItem });
            widgetToolStripMenuItem.Name = "widgetToolStripMenuItem";
            widgetToolStripMenuItem.Size = new Size(116, 22);
            widgetToolStripMenuItem.Text = "Widget";
            // 
            // widgetHideShowToolStripMenuItem
            // 
            widgetHideShowToolStripMenuItem.Name = "widgetHideShowToolStripMenuItem";
            widgetHideShowToolStripMenuItem.Size = new Size(99, 22);
            widgetHideShowToolStripMenuItem.Text = "Hide";
            widgetHideShowToolStripMenuItem.Click += widgetHideShowToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panelFolders
            // 
            panelFolders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelFolders.BackColor = Color.Transparent;
            panelFolders.BackgroundImage = Properties.Resources.panel_default_64;
            panelFolders.BackgroundImageLayout = ImageLayout.Stretch;
            panelFolders.Controls.Add(labelUnreadFolders);
            panelFolders.Location = new Point(192, 31);
            panelFolders.Name = "panelFolders";
            panelFolders.Size = new Size(51, 20);
            panelFolders.TabIndex = 4;
            // 
            // labelUnreadFolders
            // 
            labelUnreadFolders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUnreadFolders.BackColor = Color.Transparent;
            labelUnreadFolders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelUnreadFolders.ForeColor = Color.White;
            labelUnreadFolders.Location = new Point(2, 2);
            labelUnreadFolders.Name = "labelUnreadFolders";
            labelUnreadFolders.Size = new Size(47, 15);
            labelUnreadFolders.TabIndex = 1;
            labelUnreadFolders.Text = "999";
            labelUnreadFolders.TextAlign = ContentAlignment.MiddleCenter;
            labelUnreadFolders.Click += labelUnreadFolders_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(196, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Folders";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelInbox
            // 
            panelInbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelInbox.BackColor = Color.Transparent;
            panelInbox.BackgroundImage = Properties.Resources.panel_default_64;
            panelInbox.BackgroundImageLayout = ImageLayout.Stretch;
            panelInbox.Controls.Add(labelUnreadInbox);
            panelInbox.Location = new Point(135, 31);
            panelInbox.Name = "panelInbox";
            panelInbox.Size = new Size(51, 20);
            panelInbox.TabIndex = 6;
            // 
            // labelUnreadInbox
            // 
            labelUnreadInbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUnreadInbox.BackColor = Color.Transparent;
            labelUnreadInbox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelUnreadInbox.ForeColor = Color.White;
            labelUnreadInbox.Location = new Point(2, 2);
            labelUnreadInbox.Name = "labelUnreadInbox";
            labelUnreadInbox.Size = new Size(47, 15);
            labelUnreadInbox.TabIndex = 1;
            labelUnreadInbox.Text = "888";
            labelUnreadInbox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(144, 15);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "Inbox";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNewMailItems
            // 
            labelNewMailItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewMailItems.ForeColor = Color.White;
            labelNewMailItems.Location = new Point(3, 3);
            labelNewMailItems.Name = "labelNewMailItems";
            labelNewMailItems.Size = new Size(47, 28);
            labelNewMailItems.TabIndex = 2;
            labelNewMailItems.Text = "...";
            labelNewMailItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNewMail
            // 
            labelNewMail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNewMail.AutoSize = true;
            labelNewMail.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            labelNewMail.ForeColor = Color.White;
            labelNewMail.Location = new Point(79, 2);
            labelNewMail.Name = "labelNewMail";
            labelNewMail.Size = new Size(48, 15);
            labelNewMail.TabIndex = 7;
            labelNewMail.Text = "New Mail";
            labelNewMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUnreadTitle
            // 
            labelUnreadTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUnreadTitle.AutoSize = true;
            labelUnreadTitle.BackColor = Color.Transparent;
            labelUnreadTitle.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            labelUnreadTitle.ForeColor = Color.White;
            labelUnreadTitle.Location = new Point(165, 2);
            labelUnreadTitle.Name = "labelUnreadTitle";
            labelUnreadTitle.Size = new Size(40, 15);
            labelUnreadTitle.TabIndex = 8;
            labelUnreadTitle.Text = "Unread";
            labelUnreadTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.FromArgb(32, 32, 32);
            panelMain.Controls.Add(pictureBoxLogo);
            panelMain.Controls.Add(panelNew);
            panelMain.Controls.Add(labelUnreadTitle);
            panelMain.Controls.Add(labelNewMail);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(panelFolders);
            panelMain.Controls.Add(panelInbox);
            panelMain.Controls.Add(label4);
            panelMain.Location = new Point(3, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(253, 57);
            panelMain.TabIndex = 9;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.odma_icon_default;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogo.Location = new Point(15, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(45, 45);
            pictureBoxLogo.TabIndex = 10;
            pictureBoxLogo.TabStop = false;
            // 
            // panelNew
            // 
            panelNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNew.BackColor = Color.Transparent;
            panelNew.BackgroundImage = Properties.Resources.panel_default_64;
            panelNew.BackgroundImageLayout = ImageLayout.Stretch;
            panelNew.Controls.Add(label2);
            panelNew.Controls.Add(labelNewMailItems);
            panelNew.Location = new Point(78, 18);
            panelNew.Name = "panelNew";
            panelNew.Size = new Size(51, 33);
            panelNew.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 2);
            label2.Name = "label2";
            label2.Size = new Size(0, 13);
            label2.TabIndex = 1;
            label2.Text = "888";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolTipLogo
            // 
            toolTipLogo.AutoPopDelay = 5000;
            toolTipLogo.InitialDelay = 50;
            toolTipLogo.ReshowDelay = 100;
            toolTipLogo.ToolTipTitle = "Title goes here";
            // 
            // toolTipNewMail
            // 
            toolTipNewMail.AutoPopDelay = 5000;
            toolTipNewMail.InitialDelay = 50;
            toolTipNewMail.ReshowDelay = 100;
            toolTipNewMail.ToolTipTitle = "Title goe here";
            // 
            // toolTipUnreadInbox
            // 
            toolTipUnreadInbox.AutoPopDelay = 5000;
            toolTipUnreadInbox.InitialDelay = 50;
            toolTipUnreadInbox.ReshowDelay = 100;
            toolTipUnreadInbox.ToolTipTitle = "Title goes here";
            // 
            // toolTipUnreadFolders
            // 
            toolTipUnreadFolders.AutoPopDelay = 5000;
            toolTipUnreadFolders.InitialDelay = 50;
            toolTipUnreadFolders.ReshowDelay = 100;
            toolTipUnreadFolders.ToolTipTitle = "TItle goes here";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 61);
            ClientSize = new Size(260, 64);
            ContextMenuStrip = contextMenuODMA;
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Opacity = 0.95D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Window title";
            TopMost = true;
            contextMenuODMA.ResumeLayout(false);
            panelFolders.ResumeLayout(false);
            panelInbox.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelNew.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIconODMA;
        private Panel panelFolders;
        private Label labelUnreadFolders;
        private Label label1;
        private Panel panelInbox;
        private Label labelUnreadInbox;
        private Label label4;
        private ContextMenuStrip contextMenuODMA;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label labelNewMailItems;
        private Label labelNewMail;
        private Label labelUnreadTitle;
        private Panel panelMain;
        private Panel panelNew;
        private Label label2;
        private PictureBox pictureBoxLogo;
        private ToolTip toolTipLogo;
        private ToolTip toolTipNewMail;
        private ToolTip toolTipUnreadInbox;
        private ToolTip toolTipUnreadFolders;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem widgetToolStripMenuItem;
        private ToolStripMenuItem widgetHideShowToolStripMenuItem;
    }
}
