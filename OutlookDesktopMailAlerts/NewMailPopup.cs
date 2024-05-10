using OutlookDesktopMailAlerts.Common;
using OutlookDesktopMailAlerts.Structs;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace OutlookDesktopMailAlerts
{
    public partial class NewMailPopup : Form
    {
        public bool IsRunning = false;

        private int parentWindowLocationX;
        private int parentWindowHeight;
        private readonly List<NewMailItem> newMailList;

        // String max
        private const int MAX_FOLDERNAME_LEN = 15;
        private const int MAX_SENDER_LEN = 22;
        private const int MAX_SUBJECT_LEN = 26;
        private const int MAX_BODY_LEN = 125;

        // Popup Timer
        private const int POPUP_TICK = 1000;
        private const int POPUP_DURATION = 10000;
        private const int SINGLE_MSGS_MAX = 3;

        private Timer popupTimer;
        private int currentTickValue = 0;
        private int currMsgShownID = 0;






        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="parentWindow"></param>
        /// <param name="newMailList"></param>
        public NewMailPopup(int parentWindowLocationX, int parentWindowHeight, List<NewMailItem> newMailList)
        {
            InitializeComponent();

            this.parentWindowLocationX = parentWindowLocationX;
            this.parentWindowHeight = parentWindowHeight;
            //Debug.WriteLine("NEW MAIL: " + newMailList.Count);
            this.newMailList = newMailList;

            InitializeUI();

            popupTimer = new Timer();
            popupTimer.Tick += new EventHandler(PopupTimer_Tick);
            popupTimer.Interval = POPUP_TICK; // in miliseconds

            if (this.newMailList.Count > 0)
                ShowPopup();
        }

        /// <summary>
        /// Override form to create rounded corners
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottomRect"></param>
        /// <param name="nWidthEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        /// <summary>
        /// Configure the UI for startup
        /// </summary>
        private void InitializeUI()
        {
            // Colors
            this.BackColor = AppTheme.COLOR_ACCENT;
            this.panelMain.BackColor = AppTheme.COLOR_DARK;
            this.labelBody.BackColor = AppTheme.COLOR_DARK;

            this.ForeColor = AppTheme.COLOR_TEXT;
            this.labelSubject.ForeColor = AppTheme.COLOR_ACCENT;
            this.labelBody.ForeColor = AppTheme.COLOR_TEXT;


            // Override form to create rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, AppTheme.ROUND_CORNERS, AppTheme.ROUND_CORNERS));

            // Set default location to screen bottom-right
            this.SetBounds(parentWindowLocationX,// Screen.GetWorkingArea(this).Width - this.Width
                           Screen.GetWorkingArea(this).Height - this.Height - parentWindowHeight, this.Width, this.Height);

            // Tooltips
            toolTipDismissPopup.SetToolTip(buttonDismissPopup, "Dismiss Popup");
            toolTipDeleteMail.SetToolTip(buttonDeleteMail, "Delete");
            toolTipOpenMail.SetToolTip(buttonOpenMail, "Open");
            toolTipMarkAsRead.SetToolTip(buttonMarkAsRead, "Mark As Read");

        }

        /// <summary>
        /// Called from parent. Docks popup as per user request for app docking
        /// </summary>
        /// <param name="x"></param>
        public void SetDockLocationX(int x)
        {
            this.SetBounds(x,
                           Screen.GetWorkingArea(this).Height - this.Height, this.Width, this.Height);

        }


        /// <summary>
        /// Handle ticks / UI duration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopupTimer_Tick(object? sender, EventArgs e)
        {
            currentTickValue += POPUP_TICK;
            //Debug.WriteLine("currentTickValue: " + currentTickValue);
            //Debug.WriteLine("currMsgShownID: " + currMsgShownID);
            //Debug.WriteLine("newMailList.Count: " + newMailList.Count);

            // Fade out
            if (currentTickValue == POPUP_DURATION - POPUP_TICK * 2)
            {
                this.BackColor = AppTheme.COLOR_LIGHT;
                this.Refresh();
            }


            // Hide for last tick - looks better for multiple messages
            if (currentTickValue == POPUP_DURATION - POPUP_TICK)
            {
                this.Hide();
                this.Refresh();
            }

            // Hide msg
            if (currentTickValue == POPUP_DURATION)
            {
                //Debug.WriteLine("STOP TIMER / HIDE POPUP: " + currentTickValue);

                popupTimer.Stop();
                currentTickValue = 0;
                this.Hide();
                this.BackColor = AppTheme.COLOR_ACCENT;
                IsRunning = false;

                // ------------------------------------------------------
                // IF unread message count is less than SINGLE_MSGS_MAX
                // ------------------------------------------------------
                if (newMailList.Count >= 1 && newMailList.Count <= SINGLE_MSGS_MAX)
                {
                    // Is there another message?
                    if (currMsgShownID == newMailList.Count - 1)
                        return;
                    else
                    {
                        currMsgShownID++;
                        ShowPopupMsgID(currMsgShownID);
                    }
                }
            }


        }


        /// <summary>
        /// Controls whether a single msg or a bulk summary is shown
        /// </summary>
        private void ShowPopup()
        {

            if (newMailList.Count >= 1 && newMailList.Count <= SINGLE_MSGS_MAX)
                ShowPopupMsgID(currMsgShownID);
            else if (newMailList.Count > SINGLE_MSGS_MAX)
                ShowPopupMsgSummary();
        }

        /// <summary>
        /// Show popup for a single message
        /// </summary>
        /// <param name="msgID"></param>
        private void ShowPopupMsgID(int msgID)
        {
            IsRunning = true;
            //Debug.WriteLine("\nMSG ID: " + currMsgShownID);

            // Folder name
            this.labelFolderName.Text = (newMailList[currMsgShownID].ChildFolder.Length > MAX_FOLDERNAME_LEN) ? "- " + newMailList[currMsgShownID].ChildFolder.Substring(0, MAX_FOLDERNAME_LEN) : "- " + newMailList[currMsgShownID].ChildFolder;

            // Sender name
            this.labelSenderName.Text = (newMailList[currMsgShownID].From.Length > MAX_SENDER_LEN) ? newMailList[currMsgShownID].From.Substring(0, MAX_SENDER_LEN) : newMailList[currMsgShownID].From;

            // Subject
            string subjectText = "";
            if (newMailList[currMsgShownID].Subject == null)
                subjectText = "";
            else
                subjectText = (newMailList[currMsgShownID].Subject.Length > MAX_SUBJECT_LEN) ? newMailList[currMsgShownID].Subject.Substring(0, MAX_SUBJECT_LEN) : newMailList[currMsgShownID].Subject;
            this.labelSubject.Text = subjectText;

            // Body
            string bodyText = "";
            if (newMailList[currMsgShownID].Body == null)
                bodyText = "";
            else
                bodyText = (newMailList[currMsgShownID].Body.Length > MAX_BODY_LEN) ? newMailList[currMsgShownID].Body.Substring(0, MAX_BODY_LEN) : newMailList[currMsgShownID].Body;

            bodyText = bodyText.Replace("\r", "").Replace("\n\n", "\n");
            this.labelBody.Text = bodyText;

            this.Refresh();
            this.Show();

            popupTimer.Start();
        }

        /// <summary>
        /// Show a summary popup if bulk messages have arrived
        /// </summary>
        private void ShowPopupMsgSummary()
        {
            IsRunning = true;
            //Debug.WriteLine("\nMSG ID: SUMMARY");
            this.labelSenderName.Text = "New Mail Arrived";
            this.labelSubject.Text = "Bulk Messages";
            this.labelBody.Text = "A large amount of messages have arrived.\n\nCheck your mailbox.";
            this.Refresh();
            this.Show();

            popupTimer.Start();
        }


        /// <summary>
        /// Action button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDismissPopup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Action button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteMail_Click(object sender, EventArgs e)
        {
            Outlook.MailItem currMail = newMailList[currMsgShownID].Message;
            currMail.Delete();
            this.Hide();
        }

        /// <summary>
        /// Action button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenMail_Click(object sender, EventArgs e)
        {
            Outlook.MailItem currMail = newMailList[currMsgShownID].Message;
            currMail.Display();
            this.Hide();
        }

        /// <summary>
        /// Action button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMarkAsRead_Click(object sender, EventArgs e)
        {
            Outlook.MailItem currMail = newMailList[currMsgShownID].Message;
            currMail.UnRead = false;
            this.Hide();
        }
    }
}
