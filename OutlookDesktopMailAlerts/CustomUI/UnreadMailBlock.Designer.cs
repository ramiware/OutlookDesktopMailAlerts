namespace OutlookDesktopMailAlerts.CustomUI
{
    partial class UnreadMailBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelSenderName = new Label();
            labelSubject = new Label();
            labelReceivedTime = new Label();
            labelFolderName = new Label();
            buttonOpenMail = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)buttonOpenMail).BeginInit();
            SuspendLayout();
            // 
            // labelSenderName
            // 
            labelSenderName.BackColor = Color.Transparent;
            labelSenderName.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenderName.ForeColor = Color.White;
            labelSenderName.Location = new Point(0, 0);
            labelSenderName.Name = "labelSenderName";
            labelSenderName.Size = new Size(114, 17);
            labelSenderName.TabIndex = 0;
            labelSenderName.Text = "Sender Name 12345";
            labelSenderName.MouseLeave += UnreadMailBlock_MouseLeave;
            labelSenderName.MouseHover += UnreadMailBlock_MouseHover;
            // 
            // labelSubject
            // 
            labelSubject.BackColor = Color.Transparent;
            labelSubject.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubject.ForeColor = Color.White;
            labelSubject.Location = new Point(11, 16);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(190, 14);
            labelSubject.TabIndex = 1;
            labelSubject.Text = "Subject 1234567890 1234567890AB";
            labelSubject.MouseLeave += UnreadMailBlock_MouseLeave;
            labelSubject.MouseHover += UnreadMailBlock_MouseHover;
            // 
            // labelReceivedTime
            // 
            labelReceivedTime.AutoSize = true;
            labelReceivedTime.BackColor = Color.Transparent;
            labelReceivedTime.Font = new Font("Gadugi", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReceivedTime.ForeColor = Color.White;
            labelReceivedTime.Location = new Point(13, 32);
            labelReceivedTime.Name = "labelReceivedTime";
            labelReceivedTime.Size = new Size(64, 13);
            labelReceivedTime.TabIndex = 2;
            labelReceivedTime.Text = "Received Time";
            // 
            // labelFolderName
            // 
            labelFolderName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFolderName.BackColor = Color.Transparent;
            labelFolderName.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFolderName.ForeColor = Color.White;
            labelFolderName.Location = new Point(123, 0);
            labelFolderName.Name = "labelFolderName";
            labelFolderName.Size = new Size(88, 17);
            labelFolderName.TabIndex = 3;
            labelFolderName.Text = "Folder Name 1";
            labelFolderName.TextAlign = ContentAlignment.TopRight;
            labelFolderName.MouseLeave += UnreadMailBlock_MouseLeave;
            labelFolderName.MouseHover += UnreadMailBlock_MouseHover;
            // 
            // buttonOpenMail
            // 
            buttonOpenMail.BackColor = Color.Transparent;
            buttonOpenMail.BackgroundImage = Properties.Resources.ui_icon_open_64;
            buttonOpenMail.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenMail.Cursor = Cursors.Hand;
            buttonOpenMail.Location = new Point(194, 31);
            buttonOpenMail.Name = "buttonOpenMail";
            buttonOpenMail.Size = new Size(16, 16);
            buttonOpenMail.TabIndex = 10;
            buttonOpenMail.TabStop = false;
            buttonOpenMail.Click += buttonOpenMail_Click;
            buttonOpenMail.MouseLeave += UnreadMailBlock_MouseLeave;
            buttonOpenMail.MouseHover += UnreadMailBlock_MouseHover;
            // 
            // UnreadMailBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.previewblock_bg_214x50;
            Controls.Add(buttonOpenMail);
            Controls.Add(labelFolderName);
            Controls.Add(labelReceivedTime);
            Controls.Add(labelSubject);
            Controls.Add(labelSenderName);
            Cursor = Cursors.Hand;
            Name = "UnreadMailBlock";
            Size = new Size(214, 50);
            MouseLeave += UnreadMailBlock_MouseLeave;
            MouseHover += UnreadMailBlock_MouseHover;
            ((System.ComponentModel.ISupportInitialize)buttonOpenMail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSenderName;
        private Label labelSubject;
        private Label labelReceivedTime;
        private Label labelFolderName;
        private PictureBox buttonOpenMail;
    }
}
