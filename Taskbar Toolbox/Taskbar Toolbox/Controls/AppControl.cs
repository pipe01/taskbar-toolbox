using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskbar_Toolbox
{
    public partial class AppControl : UserControl
    {
        public AppControl()
        {
            InitializeComponent();
        }

        public event EventHandler appClicked;

        public Color bgColor = Color.White;
        public Color bgColorHover = Color.FromArgb(200, 200, 200);

        private App app;
        public App controlApp
        {
            get { return app; }
            set {
                app = value;
                if (app == null) { return; }
                this.picIcono.BackgroundImage = null; //Image.FromFile("");
                this.lblNombre.Text = app.name;
            }
        }

        private void AppControl_Click(object sender, EventArgs e)
        {
            appClicked(this, EventArgs.Empty);
        }

        private void AppControl_Enter(object sender, EventArgs e)
        {
            this.BackColor = bgColorHover;
        }

        private void AppControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = bgColor;
        }

        private void AppControl_Load(object sender, EventArgs e)
        {
            this.Region = Util.GetRoundRegion(this.Width, this.Height, 20);
        }
    }
}
