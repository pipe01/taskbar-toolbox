using System;
using System.Drawing;
using System.Windows.Forms;
using ScreenSnap;

namespace Taskbar_Toolbox
{
    public partial class ToolboxForm : Form
    {
        public ToolboxForm()
        {
            InitializeComponent();
            this.Region = WinAPI.GetRoundRegion(this.Width, this.Height, 15);
        }

        private Toolbox tlb;

        public void setToolbox(Toolbox tlb)
        {
            this.tlb = tlb;
            this.appContainer.Toolbox = tlb;
            this.picIcon.BackgroundImage = tlb.icon;
            this.lblName.Text = tlb.name;
            this.Location = tlb.position;
            this.BackColor = tlb.bgColor;
        }

        private bool dragging;
        private int x1, y1;

        private void picIcon_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            x1 = e.X;
            y1 = e.Y;
        }

        private void picIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                int x, y;
                x = this.Location.X;
                y = this.Location.Y;
                this.Location = new Point(x + (e.X - x1), y + (e.Y - y1));
                this.appContainer.Toolbox.position = this.Location;
            }
        }

        private void picIcon_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ToolboxForm_Shown(object sender, EventArgs e)
        {
            this.Location = tlb.position;
        }

        private void ToolboxForm_Deactivate(object sender, EventArgs e)
        {
            this.BringToFront();
            tlb.save();
            close();
        }

        private void lblEditar_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("toolboxeditor.exe", this.tlb.name);
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            
            switch (m.Msg)
            {
                case Snapper.WM_WINDOWPOSCHANGING:
                    Snapper.SnapToDesktopBorder(this, m.LParam, 0, 5, 5);
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        private const int CS_DROPSHADOW = 0x20000;

        private void ToolboxForm_Load(object sender, EventArgs e)
        {
            this.Location = tlb.position;
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.AW_SLIDE + WinAPI.AW_VER_NEGATIVE);
        }

        private void ToolboxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
        }

        public void close()
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.AW_SLIDE + WinAPI.AW_VER_POSITIVE + WinAPI.AW_HIDE);
            Application.Exit();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
