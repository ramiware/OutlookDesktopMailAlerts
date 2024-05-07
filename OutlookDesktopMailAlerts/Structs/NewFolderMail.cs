using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookDesktopMailAlerts.Structs
{

    public struct NewFolderMail
    {
        public string ChildFolder;
        public string ParentFolder;
        public Outlook.Items UnreadItems;
        public DateTime LastUpdate;
    }

}
