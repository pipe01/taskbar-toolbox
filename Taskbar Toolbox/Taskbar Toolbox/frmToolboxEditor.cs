﻿using System;
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
    public partial class frmToolboxEditor : Form
    {
        public frmToolboxEditor()
        {
            InitializeComponent();
        }

        private ToolboxList toolboxList = new ToolboxList();

        private Toolbox selectedTb = null;
        private App selectedApp = null;

        private void frmToolboxEditor_Load(object sender, EventArgs e)
        {
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
            picIcono.BackgroundImage = selectedTb.icon;
            txtName.Text = selectedTb.name;
            picColor.BackColor = selectedTb.bgColor;
        }
        private void refreshApps()
        {
            txtAppId.Text = selectedApp.id;
            txtAppName.Text = selectedApp.name;
            txtAppPath.Text = selectedApp.path;
        }
        private void refreshAppList()
        {
            if (selectedTb != null)
            {
                lbApps.Items.Clear();
                foreach (App item in selectedTb.appList.Values)
                {
                    lbApps.Items.Add(item.id);
                }
            }
        }
        private void cleanForm()
        {
            lbApps.Items.Clear();
            picIcono.BackgroundImage = null;
            txtName.Text = null;
            picColor.BackColor = Color.White;
            txtAppId.Text = null;
            txtAppName.Text = null;
            txtAppPath.Text = null;
        }
        private void saveChanges()
        {
            try
            {
                if (selectedApp != null)
                {
                    selectedApp.name = txtAppName.Text;
                    selectedApp.id = txtAppId.Text;
                    selectedApp.path = txtAppPath.Text;
                }

                selectedTb.icon = picIcono.BackgroundImage;
                selectedTb.name = txtName.Text;
                selectedTb.bgColor = picColor.BackColor;

                selectedTb.save();

                refreshForm();
                refreshList();
            } catch {  }
        }

        private void listToolboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedTb = toolboxList.getFromName((string) listToolboxes.SelectedItem);
            refreshForm();
            refreshAppList();
        }

        private void lbApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedApp = selectedTb.appList[(string) lbApps.SelectedItem];
            refreshApps();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void btnAddToolbox_Click(object sender, EventArgs e)
        {
            //new frmDialogAddToolbox().Show
            new frmDialogAddToolbox().ShowDialog();
        }
    }
}
