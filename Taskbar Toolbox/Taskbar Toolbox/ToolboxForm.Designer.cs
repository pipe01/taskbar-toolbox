using Toolbox_API;

namespace Taskbar_Toolbox
{
    partial class ToolboxForm
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
            this.components = new System.ComponentModel.Container();
            Toolbox_API.Toolbox toolbox1 = new Toolbox_API.Toolbox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEditar = new System.Windows.Forms.Label();
            this.animator = new System.Windows.Forms.Timer(this.components);
            this.appContainer = new Taskbar_Toolbox.AppContainer();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(32, 32);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            this.picIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIcon_MouseDown);
            this.picIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picIcon_MouseMove);
            this.picIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIcon_MouseUp);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblEditar
            // 
            this.lblEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.Location = new System.Drawing.Point(231, 9);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(47, 35);
            this.lblEditar.TabIndex = 3;
            this.lblEditar.Text = "Editar";
            this.lblEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblEditar_MouseUp);
            // 
            // animator
            // 
            this.animator.Interval = 1000;
            // 
            // appContainer
            // 
            this.appContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appContainer.Location = new System.Drawing.Point(12, 50);
            this.appContainer.Name = "appContainer";
            this.appContainer.Size = new System.Drawing.Size(266, 200);
            this.appContainer.TabIndex = 2;
            this.appContainer.Toolbox = toolbox1;
            // 
            // ToolboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(290, 262);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.appContainer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToolboxForm";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Deactivate += new System.EventHandler(this.ToolboxForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolboxForm_FormClosing);
            this.Load += new System.EventHandler(this.ToolboxForm_Load);
            this.Shown += new System.EventHandler(this.ToolboxForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblName;
        private AppContainer appContainer;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Timer animator;
    }
}

