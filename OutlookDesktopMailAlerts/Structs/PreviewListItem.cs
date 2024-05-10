using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookDesktopMailAlerts.Structs
{
    public struct PreviewListItem
    {
        public string Folder;
        public string SenderName;
        public string Subject;

        public DateTime ReceivedTime;

        public Outlook.MailItem Message;
    }
}
