using Outlook = Microsoft.Office.Interop.Outlook;


namespace OutlookDesktopMailAlerts.Structs
{

    public struct NewMailItem
    {
        public string ID;
        public string ParentFolder;
        public string ChildFolder;
        public string From;
        public string To;
        public string Subject;
        public string Body;
        public Outlook.OlImportance Priority;

        public Outlook.MailItem Message;

        public bool Unread;
        public DateTime LastUpdate;
        


    }

}
