using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenSnap;

namespace Taskbar_Toolbox
{
    public partial class ToolboxForm : Form
    {
        public ToolboxForm()
        {
            InitializeComponent();
            this.Region = Util.GetRoundRegion(this.Width, this.Height, 15);
        }

        private Toolbox tlb;

        public void setToolbox(Toolbox tlb)
        {
            this.tlb = tlb;
            this.appContainer.Toolbox = tlb;
            this.picIcon.BackgroundImage = tlb.icon;
            this.lblName.Text = tlb.name;
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
            tlb.save();
            this.Close();
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
    }
}
