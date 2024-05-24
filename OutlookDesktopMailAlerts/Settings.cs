using Microsoft.Office.Interop.Outlook;
using OutlookDesktopMailAlerts.Common;
using System.Runtime.InteropServices;
using static System.Windows.Forms.CheckedListBox;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookDesktopMailAlerts
{
    public partial class Settings : Form
    {
        private const int WINDOW_ROUNDED_CORNERS = 20;

        private const string FOLDER_SCAN_FILENAME = "FolderScanList.txt";
        private String appDataFolder = "";

        private Outlook.Application oApp;
        private List<string> outlookFolderList = new List<string>();

        private List<string> userFolderPreferencesList = new List<string>();

        private MainWindow mainWindowRef = null;


        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="outlookApplication"></param>

        public Settings(Outlook.Application outlookApplication, MainWindow mainWindow)
        {
            InitializeComponent();
            InitializeUI();

            appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Ramiware\" + AppVersion.APP_ID);

            this.oApp = outlookApplication;
            this.mainWindowRef = mainWindow;
            LoadData();
        }

        #region UI


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

        /// <summary>
        /// Configure the UI for startup
        /// </summary>
        private void InitializeUI()
        {
            // Colors
            this.BackColor = AppTheme.COLOR_DARK;
            this.panelNav.BackColor = AppTheme.COLOR_LIGHT;
            this.panelNav.ForeColor = AppTheme.COLOR_TEXT;

            foreach (TabPage tabPage in tabControlSettings.TabPages)
            {
                tabPage.BackColor = AppTheme.COLOR_DARK;
                tabPage.ForeColor = AppTheme.COLOR_TEXT;
            }

            // Folders colors
            checkedListFolders.BackColor = AppTheme.COLOR_DARK;
            checkedListFolders.ForeColor = AppTheme.COLOR_TEXT;



            // Override form to create rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, WINDOW_ROUNDED_CORNERS, WINDOW_ROUNDED_CORNERS));

            // Set default location to screen bottom-right
            this.SetBounds(Screen.GetWorkingArea(this).Width - this.Width
            , Screen.GetWorkingArea(this).Height - this.Height, this.Width, this.Height);


            tabControlSettings.Appearance = TabAppearance.FlatButtons;
            tabControlSettings.ItemSize = new Size(0, 1);
            tabControlSettings.SizeMode = TabSizeMode.Fixed;

            labelAppName.Text = AppVersion.APP_ID;
            labelVersion.Text = AppVersion.APP_VERSION;
            labelReleaseDate.Text = AppVersion.APP_LAST_UPDATED;
            labelAbout.Text = AppVersion.APP_INFO;

            labelFoldersInstructions.Text = "Only selected folders will be scanned.\nUncheck any folders you want to ignore.";

        }


        #endregion


        #region NAV

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void buttonFolders_Click(object sender, EventArgs e)
        {
            buttonFolders.BackColor = AppTheme.COLOR_ACCENT;
            buttonAbout.BackColor = AppTheme.COLOR_LIGHT;
            tabControlSettings.SelectedIndex = 0;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            buttonAbout.BackColor = AppTheme.COLOR_ACCENT;
            buttonFolders.BackColor = AppTheme.COLOR_LIGHT;

            tabControlSettings.SelectedIndex = 1;

        }

        #endregion



        /// <summary>
        /// Load the folder names and lists
        /// Load user preferences.
        /// IF user preferences don't exist, create and default to ALL folders
        /// </summary>
        private void LoadData()
        {
            //this.checkedListFolders.Items.Add("Inbox");

            // -----------------------------------------------------------
            // GET OUTLOOK FOLDERS
            // -----------------------------------------------------------
            // Get full folder list from Outlook
            outlookFolderList.Clear();
            Folder root = oApp.Session.DefaultStore.GetRootFolder() as Folder;
            EnumerateFolders(root);

            // Sort and add list to ui (CheckBoxList)
            outlookFolderList.Sort();
            foreach (string folder in outlookFolderList)
                this.checkedListFolders.Items.Add(folder);


            // -----------------------------------------------------------
            // GET USER PREFERENCES
            // -----------------------------------------------------------
            // Read user file into list
            // IF user file does not exist yet, create it. Set all folders to selected.
            string folderScanFile = appDataFolder + @"\" + FOLDER_SCAN_FILENAME;
            if (File.Exists(folderScanFile))
            {
                // Read file using StreamReader. Reads file line by line
                using (StreamReader file = new StreamReader(folderScanFile))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        userFolderPreferencesList.Add(ln);
                        counter++;
                    }
                    file.Close();
                    //Console.WriteLine($ "File has {counter} lines.");

                    // Select the folders based on the user preferences
                    for (int i = 0; i < checkedListFolders.Items.Count; i++)
                    {
                        if (userFolderPreferencesList.IndexOf(checkedListFolders.Items[i].ToString()) >= 0)
                            checkedListFolders.SetItemChecked(i, true);
                        else
                            checkedListFolders.SetItemChecked(i, false);
                    }

                }
            }
            else
            {
                // IF user file does not exist yet, create it. Set all folders to selected.
                SaveData(outlookFolderList);
                checkBoxSelectAll.Checked = true;
                for (int i = 0; i < checkedListFolders.Items.Count; i++)
                {
                    checkedListFolders.SetItemChecked(i, true);
                    userFolderPreferencesList.Add(checkedListFolders.Items[i].ToString());
                }
                SaveData(userFolderPreferencesList);
            }
        }


        /// <summary>
        /// Uses recursion to enumerate Outlook folders.
        /// </summary>
        /// <param name="folder"></param>
        private void EnumerateFolders(Folder folder)
        {
            Folders childFolders = folder.Folders;


            // IF folders exit
            if (childFolders.Count > 0)
            {
                // Loop through folders
                foreach (Folder childFolder in childFolders)
                {
                    // Only look at the Inbox's folders
                    //if (childFolder.FolderPath.Contains(@"\Inbox"))
                    //{

                    // Get Parent Folder
                    Folder parentFolder = childFolder.Parent;

                    // ** CHILD FOLDERS **
                    // IF the parent folder is the "Inbox"
                    if (parentFolder.Name.Equals("Inbox"))
                    {
                        //Debug.WriteLine("ParentFolder: " + parentFolder.Name);
                        //Debug.WriteLine("ChildFolder: " + childFolder.Name);

                        outlookFolderList.Add(childFolder.Name);
                        //this.checkedListFolders.Items.Add(parentFolder.Name + @"\" + childFolder.Name);

                    }

                    // Call EnumerateFolders using childFolder.
                    EnumerateFolders(childFolder);
                    //}
                }
            }
        }



        /// <summary>
        /// Save selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            userFolderPreferencesList = new List<string>();

            CheckedItemCollection checkedItemCollection = checkedListFolders.CheckedItems;
            List<String> checkedItemCollectionAsStringList = new List<String>();

            // Convert checkedItemCollection to string list
            foreach (String checkedListBox in checkedItemCollection)
            {
                checkedItemCollectionAsStringList.Add(checkedListBox);
                userFolderPreferencesList.Add(checkedListBox);
            }

            // Save data to file
            SaveData(checkedItemCollectionAsStringList);

            // Set MainWindow UserPreferencesList reference
            mainWindowRef.SetUserPreferencesList(userFolderPreferencesList);

        }

        /// <summary>
        /// Process saving folder selections
        /// </summary>
        /// <param name="folderList"></param>
        private void SaveData(List<string> folderList)
        {
            FileStream foldersFile = null;
            try
            {
                // Create Path if it does not exist - appDataFolder
                if (!Directory.Exists(appDataFolder))
                    Directory.CreateDirectory(appDataFolder);

                // Create File if it does not exist - FOLDER_SCAN_FILENAME
                if (!File.Exists(appDataFolder + @"\" + FOLDER_SCAN_FILENAME))
                {
                    foldersFile = File.Create(appDataFolder + @"\" + FOLDER_SCAN_FILENAME);
                    foldersFile.Close();
                }

                // Write selected folders to file
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(appDataFolder, FOLDER_SCAN_FILENAME)))
                {
                    foreach (String userFolderSelected in folderList)
                        outputFile.WriteLine(userFolderSelected);
                }

                MessageBox.Show("Settings saved successfully", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("An Error occurred while trying to save your settings. You may not have write privelages." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (foldersFile != null)
                    foldersFile.Close();
                return;
            }
        }

        /// <summary>
        /// Toggle select/unselect all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedTarget = (checkBoxSelectAll.Checked) ? true : false;

            for (int i = 0; i < checkedListFolders.Items.Count; i++)
            {
                checkedListFolders.SetItemChecked(i, checkedTarget);

            }
        }


        /// <summary>
        /// PUBLIC
        /// Returns the userPreferencesList folder list
        /// Only folders in this list should be scanned for new mail
        /// </summary>
        /// <returns></returns>
        public List<String> GetUserFolderPreferences()
        {
            if (userFolderPreferencesList == null || userFolderPreferencesList.Count == 0)
                return new List<string>();

            return userFolderPreferencesList;
        }

        /// <summary>
        /// Ensure the user cannot toggle the Inbox checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxInboxReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxInboxReadOnly.Checked)
                checkBoxInboxReadOnly.Checked = true;
        }
    }
}
