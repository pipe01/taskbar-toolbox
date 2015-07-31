using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Toolbox_Editor
{
    class WinAPI
    {
        /// <span class="code-SummaryComment"><summary></span>
        /// Animates the window from left to right. 
        /// This flag can be used with roll or slide animation.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_HOR_POSITIVE = 0X1;
        /// <span class="code-SummaryComment"><summary></span>
        /// Animates the window from right to left. 
        /// This flag can be used with roll or slide animation.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_HOR_NEGATIVE = 0X2;
        /// <span class="code-SummaryComment"><summary></span>
        /// Animates the window from top to bottom. 
        /// This flag can be used with roll or slide animation.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_VER_POSITIVE = 0X4;
        /// <span class="code-SummaryComment"><summary></span>
        /// Animates the window from bottom to top. 
        /// This flag can be used with roll or slide animation.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_VER_NEGATIVE = 0X8;
        /// <span class="code-SummaryComment"><summary></span>
        /// Makes the window appear to collapse inward 
        /// if AW_HIDE is used or expand outward if the AW_HIDE is not used.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_CENTER = 0X10;
        /// <span class="code-SummaryComment"><summary></span>
        /// Hides the window. By default, the window is shown.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_HIDE = 0X10000;
        /// <span class="code-SummaryComment"><summary></span>
        /// Activates the window.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_ACTIVATE = 0X20000;
        /// <span class="code-SummaryComment"><summary></span>
        /// Uses slide animation. By default, roll animation is used.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_SLIDE = 0X40000;
        /// <span class="code-SummaryComment"><summary></span>
        /// Uses a fade effect. 
        /// This flag can be used only if hwnd is a top-level window.
        /// <span class="code-SummaryComment"></summary></span>
        public const int AW_BLEND = 0X80000;
        /// <span class="code-SummaryComment"><summary></span>
        /// Animates a window.
        /// <span class="code-SummaryComment"></summary></span>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow
        (IntPtr hwand, int dwTime, int dwFlags);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern System.IntPtr CreateRoundRectRgn
        (
         int nLeftRect, // x-coordinate of upper-left corner
         int nTopRect, // y-coordinate of upper-left corner
         int nRightRect, // x-coordinate of lower-right corner
         int nBottomRect, // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(System.IntPtr hObject);

        public static Region GetRoundRegion(int width, int height, int roundRadius)
        {
            return GetRoundRegion(width, height, roundRadius, roundRadius);
        }
        public static Region GetRoundRegion(int width, int height, int roundWidth, int roundHeight)
        {
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, width, height, roundWidth, roundHeight);
            Region rg = Region.FromHrgn(ptr);
            DeleteObject(ptr);
            return rg;
        }
    }
}
