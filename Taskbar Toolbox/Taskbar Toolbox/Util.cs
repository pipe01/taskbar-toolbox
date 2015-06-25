using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Taskbar_Toolbox
{
    static class Util
    {
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

        public static Color BlendColor(this Color color, Color backColor, double amount)
        {
            byte r = (byte)((color.R * amount) + backColor.R * (1 - amount));
            byte g = (byte)((color.G * amount) + backColor.G * (1 - amount));
            byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
            return Color.FromArgb(r, g, b);
        }
    }
}
