using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Taskbar_Toolbox
{
    static class Util
    {
        #region "Round shape"
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

        #region "Delete util"
        public static List<string> files = new List<string>();
        public static List<string> folders = new List<string>();

        public static void addFile(string path)
        {
            files.Add(path);
        }
        public static void addDir(string path)
        {
            folders.Add(path);
        }
        public static void deleteFiles()
        {
            foreach (var item in files)
            {
                try{ File.Delete(item); }
                catch (Exception){  }
            }
        }
        public static void deleteFolders()
        {
            foreach (var item in folders)
            {
                try { Directory.Delete(item); }
                catch (Exception) { }
            }
        }
        #endregion

        public static Color BlendColor(this Color color, Color backColor, double amount)
        {
            byte r = (byte)((color.R * amount) + backColor.R * (1 - amount));
            byte g = (byte)((color.G * amount) + backColor.G * (1 - amount));
            byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
            return Color.FromArgb(r, g, b);
        }

        public static void forceCopy(string path1, string path2)
        {
            bool succeed = false;
            while (succeed == false)
            {
                System.IO.File.Copy(path1, path2);
            }
        }

        public static void DeleteDirectory(string path)
        {
            DeleteDirectory(path, false);
        }
        public static void DeleteDirectory(string path, bool recursive)
        {
            // Delete all files and sub-folders?
            if (recursive)
            {
                // Yep... Let's do this
                var subfolders = Directory.GetDirectories(path);
                foreach (var s in subfolders)
                {
                    DeleteDirectory(s, recursive);
                }
            }

            // Get all files of the folder
            var files = Directory.GetFiles(path);
            foreach (var f in files)
            {
                // Get the attributes of the file
                var attr = File.GetAttributes(f);

                // Is this file marked as 'read-only'?
                if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    // Yes... Remove the 'read-only' attribute, then
                    File.SetAttributes(f, attr ^ FileAttributes.ReadOnly);
                }

                // Delete the file
                    //File.Delete(f);
                addFile(f);
            }

            // When we get here, all the files of the folder were
            // already deleted, so we just delete the empty folder
                //Directory.Delete(path);
            addDir(path);
        }

        public static void MoveDirectory(string path1, string path2)
        {
            Directory.CreateDirectory(path2);

            var files = Directory.GetFiles(path1);
            foreach (var f in files)
            {
                // Get the attributes of the file
                var attr = File.GetAttributes(f);

                // Is this file marked as 'read-only'?
                if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    // Yes... Remove the 'read-only' attribute, then
                    File.SetAttributes(f, attr ^ FileAttributes.ReadOnly);
                }

                // Delete the file
                File.Copy(f, path2 + "/" + Path.GetFileName(f), true);
            }

            DeleteDirectory(path1);
        }

        public static List<Control> getControls(string what, Control where)
        {
            List<Control> controles = new List<Control>();
            foreach (Control c in where.Controls)
            {
                if (c.GetType().Name == what)
                {
                    controles.Add(c);
                }
                else if (c.Controls.Count > 0)
                {
                    controles.AddRange(getControls(what, c));
                }
            }
            return controles;
        }
        public static List<Control> getControls(Control where)
        {
            List<Control> controles = new List<Control>();
            foreach (Control c in where.Controls)
            {
                controles.Add(c);
                if (c.Controls.Count > 0)
                {
                    controles.AddRange(getControls(c));
                }
            }
            return controles;
        }

        public static string getToolboxesPath()
        {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Toolboxes/";
        }
    }
}
