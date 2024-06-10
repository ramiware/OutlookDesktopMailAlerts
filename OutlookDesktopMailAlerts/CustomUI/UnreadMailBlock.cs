using OutlookDesktopMailAlerts.Properties;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookDesktopMailAlerts.CustomUI
{
    public partial class UnreadMailBlock : UserControl
    {
        // String max
        private const int MAX_FOLDERNAME_LEN = 13;
        private const int MAX_SENDER_LEN = 18;
        private const int MAX_SUBJECT_LEN = 31;

        Outlook.MailItem currMail;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="sender"></param>
        /// <param name="subject"></param>
        /// <param name="receivedTime"></param>
        public UnreadMailBlock(string folder, string sender, string subject, string receivedTime, Outlook.MailItem message)
        {
            InitializeComponent();

            // Folder
            string folderText = "";
            if (folder == null)
                folderText = "";
            else
                folderText = (folder.Length > MAX_FOLDERNAME_LEN) ? folder.Substring(0, MAX_FOLDERNAME_LEN) : folder;
            this.labelFolderName.Text = folderText;


            // Sender
            string senderText = "";
            if (sender == null)
                senderText = "";
            else
                senderText = (sender.Length > MAX_SENDER_LEN) ? sender.Substring(0, MAX_SENDER_LEN) : sender;
            this.labelSenderName.Text = senderText;


            // Subject
            string subjectText = "";
            if (subject == null)
                subjectText = "";
            else
                subjectText = (subject.Length > MAX_SUBJECT_LEN) ? subject.Substring(0, MAX_SUBJECT_LEN) : subject;
            this.labelSubject.Text = subjectText;


            // Received time
            this.labelReceivedTime.Text = receivedTime;


            // Message object
            this.currMail = message;
        }

        /// <summary>
        /// Open current mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenMail_Click(object sender, EventArgs e)
        {
            try
            {
                currMail.Display();
                this.Hide();
            }
            catch { }
        }

        private void buttonMarkAsRead_Click(object sender, EventArgs e)
        {
            try
            {
                currMail.UnRead = false;
                this.Hide();
            }
            catch { }
        }

        private void UnreadMailBlock_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.previewblock_highlight_214x50;
            this.Refresh();
        }

        private void UnreadMailBlock_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.previewblock_bg_214x50;
            this.Refresh();
        }



    }
}
