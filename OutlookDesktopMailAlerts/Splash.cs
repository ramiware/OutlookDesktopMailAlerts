using OutlookDesktopMailAlerts.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDesktopMailAlerts
{
    public partial class Splash : Form
    {
        public Splash()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            InitializeUI();
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
            this.labelProgress.Text = "Loading Mail";

            this.BackColor = AppTheme.COLOR_LIGHT;
            this.panelBox.BackColor = AppTheme.COLOR_DARK;
            this.ForeColor = AppTheme.COLOR_TEXT;

            // Override form to create rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, AppTheme.ROUND_CORNERS, AppTheme.ROUND_CORNERS));

            // Set default location to screen bottom-right
            this.SetBounds(Screen.GetWorkingArea(this).Width - this.Width
            , Screen.GetWorkingArea(this).Height - this.Height, this.Width, this.Height);

        }
    }
}
