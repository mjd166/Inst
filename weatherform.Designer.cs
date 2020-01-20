namespace Instant
{
    partial class weatherform
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDama = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblstatustitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDama, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblstatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblstatustitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1616, 853);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDama
            // 
            this.lblDama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDama.AutoSize = true;
            this.lblDama.Font = new System.Drawing.Font("B Yekan", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDama.Location = new System.Drawing.Point(3, 426);
            this.lblDama.Name = "lblDama";
            this.lblDama.Size = new System.Drawing.Size(802, 427);
            this.lblDama.TabIndex = 3;
            this.lblDama.Text = "1";
            this.lblDama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDama.Click += new System.EventHandler(this.lblstatustitle_Click);
            this.lblDama.Paint += new System.Windows.Forms.PaintEventHandler(this.lblstatustitle_Paint);
            // 
            // lblstatus
            // 
            this.lblstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("B Yekan", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblstatus.Location = new System.Drawing.Point(3, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(802, 426);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "جوی";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblstatus.Click += new System.EventHandler(this.lblstatustitle_Click);
            this.lblstatus.Paint += new System.Windows.Forms.PaintEventHandler(this.lblstatustitle_Paint);
            // 
            // lblstatustitle
            // 
            this.lblstatustitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstatustitle.AutoSize = true;
            this.lblstatustitle.Font = new System.Drawing.Font("B Yekan", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblstatustitle.Location = new System.Drawing.Point(811, 0);
            this.lblstatustitle.Name = "lblstatustitle";
            this.lblstatustitle.Size = new System.Drawing.Size(802, 426);
            this.lblstatustitle.TabIndex = 1;
            this.lblstatustitle.Text = "وضعیت";
            this.lblstatustitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblstatustitle.Click += new System.EventHandler(this.lblstatustitle_Click);
            this.lblstatustitle.Paint += new System.Windows.Forms.PaintEventHandler(this.lblstatustitle_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(811, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 427);
            this.label1.TabIndex = 2;
            this.label1.Text = "دما";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lblstatustitle_Click);
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.lblstatustitle_Paint);
            // 
            // weatherform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 853);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "weatherform";
            this.Text = "weatherform";
            this.Load += new System.EventHandler(this.weatherform_LoadAsync);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblstatustitle;
    }
}