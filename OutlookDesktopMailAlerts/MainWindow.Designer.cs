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
            labelTitleFolders = new Label();
            labelUnreadFolders = new Label();
            panelInbox = new Panel();
            labelTitleInbox = new Label();
            labelUnreadInbox = new Label();
            labelNewMailItems = new Label();
            labelNewMail = new Label();
            labelUnreadTitle = new Label();
            panelMain = new Panel();
            buttonDockRight = new PictureBox();
            buttonDockLeft = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)buttonDockRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonDockLeft).BeginInit();
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
            panelFolders.Controls.Add(labelTitleFolders);
            panelFolders.Controls.Add(labelUnreadFolders);
            panelFolders.Location = new Point(184, 18);
            panelFolders.Name = "panelFolders";
            panelFolders.Size = new Size(51, 33);
            panelFolders.TabIndex = 4;
            panelFolders.Click += boxFolders_Click;
            // 
            // labelTitleFolders
            // 
            labelTitleFolders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTitleFolders.AutoSize = true;
            labelTitleFolders.BackColor = Color.Transparent;
            labelTitleFolders.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleFolders.ForeColor = Color.White;
            labelTitleFolders.Location = new Point(6, 1);
            labelTitleFolders.Name = "labelTitleFolders";
            labelTitleFolders.Size = new Size(38, 12);
            labelTitleFolders.TabIndex = 7;
            labelTitleFolders.Text = "Folders";
            labelTitleFolders.TextAlign = ContentAlignment.MiddleCenter;
            labelTitleFolders.Click += boxFolders_Click;
            // 
            // labelUnreadFolders
            // 
            labelUnreadFolders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUnreadFolders.BackColor = Color.Transparent;
            labelUnreadFolders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelUnreadFolders.ForeColor = Color.White;
            labelUnreadFolders.Location = new Point(2, 12);
            labelUnreadFolders.Name = "labelUnreadFolders";
            labelUnreadFolders.Size = new Size(47, 18);
            labelUnreadFolders.TabIndex = 1;
            labelUnreadFolders.Text = "999";
            labelUnreadFolders.TextAlign = ContentAlignment.MiddleCenter;
            labelUnreadFolders.Click += boxFolders_Click;
            // 
            // panelInbox
            // 
            panelInbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelInbox.BackColor = Color.Transparent;
            panelInbox.BackgroundImage = Properties.Resources.panel_default_64;
            panelInbox.BackgroundImageLayout = ImageLayout.Stretch;
            panelInbox.Controls.Add(labelTitleInbox);
            panelInbox.Controls.Add(labelUnreadInbox);
            panelInbox.Location = new Point(127, 18);
            panelInbox.Name = "panelInbox";
            panelInbox.Size = new Size(51, 33);
            panelInbox.TabIndex = 6;
            panelInbox.Click += boxInbox_Click;
            // 
            // labelTitleInbox
            // 
            labelTitleInbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTitleInbox.AutoSize = true;
            labelTitleInbox.BackColor = Color.Transparent;
            labelTitleInbox.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleInbox.ForeColor = Color.White;
            labelTitleInbox.Location = new Point(10, 1);
            labelTitleInbox.Name = "labelTitleInbox";
            labelTitleInbox.Size = new Size(30, 12);
            labelTitleInbox.TabIndex = 6;
            labelTitleInbox.Text = "Inbox";
            labelTitleInbox.TextAlign = ContentAlignment.MiddleCenter;
            labelTitleInbox.Click += boxInbox_Click;
            // 
            // labelUnreadInbox
            // 
            labelUnreadInbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUnreadInbox.BackColor = Color.Transparent;
            labelUnreadInbox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelUnreadInbox.ForeColor = Color.White;
            labelUnreadInbox.Location = new Point(2, 12);
            labelUnreadInbox.Name = "labelUnreadInbox";
            labelUnreadInbox.Size = new Size(47, 18);
            labelUnreadInbox.TabIndex = 1;
            labelUnreadInbox.Text = "888";
            labelUnreadInbox.TextAlign = ContentAlignment.MiddleCenter;
            labelUnreadInbox.Click += boxInbox_Click;
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
            labelNewMail.BackColor = Color.Transparent;
            labelNewMail.Font = new Font("Gadugi", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewMail.ForeColor = Color.White;
            labelNewMail.Location = new Point(72, 3);
            labelNewMail.Name = "labelNewMail";
            labelNewMail.Size = new Size(46, 12);
            labelNewMail.TabIndex = 7;
            labelNewMail.Text = "New Mail";
            labelNewMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUnreadTitle
            // 
            labelUnreadTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUnreadTitle.AutoSize = true;
            labelUnreadTitle.BackColor = Color.Transparent;
            labelUnreadTitle.Font = new Font("Gadugi", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUnreadTitle.ForeColor = Color.White;
            labelUnreadTitle.Location = new Point(162, 3);
            labelUnreadTitle.Name = "labelUnreadTitle";
            labelUnreadTitle.Size = new Size(37, 12);
            labelUnreadTitle.TabIndex = 8;
            labelUnreadTitle.Text = "Unread";
            labelUnreadTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.FromArgb(32, 32, 32);
            panelMain.Controls.Add(buttonDockRight);
            panelMain.Controls.Add(buttonDockLeft);
            panelMain.Controls.Add(pictureBoxLogo);
            panelMain.Controls.Add(panelNew);
            panelMain.Controls.Add(labelUnreadTitle);
            panelMain.Controls.Add(labelNewMail);
            panelMain.Controls.Add(panelFolders);
            panelMain.Controls.Add(panelInbox);
            panelMain.Location = new Point(3, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(253, 57);
            panelMain.TabIndex = 9;
            // 
            // buttonDockRight
            // 
            buttonDockRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDockRight.BackColor = Color.Transparent;
            buttonDockRight.BackgroundImage = Properties.Resources.ui_icon_right_64;
            buttonDockRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDockRight.Cursor = Cursors.Hand;
            buttonDockRight.Location = new Point(236, 22);
            buttonDockRight.Name = "buttonDockRight";
            buttonDockRight.Size = new Size(18, 20);
            buttonDockRight.TabIndex = 12;
            buttonDockRight.TabStop = false;
            buttonDockRight.Click += buttonDockRight_Click;
            // 
            // buttonDockLeft
            // 
            buttonDockLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDockLeft.BackColor = Color.Transparent;
            buttonDockLeft.BackgroundImage = Properties.Resources.ui_icon_left_64;
            buttonDockLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDockLeft.Cursor = Cursors.Hand;
            buttonDockLeft.Location = new Point(0, 22);
            buttonDockLeft.Name = "buttonDockLeft";
            buttonDockLeft.Size = new Size(18, 20);
            buttonDockLeft.TabIndex = 11;
            buttonDockLeft.TabStop = false;
            buttonDockLeft.Click += buttonDockLeft_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.odma_icon_default;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogo.Cursor = Cursors.Hand;
            pictureBoxLogo.Location = new Point(20, 7);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(45, 45);
            pictureBoxLogo.TabIndex = 10;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // panelNew
            // 
            panelNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNew.BackColor = Color.Transparent;
            panelNew.BackgroundImage = Properties.Resources.panel_default_64;
            panelNew.BackgroundImageLayout = ImageLayout.Stretch;
            panelNew.Controls.Add(label2);
            panelNew.Controls.Add(labelNewMailItems);
            panelNew.Location = new Point(70, 18);
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
            panelFolders.PerformLayout();
            panelInbox.ResumeLayout(false);
            panelInbox.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonDockRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonDockLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelNew.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIconODMA;
        private Panel panelFolders;
        private Label labelUnreadFolders;
        private Panel panelInbox;
        private Label labelUnreadInbox;
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
        private Label labelTitleInbox;
        private Label labelTitleFolders;
        private PictureBox buttonDockLeft;
        private PictureBox buttonDockRight;
    }
}
