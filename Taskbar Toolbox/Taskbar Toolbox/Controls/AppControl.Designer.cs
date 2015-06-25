namespace Taskbar_Toolbox
{
    partial class AppControl
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
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcono
            // 
            this.picIcono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcono.Location = new System.Drawing.Point(22, 3);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(32, 32);
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            this.picIcono.Click += new System.EventHandler(this.AppControl_Click);
            this.picIcono.MouseEnter += new System.EventHandler(this.AppControl_Enter);
            this.picIcono.MouseLeave += new System.EventHandler(this.AppControl_MouseLeave);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.Location = new System.Drawing.Point(0, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.AppControl_Click);
            this.lblNombre.MouseEnter += new System.EventHandler(this.AppControl_Enter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.AppControl_MouseLeave);
            // 
            // AppControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picIcono);
            this.Name = "AppControl";
            this.Size = new System.Drawing.Size(76, 67);
            this.Load += new System.EventHandler(this.AppControl_Load);
            this.Click += new System.EventHandler(this.AppControl_Click);
            this.MouseEnter += new System.EventHandler(this.AppControl_Enter);
            this.MouseLeave += new System.EventHandler(this.AppControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.Label lblNombre;
    }
}
