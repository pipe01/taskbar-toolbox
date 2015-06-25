namespace Taskbar_Toolbox
{
    partial class AppContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpApps = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpApps
            // 
            this.flpApps.BackColor = System.Drawing.Color.Transparent;
            this.flpApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpApps.Location = new System.Drawing.Point(0, 0);
            this.flpApps.Name = "flpApps";
            this.flpApps.Size = new System.Drawing.Size(261, 241);
            this.flpApps.TabIndex = 0;
            // 
            // AppContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpApps);
            this.Name = "AppContainer";
            this.Size = new System.Drawing.Size(261, 241);
            this.Load += new System.EventHandler(this.AppContainer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpApps;
    }
}
