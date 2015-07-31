using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Toolbox_Editor
{
    public partial class frmAddApp : Form
    {
        public frmAddApp()
        {
            InitializeComponent();
        }

        public App currentApp;

        private void updateAppInfo()
        {
            txtAppName.Text = currentApp.name;
            txtAppID.Text = currentApp.id;
            txtPath.Text = currentApp.path;
        }

        private void btnShortCut_Click(object sender, EventArgs e)
        {
            openShortcut.ShowDialog();
            if (openShortcut.FileName != "")
            {
                if (Path.GetExtension(openShortcut.FileName) == ".lnk")
                {
                    var shortcut = Util.getShortcut(openShortcut.FileName);
                    currentApp = new App();
                    currentApp.name = Path.GetFileNameWithoutExtension(openShortcut.FileName);
                    string txt = currentApp.name.Replace(" ", "").ToLower();
                    currentApp.id = txt;
                    currentApp.path = shortcut.TargetPath;
                    updateAppInfo();
                    picIcono.BackgroundImage = Icon.ExtractAssociatedIcon(currentApp.path).ToBitmap();
                } else if (Path.GetExtension(openShortcut.FileName) == ".url") {
                    var shortcut = Util.getUrlShortcut(openShortcut.FileName);
                    currentApp = new App();
                    currentApp.name = Path.GetFileNameWithoutExtension(openShortcut.FileName);
                    string txt = currentApp.name.Replace(" ", "").ToLower();
                    currentApp.id = txt;
                    currentApp.path = shortcut.TargetPath;
                    updateAppInfo();
                }
                picIcono.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void picIcono_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (picIcono.BackgroundImage != null)
            {
                button1.Enabled = true;
                picIcono.BackgroundImage.Save(Util.getToolboxesPath() + Util.tlb.name +
                        "/" + currentApp.id + ".png");
            }
        }

        private void picIcono_Click(object sender, EventArgs e)
        {
            openImage.ShowDialog();
            if (File.Exists(openImage.FileName))
            {
                Image img = Image.FromFile(openImage.FileName);
                picIcono.BackgroundImage = img;
            }
        }

        private void txtAppID_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Util.getToolboxesPath() + Util.tlb.name + "/" + currentApp.id + ".png"))
            {
                File.Move(Util.getToolboxesPath() + Util.tlb.name + "/" + currentApp.id + ".png",
                      Util.getToolboxesPath() + Util.tlb.name + "/" + txtAppID.Text + ".png");
                currentApp.id = txtAppID.Text;
            }
        }
    }
}
