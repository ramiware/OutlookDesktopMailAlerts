namespace OutlookDesktopMailAlerts
{
    partial class NewMailPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMailPopup));
            panelMain = new Panel();
            labelFolderName = new Label();
            labelSubject = new Label();
            labelBody = new Label();
            labelSenderName = new Label();
            pictureBoxMailIcon = new PictureBox();
            pictureBoxProfile = new PictureBox();
            labelTitle = new Label();
            buttonMarkAsRead = new PictureBox();
            buttonOpenMail = new PictureBox();
            buttonDeleteMail = new PictureBox();
            buttonDismissPopup = new PictureBox();
            toolTipDismissPopup = new ToolTip(components);
            toolTipDeleteMail = new ToolTip(components);
            toolTipOpenMail = new ToolTip(components);
            toolTipMarkAsRead = new ToolTip(components);
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMailIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMarkAsRead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonOpenMail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonDeleteMail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonDismissPopup).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.FromArgb(32, 32, 32);
            panelMain.Controls.Add(labelFolderName);
            panelMain.Controls.Add(labelSubject);
            panelMain.Controls.Add(labelBody);
            panelMain.Controls.Add(labelSenderName);
            panelMain.Controls.Add(pictureBoxMailIcon);
            panelMain.Controls.Add(pictureBoxProfile);
            panelMain.Controls.Add(labelTitle);
            panelMain.Location = new Point(33, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(224, 149);
            panelMain.TabIndex = 0;
            // 
            // labelFolderName
            // 
            labelFolderName.AutoSize = true;
            labelFolderName.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFolderName.ForeColor = Color.White;
            labelFolderName.Location = new Point(58, 8);
            labelFolderName.Name = "labelFolderName";
            labelFolderName.Size = new Size(101, 16);
            labelFolderName.TabIndex = 8;
            labelFolderName.Text = "Folder Name 12";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSubject.ForeColor = Color.FromArgb(38, 142, 237);
            labelSubject.Location = new Point(10, 49);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(154, 17);
            labelSubject.TabIndex = 7;
            labelSubject.Text = "Subject 12345 ABCDEFG";
            // 
            // labelBody
            // 
            labelBody.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBody.ForeColor = Color.White;
            labelBody.Location = new Point(10, 70);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(206, 73);
            labelBody.TabIndex = 6;
            labelBody.Text = "This is the body. The message will go in here. The end. Thank you";
            // 
            // labelSenderName
            // 
            labelSenderName.AutoSize = true;
            labelSenderName.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSenderName.ForeColor = Color.White;
            labelSenderName.Location = new Point(10, 32);
            labelSenderName.Name = "labelSenderName";
            labelSenderName.Size = new Size(150, 17);
            labelSenderName.TabIndex = 3;
            labelSenderName.Text = "Sender Name 12345678";
            // 
            // pictureBoxMailIcon
            // 
            pictureBoxMailIcon.BackgroundImage = Properties.Resources.ui_icon_newmail_64;
            pictureBoxMailIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxMailIcon.Location = new Point(10, 6);
            pictureBoxMailIcon.Name = "pictureBoxMailIcon";
            pictureBoxMailIcon.Size = new Size(16, 16);
            pictureBoxMailIcon.TabIndex = 2;
            pictureBoxMailIcon.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackgroundImage = Properties.Resources.profile_128;
            pictureBoxProfile.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxProfile.Location = new Point(168, 8);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(44, 44);
            pictureBoxProfile.TabIndex = 1;
            pictureBoxProfile.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(28, 8);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(32, 16);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Mail";
            // 
            // buttonMarkAsRead
            // 
            buttonMarkAsRead.BackgroundImage = Properties.Resources.ui_icon_read_64;
            buttonMarkAsRead.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMarkAsRead.Cursor = Cursors.Hand;
            buttonMarkAsRead.Location = new Point(6, 87);
            buttonMarkAsRead.Name = "buttonMarkAsRead";
            buttonMarkAsRead.Size = new Size(20, 20);
            buttonMarkAsRead.TabIndex = 10;
            buttonMarkAsRead.TabStop = false;
            buttonMarkAsRead.Click += buttonMarkAsRead_Click;
            // 
            // buttonOpenMail
            // 
            buttonOpenMail.BackgroundImage = Properties.Resources.ui_icon_open_64;
            buttonOpenMail.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenMail.Cursor = Cursors.Hand;
            buttonOpenMail.Location = new Point(6, 61);
            buttonOpenMail.Name = "buttonOpenMail";
            buttonOpenMail.Size = new Size(20, 20);
            buttonOpenMail.TabIndex = 9;
            buttonOpenMail.TabStop = false;
            buttonOpenMail.Click += buttonOpenMail_Click;
            // 
            // buttonDeleteMail
            // 
            buttonDeleteMail.BackgroundImage = Properties.Resources.ui_icon_delete_64;
            buttonDeleteMail.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDeleteMail.Cursor = Cursors.Hand;
            buttonDeleteMail.Location = new Point(6, 35);
            buttonDeleteMail.Name = "buttonDeleteMail";
            buttonDeleteMail.Size = new Size(20, 20);
            buttonDeleteMail.TabIndex = 8;
            buttonDeleteMail.TabStop = false;
            buttonDeleteMail.Click += buttonDeleteMail_Click;
            // 
            // buttonDismissPopup
            // 
            buttonDismissPopup.BackgroundImage = Properties.Resources.ui_icon_close_64;
            buttonDismissPopup.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDismissPopup.Cursor = Cursors.Hand;
            buttonDismissPopup.Location = new Point(6, 9);
            buttonDismissPopup.Name = "buttonDismissPopup";
            buttonDismissPopup.Size = new Size(20, 20);
            buttonDismissPopup.TabIndex = 7;
            buttonDismissPopup.TabStop = false;
            buttonDismissPopup.Click += buttonDismissPopup_Click;
            // 
            // toolTipDismissPopup
            // 
            toolTipDismissPopup.AutoPopDelay = 5000;
            toolTipDismissPopup.InitialDelay = 500;
            toolTipDismissPopup.ReshowDelay = 0;
            // 
            // toolTipDeleteMail
            // 
            toolTipDeleteMail.AutoPopDelay = 5000;
            toolTipDeleteMail.InitialDelay = 500;
            toolTipDeleteMail.ReshowDelay = 0;
            // 
            // toolTipOpenMail
            // 
            toolTipOpenMail.AutoPopDelay = 5000;
            toolTipOpenMail.InitialDelay = 500;
            toolTipOpenMail.ReshowDelay = 0;
            // 
            // toolTipMarkAsRead
            // 
            toolTipMarkAsRead.AutoPopDelay = 5000;
            toolTipMarkAsRead.InitialDelay = 500;
            toolTipMarkAsRead.ReshowDelay = 0;
            // 
            // NewMailPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 142, 237);
            ClientSize = new Size(260, 155);
            Controls.Add(buttonMarkAsRead);
            Controls.Add(buttonOpenMail);
            Controls.Add(buttonDeleteMail);
            Controls.Add(buttonDismissPopup);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewMailPopup";
            Opacity = 0.8D;
            ShowInTaskbar = false;
            Text = "New Mail";
            TopMost = true;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMailIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMarkAsRead).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonOpenMail).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonDeleteMail).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonDismissPopup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label labelTitle;
        private PictureBox pictureBoxProfile;
        private PictureBox pictureBoxMailIcon;
        private Label labelSenderName;
        private Label labelBody;
        private Label labelSubject;
        private Label labelFolderName;
        private PictureBox buttonMarkAsRead;
        private PictureBox buttonOpenMail;
        private PictureBox buttonDeleteMail;
        private PictureBox buttonDismissPopup;
        private ToolTip toolTipDismissPopup;
        private ToolTip toolTipDeleteMail;
        private ToolTip toolTipOpenMail;
        private ToolTip toolTipMarkAsRead;
    }
}