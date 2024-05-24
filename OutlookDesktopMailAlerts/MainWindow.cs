using OutlookDesktopMailAlerts.Common;
using OutlookDesktopMailAlerts.Structs;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Outlook = Microsoft.Office.Interop.Outlook;
using Timer = System.Windows.Forms.Timer;


namespace OutlookDesktopMailAlerts
{
    public partial class MainWindow : Form
    {
        //------------------------------------------------------------------
        // OUTLOOK VARIABLES
        //------------------------------------------------------------------
        private Outlook.Application oApp;
        private Outlook.NameSpace oNS;
        private Outlook.MAPIFolder oInbox;
        private Outlook.Items oItems;
        private Outlook.MailItem oMsg;



        //------------------------------------------------------------------
        // PROGRAM VARIABLES
        //------------------------------------------------------------------
        // Mail Logic
        private const int MAX_UNREAD_DISPLAYED = 999;

        private List<String> UserPreferencesList = new List<String>();
        private Settings settingsWindow = null;

        private bool FirstRun = true;

        private List<NewFolderMail> runningUnreadFolderList;
        private List<NewMailItem> allUnreadMailList = new List<NewMailItem>();
        private List<NewMailItem> newUnreadMailList = new List<NewMailItem>();
        private DateTime LastRunTimeStamp = DateTime.Now;

        private int UnreadMailInboxCountLive = 0;
        private int UnreadMailFoldersCountLive = 0;

        private int UnreadMailInboxCountPrevious = 0;
        private int UnreadMailFoldersCountPrevious = 0;

        // Refresh Timer
        private Timer refreshTimer;
        private const int REFRESH_TICK = 15000; //5000; //30000;


        // Popup Window
        private NewMailPopup mailPopup;

        // PreviewList Window
        private PreviewListWindow previewListWindow;

        // Splash Window
        private Splash splashWin = new Splash();

        //------------------------------------------------------------------
        // FUNCTIONS 
        //------------------------------------------------------------------

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public MainWindow()
        {
            splashWin.StartPosition = FormStartPosition.CenterScreen;
            splashWin.Show();
            splashWin.Refresh();
            this.Refresh();

            Application.EnableVisualStyles();
            InitializeComponent();


            // Debug.WriteLine(DateTime.Today);
            // Debug.WriteLine(DateTime.Now.Subtract(new TimeSpan(1, 0, 0)));

            InitializeUI();

            if (ConnectToOutlook())
            {
                settingsWindow = new Settings(oApp, this);
                UserPreferencesList = settingsWindow.GetUserFolderPreferences();

                // Call RefreshNewMail for the first time
                RefreshNewMail();

                StartRefreshTimer();
            }
            else
                MessageBox.Show("There was an issue connecting to Outlook\nPlease ensure your credentials are vaild and that you have allowed Outlook to be used by an external applicatoin.", "Outlook Desktop Mail Alerts - Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #region UI OVERRIDES

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
        /// OVerride move/drag window
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }
        #endregion


        #region UI


        /// <summary>
        /// Configure the UI for startup
        /// </summary>
        private void InitializeUI()
        {
            this.Text = AppVersion.APP_ID;

            // Defaults & Colors
            this.labelNewMailItems.Text = "..";
            this.labelUnreadInbox.Text = "..";
            this.labelUnreadFolders.Text = "..";

            this.BackColor = AppTheme.COLOR_LIGHT;
            this.panelMain.BackColor = AppTheme.COLOR_DARK;
            this.ForeColor = AppTheme.COLOR_TEXT;

            // Override form to create rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, AppTheme.ROUND_CORNERS, AppTheme.ROUND_CORNERS));

            // Set default location to screen bottom-right
            this.SetBounds(AppTheme.AppLocation.GetDockRightX(this),
                           Screen.GetWorkingArea(this).Height - this.Height, this.Width, this.Height);

            // Tooltips
            //toolTipLogo.ToolTipTitle = "Outlook Desktop Mail Alerts - " + AppVersion.APP_VERSION;
            //toolTipLogo.SetToolTip(pictureBoxLogo, "");

            //toolTipNewMail.ToolTipTitle = "New Mail";
            //toolTipNewMail.SetToolTip(labelNewMailItems, "Mail that arrives while the app is running will appear here briefly");

            //toolTipUnreadInbox.ToolTipTitle = "Unread - Inbox";
            //toolTipUnreadInbox.SetToolTip(labelUnreadInbox, "Total number of unread mail in your Inbox");

            //toolTipUnreadFolders.ToolTipTitle = "Unread - Folders";
            //toolTipUnreadFolders.SetToolTip(labelUnreadFolders, "Total number of unread mail in all folders under your Inbox");

        }

        /// <summary>
        /// Dock application to screen-left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDockLeft_Click(object sender, EventArgs e)
        {
            this.SetBounds(AppTheme.AppLocation.GetDockLeftX(),
                           Screen.GetWorkingArea(this).Height - this.Height, this.Width, this.Height);
        }

        /// <summary>
        /// Dock application to screen-right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDockRight_Click(object sender, EventArgs e)
        {
            this.SetBounds(AppTheme.AppLocation.GetDockRightX(this),
               Screen.GetWorkingArea(this).Height - this.Height, this.Width, this.Height);
        }



        #endregion


        #region REFRESH MAIL


        /// <summary>
        /// Starts the timer in order to call RefreshNewMail in intervals
        /// </summary>
        private void StartRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            refreshTimer.Interval = REFRESH_TICK; // in miliseconds
            refreshTimer.Start();
        }


        /// <summary>
        /// On every RefreshTimer tick, call RefreshNewMail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshTimer_Tick(object? sender, EventArgs e)
        {
            if (mailPopup != null && mailPopup.IsRunning)
                return;

            RefreshNewMail();
        }






        /// <summary>
        /// Reponsible for handling UI effects for new mail
        /// </summary>
        private void UpdateCountsUI()
        {
            // Do not update the UI if this is the first run as there may be unread messages in the inbox already
            if (FirstRun)
            {
                splashWin.Close();
                splashWin.Dispose();

                FirstRun = false;
                return;
            }


            if (UnreadMailInboxCountLive > UnreadMailInboxCountPrevious)
                panelInbox.BackgroundImage = AppTheme.PANEL_BG_ACCENT;
            else
                panelInbox.BackgroundImage = AppTheme.PANEL_BG_DEFAULT;


            if (UnreadMailFoldersCountLive > UnreadMailFoldersCountPrevious)
                panelFolders.BackgroundImage = AppTheme.PANEL_BG_ACCENT;
            else
                panelFolders.BackgroundImage = AppTheme.PANEL_BG_DEFAULT;


            // IF we have NEW MAIL
            if (newUnreadMailList.Count > 0)
            {
                this.labelNewMailItems.Text = newUnreadMailList.Count.ToString();
                this.labelNewMailItems.Refresh();

                mailPopup = new NewMailPopup(this.Location.X, this.Height, newUnreadMailList);
            }
            else
            {
                this.labelNewMailItems.Text = newUnreadMailList.Count.ToString();
                this.labelNewMailItems.Refresh();
            }

        }






        /// <summary>
        /// Connect to outlook and load all variables
        /// </summary>
        /// <returns></returns>
        private bool ConnectToOutlook()
        {
            try
            {
                // Create the Outlook application.
                // in-line initialization
                oApp = new Outlook.Application();

                // Get the MAPI namespace.
                oNS = oApp.GetNamespace("mapi");

                // Log on by using the default profile or existing session (no dialog box).
                oNS.Logon(Missing.Value, Missing.Value, false, true);

                // Alternate logon method that uses a specific profile name.
                // TODO: If you use this logon method, specify the correct profile name
                // and comment the previous Logon line.
                //oNS.Logon("profilename",Missing.Value,false,true);

                //Get the Inbox folder.
                oInbox = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);

                //Get the Items collection in the Inbox folder.
                //Outlook.Items oItems = oInbox.Items;


                // Get the first message.
                // Because the Items folder may contain different item types,
                // use explicit typecasting with the assignment.
                //oMsg = (Outlook.MailItem)oItems.GetFirst();

                //Output some common properties.
                //Debug.WriteLine(oMsg.Subject);
                //Debug.WriteLine(oMsg.SenderName);
                //Debug.WriteLine(oMsg.ReceivedTime);
                //Debug.WriteLine(oMsg.Body);

                //Check for attachments.
                //int AttachCnt = oMsg.Attachments.Count;
                //Debug.WriteLine("Attachments: " + AttachCnt.ToString());

                //Display the message.
                //oMsg.Display(true); //modal

                return true;
            }

            //Error handler.
            catch (Exception ex)
            {
                MessageBox.Show("{0} Exception caught: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool RefreshNewMail()
        {
            try
            {
                LastRunTimeStamp = DateTime.Now;
                // Debug.WriteLine("LAST RUN STAMP: " + LastRunTimeStamp);

                if (FirstRun)
                    Debug.Write("[" + LastRunTimeStamp + "] Refresh Running (FirstRun)...");
                else
                    Debug.Write("[" + LastRunTimeStamp + "] Refresh Running...");

                // Update lists and variables
                runningUnreadFolderList = new List<NewFolderMail>();

                UnreadMailInboxCountPrevious = UnreadMailInboxCountLive;
                UnreadMailInboxCountLive = 0;

                UnreadMailFoldersCountPrevious = UnreadMailFoldersCountLive;
                UnreadMailFoldersCountLive = 0;

                if (newUnreadMailList != null)
                {
                    newUnreadMailList.Clear();
                    newUnreadMailList = new List<NewMailItem>();
                }



                // -----------------------------------------------
                // INBOX
                // -----------------------------------------------

                // Refreshes newUnreadFolderList
                Outlook.Items unreadInboxItems = oInbox.Items.Restrict("[Unread]=true");
                UnreadMailInboxCountLive = unreadInboxItems.Count;

                if (UnreadMailInboxCountLive > 0)
                {
                    NewFolderMail newInboxMail = new NewFolderMail();
                    newInboxMail.ParentFolder = "Root";
                    newInboxMail.ChildFolder = "Inbox";
                    newInboxMail.UnreadItems = unreadInboxItems;
                    runningUnreadFolderList.Add(newInboxMail);
                }

                // Get/Display the number of unread emails
                NewFolderMail inboxMail = runningUnreadFolderList.Find(r => r.ChildFolder == "Inbox");
                UnreadMailInboxCountLive = (inboxMail.UnreadItems != null) ? inboxMail.UnreadItems.Count : 0;
                //Debug.WriteLine("UnreadMailInboxCount: " + UnreadMailInboxCountLive);
                this.labelUnreadInbox.Text = (UnreadMailInboxCountLive > MAX_UNREAD_DISPLAYED) ? MAX_UNREAD_DISPLAYED.ToString() : UnreadMailInboxCountLive.ToString();

                // -----------------------------------------------
                // FOLDERS
                // -----------------------------------------------
                EnumerateFoldersInDefaultStore();

                // Get/Display the number of unread emails
                foreach (NewFolderMail folderMail in runningUnreadFolderList)
                {
                    if (folderMail.ParentFolder.Equals("Inbox") && folderMail.UnreadItems != null && folderMail.UnreadItems.Count > 0)
                        UnreadMailFoldersCountLive += folderMail.UnreadItems.Count;
                }
                //Debug.WriteLine("UnreadMailFoldersCount: " + UnreadMailFoldersCountLive);
                this.labelUnreadFolders.Text = (UnreadMailFoldersCountLive > MAX_UNREAD_DISPLAYED) ? MAX_UNREAD_DISPLAYED.ToString() : UnreadMailFoldersCountLive.ToString();

                UpdateCountsUI();

                // CLEANUP allUnreadMailList to only include todaysMail
                // 1 of 2
                List<NewMailItem> oldReadMailPurgeList = new List<NewMailItem>();
                foreach (NewMailItem mail in allUnreadMailList)
                {
                    TimeSpan span = DateTime.Now.Subtract(mail.ReceivedTime);
                    if (span.TotalDays > 1)
                    {
                        //if (!mail.Unread)
                        //{
                        oldReadMailPurgeList.Add(mail);
                        Debug.WriteLine("MAIL OLDER THAN 1 DAY: " + span.TotalDays.ToString());
                        //}
                    }
                }   
                // CLEANUP allUnreadMailList to only include todaysMail
                // 2 of 2
                foreach (NewMailItem mail in oldReadMailPurgeList)
                {
                    int foundIndex = allUnreadMailList.FindIndex(0, allUnreadMailList.Count - 1, m => m.ID == mail.ID);
                    if (foundIndex >= 0)
                    {
                        Debug.WriteLine("OLD MAIL REMOVED AT INDEX: " + foundIndex);
                        allUnreadMailList.RemoveAt(foundIndex);
                    }
                }


                Debug.WriteLine("Done");

                return true;

            }
            catch (Exception ex)
            {

                // ex.Message = The RPC server is unavailable. (0x800706BA)
                // ex.ErrorCode = -2147023174
                if (ex.HResult == -2147023174)
                {
                    Application.Restart();
                    Environment.Exit(0);

                }

                Debug.WriteLine("RefreshNewMail Exception: " + ex.Message);
                return false;
            }
            finally
            {
                // Debug.WriteLine("DONE");
            }

        }




        /// <summary>
        /// Loop through the folders
        /// </summary>
        private void EnumerateFoldersInDefaultStore()
        {
            Outlook.Folder root = oApp.Session.DefaultStore.GetRootFolder() as Outlook.Folder;
            EnumerateFolders(root);
        }

        /// <summary>
        /// Uses recursion to enumerate Outlook folders.
        /// </summary>
        /// <param name="folder"></param>
        private void EnumerateFolders(Outlook.Folder folder)
        {
            Outlook.Folders childFolders = folder.Folders;

            // IF folders exit
            if (childFolders.Count > 0)
            {
                // Loop through folders
                foreach (Outlook.Folder childFolder in childFolders)
                {
                    if (childFolder != null && childFolder.Parent != null
                        && (childFolder.Name.Equals("Inbox") || ((Outlook.Folder)childFolder.Parent).Name.Equals("Inbox")))
                    {
                        // Get Parent Folder
                        Outlook.Folder parentFolder = childFolder.Parent;

                        // IGNORE folder if user does not want it scanned
                        if (parentFolder.Name.Equals("Inbox") && UserPreferencesList.IndexOf(childFolder.Name) == -1)
                            continue;


                        //Debug.WriteLine("*****");
                        //Debug.WriteLine(parentFolder.Name);
                        //Debug.WriteLine(childFolder.Name);


                        // Get all unread mail
                        Outlook.Items unreadItems = childFolder.Items.Restrict("[Unread]=true");


                        // ** CHILD FOLDERS **
                        // IF the parent folder is the inbox
                        // AND there is unread mail
                        // ** INBOX FOLDER **
                        // Must process unread mail through RefreshNewMailItemsList so the popup can receive it
                        if ((parentFolder.Name.Equals("Inbox") || childFolder.Name.Equals("Inbox"))
                            && unreadItems.Count > 0)
                        {
                            //Debug.WriteLine("--\nCreate NewFolderMail object");
                            //Debug.WriteLine("ParentFolder: " + parentFolder.Name);
                            //Debug.WriteLine("ChildFolder: " + childFolder.Name);
                            //Debug.WriteLine("UnreadItems.Count: " + unreadItems.Count);

                            NewFolderMail foldermail = new NewFolderMail();
                            foldermail.ParentFolder = parentFolder.Name;
                            foldermail.ChildFolder = childFolder.Name;
                            foldermail.UnreadItems = unreadItems;

                            // Only add if parent is Inbox as Inbox itself was already added in RefreshNewMail()
                            if (parentFolder.Name.Equals("Inbox"))
                                runningUnreadFolderList.Add(foldermail);

                            RefreshNewMailItemsList(parentFolder.Name, childFolder.Name, foldermail);

                        }

                        // Call EnumerateFolders using childFolder.
                        EnumerateFolders(childFolder);



                    }
                }
            }
        }



        /// <summary>
        /// Only refresh with new mail.
        /// Must check to see if the mail was already accounted for previously
        /// </summary>
        /// <param name="folderMail"></param>
        private void RefreshNewMailItemsList(string parentFolder, string childFolder, NewFolderMail folderMail)
        {
            // VALIDATION
            if (folderMail.UnreadItems == null || folderMail.UnreadItems.Count == 0)
                return;

            // Filter only todays new mail for performance
            Outlook.Items todayUnreadMailItems = folderMail.UnreadItems.Restrict("[ReceivedTime] > '" + DateTime.Today.ToString("MM/dd/yyyy HH:mm") + "'");
            todayUnreadMailItems.Sort("[ReceivedTime]", Outlook.OlSortOrder.olAscending);

            //Debug.WriteLine("FOLDER: " + childFolder);
            //Debug.WriteLine("TOTAL1: " + folderMail.UnreadItems.Count);
            //Debug.WriteLine("TOTAL2: " + todayUnreadMailItems.Count);
            //Debug.WriteLine("DATENOW: " + DateTime.Today.ToString("MM/dd/yyyy HH:mm"));

            // VALIDTION ON FILTER (Today Only)
            if (todayUnreadMailItems.Count == 0)
                return;



            // GET NEW MAIL
            for (int i = 1; i <= todayUnreadMailItems.Count; i++)
            {
                try
                {
                    Outlook.MailItem msg = todayUnreadMailItems[i];

                    //Debug.WriteLine("MSG RECEIVED: " + msg.ReceivedTime);


                    NewMailItem existingItem = allUnreadMailList.Find(m => m.ID == msg.EntryID);

                    //if (msg.ReceivedTime.CompareTo(LastRunTimeStamp) > 0)
                    if (existingItem.ID == null)
                    {
                        NewMailItem newMailItem = new NewMailItem();
                        newMailItem.ID = msg.EntryID;
                        newMailItem.ParentFolder = parentFolder;
                        newMailItem.ChildFolder = childFolder;
                        newMailItem.From = msg.SenderName;
                        newMailItem.To = msg.To;
                        newMailItem.Subject = msg.Subject;
                        newMailItem.Body = msg.Body;
                        newMailItem.Priority = msg.Importance;
                        newMailItem.Message = msg;
                        newMailItem.ReceivedTime = msg.ReceivedTime;// DateTime.Now; 

                        allUnreadMailList.Add(newMailItem); //TODO: Cleanup. Remove items from allUnreadMailList that are not in todayMailItems
                        if (!FirstRun)
                            newUnreadMailList.Add(newMailItem);

                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine("RefreshNewMailItemsList Error: " + e.Message);
                    continue;
                }
            }

        }



        #endregion



        #region BUTTON HANDLERS


        /// <summary>
        /// Disconnects from Outlook
        /// UNUSED at this time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Disconnect(object sender, EventArgs e)
        {
            //Log off.
            oNS.Logoff();

            //Explicitly release objects.
            oMsg = null;
            oItems = null;
            oInbox = null;
            oNS = null;
            oApp = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings(oApp, this);
            settingsWindow.StartPosition = FormStartPosition.CenterScreen;
            settingsWindow.ShowDialog();
        }



        /// <summary>
        /// Toggles showing/hiding the widget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void widgetHideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (widgetHideShowToolStripMenuItem.Text.Equals("Show"))
            {
                this.Show();
                widgetHideShowToolStripMenuItem.Text = "Hide";
            }
            else
            {
                this.Hide();
                widgetHideShowToolStripMenuItem.Text = "Show";
            }
        }




        /// <summary>
        /// Show Inbox LIST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxInbox_Click(object sender, EventArgs e)
        {
            ShowUnreadInListFormat(true);
        }

        /// <summary>
        /// Show Folders LIST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxFolders_Click(object sender, EventArgs e)
        {
            ShowUnreadInListFormat(false);
        }

        /// <summary>
        /// Show Folders/Inbox LIST
        /// </summary>
        /// <param name="showInbox"></param>
        private void ShowUnreadInListFormat(bool showInbox)
        {

            List<PreviewListItem> previewListItemsList = new List<PreviewListItem>();

            try
            {
                foreach (NewFolderMail folder in runningUnreadFolderList)
                {

                    if (folder.ChildFolder.Equals("Inbox") == showInbox)
                    {
                        if (folder.UnreadItems == null)
                            continue;

                        Outlook.Items unreadMailInFolder = folder.UnreadItems;
                        unreadMailInFolder.Sort("[ReceivedTime]", Outlook.OlSortOrder.olAscending);

                        foreach (Outlook.MailItem mail in unreadMailInFolder)
                        {
                            //MessageBox.Show("Mail: " + folder.ChildFolder + "\n" + mail.SenderName + "\n" + mail.Subject + "\n" + mail.ReceivedTime);
                            PreviewListItem previewListItem = new PreviewListItem();
                            previewListItem.Folder = folder.ChildFolder;
                            previewListItem.SenderName = mail.SenderName;
                            previewListItem.Subject = mail.Subject;
                            previewListItem.ReceivedTime = mail.ReceivedTime;
                            previewListItem.Message = mail;

                            previewListItemsList.Add(previewListItem);
                        }

                    }
                }
            }
            catch (Exception ex)
            { }
            finally
            {
                if (previewListWindow != null && previewListWindow.Visible)
                    previewListWindow.Close();

                previewListWindow = new PreviewListWindow(this.Location.X, this.Height, previewListItemsList);
            }

        }


        #endregion



        /// <summary>
        /// User folder preference list
        /// ONLY scan these folders
        /// </summary>
        /// <param name="userPreferencesList"></param>
        public void SetUserPreferencesList(List<String> userPreferencesList)
        {
            this.UserPreferencesList = userPreferencesList;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings(oApp, this);
            settingsWindow.StartPosition = FormStartPosition.CenterScreen;
            settingsWindow.ShowDialog();
        }
    }
}
