﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbox_Editor
{
    public partial class frmEditarToolbox : Form
    {
        public frmEditarToolbox()
        {
            InitializeComponent();
        }

        private Translator loc;

        private void picColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = picColor.BackColor;
            colorDialog1.ShowDialog();
            picColor.BackColor = colorDialog1.Color;
            Util.tlb.bgColor = picColor.BackColor;
            Util.tlb.save();
            refreshToolbox();
        }
        private void frmEditarToolbox_Load(object sender, EventArgs e)
        {
            loc = new Translator();
            loc.translateForm(this);
            refreshToolbox();
            txtTlbName.Text = Util.tlb.name;
        }

        private App selectedApp;

        private void lbApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedApp = Util.tlb.appList[(string) lbApps.SelectedItem];
            refreshAppInfo();
        }

        private void refreshAppInfo()
        {
            if (selectedApp != null)
            {
                txtAppID.Text = selectedApp.id;
                txtAppName.Text = selectedApp.name;
                txtPath.Text = selectedApp.path;
                txtAppID.Enabled = true;
                txtAppName.Enabled = true;
                txtPath.Enabled = true;
            } else {
                txtAppID.Text = null;
                txtAppName.Text = null;
                txtPath.Text = null;
                txtAppID.Enabled = false;
                txtAppName.Enabled = false;
                txtPath.Enabled = false;
            }

        }

        private void refreshAppList()
        {
            lbApps.Items.Clear();
            foreach (App item in Util.tlb.appList.Values)
            {
                lbApps.Items.Add(item.id);
            }
        }

        private void refreshToolbox()
        {
            Util.tlb = Toolbox.xml2toolbox(Util.getToolboxesPath() + Util.tlb.name + "/toolbox.xml");
            selectedApp = null;
            refreshAppList();
            refreshAppInfo();
            refreshToolboxInfo();
        }

        private void refreshToolboxInfo()
        {
            picIcon.BackgroundImage = Image.FromFile(Util.getToolboxesPath() + Util.tlb.name + "/icon.png");
            picColor.BackColor = Util.tlb.bgColor;
            txtTlbName.Text = Util.tlb.name;
        }

        private void addApp()
        {
            App app = new App();
            app.id = "app" + (lbApps.Items.Count + 1);
            app.name = "App";
            Util.tlb.appList.Add(app.id, app);
            Util.tlb.save();
            refreshToolbox();
        }

        private void delApp()
        {
            Util.tlb.appList.Remove(selectedApp.id);
            Util.tlb.save();
            refreshToolbox();
        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picIcon.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            Util.tlb.icon = picIcon.BackgroundImage;
            Util.tlb.save();
        }

        private void txtTlbName_TextChanged(object sender, EventArgs e)
        {
            Util.tlb.setName(txtTlbName.Text);
            Util.tlb.save();
        }

        private void btnAppAplicar_Click(object sender, EventArgs e)
        {
            if (selectedApp == null) { return; }
            selectedApp.id = txtAppID.Text;
            selectedApp.name = txtAppName.Text;
            selectedApp.path = txtPath.Text;
            Util.tlb.save();
            int sel = lbApps.SelectedIndex;
            refreshToolbox();
            lbApps.SelectedIndex = sel;
        }

        private void btnAñadirApp_Click(object sender, EventArgs e)
        {
            addApp();
            lbApps.SelectedIndex = lbApps.Items.Count - 1;
        }

        private void btnQuitarApp_Click(object sender, EventArgs e)
        {
            if (selectedApp != null)
            {
                int sel = lbApps.SelectedIndex;
                delApp();
                lbApps.SelectedIndex = sel == lbApps.Items.Count ? sel - 1 : sel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.png2ico(Util.getToolboxesPath() + Util.tlb.name + "/icon.png",
                         Util.getToolboxesPath() + Util.tlb.name + "/icon.ico");
            Util.createShortcut();
        }

        private void txtTlbName_Click(object sender, EventArgs e)
        {
            if (selectedApp != null)
            {
                selectedApp.id = txtAppID.Text;
                selectedApp.name = txtAppName.Text;
                selectedApp.path = txtPath.Text;
            }
            Util.tlb.save();
            Application.Restart();
        }
    }
}