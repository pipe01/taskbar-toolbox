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
            }
        }

        private void refreshApps()
        {
            foreach (App app in this.toolbox.appList.Values)
            {
                AppControl control = new AppControl();
                control.controlApp = app;
                this.flpApps.Controls.Add(control);
                control = null;
            }
        }

        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
