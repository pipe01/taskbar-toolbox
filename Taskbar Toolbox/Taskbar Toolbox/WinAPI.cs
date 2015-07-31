using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Taskbar_Toolbox
{
    class WinAPI
    {
        #region "AnimateWindow"
        public const int AW_HOR_POSITIVE = 0X1;
        public const int AW_HOR_NEGATIVE = 0X2;
        public const int AW_VER_POSITIVE = 0X4;
        public const int AW_VER_NEGATIVE = 0X8;
        public const int AW_CENTER = 0X10;
        public const int AW_HIDE = 0X10000;
        public const int AW_ACTIVATE = 0X20000;
        public const int AW_SLIDE = 0X40000;
        public const int AW_BLEND = 0X80000;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow
        (IntPtr hwand, int dwTime, int dwFlags);
        #endregion

        #region "RoundRegion"
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
        #endregion

    }
}
