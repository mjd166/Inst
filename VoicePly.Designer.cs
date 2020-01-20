namespace Instant
{
    partial class VoicePly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoicePly));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(1418, 608);
            this.axVLCPlugin21.TabIndex = 0;
            this.axVLCPlugin21.ClickEvent += new System.EventHandler(this.axVLCPlugin21_ClickEvent);
            this.axVLCPlugin21.MouseDownEvent += new AxAXVLC.DVLCEvents_MouseDownEventHandler(this.axVLCPlugin21_MouseDownEvent);
            // 
            // VoicePly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 609);
            this.Controls.Add(this.axVLCPlugin21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoicePly";
            this.Text = "VoicePly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoicePly_FormClosing);
            this.Load += new System.EventHandler(this.VoicePly_Load);
            this.Shown += new System.EventHandler(this.VoicePly_Shown);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.VoicePly_GiveFeedback);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VoicePly_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
    }
}