using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskbar_Toolbox
{
    public partial class ToolboxForm : Form
    {
        public ToolboxForm()
        {
            InitializeComponent();
            this.Region = Util.GetRoundRegion(this.Width, this.Height, 15);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void appControl1_Load(object sender, EventArgs e)
        {

        }

        private void appControl1_appClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

    }
}
