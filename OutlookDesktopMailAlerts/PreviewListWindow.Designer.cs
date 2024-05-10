namespace OutlookDesktopMailAlerts
{
    partial class PreviewListWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewListWindow));
            flowLayoutPreviewList = new FlowLayoutPanel();
            pictureBoxUnreadMail = new PictureBox();
            labelTitle = new Label();
            buttonDismiss = new Label();
            panelBG = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUnreadMail).BeginInit();
            panelBG.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPreviewList
            // 
            flowLayoutPreviewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPreviewList.AutoScroll = true;
            flowLayoutPreviewList.Location = new Point(0, 40);
            flowLayoutPreviewList.Name = "flowLayoutPreviewList";
            flowLayoutPreviewList.Padding = new Padding(10, 0, 0, 0);
            flowLayoutPreviewList.Size = new Size(254, 355);
            flowLayoutPreviewList.TabIndex = 0;
            // 
            // pictureBoxUnreadMail
            // 
            pictureBoxUnreadMail.BackColor = Color.Transparent;
            pictureBoxUnreadMail.BackgroundImage = Properties.Resources.ui_icon_newmail_64;
            pictureBoxUnreadMail.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxUnreadMail.Location = new Point(14, 6);
            pictureBoxUnreadMail.Name = "pictureBoxUnreadMail";
            pictureBoxUnreadMail.Size = new Size(22, 22);
            pictureBoxUnreadMail.TabIndex = 8;
            pictureBoxUnreadMail.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(7, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(30, 0, 0, 0);
            labelTitle.Size = new Size(152, 32);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Unread Messages";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonDismiss
            // 
            buttonDismiss.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDismiss.BackColor = Color.FromArgb(38, 142, 237);
            buttonDismiss.Cursor = Cursors.Hand;
            buttonDismiss.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDismiss.Location = new Point(0, 404);
            buttonDismiss.Name = "buttonDismiss";
            buttonDismiss.Size = new Size(260, 20);
            buttonDismiss.TabIndex = 9;
            buttonDismiss.Text = "Dismiss";
            buttonDismiss.TextAlign = ContentAlignment.MiddleCenter;
            buttonDismiss.Click += buttonDismiss_Click;
            // 
            // panelBG
            // 
            panelBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBG.BackColor = Color.FromArgb(32, 32, 32);
            panelBG.Controls.Add(pictureBoxUnreadMail);
            panelBG.Controls.Add(labelTitle);
            panelBG.Controls.Add(flowLayoutPreviewList);
            panelBG.Location = new Point(3, 3);
            panelBG.Name = "panelBG";
            panelBG.Size = new Size(254, 398);
            panelBG.TabIndex = 10;
            // 
            // PreviewListWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 142, 237);
            ClientSize = new Size(260, 425);
            Controls.Add(panelBG);
            Controls.Add(buttonDismiss);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PreviewListWindow";
            Opacity = 0.95D;
            ShowInTaskbar = false;
            Text = "Unread Messages";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBoxUnreadMail).EndInit();
            panelBG.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPreviewList;
        private PictureBox pictureBoxUnreadMail;
        private Label labelTitle;
        private Label buttonDismiss;
        private Panel panelBG;
    }
}