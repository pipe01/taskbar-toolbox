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
    public partial class txtName : Form
    {
        public txtName()
        {
            InitializeComponent();
        }

        private ToolboxList toolboxList = new ToolboxList();

        private Toolbox selectedTb = null;
        private App selectedApp = null;

        private void frmToolboxEditor_Load(object sender, EventArgs e)
        {
            //Toolbox test = new Toolbox();
            //test.name = "Toolbox1";
            //test.bgColor = Color.CadetBlue;
            //test.appList.Add("app1", new App("App1", "app1", "C:/carpeta/ejecutable1.exe"));
            //test.appList.Add("app2", new App("App2", "app2", "C:/carpeta/ejecutable2.exe"));
            //test.appList.Add("app3", new App("App3", "app3", "C:/carpeta/ejecutable3.exe"));
            //Toolbox.toolbox2xml(test, "./toolboxes/Toolbox1/toolbox.xml");
            //toolboxList.Add(test);
            toolboxList = ToolboxList.create();
            refreshList();
        }

        private void refreshList()
        {
            listToolboxes.Items.Clear();
            foreach(Toolbox item in toolboxList)
            {
                listToolboxes.Items.Add(item.name);
            }
        }
        private void refreshForm()
        {
            lbApps.Items.Clear();
            picIcono.BackgroundImage = selectedTb.icon;
            txtNombre.Text = selectedTb.name;
            picColor.BackColor = selectedTb.bgColor;
            foreach (App item in selectedTb.appList.Values)
            {
                lbApps.Items.Add(item.id);
            }
            txtAppId.Text = selectedApp.id;
            txtAppName.Text = selectedApp.name;
            txtAppPath.Text = selectedApp.path;
            
        }
        private void cleanForm()
        {
            lbApps.Items.Clear();
            picIcono.BackgroundImage = null;
            txtNombre.Text = null;
            picColor.BackColor = Color.White;
            txtAppId.Text = null;
            txtAppName.Text = null;
            txtAppPath.Text = null;
        }
        private void saveChanges()
        {
            selectedApp.name = txtAppName.Text;
            selectedApp.id = txtAppId.Text;
            selectedApp.path = txtAppPath.Text;
            selectedTb.save();
            refreshForm();
            refreshList();
        }

        private void listToolboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedTb = toolboxList.getFromName((string) listToolboxes.SelectedItem);
            refreshForm();
        }

        private void lbApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedApp = selectedTb.appList[(string) lbApps.SelectedItem];
            refreshForm();
        }

        private void txtAppId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
