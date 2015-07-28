using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private Toolbox toolbox_;
        public Toolbox toolbox
        {
            get
            {
                return toolbox_;
            }
            set
            {
                this.toolbox_ = value;
                string path = Util.getToolboxesPath() + this.toolbox_.name + "/" + app.id + ".png";
                if (File.Exists(path))
                {
                    this.picIcono.BackgroundImage = Image.FromFile(path);
                }
                else
                {
                    this.picIcono.BackgroundImage = Icon.ExtractAssociatedIcon(app.path).ToBitmap();
                }
            }
        }

        private App app;
        public App controlApp
        {
            get { return app; }
            set {
                app = value;
                if (app == null) { return; }
                try{
                    this.picIcono.BackgroundImage = Icon.ExtractAssociatedIcon(app.path).ToBitmap();
                } catch (Exception) { 
                    //throw
                }
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
            this.BackColor = bgColor;
        }
    }
}
