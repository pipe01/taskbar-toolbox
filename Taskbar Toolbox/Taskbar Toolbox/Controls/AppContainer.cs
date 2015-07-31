using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Taskbar_Toolbox
{
    public partial class AppContainer : UserControl
    {
        public AppContainer()
        {
            InitializeComponent();
        }

        private Toolbox toolbox;
        public Toolbox Toolbox{
            get{
                return toolbox;
            }
            set{
                this.toolbox = value;
                foreach (AppControl item in this.flpApps.Controls)
                {
                    item.toolbox = value;
                }
                refreshApps();
            }
        }

        private void refreshApps()
        {
            foreach (App app in this.toolbox.appList.Values)
            {
                AppControl control = new AppControl();
                control.controlApp = app;
                control.appClicked += appClicked;
                control.toolbox = this.toolbox;
                this.flpApps.Controls.Add(control);
                control = null;
            }
        }

        private void appClicked(object sender, EventArgs e)
        {
            toolbox.save();
            Process.Start(((AppControl) sender).controlApp.path);
            Program.form.close();
        }

        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
