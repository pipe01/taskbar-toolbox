using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using ImageMagick;
using IWshRuntimeLibrary;
using System.Collections.Generic;

namespace Toolbox_Editor
{
    class Util
    {
        public static Toolbox tlb;
        public static SteamSerial steam = new SteamSerial();

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
          Form form = new Form();
          Label label = new Label();
          TextBox textBox = new TextBox();
          Button buttonOk = new Button();
          Button buttonCancel = new Button();

          form.Text = title;
          label.Text = promptText;
          textBox.Text = value;

          buttonOk.Text = "OK";
          buttonCancel.Text = "Cancel";
          buttonOk.DialogResult = DialogResult.OK;
          buttonCancel.DialogResult = DialogResult.Cancel;

          label.SetBounds(9, 20, 372, 13);
          textBox.SetBounds(12, 36, 372, 20);
          buttonOk.SetBounds(228, 72, 75, 23);
          buttonCancel.SetBounds(309, 72, 75, 23);

          label.AutoSize = true;
          textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
          buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
          buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

          form.ClientSize = new Size(396, 107);
          form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
          form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
          form.FormBorderStyle = FormBorderStyle.FixedDialog;
          form.StartPosition = FormStartPosition.CenterScreen;
          form.MinimizeBox = false;
          form.MaximizeBox = false;
          form.AcceptButton = buttonOk;
          form.CancelButton = buttonCancel;

          DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.Cancel) {
                value = null;
            } else { value = textBox.Text; }
          return dialogResult;
        }

        public static string getToolboxesPath()
        {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Toolboxes/";
        }
        public static string getCurrentToolboxPath()
        {
            return getToolboxesPath() + tlb.name + "/";
        }

        public static void png2ico(string path1, string path2)
        {
            using (MagickImage image = new MagickImage(path1))
            {
                // Sets the output format to jpeg
                image.Format = MagickFormat.Ico;
                image.Write(path2);
            }
        }

        public static void createShortcut()
        {
            var wsh = new IWshShell_Class();
            IWshShortcut shortcut = wsh.CreateShortcut(Util.getToolboxesPath() + Util.tlb.name + ".lnk") as IWshRuntimeLibrary.IWshShortcut;
            shortcut.TargetPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\toolbox.exe";
            shortcut.IconLocation = Util.getToolboxesPath() + Util.tlb.name + "/icon.ico";
            shortcut.Arguments = Util.tlb.name;
            shortcut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            shortcut.Save();
        }

        public static IWshShortcut getShortcut(string path)
        {
            IWshShortcut shortcut = null;
            if (System.IO.File.Exists(path))
            {
                var wsh = new IWshShell_Class();
                shortcut = wsh.CreateShortcut(path);
            }
            return shortcut;
        }

        public static IWshURLShortcut getUrlShortcut(string path)
        {
            IWshURLShortcut shortcut = null;
            if (System.IO.File.Exists(path))
            {
                var wsh = new IWshShell_Class();
                shortcut = wsh.CreateShortcut(path);
            }
            return shortcut;
        }
    }
}
