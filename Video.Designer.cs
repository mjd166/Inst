namespace Instant
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.axVLCPlugin22 = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin22
            // 
            this.axVLCPlugin22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin22.Enabled = true;
            this.axVLCPlugin22.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin22.Name = "axVLCPlugin22";
            this.axVLCPlugin22.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin22.OcxState")));
            this.axVLCPlugin22.Size = new System.Drawing.Size(1399, 750);
            this.axVLCPlugin22.TabIndex = 2;
            this.axVLCPlugin22.ClickEvent += new System.EventHandler(this.axVLCPlugin22_ClickEvent);
            this.axVLCPlugin22.MouseDownEvent += new AxAXVLC.DVLCEvents_MouseDownEventHandler(this.axVLCPlugin22_MouseDownEvent);
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 750);
            this.Controls.Add(this.axVLCPlugin22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Video";
            this.Text = "Video";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Video_Load);
            this.Shown += new System.EventHandler(this.Video_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin22;
    }
}