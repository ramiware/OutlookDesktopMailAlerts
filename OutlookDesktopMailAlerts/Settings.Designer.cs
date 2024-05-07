namespace OutlookDesktopMailAlerts
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panelNav = new Panel();
            buttonAbout = new Label();
            buttonFolders = new Label();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            labelClose = new Label();
            tabPageAbout = new TabPage();
            labelAbout = new Label();
            labelRamiwareWeb = new Label();
            labelRamiware = new Label();
            labelReleaseDate = new Label();
            labelVersion = new Label();
            labelAppName = new Label();
            pictureBoxLogo = new PictureBox();
            tabPageFolders = new TabPage();
            checkBoxInboxReadOnly = new CheckBox();
            checkBoxSelectAll = new CheckBox();
            buttonSave = new Button();
            labelFoldersInstructions = new Label();
            checkedListFolders = new CheckedListBox();
            tabControlSettings = new TabControl();
            imageList1 = new ImageList(components);
            panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tabPageFolders.SuspendLayout();
            tabControlSettings.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelNav.BackColor = Color.FromArgb(61, 61, 61);
            panelNav.Controls.Add(buttonAbout);
            panelNav.Controls.Add(buttonFolders);
            panelNav.Location = new Point(0, 40);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(118, 470);
            panelNav.TabIndex = 0;
            // 
            // buttonAbout
            // 
            buttonAbout.Cursor = Cursors.Hand;
            buttonAbout.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAbout.Location = new Point(0, 30);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new Padding(10, 0, 0, 0);
            buttonAbout.Size = new Size(118, 30);
            buttonAbout.TabIndex = 3;
            buttonAbout.Text = "About";
            buttonAbout.TextAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonFolders
            // 
            buttonFolders.BackColor = Color.FromArgb(38, 142, 237);
            buttonFolders.Cursor = Cursors.Hand;
            buttonFolders.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFolders.Location = new Point(0, 0);
            buttonFolders.Name = "buttonFolders";
            buttonFolders.Padding = new Padding(10, 0, 0, 0);
            buttonFolders.Size = new Size(118, 30);
            buttonFolders.TabIndex = 2;
            buttonFolders.Text = "Folders";
            buttonFolders.TextAlign = ContentAlignment.MiddleLeft;
            buttonFolders.Click += buttonFolders_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(32, 32, 32);
            pictureBox1.BackgroundImage = Properties.Resources.odma_icon_settings;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(7, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(32, 32, 32);
            labelTitle.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(30, 0, 0, 0);
            labelTitle.Size = new Size(118, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Settings";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelClose
            // 
            labelClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Location = new Point(389, 9);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(25, 23);
            labelClose.TabIndex = 4;
            labelClose.Text = "X";
            labelClose.TextAlign = ContentAlignment.MiddleCenter;
            labelClose.Click += labelClose_Click;
            // 
            // tabPageAbout
            // 
            tabPageAbout.BackColor = Color.FromArgb(32, 32, 32);
            tabPageAbout.Controls.Add(labelAbout);
            tabPageAbout.Controls.Add(labelRamiwareWeb);
            tabPageAbout.Controls.Add(labelRamiware);
            tabPageAbout.Controls.Add(labelReleaseDate);
            tabPageAbout.Controls.Add(labelVersion);
            tabPageAbout.Controls.Add(labelAppName);
            tabPageAbout.Controls.Add(pictureBoxLogo);
            tabPageAbout.ForeColor = Color.White;
            tabPageAbout.Location = new Point(4, 24);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Padding = new Padding(3);
            tabPageAbout.Size = new Size(415, 454);
            tabPageAbout.TabIndex = 1;
            // 
            // labelAbout
            // 
            labelAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAbout.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAbout.ForeColor = Color.White;
            labelAbout.Location = new Point(126, 111);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(275, 313);
            labelAbout.TabIndex = 17;
            labelAbout.Text = "About the app....";
            // 
            // labelRamiwareWeb
            // 
            labelRamiwareWeb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRamiwareWeb.AutoSize = true;
            labelRamiwareWeb.Font = new Font("Segoe UI", 8.25F);
            labelRamiwareWeb.ForeColor = Color.White;
            labelRamiwareWeb.Location = new Point(204, 79);
            labelRamiwareWeb.Name = "labelRamiwareWeb";
            labelRamiwareWeb.Size = new Size(108, 13);
            labelRamiwareWeb.TabIndex = 16;
            labelRamiwareWeb.Text = "www.ramiware.com";
            // 
            // labelRamiware
            // 
            labelRamiware.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRamiware.AutoSize = true;
            labelRamiware.Font = new Font("Segoe UI", 8.25F);
            labelRamiware.ForeColor = Color.White;
            labelRamiware.Location = new Point(204, 64);
            labelRamiware.Name = "labelRamiware";
            labelRamiware.Size = new Size(57, 13);
            labelRamiware.TabIndex = 15;
            labelRamiware.Text = "Ramiware";
            // 
            // labelReleaseDate
            // 
            labelReleaseDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelReleaseDate.AutoSize = true;
            labelReleaseDate.Font = new Font("Segoe UI", 8.25F);
            labelReleaseDate.ForeColor = Color.White;
            labelReleaseDate.Location = new Point(204, 49);
            labelReleaseDate.Name = "labelReleaseDate";
            labelReleaseDate.Size = new Size(73, 13);
            labelReleaseDate.TabIndex = 14;
            labelReleaseDate.Text = "Release Date";
            // 
            // labelVersion
            // 
            labelVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Segoe UI", 8.25F);
            labelVersion.ForeColor = Color.White;
            labelVersion.Location = new Point(204, 34);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(45, 13);
            labelVersion.TabIndex = 13;
            labelVersion.Text = "Version";
            // 
            // labelAppName
            // 
            labelAppName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Segoe UI", 8.25F);
            labelAppName.ForeColor = Color.White;
            labelAppName.Location = new Point(204, 19);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(60, 13);
            labelAppName.TabIndex = 12;
            labelAppName.Text = "App Name";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.odma_icon_default;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogo.Location = new Point(126, 19);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(72, 72);
            pictureBoxLogo.TabIndex = 11;
            pictureBoxLogo.TabStop = false;
            // 
            // tabPageFolders
            // 
            tabPageFolders.BackColor = Color.FromArgb(32, 32, 32);
            tabPageFolders.Controls.Add(checkBoxInboxReadOnly);
            tabPageFolders.Controls.Add(checkBoxSelectAll);
            tabPageFolders.Controls.Add(buttonSave);
            tabPageFolders.Controls.Add(labelFoldersInstructions);
            tabPageFolders.Controls.Add(checkedListFolders);
            tabPageFolders.Location = new Point(4, 24);
            tabPageFolders.Name = "tabPageFolders";
            tabPageFolders.Padding = new Padding(3);
            tabPageFolders.Size = new Size(415, 454);
            tabPageFolders.TabIndex = 0;
            // 
            // checkBoxInboxReadOnly
            // 
            checkBoxInboxReadOnly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxInboxReadOnly.AutoSize = true;
            checkBoxInboxReadOnly.Checked = true;
            checkBoxInboxReadOnly.CheckState = CheckState.Checked;
            checkBoxInboxReadOnly.Location = new Point(154, 84);
            checkBoxInboxReadOnly.Name = "checkBoxInboxReadOnly";
            checkBoxInboxReadOnly.Size = new Size(114, 19);
            checkBoxInboxReadOnly.TabIndex = 6;
            checkBoxInboxReadOnly.Text = "Inbox (Required)";
            checkBoxInboxReadOnly.UseVisualStyleBackColor = true;
            checkBoxInboxReadOnly.CheckedChanged += checkBoxInboxReadOnly_CheckedChanged;
            // 
            // checkBoxSelectAll
            // 
            checkBoxSelectAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxSelectAll.AutoSize = true;
            checkBoxSelectAll.Location = new Point(140, 65);
            checkBoxSelectAll.Name = "checkBoxSelectAll";
            checkBoxSelectAll.Size = new Size(74, 19);
            checkBoxSelectAll.TabIndex = 5;
            checkBoxSelectAll.Text = "Select All";
            checkBoxSelectAll.UseVisualStyleBackColor = true;
            checkBoxSelectAll.CheckedChanged += checkBoxSelectAll_CheckedChanged;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(326, 414);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelFoldersInstructions
            // 
            labelFoldersInstructions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFoldersInstructions.BackColor = Color.Transparent;
            labelFoldersInstructions.Cursor = Cursors.Hand;
            labelFoldersInstructions.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFoldersInstructions.Location = new Point(120, 19);
            labelFoldersInstructions.Name = "labelFoldersInstructions";
            labelFoldersInstructions.Size = new Size(281, 39);
            labelFoldersInstructions.TabIndex = 3;
            labelFoldersInstructions.Text = "Instructional text";
            labelFoldersInstructions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkedListFolders
            // 
            checkedListFolders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkedListFolders.BackColor = Color.FromArgb(32, 32, 32);
            checkedListFolders.BorderStyle = BorderStyle.None;
            checkedListFolders.CheckOnClick = true;
            checkedListFolders.ForeColor = Color.White;
            checkedListFolders.FormattingEnabled = true;
            checkedListFolders.Location = new Point(153, 102);
            checkedListFolders.Name = "checkedListFolders";
            checkedListFolders.Size = new Size(248, 306);
            checkedListFolders.TabIndex = 0;
            // 
            // tabControlSettings
            // 
            tabControlSettings.Controls.Add(tabPageFolders);
            tabControlSettings.Controls.Add(tabPageAbout);
            tabControlSettings.Location = new Point(0, 35);
            tabControlSettings.Name = "tabControlSettings";
            tabControlSettings.SelectedIndex = 0;
            tabControlSettings.Size = new Size(423, 482);
            tabControlSettings.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(417, 508);
            Controls.Add(pictureBox1);
            Controls.Add(panelNav);
            Controls.Add(tabControlSettings);
            Controls.Add(labelClose);
            Controls.Add(labelTitle);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            ShowInTaskbar = false;
            Text = "Settings";
            panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageAbout.ResumeLayout(false);
            tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tabPageFolders.ResumeLayout(false);
            tabPageFolders.PerformLayout();
            tabControlSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Label buttonAbout;
        private Label buttonFolders;
        private Label labelTitle;
        private Label labelClose;
        private TabPage tabPageAbout;
        private TabPage tabPageFolders;
        private TabControl tabControlSettings;
        private Label labelRamiwareWeb;
        private Label labelRamiware;
        private Label labelReleaseDate;
        private Label labelVersion;
        private Label labelAppName;
        private PictureBox pictureBoxLogo;
        private Label labelAbout;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private CheckedListBox checkedListFolders;
        private Label labelFoldersInstructions;
        private Button buttonSave;
        private CheckBox checkBoxSelectAll;
        private CheckBox checkBoxInboxReadOnly;
    }
}