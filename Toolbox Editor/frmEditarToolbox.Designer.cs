namespace Toolbox_Editor
{
    partial class frmEditarToolbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTlbName = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lbApps = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picAppIcon = new System.Windows.Forms.PictureBox();
            this.btnAppAplicar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAñadirApp = new System.Windows.Forms.Button();
            this.btnQuitarApp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "@gui.name";
            this.label1.Text = "Nombre";
            // 
            // txtTlbName
            // 
            this.txtTlbName.Location = new System.Drawing.Point(297, 8);
            this.txtTlbName.Name = "txtTlbName";
            this.txtTlbName.ReadOnly = true;
            this.txtTlbName.Size = new System.Drawing.Size(118, 20);
            this.txtTlbName.TabIndex = 1;
            this.txtTlbName.Click += new System.EventHandler(this.txtTlbName_Click);
            this.txtTlbName.TextChanged += new System.EventHandler(this.txtTlbName_TextChanged);
            // 
            // picIcon
            // 
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Location = new System.Drawing.Point(449, 6);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(32, 32);
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.picIcon_Click);
            // 
            // lbApps
            // 
            this.lbApps.FormattingEnabled = true;
            this.lbApps.Location = new System.Drawing.Point(15, 32);
            this.lbApps.Name = "lbApps";
            this.lbApps.Size = new System.Drawing.Size(108, 108);
            this.lbApps.TabIndex = 4;
            this.lbApps.SelectedIndexChanged += new System.EventHandler(this.lbApps_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picAppIcon);
            this.panel1.Controls.Add(this.btnAppAplicar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.txtAppID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAppName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(129, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 111);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Tag = "@gui.appIcon";
            this.label2.Text = "Icono";
            // 
            // picAppIcon
            // 
            this.picAppIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAppIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAppIcon.Location = new System.Drawing.Point(8, 31);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Size = new System.Drawing.Size(32, 32);
            this.picAppIcon.TabIndex = 7;
            this.picAppIcon.TabStop = false;
            // 
            // btnAppAplicar
            // 
            this.btnAppAplicar.Location = new System.Drawing.Point(236, 79);
            this.btnAppAplicar.Name = "btnAppAplicar";
            this.btnAppAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAppAplicar.TabIndex = 6;
            this.btnAppAplicar.Tag = "@gui.apply";
            this.btnAppAplicar.Text = "Aplicar";
            this.btnAppAplicar.UseVisualStyleBackColor = true;
            this.btnAppAplicar.Click += new System.EventHandler(this.btnAppAplicar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Tag = "@gui.filepath";
            this.label5.Text = "Path del archivo";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(8, 82);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(222, 20);
            this.txtPath.TabIndex = 4;
            // 
            // txtAppID
            // 
            this.txtAppID.Enabled = false;
            this.txtAppID.Location = new System.Drawing.Point(168, 32);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(143, 20);
            this.txtAppID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 2;
            this.label4.Tag = "@gui.id";
            this.label4.Text = "ID";
            // 
            // txtAppName
            // 
            this.txtAppName.Enabled = false;
            this.txtAppName.Location = new System.Drawing.Point(49, 6);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(262, 20);
            this.txtAppName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Tag = "@gui.name";
            this.label3.Text = "Nombre";
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColor.Location = new System.Drawing.Point(449, 44);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(32, 32);
            this.picColor.TabIndex = 6;
            this.picColor.TabStop = false;
            this.picColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAñadirApp
            // 
            this.btnAñadirApp.Location = new System.Drawing.Point(15, 9);
            this.btnAñadirApp.Name = "btnAñadirApp";
            this.btnAñadirApp.Size = new System.Drawing.Size(49, 20);
            this.btnAñadirApp.TabIndex = 8;
            this.btnAñadirApp.Tag = "@gui.add";
            this.btnAñadirApp.Text = "Añadir";
            this.btnAñadirApp.UseVisualStyleBackColor = true;
            this.btnAñadirApp.Click += new System.EventHandler(this.btnAñadirApp_Click);
            // 
            // btnQuitarApp
            // 
            this.btnQuitarApp.Location = new System.Drawing.Point(70, 9);
            this.btnQuitarApp.Name = "btnQuitarApp";
            this.btnQuitarApp.Size = new System.Drawing.Size(49, 20);
            this.btnQuitarApp.TabIndex = 8;
            this.btnQuitarApp.Tag = "@gui.remove";
            this.btnQuitarApp.Text = "Quitar";
            this.btnQuitarApp.UseVisualStyleBackColor = true;
            this.btnQuitarApp.Click += new System.EventHandler(this.btnQuitarApp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 9;
            this.button1.Tag = "@gui.createshortcut";
            this.button1.Text = "Crear acceso directo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditarToolbox
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitarApp);
            this.Controls.Add(this.btnAñadirApp);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbApps);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.txtTlbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEditarToolbox";
            this.Text = "Toolbox Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditarToolbox_FormClosed);
            this.Load += new System.EventHandler(this.frmEditarToolbox_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmEditarToolbox_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmEditarToolbox_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmEditarToolbox_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTlbName;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.ListBox lbApps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAppAplicar;
        private System.Windows.Forms.Button btnAñadirApp;
        private System.Windows.Forms.Button btnQuitarApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAppIcon;
    }
}

