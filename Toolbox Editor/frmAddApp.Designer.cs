namespace Toolbox_Editor
{
    partial class frmAddApp
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShortCut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openShortcut = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.openExe = new System.Windows.Forms.OpenFileDialog();
            this.btnIcono = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importar:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(301, 84);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(37, 23);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 19;
            this.label5.Tag = "@gui.filepath";
            this.label5.Text = "Path del archivo";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(9, 86);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(286, 20);
            this.txtPath.TabIndex = 18;
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(50, 46);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(249, 20);
            this.txtAppID.TabIndex = 17;
            this.txtAppID.TextChanged += new System.EventHandler(this.txtAppID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 16;
            this.label4.Tag = "@gui.id";
            this.label4.Text = "ID";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(50, 20);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(249, 20);
            this.txtAppName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Tag = "@gui.name";
            this.label3.Text = "Nombre";
            // 
            // btnShortCut
            // 
            this.btnShortCut.Location = new System.Drawing.Point(66, 4);
            this.btnShortCut.Name = "btnShortCut";
            this.btnShortCut.Size = new System.Drawing.Size(75, 35);
            this.btnShortCut.TabIndex = 21;
            this.btnShortCut.Text = "Acceso directo";
            this.btnShortCut.UseVisualStyleBackColor = true;
            this.btnShortCut.Click += new System.EventHandler(this.btnShortCut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIcono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAppName);
            this.groupBox1.Controls.Add(this.picIcono);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAppID);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 117);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // openShortcut
            // 
            this.openShortcut.Filter = "Accesos directos (*.lnk)|*.lnk|Accesos directos a Internet (*.url)|*.url";
            this.openShortcut.Title = "Importar acceso directo";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(281, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(200, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picIcono
            // 
            this.picIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcono.Enabled = false;
            this.picIcono.Location = new System.Drawing.Point(305, 19);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(32, 32);
            this.picIcono.TabIndex = 25;
            this.picIcono.TabStop = false;
            this.picIcono.BackgroundImageChanged += new System.EventHandler(this.picIcono_BackgroundImageChanged);
            // 
            // openImage
            // 
            this.openImage.Filter = "Archivos PNG (*.png)|*png|Todos los archivos (*.*)|*.*";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Juego de Steam";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 13);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Cargando informacion...";
            this.lblStatus.Visible = false;
            // 
            // openExe
            // 
            this.openExe.Filter = "Archivos ejecutables (*.exe)|*.exe|Todos los archivos (*.*)|*.*";
            // 
            // btnIcono
            // 
            this.btnIcono.Location = new System.Drawing.Point(304, 53);
            this.btnIcono.Name = "btnIcono";
            this.btnIcono.Size = new System.Drawing.Size(33, 23);
            this.btnIcono.TabIndex = 26;
            this.btnIcono.Text = "^^";
            this.btnIcono.UseVisualStyleBackColor = true;
            this.btnIcono.Click += new System.EventHandler(this.btnIcono_Click);
            // 
            // frmAddApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 194);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShortCut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShortCut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openShortcut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog openExe;
        private System.Windows.Forms.Button btnIcono;
    }
}