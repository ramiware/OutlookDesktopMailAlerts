using OutlookDesktopMailAlerts.Common;
using OutlookDesktopMailAlerts.CustomUI;
using OutlookDesktopMailAlerts.Structs;
using System.Runtime.InteropServices;

namespace OutlookDesktopMailAlerts
{
    public partial class PreviewListWindow : Form
    {
        private const int WINDOW_ROUNDED_CORNERS = 20;

        private int parentWindowLocationX;
        private int parentWindowHeight;

        private List<PreviewListItem> previewListItemsList = new List<PreviewListItem>();


        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="parentWindowLocationX"></param>
        /// <param name="parentWindowHeight"></param>
        public PreviewListWindow(int parentWindowLocationX, int parentWindowHeight, List<PreviewListItem> previewListItemsList)
        {
            InitializeComponent();

            this.parentWindowLocationX = parentWindowLocationX;
            this.parentWindowHeight = parentWindowHeight;
            this.previewListItemsList = previewListItemsList;

            InitializeUI();

            LoadMessages();
            this.Refresh();
            this.Show();
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
            this.BackColor = AppTheme.COLOR_ACCENT;
            this.panelBG.BackColor = AppTheme.COLOR_DARK;
            this.ForeColor = AppTheme.COLOR_TEXT;
            this.panelBG.ForeColor = AppTheme.COLOR_TEXT;

            // Override form to create rounded corners
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, WINDOW_ROUNDED_CORNERS, WINDOW_ROUNDED_CORNERS));

            // Set default location to screen bottom-right
            this.SetBounds(parentWindowLocationX,// Screen.GetWorkingArea(this).Width - this.Width
                           Screen.GetWorkingArea(this).Height - this.Height - parentWindowHeight, this.Width, this.Height);


        }


        /// <summary>
        /// /// Called from parent. Docks popup as per user request for app docking
        /// </summary>
        /// <param name="x"></param>
        public void SetDockLocationX(int x)
        {
            this.SetBounds(x,
                           Screen.GetWorkingArea(this).Height - this.Height, this.Width, this.Height);

        }



        #endregion


        /// <summary>
        /// 
        /// </summary>
        private void LoadMessages()
        {
            if (previewListItemsList == null || previewListItemsList.Count == 0)
                return;

            foreach(PreviewListItem item in previewListItemsList)
            {
                UnreadMailBlock mailBlock = new UnreadMailBlock(item.Folder, item.SenderName, item.Subject, item.ReceivedTime.ToString(), item.Message);
                flowLayoutPreviewList.Controls.Add(mailBlock);
            }
        }

        /// <summary>
        /// Close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
