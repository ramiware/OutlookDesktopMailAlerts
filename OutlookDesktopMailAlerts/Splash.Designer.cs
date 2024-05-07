namespace OutlookDesktopMailAlerts
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            pictureBoxLogo = new PictureBox();
            labelProgress = new Label();
            panelBox = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = Properties.Resources.odma_icon_default;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogo.Location = new Point(68, 13);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(95, 95);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelProgress
            // 
            labelProgress.Location = new Point(41, 118);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(150, 15);
            labelProgress.TabIndex = 1;
            labelProgress.Text = "Loading";
            labelProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBox
            // 
            panelBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBox.BackColor = Color.FromArgb(32, 32, 32);
            panelBox.Controls.Add(pictureBoxLogo);
            panelBox.Controls.Add(labelProgress);
            panelBox.Location = new Point(4, 3);
            panelBox.Name = "panelBox";
            panelBox.Size = new Size(232, 148);
            panelBox.TabIndex = 2;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 61);
            ClientSize = new Size(240, 155);
            Controls.Add(panelBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Splash";
            Text = "Splash";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelProgress;
        private Panel panelBox;
    }
}